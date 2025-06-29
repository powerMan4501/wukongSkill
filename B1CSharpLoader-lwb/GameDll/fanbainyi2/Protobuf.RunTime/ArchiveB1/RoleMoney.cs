using System;
using Google.Protobuf;
using ResB1;

namespace ArchiveB1;

public sealed class RoleMoney : IMessage<RoleMoney>, IMessage, IEquatable<RoleMoney>, IDeepCloneable<RoleMoney>
{
	private static readonly MessageParser<RoleMoney> _parser = new MessageParser<RoleMoney>(() => new RoleMoney());

	private UnknownFieldSet _unknownFields;

	private MoneyType moneyType_;

	private long moneyValue_;

	public static MessageParser<RoleMoney> Parser => _parser;

	public MoneyType MoneyType
	{
		get
		{
			return moneyType_;
		}
		set
		{
			moneyType_ = value;
		}
	}

	public long MoneyValue
	{
		get
		{
			return moneyValue_;
		}
		set
		{
			moneyValue_ = value;
		}
	}

	public RoleMoney()
	{
	}

	public RoleMoney(RoleMoney other)
		: this()
	{
		moneyType_ = other.moneyType_;
		moneyValue_ = other.moneyValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleMoney Clone()
	{
		return new RoleMoney(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleMoney);
	}

	public bool Equals(RoleMoney other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MoneyType != other.MoneyType)
		{
			return false;
		}
		if (MoneyValue != other.MoneyValue)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (MoneyType != MoneyType.Default)
		{
			num ^= MoneyType.GetHashCode();
		}
		if (MoneyValue != 0L)
		{
			num ^= MoneyValue.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (MoneyType != MoneyType.Default)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)MoneyType);
		}
		if (MoneyValue != 0L)
		{
			output.WriteRawTag(16);
			output.WriteInt64(MoneyValue);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (MoneyType != MoneyType.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MoneyType);
		}
		if (MoneyValue != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(MoneyValue);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleMoney other)
	{
		if (other != null)
		{
			if (other.MoneyType != MoneyType.Default)
			{
				MoneyType = other.MoneyType;
			}
			if (other.MoneyValue != 0L)
			{
				MoneyValue = other.MoneyValue;
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
				MoneyType = (MoneyType)input.ReadEnum();
				break;
			case 16u:
				MoneyValue = input.ReadInt64();
				break;
			}
		}
	}
}
