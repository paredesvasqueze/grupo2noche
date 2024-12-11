create procedure usp_seleccionar_Rol_Todo
as
begin
select * from Rol
end


create procedure usp_Eliminar_Rol
 @nIdRol               int
as
begin
Delete from Rol
where nIdRol = @nIdRol
select CAST(@@ROWCOUNT as int)
end

create procedure usp_Actualizar_Rol
    @nIdRol               int,
	@cTipodeRol           varchar(20) 

as
begin
update Rol set
[cTipodeRol ] = @cTipodeRol 
where nIdRol = @nIdRol 
select CAST(@@ROWCOUNT as int)
end

create procedure usp_Insertar_Rol
	@cTipodeRol           varchar(20)  
as
begin
insert into Rol

(cTipodeRol)
values
(@cTipodeRol)
select cast (SCOPE_IDENTITY() as int)
end