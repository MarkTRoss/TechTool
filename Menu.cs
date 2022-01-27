//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace TechTool
{
    public class Menu
    {
        int w = Console.WindowWidth;
        int h = Console.WindowHeight;

        string _title;
        List<MenuLine> _menuLine = new List<MenuLine>();



        public Menu(string title)  //Constructor
        {
            _title = title;
            if (w>80) { w = 80; }  //treat screen winth max at 80
        }



        public void Add(string key, string description)
        {
            MenuLine menuLine = new MenuLine();
            menuLine.Key = key;
            menuLine.Description = description;
            _menuLine.Add(menuLine);
        }



        public string Print()
        {
            Console.Clear();

            string eol = "\n";
            if (_menuLine.Count<10) { eol += "\n"; }
            if (_menuLine.Count<5 ) { eol += "\n"; }

            string _print = Header() + eol;  //add linefeed after title or muliple linefeeds

            foreach (MenuLine menuLine in _menuLine)
            {
                _print += "  " + menuLine.Key + ")     " + menuLine.Description + eol;
            }
            return _print;
        }
    


        class MenuLine
        {
            public string Key = "";
            public string Description = "";
        }



    string Header()
        {
            int letterspacing = 1;
            if (w>20) { letterspacing = 2; }
            if (w>40) { letterspacing = 3; }
            if (w>80) { letterspacing = 4; }

            string header = "TECHTOOL";           
            header = String.Join(new string(' ', letterspacing-1), header.ToCharArray());

            string underline = new string('=', header.Length + letterspacing*2);

            header    =    header.PadLeft((w +    header.Length) / 2);  //need the + here
            underline = underline.PadLeft((w + underline.Length) / 2);


            //Title
            string title = _title.PadLeft((w + _title.Length) /2);

            return header + "\n" + underline + "\n\n" + title;
        }





    }  //Class 'Menu'
}  //NameSpace