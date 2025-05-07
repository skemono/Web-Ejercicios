# Ejercicio React Intro

Este proyecto es una aplicación sencilla de comentarios creada con **React**. Permite a los usuarios agregar comentarios y mostrarlos en una lista dinámica.

## 🚀 Tecnologías Utilizadas

- **React**: Biblioteca para construir interfaces de usuario.
- **ReactDOM**: Renderizado de componentes React en el DOM.
- **Babel**: Para procesar JSX.
- **HTML5 y CSS3**: Estructura y estilos de la aplicación.

## 🎨 Estilo

La aplicación utiliza un diseño limpio y moderno con colores definidos en variables CSS:

- **Color primario**: `#3498db`
- **Color secundario**: `#2980b9`
- **Color de texto**: `#333`
- **Gris claro**: `#f5f5f5`

## 🛠️ Funcionalidades

1. **Formulario de Comentarios**:  
    - Permite a los usuarios escribir y enviar comentarios.
    - Valida que el campo no esté vacío antes de agregar el comentario.

2. **Lista de Comentarios**:  
    - Muestra los comentarios enviados en una lista.
    - Si no hay comentarios, se muestra un mensaje indicando que la lista está vacía.

## 📂 Estructura del Código

### Componente Principal: `App`

- **Estado**:  
  - `comentarios`: Lista de comentarios agregados.
- **Funciones**:  
  - `agregarComentario`: Agrega un nuevo comentario al estado.

### Componente Secundario: `CommentForm`

- **Estado**:  
  - `inputValue`: Controla el valor del campo de entrada.
- **Funciones**:  
  - `manejarEnvio`: Envía el comentario al componente principal.

## 📋 Cómo Usar

1. Clona este repositorio.
2. Abre el archivo `index.html` en tu navegador.
3. Escribe un comentario en el campo de texto y presiona "Enviar".
4. ¡Mira cómo aparece tu comentario en la lista!

## 📜 Código Destacado

```jsx
function App() {
     const [comentarios, setComentarios] = React.useState([]);
     
     const agregarComentario = (nuevoComentario) => {
          setComentarios([...comentarios, nuevoComentario]);
     };
     
     return (
          <div className="container">
                <h1>Aplicación de Comentarios</h1>
                <CommentForm onSubmit={agregarComentario} />
                <div>
                     <h3>Comentarios:</h3>
                     {comentarios.length > 0 ? (
                          <ul className="comments-list">
                                {comentarios.map((comentario, index) => (
                                     <li key={index} className="comment-item">{comentario}</li>
                                ))}
                          </ul>
                     ) : (
                          <div className="empty-comments">Empieza agregando un comentario...</div>
                     )}
                </div>
          </div>
     );
}
```
