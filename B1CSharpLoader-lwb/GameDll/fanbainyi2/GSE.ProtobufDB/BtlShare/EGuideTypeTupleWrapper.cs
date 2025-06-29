using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EGuideTypeTupleWrapper : IMessage<EGuideTypeTupleWrapper>, IMessage, IEquatable<EGuideTypeTupleWrapper>, IDeepCloneable<EGuideTypeTupleWrapper>
{
	private static readonly MessageParser<EGuideTypeTupleWrapper> _parser = new MessageParser<EGuideTypeTupleWrapper>(() => new EGuideTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EGuideType item1_;

	private EGuideType item2_;

	public static MessageParser<EGuideTypeTupleWrapper> Parser => _parser;

	public EGuideType Item1
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

	public EGuideType Item2
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

	public EGuideTypeTupleWrapper()
	{
	}

	public EGuideTypeTupleWrapper(EGuideTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EGuideTypeTupleWrapper Clone()
	{
		return new EGuideTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EGuideTypeTupleWrapper);
	}

	public bool Equals(EGuideTypeTupleWrapper other)
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
		if (Item1 != EGuideType.Battle)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EGuideType.Battle)
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
		if (Item1 != EGuideType.Battle)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EGuideType.Battle)
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
		if (Item1 != EGuideType.Battle)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EGuideType.Battle)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EGuideTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EGuideType.Battle)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EGuideType.Battle)
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
				Item1 = (EGuideType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EGuideType)input.ReadEnum();
				break;
			}
		}
	}
}
