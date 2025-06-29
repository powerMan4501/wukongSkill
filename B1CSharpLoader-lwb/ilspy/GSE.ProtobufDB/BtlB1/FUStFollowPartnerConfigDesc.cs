using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStFollowPartnerConfigDesc : IMessage<FUStFollowPartnerConfigDesc>, IMessage, IEquatable<FUStFollowPartnerConfigDesc>, IDeepCloneable<FUStFollowPartnerConfigDesc>
{
	private static readonly MessageParser<FUStFollowPartnerConfigDesc> _parser = new MessageParser<FUStFollowPartnerConfigDesc>(() => new FUStFollowPartnerConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int levelID_;

	private string overlapBoxGUID_ = "";

	private int associationUnitInfoID_;

	private string followPartnerDispDAPath_ = "";

	private EFollowPartnerSpawnType followPartnerSpawnType_;

	private EGSYesNo judgeConditionAfterPartnerAppear_;

	private int respawnCheckDistance_;

	private int respawnWaitTime_;

	private string configDAPath_ = "";

	private EConditionRelationType conditionType_;

	private static readonly FieldCodec<TaskStageInfo> _repeated_questStageConditionInfoList_codec = FieldCodec.ForMessage(98u, TaskStageInfo.Parser);

	private readonly RepeatedField<TaskStageInfo> questStageConditionInfoList_ = new RepeatedField<TaskStageInfo>();

	public static MessageParser<FUStFollowPartnerConfigDesc> Parser => _parser;

	public int ID
	{
		get
		{
			return iD_;
		}
		set
		{
			iD_ = value;
		}
	}

	public int LevelID
	{
		get
		{
			return levelID_;
		}
		set
		{
			levelID_ = value;
		}
	}

	public string OverlapBoxGUID
	{
		get
		{
			return overlapBoxGUID_;
		}
		set
		{
			overlapBoxGUID_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int AssociationUnitInfoID
	{
		get
		{
			return associationUnitInfoID_;
		}
		set
		{
			associationUnitInfoID_ = value;
		}
	}

	public string FollowPartnerDispDAPath
	{
		get
		{
			return followPartnerDispDAPath_;
		}
		set
		{
			followPartnerDispDAPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EFollowPartnerSpawnType FollowPartnerSpawnType
	{
		get
		{
			return followPartnerSpawnType_;
		}
		set
		{
			followPartnerSpawnType_ = value;
		}
	}

	public EGSYesNo JudgeConditionAfterPartnerAppear
	{
		get
		{
			return judgeConditionAfterPartnerAppear_;
		}
		set
		{
			judgeConditionAfterPartnerAppear_ = value;
		}
	}

	public int RespawnCheckDistance
	{
		get
		{
			return respawnCheckDistance_;
		}
		set
		{
			respawnCheckDistance_ = value;
		}
	}

	public int RespawnWaitTime
	{
		get
		{
			return respawnWaitTime_;
		}
		set
		{
			respawnWaitTime_ = value;
		}
	}

	public string ConfigDAPath
	{
		get
		{
			return configDAPath_;
		}
		set
		{
			configDAPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EConditionRelationType ConditionType
	{
		get
		{
			return conditionType_;
		}
		set
		{
			conditionType_ = value;
		}
	}

	public RepeatedField<TaskStageInfo> QuestStageConditionInfoList => questStageConditionInfoList_;

	public FUStFollowPartnerConfigDesc()
	{
	}

	public FUStFollowPartnerConfigDesc(FUStFollowPartnerConfigDesc other)
		: this()
	{
		iD_ = other.iD_;
		levelID_ = other.levelID_;
		overlapBoxGUID_ = other.overlapBoxGUID_;
		associationUnitInfoID_ = other.associationUnitInfoID_;
		followPartnerDispDAPath_ = other.followPartnerDispDAPath_;
		followPartnerSpawnType_ = other.followPartnerSpawnType_;
		judgeConditionAfterPartnerAppear_ = other.judgeConditionAfterPartnerAppear_;
		respawnCheckDistance_ = other.respawnCheckDistance_;
		respawnWaitTime_ = other.respawnWaitTime_;
		configDAPath_ = other.configDAPath_;
		conditionType_ = other.conditionType_;
		questStageConditionInfoList_ = other.questStageConditionInfoList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStFollowPartnerConfigDesc Clone()
	{
		return new FUStFollowPartnerConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStFollowPartnerConfigDesc);
	}

	public bool Equals(FUStFollowPartnerConfigDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ID != other.ID)
		{
			return false;
		}
		if (LevelID != other.LevelID)
		{
			return false;
		}
		if (OverlapBoxGUID != other.OverlapBoxGUID)
		{
			return false;
		}
		if (AssociationUnitInfoID != other.AssociationUnitInfoID)
		{
			return false;
		}
		if (FollowPartnerDispDAPath != other.FollowPartnerDispDAPath)
		{
			return false;
		}
		if (FollowPartnerSpawnType != other.FollowPartnerSpawnType)
		{
			return false;
		}
		if (JudgeConditionAfterPartnerAppear != other.JudgeConditionAfterPartnerAppear)
		{
			return false;
		}
		if (RespawnCheckDistance != other.RespawnCheckDistance)
		{
			return false;
		}
		if (RespawnWaitTime != other.RespawnWaitTime)
		{
			return false;
		}
		if (ConfigDAPath != other.ConfigDAPath)
		{
			return false;
		}
		if (ConditionType != other.ConditionType)
		{
			return false;
		}
		if (!questStageConditionInfoList_.Equals(other.questStageConditionInfoList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ID != 0)
		{
			num ^= ID.GetHashCode();
		}
		if (LevelID != 0)
		{
			num ^= LevelID.GetHashCode();
		}
		if (OverlapBoxGUID.Length != 0)
		{
			num ^= OverlapBoxGUID.GetHashCode();
		}
		if (AssociationUnitInfoID != 0)
		{
			num ^= AssociationUnitInfoID.GetHashCode();
		}
		if (FollowPartnerDispDAPath.Length != 0)
		{
			num ^= FollowPartnerDispDAPath.GetHashCode();
		}
		if (FollowPartnerSpawnType != EFollowPartnerSpawnType.BySceneItem)
		{
			num ^= FollowPartnerSpawnType.GetHashCode();
		}
		if (JudgeConditionAfterPartnerAppear != EGSYesNo.No)
		{
			num ^= JudgeConditionAfterPartnerAppear.GetHashCode();
		}
		if (RespawnCheckDistance != 0)
		{
			num ^= RespawnCheckDistance.GetHashCode();
		}
		if (RespawnWaitTime != 0)
		{
			num ^= RespawnWaitTime.GetHashCode();
		}
		if (ConfigDAPath.Length != 0)
		{
			num ^= ConfigDAPath.GetHashCode();
		}
		if (ConditionType != EConditionRelationType.LogicRelationAnd)
		{
			num ^= ConditionType.GetHashCode();
		}
		num ^= questStageConditionInfoList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ID);
		}
		if (LevelID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(LevelID);
		}
		if (OverlapBoxGUID.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(OverlapBoxGUID);
		}
		if (AssociationUnitInfoID != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(AssociationUnitInfoID);
		}
		if (FollowPartnerDispDAPath.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(FollowPartnerDispDAPath);
		}
		if (FollowPartnerSpawnType != EFollowPartnerSpawnType.BySceneItem)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)FollowPartnerSpawnType);
		}
		if (JudgeConditionAfterPartnerAppear != EGSYesNo.No)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)JudgeConditionAfterPartnerAppear);
		}
		if (RespawnCheckDistance != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(RespawnCheckDistance);
		}
		if (RespawnWaitTime != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(RespawnWaitTime);
		}
		if (ConfigDAPath.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(ConfigDAPath);
		}
		if (ConditionType != EConditionRelationType.LogicRelationAnd)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)ConditionType);
		}
		questStageConditionInfoList_.WriteTo(output, _repeated_questStageConditionInfoList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ID);
		}
		if (LevelID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelID);
		}
		if (OverlapBoxGUID.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(OverlapBoxGUID);
		}
		if (AssociationUnitInfoID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AssociationUnitInfoID);
		}
		if (FollowPartnerDispDAPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(FollowPartnerDispDAPath);
		}
		if (FollowPartnerSpawnType != EFollowPartnerSpawnType.BySceneItem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)FollowPartnerSpawnType);
		}
		if (JudgeConditionAfterPartnerAppear != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)JudgeConditionAfterPartnerAppear);
		}
		if (RespawnCheckDistance != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RespawnCheckDistance);
		}
		if (RespawnWaitTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RespawnWaitTime);
		}
		if (ConfigDAPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ConfigDAPath);
		}
		if (ConditionType != EConditionRelationType.LogicRelationAnd)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ConditionType);
		}
		num += questStageConditionInfoList_.CalculateSize(_repeated_questStageConditionInfoList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStFollowPartnerConfigDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.LevelID != 0)
			{
				LevelID = other.LevelID;
			}
			if (other.OverlapBoxGUID.Length != 0)
			{
				OverlapBoxGUID = other.OverlapBoxGUID;
			}
			if (other.AssociationUnitInfoID != 0)
			{
				AssociationUnitInfoID = other.AssociationUnitInfoID;
			}
			if (other.FollowPartnerDispDAPath.Length != 0)
			{
				FollowPartnerDispDAPath = other.FollowPartnerDispDAPath;
			}
			if (other.FollowPartnerSpawnType != EFollowPartnerSpawnType.BySceneItem)
			{
				FollowPartnerSpawnType = other.FollowPartnerSpawnType;
			}
			if (other.JudgeConditionAfterPartnerAppear != EGSYesNo.No)
			{
				JudgeConditionAfterPartnerAppear = other.JudgeConditionAfterPartnerAppear;
			}
			if (other.RespawnCheckDistance != 0)
			{
				RespawnCheckDistance = other.RespawnCheckDistance;
			}
			if (other.RespawnWaitTime != 0)
			{
				RespawnWaitTime = other.RespawnWaitTime;
			}
			if (other.ConfigDAPath.Length != 0)
			{
				ConfigDAPath = other.ConfigDAPath;
			}
			if (other.ConditionType != EConditionRelationType.LogicRelationAnd)
			{
				ConditionType = other.ConditionType;
			}
			questStageConditionInfoList_.Add(other.questStageConditionInfoList_);
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
				ID = input.ReadInt32();
				break;
			case 16u:
				LevelID = input.ReadInt32();
				break;
			case 26u:
				OverlapBoxGUID = input.ReadString();
				break;
			case 32u:
				AssociationUnitInfoID = input.ReadInt32();
				break;
			case 42u:
				FollowPartnerDispDAPath = input.ReadString();
				break;
			case 48u:
				FollowPartnerSpawnType = (EFollowPartnerSpawnType)input.ReadEnum();
				break;
			case 56u:
				JudgeConditionAfterPartnerAppear = (EGSYesNo)input.ReadEnum();
				break;
			case 64u:
				RespawnCheckDistance = input.ReadInt32();
				break;
			case 72u:
				RespawnWaitTime = input.ReadInt32();
				break;
			case 82u:
				ConfigDAPath = input.ReadString();
				break;
			case 88u:
				ConditionType = (EConditionRelationType)input.ReadEnum();
				break;
			case 98u:
				questStageConditionInfoList_.AddEntriesFrom(input, _repeated_questStageConditionInfoList_codec);
				break;
			}
		}
	}
}
