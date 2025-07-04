# 🚗 Delivery Driver

A fun 2D top-down delivery game built with Unity where you drive around town picking up packages and delivering them to customers!

## 🎮 Game Overview

In Delivery Driver, you control a delivery vehicle navigating through a town environment. Your mission is to pick up packages and deliver them to waiting customers while avoiding obstacles along the way.

## ✨ Features

- **Top-down 2D gameplay** with smooth car controls
- **Package pickup and delivery system** - collect packages and deliver them to customers
- **Visual feedback** - your car changes color when carrying a package
- **Obstacle collision detection** - be careful not to crash!
- **Follow camera** - the camera smoothly follows your vehicle
- **Town environment** with roads, houses, trees, and various scenery

## 🎯 How to Play

1. **Movement**: Use the arrow keys or WASD to control your delivery vehicle
   - **Up/W**: Accelerate forward
   - **Down/S**: Reverse
   - **Left/A**: Steer left
   - **Right/D**: Steer right

2. **Pickup Packages**: Drive over packages to pick them up
   - Your car will change color to indicate you're carrying a package
   - You can only carry one package at a time

3. **Deliver Packages**: Drive to customers (houses) to deliver packages
   - Your car will return to its original color after successful delivery

4. **Avoid Obstacles**: Don't crash into trees, rocks, or other obstacles!

## 🛠️ Technical Details

### Built With
- **Unity 6000.1.8f1**
- **C# Scripts**
- **2D Physics System**
- **Universal Render Pipeline (URP)**

### Core Scripts
- `Driver.cs` - Handles vehicle movement and steering
- `Delivery.cs` - Manages package pickup/delivery system and collision detection
- `FollowCamera.cs` - Camera system that follows the player

### Assets Included
- Multiple car sprites (3 different vehicles)
- Road tiles (straight, curves, corners, intersections)
- Environment objects (houses, trees, rocks, bridge)
- Complete tileset for building custom levels

## 🚀 Getting Started

### Prerequisites
- Unity 6000.1.8f1 or later
- Basic understanding of Unity Editor

### Installation
1. Clone or download this repository
2. Open Unity Hub
3. Click "Add" and select the project folder
4. Open the project in Unity
5. Open the `SampleScene` in the Scenes folder
6. Press Play to start the game!

## 🎨 Customization

### Adjusting Vehicle Settings
In the `Driver.cs` script, you can modify:
- `steerSpeed` - How fast the car turns
- `moveSpeed` - How fast the car moves

### Customizing Delivery System
In the `Delivery.cs` script, you can adjust:
- `hasPackageColor` - Color when carrying a package
- `noPackageColor` - Default car color
- `destoyDelay` - How long before picked up packages disappear

### Building New Levels
Use the included road tiles and environment assets to create your own delivery routes and town layouts!

## 🎯 Future Enhancements

Some ideas for expanding the game:
- Multiple delivery routes
- Time-based challenges
- Score system
- Multiple package types
- Traffic and moving obstacles
- Sound effects and music
- Particle effects for pickups/deliveries

## 📝 License

This project is for educational and personal use. Asset pack included for learning purposes.

## 🤝 Contributing

Feel free to fork this project and add your own features! Some areas for improvement:
- UI/HUD system
- Level progression
- Audio system
- Enhanced visual effects
- Mobile controls

---

**Happy Delivering! 🚚📦**
