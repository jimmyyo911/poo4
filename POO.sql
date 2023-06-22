create database POO;

use POO;

create table Student
(
	nr_matricol int not null auto_increment,
    nume VARCHAR(255) NOT NULL,
    prenume VARCHAR(255) NOT NULL,
    Init_tata VARCHAR(2) NOT NULL,
    cnp numeric(13,0),
    data_inscriere datetime NOT NULL,
    profil VARCHAR(255) NOT NULL,
    medie_inscriere numeric(4,2),
    grupa VARCHAR(6),
    CONSTRAINT ck_ciclu CHECK (grupa = 'L' OR grupa = 'M'),
	CONSTRAINT ck_frecventa CHECK (grupa = 'F'),
    PRIMARY KEY(nr_matricol)
);

create table Note
(
	nr_matricol int not null auto_increment,
    nume VARCHAR(255) NOT NULL,
    prenume VARCHAR(255) NOT NULL,
    Init_tata VARCHAR(2) NOT NULL,
    profil VARCHAR(255) NOT NULL,
    grupa VARCHAR(6),
    CONSTRAINT ck_ciclu CHECK (grupa = 'L' OR grupa = 'M'),
	CONSTRAINT ck_frecventa CHECK (grupa = 'F'),
    disciplina VARCHAR(255) not null,
    nota NUMERIC(2,0),
    CONSTRAINT ck_nota CHECK (nota <=10 or nota>0),
    credite NUMERIC(1,0),
    constraint ck_credit check (credite>0),
    student_id int not null,
    PRIMARY KEY(nr_matricol),
    FOREIGN KEY(student_id) references Student (nr_matricol)
);

select * from Student;
select * from Note;

