-- create database HotelManagement
-- use HotelManagement



/*
create table refRoomType(
	id int identity(1, 1) primary key,
	name varchar(250) not null unique
)

create table refRoomBed(
	id int identity(1, 1) primary key,
	name varchar(250) not null unique
)

create table wtRooms(
	room_id int identity(1, 1) primary key,
	room_no varchar(250) not null unique,
	room_type int not null,
	bed int not null,
	price int not null,
	booked bit default 0,
	foreign key (room_type) references refRoomType(id),
	foreign key (bed) references refRoomBed(id)
)
*/



/*
insert into refRoomBed (name) values ('Single'), ('Double'), ('Triple');

insert into refRoomType (name) values ('Ac'), ('Non-Ac');

insert into wtRooms (room_no, room_type, bed, price, booked) values
('101', 1, 1, 1500, 0),
('102', 1, 2, 2000, 1),
('103', 1, 3, 2500, 0),
('104', 2, 1, 1000, 0),
('105', 2, 2, 1500, 1),
('106', 2, 3, 2000, 0),
('107', 1, 2, 2100, 0),
('108', 2, 1, 1100, 1),
('109', 1, 1, 1600, 0),
('110', 2, 3, 2300, 0);
*/



/*
select * from refRoomBed order by id
select * from refRoomType  order by id
select * from wtRooms  order by room_id
*/



/*
alter proc ui_GetRooms
as begin
	select 
		r.room_id as id, r.room_no as no, rt.name as type, rb.name as bed, r.price, 
		case 
			when booked = 1 then 'YES'
			when booked = 0 then 'NO'
		end as is_booked
	from wtRooms as r
	left join refRoomBed as rb on r.bed = rb.id
	left join refRoomType as rt on r.room_type = rt.id
	order by room_id	
end

-- exec ui_GetRooms
*/



/*
create proc InsertRoom
	@room_no varchar(250), @room_type int, @bed int, @price int
as begin
	insert into wtRooms(room_no, room_type, bed, price)
	values(@room_no, @room_type, @bed, @price)
end
*/



/*
create proc ui_GetBedTypes
as begin
	select * from refRoomBed
end

-- exec ui_GetBedTypes
*/



/*
create proc ui_GetRoomTypes
as begin
	select * from refRoomType
end

-- exec ui_GetRoomTypes
*/


/*
create table refCountry (
	id int identity(1,1) primary key,
	name varchar(50)
);

create table refCity (
	id int identity(1,1) primary key,
	country int not null,
	name varchar(50),
	foreign key (country) references refCountry(id)
);

create table refStreet (
	id int identity(1,1) primary key,
	city int not null,
	name varchar(100),
	foreign key (city) references refCity(id)
);

create table refHouse (
	id int identity(1,1) primary key,
	street int not null,
	house_number varchar(20),
	foreign key (street) references refStreet(id)
);

create table refLocation (
	id int identity(1,1) primary key,
	house int not null,
	name varchar(100),
	foreign key (house) references refHouse(id)
);
*/


/*
create proc ui_GetFullAddressByLocationId
	@location_id int
as
begin
	select
		loc.id as location_id,
		country.name as country,
		city.name as city,
		street.name as street,
		house.house_number,
		loc.name as location_description,
		(country.name + ', ' + city.name + ', ' + street.name + ' ' + house.house_number + isnull(', ' + loc.name, '')) as full_address
	from refLocation loc
	join refHouse house on loc.house = house.id
	join refStreet street on house.street = street.id
	join refCity city on street.city = city.id
	join refCountry country on city.country = country.id
	where loc.id = @location_id
end;
*/

/*
create procedure ui_GetCountries
as
begin
	select * from refCountry
end;
go

create procedure ui_GetCitiesByCountryId
	@country_id int
as
begin
	select * from refCity where country = @country_id
end;
go

create procedure ui_GetStreetsByCityId
	@city_id int
as
begin
	select * from refStreet where city = @city_id
end;
go

create procedure ui_GetHousesByStreetId
	@street_id int
as
begin
	select * from refHouse where street = @street_id
end;
go

create procedure ui_GetLocationsByHouseId
as
begin
	select * from refLocation
end;
go
*/


/*
-- countries
insert into refCountry (name) values ('United States');
insert into refCountry (name) values ('Germany');
insert into refCountry (name) values ('Japan');

-- cities
insert into refCity (country, name) values (1, 'New York');
insert into refCity (country, name) values (1, 'Los Angeles');
insert into refCity (country, name) values (1, 'Chicago');

insert into refCity (country, name) values (2, 'Berlin');
insert into refCity (country, name) values (2, 'Munich');
insert into refCity (country, name) values (2, 'Hamburg');

insert into refCity (country, name) values (3, 'Tokyo');
insert into refCity (country, name) values (3, 'Osaka');
insert into refCity (country, name) values (3, 'Kyoto');

-- streets (3 per city)
insert into refStreet (city, name) values (1, '5th Avenue');
insert into refStreet (city, name) values (1, 'Broadway');
insert into refStreet (city, name) values (1, 'Madison Avenue');

insert into refStreet (city, name) values (2, 'Sunset Boulevard');
insert into refStreet (city, name) values (2, 'Hollywood Boulevard');
insert into refStreet (city, name) values (2, 'Rodeo Drive');

insert into refStreet (city, name) values (3, 'State Street');
insert into refStreet (city, name) values (3, 'Michigan Avenue');
insert into refStreet (city, name) values (3, 'Wacker Drive');

insert into refStreet (city, name) values (4, 'Unter den Linden');
insert into refStreet (city, name) values (4, 'Friedrichstrasse');
insert into refStreet (city, name) values (4, 'Kurfürstendamm');

insert into refStreet (city, name) values (5, 'Leopoldstrasse');
insert into refStreet (city, name) values (5, 'Ludwigstrasse');
insert into refStreet (city, name) values (5, 'Sendlinger Strasse');

insert into refStreet (city, name) values (6, 'Reeperbahn');
insert into refStreet (city, name) values (6, 'Mönckebergstrasse');
insert into refStreet (city, name) values (6, 'Schulterblatt');

insert into refStreet (city, name) values (7, 'Shibuya Crossing');
insert into refStreet (city, name) values (7, 'Takeshita Street');
insert into refStreet (city, name) values (7, 'Omotesando');

insert into refStreet (city, name) values (8, 'Dotonbori');
insert into refStreet (city, name) values (8, 'Midosuji');
insert into refStreet (city, name) values (8, 'Tenjinbashi');

insert into refStreet (city, name) values (9, 'Gion Street');
insert into refStreet (city, name) values (9, 'Shijo Dori');
insert into refStreet (city, name) values (9, 'Philosopher');

-- houses (3 per street)
declare @street_id int = 1;
while @street_id <= 27
begin
	insert into refHouse (street, house_number) values (@street_id, '1A');
	insert into refHouse (street, house_number) values (@street_id, '2B');
	insert into refHouse (street, house_number) values (@street_id, '3C');
	set @street_id += 1;
end;

-- locations (1 per house)
declare @house_id int = 1;
while @house_id <= 81
begin
	insert into refLocation (house, name) values (@house_id, concat('Unit ', cast(@house_id as varchar(10))));
	set @house_id += 1;
end;
*/

/*
select * from refLocation
select * from refHouse
select * from refStreet
select * from refCity
select * from refCountry
*/