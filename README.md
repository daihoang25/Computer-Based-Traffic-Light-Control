# Traffic Light Control System using PIC Microcontroller and C# Interface

## 📌 Overview
This project demonstrates the communication between a **PC (C# application)** and a **PIC16F887 microcontroller** for controlling and simulating a **traffic light system**.  

The system uses **UART serial communication** over virtual COM ports and controls LEDs through a **74HC595 shift register** and **7-segment displays**. The traffic light logic is simulated in **Proteus** and visualized in a **C# Windows Form application**.

---

## ⚙️ Features
- PC ↔ Microcontroller communication via **UART (RS232)**.  
- Configurable serial settings (baud rate, parity, data bits, stop bits).  
- **Traffic light timing control** from PC to microcontroller.  
- **Real-time synchronization**:
  - Proteus simulation displays the traffic light LEDs.  
  - C# application dynamically updates the UI (Red/Yellow/Green lights).  
- Expandable via **74HC595 shift register** to drive LEDs and 7-segment displays.  

---

## 🛠️ Tools and Requirements
- **Hardware/Software**:
  - PIC16F887 microcontroller  
  - 74HC595 shift register  
  - Proteus (circuit simulation)  
  - CCS Compiler (for PIC C code)  
  - Visual Studio (C# Form application)  
  - Virtual Serial Port Driver (for COM port emulation)  

- **Programming Languages**:
  - C (for PIC microcontroller, compiled with CCS)  
  - C# (for Windows Form application)  

---

## 🚦 System Architecture
1. **C# Form Application**  
   - Sends traffic light timing (4 steps) to the PIC via serial port.  
   - Receives state updates (`"RedA_GreenB"`, `"YellowA_RedB"`, etc.) from the PIC.  
   - Displays light status dynamically in the GUI.  

2. **PIC16F887 Microcontroller**  
   - Receives UART data, parses step timings, and controls LEDs/7-segment displays.  
   - Uses **74HC595** to expand outputs for LEDs.  
   - Sends feedback strings back to the PC.  

3. **Proteus Simulation**  
   - Emulates the circuit (PIC, 74HC595, LEDs, 7-segment).  
   - Verifies correct timing and light switching logic.  
