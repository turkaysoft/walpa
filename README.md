# Walpa - Lossless Icon Colorizer

[![GitHub downloads](https://img.shields.io/github/downloads/turkaysoft/walpa/total?style=flat&color=1a893c&label=Downloads)](https://github.com/turkaysoft/walpa/releases)
[![GitHub stars](https://img.shields.io/github/stars/turkaysoft/walpa?style=flat&color=0062cc&label=Stars)](https://github.com/turkaysoft/walpa/stargazers)
[![GitHub release](https://img.shields.io/github/v/release/turkaysoft/walpa?style=flat&color=5a32a3&label=Latest%20Release)](https://github.com/turkaysoft/walpa/releases/latest)
[![Platform](https://img.shields.io/badge/platform-Windows-b31d28?style=flat&label=Platform)](https://github.com/turkaysoft/walpa)

**Walpa** is a high-performance, lossless icon recoloring software developed by **Eray Türkay**. It is engineered to recolor raster icons with maximum efficiency while preserving the original image with pixel-perfect accuracy.

Unlike conventional image processing solutions that rely on per-pixel color transformations or blending operations, Walpa directly overwrites the RGB channels of every visible pixel while leaving the **alpha channel completely untouched**. This ensures that the original transparency, anti-aliasing, edge quality, and pixel layout remain **100% identical** to the source image.

The engine operates directly on bitmap memory using **unsafe native pointer arithmetic** and **low-level memory manipulation**, eliminating the overhead associated with high-level pixel access methods. Combined with **parallel scanline processing**, Walpa maximizes memory throughput and can deliver **up to 3× faster** icon recoloring performance than conventional recoloring solutions, depending on image size, hardware, and workload.

---

### Donate
You can support this project by making a donation to help ensure its sustainability and the development of new features.

[![Buy Me A Coffee](https://img.shields.io/badge/Buy%20Me%20A%20Coffee-Donate-0a6628?style=flat&logo=buy-me-a-coffee&logoColor=white)](https://buymeacoffee.com/turkaysoft)

---

## Key Features

- **High-Performance Recoloring:** Optimized for maximum throughput, delivering up to **3× faster** icon recoloring than conventional solutions, depending on hardware and workload.
- **100% Lossless Output:** Recolors icons without altering pixel positions, transparency, or image quality, ensuring pixel-perfect results every time.
- **Perfect Transparency Preservation:** Preserves every alpha value exactly, maintaining smooth edges, anti-aliasing, and the original visual appearance.
- **Universal Image Compatibility:** Supports images of any bit depth and automatically converts them to a 32-bit ARGB format for consistent, high-quality recoloring.
- **Real-Time Live Preview:** Instantly previews color changes, allowing users to visualize the final result before applying the transformation.
- **Consistent Pixel Accuracy:** Only the visible color channels are updated while the underlying image structure remains completely unchanged.
- **Built for Scale:** Designed to efficiently process both individual icons and large icon collections with consistent performance.
* **Multilingual:** It supports 15 different languages, primarily English. You can access the supported languages here: [Supported Languages](https://github.com/turkaysoft/walpa/discussions/1)
* **Modern UI:** Clean, intuitive interface compatible with Windows 11 design language, featuring Light, Dark, and System themes.
* **Built-in Update Mechanism:** It features a built-in smart update mechanism developed specifically by **Türkaysoft**.

---

## Interface Preview

_Coming soon..._

## Modern Color Picker

_Coming soon..._

---

## Getting Started

1.  Navigate to the **[Releases](https://github.com/turkaysoft/walpa/releases/latest)** page.
2.  Download the latest ZIP file.
3.  **Extract all files from the ZIP** (Important: Application requires all folder contents to run correctly).
4.  Launch the executable corresponding to your architecture:
    * `Walpa_x64.exe`: For standard 64-bit Intel/AMD systems.
    * `Walpa_arm64.exe`: For ARM-based devices like Surface Pro.

---

## Translation Support

* **Translation Support:** Community-driven localization via the official [Translation Guide](https://github.com/turkaysoft/walpa/discussions/1).

---

## System Requirements

| Feature | Minimum Requirements | Recommended Requirements |
| :--- | :--- | :--- |
| **OS** | Windows 10 22H2 x64 | Windows 11 25H2 x64 |
| **CPU** | x64 or ARM64 | x64 or ARM64 |
| **RAM** | 100 MB Free RAM | 150 MB Free RAM |
| **.NET** | .NET Framework 4.8.1 | .NET Framework 4.8.1 |

---

## Shortcut Keys

| Shortcut | Action |
|--|--|
| `F1` | Light Theme |
| `F2` | Dark Theme |
| `F3` | System Theme |
| `F4` | Starting With: Windowed |
| `F5` | Starting With: Full Screen |
| `F6` | List View Mode: File Name |
| `F7` | List View Mode: Full Path |
| `F11` | Check Updates |
| `F12` | About |
| `ESC` | Clear Selection |

---

## Security

* **Zero Data Export Policy:** Your privacy is our priority; no data leaves your machine.
* **No Dependencies:** Developed entirely from scratch using its own source code, there are no risks from security vulnerabilities in third-party libraries.
* **Open Source:** All source code for the program is open and can be reviewed by anyone.

---

## License

This software is offered free of charge as part of the **Türkaysoft solutions package** and is protected under the [**MIT License**](https://github.com/turkaysoft/astel?tab=MIT-1-ov-file).
