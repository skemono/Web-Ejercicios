# Ejercicio React Intro

Este proyecto es una aplicación sencilla de comentarios creada con **React**. Permite a los usuarios agregar comentarios y mostrarlos en una lista dinámica.

## Características

- **Agregar comentarios**: Los usuarios pueden escribir y agregar comentarios a través de un formulario interactivo.
- **Lista dinámica**: Los comentarios se muestran en una lista que se actualiza automáticamente.
- **Diseño limpio y moderno**: Utiliza estilos CSS personalizados para una mejor experiencia visual.

## Tecnologías utilizadas

- **React**: Biblioteca de JavaScript para construir interfaces de usuario.
- **ReactDOM**: Para renderizar componentes React en el DOM.
- **Babel**: Para procesar JSX y convertirlo en JavaScript compatible con navegadores.
- **HTML5 y CSS3**: Para la estructura y el diseño de la aplicación.

## Estructura del proyecto

```plaintext
EjercicioReactIntro/
├── index.html   # Archivo principal con el código React
├── README.md    # Este archivo
```

## Cómo usar

1. **Clona el repositorio** o copia el archivo `index.html` en tu proyecto.
2. Abre el archivo `index.html` en tu navegador.
3. Escribe un comentario en el campo de texto y presiona el botón "Enviar".
4. ¡Mira cómo tu comentario aparece en la lista!

## Captura de pantalla

![Captura de pantalla de la aplicación](https://via.placeholder.com/800x400?text=Captura+de+la+Aplicaci%C3%B3n)

## Código principal

El siguiente es el código principal de la aplicación:

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

## Estilos CSS

El diseño utiliza variables CSS para colores y estilos consistentes:

```css
:root {
    --primary-color: #3498db;
    --secondary-color: #2980b9;
    --text-color: #333;
    --light-gray: #f5f5f5;
    --border-color: #ddd;
}
```
