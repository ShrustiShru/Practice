use[3307]

create table movie(
movieId int primary key identity(1,1),
movieName varchar(max) not null,
movieDate date not null,
movieCollection money not null,
movieLanguage varchar(max) not null,
movieDuration Time(min)not null,
directorId int foreign key references director(directorId)
)

select * from movie;

create table actor(
actorId int primary key identity(1,1),
actorName varchar(max) not null,
actorAge int not null
)

select * from actor;

create table director(
directorId int primary key identity(1,1),
directorName varchar(max) not null
)

select * from director;

create table Link(
linkId int primary key identity(1,1),
actorId int foreign key references actor(actorId),
movieId int foreign key references movie(movieId)
)

select * 
from movie join director on movie.directorId=director.directorId;

select * from Link;

select * from link join movie on link.movieId=movie.movieId;

update Movie set directorId=2 where directorId=1;

-------------------------------Stored Procedure----------------------------

create procedure AddMovie(
@movName varchar(max) ,
@movDate date,
@movMoney money,
@movLanguage varchar(max),
@movDuration Time,
@dirId int
) 
as 
INSERT into Movie(MovieName,MovieDate,MovieCollection,MovieLanguage,MovieDuration,DirectorId) 
VALUES(@movName,@movDate,@movMoney,@movLanguage,@movDuration,@dirId)