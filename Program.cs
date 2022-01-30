// See https://aka.ms/new-console-template for more information
using TechTool;


Menu menu = new Menu("TECHTOOL");
menu.Add("I", "Info");
menu.Add("D", "Disk");
menu.Add("N", "Network");
menu.Add("M", "Mail");
menu.Add("W", "Windows");
menu.Add("S", "Software");
menu.Add("U", "User Status");
menu.Add("C", "Custom Add-Ins");
menu.Add("P", "Presets (Custom Commands)");
menu.Add("Q", "Quit.");


switch(menu.Exec())
{
    case 'I': Info info = new Info(); break;
    case 'H': Info info3 = new Info(); break;

    default: break;
}

TechTool.Reg myReg = new TechTool.Reg(@"HKEY_LOCAL_MACHINE\System\CurrentControlSet\Control\Terminal Server\WinStations\RDP-Tcp", "PortNumber");
    myReg.Read();
Console.WriteLine(myReg.SubKey);
Console.WriteLine(myReg.KeyName);
Console.WriteLine(myReg.KeyValue);
Console.WriteLine(myReg.KeyType);
//3389
myReg.KeyValue = "3389";
//myReg.Write();

TechTool.Reg myReg2 = new TechTool.Reg(@"HKEY_LOCAL_MACHINE\System\CurrentControlSet\Control\Terminal Server\WinStations\RDP-Tcp", "AudioEnumeratorDll");
    myReg2.Read();Console.WriteLine(myReg.SubKey);
Console.WriteLine(myReg2.KeyName);
Console.WriteLine(myReg2.KeyValue);
Console.WriteLine(myReg2.KeyType);




Console.Write("Press key.");
object rk = Console.ReadKey();
//    Info info = new Info();
