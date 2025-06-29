using System;
using Google.Protobuf;

namespace ResB1;

public sealed class PlatformAchievementDesc : IMessage<PlatformAchievementDesc>, IMessage, IEquatable<PlatformAchievementDesc>, IDeepCloneable<PlatformAchievementDesc>
{
	private static readonly MessageParser<PlatformAchievementDesc> _parser = new MessageParser<PlatformAchievementDesc>(() => new PlatformAchievementDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private YesNoType isHidden_;

	private AchievementGrade grade_;

	private int xboxTrophyPoint_;

	private YesNoType isXboxBaseGameAchievement_;

	private int sortId_;

	public static MessageParser<PlatformAchievementDesc> Parser => _parser;

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

	public int XboxTrophyPoint
	{
		get
		{
			return xboxTrophyPoint_;
		}
		set
		{
			xboxTrophyPoint_ = value;
		}
	}

	public YesNoType IsXboxBaseGameAchievement
	{
		get
		{
			return isXboxBaseGameAchievement_;
		}
		set
		{
			isXboxBaseGameAchievement_ = value;
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

	public PlatformAchievementDesc()
	{
	}

	public PlatformAchievementDesc(PlatformAchievementDesc other)
		: this()
	{
		id_ = other.id_;
		isHidden_ = other.isHidden_;
		grade_ = other.grade_;
		xboxTrophyPoint_ = other.xboxTrophyPoint_;
		isXboxBaseGameAchievement_ = other.isXboxBaseGameAchievement_;
		sortId_ = other.sortId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PlatformAchievementDesc Clone()
	{
		return new PlatformAchievementDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PlatformAchievementDesc);
	}

	public bool Equals(PlatformAchievementDesc other)
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
		if (XboxTrophyPoint != other.XboxTrophyPoint)
		{
			return false;
		}
		if (IsXboxBaseGameAchievement != other.IsXboxBaseGameAchievement)
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
		if (XboxTrophyPoint != 0)
		{
			num ^= XboxTrophyPoint.GetHashCode();
		}
		if (IsXboxBaseGameAchievement != YesNoType.No)
		{
			num ^= IsXboxBaseGameAchievement.GetHashCode();
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
		if (XboxTrophyPoint != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(XboxTrophyPoint);
		}
		if (IsXboxBaseGameAchievement != YesNoType.No)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)IsXboxBaseGameAchievement);
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
		if (XboxTrophyPoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(XboxTrophyPoint);
		}
		if (IsXboxBaseGameAchievement != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsXboxBaseGameAchievement);
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

	public void MergeFrom(PlatformAchievementDesc other)
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
			if (other.XboxTrophyPoint != 0)
			{
				XboxTrophyPoint = other.XboxTrophyPoint;
			}
			if (other.IsXboxBaseGameAchievement != YesNoType.No)
			{
				IsXboxBaseGameAchievement = other.IsXboxBaseGameAchievement;
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
				XboxTrophyPoint = input.ReadInt32();
				break;
			case 40u:
				IsXboxBaseGameAchievement = (YesNoType)input.ReadEnum();
				break;
			case 48u:
				SortId = input.ReadInt32();
				break;
			}
		}
	}
}
