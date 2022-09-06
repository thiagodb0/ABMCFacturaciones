create database factura_prog1
use factura_prog1


create table forma_pago
(id_forma int,
descripcion varchar(100)
constraint pk_id_forma primary key(id_forma))

create table articulos
(cod_articulo int,
descripcion varchar(100),
pre_unitario money,
constraint pk_articulo primary key (cod_articulo))

create table factura
(nro_factura int,
fecha datetime,
id_forma_pago int,
id_cliente int
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

alter table factura
alter column id_cliente varchar(100)


--id_clientes is now cliente varchar(80)

insert into articulos values (1, 'Lapiz B1', 50)
insert into articulos values (2, 'Lapicera Bic', 70)
insert into articulos values (3, 'Cuaderno', 200)
insert into articulos values (4, 'Tijera', 150)
insert into articulos values (5, 'Crayon', 200)

insert into forma_pago values (1, 'Efectivo')
insert into forma_pago values (2, 'Debito')
insert into forma_pago values (3, 'Transferencia')

set dateformat dmy

insert into factura values (1, '10/01/2020',1, 'Lucas Almada')
insert into factura values (2, '27/01/2020',2, 'Marta Herrera')
insert into factura values (3, '28/01/2020',1, 'Ivan Granato')



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









