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

