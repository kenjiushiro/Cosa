localhost/phpmyadmin

utf8_spanish2_ci

--el id se setea autoincrementable tildando la opcion A_I

--Insertar varios rows 
INSERT INTO `alumnos`(`nombre`, `apellido`, `legajo`, `foto`) VALUES ('jorgito','perez',170312,'fotito.jpg'),('jorgito','perez',170312,'fotito.jpg'),('jorgito','perez',170312,'fotito.jpg'),('jorgito','perez',170312,'fotito.jpg'),('jorgito','perez',170312,'fotito.jpg'),('jorgito','perez',170312,'fotito.jpg'),('jorgito','perez',170312,'fotito.jpg'),('jorgito','perez',170312,'fotito.jpg')

--trae tabla entera
SELECT * FROM alumnos

--trae algunas columnas
SELECT nombre,legajo FROM alumnos

--WHERE legajo = 107330 restringe segun legajo
SELECT nombre,legajo FROM alumnos WHERE legajo = 107330

--ordenar
ORDER BY id DESC

--updatear rows
UPDATE 'alumnos' SET nombre = "josesito" WHERE id = 3

--borrar rows
DELETE FROM alumnos WHERE id = 4


INSERT INTO `alumnos`(`nombre`, `apellido`, `legajo`, `foto`) VALUES ('Pepe','Lopez',155274,'fotopepe.jpg'),('Jorgito','Perez',633274,'fotojorgito.jpg'),('Juanito','Ramirez',412543,'fotojuanito.jpg'),('Pedra','Peraz',141234,'fotopedra.jpg'),('Lele','Redreguez',623312,'fotolele.jpg')


--Si hay una sola materia
--agrego columna materia a alumnos(id,nombre,apellido,legajo,foto,materia(Foreign key))
--la foreign key de una tabla se linkea con la primary key de otra tabla (si la relacion es uno a uno, o uno a muchos)
--tabla materias (id (Primary key), nombre, cuatri, cupos ) 

--Si hay una cantidad indefinida de materias
--agrego columna materia a alumnos(id,nombre,apellido,legajo,foto,materia(Foreign key))
--la foreign key de una tabla se linkea con la primary key de otra tabla (si la relacion es uno a uno, o uno a muchos)
--tabla intermedia(id_alumno,id_materia,otra_clave_para_hacerla_unica)
--(para linkear muchas materias con muchos alumnos)
-- afafs
--tabla materias (id (Primary key), nombre, cuatri, cupos ) 
--

--Traigo todos los alumnos de la tabla alumnos, linkeado con su materia
SELECT *
--Seteo alias 'a' a la tabla alumnos
FROM alumnos a
--Joineo con la tabla materias (alias 'm') ON: columna por la que matcheo 
INNER JOIN materias m ON a.materia = m.id

--Traigo nombre, apellido y materia que cursa
SELECT a.nombre,a.apellido,m.nombre
FROM alumnos a
INNER JOIN materias m ON a.materia = m.id

INSERT INTO `alumno_materias`(`id_alumno`, `id_materia`, `anio`) VALUES (10,1,2019),(10,2,2019),(10,3,2019),(11,1,2019),(11,4,2019),(11,2,2019),(12,4,2019),(12,1,2019),(12,2,2019),(13,4,2019),(13,2,2019),(13,3,2019),(14,1,2019),(14,4,2019),(14,2,2019),(15,6,2019),(15,2,2019),(15,1,2019),(16,4,2019),(16,5,2019),(16,3,2019),(17,1,2019),(17,4,2019),(17,2,2019),(18,4,2019),(18,1,2019),(18,3,2019)

--Doble join (tabla alumnos con tabla alumno_materias y tabla alumno_materias con tabla materias)
SELECT a.nombre,a.apellido,m.nombre
FROM alumnos a
INNER JOIN alumno_materias am ON a.id = am.id_alumno INNER JOIN materias m ON am.id_materia = m.id


--TP
--1.
SELECT * FROM `productos` ORDER BY productos.pNombre ASC
--2.
SELECT * FROM `proveedores` WHERE proveedores.Localidad = "Quilmes"
--3.
SELECT * FROM `envios` WHERE Cantidad >= 200 AND Cantidad <= 300
--4.
SELECT SUM(envios.Cantidad) FROM `envios`
--5.
SELECT productos.pNombre FROM `envios` INNER JOIN productos ON envios.pNumero = productos.pNumero LIMIT 3
--6.
SELECT proveedores.Nombre,productos.pNombre FROM envios INNER JOIN proveedores ON envios.Numero = proveedores.Numero INNER JOIN productos ON envios.pNumero = productos.pNumero
--7.
SELECT (envios.Cantidad*productos.Precio) as PrecioTotal FROM envios INNER JOIN productos ON envios.pNumero = productos.pNumero
--8.
SELECT SUM(envios.Cantidad) as TotalEnviado FROM envios INNER JOIN proveedores ON envios.Numero = proveedores.Numero INNER JOIN productos ON envios.pNumero = productos.pNumero WHERE proveedores.Numero = 102 AND productos.pNumero = 1
--9.
SELECT productos.pNumero FROM `productos` INNER JOIN envios ON productos.pNumero = envios.pNumero INNER JOIN proveedores ON proveedores.Numero = envios.Numero WHERE proveedores.Localidad = "Avellaneda"
--10.
SELECT Domicilio,Localidad FROM `proveedores` WHERE Nombre LIKE '%i%'
--11.
INSERT INTO `productos`(`pNumero`, `pNombre`, `Precio`, `Tamaño`) VALUES (4,"Chocolate",25.35,"Chico")
--12.
INSERT INTO `proveedores`() VALUES ()
--13.
INSERT INTO `proveedores`(`Numero`, `Nombre`, `Localidad`) VALUES (107,"Rosales","La Plata")
--14.
UPDATE `productos` SET Precio=97.5 WHERE Tamaño = "Grande"
--15.
UPDATE `productos` INNER JOIN envios ON productos.pNumero = envios.pNumero SET `Tamaño`='Mediano'  WHERE productos.Tamaño = "Chico" AND envios.Cantidad >= 300
--16.
DELETE FROM `productos` WHERE pNumero = 1
--17.
NO FUNKA
SELECT proveedores.Numero INNER JOIN envios ON proveedores.Numero = envios.Numero FROM `proveedores` WHERE proveedores.Numero IN (SELECT envios.Numero)