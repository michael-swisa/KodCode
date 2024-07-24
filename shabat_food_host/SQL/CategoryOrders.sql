-- יצירת שאילתא שתחזיר את כל האוכל שהוזמן מאותו קטגוריה ואת הכמות של אותה מנה
--declare @food_category varchar(20) = 'Drinks'
SELECT Food.food_name, COUNT(*) as quantity
FROM Food 
JOIN Category ON Category.category_code = Food.category_code
WHERE Category.category_name = @food_category
GROUP BY Food.food_name