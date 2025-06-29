using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class EGroupAIMoveTypeTupleWrapper : IMessage<EGroupAIMoveTypeTupleWrapper>, IMessage, IEquatable<EGroupAIMoveTypeTupleWrapper>, IDeepCloneable<EGroupAIMoveTypeTupleWrapper>
{
	private static readonly MessageParser<EGroupAIMoveTypeTupleWrapper> _parser = new MessageParser<EGroupAIMoveTypeTupleWrapper>(() => new EGroupAIMoveTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EGroupAIMoveType item1_;

	private EGroupAIMoveType item2_;

	public static MessageParser<EGroupAIMoveTypeTupleWrapper> Parser => _parser;

	public EGroupAIMoveType Item1
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

	public EGroupAIMoveType Item2
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

	public EGroupAIMoveTypeTupleWrapper()
	{
	}

	public EGroupAIMoveTypeTupleWrapper(EGroupAIMoveTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EGroupAIMoveTypeTupleWrapper Clone()
	{
		return new EGroupAIMoveTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EGroupAIMoveTypeTupleWrapper);
	}

	public bool Equals(EGroupAIMoveTypeTupleWrapper other)
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
		if (Item1 != EGroupAIMoveType.UseDefault)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EGroupAIMoveType.UseDefault)
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
		if (Item1 != EGroupAIMoveType.UseDefault)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EGroupAIMoveType.UseDefault)
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
		if (Item1 != EGroupAIMoveType.UseDefault)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EGroupAIMoveType.UseDefault)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EGroupAIMoveTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EGroupAIMoveType.UseDefault)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EGroupAIMoveType.UseDefault)
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
				Item1 = (EGroupAIMoveType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EGroupAIMoveType)input.ReadEnum();
				break;
			}
		}
	}
}
