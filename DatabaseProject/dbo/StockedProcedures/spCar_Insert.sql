CREATE PROCEDURE [dbo].[spCar_Insert]
	@Name Varchar(50),
	@Description Varchar(300),
	@Price Numeric(18,3)
AS
Begin
	INSERT INTO [dbo].[Cars]
	(Name,Description,Price)
	VALUES
	(@Name,@Description,@Price)
end;
