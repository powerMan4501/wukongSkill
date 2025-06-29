using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class CalliopeCustom_TransitionCondition_Battle : IMessage<CalliopeCustom_TransitionCondition_Battle>, IMessage, IEquatable<CalliopeCustom_TransitionCondition_Battle>, IDeepCloneable<CalliopeCustom_TransitionCondition_Battle>
{
	private static readonly MessageParser<CalliopeCustom_TransitionCondition_Battle> _parser = new MessageParser<CalliopeCustom_TransitionCondition_Battle>(() => new CalliopeCustom_TransitionCondition_Battle());

	private UnknownFieldSet _unknownFields;

	private int conditionType_;

	private static readonly FieldCodec<string> _repeated_units_codec = FieldCodec.ForString(18u);

	private readonly RepeatedField<string> units_ = new RepeatedField<string>();

	private string spawner_ = "";

	private string unitGuid_ = "";

	private string buffId_ = "";

	private static readonly FieldCodec<string> _repeated_killOrder_codec = FieldCodec.ForString(50u);

	private readonly RepeatedField<string> killOrder_ = new RepeatedField<string>();

	private string groupUnit_ = "";

	private string overlapGuid_ = "";

	private int unitDeadNum_;

	private int countdownTime_;

	private bool isReverseCondition_;

	public static MessageParser<CalliopeCustom_TransitionCondition_Battle> Parser => _parser;

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

	public string GroupUnit
	{
		get
		{
			return groupUnit_;
		}
		set
		{
			groupUnit_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public int UnitDeadNum
	{
		get
		{
			return unitDeadNum_;
		}
		set
		{
			unitDeadNum_ = value;
		}
	}

	public int CountdownTime
	{
		get
		{
			return countdownTime_;
		}
		set
		{
			countdownTime_ = value;
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

	public CalliopeCustom_TransitionCondition_Battle()
	{
	}

	public CalliopeCustom_TransitionCondition_Battle(CalliopeCustom_TransitionCondition_Battle other)
		: this()
	{
		conditionType_ = other.conditionType_;
		units_ = other.units_.Clone();
		spawner_ = other.spawner_;
		unitGuid_ = other.unitGuid_;
		buffId_ = other.buffId_;
		killOrder_ = other.killOrder_.Clone();
		groupUnit_ = other.groupUnit_;
		overlapGuid_ = other.overlapGuid_;
		unitDeadNum_ = other.unitDeadNum_;
		countdownTime_ = other.countdownTime_;
		isReverseCondition_ = other.isReverseCondition_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_TransitionCondition_Battle Clone()
	{
		return new CalliopeCustom_TransitionCondition_Battle(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_TransitionCondition_Battle);
	}

	public bool Equals(CalliopeCustom_TransitionCondition_Battle other)
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
		if (GroupUnit != other.GroupUnit)
		{
			return false;
		}
		if (OverlapGuid != other.OverlapGuid)
		{
			return false;
		}
		if (UnitDeadNum != other.UnitDeadNum)
		{
			return false;
		}
		if (CountdownTime != other.CountdownTime)
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
		if (GroupUnit.Length != 0)
		{
			num ^= GroupUnit.GetHashCode();
		}
		if (OverlapGuid.Length != 0)
		{
			num ^= OverlapGuid.GetHashCode();
		}
		if (UnitDeadNum != 0)
		{
			num ^= UnitDeadNum.GetHashCode();
		}
		if (CountdownTime != 0)
		{
			num ^= CountdownTime.GetHashCode();
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
		units_.WriteTo(output, _repeated_units_codec);
		if (Spawner.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Spawner);
		}
		if (UnitGuid.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(UnitGuid);
		}
		if (BuffId.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(BuffId);
		}
		killOrder_.WriteTo(output, _repeated_killOrder_codec);
		if (GroupUnit.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(GroupUnit);
		}
		if (OverlapGuid.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(OverlapGuid);
		}
		if (UnitDeadNum != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(UnitDeadNum);
		}
		if (CountdownTime != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(CountdownTime);
		}
		if (IsReverseCondition)
		{
			output.WriteRawTag(88);
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
		if (GroupUnit.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GroupUnit);
		}
		if (OverlapGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(OverlapGuid);
		}
		if (UnitDeadNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnitDeadNum);
		}
		if (CountdownTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CountdownTime);
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

	public void MergeFrom(CalliopeCustom_TransitionCondition_Battle other)
	{
		if (other != null)
		{
			if (other.ConditionType != 0)
			{
				ConditionType = other.ConditionType;
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
			if (other.GroupUnit.Length != 0)
			{
				GroupUnit = other.GroupUnit;
			}
			if (other.OverlapGuid.Length != 0)
			{
				OverlapGuid = other.OverlapGuid;
			}
			if (other.UnitDeadNum != 0)
			{
				UnitDeadNum = other.UnitDeadNum;
			}
			if (other.CountdownTime != 0)
			{
				CountdownTime = other.CountdownTime;
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
				units_.AddEntriesFrom(input, _repeated_units_codec);
				break;
			case 26u:
				Spawner = input.ReadString();
				break;
			case 34u:
				UnitGuid = input.ReadString();
				break;
			case 42u:
				BuffId = input.ReadString();
				break;
			case 50u:
				killOrder_.AddEntriesFrom(input, _repeated_killOrder_codec);
				break;
			case 58u:
				GroupUnit = input.ReadString();
				break;
			case 66u:
				OverlapGuid = input.ReadString();
				break;
			case 72u:
				UnitDeadNum = input.ReadInt32();
				break;
			case 80u:
				CountdownTime = input.ReadInt32();
				break;
			case 88u:
				IsReverseCondition = input.ReadBool();
				break;
			}
		}
	}
}
