using System;
using Google.Protobuf;

namespace BtlU3;

public sealed class EB2DUnitStateTupleWrapper : IMessage<EB2DUnitStateTupleWrapper>, IMessage, IEquatable<EB2DUnitStateTupleWrapper>, IDeepCloneable<EB2DUnitStateTupleWrapper>
{
	private static readonly MessageParser<EB2DUnitStateTupleWrapper> _parser = new MessageParser<EB2DUnitStateTupleWrapper>(() => new EB2DUnitStateTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EB2DUnitState item1_;

	private EB2DUnitState item2_;

	public static MessageParser<EB2DUnitStateTupleWrapper> Parser => _parser;

	public EB2DUnitState Item1
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

	public EB2DUnitState Item2
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

	public EB2DUnitStateTupleWrapper()
	{
	}

	public EB2DUnitStateTupleWrapper(EB2DUnitStateTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EB2DUnitStateTupleWrapper Clone()
	{
		return new EB2DUnitStateTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EB2DUnitStateTupleWrapper);
	}

	public bool Equals(EB2DUnitStateTupleWrapper other)
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
		if (Item1 != EB2DUnitState.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EB2DUnitState.None)
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
		if (Item1 != EB2DUnitState.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EB2DUnitState.None)
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
		if (Item1 != EB2DUnitState.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EB2DUnitState.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EB2DUnitStateTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EB2DUnitState.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EB2DUnitState.None)
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
				Item1 = (EB2DUnitState)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EB2DUnitState)input.ReadEnum();
				break;
			}
		}
	}
}
