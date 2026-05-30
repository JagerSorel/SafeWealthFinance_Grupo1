Create database SafeWealthFinanceDB;
Go
Use SafeWealthFinanceDB;
Go
Create table Usuario(
Id_Usuario int primary key identity,
Usuario Varchar(50) Unique,
Contrasena Varchar(50),
Nombre Varchar(50),
Email Varchar(50)
);
Go
Create table Presupuesto_Mensual(
Id_Presupuesto int primary key identity,
Id_Usuario int foreign key references Usuario(Id_Usuario),
Fecha date,
TotalEspeculado Decimal(10,2),
TotalReal Decimal(10,2),
PorcentajeFinal Decimal(10,2)
);
Go
Create table Tipo_Gasto(
Id_TipoGasto Int Primary key Identity,
TipoGasto Varchar(50)
);
Go
Create table Presupuesto_Detalle(
Id_Detalle Int Primary key identity,
Id_Presupuesto Int Foreign key references Presupuesto_Mensual(Id_Presupuesto),
NombreTransaccion Varchar(100),
Id_TipoGasto Int Foreign key references Tipo_Gasto(Id_TipoGasto),
MontoEspeculado Decimal(10,2)
);
Go
Create table Metas_Ahorro(
Id_Meta Int Primary key Identity,
Id_Usuario Int Foreign key references Usuario(Id_Usuario),
NombreMeta Varchar(50),
MontoMeta Decimal(10,2),
MontoRealizado Decimal(10,2),
EstadoMeta Varchar(10),
Constraint CHK_EstadoMeta Check (EstadoMeta IN ('Completa', 'En proceso')),
FechaInicio Date,
FechaObjetivo Date
);
Go
Create table Gastos(
Id_Gasto Int Primary key Identity,
Id_Usuario Int Foreign key references Usuario(Id_Usuario),
NombreTransaccion Varchar(50),
MontoGasto Decimal(10,2),
FechaGasto Date,
Id_TipoGasto Int Foreign key references Tipo_Gasto(Id_TipoGasto)
);
Go
Insert into Tipo_Gasto(TipoGasto)
Values('Mensualidad'),
('Compra'),
('Alimentos'),
('Entretenimiento')

SELECT * FROM Tipo_Gasto

Create table GastosMensuales(
Id_GastoMensual int identity,
Id_Usuario int foreign key references Usuario(Id_Usuario),
Mes int,
anio int,
Ingresos Decimal(10,2),
Gastos Decimal(10,2),
Ganancias Decimal(10,2),
);
--Si ya habias declarado la base, no la borres, utiliza el siguiente comando
--drop table GastosMensuales
--Una vez que lo hayas hecho, ejecuta unicamente el cretare Gastos mensuales con sus propiedades
Go
Create table Ingreso(
Id_Ingreso Int primary key identity,
Id_Usuario int foreign key references Usuario(Id_Usuario),
NombreIngreso Varchar(50),
MontoIngreso Decimal(10,2),
FechaIngreso Date
);
GO
Create table Distribucion(
Id_Distribucion Int primary key identity,
Id_Usuario int foreign key references Usuario(Id_Usuario),
--Columnas agregadas empiezan aqui
Mes int,
Anio int,
--Columnas agregadas terminan aqui
MontoIngreso Decimal(10,2),
PorAhorro Decimal(10,2),
PorPresupuesto Decimal(10,2)
);
--Si ya habias declarado la base, unicamente coloca el siguiente comando
--Alter table Distribucion add Mes int, Anio int;
GO
create table DineroAhorro(
Id_DineroAhorro int primary key identity,
Id_Usuario int foreign key references Usuario(Id_Usuario),
mes int,
anio int,
MontoAhorro decimal(10,2)
);
Go
Select * From Ingreso
Go
Select * From Distribucion
