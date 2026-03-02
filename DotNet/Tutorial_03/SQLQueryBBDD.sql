/* =========================================================
   SCRIPT MAESTRO — BIBLIOTECA (INCLUYE VENTAS)
   ========================================================= */

-- 1️⃣ Crear BD si no existe
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'Biblioteca')
BEGIN
    CREATE DATABASE Biblioteca
END
GO

USE Biblioteca
GO

/* =========================================================
   LIMPIEZA
   ========================================================= */

-- Eliminar FKs primero
ALTER TABLE dbo.Ventas DROP CONSTRAINT IF EXISTS FK_Ventas_LibrosUnidades
ALTER TABLE dbo.LibrosUnidades DROP CONSTRAINT IF EXISTS FK_LibrosUnidades_Libros
ALTER TABLE dbo.LibrosUnidades DROP CONSTRAINT IF EXISTS FK_LibrosUnidades_Ubicaciones
ALTER TABLE dbo.Libros DROP CONSTRAINT IF EXISTS FK_Libros_Categorias
GO

-- Eliminar tablas si existen
DROP TABLE IF EXISTS dbo.Ventas
DROP TABLE IF EXISTS dbo.LibrosUnidades
DROP TABLE IF EXISTS dbo.Libros
DROP TABLE IF EXISTS dbo.Categorias
DROP TABLE IF EXISTS dbo.Ubicaciones
GO

/* =========================================================
   TABLAS
   ========================================================= */

CREATE TABLE dbo.Categorias(
	idCategoria INT NOT NULL,
	Nombre NVARCHAR(100) NOT NULL,
	CONSTRAINT PK_Categorias PRIMARY KEY CLUSTERED (idCategoria)
)
GO

CREATE TABLE dbo.Ubicaciones(
	idUbicacion INT NOT NULL,
	Nombre NVARCHAR(100) NOT NULL,
	CONSTRAINT PK_Ubicaciones PRIMARY KEY CLUSTERED (idUbicacion)
)
GO

CREATE TABLE dbo.Libros(
	idLibro INT IDENTITY(1,1) PRIMARY KEY,
	idCategoria INT NOT NULL,
	Nombre NVARCHAR(100) NOT NULL,
	Autor NVARCHAR(100) NOT NULL,
	FechaPublicacion DATETIME NOT NULL
)
GO

CREATE TABLE dbo.LibrosUnidades(
	idLibroUnidades INT IDENTITY(1,1) PRIMARY KEY,
	idLibro INT NOT NULL,
	idUbicacion INT NOT NULL,
	Codigo NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE dbo.Ventas(
	idVenta INT IDENTITY(1,1) PRIMARY KEY,
	idLibroUnidades INT NOT NULL,
	FechaVenta DATETIME NOT NULL,
	NombreCliente NVARCHAR(100) NOT NULL,
	Precio DECIMAL(16,2) NOT NULL
)
GO

/* =========================================================
   DATOS BASE
   ========================================================= */

-- Categorias
INSERT INTO dbo.Categorias (idCategoria, Nombre)
VALUES
(1, N'Comedia'),
(2, N'Drama'),
(3, N'Juvenil')
GO

-- Ubicaciones
INSERT INTO dbo.Ubicaciones (idUbicacion, Nombre)
VALUES
(1, N'Sevilla'),
(2, N'Cadiz')
GO

-- Libros
INSERT INTO dbo.Libros (idCategoria, Nombre, Autor, FechaPublicacion)
VALUES
(1, N'Citas del presidente', N'de MAO', '2019-10-07'),
(3, N'Harry potter', N'Rowling', '2018-06-01'),
(3, N'El alquimista', N'de paulo', '2018-05-02')
GO

-- LibrosUnidades
INSERT INTO dbo.LibrosUnidades (idLibro, idUbicacion, Codigo)
VALUES
(1, 1, N'EJEMPLO'),
(1, 2, N'EJEMPLO2'),
(3, 1, N'EJEMPLO3')
GO

-- Ventas: aún sin datos
-- INSERT INTO dbo.Ventas (...) VALUES (...)  -- Opcional
GO

/* =========================================================
   FOREIGN KEYS
   ========================================================= */

ALTER TABLE dbo.Libros ADD CONSTRAINT FK_Libros_Categorias
FOREIGN KEY (idCategoria)
REFERENCES dbo.Categorias(idCategoria)
GO

ALTER TABLE dbo.LibrosUnidades ADD CONSTRAINT FK_LibrosUnidades_Libros
FOREIGN KEY (idLibro) REFERENCES dbo.Libros(idLibro)
GO

ALTER TABLE dbo.LibrosUnidades ADD CONSTRAINT FK_LibrosUnidades_Ubicaciones
FOREIGN KEY (idUbicacion) REFERENCES dbo.Ubicaciones(idUbicacion)
GO

ALTER TABLE dbo.Ventas ADD CONSTRAINT FK_Ventas_LibrosUnidades
FOREIGN KEY (idLibroUnidades) REFERENCES dbo.LibrosUnidades(idLibroUnidades)
GO