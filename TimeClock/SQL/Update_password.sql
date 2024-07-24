DECLARE @anserId VARCHAR(250)
DECLARE @answer2 VARCHAR(250)
IF EXISTS (SELECT * FROM Employes WHERE Employ_id = @id )
BEGIN
	SELECT @anserId =  (SELECT Employes.Code FROM Employes WHERE Employes.Employ_id = @id)
	IF EXISTS (SELECT * FROM Passwords WHERE User_password = @password 
	AND Employe_Code = @anserId 
	AND Is_active = 1)
	BEGIN
	    IF EXISTS (SELECT *FROM Passwords WHERE Employe_Code = @anserId 
		AND User_password = @newPassword)
		BEGIN
			SELECT @answer2 = 'It is not possible to choose an old password'
		END
		ELSE
		BEGIN
			UPDATE Passwords SET Is_active = 0 WHERE User_password = @password 
			AND Employe_Code = @anserId
			INSERT INTO Passwords VALUES (@newPassword, DATEADD(DAY, 180, GETDATE()), @anserId, 1);
			SELECT @answer2 = 'The password has been changed successfully'
		END
    END
    ELSE
    BEGIN
        SELECT @answer2 = 'Incorrect password'    
    END
END
ELSE
BEGIN
    SELECT @answer2 = 'Username does not exist'
END
SELECT @answer2