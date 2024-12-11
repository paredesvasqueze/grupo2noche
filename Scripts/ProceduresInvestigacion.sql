create procedure usp_seleccionar_Investigacion_Todo
as
begin
select * from Investigacion
end


create procedure usp_Eliminar_Investigacion
 @nIdInvestigacion     int
as
begin
Delete from Investigacion
where nIdInvestigacion = @nIdInvestigacion 
select CAST(@@ROWCOUNT as int)
end

create procedure usp_Actualizar_Investigacion
    @nIdInvestigacion     int,
	@cTituloInvestigacion varchar(250),
	@dAnioInves           datetime,
	@cInstitucion         varchar(260),
	@cEnlaceAcceso        varchar(200),
	@cResumen             varchar(500),
	@nIdPublicacion       int,
	@cIdPublicacion       varchar(25)
as
begin
update Investigacion set
[cTituloInvestigacion] = @cTituloInvestigacion,
[dAnioInves] = @dAnioInves,
[cInstitucion] = @cInstitucion,
[cEnlaceAcceso] = @cEnlaceAcceso,
[cResumen] = @cResumen,
[nIdPublicacion] = @nIdPublicacion,
[cIdPublicacion] = @cIdPublicacion
where nIdInvestigacion = @nIdInvestigacion
select CAST(@@ROWCOUNT as int)
end

create procedure usp_Insertar_Investigacion
	@cTituloInvestigacion varchar(250),
	@dAnioInves           datetime,
	@cInstitucion         varchar(260),
	@cEnlaceAcceso        varchar(200),
	@cResumen             varchar(500),
	@nIdPublicacion       int,
	@cIdPublicacion       varchar(25)
as
begin
insert into Investigacion

(cTituloInvestigacion, dAnioInves, cInstitucion, cEnlaceAcceso, cResumen, nIdPublicacion, cIdPublicacion)
values
(@cTituloInvestigacion, @dAnioInves, @cInstitucion, @cEnlaceAcceso,	@cResumen,@nIdPublicacion, @cIdPublicacion)
select cast (SCOPE_IDENTITY() as int)
end