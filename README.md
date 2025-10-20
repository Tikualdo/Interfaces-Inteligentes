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

## ⚙️ Ejercicio 3 y 8

Para resolver estos ejercicios combinados, desarrollé los siguientes scripts:
- **[EventManagerv2.cs](./Ejercicio_3/EventManagerv2.cs):** Permite al Nórdico (humanoide 1) y al Lich (humanoide 2) invocar un evento.
- **[FighterBehaviourv2.cs](./Ejercicio_3/FighterBehaviourv2.cs):** Hace que dependiendo del evento que se active (colisión del cubo con un Lich o un Nórdico), los Nórdicoshagan una cosa u otra.
- **[FighterTrigger.cs](./Ejercicio_3/FighterTrigger.cs):** 
- **[LichTrigger.cs](./Ejercicio_3/LichTrigger.cs):** El nórdico envía un evento cuando un cubo colisiona con él.
- **[ShieldColor.cs](./Ejercicio_3/ShieldColor.cs):** Cuando el escudo colisiona con algo, se le cambia color aleatoriamente.
- **[TriggerCube.cs](./Ejercicio_3/TriggerCube.cs):** Cuando el cubo colisona con algo, envía el evento de colisión con Lich o Nórdico.

Cabe destacar que en el ejercicio había puesto físicas a los cubos, por lo que automaticamente hice el ejercicio 8.

![Resultado del Ejercicio 3 y 8](./Ejercicio_3/Práctica%204%20-%20Ejercicio%203.gif)

---

## ⚙️ Ejercicio 4

Para este ejercicio, implementé los scripts que detallo a continuación:
- **[FighterTeleport.cs](./Ejercicio_4/FighterTeleport.cs):** cuando detecta una colision mueve a todos los Nórdicos a la posición del objeto seleccionado en el inspector.
- **[MoverHaciaObjetivo.cs](./Ejercicio_4/MoverHaciaObjetivo.cs):** mueve el cubo lentamente hacia un objeto seleccionado.

![Resultado del Ejercicio 4](./Ejercicio_4/Práctica%204%20-%20Ejercicio%204.gif)

---

## ⚙️ Ejercicio 5

Para resolver este punto, me enfoqué en los siguientes scripts:
- **[NombreDelScript1.cs](./Ejercicio_5/NombreDelScript1.cs):** [Breve descripción de la funcionalidad del script].
- **[NombreDelScript2.cs](./Ejercicio_5/NombreDelScript2.cs):** [Breve descripción de la funcionalidad del script].

![Resultado del Ejercicio 5](./Ejercicio_5/Práctica%204%20-%20Ejercicio%205.gif)

---

## ⚙️ Ejercicio 6

En este caso, la lógica se distribuyó en estos scripts:
- **[NombreDelScript1.cs](./Ejercicio_6/NombreDelScript1.cs):** [Breve descripción de la funcionalidad del script].
- **[NombreDelScript2.cs](./Ejercicio_6/NombreDelScript2.cs):** [Breve descripción de la funcionalidad del script].

![Resultado del Ejercicio 6](./Ejercicio_6/Práctica%204%20-%20Ejercicio%206.gif)

---

## ⚙️ Ejercicio 7

Finalmente, para este ejercicio, desarrollé los siguientes componentes:
- **[NombreDelScript1.cs](./Ejercicio_7/NombreDelScript1.cs):** [Breve descripción de la funcionalidad del script].
- **[NombreDelScript2.cs](./Ejercicio_7/NombreDelScript2.cs):** [Breve descripción de la funcionalidad del script].

![Resultado del Ejercicio 7](./Ejercicio_7/Práctica%204%20-%20Ejercicio%207.gif)

---