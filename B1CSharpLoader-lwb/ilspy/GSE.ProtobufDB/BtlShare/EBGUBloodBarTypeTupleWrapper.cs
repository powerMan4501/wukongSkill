using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EBGUBloodBarTypeTupleWrapper : IMessage<EBGUBloodBarTypeTupleWrapper>, IMessage, IEquatable<EBGUBloodBarTypeTupleWrapper>, IDeepCloneable<EBGUBloodBarTypeTupleWrapper>
{
	private static readonly MessageParser<EBGUBloodBarTypeTupleWrapper> _parser = new MessageParser<EBGUBloodBarTypeTupleWrapper>(() => new EBGUBloodBarTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EBGUBloodBarType item1_;

	private EBGUBloodBarType item2_;

	public static MessageParser<EBGUBloodBarTypeTupleWrapper> Parser => _parser;

	public EBGUBloodBarType Item1
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

	public EBGUBloodBarType Item2
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

	public EBGUBloodBarTypeTupleWrapper()
	{
	}

	public EBGUBloodBarTypeTupleWrapper(EBGUBloodBarTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EBGUBloodBarTypeTupleWrapper Clone()
	{
		return new EBGUBloodBarTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EBGUBloodBarTypeTupleWrapper);
	}

	public bool Equals(EBGUBloodBarTypeTupleWrapper other)
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
		if (Item1 != EBGUBloodBarType.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EBGUBloodBarType.None)
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
		if (Item1 != EBGUBloodBarType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EBGUBloodBarType.None)
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
		if (Item1 != EBGUBloodBarType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EBGUBloodBarType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EBGUBloodBarTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EBGUBloodBarType.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EBGUBloodBarType.None)
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
				Item1 = (EBGUBloodBarType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EBGUBloodBarType)input.ReadEnum();
				break;
			}
		}
	}
}
