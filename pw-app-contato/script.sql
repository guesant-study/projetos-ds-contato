create database if not exists app_contato_db;
use app_contato_db;


create table contato (
	id_con int primary key auto_increment,
    
    nome_con varchar(200) not null,
    data_nasc_con date not null,
    sexo_con varchar(30),
    email_con varchar(150) not null,
    telefone_con varchar(20) not null,
    cpf_con varchar(14)
);


insert into contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con, cpf_con) values (1, 'Humberto Mazin', '1996-04-07', 'F', 'hmazin0@redcross.org', '155-637-1517', '37671225008');
insert into contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con, cpf_con) values (2, 'Marge Cantrell', '1996-02-19', 'F', 'mcantrell1@google.cn', '166-957-1724', '83364971309');
insert into contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con, cpf_con) values (3, 'Jacqueline Wildes', '1994-06-21', 'F', 'jwildes2@drupal.org', '895-598-9117', '10348408158');
insert into contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con, cpf_con) values (4, 'Rabi Phebey', '1989-08-14', 'F', 'rphebey3@theglobeandmail.com', '371-603-4633', '37426775544');
insert into contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con, cpf_con) values (5, 'Teddy Sink', '1984-02-24', 'M', 'tsink4@state.gov', '414-913-6821', '70357415385');
insert into contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con, cpf_con) values (6, 'Jeanne Bastie', '1981-01-29', 'M', 'jbastie5@sciencedirect.com', '517-533-1146', '35760126332');
insert into contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con, cpf_con) values (7, 'Percy Daffey', '1990-07-15', 'F', 'pdaffey6@opensource.org', '598-589-2999', '88848649669');
insert into contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con, cpf_con) values (8, 'Currie Carnoghan', '1984-04-20', 'M', 'ccarnoghan7@cbc.ca', '562-815-4087', '37621220926');
insert into contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con, cpf_con) values (9, 'Pattie Benoist', '1981-03-14', 'M', 'pbenoist8@columbia.edu', '610-835-6773', '44766599652');
insert into contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con, cpf_con) values (10, 'Diane Lagden', '1989-07-20', 'M', 'dlagden9@who.int', '199-580-1884', '77463261395');

select * from contato;
