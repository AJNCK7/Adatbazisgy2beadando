drop table owners;

create table owners
(
    id int not null,
    familyName char(60) not null,
    surName char(60) not null,
    birthDate date not null,
    zipCode string(4) not null,
    city char(200) not null,
    address char(200) not null,
    phoneNumber char(12) not null,
    email char(200) not null,
    
    constraint pk_owners primary key(id),
    constraint fk_animalclinic foreign key(id) references animalclinic(ownerid)
);

 