using System;
using BtlShare;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgCollectionReadCardStoryReq : IMessage<CSMsgCollectionReadCardStoryReq>, IMessage, IEquatable<CSMsgCollectionReadCardStoryReq>, IDeepCloneable<CSMsgCollectionReadCardStoryReq>
{
	private static readonly MessageParser<CSMsgCollectionReadCardStoryReq> _parser = new MessageParser<CSMsgCollectionReadCardStoryReq>(() => new CSMsgCollectionReadCardStoryReq());

	private UnknownFieldSet _unknownFields;

	private int cardId_;

	private ECollectionStage collectionStage_;

	public static MessageParser<CSMsgCollectionReadCardStoryReq> Parser => _parser;

	public int CardId
	{
		get
		{
			return cardId_;
		}
		set
		{
			cardId_ = value;
		}
	}

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

	public CSMsgCollectionReadCardStoryReq()
	{
	}

	public CSMsgCollectionReadCardStoryReq(CSMsgCollectionReadCardStoryReq other)
		: this()
	{
		cardId_ = other.cardId_;
		collectionStage_ = other.collectionStage_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgCollectionReadCardStoryReq Clone()
	{
		return new CSMsgCollectionReadCardStoryReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgCollectionReadCardStoryReq);
	}

	public bool Equals(CSMsgCollectionReadCardStoryReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CardId != other.CardId)
		{
			return false;
		}
		if (CollectionStage != other.CollectionStage)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (CardId != 0)
		{
			num ^= CardId.GetHashCode();
		}
		if (CollectionStage != ECollectionStage.FirstSight)
		{
			num ^= CollectionStage.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (CardId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(CardId);
		}
		if (CollectionStage != ECollectionStage.FirstSight)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)CollectionStage);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (CardId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CardId);
		}
		if (CollectionStage != ECollectionStage.FirstSight)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CollectionStage);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgCollectionReadCardStoryReq other)
	{
		if (other != null)
		{
			if (other.CardId != 0)
			{
				CardId = other.CardId;
			}
			if (other.CollectionStage != ECollectionStage.FirstSight)
			{
				CollectionStage = other.CollectionStage;
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
				CardId = input.ReadInt32();
				break;
			case 16u:
				CollectionStage = (ECollectionStage)input.ReadEnum();
				break;
			}
		}
	}
}
