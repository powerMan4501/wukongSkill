using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class EValOpTupleWrapper : IMessage<EValOpTupleWrapper>, IMessage, IEquatable<EValOpTupleWrapper>, IDeepCloneable<EValOpTupleWrapper>
{
	private static readonly MessageParser<EValOpTupleWrapper> _parser = new MessageParser<EValOpTupleWrapper>(() => new EValOpTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EValOp item1_;

	private EValOp item2_;

	public static MessageParser<EValOpTupleWrapper> Parser => _parser;

	public EValOp Item1
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

	public EValOp Item2
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

	public EValOpTupleWrapper()
	{
	}

	public EValOpTupleWrapper(EValOpTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EValOpTupleWrapper Clone()
	{
		return new EValOpTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EValOpTupleWrapper);
	}

	public bool Equals(EValOpTupleWrapper other)
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
		if (Item1 != EValOp.Add)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EValOp.Add)
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
		if (Item1 != EValOp.Add)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EValOp.Add)
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
		if (Item1 != EValOp.Add)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EValOp.Add)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EValOpTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EValOp.Add)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EValOp.Add)
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
				Item1 = (EValOp)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EValOp)input.ReadEnum();
				break;
			}
		}
	}
}
