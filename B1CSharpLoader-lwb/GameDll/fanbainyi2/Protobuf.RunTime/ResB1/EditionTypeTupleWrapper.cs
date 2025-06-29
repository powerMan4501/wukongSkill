using System;
using Google.Protobuf;

namespace ResB1;

public sealed class EditionTypeTupleWrapper : IMessage<EditionTypeTupleWrapper>, IMessage, IEquatable<EditionTypeTupleWrapper>, IDeepCloneable<EditionTypeTupleWrapper>
{
	private static readonly MessageParser<EditionTypeTupleWrapper> _parser = new MessageParser<EditionTypeTupleWrapper>(() => new EditionTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EditionType item1_;

	private EditionType item2_;

	public static MessageParser<EditionTypeTupleWrapper> Parser => _parser;

	public EditionType Item1
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

	public EditionType Item2
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

	public EditionTypeTupleWrapper()
	{
	}

	public EditionTypeTupleWrapper(EditionTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EditionTypeTupleWrapper Clone()
	{
		return new EditionTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EditionTypeTupleWrapper);
	}

	public bool Equals(EditionTypeTupleWrapper other)
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
		if (Item1 != EditionType.Standard)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EditionType.Standard)
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
		if (Item1 != EditionType.Standard)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EditionType.Standard)
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
		if (Item1 != EditionType.Standard)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EditionType.Standard)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EditionTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EditionType.Standard)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EditionType.Standard)
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
				Item1 = (EditionType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EditionType)input.ReadEnum();
				break;
			}
		}
	}
}
