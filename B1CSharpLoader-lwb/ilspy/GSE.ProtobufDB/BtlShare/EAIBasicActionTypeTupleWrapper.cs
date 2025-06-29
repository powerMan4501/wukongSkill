using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EAIBasicActionTypeTupleWrapper : IMessage<EAIBasicActionTypeTupleWrapper>, IMessage, IEquatable<EAIBasicActionTypeTupleWrapper>, IDeepCloneable<EAIBasicActionTypeTupleWrapper>
{
	private static readonly MessageParser<EAIBasicActionTypeTupleWrapper> _parser = new MessageParser<EAIBasicActionTypeTupleWrapper>(() => new EAIBasicActionTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EAIBasicActionType item1_;

	private EAIBasicActionType item2_;

	public static MessageParser<EAIBasicActionTypeTupleWrapper> Parser => _parser;

	public EAIBasicActionType Item1
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

	public EAIBasicActionType Item2
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

	public EAIBasicActionTypeTupleWrapper()
	{
	}

	public EAIBasicActionTypeTupleWrapper(EAIBasicActionTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EAIBasicActionTypeTupleWrapper Clone()
	{
		return new EAIBasicActionTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EAIBasicActionTypeTupleWrapper);
	}

	public bool Equals(EAIBasicActionTypeTupleWrapper other)
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
		if (Item1 != EAIBasicActionType.DirectionMove)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EAIBasicActionType.DirectionMove)
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
		if (Item1 != EAIBasicActionType.DirectionMove)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EAIBasicActionType.DirectionMove)
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
		if (Item1 != EAIBasicActionType.DirectionMove)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EAIBasicActionType.DirectionMove)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EAIBasicActionTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EAIBasicActionType.DirectionMove)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EAIBasicActionType.DirectionMove)
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
				Item1 = (EAIBasicActionType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EAIBasicActionType)input.ReadEnum();
				break;
			}
		}
	}
}
