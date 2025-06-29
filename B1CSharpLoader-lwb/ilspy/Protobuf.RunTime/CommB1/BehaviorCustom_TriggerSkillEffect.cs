using System;
using Google.Protobuf;

namespace CommB1;

public sealed class BehaviorCustom_TriggerSkillEffect : IMessage<BehaviorCustom_TriggerSkillEffect>, IMessage, IEquatable<BehaviorCustom_TriggerSkillEffect>, IDeepCloneable<BehaviorCustom_TriggerSkillEffect>
{
	private static readonly MessageParser<BehaviorCustom_TriggerSkillEffect> _parser = new MessageParser<BehaviorCustom_TriggerSkillEffect>(() => new BehaviorCustom_TriggerSkillEffect());

	private UnknownFieldSet _unknownFields;

	private int effectId_;

	public static MessageParser<BehaviorCustom_TriggerSkillEffect> Parser => _parser;

	public int EffectId
	{
		get
		{
			return effectId_;
		}
		set
		{
			effectId_ = value;
		}
	}

	public BehaviorCustom_TriggerSkillEffect()
	{
	}

	public BehaviorCustom_TriggerSkillEffect(BehaviorCustom_TriggerSkillEffect other)
		: this()
	{
		effectId_ = other.effectId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_TriggerSkillEffect Clone()
	{
		return new BehaviorCustom_TriggerSkillEffect(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_TriggerSkillEffect);
	}

	public bool Equals(BehaviorCustom_TriggerSkillEffect other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EffectId != other.EffectId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (EffectId != 0)
		{
			num ^= EffectId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (EffectId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(EffectId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (EffectId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EffectId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_TriggerSkillEffect other)
	{
		if (other != null)
		{
			if (other.EffectId != 0)
			{
				EffectId = other.EffectId;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				EffectId = input.ReadInt32();
			}
		}
	}
}
