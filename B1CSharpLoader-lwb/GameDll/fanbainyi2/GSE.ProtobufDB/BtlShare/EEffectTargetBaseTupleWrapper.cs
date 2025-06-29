using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EEffectTargetBaseTupleWrapper : IMessage<EEffectTargetBaseTupleWrapper>, IMessage, IEquatable<EEffectTargetBaseTupleWrapper>, IDeepCloneable<EEffectTargetBaseTupleWrapper>
{
	private static readonly MessageParser<EEffectTargetBaseTupleWrapper> _parser = new MessageParser<EEffectTargetBaseTupleWrapper>(() => new EEffectTargetBaseTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EEffectTargetBase item1_;

	private EEffectTargetBase item2_;

	public static MessageParser<EEffectTargetBaseTupleWrapper> Parser => _parser;

	public EEffectTargetBase Item1
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

	public EEffectTargetBase Item2
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

	public EEffectTargetBaseTupleWrapper()
	{
	}

	public EEffectTargetBaseTupleWrapper(EEffectTargetBaseTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EEffectTargetBaseTupleWrapper Clone()
	{
		return new EEffectTargetBaseTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EEffectTargetBaseTupleWrapper);
	}

	public bool Equals(EEffectTargetBaseTupleWrapper other)
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
		if (Item1 != EEffectTargetBase.Self)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EEffectTargetBase.Self)
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
		if (Item1 != EEffectTargetBase.Self)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EEffectTargetBase.Self)
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
		if (Item1 != EEffectTargetBase.Self)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EEffectTargetBase.Self)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EEffectTargetBaseTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EEffectTargetBase.Self)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EEffectTargetBase.Self)
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
				Item1 = (EEffectTargetBase)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EEffectTargetBase)input.ReadEnum();
				break;
			}
		}
	}
}
