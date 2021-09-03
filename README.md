<img alt="GitHub" src="https://img.shields.io/github/license/galalmounir/com.galalhassan.events-manager?style=for-the-badge">

# About
The events manager is a system to streamline messaging between different components in Unity.

# Installation
## Modify manifest.json
Add the following line under the `dependencies` section in the `manifest.json` file.
```json
"com.galalhassan.events-manager": "ssh://git@github.com/galalmounir/com.galalhassan.events-manager.git?path=/package_source"
```

## Package Manager
In Unity's Package Manager, click on `+ -> Add package from git URL...`. Then put in the following:
```json
ssh://git@github.com/galalmounir/com.galalhassan.events-manager.git?path=/package_source
```

# Usage
Usage is described in the [documentation](package_source/Documentation~/index.md) folder.

# Next Steps
- Support for more payload types
- Support for listening to events in-code

# Contribution
I am continuously improving on the package. I will always merge working bug fixes. However, if you want to add something new to the packge, please create an "issue" on github for this first so we can discuss if it should end up in the package before you start implementing it.
