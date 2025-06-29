using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class ECollectionStageTupleWrapper : IMessage<ECollectionStageTupleWrapper>, IMessage, IEquatable<ECollectionStageTupleWrapper>, IDeepCloneable<ECollectionStageTupleWrapper>
{
	private static readonly MessageParser<ECollectionStageTupleWrapper> _parser = new MessageParser<ECollectionStageTupleWrapper>(() => new ECollectionStageTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ECollectionStage item1_;

	private ECollectionStage item2_;

	public static MessageParser<ECollectionStageTupleWrapper> Parser => _parser;

	public ECollectionStage Item1
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

	public ECollectionStage Item2
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

	public ECollectionStageTupleWrapper()
	{
	}

	public ECollectionStageTupleWrapper(ECollectionStageTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ECollectionStageTupleWrapper Clone()
	{
		return new ECollectionStageTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ECollectionStageTupleWrapper);
	}

	public bool Equals(ECollectionStageTupleWrapper other)
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
		if (Item1 != ECollectionStage.FirstSight)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ECollectionStage.FirstSight)
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
		if (Item1 != ECollectionStage.FirstSight)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ECollectionStage.FirstSight)
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
		if (Item1 != ECollectionStage.FirstSight)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ECollectionStage.FirstSight)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ECollectionStageTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ECollectionStage.FirstSight)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ECollectionStage.FirstSight)
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
				Item1 = (ECollectionStage)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ECollectionStage)input.ReadEnum();
				break;
			}
		}
	}
}
