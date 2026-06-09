# Calculator Application (Windows Forms / C#) 🧮

<p align="center">
<img src="https://skillicons.dev"/>
</p>

A responsive, lightweight **desktop calculator application** built using **C#** and **Windows Forms**. The project implements an event-driven control flow to process multi-step arithmetic calculations, decimal positioning, and real-time input backspacing.

---

## ✨ Features

* **Dual-Screen UI Layout:** Features an upper tracking display (`labScreen`) for current operations and a lower input screen (`labResult`) for immediate feedback.
* **Unified Event Routing:** Uses dynamic control casting (`(Button)sender`) to route all numerical inputs through a centralized click handler.
* **Basic Arithmetic Engine:** Evaluates floating-point mathematical equations for addition, subtraction, multiplication, and division.
* **In-Flight Data Correction:** Includes an index-safe backspace mechanism (`button15_Click`) using string truncation to remove trailing characters safely.
* **State Reset Utility:** A global clear controller (`btnClose_Click`) that wipes execution variables, resets screen buffers, and restores `FirstNumber` memory states to zero.
* **Defensive Decimal Insertion:** Protects calculation strings from formatting faults by validation-checking user inputs before binding decimals.

---

## 🛠️ Tech Stack & Architecture

* **Language:** C#
* **Framework:** .NET / Windows Forms (WinForms)
* **Design Pattern:** Event-Driven Programming with structural type parsing.

---

## 📂 Core Logic Breakdown

The architectural layout of `Form1.cs` utilizes these essential operational blocks:
* `NumbersBTNsClick`: Appends numerical string literals extracted from component `Tag` properties directly into UI screen buffers.
* `ArithmeticBTNsClick`: Offloads text data into execution memory (`FirstNumber`), binds operation operators, and clears the secondary viewport for next inputs.
* `Result`: The calculation engine that checks operational states (`+`, `-`, `*`, `/`) and processes computational data through native mathematical operators.
* `button14_Click`: Validates and appends decimal points safely to ensure functional data integrity before evaluation conversion.
* `button15_Click`: Executes string index mutations via `String.Remove` to deliver granular character erasure.

---

## 🚀 How to Run & Build

1. **Clone the Repository:**
   ```bash
   git clone https://github.com
   ```
2. **Open the Project:** Launch the `.sln` or `.csproj` file inside **Visual Studio 2022** (or higher).
3. **Configure UI Tags:** Ensure your form buttons have their matching numerical or arithmetic symbols configured in their **Tag property** via the properties window.
4. **Compile and Run:** Press `F5` or click **Start** inside Visual Studio to execute the binary application.

