CREATE DATABASE AnimalDB;
GO

USE AnimalDB;
GO

CREATE TABLE ANIMALS (
    ANIMALID INT PRIMARY KEY IDENTITY(1,1), 
    ANIMALTYPE NVARCHAR(50),                 
    SOUND NVARCHAR(50)                       
);

INSERT INTO ANIMALS (ANIMALTYPE, SOUND)
VALUES 
('Cow', 'Moo'),
('Sheep', 'Baa'),
('Goat', 'Bleat');

