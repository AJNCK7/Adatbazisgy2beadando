drop table animalclinic;

create table animalclinic(
    animalclinicid int not null,
    animalclinicname char(200) not null,
    
    constraint pk_animalclinic primary key(animalclinicid)
);