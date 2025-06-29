using System;
using Google.Protobuf;

namespace ResB1;

public sealed class EBossRushTypeTupleWrapper : IMessage<EBossRushTypeTupleWrapper>, IMessage, IEquatable<EBossRushTypeTupleWrapper>, IDeepCloneable<EBossRushTypeTupleWrapper>
{
	private static readonly MessageParser<EBossRushTypeTupleWrapper> _parser = new MessageParser<EBossRushTypeTupleWrapper>(() => new EBossRushTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EBossRushType item1_;

	private EBossRushType item2_;

	public static MessageParser<EBossRushTypeTupleWrapper> Parser => _parser;

	public EBossRushType Item1
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

	public EBossRushType Item2
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

	public EBossRushTypeTupleWrapper()
	{
	}

	public EBossRushTypeTupleWrapper(EBossRushTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EBossRushTypeTupleWrapper Clone()
	{
		return new EBossRushTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EBossRushTypeTupleWrapper);
	}

	public bool Equals(EBossRushTypeTupleWrapper other)
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
		if (Item1 != EBossRushType.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EBossRushType.None)
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
		if (Item1 != EBossRushType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EBossRushType.None)
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
		if (Item1 != EBossRushType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EBossRushType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EBossRushTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EBossRushType.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EBossRushType.None)
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
				Item1 = (EBossRushType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EBossRushType)input.ReadEnum();
				break;
			}
		}
	}
}
