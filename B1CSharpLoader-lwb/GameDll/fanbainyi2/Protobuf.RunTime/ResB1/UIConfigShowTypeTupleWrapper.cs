using System;
using Google.Protobuf;

namespace ResB1;

public sealed class UIConfigShowTypeTupleWrapper : IMessage<UIConfigShowTypeTupleWrapper>, IMessage, IEquatable<UIConfigShowTypeTupleWrapper>, IDeepCloneable<UIConfigShowTypeTupleWrapper>
{
	private static readonly MessageParser<UIConfigShowTypeTupleWrapper> _parser = new MessageParser<UIConfigShowTypeTupleWrapper>(() => new UIConfigShowTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private UIConfigShowType item1_;

	private UIConfigShowType item2_;

	public static MessageParser<UIConfigShowTypeTupleWrapper> Parser => _parser;

	public UIConfigShowType Item1
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

	public UIConfigShowType Item2
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

	public UIConfigShowTypeTupleWrapper()
	{
	}

	public UIConfigShowTypeTupleWrapper(UIConfigShowTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public UIConfigShowTypeTupleWrapper Clone()
	{
		return new UIConfigShowTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as UIConfigShowTypeTupleWrapper);
	}

	public bool Equals(UIConfigShowTypeTupleWrapper other)
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
		if (Item1 != UIConfigShowType.All)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != UIConfigShowType.All)
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
		if (Item1 != UIConfigShowType.All)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != UIConfigShowType.All)
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
		if (Item1 != UIConfigShowType.All)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != UIConfigShowType.All)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(UIConfigShowTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != UIConfigShowType.All)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != UIConfigShowType.All)
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
				Item1 = (UIConfigShowType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (UIConfigShowType)input.ReadEnum();
				break;
			}
		}
	}
}
