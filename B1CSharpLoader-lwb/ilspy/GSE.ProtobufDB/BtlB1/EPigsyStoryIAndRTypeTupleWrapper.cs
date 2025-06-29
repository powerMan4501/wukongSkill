using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class EPigsyStoryIAndRTypeTupleWrapper : IMessage<EPigsyStoryIAndRTypeTupleWrapper>, IMessage, IEquatable<EPigsyStoryIAndRTypeTupleWrapper>, IDeepCloneable<EPigsyStoryIAndRTypeTupleWrapper>
{
	private static readonly MessageParser<EPigsyStoryIAndRTypeTupleWrapper> _parser = new MessageParser<EPigsyStoryIAndRTypeTupleWrapper>(() => new EPigsyStoryIAndRTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EPigsyStoryIAndRType item1_;

	private EPigsyStoryIAndRType item2_;

	public static MessageParser<EPigsyStoryIAndRTypeTupleWrapper> Parser => _parser;

	public EPigsyStoryIAndRType Item1
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

	public EPigsyStoryIAndRType Item2
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

	public EPigsyStoryIAndRTypeTupleWrapper()
	{
	}

	public EPigsyStoryIAndRTypeTupleWrapper(EPigsyStoryIAndRTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EPigsyStoryIAndRTypeTupleWrapper Clone()
	{
		return new EPigsyStoryIAndRTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EPigsyStoryIAndRTypeTupleWrapper);
	}

	public bool Equals(EPigsyStoryIAndRTypeTupleWrapper other)
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
		if (Item1 != EPigsyStoryIAndRType.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EPigsyStoryIAndRType.None)
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
		if (Item1 != EPigsyStoryIAndRType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EPigsyStoryIAndRType.None)
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
		if (Item1 != EPigsyStoryIAndRType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EPigsyStoryIAndRType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EPigsyStoryIAndRTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EPigsyStoryIAndRType.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EPigsyStoryIAndRType.None)
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
				Item1 = (EPigsyStoryIAndRType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EPigsyStoryIAndRType)input.ReadEnum();
				break;
			}
		}
	}
}
