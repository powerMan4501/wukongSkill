using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class ELandFXPlayTypeTupleWrapper : IMessage<ELandFXPlayTypeTupleWrapper>, IMessage, IEquatable<ELandFXPlayTypeTupleWrapper>, IDeepCloneable<ELandFXPlayTypeTupleWrapper>
{
	private static readonly MessageParser<ELandFXPlayTypeTupleWrapper> _parser = new MessageParser<ELandFXPlayTypeTupleWrapper>(() => new ELandFXPlayTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ELandFXPlayType item1_;

	private ELandFXPlayType item2_;

	public static MessageParser<ELandFXPlayTypeTupleWrapper> Parser => _parser;

	public ELandFXPlayType Item1
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

	public ELandFXPlayType Item2
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

	public ELandFXPlayTypeTupleWrapper()
	{
	}

	public ELandFXPlayTypeTupleWrapper(ELandFXPlayTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ELandFXPlayTypeTupleWrapper Clone()
	{
		return new ELandFXPlayTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ELandFXPlayTypeTupleWrapper);
	}

	public bool Equals(ELandFXPlayTypeTupleWrapper other)
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
		if (Item1 != ELandFXPlayType.JustOnRoot)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ELandFXPlayType.JustOnRoot)
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
		if (Item1 != ELandFXPlayType.JustOnRoot)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ELandFXPlayType.JustOnRoot)
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
		if (Item1 != ELandFXPlayType.JustOnRoot)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ELandFXPlayType.JustOnRoot)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ELandFXPlayTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ELandFXPlayType.JustOnRoot)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ELandFXPlayType.JustOnRoot)
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
				Item1 = (ELandFXPlayType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ELandFXPlayType)input.ReadEnum();
				break;
			}
		}
	}
}
