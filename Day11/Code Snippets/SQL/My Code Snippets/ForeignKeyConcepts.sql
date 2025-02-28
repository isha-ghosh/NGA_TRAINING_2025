create table customers
(
cid int primary key,      
cname varchar(40),
cmobno char(10)


)

insert into customers values(1, 'ABC','34343343' )
insert into customers values(2, 'DFD','8343343' )
insert into customers values(3, 'Xyz','9343343' )

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