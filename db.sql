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

/*
CREATE TABLE refNationality (
    id INT identity(1,1) PRIMARY KEY,
    name NVARCHAR(100)
);
*/

--INSERT INTO refNationality (name) VALUES 
--('Afghan'),
--('Algerian'),
--('Angolan'),
--('Argentine'),
--('Austrian'),
--('Australian'),
--('Bangladeshi'),
--('Belarusian'),
--('Belgian'),
--('Bolivian'),
--('Bosnian'),
--('Herzegovinian'),
--('Brazilian'),
--('British'),
--('Bulgarian'),
--('Cambodian'),
--('Cameroonian'),
--('Canadian'),
--('Central African'),
--('Chadian'),
--('Chinese'),
--('Colombian'),
--('Costa Rican'),
--('Croatian'),
--('Czech'),
--('Congolese'),
--('Danish'),
--('Ecuadorian'),
--('Egyptian'),
--('Salvadoran'),
--('English'),
--('Estonian'),
--('Ethiopian'),
--('Finnish'),
--('French'),
--('German'),
--('Ghanaian'),
--('Greek'),
--('Guatemalan'),
--('Dutch'),
--('Honduran'),
--('Hungarian'),
--('Icelandic'),
--('Indian'),
--('Indonesian'),
--('Iranian'),
--('Iraqi'),
--('Irish'),
--('Israeli'),
--('Italian'),
--('Ivorian'),
--('Jamaican'),
--('Japanese'),
--('Jordanian'),
--('Kazakh'),
--('Kenyan'),
--('Lao'),
--('Latvian'),
--('Libyan'),
--('Lithuanian'),
--('Malagasy'),
--('Malaysian'),
--('Malian'),
--('Mauritanian'),
--('Mexican'),
--('Moroccan'),
--('Namibian'),
--('New Zealand'),
--('Nicaraguan'),
--('Nigerien'),
--('Nigerian'),
--('Norwegian'),
--('Omani'),
--('Pakistani'),
--('Panamanian'),
--('Paraguayan'),
--('Peruvian'),
--('Philippine'),
--('Polish'),
--('Portuguese'),
--('Romanian'),
--('Russian'),
--('Saudi'),
--('Saudi Arabian'),
--('Scottish'),
--('Senegalese'),
--('Serbian'),
--('Singaporean'),
--('Slovak'),
--('Somalian'),
--('South African'),
--('Spanish'),
--('Sudanese'),
--('Swedish'),
--('Swiss'),
--('Syrian'),
--('Thai'),
--('Tunisian'),
--('Turkish'),
--('Turkmen'),
--('Ukranian'),
--('Emirati'),
--('American'),
--('Uruguayan'),
--('Vietnamese'),
--('Welsh'),
--('Zambian'),
--('Zimbabwean');

/*
create proc ui_GetNationlities
as begin
	select * from refNationality
end

-- exec ui_GetNationlities
*/

/*
create TABLE refGender (
    id INT identity(1,1) PRIMARY KEY,
    name NVARCHAR(10),
	short_name NVARCHAR(1)
);
*/

/*
INSERT INTO refGender (name, short_name) VALUES 
('Male', 'M'),
('Female', 'F')

create proc ui_GetGender
as begin
	select id, name from refGender
end

-- exec ui_GetGender
*/

/*
create table wtCustomer(
	id int identity(1,1) primary key,
	name varchar(250) not null,
	phone varchar(12) not null,
	nationality int not null,
	gender int not null,
	dob date,
	idproof varchar(50) not null,
	location int not null,
	checkin datetime not null,
	checkout datetime,
	room_id int not null,
	foreign key (nationality) references refNationality(id),
	foreign key (gender) references refGender(id),
	foreign key (location) references refLocation(id),
	foreign key (room_id) references wtRooms(room_id)
)
*/

/*
CREATE PROCEDURE InsertCustomer
    @name VARCHAR(250),
    @phone VARCHAR(12),
    @nationality INT,
    @gender INT,
    @dob DATE,
    @idproof VARCHAR(50),
    @location INT,
    @checkin DATETIME,
    @checkout DATETIME = NULL,
    @room_id INT
AS
BEGIN
    INSERT INTO wtCustomer (
        name, phone, nationality, gender, dob, idproof,
        location, checkin, checkout, room_id
    )
    VALUES (
        @name, @phone, @nationality, @gender, @dob, @idproof,
        @location, @checkin, @checkout, @room_id
    );
END;
*/


/*
EXEC InsertCustomer 
    @name = 'John Doe',
    @phone = '1234567890',
    @nationality = 1,
    @gender = 1,
    @dob = '15-05-1990',
    @idproof = 'AB123456',
    @location = 2,
    @checkin = '2025-21-04 14:00:00',
    @checkout = NULL,
    @room_id = 5;
	*/


/*
CREATE PROCEDURE ui_GetCustomers
AS
BEGIN
    SELECT 
        c.id,
        c.name,
        c.phone,
        c.dob,
        c.idproof,
        c.checkin,
        c.checkout,
        g.name AS gender_name,
        n.name AS nationality_name,
        r.room_no,
        cn.name AS country,
        ci.name AS city,
        s.name AS street,
        h.house_number AS house
    FROM wtCustomer c
    LEFT JOIN refGender g ON c.gender = g.id
    LEFT JOIN refNationality n ON c.nationality = n.id
    LEFT JOIN wtRooms r ON c.room_id = r.room_id
    LEFT JOIN refLocation l ON c.location = l.id
    LEFT JOIN refHouse h ON l.house = h.id
    LEFT JOIN refStreet s ON h.street = s.id
    LEFT JOIN refCity ci ON s.city = ci.id
    LEFT JOIN refCountry cn ON ci.country = cn.id;
END;
*/

-- exec ui_GetCustomers