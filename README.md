# Fundamentos del Desarrollo de Videojuegos

## Actividad 1

En este script se han programado varios comportamientos relacionados con la colisión del personaje con la esfera:
* Al colisionar la esfera cambia el color de su material a rojo.
* Al colisionar un sistema de particulas se activa.
* Al colisionar el personaje es devuelto a su posición de origen.

Se puede observar el comportamiento en el siguiente vídeo:

https://youtu.be/eREl3-QgqSY

## Actividad 2

En estos scripts se han programado una serie de comportamientos relacionados con la colisión del personaje con los cilindros del terreno:
* Al colisionar con uno de los cilindros estáticos este cambia de posición entre tres posiciones distintas (izquierda, centro y derecha).
* Al colisionar con uno de los cilindros en movimiento, este cambia de dirección, reduce su escala en el eje Y y aumenta su velocidad proporcionalmente al poder del jugador. Después el jugador aumenta su poder en 1. 
* Cuando el tamaño en el eje Y de un cilindro se reduce hasta 0.25 unidades este desaparece.

https://youtu.be/bJw7Etsfbhs

## Unity Collab

Se ha añadido el proyecto a Unity Collab.

El proceso fue clicar en el icono de Unity Collab, posteriormente se crea un Id para el proyecto y se enciende el seguimiento de Unity Collab.

Unity Collab detecta todos los cambios, se seleccionan todos y se commitea y publica para su acceso online por parte de otros jugadores.

En la imagen inferior se puede observar el commit inicial que hace Unity así como el commit con todos los elementos que generé yo después para tener todo el repositorio accesible online.

![image](https://user-images.githubusercontent.com/5501664/138852336-ac80d130-b85b-4505-b6ef-867311957bea.png)

## Actividad 3

En estos scripts se han programado una serie de comportamientos relacionados con los eventos y el movimiento rectilíneo:
* El personaje azul se mueve utilizando las teclas WASD y el personaje rojo usando las flechas de dirección.
* Uno de los enemigos verdes perseguirá al personaje controlado con WASD.
* El cilindro del centro del mapa provocará que cualquiera que lo toque tanto amigo como enemigo se teletransporte a la ubicación configurada.
* El otro enemigo verde siempre se dirigirá a este cilindro de teletransporte.
* Si cualquiera de los enemigos contacta con un jugador le quitará una vida, indicadas en la interfaz en la esquina superior derecha.
* Si uno de los personajes recoge la ficha flotante violeta se abrirá la puerta de la mazmorra de roca.
* Tocando los botones de la esquina superior izquierda se cambia al modo seleccionado si no se está ya en ese modo y no se ha perdido ninguna vida, ya que al perder una vida se considera que ha comenzado el juego y no permite cambiar de modo.

https://youtu.be/9DADCcfcRWs

## Actividad 4

En este juego se han programado los siguientes comportamientos:
* Tanto el ladrón como la maga tienen animación de Idle por defecto.
* El ladrón se puede mover a izquierda y derecha con WASD, haciendo flip del sprite dependiendo de la dirección y activando la animación de caminar.
* Cuando se pulsa espacio el ladrón ataca.
* Cuando se pulsa X la maga ataca.
* Si el ladrón ataca a menos de 1.5 unidades de distancia de la maga, la maga muere.

https://youtu.be/uZH9gmnudyA

## Waypoints

https://youtu.be/QsMIuYCcc2o

## Actividad 5

### Parte 1

El siguiente video contiene todas las pruebas de la actividad:

https://youtu.be/J9OW0nV-L_Q

### Parte 2

El Script que contiene los mensajes de debug para collisions y triggers se encuentra en la carpeta Parte 2 de la Actividad 5
* Cuando un objeto colisiona con otro muestra el mensaje: "El objeto X ha colisionado con Y", siendo X e Y los nombres de los diferentes objetos extraídos a través de código.
* Cuando un objeto activa un trigger muestra el mensaje: "El objeto X ha disparado a Y", siendo X e Y los nombres de los diferentes objetos extraídos a través de código.

### Parte 3

En esta parte se contemplan varios comportamientos físicos requeridos por la actividad:
* El Ladrón tiene un movimiento físico programado desde el FixedUpdate.
* La puerta de la izquierda funciona como objeto estático que no podrá sobrepasar.
* El ladrón llevará siembre al bebé orco a una distancia fija gracias a un Distance Joint 2D.
* Al pasar por la palanca, el ladrón recibirá un impulso.
* La maga es un objeto dinámico al que se le han bajado los valores de masa y efecto de la gravedad para que salga disparada cuando el ladrón la golpee tras acelerar en la palanca.
* El ladrón podrá pasar por detrás de los enemigos, ya que se encuentran en otra capa y no colisionará a pesar de que estos tengan configurado Box Collision y Rigidbody propio.

En el siguiente enlace se puede ver el vídeo de la demostración: 

https://youtu.be/X0FpKIzP1LM
