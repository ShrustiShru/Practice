use[3307]

create table SamsungEmployee(
EmpId int primary key identity(1,1),
EmpName varchar(50) not null,
EmpSalary money not null,
)

select * from RouteStops;

create table Bill(
BillId int primary key identity(11,1),
TotalPrice money not null,
EmpId int foreign key references SamsungEmployee(EmpId),
RouteNumber int foreign key references RouteName(RouteNumber),
)

alter table RouteName(
RouteNumber int primary key identity(100,1),
RouteName varchar(100) not null,
)

create table RouteStops(
StopId int primary key identity(50,1),
PickUp varchar(100) not null,
DropOut varchar(100) not null,
RouteNumber int foreign key references RouteName(RouteNumber),
TicketAmount money not null,
)

insert into SamsungEmployee (EmpName, EmpSalary) values ('Deepu', '$71988.42');
insert into SamsungEmployee (EmpName, EmpSalary) values ('Shrusti', '$99593.54');
insert into SamsungEmployee (EmpName, EmpSalary) values ('Hemanth', '$74974.35');
insert into SamsungEmployee (EmpName, EmpSalary) values ('Lekha', '$88262.36');
insert into SamsungEmployee (EmpName, EmpSalary) values ('Hanumanth', '$54924.32');
insert into SamsungEmployee (EmpName, EmpSalary) values ('Gagan', '$71903.80');
insert into SamsungEmployee (EmpName, EmpSalary) values ('Prajit', '$81965.66');
insert into SamsungEmployee (EmpName, EmpSalary) values ('Ashwin', '$52381.78');
insert into SamsungEmployee (EmpName, EmpSalary) values ('Karthik', '$53117.49');
insert into SamsungEmployee (EmpName, EmpSalary) values ('Anagha', '$63079.26');

insert into RouteName(RouteName) values('Baiyapanahalli - Kengeri');
insert into RouteName(RouteName) values('Nagsandra - Silk Institute');

insert into RouteStops(PickUp,DropOut,RouteNumber,TicketAmount) values('Baiyapanahalli',' Indiranagar',100,30);
insert into RouteStops(PickUp,DropOut,RouteNumber,TicketAmount) values('Majestic',' Kengeri',100,50);
insert into RouteStops(PickUp,DropOut,RouteNumber,TicketAmount) values('Nagsandra',' Jaynagar',101,70);
insert into RouteStops(PickUp,DropOut,RouteNumber,TicketAmount) values('Yeswantpura',' SilkInstitute',101,80);


drop table RouteStops

delete from RouteName where RouteNumber>108;