CREATE DATABASE MunicipioSP;
GO
USE MunicipioSP;
GO
CREATE TABLE Municipio(
    IDMunicipio int not null primary key,
    NombreMunicipio char(50) not null,
    Direccion char(50) not null,
    CodPostalMun char(50)
)
go
INSERT INTO Municipio (IDMunicipio, NombreMunicipio, Direccion,CodPostalMun)
VALUES (1,'ZACATLAN','LUIS CABRERA NUM 20','73310');
go
select * from Municipio;
GO
CREATE PROC sp_Insert_Municipio(
    @IDMunicipio int, 
    @NombreMunicipio char(50),
    @Direccion char(50),
    @CodPostalMun char (50)
)
AS 
INSERT INTO Municipio(IDMunicipio, NombreMunicipio, Direccion,CodPostalMun)
VALUES (@IDMunicipio, @NombreMunicipio, @Direccion,@CodPostalMun);

GO
sp_Insert_Municipio 2,'CHIGNAHUAPAN','JUAN NEPOMUCENO MENDEZ','73300';
select * from Municipio;

go
CREATE PROC sp_Update_Municipio(
    @IDMunicipio int, 
    @NombreMunicipio char(50),
    @Direccion char(50),
    @CodPostalMun char (50)
)
AS 
UPDATE Municipio
SET
    IDMunicipio=@IDMunicipio, 
    NombreMunicipio=@NombreMunicipio, 
    Direccion=@Direccion,
    CodPostalMun = @CodPostalMun
WHERE IDMunicipio = @IDMunicipio;

go 
select * from municipio;
go
sp_Update_Municipio 23,'JOPALA','JOSE CLEMENTE OROZCO','73260';
GO
sp_Update_Municipio 23,'JOPALA','JOSE CLEMENTE',73260;

GO
CREATE PROC sp_Delete_Municipio(
@IDMunicipio int)
AS
DELETE Municipio 
WHERE IDMunicipio = @IDMunicipio;

select *  from Municipio;
GO
sp_Delete_Municipio 23;


--Vivienda
CREATE TABLE Vivienda (
    IDVivienda int not null CONSTRAINT PK_Vivienda PRIMARY KEY,
    NumVivienda char(50) not null,
    NombreCalleVivienda char(50) not null,
    DireccionVivienda char(50) null,
    N_Int_Vivienda char(5) null DEFAULT 'S/N',
    N_Ext_Vivienda char(5) null DEFAULT 'S/N',
    ColoniaVivienda char(50) not null,
    EstadoVivienda char(50) not null,
    CodigoPostalVivienda char(5) not null CONSTRAINT CH_CodigoPostal_Viv CHECK(CodigoPostalVivienda like '[0-9][0-9][0-9][0-9][0-9]')
)
GO--INSERTAR
CREATE PROC sp_Insert_Vivienda(
    @IDVivienda int,
    @NumVivienda char(50),
    @NombreCalleVivienda char(50),
    @DireccionVivienda char(50),
    @N_Int_Vivienda char(5),
    @N_Ext_Vivienda char(5),
    @ColoniaVivienda char(50),
    @EstadoVivienda char(50),
    @CodigoPostalVivienda char(5)
)
AS 
INSERT INTO Vivienda(IDVivienda,NumVivienda,NombreCalleVivienda,DireccionVivienda,N_Int_Vivienda, N_Ext_Vivienda,ColoniaVivienda,EstadoVivienda,CodigoPostalVivienda)
VALUES (@IDVivienda,@NumVivienda,@NombreCalleVivienda,@DireccionVivienda,@N_Int_Vivienda, @N_Ext_Vivienda,@ColoniaVivienda,@EstadoVivienda,@CodigoPostalVivienda);
go
sp_Insert_Vivienda 1,'5','GALEANA','BUENOS AIRES','5','S/N','5 DE MAYO','PERFECTA','73310'; 
go
sp_Insert_Vivienda 2,'5','GALEANA','BUENOS AIRES','5','S/N','5 DE MAYO','PERFECTA','73310'; 
go
sp_Insert_Vivienda 3,'5','GALEANA','BUENOS AIRES','5','S/N','5 DE MAYO','PERFECTA','73310'; 
GO
CREATE PROC sp_Update_Vivienda(
    @IDVivienda int,
    @NumVivienda char(50),
    @NombreCalleVivienda char(50),
    @DireccionVivienda char(50),
    @N_Int_Vivienda char(5),
    @N_Ext_Vivienda char(5),
    @ColoniaVivienda char(50),
    @EstadoVivienda char(50),
    @CodigoPostalVivienda char(5)
)
AS 
UPDATE Vivienda
SET
    IDVivienda = @IDVivienda,
    NumVivienda = @NumVivienda,
    NombreCalleVivienda = @NombreCalleVivienda,
    DireccionVivienda = @DireccionVivienda,
    N_Int_Vivienda = @N_Int_Vivienda,
    N_Ext_Vivienda = @N_Ext_Vivienda,
    ColoniaVivienda =@ColoniaVivienda,
    EstadoVivienda = @EstadoVivienda,
    CodigoPostalVivienda = @CodigoPostalVivienda
WHERE IDVivienda = @IDVivienda;
go
sp_Update_Vivienda 3,'5','GALEANA','NUEVA YORK','5','S/N','5 DE MAYO','PERFECTA','73310'; 
GO-------
SELECT * FROM Vivienda;
GO
CREATE PROC sp_Delete_Vivienda(
@IDVivienda int)
AS
DELETE Vivienda 
WHERE IDVivienda = @IDVivienda;
GO
sp_Delete_Vivienda 1;

go
SELECT *  FROM Persona;
SELECT * FROM Municipio;
go
sp_Insert_Persona 1,'DAVID','NAVA','GARCIA','JOSE CLEMENTE','1','5','73310','5 DE MAYO','1','MÉXICO','7641857875','NAGD020401','20','01/04/2022','M','S','1.60','60','1000','NAGD0020401HPLVRV4';
GO
select * from Vivienda;
--DROP TABLE Persona;
go
CREATE TABLE Persona (
    IDPersona int not null CONSTRAINT PK_Persona PRIMARY KEY,
    NombrePersona char(50) not null,
    A_Paterno char(50) not null,
    A_Materno char(50) null,
    NombreCalle char(50) DEFAULT 'DOMICILIO CONOCIDO',
    N_Int char(5) null DEFAULT 'S/N',
    N_Ext char(5) null DEFAULT 'S/N',
    CodigoPostal char(5) not null CONSTRAINT CH_CodigoPostal CHECK(CodigoPostal like '[0-9][0-9][0-9][0-9][0-9]') ,
    Colonia char(30) null,
    ID_Municipio int not null CONSTRAINT FK_ID_Municipio FOREIGN KEY(ID_Municipio) 
    REFERENCES Municipio(IDMunicipio),--foreign
    ID_Vivienda int not null CONSTRAINT FK_ID_Vivienda FOREIGN KEY(ID_Vivienda) 
    REFERENCES Vivienda(IDVivienda),--forreign
    ID_Persona int not null CONSTRAINT FK_ID_Persona FOREIGN KEY(ID_Persona) 
    REFERENCES Persona(IDPersona),--persona quien la encabeza
    Pais char(50) not null DEFAULT 'MÉXICO',
    Telefono char(17) not null CONSTRAINT DF_TelefonoDefault DEFAULT '(000)000-0000',
    RFC char(10) not null CONSTRAINT CH_RFC CHECK(RFC like '[A-Z][A-Z][A-Z][A-Z][0-9][0-9][0-9][0-9][0-9][0-9]'),
    Edad int not null CONSTRAINT CH_Edad CHECK(Edad > 0 AND Edad <125),
    FechaNacimiento datetime not null CONSTRAINT CH_FechaNac CHECK(FechaNacimiento < getdate()),
    Sexo char(1) not null CONSTRAINT CH_Sexo CHECK(Sexo = 'M' OR Sexo = 'F'),
    EstadoCivil char(1) not null CONSTRAINT CH_EdoCivil CHECK(EstadoCivil in('C', 'S','V', 'D', 'U')),
    Estatura decimal not null CONSTRAINT CH_Estatura CHECK (Estatura > 0 and Estatura <=3),
    Peso decimal not null CONSTRAINT CH_Peso CHECK (Peso >= 0 AND Peso <1000),
    Sueldo money not null DEFAULT 0,
    CURP char(18) not null
)

/*
CONSTRAINT FK_Municipio FOREIGN KEY(ID_Municipio) 
    REFERENCES Municipio(IDMunicipio)
*/
GO
SELECT * FROM Persona;
GO
CREATE PROC sp_Insert_Persona(
    @IDPersona int,
    @NombrePersona char(50),
    @A_Paterno char(50),
    @A_Materno char(50),
    @NombreCalle char(50),
    @N_Int char(5),
    @N_Ext char(5),
    @CodigoPostal char(5),
    @Colonia char(30),
    @ID_Municipio int ,
    @ID_Vivienda int,
    @ID_Persona int,
    @Pais char(50),
    @Telefono char(17),
    @RFC char(10),
    @Edad int,
    @FechaNacimiento datetime,
    @Sexo char(1),
    @EstadoCivil char(1),
    @Estatura decimal,
    @Peso decimal,
    @Sueldo money,
    @CURP char(18)
)
AS 
INSERT INTO Persona( IDPersona,NombrePersona, A_Paterno, A_Materno, NombreCalle, N_Int, N_Ext, CodigoPostal, Colonia, ID_Municipio, ID_Vivienda, ID_Persona, Pais,
        Telefono, RFC, Edad, FechaNacimiento, Sexo, EstadoCivil, Estatura, Peso,Sueldo, CURP)
VALUES ( @IDPersona,@NombrePersona, @A_Paterno, @A_Materno, @NombreCalle, @N_Int, @N_Ext, @CodigoPostal, @Colonia, @ID_Municipio,@ID_Vivienda,@ID_Persona, @Pais,
        @Telefono, @RFC, @Edad,@FechaNacimiento, @Sexo, @EstadoCivil, @Estatura,@Peso, @Sueldo, @CURP);
    
GO
SELECT *  FROM Persona;
SELECT* FROM Vivienda;
SELECT * FROM Municipio;
go
sp_Insert_Persona 1,'DAVID','NAVA','GARCIA','JOSE CLEMENTE','1','5','73310','5 DE MAYO','1','3','1','MÉXICO','7641857875','NAGD020401','20','01/04/2022','M','S','1.60','60','1000','NAGD0020401HPLVRV4';
GO
sp_Insert_Persona 2,'JUAN','NAVA','GARCIA','JOSE CLEMENTE','1','5','73310','5 DE MAYO','1','3','1','MÉXICO','7641857875','NAGD020401','20','01/04/2022','M','S','1.60','60','1000','NAGD0020401HPLVRV4';
GO
sp_Insert_Persona 3,'PEDRO','NAVA','GARCIA','JOSE CLEMENTE','1','5','73310','5 DE MAYO','1','3','1','MÉXICO','7641857875','NAGD020401','20','01/04/2022','M','S','1.60','60','1000','NAGD0020401HPLVRV4';

GO
CREATE PROC sp_Update_Persona(
    @IDPersona int,
    @NombrePersona char(50),
    @A_Paterno char(50),
    @A_Materno char(50),
    @NombreCalle char(50),
    @N_Int char(5),
    @N_Ext char(5),
    @CodigoPostal char(5),
    @Colonia char(30),
    @ID_Municipio int ,
    @ID_Vivienda int,
    @ID_Persona int,
    @Pais char(50),
    @Telefono char(17),
    @RFC char(10),
    @Edad int,
    @FechaNacimiento datetime,
    @Sexo char(1),
    @EstadoCivil char(1),
    @Estatura decimal,
    @Peso decimal,
    @Sueldo money,
    @CURP char(18)
)
AS 
UPDATE Persona
SET
    IDPersona = @IDPersona,
    NombrePersona = @NombrePersona,
    A_Paterno = @A_Paterno,
    A_Materno = @A_Materno ,
    NombreCalle = @NombreCalle,
    N_Int = @N_Int,
    N_Ext = @N_Ext,
    CodigoPostal = @CodigoPostal,
    Colonia = @Colonia,
    ID_Municipio = @ID_Municipio,
    ID_Vivienda = @ID_Vivienda,
    ID_Persona = @ID_Persona,
    Pais = @Pais,
    Telefono = @Telefono,
    RFC = @RFC,
    Edad = @Edad,
    FechaNacimiento = @FechaNacimiento,
    Sexo = @Sexo,
    EstadoCivil = @EstadoCivil,
    Estatura = @Estatura,
    Peso= @Peso,
    Sueldo = @Sueldo,
    CURP = @CURP 
WHERE IDPersona = @IDPersona;

go
sp_Update_Persona 1,'DAVID','NAVA','GARCIA','JOSE CLEMENTE','1','5','73310','5 DE MAYO','1','2','1','MÉXICO','7641857875','NAGD020401','20','01/04/2022','M','S','1.60','60','1000','NAGD0020401HPLVRV4';
GO
select * from Persona;

GO
CREATE PROC sp_Delete_Persona(
@IDPersona int)
AS
DELETE Persona 
WHERE IDPersona = @IDPersona;

select *  from Municipio;
SELECT * FROM PERSONA;
go
sp_Delete_Persona 1;
go
--Relacion Persona Vivienda
CREATE TABLE PerPropVivienda(
    IDPerPropVivienda int not null PRIMARY key,
    ID_Vivienda int not null CONSTRAINT FK_ID_Vivienda_prePropV FOREIGN KEY(ID_Vivienda) 
    REFERENCES Vivienda(IDVivienda),
    ID_Persona int not null CONSTRAINT FK_ID_Persona_prePropV FOREIGN KEY(ID_Persona) 
    REFERENCES Persona(IDPersona),
    FechaPago datetime not null,
    PrecioPredio money not null
)
select * from PerPropVivienda;
GO--INSERTAR
CREATE PROC sp_Insert_perPropVivienda(
    @IDPerPropVivienda int,
    @ID_Vivienda int,
    @ID_Persona int,
    @FechaPago datetime,
    @PrecioPredio money
)
AS 
INSERT INTO PerPropVivienda(IDPerPropVivienda,ID_Vivienda,ID_Persona,FechaPago,PrecioPredio)
VALUES (@IDPerPropVivienda,@ID_Vivienda,@ID_Persona,@FechaPago,@PrecioPredio);
go
sp_Insert_perPropVivienda 1,2,1,'2022-10-22',20000;

GO
SELECT * from Vivienda;
SELECT * from Persona;
SELECT * from PerPropVivienda;