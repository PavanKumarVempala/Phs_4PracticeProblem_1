create database School_Project

create table student(stu_id int primary key, stu_name varchar(20), stu_class int)
insert into student values(1,'Pavan',6),(2,'kumar',10),(3,'John',7),(4,'Paul',10),(5,'Shaker',9),(6,'Surya',8)
select * from student


create table subjects(sub_id int, sub_name varchar(20))
insert into subjects values(1,'telugu'),(2,'maths'),(3,'science'),(4,'social'),(5,'english'),(6,'hindi')
select * from subjects


create table classes(class int)
insert into classes values(5),(6),(7),(8),(9),(10)
select * from classes