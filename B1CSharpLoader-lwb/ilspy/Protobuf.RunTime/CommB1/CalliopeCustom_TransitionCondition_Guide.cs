using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class CalliopeCustom_TransitionCondition_Guide : IMessage<CalliopeCustom_TransitionCondition_Guide>, IMessage, IEquatable<CalliopeCustom_TransitionCondition_Guide>, IDeepCloneable<CalliopeCustom_TransitionCondition_Guide>
{
	private static readonly MessageParser<CalliopeCustom_TransitionCondition_Guide> _parser = new MessageParser<CalliopeCustom_TransitionCondition_Guide>(() => new CalliopeCustom_TransitionCondition_Guide());

	private UnknownFieldSet _unknownFields;

	private int conditionType_;

	private bool isReverseCondition_;

	private string pinName_ = "";

	private static readonly FieldCodec<int> _repeated_relatedGuideGroupId_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> relatedGuideGroupId_ = new RepeatedField<int>();

	private string overlapGuid_ = "";

	private int abnormalState_;

	private int rebirthPointId_;

	private string unitGuid_ = "";

	private int itemId_;

	private int checkRange_;

	private static readonly FieldCodec<int> _repeated_checkResIdList_codec = FieldCodec.ForInt32(90u);

	private readonly RepeatedField<int> checkResIdList_ = new RepeatedField<int>();

	private int attrFloatType_;

	private int compareOperation_;

	private float compareValue_;

	private string taskStageId_ = "";

	private int taskStageStatus_;

	private int mapId_;

	private int talentId_;

	private int uiPageType_;

	private int guideGroupId_;

	private int sequenceId_;

	private int sequencePhase_;

	private int itemNum_;

	public static MessageParser<CalliopeCustom_TransitionCondition_Guide> Parser => _parser;

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

	public string PinName
	{
		get
		{
			return pinName_;
		}
		set
		{
			pinName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<int> RelatedGuideGroupId => relatedGuideGroupId_;

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

	public int AbnormalState
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

	public int ItemId
	{
		get
		{
			return itemId_;
		}
		set
		{
			itemId_ = value;
		}
	}

	public int CheckRange
	{
		get
		{
			return checkRange_;
		}
		set
		{
			checkRange_ = value;
		}
	}

	public RepeatedField<int> CheckResIdList => checkResIdList_;

	public int AttrFloatType
	{
		get
		{
			return attrFloatType_;
		}
		set
		{
			attrFloatType_ = value;
		}
	}

	public int CompareOperation
	{
		get
		{
			return compareOperation_;
		}
		set
		{
			compareOperation_ = value;
		}
	}

	public float CompareValue
	{
		get
		{
			return compareValue_;
		}
		set
		{
			compareValue_ = value;
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

	public int MapId
	{
		get
		{
			return mapId_;
		}
		set
		{
			mapId_ = value;
		}
	}

	public int TalentId
	{
		get
		{
			return talentId_;
		}
		set
		{
			talentId_ = value;
		}
	}

	public int UiPageType
	{
		get
		{
			return uiPageType_;
		}
		set
		{
			uiPageType_ = value;
		}
	}

	public int GuideGroupId
	{
		get
		{
			return guideGroupId_;
		}
		set
		{
			guideGroupId_ = value;
		}
	}

	public int SequenceId
	{
		get
		{
			return sequenceId_;
		}
		set
		{
			sequenceId_ = value;
		}
	}

	public int SequencePhase
	{
		get
		{
			return sequencePhase_;
		}
		set
		{
			sequencePhase_ = value;
		}
	}

	public int ItemNum
	{
		get
		{
			return itemNum_;
		}
		set
		{
			itemNum_ = value;
		}
	}

	public CalliopeCustom_TransitionCondition_Guide()
	{
	}

	public CalliopeCustom_TransitionCondition_Guide(CalliopeCustom_TransitionCondition_Guide other)
		: this()
	{
		conditionType_ = other.conditionType_;
		isReverseCondition_ = other.isReverseCondition_;
		pinName_ = other.pinName_;
		relatedGuideGroupId_ = other.relatedGuideGroupId_.Clone();
		overlapGuid_ = other.overlapGuid_;
		abnormalState_ = other.abnormalState_;
		rebirthPointId_ = other.rebirthPointId_;
		unitGuid_ = other.unitGuid_;
		itemId_ = other.itemId_;
		checkRange_ = other.checkRange_;
		checkResIdList_ = other.checkResIdList_.Clone();
		attrFloatType_ = other.attrFloatType_;
		compareOperation_ = other.compareOperation_;
		compareValue_ = other.compareValue_;
		taskStageId_ = other.taskStageId_;
		taskStageStatus_ = other.taskStageStatus_;
		mapId_ = other.mapId_;
		talentId_ = other.talentId_;
		uiPageType_ = other.uiPageType_;
		guideGroupId_ = other.guideGroupId_;
		sequenceId_ = other.sequenceId_;
		sequencePhase_ = other.sequencePhase_;
		itemNum_ = other.itemNum_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_TransitionCondition_Guide Clone()
	{
		return new CalliopeCustom_TransitionCondition_Guide(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_TransitionCondition_Guide);
	}

	public bool Equals(CalliopeCustom_TransitionCondition_Guide other)
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
		if (IsReverseCondition != other.IsReverseCondition)
		{
			return false;
		}
		if (PinName != other.PinName)
		{
			return false;
		}
		if (!relatedGuideGroupId_.Equals(other.relatedGuideGroupId_))
		{
			return false;
		}
		if (OverlapGuid != other.OverlapGuid)
		{
			return false;
		}
		if (AbnormalState != other.AbnormalState)
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
		if (ItemId != other.ItemId)
		{
			return false;
		}
		if (CheckRange != other.CheckRange)
		{
			return false;
		}
		if (!checkResIdList_.Equals(other.checkResIdList_))
		{
			return false;
		}
		if (AttrFloatType != other.AttrFloatType)
		{
			return false;
		}
		if (CompareOperation != other.CompareOperation)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CompareValue, other.CompareValue))
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
		if (MapId != other.MapId)
		{
			return false;
		}
		if (TalentId != other.TalentId)
		{
			return false;
		}
		if (UiPageType != other.UiPageType)
		{
			return false;
		}
		if (GuideGroupId != other.GuideGroupId)
		{
			return false;
		}
		if (SequenceId != other.SequenceId)
		{
			return false;
		}
		if (SequencePhase != other.SequencePhase)
		{
			return false;
		}
		if (ItemNum != other.ItemNum)
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
		if (IsReverseCondition)
		{
			num ^= IsReverseCondition.GetHashCode();
		}
		if (PinName.Length != 0)
		{
			num ^= PinName.GetHashCode();
		}
		num ^= relatedGuideGroupId_.GetHashCode();
		if (OverlapGuid.Length != 0)
		{
			num ^= OverlapGuid.GetHashCode();
		}
		if (AbnormalState != 0)
		{
			num ^= AbnormalState.GetHashCode();
		}
		if (RebirthPointId != 0)
		{
			num ^= RebirthPointId.GetHashCode();
		}
		if (UnitGuid.Length != 0)
		{
			num ^= UnitGuid.GetHashCode();
		}
		if (ItemId != 0)
		{
			num ^= ItemId.GetHashCode();
		}
		if (CheckRange != 0)
		{
			num ^= CheckRange.GetHashCode();
		}
		num ^= checkResIdList_.GetHashCode();
		if (AttrFloatType != 0)
		{
			num ^= AttrFloatType.GetHashCode();
		}
		if (CompareOperation != 0)
		{
			num ^= CompareOperation.GetHashCode();
		}
		if (CompareValue != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CompareValue);
		}
		if (TaskStageId.Length != 0)
		{
			num ^= TaskStageId.GetHashCode();
		}
		if (TaskStageStatus != 0)
		{
			num ^= TaskStageStatus.GetHashCode();
		}
		if (MapId != 0)
		{
			num ^= MapId.GetHashCode();
		}
		if (TalentId != 0)
		{
			num ^= TalentId.GetHashCode();
		}
		if (UiPageType != 0)
		{
			num ^= UiPageType.GetHashCode();
		}
		if (GuideGroupId != 0)
		{
			num ^= GuideGroupId.GetHashCode();
		}
		if (SequenceId != 0)
		{
			num ^= SequenceId.GetHashCode();
		}
		if (SequencePhase != 0)
		{
			num ^= SequencePhase.GetHashCode();
		}
		if (ItemNum != 0)
		{
			num ^= ItemNum.GetHashCode();
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
		if (IsReverseCondition)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsReverseCondition);
		}
		if (PinName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(PinName);
		}
		relatedGuideGroupId_.WriteTo(output, _repeated_relatedGuideGroupId_codec);
		if (OverlapGuid.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(OverlapGuid);
		}
		if (AbnormalState != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(AbnormalState);
		}
		if (RebirthPointId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(RebirthPointId);
		}
		if (UnitGuid.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(UnitGuid);
		}
		if (ItemId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(ItemId);
		}
		if (CheckRange != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(CheckRange);
		}
		checkResIdList_.WriteTo(output, _repeated_checkResIdList_codec);
		if (AttrFloatType != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(AttrFloatType);
		}
		if (CompareOperation != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(CompareOperation);
		}
		if (CompareValue != 0f)
		{
			output.WriteRawTag(117);
			output.WriteFloat(CompareValue);
		}
		if (TaskStageId.Length != 0)
		{
			output.WriteRawTag(122);
			output.WriteString(TaskStageId);
		}
		if (TaskStageStatus != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(TaskStageStatus);
		}
		if (MapId != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(MapId);
		}
		if (TalentId != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteInt32(TalentId);
		}
		if (UiPageType != 0)
		{
			output.WriteRawTag(152, 1);
			output.WriteInt32(UiPageType);
		}
		if (GuideGroupId != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(GuideGroupId);
		}
		if (SequenceId != 0)
		{
			output.WriteRawTag(168, 1);
			output.WriteInt32(SequenceId);
		}
		if (SequencePhase != 0)
		{
			output.WriteRawTag(176, 1);
			output.WriteInt32(SequencePhase);
		}
		if (ItemNum != 0)
		{
			output.WriteRawTag(184, 1);
			output.WriteInt32(ItemNum);
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
		if (IsReverseCondition)
		{
			num += 2;
		}
		if (PinName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PinName);
		}
		num += relatedGuideGroupId_.CalculateSize(_repeated_relatedGuideGroupId_codec);
		if (OverlapGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(OverlapGuid);
		}
		if (AbnormalState != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AbnormalState);
		}
		if (RebirthPointId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RebirthPointId);
		}
		if (UnitGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UnitGuid);
		}
		if (ItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemId);
		}
		if (CheckRange != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CheckRange);
		}
		num += checkResIdList_.CalculateSize(_repeated_checkResIdList_codec);
		if (AttrFloatType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AttrFloatType);
		}
		if (CompareOperation != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CompareOperation);
		}
		if (CompareValue != 0f)
		{
			num += 5;
		}
		if (TaskStageId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TaskStageId);
		}
		if (TaskStageStatus != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TaskStageStatus);
		}
		if (MapId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(MapId);
		}
		if (TalentId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TalentId);
		}
		if (UiPageType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(UiPageType);
		}
		if (GuideGroupId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(GuideGroupId);
		}
		if (SequenceId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SequenceId);
		}
		if (SequencePhase != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SequencePhase);
		}
		if (ItemNum != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ItemNum);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_TransitionCondition_Guide other)
	{
		if (other != null)
		{
			if (other.ConditionType != 0)
			{
				ConditionType = other.ConditionType;
			}
			if (other.IsReverseCondition)
			{
				IsReverseCondition = other.IsReverseCondition;
			}
			if (other.PinName.Length != 0)
			{
				PinName = other.PinName;
			}
			relatedGuideGroupId_.Add(other.relatedGuideGroupId_);
			if (other.OverlapGuid.Length != 0)
			{
				OverlapGuid = other.OverlapGuid;
			}
			if (other.AbnormalState != 0)
			{
				AbnormalState = other.AbnormalState;
			}
			if (other.RebirthPointId != 0)
			{
				RebirthPointId = other.RebirthPointId;
			}
			if (other.UnitGuid.Length != 0)
			{
				UnitGuid = other.UnitGuid;
			}
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}
			if (other.CheckRange != 0)
			{
				CheckRange = other.CheckRange;
			}
			checkResIdList_.Add(other.checkResIdList_);
			if (other.AttrFloatType != 0)
			{
				AttrFloatType = other.AttrFloatType;
			}
			if (other.CompareOperation != 0)
			{
				CompareOperation = other.CompareOperation;
			}
			if (other.CompareValue != 0f)
			{
				CompareValue = other.CompareValue;
			}
			if (other.TaskStageId.Length != 0)
			{
				TaskStageId = other.TaskStageId;
			}
			if (other.TaskStageStatus != 0)
			{
				TaskStageStatus = other.TaskStageStatus;
			}
			if (other.MapId != 0)
			{
				MapId = other.MapId;
			}
			if (other.TalentId != 0)
			{
				TalentId = other.TalentId;
			}
			if (other.UiPageType != 0)
			{
				UiPageType = other.UiPageType;
			}
			if (other.GuideGroupId != 0)
			{
				GuideGroupId = other.GuideGroupId;
			}
			if (other.SequenceId != 0)
			{
				SequenceId = other.SequenceId;
			}
			if (other.SequencePhase != 0)
			{
				SequencePhase = other.SequencePhase;
			}
			if (other.ItemNum != 0)
			{
				ItemNum = other.ItemNum;
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
			case 16u:
				IsReverseCondition = input.ReadBool();
				break;
			case 26u:
				PinName = input.ReadString();
				break;
			case 32u:
			case 34u:
				relatedGuideGroupId_.AddEntriesFrom(input, _repeated_relatedGuideGroupId_codec);
				break;
			case 42u:
				OverlapGuid = input.ReadString();
				break;
			case 48u:
				AbnormalState = input.ReadInt32();
				break;
			case 56u:
				RebirthPointId = input.ReadInt32();
				break;
			case 66u:
				UnitGuid = input.ReadString();
				break;
			case 72u:
				ItemId = input.ReadInt32();
				break;
			case 80u:
				CheckRange = input.ReadInt32();
				break;
			case 88u:
			case 90u:
				checkResIdList_.AddEntriesFrom(input, _repeated_checkResIdList_codec);
				break;
			case 96u:
				AttrFloatType = input.ReadInt32();
				break;
			case 104u:
				CompareOperation = input.ReadInt32();
				break;
			case 117u:
				CompareValue = input.ReadFloat();
				break;
			case 122u:
				TaskStageId = input.ReadString();
				break;
			case 128u:
				TaskStageStatus = input.ReadInt32();
				break;
			case 136u:
				MapId = input.ReadInt32();
				break;
			case 144u:
				TalentId = input.ReadInt32();
				break;
			case 152u:
				UiPageType = input.ReadInt32();
				break;
			case 160u:
				GuideGroupId = input.ReadInt32();
				break;
			case 168u:
				SequenceId = input.ReadInt32();
				break;
			case 176u:
				SequencePhase = input.ReadInt32();
				break;
			case 184u:
				ItemNum = input.ReadInt32();
				break;
			}
		}
	}
}
