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

## Actividad 6

* Una cámara seguirá al personaje Rogue y otra cámara seguirá al personaje Wizard.
* La cámara del Rogue será la de mayor prioridad y el juego comenzará enfocando a ella
* La cámara del Rogue estará confinada en toda la escena, mientras que la del Wizard se mantendrá en el lado derecho de la misma.
* La zona de seguimiento del personaje Wizard es mayor que la del Rogue.
* Existe una cámara que seguirá a ambos personajes.
* Cuando el Rogue choca con la estatua, la cámara vibrará, solo cuando se esté viendo la cámara asociada al Rogue.
* Si se pulsa Espacio, la cámara cambiará a la siguiente en orden de prioridad, primero de Rogue a Wizard, de Wizard a la Cámara general y de ahí de vuelta a la del Rogue.
* Cada vez que un personaje ataque, vibrará su propia cámara o la cámara general si se está viendo esta. Es decir, un ataque del Wizard no hará que la cámara del Rogue vibre.
* Se ha añadido un perfil de ruido de Perlin a la cámara del Rogue, modificando su amplitud y frecuencia.

El siguiente enlace contiene un video mostrando lo explicado arriba:

https://youtu.be/Xr92jqS1hjE

## Actividad 7

Esta actividad contiene cuatro partes: Background Scrolling, Player Scrolling, Parallax Scrolling y Pooling.

### Background Scrolling

* En este caso se añade el fondo como textura a un GameObject Quad.
* El sprite del fondo se importa teniendo en cuenta que la propiedad "Wrap Mode" debe estar asignada a "Repeat".
* La textura se mueve a través del Quad.
* El personaje se configura para estar permanentemente corriendo para que no desentone con el fondo en constante movimiento.

### Player Scrolling

* En este caso el jugador debe tener asociada una cámara que le siga.
* El fondo debe estar compuesto de dos o más sprites contínuos.
* Cuando uno de los sprites salga de plano de la cámara que sigue al personaje se moverá al siguiente lugar para continuar la sucesión.
* Esto funciona en ambos sentidos cambiando la condición que detecta la desaparición del fondo.

### Parallax Scrolling

* Parecido al caso anterior con varias modificaciones.
* Ahora el fondo sigue estando compuesto de varios fondos continuados, sin embargo cada fondo tiene varias capas.
* Cada capa se desplazará a distintas velocidades provocando un efecto de profundidad.
* Igual que en el caso anterior, cuando una parte de una capa se salga de plano, se moverá al siguiente lugar para continuar la sucesión.

### Pooling

* Consiste en crear un pool de objetos que se van activando y desactivando para ahorrar memoria y no crear objetos infinitos.
* Se crea un pool de 5 sillas y 5 mesas usando un diccionario de colas.
* Cuando se quiere spawnear un objeto se saca, se crea y se vuelve a añadir para usarlo posteriormente.
* Cuando se crea, se asigna una altura, rotación y velocidad aleatoria.

El siguiente enlace contiene un video mostrando lo explicado arriba:

https://youtu.be/OAwJRD9gWyA

## Perforce

Para probar perforce se subió el primer proyecto de Sprites2D al Depot proporcionado por la universidad para esta asignatura, usando el comando mark to add. 

También se modificó el fichero de texto de ejemplo para probar a hacer checkout y modificar ficheros ya existentes, añadiendo una linea de texto nueva a dicho fichero.
