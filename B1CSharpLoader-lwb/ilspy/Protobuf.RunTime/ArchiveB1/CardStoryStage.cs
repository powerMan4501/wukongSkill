using System;
using BtlShare;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class CardStoryStage : IMessage<CardStoryStage>, IMessage, IEquatable<CardStoryStage>, IDeepCloneable<CardStoryStage>
{
	private static readonly MessageParser<CardStoryStage> _parser = new MessageParser<CardStoryStage>(() => new CardStoryStage());

	private UnknownFieldSet _unknownFields;

	private ECollectionStage collectionStage_;

	private bool isRead_;

	public static MessageParser<CardStoryStage> Parser => _parser;

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

	public bool IsRead
	{
		get
		{
			return isRead_;
		}
		set
		{
			isRead_ = value;
		}
	}

	public CardStoryStage()
	{
	}

	public CardStoryStage(CardStoryStage other)
		: this()
	{
		collectionStage_ = other.collectionStage_;
		isRead_ = other.isRead_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CardStoryStage Clone()
	{
		return new CardStoryStage(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CardStoryStage);
	}

	public bool Equals(CardStoryStage other)
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
		if (IsRead != other.IsRead)
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
		if (IsRead)
		{
			num ^= IsRead.GetHashCode();
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
		if (IsRead)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsRead);
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
		if (IsRead)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CardStoryStage other)
	{
		if (other != null)
		{
			if (other.CollectionStage != ECollectionStage.FirstSight)
			{
				CollectionStage = other.CollectionStage;
			}
			if (other.IsRead)
			{
				IsRead = other.IsRead;
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
			case 16u:
				IsRead = input.ReadBool();
				break;
			}
		}
	}
}
