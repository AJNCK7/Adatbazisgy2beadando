drop table injections;

create table injections(
    injectionid int not null,
    injectionname char(100) not null,
    
    constraint pk_injectionid primary key(injectionid)
);