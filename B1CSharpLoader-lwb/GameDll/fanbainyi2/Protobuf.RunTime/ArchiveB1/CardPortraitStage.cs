using System;
using BtlShare;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class CardPortraitStage : IMessage<CardPortraitStage>, IMessage, IEquatable<CardPortraitStage>, IDeepCloneable<CardPortraitStage>
{
	private static readonly MessageParser<CardPortraitStage> _parser = new MessageParser<CardPortraitStage>(() => new CardPortraitStage());

	private UnknownFieldSet _unknownFields;

	private bool isRead_;

	private ECollectionPortraitStage portraitStage_;

	public static MessageParser<CardPortraitStage> Parser => _parser;

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

	public ECollectionPortraitStage PortraitStage
	{
		get
		{
			return portraitStage_;
		}
		set
		{
			portraitStage_ = value;
		}
	}

	public CardPortraitStage()
	{
	}

	public CardPortraitStage(CardPortraitStage other)
		: this()
	{
		isRead_ = other.isRead_;
		portraitStage_ = other.portraitStage_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CardPortraitStage Clone()
	{
		return new CardPortraitStage(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CardPortraitStage);
	}

	public bool Equals(CardPortraitStage other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsRead != other.IsRead)
		{
			return false;
		}
		if (PortraitStage != other.PortraitStage)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (IsRead)
		{
			num ^= IsRead.GetHashCode();
		}
		if (PortraitStage != ECollectionPortraitStage.FirstSight)
		{
			num ^= PortraitStage.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (IsRead)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsRead);
		}
		if (PortraitStage != ECollectionPortraitStage.FirstSight)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)PortraitStage);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (IsRead)
		{
			num += 2;
		}
		if (PortraitStage != ECollectionPortraitStage.FirstSight)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)PortraitStage);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CardPortraitStage other)
	{
		if (other != null)
		{
			if (other.IsRead)
			{
				IsRead = other.IsRead;
			}
			if (other.PortraitStage != ECollectionPortraitStage.FirstSight)
			{
				PortraitStage = other.PortraitStage;
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
			case 16u:
				IsRead = input.ReadBool();
				break;
			case 24u:
				PortraitStage = (ECollectionPortraitStage)input.ReadEnum();
				break;
			}
		}
	}
}
