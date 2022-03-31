use trail
go

create table RegistrationForm1
(
RegistrationFormNo int identity(1,1)constraint FM primary key(RegistrationFormNo),
REgiDate date default getdate(),
FirstName varchar(20),
LastNAme varchar(20),
Gender varchar(10) constraint Gender check (Gender in('Male','Female','Others')),
PhoneNO char(10),
CurrentAddress varchar(50),
PermanentAddress varchar(50),
Email varchar(20),
LanguageKnown varchar(20),
Qualification varchar(10) ,
ApplyingPosition varchar(30) ,
Nationality varchar(30),
Religion varchar(20),
PassingYear char(4) constraint Pass check (PassingYear in('2022','2021')),
constraint Qual check (Qualification in('B.E','B.TECH','M.E','M.TECH')),
constraint Appl check (ApplyingPosition in('Software Developer','Network Engineer','Business Analyst','Help Desk Support')),
)

insert RegistrationForm1 ([FirstName], [LastNAme], [Gender], [PhoneNO], [CurrentAddress], [PermanentAddress], [Email], [LanguageKnown], [Qualification], [ApplyingPosition], [Nationality], [Religion], [PassingYear])
values('Nithin','p','Male','6383255712','Chennai','Villupuram','Nithin@gmail.com','English,Tamil','B.TECH','Software Developer','Indian','Indian','2022')
insert RegistrationForm1([FirstName], [LastNAme], [Gender], [PhoneNO], [CurrentAddress], [PermanentAddress], [Email], [LanguageKnown], [Qualification], [ApplyingPosition], [Nationality], [Religion], [PassingYear])
values('Rukesh','Kumar','Male','9655108460','Chennai','Vellore','Rukesh@gmail.com','English,Tamil','B.E','Network Engineer','Indian','Indian','2022') 
insert RegistrationForm1([FirstName], [LastNAme], [Gender], [PhoneNO], [CurrentAddress], [PermanentAddress], [Email], [LanguageKnown], [Qualification], [ApplyingPosition], [Nationality], [Religion], [PassingYear])
values('Kaviyarasan','B','Male','6383290144','Chennai','Neyveli','kavi1@gmail.com','English,Tamil','B.TECH','Network Engineer','Indian','Indian','2022') 
select * from RegistrationForm1