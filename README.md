# CountingFrozenSegments

**CountingFrozenSegments** is a C# console application that simulates the melting of ice blocks in a frozen tunnel due to cold air exposure. The program calculates how many ice blocks melt based on a specific rule and visualizes the process through a simple console interface.

---

## 🧊 Project Overview

The frozen tunnel is represented as a string:

- `I` → Ice block  
- `_` → Cold air  

**Melting Rule:**
- Whenever **three consecutive air cells `___`** appear, the **first ice block immediately after** this triple-air segment melts (turns into `_`).  
- This melting may create new triple-air segments, and the process **repeats** until no more ice can melt.  

The program outputs the **total number of ice blocks that melted**.

---

## 🚀 Features

- Calculates ice melting dynamically until stability is reached.
- Handles multiple consecutive melting events caused by newly exposed air.
- User-friendly console input and output.
- Lightweight and simple C# implementation.

---

## 💻 How to Run

1. Clone the repository or download the project files.  
2. Open the project in **Visual Studio**.  
3. Build the solution (`Ctrl + Shift + B`).  
4. Run the application (`F5` or `Ctrl + F5`).  
5. Enter the frozen tunnel pattern when prompted.  

Example input:

Enter the frozen tunnel pattern (I for ice, _ for cold air):
___I__I_I

lua
Copy code

Example output:

Total ice blocks melted: 2

yaml
Copy code

---

## 📝 Example Cases

| Tunnel Pattern      | Melted Ice Blocks |
|--------------------|-----------------|
| `___I_I___I`       | 2               |
| `I__I__I`          | 0               |
| `___I___I___I`     | 3               |

---

## ⚙️ Technologies Used

- **C#**
- **.NET** Console Application

---

## 📂 Project Structure

CountingFrozenSegments/
│
├─ Program.cs # Main logic and ice melting algorithm
├─ CountingFrozenSegments.csproj
├─ CountingFrozenSegments.sln
└─ README.md # Project documentation

yaml
Copy code

---

## 🛠 Author

**Youssef Sameh**  
Email: [youssefelazab46@gmail.com](mailto:youssefelazab46@gmail.com)

---

## 📜 License

This project is licensed under the MIT License. See the LICENSE file for details.
