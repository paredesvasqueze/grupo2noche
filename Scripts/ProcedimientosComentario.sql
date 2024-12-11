create procedure usp_seleccionar_Comentario_Todo
as
begin
select * from Comentario
end


create procedure usp_Eliminar_Comentario
 @nIdComentario       int
as
begin
Delete from Comentario
where nIdComentario  = @nIdComentario 
select CAST(@@ROWCOUNT as int)
end

create procedure usp_Actualizar_Comentario
    @nIdComentario        int,
	@dFechaComentario     datetime,
	@nIdPublicacion       int,
	@cIdPublicacion       varchar(25),
	@nIdUsuario           int,
	@cComentario          varchar(500)
as
begin
update Comentario set
[dFechaComentario] = @dFechaComentario,
[nIdPublicacion] = @nIdPublicacion,
[cIdPublicacion] = @cIdPublicacion,
[nIdUsuario] = @nIdUsuario,
[cComentario] = @cComentario
where nIdComentario = @nIdComentario
select CAST(@@ROWCOUNT as int)
end

create procedure usp_Insertar_Comentario
	@dFechaComentario     datetime,
	@nIdPublicacion       int,
	@cIdPublicacion       varchar(25),
	@nIdUsuario           int,
	@cComentario          varchar(500)
as
begin
insert into Comentario

(dFechaComentario, nIdPublicacion, cIdPublicacion, nIdUsuario, cComentario)
values
(@dFechaComentario, @nIdPublicacion, @cIdPublicacion, @nIdUsuario, @cComentario)
select cast (SCOPE_IDENTITY() as int)
end