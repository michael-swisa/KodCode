-- יצירת טבלת מרצים
CREATE TABLE Lecturers(
lecturerID INT PRIMARY KEY IDENTITY,
fullName VARCHAR(30),
hourlyRate INT
);

-- יצירת טבלת פרטי הקורס
CREATE TABLE CourseDetails(
courseDetailsID INT PRIMARY KEY IDENTITY,
startDate DATE,
daysWeek VARCHAR(100),
courseHours VARCHAR(100),
priceCourse INT
);

-- יצירת טבלת קורסים
CREATE TABLE Course(
CourseID INT PRIMARY KEY IDENTITY,
sumHours INT,
lecturerID INT FOREIGN KEY REFERENCES Lecturers(lecturerID),
courseDetailsID INT FOREIGN KEY REFERENCES CourseDetails(courseDetailsID),
courseName VARCHAR(30)
);

--יצירת טבלת מחזוריות קורס
CREATE TABLE CourseRotation(
	courseRotationID INT PRIMARY KEY IDENTITY,
	courseID INT FOREIGN KEY REFERENCES Course(CourseID),
);

-- יצירת טבלת משתתפים
CREATE TABLE Users(
userID INT PRIMARY KEY IDENTITY,
fullName VARCHAR(30),
courseID INT FOREIGN KEY REFERENCES CourseRotation(courseRotationID),
balancePayment INT
);

-- יצירת טבלה מקשרת בין משתתף למחזוריות קורס
CREATE TABLE UserCourseRotation(
	userID INT FOREIGN KEY REFERENCES Users(userID),
	courseRotationID INT FOREIGN KEY REFERENCES CourseRotation(courseRotationID)
);

-- יצירת טבלת תשלומים
CREATE TABLE Payments(
courseRotation INT FOREIGN KEY REFERENCES CourseRotation(courseRotationID),
userID INT FOREIGN KEY REFERENCES Users(UserID),
payment INT
);

--drop table Payments
--drop table CourseRotation
--drop table UserCourseRotation
--drop table Users
--drop table CourseDetails
--drop table Lecturers
--drop table Course





-- הכנסת מרצים 
INSERT INTO Lecturers VALUES
('משה כהן', 54),('דוד לוי', 47),
('דביר לרר', 150), ('אברהם בראל', 70),
('אלחנן תורגמן', 40), ('יהושוע דבידוב', 49)

--SELECT * FROM Lecturers

 --הכנסת פרטים על הקורס
declare @date Date = getDAte();
INSERT INTO CourseDetails VALUES(@date,'א ב ד ה ', '10:00 - 17:00', 2590),
(@date,'א ב ג ה ', '10:00 - 17:00', 1590),
(@date,'א ב ד ה ', '10:00 - 17:00', 3480),
(@date,'א ב ד ', '10:00 - 17:00', 1090)

--SELECT * FROM CourseDetails

-- הכנסת פרטים על הקורסים
INSERT INTO Course VALUES(50, 2, 1, 'עיצוב')
INSERT INTO Course VALUES(50, 2, 1, 'בניה')
INSERT INTO Course VALUES(50, 2, 1, 'תכנות')


insert into CourseRotation values(1),(2),(3),(4)
select * from CourseRotation










select * from Users


--select * from CourseDetails join Course on CourseDetails.courseDetailsID = Course.CourseID

select * from Users