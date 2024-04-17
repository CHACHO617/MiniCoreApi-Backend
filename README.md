# Mini Core Ventas

## Descripción.
Este proyecto es un sistema desarrollado con Dotnet 6 para el backend, el cual implementa diversas APIs para la manipulación de datos, junto con React para el frontend, encargado de la presentación de la información. En esencia, el propósito principal del proyecto es calcular la suma total de ventas realizadas por varios vendedores dentro de un intervalo de fechas específico.
 
--- 
### Indice:
1. Introducción
   - Tecnologías utilizadas
   - Paquetes utilizados
   - ¿Como correr el proyecto?
2. Implementación del backend:
3. Implementación del frontend:
---

## Introducción
### Tecnologías utilizadas:
Para la implementacion del presente proyecto se utilizo Dotnet 6 para crear el backend del mini core y por otro lado se utilizó la version 18.0.2 de React para la implementacion del frontend. Por otro lado el proyecto tambien fue deployado utilizando Netlify y utiliza una base de datos a nivel local. 


### Paquetes:
-


### ¿Como correr el proyecto?
Como tal para ejecutar el proyecto se debe crear una base de datos a nivel local con la informacion que se muestra en los modelos (se recomienda utilizar el query adjunto ___) para crear la base de datos a nivel local
Luego se debe realizar una cadena de conexion a la base de datos; por consiguiente se podra almacenar informacion en ella. Por otro lado tambien se deberá implementar y correr tanto el backend como el frontend del sistema y deployarlo utilzando un software de preferencia (en este caso Netlify). Una vez que se tengan corriendo correctammente los APIs y se pueda acceder a la informacion se debe verificar que este corriendo el API primero para luego correr el backend y que todo ejecute con normalidad y sin problemas

---
## Implementación del backend:
Como tal la implmentacion del backend de este sistema consta de APIs, ademas de la logica que se realiza para poder tomar datos y dar un resultado. Estos proceos como tal se realzan en el backend de la aplicacion permitiendo que las vistas o el front end en React unicamente muestre la informacaion que se ha calculado

---
## Implementacion del frontend:
El frontend se basa en crear dentro de la carpeta src 2 carpetas extras. La primera carpeta llamada servicios utiliza axios para hacer llamadas a las apis y obtener la informacion necesaria. Por otro lado la segunda carpeta hace referencia a componentes de la aplcacion, donde se debe mapear los datos y  devolver el componente para que sea msotrado el UI.
