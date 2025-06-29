using System;
using Google.Protobuf;

namespace ResB1;

public sealed class MonsterTypeTupleWrapper : IMessage<MonsterTypeTupleWrapper>, IMessage, IEquatable<MonsterTypeTupleWrapper>, IDeepCloneable<MonsterTypeTupleWrapper>
{
	private static readonly MessageParser<MonsterTypeTupleWrapper> _parser = new MessageParser<MonsterTypeTupleWrapper>(() => new MonsterTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private MonsterType item1_;

	private MonsterType item2_;

	public static MessageParser<MonsterTypeTupleWrapper> Parser => _parser;

	public MonsterType Item1
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

	public MonsterType Item2
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

	public MonsterTypeTupleWrapper()
	{
	}

	public MonsterTypeTupleWrapper(MonsterTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MonsterTypeTupleWrapper Clone()
	{
		return new MonsterTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MonsterTypeTupleWrapper);
	}

	public bool Equals(MonsterTypeTupleWrapper other)
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
		if (Item1 != MonsterType.Boss)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != MonsterType.Boss)
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
		if (Item1 != MonsterType.Boss)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != MonsterType.Boss)
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
		if (Item1 != MonsterType.Boss)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != MonsterType.Boss)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MonsterTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != MonsterType.Boss)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != MonsterType.Boss)
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
				Item1 = (MonsterType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (MonsterType)input.ReadEnum();
				break;
			}
		}
	}
}
