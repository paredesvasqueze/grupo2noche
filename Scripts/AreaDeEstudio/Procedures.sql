create procedure usp_seleccionar_AreaDeEstudio_Todo
as
begin
select * from AreaDeEstudio
end


create procedure usp_Eliminar_AreaDeEstudio
 @nIdArea             int
as
begin
Delete from AreaDeEstudio
where nIdArea = @nIdArea 
select CAST(@@ROWCOUNT as int)
end

create procedure usp_Actualizar_AreaDeEstudio
    @nIdArea             int,
	@cAreadeEstudio       varchar(50),
	@cDescripcion         varchar(500),
	@cImagen              varchar(300)
as
begin
update AreaDeEstudio set
[cAreadeEstudio] = @cAreadeEstudio,
[cDescripcion] = @cDescripcion,
[cImagen] = @cImagen
where nIdArea = @nIdArea
select CAST(@@ROWCOUNT as int)
end

create procedure usp_Insertar_AreaDeEstudio
	@cAreadeEstudio       varchar(50),
	@cDescripcion         varchar(500),
	@cImagen              varchar(300)
as
begin
insert into AreaDeEstudio

(cAreadeEstudio,cDescripcion,cImagen)
values
(@cAreadeEstudio, @cDescripcion, @cImagen)
select cast (SCOPE_IDENTITY() as int)
end