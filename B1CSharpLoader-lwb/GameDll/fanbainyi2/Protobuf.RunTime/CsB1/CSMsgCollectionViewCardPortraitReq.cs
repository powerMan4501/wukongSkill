using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgCollectionViewCardPortraitReq : IMessage<CSMsgCollectionViewCardPortraitReq>, IMessage, IEquatable<CSMsgCollectionViewCardPortraitReq>, IDeepCloneable<CSMsgCollectionViewCardPortraitReq>
{
	private static readonly MessageParser<CSMsgCollectionViewCardPortraitReq> _parser = new MessageParser<CSMsgCollectionViewCardPortraitReq>(() => new CSMsgCollectionViewCardPortraitReq());

	private UnknownFieldSet _unknownFields;

	private int cardId_;

	public static MessageParser<CSMsgCollectionViewCardPortraitReq> Parser => _parser;

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

	public CSMsgCollectionViewCardPortraitReq()
	{
	}

	public CSMsgCollectionViewCardPortraitReq(CSMsgCollectionViewCardPortraitReq other)
		: this()
	{
		cardId_ = other.cardId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgCollectionViewCardPortraitReq Clone()
	{
		return new CSMsgCollectionViewCardPortraitReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgCollectionViewCardPortraitReq);
	}

	public bool Equals(CSMsgCollectionViewCardPortraitReq other)
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
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
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
		if (CardId != 0)
		{
			output.WriteRawTag(8);
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

	public void MergeFrom(CSMsgCollectionViewCardPortraitReq other)
	{
		if (other != null)
		{
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
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				CardId = input.ReadInt32();
			}
		}
	}
}
