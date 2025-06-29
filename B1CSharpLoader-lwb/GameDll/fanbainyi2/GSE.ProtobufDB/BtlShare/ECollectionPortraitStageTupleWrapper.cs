using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class ECollectionPortraitStageTupleWrapper : IMessage<ECollectionPortraitStageTupleWrapper>, IMessage, IEquatable<ECollectionPortraitStageTupleWrapper>, IDeepCloneable<ECollectionPortraitStageTupleWrapper>
{
	private static readonly MessageParser<ECollectionPortraitStageTupleWrapper> _parser = new MessageParser<ECollectionPortraitStageTupleWrapper>(() => new ECollectionPortraitStageTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ECollectionPortraitStage item1_;

	private ECollectionPortraitStage item2_;

	public static MessageParser<ECollectionPortraitStageTupleWrapper> Parser => _parser;

	public ECollectionPortraitStage Item1
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

	public ECollectionPortraitStage Item2
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

	public ECollectionPortraitStageTupleWrapper()
	{
	}

	public ECollectionPortraitStageTupleWrapper(ECollectionPortraitStageTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ECollectionPortraitStageTupleWrapper Clone()
	{
		return new ECollectionPortraitStageTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ECollectionPortraitStageTupleWrapper);
	}

	public bool Equals(ECollectionPortraitStageTupleWrapper other)
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
		if (Item1 != ECollectionPortraitStage.FirstSight)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ECollectionPortraitStage.FirstSight)
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
		if (Item1 != ECollectionPortraitStage.FirstSight)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ECollectionPortraitStage.FirstSight)
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
		if (Item1 != ECollectionPortraitStage.FirstSight)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ECollectionPortraitStage.FirstSight)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ECollectionPortraitStageTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ECollectionPortraitStage.FirstSight)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ECollectionPortraitStage.FirstSight)
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
				Item1 = (ECollectionPortraitStage)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ECollectionPortraitStage)input.ReadEnum();
				break;
			}
		}
	}
}
