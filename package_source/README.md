# Custom Unity Package Template
This is a starter project to accelerate creating unity packages.

## How to create a new package
There are a few things you need you do to use this repository to create a new package.

### Fork this repository
Feel free to fork (or clone) this repository and use it under the MIT license.

### Modifying the template
There are a few things that need to be modified when creating a new package from this template.
However, before you start, you need to clone your repository and open it in Unity.

#### Reset all file GUIDs
If you use this template, a GUID is already assigned in the `meta` file for each of the package files/directories. To avoid conflicts with other packages created using this template, you will need to regenerate new GUIDs for all the files/directories. 

To regenerate the package GUIDs, you can use the editor script `UnityGUIDRegenerator.cs`. To use this script go to `Tools/Regenerate Package GUIDs`.

#### The `package_source/package.json` file:
- Rename the package to match your repository name
- Make sure the version number is `0.0.1` since this will be the first release of the package.
- Change the `displayName` to match the name you want displayed for your package.
- Change the `description` to describe what your package does.
- Add any dependencies your package will depend on. (Note: do not add more dependencies than you need)

#### The `Packages/manifest.json` file:
- Modify the package name under `dependencies` to match your new package name
- Modify the package name under `testables` to match your new package name 

#### The `README.md` file:
- Change this file to have any instructions on how to use your repository.
Note: This should not describe how to use the package, this is only for the repository.
  
#### The `CHANGELOG.md` file:
- Update the log to have an entry for each new version you release for the package.

#### The `Documentation~/index.md` file:
- Update the documentation to describe how your package can be used.
Note: This should describe how a user would use your package.
  
#### The `Runtime` folder:
- This is where any runtime scripts for your package would live.

#### The `Editor` folder:
- This is where any editor scripts for your package would live.

#### The `Runtime/CompanyName.PackageName.Runtime.asmdef` file:
- Make sure the name of this file matches your package. (Use camelcase)
- Make sure the name inside this file matches the name of the file.
- Make sure the `rootNamespace` matches the root namespace of your package.

#### The `Runtime/CompanyName.PackageName.Editor.asmdef` file:
- Make sure the name of this file matches your package. (Use camelcase)
- Make sure the name inside this file matches the name of the file.
- Make sure the `rootNamespace` matches the root namespace of your package.

#### The `Tests/Runtime` folder:
- This is where all runtime tests for your package would live.

#### The `Tests/Editor` folder:
- This is where all editor tests for your package would live.

#### The `Runtime/CompanyName.PackageName.Runtime.asmdef` file:
- Make sure the name of this file matches your package. (use camelcase)
- Make sure the name inside this file matches the name of the file.
- Make sure the `rootNamespace` matches the root namespace of your package.
- Make sure the `references` has any references to assemblies you want to test.

#### The `Runtime/CompanyName.PackageName.Editor.asmdef` file:
- Make sure the name of this file matches your package. (use camelcase)
- Make sure the name inside this file matches the name of the file.
- Make sure the `rootNamespace` matches the root namespace of your package.
- Make sure the `references` has any references to assemblies you want to test.