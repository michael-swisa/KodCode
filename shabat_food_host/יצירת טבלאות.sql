-- יצירת טבלת אורחים המכילה מספר מזהה המתקדם אוטומטית, ושם אורח
CREATE TABLE Person
(
person_code INT PRIMARY KEY IDENTITY,
full_name VARCHAR(30)
);

-- יצירת טבלת קטגוריות אוכל
CREATE TABLE Category
(
category_code INT PRIMARY KEY IDENTITY,
category_name VARCHAR(30)
)

-- יצירת טבלת אוכל
CREATE TABLE Food
(
food_code INT PRIMARY KEY IDENTITY,
food_name VARCHAR(100),
person_code INT FOREIGN KEY REFERENCES Person(person_code),
category_code INT FOREIGN KEY REFERENCES Category(category_code)
)
