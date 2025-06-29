using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class FUStBuffEffectAttr : IMessage<FUStBuffEffectAttr>, IMessage, IEquatable<FUStBuffEffectAttr>, IDeepCloneable<FUStBuffEffectAttr>
{
	private static readonly MessageParser<FUStBuffEffectAttr> _parser = new MessageParser<FUStBuffEffectAttr>(() => new FUStBuffEffectAttr());

	private UnknownFieldSet _unknownFields;

	private EBuffEffectTriggerType effectTrigger_;

	private EBuffAndSkillEffectType effectType_;

	private EBuffEffectTargetSelectType effectTargetSelectType_;

	private static readonly FieldCodec<string> _repeated_effectParamsString_codec = FieldCodec.ForString(34u);

	private readonly RepeatedField<string> effectParamsString_ = new RepeatedField<string>();

	private static readonly FieldCodec<int> _repeated_effectParams_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> effectParams_ = new RepeatedField<int>();

	private static readonly FieldCodec<float> _repeated_effectParamsFloat_codec = FieldCodec.ForFloat(50u);

	private readonly RepeatedField<float> effectParamsFloat_ = new RepeatedField<float>();

	public static MessageParser<FUStBuffEffectAttr> Parser => _parser;

	public EBuffEffectTriggerType EffectTrigger
	{
		get
		{
			return effectTrigger_;
		}
		set
		{
			effectTrigger_ = value;
		}
	}

	public EBuffAndSkillEffectType EffectType
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

	public EBuffEffectTargetSelectType EffectTargetSelectType
	{
		get
		{
			return effectTargetSelectType_;
		}
		set
		{
			effectTargetSelectType_ = value;
		}
	}

	public RepeatedField<string> EffectParamsString => effectParamsString_;

	public RepeatedField<int> EffectParams => effectParams_;

	public RepeatedField<float> EffectParamsFloat => effectParamsFloat_;

	public FUStBuffEffectAttr()
	{
	}

	public FUStBuffEffectAttr(FUStBuffEffectAttr other)
		: this()
	{
		effectTrigger_ = other.effectTrigger_;
		effectType_ = other.effectType_;
		effectTargetSelectType_ = other.effectTargetSelectType_;
		effectParamsString_ = other.effectParamsString_.Clone();
		effectParams_ = other.effectParams_.Clone();
		effectParamsFloat_ = other.effectParamsFloat_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStBuffEffectAttr Clone()
	{
		return new FUStBuffEffectAttr(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStBuffEffectAttr);
	}

	public bool Equals(FUStBuffEffectAttr other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EffectTrigger != other.EffectTrigger)
		{
			return false;
		}
		if (EffectType != other.EffectType)
		{
			return false;
		}
		if (EffectTargetSelectType != other.EffectTargetSelectType)
		{
			return false;
		}
		if (!effectParamsString_.Equals(other.effectParamsString_))
		{
			return false;
		}
		if (!effectParams_.Equals(other.effectParams_))
		{
			return false;
		}
		if (!effectParamsFloat_.Equals(other.effectParamsFloat_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (EffectTrigger != EBuffEffectTriggerType.None)
		{
			num ^= EffectTrigger.GetHashCode();
		}
		if (EffectType != EBuffAndSkillEffectType.None)
		{
			num ^= EffectType.GetHashCode();
		}
		if (EffectTargetSelectType != EBuffEffectTargetSelectType.BuffTarget)
		{
			num ^= EffectTargetSelectType.GetHashCode();
		}
		num ^= effectParamsString_.GetHashCode();
		num ^= effectParams_.GetHashCode();
		num ^= effectParamsFloat_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (EffectTrigger != EBuffEffectTriggerType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)EffectTrigger);
		}
		if (EffectType != EBuffAndSkillEffectType.None)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)EffectType);
		}
		if (EffectTargetSelectType != EBuffEffectTargetSelectType.BuffTarget)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)EffectTargetSelectType);
		}
		effectParamsString_.WriteTo(output, _repeated_effectParamsString_codec);
		effectParams_.WriteTo(output, _repeated_effectParams_codec);
		effectParamsFloat_.WriteTo(output, _repeated_effectParamsFloat_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (EffectTrigger != EBuffEffectTriggerType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EffectTrigger);
		}
		if (EffectType != EBuffAndSkillEffectType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EffectType);
		}
		if (EffectTargetSelectType != EBuffEffectTargetSelectType.BuffTarget)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EffectTargetSelectType);
		}
		num += effectParamsString_.CalculateSize(_repeated_effectParamsString_codec);
		num += effectParams_.CalculateSize(_repeated_effectParams_codec);
		num += effectParamsFloat_.CalculateSize(_repeated_effectParamsFloat_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStBuffEffectAttr other)
	{
		if (other != null)
		{
			if (other.EffectTrigger != EBuffEffectTriggerType.None)
			{
				EffectTrigger = other.EffectTrigger;
			}
			if (other.EffectType != EBuffAndSkillEffectType.None)
			{
				EffectType = other.EffectType;
			}
			if (other.EffectTargetSelectType != EBuffEffectTargetSelectType.BuffTarget)
			{
				EffectTargetSelectType = other.EffectTargetSelectType;
			}
			effectParamsString_.Add(other.effectParamsString_);
			effectParams_.Add(other.effectParams_);
			effectParamsFloat_.Add(other.effectParamsFloat_);
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
				EffectTrigger = (EBuffEffectTriggerType)input.ReadEnum();
				break;
			case 16u:
				EffectType = (EBuffAndSkillEffectType)input.ReadEnum();
				break;
			case 24u:
				EffectTargetSelectType = (EBuffEffectTargetSelectType)input.ReadEnum();
				break;
			case 34u:
				effectParamsString_.AddEntriesFrom(input, _repeated_effectParamsString_codec);
				break;
			case 40u:
			case 42u:
				effectParams_.AddEntriesFrom(input, _repeated_effectParams_codec);
				break;
			case 50u:
			case 53u:
				effectParamsFloat_.AddEntriesFrom(input, _repeated_effectParamsFloat_codec);
				break;
			}
		}
	}
}
