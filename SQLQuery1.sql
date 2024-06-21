CREATE TABLE Persons (
    PersonID int,
    Name varchar(50),
    Address varchar(100),
    City varchar(255)
);

Insert into Persons(PersonId, Name, Address, City)
Values (3,'chicku', 'Pandaypur', 'varanasi');

Select *from Persons;