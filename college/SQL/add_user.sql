--declare @FullName VARCHAR(100) = 'Kobi Tal', @CourseName VARCHAR(100) = 'בניה';


declare @CourseCode INT, @priceCourse INT;

-- קליטת מחיר הקורס לתוך משתנה
SELECT @priceCourse =  CourseDetails.priceCourse FROM CourseDetails
 JOIN Course ON Course.courseDetailsID = CourseDetails.courseDetailsID WHERE
@CourseName = Course.courseName

-- קליטת מספר הקורס לתוך משתנה
SELECT @CourseCode = (SELECT courseRotationID FROM CourseRotation JOIN Course ON CourseRotation.courseID = Course.courseID WHERE @CourseName = Course.courseName)

-- הכנסת הערכים לתוך Users
INSERT INTO Users VALUES(@FullName, @CourseCode, @priceCourse)

-- החזרת סכום לתשלום
SELECT @priceCourse