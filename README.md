# 🎧 Micrófono y cámara

## 📂 Descripción de Scripts y Escenas

A continuación se detalla la funcionalidad de los scripts implementados y su ubicación en el proyecto.

### 1. Escena 4: Los Guerreros ⚔️
Primer ejercicio de la práctica, centrado en añadir audio espacial al interactuar con los guerreros.

* En **`CollisionHumanObserver.cs`** se añadió lo siguiente:
    * Gestiona la reproducción de efectos de sonido (SFX) puntuales al producirse eventos de impacto.

* **`SonidoProximidad.cs`**: **Sistema de audio por distancia.**
    * Calcula la distancia en tiempo real entre el enemigo y el jugador (Cubo).
    * Ajusta el volumen de forma lineal (más cerca = más volumen), forzando el audio a 2D para priorizar la posición del jugador sobre la posición de la cámara.

### 2. Escena Multimedia: Altavoces y Pantalla 🎤📺
Nueva escena enfocada en la captura y manipulación de periféricos de entrada (Micrófono y Webcam).

* **`Recorder.cs`**: **Sistema de megafonía (Micrófono).**
    * Captura el audio del micrófono predeterminado del sistema mediante `Microphone.Start`.
    * Reproduce el sonido a través de los altavoces virtuales de la escena.
    * Implementa lógica *Push-to-Talk*: el audio solo se escucha mientras se mantiene pulsada la tecla **R**.

* **`TV.cs`**: **Sistema de Circuito Cerrado (Webcam).**
    * Utiliza `WebCamTexture` para proyectar la imagen de la cámara real sobre un objeto 3D en la escena.
    * Permite guardar fotogramas en el disco local.
    * **Controles implementados:**
        * **`Z`**: Encender cámara y proyectar en la pantalla.
        * **`P`**: Pausar la imagen (Stop).
        * **`X`**: Tomar una captura instantánea (*Snapshot*) y guardarla en la carpeta del proyecto.