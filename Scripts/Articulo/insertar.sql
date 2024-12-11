create procedure usp_insertar_Articulo
    @cTituloArticulo      varchar(50),
	@dFechaArticulo       datetime,
	@cTexto               varchar(500),
	@nVolumen             char(18),
	@nIdPublicacion       int ,
	@cIdPublicacion       varchar(25) 
as
begin
insert into Articulo

(cTituloArticulo , dFechaArticulo, cTexto, nVolumen, nIdPublicacion, cIdPublicacion)
values
(@cTituloArticulo , @dFechaArticulo, @cTexto, @nVolumen, @nIdPublicacion, @cIdPublicacion)
select cast (SCOPE_IDENTITY() as int)
end