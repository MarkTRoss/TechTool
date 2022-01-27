//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace TechTool
{
    internal class Reg
    {
        public string? SubKey;
        public string? KeyName;
        public string? KeyValue;
        public string? KeyType;


        public Reg(string subKey, string keyName)
        {
            SubKey = subKey;
            KeyName = keyName;
        }


        public Reg(string subKey, string keyName, string keyValue)
        {
            SubKey = subKey;
            KeyName = keyName;
            KeyValue = keyValue;
        }



        public void Read()
        {
            KeyValue = Microsoft.Win32.Registry.GetValue(SubKey, KeyName, null).ToString();
            KeyType = Microsoft.Win32.Registry.GetValue(SubKey, KeyName, null).GetType().Name;
        }


        public void Write()
        {
            Microsoft.Win32.Registry.SetValue(SubKey, KeyName, KeyValue);
        }



    }
}



//https://docs.microsoft.com/en-us/dotnet/api/microsoft.win32.registry.getvalue?view=net-6.0

//    Public Shared Sub WriteKey(RegKey As String, RegName As String, RegValue As String)
//        Try: My.Computer.Registry.SetValue(RegKey, RegName, RegValue)
//        Catch: Common.WriteLineError() : End Try
//    End Sub


//    Public Shared Function KeyExits(Type As String, RegName As String, RegValue As String) As Boolean       'if RegValue="" then SubKey
//        If Type = "LocalMachine" Then
//            If RegValue = "" Then Return My.Computer.Registry.LocalMachine.OpenSubKey(RegName, True) IsNot Nothing      'if nothing then key doesn't exists
//            ''TODO: other types, keys as well
//        End If
//    End Function


//    Public Shared Function RenameKey(RegNameOld As String, RegNameNew As String)
//        Try
//            Dim startInfo As New ProcessStartInfo("REG.EXE")
//            startInfo.WindowStyle = ProcessWindowStyle.Hidden
//            startInfo.Arguments = "COPY """ & RegNameOld & """ """ & RegNameNew & """ /s"
//            Dim myProcess As Process = Process.Start(startInfo)
//            myProcess.WaitForExit()
//            startInfo.Arguments = "DELETE """ & RegNameOld & """ /f"
//            Process.Start(startInfo)
//        Catch: Common.WriteLineError() : End Try
//    End Function



//    Public Shared Sub PrintKeys(rkey As Microsoft.Win32.RegistryKey, filter As String)
//        Console.ForegroundColor = ConsoleColor.Cyan
//        Dim names As String() = rkey.GetSubKeyNames()
//        Dim icount As Integer = 0
//        Dim s As String

//        For Each s In names
//            Dim displayName As String = My.Computer.Registry.GetValue(rkey.ToString & "\" & s, "DisplayName", Nothing)

//            If displayName IsNot Nothing Then
//                    If displayName.Contains(filter) Then Console.WriteLine(displayName)
//                End If
//                icount += 1
//        Next s
//        Console.ForegroundColor = ConsoleColor.White
//    End Sub
//End Class
