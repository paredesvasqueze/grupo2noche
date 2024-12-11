create procedure usp_seleccionar_Usuario_Todo
as
begin
select * from Usuario
end


create procedure usp_Eliminar_Usuario
 @nIdUsuario           int
as
begin
Delete from Usuario
where nIdUsuario = @nIdUsuario
select CAST(@@ROWCOUNT as int)
end

create procedure usp_Actualizar_Usuario
    @nIdUsuario           int,
	@cNombre              varchar(100),
	@cApellido            varchar(100),
	@cEmail               varchar(100),
	@nTelefono            varchar(12),
	@cContrasena          varchar(20),
	@cDireccion           varchar(50),
	@nIdRol               int  

as
begin
update Usuario set
[cNombre] = @cNombre,
[cApellido] = @cApellido, 
[cEmail] = @cEmail,
[nTelefono] = @nTelefono,  
[cContrasena] = @cContrasena,   
[cDireccion] = @cDireccion,
[nIdRol] = @nIdRol
where nIdUsuario  = @nIdUsuario  
select CAST(@@ROWCOUNT as int)
end

create procedure usp_Insertar_Usuario
	@cNombre              varchar(100),
	@cApellido            varchar(100),
	@cEmail               varchar(100),
	@nTelefono            varchar(12),
	@cContrasena          varchar(20),
	@cDireccion           varchar(50),
	@nIdRol               int   
as
begin
insert into Usuario

(cNombre, cApellido, cEmail, nTelefono, cContrasena,cDireccion, nIdRol)
values
(@cNombre, @cApellido, @cEmail, @nTelefono, @cContrasena, @cDireccion, @nIdRol)
select cast (SCOPE_IDENTITY() as int)
end