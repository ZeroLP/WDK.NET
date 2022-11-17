
#  Welcome to WDK.NET
This project provides you the core foundation to build a fully executable Windows kernel driver in C#.
The primary backbone technologies of this project are [NativeAOT](https://learn.microsoft.com/en-us/dotnet/core/deploying/native-aot/) and [.NET 7](https://dotnet.microsoft.com/). 

# Requirements
The requirements are as follows:

 - [.NET 7](https://dotnet.microsoft.com/en-us/download)
 - [Visual Studio 2022 Latest](https://visualstudio.microsoft.com/vs/)
 - [Windows 10 SDK, version 2004 (_10.0.19041.0_)](https://developer.microsoft.com/en-us/windows/downloads/sdk-archive/) 
 - [Windows Driver Kit (WDK)](https://learn.microsoft.com/en-us/windows-hardware/drivers/other-wdk-downloads?source=recommendations#step-2-install-the-wdk)

# Building a driver
Publish the project with the latest Visual Studio 2022 and .NET 7 installed. Currently, the ILC(NativeAOT compiler) will complain that it failed to produce native executable for linking and the publish will fail. Just disregard that error. You will nonetheless see a driver executable file (.sys) in the publish path.

# TODOs
 - [ ] Create a separate class library for ILCCompliance module so it can be worked on an individual level
 - [ ] Further port the WDK
 - [ ] Instead of having the WDK referenced as a local DLL, properly resolve it as a project dependency (There are some compile issues with this currently)
 - [ ] Etc. Please suggest via PR

# Documentation
Currently there is no-limited documentation present. If you will, you are more than welcomed to contribute in writing the documentation.

# How can I contribute?
You can contribute by creating issues if any, or suggest a fix or feature addition via PRs.
When contributing by code, please follow the [C# Coding Convention](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions) to keep the code organised.