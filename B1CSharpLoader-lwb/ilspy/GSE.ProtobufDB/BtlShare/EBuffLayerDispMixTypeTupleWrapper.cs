using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EBuffLayerDispMixTypeTupleWrapper : IMessage<EBuffLayerDispMixTypeTupleWrapper>, IMessage, IEquatable<EBuffLayerDispMixTypeTupleWrapper>, IDeepCloneable<EBuffLayerDispMixTypeTupleWrapper>
{
	private static readonly MessageParser<EBuffLayerDispMixTypeTupleWrapper> _parser = new MessageParser<EBuffLayerDispMixTypeTupleWrapper>(() => new EBuffLayerDispMixTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EBuffLayerDispMixType item1_;

	private EBuffLayerDispMixType item2_;

	public static MessageParser<EBuffLayerDispMixTypeTupleWrapper> Parser => _parser;

	public EBuffLayerDispMixType Item1
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

	public EBuffLayerDispMixType Item2
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

	public EBuffLayerDispMixTypeTupleWrapper()
	{
	}

	public EBuffLayerDispMixTypeTupleWrapper(EBuffLayerDispMixTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EBuffLayerDispMixTypeTupleWrapper Clone()
	{
		return new EBuffLayerDispMixTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EBuffLayerDispMixTypeTupleWrapper);
	}

	public bool Equals(EBuffLayerDispMixTypeTupleWrapper other)
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
		if (Item1 != EBuffLayerDispMixType.Override)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EBuffLayerDispMixType.Override)
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
		if (Item1 != EBuffLayerDispMixType.Override)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EBuffLayerDispMixType.Override)
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
		if (Item1 != EBuffLayerDispMixType.Override)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EBuffLayerDispMixType.Override)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EBuffLayerDispMixTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EBuffLayerDispMixType.Override)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EBuffLayerDispMixType.Override)
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
				Item1 = (EBuffLayerDispMixType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EBuffLayerDispMixType)input.ReadEnum();
				break;
			}
		}
	}
}
