using System;
using Google.Protobuf;

namespace BtlU3;

public sealed class EB2DEffectRangeTargetBaseTupleWrapper : IMessage<EB2DEffectRangeTargetBaseTupleWrapper>, IMessage, IEquatable<EB2DEffectRangeTargetBaseTupleWrapper>, IDeepCloneable<EB2DEffectRangeTargetBaseTupleWrapper>
{
	private static readonly MessageParser<EB2DEffectRangeTargetBaseTupleWrapper> _parser = new MessageParser<EB2DEffectRangeTargetBaseTupleWrapper>(() => new EB2DEffectRangeTargetBaseTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EB2DEffectRangeTargetBase item1_;

	private EB2DEffectRangeTargetBase item2_;

	public static MessageParser<EB2DEffectRangeTargetBaseTupleWrapper> Parser => _parser;

	public EB2DEffectRangeTargetBase Item1
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

	public EB2DEffectRangeTargetBase Item2
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

	public EB2DEffectRangeTargetBaseTupleWrapper()
	{
	}

	public EB2DEffectRangeTargetBaseTupleWrapper(EB2DEffectRangeTargetBaseTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EB2DEffectRangeTargetBaseTupleWrapper Clone()
	{
		return new EB2DEffectRangeTargetBaseTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EB2DEffectRangeTargetBaseTupleWrapper);
	}

	public bool Equals(EB2DEffectRangeTargetBaseTupleWrapper other)
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
		if (Item1 != EB2DEffectRangeTargetBase.Auto)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EB2DEffectRangeTargetBase.Auto)
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
		if (Item1 != EB2DEffectRangeTargetBase.Auto)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EB2DEffectRangeTargetBase.Auto)
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
		if (Item1 != EB2DEffectRangeTargetBase.Auto)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EB2DEffectRangeTargetBase.Auto)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EB2DEffectRangeTargetBaseTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EB2DEffectRangeTargetBase.Auto)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EB2DEffectRangeTargetBase.Auto)
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
				Item1 = (EB2DEffectRangeTargetBase)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EB2DEffectRangeTargetBase)input.ReadEnum();
				break;
			}
		}
	}
}
