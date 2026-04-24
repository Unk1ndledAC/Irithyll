# Irithyll

A level scene project built with Unity.

## Requirements

- **Unity Version:** 2022.3.52f1c1 (LTS)
- **Git LFS:** Required for large file management

## Repository Setup

This project uses **Git LFS** to track large binary assets. The following file types are managed by LFS:

| File Type | Extension |
|-----------|-----------|
| 3D Models | `.fbx` |
| Materials | `.mat` |
| Textures  | `.png` |
| Unity Meta| `.meta` |

### Git LFS Configuration

If you are cloning this repository for the first time, ensure Git LFS is installed on your system:

```bash
# Install Git LFS (if not already installed)
git lfs install

The repository includes the following LFS tracking rules in `.gitattributes`:

```bash
git lfs track "*.fbx"
git lfs track "*.mat"
git lfs track "*.png"
git lfs track "*.meta"
git add .gitattributes

### Git Configuration

The following Git configurations are applied for optimal LFS performance:

```bash
# Disable core compression
git config core.compression 0

# Disable LFS lock verification
git config lfs.https://github.com/Unk1ndledAC/Irithyll.git/info/lfs.locksverify false

# Increase HTTP post buffer to 2GB
git config http.postBuffer 2147483648

### Pushing LFS Assets

To push all LFS-tracked assets to the remote repository:

```bash
git lfs push --all origin main
git push origin main