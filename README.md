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
