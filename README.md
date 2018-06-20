# Draco_Unity
Unity 2018.1.0f2

[Google Draco](https://github.com/google/draco)

[Google Draco Unity](https://github.com/google/draco/tree/master/unity)

> Draco 
>
> Editor
>
> Plugins
>
> Resources
>
> Scenes
>
> Scripts

Windows10 环境 Draco 编译步骤 https://igco.xyz/d/14-google-draco 

- CMake 
- Windows 10 
- Visual Studio 2017

![](https://github.com/iifork/Draco_Unity/blob/master/1.png?raw=true)

------

----

Draco Release （ draco_encoder.exe - 编译的可执行文件 Windows10 ）

编译成功的可执行文件：https://github.com/iifork/Draco_Unity/releases/tag/v1.0

[使用方法](https://igco.xyz/d/14-google-draco/8) 

CMD: ` draco_encoder.exe `

`draco_encoder.exe -o "xxx.drc" -i "xxx.obj" `

由于 Unity 只能识别 Unity 已知的文件扩展名，因此需要将压缩的 `.drc` 文件更改为 `.bytes ` ，以便 Unity 将其识别为二进制文件。例如:

`xxx.obj` 要改成 `xxx.bytes ` 才能被Unity 读取

------

#### **WELCOME**

#### To 	 [IGC - Indie Game Community .](https://igco.xyz/) ( Chinese Community )

[iifork.com](https://iifork.com) ✔
