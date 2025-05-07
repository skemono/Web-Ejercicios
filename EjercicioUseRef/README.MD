# Ejercicio React Timer

Este proyecto es una aplicación de temporizador creada con **React**. Permite iniciar, pausar, reiniciar y guardar intervalos de tiempo. Es ideal para practicar el uso de hooks como `useState` y `useRef`.

## Características

- **Iniciar/Pausar**: Controla el temporizador con un solo botón.
- **Reiniciar**: Restablece el temporizador a 0.
- **Guardar Intervalos**: Guarda los tiempos registrados en una lista.
- **Interfaz amigable**: Diseño limpio y responsivo.

## Tecnologías utilizadas

- **React**: Biblioteca para construir interfaces de usuario.
- **ReactDOM**: Renderizado de componentes en el DOM.
- **Babel**: Transpila el código JSX a JavaScript.
- **HTML/CSS**: Estructura y estilos de la aplicación.

## Instalación y uso

1. Clona este repositorio o copia el código en un archivo HTML.
2. Asegúrate de tener conexión a internet para cargar las dependencias desde los CDN.
3. Abre el archivo en tu navegador para ver la aplicación en acción.

## Estructura del código

### Componentes principales

- **`Stopwatch`**: Componente principal que contiene toda la lógica del temporizador.
    - **`useState`**: Maneja el estado del tiempo, el estado activo y los intervalos guardados.
    - **`useRef`**: Referencia al temporizador para controlar el intervalo.

### Funciones clave

- **`toggleTimer`**: Inicia o pausa el temporizador.
- **`resetTimer`**: Reinicia el temporizador y detiene el intervalo.
- **`saveInterval`**: Guarda el tiempo actual en la lista de intervalos.
- **`formatTime`**: Formatea el tiempo en minutos y segundos.

## Estilos

El diseño utiliza variables CSS para colores y estilos consistentes. La interfaz es responsiva y fácil de usar.
