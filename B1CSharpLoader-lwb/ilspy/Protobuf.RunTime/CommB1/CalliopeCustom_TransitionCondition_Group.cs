using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class CalliopeCustom_TransitionCondition_Group : IMessage<CalliopeCustom_TransitionCondition_Group>, IMessage, IEquatable<CalliopeCustom_TransitionCondition_Group>, IDeepCloneable<CalliopeCustom_TransitionCondition_Group>
{
	private static readonly MessageParser<CalliopeCustom_TransitionCondition_Group> _parser = new MessageParser<CalliopeCustom_TransitionCondition_Group>(() => new CalliopeCustom_TransitionCondition_Group());

	private UnknownFieldSet _unknownFields;

	private int conditionType_;

	private string overlapGuid_ = "";

	private string interactorGuid_ = "";

	private int gameStateCondition_;

	private static readonly FieldCodec<string> _repeated_units_codec = FieldCodec.ForString(42u);

	private readonly RepeatedField<string> units_ = new RepeatedField<string>();

	private string spawner_ = "";

	private string unitGuid_ = "";

	private string buffId_ = "";

	private static readonly FieldCodec<string> _repeated_killOrder_codec = FieldCodec.ForString(74u);

	private readonly RepeatedField<string> killOrder_ = new RepeatedField<string>();

	private string sequenceId_ = "";

	private string taskStageId_ = "";

	private int taskStageStatus_;

	private bool isReverseCondition_;

	public static MessageParser<CalliopeCustom_TransitionCondition_Group> Parser => _parser;

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

	public RepeatedField<string> Units => units_;

	public string Spawner
	{
		get
		{
			return spawner_;
		}
		set
		{
			spawner_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public string BuffId
	{
		get
		{
			return buffId_;
		}
		set
		{
			buffId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<string> KillOrder => killOrder_;

	public string SequenceId
	{
		get
		{
			return sequenceId_;
		}
		set
		{
			sequenceId_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public CalliopeCustom_TransitionCondition_Group()
	{
	}

	public CalliopeCustom_TransitionCondition_Group(CalliopeCustom_TransitionCondition_Group other)
		: this()
	{
		conditionType_ = other.conditionType_;
		overlapGuid_ = other.overlapGuid_;
		interactorGuid_ = other.interactorGuid_;
		gameStateCondition_ = other.gameStateCondition_;
		units_ = other.units_.Clone();
		spawner_ = other.spawner_;
		unitGuid_ = other.unitGuid_;
		buffId_ = other.buffId_;
		killOrder_ = other.killOrder_.Clone();
		sequenceId_ = other.sequenceId_;
		taskStageId_ = other.taskStageId_;
		taskStageStatus_ = other.taskStageStatus_;
		isReverseCondition_ = other.isReverseCondition_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_TransitionCondition_Group Clone()
	{
		return new CalliopeCustom_TransitionCondition_Group(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_TransitionCondition_Group);
	}

	public bool Equals(CalliopeCustom_TransitionCondition_Group other)
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
		if (!units_.Equals(other.units_))
		{
			return false;
		}
		if (Spawner != other.Spawner)
		{
			return false;
		}
		if (UnitGuid != other.UnitGuid)
		{
			return false;
		}
		if (BuffId != other.BuffId)
		{
			return false;
		}
		if (!killOrder_.Equals(other.killOrder_))
		{
			return false;
		}
		if (SequenceId != other.SequenceId)
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
		if (IsReverseCondition != other.IsReverseCondition)
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
		num ^= units_.GetHashCode();
		if (Spawner.Length != 0)
		{
			num ^= Spawner.GetHashCode();
		}
		if (UnitGuid.Length != 0)
		{
			num ^= UnitGuid.GetHashCode();
		}
		if (BuffId.Length != 0)
		{
			num ^= BuffId.GetHashCode();
		}
		num ^= killOrder_.GetHashCode();
		if (SequenceId.Length != 0)
		{
			num ^= SequenceId.GetHashCode();
		}
		if (TaskStageId.Length != 0)
		{
			num ^= TaskStageId.GetHashCode();
		}
		if (TaskStageStatus != 0)
		{
			num ^= TaskStageStatus.GetHashCode();
		}
		if (IsReverseCondition)
		{
			num ^= IsReverseCondition.GetHashCode();
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
		units_.WriteTo(output, _repeated_units_codec);
		if (Spawner.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(Spawner);
		}
		if (UnitGuid.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(UnitGuid);
		}
		if (BuffId.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(BuffId);
		}
		killOrder_.WriteTo(output, _repeated_killOrder_codec);
		if (SequenceId.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(SequenceId);
		}
		if (TaskStageId.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(TaskStageId);
		}
		if (TaskStageStatus != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(TaskStageStatus);
		}
		if (IsReverseCondition)
		{
			output.WriteRawTag(104);
			output.WriteBool(IsReverseCondition);
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
		num += units_.CalculateSize(_repeated_units_codec);
		if (Spawner.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Spawner);
		}
		if (UnitGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UnitGuid);
		}
		if (BuffId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BuffId);
		}
		num += killOrder_.CalculateSize(_repeated_killOrder_codec);
		if (SequenceId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SequenceId);
		}
		if (TaskStageId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TaskStageId);
		}
		if (TaskStageStatus != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TaskStageStatus);
		}
		if (IsReverseCondition)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_TransitionCondition_Group other)
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
			units_.Add(other.units_);
			if (other.Spawner.Length != 0)
			{
				Spawner = other.Spawner;
			}
			if (other.UnitGuid.Length != 0)
			{
				UnitGuid = other.UnitGuid;
			}
			if (other.BuffId.Length != 0)
			{
				BuffId = other.BuffId;
			}
			killOrder_.Add(other.killOrder_);
			if (other.SequenceId.Length != 0)
			{
				SequenceId = other.SequenceId;
			}
			if (other.TaskStageId.Length != 0)
			{
				TaskStageId = other.TaskStageId;
			}
			if (other.TaskStageStatus != 0)
			{
				TaskStageStatus = other.TaskStageStatus;
			}
			if (other.IsReverseCondition)
			{
				IsReverseCondition = other.IsReverseCondition;
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
			case 42u:
				units_.AddEntriesFrom(input, _repeated_units_codec);
				break;
			case 50u:
				Spawner = input.ReadString();
				break;
			case 58u:
				UnitGuid = input.ReadString();
				break;
			case 66u:
				BuffId = input.ReadString();
				break;
			case 74u:
				killOrder_.AddEntriesFrom(input, _repeated_killOrder_codec);
				break;
			case 82u:
				SequenceId = input.ReadString();
				break;
			case 90u:
				TaskStageId = input.ReadString();
				break;
			case 96u:
				TaskStageStatus = input.ReadInt32();
				break;
			case 104u:
				IsReverseCondition = input.ReadBool();
				break;
			}
		}
	}
}
