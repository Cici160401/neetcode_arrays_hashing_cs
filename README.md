# Neetcode Exercises

Colección educativa de ejercicios de algoritmos y estructuras de datos implementados en C# y .NET 9. Este repositorio documenta un proceso de aprendizaje a través de problemas de NeetCode y establece una base para futuras contribuciones de la comunidad.

Las soluciones se encuentran en una biblioteca reutilizable, las pruebas en un proyecto independiente con xUnit y los ejemplos manuales en una aplicación de consola. El proyecto está en desarrollo: algunas soluciones todavía no cuentan con pruebas.

## Tecnologías

- **C#** para implementar los algoritmos.
- **.NET 9** (`net9.0`) en los tres proyectos.
- **xUnit** para las pruebas unitarias, junto con Microsoft.NET.Test.Sdk y el ejecutor de pruebas de Visual Studio.
- **Coverlet collector**, incluido en el proyecto de pruebas para recopilar cobertura de forma opcional.

## Objetivos educativos

- Practicar la resolución de problemas con arreglos, tablas hash, cadenas y otras estructuras de datos.
- Comprender la corrección de los algoritmos y su complejidad temporal y espacial.
- Comparar implementaciones iniciales con alternativas más eficientes.
- Desarrollar pruebas unitarias útiles que incluyan casos límite.
- Practicar la organización de proyectos mantenibles y el desarrollo colaborativo.

## Estructura del repositorio

```text
/
├── src/
│   └── Neetcode.ArraysHashing/
│       ├── Neetcode.ArraysHashing.csproj
│       ├── ArraysHashing/
│       │   ├── Contains_Duplicate.cs
│       │   ├── Group_Anagrams.cs
│       │   └── TwoSum.cs
│       └── TwoPointers/
│           └── Valid_Palindrome.cs
├── tests/
│   └── Neetcode.ArraysHashing.Tests/
│       ├── Neetcode.ArraysHashing.Tests.csproj
│       ├── ArraysHashing/
│       │   └── ContainsDuplicateTests.cs
│       └── UnitTest1.cs
├── Runner/
│   ├── Runner.csproj
│   └── Program.cs
├── .gitignore
├── README.md
└── NeetcodeArraysHashing.sln
```

`NeetcodeArraysHashing.sln` agrupa los tres proyectos. Tanto el proyecto de pruebas como Runner referencian la biblioteca `Neetcode.ArraysHashing`. Las carpetas organizan los ejercicios por categoría y conservan los nombres actuales de proyectos y namespaces.

## Requisitos

- **SDK de .NET 9**, o un SDK posterior compatible con `net9.0`.
- **Runtime de .NET 9** para ejecutar las pruebas y Runner. El SDK de .NET 9 incluye este runtime.
- Acceso a Internet para restaurar los paquetes desde NuGet por primera vez.
- Git si se desea clonar el repositorio.
- Opcional: Visual Studio Code con soporte para C# u otro IDE compatible con .NET.

## Instalación y ejecución

Clona este repositorio mediante su URL de GitHub o descarga y extrae el código fuente. Abre una terminal en la raíz del repositorio, donde se encuentra `NeetcodeArraysHashing.sln`.

Restaura las dependencias y compila la solución:

```bash
dotnet restore
dotnet build
```

Ejecuta las pruebas:

```bash
dotnet test
```

Ejecuta la aplicación de consola:

```bash
dotnet run --project Runner/Runner.csproj
```

Actualmente, Runner imprime `Hello, World!`. Para experimentar con un algoritmo, añade una llamada en `Runner/Program.cs`.

## Progreso de los ejercicios

«Implementada» indica que existe una solución en el repositorio; no implica cobertura completa de pruebas ni validación de todos los casos de entrada.

| Categoría | Ejercicio | Solución | Pruebas unitarias |
| --- | --- | --- | --- |
| Arrays & Hashing | Contains Duplicate | [Implementada](src/Neetcode.ArraysHashing/ArraysHashing/Contains_Duplicate.cs) — `ContainsDuplicateSolution.ContainsDuplicate` | [Implementadas](tests/Neetcode.ArraysHashing.Tests/ArraysHashing/ContainsDuplicateTests.cs) — tres casos parametrizados |
| Arrays & Hashing | Two Sum | [Implementada](src/Neetcode.ArraysHashing/ArraysHashing/TwoSum.cs) — `Class1.TwoSum` | Pendientes |
| Arrays & Hashing | Group Anagrams | [Implementada](src/Neetcode.ArraysHashing/ArraysHashing/Group_Anagrams.cs) — `GroupAnagramsSolution.GroupAnagrams` | Pendientes |
| Two Pointers | Valid Palindrome | [Implementada](src/Neetcode.ArraysHashing/TwoPointers/Valid_Palindrome.cs) — `IsPalindromeSolution.IsPalindrome` | Pendientes |

`UnitTest1.cs` contiene una prueba vacía de la plantilla y no valida ningún ejercicio. Valid Palindrome está organizado en la categoría Two Pointers, aunque su implementación actual construye una cadena filtrada y la compara con su versión invertida.

Entre las revisiones pendientes están el límite del bucle de Two Sum (`i <= nums.Length`), que puede acceder fuera del arreglo cuando no se encuentra una pareja, y la concatenación repetida de cadenas en Valid Palindrome.

## Contribuciones de la comunidad

Las contribuciones son bienvenidas a medida que evoluciona el proyecto. Algunas oportunidades iniciales son añadir pruebas, corregir errores con casos que los reproduzcan, explicar la complejidad de las soluciones e incorporar nuevos ejercicios.

Para proponer una contribución:

1. Abre un issue para describir un error o discutir un cambio de mayor alcance.
2. Crea un fork del repositorio y una rama dedicada a tu cambio.
3. Coloca las soluciones en la categoría correspondiente dentro de `src/Neetcode.ArraysHashing/` y sus pruebas en la misma categoría dentro de `tests/Neetcode.ArraysHashing.Tests/`.
4. Conserva las APIs públicas existentes salvo que el cambio se haya discutido explícitamente. Explica cualquier modificación de comportamiento o del algoritmo.
5. Ejecuta `dotnet build` y `dotnet test`. Actualiza la tabla de progreso cuando corresponda.
6. Envía un pull request que explique el cambio y cómo lo verificaste.

Todavía no se han incorporado una guía de contribución independiente ni una licencia open source. La elección de la licencia forma parte de la evolución prevista.

## Hoja de ruta

- Ampliar las pruebas de los ejercicios actuales, incluyendo casos límite, y sustituir la prueba vacía por cobertura útil.
- Revisar la corrección de los algoritmos y documentar su complejidad temporal y espacial.
- Incorporar progresivamente ejercicios y categorías como Stack y Binary Search.
- Añadir notas sobre los problemas y ejemplos manuales en Runner.
- Elegir una licencia y añadir una guía de contribución y plantillas de issues de GitHub.
- Incorporar un flujo básico de compilación y pruebas cuando se establezca el proceso de contribución.
