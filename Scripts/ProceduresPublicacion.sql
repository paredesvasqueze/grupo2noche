create procedure usp_seleccionar_Publicacion_Todo
as
begin
select * from Publicacion
end


create procedure usp_Eliminar_Publicacion
 @nIdPublicacion       int
as 
begin
Delete from Publicacion
where nIdPublicacion  = @nIdPublicacion  
select CAST(@@ROWCOUNT as int)
end

create procedure usp_Actualizar_Publicacion
    @nIdPublicacion       int,
	@cIdPublicacion       varchar(25),
	@nTipoPublicacion     varchar(30),
	@dFechaRegistro       datetime,
	@cAutor               varchar(200),
	@nIdArea              int
as
begin
update Publicacion set
[cIdPublicacion] = @cIdPublicacion,
[nTipoPublicacion] = @nTipoPublicacion,
[dFechaRegistro] = @dFechaRegistro,
[cAutor] = @cAutor,
[nIdArea] = @nIdArea
where nIdPublicacion = @nIdPublicacion
select CAST(@@ROWCOUNT as int)
end

create procedure usp_Insertar_Publicacion
	@cIdPublicacion       varchar(25),
	@nTipoPublicacion     varchar(30),
	@dFechaRegistro       datetime,
	@cAutor               varchar(200),
	@nIdArea              int
as
begin
insert into Publicacion

(cIdPublicacion, nTipoPublicacion, dFechaRegistro, cAutor, nIdArea)
values
(@cIdPublicacion,@nTipoPublicacion,@dFechaRegistro, @cAutor, @nIdArea)
select cast (SCOPE_IDENTITY() as int)
end