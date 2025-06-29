using System;
using Google.Protobuf;

namespace BtlX2;

public sealed class EB2DSpecialStateTupleWrapper : IMessage<EB2DSpecialStateTupleWrapper>, IMessage, IEquatable<EB2DSpecialStateTupleWrapper>, IDeepCloneable<EB2DSpecialStateTupleWrapper>
{
	private static readonly MessageParser<EB2DSpecialStateTupleWrapper> _parser = new MessageParser<EB2DSpecialStateTupleWrapper>(() => new EB2DSpecialStateTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EB2DSpecialState item1_;

	private EB2DSpecialState item2_;

	public static MessageParser<EB2DSpecialStateTupleWrapper> Parser => _parser;

	public EB2DSpecialState Item1
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

	public EB2DSpecialState Item2
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

	public EB2DSpecialStateTupleWrapper()
	{
	}

	public EB2DSpecialStateTupleWrapper(EB2DSpecialStateTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EB2DSpecialStateTupleWrapper Clone()
	{
		return new EB2DSpecialStateTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EB2DSpecialStateTupleWrapper);
	}

	public bool Equals(EB2DSpecialStateTupleWrapper other)
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
		if (Item1 != EB2DSpecialState.Default)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EB2DSpecialState.Default)
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
		if (Item1 != EB2DSpecialState.Default)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EB2DSpecialState.Default)
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
		if (Item1 != EB2DSpecialState.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EB2DSpecialState.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EB2DSpecialStateTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EB2DSpecialState.Default)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EB2DSpecialState.Default)
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
				Item1 = (EB2DSpecialState)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EB2DSpecialState)input.ReadEnum();
				break;
			}
		}
	}
}
