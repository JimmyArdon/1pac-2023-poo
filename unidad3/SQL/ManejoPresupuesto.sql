INSERT INTO TiposCuenta
(Nombre, UsuarioId, Orden)
VALUES
(@Nombre, @UsuarioId, @Orden);
SELECT SCOPE_IDENTITY();

SELECT * FROM Usuarios

SELECT 1
FROM TiposCuenta
WHERE Nombre = @Nombre AND UsuarioId = @UsuarioId
--WHERE Nombre = 'Préstamos' AND UsuarioId = 1

-- Obtener los tipos de cuenta que pertenecen a un usuario
SELECT Id, Nombre, Orden
FROM TiposCuenta
--WHERE UsuarioId = @UsuarioId
WHERE UsuarioId = 1

-- Editar un tipo de cuenta
UPDATE TiposCuenta
SET Nombre = @Nombre
WHERE Id = @Id

-- Obtener tipo de cuenta por usuarioId
SELECT Id, Nombre, Orden
FROM TiposCuenta
WHERE Id = @Id AND UsuarioId = @UsuarioId