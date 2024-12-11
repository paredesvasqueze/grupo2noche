create procedure usp_Insertar_Genero
	@cTipoGenero          varchar(50)
as
begin
insert into Genero

(cTipoGenero)
values
(@cTipoGenero)
select cast (SCOPE_IDENTITY() as int)
end