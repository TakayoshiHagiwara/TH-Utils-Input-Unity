# TH-Utils-Input-Unity/TH.Utils.InputExtentions class<!-- omit in toc -->
<img src="https://img.shields.io/badge/Unity-2021 or Later-blue?&logo=Unity"> <img src="https://img.shields.io/badge/License-MIT-green">


# Table Of Contents <!-- omit in toc -->
<details>
<summary>Details</summary>

- [Definition](#definition)
- [Methods](#methods)
  - [AnyKeyDownExceptSpecificKeyCode(KeyCode)](#anykeydownexceptspecifickeycodekeycode)
    - [Parameters](#parameters)
    - [Returns](#returns)
    - [Exapmle](#exapmle)
  - [AnyKeyDownExceptSpecificKeyCode(List)](#anykeydownexceptspecifickeycodelist)
    - [Parameters](#parameters-1)
    - [Returns](#returns-1)
  - [GetInputKeyCode()](#getinputkeycode)
    - [Returns](#returns-2)
</details>


# Definition
Namespace: TH.Utils

UnityEngine.Inputクラスを拡張する静的メソッドを提供します。

# Methods
<!-- -------------------------------------------------- -->
## AnyKeyDownExceptSpecificKeyCode(KeyCode)
指定したキーコード以外の何らかのキーが押下されたかどうかを判定します。


```csharp
public static bool AnyKeyDownExceptSpecificKeyCode(KeyCode keycode)
```

### Parameters
- `keycode`: UnityEngine.Keycode
  - 判定を除外するキーコード。

### Returns
- bool
  - 指定したキーコード以外のキーが押下された場合、Trueを返します。

### Exapmle

```csharp
using System;
using UnityEngine;
using TH.Utils;

if (InputExtentions.AnyKeyDownExceptSpecificKeyCode(KeyCode.C)) 
{
    Debug.Log("Any key other than 'C' was pressed.");
}
```


<!-- -------------------------------------------------- -->
## AnyKeyDownExceptSpecificKeyCode(List<KeyCode>)
引数のListに含まれるキーコード以外の何らかのキーが押下されたかどうかを判定します。


```csharp
public static bool AnyKeyDownExceptSpecificKeyCode(List<KeyCode> keycodes)
```

### Parameters
- `keycodes`: List
  - 判定を除外するキーコードのList。

### Returns
- bool
  - 指定したキーコード以外のキーが押下された場合、Trueを返します。


<!-- -------------------------------------------------- -->
## GetInputKeyCode()
押下されたキーのキーコードを返します。


```csharp
public static KeyCode GetInputKeyCode()
```

### Returns
- UnityEngine.KeyCode
  - 押下されたキーのキーコード。