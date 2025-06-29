using System;
using Google.Protobuf;

namespace GurCalliopeState;

public sealed class CalliopeCustom_FChildActorActionInfo : IMessage<CalliopeCustom_FChildActorActionInfo>, IMessage, IEquatable<CalliopeCustom_FChildActorActionInfo>, IDeepCloneable<CalliopeCustom_FChildActorActionInfo>
{
	private static readonly MessageParser<CalliopeCustom_FChildActorActionInfo> _parser = new MessageParser<CalliopeCustom_FChildActorActionInfo>(() => new CalliopeCustom_FChildActorActionInfo());

	private UnknownFieldSet _unknownFields;

	private int actionType_;

	private int skillId_;

	private bool needCheckSkillCanCast_;

	private string montageStartSectionName_ = "";

	private int buffId_;

	private int buffLayer_;

	private int buffDuration_;

	private bool triggerRemoveEffect_;

	public static MessageParser<CalliopeCustom_FChildActorActionInfo> Parser => _parser;

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

	public bool NeedCheckSkillCanCast
	{
		get
		{
			return needCheckSkillCanCast_;
		}
		set
		{
			needCheckSkillCanCast_ = value;
		}
	}

	public string MontageStartSectionName
	{
		get
		{
			return montageStartSectionName_;
		}
		set
		{
			montageStartSectionName_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public int BuffLayer
	{
		get
		{
			return buffLayer_;
		}
		set
		{
			buffLayer_ = value;
		}
	}

	public int BuffDuration
	{
		get
		{
			return buffDuration_;
		}
		set
		{
			buffDuration_ = value;
		}
	}

	public bool TriggerRemoveEffect
	{
		get
		{
			return triggerRemoveEffect_;
		}
		set
		{
			triggerRemoveEffect_ = value;
		}
	}

	public CalliopeCustom_FChildActorActionInfo()
	{
	}

	public CalliopeCustom_FChildActorActionInfo(CalliopeCustom_FChildActorActionInfo other)
		: this()
	{
		actionType_ = other.actionType_;
		skillId_ = other.skillId_;
		needCheckSkillCanCast_ = other.needCheckSkillCanCast_;
		montageStartSectionName_ = other.montageStartSectionName_;
		buffId_ = other.buffId_;
		buffLayer_ = other.buffLayer_;
		buffDuration_ = other.buffDuration_;
		triggerRemoveEffect_ = other.triggerRemoveEffect_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_FChildActorActionInfo Clone()
	{
		return new CalliopeCustom_FChildActorActionInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_FChildActorActionInfo);
	}

	public bool Equals(CalliopeCustom_FChildActorActionInfo other)
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
		if (SkillId != other.SkillId)
		{
			return false;
		}
		if (NeedCheckSkillCanCast != other.NeedCheckSkillCanCast)
		{
			return false;
		}
		if (MontageStartSectionName != other.MontageStartSectionName)
		{
			return false;
		}
		if (BuffId != other.BuffId)
		{
			return false;
		}
		if (BuffLayer != other.BuffLayer)
		{
			return false;
		}
		if (BuffDuration != other.BuffDuration)
		{
			return false;
		}
		if (TriggerRemoveEffect != other.TriggerRemoveEffect)
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
		if (SkillId != 0)
		{
			num ^= SkillId.GetHashCode();
		}
		if (NeedCheckSkillCanCast)
		{
			num ^= NeedCheckSkillCanCast.GetHashCode();
		}
		if (MontageStartSectionName.Length != 0)
		{
			num ^= MontageStartSectionName.GetHashCode();
		}
		if (BuffId != 0)
		{
			num ^= BuffId.GetHashCode();
		}
		if (BuffLayer != 0)
		{
			num ^= BuffLayer.GetHashCode();
		}
		if (BuffDuration != 0)
		{
			num ^= BuffDuration.GetHashCode();
		}
		if (TriggerRemoveEffect)
		{
			num ^= TriggerRemoveEffect.GetHashCode();
		}
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
		if (SkillId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SkillId);
		}
		if (NeedCheckSkillCanCast)
		{
			output.WriteRawTag(24);
			output.WriteBool(NeedCheckSkillCanCast);
		}
		if (MontageStartSectionName.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(MontageStartSectionName);
		}
		if (BuffId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(BuffId);
		}
		if (BuffLayer != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(BuffLayer);
		}
		if (BuffDuration != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(BuffDuration);
		}
		if (TriggerRemoveEffect)
		{
			output.WriteRawTag(64);
			output.WriteBool(TriggerRemoveEffect);
		}
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
		if (SkillId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SkillId);
		}
		if (NeedCheckSkillCanCast)
		{
			num += 2;
		}
		if (MontageStartSectionName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MontageStartSectionName);
		}
		if (BuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffId);
		}
		if (BuffLayer != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffLayer);
		}
		if (BuffDuration != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffDuration);
		}
		if (TriggerRemoveEffect)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_FChildActorActionInfo other)
	{
		if (other != null)
		{
			if (other.ActionType != 0)
			{
				ActionType = other.ActionType;
			}
			if (other.SkillId != 0)
			{
				SkillId = other.SkillId;
			}
			if (other.NeedCheckSkillCanCast)
			{
				NeedCheckSkillCanCast = other.NeedCheckSkillCanCast;
			}
			if (other.MontageStartSectionName.Length != 0)
			{
				MontageStartSectionName = other.MontageStartSectionName;
			}
			if (other.BuffId != 0)
			{
				BuffId = other.BuffId;
			}
			if (other.BuffLayer != 0)
			{
				BuffLayer = other.BuffLayer;
			}
			if (other.BuffDuration != 0)
			{
				BuffDuration = other.BuffDuration;
			}
			if (other.TriggerRemoveEffect)
			{
				TriggerRemoveEffect = other.TriggerRemoveEffect;
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
				ActionType = input.ReadInt32();
				break;
			case 16u:
				SkillId = input.ReadInt32();
				break;
			case 24u:
				NeedCheckSkillCanCast = input.ReadBool();
				break;
			case 34u:
				MontageStartSectionName = input.ReadString();
				break;
			case 40u:
				BuffId = input.ReadInt32();
				break;
			case 48u:
				BuffLayer = input.ReadInt32();
				break;
			case 56u:
				BuffDuration = input.ReadInt32();
				break;
			case 64u:
				TriggerRemoveEffect = input.ReadBool();
				break;
			}
		}
	}
}
