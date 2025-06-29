using System;
using Google.Protobuf;

namespace ResB1;

public sealed class PlatformAchievementLiteDesc : IMessage<PlatformAchievementLiteDesc>, IMessage, IEquatable<PlatformAchievementLiteDesc>, IDeepCloneable<PlatformAchievementLiteDesc>
{
	private static readonly MessageParser<PlatformAchievementLiteDesc> _parser = new MessageParser<PlatformAchievementLiteDesc>(() => new PlatformAchievementLiteDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private YesNoType isHidden_;

	private AchievementGrade grade_;

	private int ps5TrophyPoint_;

	private int epicXp_;

	private int sortId_;

	public static MessageParser<PlatformAchievementLiteDesc> Parser => _parser;

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

	public YesNoType IsHidden
	{
		get
		{
			return isHidden_;
		}
		set
		{
			isHidden_ = value;
		}
	}

	public AchievementGrade Grade
	{
		get
		{
			return grade_;
		}
		set
		{
			grade_ = value;
		}
	}

	public int Ps5TrophyPoint
	{
		get
		{
			return ps5TrophyPoint_;
		}
		set
		{
			ps5TrophyPoint_ = value;
		}
	}

	public int EpicXp
	{
		get
		{
			return epicXp_;
		}
		set
		{
			epicXp_ = value;
		}
	}

	public int SortId
	{
		get
		{
			return sortId_;
		}
		set
		{
			sortId_ = value;
		}
	}

	public PlatformAchievementLiteDesc()
	{
	}

	public PlatformAchievementLiteDesc(PlatformAchievementLiteDesc other)
		: this()
	{
		id_ = other.id_;
		isHidden_ = other.isHidden_;
		grade_ = other.grade_;
		ps5TrophyPoint_ = other.ps5TrophyPoint_;
		epicXp_ = other.epicXp_;
		sortId_ = other.sortId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PlatformAchievementLiteDesc Clone()
	{
		return new PlatformAchievementLiteDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PlatformAchievementLiteDesc);
	}

	public bool Equals(PlatformAchievementLiteDesc other)
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
		if (IsHidden != other.IsHidden)
		{
			return false;
		}
		if (Grade != other.Grade)
		{
			return false;
		}
		if (Ps5TrophyPoint != other.Ps5TrophyPoint)
		{
			return false;
		}
		if (EpicXp != other.EpicXp)
		{
			return false;
		}
		if (SortId != other.SortId)
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
		if (IsHidden != YesNoType.No)
		{
			num ^= IsHidden.GetHashCode();
		}
		if (Grade != AchievementGrade.Glod)
		{
			num ^= Grade.GetHashCode();
		}
		if (Ps5TrophyPoint != 0)
		{
			num ^= Ps5TrophyPoint.GetHashCode();
		}
		if (EpicXp != 0)
		{
			num ^= EpicXp.GetHashCode();
		}
		if (SortId != 0)
		{
			num ^= SortId.GetHashCode();
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
		if (IsHidden != YesNoType.No)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)IsHidden);
		}
		if (Grade != AchievementGrade.Glod)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)Grade);
		}
		if (Ps5TrophyPoint != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Ps5TrophyPoint);
		}
		if (EpicXp != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(EpicXp);
		}
		if (SortId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(SortId);
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
		if (IsHidden != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsHidden);
		}
		if (Grade != AchievementGrade.Glod)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Grade);
		}
		if (Ps5TrophyPoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Ps5TrophyPoint);
		}
		if (EpicXp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EpicXp);
		}
		if (SortId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SortId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PlatformAchievementLiteDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.IsHidden != YesNoType.No)
			{
				IsHidden = other.IsHidden;
			}
			if (other.Grade != AchievementGrade.Glod)
			{
				Grade = other.Grade;
			}
			if (other.Ps5TrophyPoint != 0)
			{
				Ps5TrophyPoint = other.Ps5TrophyPoint;
			}
			if (other.EpicXp != 0)
			{
				EpicXp = other.EpicXp;
			}
			if (other.SortId != 0)
			{
				SortId = other.SortId;
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
				IsHidden = (YesNoType)input.ReadEnum();
				break;
			case 24u:
				Grade = (AchievementGrade)input.ReadEnum();
				break;
			case 32u:
				Ps5TrophyPoint = input.ReadInt32();
				break;
			case 40u:
				EpicXp = input.ReadInt32();
				break;
			case 48u:
				SortId = input.ReadInt32();
				break;
			}
		}
	}
}
