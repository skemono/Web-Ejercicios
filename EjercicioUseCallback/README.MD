# Ejercicio Renderizado de Hijos

Este proyecto es una aplicación sencilla creada con **React** que demuestra el uso de `useCallback` para optimizar el renderizado de componentes.

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

## 🛠️ Funcionalidades

1. **Generar Número Aleatorio**:  
    - Utiliza un botón optimizado con `React.useCallback` para evitar renderizados innecesarios.

2. **Incrementar Contador**:  
    - Utiliza un botón normal que incrementa el contador sin optimización.

## 📂 Estructura del Código

### Componente Principal: `CartaDeElementos`

- **Estado**:  
  - `randomNumber`: Número aleatorio generado.
  - `counter`: Contador que se incrementa.
- **Funciones**:  
  - `createRandom`: Genera un número aleatorio (optimizado con `useCallback`).
  - `addCounter`: Incrementa el contador.

### Componentes Secundarios

- **`ButtonOptimizado`**:  
  - Botón optimizado para evitar renderizados innecesarios.
- **`ButtonNormal`**:  
  - Botón sin optimización.

## 📋 Cómo Usar

1. Abre el archivo `index.html` en tu navegador.
2. Haz clic en "Generar Número Aleatorio" para generar un número aleatorio.
3. Haz clic en "Incrementar Contador" para incrementar el contador.

## 📜 Código Destacado

```jsx
function CartaDeElementos() {
     const [randomNumber, setRandomNumber] = React.useState(0);
     const [counter, setCounter] = React.useState(0);

     const createRandom = React.useCallback(() => {
          const newRandom = Math.floor(Math.random() * 100);
          setRandomNumber(newRandom);
     }, []);

     const addCounter = () => {
          setCounter(prevCounter => prevCounter + 1);
     };

     return (
          <div className="container">
                <h1>Carta de Elementos</h1>
                <div className="card">
                     <p>Número aleatorio: {randomNumber}</p>
                     <p>Contador: {counter}</p>
                     <ButtonOptimizado onClick={createRandom}>
                          Generar Número Aleatorio
                     </ButtonOptimizado>
                     <ButtonNormal onClick={addCounter}>
                          Incrementar Contador
                     </ButtonNormal>
                </div>
          </div>
     );
}
```
