use NFBDataBase;

drop table Employee;

CREATE TABLE Employee(
    ID INT PRIMARY KEY IDENTITY (1, 1),
    Name VARCHAR (50) NOT NULL,
    Gender VARCHAR (10) NOT NULL,
    Extension VARCHAR (30) NOT NULL,
    PhoneNumber VARCHAR(20) NOT NULL,
    Location VARCHAR(20) NOT NULL,
	Role VARCHAR(20) NOT NULL,
	Profile Text NOT NULL

);

select * from Employee;