# TH-Utils-Input-Unity<!-- omit in toc -->
<img src="https://img.shields.io/badge/Unity-2021 or Later-blue?&logo=Unity"> <img src="https://img.shields.io/badge/License-MIT-green">

Unityにおける入力関連のメソッドを扱います。
著者が個人的な開発を行っていた際に必要になったちょっとしたメソッドをまとめています。

# Table Of Contents <!-- omit in toc -->
<details>
<summary>Details</summary>

- [Environment](#environment)
- [Installation](#installation)
  - [Unity Package Manager経由での導入](#unity-package-manager経由での導入)
- [Description](#description)
  - [InputExtentions class](#inputextentions-class)
    - [Definition](#definition)
    - [Methods](#methods)
- [References](#references)
- [Troubleshooting](#troubleshooting)
- [Versions](#versions)
- [Author](#author)
- [License](#license)
</details>


# Environment
- Unity 2021 or Later

# Installation
## Unity Package Manager経由での導入
1. Window -> Package Managerを開きます
2. 左上のプラスアイコンをクリックし、「Add package from git URL...」をクリックします
3. このリポジトリURLを入力し、addをクリックします


# Description
<!-- -------------------------------------------------- -->
## InputExtentions class
### Definition
- Namespace: TH.Utils

UnityEngine.Inputクラスを拡張する静的メソッドを提供します。

### Methods
| Name | Summary |
| ---- | ---- |
| [AnyKeyDownExceptSpecificKeyCode(KeyCode)](/Docs~/doc_InputExtentions.md#anykeydownexceptspecifickeycodekeycode) | 指定したキーコード以外の何らかのキーが押下されたかどうかを判定します。 |
| [AnyKeyDownExceptSpecificKeyCode(List<KeyCode>)](/Docs~/doc_InputExtentions.md#anykeydownexceptspecifickeycodelist) | 引数のListに含まれるキーコード以外の何らかのキーが押下されたかどうかを判定します。 |
| [GetInputKeyCode()](/Docs~/doc_InputExtentions.md#getinputkeycode) | 押下されたキーのキーコードを返します。 |


# References


# Troubleshooting


# Versions
- [CHANGELOG](/CHANGELOG.md)


# Author
- Takayoshi Hagiwara
    - Toyohashi University of Technology


# License
- MIT License