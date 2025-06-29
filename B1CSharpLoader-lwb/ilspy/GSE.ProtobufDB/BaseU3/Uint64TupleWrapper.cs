using System;
using Google.Protobuf;

namespace BaseU3;

public sealed class Uint64TupleWrapper : IMessage<Uint64TupleWrapper>, IMessage, IEquatable<Uint64TupleWrapper>, IDeepCloneable<Uint64TupleWrapper>
{
	private static readonly MessageParser<Uint64TupleWrapper> _parser = new MessageParser<Uint64TupleWrapper>(() => new Uint64TupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ulong item1_;

	private ulong item2_;

	public static MessageParser<Uint64TupleWrapper> Parser => _parser;

	public ulong Item1
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

	public ulong Item2
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

	public Uint64TupleWrapper()
	{
	}

	public Uint64TupleWrapper(Uint64TupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public Uint64TupleWrapper Clone()
	{
		return new Uint64TupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as Uint64TupleWrapper);
	}

	public bool Equals(Uint64TupleWrapper other)
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
		if (Item1 != 0L)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != 0L)
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
		if (Item1 != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(Item1);
		}
		if (Item2 != 0L)
		{
			output.WriteRawTag(16);
			output.WriteUInt64(Item2);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Item1 != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(Item1);
		}
		if (Item2 != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(Uint64TupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != 0L)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != 0L)
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
				Item1 = input.ReadUInt64();
				break;
			case 16u:
				Item2 = input.ReadUInt64();
				break;
			}
		}
	}
}
