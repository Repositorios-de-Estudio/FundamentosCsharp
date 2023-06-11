# Fundamentos de C#

Curso: https://www.udemy.com/course/c-sharp-para-principiantes/
Documentacion C#: https://learn.microsoft.com/es-es/dotnet/

#### Curso Completado, al final se encuentra la especificación del proyecto final

# MIS NOTAS

## Areas de aplicacion de C#
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

# Herencia

## Herencia desde una clase

- Una nueva clase toma los mismos atributos y metodos de otra clase
	- Empleado Hereda de Persona, Empleaso hereda los mismos atributos y metodos de Persona
	- Esto evita declarar atributos y metodos que son comunes con la clase Persona
- La clase principal es llamada _superclase_ y la que hereda es llamada _subclase_
- Cada _subclase_ puede convertirse es una _superclase_  
	- De esta manera se puede tener un arbol de herencia: Animal <- Mamifero <- Felino <- Leon
- C# solo soporta herencia simple, cada clase solo puede heredas de una sola clase
	- 	La herencia multiple se tratar con Interfaces
- Se usa `override` en una sublcase para indicar en C# que se va a sobreescribir un metodo de la subclase: `public override string ToString() { return "";}` 
	- Al usar `override` en un Metodo se puede agregar lo que hace la _superclase_ con `base.Metodo();`
- Se llama al constructor de la _superclase_ con : `base(param1, param2)`
- Herencia sistanxis en C#: 
	- Persona es _superclase__:
	```
		internal class Persona 
		{ 
			// cuerpo clase Persona
			
			public Persona():
			{
				// cuerpo constructor Persona
			}
			
			public virtual void Saludar()
			{
				Console.WriteLine("Hola!!!");
			}
			
		}
	```
	- Empleado hereda de Persona, es _sublcase_
	```
		internal class Empleado : Persona 
		{ 
			// cuerpo clase Empleado
			
			public Empleado(): base(aaa, bbb)
			{
				// cuerpo constructor Empleado
			}
			
			public override void Saludar()
			{
				Console.WriteLine("Hola, Empleado");
			}
		}
	```

## Clase Abstracta
- La clase abstracta puede funcionar si cumple una de estas dos:
	- La clase que hereda implementa todas los metodos y propiedades abstractos
	- Se vuelva así misma una clase abstracta
- Se pueden definir metodos y propiedades abstractos y no abstractos
- Las clases abstractas pueden heredar de otra clase abstracta
- No son instanciables (no se pueden crear objetos)
- Declara metodos que se deben sobreescribir en la clase que herede de esta
	- Se pueden crear metodos no abstractos
- Cuando se tienen varias clases que comparten metodos y propiedades que funcionan diferente
- Se declara `abstracra class` en vez de `class`
- Se usa `virtual` en un metodo de una superclase para indicar en C# que se puede sobreescribir el metodo en una subclase: `public virtual void Metodo() {}`
- Se usa `virtual` en una propiedad de una superclase para indicar en C# que se puede sobreescribir la propiedad en una subclase: `public virtual int Prop {get; set;}`
- Se usa `abstract` en un metodo de una superclase para indicar en C# que SE DEBE sobreescribir el metodo en una subclase: `public abstract void Metodo() {}`
- Se usa `public abstract int Propiedad {get; set};` para denotar que solo se hace la estructura de la propiedad y es inicializa por la clase que herede de esta
	- Por ejemplo si se quiere calcular salario pero cada _subclase_ que lo implementa aplica una formula matematica diferente, uno de `salario*1.1` y otro de `salario*1.5`
	- Esto facilita que al pedir salario retorne el salario para cada caso y no tener que calcularlo en un metodo diferente
	- Esta propiedad no va en el constructor de la _superclase_
	- Se implementa en la _subclase_ con `override` asi: `public override decimal Salario {get (...); set(...);}`
- Se usa `public abstract void MetodoAbs();` para estructurar el metodo que debe implementar la clase que herede esta 
	- No se colocan corchetes, indica que no tiene implementacion
- Se indica la herencia de la clase abstracta asi: `internal class Clase2 : Clase1 { //cuerpo Clase2 }`

## Clase Object
- Todas las clases heredan de Object
- Contiene metodos propios
	- Por ejemplo: `Equals`, `GetHashCode`
- Se deben reescribir las clases, en caso contrario se usa la comparación por referencia
- Cuando se necesita compara una objetos por una de sus propiedades, ej: `Array.Sort()` se debe heredar de `IComparable`
	- Se debe implementar `CompareTo`
- Ejemplo:
	- `Equals`
	```
        public override bool Equals(object obj)
        {
            /* primero se valida que los objetos sea del mismo tipo */

            if (obj == null) return false;

            // se castea obj como persona
            Persona p = obj as Persona;
            if (p == null) return false;

            /* luego se comprueba que sus propiedades tengan el mismo valor */
            return (Nombre == p.Nombre) && (Edad == p.Edad);
        }
	```
	- `GetHashCode`
	```
	    public override int GetHashCode()
        {
            //numero primo
            int hash = 104297;

            // se calcula el hash con otro numero primo y se les suma los hash de las propiedades
            hash = (hash * 103919) + Nombre.GetHashCode();
            hash = (hash * 103919) + Edad.GetHashCode();

            return hash;
        }
	```
	- ``
	```
	    public int CompareTo(Object c2)
        {
            Contacto c3 = (Contacto)c2; // compara el nombre de dos contactos para decidir como ordenarlos
            return this.Nombre.CompareTo(c3.Nombre);
        }
	```

# Poliformismo
- Habilidad de poder realizar operaciones con objetos de distinto tipo
	- ej: objetos distinto tipo TV, auto, Lampara se pueden "Encender"
- Permite crear sistemas escalables
- Objetos de distinto tipo se comportan como uno solo
- Reuso de codigo
- Se aplica con clases, metodos virtual que se reescriben con overrride, new y sealed override

## Interfaces
- Define metodos y propiedades abstractos
- todos los metodos y propiedades son abstractos por defecto
- Todos los metodos y propiedades deben ser abstractos
- Todos los metodos y propiedades deben ser implementados por _subclase_
- No se puede usar `virtual`
- No se debe usar `override` ni `new` en la _subclase_
- Una interfaz es como un molde rigido para una clase
- Una clase puede implementar varias interfaces
- Las interfaces deben empezar con I mayuscula: Interfaz Encendible = IEncencible
- Upcasting: Moldea/castea un objeto del tipo _subclase_ al tipo de una de su _superclase_
	- Array de tipo Mueble, silla de tipo Silla: `array[0]= silla;` // implicitamente se castea a tipo Mueble
- Downcasting: Moldea/castea un objeto del tipo _superclase_ al tipo de una _subclase_
	- Array de tipo Mueble, silla de tipo Silla: `Circulo otraSilla = array[0] as Circulo;`
- Se declara con `interface`
- Implicitamente todos las propiedades y metodos son `interface` para no tener que escribirlo
- Implicitamente todos las propiedades y metodos son `public` para no tener que escribirlo

# Versiones:
- version  1.0: 2002
- version 11.0: 2022

# Ventajas de usar POO
- Modelo inspirado en objetos reales
- Reuso del codigo
- Facil de mantener


# Variables y Tipos

- Asignacion nula: `int variable = null;`

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
- Resta `-`
- Multiplicacion: `* `
- Division: `/`
- Modulo: `%`
- Potencia: `a = Math.Pow(var, n);` // n es la potencia
- Raiz cuadrada: `a = Math.Sqrt(base);`

# Estructuras
- Tipo de dato similar a una clase que permite crear entidades con propiedades y metodos que no requiren de herencia o polimorfismo
- Crear una clase y cambiar de `class` a `struct`
- No se puede definir el constructor vacio, no se debe crear
- Todos los constructores deben llamar al constructor vacio:  `public Vector(double x): this(){....}`
- 

# Operadores

## Operadores Unarios
- Incremento: `var++;`
- Decremento: `var--;`

## Operadores Ternario
- ejemplo (if): `variable = value < 0 ? 0: value;` // condicional if
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
- Listas (`arreglo[ ]`)
	- Cacrateristicas:
		- Declarar: `int[] arreglo = new int[n];` // n: tamaño
		- Declarar: `char[] vocales = {'a','e', 'i', 'o', 'u'};`
		- Declarar: `char[] vocales = new char[] {'a','e', 'i', 'o', 'u'};`
		- Primer indice: 0
		- Ultimo indice: arreglo.Length-1;
		- get: `int var = arreglo[i]`
		- set: `arreglo[i] = var`
		- Multimencionales, filas y columnas `matriz[i][j]`
		- Los arreglos no pueden cambiar de tamaño, tamaño dinamico usar  ArrayList 
- Listas bidimencional:
		- Declarar: `int[ , ] matriz = new int[3, 2] { {0,1 }, {2,3}, {4,5} };`
		- Declarar: `int[ , ] matriz = { {0,1 }, {2,3}, {4,5} };`
		- Declarar: `int[ , ] matriz = new int[3, 2];`
		- Mostrar:		
			- For:
			
```
for (int fila = 0; fila < matriz.GetLength(0); fila++)
{
	for (int colum = 0; colum < matriz.GetLength(1); colum++)
	{
		Console.WriteLine("For anidado [ {0} , {1} ] : {2} ", fila, colum, matriz[fila,colum]);
	}
}
```			
			- Foreach:
			
```
foreach (var item in matriz)
{
	Console.WriteLine("Foreach Matriz [ {0} ]", item);
}
```
		
		
- Clase Array:
	- Declaracion: `ArrayList myAL = new ArrayList();`
	- Copiar arreglo: `Array.Copy(lista, otraLista, longitud);`
	- Invertir arreglo: `Array.Reverse(list);` // no necesita ser asignado a otra lista
	- Ordenar arreglo: `Array.Sort(list);` // ascendente, no necesita ser asignado a otra lista

## Operadores de comparacion (retorna booleano)
- Mayor que `>`
- Menor que `<`
- Mayor o igual que `>=`
- Menor o igual que `<=`
- Igual `==` // comparacion por referencia
- Difernete `!=`

## Operadores Logicos
- AND: `&&`
- OR: `||`
- Negacion: `!`

## Operaciones con cadenas (no mutables)
- Concatenacion: `+`
- Concatenacion: `string.Concat(a,b,c);`
- Tamaño: `var.Length;`
- Todo a mayusculas: `var.ToUpper();` 
- Todo a minusculas: `var.ToLower();` 
- Reemplazar: `var.Replace(string1, string2);`
- Acceder a caracteres: `var[indice];`
- Sub-cadena: `var.Substring(i,j);` //incluyendo, hasta n-1
- Contiene sub cadena: `var.Contains(otroString));` // retorna bool
- Comienza con: `var.StartsWith(otroString);` //retorna bool
- Es vacio o nulo: `string.IsNullOrEmpty(var);`
- Es vacio o nulo o solo contiene caracteres en blanco: `string.IsNullOrWhiteSpace(var));`
- Indice de subcadena: `cadena.IndexOf(otroString);` // retorna -1 o natural

# Condicionales:

## MODIFICADORES
- `Break`: Interrumpe el ciclo y lo termina
- `Continue`: Interrumpe el ciclo en ejecución y continua con la siguiente iteración

## if
```
if (num > 5)
{
	Console.WriteLine("num es mayor que 5");
}
```


## if - else
```
int edad = 23;
if (edad >= 18)
{
	Console.WriteLine("Es mayor de edad");
}
else
{
	Console.WriteLine("Menor de edad");
}
```


## if - else if - else
```
int a = 1;
int b = 6;
if (a > b)
{
	Console.WriteLine("A es mayor que B");
}
else if (a == b)
{
	Console.WriteLine("A es igual que B");
}
else
{
	Console.WriteLine("A es menor que B");
}
```

## switch
```
string codigo = "A1X";
switch (codigo)
{
	case "A1":
		Console.WriteLine("A1");
		break;
	case "A2":
		Console.WriteLine("A2");
		break;
	case "A3":
		Console.WriteLine("A3");
		break;
	default:
		Console.WriteLine("No encontrado");
		break;
}
```

# Bucles

## for
```
for (int i = 0; i < arreglo.Length; i++)
{
	Console.Write(arreglo[i]);
}
```

## while
```
while (k < arreglo.Length)
{
	Console.WriteLine(arreglo[k]);
	k++;
}
```
			
## Do while
```
do
{
	Console.WriteLine(arreglo[j]);
	j++;

} while (j < arreglo.Length);
```

## foreach
```
foreach (var item in arreglo)
{
	Console.WriteLine(item);
}
```

# TIPOS DE REFERENCIA VS TIPOS DE VALOR

- Los Tipos de referencia son Clases
	- Al hacer una asignación creando otro objeto, se crea una referencia al objeto original
	- Al hacer cambios al otro objeto se modifica el objeto original porque usa la referencia
- Los Tipos de valor son Estructuras
	- Al hacer una asignación creando otro objeto, se crea una copia del objeto original
	- Al hacer cambios a la copia no se modifica el objeto original, ya que hace referencia a otro objeto
- Usar una estructura cuando:
	- Son datos simples con pocas propiedades
	- No se necesita herencia


- Clase (referencias)
```
    internal class PuntoRef
    {
	...
	}
```
- Estructura (valores)
```
    internal struct PuntoVal
    {
	...
	}
	
	public PuntoVal(int x, int y): this()
    {
	...
	}
```

## String Builder
- Declaración: `StringBuilder var = new StringBuilder("CADENA");`
- El tamaño crece dinamicamente
- Longitud: `var.Length;`
- Capacidad maxima: `var.Capacity;` // la capacidad es alterada automaticamente o es posible modificarla
- Cambiar capacidad: `var.EnsureCapacity(valor);` // valor: int
- Concatenación (muta): `var.Append(otroString);` // solo se usa un objeto
- Insertar (muta): `cadenaBL.Insert(i,otroString);` // indice int i




# ENCAPSULAMIENTO (namespaces)
- Mecanismo para ocultar datos
- Los datos de una clase solo son accesibles a traves de las propiedades y metodos designados
- Garantiza la integridad de los datos que contiene el objeto
- `using <ruta del archivo>` para importar un metodo o clase de otro archivo

# Niveles de acceso
- `public`: accesible por todos
- `internal`: todos dentro del mismo ensamblado pueden acceder
- `protected`:todas las subclases pueden acceder
- `private`: solo la clase puede acceder
	- variable privada `private int _VAR;` // en mayusculas y guion bajo al inicio del nombre
	- variable constatnte `private const int _VAR;`

## FORMATO TEXTO
- Crear cadena: `string result = string.Format("Aca texto {0}. ", var);`
- Mostrar texto con formato: `Console.Write("Pi: {0:0.0000}", Math.PI);` // ver 1 entero y 4 decimales
- Ajustar espacios a la derecha: `Console.WriteLine("Texto{0, k}",var);`   // ajustar el texto en K espacios como un tabulador
- Ajustar espacios a la izquierda: `Console.WriteLine("Texto{0, -k}",var);`   // ajustar el texto en K espacios como un tabulador
- Formato en Numero: `Console.WriteLine("{0:N}", valor);`
- Formato en Cientifico: `Console.WriteLine("{0:E}", valor);`
- Formato en Moneda: `Console.WriteLine("{0:C}", valor);`
- Formato en Porcentaje: `Console.WriteLine("{0:P}", valor);`
- Formato en Hexa: `Console.WriteLine("{0:X}", valor);  `          

## Fechas
- Declaracion: `DateTime var = new DateTime();` // hay varios constructores
- Fecha y hora actual: `DateTime.Now;`
- Agregar dias: `var.AddDays(valor);` // no muta
- Restar dias: `var.AddDays(-valor);` // no muta
- Restar dos fechas: `var.Subtract(otraVar;`) // no muta

## Numeros aleatorios
- Declaracion: `Random var = new Random();` // sin semilla
- Declaracion: `Random var = new Random(primo);` // con semilla numero primo
- Numero en un intervalo: `var.Next(i, j);` // j no esta incluido, va hasta j-1
- Probabilidad (doble): `var.NextDouble();` // retorna double entre 0 y 1

# Excepciones 

- Bloque Try - catch:
```
try
{
	...
}
catch (Exception ex)
{

	Console.WriteLine("Error Mensaje: " + ex.Message);
}
```

- Bloque Try con varios Catch segun tipo:
```
try
{
	...
}
catch (FormatException exf)
{

	Console.WriteLine("Error de formato: " + exf.Message);
}
catch (DivideByZeroException exd)
{
	Console.WriteLine("La division entre 0 no esta definida: " + exd.Message);
}
```

# APUNTES
- Leer datos desde el teclado: `int a = Int.Parse(Console.ReadLine());`
- Leer datos desde el teclado: `int a = Convert.ToInt32(Console.ReadLine());`
- Convertir string a int: `Int.Parse(var);`
- Convertir int a string: `var.ToString();`
- Mostrar en consola por linea: `Console.WriteLine();`
	- Ejemplo: `Console.WriteLine("Primero: {0}, Segundo: {1}, Tercero: {2}", aaa, bbb, ccc);`
- Mostrar en consola sin saltos de linea: `Console.Write();`
- Formato: `string.Format();`
- Dar formato para que los numeros tengas una cantidad fija (nn.nn): `Console.Write("{0:00.#0}", matriz[i]);`;
- En los atributos de las propiedades`{get (...);` y `{set (...)}` se puede usar `get => blabla;` en vez de `get { return blabla; }`
- Implementar la interfaz `IComparable` para que por ejemplo funcione `Array.Sort();` con cualquier tipo de objeto
- Puede ser mejor opcion usar `List<Clase> var` cuando se necesita ordenar eficientemente.
	- Ejemplo: A la clase Producto se le implementa la interfaz para poder ordenar los productos
	```
	    internal class Producto : IComparable<Producto>
    {
        public string Codigo { get; set; }
        public decimal Precio { get; set; }

        public int CompareTo(Producto other)
        {
            // comprar en base a su precio

            // > 0 es mayor, == 0 son iguales, < -1 es menor

            if (Precio > other.Precio) { return 1; }
            else if (Precio == other.Precio) { return 0; }
            else { return -1;}
        }
    }
	```


las propiedades de la clase deben ir con Public y nombe empieza con Mayuscula
Los metodos de la clase deben ir con Public seguido del tipo de retorno (void, int,..)

public static : No necesita tener un objeto instanciado para ser usado, los metodos static no pueden modificar directamente las propiedades que no son static
				- es util cuando se necesita tener o hacer algo a todas las instancias por igual
- Caracter de espacape para comillas dobles ":
	- `Console.WriteLine("Palabra con \"de\".");` resultado: `Palabra con "de".`
- Las operaciones con cadenas pueden afectar el rendimiento por lo que se deberia usar String Builder
	- Se evita llenar la memoria de objetos innecesarios al modificar un solo objeto
	
- Interfaz vs Clase abstracta/concreta


| Propiedad                                                    | Interfaz (I)                                                                | Clase<br>Abstract /<br>Concreta                                                                                                    |
|--------------------------------------------------------------|-----------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------|
| Herencia                                                     | Si, multiple                                                                | Si, solo simple                                                                                                                    |
| Metodos y Clases                                             | Siempre Abstractos (implementación muy rigida)                              | Concretros o Abstractos (implementacion mas flexible)                                                                              |
| Uso                                                          | Cuando la subclase debe implementa todos y se requiere de Herencia multiple | Cuando la subclase solo implementa algunos atributos y metodos, y la subclase implemnta otros, y no es necesario herencia multiple |
| Uso de virtual y abstract (overrride, new)                   | NO                                                                          | SI                                                                                                                                 |
| Polimorfismo (objetos de distinto tipo con metodos en comun) | NO                                                                          | SI, se puede usar virtual con new, override y sealed overrride                                                                     |

***

## Visual estudio
- Propiedades aparecen con icono de llave inglesa.
- Metodos aparecen con icono de cubo.
- Depuración:
	- Definir brakpoint, click sobre la parte lateral gris mas a la izquierda
	- Boton `Depurar - F5`
		- La parte del codigo que se esta evaluando se sombre
		- En la parte inferior se veran los valores de las variables
		- Controles: 
			- `F11`: por instruccion (para ver linea por linea)
			- `F10`: por metodos
			- `Mayus + F11`: salir por instruccion
		- Colocando el cursor sobre una variable aparece la opcion de fijar su valor en la pantalla
- Comentar tetxo seleccionado: `Ctrl + k + Ctrl + c`
- Descomentar tetxo seleccionado: `Ctrl + k + Ctrl + u`
- Ver snippeds > Click derecho > insertar fragmento de codigo > Visual C# 
- Snipped `Console.WriteLine();` se escribe `cw` y tabulador dos veces
- Snipped `class` genera una clase
- Snipped `prop` propiedad
- Snipped `for` genera for 
- Snipped `foreach` genera for
- Snipped `while` genera for
- Formatear archivo como codigo: `Ctrl + k + Ctrl + D`
- Buscar: `Ctrl + F`
- Reemplazar: `Ctrl + H`
- Documentación: `F1`

***

# PROYECTO FINAL


## PROYECTO FINAL - AGENDA DE CONTACTOS

App de consola que permita:

1. ver contactos
 1.1 orden ascendente por nombre
 1.2 orden descendente por nombre
2. agregar contacto
3. borrar ultimo contacto
4. buscar contacto por nombre
5. salir


Contactos:
- nombre
- telefono
- email


## Consideraciones:
- la agenda puede ser una estructura de almacenamiento con tamaño maximo de 20 elementos
- será necesario poder comprobar instancias de la clase Contacto (sobreescribir los metodos pertinentes de la clase Object y/o implementar interfaz IComparable
- El programa debe tener diseño orientado a objetos (cada clase con un proposito bien definido)

## Cambios propios:
 - Estructura:
	- Clase de contactos: `Clase Contacto`
	- Gestion de Contactos: `Clase Agenda`
	- Interacción con el usuario: `Clase Menu`
 - Validación de datos de entrada: `try() catch()`
 - Propiedad Telefono como `int`
 - Salir del programa con cualquier tecla
 - Uso de `List<Contacto>` en vez de `Array`
 - Uso de animacion de texto para los creditos en `Acerca de...`
 - Proyecto disponible en: ".../40-Proyetco_final-Agenda_de_contactos"
 
***