drop table owners;
create table owners
(
    id char(10) not null,
    familyname char(50) not null,
    surname char(50) not null,
    birthdate date not null,
    zipcode char(4) not null,
    city char(150) not null,
    address char(150) not null,
    phonenumber char(13) not null,
    email char(150) not null,
    
    constraint pk_owners primary key(id)
);