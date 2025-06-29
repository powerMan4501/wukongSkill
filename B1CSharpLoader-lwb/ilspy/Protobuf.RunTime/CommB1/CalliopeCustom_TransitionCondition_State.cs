using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class CalliopeCustom_TransitionCondition_State : IMessage<CalliopeCustom_TransitionCondition_State>, IMessage, IEquatable<CalliopeCustom_TransitionCondition_State>, IDeepCloneable<CalliopeCustom_TransitionCondition_State>
{
	private static readonly MessageParser<CalliopeCustom_TransitionCondition_State> _parser = new MessageParser<CalliopeCustom_TransitionCondition_State>(() => new CalliopeCustom_TransitionCondition_State());

	private UnknownFieldSet _unknownFields;

	private int conditionType_;

	private string overlapGuid_ = "";

	private string interactorGuid_ = "";

	private static readonly FieldCodec<string> _repeated_units_codec = FieldCodec.ForString(34u);

	private readonly RepeatedField<string> units_ = new RepeatedField<string>();

	private string spawner_ = "";

	private string unitGuid_ = "";

	private int buffId_;

	private int sequenceId_;

	private int taskStageId_;

	private int taskStageStatus_;

	private string gameplayCounterGuid_ = "";

	private int gameplayCounterType_;

	private float gameplayCounterValue_;

	private string circusNickName_ = "";

	public static MessageParser<CalliopeCustom_TransitionCondition_State> Parser => _parser;

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

	public int BuffId
	{
		get
		{
			return buffId_;
		}
		set
		{
			buffId_ = value;
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

	public int TaskStageId
	{
		get
		{
			return taskStageId_;
		}
		set
		{
			taskStageId_ = value;
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

	public string GameplayCounterGuid
	{
		get
		{
			return gameplayCounterGuid_;
		}
		set
		{
			gameplayCounterGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public string CircusNickName
	{
		get
		{
			return circusNickName_;
		}
		set
		{
			circusNickName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public CalliopeCustom_TransitionCondition_State()
	{
	}

	public CalliopeCustom_TransitionCondition_State(CalliopeCustom_TransitionCondition_State other)
		: this()
	{
		conditionType_ = other.conditionType_;
		overlapGuid_ = other.overlapGuid_;
		interactorGuid_ = other.interactorGuid_;
		units_ = other.units_.Clone();
		spawner_ = other.spawner_;
		unitGuid_ = other.unitGuid_;
		buffId_ = other.buffId_;
		sequenceId_ = other.sequenceId_;
		taskStageId_ = other.taskStageId_;
		taskStageStatus_ = other.taskStageStatus_;
		gameplayCounterGuid_ = other.gameplayCounterGuid_;
		gameplayCounterType_ = other.gameplayCounterType_;
		gameplayCounterValue_ = other.gameplayCounterValue_;
		circusNickName_ = other.circusNickName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_TransitionCondition_State Clone()
	{
		return new CalliopeCustom_TransitionCondition_State(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_TransitionCondition_State);
	}

	public bool Equals(CalliopeCustom_TransitionCondition_State other)
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
		if (GameplayCounterGuid != other.GameplayCounterGuid)
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
		if (CircusNickName != other.CircusNickName)
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
		num ^= units_.GetHashCode();
		if (Spawner.Length != 0)
		{
			num ^= Spawner.GetHashCode();
		}
		if (UnitGuid.Length != 0)
		{
			num ^= UnitGuid.GetHashCode();
		}
		if (BuffId != 0)
		{
			num ^= BuffId.GetHashCode();
		}
		if (SequenceId != 0)
		{
			num ^= SequenceId.GetHashCode();
		}
		if (TaskStageId != 0)
		{
			num ^= TaskStageId.GetHashCode();
		}
		if (TaskStageStatus != 0)
		{
			num ^= TaskStageStatus.GetHashCode();
		}
		if (GameplayCounterGuid.Length != 0)
		{
			num ^= GameplayCounterGuid.GetHashCode();
		}
		if (GameplayCounterType != 0)
		{
			num ^= GameplayCounterType.GetHashCode();
		}
		if (GameplayCounterValue != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(GameplayCounterValue);
		}
		if (CircusNickName.Length != 0)
		{
			num ^= CircusNickName.GetHashCode();
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
		units_.WriteTo(output, _repeated_units_codec);
		if (Spawner.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(Spawner);
		}
		if (UnitGuid.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(UnitGuid);
		}
		if (BuffId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(BuffId);
		}
		if (SequenceId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(SequenceId);
		}
		if (TaskStageId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(TaskStageId);
		}
		if (TaskStageStatus != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(TaskStageStatus);
		}
		if (GameplayCounterGuid.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(GameplayCounterGuid);
		}
		if (GameplayCounterType != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(GameplayCounterType);
		}
		if (GameplayCounterValue != 0f)
		{
			output.WriteRawTag(109);
			output.WriteFloat(GameplayCounterValue);
		}
		if (CircusNickName.Length != 0)
		{
			output.WriteRawTag(114);
			output.WriteString(CircusNickName);
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
		num += units_.CalculateSize(_repeated_units_codec);
		if (Spawner.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Spawner);
		}
		if (UnitGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UnitGuid);
		}
		if (BuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffId);
		}
		if (SequenceId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SequenceId);
		}
		if (TaskStageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TaskStageId);
		}
		if (TaskStageStatus != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TaskStageStatus);
		}
		if (GameplayCounterGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GameplayCounterGuid);
		}
		if (GameplayCounterType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GameplayCounterType);
		}
		if (GameplayCounterValue != 0f)
		{
			num += 5;
		}
		if (CircusNickName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CircusNickName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_TransitionCondition_State other)
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
			units_.Add(other.units_);
			if (other.Spawner.Length != 0)
			{
				Spawner = other.Spawner;
			}
			if (other.UnitGuid.Length != 0)
			{
				UnitGuid = other.UnitGuid;
			}
			if (other.BuffId != 0)
			{
				BuffId = other.BuffId;
			}
			if (other.SequenceId != 0)
			{
				SequenceId = other.SequenceId;
			}
			if (other.TaskStageId != 0)
			{
				TaskStageId = other.TaskStageId;
			}
			if (other.TaskStageStatus != 0)
			{
				TaskStageStatus = other.TaskStageStatus;
			}
			if (other.GameplayCounterGuid.Length != 0)
			{
				GameplayCounterGuid = other.GameplayCounterGuid;
			}
			if (other.GameplayCounterType != 0)
			{
				GameplayCounterType = other.GameplayCounterType;
			}
			if (other.GameplayCounterValue != 0f)
			{
				GameplayCounterValue = other.GameplayCounterValue;
			}
			if (other.CircusNickName.Length != 0)
			{
				CircusNickName = other.CircusNickName;
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
			case 34u:
				units_.AddEntriesFrom(input, _repeated_units_codec);
				break;
			case 42u:
				Spawner = input.ReadString();
				break;
			case 50u:
				UnitGuid = input.ReadString();
				break;
			case 56u:
				BuffId = input.ReadInt32();
				break;
			case 64u:
				SequenceId = input.ReadInt32();
				break;
			case 72u:
				TaskStageId = input.ReadInt32();
				break;
			case 80u:
				TaskStageStatus = input.ReadInt32();
				break;
			case 90u:
				GameplayCounterGuid = input.ReadString();
				break;
			case 96u:
				GameplayCounterType = input.ReadInt32();
				break;
			case 109u:
				GameplayCounterValue = input.ReadFloat();
				break;
			case 114u:
				CircusNickName = input.ReadString();
				break;
			}
		}
	}
}
