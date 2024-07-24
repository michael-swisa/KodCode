IF NOT EXISTS(SELECT full_name FROM Person WHERE full_name = @person)
BEGIN
	insert into Person values(@person)	
END