using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class EHitItemFXTypeTupleWrapper : IMessage<EHitItemFXTypeTupleWrapper>, IMessage, IEquatable<EHitItemFXTypeTupleWrapper>, IDeepCloneable<EHitItemFXTypeTupleWrapper>
{
	private static readonly MessageParser<EHitItemFXTypeTupleWrapper> _parser = new MessageParser<EHitItemFXTypeTupleWrapper>(() => new EHitItemFXTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EHitItemFXType item1_;

	private EHitItemFXType item2_;

	public static MessageParser<EHitItemFXTypeTupleWrapper> Parser => _parser;

	public EHitItemFXType Item1
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

	public EHitItemFXType Item2
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

	public EHitItemFXTypeTupleWrapper()
	{
	}

	public EHitItemFXTypeTupleWrapper(EHitItemFXTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EHitItemFXTypeTupleWrapper Clone()
	{
		return new EHitItemFXTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EHitItemFXTypeTupleWrapper);
	}

	public bool Equals(EHitItemFXTypeTupleWrapper other)
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
		if (Item1 != EHitItemFXType.NormalBody)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EHitItemFXType.NormalBody)
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
		if (Item1 != EHitItemFXType.NormalBody)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EHitItemFXType.NormalBody)
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
		if (Item1 != EHitItemFXType.NormalBody)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EHitItemFXType.NormalBody)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EHitItemFXTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EHitItemFXType.NormalBody)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EHitItemFXType.NormalBody)
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
				Item1 = (EHitItemFXType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EHitItemFXType)input.ReadEnum();
				break;
			}
		}
	}
}
