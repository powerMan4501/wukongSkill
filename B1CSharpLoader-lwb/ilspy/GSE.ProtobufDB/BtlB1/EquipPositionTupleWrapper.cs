using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class EquipPositionTupleWrapper : IMessage<EquipPositionTupleWrapper>, IMessage, IEquatable<EquipPositionTupleWrapper>, IDeepCloneable<EquipPositionTupleWrapper>
{
	private static readonly MessageParser<EquipPositionTupleWrapper> _parser = new MessageParser<EquipPositionTupleWrapper>(() => new EquipPositionTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EquipPosition item1_;

	private EquipPosition item2_;

	public static MessageParser<EquipPositionTupleWrapper> Parser => _parser;

	public EquipPosition Item1
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

	public EquipPosition Item2
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

	public EquipPositionTupleWrapper()
	{
	}

	public EquipPositionTupleWrapper(EquipPositionTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EquipPositionTupleWrapper Clone()
	{
		return new EquipPositionTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EquipPositionTupleWrapper);
	}

	public bool Equals(EquipPositionTupleWrapper other)
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
		if (Item1 != EquipPosition.Head)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EquipPosition.Head)
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
		if (Item1 != EquipPosition.Head)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EquipPosition.Head)
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
		if (Item1 != EquipPosition.Head)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EquipPosition.Head)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EquipPositionTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EquipPosition.Head)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EquipPosition.Head)
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
				Item1 = (EquipPosition)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EquipPosition)input.ReadEnum();
				break;
			}
		}
	}
}
