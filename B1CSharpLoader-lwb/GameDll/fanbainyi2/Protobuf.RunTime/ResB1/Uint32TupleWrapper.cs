using System;
using Google.Protobuf;

namespace ResB1;

public sealed class Uint32TupleWrapper : IMessage<Uint32TupleWrapper>, IMessage, IEquatable<Uint32TupleWrapper>, IDeepCloneable<Uint32TupleWrapper>
{
	private static readonly MessageParser<Uint32TupleWrapper> _parser = new MessageParser<Uint32TupleWrapper>(() => new Uint32TupleWrapper());

	private UnknownFieldSet _unknownFields;

	private uint item1_;

	private uint item2_;

	public static MessageParser<Uint32TupleWrapper> Parser => _parser;

	public uint Item1
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

	public uint Item2
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

	public Uint32TupleWrapper()
	{
	}

	public Uint32TupleWrapper(Uint32TupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public Uint32TupleWrapper Clone()
	{
		return new Uint32TupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as Uint32TupleWrapper);
	}

	public bool Equals(Uint32TupleWrapper other)
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
		if (Item1 != 0)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != 0)
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
		if (Item1 != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Item1);
		}
		if (Item2 != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Item2);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Item1 != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Item1);
		}
		if (Item2 != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(Uint32TupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != 0)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != 0)
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
				Item1 = input.ReadUInt32();
				break;
			case 16u:
				Item2 = input.ReadUInt32();
				break;
			}
		}
	}
}
