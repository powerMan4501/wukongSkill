using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EAIElemTypeTupleWrapper : IMessage<EAIElemTypeTupleWrapper>, IMessage, IEquatable<EAIElemTypeTupleWrapper>, IDeepCloneable<EAIElemTypeTupleWrapper>
{
	private static readonly MessageParser<EAIElemTypeTupleWrapper> _parser = new MessageParser<EAIElemTypeTupleWrapper>(() => new EAIElemTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EAIElemType item1_;

	private EAIElemType item2_;

	public static MessageParser<EAIElemTypeTupleWrapper> Parser => _parser;

	public EAIElemType Item1
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

	public EAIElemType Item2
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

	public EAIElemTypeTupleWrapper()
	{
	}

	public EAIElemTypeTupleWrapper(EAIElemTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EAIElemTypeTupleWrapper Clone()
	{
		return new EAIElemTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EAIElemTypeTupleWrapper);
	}

	public bool Equals(EAIElemTypeTupleWrapper other)
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
		if (Item1 != EAIElemType.Think)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EAIElemType.Think)
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
		if (Item1 != EAIElemType.Think)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EAIElemType.Think)
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
		if (Item1 != EAIElemType.Think)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EAIElemType.Think)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EAIElemTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EAIElemType.Think)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EAIElemType.Think)
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
				Item1 = (EAIElemType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EAIElemType)input.ReadEnum();
				break;
			}
		}
	}
}
