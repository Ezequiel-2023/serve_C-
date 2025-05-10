### 📚 API Web ASP.NET Core + MongoDB

Esta es una API RESTful creada con ASP.NET Core, basada en la documentación oficial de .NET, que implementa un CRUD completo utilizando MongoDB como base de datos.

---

## 🧪 Tecnologías utilizadas

- ASP.NET Core 9
- MongoDB (Atlas)
- C#
- Swagger (OpenAPI)

---

## 🚀 Cómo comenzar

### 1. 🔁 Clona este repositorio

```bash
git clone https://github.com/tu_usuario/tu_repositorio.git
cd tu_repositorio
2. ⚙️ Configura el archivo appsettings.json
Edita la cadena de conexión para MongoDB (por ejemplo, usando MongoDB Atlas):
```

Después de clonar el repositorio, incluye en el archivo `appsettings.json` y  `Program.cs` tus variables de entorno 

```bash

 "MONGO_CONNECTION_STRING",// variable de entorno para credenciales de mongo db
   
```




### 3. ▶️ Ejecuta el proyecto
```bash
dotnet run
Esto iniciará el servidor y mostrará la URL de acceso en consola, por ejemplo:

http://localhost:5263/api/books

```

### 🔗 Endpoints disponibles

📖 Libros
```bash
GET /api/books – Obtener todos los libros

GET /api/books/{id} – Obtener un libro por ID

POST /api/books – Crear un nuevo libro

PUT /api/books/{id} – Actualizar un libro existente

DELETE /api/books/{id} – Eliminar un libro

```
### 📘 Documentación interactiva (Swagger)

Accede a la interfaz de Swagger para probar la API desde el navegador:
```bash
http://localhost:5263/swagger
```

### ✅ Requisitos
.NET SDK 9 o superior

MongoDB Atlas (o local)

Visual Studio Code (recomendado) + extensión C#

Remplazar variables de entorno para la conexiona la base de datos 

📬 Contacto o sugerencias
Puedes sugerir mejoras o reportar errores creando un Issue o un Pull Request en este repositorio.

