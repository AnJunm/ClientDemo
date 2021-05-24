using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Threading;
using LitJson;
public class Client
{
    Socket socket;

    IPEndPoint iep;

    public Client()
    {

    }

    public void connectServer()
    {
        try
        {

       
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            
            iep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 30000);

            socket.Connect(iep);


            JsonData jd = new JsonData();
            jd["code"] = 1;
            jd["result"] = 4;
            byte[] jsbyte = Encoding.UTF8.GetBytes(jd.ToString());

            socket.Send(jdbyte);


            while(true)
            {
                Thread.Sleep(1000);
                socket.Send(bytes);
      
            }


        }
        catch (Exception e)
        {
            Console.WriteLine("客户端连接服务器失败");
        }

 
    }
}