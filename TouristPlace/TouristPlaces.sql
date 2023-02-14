use[3307]

create Table TouristPlaces(
PlaceId int primary key identity(1,1),
PlaceName varchar(50) not null,
Pincode int not null,
States varchar(100) not null,
Significance varchar(200) not null Check (Significance In('Historic','Religious','Leisure','HillStation')),
Descriptions varchar(MAX) not null
)

create table ImageFiles(
ImageId int primary key identity(100,1),
PlaceId int foreign key references TouristPlaces(PlaceId)not null,
ImagePath varchar(MAX) not null
)

select * from TouristPlaces

insert into TouristPlaces(PlaceName,Pincode,States,Significance,Descriptions) values('Hampi','583239','Karnataka','Historic','Hampi is an ancient village in the south Indian state of Karnataka. It’s dotted with numerous ruined temple complexes from the Vijayanagara Empire. On the south bank of the River Tungabhadra is the 7th-century Hindu Virupaksha Temple, near the revived Hampi Bazaar. A carved stone chariot stands in front of the huge Vittala Temple site. Southeast of Hampi, Daroji Bear Sanctuary is home to the Indian sloth bear.')

insert into TouristPlaces(PlaceName,Pincode,States,Significance,Descriptions) values('Taj Mahal','282006','Delhi','Historic','The Taj Mahal is an ivory-white marble mausoleum on the south bank of the Yamuna river in the Indian city of Agra. It was commissioned in 1632 by the Mughal emperor, Shah Jahan (reigned from 1628 to 1658), to house the tomb of his favourite wife, Mumtaz Mahal.')