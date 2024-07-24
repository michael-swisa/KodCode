 DECLARE @Code int 
 SELECT @Code = @@IDENTITY INSERT INTO CourseDetails VALUES(@date, @days, @hours, @price)

--INSERT INTO Course VALUES(50, 2, @Code, @fullName)