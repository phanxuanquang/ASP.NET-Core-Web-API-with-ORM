-- Example for a standard table schema in SQL Server database
CREATE TABLE Person (
	Id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY, -- The value is set automatically by the database
	Name TEXT,
	Age INT,
	Gender BIT, -- TRUE stands for "Male", and FALSE stands for "Female"
	Height FLOAT,
	LastModifiedTime DATETIME DEFAULT GETDATE(), -- The value is set automatically by the database
);