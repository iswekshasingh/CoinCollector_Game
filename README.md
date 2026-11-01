# 🪙 Coin Collector Game

A 2D arcade-style coin collection game developed using **Unity and C#**. The player controls a catcher to collect falling coins while avoiding bombs. The objective is to reach the target score without losing all available lives.

## 🎮 Game Overview

Coin Collector is a simple yet engaging arcade game that tests the player's reflexes and timing. Coins and bombs fall from the top of the screen at random horizontal positions, and the player must collect coins while avoiding bombs.

## ✨ Features

- **Player Movement:** Move the catcher horizontally to collect falling objects.
- **Random Object Spawning:** Coins and bombs spawn at random positions.
- **Scoring System:** Earn one point for every coin collected.
- **Lives System:** Start with 3 lives. Each bomb collision costs one life.
- **Win Condition:** Collect 20 coins to win the game.
- **Game Over Condition:** Lose all 3 lives to end the game.
- **Visual Feedback:** Dedicated victory and game-over screens with transition effects.
- **Collision Detection:** Uses Unity's 2D physics and trigger colliders.

## 🕹️ Controls

| Key | Action |
|---|---|
| ← Left Arrow | Move catcher left |
| → Right Arrow | Move catcher right |

## 🛠️ Technologies Used

- **Unity 6** – Game development engine
- **C#** – Game logic and scripting
- **Unity 2D Physics** – Collision and trigger detection
- **TextMeshPro** – In-game UI and text rendering
- **Git & GitHub** – Version control and project hosting

## 📂 Project Structure

```text
Coin_Collector_Game/
│
├── Assets/
│   ├── Prefabs/
│   │   ├── coin.prefab
│   │   └── bomb.prefab
│   │
│   ├── Scenes/
│   │   └── Main.unity
│   │
│   ├── Scripts/
│   │   ├── Catcher.cs
│   │   ├── FallingObject.cs
│   │   ├── GameManager.cs
│   │   └── ObjectSpawner.cs
│   │
│   ├── Sprites/
│   └── TextMesh Pro/
│
├── Packages/
├── ProjectSettings/
└── README.md
```

## 🚀 How to Run the Project

1. Clone this repository:

   ```bash
   git clone https://github.com/iswekshasingh/WorkShop2.git
   ```

2. Open **Unity Hub**.
3. Click **Add Project from Disk**.
4. Select the cloned `WorkShop2` folder.
5. Open the project using a compatible Unity 6 editor.
6. Open the `Main` scene from `Assets/Scenes/`.
7. Press the **Play** button to start the game.

## 🎯 Game Rules

- Collect coins to increase your score.
- Avoid bombs to preserve your lives.
- Reach **20 points** to win.
- Lose all **3 lives** and the game is over.

## 👩‍💻 Developer

**Sweksha Singh**

B.Tech – Computer Science and Engineering (AI & ML)

## 🔗 Repository

[Coin Collector Game – GitHub](https://github.com/iswekshasingh/WorkShop2)

---

*Developed with Unity and C#.*
