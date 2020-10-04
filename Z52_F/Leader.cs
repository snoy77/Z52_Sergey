using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;

namespace Z52_F
{
    public class Leader
    {
        private string workersName; // Сувать полное имя до файла
        private object worker;
        private MethodInfo workersMethod;

        public string WorkersName { //Когда устанавливается значение имени библиотеки, автоматически запускается метод инициализации объектов из библиотеки
            get { return workersName; } 
            set
            {
                this.workersName = value;
                this.SetWorkerObject(); //Вот туть 
            }
        }

        private void SetWorkerObject()
        {
            //Забираем тип объекта воркера
            Assembly asm = Assembly.LoadFrom(workersName);
            Type t = asm.GetType("WorkersDll.Worker", true, true);

            //Инициализируем объект и его метод
            this.worker = Activator.CreateInstance(t);
            this.workersMethod = t.GetMethod("Start");
        }
        public object StartWorker() { return StartWorker(null); }
        public object StartWorker(object[] arguments)
        {
            object result = workersMethod.Invoke(worker, arguments);
            return result;
        }

        public Leader(string workersName)
        {
            this.WorkersName = workersName;
        }
    }
}
