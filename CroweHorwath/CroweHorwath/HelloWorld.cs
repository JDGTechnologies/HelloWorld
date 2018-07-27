using System;

namespace CroweHorwath
{
    class HelloWorld
    {

        static void Main(string[] args)
        {

            string Message = "Hello World";

            Console.WriteLine(Message);

            HelloWorldAPI.APIGateway APIGatewayConsole = new HelloWorldAPI.APIGateway("Console");
            HelloWorldAPI.APIGateway APIGatewayDatabase = new HelloWorldAPI.APIGateway("Database");
            HelloWorldAPI.APIGateway APIGatewayMobile = new HelloWorldAPI.APIGateway("Mobile");

            //Console
            APIGatewayConsole.setMessage(Message);
            string consoleMessage = APIGatewayConsole.getMessage();
            APIGatewayConsole.printMessage();

            //Database
            APIGatewayDatabase.setMessage(Message);
            string databaseMessage = APIGatewayDatabase.getMessage();
            APIGatewayDatabase.printMessage();

            //Mobile
            APIGatewayMobile.setMessage(Message);
            string mobileMessage = APIGatewayMobile.getMessage();
            APIGatewayMobile.printMessage();

            Console.ReadLine();


        }
    }
}
