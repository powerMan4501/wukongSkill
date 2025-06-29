using System;
using CommB1;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgAwolMsgUpdateReq : IMessage<CSMsgAwolMsgUpdateReq>, IMessage, IEquatable<CSMsgAwolMsgUpdateReq>, IDeepCloneable<CSMsgAwolMsgUpdateReq>
{
	private static readonly MessageParser<CSMsgAwolMsgUpdateReq> _parser = new MessageParser<CSMsgAwolMsgUpdateReq>(() => new CSMsgAwolMsgUpdateReq());

	private UnknownFieldSet _unknownFields;

	private AwolMsgType msgType_;

	private uint msgId_;

	private CSAwolMsgUpdateType updateType_;

	public static MessageParser<CSMsgAwolMsgUpdateReq> Parser => _parser;

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

	public CSAwolMsgUpdateType UpdateType
	{
		get
		{
			return updateType_;
		}
		set
		{
			updateType_ = value;
		}
	}

	public CSMsgAwolMsgUpdateReq()
	{
	}

	public CSMsgAwolMsgUpdateReq(CSMsgAwolMsgUpdateReq other)
		: this()
	{
		msgType_ = other.msgType_;
		msgId_ = other.msgId_;
		updateType_ = other.updateType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgAwolMsgUpdateReq Clone()
	{
		return new CSMsgAwolMsgUpdateReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgAwolMsgUpdateReq);
	}

	public bool Equals(CSMsgAwolMsgUpdateReq other)
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
		if (UpdateType != other.UpdateType)
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
		if (UpdateType != CSAwolMsgUpdateType.CsAwolmsgOpNone)
		{
			num ^= UpdateType.GetHashCode();
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
		if (UpdateType != CSAwolMsgUpdateType.CsAwolmsgOpNone)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)UpdateType);
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
		if (UpdateType != CSAwolMsgUpdateType.CsAwolmsgOpNone)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)UpdateType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgAwolMsgUpdateReq other)
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
			if (other.UpdateType != CSAwolMsgUpdateType.CsAwolmsgOpNone)
			{
				UpdateType = other.UpdateType;
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
			case 24u:
				UpdateType = (CSAwolMsgUpdateType)input.ReadEnum();
				break;
			}
		}
	}
}
