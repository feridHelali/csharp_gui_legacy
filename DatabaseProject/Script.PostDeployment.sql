if not exists (select 1 from [dbo].[Cars])

INSERT INTO CARS 
	(Name,Description,Price)
VALUES
	('Mercedes','Mercedes Benz',78200.000);
