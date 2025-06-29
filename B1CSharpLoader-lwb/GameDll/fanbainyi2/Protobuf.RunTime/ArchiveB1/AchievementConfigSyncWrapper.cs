using System;
using Google.Protobuf;
using ResB1;

namespace ArchiveB1;

public sealed class AchievementConfigSyncWrapper : IMessage<AchievementConfigSyncWrapper>, IMessage, IEquatable<AchievementConfigSyncWrapper>, IDeepCloneable<AchievementConfigSyncWrapper>
{
	private static readonly MessageParser<AchievementConfigSyncWrapper> _parser = new MessageParser<AchievementConfigSyncWrapper>(() => new AchievementConfigSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Int32SyncWrapper achievementId_;

	private AchievementUnlockRequirementSyncWrapper requirementType_;

	private Int32SyncWrapper requirementCount_;

	private BoolSyncWrapper isProgress_;

	private BoolSyncWrapper isResetOnGameplus_;

	public static MessageParser<AchievementConfigSyncWrapper> Parser => _parser;

	public int SyncFlag
	{
		get
		{
			return syncFlag_;
		}
		set
		{
			syncFlag_ = value;
		}
	}

	public int SyncIdx
	{
		get
		{
			return syncIdx_;
		}
		set
		{
			syncIdx_ = value;
		}
	}

	public Int32SyncWrapper AchievementId
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

	public AchievementUnlockRequirementSyncWrapper RequirementType
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

	public Int32SyncWrapper RequirementCount
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

	public BoolSyncWrapper IsProgress
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

	public BoolSyncWrapper IsResetOnGameplus
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

	public AchievementConfigSyncWrapper()
	{
	}

	public AchievementConfigSyncWrapper(AchievementConfigSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		achievementId_ = ((other.achievementId_ != null) ? other.achievementId_.Clone() : null);
		requirementType_ = ((other.requirementType_ != null) ? other.requirementType_.Clone() : null);
		requirementCount_ = ((other.requirementCount_ != null) ? other.requirementCount_.Clone() : null);
		isProgress_ = ((other.isProgress_ != null) ? other.isProgress_.Clone() : null);
		isResetOnGameplus_ = ((other.isResetOnGameplus_ != null) ? other.isResetOnGameplus_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AchievementConfigSyncWrapper Clone()
	{
		return new AchievementConfigSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AchievementConfigSyncWrapper);
	}

	public bool Equals(AchievementConfigSyncWrapper other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SyncFlag != other.SyncFlag)
		{
			return false;
		}
		if (SyncIdx != other.SyncIdx)
		{
			return false;
		}
		if (!object.Equals(AchievementId, other.AchievementId))
		{
			return false;
		}
		if (!object.Equals(RequirementType, other.RequirementType))
		{
			return false;
		}
		if (!object.Equals(RequirementCount, other.RequirementCount))
		{
			return false;
		}
		if (!object.Equals(IsProgress, other.IsProgress))
		{
			return false;
		}
		if (!object.Equals(IsResetOnGameplus, other.IsResetOnGameplus))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SyncFlag != 0)
		{
			num ^= SyncFlag.GetHashCode();
		}
		if (SyncIdx != 0)
		{
			num ^= SyncIdx.GetHashCode();
		}
		if (achievementId_ != null)
		{
			num ^= AchievementId.GetHashCode();
		}
		if (requirementType_ != null)
		{
			num ^= RequirementType.GetHashCode();
		}
		if (requirementCount_ != null)
		{
			num ^= RequirementCount.GetHashCode();
		}
		if (isProgress_ != null)
		{
			num ^= IsProgress.GetHashCode();
		}
		if (isResetOnGameplus_ != null)
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
		if (SyncFlag != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SyncIdx);
		}
		if (achievementId_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(AchievementId);
		}
		if (requirementType_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(RequirementType);
		}
		if (requirementCount_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(RequirementCount);
		}
		if (isProgress_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(IsProgress);
		}
		if (isResetOnGameplus_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(IsResetOnGameplus);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SyncFlag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncIdx);
		}
		if (achievementId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AchievementId);
		}
		if (requirementType_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RequirementType);
		}
		if (requirementCount_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RequirementCount);
		}
		if (isProgress_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IsProgress);
		}
		if (isResetOnGameplus_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IsResetOnGameplus);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AchievementConfigSyncWrapper other)
	{
		if (other == null)
		{
			return;
		}
		if (other.SyncFlag != 0)
		{
			SyncFlag = other.SyncFlag;
		}
		if (other.SyncIdx != 0)
		{
			SyncIdx = other.SyncIdx;
		}
		if (other.achievementId_ != null)
		{
			if (achievementId_ == null)
			{
				AchievementId = new Int32SyncWrapper();
			}
			AchievementId.MergeFrom(other.AchievementId);
		}
		if (other.requirementType_ != null)
		{
			if (requirementType_ == null)
			{
				RequirementType = new AchievementUnlockRequirementSyncWrapper();
			}
			RequirementType.MergeFrom(other.RequirementType);
		}
		if (other.requirementCount_ != null)
		{
			if (requirementCount_ == null)
			{
				RequirementCount = new Int32SyncWrapper();
			}
			RequirementCount.MergeFrom(other.RequirementCount);
		}
		if (other.isProgress_ != null)
		{
			if (isProgress_ == null)
			{
				IsProgress = new BoolSyncWrapper();
			}
			IsProgress.MergeFrom(other.IsProgress);
		}
		if (other.isResetOnGameplus_ != null)
		{
			if (isResetOnGameplus_ == null)
			{
				IsResetOnGameplus = new BoolSyncWrapper();
			}
			IsResetOnGameplus.MergeFrom(other.IsResetOnGameplus);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				SyncFlag = input.ReadInt32();
				break;
			case 16u:
				SyncIdx = input.ReadInt32();
				break;
			case 26u:
				if (achievementId_ == null)
				{
					AchievementId = new Int32SyncWrapper();
				}
				input.ReadMessage(AchievementId);
				break;
			case 34u:
				if (requirementType_ == null)
				{
					RequirementType = new AchievementUnlockRequirementSyncWrapper();
				}
				input.ReadMessage(RequirementType);
				break;
			case 50u:
				if (requirementCount_ == null)
				{
					RequirementCount = new Int32SyncWrapper();
				}
				input.ReadMessage(RequirementCount);
				break;
			case 58u:
				if (isProgress_ == null)
				{
					IsProgress = new BoolSyncWrapper();
				}
				input.ReadMessage(IsProgress);
				break;
			case 66u:
				if (isResetOnGameplus_ == null)
				{
					IsResetOnGameplus = new BoolSyncWrapper();
				}
				input.ReadMessage(IsResetOnGameplus);
				break;
			}
		}
	}
}
