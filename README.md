# Overview
En las siguientes lineas revisaremos las mejoras practicas de **Clean Code & Clean Arquitecture**, además de las **buenas practicas** de la **codificación defensiva** para proteger nuestros desarrollos desde el momento de escribir la primera linea de código

## Contenido
1. [Unit Test](#unit-test) 
## Unit Test
  - Antes de comenzar un proyecto debes instalar los siguientes package
  
    - Lee sobre NUnit [link] (https://nunit.org/) 
    - SonarLint [link](https://www.sonarlint.org/visualstudio/)
    - Coverlet MSBuild para la medición y reportes de Covertura [link](https://www.nuget.org/packages/coverlet.msbuild)
    - ESLint VsCode [link](https://marketplace.visualstudio.com/items?itemName=dbaeumer.vscode-eslint)
    - Proyect de ejemplo [link](https://github.com/MobDevCL/proven-practices-net-core/tree/master/unit%20testing)

¿Qué son los Unit Test?

¿Para qué los usamos?

Cómo crear un proyecto de Unit Test con **NUnit**


## Unit Test in Memory

## Unit Test with Moq

## Implementación y uso de Coverlet en Unit Test

- Visualización reportes de Covertura con plugin de Visual Studio:

    - Instalar plugin de Visual Studio [link](https://marketplace.visualstudio.com/items?itemName=ChrisDexter.RunCoverletReport)
    - Instalar mediante Administrador de paquetes nuget: Coverlet Collector [link](https://www.nuget.org/packages/coverlet.collector) 
    - Instalar mediante Administrador de paquetes nuget: Coverlet MSBuild [link](https://www.nuget.org/packages/coverlet.msbuild)
    - Ir a Herramientas -> Opciones -> Run Coverlet Report -> Cambiar Integration type a MSBuild -> Aceptar
    - Para visualizar reporte ir a Herramientas -> Run Code Coverage

## Estadar de Códificación

Debes utilizar string.empty en vez de ""

_Example:_

usage `string holaMundo = string.Empty;` en vez de `string holaMundo = "";`

Debes usar Any() para las listas en vez de =! null

_Example:_

usage `if(lstCuentas.Any())` en vez de `if(lstCuentas != null) o if(lstCuentas.Count > 0)`


### Nomenclaturas (Naming Conventions) & Estructura de proyectos

- Proyectos
- Procedimientos
- Funciones
- Variables
- Estructura de Proyecto Base

### Uso de Variables y parámetros 

- Los `métodos` no pueden tener más de 5 parámetros de entrada
- Las `variables`


### Formato y Espaciados

- Usa TAB para generar espaciado en el código
- Los comentarios deben estar al mismo nivel del código
  
  Correcto:
  
  `//Comentario`
  
  `string holaMundo = string.empty;`
  
  Incorrecto:
  
  `//Comentario`
  
        `string holaMundo = string.empty;`
 - Evita escribir métodos muy largos, los métodos deben tener entre 10 a 25 lineas de código

### Uso de sentencias en C#

### Procedimientos y Funciones en C#

### Comentarios

### Hablemos de complejidad ciclomatica

### How To: Implementar captura de errores globales

### Estandar de Diseño de APIs

- ¿Que es REST?

Hablaremos de la historia de la computación distribuida: 

- Diseño de URIs
- Verbos
- Diseño de Resultados
- Formato de REsultados
- Hypermedia
- Diseño de Asociaciones
- Diseño de Paginación
- Diseñi de Caching (ETag)
- APIs funcionales
- Versionamiento
- Cross Domain Security
- GraphQL


### Soluction Arquitecture .NET Project

### Clean Arquitecture

### Patrones de Diseño
