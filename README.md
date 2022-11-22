
#  Welcome to WDK.NET
This project provides you the core foundation to build a fully executable Windows kernel driver in C#.
The primary backbone technologies of this project are [NativeAOT](https://learn.microsoft.com/en-us/dotnet/core/deploying/native-aot/) and [.NET 7](https://dotnet.microsoft.com/). 

# Requirements
The requirements are as follows:

 - [.NET 7](https://dotnet.microsoft.com/en-us/download)
 - [Visual Studio 2022 Latest](https://visualstudio.microsoft.com/vs/)
 - [Windows 10 SDK, version 2004 (_10.0.19041.0_)](https://developer.microsoft.com/en-us/windows/downloads/sdk-archive/) 
 - [Windows Driver Kit (WDK)](https://learn.microsoft.com/en-us/windows-hardware/drivers/other-wdk-downloads?source=recommendations#step-2-install-the-wdk)

# Building the sample driver
As of now, the project is set up to require few steps in order to have the driver build successfully. 
The steps are as follows:
1. When you first open up the project solution, configure the build configuration to targets release mode rather than debug.
2. Build the WDK.NET project (Assuming it is in release build mode).
3. Publish the Sampleriver in Win-x64 and in Release profile.
4. Currently, the ILC(NativeAOT compiler) will complain that it fails to produce a native executable for linking and the publish will result in a fail. Just simply disregard that error. You will nonetheless see a driver executable file (.sys) in the publish path.

# Testing the sample driver
There are multiple ways you can test the driver in action. 
1. A Windows virtual machine with test sign mode on (Most safe and the officially supported method of testing)
2. Kdmapper and a WinDbg or DbgView in a Windows virtual machine (Hacky and unreliable/unsafe, yet easier to do get-go testing)
3. Whichever driver testing method you like

# TODOs
 - [ ] Further port the WDK
 - [x] Instead of having the WDK referenced as a local DLL, properly resolve it as a project dependency (There are some compile issues with this currently)
 - [ ] Etc. Please suggest via PR

# Documentation
Currently there is no-limited documentation present. If you will, you are more than welcomed to contribute in writing the documentation.

# How can I contribute?
You can contribute by creating issues if any, or suggest a fix or feature addition via PRs.
When contributing by code, please follow the [C# Coding Convention](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions) to keep the code organised.