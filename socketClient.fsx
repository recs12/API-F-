open System
open System.Net
open System.Net.Sockets
open System.Text

// Establish the remote endpoint
// for the socket. This example
// uses port 11111 on the local
// computer.
let ipHost = Dns.GetHostEntry(Dns.GetHostName())
let ipAddr = ipHost.AddressList[0]
let localEndPoint = IPEndPoint(ipAddr, 80)

let sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp)

// Connect Socket to the remote
// endpoint using method Connect()
sender.Connect(localEndPoint)

// We print EndPoint information
// that we are connected
Console.WriteLine("Socket connected to -> {0} ", sender.RemoteEndPoint.ToString())

// Creation of message that
// we will send to Server
let messageSent = Encoding.ASCII.GetBytes("Test Client<EOF>")
let byteSent = sender.Send(messageSent);

// Data buffer
let messageReceived : byte [] = Array.zeroCreate 1024

// We receive the message using
// the method Receive(). This
// method returns number of bytes
// received, that we'll use to
// convert them to string
let byteRecv = sender.Receive(messageReceived)
Console.WriteLine("Message from Server -> {0}", Encoding.ASCII.GetString(messageReceived, 0, byteRecv))

// Close Socket using
// the method Close()
sender.Shutdown(SocketShutdown.Both)
sender.Close()