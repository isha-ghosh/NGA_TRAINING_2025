create table customers
(
cid int primary key,      
cname varchar(40),
cmobno char(10)


)

insert into customers values(1, 'ABC','34343343' )
insert into customers values(2, 'DFD','8343343' )
insert into customers values(3, 'Xyz','9343343' )
insert into customers values(4, 'DFD','9343343' )
insert into customers values(5, 'ABC','9343343' )
select * from customers
create table products
(
pcode int primary key,
pname varchar(20),
price money

)

insert into products values(10,'pencil',30)
insert into products values(11,'board',10)
insert into products values(12,'computer',5000)

--junction table
create table orders
(

oid int primary key,
qty int,
Cid int foreign key references customers(cid),
Pcode int foreign key references products(pcode)


)

insert into orders values(101, 20 ,1 ,12)
select * from customers 
select * from products
select * from orders

select cid , cname from customers where cname = 'ABC' order by cid;

select * from customers order by cid asc offset 0 rows fetch next 4 rows only

select count(*) total from customers

select top(70)  percent cname from customers order by cid

drop table customers

create table Person
(
pid int primary key identity(101,1),      
pname varchar(40),
pmobno int


)

insert into Person values('ABC',34343343 )
insert into Person values( 'DFD',8343343 )
insert into Person values( 'Xyz',9343343 )
insert into Person values( 'DFD',9343343)
insert into Person values( 'ABC',9343343 )

select * from Person

update top(3) person set pmobno=12345

delete top(2) from person


-- A transaction is a set of SQL statements that should be executed as one unit and transaction can be handled by commit and rolback

-- every transaction has two things a) Beginning b) Ending

-- 1. begin the transaction 
-- 2. Process database commands
-- 3. Check for the errors
--    if error occurs 
--          roll back the transaction
--	   else 
--	        commit the transaction 

create table product
(
productid int primary key,
name varchar(30),
price int,
quantity int
)

insert into product values(101, 'Product1',100,10)
insert into product values(102, 'Product2',200,50)
insert into product values(103, 'Product3',300,70)
insert into product values(104, 'Product4',450,80)

Begin transaction 
 save transaction savepoint1
 insert into product values(105,'Product5',500,30)
 Begin transaction 
 save transaction savepoint2
 update product set price = 390 where productid =103
 Begin transaction 
 save transaction savepoint3
 delete from product where productid =103


 

select * from product





Begin transaction 
 insert into product values(106,'Product6',500,30)
 update product set price = 550 where productid =105
 delete from product where productid =104
 if(@@Error >0) -- if any error occured
 begin
   rollback transaction
end
else 
begin
  commit transaction
end

 select * from product

 begin transaction 
 insert into product values(140,'Product7',600,30)
 insert into product values(140,'Product7',600,30)

 if(@@Error >0) -- if any error occured
 begin
   select * from product
   rollback transaction
end
else 
begin
  commit transaction
end


select * from product

begin transaction T1
     insert into product values(200,'Product2',400,10)
	 insert into product values(300,'Product5',500,10)

	 begin transaction T2
	    insert into product values(203,'Product2',400,10)
	    insert into product values(303,'Product5',500,10)
		print @@Trancount -- it will count the transactions

	 
	 commit transaction T2
	 print @@Trancount

commit transaction T1
print @@Trancount




begin transaction T1

     save transaction savepoint1
     insert into product values(600,'Product2',400,10)
	 insert into product values(650,'Product5',500,10)

	save transaction savepoint2
	    insert into product values(860,'Product2',400,10)
	    insert into product values(870,'Product5',500,10)
		

	 save transaction savepoint3
	    insert into product values(900,'Product2',400,10)
	    insert into product values(950,'Product5',500,10)
	
	select * from product
	rollback transaction savepoint2

























