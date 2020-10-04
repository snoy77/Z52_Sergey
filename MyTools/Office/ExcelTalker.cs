 
namespace MyTools.Office
{
    //----------------------------------------------------------------------------------------------------------------

    public class ExcelTalker
    {
        //Этот класс работает с таблицей ексельки. Именно он будет записывать всё в ексель. ОН НЕ СОЗДАЁТ ДОКУМЕНТ. СОЗДАВАЙТЕ ЕГО САМИ(ЧЕРЕЗ КОД, КОНЕЧНО ЖЕ!)

        //ПОЛЯ
        private string fileFullName; //Полное имя файла
        private int startTableIndex;  //Индекс начальной строки таблицы
        private int lastTableIndex;   //Индекс последней строка в таблице

        public string FileFullName
        {
            get
            {
                return this.fileFullName;
            }

            set
            {
                this.fileFullName = value;
            }
        }

        public int StartTableInex { get { return this.startTableIndex; } }
        public int LastTableIndex { get { return this.lastTableIndex; } }

        //МЕТОДЫ

        // public void writeInTable(???)
        //записывает в таблицу переданные данные. Какие переданные данные будут типа? Может зубчатый масив? }

        public int findLastIndexOfRow() { return 5; }

        public void writeLine(string[] elementOfLine)
        { //Записывает в линию данные переданные. Достаточно массивчика }
        }
        public bool ExsistRecord(string[] elementOfLine)
        { //проверяет на наличие записи(линии) в таблице}
            return true;
        }
        //КОНСТРУКТОРЫ

        public ExcelTalker(string fileFullNameOf)
        {
            this.FileFullName = fileFullName;
        }
    }
}