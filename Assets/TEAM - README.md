
# 🧩 Escape Room: The Curious Case of the MISSING JOB

Welcome to the official Unity project for our academic game – **The Curious Case of the MISSING JOB**.  
This is a first-person puzzle game where players solve STEM-based logic puzzles to escape from a classroom-turned-prison, progressing through 8 levels of increasing difficulty — with maybe a 9th BOSS Fight Level.

---

## 🚀 Getting Started

### 1. Requirements
- Unity 6000.0 LTS (or later)
- Unity Hub
- Git (with GitHub Desktop, CLI, VS Code Git integration, or just regular git)
- Unity Account (for using Unity Hub)

---

## 📦 Initial Setup from .zip

If you've received the project as a `.zip` file from the team lead:

1. **Extract the ZIP** to your preferred working directory.
2. **Delete the `.git` folder** inside the extracted project (if it exists).
3. Open a terminal in the root of the extracted project and run:

```bash
git init
git remote add origin https://github.com/your-org/your-repo.git
git fetch
git checkout main
```

✅ This will link your local folder to the official GitHub repository.

4. If Unity prompts you to upgrade/modify the project:  
   Click "Skip" or "Confirm" based on team instructions.  
   Always **discuss before upgrading Unity version**.

5. After opening the project in Unity:  
   Make sure everything runs correctly (test the sample scene if provided).  
   Start working on your assigned tasks only after syncing and testing.

---

## 📤 Regular Workflow (Git)

1. **Pull the latest changes before working:**
```bash
git pull origin main
```

2. **Add & commit your changes:**
```bash
git add .
git commit -m "Describe your changes here"
```

3. **Push your changes:**
```bash
git push origin main
```

⚠️ Always resolve merge conflicts carefully. Communicate early.

---

## 📎 .gitignore

Make sure you're using a Unity-optimized `.gitignore` file. Ours includes:

```
# [Libraries & Cache]
Library/
Temp/
Logs/
Obj/
Build/

# [IDE & OS]
.vscode/
*.csproj
*.sln
.DS_Store

# [Unity]
*.unitypackage
```

---

## 📁 Project Structure

```
Assets/
│
├── Scenes/             → Game levels and test scenes
├── Scripts/            → Game logic and puzzle scripts
├── Prefabs/            → Reusable game objects
├── Audio/              → Game sounds & ambient
├── UI/                 → Menus and interaction elements
├── Materials/Models/   → Art assets
```

---

## 🤝 Collaboration Guidelines

- Use **branches** for feature work if needed.
- Stick to **scene naming conventions** and **folder hierarchy**.
- Don’t commit heavy temp files (`.tmp`, `Library/`, etc.)
- `.gitignore` is already set up for Unity – no need to modify.

---

## 🔊 Audio & Assets

Assets are sourced from:
- [Unity Asset Store](https://assetstore.unity.com/) (free/low-cost)
- [Kenney.nl](https://kenney.nl/assets)
- [Freesound.org](https://freesound.org) *(with attribution)*
- [OpenGameArt.org](https://opengameart.org)

---

Let’s build something awesome. ✨
