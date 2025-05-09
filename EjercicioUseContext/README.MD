# Ejercicio React Tema Claro/Oscuro

Este proyecto es una aplicación sencilla creada con **React** que demuestra cómo implementar un cambio de tema (claro/oscuro) utilizando **React Context**.

## 🚀 Tecnologías Utilizadas

- **React**: Biblioteca para construir interfaces de usuario.
- **ReactDOM**: Renderizado de componentes React en el DOM.
- **Babel**: Para procesar JSX.
- **HTML5 y CSS3**: Estructura y estilos de la aplicación.

## 🎨 Estilo

La aplicación utiliza un diseño limpio y moderno con colores definidos en variables CSS:

- **Color primario**: `#f39c12`
- **Color secundario**: `#e67e22`
- **Color de texto**: `#333`
- **Gris claro**: `#fdf2e9`
- **Fondo oscuro**: `#333`
- **Texto oscuro**: `#fef9e7`

## 🛠️ Funcionalidades

1. **Cambio de Tema**:  
    - Alterna entre los temas claro y oscuro con un botón.

2. **Uso de React Context**:  
    - Implementa un contexto para compartir el estado del tema entre componentes.

## 📂 Estructura del Código

### Componente Principal: `App`

- **Estado**:  
  - `isDarkMode`: Indica si el tema oscuro está activado.
- **Funciones**:  
  - `toggleTheme`: Alterna entre los temas claro y oscuro.

### Componentes Secundarios

- **`ThemeProvider`**:  
  - Proveedor del contexto del tema.
- **`ThemeToggle`**:  
  - Botón para alternar entre temas.
- **`ThemeDisplay`**:  
  - Muestra el contenido con el tema seleccionado.

## 📋 Cómo Usar

1. Abre el archivo `index.html` en tu navegador.
2. Haz clic en el botón "Cambiar Tema" para alternar entre el tema claro y oscuro.

## 📜 Código Destacado

```jsx
function ThemeProvider({ children }) {
     const [isDarkMode, setIsDarkMode] = React.useState(false);

     const toggleTheme = () => {
          setIsDarkMode(!isDarkMode);
     };

     return (
          <ThemeContext.Provider value={{ isDarkMode, toggleTheme }}>
                {children}
          </ThemeContext.Provider>
     );
}

function ThemeToggle() {
     const { toggleTheme } = React.useContext(ThemeContext);

     return (
          <div className="theme-toggle">
                <button onClick={toggleTheme}>Cambiar Tema</button>
          </div>
     );
}

function ThemeDisplay() {
     const { isDarkMode } = React.useContext(ThemeContext);

     return (
          <div className={`container ${isDarkMode ? 'dark-theme' : 'light-theme'}`}>
                <h1>{isDarkMode ? 'Modo Oscuro' : 'Modo Claro'}</h1>
                <p>Este es un ejemplo de cómo cambiar entre temas usando React Context.</p>
          </div>
     );
}
```

## 🌟 Créditos

Este proyecto fue creado para practicar el uso de **React Context** y el diseño de temas dinámicos.  