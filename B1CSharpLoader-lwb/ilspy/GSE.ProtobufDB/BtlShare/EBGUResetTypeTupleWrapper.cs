using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EBGUResetTypeTupleWrapper : IMessage<EBGUResetTypeTupleWrapper>, IMessage, IEquatable<EBGUResetTypeTupleWrapper>, IDeepCloneable<EBGUResetTypeTupleWrapper>
{
	private static readonly MessageParser<EBGUResetTypeTupleWrapper> _parser = new MessageParser<EBGUResetTypeTupleWrapper>(() => new EBGUResetTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EBGUResetType item1_;

	private EBGUResetType item2_;

	public static MessageParser<EBGUResetTypeTupleWrapper> Parser => _parser;

	public EBGUResetType Item1
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

	public EBGUResetType Item2
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

	public EBGUResetTypeTupleWrapper()
	{
	}

	public EBGUResetTypeTupleWrapper(EBGUResetTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EBGUResetTypeTupleWrapper Clone()
	{
		return new EBGUResetTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EBGUResetTypeTupleWrapper);
	}

	public bool Equals(EBGUResetTypeTupleWrapper other)
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
		if (Item1 != EBGUResetType.No)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EBGUResetType.No)
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
		if (Item1 != EBGUResetType.No)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EBGUResetType.No)
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
		if (Item1 != EBGUResetType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EBGUResetType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EBGUResetTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EBGUResetType.No)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EBGUResetType.No)
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
				Item1 = (EBGUResetType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EBGUResetType)input.ReadEnum();
				break;
			}
		}
	}
}
