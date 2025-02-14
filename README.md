# AutoUpdateTest
## 说明
程序检查更新功能测试仓库，包含例程<br>
*(假设程序最新版本为Release1.1.0.0)*

## 文件结构
### 程序
`\_Compile\AutoUpdateTest_Release1.0.0.0.exe`作为程序`Release1.0.0.0`版本，为**旧版本**<br>
`\_Conpile\AutoUpdateTest_Release1.1.0.0.exe`作为程序`Release1.1.0.0`版本，为**最新版本**<br><br>

### 文件
`\_AutoUpdate\Version.txt`存放程序的最新版本号 *(Release1.1.0.0)*<br>

## 原理
程序启动时或用户手动按下**检查更新按钮**时，从`https://raw.githubusercontent.com/bilibilihuazi/AutoUpdateTest/refs/heads/master/_AutoUpdate/Version.txt`读取文件信息，并于程序内部`Version`变量比较，如相同则不提示任何信息。如不同则提示有新版本并显示最新版本