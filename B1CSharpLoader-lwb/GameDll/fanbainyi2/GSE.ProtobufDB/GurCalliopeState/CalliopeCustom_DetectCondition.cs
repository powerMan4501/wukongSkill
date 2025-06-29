using System;
using Google.Protobuf;

namespace GurCalliopeState;

public sealed class CalliopeCustom_DetectCondition : IMessage<CalliopeCustom_DetectCondition>, IMessage, IEquatable<CalliopeCustom_DetectCondition>, IDeepCloneable<CalliopeCustom_DetectCondition>
{
	private static readonly MessageParser<CalliopeCustom_DetectCondition> _parser = new MessageParser<CalliopeCustom_DetectCondition>(() => new CalliopeCustom_DetectCondition());

	private UnknownFieldSet _unknownFields;

	private int detectedElementType_;

	private bool isReverseCondition_;

	private string comment_ = "";

	private CalliopeCustom_DetectCondition_SimpleState simpleState_;

	private CalliopeCustom_DetectCondition_UnitState unitState_;

	private CalliopeCustom_DetectCondition_HasBuff hasBuff_;

	private CalliopeCustom_DetectCondition_UnitAttr unitAttr_;

	private CalliopeCustom_DetectCondition_UnitActived unitActived_;

	private CalliopeCustom_DetectCondition_UnitInActived unitInActived_;

	private CalliopeCustom_DetectCondition_AbnormalState abnormalState_;

	private CalliopeCustom_DetectCondition_FsmState fsmState_;

	private CalliopeCustom_DetectCondition_SkillCoolDown skillCoolDown_;

	private CalliopeCustom_DetectCondition_DistanceFromTarget distanceFromTarget_;

	private CalliopeCustom_DetectCondition_SkillCanCast skillCanCast_;

	private CalliopeCustom_DetectCondition_CustomFsmState customFsmState_;

	private CalliopeCustom_DetectCondition_LastBeAttackedStiffLevel lastBeAttackedStiffLevel_;

	private CalliopeCustom_DetectCondition_DistanceFromMaster distanceFromMaster_;

	private CalliopeCustom_DetectCondition_ActorYawRotation actorYawRotation_;

	private CalliopeCustom_DetectCondition_GlobalCastSkillCount globalCastSkillCount_;

	private CalliopeCustom_DetectCondition_DurCastSkill durCastSkill_;

	private CalliopeCustom_DetectCondition_CurrentBeAttackedStiffLevel currentBeAttackedStiffLevel_;

	private CalliopeCustom_DetectCondition_CurSkillCostDmgNum curSkillCostDmgNum_;

	private CalliopeCustom_DetectCondition_SocketUnitsDead socketUnitsDead_;

	private CalliopeCustom_DetectCondition_DistanceFromNearestPlayer distanceFromNearestPlayer_;

	private CalliopeCustom_DetectCondition_SpecifyResIdUnitsDead specifyResIdUnitsDead_;

	private CalliopeCustom_DetectCondition_FamilySpecifyUnitAttr familySpecifyUnitAttr_;

	private CalliopeCustom_DetectCondition_Random random_;

	private CalliopeCustom_DetectCondition_FamilyUnitAliveNum familyUnitAliveNum_;

	private CalliopeCustom_DetectCondition_TargetInAngleRange targetInAngleRange_;

	private CalliopeCustom_DetectCondition_CompareBuffLayer compareBuffLayer_;

	private CalliopeCustom_DetectCondition_CompareGamePlusCount compareGamePlusCount_;

	private CalliopeCustom_DetectCondition_CheckSurfaceType checkSurfaceType_;

	private CalliopeCustom_DetectCondition_HasStoryCanTalkInThisLevel hasStoryCanTalkInThisLevel_;

	private CalliopeCustom_DetectCondition_StoryInCollingOffPeriod storyInCollingOffPeriod_;

	private CalliopeCustom_DetectCondition_PlayerLeisureOverTime playerLeisureOverTime_;

	public static MessageParser<CalliopeCustom_DetectCondition> Parser => _parser;

	public int DetectedElementType
	{
		get
		{
			return detectedElementType_;
		}
		set
		{
			detectedElementType_ = value;
		}
	}

	public bool IsReverseCondition
	{
		get
		{
			return isReverseCondition_;
		}
		set
		{
			isReverseCondition_ = value;
		}
	}

	public string Comment
	{
		get
		{
			return comment_;
		}
		set
		{
			comment_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public CalliopeCustom_DetectCondition_SimpleState SimpleState
	{
		get
		{
			return simpleState_;
		}
		set
		{
			simpleState_ = value;
		}
	}

	public CalliopeCustom_DetectCondition_UnitState UnitState
	{
		get
		{
			return unitState_;
		}
		set
		{
			unitState_ = value;
		}
	}

	public CalliopeCustom_DetectCondition_HasBuff HasBuff
	{
		get
		{
			return hasBuff_;
		}
		set
		{
			hasBuff_ = value;
		}
	}

	public CalliopeCustom_DetectCondition_UnitAttr UnitAttr
	{
		get
		{
			return unitAttr_;
		}
		set
		{
			unitAttr_ = value;
		}
	}

	public CalliopeCustom_DetectCondition_UnitActived UnitActived
	{
		get
		{
			return unitActived_;
		}
		set
		{
			unitActived_ = value;
		}
	}

	public CalliopeCustom_DetectCondition_UnitInActived UnitInActived
	{
		get
		{
			return unitInActived_;
		}
		set
		{
			unitInActived_ = value;
		}
	}

	public CalliopeCustom_DetectCondition_AbnormalState AbnormalState
	{
		get
		{
			return abnormalState_;
		}
		set
		{
			abnormalState_ = value;
		}
	}

	public CalliopeCustom_DetectCondition_FsmState FsmState
	{
		get
		{
			return fsmState_;
		}
		set
		{
			fsmState_ = value;
		}
	}

	public CalliopeCustom_DetectCondition_SkillCoolDown SkillCoolDown
	{
		get
		{
			return skillCoolDown_;
		}
		set
		{
			skillCoolDown_ = value;
		}
	}

	public CalliopeCustom_DetectCondition_DistanceFromTarget DistanceFromTarget
	{
		get
		{
			return distanceFromTarget_;
		}
		set
		{
			distanceFromTarget_ = value;
		}
	}

	public CalliopeCustom_DetectCondition_SkillCanCast SkillCanCast
	{
		get
		{
			return skillCanCast_;
		}
		set
		{
			skillCanCast_ = value;
		}
	}

	public CalliopeCustom_DetectCondition_CustomFsmState CustomFsmState
	{
		get
		{
			return customFsmState_;
		}
		set
		{
			customFsmState_ = value;
		}
	}

	public CalliopeCustom_DetectCondition_LastBeAttackedStiffLevel LastBeAttackedStiffLevel
	{
		get
		{
			return lastBeAttackedStiffLevel_;
		}
		set
		{
			lastBeAttackedStiffLevel_ = value;
		}
	}

	public CalliopeCustom_DetectCondition_DistanceFromMaster DistanceFromMaster
	{
		get
		{
			return distanceFromMaster_;
		}
		set
		{
			distanceFromMaster_ = value;
		}
	}

	public CalliopeCustom_DetectCondition_ActorYawRotation ActorYawRotation
	{
		get
		{
			return actorYawRotation_;
		}
		set
		{
			actorYawRotation_ = value;
		}
	}

	public CalliopeCustom_DetectCondition_GlobalCastSkillCount GlobalCastSkillCount
	{
		get
		{
			return globalCastSkillCount_;
		}
		set
		{
			globalCastSkillCount_ = value;
		}
	}

	public CalliopeCustom_DetectCondition_DurCastSkill DurCastSkill
	{
		get
		{
			return durCastSkill_;
		}
		set
		{
			durCastSkill_ = value;
		}
	}

	public CalliopeCustom_DetectCondition_CurrentBeAttackedStiffLevel CurrentBeAttackedStiffLevel
	{
		get
		{
			return currentBeAttackedStiffLevel_;
		}
		set
		{
			currentBeAttackedStiffLevel_ = value;
		}
	}

	public CalliopeCustom_DetectCondition_CurSkillCostDmgNum CurSkillCostDmgNum
	{
		get
		{
			return curSkillCostDmgNum_;
		}
		set
		{
			curSkillCostDmgNum_ = value;
		}
	}

	public CalliopeCustom_DetectCondition_SocketUnitsDead SocketUnitsDead
	{
		get
		{
			return socketUnitsDead_;
		}
		set
		{
			socketUnitsDead_ = value;
		}
	}

	public CalliopeCustom_DetectCondition_DistanceFromNearestPlayer DistanceFromNearestPlayer
	{
		get
		{
			return distanceFromNearestPlayer_;
		}
		set
		{
			distanceFromNearestPlayer_ = value;
		}
	}

	public CalliopeCustom_DetectCondition_SpecifyResIdUnitsDead SpecifyResIdUnitsDead
	{
		get
		{
			return specifyResIdUnitsDead_;
		}
		set
		{
			specifyResIdUnitsDead_ = value;
		}
	}

	public CalliopeCustom_DetectCondition_FamilySpecifyUnitAttr FamilySpecifyUnitAttr
	{
		get
		{
			return familySpecifyUnitAttr_;
		}
		set
		{
			familySpecifyUnitAttr_ = value;
		}
	}

	public CalliopeCustom_DetectCondition_Random Random
	{
		get
		{
			return random_;
		}
		set
		{
			random_ = value;
		}
	}

	public CalliopeCustom_DetectCondition_FamilyUnitAliveNum FamilyUnitAliveNum
	{
		get
		{
			return familyUnitAliveNum_;
		}
		set
		{
			familyUnitAliveNum_ = value;
		}
	}

	public CalliopeCustom_DetectCondition_TargetInAngleRange TargetInAngleRange
	{
		get
		{
			return targetInAngleRange_;
		}
		set
		{
			targetInAngleRange_ = value;
		}
	}

	public CalliopeCustom_DetectCondition_CompareBuffLayer CompareBuffLayer
	{
		get
		{
			return compareBuffLayer_;
		}
		set
		{
			compareBuffLayer_ = value;
		}
	}

	public CalliopeCustom_DetectCondition_CompareGamePlusCount CompareGamePlusCount
	{
		get
		{
			return compareGamePlusCount_;
		}
		set
		{
			compareGamePlusCount_ = value;
		}
	}

	public CalliopeCustom_DetectCondition_CheckSurfaceType CheckSurfaceType
	{
		get
		{
			return checkSurfaceType_;
		}
		set
		{
			checkSurfaceType_ = value;
		}
	}

	public CalliopeCustom_DetectCondition_HasStoryCanTalkInThisLevel HasStoryCanTalkInThisLevel
	{
		get
		{
			return hasStoryCanTalkInThisLevel_;
		}
		set
		{
			hasStoryCanTalkInThisLevel_ = value;
		}
	}

	public CalliopeCustom_DetectCondition_StoryInCollingOffPeriod StoryInCollingOffPeriod
	{
		get
		{
			return storyInCollingOffPeriod_;
		}
		set
		{
			storyInCollingOffPeriod_ = value;
		}
	}

	public CalliopeCustom_DetectCondition_PlayerLeisureOverTime PlayerLeisureOverTime
	{
		get
		{
			return playerLeisureOverTime_;
		}
		set
		{
			playerLeisureOverTime_ = value;
		}
	}

	public CalliopeCustom_DetectCondition()
	{
	}

	public CalliopeCustom_DetectCondition(CalliopeCustom_DetectCondition other)
		: this()
	{
		detectedElementType_ = other.detectedElementType_;
		isReverseCondition_ = other.isReverseCondition_;
		comment_ = other.comment_;
		simpleState_ = ((other.simpleState_ != null) ? other.simpleState_.Clone() : null);
		unitState_ = ((other.unitState_ != null) ? other.unitState_.Clone() : null);
		hasBuff_ = ((other.hasBuff_ != null) ? other.hasBuff_.Clone() : null);
		unitAttr_ = ((other.unitAttr_ != null) ? other.unitAttr_.Clone() : null);
		unitActived_ = ((other.unitActived_ != null) ? other.unitActived_.Clone() : null);
		unitInActived_ = ((other.unitInActived_ != null) ? other.unitInActived_.Clone() : null);
		abnormalState_ = ((other.abnormalState_ != null) ? other.abnormalState_.Clone() : null);
		fsmState_ = ((other.fsmState_ != null) ? other.fsmState_.Clone() : null);
		skillCoolDown_ = ((other.skillCoolDown_ != null) ? other.skillCoolDown_.Clone() : null);
		distanceFromTarget_ = ((other.distanceFromTarget_ != null) ? other.distanceFromTarget_.Clone() : null);
		skillCanCast_ = ((other.skillCanCast_ != null) ? other.skillCanCast_.Clone() : null);
		customFsmState_ = ((other.customFsmState_ != null) ? other.customFsmState_.Clone() : null);
		lastBeAttackedStiffLevel_ = ((other.lastBeAttackedStiffLevel_ != null) ? other.lastBeAttackedStiffLevel_.Clone() : null);
		distanceFromMaster_ = ((other.distanceFromMaster_ != null) ? other.distanceFromMaster_.Clone() : null);
		actorYawRotation_ = ((other.actorYawRotation_ != null) ? other.actorYawRotation_.Clone() : null);
		globalCastSkillCount_ = ((other.globalCastSkillCount_ != null) ? other.globalCastSkillCount_.Clone() : null);
		durCastSkill_ = ((other.durCastSkill_ != null) ? other.durCastSkill_.Clone() : null);
		currentBeAttackedStiffLevel_ = ((other.currentBeAttackedStiffLevel_ != null) ? other.currentBeAttackedStiffLevel_.Clone() : null);
		curSkillCostDmgNum_ = ((other.curSkillCostDmgNum_ != null) ? other.curSkillCostDmgNum_.Clone() : null);
		socketUnitsDead_ = ((other.socketUnitsDead_ != null) ? other.socketUnitsDead_.Clone() : null);
		distanceFromNearestPlayer_ = ((other.distanceFromNearestPlayer_ != null) ? other.distanceFromNearestPlayer_.Clone() : null);
		specifyResIdUnitsDead_ = ((other.specifyResIdUnitsDead_ != null) ? other.specifyResIdUnitsDead_.Clone() : null);
		familySpecifyUnitAttr_ = ((other.familySpecifyUnitAttr_ != null) ? other.familySpecifyUnitAttr_.Clone() : null);
		random_ = ((other.random_ != null) ? other.random_.Clone() : null);
		familyUnitAliveNum_ = ((other.familyUnitAliveNum_ != null) ? other.familyUnitAliveNum_.Clone() : null);
		targetInAngleRange_ = ((other.targetInAngleRange_ != null) ? other.targetInAngleRange_.Clone() : null);
		compareBuffLayer_ = ((other.compareBuffLayer_ != null) ? other.compareBuffLayer_.Clone() : null);
		compareGamePlusCount_ = ((other.compareGamePlusCount_ != null) ? other.compareGamePlusCount_.Clone() : null);
		checkSurfaceType_ = ((other.checkSurfaceType_ != null) ? other.checkSurfaceType_.Clone() : null);
		hasStoryCanTalkInThisLevel_ = ((other.hasStoryCanTalkInThisLevel_ != null) ? other.hasStoryCanTalkInThisLevel_.Clone() : null);
		storyInCollingOffPeriod_ = ((other.storyInCollingOffPeriod_ != null) ? other.storyInCollingOffPeriod_.Clone() : null);
		playerLeisureOverTime_ = ((other.playerLeisureOverTime_ != null) ? other.playerLeisureOverTime_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_DetectCondition Clone()
	{
		return new CalliopeCustom_DetectCondition(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_DetectCondition);
	}

	public bool Equals(CalliopeCustom_DetectCondition other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DetectedElementType != other.DetectedElementType)
		{
			return false;
		}
		if (IsReverseCondition != other.IsReverseCondition)
		{
			return false;
		}
		if (Comment != other.Comment)
		{
			return false;
		}
		if (!object.Equals(SimpleState, other.SimpleState))
		{
			return false;
		}
		if (!object.Equals(UnitState, other.UnitState))
		{
			return false;
		}
		if (!object.Equals(HasBuff, other.HasBuff))
		{
			return false;
		}
		if (!object.Equals(UnitAttr, other.UnitAttr))
		{
			return false;
		}
		if (!object.Equals(UnitActived, other.UnitActived))
		{
			return false;
		}
		if (!object.Equals(UnitInActived, other.UnitInActived))
		{
			return false;
		}
		if (!object.Equals(AbnormalState, other.AbnormalState))
		{
			return false;
		}
		if (!object.Equals(FsmState, other.FsmState))
		{
			return false;
		}
		if (!object.Equals(SkillCoolDown, other.SkillCoolDown))
		{
			return false;
		}
		if (!object.Equals(DistanceFromTarget, other.DistanceFromTarget))
		{
			return false;
		}
		if (!object.Equals(SkillCanCast, other.SkillCanCast))
		{
			return false;
		}
		if (!object.Equals(CustomFsmState, other.CustomFsmState))
		{
			return false;
		}
		if (!object.Equals(LastBeAttackedStiffLevel, other.LastBeAttackedStiffLevel))
		{
			return false;
		}
		if (!object.Equals(DistanceFromMaster, other.DistanceFromMaster))
		{
			return false;
		}
		if (!object.Equals(ActorYawRotation, other.ActorYawRotation))
		{
			return false;
		}
		if (!object.Equals(GlobalCastSkillCount, other.GlobalCastSkillCount))
		{
			return false;
		}
		if (!object.Equals(DurCastSkill, other.DurCastSkill))
		{
			return false;
		}
		if (!object.Equals(CurrentBeAttackedStiffLevel, other.CurrentBeAttackedStiffLevel))
		{
			return false;
		}
		if (!object.Equals(CurSkillCostDmgNum, other.CurSkillCostDmgNum))
		{
			return false;
		}
		if (!object.Equals(SocketUnitsDead, other.SocketUnitsDead))
		{
			return false;
		}
		if (!object.Equals(DistanceFromNearestPlayer, other.DistanceFromNearestPlayer))
		{
			return false;
		}
		if (!object.Equals(SpecifyResIdUnitsDead, other.SpecifyResIdUnitsDead))
		{
			return false;
		}
		if (!object.Equals(FamilySpecifyUnitAttr, other.FamilySpecifyUnitAttr))
		{
			return false;
		}
		if (!object.Equals(Random, other.Random))
		{
			return false;
		}
		if (!object.Equals(FamilyUnitAliveNum, other.FamilyUnitAliveNum))
		{
			return false;
		}
		if (!object.Equals(TargetInAngleRange, other.TargetInAngleRange))
		{
			return false;
		}
		if (!object.Equals(CompareBuffLayer, other.CompareBuffLayer))
		{
			return false;
		}
		if (!object.Equals(CompareGamePlusCount, other.CompareGamePlusCount))
		{
			return false;
		}
		if (!object.Equals(CheckSurfaceType, other.CheckSurfaceType))
		{
			return false;
		}
		if (!object.Equals(HasStoryCanTalkInThisLevel, other.HasStoryCanTalkInThisLevel))
		{
			return false;
		}
		if (!object.Equals(StoryInCollingOffPeriod, other.StoryInCollingOffPeriod))
		{
			return false;
		}
		if (!object.Equals(PlayerLeisureOverTime, other.PlayerLeisureOverTime))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (DetectedElementType != 0)
		{
			num ^= DetectedElementType.GetHashCode();
		}
		if (IsReverseCondition)
		{
			num ^= IsReverseCondition.GetHashCode();
		}
		if (Comment.Length != 0)
		{
			num ^= Comment.GetHashCode();
		}
		if (simpleState_ != null)
		{
			num ^= SimpleState.GetHashCode();
		}
		if (unitState_ != null)
		{
			num ^= UnitState.GetHashCode();
		}
		if (hasBuff_ != null)
		{
			num ^= HasBuff.GetHashCode();
		}
		if (unitAttr_ != null)
		{
			num ^= UnitAttr.GetHashCode();
		}
		if (unitActived_ != null)
		{
			num ^= UnitActived.GetHashCode();
		}
		if (unitInActived_ != null)
		{
			num ^= UnitInActived.GetHashCode();
		}
		if (abnormalState_ != null)
		{
			num ^= AbnormalState.GetHashCode();
		}
		if (fsmState_ != null)
		{
			num ^= FsmState.GetHashCode();
		}
		if (skillCoolDown_ != null)
		{
			num ^= SkillCoolDown.GetHashCode();
		}
		if (distanceFromTarget_ != null)
		{
			num ^= DistanceFromTarget.GetHashCode();
		}
		if (skillCanCast_ != null)
		{
			num ^= SkillCanCast.GetHashCode();
		}
		if (customFsmState_ != null)
		{
			num ^= CustomFsmState.GetHashCode();
		}
		if (lastBeAttackedStiffLevel_ != null)
		{
			num ^= LastBeAttackedStiffLevel.GetHashCode();
		}
		if (distanceFromMaster_ != null)
		{
			num ^= DistanceFromMaster.GetHashCode();
		}
		if (actorYawRotation_ != null)
		{
			num ^= ActorYawRotation.GetHashCode();
		}
		if (globalCastSkillCount_ != null)
		{
			num ^= GlobalCastSkillCount.GetHashCode();
		}
		if (durCastSkill_ != null)
		{
			num ^= DurCastSkill.GetHashCode();
		}
		if (currentBeAttackedStiffLevel_ != null)
		{
			num ^= CurrentBeAttackedStiffLevel.GetHashCode();
		}
		if (curSkillCostDmgNum_ != null)
		{
			num ^= CurSkillCostDmgNum.GetHashCode();
		}
		if (socketUnitsDead_ != null)
		{
			num ^= SocketUnitsDead.GetHashCode();
		}
		if (distanceFromNearestPlayer_ != null)
		{
			num ^= DistanceFromNearestPlayer.GetHashCode();
		}
		if (specifyResIdUnitsDead_ != null)
		{
			num ^= SpecifyResIdUnitsDead.GetHashCode();
		}
		if (familySpecifyUnitAttr_ != null)
		{
			num ^= FamilySpecifyUnitAttr.GetHashCode();
		}
		if (random_ != null)
		{
			num ^= Random.GetHashCode();
		}
		if (familyUnitAliveNum_ != null)
		{
			num ^= FamilyUnitAliveNum.GetHashCode();
		}
		if (targetInAngleRange_ != null)
		{
			num ^= TargetInAngleRange.GetHashCode();
		}
		if (compareBuffLayer_ != null)
		{
			num ^= CompareBuffLayer.GetHashCode();
		}
		if (compareGamePlusCount_ != null)
		{
			num ^= CompareGamePlusCount.GetHashCode();
		}
		if (checkSurfaceType_ != null)
		{
			num ^= CheckSurfaceType.GetHashCode();
		}
		if (hasStoryCanTalkInThisLevel_ != null)
		{
			num ^= HasStoryCanTalkInThisLevel.GetHashCode();
		}
		if (storyInCollingOffPeriod_ != null)
		{
			num ^= StoryInCollingOffPeriod.GetHashCode();
		}
		if (playerLeisureOverTime_ != null)
		{
			num ^= PlayerLeisureOverTime.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (DetectedElementType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(DetectedElementType);
		}
		if (IsReverseCondition)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsReverseCondition);
		}
		if (Comment.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Comment);
		}
		if (simpleState_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(SimpleState);
		}
		if (unitState_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(UnitState);
		}
		if (hasBuff_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(HasBuff);
		}
		if (unitAttr_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(UnitAttr);
		}
		if (unitActived_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(UnitActived);
		}
		if (unitInActived_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(UnitInActived);
		}
		if (abnormalState_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(AbnormalState);
		}
		if (fsmState_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(FsmState);
		}
		if (skillCoolDown_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(SkillCoolDown);
		}
		if (distanceFromTarget_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(DistanceFromTarget);
		}
		if (skillCanCast_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(SkillCanCast);
		}
		if (customFsmState_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(CustomFsmState);
		}
		if (lastBeAttackedStiffLevel_ != null)
		{
			output.WriteRawTag(130, 1);
			output.WriteMessage(LastBeAttackedStiffLevel);
		}
		if (distanceFromMaster_ != null)
		{
			output.WriteRawTag(138, 1);
			output.WriteMessage(DistanceFromMaster);
		}
		if (actorYawRotation_ != null)
		{
			output.WriteRawTag(146, 1);
			output.WriteMessage(ActorYawRotation);
		}
		if (globalCastSkillCount_ != null)
		{
			output.WriteRawTag(154, 1);
			output.WriteMessage(GlobalCastSkillCount);
		}
		if (durCastSkill_ != null)
		{
			output.WriteRawTag(162, 1);
			output.WriteMessage(DurCastSkill);
		}
		if (currentBeAttackedStiffLevel_ != null)
		{
			output.WriteRawTag(170, 1);
			output.WriteMessage(CurrentBeAttackedStiffLevel);
		}
		if (curSkillCostDmgNum_ != null)
		{
			output.WriteRawTag(178, 1);
			output.WriteMessage(CurSkillCostDmgNum);
		}
		if (socketUnitsDead_ != null)
		{
			output.WriteRawTag(186, 1);
			output.WriteMessage(SocketUnitsDead);
		}
		if (distanceFromNearestPlayer_ != null)
		{
			output.WriteRawTag(194, 1);
			output.WriteMessage(DistanceFromNearestPlayer);
		}
		if (specifyResIdUnitsDead_ != null)
		{
			output.WriteRawTag(202, 1);
			output.WriteMessage(SpecifyResIdUnitsDead);
		}
		if (familySpecifyUnitAttr_ != null)
		{
			output.WriteRawTag(210, 1);
			output.WriteMessage(FamilySpecifyUnitAttr);
		}
		if (random_ != null)
		{
			output.WriteRawTag(218, 1);
			output.WriteMessage(Random);
		}
		if (familyUnitAliveNum_ != null)
		{
			output.WriteRawTag(226, 1);
			output.WriteMessage(FamilyUnitAliveNum);
		}
		if (targetInAngleRange_ != null)
		{
			output.WriteRawTag(234, 1);
			output.WriteMessage(TargetInAngleRange);
		}
		if (compareBuffLayer_ != null)
		{
			output.WriteRawTag(242, 1);
			output.WriteMessage(CompareBuffLayer);
		}
		if (compareGamePlusCount_ != null)
		{
			output.WriteRawTag(250, 1);
			output.WriteMessage(CompareGamePlusCount);
		}
		if (checkSurfaceType_ != null)
		{
			output.WriteRawTag(130, 2);
			output.WriteMessage(CheckSurfaceType);
		}
		if (hasStoryCanTalkInThisLevel_ != null)
		{
			output.WriteRawTag(138, 2);
			output.WriteMessage(HasStoryCanTalkInThisLevel);
		}
		if (storyInCollingOffPeriod_ != null)
		{
			output.WriteRawTag(146, 2);
			output.WriteMessage(StoryInCollingOffPeriod);
		}
		if (playerLeisureOverTime_ != null)
		{
			output.WriteRawTag(154, 2);
			output.WriteMessage(PlayerLeisureOverTime);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (DetectedElementType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DetectedElementType);
		}
		if (IsReverseCondition)
		{
			num += 2;
		}
		if (Comment.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Comment);
		}
		if (simpleState_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SimpleState);
		}
		if (unitState_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(UnitState);
		}
		if (hasBuff_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HasBuff);
		}
		if (unitAttr_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(UnitAttr);
		}
		if (unitActived_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(UnitActived);
		}
		if (unitInActived_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(UnitInActived);
		}
		if (abnormalState_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AbnormalState);
		}
		if (fsmState_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FsmState);
		}
		if (skillCoolDown_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SkillCoolDown);
		}
		if (distanceFromTarget_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DistanceFromTarget);
		}
		if (skillCanCast_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SkillCanCast);
		}
		if (customFsmState_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CustomFsmState);
		}
		if (lastBeAttackedStiffLevel_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(LastBeAttackedStiffLevel);
		}
		if (distanceFromMaster_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(DistanceFromMaster);
		}
		if (actorYawRotation_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(ActorYawRotation);
		}
		if (globalCastSkillCount_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(GlobalCastSkillCount);
		}
		if (durCastSkill_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(DurCastSkill);
		}
		if (currentBeAttackedStiffLevel_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CurrentBeAttackedStiffLevel);
		}
		if (curSkillCostDmgNum_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CurSkillCostDmgNum);
		}
		if (socketUnitsDead_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(SocketUnitsDead);
		}
		if (distanceFromNearestPlayer_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(DistanceFromNearestPlayer);
		}
		if (specifyResIdUnitsDead_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(SpecifyResIdUnitsDead);
		}
		if (familySpecifyUnitAttr_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(FamilySpecifyUnitAttr);
		}
		if (random_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(Random);
		}
		if (familyUnitAliveNum_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(FamilyUnitAliveNum);
		}
		if (targetInAngleRange_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(TargetInAngleRange);
		}
		if (compareBuffLayer_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CompareBuffLayer);
		}
		if (compareGamePlusCount_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CompareGamePlusCount);
		}
		if (checkSurfaceType_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CheckSurfaceType);
		}
		if (hasStoryCanTalkInThisLevel_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(HasStoryCanTalkInThisLevel);
		}
		if (storyInCollingOffPeriod_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(StoryInCollingOffPeriod);
		}
		if (playerLeisureOverTime_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PlayerLeisureOverTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_DetectCondition other)
	{
		if (other == null)
		{
			return;
		}
		if (other.DetectedElementType != 0)
		{
			DetectedElementType = other.DetectedElementType;
		}
		if (other.IsReverseCondition)
		{
			IsReverseCondition = other.IsReverseCondition;
		}
		if (other.Comment.Length != 0)
		{
			Comment = other.Comment;
		}
		if (other.simpleState_ != null)
		{
			if (simpleState_ == null)
			{
				SimpleState = new CalliopeCustom_DetectCondition_SimpleState();
			}
			SimpleState.MergeFrom(other.SimpleState);
		}
		if (other.unitState_ != null)
		{
			if (unitState_ == null)
			{
				UnitState = new CalliopeCustom_DetectCondition_UnitState();
			}
			UnitState.MergeFrom(other.UnitState);
		}
		if (other.hasBuff_ != null)
		{
			if (hasBuff_ == null)
			{
				HasBuff = new CalliopeCustom_DetectCondition_HasBuff();
			}
			HasBuff.MergeFrom(other.HasBuff);
		}
		if (other.unitAttr_ != null)
		{
			if (unitAttr_ == null)
			{
				UnitAttr = new CalliopeCustom_DetectCondition_UnitAttr();
			}
			UnitAttr.MergeFrom(other.UnitAttr);
		}
		if (other.unitActived_ != null)
		{
			if (unitActived_ == null)
			{
				UnitActived = new CalliopeCustom_DetectCondition_UnitActived();
			}
			UnitActived.MergeFrom(other.UnitActived);
		}
		if (other.unitInActived_ != null)
		{
			if (unitInActived_ == null)
			{
				UnitInActived = new CalliopeCustom_DetectCondition_UnitInActived();
			}
			UnitInActived.MergeFrom(other.UnitInActived);
		}
		if (other.abnormalState_ != null)
		{
			if (abnormalState_ == null)
			{
				AbnormalState = new CalliopeCustom_DetectCondition_AbnormalState();
			}
			AbnormalState.MergeFrom(other.AbnormalState);
		}
		if (other.fsmState_ != null)
		{
			if (fsmState_ == null)
			{
				FsmState = new CalliopeCustom_DetectCondition_FsmState();
			}
			FsmState.MergeFrom(other.FsmState);
		}
		if (other.skillCoolDown_ != null)
		{
			if (skillCoolDown_ == null)
			{
				SkillCoolDown = new CalliopeCustom_DetectCondition_SkillCoolDown();
			}
			SkillCoolDown.MergeFrom(other.SkillCoolDown);
		}
		if (other.distanceFromTarget_ != null)
		{
			if (distanceFromTarget_ == null)
			{
				DistanceFromTarget = new CalliopeCustom_DetectCondition_DistanceFromTarget();
			}
			DistanceFromTarget.MergeFrom(other.DistanceFromTarget);
		}
		if (other.skillCanCast_ != null)
		{
			if (skillCanCast_ == null)
			{
				SkillCanCast = new CalliopeCustom_DetectCondition_SkillCanCast();
			}
			SkillCanCast.MergeFrom(other.SkillCanCast);
		}
		if (other.customFsmState_ != null)
		{
			if (customFsmState_ == null)
			{
				CustomFsmState = new CalliopeCustom_DetectCondition_CustomFsmState();
			}
			CustomFsmState.MergeFrom(other.CustomFsmState);
		}
		if (other.lastBeAttackedStiffLevel_ != null)
		{
			if (lastBeAttackedStiffLevel_ == null)
			{
				LastBeAttackedStiffLevel = new CalliopeCustom_DetectCondition_LastBeAttackedStiffLevel();
			}
			LastBeAttackedStiffLevel.MergeFrom(other.LastBeAttackedStiffLevel);
		}
		if (other.distanceFromMaster_ != null)
		{
			if (distanceFromMaster_ == null)
			{
				DistanceFromMaster = new CalliopeCustom_DetectCondition_DistanceFromMaster();
			}
			DistanceFromMaster.MergeFrom(other.DistanceFromMaster);
		}
		if (other.actorYawRotation_ != null)
		{
			if (actorYawRotation_ == null)
			{
				ActorYawRotation = new CalliopeCustom_DetectCondition_ActorYawRotation();
			}
			ActorYawRotation.MergeFrom(other.ActorYawRotation);
		}
		if (other.globalCastSkillCount_ != null)
		{
			if (globalCastSkillCount_ == null)
			{
				GlobalCastSkillCount = new CalliopeCustom_DetectCondition_GlobalCastSkillCount();
			}
			GlobalCastSkillCount.MergeFrom(other.GlobalCastSkillCount);
		}
		if (other.durCastSkill_ != null)
		{
			if (durCastSkill_ == null)
			{
				DurCastSkill = new CalliopeCustom_DetectCondition_DurCastSkill();
			}
			DurCastSkill.MergeFrom(other.DurCastSkill);
		}
		if (other.currentBeAttackedStiffLevel_ != null)
		{
			if (currentBeAttackedStiffLevel_ == null)
			{
				CurrentBeAttackedStiffLevel = new CalliopeCustom_DetectCondition_CurrentBeAttackedStiffLevel();
			}
			CurrentBeAttackedStiffLevel.MergeFrom(other.CurrentBeAttackedStiffLevel);
		}
		if (other.curSkillCostDmgNum_ != null)
		{
			if (curSkillCostDmgNum_ == null)
			{
				CurSkillCostDmgNum = new CalliopeCustom_DetectCondition_CurSkillCostDmgNum();
			}
			CurSkillCostDmgNum.MergeFrom(other.CurSkillCostDmgNum);
		}
		if (other.socketUnitsDead_ != null)
		{
			if (socketUnitsDead_ == null)
			{
				SocketUnitsDead = new CalliopeCustom_DetectCondition_SocketUnitsDead();
			}
			SocketUnitsDead.MergeFrom(other.SocketUnitsDead);
		}
		if (other.distanceFromNearestPlayer_ != null)
		{
			if (distanceFromNearestPlayer_ == null)
			{
				DistanceFromNearestPlayer = new CalliopeCustom_DetectCondition_DistanceFromNearestPlayer();
			}
			DistanceFromNearestPlayer.MergeFrom(other.DistanceFromNearestPlayer);
		}
		if (other.specifyResIdUnitsDead_ != null)
		{
			if (specifyResIdUnitsDead_ == null)
			{
				SpecifyResIdUnitsDead = new CalliopeCustom_DetectCondition_SpecifyResIdUnitsDead();
			}
			SpecifyResIdUnitsDead.MergeFrom(other.SpecifyResIdUnitsDead);
		}
		if (other.familySpecifyUnitAttr_ != null)
		{
			if (familySpecifyUnitAttr_ == null)
			{
				FamilySpecifyUnitAttr = new CalliopeCustom_DetectCondition_FamilySpecifyUnitAttr();
			}
			FamilySpecifyUnitAttr.MergeFrom(other.FamilySpecifyUnitAttr);
		}
		if (other.random_ != null)
		{
			if (random_ == null)
			{
				Random = new CalliopeCustom_DetectCondition_Random();
			}
			Random.MergeFrom(other.Random);
		}
		if (other.familyUnitAliveNum_ != null)
		{
			if (familyUnitAliveNum_ == null)
			{
				FamilyUnitAliveNum = new CalliopeCustom_DetectCondition_FamilyUnitAliveNum();
			}
			FamilyUnitAliveNum.MergeFrom(other.FamilyUnitAliveNum);
		}
		if (other.targetInAngleRange_ != null)
		{
			if (targetInAngleRange_ == null)
			{
				TargetInAngleRange = new CalliopeCustom_DetectCondition_TargetInAngleRange();
			}
			TargetInAngleRange.MergeFrom(other.TargetInAngleRange);
		}
		if (other.compareBuffLayer_ != null)
		{
			if (compareBuffLayer_ == null)
			{
				CompareBuffLayer = new CalliopeCustom_DetectCondition_CompareBuffLayer();
			}
			CompareBuffLayer.MergeFrom(other.CompareBuffLayer);
		}
		if (other.compareGamePlusCount_ != null)
		{
			if (compareGamePlusCount_ == null)
			{
				CompareGamePlusCount = new CalliopeCustom_DetectCondition_CompareGamePlusCount();
			}
			CompareGamePlusCount.MergeFrom(other.CompareGamePlusCount);
		}
		if (other.checkSurfaceType_ != null)
		{
			if (checkSurfaceType_ == null)
			{
				CheckSurfaceType = new CalliopeCustom_DetectCondition_CheckSurfaceType();
			}
			CheckSurfaceType.MergeFrom(other.CheckSurfaceType);
		}
		if (other.hasStoryCanTalkInThisLevel_ != null)
		{
			if (hasStoryCanTalkInThisLevel_ == null)
			{
				HasStoryCanTalkInThisLevel = new CalliopeCustom_DetectCondition_HasStoryCanTalkInThisLevel();
			}
			HasStoryCanTalkInThisLevel.MergeFrom(other.HasStoryCanTalkInThisLevel);
		}
		if (other.storyInCollingOffPeriod_ != null)
		{
			if (storyInCollingOffPeriod_ == null)
			{
				StoryInCollingOffPeriod = new CalliopeCustom_DetectCondition_StoryInCollingOffPeriod();
			}
			StoryInCollingOffPeriod.MergeFrom(other.StoryInCollingOffPeriod);
		}
		if (other.playerLeisureOverTime_ != null)
		{
			if (playerLeisureOverTime_ == null)
			{
				PlayerLeisureOverTime = new CalliopeCustom_DetectCondition_PlayerLeisureOverTime();
			}
			PlayerLeisureOverTime.MergeFrom(other.PlayerLeisureOverTime);
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
				DetectedElementType = input.ReadInt32();
				break;
			case 16u:
				IsReverseCondition = input.ReadBool();
				break;
			case 26u:
				Comment = input.ReadString();
				break;
			case 34u:
				if (simpleState_ == null)
				{
					SimpleState = new CalliopeCustom_DetectCondition_SimpleState();
				}
				input.ReadMessage(SimpleState);
				break;
			case 42u:
				if (unitState_ == null)
				{
					UnitState = new CalliopeCustom_DetectCondition_UnitState();
				}
				input.ReadMessage(UnitState);
				break;
			case 50u:
				if (hasBuff_ == null)
				{
					HasBuff = new CalliopeCustom_DetectCondition_HasBuff();
				}
				input.ReadMessage(HasBuff);
				break;
			case 58u:
				if (unitAttr_ == null)
				{
					UnitAttr = new CalliopeCustom_DetectCondition_UnitAttr();
				}
				input.ReadMessage(UnitAttr);
				break;
			case 66u:
				if (unitActived_ == null)
				{
					UnitActived = new CalliopeCustom_DetectCondition_UnitActived();
				}
				input.ReadMessage(UnitActived);
				break;
			case 74u:
				if (unitInActived_ == null)
				{
					UnitInActived = new CalliopeCustom_DetectCondition_UnitInActived();
				}
				input.ReadMessage(UnitInActived);
				break;
			case 82u:
				if (abnormalState_ == null)
				{
					AbnormalState = new CalliopeCustom_DetectCondition_AbnormalState();
				}
				input.ReadMessage(AbnormalState);
				break;
			case 90u:
				if (fsmState_ == null)
				{
					FsmState = new CalliopeCustom_DetectCondition_FsmState();
				}
				input.ReadMessage(FsmState);
				break;
			case 98u:
				if (skillCoolDown_ == null)
				{
					SkillCoolDown = new CalliopeCustom_DetectCondition_SkillCoolDown();
				}
				input.ReadMessage(SkillCoolDown);
				break;
			case 106u:
				if (distanceFromTarget_ == null)
				{
					DistanceFromTarget = new CalliopeCustom_DetectCondition_DistanceFromTarget();
				}
				input.ReadMessage(DistanceFromTarget);
				break;
			case 114u:
				if (skillCanCast_ == null)
				{
					SkillCanCast = new CalliopeCustom_DetectCondition_SkillCanCast();
				}
				input.ReadMessage(SkillCanCast);
				break;
			case 122u:
				if (customFsmState_ == null)
				{
					CustomFsmState = new CalliopeCustom_DetectCondition_CustomFsmState();
				}
				input.ReadMessage(CustomFsmState);
				break;
			case 130u:
				if (lastBeAttackedStiffLevel_ == null)
				{
					LastBeAttackedStiffLevel = new CalliopeCustom_DetectCondition_LastBeAttackedStiffLevel();
				}
				input.ReadMessage(LastBeAttackedStiffLevel);
				break;
			case 138u:
				if (distanceFromMaster_ == null)
				{
					DistanceFromMaster = new CalliopeCustom_DetectCondition_DistanceFromMaster();
				}
				input.ReadMessage(DistanceFromMaster);
				break;
			case 146u:
				if (actorYawRotation_ == null)
				{
					ActorYawRotation = new CalliopeCustom_DetectCondition_ActorYawRotation();
				}
				input.ReadMessage(ActorYawRotation);
				break;
			case 154u:
				if (globalCastSkillCount_ == null)
				{
					GlobalCastSkillCount = new CalliopeCustom_DetectCondition_GlobalCastSkillCount();
				}
				input.ReadMessage(GlobalCastSkillCount);
				break;
			case 162u:
				if (durCastSkill_ == null)
				{
					DurCastSkill = new CalliopeCustom_DetectCondition_DurCastSkill();
				}
				input.ReadMessage(DurCastSkill);
				break;
			case 170u:
				if (currentBeAttackedStiffLevel_ == null)
				{
					CurrentBeAttackedStiffLevel = new CalliopeCustom_DetectCondition_CurrentBeAttackedStiffLevel();
				}
				input.ReadMessage(CurrentBeAttackedStiffLevel);
				break;
			case 178u:
				if (curSkillCostDmgNum_ == null)
				{
					CurSkillCostDmgNum = new CalliopeCustom_DetectCondition_CurSkillCostDmgNum();
				}
				input.ReadMessage(CurSkillCostDmgNum);
				break;
			case 186u:
				if (socketUnitsDead_ == null)
				{
					SocketUnitsDead = new CalliopeCustom_DetectCondition_SocketUnitsDead();
				}
				input.ReadMessage(SocketUnitsDead);
				break;
			case 194u:
				if (distanceFromNearestPlayer_ == null)
				{
					DistanceFromNearestPlayer = new CalliopeCustom_DetectCondition_DistanceFromNearestPlayer();
				}
				input.ReadMessage(DistanceFromNearestPlayer);
				break;
			case 202u:
				if (specifyResIdUnitsDead_ == null)
				{
					SpecifyResIdUnitsDead = new CalliopeCustom_DetectCondition_SpecifyResIdUnitsDead();
				}
				input.ReadMessage(SpecifyResIdUnitsDead);
				break;
			case 210u:
				if (familySpecifyUnitAttr_ == null)
				{
					FamilySpecifyUnitAttr = new CalliopeCustom_DetectCondition_FamilySpecifyUnitAttr();
				}
				input.ReadMessage(FamilySpecifyUnitAttr);
				break;
			case 218u:
				if (random_ == null)
				{
					Random = new CalliopeCustom_DetectCondition_Random();
				}
				input.ReadMessage(Random);
				break;
			case 226u:
				if (familyUnitAliveNum_ == null)
				{
					FamilyUnitAliveNum = new CalliopeCustom_DetectCondition_FamilyUnitAliveNum();
				}
				input.ReadMessage(FamilyUnitAliveNum);
				break;
			case 234u:
				if (targetInAngleRange_ == null)
				{
					TargetInAngleRange = new CalliopeCustom_DetectCondition_TargetInAngleRange();
				}
				input.ReadMessage(TargetInAngleRange);
				break;
			case 242u:
				if (compareBuffLayer_ == null)
				{
					CompareBuffLayer = new CalliopeCustom_DetectCondition_CompareBuffLayer();
				}
				input.ReadMessage(CompareBuffLayer);
				break;
			case 250u:
				if (compareGamePlusCount_ == null)
				{
					CompareGamePlusCount = new CalliopeCustom_DetectCondition_CompareGamePlusCount();
				}
				input.ReadMessage(CompareGamePlusCount);
				break;
			case 258u:
				if (checkSurfaceType_ == null)
				{
					CheckSurfaceType = new CalliopeCustom_DetectCondition_CheckSurfaceType();
				}
				input.ReadMessage(CheckSurfaceType);
				break;
			case 266u:
				if (hasStoryCanTalkInThisLevel_ == null)
				{
					HasStoryCanTalkInThisLevel = new CalliopeCustom_DetectCondition_HasStoryCanTalkInThisLevel();
				}
				input.ReadMessage(HasStoryCanTalkInThisLevel);
				break;
			case 274u:
				if (storyInCollingOffPeriod_ == null)
				{
					StoryInCollingOffPeriod = new CalliopeCustom_DetectCondition_StoryInCollingOffPeriod();
				}
				input.ReadMessage(StoryInCollingOffPeriod);
				break;
			case 282u:
				if (playerLeisureOverTime_ == null)
				{
					PlayerLeisureOverTime = new CalliopeCustom_DetectCondition_PlayerLeisureOverTime();
				}
				input.ReadMessage(PlayerLeisureOverTime);
				break;
			}
		}
	}
}
