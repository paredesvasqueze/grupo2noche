create procedure usp_seleccionar_Autor_Todo
as
begin
select * from Autor
end


create procedure usp_Eliminar_Autor
 @nIdAutor            int
as
begin
Delete from Autor
where nIdAutor = @nIdAutor 
select CAST(@@ROWCOUNT as int)
end

create procedure usp_Actualizar_Autor
    @nIdAutor             int,
	@cNombre              varchar(200),
	@cNacionalidad        varchar(20),
	@cEspecialidad        varchar(260) 
as
begin
update Autor set
[cNombre] = @cNombre,
[cNacionalidad] = @cNacionalidad,
[cEspecialidad] = @cEspecialidad
where nIdAutor = @nIdAutor
select CAST(@@ROWCOUNT as int)
end

create procedure usp_Insertar_Autor
	@cNombre              varchar(200),
	@cNacionalidad        varchar(20),
	@cEspecialidad        varchar(260)
as
begin
insert into Autor

(cNombre, cNacionalidad, cEspecialidad)
values
(@cNombre, @cNacionalidad,@cEspecialidad)
select cast (SCOPE_IDENTITY() as int)
end