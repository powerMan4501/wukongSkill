using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class CalliopeCustom_IdleProcessAction : IMessage<CalliopeCustom_IdleProcessAction>, IMessage, IEquatable<CalliopeCustom_IdleProcessAction>, IDeepCloneable<CalliopeCustom_IdleProcessAction>
{
	private static readonly MessageParser<CalliopeCustom_IdleProcessAction> _parser = new MessageParser<CalliopeCustom_IdleProcessAction>(() => new CalliopeCustom_IdleProcessAction());

	private UnknownFieldSet _unknownFields;

	private int actionType_;

	private bool isTeleportToOtherLevel_;

	private int targetLevelId_;

	private string pointName_ = "";

	private string beforeTeleportMontage_ = "";

	private string afterTeleportMontage_ = "";

	private bool isSaveArchiveAfterTeleport_;

	private string archiveLabel_ = "";

	private int rebirthPointId_;

	private string unitGuid_ = "";

	private string dropItemManageGuid_ = "";

	private string aiConversationContentIdList_ = "";

	private int npcTeamId_;

	private int npcIdleAmIdx_;

	private int npcLeisureAnimIndex_;

	private int npcInteractGroupId_;

	private int npcShowState_;

	private static readonly FieldCodec<CalliopeCustom_TriggerUnitBattleConfig> _repeated_triggerUnitBattleConfigs_codec = FieldCodec.ForMessage(146u, CalliopeCustom_TriggerUnitBattleConfig.Parser);

	private readonly RepeatedField<CalliopeCustom_TriggerUnitBattleConfig> triggerUnitBattleConfigs_ = new RepeatedField<CalliopeCustom_TriggerUnitBattleConfig>();

	private string associationUnitInfoConfigId_ = "";

	private int associationUnitSpawnInfoDelayExecuteTime_;

	private int associationUnitSpawnInfoSpawnType_;

	private int associationUnitSpawnInfoActiveType_;

	private string associationUnitActiveInfoTargetGuid_ = "";

	private int associationUnitActiveInfoOnfightSkillid_;

	private int npcActionSkillId_;

	private string targetActorGuid_ = "";

	private int moveAiType_;

	private int moveSpeedType_;

	private float moveAcceptableRadius_;

	private int npcMoveType_;

	private bool needSwitchSpeedByDistanceToPlayer_;

	private float maxDistanceSprint_;

	private float maxDistanceRun_;

	private float maxDistanceJog_;

	private float distanceBuffer_;

	private int weakPerformConfigId_;

	private string followPartnerConfigId_ = "";

	private string gameplayTag_ = "";

	private bool isDontResetPlayerState_;

	private int loadingScreenType_;

	private int extendId_;

	private bool isBlockRebirthpoint_;

	private static readonly FieldCodec<int> _repeated_teleportLoadingTips_codec = FieldCodec.ForInt32(346u);

	private readonly RepeatedField<int> teleportLoadingTips_ = new RepeatedField<int>();

	public static MessageParser<CalliopeCustom_IdleProcessAction> Parser => _parser;

	public int ActionType
	{
		get
		{
			return actionType_;
		}
		set
		{
			actionType_ = value;
		}
	}

	public bool IsTeleportToOtherLevel
	{
		get
		{
			return isTeleportToOtherLevel_;
		}
		set
		{
			isTeleportToOtherLevel_ = value;
		}
	}

	public int TargetLevelId
	{
		get
		{
			return targetLevelId_;
		}
		set
		{
			targetLevelId_ = value;
		}
	}

	public string PointName
	{
		get
		{
			return pointName_;
		}
		set
		{
			pointName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string BeforeTeleportMontage
	{
		get
		{
			return beforeTeleportMontage_;
		}
		set
		{
			beforeTeleportMontage_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string AfterTeleportMontage
	{
		get
		{
			return afterTeleportMontage_;
		}
		set
		{
			afterTeleportMontage_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool IsSaveArchiveAfterTeleport
	{
		get
		{
			return isSaveArchiveAfterTeleport_;
		}
		set
		{
			isSaveArchiveAfterTeleport_ = value;
		}
	}

	public string ArchiveLabel
	{
		get
		{
			return archiveLabel_;
		}
		set
		{
			archiveLabel_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int RebirthPointId
	{
		get
		{
			return rebirthPointId_;
		}
		set
		{
			rebirthPointId_ = value;
		}
	}

	public string UnitGuid
	{
		get
		{
			return unitGuid_;
		}
		set
		{
			unitGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DropItemManageGuid
	{
		get
		{
			return dropItemManageGuid_;
		}
		set
		{
			dropItemManageGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string AiConversationContentIdList
	{
		get
		{
			return aiConversationContentIdList_;
		}
		set
		{
			aiConversationContentIdList_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int NpcTeamId
	{
		get
		{
			return npcTeamId_;
		}
		set
		{
			npcTeamId_ = value;
		}
	}

	public int NpcIdleAmIdx
	{
		get
		{
			return npcIdleAmIdx_;
		}
		set
		{
			npcIdleAmIdx_ = value;
		}
	}

	public int NpcLeisureAnimIndex
	{
		get
		{
			return npcLeisureAnimIndex_;
		}
		set
		{
			npcLeisureAnimIndex_ = value;
		}
	}

	public int NpcInteractGroupId
	{
		get
		{
			return npcInteractGroupId_;
		}
		set
		{
			npcInteractGroupId_ = value;
		}
	}

	public int NpcShowState
	{
		get
		{
			return npcShowState_;
		}
		set
		{
			npcShowState_ = value;
		}
	}

	public RepeatedField<CalliopeCustom_TriggerUnitBattleConfig> TriggerUnitBattleConfigs => triggerUnitBattleConfigs_;

	public string AssociationUnitInfoConfigId
	{
		get
		{
			return associationUnitInfoConfigId_;
		}
		set
		{
			associationUnitInfoConfigId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int AssociationUnitSpawnInfoDelayExecuteTime
	{
		get
		{
			return associationUnitSpawnInfoDelayExecuteTime_;
		}
		set
		{
			associationUnitSpawnInfoDelayExecuteTime_ = value;
		}
	}

	public int AssociationUnitSpawnInfoSpawnType
	{
		get
		{
			return associationUnitSpawnInfoSpawnType_;
		}
		set
		{
			associationUnitSpawnInfoSpawnType_ = value;
		}
	}

	public int AssociationUnitSpawnInfoActiveType
	{
		get
		{
			return associationUnitSpawnInfoActiveType_;
		}
		set
		{
			associationUnitSpawnInfoActiveType_ = value;
		}
	}

	public string AssociationUnitActiveInfoTargetGuid
	{
		get
		{
			return associationUnitActiveInfoTargetGuid_;
		}
		set
		{
			associationUnitActiveInfoTargetGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int AssociationUnitActiveInfoOnfightSkillid
	{
		get
		{
			return associationUnitActiveInfoOnfightSkillid_;
		}
		set
		{
			associationUnitActiveInfoOnfightSkillid_ = value;
		}
	}

	public int NpcActionSkillId
	{
		get
		{
			return npcActionSkillId_;
		}
		set
		{
			npcActionSkillId_ = value;
		}
	}

	public string TargetActorGuid
	{
		get
		{
			return targetActorGuid_;
		}
		set
		{
			targetActorGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int MoveAiType
	{
		get
		{
			return moveAiType_;
		}
		set
		{
			moveAiType_ = value;
		}
	}

	public int MoveSpeedType
	{
		get
		{
			return moveSpeedType_;
		}
		set
		{
			moveSpeedType_ = value;
		}
	}

	public float MoveAcceptableRadius
	{
		get
		{
			return moveAcceptableRadius_;
		}
		set
		{
			moveAcceptableRadius_ = value;
		}
	}

	public int NpcMoveType
	{
		get
		{
			return npcMoveType_;
		}
		set
		{
			npcMoveType_ = value;
		}
	}

	public bool NeedSwitchSpeedByDistanceToPlayer
	{
		get
		{
			return needSwitchSpeedByDistanceToPlayer_;
		}
		set
		{
			needSwitchSpeedByDistanceToPlayer_ = value;
		}
	}

	public float MaxDistanceSprint
	{
		get
		{
			return maxDistanceSprint_;
		}
		set
		{
			maxDistanceSprint_ = value;
		}
	}

	public float MaxDistanceRun
	{
		get
		{
			return maxDistanceRun_;
		}
		set
		{
			maxDistanceRun_ = value;
		}
	}

	public float MaxDistanceJog
	{
		get
		{
			return maxDistanceJog_;
		}
		set
		{
			maxDistanceJog_ = value;
		}
	}

	public float DistanceBuffer
	{
		get
		{
			return distanceBuffer_;
		}
		set
		{
			distanceBuffer_ = value;
		}
	}

	public int WeakPerformConfigId
	{
		get
		{
			return weakPerformConfigId_;
		}
		set
		{
			weakPerformConfigId_ = value;
		}
	}

	public string FollowPartnerConfigId
	{
		get
		{
			return followPartnerConfigId_;
		}
		set
		{
			followPartnerConfigId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string GameplayTag
	{
		get
		{
			return gameplayTag_;
		}
		set
		{
			gameplayTag_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool IsDontResetPlayerState
	{
		get
		{
			return isDontResetPlayerState_;
		}
		set
		{
			isDontResetPlayerState_ = value;
		}
	}

	public int LoadingScreenType
	{
		get
		{
			return loadingScreenType_;
		}
		set
		{
			loadingScreenType_ = value;
		}
	}

	public int ExtendId
	{
		get
		{
			return extendId_;
		}
		set
		{
			extendId_ = value;
		}
	}

	public bool IsBlockRebirthpoint
	{
		get
		{
			return isBlockRebirthpoint_;
		}
		set
		{
			isBlockRebirthpoint_ = value;
		}
	}

	public RepeatedField<int> TeleportLoadingTips => teleportLoadingTips_;

	public CalliopeCustom_IdleProcessAction()
	{
	}

	public CalliopeCustom_IdleProcessAction(CalliopeCustom_IdleProcessAction other)
		: this()
	{
		actionType_ = other.actionType_;
		isTeleportToOtherLevel_ = other.isTeleportToOtherLevel_;
		targetLevelId_ = other.targetLevelId_;
		pointName_ = other.pointName_;
		beforeTeleportMontage_ = other.beforeTeleportMontage_;
		afterTeleportMontage_ = other.afterTeleportMontage_;
		isSaveArchiveAfterTeleport_ = other.isSaveArchiveAfterTeleport_;
		archiveLabel_ = other.archiveLabel_;
		rebirthPointId_ = other.rebirthPointId_;
		unitGuid_ = other.unitGuid_;
		dropItemManageGuid_ = other.dropItemManageGuid_;
		aiConversationContentIdList_ = other.aiConversationContentIdList_;
		npcTeamId_ = other.npcTeamId_;
		npcIdleAmIdx_ = other.npcIdleAmIdx_;
		npcLeisureAnimIndex_ = other.npcLeisureAnimIndex_;
		npcInteractGroupId_ = other.npcInteractGroupId_;
		npcShowState_ = other.npcShowState_;
		triggerUnitBattleConfigs_ = other.triggerUnitBattleConfigs_.Clone();
		associationUnitInfoConfigId_ = other.associationUnitInfoConfigId_;
		associationUnitSpawnInfoDelayExecuteTime_ = other.associationUnitSpawnInfoDelayExecuteTime_;
		associationUnitSpawnInfoSpawnType_ = other.associationUnitSpawnInfoSpawnType_;
		associationUnitSpawnInfoActiveType_ = other.associationUnitSpawnInfoActiveType_;
		associationUnitActiveInfoTargetGuid_ = other.associationUnitActiveInfoTargetGuid_;
		associationUnitActiveInfoOnfightSkillid_ = other.associationUnitActiveInfoOnfightSkillid_;
		npcActionSkillId_ = other.npcActionSkillId_;
		targetActorGuid_ = other.targetActorGuid_;
		moveAiType_ = other.moveAiType_;
		moveSpeedType_ = other.moveSpeedType_;
		moveAcceptableRadius_ = other.moveAcceptableRadius_;
		npcMoveType_ = other.npcMoveType_;
		needSwitchSpeedByDistanceToPlayer_ = other.needSwitchSpeedByDistanceToPlayer_;
		maxDistanceSprint_ = other.maxDistanceSprint_;
		maxDistanceRun_ = other.maxDistanceRun_;
		maxDistanceJog_ = other.maxDistanceJog_;
		distanceBuffer_ = other.distanceBuffer_;
		weakPerformConfigId_ = other.weakPerformConfigId_;
		followPartnerConfigId_ = other.followPartnerConfigId_;
		gameplayTag_ = other.gameplayTag_;
		isDontResetPlayerState_ = other.isDontResetPlayerState_;
		loadingScreenType_ = other.loadingScreenType_;
		extendId_ = other.extendId_;
		isBlockRebirthpoint_ = other.isBlockRebirthpoint_;
		teleportLoadingTips_ = other.teleportLoadingTips_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_IdleProcessAction Clone()
	{
		return new CalliopeCustom_IdleProcessAction(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_IdleProcessAction);
	}

	public bool Equals(CalliopeCustom_IdleProcessAction other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ActionType != other.ActionType)
		{
			return false;
		}
		if (IsTeleportToOtherLevel != other.IsTeleportToOtherLevel)
		{
			return false;
		}
		if (TargetLevelId != other.TargetLevelId)
		{
			return false;
		}
		if (PointName != other.PointName)
		{
			return false;
		}
		if (BeforeTeleportMontage != other.BeforeTeleportMontage)
		{
			return false;
		}
		if (AfterTeleportMontage != other.AfterTeleportMontage)
		{
			return false;
		}
		if (IsSaveArchiveAfterTeleport != other.IsSaveArchiveAfterTeleport)
		{
			return false;
		}
		if (ArchiveLabel != other.ArchiveLabel)
		{
			return false;
		}
		if (RebirthPointId != other.RebirthPointId)
		{
			return false;
		}
		if (UnitGuid != other.UnitGuid)
		{
			return false;
		}
		if (DropItemManageGuid != other.DropItemManageGuid)
		{
			return false;
		}
		if (AiConversationContentIdList != other.AiConversationContentIdList)
		{
			return false;
		}
		if (NpcTeamId != other.NpcTeamId)
		{
			return false;
		}
		if (NpcIdleAmIdx != other.NpcIdleAmIdx)
		{
			return false;
		}
		if (NpcLeisureAnimIndex != other.NpcLeisureAnimIndex)
		{
			return false;
		}
		if (NpcInteractGroupId != other.NpcInteractGroupId)
		{
			return false;
		}
		if (NpcShowState != other.NpcShowState)
		{
			return false;
		}
		if (!triggerUnitBattleConfigs_.Equals(other.triggerUnitBattleConfigs_))
		{
			return false;
		}
		if (AssociationUnitInfoConfigId != other.AssociationUnitInfoConfigId)
		{
			return false;
		}
		if (AssociationUnitSpawnInfoDelayExecuteTime != other.AssociationUnitSpawnInfoDelayExecuteTime)
		{
			return false;
		}
		if (AssociationUnitSpawnInfoSpawnType != other.AssociationUnitSpawnInfoSpawnType)
		{
			return false;
		}
		if (AssociationUnitSpawnInfoActiveType != other.AssociationUnitSpawnInfoActiveType)
		{
			return false;
		}
		if (AssociationUnitActiveInfoTargetGuid != other.AssociationUnitActiveInfoTargetGuid)
		{
			return false;
		}
		if (AssociationUnitActiveInfoOnfightSkillid != other.AssociationUnitActiveInfoOnfightSkillid)
		{
			return false;
		}
		if (NpcActionSkillId != other.NpcActionSkillId)
		{
			return false;
		}
		if (TargetActorGuid != other.TargetActorGuid)
		{
			return false;
		}
		if (MoveAiType != other.MoveAiType)
		{
			return false;
		}
		if (MoveSpeedType != other.MoveSpeedType)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MoveAcceptableRadius, other.MoveAcceptableRadius))
		{
			return false;
		}
		if (NpcMoveType != other.NpcMoveType)
		{
			return false;
		}
		if (NeedSwitchSpeedByDistanceToPlayer != other.NeedSwitchSpeedByDistanceToPlayer)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MaxDistanceSprint, other.MaxDistanceSprint))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MaxDistanceRun, other.MaxDistanceRun))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MaxDistanceJog, other.MaxDistanceJog))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DistanceBuffer, other.DistanceBuffer))
		{
			return false;
		}
		if (WeakPerformConfigId != other.WeakPerformConfigId)
		{
			return false;
		}
		if (FollowPartnerConfigId != other.FollowPartnerConfigId)
		{
			return false;
		}
		if (GameplayTag != other.GameplayTag)
		{
			return false;
		}
		if (IsDontResetPlayerState != other.IsDontResetPlayerState)
		{
			return false;
		}
		if (LoadingScreenType != other.LoadingScreenType)
		{
			return false;
		}
		if (ExtendId != other.ExtendId)
		{
			return false;
		}
		if (IsBlockRebirthpoint != other.IsBlockRebirthpoint)
		{
			return false;
		}
		if (!teleportLoadingTips_.Equals(other.teleportLoadingTips_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ActionType != 0)
		{
			num ^= ActionType.GetHashCode();
		}
		if (IsTeleportToOtherLevel)
		{
			num ^= IsTeleportToOtherLevel.GetHashCode();
		}
		if (TargetLevelId != 0)
		{
			num ^= TargetLevelId.GetHashCode();
		}
		if (PointName.Length != 0)
		{
			num ^= PointName.GetHashCode();
		}
		if (BeforeTeleportMontage.Length != 0)
		{
			num ^= BeforeTeleportMontage.GetHashCode();
		}
		if (AfterTeleportMontage.Length != 0)
		{
			num ^= AfterTeleportMontage.GetHashCode();
		}
		if (IsSaveArchiveAfterTeleport)
		{
			num ^= IsSaveArchiveAfterTeleport.GetHashCode();
		}
		if (ArchiveLabel.Length != 0)
		{
			num ^= ArchiveLabel.GetHashCode();
		}
		if (RebirthPointId != 0)
		{
			num ^= RebirthPointId.GetHashCode();
		}
		if (UnitGuid.Length != 0)
		{
			num ^= UnitGuid.GetHashCode();
		}
		if (DropItemManageGuid.Length != 0)
		{
			num ^= DropItemManageGuid.GetHashCode();
		}
		if (AiConversationContentIdList.Length != 0)
		{
			num ^= AiConversationContentIdList.GetHashCode();
		}
		if (NpcTeamId != 0)
		{
			num ^= NpcTeamId.GetHashCode();
		}
		if (NpcIdleAmIdx != 0)
		{
			num ^= NpcIdleAmIdx.GetHashCode();
		}
		if (NpcLeisureAnimIndex != 0)
		{
			num ^= NpcLeisureAnimIndex.GetHashCode();
		}
		if (NpcInteractGroupId != 0)
		{
			num ^= NpcInteractGroupId.GetHashCode();
		}
		if (NpcShowState != 0)
		{
			num ^= NpcShowState.GetHashCode();
		}
		num ^= triggerUnitBattleConfigs_.GetHashCode();
		if (AssociationUnitInfoConfigId.Length != 0)
		{
			num ^= AssociationUnitInfoConfigId.GetHashCode();
		}
		if (AssociationUnitSpawnInfoDelayExecuteTime != 0)
		{
			num ^= AssociationUnitSpawnInfoDelayExecuteTime.GetHashCode();
		}
		if (AssociationUnitSpawnInfoSpawnType != 0)
		{
			num ^= AssociationUnitSpawnInfoSpawnType.GetHashCode();
		}
		if (AssociationUnitSpawnInfoActiveType != 0)
		{
			num ^= AssociationUnitSpawnInfoActiveType.GetHashCode();
		}
		if (AssociationUnitActiveInfoTargetGuid.Length != 0)
		{
			num ^= AssociationUnitActiveInfoTargetGuid.GetHashCode();
		}
		if (AssociationUnitActiveInfoOnfightSkillid != 0)
		{
			num ^= AssociationUnitActiveInfoOnfightSkillid.GetHashCode();
		}
		if (NpcActionSkillId != 0)
		{
			num ^= NpcActionSkillId.GetHashCode();
		}
		if (TargetActorGuid.Length != 0)
		{
			num ^= TargetActorGuid.GetHashCode();
		}
		if (MoveAiType != 0)
		{
			num ^= MoveAiType.GetHashCode();
		}
		if (MoveSpeedType != 0)
		{
			num ^= MoveSpeedType.GetHashCode();
		}
		if (MoveAcceptableRadius != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MoveAcceptableRadius);
		}
		if (NpcMoveType != 0)
		{
			num ^= NpcMoveType.GetHashCode();
		}
		if (NeedSwitchSpeedByDistanceToPlayer)
		{
			num ^= NeedSwitchSpeedByDistanceToPlayer.GetHashCode();
		}
		if (MaxDistanceSprint != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MaxDistanceSprint);
		}
		if (MaxDistanceRun != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MaxDistanceRun);
		}
		if (MaxDistanceJog != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MaxDistanceJog);
		}
		if (DistanceBuffer != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DistanceBuffer);
		}
		if (WeakPerformConfigId != 0)
		{
			num ^= WeakPerformConfigId.GetHashCode();
		}
		if (FollowPartnerConfigId.Length != 0)
		{
			num ^= FollowPartnerConfigId.GetHashCode();
		}
		if (GameplayTag.Length != 0)
		{
			num ^= GameplayTag.GetHashCode();
		}
		if (IsDontResetPlayerState)
		{
			num ^= IsDontResetPlayerState.GetHashCode();
		}
		if (LoadingScreenType != 0)
		{
			num ^= LoadingScreenType.GetHashCode();
		}
		if (ExtendId != 0)
		{
			num ^= ExtendId.GetHashCode();
		}
		if (IsBlockRebirthpoint)
		{
			num ^= IsBlockRebirthpoint.GetHashCode();
		}
		num ^= teleportLoadingTips_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ActionType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ActionType);
		}
		if (IsTeleportToOtherLevel)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsTeleportToOtherLevel);
		}
		if (TargetLevelId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(TargetLevelId);
		}
		if (PointName.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(PointName);
		}
		if (BeforeTeleportMontage.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(BeforeTeleportMontage);
		}
		if (AfterTeleportMontage.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(AfterTeleportMontage);
		}
		if (IsSaveArchiveAfterTeleport)
		{
			output.WriteRawTag(56);
			output.WriteBool(IsSaveArchiveAfterTeleport);
		}
		if (ArchiveLabel.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(ArchiveLabel);
		}
		if (RebirthPointId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(RebirthPointId);
		}
		if (UnitGuid.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(UnitGuid);
		}
		if (DropItemManageGuid.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(DropItemManageGuid);
		}
		if (AiConversationContentIdList.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(AiConversationContentIdList);
		}
		if (NpcTeamId != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(NpcTeamId);
		}
		if (NpcIdleAmIdx != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(NpcIdleAmIdx);
		}
		if (NpcLeisureAnimIndex != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(NpcLeisureAnimIndex);
		}
		if (NpcInteractGroupId != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(NpcInteractGroupId);
		}
		if (NpcShowState != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(NpcShowState);
		}
		triggerUnitBattleConfigs_.WriteTo(output, _repeated_triggerUnitBattleConfigs_codec);
		if (AssociationUnitInfoConfigId.Length != 0)
		{
			output.WriteRawTag(154, 1);
			output.WriteString(AssociationUnitInfoConfigId);
		}
		if (AssociationUnitSpawnInfoDelayExecuteTime != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(AssociationUnitSpawnInfoDelayExecuteTime);
		}
		if (AssociationUnitSpawnInfoSpawnType != 0)
		{
			output.WriteRawTag(168, 1);
			output.WriteInt32(AssociationUnitSpawnInfoSpawnType);
		}
		if (AssociationUnitSpawnInfoActiveType != 0)
		{
			output.WriteRawTag(176, 1);
			output.WriteInt32(AssociationUnitSpawnInfoActiveType);
		}
		if (AssociationUnitActiveInfoTargetGuid.Length != 0)
		{
			output.WriteRawTag(186, 1);
			output.WriteString(AssociationUnitActiveInfoTargetGuid);
		}
		if (AssociationUnitActiveInfoOnfightSkillid != 0)
		{
			output.WriteRawTag(192, 1);
			output.WriteInt32(AssociationUnitActiveInfoOnfightSkillid);
		}
		if (NpcActionSkillId != 0)
		{
			output.WriteRawTag(200, 1);
			output.WriteInt32(NpcActionSkillId);
		}
		if (TargetActorGuid.Length != 0)
		{
			output.WriteRawTag(210, 1);
			output.WriteString(TargetActorGuid);
		}
		if (MoveAiType != 0)
		{
			output.WriteRawTag(216, 1);
			output.WriteInt32(MoveAiType);
		}
		if (MoveSpeedType != 0)
		{
			output.WriteRawTag(224, 1);
			output.WriteInt32(MoveSpeedType);
		}
		if (MoveAcceptableRadius != 0f)
		{
			output.WriteRawTag(237, 1);
			output.WriteFloat(MoveAcceptableRadius);
		}
		if (NpcMoveType != 0)
		{
			output.WriteRawTag(240, 1);
			output.WriteInt32(NpcMoveType);
		}
		if (NeedSwitchSpeedByDistanceToPlayer)
		{
			output.WriteRawTag(248, 1);
			output.WriteBool(NeedSwitchSpeedByDistanceToPlayer);
		}
		if (MaxDistanceSprint != 0f)
		{
			output.WriteRawTag(133, 2);
			output.WriteFloat(MaxDistanceSprint);
		}
		if (MaxDistanceRun != 0f)
		{
			output.WriteRawTag(141, 2);
			output.WriteFloat(MaxDistanceRun);
		}
		if (MaxDistanceJog != 0f)
		{
			output.WriteRawTag(149, 2);
			output.WriteFloat(MaxDistanceJog);
		}
		if (DistanceBuffer != 0f)
		{
			output.WriteRawTag(157, 2);
			output.WriteFloat(DistanceBuffer);
		}
		if (WeakPerformConfigId != 0)
		{
			output.WriteRawTag(160, 2);
			output.WriteInt32(WeakPerformConfigId);
		}
		if (FollowPartnerConfigId.Length != 0)
		{
			output.WriteRawTag(170, 2);
			output.WriteString(FollowPartnerConfigId);
		}
		if (GameplayTag.Length != 0)
		{
			output.WriteRawTag(178, 2);
			output.WriteString(GameplayTag);
		}
		if (IsDontResetPlayerState)
		{
			output.WriteRawTag(184, 2);
			output.WriteBool(IsDontResetPlayerState);
		}
		if (LoadingScreenType != 0)
		{
			output.WriteRawTag(192, 2);
			output.WriteInt32(LoadingScreenType);
		}
		if (ExtendId != 0)
		{
			output.WriteRawTag(200, 2);
			output.WriteInt32(ExtendId);
		}
		if (IsBlockRebirthpoint)
		{
			output.WriteRawTag(208, 2);
			output.WriteBool(IsBlockRebirthpoint);
		}
		teleportLoadingTips_.WriteTo(output, _repeated_teleportLoadingTips_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ActionType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ActionType);
		}
		if (IsTeleportToOtherLevel)
		{
			num += 2;
		}
		if (TargetLevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetLevelId);
		}
		if (PointName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PointName);
		}
		if (BeforeTeleportMontage.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BeforeTeleportMontage);
		}
		if (AfterTeleportMontage.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AfterTeleportMontage);
		}
		if (IsSaveArchiveAfterTeleport)
		{
			num += 2;
		}
		if (ArchiveLabel.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ArchiveLabel);
		}
		if (RebirthPointId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RebirthPointId);
		}
		if (UnitGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UnitGuid);
		}
		if (DropItemManageGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DropItemManageGuid);
		}
		if (AiConversationContentIdList.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AiConversationContentIdList);
		}
		if (NpcTeamId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NpcTeamId);
		}
		if (NpcIdleAmIdx != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NpcIdleAmIdx);
		}
		if (NpcLeisureAnimIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NpcLeisureAnimIndex);
		}
		if (NpcInteractGroupId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(NpcInteractGroupId);
		}
		if (NpcShowState != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(NpcShowState);
		}
		num += triggerUnitBattleConfigs_.CalculateSize(_repeated_triggerUnitBattleConfigs_codec);
		if (AssociationUnitInfoConfigId.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(AssociationUnitInfoConfigId);
		}
		if (AssociationUnitSpawnInfoDelayExecuteTime != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(AssociationUnitSpawnInfoDelayExecuteTime);
		}
		if (AssociationUnitSpawnInfoSpawnType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(AssociationUnitSpawnInfoSpawnType);
		}
		if (AssociationUnitSpawnInfoActiveType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(AssociationUnitSpawnInfoActiveType);
		}
		if (AssociationUnitActiveInfoTargetGuid.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(AssociationUnitActiveInfoTargetGuid);
		}
		if (AssociationUnitActiveInfoOnfightSkillid != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(AssociationUnitActiveInfoOnfightSkillid);
		}
		if (NpcActionSkillId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(NpcActionSkillId);
		}
		if (TargetActorGuid.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(TargetActorGuid);
		}
		if (MoveAiType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MoveAiType);
		}
		if (MoveSpeedType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MoveSpeedType);
		}
		if (MoveAcceptableRadius != 0f)
		{
			num += 6;
		}
		if (NpcMoveType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(NpcMoveType);
		}
		if (NeedSwitchSpeedByDistanceToPlayer)
		{
			num += 3;
		}
		if (MaxDistanceSprint != 0f)
		{
			num += 6;
		}
		if (MaxDistanceRun != 0f)
		{
			num += 6;
		}
		if (MaxDistanceJog != 0f)
		{
			num += 6;
		}
		if (DistanceBuffer != 0f)
		{
			num += 6;
		}
		if (WeakPerformConfigId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(WeakPerformConfigId);
		}
		if (FollowPartnerConfigId.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(FollowPartnerConfigId);
		}
		if (GameplayTag.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(GameplayTag);
		}
		if (IsDontResetPlayerState)
		{
			num += 3;
		}
		if (LoadingScreenType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(LoadingScreenType);
		}
		if (ExtendId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ExtendId);
		}
		if (IsBlockRebirthpoint)
		{
			num += 3;
		}
		num += teleportLoadingTips_.CalculateSize(_repeated_teleportLoadingTips_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_IdleProcessAction other)
	{
		if (other != null)
		{
			if (other.ActionType != 0)
			{
				ActionType = other.ActionType;
			}
			if (other.IsTeleportToOtherLevel)
			{
				IsTeleportToOtherLevel = other.IsTeleportToOtherLevel;
			}
			if (other.TargetLevelId != 0)
			{
				TargetLevelId = other.TargetLevelId;
			}
			if (other.PointName.Length != 0)
			{
				PointName = other.PointName;
			}
			if (other.BeforeTeleportMontage.Length != 0)
			{
				BeforeTeleportMontage = other.BeforeTeleportMontage;
			}
			if (other.AfterTeleportMontage.Length != 0)
			{
				AfterTeleportMontage = other.AfterTeleportMontage;
			}
			if (other.IsSaveArchiveAfterTeleport)
			{
				IsSaveArchiveAfterTeleport = other.IsSaveArchiveAfterTeleport;
			}
			if (other.ArchiveLabel.Length != 0)
			{
				ArchiveLabel = other.ArchiveLabel;
			}
			if (other.RebirthPointId != 0)
			{
				RebirthPointId = other.RebirthPointId;
			}
			if (other.UnitGuid.Length != 0)
			{
				UnitGuid = other.UnitGuid;
			}
			if (other.DropItemManageGuid.Length != 0)
			{
				DropItemManageGuid = other.DropItemManageGuid;
			}
			if (other.AiConversationContentIdList.Length != 0)
			{
				AiConversationContentIdList = other.AiConversationContentIdList;
			}
			if (other.NpcTeamId != 0)
			{
				NpcTeamId = other.NpcTeamId;
			}
			if (other.NpcIdleAmIdx != 0)
			{
				NpcIdleAmIdx = other.NpcIdleAmIdx;
			}
			if (other.NpcLeisureAnimIndex != 0)
			{
				NpcLeisureAnimIndex = other.NpcLeisureAnimIndex;
			}
			if (other.NpcInteractGroupId != 0)
			{
				NpcInteractGroupId = other.NpcInteractGroupId;
			}
			if (other.NpcShowState != 0)
			{
				NpcShowState = other.NpcShowState;
			}
			triggerUnitBattleConfigs_.Add(other.triggerUnitBattleConfigs_);
			if (other.AssociationUnitInfoConfigId.Length != 0)
			{
				AssociationUnitInfoConfigId = other.AssociationUnitInfoConfigId;
			}
			if (other.AssociationUnitSpawnInfoDelayExecuteTime != 0)
			{
				AssociationUnitSpawnInfoDelayExecuteTime = other.AssociationUnitSpawnInfoDelayExecuteTime;
			}
			if (other.AssociationUnitSpawnInfoSpawnType != 0)
			{
				AssociationUnitSpawnInfoSpawnType = other.AssociationUnitSpawnInfoSpawnType;
			}
			if (other.AssociationUnitSpawnInfoActiveType != 0)
			{
				AssociationUnitSpawnInfoActiveType = other.AssociationUnitSpawnInfoActiveType;
			}
			if (other.AssociationUnitActiveInfoTargetGuid.Length != 0)
			{
				AssociationUnitActiveInfoTargetGuid = other.AssociationUnitActiveInfoTargetGuid;
			}
			if (other.AssociationUnitActiveInfoOnfightSkillid != 0)
			{
				AssociationUnitActiveInfoOnfightSkillid = other.AssociationUnitActiveInfoOnfightSkillid;
			}
			if (other.NpcActionSkillId != 0)
			{
				NpcActionSkillId = other.NpcActionSkillId;
			}
			if (other.TargetActorGuid.Length != 0)
			{
				TargetActorGuid = other.TargetActorGuid;
			}
			if (other.MoveAiType != 0)
			{
				MoveAiType = other.MoveAiType;
			}
			if (other.MoveSpeedType != 0)
			{
				MoveSpeedType = other.MoveSpeedType;
			}
			if (other.MoveAcceptableRadius != 0f)
			{
				MoveAcceptableRadius = other.MoveAcceptableRadius;
			}
			if (other.NpcMoveType != 0)
			{
				NpcMoveType = other.NpcMoveType;
			}
			if (other.NeedSwitchSpeedByDistanceToPlayer)
			{
				NeedSwitchSpeedByDistanceToPlayer = other.NeedSwitchSpeedByDistanceToPlayer;
			}
			if (other.MaxDistanceSprint != 0f)
			{
				MaxDistanceSprint = other.MaxDistanceSprint;
			}
			if (other.MaxDistanceRun != 0f)
			{
				MaxDistanceRun = other.MaxDistanceRun;
			}
			if (other.MaxDistanceJog != 0f)
			{
				MaxDistanceJog = other.MaxDistanceJog;
			}
			if (other.DistanceBuffer != 0f)
			{
				DistanceBuffer = other.DistanceBuffer;
			}
			if (other.WeakPerformConfigId != 0)
			{
				WeakPerformConfigId = other.WeakPerformConfigId;
			}
			if (other.FollowPartnerConfigId.Length != 0)
			{
				FollowPartnerConfigId = other.FollowPartnerConfigId;
			}
			if (other.GameplayTag.Length != 0)
			{
				GameplayTag = other.GameplayTag;
			}
			if (other.IsDontResetPlayerState)
			{
				IsDontResetPlayerState = other.IsDontResetPlayerState;
			}
			if (other.LoadingScreenType != 0)
			{
				LoadingScreenType = other.LoadingScreenType;
			}
			if (other.ExtendId != 0)
			{
				ExtendId = other.ExtendId;
			}
			if (other.IsBlockRebirthpoint)
			{
				IsBlockRebirthpoint = other.IsBlockRebirthpoint;
			}
			teleportLoadingTips_.Add(other.teleportLoadingTips_);
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
				ActionType = input.ReadInt32();
				break;
			case 16u:
				IsTeleportToOtherLevel = input.ReadBool();
				break;
			case 24u:
				TargetLevelId = input.ReadInt32();
				break;
			case 34u:
				PointName = input.ReadString();
				break;
			case 42u:
				BeforeTeleportMontage = input.ReadString();
				break;
			case 50u:
				AfterTeleportMontage = input.ReadString();
				break;
			case 56u:
				IsSaveArchiveAfterTeleport = input.ReadBool();
				break;
			case 66u:
				ArchiveLabel = input.ReadString();
				break;
			case 72u:
				RebirthPointId = input.ReadInt32();
				break;
			case 82u:
				UnitGuid = input.ReadString();
				break;
			case 90u:
				DropItemManageGuid = input.ReadString();
				break;
			case 98u:
				AiConversationContentIdList = input.ReadString();
				break;
			case 104u:
				NpcTeamId = input.ReadInt32();
				break;
			case 112u:
				NpcIdleAmIdx = input.ReadInt32();
				break;
			case 120u:
				NpcLeisureAnimIndex = input.ReadInt32();
				break;
			case 128u:
				NpcInteractGroupId = input.ReadInt32();
				break;
			case 136u:
				NpcShowState = input.ReadInt32();
				break;
			case 146u:
				triggerUnitBattleConfigs_.AddEntriesFrom(input, _repeated_triggerUnitBattleConfigs_codec);
				break;
			case 154u:
				AssociationUnitInfoConfigId = input.ReadString();
				break;
			case 160u:
				AssociationUnitSpawnInfoDelayExecuteTime = input.ReadInt32();
				break;
			case 168u:
				AssociationUnitSpawnInfoSpawnType = input.ReadInt32();
				break;
			case 176u:
				AssociationUnitSpawnInfoActiveType = input.ReadInt32();
				break;
			case 186u:
				AssociationUnitActiveInfoTargetGuid = input.ReadString();
				break;
			case 192u:
				AssociationUnitActiveInfoOnfightSkillid = input.ReadInt32();
				break;
			case 200u:
				NpcActionSkillId = input.ReadInt32();
				break;
			case 210u:
				TargetActorGuid = input.ReadString();
				break;
			case 216u:
				MoveAiType = input.ReadInt32();
				break;
			case 224u:
				MoveSpeedType = input.ReadInt32();
				break;
			case 237u:
				MoveAcceptableRadius = input.ReadFloat();
				break;
			case 240u:
				NpcMoveType = input.ReadInt32();
				break;
			case 248u:
				NeedSwitchSpeedByDistanceToPlayer = input.ReadBool();
				break;
			case 261u:
				MaxDistanceSprint = input.ReadFloat();
				break;
			case 269u:
				MaxDistanceRun = input.ReadFloat();
				break;
			case 277u:
				MaxDistanceJog = input.ReadFloat();
				break;
			case 285u:
				DistanceBuffer = input.ReadFloat();
				break;
			case 288u:
				WeakPerformConfigId = input.ReadInt32();
				break;
			case 298u:
				FollowPartnerConfigId = input.ReadString();
				break;
			case 306u:
				GameplayTag = input.ReadString();
				break;
			case 312u:
				IsDontResetPlayerState = input.ReadBool();
				break;
			case 320u:
				LoadingScreenType = input.ReadInt32();
				break;
			case 328u:
				ExtendId = input.ReadInt32();
				break;
			case 336u:
				IsBlockRebirthpoint = input.ReadBool();
				break;
			case 344u:
			case 346u:
				teleportLoadingTips_.AddEntriesFrom(input, _repeated_teleportLoadingTips_codec);
				break;
			}
		}
	}
}
