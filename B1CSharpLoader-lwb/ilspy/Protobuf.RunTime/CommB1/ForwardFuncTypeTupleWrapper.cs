using System;
using Google.Protobuf;

namespace CommB1;

public sealed class ForwardFuncTypeTupleWrapper : IMessage<ForwardFuncTypeTupleWrapper>, IMessage, IEquatable<ForwardFuncTypeTupleWrapper>, IDeepCloneable<ForwardFuncTypeTupleWrapper>
{
	private static readonly MessageParser<ForwardFuncTypeTupleWrapper> _parser = new MessageParser<ForwardFuncTypeTupleWrapper>(() => new ForwardFuncTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ForwardFuncType item1_;

	private ForwardFuncType item2_;

	public static MessageParser<ForwardFuncTypeTupleWrapper> Parser => _parser;

	public ForwardFuncType Item1
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

	public ForwardFuncType Item2
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

	public ForwardFuncTypeTupleWrapper()
	{
	}

	public ForwardFuncTypeTupleWrapper(ForwardFuncTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ForwardFuncTypeTupleWrapper Clone()
	{
		return new ForwardFuncTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ForwardFuncTypeTupleWrapper);
	}

	public bool Equals(ForwardFuncTypeTupleWrapper other)
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
		if (Item1 != ForwardFuncType.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ForwardFuncType.None)
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
		if (Item1 != ForwardFuncType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ForwardFuncType.None)
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
		if (Item1 != ForwardFuncType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ForwardFuncType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ForwardFuncTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ForwardFuncType.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ForwardFuncType.None)
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
				Item1 = (ForwardFuncType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ForwardFuncType)input.ReadEnum();
				break;
			}
		}
	}
}
