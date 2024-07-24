-- מחק את כל הרשומות שתלויות בקטגוריה בטבלת Food
DELETE FROM Food WHERE category_code = (SELECT category_code FROM Category WHERE category_name = @category_name);

-- מחק את הקטגוריה מטבלת Category
DELETE FROM Category WHERE category_name = @category_name;
