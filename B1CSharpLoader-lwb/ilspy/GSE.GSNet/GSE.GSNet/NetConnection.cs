using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using GSE.OnlineBase;

namespace GSE.GSNet;

public class NetConnection
{
	public const int FRAME_HEAD_BYTE_SIZE = 12;

	public const int FRAME_MAX_SIZE = 655360;

	public const int UXNET_MSG_FRAME_MAGIC = 1437226410;

	public const int UXNET_MSG_FRAME_FLAG_ZIPED = 1;

	public const int UXNET_MSG_FRAME_FLAG_ENCRYPT = 2;

	public NetProtoType NetType;

	public ConnctionState ConnectState;

	private byte[] FrameHeadBuffer;

	public byte[] FrameBuffer;

	public uint FrameBodySize;

	public float ConnectTimeoutSecond;

	public string Uri;

	public Socket Sock;

	public OnConnectStatusEventCallback OnConnectStatus;

	public OnReceiveEventCallback OnReceive;

	public OnClosedEventCallback OnClosed;

	public NetClosedReason CloseReason;

	private string Error;

	private int ErrorCode;

	private int maxCompressThresholdSize;

	public bool IsServerAccepted;

	public int MaxCompressThresholdSize
	{
		get
		{
			return maxCompressThresholdSize;
		}
		set
		{
			maxCompressThresholdSize = value;
		}
	}

	public void Close()
	{
		if (Sock != null)
		{
			Sock.Close();
			ConnectState = ConnctionState.CONNECTION_DESTROY;
			Sock = null;
		}
	}

	public NetConnection()
	{
		FrameHeadBuffer = new byte[12];
	}

	public NetFrameHead DecodeFrameHead(byte[] frameHeadBytes)
	{
		NetFrameHead result = default(NetFrameHead);
		result.frame_length = 0;
		result.magic = 0;
		result.flags = 0;
		result.frame_length = IPAddress.NetworkToHostOrder(BitConverter.ToInt32(frameHeadBytes, 0));
		result.magic = IPAddress.NetworkToHostOrder(BitConverter.ToInt32(frameHeadBytes, 4));
		result.flags = IPAddress.NetworkToHostOrder(BitConverter.ToInt32(frameHeadBytes, 8));
		return result;
	}

	public byte[] DecodeFrameBody(NetFrameHead head, byte[] frameBufferBytes)
	{
		int num = head.frame_length - 12;
		if (num < 0)
		{
			return new byte[0];
		}
		byte[] array = new byte[num];
		Array.Copy(frameBufferBytes, 12, array, 0, num);
		if ((head.flags & 1) != 0)
		{
			return ZlibHelper.ZlibDecompress(array);
		}
		return array;
	}

	private byte[] EncodeFrameBuffer(byte[] frameHeadBytes, byte[] Payload)
	{
		int num = Payload.Length;
		byte[] bytes = BitConverter.GetBytes(IPAddress.HostToNetworkOrder(1437226410));
		frameHeadBytes[4] = bytes[0];
		frameHeadBytes[5] = bytes[1];
		frameHeadBytes[6] = bytes[2];
		frameHeadBytes[7] = bytes[3];
		int num2 = 0;
		bool flag = false;
		if (num > maxCompressThresholdSize && maxCompressThresholdSize > 0)
		{
			num2 |= 1;
			flag = true;
		}
		bytes = BitConverter.GetBytes(IPAddress.HostToNetworkOrder(num2));
		frameHeadBytes[8] = bytes[0];
		frameHeadBytes[9] = bytes[1];
		frameHeadBytes[10] = bytes[2];
		frameHeadBytes[11] = bytes[3];
		if (flag)
		{
			byte[] array = ZlibHelper.ZlibCompress(Payload);
			bytes = BitConverter.GetBytes(IPAddress.HostToNetworkOrder(array.Length + 12));
			frameHeadBytes[0] = bytes[0];
			frameHeadBytes[1] = bytes[1];
			frameHeadBytes[2] = bytes[2];
			frameHeadBytes[3] = bytes[3];
			return array;
		}
		bytes = BitConverter.GetBytes(IPAddress.HostToNetworkOrder(num + 12));
		frameHeadBytes[0] = bytes[0];
		frameHeadBytes[1] = bytes[1];
		frameHeadBytes[2] = bytes[2];
		frameHeadBytes[3] = bytes[3];
		return Payload;
	}

	public bool Send(byte[] Buffer)
	{
		if (Sock != null)
		{
			try
			{
				byte[] array = EncodeFrameBuffer(FrameHeadBuffer, Buffer);
				IList<ArraySegment<byte>> buffers = new ArraySegment<byte>[2]
				{
					new ArraySegment<byte>(FrameHeadBuffer),
					new ArraySegment<byte>(array)
				};
				if (Sock.Send(buffers) != 12 + array.Length)
				{
					CloseReason = NetClosedReason.NET_CLOSE_SEND;
					Error = "Send Buffer Size Not Match";
					return false;
				}
				return true;
			}
			catch (SocketException ex)
			{
				ErrorCode = ex.ErrorCode;
				Error = ex.ToString();
				ConnectState = ConnctionState.CONNECTION_WAIT_CLOSE;
				return false;
			}
			catch (ObjectDisposedException ex2)
			{
				Error = ex2.ToString();
				ConnectState = ConnctionState.CONNECTION_WAIT_CLOSE;
				return false;
			}
			catch (Exception ex3)
			{
				Error = ex3.ToString();
				ConnectState = ConnctionState.CONNECTION_WAIT_CLOSE;
				return false;
			}
		}
		return false;
	}

	public NetClosedReason GetCloseReason()
	{
		return CloseReason;
	}

	public int GetErrorCode()
	{
		return ErrorCode;
	}

	public string GetError()
	{
		return Error;
	}

	public void SetError(string ErrMsg, int ErrCode)
	{
		Error = ErrMsg;
		ErrorCode = ErrCode;
	}

	public void SetCloseReason(NetClosedReason Reason)
	{
		CloseReason = Reason;
	}

	public void ReserveFrameBuffer(int iBuff)
	{
		if (FrameBuffer == null || FrameBuffer.Length < iBuff)
		{
			FrameBuffer = new byte[iBuff];
		}
	}

	public override string ToString()
	{
		if (Uri != null)
		{
			return Uri + "|" + ConnectState.ToString() + "|" + ErrorCode;
		}
		return "nil";
	}
}
