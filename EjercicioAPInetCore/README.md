Aquí tienes el readme modificado con algunos emojis para hacerlo más visual:

---

# API con .NET Core y SQL Server 💻🗄️

Este ejercicio tiene como objetivo desarrollar una API utilizando .NET Core, la cual se conectará a una base de datos SQL Server. A continuación se detallan los pasos para configurar y ejecutar el proyecto desde la línea de comandos.

## Prerrequisitos 🔧

Antes de ejecutar el proyecto, asegúrate de tener instalados los siguientes componentes:

- **Docker** 🐳: Descarga e instala Docker para levantar los contenedores y tenlo corriendo.
- **Git** (opcional) 🔗: Para clonar el repositorio si aún no tienes los archivos del proyecto.

## Instrucciones de Configuración 🚀

1. **Clonar el Repositorio**  
   Si aún no has descargado el proyecto, clónalo usando Git:
   ```bash
   git clone https://github.com/skemono/EjercicioAPInetCore.git
   ```
2. **Entrar a la carpeta principal** 📂  
   ```bash
   cd EjercicioAPInetCore
   ```
3. **Buildea los contenedores con Docker Compose** 🐋  
   ```bash
   docker-compose up --build
   ```
   La aplicación estará escuchando en http://localhost:8080 con Swagger y en http://localhost:8080/incidents directamente para hacer llamadas a la API.

## Endpoints 📡

- **POST /incidents** ➕  
  Crea un nuevo incidente.

- **GET /incidents** 📋  
  Obtiene la lista de incidentes.

- **GET /incidents/{id}** 🔍  
  Obtiene un incidente específico.

- **PUT /incidents/{id}** ✏️  
  Actualiza los datos de un incidente.

- **DELETE /incidents/{id}** 🗑️  
  Elimina un incidente existente.

---
