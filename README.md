# Práctica 2 - Movimiento

## Ejercicio 1
**Descripción**: Crea un script asociado a un objeto en la escena que inicialice un vector de 3 posiciones con valores entre 0.0 y 1.0, para tomarlo como un vector de color (Color). Cada 120 frames se debe cambiar el valor de una posición aleatoria y asignar el nuevo color al objeto. Parametrizar la cantidad de frames de espera para poderlo cambiar desde el inspector.
![](./Ejercicio_1/Práctica%202%20-%20Ejercicio%201.gif)
## Ejercicio 2
**Descripción**: Crea un script asociado a la esfera con dos variables Vector3 públicas. Dale valor a cada componente de los vectores desde el inspector. Muestra en la consola:
1. La magnitud de cada uno de ellos.
2. El ángulo que forman.
3. La distancia entre ambos.
4. Un mensaje indicando qué vector está a una altura mayor.


![](./Ejercicio_2/Práctica%202%20-%20Ejercicio%202.gif)
## Ejercicio 3
**Descripción**: Muestra en pantalla el vector con la posición de la esfera.

![](./Ejercicio_3/Práctica%202%20-%20Ejercicio%203.gif)
## Ejercicio 4
**Descripción**: Crea un script para la esfera que muestre en consola la distancia a la que están el cubo y el cilindro.

![](./Ejercicio_4/Práctica%202%20-%20Ejercicio%204.gif)
## Ejercicio 5
**Descripción**: Selecciona tres posiciones en tu escena a través de un objeto invisible (marcador) que incluya 3 vectores numéricos para configurar posiciones en las que quieres ubicar los objetos en respuesta a pulsar la barra espaciadora. Estos vectores representan un desplazamiento respecto a la posición original de cada objeto. Crea un script que ubique en las posiciones configuradas cuando el usuario pulse la barra espaciadora.

![](./Ejercicio_5/Práctica%202%20-%20Ejercicio%205.gif)
## Ejercicio 6
**Descripción**: Agrega un campo velocidad a un cubo y asígnale un valor que se pueda cambiar en el inspector de objetos. Muestra la consola el resultado de multiplicar la velocidad por el valor del eje vertical y por el valor del eje horizontal cada vez que se pulsan las teclas flecha arriba-abajo ó flecha izquierda-derecha. El mensaje debe comenzar por el nombre de la flecha pulsada.

![](./Ejercicio_6/Práctica%202%20-%20Ejercicio%206.gif)
## Ejercicio 7
**Descripción**: Mapea la tecla H a la función disparo.

![](./Ejercicio_7/Práctica%202%20-%20Ejercicio%207.gif)
## Ejercicio 8
**Descripción**: Crea un script asociado al cubo que en cada iteración traslade al cubo una cantidad proporcional un vector que indica la dirección del movimiento: moveDirection que debe poder modificarse en el inspector.  La velocidad a la que se produce el movimiento también se especifica en el inspector, con la propiedad speed. Inicialmente la velocidad debe ser mayor que 1 y el cubo estar en una posición y=0. En el informe de la práctica comenta los resultados que obtienes en cada una de las siguientes situaciones:
1. duplicas las coordenadas de la dirección del movimiento -> Se aumenta la velocidad.
2. duplicas la velocidad manteniendo la dirección del movimiento -> Se aumenta la velocidad.
3. la velocidad que usas es menor que 1 -> Se invierte la dirección actual
4. la posición del cubo tiene y>0 -> Se cambia la posición en y del cubo
5. intercambiar movimiento relativo al sistema de referencia local y el mundial. ->


![](./Ejercicio_8/Práctica%202%20-%20Ejercicio%208.gif)
## Ejercicio 9
**Descripción**: Mueve el cubo con las teclas de flecha arriba-abajo, izquierda-derecha a la velocidad speed. Cada uno de estos ejes implican desplazamientos en el eje vertical y horizontal respectivamente. Mueve la esfera con las teclas w-s (movimiento vertical) a-d (movimiento horizontal).

![](./Ejercicio_9/Práctica%202%20-%20Ejercicio%209.gif)
## Ejercicio 10
**Descripción**: Adapta el movimiento en el ejercicio 9 para que sea proporcional al tiempo transcurrido durante la generación del frame.

![](./Ejercicio_10/Práctica%202%20-%20Ejercicio%2010.gif)
## Ejercicio 11
**Descripción**: Adapta el movimiento en el ejercicio 10 para que el cubo se mueva hacia la posición de la esfera. Debes considerar que el avance no debe estar influenciado por cuánto de lejos o cerca estén los dos objetos.

![](./Ejercicio_11/Práctica%202%20-%20Ejercicio%2011.gif)
## Ejercicio 12
**Descripción**: Adapta el movimiento en el ejercicio 11 de forma que el cubo avance mirando siempre hacia la esfera, independientemente de la orientación de su sistema de referencia. Para ello, el cubo debe girar de forma que el eje Z positivo apunte hacia la esfera . Realiza pruebas cambiando la posición de la esfera mediante las teclas awsd.

![](./Ejercicio_12/Práctica%202%20-%20Ejercicio%2012.gif)
## Ejercicio 13
**Descripción**: Utilizar el eje “Horizontal” para girar el objetivo y que avance siempre en la dirección hacia adelante.

![](./Ejercicio_13/Práctica%202%20-%20Ejercicio%2013.gif)