using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class ECollectionStageRemoveTupleWrapper : IMessage<ECollectionStageRemoveTupleWrapper>, IMessage, IEquatable<ECollectionStageRemoveTupleWrapper>, IDeepCloneable<ECollectionStageRemoveTupleWrapper>
{
	private static readonly MessageParser<ECollectionStageRemoveTupleWrapper> _parser = new MessageParser<ECollectionStageRemoveTupleWrapper>(() => new ECollectionStageRemoveTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ECollectionStageRemove item1_;

	private ECollectionStageRemove item2_;

	public static MessageParser<ECollectionStageRemoveTupleWrapper> Parser => _parser;

	public ECollectionStageRemove Item1
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

	public ECollectionStageRemove Item2
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

	public ECollectionStageRemoveTupleWrapper()
	{
	}

	public ECollectionStageRemoveTupleWrapper(ECollectionStageRemoveTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ECollectionStageRemoveTupleWrapper Clone()
	{
		return new ECollectionStageRemoveTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ECollectionStageRemoveTupleWrapper);
	}

	public bool Equals(ECollectionStageRemoveTupleWrapper other)
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
		if (Item1 != ECollectionStageRemove.Min)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ECollectionStageRemove.Min)
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
		if (Item1 != ECollectionStageRemove.Min)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ECollectionStageRemove.Min)
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
		if (Item1 != ECollectionStageRemove.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ECollectionStageRemove.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ECollectionStageRemoveTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ECollectionStageRemove.Min)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ECollectionStageRemove.Min)
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
				Item1 = (ECollectionStageRemove)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ECollectionStageRemove)input.ReadEnum();
				break;
			}
		}
	}
}
