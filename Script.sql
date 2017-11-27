create database examen_coding_band;
use examen_coding_band;

create table autor(
id_autor int not null identity(1,1),
nombre varchar(max) not null,
primary key(id_autor)
);

create table libro(
id_libro int not null identity(1, 1),
titulo varchar(max) not null,
fecha_edicion date,
primary key(id_libro)
);

create table autor_libro(
id_autor int not null,
id_libro int not null,
primary key(id_autor, id_libro),
foreign key (id_autor) references autor(id_autor),
foreign key (id_libro) references libro(id_libro)
);