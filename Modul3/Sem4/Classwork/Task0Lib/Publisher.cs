using System;

namespace Task0Lib
{
    public class Publisher
    {
        public delegate void Notify(string message);

        public event Notify BeginOutput;

        public event Notify EndOutput;

        public void Display(string message)
        {
            OnBeginOutput();
            Console.WriteLine(message);
            OnEndOutput();
        }

        private void OnBeginOutput()
        {
            BeginOutput?.Invoke("Starting output");
        }

        private void OnEndOutput()
        {
            EndOutput?.Invoke("Ending output");
        }
    }
}