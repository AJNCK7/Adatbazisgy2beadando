drop table animals;

create table animals(
    animalownerid int not null,
    animalid int not null,
    animalname char (100) not null,
    animalbirthdate date not null,
    animalgender char (20) not null,
    animalisneutered number(1) not null,
    
    constraint pk_animals primary key(animalid),
    constraint fk_owners foreign key(animalownerid) references owners(id)
);