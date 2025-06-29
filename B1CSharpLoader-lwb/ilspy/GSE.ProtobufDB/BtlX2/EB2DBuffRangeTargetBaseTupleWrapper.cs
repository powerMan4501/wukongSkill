using System;
using Google.Protobuf;

namespace BtlX2;

public sealed class EB2DBuffRangeTargetBaseTupleWrapper : IMessage<EB2DBuffRangeTargetBaseTupleWrapper>, IMessage, IEquatable<EB2DBuffRangeTargetBaseTupleWrapper>, IDeepCloneable<EB2DBuffRangeTargetBaseTupleWrapper>
{
	private static readonly MessageParser<EB2DBuffRangeTargetBaseTupleWrapper> _parser = new MessageParser<EB2DBuffRangeTargetBaseTupleWrapper>(() => new EB2DBuffRangeTargetBaseTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EB2DBuffRangeTargetBase item1_;

	private EB2DBuffRangeTargetBase item2_;

	public static MessageParser<EB2DBuffRangeTargetBaseTupleWrapper> Parser => _parser;

	public EB2DBuffRangeTargetBase Item1
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

	public EB2DBuffRangeTargetBase Item2
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

	public EB2DBuffRangeTargetBaseTupleWrapper()
	{
	}

	public EB2DBuffRangeTargetBaseTupleWrapper(EB2DBuffRangeTargetBaseTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EB2DBuffRangeTargetBaseTupleWrapper Clone()
	{
		return new EB2DBuffRangeTargetBaseTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EB2DBuffRangeTargetBaseTupleWrapper);
	}

	public bool Equals(EB2DBuffRangeTargetBaseTupleWrapper other)
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
		if (Item1 != EB2DBuffRangeTargetBase.RootCaster)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EB2DBuffRangeTargetBase.RootCaster)
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
		if (Item1 != EB2DBuffRangeTargetBase.RootCaster)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EB2DBuffRangeTargetBase.RootCaster)
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
		if (Item1 != EB2DBuffRangeTargetBase.RootCaster)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EB2DBuffRangeTargetBase.RootCaster)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EB2DBuffRangeTargetBaseTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EB2DBuffRangeTargetBase.RootCaster)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EB2DBuffRangeTargetBase.RootCaster)
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
				Item1 = (EB2DBuffRangeTargetBase)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EB2DBuffRangeTargetBase)input.ReadEnum();
				break;
			}
		}
	}
}
