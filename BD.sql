----------------------------------- COMANDOS OFICIALES ------------------------------------------------
create database TrabajandoEnCapas_ok
GO
use TrabajandoEnCapas_ok
GO

------------------------------------------------------------------------------------------------------
create table Personass
(
NombrePersona nchar (28),				--		@nombrePersonass
ApellidoPersona nchar (28),				--		@apellidoPersona							
TipoDocumento nchar  (4),				--		@tipoDocumento
Ndocumento int primary key,				--		@ndocumento
CUIL bigint,							--		@cUIL
FechaNacimiento date,					--		@fechaNacimiento
Edad int								--		@edad
)
GO
insert into Personass
values
('Mateo','Artino','DNI',41886444,20418864445,'03-06-1999', 21)
GO
-----------------------------------------------------------------------------------------------------
create table Tarjetass 
(
NumeroTarjeta smallint primary key,
dniTarjeta int ,
Saldo float,
)
GO
INSERT INTO Tarjetass 
VALUES
(1234,41886444,25),
(4321,43889888,44),
(3412,41886444,70)
GO

-------------------------------------------------------------------------------------------------------
---PROCEDIMIENTOS ALMACENADOS TABLA TARJETAS
-------------------------------------------------------------------------------------------------------
				--------------------------MOSTRAR 
create proc MostrarTarjetass
as
select *from Tarjetass
GO

				--------------------------INSERTAR 
create proc InsetarTarjetass
@numeroTarjetass smallint, 
@dniTarjetass int,
@saldo float
as
insert into Tarjetass values (@numeroTarjetass, @dniTarjetass, @saldo)
GO

				---------------------------ELIMINAR
create proc EliminarTarjetass
@numeroTarjetass smallint
as
delete from Tarjetass where NumeroTarjeta =@numeroTarjetass
GO

--				-----------------------------EDITAR
create proc EditarTarjetass
@dniTarjetass int,
@numeroTarjetass smallint,
@saldo float
as
update Tarjetass set dniTarjeta=@dniTarjetass , Saldo=@saldo where NumeroTarjeta = @numeroTarjetass
GO
				----------------------CARGAR_SALDO Y PAGAR_PASAJE
create proc CargarSaldo_PagarPasaje
@dniTarjetass int,
@numeroTarjetass smallint,
@saldo float
as
update Tarjetass set Saldo=@saldo, dniTarjeta= @dniTarjetass where NumeroTarjeta=@numeroTarjetass
GO

-----------------------------------------------------------------------------------------------------
---PROCEDIMIENTOS ALMACENADOS TABLA PERSONAS
------------------------------------------------------------------------------------------------------
				
				--------------------------MOSTRAR 
create proc MostrarPersonass
as
select *from Personass
GO

				--------------------------INSERTAR 
create proc InsetarPersonass
@nombrePersonass nchar (28),
@apellidoPersona nchar (28),
@tipoDocumento nchar (4),
@ndocumento int,
@cUIL bigint,
@fechaNacimiento date,
@edad int
as
insert into Personass values (@nombrePersonass, @apellidoPersona, @tipoDocumento, @ndocumento, @cUIL, @fechaNacimiento, @edad)
GO

				---------------------------ELIMINAR
create proc EliminarPersonass
@ndocumentoPers int
as
delete from Personass where Ndocumento=@ndocumentoPers
GO

				-----------------------------EDITAR
create proc EditarPersonass
@nombrePersonass nchar (28),
@apellidoPersona nchar (28),
@tipoDocumento nchar (4),
@ndocumento int,
@cUIL bigint,
@fechaNacimiento date,
@edad int
as
update Personass set NombrePersona=@nombrePersonass, ApellidoPersona=@apellidoPersona, TipoDocumento=@tipoDocumento, 
CUIL=@cUIL, FechaNacimiento=@fechaNacimiento, Edad=@edad where Ndocumento=@ndocumento
GO

				------------------VERIFICAR TARJETAS
create proc TarjetaExiste
as
select A.NombrePersona, A.ApellidoPersona, B.NumeroTarjeta, B.dniTarjeta, B.Saldo from Tarjetass B, Personass A where A.Ndocumento = B.dniTarjeta order by ApellidoPersona, NombrePersona, NumeroTarjeta
GO

				------------------VERIFICAR NUMERO TARJETAS
create proc ExisteNroTarjeta
@numeroTarjeta smallint
as
SELECT * FROM Tarjetass WHERE NumeroTarjeta = @numeroTarjeta
GO

				------------------VERIFICAR NUMERO DOCUMENTOS
create proc ExisteNroDocumento
@numeroDocumento int
as
SELECT * FROM Personass WHERE Ndocumento = @numeroDocumento
GO

				------------------VERIFICAR TARJETAS ASOCIADAS
create proc ExisteTarjetaAsociada
	@numeroDocumento int 
	as
	SELECT * FROM Tarjetass WHERE dniTarjeta = @numeroDocumento
GO


























-------------------------------- COMANDOS INICIALES ----------------------------------------------------

--create database TrabajandoEnCapas_ok
--GO
--use TrabajandoEnCapas_ok
--GO
--create table Tarjetass 
--(
--dniTarjeta int  primary key,
--NombreTarjeta nvarchar (28),
--Saldo float,
--)
--GO
--insert into Tarjetass 
--values
--(41886483,'MATEO ARTINO', 15),
--(43889879,'CATALINA ARTINO', 25)
--GO
-----PROCEDIMIENTOS ALMACENADOS 
--				--------------------------MOSTRAR 
--create proc MostrarTarjetass
--as
--select *from Tarjetass
--GO

--				--------------------------INSERTAR 
--create proc InsetarTarjetass
--@dniTarjetass int,
--@nombreTarjetass nvarchar (28),
--@saldo float
--as
--insert into Tarjetass values (@dniTarjetass,@nombreTarjetass,@saldo)
--GO

--				---------------------------ELIMINAR
--create proc EliminarTarjetass
--@dniTar int
--as
--delete from Tarjetass where dniTarjeta=@dniTar
--GO
--				-----------------------------EDITAR

--create proc EditarTarjetass
--@dniTarjetass int,
--@nombreTarjetass nvarchar (28),
--@saldo float
--as
--update Tarjetass set NombreTarjeta=@nombreTarjetass, Saldo=@saldo where dniTarjeta=@dniTarjetass
--GO
--				----------------------CARGAR_SALDO

--create proc CargarSaldoTarjetass
--@dniTarjetass int,
--@nombreTarjetass nvarchar (28),
--@saldo float
--as
--update Tarjetass set NombreTarjeta=@nombreTarjetass, Saldo=@saldo where dniTarjeta=@dniTarjetass
--GO
--				----------------------PAGAR_PASAJE

--create proc PagarPasajeTarjetass
--@dniTarjetass int,
--@nombreTarjetass nvarchar (28),
--@saldo float
--as
--update Tarjetass set NombreTarjeta=@nombreTarjetass, Saldo=@saldo where dniTarjeta=@dniTarjetass
--GO
-------------------------------------------------------------------------------------------------------


--------------------------------------------------------------------------------------------------------

--create table Personass
--(
--NombrePersona nchar (28),				--		@nombrePersonass
--ApellidoPersona nchar (28),				--		@apellidoPersona							
--TipoDocumento nchar  (4),				--		@tipoDocumento
--Ndocumento int primary key,				--		@ndocumento
--CUIL bigint,							--		@cUIL
--FechaNacimiento date,					--		@fechaNacimiento
--Edad int								--		@edad
--)
--GO
--insert into Personass
--values
--('Mateo','Artino','DNI',41886483,20418864835,'03-06-1999', 20),
--('Catalina','Artino','DNI',43889879,27438898793,'04-08-2001', 18)
--GO
-----PROCEDIMIENTOS ALMACENADOS 
--				--------------------------MOSTRAR 
--create proc MostrarPersonass
--as
--select *from Personass
--GO

--				--------------------------INSERTAR 
--create proc InsetarPersonass
--@nombrePersonass nchar (28),
--@apellidoPersona nchar (28),
--@tipoDocumento nchar (4),
--@ndocumento int,
--@cUIL bigint,
--@fechaNacimiento date,
--@edad int
--as
--insert into Personass values (@nombrePersonass, @apellidoPersona, @tipoDocumento, @ndocumento, @cUIL, @fechaNacimiento, @edad)
--GO

--				---------------------------ELIMINAR
--create proc EliminarPersonass
--@ndocumentoPers int
--as
--delete from Personass where Ndocumento=@ndocumentoPers
--GO
--				-----------------------------EDITAR

--create proc EditarPersonass
--@nombrePersonass nchar (28),
--@apellidoPersona nchar (28),
--@tipoDocumento nchar (4),
--@ndocumento int,
--@cUIL bigint,
--@fechaNacimiento date,
--@edad int
--as
--update Personass set NombrePersona=@nombrePersonass, ApellidoPersona=@apellidoPersona, TipoDocumento=@tipoDocumento, 
--CUIL=@cUIL, FechaNacimiento=@fechaNacimiento, Edad=@edad where Ndocumento=@ndocumento
--GO

--				------------------VERIFICAR TARJETAS

--create proc TarjetaExiste
--as
--select dniTarjeta, NombreTarjeta, Saldo from Tarjetass, Personass where Ndocumento = dniTarjeta
--GO

--				------------------VERIFICAR TARJETAS

--select NombrePersona, ApellidoPersona, TipoDocumento, Ndocumento, CUIL, FechaNacimiento, Edad, Saldo from Personass, Tarjetass where Ndocumento=dniTarjeta



