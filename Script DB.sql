CREATE TABLE Persona(
identificacion varchar(15) PRIMARY KEY,
id nvarchar(128) FOREIGN KEY REFERENCES AspNetUsers(id),
nombre varchar(30),
apellido1 varchar(30),
apellido2 varchar(30),
correo varchar(50),
curriculo varbinary(max),
discapacidad bit
);


CREATE TABLE Telefono_Persona(
identificacion varchar(15) FOREIGN KEY REFERENCES Persona(identificacion),
numero varchar(15),
PRIMARY KEY (identificacion, numero)
);


CREATE TABLE Servicio(
id int identity(1,1) PRIMARY KEY, 
descripcion varchar(200),
imagen varbinary(max),
costo varchar(20),
identificacionPersona varchar(15) FOREIGN KEY REFERENCES Persona(identificacion)
);

CREATE TABLE Especialidad(
nombre varchar(50) PRIMARY KEY,
);

CREATE TABLE Empresa(
identificacion varchar(15) PRIMARY KEY,
id nvarchar(128) FOREIGN KEY REFERENCES AspNetUsers (id),
nombre varchar(30),
estado bit,
certificacion bit,
puntos int, 
especialidad varchar(50) FOREIGN KEY REFERENCES Especialidad(nombre), 
);


CREATE TABLE Area_Trabajo(
id int identity(1,1) PRIMARY KEY, 
nombre varchar(50)
);

CREATE TABLE Requerimiento(
identificacion varchar(15) PRIMARY KEY,
descripcion varchar(100),
identificacionEmpresa varchar(15) FOREIGN KEY REFERENCES Empresa(identificacion), 
);

CREATE TABLE Puesto(
identificacion varchar(15) PRIMARY KEY,
nombre varchar(30),
descripcion varchar(100),
idArea int FOREIGN KEY REFERENCES Area_Trabajo(Id)
);


CREATE TABLE Aplica(
IdentificacionAplicante varchar(15) FOREIGN KEY REFERENCES Persona(identificacion),
identificacionPuesto varchar(15) FOREIGN KEY REFERENCES Puesto(identificacion),
fechaAplicacion datetime,
PRIMARY KEY (identificacionAplicante, identificacionPuesto)
);


CREATE TABLE Requerimientos_Puesto(
identificacionPuesto varchar(15) FOREIGN KEY REFERENCES Puesto(identificacion), 
identificacionReq varchar(15) FOREIGN KEY REFERENCES Requerimiento(identificacion),
);


CREATE TABLE Trabaja_En(
idenficacionPersona varchar(15)  FOREIGN KEY REFERENCES Persona(identificacion),
identifcacionPuesto varchar(15) FOREIGN KEY REFERENCES Puesto(identificacion),
fechaInicio datetime NOT NULL,
fechafinal datetime,
);

CREATE TABLE Telefono_Empresa(
identificacion varchar(15) FOREIGN KEY REFERENCES Empresa(identificacion),
numero varchar(15),
PRIMARY KEY (identificacion, numero)
);