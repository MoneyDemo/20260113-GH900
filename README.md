# TODO Web Application

A Java-based TODO web application built with Spring Boot, featuring CRUD operations and a modern UI.

## 🎯 Features

- ✅ Create new TODO items
- ✅ View all TODO items
- ✅ Edit existing TODO items
- ✅ Delete TODO items
- ✅ Status management (PENDING, IN_PROGRESS, COMPLETED)
- ✅ Timestamp tracking
- ✅ Modern and responsive UI

## 🛠 Technical Stack

- **Language**: Java 17+
- **Framework**: Spring Boot 3.2.1
- **Build Tool**: Maven
- **Database**: H2 (in-memory)
- **View Engine**: Thymeleaf
- **ORM**: Spring Data JPA

## 📋 Requirements

- Java 17 or higher
- Maven 3.6 or higher

## 🚀 Getting Started

### Build the Application

```bash
mvn clean package
```

### Run the Application

```bash
mvn spring-boot:run
```

Or run the JAR file directly:

```bash
java -jar target/todo-app-1.0.0.jar
```

### Access the Application

Once the application is running, open your browser and navigate to:

```
http://localhost:8080
```

### H2 Database Console (Development)

To access the H2 database console:

```
http://localhost:8080/h2-console
```

Connection details:
- JDBC URL: `jdbc:h2:mem:tododb`
- Username: `sa`
- Password: (leave empty)

## 📁 Project Structure

```
src/
├── main/
│   ├── java/com/example/todo/
│   │   ├── TodoApplication.java          # Main application class
│   │   ├── controller/
│   │   │   └── TodoController.java       # Web controller
│   │   ├── model/
│   │   │   └── Todo.java                 # Entity model
│   │   ├── repository/
│   │   │   └── TodoRepository.java       # Data access layer
│   │   └── service/
│   │       └── TodoService.java          # Business logic layer
│   └── resources/
│       ├── application.properties         # Application configuration
│       ├── static/css/
│       │   └── style.css                  # Stylesheet
│       └── templates/
│           ├── index.html                 # List all TODOs
│           ├── create.html                # Create TODO form
│           └── edit.html                  # Edit TODO form
└── test/
    └── java/com/example/todo/
```

## 🎨 Usage

### Creating a TODO

1. Click on the "+ 新增 TODO" button
2. Fill in the title (required)
3. Add a description (optional)
4. Select a status
5. Click "建立 TODO"

### Editing a TODO

1. Click the "編輯" button next to the TODO you want to edit
2. Modify the fields
3. Click "更新 TODO"

### Deleting a TODO

1. Click the "刪除" button next to the TODO you want to delete
2. Confirm the deletion

## 📝 TODO Model

The TODO entity contains the following fields:

- `id`: Unique identifier (auto-generated)
- `title`: Title of the TODO (required, max 200 characters)
- `description`: Detailed description (optional, max 1000 characters)
- `status`: Current status (PENDING, IN_PROGRESS, COMPLETED)
- `createdAt`: Timestamp of creation (auto-generated)

## 🔧 Configuration

Application settings can be modified in `src/main/resources/application.properties`:

- Server port: `server.port=8080`
- Database URL: `spring.datasource.url=jdbc:h2:mem:tododb`
- H2 Console: `spring.h2.console.enabled=true`

## 📄 License

This project is licensed under the MIT License - see the LICENSE file for details.
# 20260113-GH900

Demo site

Demo2
