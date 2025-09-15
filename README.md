----

# C\# Demo: Logical Cohesion and Control Coupling

This is a simple C\# console application designed to demonstrate two key software design principles: **Logical Cohesion** and **Control Coupling**. It uses characters from the game Honkai: Star Rail as a thematic example.

## Core Concepts Demonstrated

This project is a practical example of design patterns that are often discussed in software engineering.

### 1\. Logical Cohesion 🧰

Logical cohesion occurs when a module's parts are grouped together because they fall into a similar logical category, even if they are functionally different and independent.

  * **In this project:** The `HsrChar` class is logically cohesive.
  * **Why:** The private methods `DisplayInfo()`, `ShowPath()`, and `CheckElement()` are all independent actions. They are grouped together and managed by a single controller method (`Cek`) simply because they are all logically "checks" or "actions" you can perform on a character. The class acts like a "toolbox" for character-related actions.

### 2\. Control Coupling 🚦

Control coupling occurs when one module passes a "flag" or command to another module, telling it what to do and thus controlling its logic.

  * **In this project:** The `Cek(string Type)` method demonstrates this.
  * **Why:** The `Program.cs` file doesn't just pass data; it passes a command string (`"info"`, `"path"`, etc.) that dictates which part of the `Cek` method's `switch` statement will execute. The calling module is "controlling" the logic of the `HsrChar` class, much like a remote control sending commands to a TV.

## How to Run

1.  Make sure you have the .NET SDK installed.
2.  Open a terminal in the project's root directory.
3.  Run the following command:

<!-- end list -->

```bash
dotnet run
```

## Code Structure

  * `HsrChar.cs`: Defines the character class. This file contains the `Cek` method, which is the primary example of logical cohesion and control coupling.
  * `Program.cs`: The main entry point for the application. It creates instances of `HsrChar` and calls the `Cek` method with different commands to demonstrate the concepts.

## Example Output

```console
--- Character Actions ---
Info Dan Heng : Character: Dan Heng [Wind | The Hunt]
Info Phainon : Character: Phainon [Physical | Destruction]
Path : Phainon follows the Path of 'Destruction'.
Element : Dan Heng's Element is Wind.
Ultimate : No such check is in here
```
