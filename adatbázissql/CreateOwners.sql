drop table owners;

create table owners
(
    id int not null,
    familyName varchar2(60) not null,
    surName varchar2(60) not null,
    birthDate date not null,
    zipCode varchar2(4) not null,
    city varchar2(200) not null,
    address varchar2(200) not null,
    phoneNumber varchar2(12) not null,
    email varchar2(200) not null,
    
    constraint pk_owners primary key(id)
);

 