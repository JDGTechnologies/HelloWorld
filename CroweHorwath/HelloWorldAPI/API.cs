using System;

namespace HelloWorldAPI
{

    public interface IAPI
    {
        void setMessage(string Message);
        string getMessage();

        void printMessage();
    }

    public class DatabaseApplication : IAPI
    {
        private string _Message;
        void IAPI.setMessage(string Message)
        {
            _Message = Message;
        }

        string IAPI.getMessage()
        {
            return _Message;
        }

        void IAPI.printMessage()
        {
            Console.WriteLine("Database:" + _Message);
        }
    }

    public class ConsoleApplication : IAPI
    {
        private string _Message;
        void IAPI.setMessage(string Message)
        {
            _Message = Message;
        }

        string IAPI.getMessage()
        {
            return _Message;
        }

        void IAPI.printMessage()
        {
            Console.WriteLine("Console:" + _Message);
        }
    }

    public class MobileApplication : IAPI
    {
        private string _Message;
        void IAPI.setMessage(string Message)
        {
            _Message = Message;
        }

        string IAPI.getMessage()
        {
            return _Message;
        }

        void IAPI.printMessage()
        {
            Console.WriteLine("Mobile:" + _Message);
        }
    }

    public class APIGateway
    {
        IAPI _Type;

        public APIGateway()
        {
            _Type = new ConsoleApplication();
        }

        public APIGateway(string type)
        {
            switch (type)
            {
                case "Console":
                    _Type = new ConsoleApplication();
                    break;
                case "Database":
                    _Type = new DatabaseApplication();
                    break;
                case "Mobile":
                    _Type = new MobileApplication();
                    break;
            }

        }

        public IAPI getType()
        {
            return _Type;
        }

        public void setMessage(string message)
        {
            _Type.setMessage(message);
        }

        public string getMessage()
        {
            return _Type.getMessage();
        }

        public void printMessage()
        {
            _Type.printMessage();
        } 

    }

}
