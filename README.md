# GameStore

A full-stack sample application for managing a catalog of games, built with an
**ASP.NET Core minimal API** backend and a **React + TypeScript** frontend.

It demonstrates a clean, end-to-end CRUD stack: EF Core with SQLite, DTO-based
endpoints, request validation, and a Vite-powered React SPA that talks to the
API through a dev proxy.

## Tech Stack

| Layer      | Technology                                              |
| ---------- | ------------------------------------------------------- |
| Backend    | ASP.NET Core 10 (Minimal APIs), C#                      |
| Data       | Entity Framework Core 10, SQLite                         |
| Frontend   | React 19, TypeScript, Vite, React Router, Bootstrap 5   |

## Repository Structure

```
.
├── GameStore.Api/       # ASP.NET Core minimal API (games + genres)
├── GameStore.React/     # React + TypeScript + Vite frontend
├── LICENSE              # MIT
└── README.md            # You are here
```

## Prerequisites

- [.NET SDK 10.0+](https://dotnet.microsoft.com/download)
- [Node.js 18+](https://nodejs.org/) and npm

## Getting Started

Clone the repository, then run the backend and frontend in two terminals.

### 1. Backend — GameStore.Api

```bash
cd GameStore.Api
dotnet restore
dotnet run
```

The API starts on `http://localhost:5190` (and `https://localhost:7045`).
The SQLite database and schema are created automatically on first run
(migrations are applied and genres are seeded at startup).

### 2. Frontend — GameStore.React

```bash
cd GameStore.React
npm install
npm run dev
```

The app starts on `http://localhost:5173`. Requests to `/api/*` are proxied to
the backend at `http://localhost:5190` (see `vite.config.ts`), so no extra
configuration is needed for local development.

## API Overview

Base URL: `http://localhost:5190`

| Method   | Route           | Description              |
| -------- | --------------- | ------------------------ |
| `GET`    | `/games`        | List all games           |
| `GET`    | `/games/{id}`   | Get a single game        |
| `POST`   | `/games`        | Create a game            |
| `PUT`    | `/games/{id}`   | Update a game            |
| `DELETE` | `/games/{id}`   | Delete a game            |
| `GET`    | `/genres`       | List all genres          |

A ready-to-use request collection lives in
[`GameStore.Api/games.http`](GameStore.Api/games.http).

## Configuration

The backend connection string is defined in
[`GameStore.Api/appsettings.json`](GameStore.Api/appsettings.json):

```json
"ConnectionStrings": {
  "GameStore": "Data Source=GameStore.db"
}
```

Database files (`*.db`) are generated at runtime and are intentionally
excluded from version control via `.gitignore`.

## Contributing

Contributions are welcome! Please see [CONTRIBUTING.md](CONTRIBUTING.md) for
guidelines on setting up your environment, coding style, and submitting pull
requests.

## License

This project is licensed under the [MIT License](LICENSE).
# GameStore
# GameStore
