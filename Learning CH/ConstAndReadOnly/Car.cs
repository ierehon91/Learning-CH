using System;
using System.Collections.Generic;
using System.Text;

namespace ConstAndReadOnly
{
    class Car
    {
        private bool isStartEngine;
        private readonly Loger loger;

        private const string ENGINE_NO_START = "Двигатель не заведён";
        private const string ENGINE_START = "Двигатель заведён";
        private const string ENGINE_START_PROCESS = "Завожу двигатель";
        private const string ENGINE_IS_STARTED = "Двигатель уже заведён";
        private const string START_DRIVE = "Стартуем";
        private const string GO_DRIVE = "Едем";

        public Car(Loger loger)
        {
            this.loger = loger;
        }

        public void StartEngine()
        {
            loger.Info(ENGINE_START_PROCESS);
            if (isStartEngine)
            {
                loger.Warning(ENGINE_IS_STARTED);
            }
            else
            {
                isStartEngine = true;
                loger.Info(ENGINE_START);
            }
        }

        public void Drive()
        {
            loger.Info(START_DRIVE);
            if (isStartEngine)
            {
                loger.Info(GO_DRIVE);
            }
            else
            {      
                loger.Warning(ENGINE_NO_START);
            }
        }
    }
}
