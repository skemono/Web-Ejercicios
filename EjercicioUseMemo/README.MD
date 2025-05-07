# Ejercicio React UserSearch

Este proyecto es una aplicación sencilla creada con React que permite buscar y agregar usuarios a una lista. La funcionalidad principal se basa en el uso del hook `useMemo` para optimizar el filtrado de usuarios.

## Características

- **Búsqueda de usuarios**: Filtra usuarios por nombre o descripción en tiempo real.
- **Agregar usuarios**: Permite agregar nuevos usuarios con un nombre y una descripción.
- **Interfaz amigable**: Diseño simple y limpio con estilos CSS personalizados.

## Tecnologías utilizadas

- **React**: Biblioteca para construir interfaces de usuario.
- **ReactDOM**: Para renderizar componentes en el DOM.
- **Babel**: Para procesar JSX.
- **HTML y CSS**: Estructura y estilos de la aplicación.

## Instalación

1. Clona este repositorio en tu máquina local.
2. Abre el archivo `index.html` en tu navegador para ejecutar la aplicación.

## Código principal

El componente principal es `UserSearch`, que incluye:

- **Estado**:
    - `searchText`: Texto de búsqueda ingresado por el usuario.
    - `users`: Lista de usuarios.
    - `newUser`: Objeto para manejar los datos del nuevo usuario.

- **Funciones**:
    - `handleAddUser`: Agrega un nuevo usuario a la lista.
    - `filteredUsers`: Filtra los usuarios según el texto de búsqueda utilizando `useMemo`.

## Estructura del proyecto

```
EjercicioUseMemo/
├── index.html
├── README.md
└── styles.css
```

## Uso

1. Escribe en el campo de búsqueda para filtrar usuarios por nombre o descripción.
2. Agrega un nuevo usuario completando los campos de nombre y descripción, y presiona el botón "Agregar Usuario".
