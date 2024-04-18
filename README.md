# Mini Core Ventas

## Descripción.
Este proyecto es un sistema desarrollado con Dotnet 6 para el backend, el cual implementa diversas APIs para la manipulación de datos, junto con React para el frontend, encargado de la presentación de la información. En esencia, el propósito principal del proyecto es calcular la suma total de ventas realizadas por varios vendedores dentro de un intervalo de fechas específico.
 
--- 
### Indice:
1. Introducción
   - Tecnologías utilizadas
   - Paquetes utilizados
   - ¿Como correr el proyecto?
2. Implementación del backend
3. Implementación del frontend
4. Video Explicativo de la solucion en YouTube
5. Link Deploy

---

## Introducción
### Tecnologías utilizadas:
Para la implementación de este proyecto, se empleó Dotnet 6 en la creación del backend del mini core. En cuanto al frontend, se utilizó React versión 18.0.2. Adicionalmente, el despliegue del proyecto se realizó a través de Netlify. Cabe destacar que el proyecto hace uso de una base de datos SQL local.


### Paquetes:
Backend:
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.VisualStudio.Web.CodeGeneration.Design
- Swashbuckle.AspNetCore

Frontend:
- Axios

### ¿Como correr el proyecto?
Para ejecutar el proyecto, el primer paso es crear una base de datos local SQL utilizando la información proporcionada en los modelos. Se recomienda utilizar el Query adjunto como guía para esta tarea. Una vez creada la base de datos, se procede a establecer una cadena de conexión para permitir el almacenamiento de información en ella. Posteriormente, se debe implementar y ejecutar tanto el backend como el frontend del sistema, y desplegarlos utilizando una plataforma de preferencia, como Netlify en este caso. Es importante verificar que los APIs estén en funcionamiento antes de ejecutar el backend, asegurándose de que todo opere con normalidad y sin inconvenientes.

[Link a Query](https://github.com/CHACHO617/MiniCoreApi-Backend/blob/main/QueryMinicoreVentas.sql)

---
## Implementación del backend:
La implementación del backend de este sistema se compone principalmente de APIs y la lógica necesaria para procesar los datos y generar resultados. Estos procesos se ejecutan en el backend de la aplicación, permitiendo que el frontend en React se encargue exclusivamente de mostrar la información calculada

[Repositorio del Backend en GitHub](https://github.com/CHACHO617/MiniCoreApi-Backend)


---
## Implementacion del frontend:
En el frontend, se estructura creando dos carpetas adicionales dentro de la carpeta 'src'. La primera carpeta, llamada 'servicios', emplea Axios para realizar llamadas a las APIs y obtener la información necesaria. Por otro lado, la segunda carpeta contiene los componentes de la aplicación, donde se realiza el mapeo de los datos y se devuelve el componente correspondiente para que se muestre en la interfaz de usuario (UI).

[Repositorio del Frontend en GitHub](https://github.com/CHACHO617/minicore-front)


## Video Explicativo de la solucion en YouTube: 
[Video en YouTube](https://youtu.be/dDBVw5zAxzc)

## Link Deploy
[Link Deploy](https://main--minicoreventas.netlify.app/)
![image](https://github.com/CHACHO617/MiniCoreApi-Backend/assets/135248701/34f0d105-b0ec-456f-a9b5-51250c9fdcfe)


