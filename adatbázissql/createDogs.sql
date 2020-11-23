drop table dogs;

create table dogs(
    dogid int not null,
    specie char(100) not null,
    ischipped number(1) not null,
    chipid int not null,
    addedinjections char(100),
    
    constraint pk_dogs primary key(dogid),
    constraint fk_animal foreign key(dogid) references animals(animalid)
);