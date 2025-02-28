CREATE DATABASE olympus
use olympus
CREATE TABLE Associates (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100),
    Age INT,
    Department VARCHAR(50),
	Details VARCHAR (20)
)

INSERT INTO Associates(Name,Age,Department,Details)
VALUES 
    ('Achu', 30, 'IT','EMPTY'),
    ('Abi', 28, 'HR','EMPTY'),
    ('vikram', 35, 'Finance','6565')

	select*from Associates

	ALTER table Associates ADD Details Varchar(15)

	select*from Associates

	UPDATE Associates SET Name='vibin',Age='55' WHERE ID=1

	select *from Associates

	UPDATE Associates SET Name='deshik',Age='58' WHERE ID=2

	select *from Associates;

	UPDATE Associates SET Name='dinesh',Age='58' WHERE ID=3

	select *from Associates

	DELETE from Associates WHERE Name='vikram'

	select * from Associates


