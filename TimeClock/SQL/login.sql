DECLARE @code INT, @answer VARCHAR(250)

-- בדיקה אם העובד קיים ומשיכת קוד העובד
IF EXISTS (SELECT * FROM Employes WHERE Employ_id = @id)
BEGIN
    SELECT @code = (SELECT Code FROM Employes WHERE Employ_id = @id);
END
ELSE
BEGIN
    -- הוספת עובד חדש לטבלה
    INSERT INTO Employes VALUES (@fullName, @ID);
    SELECT @code = @@IDENTITY;
END

-- בדיקת סיסמה
IF EXISTS (SELECT * FROM Passwords WHERE Employe_Code = @code)
BEGIN
    IF EXISTS (SELECT User_password FROM Passwords
               WHERE Employe_Code = @code
               AND User_password = @password
               AND Is_active = 1)
    BEGIN
        IF EXISTS (SELECT User_password FROM Passwords
                   WHERE Employe_Code = @code
                   AND User_password = @password
                   AND Is_active = 1
                   AND Password_expiry_date >= GETDATE())
        BEGIN
            -- בדיקת כניסה ויציאה
            IF EXISTS (SELECT * FROM Time_clock WHERE Employe_Code = @code
                       AND leaving_time IS NULL)
            BEGIN
                -- עדכון זמן יציאה
                UPDATE Time_clock SET leaving_time = GETDATE() WHERE Employe_Code = @code AND leaving_time IS NULL;
                SELECT @answer = 'exit time' + CHAR(13) + CHAR(10) + CONVERT(NVARCHAR, GETDATE(), 121);

            END
            ELSE
            BEGIN
                -- עדכון זמן כניסה
                INSERT INTO Time_clock VALUES (GETDATE(), NULL, @code);
                SELECT @answer = 'Entry time' + CONVERT(NVARCHAR, GETDATE(), 121);
            END
        END
        ELSE
        BEGIN
            SELECT @answer = 'You need to update password';
        END
    END
    ELSE
    BEGIN
        SELECT @answer = 'wrong password';
    END
END
ELSE
BEGIN
    -- יצירת סיסמה חדשה
    INSERT INTO Passwords VALUES (@password, DATEADD(DAY, 180, GETDATE()), @code, 1);
    SELECT @answer = 'You create A worker and password';
END

SELECT @answer;