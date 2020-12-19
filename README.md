# Diseno-oo-ejercicio3-mastermind-separar-controladores

Esta es la práctica final del [curso de diseño orientado a objetos](https://escuela.it/cursos/curso-de-diseno-orientado-a-objetos) de EscuelaIT, en la que trabajamos en la línea propuesta durante las clases, separando el código entre vistas, modelos y, ahora, controladores.

La práctica fue propuesta al final de la clase de [Inyección de dependencias, Liskov, doble despacho y otras leyes y técnicas](https://escuela.it/cursos/curso-de-diseno-orientado-a-objetos/clase/inyeccion-de-dependencias-liskov-doble-despacho-y-otras-leyes-y-tecnicas). La resumimos aquí.

## Objetivo

Se debe realizar la programación del juego de Mastermind, con vista en unos requisitos nuevos, en los que se ha incorporado también gráficos de interfaz de usuario (GUI), además de la versión de consola que ya se tenía. Los [nuevos requisitos están aquí](https://github.com/SantaTecla-mastermind/requirements/tree/master/2.Gr%C3%A1ficos).

Nota: La parte de gráficos, para el manejo de las librerías de Java, no es el objetivo de la práctica, sino conseguir en la misma aplicación ofrecer esas dos interfaces de usario gráficos / consola, incorporando las nuevas vistas y creando controladores.

## Modelo de desarrollo a seguir

Debes usar como guía el desarrollo del juego de las Tres en Raya, que está publico en sus distintas versiones. Debes ver el código de la solución, hasta el punto en que estamos y analizarlo, para poder llevar esas mismas prácticas al juego del Mastermind. En otras palabras, imitar el modelo de aplicación del TicTacToe para construir el Mastermind por tu cuenta.

En este enlace puedes ver la [secuencia de soluciones del TicTacToe](https://github.com/SantaTecla-ticTacToe/solution.java.swing.socket.sql). Observarás que hay muchas soluciones. Nosotros estamos desarrollando hasta el punto de "withDoubleDispatching" y es hasta el punto al que tienes que llevar la solución del Mastermind.

Puedes realizar el ejercicio programando las versiones del juego, una a una, tal como se ha hecho en el TicTacToe, o bien programar del tirón la versión final hasta el punto en el que se pide. La decisión será la que cada uno juzgue adecuada para su nivel o capacidad. 

Por si no las encuentras, esta es la [carpeta donde están las soluciones que estámos trabajando en esta práctica](https://github.com/SantaTecla-ticTacToe/solution.java.swing.socket.sql/tree/master/modelViewPresenter/presentationModel) y representadas en el gráfico del enlace anterior. Para cualquier duda adicional, recomendamos que veas de nuevo el enunciado propuesto en el vídeo de la clase del curso al que hemos hecho referencia al principio de este README.

