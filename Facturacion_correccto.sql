



create database factura_prog1
use factura_prog1


create table forma_pago
(id_forma int identity(1,1),
descripcion varchar(100)
constraint pk_id_forma primary key(id_forma))

create table articulos
(cod_articulo int,
descripcion varchar(100),
pre_unitario money,
constraint pk_articulo primary key (cod_articulo))

create table factura
(nro_factura int identity(1,1),
fecha datetime,
id_forma_pago int,
cliente varchar (250),
total money
constraint pk_nro_factura primary key(nro_factura),
constraint fk_id_forma foreign key(id_forma_pago) references forma_pago(id_forma))

create table detalle_fac
(id_detalle int identity (1,1),
nro_factura int,
cod_articulo int,
cantidad int,
constraint pk_id_detalle primary key(id_detalle),
constraint fk_nro_factura foreign key(nro_factura) references factura(nro_factura),
constraint fk_articulo foreign key(cod_articulo) references articulos(cod_articulo))




--id_clientes is now cliente varchar(80)

insert into articulos values (1, 'Lapiz B1', 50)
insert into articulos values (2, 'Lapicera Bic', 70)
insert into articulos values (3, 'Cuaderno', 200)
insert into articulos values (4, 'Tijera', 150)
insert into articulos values (5, 'Crayon', 200)

insert into forma_pago values ( 'Efectivo')
insert into forma_pago values ( 'Debito')
insert into forma_pago values ( 'Transferencia')

set dateformat dmy

insert into factura values ( '10/01/2020',1, 'Lucas Almada', 5800)
insert into factura values ( '27/01/2020',2, 'Marta Herrera', 3200)
insert into factura values ( '28/01/2020',1, 'Ivan Granato', 7750)




--CREATE PROCEDURE Sales.uspGetEmployeeSalesYTD  
  --  @SalesPerson nvarchar(50),  
    --@SalesYTD money OUTPUT  
--AS    
  
  --  SET NOCOUNT ON;

--    SELECT @SalesYTD = SalesYTD  
  --  FROM Sales.SalesPerson AS sp  
    --JOIN HumanResources.vEmployee AS e ON e.BusinessEntityID = sp.BusinessEntityID  
    --WHERE LastName = @SalesPerson;

    --RETURN;
--GO

create procedure prox_fact
@next int output
as
begin
set @next = (select max(nro_factura) + 1
from factura); 
end

create procedure consultar_articulos
as
BEGIN
	
	SELECT * from articulos
END

create procedure SP_CONS_FORMAPAG
as
BEGIN
	
	SELECT * from forma_pago
END


create procedure SP_LLAMAR_ARTICULO
@nro int
as
Select  descripcion as 'Descripcion', pre_unitario as 'Precio'
from articulos
where cod_articulo = @nro 

create procedure SP_INSERT_ARTICULO
@codigo int,
@descripcion varchar(100),
@precio money
as
insert into articulos values(@codigo, @descripcion, @precio)


ALTER PROCEDURE [dbo].[SP_INSERTAR_MAESTRO] 
	@cliente varchar(255), 
	@forma_pago int,
	@total numeric(8,2),
	@presupuesto_nro int OUTPUT
AS
BEGIN
	INSERT INTO factura(fecha, id_forma_pago, cliente, total, estado)
    VALUES (GETDATE(), @forma_pago, @cliente, @total, 'Activa');
    --Asignamos el valor del último ID autogenerado (obtenido --  
    --mediante la función SCOPE_IDENTITY() de SQLServer)	
    SET @presupuesto_nro = SCOPE_IDENTITY();

END

delete from factura

select * from detalle_fac

create procedure insertar_detalle
@nro_factura int,
@cod_articulo int,
@cantidad int
as
begin 
insert into detalle_fac (nro_factura, cod_articulo, cantidad)
values (@nro_factura, @cod_articulo,@cantidad)
end


create procedure consult_fact_fecha
@fecha1 smalldatetime,
@fecha2 smalldatetime
as
select nro_factura, cliente, fecha
from factura
where fecha between @fecha1 and @fecha2 



set dateformat dmy


create procedure sp_baja
@nro_fact int
as 
update factura
set estado = 'Baja' where nro_factura = @nro_fact

alter procedure sp_cons_fact
as
select * from factura
where estado = 'Activo'


