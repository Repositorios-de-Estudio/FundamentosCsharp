# Fundamentos de C#

Curso: https://www.udemy.com/course/c-sharp-para-principiantes/


## Areas de aplicaicón de C#
- Aplicaciones de escritorio
- Aplicaciones moviles
- Aplicaciones web


## Es compatible con:
- Windows
- Linux
- MacOS

## Caracteristicas:
- Orientado a objetos (paradigma)
- Fuertemente tipado
- Soportar varios paradigmas (imperativo, declarativo, funcional, generico)
- Manejo automatico de memoria
- Funciona junto con Framework .NET,
- Funciona mediante la mv CLR: Common Language Runtime (lo da .NET):
	- Codigo a C# -> codigo CIL (common intermediate language) -> codigo nativo
	- CIL: Administra memoria, seguridad de tipos, manejo de excepciones, recolector, administrador de hilos


# Versiones:
- version 1.0: 2002
- version 11.0: 2022

# Ventajas de usar POO
- Modelo inspirado en objetos reales
- Reuso del codigo
- Facil de mantener


# Variables y Tipos

## Tipos enteros
- `int` -> `System.Int32`
- `short` -> `System.Int16`
- `byte` -> `System.Byte`
- `largo` -> `System.Int64`


## Tipos flotantes
- `float`  -> `System.Single`
- `double` -> `System.Double`
- `decimal` -> `System.Decimal`


## Otros
- `char` -> `System.Char`
- `bool` -> `System.Boolean`
- `string` -> `System.String`



## Operadores ARITMETICOS o Binarios
- Suma: `+ `
- Resta `+`
- Multiplicacion: `* `
- Division: `/`
- Modulo: `%`


# Operadores

## Operadores Unarios
- Incremento: `var++;`
- Decremento: `var--;`

## Operadores Ternario
- ejemplo (if): `variable = value < 0 ? 0: value;`
	- si valor es menor a 0, retorna 0, sino retorna valor, value palabra reservada


# VARIABLES
- `int entero = 100;` //hasta 32bits
- `short sss = 140;` //16bits
- `byte bbb = 10;` // 8bits
- `long largo = 1234567890;` //64bits     
- `float fff = 123.5f;` // siempre debe ir con f, precion single o de un decimal
- `double ddd = 3.14159;` // precision doble o double
- `decimal dec = 129.99m;` // siempre usar m, utlizado para operaciones financieras ideal para calculos
- `char ccc = 'A';`
- `bool boo = true;`
- Arreglos (`arreglo[ ]`)
	- Cacrateristicas:
		- declarar: `int[] arreglo = new int[n];` // n: tamaño
		- declarar: `char[] vocales = {'a','e', 'i', 'o', 'u'};`
		- declarar: `char[] vocales = new char[] {'a','e', 'i', 'o', 'u'};`
		- primer indice: 0
		- ultimo indice: arreglo.Length-1;
		- get: `int var = arreglo[i]`
		- set: `arreglo[i] = var`
		- multimencionales, filas y columnas `matriz[i][j]`
		- los arreglos no pueden cambiar de tamaño, tamaño dinamico usar  ArrayList 

## Operadores de comparacion (retorna booleano)
- Mayor que `>`
- Menor que `<`
- Mayor o igual que `>=`
- Menor o igual que `<=`
- Igual `==`
- Difernete `!=`
             


# ENCAPSULAMIENTO (namespaces)
- Mecanismo para ocultar datos
- Los datos de una clase solo son accesibles a traves de las propiedades y metodos designados
- Garantiza la integridad de los datos que contiene el objeto

# Niveles de acceso
- public: accesible por todos
- internal: todos dentro del mismo ensamblado pueden acceder
- protected:todas las subclases pueden acceder
- private: solo la clase puede acceder


# APUNTES
- Leer datos desde el teclado: `int a = Int.Parse(Console.ReadLine());`
- convertir int a string: `Int.Parse(algo);`
- convertir string a int: `algo.ToString();`
- mostrar en consola: `Console.WriteLine();`
- formato: `string.Format();`



las propiedades de la clase deben ir con Public y nombe empieza con Mayuscula
Los metodos de la clase deben ir con Public seguido del tipo de retorno (void, int,..)

public static : No necesita tener un objeto instanciado para ser usado, los metodos static no pueden modificar directamente las propiedades que no son static
				- es util cuando se necesita tener o hacer algo a todas las instancias por igual

## Visual estudio
- Propiedades aparecen con icono de llave inglesa.
- Metodos aparecen con icono de cubo.
