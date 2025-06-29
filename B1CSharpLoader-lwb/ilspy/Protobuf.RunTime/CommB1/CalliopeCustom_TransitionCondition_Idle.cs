using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class CalliopeCustom_TransitionCondition_Idle : IMessage<CalliopeCustom_TransitionCondition_Idle>, IMessage, IEquatable<CalliopeCustom_TransitionCondition_Idle>, IDeepCloneable<CalliopeCustom_TransitionCondition_Idle>
{
	private static readonly MessageParser<CalliopeCustom_TransitionCondition_Idle> _parser = new MessageParser<CalliopeCustom_TransitionCondition_Idle>(() => new CalliopeCustom_TransitionCondition_Idle());

	private UnknownFieldSet _unknownFields;

	private int conditionType_;

	private string overlapGuid_ = "";

	private string interactorGuid_ = "";

	private int gameStateCondition_;

	private float inAreaTimer_;

	private float outAreaTimer_;

	private string taskStageId_ = "";

	private int taskStageStatus_;

	private int interactGroupId_;

	private int interactStep_;

	private int owningItemId_;

	private int owningNum_;

	private int consumeItemId_;

	private int consumptionQuantity_;

	private bool isReverseCondition_;

	private string unitGuid_ = "";

	private string npcGuid_ = "";

	private string actorGuid_ = "";

	private float moveAcceptableRadius_;

	private int npcMoveType_;

	private int skillId_;

	private int gameplayCounterType_;

	private float gameplayCounterValue_;

	public static MessageParser<CalliopeCustom_TransitionCondition_Idle> Parser => _parser;

	public int ConditionType
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

	public string OverlapGuid
	{
		get
		{
			return overlapGuid_;
		}
		set
		{
			overlapGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string InteractorGuid
	{
		get
		{
			return interactorGuid_;
		}
		set
		{
			interactorGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int GameStateCondition
	{
		get
		{
			return gameStateCondition_;
		}
		set
		{
			gameStateCondition_ = value;
		}
	}

	public float InAreaTimer
	{
		get
		{
			return inAreaTimer_;
		}
		set
		{
			inAreaTimer_ = value;
		}
	}

	public float OutAreaTimer
	{
		get
		{
			return outAreaTimer_;
		}
		set
		{
			outAreaTimer_ = value;
		}
	}

	public string TaskStageId
	{
		get
		{
			return taskStageId_;
		}
		set
		{
			taskStageId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int TaskStageStatus
	{
		get
		{
			return taskStageStatus_;
		}
		set
		{
			taskStageStatus_ = value;
		}
	}

	public int InteractGroupId
	{
		get
		{
			return interactGroupId_;
		}
		set
		{
			interactGroupId_ = value;
		}
	}

	public int InteractStep
	{
		get
		{
			return interactStep_;
		}
		set
		{
			interactStep_ = value;
		}
	}

	public int OwningItemId
	{
		get
		{
			return owningItemId_;
		}
		set
		{
			owningItemId_ = value;
		}
	}

	public int OwningNum
	{
		get
		{
			return owningNum_;
		}
		set
		{
			owningNum_ = value;
		}
	}

	public int ConsumeItemId
	{
		get
		{
			return consumeItemId_;
		}
		set
		{
			consumeItemId_ = value;
		}
	}

	public int ConsumptionQuantity
	{
		get
		{
			return consumptionQuantity_;
		}
		set
		{
			consumptionQuantity_ = value;
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

	public string NpcGuid
	{
		get
		{
			return npcGuid_;
		}
		set
		{
			npcGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ActorGuid
	{
		get
		{
			return actorGuid_;
		}
		set
		{
			actorGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public int SkillId
	{
		get
		{
			return skillId_;
		}
		set
		{
			skillId_ = value;
		}
	}

	public int GameplayCounterType
	{
		get
		{
			return gameplayCounterType_;
		}
		set
		{
			gameplayCounterType_ = value;
		}
	}

	public float GameplayCounterValue
	{
		get
		{
			return gameplayCounterValue_;
		}
		set
		{
			gameplayCounterValue_ = value;
		}
	}

	public CalliopeCustom_TransitionCondition_Idle()
	{
	}

	public CalliopeCustom_TransitionCondition_Idle(CalliopeCustom_TransitionCondition_Idle other)
		: this()
	{
		conditionType_ = other.conditionType_;
		overlapGuid_ = other.overlapGuid_;
		interactorGuid_ = other.interactorGuid_;
		gameStateCondition_ = other.gameStateCondition_;
		inAreaTimer_ = other.inAreaTimer_;
		outAreaTimer_ = other.outAreaTimer_;
		taskStageId_ = other.taskStageId_;
		taskStageStatus_ = other.taskStageStatus_;
		interactGroupId_ = other.interactGroupId_;
		interactStep_ = other.interactStep_;
		owningItemId_ = other.owningItemId_;
		owningNum_ = other.owningNum_;
		consumeItemId_ = other.consumeItemId_;
		consumptionQuantity_ = other.consumptionQuantity_;
		isReverseCondition_ = other.isReverseCondition_;
		unitGuid_ = other.unitGuid_;
		npcGuid_ = other.npcGuid_;
		actorGuid_ = other.actorGuid_;
		moveAcceptableRadius_ = other.moveAcceptableRadius_;
		npcMoveType_ = other.npcMoveType_;
		skillId_ = other.skillId_;
		gameplayCounterType_ = other.gameplayCounterType_;
		gameplayCounterValue_ = other.gameplayCounterValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_TransitionCondition_Idle Clone()
	{
		return new CalliopeCustom_TransitionCondition_Idle(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_TransitionCondition_Idle);
	}

	public bool Equals(CalliopeCustom_TransitionCondition_Idle other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ConditionType != other.ConditionType)
		{
			return false;
		}
		if (OverlapGuid != other.OverlapGuid)
		{
			return false;
		}
		if (InteractorGuid != other.InteractorGuid)
		{
			return false;
		}
		if (GameStateCondition != other.GameStateCondition)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(InAreaTimer, other.InAreaTimer))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(OutAreaTimer, other.OutAreaTimer))
		{
			return false;
		}
		if (TaskStageId != other.TaskStageId)
		{
			return false;
		}
		if (TaskStageStatus != other.TaskStageStatus)
		{
			return false;
		}
		if (InteractGroupId != other.InteractGroupId)
		{
			return false;
		}
		if (InteractStep != other.InteractStep)
		{
			return false;
		}
		if (OwningItemId != other.OwningItemId)
		{
			return false;
		}
		if (OwningNum != other.OwningNum)
		{
			return false;
		}
		if (ConsumeItemId != other.ConsumeItemId)
		{
			return false;
		}
		if (ConsumptionQuantity != other.ConsumptionQuantity)
		{
			return false;
		}
		if (IsReverseCondition != other.IsReverseCondition)
		{
			return false;
		}
		if (UnitGuid != other.UnitGuid)
		{
			return false;
		}
		if (NpcGuid != other.NpcGuid)
		{
			return false;
		}
		if (ActorGuid != other.ActorGuid)
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
		if (SkillId != other.SkillId)
		{
			return false;
		}
		if (GameplayCounterType != other.GameplayCounterType)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(GameplayCounterValue, other.GameplayCounterValue))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ConditionType != 0)
		{
			num ^= ConditionType.GetHashCode();
		}
		if (OverlapGuid.Length != 0)
		{
			num ^= OverlapGuid.GetHashCode();
		}
		if (InteractorGuid.Length != 0)
		{
			num ^= InteractorGuid.GetHashCode();
		}
		if (GameStateCondition != 0)
		{
			num ^= GameStateCondition.GetHashCode();
		}
		if (InAreaTimer != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(InAreaTimer);
		}
		if (OutAreaTimer != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(OutAreaTimer);
		}
		if (TaskStageId.Length != 0)
		{
			num ^= TaskStageId.GetHashCode();
		}
		if (TaskStageStatus != 0)
		{
			num ^= TaskStageStatus.GetHashCode();
		}
		if (InteractGroupId != 0)
		{
			num ^= InteractGroupId.GetHashCode();
		}
		if (InteractStep != 0)
		{
			num ^= InteractStep.GetHashCode();
		}
		if (OwningItemId != 0)
		{
			num ^= OwningItemId.GetHashCode();
		}
		if (OwningNum != 0)
		{
			num ^= OwningNum.GetHashCode();
		}
		if (ConsumeItemId != 0)
		{
			num ^= ConsumeItemId.GetHashCode();
		}
		if (ConsumptionQuantity != 0)
		{
			num ^= ConsumptionQuantity.GetHashCode();
		}
		if (IsReverseCondition)
		{
			num ^= IsReverseCondition.GetHashCode();
		}
		if (UnitGuid.Length != 0)
		{
			num ^= UnitGuid.GetHashCode();
		}
		if (NpcGuid.Length != 0)
		{
			num ^= NpcGuid.GetHashCode();
		}
		if (ActorGuid.Length != 0)
		{
			num ^= ActorGuid.GetHashCode();
		}
		if (MoveAcceptableRadius != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MoveAcceptableRadius);
		}
		if (NpcMoveType != 0)
		{
			num ^= NpcMoveType.GetHashCode();
		}
		if (SkillId != 0)
		{
			num ^= SkillId.GetHashCode();
		}
		if (GameplayCounterType != 0)
		{
			num ^= GameplayCounterType.GetHashCode();
		}
		if (GameplayCounterValue != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(GameplayCounterValue);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ConditionType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ConditionType);
		}
		if (OverlapGuid.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(OverlapGuid);
		}
		if (InteractorGuid.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(InteractorGuid);
		}
		if (GameStateCondition != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(GameStateCondition);
		}
		if (InAreaTimer != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(InAreaTimer);
		}
		if (OutAreaTimer != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(OutAreaTimer);
		}
		if (TaskStageId.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(TaskStageId);
		}
		if (TaskStageStatus != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(TaskStageStatus);
		}
		if (InteractGroupId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(InteractGroupId);
		}
		if (InteractStep != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(InteractStep);
		}
		if (OwningItemId != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(OwningItemId);
		}
		if (OwningNum != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(OwningNum);
		}
		if (ConsumeItemId != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(ConsumeItemId);
		}
		if (ConsumptionQuantity != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(ConsumptionQuantity);
		}
		if (IsReverseCondition)
		{
			output.WriteRawTag(120);
			output.WriteBool(IsReverseCondition);
		}
		if (UnitGuid.Length != 0)
		{
			output.WriteRawTag(130, 1);
			output.WriteString(UnitGuid);
		}
		if (NpcGuid.Length != 0)
		{
			output.WriteRawTag(138, 1);
			output.WriteString(NpcGuid);
		}
		if (ActorGuid.Length != 0)
		{
			output.WriteRawTag(146, 1);
			output.WriteString(ActorGuid);
		}
		if (MoveAcceptableRadius != 0f)
		{
			output.WriteRawTag(157, 1);
			output.WriteFloat(MoveAcceptableRadius);
		}
		if (NpcMoveType != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(NpcMoveType);
		}
		if (SkillId != 0)
		{
			output.WriteRawTag(168, 1);
			output.WriteInt32(SkillId);
		}
		if (GameplayCounterType != 0)
		{
			output.WriteRawTag(176, 1);
			output.WriteInt32(GameplayCounterType);
		}
		if (GameplayCounterValue != 0f)
		{
			output.WriteRawTag(189, 1);
			output.WriteFloat(GameplayCounterValue);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ConditionType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionType);
		}
		if (OverlapGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(OverlapGuid);
		}
		if (InteractorGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(InteractorGuid);
		}
		if (GameStateCondition != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GameStateCondition);
		}
		if (InAreaTimer != 0f)
		{
			num += 5;
		}
		if (OutAreaTimer != 0f)
		{
			num += 5;
		}
		if (TaskStageId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TaskStageId);
		}
		if (TaskStageStatus != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TaskStageStatus);
		}
		if (InteractGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(InteractGroupId);
		}
		if (InteractStep != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(InteractStep);
		}
		if (OwningItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OwningItemId);
		}
		if (OwningNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OwningNum);
		}
		if (ConsumeItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConsumeItemId);
		}
		if (ConsumptionQuantity != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConsumptionQuantity);
		}
		if (IsReverseCondition)
		{
			num += 2;
		}
		if (UnitGuid.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(UnitGuid);
		}
		if (NpcGuid.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(NpcGuid);
		}
		if (ActorGuid.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(ActorGuid);
		}
		if (MoveAcceptableRadius != 0f)
		{
			num += 6;
		}
		if (NpcMoveType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(NpcMoveType);
		}
		if (SkillId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SkillId);
		}
		if (GameplayCounterType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(GameplayCounterType);
		}
		if (GameplayCounterValue != 0f)
		{
			num += 6;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_TransitionCondition_Idle other)
	{
		if (other != null)
		{
			if (other.ConditionType != 0)
			{
				ConditionType = other.ConditionType;
			}
			if (other.OverlapGuid.Length != 0)
			{
				OverlapGuid = other.OverlapGuid;
			}
			if (other.InteractorGuid.Length != 0)
			{
				InteractorGuid = other.InteractorGuid;
			}
			if (other.GameStateCondition != 0)
			{
				GameStateCondition = other.GameStateCondition;
			}
			if (other.InAreaTimer != 0f)
			{
				InAreaTimer = other.InAreaTimer;
			}
			if (other.OutAreaTimer != 0f)
			{
				OutAreaTimer = other.OutAreaTimer;
			}
			if (other.TaskStageId.Length != 0)
			{
				TaskStageId = other.TaskStageId;
			}
			if (other.TaskStageStatus != 0)
			{
				TaskStageStatus = other.TaskStageStatus;
			}
			if (other.InteractGroupId != 0)
			{
				InteractGroupId = other.InteractGroupId;
			}
			if (other.InteractStep != 0)
			{
				InteractStep = other.InteractStep;
			}
			if (other.OwningItemId != 0)
			{
				OwningItemId = other.OwningItemId;
			}
			if (other.OwningNum != 0)
			{
				OwningNum = other.OwningNum;
			}
			if (other.ConsumeItemId != 0)
			{
				ConsumeItemId = other.ConsumeItemId;
			}
			if (other.ConsumptionQuantity != 0)
			{
				ConsumptionQuantity = other.ConsumptionQuantity;
			}
			if (other.IsReverseCondition)
			{
				IsReverseCondition = other.IsReverseCondition;
			}
			if (other.UnitGuid.Length != 0)
			{
				UnitGuid = other.UnitGuid;
			}
			if (other.NpcGuid.Length != 0)
			{
				NpcGuid = other.NpcGuid;
			}
			if (other.ActorGuid.Length != 0)
			{
				ActorGuid = other.ActorGuid;
			}
			if (other.MoveAcceptableRadius != 0f)
			{
				MoveAcceptableRadius = other.MoveAcceptableRadius;
			}
			if (other.NpcMoveType != 0)
			{
				NpcMoveType = other.NpcMoveType;
			}
			if (other.SkillId != 0)
			{
				SkillId = other.SkillId;
			}
			if (other.GameplayCounterType != 0)
			{
				GameplayCounterType = other.GameplayCounterType;
			}
			if (other.GameplayCounterValue != 0f)
			{
				GameplayCounterValue = other.GameplayCounterValue;
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
				ConditionType = input.ReadInt32();
				break;
			case 18u:
				OverlapGuid = input.ReadString();
				break;
			case 26u:
				InteractorGuid = input.ReadString();
				break;
			case 32u:
				GameStateCondition = input.ReadInt32();
				break;
			case 45u:
				InAreaTimer = input.ReadFloat();
				break;
			case 53u:
				OutAreaTimer = input.ReadFloat();
				break;
			case 58u:
				TaskStageId = input.ReadString();
				break;
			case 64u:
				TaskStageStatus = input.ReadInt32();
				break;
			case 72u:
				InteractGroupId = input.ReadInt32();
				break;
			case 80u:
				InteractStep = input.ReadInt32();
				break;
			case 88u:
				OwningItemId = input.ReadInt32();
				break;
			case 96u:
				OwningNum = input.ReadInt32();
				break;
			case 104u:
				ConsumeItemId = input.ReadInt32();
				break;
			case 112u:
				ConsumptionQuantity = input.ReadInt32();
				break;
			case 120u:
				IsReverseCondition = input.ReadBool();
				break;
			case 130u:
				UnitGuid = input.ReadString();
				break;
			case 138u:
				NpcGuid = input.ReadString();
				break;
			case 146u:
				ActorGuid = input.ReadString();
				break;
			case 157u:
				MoveAcceptableRadius = input.ReadFloat();
				break;
			case 160u:
				NpcMoveType = input.ReadInt32();
				break;
			case 168u:
				SkillId = input.ReadInt32();
				break;
			case 176u:
				GameplayCounterType = input.ReadInt32();
				break;
			case 189u:
				GameplayCounterValue = input.ReadFloat();
				break;
			}
		}
	}
}
