# GameStore — React Frontend

A React + TypeScript application for managing games with basic CRUD operations.
It is the frontend for the [GameStore API](../GameStore.Api).

## Features

- View games in a table
- Add new games
- Edit existing games
- Delete games

## Prerequisites

- Node.js 18+ and npm
- The [GameStore API](../GameStore.Api) running on `http://localhost:5190`

## Setup

1. Install dependencies:
   ```bash
   npm install
   ```

2. Start the development server:
   ```bash
   npm run dev
   ```

3. Open `http://localhost:5173` in your browser.

Requests to `/api/*` are proxied to the API at `http://localhost:5190`
(configured in `vite.config.ts`), so no extra setup is required for local
development.

## Scripts

| Command           | Description                              |
| ----------------- | ---------------------------------------- |
| `npm run dev`     | Start the Vite dev server                |
| `npm run build`   | Type-check and build for production       |
| `npm run preview` | Preview the production build locally      |
| `npm run lint`    | Run ESLint                               |

## Technology Stack

- React 19
- TypeScript
- Vite
- React Router
- Bootstrap 5
