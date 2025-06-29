using System;
using BtlShare;
using Google.Protobuf;

namespace BtlB1;

public sealed class NPCInfo : IMessage<NPCInfo>, IMessage, IEquatable<NPCInfo>, IDeepCloneable<NPCInfo>
{
	private static readonly MessageParser<NPCInfo> _parser = new MessageParser<NPCInfo>(() => new NPCInfo());

	private UnknownFieldSet _unknownFields;

	private ECollectionStage collectionStage_;

	private int cardId_;

	public static MessageParser<NPCInfo> Parser => _parser;

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

	public NPCInfo()
	{
	}

	public NPCInfo(NPCInfo other)
		: this()
	{
		collectionStage_ = other.collectionStage_;
		cardId_ = other.cardId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public NPCInfo Clone()
	{
		return new NPCInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as NPCInfo);
	}

	public bool Equals(NPCInfo other)
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
		if (CardId != other.CardId)
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
		if (CardId != 0)
		{
			num ^= CardId.GetHashCode();
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
		if (CardId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(CardId);
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
		if (CardId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CardId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(NPCInfo other)
	{
		if (other != null)
		{
			if (other.CollectionStage != ECollectionStage.FirstSight)
			{
				CollectionStage = other.CollectionStage;
			}
			if (other.CardId != 0)
			{
				CardId = other.CardId;
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
				CardId = input.ReadInt32();
				break;
			}
		}
	}
}
