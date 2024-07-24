-- הכנסת קטגוריות - Fishs,Chicken, Meat, Drinks
DECLARE @answer_category VARCHAR(100), @new_category VARCHAR(50) = 'Drinks'

IF NOT EXISTS(SELECT category_name FROM Category WHERE category_name = @new_category)
BEGIN
	insert into Category values(@new_category)
	SELECT @answer_category = 'The category has been successfully received'
END
ELSE
BEGIN
	SELECT @answer_category = 'The category already exists'
END
SELECT @answer_category


-- יצירת משתנה שמביא את כל השמות של הקטגוריות שקיימות 
DECLARE @get_category VARCHAR(100)
SELECT category_name FROM Category WHERE category_name LIKE '%' +  @get_category + '%'




-- הוספת אורח - michael swisa, Kobi Tal, David levi
DECLARE @person VARCHAR(30) = 'David levi'
IF NOT EXISTS(SELECT full_name FROM Person WHERE full_name = @person)
BEGIN
	insert into Person values(@person)	
END


-- הוספת מנות
DECLARE @full_name VARCHAR(30) = 'David levi', @category VARCHAR(100) = 'Drinks', @food VARCHAR(100) = 'Water'
SELECT @full_name = person_code FROM Person WHERE full_name = @full_name
SELECT @category = category_code FROM Category WHERE category_name = @category
IF (@full_name IS NOT NULL AND @category IS NOT NULL)
BEGIN
	INSERT INTO Food VALUES(@food, @full_name, @category)
END


-- יצירת שאילתא שתחזיר את כל האוכל שהוזמן מאותו קטגוריה ואת הכמות של אותה מנה
DECLARE @food_category VARCHAR(100) = 'Fishs'
SELECT Food.food_name, COUNT(*) as quantity
FROM Food 
JOIN Category ON Category.category_code = Food.category_code
WHERE Category.category_name = @food_category
GROUP BY Food.food_name


-- שאילתא שמחזירה למשתמש מה הוא בחר לפי קטגוריה
DECLARE @fullname VARCHAR(30) = 'michael swisa' , @food_category VARCHAR(100) = 'Fishs'
SELECT Food.food_name, COUNT(*) as quantity, Category.category_name FROM Food 
JOIN Person ON Food.person_code = Person.person_code
JOIN Category ON Category.category_code = Food.category_code
WHERE Person.full_name = @fullname AND Category.category_name = @food_category
GROUP BY Food.food_name, Category.category_name


-- שאילתא שמחזירה למשתמש מה שאר המשתמשים בחרו לפי קטגוריה
DECLARE @fullname VARCHAR(30) = 'michael swisa' , @food_category VARCHAR(100) = 'Drinks'
SELECT Food.food_name, COUNT(*) as quantity, Category.category_name FROM Food 
JOIN Person ON Food.person_code = Person.person_code
JOIN Category ON Category.category_code = Food.category_code
WHERE Person.full_name != @fullname AND Category.category_name = @food_category
GROUP BY Food.food_name, Category.category_name






-- הצגת הטבלאות
SELECT * FROM Person
SELECT * FROM Category
SELECT * FROM Food