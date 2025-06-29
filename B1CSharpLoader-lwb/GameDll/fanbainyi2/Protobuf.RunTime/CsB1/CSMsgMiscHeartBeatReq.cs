using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgMiscHeartBeatReq : IMessage<CSMsgMiscHeartBeatReq>, IMessage, IEquatable<CSMsgMiscHeartBeatReq>, IDeepCloneable<CSMsgMiscHeartBeatReq>
{
	private static readonly MessageParser<CSMsgMiscHeartBeatReq> _parser = new MessageParser<CSMsgMiscHeartBeatReq>(() => new CSMsgMiscHeartBeatReq());

	private UnknownFieldSet _unknownFields;

	private uint ping_;

	public static MessageParser<CSMsgMiscHeartBeatReq> Parser => _parser;

	public uint Ping
	{
		get
		{
			return ping_;
		}
		set
		{
			ping_ = value;
		}
	}

	public CSMsgMiscHeartBeatReq()
	{
	}

	public CSMsgMiscHeartBeatReq(CSMsgMiscHeartBeatReq other)
		: this()
	{
		ping_ = other.ping_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgMiscHeartBeatReq Clone()
	{
		return new CSMsgMiscHeartBeatReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgMiscHeartBeatReq);
	}

	public bool Equals(CSMsgMiscHeartBeatReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Ping != other.Ping)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Ping != 0)
		{
			num ^= Ping.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Ping != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Ping);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Ping != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Ping);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgMiscHeartBeatReq other)
	{
		if (other != null)
		{
			if (other.Ping != 0)
			{
				Ping = other.Ping;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				Ping = input.ReadUInt32();
			}
		}
	}
}
