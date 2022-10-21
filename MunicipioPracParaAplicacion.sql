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
    ID_Municipio int not null,
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
INSERT INTO Persona( IDPersona,NombrePersona, A_Paterno, A_Materno, NombreCalle, N_Int, N_Ext, CodigoPostal, Colonia, ID_Municipio, Pais,
        Telefono, RFC, Edad, FechaNacimiento, Sexo, EstadoCivil, Estatura, Peso,Sueldo, CURP)
VALUES ( @IDPersona,@NombrePersona, @A_Paterno, @A_Materno, @NombreCalle, @N_Int, @N_Ext, @CodigoPostal, @Colonia, @ID_Municipio, @Pais,
        @Telefono, @RFC, @Edad,@FechaNacimiento, @Sexo, @EstadoCivil, @Estatura,@Peso, @Sueldo, @CURP);
    
GO
SELECT *  FROM Persona;
SELECT * FROM Municipio;
go
sp_Insert_Persona 1,'DAVID','NAVA','GARCIA','JOSE CLEMENTE','1','5','73310','5 DE MAYO','1','MÉXICO','7641857875','NAGD020401','20','01/04/2022','M','S','1.60','60','1000','NAGD0020401HPLVRV4';
GO
CREATE PROC sp_Update_Persona(
    @IDPersona int,
    @NombrePersona varchar(50),
    @A_Paterno varchar(50),
    @A_Materno varchar(50),
    @NombreCalle varchar(50),
    @N_Int char(5),
    @N_Ext char(5),
    @CodigoPostal char(5),
    @Colonia char(30),
    @ID_Municipio int ,
    @Pais char(50),
    @Telefono varchar(17),
    @RFC varchar(10),
    @Edad int,
    @FechaNacimiento datetime,
    @Sexo char(1),
    @EstadoCivil char(1),
    @Estatura decimal,
    @Peso decimal,
    @Sueldo money,
    @CURP varchar(18)
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
    Pais = @Pais,
    Telefono = @Telefono,
    RFC = @RFC,
    Edad = @Edad,
    --@FechaNacimiento datetime,
    Sexo = @Sexo,
    EstadoCivil = @EstadoCivil,
    Estatura = @Estatura,
    Peso= @Peso,
    Sueldo = @Sueldo,
    CURP = @CURP 
WHERE IDPersona = @IDPersona;

go
sp_Update_Persona 1,'DAVID','NAVA','GARCIA','JOSE CLEMENTE','1','5','73310','5 DE MAYO','1','MÉXICO','7641857875','NAGD020401','20',/*'01/04/2022',*/'M','S','1.60','60','1000','NAGD0020401HPLVRV4';
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