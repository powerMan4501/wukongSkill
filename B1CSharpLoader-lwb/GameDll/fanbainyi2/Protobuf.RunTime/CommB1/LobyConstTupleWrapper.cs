using System;
using Google.Protobuf;

namespace CommB1;

public sealed class LobyConstTupleWrapper : IMessage<LobyConstTupleWrapper>, IMessage, IEquatable<LobyConstTupleWrapper>, IDeepCloneable<LobyConstTupleWrapper>
{
	private static readonly MessageParser<LobyConstTupleWrapper> _parser = new MessageParser<LobyConstTupleWrapper>(() => new LobyConstTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private LobyConst item1_;

	private LobyConst item2_;

	public static MessageParser<LobyConstTupleWrapper> Parser => _parser;

	public LobyConst Item1
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

	public LobyConst Item2
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

	public LobyConstTupleWrapper()
	{
	}

	public LobyConstTupleWrapper(LobyConstTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LobyConstTupleWrapper Clone()
	{
		return new LobyConstTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LobyConstTupleWrapper);
	}

	public bool Equals(LobyConstTupleWrapper other)
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
		if (Item1 != LobyConst.Default)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != LobyConst.Default)
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
		if (Item1 != LobyConst.Default)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != LobyConst.Default)
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
		if (Item1 != LobyConst.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != LobyConst.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LobyConstTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != LobyConst.Default)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != LobyConst.Default)
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
				Item1 = (LobyConst)input.ReadEnum();
				break;
			case 16u:
				Item2 = (LobyConst)input.ReadEnum();
				break;
			}
		}
	}
}
