# Employee management
### Aplicación web para la administración de empleados integrando .NET y Vue.js con el framework MVC.
![Screenshot 2023-10-02 182624](https://github.com/AndresMoreta20/management/assets/61909582/650a4e56-dbed-4dcc-ab7e-9d17e85e69ac)

### Introducción al modelo MVC
Model-View-Controller, comúnmente conocido como MVC, es un patrón de diseño arquitectónico ampliamente utilizado en el desarrollo de aplicaciones de software. Este modelo se ha convertido en un estándar de la industria debido a su capacidad para separar y organizar de manera efectiva diferentes responsabilidades de aplicaciones, lo que facilita la construcción, el mantenimiento y la escala de sistemas de software complejos.

MVC divide la aplicación en tres componentes interconectados, cada uno con una función específica:

Modelo:
El modelo representa los datos y la lógica empresarial de la aplicación. Es decir, es la capa encargada de gestionar y almacenar datos y realizar operaciones sobre ellos. Esta parte del sistema no está directamente vinculada a la interfaz de usuario y funciona de forma independiente. 
Vista:
La vista es responsable de presentar información al usuario final. Este componente se ocupa de cómo se muestran los datos al usuario y cómo el usuario interactúa  con la GUI. En otras palabras, esta es la capa de presentación.
Controlador:
El controlador actúa como intermediario entre el modelo y la vista. Gestiona las solicitudes de los usuarios, interpreta sus acciones y coordina las interacciones entre modelos y vistas. Es responsable de tomar decisiones basadas en las entradas del usuario y  actualizar el modelo o vista según sea necesario

### Arcquitectura del proyecto.
![mvc](https://github.com/AndresMoreta20/management/assets/61909582/43345826-344b-49e7-b4b4-3684eb4fbe0c)
La aplicación web está desarrollada basada en el framework MVC, se parte desde los componentes propios del backend de la aplicación desarrollados en .NET con C#. 
El modelo corresponde a las clases y estructuras de datos a partir de las cuales se crean las tablas de la base de datos, para el proyecto por el momento se usa una sola clase empleado.
El controlador se refiere a los componentes que definen que parte de la aplicación se presentará al usuario dependiendo de la interacción del usuario. Aqui se definen también los métodos para realizar las operaciones crud en la api. 
Las vistas están conformadas por las interfaces desarrolladas con html y Vue.js, aquí se muestran las opciones que el usuario puede seleccionar junto con las restricciones de los datos que ingresa, además se presentan las rutas y conección con el controlador que decide que ruta se enviará ante la solicitud del cliente. Debido a que Vue.js se llama desde un cdn en la web, se la define como un recurso externo enlazado a las vistas en .net.


Link de video presentación en Loom: https://www.loom.com/share/11a7ee5761954be2a9f31d0fc62783c7?sid=3dced216-de46-4578-8987-d274f13138cc




