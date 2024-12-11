create procedure usp_eliminar_Articulo
@nIdArticulo int
as
begin
Delete from Articulo
where nIdArticulo = @nIdArticulo
select CAST(@@ROWCOUNT as int)
end