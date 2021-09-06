-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE InsertCustomer
	-- Add the parameters for the stored procedure here
	@Name varchar(20),
	@Email varchar(20),
	@Zipcode int,
	
	@Username varchar(20),
	@Password varchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	Declare @id int;
    -- Insert statements for procedure here
	INSERT INTO CustomerTb([Name], Email, Zipcode) Values(@Name,@Email,@Zipcode)
	Set @id=SCOPE_IDENTITY()
	INSERT INTO LoginTb(CustomerId,Username, [Password]) Values(@id,@Username, @Password)
END
GO
