﻿// See https://aka.ms/new-console-template for more information

TechTool.Menu menu = new TechTool.Menu("MAIN");
menu.Add("1", "aaa");
menu.Add("2", "bbb");
Console.WriteLine(menu.Print());

TechTool.Reg myReg = new TechTool.Reg(@"HKEY_LOCAL_MACHINE\System\CurrentControlSet\Control\Terminal Server\WinStations\RDP-Tcp", "PortNumber");
myReg.Read();
Console.WriteLine(myReg.SubKey);
Console.WriteLine(myReg.KeyName);
Console.WriteLine(myReg.KeyValue);
Console.WriteLine(myReg.KeyType);
//3389
myReg.KeyValue = "3389";
myReg.Write();

TechTool.Reg myReg2 = new TechTool.Reg(@"HKEY_LOCAL_MACHINE\System\CurrentControlSet\Control\Terminal Server\WinStations\RDP-Tcp", "AudioEnumeratorDll");
myReg2.Read();Console.WriteLine(myReg.SubKey);
Console.WriteLine(myReg2.KeyName);
Console.WriteLine(myReg2.KeyValue);
Console.WriteLine(myReg2.KeyType);

Console.Write("Press key.");
object rk = Console.ReadKey();