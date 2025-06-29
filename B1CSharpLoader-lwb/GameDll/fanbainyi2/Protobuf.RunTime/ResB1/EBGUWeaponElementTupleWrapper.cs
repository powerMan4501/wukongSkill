using System;
using Google.Protobuf;

namespace ResB1;

public sealed class EBGUWeaponElementTupleWrapper : IMessage<EBGUWeaponElementTupleWrapper>, IMessage, IEquatable<EBGUWeaponElementTupleWrapper>, IDeepCloneable<EBGUWeaponElementTupleWrapper>
{
	private static readonly MessageParser<EBGUWeaponElementTupleWrapper> _parser = new MessageParser<EBGUWeaponElementTupleWrapper>(() => new EBGUWeaponElementTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EBGUWeaponElement item1_;

	private EBGUWeaponElement item2_;

	public static MessageParser<EBGUWeaponElementTupleWrapper> Parser => _parser;

	public EBGUWeaponElement Item1
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

	public EBGUWeaponElement Item2
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

	public EBGUWeaponElementTupleWrapper()
	{
	}

	public EBGUWeaponElementTupleWrapper(EBGUWeaponElementTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EBGUWeaponElementTupleWrapper Clone()
	{
		return new EBGUWeaponElementTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EBGUWeaponElementTupleWrapper);
	}

	public bool Equals(EBGUWeaponElementTupleWrapper other)
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
		if (Item1 != EBGUWeaponElement.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EBGUWeaponElement.None)
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
		if (Item1 != EBGUWeaponElement.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EBGUWeaponElement.None)
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
		if (Item1 != EBGUWeaponElement.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EBGUWeaponElement.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EBGUWeaponElementTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EBGUWeaponElement.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EBGUWeaponElement.None)
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
				Item1 = (EBGUWeaponElement)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EBGUWeaponElement)input.ReadEnum();
				break;
			}
		}
	}
}
