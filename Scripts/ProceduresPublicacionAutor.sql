create procedure usp_seleccionar_PublicacionAutor_Todo
as
begin
select * from PublicacionAutor
end


create procedure usp_Eliminar_PublicacionAutor
 @nIdPublicacionAutor  char(18)
as
begin
Delete from PublicacionAutor
where nIdPublicacionAutor  = @nIdPublicacionAutor  
select CAST(@@ROWCOUNT as int)
end

create procedure usp_Actualizar_PublicacionAutor
    @nIdPublicacionAutor  char(18),
	@nIdPublicacion       int,
	@cIdPublicacion       varchar(25),
	@nIdAutor             int   

as
begin
update PublicacionAutor set
[nIdPublicacion] = @nIdPublicacion,
[cIdPublicacion] = @cIdPublicacion,
[nIdAutor] = @nIdAutor
where nIdPublicacionAutor = @nIdPublicacionAutor
select CAST(@@ROWCOUNT as int)
end

create procedure usp_Insertar_PublicacionAutor
	@nIdPublicacion       int,
	@cIdPublicacion       varchar(25),
	@nIdAutor             int 
as
begin
insert into PublicacionAutor

(nIdPublicacion,cIdPublicacion,nIdAutor)
values
(@nIdPublicacion, @cIdPublicacion, @nIdAutor)
select cast (SCOPE_IDENTITY() as int)
end