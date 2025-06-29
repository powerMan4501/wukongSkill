using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlU3;

public sealed class FUStB2DBuffEffectAttr : IMessage<FUStB2DBuffEffectAttr>, IMessage, IEquatable<FUStB2DBuffEffectAttr>, IDeepCloneable<FUStB2DBuffEffectAttr>
{
	private static readonly MessageParser<FUStB2DBuffEffectAttr> _parser = new MessageParser<FUStB2DBuffEffectAttr>(() => new FUStB2DBuffEffectAttr());

	private UnknownFieldSet _unknownFields;

	private EB2DBuffEffectTriggerType effectTrigger_;

	private EB2DBuffAndSkillEffectType effectType_;

	private string extraEffectParam_ = "";

	private static readonly FieldCodec<int> _repeated_effectParams_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> effectParams_ = new RepeatedField<int>();

	private static readonly FieldCodec<float> _repeated_effectParamsFloat_codec = FieldCodec.ForFloat(42u);

	private readonly RepeatedField<float> effectParamsFloat_ = new RepeatedField<float>();

	public static MessageParser<FUStB2DBuffEffectAttr> Parser => _parser;

	public EB2DBuffEffectTriggerType EffectTrigger
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

	public EB2DBuffAndSkillEffectType EffectType
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

	public string ExtraEffectParam
	{
		get
		{
			return extraEffectParam_;
		}
		set
		{
			extraEffectParam_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<int> EffectParams => effectParams_;

	public RepeatedField<float> EffectParamsFloat => effectParamsFloat_;

	public FUStB2DBuffEffectAttr()
	{
	}

	public FUStB2DBuffEffectAttr(FUStB2DBuffEffectAttr other)
		: this()
	{
		effectTrigger_ = other.effectTrigger_;
		effectType_ = other.effectType_;
		extraEffectParam_ = other.extraEffectParam_;
		effectParams_ = other.effectParams_.Clone();
		effectParamsFloat_ = other.effectParamsFloat_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStB2DBuffEffectAttr Clone()
	{
		return new FUStB2DBuffEffectAttr(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStB2DBuffEffectAttr);
	}

	public bool Equals(FUStB2DBuffEffectAttr other)
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
		if (ExtraEffectParam != other.ExtraEffectParam)
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
		if (EffectTrigger != EB2DBuffEffectTriggerType.None)
		{
			num ^= EffectTrigger.GetHashCode();
		}
		if (EffectType != EB2DBuffAndSkillEffectType.None)
		{
			num ^= EffectType.GetHashCode();
		}
		if (ExtraEffectParam.Length != 0)
		{
			num ^= ExtraEffectParam.GetHashCode();
		}
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
		if (EffectTrigger != EB2DBuffEffectTriggerType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)EffectTrigger);
		}
		if (EffectType != EB2DBuffAndSkillEffectType.None)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)EffectType);
		}
		if (ExtraEffectParam.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(ExtraEffectParam);
		}
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
		if (EffectTrigger != EB2DBuffEffectTriggerType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EffectTrigger);
		}
		if (EffectType != EB2DBuffAndSkillEffectType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EffectType);
		}
		if (ExtraEffectParam.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ExtraEffectParam);
		}
		num += effectParams_.CalculateSize(_repeated_effectParams_codec);
		num += effectParamsFloat_.CalculateSize(_repeated_effectParamsFloat_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStB2DBuffEffectAttr other)
	{
		if (other != null)
		{
			if (other.EffectTrigger != EB2DBuffEffectTriggerType.None)
			{
				EffectTrigger = other.EffectTrigger;
			}
			if (other.EffectType != EB2DBuffAndSkillEffectType.None)
			{
				EffectType = other.EffectType;
			}
			if (other.ExtraEffectParam.Length != 0)
			{
				ExtraEffectParam = other.ExtraEffectParam;
			}
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
				EffectTrigger = (EB2DBuffEffectTriggerType)input.ReadEnum();
				break;
			case 16u:
				EffectType = (EB2DBuffAndSkillEffectType)input.ReadEnum();
				break;
			case 26u:
				ExtraEffectParam = input.ReadString();
				break;
			case 32u:
			case 34u:
				effectParams_.AddEntriesFrom(input, _repeated_effectParams_codec);
				break;
			case 42u:
			case 45u:
				effectParamsFloat_.AddEntriesFrom(input, _repeated_effectParamsFloat_codec);
				break;
			}
		}
	}
}
