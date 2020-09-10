
--***************************DOCTOR TABLE***********************************
CREATE TABLE tbDoctor (
  
  DoctorId int not null identity(1,1),
  FirstName varchar(20) NOT NULL,
  LastName varchar(20) NOT NULL,
  Gender int ,
  SpecializationId int,
  Email nvarchar(50) NOT NULL,
  PhoneNumber varchar(15) NOT NULL,
  CONSTRAINT Doctor_pk PRIMARY KEY (DoctorId),
  CONSTRAINT FK_DoctorSpecialization FOREIGN KEY (SpecializationId) REFERENCES tbSpecialization(Id),
  CONSTRAINT FK_DoctorGender FOREIGN KEY (Gender)
  REFERENCES tbGender(GenderId) 
)

INSERT INTO tbDoctor (FirstName,LastName,SpecializationId,Gender,Email,PhoneNumber)
VALUES ('Mohit','Sharma',1,1,'mohitsharma@gmail.com','9873145873'), ('Priya','Desai',2,2,'priyadesai@yahoo.co.in','9845345563'), ('Rahul','Chahal',3,1,'rahulchahal@gmail.com','9987145321'), ('Ravi','Shankar',4,1,'ravishankar@gmail.com','9343144643'),('Sneha','Prasanna',5,2,'snehaprasanna@yahoo.com','8971365783');

SELECT * FROM tbdoctor;

drop table tbDoctor

--***************************DOCTOR TABLE***********************************

--***************************DOCTOR SPECIALIZATION TABLE***********************************
create table tbSpecialization
(
  Id int not null ,
  Specialization_Name varchar(50)
  CONSTRAINT Specialization_pk PRIMARY KEY (Id)
)

insert into tbSpecialization values(1,'Surgeon'),(2,'Dentist'),(3,'Neurologist'),(4,'Psychiatrist'),(5,'General Physician')

select * from tbSpecialization

DROP TABLE tbGender
--***************************DOCTOR SPECIALIZATION TABLE***********************************

--***************************PATIENT TABLE***********************************
CREATE TABLE tbPatient (
  
  PatientId int not null identity(1,1),
  FirstName varchar(20) NOT NULL,
  LastName varchar(20) NOT NULL,
  DateOfBirth date NOT NULL,
  Gender int,
  Email nvarchar(50) NOT NULL,
  PhoneNumber varchar(15) NOT NULL,
  City VARCHAR (255) NOT NULL,
  State VARCHAR (50)NOT NULL,
  Pincode VARCHAR (8)NOT NULL
  CONSTRAINT Patient_pk PRIMARY KEY (PatientId),
  CONSTRAINT FK_PatientGender FOREIGN KEY (Gender)REFERENCES tbGender(GenderId) 
)

INSERT INTO tbPatient (FirstName,LastName,DateOfBirth,Gender,Email,PhoneNumber,City,State,Pincode)
VALUES ('Sai','Guru','1990-07-19',1,'saiguru@gmail.com','9873145345','Bangalore','Karnataka','560036')

select * from tbPatient

drop table tbPatient
--***************************PATIENT TABLE***********************************


--***************************GENDER TABLE***********************************
create table tbGender
(
  GenderId int not null ,
  Gender_Name varchar(50)
  CONSTRAINT Gender_pk PRIMARY KEY (GenderId)
)

insert into tbGender values(1,'Male'),(2,'Female'),(3,'Unknown')

select * from tbGender

drop table tbGender
--***************************GENDER TABLE***********************************

--***************************APPOINTMENT TABLE***********************************

CREATE TABLE tbAppointment (
   
   
    DoctorId int NOT NULL,
    [Date] date NOT NULL,
    StartTime time(0) NOT NULL CONSTRAINT CHK_StartTime_TenMinute CHECK (DATEPART(MINUTE, StartTime)%10 = 0 AND DATEPART(SECOND, StartTime) = 0),
    EndTime time(0) NOT NULL CONSTRAINT CHK_EndTime_TenMinute CHECK (DATEPART(MINUTE, EndTime)%10 = 0 AND DATEPART(SECOND, EndTime) = 0),
    Status varchar(20) NOT NULL,
    PatientID int NOT NULL,
    CONSTRAINT PK_Appointment PRIMARY KEY  (DoctorID, [Date], StartTime),
	CONSTRAINT FK_DocterAppointment FOREIGN KEY (DoctorId) REFERENCES tbDoctor(DoctorId),
	CONSTRAINT FK_PatientAppointment FOREIGN KEY (PatientId) REFERENCES tbPatient(PatientId),
    CONSTRAINT CHK_StartTime_BusinessHours CHECK (DATEPART(HOUR, StartTime) > = 9 AND DATEPART(HOUR, StartTime) < = 16),
    CONSTRAINT CHK_EndTime_BusinessHours CHECK (DATEPART(HOUR, EndTime) > = 9 AND DATEPART(HOUR, DATEADD(SECOND, -1, EndTime)) < = 16),
    CONSTRAINT CHK_EndTime_After_StartTime CHECK (EndTime > StartTime));

CREATE INDEX iDoctor_End ON tbAppointment (DoctorID, [Date], EndTime);


INSERT INTO tbAppointment VALUES (1, '20200909', '09:30:00', '09:50:00', 'Cancelled', 5);
INSERT INTO tbAppointment VALUES (1, '20200909', '10:00:00', '10:20:00', 'Confirmed', 7);
INSERT INTO tbAppointment VALUES (1, '20200909', '10:30:00', '10:50:00', 'Confirmed', 8);
INSERT INTO tbAppointment VALUES (1, '20200910', '11:00:00', '11:20:00', 'Confirmed', 9);
INSERT INTO tbAppointment VALUES (2, '20200910', '14:00:00', '14:20:00', 'Confirmed', 10);
INSERT INTO tbAppointment VALUES (2, '20200910', '14:30:00', '14:50:00', 'Confirmed', 18);
INSERT INTO tbAppointment VALUES (3, '20200911', '15:00:00', '15:20:00', 'Confirmed', 20);
INSERT INTO tbAppointment VALUES (3, '20200912', '15:30:00', '15:50:00', 'Confirmed', 19);
INSERT INTO tbAppointment VALUES (4, '20200914', '09:00:00', '09:20:00', 'Confirmed', 5);
INSERT INTO tbAppointment VALUES (4, '20200915', '09:30:00', '09:50:00', 'Confirmed', 10);
INSERT INTO tbAppointment VALUES (5, '20200915', '09:00:00', '09:20:00', 'Confirmed', 11);

select * from tbAppointment

drop table tbAppointment

select 

--***************************APPOINTMENT TABLE***********************************