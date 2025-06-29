using System;
using Google.Protobuf;

namespace BtlX2;

public sealed class EB2DSBMapCondTupleWrapper : IMessage<EB2DSBMapCondTupleWrapper>, IMessage, IEquatable<EB2DSBMapCondTupleWrapper>, IDeepCloneable<EB2DSBMapCondTupleWrapper>
{
	private static readonly MessageParser<EB2DSBMapCondTupleWrapper> _parser = new MessageParser<EB2DSBMapCondTupleWrapper>(() => new EB2DSBMapCondTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EB2DSBMapCond item1_;

	private EB2DSBMapCond item2_;

	public static MessageParser<EB2DSBMapCondTupleWrapper> Parser => _parser;

	public EB2DSBMapCond Item1
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

	public EB2DSBMapCond Item2
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

	public EB2DSBMapCondTupleWrapper()
	{
	}

	public EB2DSBMapCondTupleWrapper(EB2DSBMapCondTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EB2DSBMapCondTupleWrapper Clone()
	{
		return new EB2DSBMapCondTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EB2DSBMapCondTupleWrapper);
	}

	public bool Equals(EB2DSBMapCondTupleWrapper other)
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
		if (Item1 != EB2DSBMapCond.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EB2DSBMapCond.None)
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
		if (Item1 != EB2DSBMapCond.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EB2DSBMapCond.None)
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
		if (Item1 != EB2DSBMapCond.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EB2DSBMapCond.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EB2DSBMapCondTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EB2DSBMapCond.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EB2DSBMapCond.None)
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
				Item1 = (EB2DSBMapCond)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EB2DSBMapCond)input.ReadEnum();
				break;
			}
		}
	}
}
