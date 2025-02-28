drop table customerssssss
create table customerssssss
(
	id int,
	name varchar(100) constraint email_unique unique,
	cid int constraint cid_unique unique (id)
	)
insert into customerssssss values (7, 'rohit', 567)
insert into customerssssss values (7, 'ishahbhbahsxahkxk', 567)
select * from customerssssss


create table emp(
id int not null,
city varchar(255) default 'mumbai',
age int)


insert into emp (id,city) values (1,'ishah')
select * from emp






















/*create database demo 

 

use demo 

 

-- one character or max to 128 characters  ,, a table can contain max 1024  

create table student 

( 

studid int, 

sname varchar(30), 

salary decimal(6 , 2) 

 

) 

 

Alter table student alter column salary decimal(5,2) 

 

alter table student add marks decimal(5,2) 

 

alter table student drop column marks ; 

 

sp_rename 'student' ,'studentdata'  

 

sp_rename 'studentdata.salarry' , 'sal' 

 

insert into studentdata values(10,'Niti' , 100.00) 

 

select * from studentdata 

 

truncate table studentdata   --structure of a table exist but data will be deleted 

 

drop table studentdata 

*/
 