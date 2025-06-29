using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EBGUMagicFieldGenTypeTupleWrapper : IMessage<EBGUMagicFieldGenTypeTupleWrapper>, IMessage, IEquatable<EBGUMagicFieldGenTypeTupleWrapper>, IDeepCloneable<EBGUMagicFieldGenTypeTupleWrapper>
{
	private static readonly MessageParser<EBGUMagicFieldGenTypeTupleWrapper> _parser = new MessageParser<EBGUMagicFieldGenTypeTupleWrapper>(() => new EBGUMagicFieldGenTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EBGUMagicFieldGenType item1_;

	private EBGUMagicFieldGenType item2_;

	public static MessageParser<EBGUMagicFieldGenTypeTupleWrapper> Parser => _parser;

	public EBGUMagicFieldGenType Item1
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

	public EBGUMagicFieldGenType Item2
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

	public EBGUMagicFieldGenTypeTupleWrapper()
	{
	}

	public EBGUMagicFieldGenTypeTupleWrapper(EBGUMagicFieldGenTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EBGUMagicFieldGenTypeTupleWrapper Clone()
	{
		return new EBGUMagicFieldGenTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EBGUMagicFieldGenTypeTupleWrapper);
	}

	public bool Equals(EBGUMagicFieldGenTypeTupleWrapper other)
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
		if (Item1 != EBGUMagicFieldGenType.EbgumagicFieldGenTypeCaster)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EBGUMagicFieldGenType.EbgumagicFieldGenTypeCaster)
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
		if (Item1 != EBGUMagicFieldGenType.EbgumagicFieldGenTypeCaster)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EBGUMagicFieldGenType.EbgumagicFieldGenTypeCaster)
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
		if (Item1 != EBGUMagicFieldGenType.EbgumagicFieldGenTypeCaster)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EBGUMagicFieldGenType.EbgumagicFieldGenTypeCaster)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EBGUMagicFieldGenTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EBGUMagicFieldGenType.EbgumagicFieldGenTypeCaster)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EBGUMagicFieldGenType.EbgumagicFieldGenTypeCaster)
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
				Item1 = (EBGUMagicFieldGenType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EBGUMagicFieldGenType)input.ReadEnum();
				break;
			}
		}
	}
}
