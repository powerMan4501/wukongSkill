using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using GSE.OnlineBase;

namespace GSE.GSNet;

public class NetDriver
{
	public static int MaxDispctchMsgNumOneTick = 10;

	public static bool EnableThrowUserException = true;

	private List<NetConnection> Connections;

	public ListenerContext listenerContext;

	public IPEndPoint ListeningAddress => listenerContext.FinalListenAddress;

	public int Init()
	{
		if (Connections == null)
		{
			Connections = new List<NetConnection>();
		}
		if (listenerContext == null)
		{
			listenerContext = new ListenerContext();
		}
		return 0;
	}

	public void StopListen()
	{
		if (listenerContext.Listener != null)
		{
			listenerContext.Listener.Stop();
			listenerContext.Listener = null;
		}
	}

	public void StopAllConnections()
	{
		for (int i = 0; i < Connections.Count; i++)
		{
			Connections[i].Close();
		}
		Connections.Clear();
	}

	public void Destroy()
	{
		StopAllConnections();
		StopListen();
	}

	private void CheckTcpConnectionReceive(NetConnection connection)
	{
		try
		{
			Stopwatch stopwatch = new Stopwatch();
			int num = 0;
			int num2 = connection.Sock.Available;
			if (num2 == 0)
			{
				if (connection.Sock.Poll(0, SelectMode.SelectRead))
				{
					connection.SetCloseReason(NetClosedReason.NET_CLOSE_PEER);
					connection.SetError("Check Peer Closed", 0);
					connection.ConnectState = ConnctionState.CONNECTION_WAIT_CLOSE;
				}
				return;
			}
			byte[] array = new byte[12];
			while (num2 > 12)
			{
				if (connection.Sock.Receive(array, 12, SocketFlags.Peek) != 12)
				{
					connection.SetCloseReason(NetClosedReason.NET_CLOSE_RECEIVE);
					connection.SetError("Recv Head Size Not Match", 0);
					connection.ConnectState = ConnctionState.CONNECTION_WAIT_CLOSE;
					break;
				}
				NetFrameHead head = connection.DecodeFrameHead(array);
				if (head.magic != 1437226410)
				{
					connection.SetCloseReason(NetClosedReason.NET_CLOSE_FRAME_MALFORMD);
					connection.SetError("Magic Error", 0);
					connection.ConnectState = ConnctionState.CONNECTION_WAIT_CLOSE;
					break;
				}
				if (head.frame_length > 655360 || head.frame_length <= 12)
				{
					connection.SetCloseReason(NetClosedReason.NET_CLOSE_FRAME_MALFORMD);
					connection.SetError($"Frame Size Invalid:{head.frame_length}", 0);
					connection.ConnectState = ConnctionState.CONNECTION_WAIT_CLOSE;
					break;
				}
				if (num2 < head.frame_length)
				{
					break;
				}
				connection.ReserveFrameBuffer(head.frame_length);
				if (connection.Sock.Receive(connection.FrameBuffer, head.frame_length, SocketFlags.None) != head.frame_length)
				{
					connection.SetCloseReason(NetClosedReason.NET_CLOSE_RECEIVE);
					connection.SetError("Recv Body Size Not Match", 0);
					connection.ConnectState = ConnctionState.CONNECTION_WAIT_CLOSE;
					break;
				}
				num2 -= head.frame_length;
				byte[] array2 = connection.DecodeFrameBody(head, connection.FrameBuffer);
				stopwatch.Start();
				try
				{
					connection.OnReceive(array2, array2.Length);
				}
				catch (Exception e)
				{
					throw new NetMsgHandlerException(e);
				}
				stopwatch.Stop();
				if (connection.ConnectState != ConnctionState.CONNECTION_ESTABLISHED)
				{
					break;
				}
				num++;
				if (num >= MaxDispctchMsgNumOneTick)
				{
					break;
				}
			}
		}
		catch (SocketException ex)
		{
			connection.SetCloseReason(NetClosedReason.NET_CLOSE_PEER);
			connection.SetError(ex.ToString(), ex.ErrorCode);
			connection.ConnectState = ConnctionState.CONNECTION_WAIT_CLOSE;
		}
		catch (NetMsgHandlerException ex2)
		{
			connection.SetCloseReason(NetClosedReason.NET_CLOSE_RECEIVE);
			connection.SetError(ex2.Message, 0);
			connection.ConnectState = ConnctionState.CONNECTION_WAIT_CLOSE;
			if (EnableThrowUserException)
			{
				throw;
			}
		}
		catch (Exception ex3)
		{
			connection.SetCloseReason(NetClosedReason.NET_CLOSE_RECEIVE);
			connection.SetError(ex3.ToString(), 0);
			connection.ConnectState = ConnctionState.CONNECTION_WAIT_CLOSE;
		}
	}

	private void CheckUdpConnectionReceive(NetConnection connection)
	{
		try
		{
			int num = connection.Sock.Available;
			int num2 = 0;
			while (num > 12)
			{
				num2 = connection.Sock.Receive(connection.FrameBuffer, SocketFlags.None);
				if (num2 <= 12)
				{
					connection.SetError("Recv Body Size Not Match", 0);
					break;
				}
				num -= num2;
				NetFrameHead head = connection.DecodeFrameHead(connection.FrameBuffer);
				if (head.magic != 1437226410)
				{
					connection.SetError("Magic Error", 0);
					break;
				}
				if (head.frame_length > 655360 || head.frame_length <= 12)
				{
					connection.SetError($"Frame Size Invalid:{head.frame_length}", 0);
					break;
				}
				byte[] array = connection.DecodeFrameBody(head, connection.FrameBuffer);
				try
				{
					connection.OnReceive(array, array.Length);
				}
				catch (Exception e)
				{
					throw new NetMsgHandlerException(e);
				}
				if (connection.ConnectState != ConnctionState.CONNECTION_ESTABLISHED)
				{
					break;
				}
			}
		}
		catch (SocketException ex)
		{
			connection.SetCloseReason(NetClosedReason.NET_CLOSE_PEER);
			connection.SetError(ex.Message, ex.ErrorCode);
			connection.ConnectState = ConnctionState.CONNECTION_WAIT_CLOSE;
		}
		catch (NetMsgHandlerException ex2)
		{
			connection.SetCloseReason(NetClosedReason.NET_CLOSE_RECEIVE);
			connection.SetError(ex2.Message, 0);
			connection.ConnectState = ConnctionState.CONNECTION_WAIT_CLOSE;
			if (EnableThrowUserException)
			{
				throw;
			}
		}
		catch (Exception ex3)
		{
			connection.SetCloseReason(NetClosedReason.NET_CLOSE_RECEIVE);
			connection.SetError(ex3.Message, 0);
			connection.ConnectState = ConnctionState.CONNECTION_WAIT_CLOSE;
		}
	}

	private void CheckKcpConnectionReceive(NetConnection connection)
	{
	}

	public void CheckConnectingSocket(List<Socket> waitSockets)
	{
		Socket.Select(null, waitSockets, null, 0);
		for (int i = 0; i < waitSockets.Count; i++)
		{
			for (int j = 0; j < Connections.Count; j++)
			{
				if (waitSockets[i] == Connections[j].Sock)
				{
					NetConnection netConnection = Connections[j];
					if (netConnection.Sock.Connected)
					{
						netConnection.ConnectTimeoutSecond = 0f;
						netConnection.ConnectState = ConnctionState.CONNECTION_ESTABLISHED;
						netConnection.OnConnectStatus(netConnection, bSuccess: true, "");
					}
				}
			}
		}
	}

	public void CheckEstablishedSocket(List<Socket> waitSockets)
	{
		List<Socket> list = new List<Socket>();
		for (int i = 0; i < waitSockets.Count; i++)
		{
			list.Add(waitSockets[i]);
		}
		Socket.Select(waitSockets, null, null, 0);
		for (int j = 0; j < waitSockets.Count; j++)
		{
			for (int k = 0; k < Connections.Count; k++)
			{
				if (waitSockets[j] == Connections[k].Sock)
				{
					if (Connections[k].NetType == NetProtoType.NET_PROTO_TCP)
					{
						CheckTcpConnectionReceive(Connections[k]);
					}
					else if (Connections[k].NetType == NetProtoType.NET_PROTO_UDP)
					{
						CheckUdpConnectionReceive(Connections[k]);
					}
					else if (Connections[k].NetType == NetProtoType.NET_PROTO_KCP)
					{
						CheckKcpConnectionReceive(Connections[k]);
					}
				}
			}
		}
	}

	private void CheckNewConnx()
	{
		do
		{
			try
			{
				Socket socket = listenerContext.Listener.AcceptSocket();
				socket.NoDelay = true;
				socket.SendBufferSize = 1048576;
				socket.ReceiveBufferSize = 1048576;
				socket.Blocking = false;
				socket.SendBufferSize = listenerContext.SendBufferSize;
				socket.ReceiveBufferSize = listenerContext.ReceiveBufferSize;
				NetConnection connx = new NetConnection
				{
					Sock = socket,
					OnConnectStatus = null,
					NetType = NetProtoType.NET_PROTO_TCP,
					ConnectState = ConnctionState.CONNECTION_ESTABLISHED,
					IsServerAccepted = true
				};
				connx.OnClosed = delegate
				{
					listenerContext.onConnxCloseCallback(connx);
				};
				connx.OnReceive = delegate(byte[] buffer, int len)
				{
					listenerContext.onConnxReceiveCallback(connx, buffer, len);
				};
				if (listenerContext.ZipThresholdSize > 0)
				{
					connx.MaxCompressThresholdSize = listenerContext.ZipThresholdSize;
				}
				connx.ReserveFrameBuffer(65536);
				Connections.Add(connx);
				listenerContext.onNewConnxCallback(connx);
			}
			catch (Exception)
			{
			}
		}
		while (listenerContext.Listener.Pending());
	}

	public void TickDispatch(float DeltaTime)
	{
		List<Socket> list = new List<Socket>();
		List<Socket> list2 = new List<Socket>();
		for (int num = Connections.Count - 1; num >= 0; num--)
		{
			NetConnection netConnection = Connections[num];
			if (netConnection.ConnectState == ConnctionState.CONNECTION_CONNECTING)
			{
				netConnection.ConnectTimeoutSecond -= DeltaTime;
				if (netConnection.ConnectTimeoutSecond <= 0f)
				{
					netConnection.Close();
					netConnection.SetError("Connect Time Out", 0);
					netConnection.OnConnectStatus(null, bSuccess: false, "time out");
				}
				else
				{
					list.Add(netConnection.Sock);
				}
			}
			else if (netConnection.ConnectState == ConnctionState.CONNECTION_ESTABLISHED)
			{
				list2.Add(netConnection.Sock);
			}
		}
		if (list.Count > 0)
		{
			CheckConnectingSocket(list);
		}
		if (list2.Count > 0)
		{
			CheckEstablishedSocket(list2);
		}
		for (int num2 = Connections.Count - 1; num2 >= 0; num2--)
		{
			NetConnection netConnection2 = Connections[num2];
			if (netConnection2.ConnectState == ConnctionState.CONNECTION_WAIT_CLOSE || netConnection2.ConnectState == ConnctionState.CONNECTION_DESTROY)
			{
				if (netConnection2.ConnectState == ConnctionState.CONNECTION_WAIT_CLOSE)
				{
					Connections[num2].OnClosed();
					Connections[num2].Close();
				}
				Connections.RemoveAt(num2);
			}
		}
		if (listenerContext != null && listenerContext.Listener != null && listenerContext.Listener.Pending())
		{
			CheckNewConnx();
		}
	}

	public static List<int> GetBusyTcpPortList()
	{
		List<int> list = new List<int>();
		IPEndPoint[] activeTcpListeners = IPGlobalProperties.GetIPGlobalProperties().GetActiveTcpListeners();
		foreach (IPEndPoint iPEndPoint in activeTcpListeners)
		{
			list.Add(iPEndPoint.Port);
		}
		return list;
	}

	public bool Listen(OnNewClientEventCallback onNewConnect, OnClientClosedEventCallback onClosed, OnClientReceiveEventCallback onReceived, string Url, out string Error)
	{
		if (listenerContext.Listener != null)
		{
			Error = "server listen already";
			return false;
		}
		UrlParser urlParser = new UrlParser();
		if (!urlParser.Parse(Url))
		{
			Error = "Url is Invalid";
			return false;
		}
		urlParser.GetProto("tcp").ToLowerInvariant();
		string host = urlParser.GetHost();
		short num = urlParser.GetPort(8080);
		int sendBufferSize = Convert.ToInt32(urlParser.GetOption("SendBuffSize", "512000"));
		int receiveBufferSize = Convert.ToInt32(urlParser.GetOption("RecvBuffSize", "512000"));
		int backlog = Convert.ToInt32(urlParser.GetOption("Backlog", "8"));
		_ = urlParser.GetOption("NoDelay", "1") == "1";
		_ = urlParser.GetOption("KeepAlive", "0") == "1";
		_ = urlParser.GetOption("ReuseAddr", "0") == "1";
		Convert.ToInt32(urlParser.GetOption("ZipThreshold", "0"));
		int num2 = Convert.ToInt32(urlParser.GetOption("PortProbeNumMax", "8"));
		try
		{
			IPAddress iPAddress = IPAddress.Any;
			if (!host.All((char c) => c == '.' || char.IsDigit(c)))
			{
				LogHelper.LogError("warnning: host is not ip , need dns:" + host);
				IPAddress[] hostAddresses = Dns.GetHostAddresses(host);
				if (hostAddresses != null && hostAddresses.Length != 0)
				{
					Random random = new Random();
					iPAddress = hostAddresses[random.Next(hostAddresses.Length)];
					LogHelper.LogError("warnning: dns host:" + host + " query ip num:" + hostAddresses.Length + " select:" + iPAddress);
				}
			}
			else
			{
				iPAddress = IPAddress.Parse(host);
			}
			List<int> busyTcpPortList = GetBusyTcpPortList();
			int num3 = 0;
			while (num3 < num2 && busyTcpPortList.Contains(num))
			{
				LogHelper.LogWarn("tcp listen port:{0} is busy, try next.", num);
				num3++;
				num++;
			}
			IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, num);
			TcpListener tcpListener = new TcpListener(iPEndPoint);
			tcpListener.Start(backlog);
			listenerContext = new ListenerContext
			{
				Listener = tcpListener,
				onConnxCloseCallback = onClosed,
				onConnxReceiveCallback = onReceived,
				onNewConnxCallback = onNewConnect,
				SendBufferSize = sendBufferSize,
				ReceiveBufferSize = receiveBufferSize,
				FinalListenAddress = iPEndPoint
			};
			Error = null;
			return true;
		}
		catch (Exception ex)
		{
			Error = ex.Message;
			LogHelper.LogError("net connect exception:" + ex.ToString());
			return false;
		}
	}

	public bool Connect(OnConnectStatusEventCallback onConnect, OnClosedEventCallback onClosed, OnReceiveEventCallback onReceived, string Url, out string Error)
	{
		UrlParser urlParser = new UrlParser();
		if (!urlParser.Parse(Url))
		{
			Error = "Url is Invalid";
			return false;
		}
		string text = urlParser.GetProto("tcp").ToLowerInvariant();
		string host = urlParser.GetHost();
		short port = urlParser.GetPort(8080);
		int sendBufferSize = Convert.ToInt32(urlParser.GetOption("SendBuffSize", "512000"));
		int receiveBufferSize = Convert.ToInt32(urlParser.GetOption("RecvBuffSize", "512000"));
		bool noDelay = urlParser.GetOption("NoDelay", "1") == "1";
		bool flag = urlParser.GetOption("KeepAlive", "0") == "1";
		bool flag2 = urlParser.GetOption("ReuseAddr", "0") == "1";
		int num = Convert.ToInt32(urlParser.GetOption("ZipThreshold", "0"));
		int num2 = Convert.ToInt32(urlParser.GetOption("ConnectTimeout", "5"));
		if (num2 <= 0 || num2 > 10)
		{
			num2 = 5;
		}
		SocketType socketType = SocketType.Stream;
		ProtocolType protocolType = ProtocolType.Tcp;
		NetProtoType netProtoType = NetProtoType.NET_PROTO_TCP;
		if (text == "udp" || text == "kcp")
		{
			socketType = SocketType.Dgram;
			protocolType = ProtocolType.Udp;
			if (text == "udp")
			{
				netProtoType = NetProtoType.NET_PROTO_UDP;
			}
			else if (text == "kcp")
			{
				netProtoType = NetProtoType.NET_PROTO_KCP;
			}
		}
		NetConnection netConnection = null;
		try
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			Socket socket = new Socket(AddressFamily.InterNetwork, socketType, protocolType);
			IPAddress iPAddress = null;
			if (!host.All((char c) => c == '.' || char.IsDigit(c)))
			{
				LogHelper.LogError("warnning: host is not ip , need dns:" + host);
				IPAddress[] hostAddresses = Dns.GetHostAddresses(host);
				if (hostAddresses != null && hostAddresses.Length != 0)
				{
					Random random = new Random();
					iPAddress = hostAddresses[random.Next(hostAddresses.Length)];
					LogHelper.LogError("warnning: dns host:" + host + " query ip num:" + hostAddresses.Length + " select:" + iPAddress);
				}
			}
			else
			{
				iPAddress = IPAddress.Parse(host);
			}
			socket.Blocking = false;
			socket.SendBufferSize = sendBufferSize;
			socket.ReceiveBufferSize = receiveBufferSize;
			if (netProtoType == NetProtoType.NET_PROTO_TCP)
			{
				socket.NoDelay = noDelay;
				if (flag)
				{
					socket.SetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.KeepAlive, optionValue: true);
				}
				if (flag2)
				{
					socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, optionValue: true);
				}
			}
			try
			{
				LogHelper.LogError("warnning: connecting server:" + iPAddress?.ToString() + ":" + port);
				socket.ConnectAsync(iPAddress, port);
			}
			catch (SocketException ex)
			{
				if (ex.ErrorCode != 10035 && ex.ErrorCode != 10036)
				{
					throw ex;
				}
			}
			stopwatch.Stop();
			string text2 = text + "://" + iPAddress.ToString() + ":" + port;
			netConnection = new NetConnection
			{
				Sock = socket,
				OnClosed = onClosed,
				OnConnectStatus = onConnect,
				OnReceive = onReceived,
				NetType = netProtoType,
				ConnectState = ConnctionState.CONNECTION_CONNECTING,
				ConnectTimeoutSecond = num2,
				Uri = text2
			};
			if (num > 0)
			{
				netConnection.MaxCompressThresholdSize = num;
			}
			netConnection.ReserveFrameBuffer(65536);
			Connections.Add(netConnection);
			Error = text2;
			return true;
		}
		catch (Exception ex2)
		{
			Error = ex2.Message;
			LogHelper.LogError("net connect exception:" + ex2.ToString());
			return false;
		}
	}
}
