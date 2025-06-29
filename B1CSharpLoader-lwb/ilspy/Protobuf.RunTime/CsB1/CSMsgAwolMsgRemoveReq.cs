using System;
using CommB1;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgAwolMsgRemoveReq : IMessage<CSMsgAwolMsgRemoveReq>, IMessage, IEquatable<CSMsgAwolMsgRemoveReq>, IDeepCloneable<CSMsgAwolMsgRemoveReq>
{
	private static readonly MessageParser<CSMsgAwolMsgRemoveReq> _parser = new MessageParser<CSMsgAwolMsgRemoveReq>(() => new CSMsgAwolMsgRemoveReq());

	private UnknownFieldSet _unknownFields;

	private AwolMsgType msgType_;

	private uint msgId_;

	public static MessageParser<CSMsgAwolMsgRemoveReq> Parser => _parser;

	public AwolMsgType MsgType
	{
		get
		{
			return msgType_;
		}
		set
		{
			msgType_ = value;
		}
	}

	public uint MsgId
	{
		get
		{
			return msgId_;
		}
		set
		{
			msgId_ = value;
		}
	}

	public CSMsgAwolMsgRemoveReq()
	{
	}

	public CSMsgAwolMsgRemoveReq(CSMsgAwolMsgRemoveReq other)
		: this()
	{
		msgType_ = other.msgType_;
		msgId_ = other.msgId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgAwolMsgRemoveReq Clone()
	{
		return new CSMsgAwolMsgRemoveReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgAwolMsgRemoveReq);
	}

	public bool Equals(CSMsgAwolMsgRemoveReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MsgType != other.MsgType)
		{
			return false;
		}
		if (MsgId != other.MsgId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (MsgType != AwolMsgType.None)
		{
			num ^= MsgType.GetHashCode();
		}
		if (MsgId != 0)
		{
			num ^= MsgId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (MsgType != AwolMsgType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)MsgType);
		}
		if (MsgId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(MsgId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (MsgType != AwolMsgType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MsgType);
		}
		if (MsgId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MsgId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgAwolMsgRemoveReq other)
	{
		if (other != null)
		{
			if (other.MsgType != AwolMsgType.None)
			{
				MsgType = other.MsgType;
			}
			if (other.MsgId != 0)
			{
				MsgId = other.MsgId;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
				MsgType = (AwolMsgType)input.ReadEnum();
				break;
			case 16u:
				MsgId = input.ReadUInt32();
				break;
			}
		}
	}
}
