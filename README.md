# App100tifica
Software para registro de estudiantes y selección de algoritmo
Base de dartos: 

# En appConfig debes configurar la cadena de conexion 
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
	<connectionStrings>
		<add name="dataConnex" connectionString="server= .; Integrated Security = yes ; Database = appcientifica"/>
	</connectionStrings>
</configuration>


# base de datos
CREATE DATABASE appcientifica;
GO
USE appcientifica;
GO

CREATE TABLE Estudiantes (
    Matricula INT PRIMARY KEY,          
    nombreE VARCHAR(100) NOT NULL,       
    carreraID NVARCHAR(50) NOT NULL      
);



CREATE TABLE Algoritmos (
    idAlgoritmo INT IDENTITY(1,1) PRIMARY KEY,
    titulo NVARCHAR(255) NOT NULL,
    problema text NOT NULL,
    matricula NVARCHAR(50) NOT NULL,
    complejidad NVARCHAR(50) NOT NULL,
    fechaCreacion DATETIME DEFAULT GETDATE()
);
GO

-- stored procedure

CREATE PROCEDURE SP_INSERTAREst
    @mat INT,
    @nom VARCHAR(100),
    @carrer NVARCHAR(50)
AS
BEGIN
    -- Verificar si la matrícula ya existe antes de insertar
    IF NOT EXISTS (SELECT 1 FROM Estudiantes WHERE Matricula = @mat)
    BEGIN
        INSERT INTO Estudiantes (Matricula, nombreE, carreraID)
        VALUES (@mat, @nom, @carrer);
    END
    ELSE
    BEGIN
        PRINT 'La matrícula ya existe. No se puede insertar.';
    END
END;

-- insert de las tabas en sql server 
--insert

INSERT INTO [dbo].[Algoritmos] ( [titulo], [problema], [matricula], [complejidad], [fechaCreacion])
VALUES 
( 'Determinar si tiene 3 dígitos', 'Leer un número entero y determinar si tiene 3 dígitos.', 'A001', 'Baja', GETDATE()),

( 'Determinar si es negativo', 'Leer un número entero y determinar si es negativo.', 'A002', 'Baja', GETDATE()),

( 'Suma de dígitos', 'Leer un número entero de dos dígitos y determinar a cuánto es igual la suma de sus dígitos.', 'A003', 'Baja', GETDATE()),

( 'Dígitos pares', 'Leer un número entero de dos dígitos y determinar si ambos dígitos son pares.', 'A004', 'Media', GETDATE()),

('Dígitos iguales', 'Leer un número entero de dos dígitos y determinar si los dos dígitos son iguales.', 'A005', 'Media', GETDATE()),

('Determinar mayor de dos números', 'Leer dos números enteros distintos y determinar cuál es el mayor.', 'A006', 'Media', GETDATE()),

('Suma de dos números par', 'Leer dos números enteros de dos dígitos y determinar si la suma de los dos números origina un número par.', 'A007', 'Media', GETDATE()),

('Determinar mayor de tres números', 'Leer tres números enteros y determinar cuál es el mayor.', 'A008', 'Alta', GETDATE()),

('Mostrar números ascendentemente', 'Leer tres números enteros pedidos al usuario y mostrarlos ascendentemente.', 'A009', 'Alta', GETDATE()),

('Determinar si es igual a 10', 'Leer un número entero pedido al usuario y determinar si es igual a 10.', 'A010', 'Baja', GETDATE()),

('Determinar múltiplo de 7', 'Leer un número entero pedido al usuario y determinar si es múltiplo de 7.', 'A011', 'Baja', GETDATE()),

('Termina en 7', 'Leer un número entero y determinar si termina en 7.', 'A012', 'Baja', GETDATE()),

('Cuántos dígitos tiene', 'Leer un número entero menor que mil y determinar cuántos dígitos tiene.', 'A013', 'Media', GETDATE()),

('Mostrar dígitos por separado', 'Leer un número entero de dos dígitos, guardar cada dígito en una variable diferente y mostrarlas.', 'A014', 'Alta', GETDATE()),

('Múltiplo de cuál', 'Leer dos números enteros y determinar cuál es múltiplo de cuál.', 'A015', 'Media', GETDATE()),

('Suma si es par', 'Leer un número entero de 2 dígitos y si es par mostrar en pantalla la suma de sus dígitos.', 'A016', 'Media', GETDATE()),

('Determinar si es par o impar', 'Leer un número entero y si es menor que 100 determinar si es par o impar.', 'A017', 'Baja', GETDATE()),

('Mostrar todos los números entre 1 y N', 'Leer un número entero y mostrar todos los enteros comprendidos entre 1 y el número leído.', 'A018', 'Media', GETDATE()),

('Mostrar pares entre 1 y N', 'Leer un número entero y mostrar todos los pares comprendidos entre 1 y el número leído.', 'A019', 'Media', GETDATE()),

('Mostrar números entre dos números', 'Leer dos números y mostrar todos los enteros comprendidos entre ellos.', 'A020', 'Media', GETDATE()),

('Mostrar terminados en 4', 'Leer dos números y mostrar todos los números terminados en 4 comprendidos entre ellos.', 'A021', 'Alta', GETDATE()),

('Mostrar entre 1 y 100', 'Mostrar en pantalla todos los enteros comprendidos entre 1 y 100.', 'A022', 'Baja', GETDATE()),

('Mostrar pares entre 20 y 200', 'Mostrar en pantalla todos los pares comprendidos entre 20 y 200.', 'A023', 'Media', GETDATE());




--INSERT INTERMEDIO

INSERT INTO [dbo].[AlgoritmoIntermedio] ([titulo], [problema], [matricula], [complejidad])
VALUES 
('Mostrar números entre dígitos', 'Leer un número entero de dos dígitos y mostrar en pantalla todos los enteros comprendidos entre un dígito y otro.', 'B001', 'Media'),

('Tablas de multiplicar', 'Generar todas las tablas de multiplicar del 1 al 10.', 'B002', 'Media'),

('Serie de Fibonacci', 'Cargar un vector de 10 posiciones con los 10 primeros elementos de la serie de Fibonacci y mostrarlo en pantalla.', 'B003', 'Media'),

('Mayor en el vector', 'Leer 10 números enteros, almacenarlos en un vector y determinar en qué posiciones se encuentra el número mayor.', 'B004', 'Media'),

('Números terminados en 4', 'Leer 10 números enteros, almacenarlos en un vector y determinar en qué posiciones se encuentran los números terminados en 4.', 'B005', 'Media'),

('Ordenar vector aleatorio', 'Crear un vector de 10 posiciones con números aleatorios del 1 al 100, ordenarlo ascendentemente y mostrarlo.', 'B006', 'Alta'),

('Repeticiones del mayor', 'Leer 10 números enteros, almacenarlos en un vector y determinar cuántas veces está repetido el mayor.', 'B007', 'Media'),

('Números con menos de 3 dígitos', 'Leer 10 números enteros, almacenarlos en un vector y determinar cuántos números tienen menos de 3 dígitos.', 'B008', 'Media'),

('Promedio en el vector', 'Leer 10 números enteros, almacenarlos en un vector y determinar si el promedio entero de estos datos está almacenado en el vector.', 'B009', 'Alta'),

('Números negativos en el vector', 'Leer 10 números enteros, almacenarlos en un vector y determinar cuántos números negativos hay.', 'B010', 'Media');

