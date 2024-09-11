# Emergencia en el Laboratorio Cuántico

## Descripción
"Emergencia en el Laboratorio Cuántico" es un juego de simulación interactiva desarrollado en Unity3D. Los jugadores asumen el papel de un Agente Científico encargado de recolectar Estabilizadores Cuánticos para prevenir un desastre en un laboratorio de investigación avanzada.

## Características Principales
- Entorno 3D interactivo ambientado en un laboratorio cuántico
- Sistema de movimiento en primera persona
- Mecánica de recolección de objetos
- Interfaz de usuario con contador de objetos y panel de victoria
- Menú principal con introducción al lore del juego

## Requisitos del Sistema
- Unity 2022.3.24f1 LTS
- Sistema Operativo: Windows 10 (64-bit)

## Instalación
1. Clona este repositorio o descarga el ZIP.
2. Abre el proyecto en Unity 2022.3.24f1 LTS.
3. Abre la escena principal ubicada en `Assets/Scenes/PruebaTecnicaInnovatechVR.unity`.

## Cómo Jugar
1. Ejecuta el juego desde Unity o abre el ejecutable compilado.
2. En el menú principal, lee las instrucciones y el contexto del juego.
3. Haz clic en "Iniciar Misión" para comenzar.
4. Usa WASD para moverte y el ratón para mirar alrededor.
5. Recolecta los 5 Estabilizadores Cuánticos dispersos por el laboratorio.
6. Completa la misión recolectando todos los objetos para ganar.

## Desarrollo
Este proyecto fue desarrollado como parte de una prueba técnica para demostrar habilidades en:
- Programación en C# con Unity
- Diseño de mecánicas de juego básicas
- Implementación de UI y manejo de estados de juego

## Estructura del Proyecto
- `/Assets/`
  - `/3rdParty/`: Assets de terceros utilizados en el proyecto
    - `3D Laboratory Environment with Appratus/`: Modelos y texturas para el entorno del laboratorio
    - `Casual Game Sounds U6/`: Efectos de sonido para el juego
  - `/JMO Assets/`: Sistemas de particulas utilizados en el juego
  - `/Materials/`: Materiales utilizados en el juego
    - `EyesMaterial`: Material específico para los ojos de los personajes o elementos
  - `/Models/`: Modelos 3D utilizados en el juego
  - `/Prefabs/`: Prefabs reutilizables
    - `Items/`: Prefabs de los objetos recolectables
    - `Player/`: Prefab del jugador y componentes relacionados
    - `UI/`: Prefabs de elementos de la interfaz de usuario
  - `/Scenes/`: Escenas del juego
  - `/Scripts/`: Todos los scripts C# del juego
    - `ObjectCollectionSystem/`: Scripts relacionados con el sistema de recolección de objetos
    - `Player/`: Scripts de control del jugador
    - `UIManagers/`: Scripts para gestionar la interfaz de usuario
  - `/TextMesh Pro/`: Assets para el sistema de texto TextMesh Pro
  - `/UI/`: Recursos de la interfaz de usuario
    - `Animation/`: Animaciones para elementos de UI
  - `/Packages/`: Paquetes de Unity utilizados en el proyecto

## Contacto
Mauricio Castro - https://www.linkedin.com/in/maocastro13/

Enlace del Proyecto: [https://github.com/maocastro13/emergencia-laboratorio-cuantico](https://github.com/maocastro13/InnovatechVR_PruebaTecnica)

## Agradecimientos
- Unity Technologies
- https://assetstore.unity.com/packages/audio/sound-fx/free-casual-game-sfx-pack-54116
- https://assetstore.unity.com/packages/vfx/particles/cartoon-fx-remaster-free-109565
- https://assetstore.unity.com/packages/3d/environments/chemistry-lab-items-pack-220212
