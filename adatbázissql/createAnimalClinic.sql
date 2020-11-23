drop table animalclinic;

create table animalclinic(
    ownerid int not null,
    animalid int not null,
    injectionid int not null,
    animalclinicid int not null,
    animalclinicname char(200) not null,
    
    constraint pk_animalclinic primary key(animalclinicid),
    constraint uq_ownerid unique(ownerid)
);