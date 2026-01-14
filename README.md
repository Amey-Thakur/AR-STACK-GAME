<div align="center">

  # AR Stack Builder Game

  [![License: MIT](https://img.shields.io/badge/License-MIT-lightgrey)](LICENSE)
  ![Status](https://img.shields.io/badge/Status-Completed-success)
  [![Platform](https://img.shields.io/badge/Platform-Android-blueviolet)](https://github.com/Amey-Thakur/AR-STACK-GAME)
  [![Technology](https://img.shields.io/badge/Technology-Unity%20%7C%20ARCore-orange)](https://github.com/Amey-Thakur/AR-STACK-GAME)
  [![Developed by](https://img.shields.io/badge/Developed%20by-Amey%20Thakur%20%26%20Hasan%20Rizvi-blue)](https://github.com/Amey-Thakur/AR-STACK-GAME)

  An immersive Augmented Reality stack builder game developed for Android using Google's ARCore SDK and Unity Engine.

  **[Download APK](https://github.com/Amey-Thakur/AR-STACK-GAME/blob/main/AR-Stack-Game.apk?raw=true)** &nbsp;·&nbsp; **[Source Code](Source%20Code/)** &nbsp;·&nbsp; **[Technical Specification](docs/SPECIFICATION.md)**

</div>

---

<div align="center">

  [Authors](#authors) &nbsp;·&nbsp; [Overview](#overview) &nbsp;·&nbsp; [Features](#features) &nbsp;·&nbsp; [Structure](#project-structure) &nbsp;·&nbsp; [Quick Start](#quick-start) &nbsp;·&nbsp; [Usage Guidelines](#usage-guidelines) &nbsp;·&nbsp; [License](#license) &nbsp;·&nbsp; [About](#about-this-repository) &nbsp;·&nbsp; [Acknowledgments](#acknowledgments)

</div>

---

<!-- AUTHORS -->
<div align="center">

  ## Authors

  **Terna Engineering College | Computer Engineering | Batch of 2022**

| <a href="https://github.com/Amey-Thakur"><img src="https://github.com/Amey-Thakur.png" width="150" height="150" alt="Amey Thakur"></a><br>[**Amey Thakur**](https://github.com/Amey-Thakur)<br><br>[![ORCID](https://img.shields.io/badge/ORCID-0000--0001--5644--1575-green.svg)](https://orcid.org/0000-0001-5644-1575) | <a href="https://github.com/rizvihasan"><img src="https://github.com/rizvihasan.png" width="150" height="150" alt="Hasan Rizvi"></a><br>[**Hasan Rizvi**](https://github.com/rizvihasan)<br><br>[![GitHub](https://img.shields.io/badge/GitHub-rizvihasan-181717?style=flat&logo=github&logoColor=white)](https://github.com/rizvihasan) |
| :---: | :---: |

</div>

> [!IMPORTANT]
> ### 🤝🏻 Special Acknowledgement
> *Special thanks to **[Hasan Rizvi](https://github.com/rizvihasan)** for his meaningful contributions, guidance, and support that helped shape this work.*

---

<!-- OVERVIEW -->
## Overview

The **AR Stack Builder Game** is a Computer Graphics Mini-Project designed to explore the capabilities of Augmented Reality (AR) in mobile gaming. By leveraging **Google's ARCore** for plane detection and tracking, and **Unity** for 3D rendering and physics, this game allows players to stack 3D blocks in their real-world environment.

The objective is simple yet challenging: build the highest stack possible without letting it topple over, testing both the player's precision and the stability of the virtual structure in the physical world.

> [!NOTE]
> **Research Impact**: The development and architectural overview of this project are part of a curated Computer Engineering collection on ResearchGate.
> - [ResearchGate Profile](https://www.researchgate.net/profile/Amey-Thakur)

### Resources

| # | Resource | Description |
|---|---|---|
| 1 | [AR Stack Builder APK](https://github.com/Amey-Thakur/AR-STACK-GAME/blob/main/AR-Stack-Game.apk?raw=true) | Production Android build (APK) |
| 2 | [Unity Package](https://github.com/Amey-Thakur/AR-STACK-GAME/blob/main/ARStackGame.unitypackage?raw=true) | Unity Asset Exchange Package |
| 3 | [Technical Specification](docs/SPECIFICATION.md) | Technical architecture and logic specification |
| 4 | [Source Code](Source%20Code/) | Core C# implementation files |
| 5 | [CG Laboratory](https://github.com/Amey-Thakur/COMPUTER-GRAPHICS-AND-COMPUTER-GRAPHICS-LAB) | Academic repository for Computer Graphics |

> [!TIP]
> **Technical Customization**
> To analyze game difficulty or physics behavior, the `moveSpeed` variable in `MovingCube.cs` (Line 28) can be modified. Incremental adjustments to this parameter allow for the evaluation of user reaction times and precision in augmented environments.

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

```bash
AR-STACK-GAME/
│
├── docs/                                # Formal Documentation
│   └── SPECIFICATION.md                 # Technical Architecture & Specification
│
├── Source Code/                         # Core Implementation
│   ├── ARPlacementManager.cs            # ARCore Plane Detection
│   ├── CubeSpawner.cs                   # Block Instantiation
│   ├── MovingCube.cs                    # Physics & Slicing Logic
│   └── StackManager.cs                  # Game State Controller
│
├── .gitattributes                       # Git Configuration
├── .gitignore                           # Git Ignore Rules
├── AR-Stack-Game.apk                    # Android Production Build
├── ARStackGame.unitypackage             # Unity Asset Package
├── CITATION.cff                         # Citation Metadata
├── codemeta.json                        # Project Metadata (JSON-LD)
├── LICENSE                              # MIT License
├── README.md                            # Main Documentation
└── SECURITY.md                          # Security Policy & Posture
```

---

<!-- QUICK START -->
## Quick Start

### Prerequisites
- **Android Device**: Optimized for devices supporting [Google Play Services for AR](https://developers.google.com/ar/devices) (ARCore).
- **Camera Access**: Explicit camera permissions are required for real-time environment mapping and plane detection.
- **Environment**: Operates best in well-lit areas with textured surfaces (e.g., patterned floors or rugs) to assist AR tracking stability.

> [!WARNING]
> **Hardware & Environmental Requirements**
>
> This application requires an **ARCore-compatible** Android device. Successful environmental mapping is highly dependent on ambient lighting and surface texture; low-light conditions or reflective/featureless surfaces (like plain white tables) will result in tracking failure or virtual drift.

### Installation & Deployment

1. **Download the Project**
   Download the production-ready build directly from the repository:  
   [AR-Stack-Game.apk](https://github.com/Amey-Thakur/AR-STACK-GAME/blob/main/AR-Stack-Game.apk?raw=true)

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

<!-- =========================================================================================
                                     USAGE SECTION
     ========================================================================================= -->
## Usage Guidelines

This repository is openly shared to support learning and knowledge exchange across the academic community.

**For Students**  
Use this mini-project as a reference for understanding Augmented Reality (AR) implementation, Unity physics, and mobile game development. The source code is documented to support self-paced learning and exploration of real-time environmental mapping.

**For Educators**  
This project may serve as a practical example or supplementary teaching resource for Computer Graphics courses (`CSC404` / `CSL402`). Attribution is appreciated when utilizing content.

**For Researchers**  
The documentation and organization provide insights into academic project curation and educational software structuring.

---

<!-- LICENSE -->
## License

This repository and all linked academic content are made available under the **MIT License**. See the [LICENSE](LICENSE) file for complete terms.

> [!NOTE]
> **Summary**: You are free to share and adapt this content for any purpose, even commercially, as long as you provide appropriate attribution to the original author.

Copyright © 2020 Amey Thakur, Hasan Rizvi

---

<!-- ABOUT -->
## About This Repository

**Created & Maintained by**: [Amey Thakur](https://github.com/Amey-Thakur) & [Hasan Rizvi](https://github.com/rizvihasan)  
**Academic Journey**: Bachelor of Engineering in Computer Engineering (2018-2022)  
**Institution**: [Terna Engineering College](https://ternaengg.ac.in/), Navi Mumbai  
**University**: [University of Mumbai](https://mu.ac.in/)

This project features the AR Stack Builder Game, an immersive augmented reality application developed as a 4th-semester mini-project for the Computer Graphics course. It showcases the practical integration of Unity's 3D rendering capabilities with Google's ARCore SDK for real-world plane detection and physics-based interactions.

**Connect:** [GitHub](https://github.com/Amey-Thakur) &nbsp;·&nbsp; [LinkedIn](https://www.linkedin.com/in/amey-thakur) &nbsp;·&nbsp; [ORCID](https://orcid.org/0000-0001-5644-1575)

### Acknowledgments

Grateful acknowledgment to [**Hasan Rizvi**](https://github.com/rizvihasan) for his exceptional collaboration and innovative contributions during the development of this project. His technical expertise in ARCore integration, physics simulation, and commitment to software quality were instrumental in achieving the project's immersive objectives. Learning alongside him was a transformative experience; his thoughtful approach to problem-solving and steady encouragement turned complex challenges into meaningful learning moments. This work reflects the growth and insights gained from our side-by-side academic journey. Thank you, Hasan, for everything you shared and taught along the way.

Grateful acknowledgment to the faculty members of the Department of Computer Engineering at Terna Engineering College for their guidance and instruction in Computer Graphics. Their expertise in real-time rendering and spatial mapping helped shape the technical foundation of this project.

Special thanks to the mentors and peers whose encouragement, discussions, and support contributed meaningfully to this learning endeavor.

---

<!-- FOOTER -->
<div align="center">

  [↑ Back to Top](#ar-stack-builder-game)

  [Authors](#authors) &nbsp;·&nbsp; [Overview](#overview) &nbsp;·&nbsp; [Features](#features) &nbsp;·&nbsp; [Structure](#project-structure) &nbsp;·&nbsp; [Quick Start](#quick-start) &nbsp;·&nbsp; [Usage Guidelines](#usage-guidelines) &nbsp;·&nbsp; [License](#license) &nbsp;·&nbsp; [About](#about-this-repository) &nbsp;·&nbsp; [Acknowledgments](#acknowledgments)

  <br>

  🔬 **[Computer Graphics Lab](https://github.com/Amey-Thakur/COMPUTER-GRAPHICS-AND-COMPUTER-GRAPHICS-LAB)** &nbsp;·&nbsp; 🎮 **[AR-STACK-GAME](https://github.com/Amey-Thakur/AR-STACK-GAME)**

</div>

---

<div align="center">

  #### Presented as part of the 4th Semester Mini-Project @ Terna Engineering College

  ---

  ### 🎓 [Computer Engineering Repository](https://github.com/Amey-Thakur/COMPUTER-ENGINEERING)

  **Computer Engineering (B.E.) - University of Mumbai**

  *Semester-wise curriculum, laboratories, projects, and academic notes.*

</div>
