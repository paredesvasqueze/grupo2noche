create procedure usp_seleccionar_Libro_Todo
as
begin
select * from Libro
end


create procedure usp_Eliminar_Libro
 @nIdLibro                 int
as
begin
Delete from Libro
where nIdLibro = @nIdLibro 
select CAST(@@ROWCOUNT as int)
end

create procedure usp_Actualizar_Libro
    @nIdLibro             int,
	@cTituloLibro         varchar,
	@cEditorial           varchar(100),
	@nPaginas             int,
	@cIdioma              varchar(20),
	@nIdGenero            int,
	@nIdPublicacion       int,
	@cIdPublicacion       varchar(25) 

as
begin
update Libro set
[cTituloLibro] = @cTituloLibro,
[cEditorial] = @cEditorial,
[nPaginas] = @nPaginas,
[cIdioma] = @cIdioma,
[nIdGenero] = @nIdGenero,
[nIdPublicacion] = @nIdPublicacion,
[cIdPublicacion] = @cIdPublicacion 


where nIdLibro = @nIdLibro 
select CAST(@@ROWCOUNT as int)
end

create procedure usp_Insertar_Libro
	@cTituloLibro         varchar,
	@cEditorial           varchar(100),
	@nPaginas             int,
	@cIdioma              varchar(20),
	@nIdGenero            int,
	@nIdPublicacion       int,
	@cIdPublicacion       varchar(25)  
as
begin
insert into Libro

(cTituloLibro, cEditorial, nPaginas, cIdioma, nIdGenero, nIdPublicacion, cIdPublicacion)
values
(@cTituloLibro, @cEditorial, @nPaginas, @cIdioma, @nIdGenero, @nIdPublicacion, @cIdPublicacion)
select cast (SCOPE_IDENTITY() as int)
end