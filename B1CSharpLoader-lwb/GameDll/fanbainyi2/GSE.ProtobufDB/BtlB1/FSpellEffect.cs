using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FSpellEffect : IMessage<FSpellEffect>, IMessage, IEquatable<FSpellEffect>, IDeepCloneable<FSpellEffect>
{
	private static readonly MessageParser<FSpellEffect> _parser = new MessageParser<FSpellEffect>(() => new FSpellEffect());

	private UnknownFieldSet _unknownFields;

	private ESpellTriggerEffectType effectType_;

	private ESpellTargetBaseType targetBaseType_;

	private int value_;

	public static MessageParser<FSpellEffect> Parser => _parser;

	public ESpellTriggerEffectType EffectType
	{
		get
		{
			return effectType_;
		}
		set
		{
			effectType_ = value;
		}
	}

	public ESpellTargetBaseType TargetBaseType
	{
		get
		{
			return targetBaseType_;
		}
		set
		{
			targetBaseType_ = value;
		}
	}

	public int Value
	{
		get
		{
			return value_;
		}
		set
		{
			value_ = value;
		}
	}

	public FSpellEffect()
	{
	}

	public FSpellEffect(FSpellEffect other)
		: this()
	{
		effectType_ = other.effectType_;
		targetBaseType_ = other.targetBaseType_;
		value_ = other.value_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FSpellEffect Clone()
	{
		return new FSpellEffect(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FSpellEffect);
	}

	public bool Equals(FSpellEffect other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EffectType != other.EffectType)
		{
			return false;
		}
		if (TargetBaseType != other.TargetBaseType)
		{
			return false;
		}
		if (Value != other.Value)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (EffectType != ESpellTriggerEffectType.None)
		{
			num ^= EffectType.GetHashCode();
		}
		if (TargetBaseType != ESpellTargetBaseType.None)
		{
			num ^= TargetBaseType.GetHashCode();
		}
		if (Value != 0)
		{
			num ^= Value.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (EffectType != ESpellTriggerEffectType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)EffectType);
		}
		if (TargetBaseType != ESpellTargetBaseType.None)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)TargetBaseType);
		}
		if (Value != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Value);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (EffectType != ESpellTriggerEffectType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EffectType);
		}
		if (TargetBaseType != ESpellTargetBaseType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)TargetBaseType);
		}
		if (Value != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Value);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FSpellEffect other)
	{
		if (other != null)
		{
			if (other.EffectType != ESpellTriggerEffectType.None)
			{
				EffectType = other.EffectType;
			}
			if (other.TargetBaseType != ESpellTargetBaseType.None)
			{
				TargetBaseType = other.TargetBaseType;
			}
			if (other.Value != 0)
			{
				Value = other.Value;
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
				EffectType = (ESpellTriggerEffectType)input.ReadEnum();
				break;
			case 16u:
				TargetBaseType = (ESpellTargetBaseType)input.ReadEnum();
				break;
			case 24u:
				Value = input.ReadInt32();
				break;
			}
		}
	}
}
