using System;
using Google.Protobuf;

namespace Gs;

public sealed class UxNetMsg : IMessage<UxNetMsg>, IMessage, IEquatable<UxNetMsg>, IDeepCloneable<UxNetMsg>
{
	private static readonly MessageParser<UxNetMsg> _parser = new MessageParser<UxNetMsg>(() => new UxNetMsg());

	private UnknownFieldSet _unknownFields;

	private UxNetMsgCmd cmd_;

	private ByteString payload_ = ByteString.Empty;

	private UxNetUdpAsk udpAsk_;

	private UxNetUdpAck updAck_;

	private UxNetAuthReq authReq_;

	private UxNetAuthRes authRes_;

	private UxNetAuthToken authToken_;

	public static MessageParser<UxNetMsg> Parser => _parser;

	public UxNetMsgCmd Cmd
	{
		get
		{
			return cmd_;
		}
		set
		{
			cmd_ = value;
		}
	}

	public ByteString Payload
	{
		get
		{
			return payload_;
		}
		set
		{
			payload_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public UxNetUdpAsk UdpAsk
	{
		get
		{
			return udpAsk_;
		}
		set
		{
			udpAsk_ = value;
		}
	}

	public UxNetUdpAck UpdAck
	{
		get
		{
			return updAck_;
		}
		set
		{
			updAck_ = value;
		}
	}

	public UxNetAuthReq AuthReq
	{
		get
		{
			return authReq_;
		}
		set
		{
			authReq_ = value;
		}
	}

	public UxNetAuthRes AuthRes
	{
		get
		{
			return authRes_;
		}
		set
		{
			authRes_ = value;
		}
	}

	public UxNetAuthToken AuthToken
	{
		get
		{
			return authToken_;
		}
		set
		{
			authToken_ = value;
		}
	}

	public UxNetMsg()
	{
	}

	public UxNetMsg(UxNetMsg other)
		: this()
	{
		cmd_ = other.cmd_;
		payload_ = other.payload_;
		udpAsk_ = ((other.udpAsk_ != null) ? other.udpAsk_.Clone() : null);
		updAck_ = ((other.updAck_ != null) ? other.updAck_.Clone() : null);
		authReq_ = ((other.authReq_ != null) ? other.authReq_.Clone() : null);
		authRes_ = ((other.authRes_ != null) ? other.authRes_.Clone() : null);
		authToken_ = ((other.authToken_ != null) ? other.authToken_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public UxNetMsg Clone()
	{
		return new UxNetMsg(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as UxNetMsg);
	}

	public bool Equals(UxNetMsg other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Cmd != other.Cmd)
		{
			return false;
		}
		if (Payload != other.Payload)
		{
			return false;
		}
		if (!object.Equals(UdpAsk, other.UdpAsk))
		{
			return false;
		}
		if (!object.Equals(UpdAck, other.UpdAck))
		{
			return false;
		}
		if (!object.Equals(AuthReq, other.AuthReq))
		{
			return false;
		}
		if (!object.Equals(AuthRes, other.AuthRes))
		{
			return false;
		}
		if (!object.Equals(AuthToken, other.AuthToken))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Cmd != UxNetMsgCmd.Payload)
		{
			num ^= Cmd.GetHashCode();
		}
		if (Payload.Length != 0)
		{
			num ^= Payload.GetHashCode();
		}
		if (udpAsk_ != null)
		{
			num ^= UdpAsk.GetHashCode();
		}
		if (updAck_ != null)
		{
			num ^= UpdAck.GetHashCode();
		}
		if (authReq_ != null)
		{
			num ^= AuthReq.GetHashCode();
		}
		if (authRes_ != null)
		{
			num ^= AuthRes.GetHashCode();
		}
		if (authToken_ != null)
		{
			num ^= AuthToken.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Cmd != UxNetMsgCmd.Payload)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Cmd);
		}
		if (Payload.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteBytes(Payload);
		}
		if (udpAsk_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(UdpAsk);
		}
		if (updAck_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(UpdAck);
		}
		if (authReq_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(AuthReq);
		}
		if (authRes_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(AuthRes);
		}
		if (authToken_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(AuthToken);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Cmd != UxNetMsgCmd.Payload)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Cmd);
		}
		if (Payload.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(Payload);
		}
		if (udpAsk_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(UdpAsk);
		}
		if (updAck_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(UpdAck);
		}
		if (authReq_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AuthReq);
		}
		if (authRes_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AuthRes);
		}
		if (authToken_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AuthToken);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(UxNetMsg other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Cmd != UxNetMsgCmd.Payload)
		{
			Cmd = other.Cmd;
		}
		if (other.Payload.Length != 0)
		{
			Payload = other.Payload;
		}
		if (other.udpAsk_ != null)
		{
			if (udpAsk_ == null)
			{
				UdpAsk = new UxNetUdpAsk();
			}
			UdpAsk.MergeFrom(other.UdpAsk);
		}
		if (other.updAck_ != null)
		{
			if (updAck_ == null)
			{
				UpdAck = new UxNetUdpAck();
			}
			UpdAck.MergeFrom(other.UpdAck);
		}
		if (other.authReq_ != null)
		{
			if (authReq_ == null)
			{
				AuthReq = new UxNetAuthReq();
			}
			AuthReq.MergeFrom(other.AuthReq);
		}
		if (other.authRes_ != null)
		{
			if (authRes_ == null)
			{
				AuthRes = new UxNetAuthRes();
			}
			AuthRes.MergeFrom(other.AuthRes);
		}
		if (other.authToken_ != null)
		{
			if (authToken_ == null)
			{
				AuthToken = new UxNetAuthToken();
			}
			AuthToken.MergeFrom(other.AuthToken);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 8u:
				Cmd = (UxNetMsgCmd)input.ReadEnum();
				break;
			case 18u:
				Payload = input.ReadBytes();
				break;
			case 26u:
				if (udpAsk_ == null)
				{
					UdpAsk = new UxNetUdpAsk();
				}
				input.ReadMessage(UdpAsk);
				break;
			case 34u:
				if (updAck_ == null)
				{
					UpdAck = new UxNetUdpAck();
				}
				input.ReadMessage(UpdAck);
				break;
			case 42u:
				if (authReq_ == null)
				{
					AuthReq = new UxNetAuthReq();
				}
				input.ReadMessage(AuthReq);
				break;
			case 50u:
				if (authRes_ == null)
				{
					AuthRes = new UxNetAuthRes();
				}
				input.ReadMessage(AuthRes);
				break;
			case 58u:
				if (authToken_ == null)
				{
					AuthToken = new UxNetAuthToken();
				}
				input.ReadMessage(AuthToken);
				break;
			}
		}
	}
}
