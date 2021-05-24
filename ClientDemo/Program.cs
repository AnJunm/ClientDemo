using System;

namespace ClientDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Client cd = new Client();

            Console.WriteLine("客户端连接服务器成功");
            cd.connectServer();
            Console.ReadKey();
        }
    }
}
