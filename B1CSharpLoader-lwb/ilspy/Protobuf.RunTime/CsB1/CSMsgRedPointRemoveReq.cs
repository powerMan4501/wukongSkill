using System;
using CommB1;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRedPointRemoveReq : IMessage<CSMsgRedPointRemoveReq>, IMessage, IEquatable<CSMsgRedPointRemoveReq>, IDeepCloneable<CSMsgRedPointRemoveReq>
{
	private static readonly MessageParser<CSMsgRedPointRemoveReq> _parser = new MessageParser<CSMsgRedPointRemoveReq>(() => new CSMsgRedPointRemoveReq());

	private UnknownFieldSet _unknownFields;

	private RedPointType redPointType_;

	private int redPointId_;

	public static MessageParser<CSMsgRedPointRemoveReq> Parser => _parser;

	public RedPointType RedPointType
	{
		get
		{
			return redPointType_;
		}
		set
		{
			redPointType_ = value;
		}
	}

	public int RedPointId
	{
		get
		{
			return redPointId_;
		}
		set
		{
			redPointId_ = value;
		}
	}

	public CSMsgRedPointRemoveReq()
	{
	}

	public CSMsgRedPointRemoveReq(CSMsgRedPointRemoveReq other)
		: this()
	{
		redPointType_ = other.redPointType_;
		redPointId_ = other.redPointId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRedPointRemoveReq Clone()
	{
		return new CSMsgRedPointRemoveReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRedPointRemoveReq);
	}

	public bool Equals(CSMsgRedPointRemoveReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RedPointType != other.RedPointType)
		{
			return false;
		}
		if (RedPointId != other.RedPointId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (RedPointType != RedPointType.None)
		{
			num ^= RedPointType.GetHashCode();
		}
		if (RedPointId != 0)
		{
			num ^= RedPointId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (RedPointType != RedPointType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)RedPointType);
		}
		if (RedPointId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(RedPointId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (RedPointType != RedPointType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)RedPointType);
		}
		if (RedPointId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RedPointId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgRedPointRemoveReq other)
	{
		if (other != null)
		{
			if (other.RedPointType != RedPointType.None)
			{
				RedPointType = other.RedPointType;
			}
			if (other.RedPointId != 0)
			{
				RedPointId = other.RedPointId;
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
				RedPointType = (RedPointType)input.ReadEnum();
				break;
			case 16u:
				RedPointId = input.ReadInt32();
				break;
			}
		}
	}
}
