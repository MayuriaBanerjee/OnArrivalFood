# OAF — On Arrival Food 🍽️🚀

OAF (On Arrival Food) is a modern full-stack restaurant reservation and food pre-ordering platform built using the latest Angular and ASP.NET Core technologies.

The main goal of OAF is to solve a real-world restaurant problem:

> Customers often reach restaurants hungry and still need to:
> - wait for tables
> - order food
> - wait for preparation
>
> OAF eliminates this waiting time.

With OAF, users can:
- reserve seats before arrival
- pre-order food
- schedule arrival time
- get food ready when they arrive

---

# 🌟 Core Idea

OAF allows customers to:
1. Browse restaurants
2. Reserve tables
3. Pre-order meals
4. Schedule arrival time
5. Reach restaurant and get food immediately

This creates:
- better customer experience
- reduced waiting time
- better restaurant planning
- smarter order management

---

# 🛠️ Tech Stack

## Frontend
- Angular (Latest)
- Angular Material
- Tailwind CSS
- RxJS
- TypeScript

## Backend
- ASP.NET Core Web API (.NET Latest)
- SignalR
- Entity Framework Core
- JWT Authentication

## Database
- PostgreSQL / SQL Server (planned)

## DevOps
- Docker
- GitHub Actions
- Azure Deployment

---

# 📂 Project Structure

```text
OAF_Workspace/
│
├── backend/
│   └── OAF.API/
│
├── frontend/
│   └── oaf-client/
│
├── docs/
│
└── README.md
🧱 Backend Architecture
OAF.API/
│
├── Controllers/
├── Services/
├── Interfaces/
├── Repositories/
├── Models/
├── DTOs/
├── Data/
├── Middleware/
├── SignalR/
├── Helpers/
├── Validators/
└── Features/
🎨 Frontend Architecture
src/app/
│
├── core/
├── shared/
├── features/
├── layout/
├── services/
├── models/
├── guards/
├── interceptors/
└── store/
✨ Planned Features
Customer Features
Restaurant browsing
Table reservation
Food pre-ordering
ETA-based ordering
Cart system
Real-time order tracking
Reservation management
Responsive UI
Restaurant Dashboard
Reservation management
Order management
Menu management
Live kitchen updates
Seat availability tracking
Admin Features
Analytics dashboard
Restaurant management
User management
Revenue insights
⚡ Real-Time Features

Using SignalR:

live reservation updates
order status updates
kitchen notifications
seat availability updates
🤖 Future AI Features

Planned AI-powered features:

food recommendation engine
smart ETA prediction
AI restaurant assistant
demand forecasting
smart kitchen scheduling
📅 3-Month Development Goal

The objective of this project is to:

learn enterprise Angular architecture
build scalable .NET APIs
understand real-time systems
create production-style full-stack applications
build a strong portfolio project
🚀 Getting Started
Backend
cd backend/OAF.API
dotnet run

Backend runs on:

http://localhost:5082
Frontend
cd frontend/oaf-client
ng serve

Frontend runs on:

http://localhost:4200
📌 Current Status
Completed
Development environment setup
ASP.NET Core API setup
Angular application setup
GitHub repository setup
In Progress
UI architecture
Restaurant module
Reservation workflow
📖 Learning Journey

This project is being built as a complete learning journey covering:

Angular
ASP.NET Core
REST APIs
Authentication
SignalR
Database design
Docker
Cloud deployment
Enterprise architecture
👩‍💻 Developer

Built by Mayuria Banerjee

⭐ Vision

OAF aims to become a smart restaurant arrival management platform where customers never need to wait unnecessarily for food and seating.

📜 License

This project is currently under development for educational and portfolio purposes.
