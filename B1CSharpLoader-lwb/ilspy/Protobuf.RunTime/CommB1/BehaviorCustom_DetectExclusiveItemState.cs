using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class BehaviorCustom_DetectExclusiveItemState : IMessage<BehaviorCustom_DetectExclusiveItemState>, IMessage, IEquatable<BehaviorCustom_DetectExclusiveItemState>, IDeepCloneable<BehaviorCustom_DetectExclusiveItemState>
{
	private static readonly MessageParser<BehaviorCustom_DetectExclusiveItemState> _parser = new MessageParser<BehaviorCustom_DetectExclusiveItemState>(() => new BehaviorCustom_DetectExclusiveItemState());

	private UnknownFieldSet _unknownFields;

	private bool isReverseCondition_;

	private int conditionCoolDownTimeMs_;

	private string actorTag_ = "";

	private static readonly FieldCodec<string> _repeated_stateTags_codec = FieldCodec.ForString(34u);

	private readonly RepeatedField<string> stateTags_ = new RepeatedField<string>();

	public static MessageParser<BehaviorCustom_DetectExclusiveItemState> Parser => _parser;

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

	public int ConditionCoolDownTimeMs
	{
		get
		{
			return conditionCoolDownTimeMs_;
		}
		set
		{
			conditionCoolDownTimeMs_ = value;
		}
	}

	public string ActorTag
	{
		get
		{
			return actorTag_;
		}
		set
		{
			actorTag_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<string> StateTags => stateTags_;

	public BehaviorCustom_DetectExclusiveItemState()
	{
	}

	public BehaviorCustom_DetectExclusiveItemState(BehaviorCustom_DetectExclusiveItemState other)
		: this()
	{
		isReverseCondition_ = other.isReverseCondition_;
		conditionCoolDownTimeMs_ = other.conditionCoolDownTimeMs_;
		actorTag_ = other.actorTag_;
		stateTags_ = other.stateTags_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_DetectExclusiveItemState Clone()
	{
		return new BehaviorCustom_DetectExclusiveItemState(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_DetectExclusiveItemState);
	}

	public bool Equals(BehaviorCustom_DetectExclusiveItemState other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsReverseCondition != other.IsReverseCondition)
		{
			return false;
		}
		if (ConditionCoolDownTimeMs != other.ConditionCoolDownTimeMs)
		{
			return false;
		}
		if (ActorTag != other.ActorTag)
		{
			return false;
		}
		if (!stateTags_.Equals(other.stateTags_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (IsReverseCondition)
		{
			num ^= IsReverseCondition.GetHashCode();
		}
		if (ConditionCoolDownTimeMs != 0)
		{
			num ^= ConditionCoolDownTimeMs.GetHashCode();
		}
		if (ActorTag.Length != 0)
		{
			num ^= ActorTag.GetHashCode();
		}
		num ^= stateTags_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (IsReverseCondition)
		{
			output.WriteRawTag(8);
			output.WriteBool(IsReverseCondition);
		}
		if (ConditionCoolDownTimeMs != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ConditionCoolDownTimeMs);
		}
		if (ActorTag.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(ActorTag);
		}
		stateTags_.WriteTo(output, _repeated_stateTags_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (IsReverseCondition)
		{
			num += 2;
		}
		if (ConditionCoolDownTimeMs != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionCoolDownTimeMs);
		}
		if (ActorTag.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ActorTag);
		}
		num += stateTags_.CalculateSize(_repeated_stateTags_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_DetectExclusiveItemState other)
	{
		if (other != null)
		{
			if (other.IsReverseCondition)
			{
				IsReverseCondition = other.IsReverseCondition;
			}
			if (other.ConditionCoolDownTimeMs != 0)
			{
				ConditionCoolDownTimeMs = other.ConditionCoolDownTimeMs;
			}
			if (other.ActorTag.Length != 0)
			{
				ActorTag = other.ActorTag;
			}
			stateTags_.Add(other.stateTags_);
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
				IsReverseCondition = input.ReadBool();
				break;
			case 16u:
				ConditionCoolDownTimeMs = input.ReadInt32();
				break;
			case 26u:
				ActorTag = input.ReadString();
				break;
			case 34u:
				stateTags_.AddEntriesFrom(input, _repeated_stateTags_codec);
				break;
			}
		}
	}
}
