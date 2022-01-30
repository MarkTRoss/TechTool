//using TechTool;

namespace TechTool
{

    internal class Info
    {
        public Info()
        {
            Menu menu = new Menu("INFO");
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
            menu.Exec();
        }


    }  //Class 'Info'
}  //NameSpace
