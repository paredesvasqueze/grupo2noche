create procedure usp_actualizar_Articulo
    @nIdArticulo          int,
	@cTituloArticulo      varchar(50),
	@dFechaArticulo       datetime,
	@cTexto               varchar(500),
	@nVolumen             char(18),
	@nIdPublicacion       int,
	@cIdPublicacion       varchar(25) 
as
begin
update Articulo set
[cTituloArticulo] = @cTituloArticulo,
[dFechaArticulo] = @dFechaArticulo,
[cTexto] = @cTexto,
[nVolumen]= @nVolumen,
[nIdPublicacion]= @nIdPublicacion,
[cIdPublicacion]= @cIdPublicacion
where nIdArticulo = @nIdArticulo
select CAST(@@ROWCOUNT as int)
end