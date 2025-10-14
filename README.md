# 🧩 Práctica 3 - Físicas  

## ⚙️ Situaciones  

### ⚙️ Situación 1  
El plano no es un objeto físico. El cubo es un objeto físico y la esfera no.  
En este caso, el plano y la esfera sólo tienen **Collider**, mientras que el cubo tiene **Rigidbody**.

| Objeto | Rigidbody | Collider | Cinemático | Masa | Fricción | Trigger | Observaciones |
|---------|------------|-----------|-------------|-------|-----------|----------|----------------|
| Plano   | ❌ No | ✅ Sí (Mesh Collider) | - | - | - | - | Actúa como superficie estática. |
| Cubo    | ✅ Sí | ✅ Sí (Box Collider) | ❌ No | 1 | - | - | Cae por gravedad hasta colisionar con el plano. |
| Esfera  | ❌ No | ✅ Sí (Sphere Collider) | - | - | - | - | Permanece inmóvil en su posición inicial. |

> 💡 *Comportamiento esperado:* solo el cubo cae y colisiona con el plano; la esfera y el plano permanecen estáticos.

<img src="./Situ_1/Práctica%203%20-%20Situación%201.png" alt="Situación 1" width="700">

---

### ⚙️ Situación 2  
El plano no es un objeto físico. El cubo y la esfera son objetos físicos.  
En este caso, el plano sólo tiene **Collider**, mientras que el cubo y la esfera tienen **Rigidbody**.

| Objeto | Rigidbody | Collider | Cinemático | Masa | Fricción | Trigger | Observaciones |
|---------|------------|-----------|-------------|-------|-----------|----------|----------------|
| Plano   | ❌ No | ✅ Sí (Mesh Collider) | - | - | - | - | Superficie estática de apoyo. |
| Cubo    | ✅ Sí | ✅ Sí (Box Collider) | ❌ No | 1 | - | - | Cae por gravedad y puede colisionar con la esfera. |
| Esfera  | ✅ Sí | ✅ Sí (Sphere Collider) | ❌ No | 1 | - | - | Cae por gravedad y puede colisionar con el cubo. |

> 💡 *Comportamiento esperado:* ambos objetos caen y colisionan entre sí o con el plano.

![](./Situ_2/Práctica%203%20-%20Situación%202.gif)

---

### ⚙️ Situación 3  
El plano no es un objeto físico. El cubo es un objeto físico y la esfera es **cinemática**.  
En este caso, el plano sólo tiene **Collider**, mientras que el cubo y la esfera tienen **Rigidbody**, pero la esfera está marcada como **Cinemático**.

| Objeto | Rigidbody | Collider | Cinemático | Masa | Fricción | Trigger | Observaciones |
|---------|------------|-----------|-------------|-------|-----------|----------|----------------|
| Plano   | ❌ No | ✅ Sí (Mesh Collider) | - | - | - | - | Superficie estática de apoyo. |
| Cubo    | ✅ Sí | ✅ Sí (Box Collider) | ❌ No | 1 | - | - | Cae por gravedad hasta colisionar con el plano. |
| Esfera  | ✅ Sí | ✅ Sí (Sphere Collider) | ✅ Sí | 1 | - | - | No cae ni se mueve; permanece en su posición inicial pese a tener Rigidbody. |

> 💡 *Comportamiento esperado:* solo el cubo cae y colisiona con el plano; la esfera cinemática permanece estática.

![](./Situ_3/Práctica%203%20-%20Situación%203.gif)

---

### ⚙️ Situación 4  
El plano, el cubo y la esfera son todos objetos físicos, pero el plano está marcado como **Cinemático**.  
En este caso, todos los objetos tienen **Rigidbody**.

| Objeto | Rigidbody | Collider | Cinemático | Masa | Fricción | Trigger | Observaciones |
|---------|------------|-----------|-------------|-------|-----------|----------|----------------|
| Plano   | ✅ Sí | ✅ Sí (Mesh Collider) | ✅ Sí | - | - | - | Superficie con Rigidbody cinemático; no se mueve por gravedad pero puede colisionar. |
| Cubo    | ✅ Sí | ✅ Sí (Box Collider) | ❌ No | 1 | - | - | Cae por gravedad y colisiona con el plano. |
| Esfera  | ✅ Sí | ✅ Sí (Sphere Collider) | ❌ No | 1 | - | - | Cae por gravedad y colisiona con cubo y plano. |

> 💡 *Comportamiento esperado:* el cubo y la esfera caen y colisionan; el plano permanece estático por ser cinemático.

<img src="./Situ_4/Práctica%203%20-%20Situación%204.png" alt="Situación 1" width="700">

---

### ⚙️ Situación 5  
El plano, el cubo y la esfera son objetos físicos.  
La esfera tiene una **masa 10 veces mayor** que la del cubo.  
En este caso, todos los objetos tienen **Rigidbody**.

| Objeto | Rigidbody | Collider | Cinemático | Masa | Fricción | Trigger | Observaciones |
|---------|------------|-----------|-------------|-------|-----------|----------|----------------|
| Plano   | ✅ Sí | ✅ Sí (Mesh Collider) | ✅ Sí | - | - | - | Superficie con Rigidbody cinemático; sirve de base estática para las colisiones. |
| Cubo    | ✅ Sí | ✅ Sí (Box Collider) | ❌ No | 1 | - | - | Cae por gravedad y colisiona con el plano o la esfera. |
| Esfera  | ✅ Sí | ✅ Sí (Sphere Collider) | ❌ No | 10 | - | - | Cae por gravedad con mayor inercia debido a su masa superior. |

> 💡 *Comportamiento esperado:* tanto el cubo como la esfera caen, pero la esfera muestra menos desaceleración y mayor impacto por su mayor masa.

![](./Situ_5/Práctica%203%20-%20Situación%205.gif)

---

### ⚙️ Situación 6  
El plano, el cubo y la esfera son objetos físicos.  
La esfera tiene una **masa 100 veces mayor** que la del cubo.  
En este caso, todos los objetos tienen **Rigidbody**.

| Objeto | Rigidbody | Collider | Cinemático | Masa | Fricción | Trigger | Observaciones |
|---------|------------|-----------|-------------|-------|-----------|----------|----------------|
| Plano   | ✅ Sí | ✅ Sí (Mesh Collider) | ✅ Sí | - | - | - | Superficie con Rigidbody cinemático; sirve de base estática para las colisiones. |
| Cubo    | ✅ Sí | ✅ Sí (Box Collider) | ❌ No | 1 | - | - | Cae por gravedad y colisiona con el plano o la esfera. |
| Esfera  | ✅ Sí | ✅ Sí (Sphere Collider) | ❌ No | 100 | - | - | Cae por gravedad con mayor inercia debido a su masa superior. |

> 💡 *Comportamiento esperado:* tanto el cubo como la esfera caen, pero la esfera muestra menos desaceleración y mayor impacto por su mayor masa.

![](./Situ_6/Práctica%203%20-%20Situación%206.gif)

---

### ⚙️ Situación 7  
El plano, el cubo y la esfera son objetos físicos.  
La esfera, además, tiene **fricción** aplicada mediante un *Physic Material*.  
En este caso, todos los objetos deben tener **Rigidbody**.

| Objeto | Rigidbody | Collider | Cinemático | Masa | Fricción | Trigger | Observaciones |
|---------|------------|-----------|-------------|-------|-----------|----------|----------------|
| Plano   | ✅ Sí | ✅ Sí (Mesh Collider) | ✅ Sí | - | Predeterminada | - | Actúa como superficie estable sin fricción especial. |
| Cubo    | ✅ Sí | ✅ Sí (Box Collider) | ❌ No | 1 | Predeterminada | - | Interactúa normalmente con el plano. |
| Esfera  | ✅ Sí | ✅ Sí (Sphere Collider) | ❌ No | 1 | Alta | - | Rueda con dificultad debido a la fricción aplicada. |

> 💡 *Comportamiento esperado:* la fricción alta de la esfera hace que su movimiento se detenga más rápidamente al deslizar o rodar sobre el plano.

![](./Situ_7/Práctica%203%20-%20Situación%207.gif)

---

### ⚙️ Situación 8  
El plano y el cubo son objetos físicos, pero la esfera **no es física** y actúa como **Trigger**.  
En este caso, todos los objetos deben tener **Rigidbody**.

| Objeto | Rigidbody | Collider | Cinemático | Masa | Fricción | Trigger | Observaciones |
|---------|------------|-----------|-------------|-------|-----------|----------|----------------|
| Plano   | ✅ Sí | ✅ Sí (Mesh Collider) | ✅ Sí | - | Predeterminada | ❌ No | Sirve de superficie base estable. |
| Cubo    | ✅ Sí | ✅ Sí (Box Collider) | ❌ No | 1 | Predeterminada | ❌ No | Se comporta como objeto físico normal. |
| Esfera  | ✅ Sí | ✅ Sí (Sphere Collider) | ❌ No | 1 | Predeterminada | ✅ Sí | No colisiona físicamente, pero detecta eventos al superponerse. |

> 💡 *Comportamiento esperado:* la esfera atraviesa el cubo y el plano sin colisionar, pero activa eventos de detección gracias a su propiedad *Is Trigger*.

![](./Situ_8/Práctica%203%20-%20Situación%208.gif)

---

### ⚙️ Situación 9  
El plano, el cubo y la esfera son objetos físicos.  
La **esfera**, además, tiene activado el modo **Trigger**, por lo que detecta colisiones sin respuesta física.  
En este caso, todos los objetos deben tener **Rigidbody**.

| Objeto | Rigidbody | Collider | Cinemático | Masa | Fricción | Trigger | Observaciones |
|---------|------------|-----------|-------------|-------|-----------|----------|----------------|
| Plano   | ✅ Sí | ✅ Sí (Mesh Collider) | ✅ Sí | - | Predeterminada | ❌ No | Superficie estable que recibe impactos físicos. |
| Cubo    | ✅ Sí | ✅ Sí (Box Collider) | ❌ No | 1 | Predeterminada | ❌ No | Objeto físico normal, afectado por la gravedad y colisiones. |
| Esfera  | ✅ Sí | ✅ Sí (Sphere Collider) | ❌ No | 1 | Predeterminada | ✅ Sí | Responde a la gravedad, pero no colisiona; detecta superposiciones como *Trigger*. |

> 💡 *Comportamiento esperado:* la esfera cae por la gravedad, atraviesa el cubo y el plano sin chocar físicamente, pero activa eventos de detección (*OnTriggerEnter*, *OnTriggerExit*).

![](./Situ_9/Práctica%203%20-%20Situación%209.gif)

---

## ⚙️ Ejercicios  

### ⚙️ Ejercicio 1 
Crea un personaje,controla su desplazamiento con las teclas **WASD** o las flechas, el movimiento debe estar influenciado por usando un `Rigidbody`, pero manteniendo el control total.

![](./Ejercicio_1/Práctica%203%20-%20Ejercicio%201.gif)

---

### ⚙️ Ejercicio 2 
Crea varios cubos o esferas con `Rigidbody` dinámico. Muestra por consola el nombre del objeto con el que colisiona, y cámbiale su color al colisionar.

![](./Ejercicio_2/Práctica%203%20-%20Ejercicio%202.gif)

---

### ⚙️ Ejercicio 3
Crea una zona (por ejemplo, un cubo grande con *Is Trigger = true*). Al entrar, cambia el color del personaje o activa un efecto que cambie la luz. Al salir, revierte el cambio. Añade otra zona que aumente una variable daño.

![](./Ejercicio_3/Práctica%203%20-%20Ejercicio%203.gif)

---

### ⚙️ Ejercicio 4
Crea tres tipos de objetos en capas distintas: jugador, enemigos, recolectables. Configura la **Layer Collision Matrix** (Project Settings > Physics). Haz que los enemigos solo colisionen con el jugador, y que los recolectables solo sean detectados por triggers.

![](./Ejercicio_4/Práctica%203%20-%20Ejercicio%204.gif)

---

### ⚙️ Ejercicio 5
Crea una escena con distintos materiales físicos (resbaladizo, rugoso, rebote alto). Aplica distintos **Physic Materials** a objetos. Lanza los objetos con AddForce() al pulsar la tecla X y observa cómo cambian las reacciones.

![](./Ejercicio_5/Práctica%203%20-%20Ejercicio%205.gif)

---
