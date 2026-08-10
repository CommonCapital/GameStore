# Contributing to GameStore

Thanks for your interest in contributing! This document explains how to get set
up and how to propose changes.

## Getting Started

1. Fork the repository and clone your fork.
2. Follow the setup steps in the [README](README.md) to run the backend and
   frontend locally.
3. Create a feature branch:
   ```bash
   git checkout -b feature/short-description
   ```

## Development Workflow

### Backend (`GameStore.Api`)

```bash
cd GameStore.Api
dotnet build      # compile
dotnet run        # run locally
```

- Target framework: .NET 10, nullable reference types enabled.
- Keep endpoints thin; use DTOs (see `Dtos/`) for request/response shapes.

### Frontend (`GameStore.React`)

```bash
cd GameStore.React
npm install
npm run dev       # start dev server
npm run lint      # run ESLint
npm run build     # type-check + production build
```

Please make sure `npm run lint` and `npm run build` pass before opening a PR.

## Commit Messages

Write clear, imperative commit messages (e.g. "Add genre filter to games list").
Keep unrelated changes in separate commits where practical.

## Pull Requests

1. Ensure the backend builds and the frontend lints and builds.
2. Describe **what** changed and **why** in the PR description.
3. Link any related issues.

## Reporting Issues

Open a GitHub issue with:
- What you expected to happen
- What actually happened
- Steps to reproduce
- Environment details (OS, .NET SDK version, Node version)

## Code of Conduct

Please be respectful and constructive. See [CODE_OF_CONDUCT.md](CODE_OF_CONDUCT.md).
