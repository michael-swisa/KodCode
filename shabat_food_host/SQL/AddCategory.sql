DECLARE @answer_category VARCHAR(100)

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