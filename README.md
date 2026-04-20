# ConnectFour-SODV1202
This is our final project.

# Connect Four – SODV 1202 Term Project

## Team Name
Quantum Connectors

## Team Members
- Bibek Panta  
- Nyein Chan Tun  

---

## Project Overview
This project is a console-based implementation of the classic Connect Four game developed in C#. Two players take turns dropping discs into a 7x6 grid. The objective is to connect four of the same symbols horizontally, vertically, or diagonally.

---

## Features
- Two-player gameplay (Human vs Human)
- 7x6 game board
- Input validation (prevents invalid or full column moves)
- Automatic win detection
- Draw detection
- Replay option after game ends
- Clean console-based user interface

---

## How to Run the Program
1. Open the project in Visual Studio 2022  
2. Build the solution  
3. Run the program (Press **F5** or click Start)  
4. Enter column numbers (1–7) to play  

---

## Object-Oriented Programming Concepts Used

### Abstraction
- The `Player` class is an abstract class that defines the structure for all player types.

### Inheritance
- The `HumanPlayer` class inherits from the `Player` class.

### Polymorphism
- The `MakeMove()` method is overridden in the `HumanPlayer` class.

### Encapsulation
- The `Model` class manages the game board and logic internally, protecting data from direct access.

---

## Project Structure
- `Program.cs` → Entry point of the application  
- `Controller.cs` → Manages game flow and logic  
- `Model.cs` → Handles board state and game rules  
- `View.cs` → Displays output to the console  
- `Player.cs` → Abstract base class  
- `HumanPlayer.cs` → Implements player input  

---

## GitHub Repository
https://github.com/bibekpanta007/ConnectFour-SODV1202

---

## Notes
- The project follows clean coding practices and proper object-oriented design.
- Development progress is tracked through regular Git commits.
