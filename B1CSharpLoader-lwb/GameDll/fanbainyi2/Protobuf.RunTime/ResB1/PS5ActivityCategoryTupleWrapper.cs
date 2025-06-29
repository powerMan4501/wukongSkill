using System;
using Google.Protobuf;

namespace ResB1;

public sealed class PS5ActivityCategoryTupleWrapper : IMessage<PS5ActivityCategoryTupleWrapper>, IMessage, IEquatable<PS5ActivityCategoryTupleWrapper>, IDeepCloneable<PS5ActivityCategoryTupleWrapper>
{
	private static readonly MessageParser<PS5ActivityCategoryTupleWrapper> _parser = new MessageParser<PS5ActivityCategoryTupleWrapper>(() => new PS5ActivityCategoryTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private PS5ActivityCategory item1_;

	private PS5ActivityCategory item2_;

	public static MessageParser<PS5ActivityCategoryTupleWrapper> Parser => _parser;

	public PS5ActivityCategory Item1
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

	public PS5ActivityCategory Item2
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

	public PS5ActivityCategoryTupleWrapper()
	{
	}

	public PS5ActivityCategoryTupleWrapper(PS5ActivityCategoryTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PS5ActivityCategoryTupleWrapper Clone()
	{
		return new PS5ActivityCategoryTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PS5ActivityCategoryTupleWrapper);
	}

	public bool Equals(PS5ActivityCategoryTupleWrapper other)
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
		if (Item1 != PS5ActivityCategory.Progress)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != PS5ActivityCategory.Progress)
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
		if (Item1 != PS5ActivityCategory.Progress)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != PS5ActivityCategory.Progress)
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
		if (Item1 != PS5ActivityCategory.Progress)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != PS5ActivityCategory.Progress)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PS5ActivityCategoryTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != PS5ActivityCategory.Progress)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != PS5ActivityCategory.Progress)
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
				Item1 = (PS5ActivityCategory)input.ReadEnum();
				break;
			case 16u:
				Item2 = (PS5ActivityCategory)input.ReadEnum();
				break;
			}
		}
	}
}
