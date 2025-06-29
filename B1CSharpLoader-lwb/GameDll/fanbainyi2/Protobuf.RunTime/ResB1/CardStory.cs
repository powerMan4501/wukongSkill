using System;
using BtlShare;
using Google.Protobuf;

namespace ResB1;

public sealed class CardStory : IMessage<CardStory>, IMessage, IEquatable<CardStory>, IDeepCloneable<CardStory>
{
	private static readonly MessageParser<CardStory> _parser = new MessageParser<CardStory>(() => new CardStory());

	private UnknownFieldSet _unknownFields;

	private ECollectionStage collectionStage_;

	private string unitStory_ = "";

	public static MessageParser<CardStory> Parser => _parser;

	public ECollectionStage CollectionStage
	{
		get
		{
			return collectionStage_;
		}
		set
		{
			collectionStage_ = value;
		}
	}

	public string UnitStory
	{
		get
		{
			return unitStory_;
		}
		set
		{
			unitStory_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public CardStory()
	{
	}

	public CardStory(CardStory other)
		: this()
	{
		collectionStage_ = other.collectionStage_;
		unitStory_ = other.unitStory_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CardStory Clone()
	{
		return new CardStory(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CardStory);
	}

	public bool Equals(CardStory other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CollectionStage != other.CollectionStage)
		{
			return false;
		}
		if (UnitStory != other.UnitStory)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (CollectionStage != ECollectionStage.FirstSight)
		{
			num ^= CollectionStage.GetHashCode();
		}
		if (UnitStory.Length != 0)
		{
			num ^= UnitStory.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (CollectionStage != ECollectionStage.FirstSight)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)CollectionStage);
		}
		if (UnitStory.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(UnitStory);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (CollectionStage != ECollectionStage.FirstSight)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CollectionStage);
		}
		if (UnitStory.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UnitStory);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CardStory other)
	{
		if (other != null)
		{
			if (other.CollectionStage != ECollectionStage.FirstSight)
			{
				CollectionStage = other.CollectionStage;
			}
			if (other.UnitStory.Length != 0)
			{
				UnitStory = other.UnitStory;
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
				CollectionStage = (ECollectionStage)input.ReadEnum();
				break;
			case 18u:
				UnitStory = input.ReadString();
				break;
			}
		}
	}
}
