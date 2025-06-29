using System;
using Google.Protobuf;

namespace CommB1;

public sealed class MuseumRedPointTypeTupleWrapper : IMessage<MuseumRedPointTypeTupleWrapper>, IMessage, IEquatable<MuseumRedPointTypeTupleWrapper>, IDeepCloneable<MuseumRedPointTypeTupleWrapper>
{
	private static readonly MessageParser<MuseumRedPointTypeTupleWrapper> _parser = new MessageParser<MuseumRedPointTypeTupleWrapper>(() => new MuseumRedPointTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private MuseumRedPointType item1_;

	private MuseumRedPointType item2_;

	public static MessageParser<MuseumRedPointTypeTupleWrapper> Parser => _parser;

	public MuseumRedPointType Item1
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

	public MuseumRedPointType Item2
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

	public MuseumRedPointTypeTupleWrapper()
	{
	}

	public MuseumRedPointTypeTupleWrapper(MuseumRedPointTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MuseumRedPointTypeTupleWrapper Clone()
	{
		return new MuseumRedPointTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MuseumRedPointTypeTupleWrapper);
	}

	public bool Equals(MuseumRedPointTypeTupleWrapper other)
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
		if (Item1 != MuseumRedPointType.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != MuseumRedPointType.None)
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
		if (Item1 != MuseumRedPointType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != MuseumRedPointType.None)
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
		if (Item1 != MuseumRedPointType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != MuseumRedPointType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MuseumRedPointTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != MuseumRedPointType.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != MuseumRedPointType.None)
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
				Item1 = (MuseumRedPointType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (MuseumRedPointType)input.ReadEnum();
				break;
			}
		}
	}
}
