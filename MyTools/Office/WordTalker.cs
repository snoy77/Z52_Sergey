using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;



namespace MyTools.Office
{
    public class WordTalker
    {
        //ПОЛЯ И СВОЙСТВА
        private string fullName; //Path
        private string name;
        private string[] namesElement;
        static public string[] formats;

        public string FullName
        {
            set
            {
                this.fullName = value;
                this.name = Path.GetFileName(value);
                this.namesElement = this.name.Split('_');
            }
            get
            {
                return fullName;
            }
        }

        public string Name { get { return name; } }
        public string[] NamesElement { get { return this.namesElement; } }

        //МЕТОДЫ
        public void deliteMe()
        {
            File.Delete(fullName);
        }

        //КОНСТРУКТОРЫ
        public WordTalker(string fullName)
        {
            this.FullName = fullName;
         
        }

    }
}
