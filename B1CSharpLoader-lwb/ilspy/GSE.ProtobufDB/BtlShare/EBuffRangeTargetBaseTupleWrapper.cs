using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EBuffRangeTargetBaseTupleWrapper : IMessage<EBuffRangeTargetBaseTupleWrapper>, IMessage, IEquatable<EBuffRangeTargetBaseTupleWrapper>, IDeepCloneable<EBuffRangeTargetBaseTupleWrapper>
{
	private static readonly MessageParser<EBuffRangeTargetBaseTupleWrapper> _parser = new MessageParser<EBuffRangeTargetBaseTupleWrapper>(() => new EBuffRangeTargetBaseTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EBuffRangeTargetBase item1_;

	private EBuffRangeTargetBase item2_;

	public static MessageParser<EBuffRangeTargetBaseTupleWrapper> Parser => _parser;

	public EBuffRangeTargetBase Item1
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

	public EBuffRangeTargetBase Item2
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

	public EBuffRangeTargetBaseTupleWrapper()
	{
	}

	public EBuffRangeTargetBaseTupleWrapper(EBuffRangeTargetBaseTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EBuffRangeTargetBaseTupleWrapper Clone()
	{
		return new EBuffRangeTargetBaseTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EBuffRangeTargetBaseTupleWrapper);
	}

	public bool Equals(EBuffRangeTargetBaseTupleWrapper other)
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
		if (Item1 != EBuffRangeTargetBase.RootCaster)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EBuffRangeTargetBase.RootCaster)
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
		if (Item1 != EBuffRangeTargetBase.RootCaster)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EBuffRangeTargetBase.RootCaster)
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
		if (Item1 != EBuffRangeTargetBase.RootCaster)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EBuffRangeTargetBase.RootCaster)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EBuffRangeTargetBaseTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EBuffRangeTargetBase.RootCaster)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EBuffRangeTargetBase.RootCaster)
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
				Item1 = (EBuffRangeTargetBase)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EBuffRangeTargetBase)input.ReadEnum();
				break;
			}
		}
	}
}
