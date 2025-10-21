# 🔔 Práctica 4 - Delegados y eventos

En esta práctica, he aplicado los conceptos de delegados y eventos en Unity para resolver una serie de ejercicios. A continuación, detallo el proceso y el resultado de cada uno.

---

## ⚙️ Ejercicio 1

Para este ejercicio, realicé diferentes scripts que detallo a continuación:
- **[CylinderTrigger.cs](./Ejercicio_1/CylinderTrigger.cs):** El cilindro envía un evento solo cuando el cubo ha colisionado con él.
- **[SphereBehaviour.cs](./Ejercicio_1/SphereBehaviour.cs):** Las esferas de tipo 1 se moverán a la posición de la esfera de tipo 2 seleccionada en el inspector cuando el cilindro lance un evento, mientras que las esferas de tipo dos se moverán al cilindro cuando ocurra lo mismo que antes mencionado.
- **[EventManager.cs](./Ejercicio_1/EventManager.cs):** Permite al cilindro invocar un evento.

![Resultado del Ejercicio 1](./Ejercicio_1/Práctica%204%20-%20Ejercicio%201.gif)

---

## ⚙️ Ejercicio 2

Para este ejercicio, realicé diferentes scripts que detallo a continuación:
- **[FighterBehaviour1.cs](./Ejercicio_2/FighterBehaviour1.cs):** Misma funcionalidad que [SphereBehaviour.cs](./Ejercicio_1/SphereBehaviour.cs) Pero adaptado a los humanoides.

![Resultado del Ejercicio 2](./Ejercicio_2/Práctica%204%20-%20Ejercicio%202.gif)

---

## ⚙️ Ejercicio 3 y 9

Para resolver estos ejercicios combinados, desarrollé los siguientes scripts:
- **[EventManagerv2.cs](./Ejercicio_3/EventManagerv2.cs):** Permite al Nórdico (humanoide 1) y al Lich (humanoide 2) invocar un evento.
- **[FighterBehaviourv2.cs](./Ejercicio_3/FighterBehaviourv2.cs):** Hace que dependiendo del evento que se active (colisión del cubo con un Lich o un Nórdico), los Nórdicoshagan una cosa u otra.
- **[FighterTrigger.cs](./Ejercicio_3/FighterTrigger.cs):** 
- **[LichTrigger.cs](./Ejercicio_3/LichTrigger.cs):** El nórdico envía un evento cuando un cubo colisiona con él.
- **[ShieldColor.cs](./Ejercicio_3/ShieldColor.cs):** Cuando el escudo colisiona con algo, se le cambia color aleatoriamente.
- **[TriggerCube.cs](./Ejercicio_3/TriggerCube.cs):** Cuando el cubo colisona con algo, envía el evento de colisión con Lich o Nórdico.

Cabe destacar que en el ejercicio había puesto físicas a los cubos, por lo que automaticamente hice el ejercicio 8.

![Resultado del Ejercicio 3 y 9](./Ejercicio_3/Práctica%204%20-%20Ejercicio%203.gif)

---

## ⚙️ Ejercicio 4

Para este ejercicio, implementé los scripts que detallo a continuación:
- **[FighterTeleport.cs](./Ejercicio_4/FighterTeleport.cs):** cuando detecta una colision mueve a todos los Nórdicos a la posición del objeto seleccionado en el inspector.
- **[MoverHaciaObjetivo.cs](./Ejercicio_4/MoverHaciaObjetivo.cs):** mueve el cubo lentamente hacia un objeto seleccionado.

![Resultado del Ejercicio 4](./Ejercicio_4/Práctica%204%20-%20Ejercicio%204.gif)

---

## ⚙️ Ejercicio 5

Para resolver este punto, me enfoqué en los siguientes scripts:
- **[PlayerController.cs](./Ejercicio_5/PlayerController.cs):** Permite al jugador moverse, además de tener un contador para la puntuación y el método para ir acumulandola.
- **[NombreDelScript2.cs](./Ejercicio_5/NombreDelScript2.cs):** Detecta si el objeto que colisionó con el objeto es un Nórdico y luego dependiendo de cual sea el tipo del objeto (Tipo 1 o Tipo 2) da 5 o 10 puntos al Nórdico.

![Resultado del Ejercicio 5](./Ejercicio_5/Práctica%204%20-%20Ejercicio%205.gif)

---

## ⚙️ Ejercicio 6

En este caso, la lógica se distribuyó en estos scripts:
- **[PlayerController.cs](./Ejercicio_6/PlayerController.cs):** Mismo que el anterior pero con la variación de que la puntuación se muestra a traves de un mensaje con canva en la UI.
- **[CollectibleShieldTrigger.cs](./Ejercicio_6/CollectibleShieldTrigger.cs):** Mismo que el anterior ejercicio

![Resultado del Ejercicio 6](./Ejercicio_6/Práctica%204%20-%20Ejercicio%206.gif)

---

## ⚙️ Ejercicio 7

Por otra parte, en este ejercicio implementé:
- **[PlayerController.cs](./Ejercicio_7/PlayerController.cs):** Mismo que el anterior pero con la implementación adicional de que salga un mensaje de recompensa ganada cada 100 puntos. El mensaje dura 5 segundos en pantalla y se hace de igual forma con canva.
- **[CollectibleShieldTrigger.cs](./Ejercicio_7/CollectibleShieldTrigger.cs):** Mismo que el anterior ejercicio.

![Resultado del Ejercicio 7](./Ejercicio_7/Práctica%204%20-%20Ejercicio%207.gif)

---

## ⚙️ Ejercicio 8

Finalmente, para este ejercicio, añadí espadas al escenario con la misma funcionalidad anterior hecha en el ejercicio 5. Para ello se utilizó los siguientes scripts:
- **[PlayerController.cs](./Ejercicio_8/PlayerController.cs):** Mismo que el anterior.
- **[CollectibleShieldTrigger.cs](./Ejercicio_8/CollectibleShieldTrigger.cs):** Similar al anterior pero muestra un mensaje de que se ha recogido la espada por consola.

![Resultado del Ejercicio 8](./Ejercicio_8/Práctica%204%20-%20Ejercicio%208.gif)

---