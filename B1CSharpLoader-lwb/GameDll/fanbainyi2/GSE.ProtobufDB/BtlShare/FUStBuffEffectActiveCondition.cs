using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class FUStBuffEffectActiveCondition : IMessage<FUStBuffEffectActiveCondition>, IMessage, IEquatable<FUStBuffEffectActiveCondition>, IDeepCloneable<FUStBuffEffectActiveCondition>
{
	private static readonly MessageParser<FUStBuffEffectActiveCondition> _parser = new MessageParser<FUStBuffEffectActiveCondition>(() => new FUStBuffEffectActiveCondition());

	private UnknownFieldSet _unknownFields;

	private EGSBuffAndSkillEffectActiveCondition conditionType_;

	private string conditionParams_ = "";

	public static MessageParser<FUStBuffEffectActiveCondition> Parser => _parser;

	public EGSBuffAndSkillEffectActiveCondition ConditionType
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

	public string ConditionParams
	{
		get
		{
			return conditionParams_;
		}
		set
		{
			conditionParams_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStBuffEffectActiveCondition()
	{
	}

	public FUStBuffEffectActiveCondition(FUStBuffEffectActiveCondition other)
		: this()
	{
		conditionType_ = other.conditionType_;
		conditionParams_ = other.conditionParams_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStBuffEffectActiveCondition Clone()
	{
		return new FUStBuffEffectActiveCondition(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStBuffEffectActiveCondition);
	}

	public bool Equals(FUStBuffEffectActiveCondition other)
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
		if (ConditionParams != other.ConditionParams)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ConditionType != EGSBuffAndSkillEffectActiveCondition.Always)
		{
			num ^= ConditionType.GetHashCode();
		}
		if (ConditionParams.Length != 0)
		{
			num ^= ConditionParams.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ConditionType != EGSBuffAndSkillEffectActiveCondition.Always)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)ConditionType);
		}
		if (ConditionParams.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(ConditionParams);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ConditionType != EGSBuffAndSkillEffectActiveCondition.Always)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ConditionType);
		}
		if (ConditionParams.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ConditionParams);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStBuffEffectActiveCondition other)
	{
		if (other != null)
		{
			if (other.ConditionType != EGSBuffAndSkillEffectActiveCondition.Always)
			{
				ConditionType = other.ConditionType;
			}
			if (other.ConditionParams.Length != 0)
			{
				ConditionParams = other.ConditionParams;
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
				ConditionType = (EGSBuffAndSkillEffectActiveCondition)input.ReadEnum();
				break;
			case 18u:
				ConditionParams = input.ReadString();
				break;
			}
		}
	}
}
