using System;
using Google.Protobuf;

namespace BtlX2;

public sealed class FUStB2DLevelTimeBonusDesc : IMessage<FUStB2DLevelTimeBonusDesc>, IMessage, IEquatable<FUStB2DLevelTimeBonusDesc>, IDeepCloneable<FUStB2DLevelTimeBonusDesc>
{
	private static readonly MessageParser<FUStB2DLevelTimeBonusDesc> _parser = new MessageParser<FUStB2DLevelTimeBonusDesc>(() => new FUStB2DLevelTimeBonusDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int dragPercentage_;

	private int bonusTime_;

	public static MessageParser<FUStB2DLevelTimeBonusDesc> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public int DragPercentage
	{
		get
		{
			return dragPercentage_;
		}
		set
		{
			dragPercentage_ = value;
		}
	}

	public int BonusTime
	{
		get
		{
			return bonusTime_;
		}
		set
		{
			bonusTime_ = value;
		}
	}

	public FUStB2DLevelTimeBonusDesc()
	{
	}

	public FUStB2DLevelTimeBonusDesc(FUStB2DLevelTimeBonusDesc other)
		: this()
	{
		id_ = other.id_;
		dragPercentage_ = other.dragPercentage_;
		bonusTime_ = other.bonusTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStB2DLevelTimeBonusDesc Clone()
	{
		return new FUStB2DLevelTimeBonusDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStB2DLevelTimeBonusDesc);
	}

	public bool Equals(FUStB2DLevelTimeBonusDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (DragPercentage != other.DragPercentage)
		{
			return false;
		}
		if (BonusTime != other.BonusTime)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (DragPercentage != 0)
		{
			num ^= DragPercentage.GetHashCode();
		}
		if (BonusTime != 0)
		{
			num ^= BonusTime.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (DragPercentage != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(DragPercentage);
		}
		if (BonusTime != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BonusTime);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (DragPercentage != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DragPercentage);
		}
		if (BonusTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BonusTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStB2DLevelTimeBonusDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.DragPercentage != 0)
			{
				DragPercentage = other.DragPercentage;
			}
			if (other.BonusTime != 0)
			{
				BonusTime = other.BonusTime;
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
				Id = input.ReadInt32();
				break;
			case 16u:
				DragPercentage = input.ReadInt32();
				break;
			case 24u:
				BonusTime = input.ReadInt32();
				break;
			}
		}
	}
}
