<img width="1874" height="1521" alt="1000033412" src="https://github.com/user-attachments/assets/497a841e-55e6-4bf2-b5fd-e6d05a813f3f" />


# PKMN-ED
A lightweight C# utility built on top of pk3DS.Core to seamlessly extract Gen 6 and Gen 7 Pokémon 3D models, textures, and animations directly from Nintendo 3DS ROMs. Designed specifically to generate .bch and .bcmot files that are 100% compatible with the SPICA emulator/visualizer.

An upgraded, modernized, and feature-packed fork of **pk3DS** designed for Nintendo 3DS Pokémon ROM hacking, resource editing, and asset extraction (Gen 6 & Gen 7). 

<img width="1090" height="639" alt="1000033436" src="https://github.com/user-attachments/assets/2fa33ad1-cb18-44cf-81fd-256d4f0b1449" />


**PKMN-ED** rebuilds and enhances the original core tool by integrating the **SPICA 3D rendering pipeline**, adding direct **audio/music stream management**, overhauling the **UI/UX design**, and drastically optimizing tool performance and extraction speed.

---

## Key Improvements & Upgrades

### Modernized UI & Improved UX
* **Redesigned Interface**: Cleaner, more intuitive WinForms layout tailored for modern displays and multi-tasking workflows.

<img width="973" height="420" alt="1000033435" src="https://github.com/user-attachments/assets/cce99e3d-add7-4dff-8fde-6a1f96878595" />


* **Real-Time Visual Feedback**: Integrated `ListBox` inspector that displays container sub-files, asset categories, and exact buffer sizes before exporting.

### Native 3D Engine Integration (SPICA)
* **Built-in SPICA Visualizer**: Embedded 3D rendering engine directly within the solution—no need for external view tools.

<img width="936" height="500" alt="1000033437" src="https://github.com/user-attachments/assets/de4f5815-555f-4750-b34e-fec386949a32" />


* **Automated Texture Linking**: Extracts and outputs 3D models (`.bch`) along with normal and shiny texture maps (`_tex.bch` / `_shiny.bch`) using SPICA-compliant naming for instant texture auto-binding.
* **Full Animation Support**: Complete decompression of `.bcmot` animation streams (Idle, Attack, Expressions).

### Enhanced Audio & Music Tools
* **Direct Audio Extraction**: Native handling for BGM and sound effects streams.
* **Media Preview**: Inspect and manage audio assets alongside 3D meshes without needing third-party converters.

<img width="1037" height="531" alt="1000033434" src="https://github.com/user-attachments/assets/d5b8d0c8-16fd-4b7b-94ad-2886c8d5ded9" />


### Performance & Core Speed
* **Optimized LZ11 Decompression**: Streamlined memory allocation and stream handling for faster GARC archive unpacking.
* **Smart Index Calculator**: Automatic mapping from National Pokédex numbers (#001–#807) to exact GARC file offsets across both Gen 6 (`a/0/0/8`) and Gen 7 (`a/0/9/4`) ROM structures.

---

## Tech Stack & Requirements

* **Language**: C# / .NET Framework 4.7.2+ (or .NET 6.0+ Desktop Runtime)
* **Graphics**: OpenTK / OpenGL (for SPICA 3D viewport and ETC1 texture processing)

---
### Warning
This project does not include copies of original files, such as 3D models, games, sound effects, or any program made by Nintendo or Game Freak.

---

## License & Acknowledgments

This project is open-source under the **MIT License**.

### Credits

* **[kwsch](https://github.com/kwsch/pk3DS)** — Original creator of `pk3DS` and `PKHeX`. Core GARC archive structure and ROM manipulation logic.
* **[gdkchan](https://github.com/gdkchan/SPICA)** — Creator of `SPICA`. 3D model parsing, H3D/BCH specifications, and rendering pipeline.
* **Game Freak & Nintendo** — Original game assets, models, and audio structures.

---
*Maintained and developed by [drJhonatan00](https://github.com/drJhonatan00)*
