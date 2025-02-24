# Project Management API Backend

## Overview

This repository contains the backend API for a project management application built using ASP.NET 8 and SQLite. The API provides endpoints for managing projects, tasks, boards, comments, notebooks, notes, and users. This project is designed to serve as a backend for a project management application without authentication.

## Features

- **Projects**: Create, read, update, and delete projects.
- **Tasks**: Manage tasks within projects.
- **Boards**: Organize tasks into boards.
- **Comments**: Add comments to tasks.
- **Notebooks**: Create and manage notebooks.
- **Notes**: Add and manage notes within notebooks.
- **Users**: Basic user management (no authentication).

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQLite](https://www.sqlite.org/download.html)

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/project-management-api.git
   ```

2. Navigate to the project directory:
   ```bash
   cd project-management-api
   ```

3. Restore dependencies:
   ```bash
   dotnet restore
   ```

4. Run the application:
   ```bash
   dotnet run
   ```

### Database Setup

The project uses SQLite as the database. The database file will be created automatically when you run the application for the first time. You can find the database file at `./Data/project_management.db`.

### API Endpoints

#### Projects

- **GET /api/projects**: Retrieve all projects.
- **POST /api/projects**: Create a new project.
- **GET /api/projects/{id}**: Retrieve a project by ID.
- **PUT /api/projects/{id}**: Update a project.
- **DELETE /api/projects/{id}**: Delete a project.

#### Tasks

- **GET /api/tasks**: Retrieve all tasks.
- **POST /api/tasks**: Create a new task.
- **GET /api/tasks/{id}**: Retrieve a task by ID.
- **PUT /api/tasks/{id}**: Update a task.
- **DELETE /api/tasks/{id}**: Delete a task.

#### Boards

- **GET /api/boards**: Retrieve all boards.
- **POST /api/boards**: Create a new board.
- **GET /api/boards/{id}**: Retrieve a board by ID.
- **PUT /api/boards/{id}**: Update a board.
- **DELETE /api/boards/{id}**: Delete a board.

#### Comments

- **GET /api/comments**: Retrieve all comments.
- **POST /api/comments**: Create a new comment.
- **GET /api/comments/{id}**: Retrieve a comment by ID.
- **PUT /api/comments/{id}**: Update a comment.
- **DELETE /api/comments/{id}**: Delete a comment.

#### Notebooks

- **GET /api/notebooks**: Retrieve all notebooks.
- **POST /api/notebooks**: Create a new notebook.
- **GET /api/notebooks/{id}**: Retrieve a notebook by ID.
- **PUT /api/notebooks/{id}**: Update a notebook.
- **DELETE /api/notebooks/{id}**: Delete a notebook.

#### Notes

- **GET /api/notes**: Retrieve all notes.
- **POST /api/notes**: Create a new note.
- **GET /api/notes/{id}**: Retrieve a note by ID.
- **PUT /api/notes/{id}**: Update a note.
- **DELETE /api/notes/{id}**: Delete a note.

#### Users

- **GET /api/users**: Retrieve all users.
- **POST /api/users**: Create a new user.
- **GET /api/users/{id}**: Retrieve a user by ID.
- **PUT /api/users/{id}**: Update a user.
- **DELETE /api/users/{id}**: Delete a user.

## Contributing

Contributions are welcome! Please follow these guidelines:

1. Fork the repository.
2. Create a new branch: `git checkout -b feature/your-feature-name`.
3. Commit your changes: `git commit -m "Add your feature"`.
4. Push to the branch: `git push origin feature/your-feature-name`.
5. Open a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact

For any questions or issues, please contact [your-email@example.com](mailto:your-email@example.com).
