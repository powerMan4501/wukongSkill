using System;
using Google.Protobuf;

namespace BtlX2;

public sealed class EB2DStateWithMontageTupleWrapper : IMessage<EB2DStateWithMontageTupleWrapper>, IMessage, IEquatable<EB2DStateWithMontageTupleWrapper>, IDeepCloneable<EB2DStateWithMontageTupleWrapper>
{
	private static readonly MessageParser<EB2DStateWithMontageTupleWrapper> _parser = new MessageParser<EB2DStateWithMontageTupleWrapper>(() => new EB2DStateWithMontageTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EB2DStateWithMontage item1_;

	private EB2DStateWithMontage item2_;

	public static MessageParser<EB2DStateWithMontageTupleWrapper> Parser => _parser;

	public EB2DStateWithMontage Item1
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

	public EB2DStateWithMontage Item2
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

	public EB2DStateWithMontageTupleWrapper()
	{
	}

	public EB2DStateWithMontageTupleWrapper(EB2DStateWithMontageTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EB2DStateWithMontageTupleWrapper Clone()
	{
		return new EB2DStateWithMontageTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EB2DStateWithMontageTupleWrapper);
	}

	public bool Equals(EB2DStateWithMontageTupleWrapper other)
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
		if (Item1 != EB2DStateWithMontage.Min)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EB2DStateWithMontage.Min)
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
		if (Item1 != EB2DStateWithMontage.Min)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EB2DStateWithMontage.Min)
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
		if (Item1 != EB2DStateWithMontage.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EB2DStateWithMontage.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EB2DStateWithMontageTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EB2DStateWithMontage.Min)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EB2DStateWithMontage.Min)
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
				Item1 = (EB2DStateWithMontage)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EB2DStateWithMontage)input.ReadEnum();
				break;
			}
		}
	}
}
