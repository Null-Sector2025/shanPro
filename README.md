# shanPro
Pure C# .NET MAUI Android Terminal APP, like Termux.

## 项目介绍
100% C# .NET8 MAUI 开发安卓终端模拟器，复刻Termux本地Shell执行功能
Github Actions自动编译Release APK

## 环境要求
- .NET 8 SDK
- MAUI Android workload
- Android SDK 34

## 本地编译命令
```bash
dotnet publish -c Release -f net8.0-android34.0
Github CI
 
推送main分支自动构建APK，成品在Actions artifacts下载
