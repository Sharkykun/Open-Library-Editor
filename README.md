Para un correcto uso de la aplicación es necesario tener instaladas en el ordenador unas fuentes concretas, disponibles gratuitamente en Google Fonts:
- Fuente Merienda: https://fonts.google.com/specimen/Merienda?query=Merienda
- Fuente Merienda One: https://fonts.google.com/specimen/Merienda+One?query=Merienda

Pero si se desea se puede utilizar la aplicación instalándola a través del setup incluido en el proyecto, el cuál ya instalará las fuentes anteriores en tu ordenador 
directamente.

Destacar que la en la aplicación se han utilizado los frameworks de Guna y de Krypton Suite, por lo que si se descarga el código y se trata de ejecutar en Visual Studio,
dará errores de compilación si no se tienen estos frameworks instalados en el IDE. También añadir que para poder usar Krypton se ha tenido que desarrollar la aplicación
utilizando como plataforma de destino del proyecto la versión .Net Framework 4.8, en versiones anteriores puede dar problemas de compilación.

Añadir que el primer próposito y para lo que se pensó inicialmente la aplicación era para ser utilizada como biblioteca personal de una persona en local. Posteriormente se añadio la posibilidad de poder crear una base de datos en un servidor propio con mysql y compartir así la información con familiares o amigos, pero para ello es necesario disponer de un servidor propio que permita acceder a la tabla USER de MySQL, por eso la aplicación si se desea utilizar de este modo está orientada a una persona con ciertos conocimientos en la creación y utilización de servidores personales.
A partir de la creación del servidor ya se podría crear la base de datos desde la aplicación y el administrador de la aplicación y de la base de datos podría compartir la dirección de su servidor para que sus contactos se puedan registrar en ella a través de la propia aplicación.
