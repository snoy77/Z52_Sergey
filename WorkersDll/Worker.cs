using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Linq;
using MyTools.Office;
using System.Runtime.CompilerServices;

namespace WorkersDll
{
    //Класс обязательно должен иметь своё имя Worker, а так же должен иметь обязательный статический метод Start()
    public class Worker
    {

        //Класс выполняет основную работу

        //МЕТОДЫ
        //public WordTalker[] getWordsDocs(string pathOfDirectory)
        //{
        //    string[] files = Directory.GetFiles(pathOfDirectory);
        //    files = files.Where(x => WordTalker.formats.Contains(x.Substring(x.Length - 5))).ToArray();
        //    WordTalker[] result = files.Select(x => new WordTalker(x)).ToArray();
        //    return result;
        //}
        
        public static void Start(string[] docFiles)
        {

        }
        //КОНСТРУКТОРЫ
        public Worker() { }
    }
}