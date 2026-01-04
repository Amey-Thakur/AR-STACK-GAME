<div align="center">

  # AR Stack Builder Game

  [![License: MIT](https://img.shields.io/badge/License-MIT-lightgrey)](LICENSE)
  ![Status](https://img.shields.io/badge/Status-Completed-success)
  [![Platform](https://img.shields.io/badge/Platform-Android-blueviolet)](https://github.com/Amey-Thakur/AR-STACK-GAME)
  [![Technology](https://img.shields.io/badge/Technology-Unity%20%7C%20ARCore-orange)](https://github.com/Amey-Thakur/AR-STACK-GAME)
  [![Developed by](https://img.shields.io/badge/Developed%20by-Amey%20Thakur%20%26%20Hasan%20Rizvi-blue)](https://github.com/Amey-Thakur/AR-STACK-GAME)

  An immersive Augmented Reality stack builder game developed for Android using Google's ARCore SDK and Unity Engine.

  **[Download APK](https://github.com/Amey-Thakur/AR-STACK-GAME/blob/main/AR-Stack-Game.apk?raw=true)** &nbsp;&middot;&nbsp; **[Source Code](Source%20Code/)**

</div>

---

<div align="center">

  [Authors](#authors) &nbsp;·&nbsp; [Overview](#overview) &nbsp;·&nbsp; [Features](#features) &nbsp;·&nbsp; [Structure](#project-structure) &nbsp;·&nbsp; [Quick Start](#quick-start) &nbsp;·&nbsp; [License](#license) &nbsp;·&nbsp; [About](#about-this-repository) &nbsp;·&nbsp; [Acknowledgments](#acknowledgments)

</div>

---

<!-- AUTHORS -->
<div align="center">

  ## Authors

  **Terna Engineering College | Computer Engineering | Batch of 2022**

  <table>
  <tr>
  <td align="center">
  <a href="https://github.com/Amey-Thakur">
  <img src="https://github.com/Amey-Thakur.png" width="150px;" alt="Amey Thakur"/><br />
  <sub><b>Amey Thakur</b></sub>
  </a>
  </td>
  <td align="center">
  <a href="https://github.com/rizvihasan">
  <img src="https://github.com/rizvihasan.png" width="150px;" alt="Hasan Rizvi"/><br />
  <sub><b>Hasan Rizvi</b></sub>
  </a>
  </td>
  </tr>
  </table>

  Special thanks to [Hasan Rizvi](https://github.com/rizvihasan) for his meaningful contributions, guidance, and support that helped shape this work.

</div>

---

<!-- OVERVIEW -->
## Overview

The **AR Stack Builder Game** is a Computer Graphics Mini-Project designed to explore the capabilities of Augmented Reality (AR) in mobile gaming. By leveraging **Google's ARCore** for plane detection and tracking, and **Unity** for 3D rendering and physics, this game allows players to stack 3D blocks in their real-world environment.

The objective is simple yet challenging: build the highest stack possible without letting it topple over, testing both the player's precision and the stability of the virtual structure in the physical world.

---

<!-- FEATURES -->
## Features

| Feature | Description |
|---------|-------------|
| **Immersive AR** | Places game elements in the real world using plane detection |
| **Physics Engine** | Realistic gravity and collision simulation for stacking blocks |
| **3D Rendering** | High-quality 3D assets rendered using Unity Engine |
| **Touch Controls** | Intuitive touch interface for positioning and dropping blocks |

### Tech Stack
- **Engine**: Unity 3D
- **AR SDK**: Google ARCore
- **Language**: C#
- **Platform**: Android

---

<!-- STRUCTURE -->
## Project Structure

```
AR-STACK-GAME/
│
├── Source Code/                     # C# Source Files
│   ├── StackManager.cs              # Game State Controller
│   ├── CubeSpawner.cs               # Block Spawner
│   ├── MovingCube.cs                # Physics & Slicing Logic
│   └── ARPlacementManager.cs        # ARCore Integration
│
├── AR-Stack-Game.apk                # Production Android Build
├── ARStackGame.unitypackage         # Unity Asset Exchange File
│
├── LICENSE                          # MIT License
├── CITATION.cff                     # Citation Metadata
└── README.md                        # Project Documentation
```

---

<!-- QUICK START -->
## Quick Start

### Prerequisites
- **Android Device**: Optimized for devices supporting [Google Play Services for AR](https://developers.google.com/ar/devices) (ARCore).
- **Camera Access**: Explicit camera permissions are required for real-time environment mapping and plane detection.
- **Environment**: Operates best in well-lit areas with textured surfaces (e.g., patterned floors or rugs) to assist AR tracking stability.

### Installation & Deployment

1. **Download the Artifact**
   Download the production-ready build directly from the repository:  
   **[AR-Stack-Game.apk](https://github.com/Amey-Thakur/AR-STACK-GAME/blob/main/AR-Stack-Game.apk?raw=true)**

2. **System Configuration**
   - Locate the `.apk` file in your device's file manager.
   - Enable **"Install from unknown sources"** in System Settings if prompted.
   - Proceed with the installation.

3. **Environment Initialization**
   - Launch the application and grant **Camera Permission**.
   - **Surface Mapping**: Move the device in a slow, circular motion while pointing at a flat surface. Visual indicators will appear once the ARCore engine successfully identifies a valid horizontal plane.

4. **Gameplay Execution**
   - **Place Foundation**: Tap the detected plane to instantiate the game's base.
   - **Stack Blocks**: Tap the screen to drop oscillating blocks. Precision is critical; portions of the block extending beyond the previous layer will be sliced, reducing the surface area for subsequent stacks.

---

<!-- LICENSE -->
## License

This project is licensed under the **MIT License** - see the [LICENSE](LICENSE) file for details.

**Summary**: You are free to share and adapt this content for any purpose, even commercially, as long as you provide appropriate attribution to the original author.

**Copyright &copy; 2020** [Amey Thakur](https://github.com/Amey-Thakur), [Hasan Rizvi](https://github.com/rizvihasan)

---

<!-- ABOUT -->
## About This Repository

**Created & Maintained by**: [Amey Thakur](https://github.com/Amey-Thakur)  
**Academic Journey**: Bachelor of Engineering in Computer Engineering (2018-2022)  
**Institution**: [Terna Engineering College](https://ternaengg.ac.in/), Navi Mumbai  
**University**: [University of Mumbai](https://mu.ac.in/)

This project features the AR Stack Builder Game, an immersive augmented reality application developed as a 4th-semester mini-project for the Computer Graphics course. It showcases the practical integration of Unity's 3D rendering capabilities with Google's ARCore SDK for real-world plane detection and physics-based interactions.

**Connect**: [GitHub](https://github.com/Amey-Thakur) &nbsp;&middot;&nbsp; [LinkedIn](https://www.linkedin.com/in/amey-thakur)

### Acknowledgments

Grateful acknowledgment to **[Hasan Rizvi](https://github.com/rizvihasan)** for his pivotal role and collaborative excellence during the development of this project. His technical expertise, innovative contributions to AR integration, and dedicated commitment to software quality were fundamental in achieving the project's immersive and functional objectives. This archival record serves as a testament to his scholarly partnership and significant impact on the final implementation.

Special thanks to the faculty members of the Department of Computer Engineering at Terna Engineering College for their guidance during the course of this project. Gratitude is also extended to the mentors and peers who supported this learning endeavor.

---

<!-- FOOTER -->
<div align="center">

  [↑ Back to Top](#ar-stack-builder-game)

  [Authors](#authors) &nbsp;·&nbsp; [Overview](#overview) &nbsp;·&nbsp; [Features](#features) &nbsp;·&nbsp; [Structure](#project-structure) &nbsp;·&nbsp; [Quick Start](#quick-start) &nbsp;·&nbsp; [License](#license) &nbsp;·&nbsp; [About](#about-this-repository) &nbsp;·&nbsp; [Acknowledgments](#acknowledgments)

  <br>

  🔬 **[Computer Graphics Lab](https://github.com/Amey-Thakur/COMPUTER-GRAPHICS-AND-COMPUTER-GRAPHICS-LAB)** &nbsp;·&nbsp; 🎮 **[Game Repository](https://github.com/Amey-Thakur/AR-STACK-GAME)**

</div>

---

<div align="center">

  ### 🎓 [Computer Engineering Repository](https://github.com/Amey-Thakur/COMPUTER-ENGINEERING)

  **Computer Engineering (B.E.) - University of Mumbai**

  *Semester-wise curriculum, laboratories, projects, and academic notes.*

</div>
