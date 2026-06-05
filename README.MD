# 🔧 PIC Micro Embedded Projects

A collection of small embedded hardware/software projects built around **Microchip PIC** microcontrollers. Each project includes firmware written in **PicBasic Pro** (v1.6–3.0) and a PCB layout designed in **Sprint Layout 5.0**.

---

## 🛠 Tools & Environment

| Tool | Version |
|---|---|
| **PicBasic Pro** | 1.6 – 3.0 |
| **Sprint Layout** | 5.0 |
| **Target MCUs** | PIC12F629, PIC16F84, PIC16F628, PIC18F4550 |

---

## 📁 Projects

### 🌡 TweetTermo
**MCU:** PIC16F628  
Temperature monitoring project. Reads temperature sensor data and outputs/transmits readings.

---

### 💡 BMW Additional Lights
**MCU:** —  
Controller for additional/auxiliary lighting on BMW vehicles. Handles switching logic for fog lights, DRL, or other auxiliary lamp circuits.

---

### 📞 GSM Call Controller
**MCU:** PIC16F628  
Controls a relay or output based on incoming GSM calls. Useful for remote switching via mobile phone without data/internet.

---

### 🔦 Pick by Light
**MCU:** —  
Pick-by-light system for warehouse/industrial use. Illuminates indicators to guide operators during order picking.

---

### ⏰ RTC Relay
**MCU:** PIC12F629  
Real-time clock based relay controller. Switches outputs on a configurable time schedule using an RTC module.

---

### 🌡 Thermostat
**MCU:** PIC16F84  
Simple thermostat controller. Reads a temperature sensor and switches a relay/output to control a heating or cooling device.

---

### ⏱ Time Relay
**MCU:** PIC16F84  
Programmable time-delay relay. Activates an output for a set duration after a trigger event.

---

## 📂 Project Structure

Each project folder typically contains:

```
project-name/
├── firmware/         # PicBasic Pro source (.bas)
├── pcb/              # Sprint Layout 5.0 file (.lay)
├── schematic/        # Schematic (image or file)
└── README.md         # Project-specific notes
```

---

## ⚡ Getting Started

### Firmware
1. Open `.bas` source files in **PicBasic Pro** (v1.6–3.0)
2. Compile and flash to the target PIC using a compatible programmer (e.g. PICkit, ICD)

### PCB
1. Open `.lay` files in **Sprint Layout 5.0**
2. Export Gerbers for manufacturing or print for DIY toner-transfer etching

---

## 📜 License

This repository is licensed under the **MIT License**.  
See [LICENSE](LICENSE) for details.
