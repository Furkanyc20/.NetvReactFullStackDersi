CREATE DATABASE ProductDb;

USE ProductDb;

CREATE TABLE Products (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100),
    Price DECIMAL(18, 2),
    Stock INT
);