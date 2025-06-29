using System;
using System.IO;
using System.Net.Sockets;

namespace ILRuntime.Runtime.Debugger;

public class DebugSocket
{
	private Socket _socket;

	private bool _ready;

	private const int MAX_BUFF_SIZE = 262144;

	private const int HEAD_SIZE = 8;

	private byte[] _headBuffer = new byte[8];

	private byte[] _sendBuffer = new byte[65536];

	private MemoryStream _sendStream;

	private BinaryWriter bw;

	private const int RECV_BUFFER_SIZE = 1024;

	private MemoryStream recvBuffer = new MemoryStream();

	private int lastMsgLength = -1;

	private byte[] socketAsyncBuffer = new byte[1024];

	private SocketAsyncEventArgs saeArgs;

	private object socketLockObj = new object();

	private byte[] _sendHeaderBuffer = new byte[8];

	public bool Disconnected
	{
		get
		{
			if (_socket != null)
			{
				return !_socket.Connected;
			}
			return true;
		}
	}

	public Action OnConnect { get; set; }

	public Action OnConnectFailed { get; set; }

	public Action OnClose { get; set; }

	public Action<DebugMessageType, byte[]> OnReciveMessage { get; set; }

	public DebugSocket()
	{
		_sendStream = new MemoryStream(_sendBuffer);
		bw = new BinaryWriter(_sendStream);
	}

	public DebugSocket(Socket _socket)
		: this()
	{
		this._socket = _socket;
		BeginReceive();
		_ready = true;
	}

	public void Connect(string ip, int port)
	{
		Close();
		Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		socket.BeginConnect(ip, port, onConnected, this);
		_socket = socket;
		_ready = false;
	}

	private void AsyncRecv_Completed(object sender, SocketAsyncEventArgs e)
	{
		if (e.SocketError == SocketError.Success && e.BytesTransferred > 0)
		{
			try
			{
				ReceivePayload(e.Buffer, e.BytesTransferred);
			}
			catch (Exception)
			{
				Close();
				return;
			}
			try
			{
				if (!_socket.ReceiveAsync(saeArgs))
				{
					AsyncRecv_Completed(null, saeArgs);
				}
				return;
			}
			catch (Exception ex2)
			{
				Close();
				throw ex2;
			}
		}
		Close();
	}

	private void ReceivePayload(byte[] data, int length)
	{
		if (_socket == null)
		{
			return;
		}
		if (!_socket.Connected)
		{
			Close();
			return;
		}
		recvBuffer.Position = recvBuffer.Length;
		recvBuffer.Write(data, 0, length);
		if (lastMsgLength < 0 && recvBuffer.Length < 4)
		{
			byte[] array = null;
			return;
		}
		recvBuffer.Position = 0L;
		BinaryReader binaryReader = new BinaryReader(recvBuffer);
		if (lastMsgLength < 0)
		{
			lastMsgLength = binaryReader.ReadInt32() - 4;
			if (lastMsgLength > 262144)
			{
				Close();
				throw new Exception("Too long package length!");
			}
		}
		int num = (int)(recvBuffer.Length - recvBuffer.Position);
		while (num >= lastMsgLength && lastMsgLength > 0)
		{
			int arg = binaryReader.ReadInt32();
			byte[] array = binaryReader.ReadBytes(lastMsgLength - 4);
			try
			{
				if (OnReciveMessage != null)
				{
					OnReciveMessage((DebugMessageType)arg, array);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
			lastMsgLength = -1;
			num = (int)(recvBuffer.Length - recvBuffer.Position);
			if (num >= 4)
			{
				lastMsgLength = binaryReader.ReadInt32() - 4;
				num -= 4;
				if (lastMsgLength > 262144)
				{
					Close();
					throw new Exception("Too long package length!");
				}
			}
		}
		num = (int)(recvBuffer.Length - recvBuffer.Position);
		if (num > 0)
		{
			byte[] buffer = recvBuffer.GetBuffer();
			Array.Copy(buffer, recvBuffer.Position, buffer, 0L, num);
		}
		recvBuffer.Position = 0L;
		recvBuffer.SetLength(num);
	}

	private void onConnected(IAsyncResult result)
	{
		if (_socket.Connected)
		{
			_socket.EndConnect(result);
			BeginReceive();
			if (OnConnect != null)
			{
				OnConnect();
			}
		}
		else if (OnConnectFailed != null)
		{
			OnConnectFailed();
		}
	}

	private void BeginReceive()
	{
		saeArgs = new SocketAsyncEventArgs();
		saeArgs.Completed += AsyncRecv_Completed;
		saeArgs.SetBuffer(socketAsyncBuffer, 0, socketAsyncBuffer.Length);
		_socket.ReceiveAsync(saeArgs);
		_ready = true;
	}

	public void Send(DebugMessageType type, byte[] buffer, int len)
	{
		if (_ready)
		{
			_sendStream.Position = 0L;
			bw.Write(len + 8);
			bw.Write((int)type);
			bw.Write(buffer, 0, len);
			int end = (int)_sendStream.Position;
			RawSend(_socket, _sendBuffer, end);
		}
	}

	private void RawSend(Socket sock, byte[] buf, int end)
	{
		if (sock != null)
		{
			if (end < 0)
			{
				end = buf.Length;
			}
			sock.Send(buf, end, SocketFlags.None);
		}
	}

	public void Close()
	{
		if (_socket != null && _ready)
		{
			if (saeArgs != null)
			{
				saeArgs.Dispose();
			}
			_socket.Close();
			_socket = null;
			_ready = false;
			if (OnClose != null)
			{
				OnClose();
			}
		}
	}
}
