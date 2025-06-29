using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EChallengeSuccessTypeTupleWrapper : IMessage<EChallengeSuccessTypeTupleWrapper>, IMessage, IEquatable<EChallengeSuccessTypeTupleWrapper>, IDeepCloneable<EChallengeSuccessTypeTupleWrapper>
{
	private static readonly MessageParser<EChallengeSuccessTypeTupleWrapper> _parser = new MessageParser<EChallengeSuccessTypeTupleWrapper>(() => new EChallengeSuccessTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EChallengeSuccessType item1_;

	private EChallengeSuccessType item2_;

	public static MessageParser<EChallengeSuccessTypeTupleWrapper> Parser => _parser;

	public EChallengeSuccessType Item1
	{
		get
		{
			return item1_;
		}
		set
		{
			item1_ = value;
		}
	}

	public EChallengeSuccessType Item2
	{
		get
		{
			return item2_;
		}
		set
		{
			item2_ = value;
		}
	}

	public EChallengeSuccessTypeTupleWrapper()
	{
	}

	public EChallengeSuccessTypeTupleWrapper(EChallengeSuccessTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EChallengeSuccessTypeTupleWrapper Clone()
	{
		return new EChallengeSuccessTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EChallengeSuccessTypeTupleWrapper);
	}

	public bool Equals(EChallengeSuccessTypeTupleWrapper other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Item1 != other.Item1)
		{
			return false;
		}
		if (Item2 != other.Item2)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Item1 != EChallengeSuccessType.KillAllUnit)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EChallengeSuccessType.KillAllUnit)
		{
			num ^= Item2.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Item1 != EChallengeSuccessType.KillAllUnit)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EChallengeSuccessType.KillAllUnit)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Item2);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Item1 != EChallengeSuccessType.KillAllUnit)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EChallengeSuccessType.KillAllUnit)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EChallengeSuccessTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EChallengeSuccessType.KillAllUnit)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EChallengeSuccessType.KillAllUnit)
			{
				Item2 = other.Item2;
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
				Item1 = (EChallengeSuccessType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EChallengeSuccessType)input.ReadEnum();
				break;
			}
		}
	}
}
