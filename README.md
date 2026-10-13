# Neetcode Exercises

Colección de ejercicios de algoritmos y estructuras de datos de NeetCode en C# sobre .NET 9. Actualmente incluye Contains Duplicate, Two Sum, Group Anagrams y Valid Palindrome.

## Requisitos

- .NET SDK 9.0 o una versión posterior compatible con `net9.0`.
- Runtime .NET 9.0 para ejecutar los tests y el Runner.
- Acceso a NuGet para restaurar los paquetes de pruebas.
- Opcional: Visual Studio Code con soporte para C# o cualquier IDE .NET.

## Estructura

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

La solución incluye los tres proyectos. Tanto Runner como el proyecto xUnit referencian la biblioteca mediante `ProjectReference`. Se conservan los nombres de proyectos, assemblies y namespaces existentes; las carpetas agrupan los ejercicios por categoría.

## Compilar y probar

Desde la raíz del repositorio:

```bash
dotnet restore
dotnet build
dotnet test
```

Las pruebas actuales contienen tres casos de Contains Duplicate y un test vacío de la plantilla (`UnitTest1`). No cubren todavía todos los algoritmos.

## Ejecutar el Runner

```bash
dotnet run --project Runner/Runner.csproj
```

Actualmente imprime `Hello, World!`. Para ejecutar un ejercicio manualmente, añade su llamada en `Runner/Program.cs`.

## Añadir un ejercicio

1. Añade la solución en la categoría correspondiente dentro de `src/Neetcode.ArraysHashing/`.
2. Añade sus pruebas en la misma categoría dentro de `tests/Neetcode.ArraysHashing.Tests/`.
3. Ejecuta `dotnet build` y `dotnet test` antes de proponer cambios.

Crea categorías adicionales cuando tengan ejercicios. La licencia, la guía de contribución y las configuraciones de GitHub quedan para una etapa posterior.
