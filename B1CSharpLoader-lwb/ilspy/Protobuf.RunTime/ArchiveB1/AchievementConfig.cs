using System;
using Google.Protobuf;
using ResB1;

namespace ArchiveB1;

public sealed class AchievementConfig : IMessage<AchievementConfig>, IMessage, IEquatable<AchievementConfig>, IDeepCloneable<AchievementConfig>
{
	private static readonly MessageParser<AchievementConfig> _parser = new MessageParser<AchievementConfig>(() => new AchievementConfig());

	private UnknownFieldSet _unknownFields;

	private int achievementId_;

	private AchievementUnlockRequirement requirementType_;

	private int requirementCount_;

	private bool isProgress_;

	private bool isResetOnGameplus_;

	public static MessageParser<AchievementConfig> Parser => _parser;

	public int AchievementId
	{
		get
		{
			return achievementId_;
		}
		set
		{
			achievementId_ = value;
		}
	}

	public AchievementUnlockRequirement RequirementType
	{
		get
		{
			return requirementType_;
		}
		set
		{
			requirementType_ = value;
		}
	}

	public int RequirementCount
	{
		get
		{
			return requirementCount_;
		}
		set
		{
			requirementCount_ = value;
		}
	}

	public bool IsProgress
	{
		get
		{
			return isProgress_;
		}
		set
		{
			isProgress_ = value;
		}
	}

	public bool IsResetOnGameplus
	{
		get
		{
			return isResetOnGameplus_;
		}
		set
		{
			isResetOnGameplus_ = value;
		}
	}

	public AchievementConfig()
	{
	}

	public AchievementConfig(AchievementConfig other)
		: this()
	{
		achievementId_ = other.achievementId_;
		requirementType_ = other.requirementType_;
		requirementCount_ = other.requirementCount_;
		isProgress_ = other.isProgress_;
		isResetOnGameplus_ = other.isResetOnGameplus_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AchievementConfig Clone()
	{
		return new AchievementConfig(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AchievementConfig);
	}

	public bool Equals(AchievementConfig other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AchievementId != other.AchievementId)
		{
			return false;
		}
		if (RequirementType != other.RequirementType)
		{
			return false;
		}
		if (RequirementCount != other.RequirementCount)
		{
			return false;
		}
		if (IsProgress != other.IsProgress)
		{
			return false;
		}
		if (IsResetOnGameplus != other.IsResetOnGameplus)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (AchievementId != 0)
		{
			num ^= AchievementId.GetHashCode();
		}
		if (RequirementType != AchievementUnlockRequirement.None)
		{
			num ^= RequirementType.GetHashCode();
		}
		if (RequirementCount != 0)
		{
			num ^= RequirementCount.GetHashCode();
		}
		if (IsProgress)
		{
			num ^= IsProgress.GetHashCode();
		}
		if (IsResetOnGameplus)
		{
			num ^= IsResetOnGameplus.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (AchievementId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(AchievementId);
		}
		if (RequirementType != AchievementUnlockRequirement.None)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)RequirementType);
		}
		if (RequirementCount != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(RequirementCount);
		}
		if (IsProgress)
		{
			output.WriteRawTag(40);
			output.WriteBool(IsProgress);
		}
		if (IsResetOnGameplus)
		{
			output.WriteRawTag(48);
			output.WriteBool(IsResetOnGameplus);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (AchievementId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AchievementId);
		}
		if (RequirementType != AchievementUnlockRequirement.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)RequirementType);
		}
		if (RequirementCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RequirementCount);
		}
		if (IsProgress)
		{
			num += 2;
		}
		if (IsResetOnGameplus)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AchievementConfig other)
	{
		if (other != null)
		{
			if (other.AchievementId != 0)
			{
				AchievementId = other.AchievementId;
			}
			if (other.RequirementType != AchievementUnlockRequirement.None)
			{
				RequirementType = other.RequirementType;
			}
			if (other.RequirementCount != 0)
			{
				RequirementCount = other.RequirementCount;
			}
			if (other.IsProgress)
			{
				IsProgress = other.IsProgress;
			}
			if (other.IsResetOnGameplus)
			{
				IsResetOnGameplus = other.IsResetOnGameplus;
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
				AchievementId = input.ReadInt32();
				break;
			case 16u:
				RequirementType = (AchievementUnlockRequirement)input.ReadEnum();
				break;
			case 32u:
				RequirementCount = input.ReadInt32();
				break;
			case 40u:
				IsProgress = input.ReadBool();
				break;
			case 48u:
				IsResetOnGameplus = input.ReadBool();
				break;
			}
		}
	}
}
