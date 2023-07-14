USE SportsStore ;
GO

IF EXISTS(	SELECT *
			FROM INFORMATION_SCHEMA.TABLES
			WHERE TABLE_NAME = 'Products' )
BEGIN
	PRINT 'Dropping table dbo.Products'
	DROP TABLE dbo.Products ;
END ;
GO

CREATE TABLE dbo.Products
(
	ProductID		INT				NOT NULL		PRIMARY KEY IDENTITY,
	Name			NVARCHAR(100)	NOT NULL,
	Description		NVARCHAR(500)	NOT NULL,
	Category		NVARCHAR(50)	NOT NULL,
	Price			DECIMAL(16, 2)	NOT NULL
) ;

INSERT INTO dbo.Products ( Name, Description, Category, Price )
VALUES ( 'Kayak',				'A boat for one person',						'Watersports',	275.00 ) ;

INSERT INTO dbo.Products ( Name, Description, Category, Price )
VALUES ( 'Lifejacket',			'Protective and fashionable',					'Watersports',	48.95 ) ;

INSERT INTO dbo.Products ( Name, Description, Category, Price )
VALUES ( 'Soccer Ball',			'FIFA-approved size and weight',				'Soccer',		19.50 ) ;

INSERT INTO dbo.Products ( Name, Description, Category, Price )
VALUES ( 'Corner Flags',		'Give your playing field a professional touch',	'Soccer',		34.95 ) ;

INSERT INTO dbo.Products ( Name, Description, Category, Price )
VALUES ( 'Stadium',				'Flat-packed 35,000-seat stadium',				'Soccer',		79500.00 ) ;

INSERT INTO dbo.Products ( Name, Description, Category, Price )
VALUES ( 'Thinking Cap',		'Improve your brain efficiency by 75%',			'Chess',		16.00 ) ;

INSERT INTO dbo.Products ( Name, Description, Category, Price )
VALUES ( 'Unsteady Chair',		'Secretly give your opponent a disadvantage',	'Chess',		29.95 ) ;

INSERT INTO dbo.Products ( Name, Description, Category, Price )
VALUES ( 'Human Chess Board',	'A fun game for the family',					'Chess',		75.00 ) ;

INSERT INTO dbo.Products ( Name, Description, Category, Price )
VALUES ( 'Bling-Bling King', 'Gold-plated, diamond-studded King',				'Chess',		1200.00 ) ;

SELECT * FROM dbo.Products ;
