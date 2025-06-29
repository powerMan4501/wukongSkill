using System;
using Google.Protobuf;

namespace ResB1;

public sealed class FuncOpenLimitDesc : IMessage<FuncOpenLimitDesc>, IMessage, IEquatable<FuncOpenLimitDesc>, IDeepCloneable<FuncOpenLimitDesc>
{
	private static readonly MessageParser<FuncOpenLimitDesc> _parser = new MessageParser<FuncOpenLimitDesc>(() => new FuncOpenLimitDesc());

	private UnknownFieldSet _unknownFields;

	private FuncOpenLimitType limitType_;

	private uint limitId_;

	private int limitVal_;

	public static MessageParser<FuncOpenLimitDesc> Parser => _parser;

	public FuncOpenLimitType LimitType
	{
		get
		{
			return limitType_;
		}
		set
		{
			limitType_ = value;
		}
	}

	public uint LimitId
	{
		get
		{
			return limitId_;
		}
		set
		{
			limitId_ = value;
		}
	}

	public int LimitVal
	{
		get
		{
			return limitVal_;
		}
		set
		{
			limitVal_ = value;
		}
	}

	public FuncOpenLimitDesc()
	{
	}

	public FuncOpenLimitDesc(FuncOpenLimitDesc other)
		: this()
	{
		limitType_ = other.limitType_;
		limitId_ = other.limitId_;
		limitVal_ = other.limitVal_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FuncOpenLimitDesc Clone()
	{
		return new FuncOpenLimitDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FuncOpenLimitDesc);
	}

	public bool Equals(FuncOpenLimitDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LimitType != other.LimitType)
		{
			return false;
		}
		if (LimitId != other.LimitId)
		{
			return false;
		}
		if (LimitVal != other.LimitVal)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (LimitType != FuncOpenLimitType.None)
		{
			num ^= LimitType.GetHashCode();
		}
		if (LimitId != 0)
		{
			num ^= LimitId.GetHashCode();
		}
		if (LimitVal != 0)
		{
			num ^= LimitVal.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (LimitType != FuncOpenLimitType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)LimitType);
		}
		if (LimitId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(LimitId);
		}
		if (LimitVal != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(LimitVal);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (LimitType != FuncOpenLimitType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)LimitType);
		}
		if (LimitId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LimitId);
		}
		if (LimitVal != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LimitVal);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FuncOpenLimitDesc other)
	{
		if (other != null)
		{
			if (other.LimitType != FuncOpenLimitType.None)
			{
				LimitType = other.LimitType;
			}
			if (other.LimitId != 0)
			{
				LimitId = other.LimitId;
			}
			if (other.LimitVal != 0)
			{
				LimitVal = other.LimitVal;
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
				LimitType = (FuncOpenLimitType)input.ReadEnum();
				break;
			case 16u:
				LimitId = input.ReadUInt32();
				break;
			case 24u:
				LimitVal = input.ReadInt32();
				break;
			}
		}
	}
}
