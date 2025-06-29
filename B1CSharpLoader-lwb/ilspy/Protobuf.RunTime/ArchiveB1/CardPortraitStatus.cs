using System;
using BtlShare;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class CardPortraitStatus : IMessage<CardPortraitStatus>, IMessage, IEquatable<CardPortraitStatus>, IDeepCloneable<CardPortraitStatus>
{
	private static readonly MessageParser<CardPortraitStatus> _parser = new MessageParser<CardPortraitStatus>(() => new CardPortraitStatus());

	private UnknownFieldSet _unknownFields;

	private ECollectionPortraitStage portraitStage_;

	private bool isRead_;

	public static MessageParser<CardPortraitStatus> Parser => _parser;

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

	public CardPortraitStatus()
	{
	}

	public CardPortraitStatus(CardPortraitStatus other)
		: this()
	{
		portraitStage_ = other.portraitStage_;
		isRead_ = other.isRead_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CardPortraitStatus Clone()
	{
		return new CardPortraitStatus(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CardPortraitStatus);
	}

	public bool Equals(CardPortraitStatus other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PortraitStage != other.PortraitStage)
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
		if (PortraitStage != ECollectionPortraitStage.FirstSight)
		{
			num ^= PortraitStage.GetHashCode();
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
		if (PortraitStage != ECollectionPortraitStage.FirstSight)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)PortraitStage);
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
		if (PortraitStage != ECollectionPortraitStage.FirstSight)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)PortraitStage);
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

	public void MergeFrom(CardPortraitStatus other)
	{
		if (other != null)
		{
			if (other.PortraitStage != ECollectionPortraitStage.FirstSight)
			{
				PortraitStage = other.PortraitStage;
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
				PortraitStage = (ECollectionPortraitStage)input.ReadEnum();
				break;
			case 16u:
				IsRead = input.ReadBool();
				break;
			}
		}
	}
}
