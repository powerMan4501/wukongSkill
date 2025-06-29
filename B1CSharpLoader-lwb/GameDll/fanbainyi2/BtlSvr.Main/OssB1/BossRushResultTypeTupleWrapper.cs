using System;
using Google.Protobuf;

namespace OssB1;

public sealed class BossRushResultTypeTupleWrapper : IMessage<BossRushResultTypeTupleWrapper>, IMessage, IEquatable<BossRushResultTypeTupleWrapper>, IDeepCloneable<BossRushResultTypeTupleWrapper>
{
	private static readonly MessageParser<BossRushResultTypeTupleWrapper> _parser = new MessageParser<BossRushResultTypeTupleWrapper>(() => new BossRushResultTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private BossRushResultType item1_;

	private BossRushResultType item2_;

	public static MessageParser<BossRushResultTypeTupleWrapper> Parser => _parser;

	public BossRushResultType Item1
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

	public BossRushResultType Item2
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

	public BossRushResultTypeTupleWrapper()
	{
	}

	public BossRushResultTypeTupleWrapper(BossRushResultTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossRushResultTypeTupleWrapper Clone()
	{
		return new BossRushResultTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossRushResultTypeTupleWrapper);
	}

	public bool Equals(BossRushResultTypeTupleWrapper other)
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
		if (Item1 != BossRushResultType.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != BossRushResultType.None)
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
		if (Item1 != BossRushResultType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != BossRushResultType.None)
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
		if (Item1 != BossRushResultType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != BossRushResultType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BossRushResultTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != BossRushResultType.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != BossRushResultType.None)
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
				Item1 = (BossRushResultType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (BossRushResultType)input.ReadEnum();
				break;
			}
		}
	}
}
