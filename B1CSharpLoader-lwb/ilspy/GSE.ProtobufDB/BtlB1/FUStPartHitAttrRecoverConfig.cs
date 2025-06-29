using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStPartHitAttrRecoverConfig : IMessage<FUStPartHitAttrRecoverConfig>, IMessage, IEquatable<FUStPartHitAttrRecoverConfig>, IDeepCloneable<FUStPartHitAttrRecoverConfig>
{
	private static readonly MessageParser<FUStPartHitAttrRecoverConfig> _parser = new MessageParser<FUStPartHitAttrRecoverConfig>(() => new FUStPartHitAttrRecoverConfig());

	private UnknownFieldSet _unknownFields;

	private EHitPartRecoverAttrType recoverAttrType_;

	private EHitPartRecoverAttrConversionType recoverAttrConversionType_;

	private float damageConversionRatio_;

	private EValueClampType valueClampType_;

	private float minValue_;

	private float maxValue_;

	public static MessageParser<FUStPartHitAttrRecoverConfig> Parser => _parser;

	public EHitPartRecoverAttrType RecoverAttrType
	{
		get
		{
			return recoverAttrType_;
		}
		set
		{
			recoverAttrType_ = value;
		}
	}

	public EHitPartRecoverAttrConversionType RecoverAttrConversionType
	{
		get
		{
			return recoverAttrConversionType_;
		}
		set
		{
			recoverAttrConversionType_ = value;
		}
	}

	public float DamageConversionRatio
	{
		get
		{
			return damageConversionRatio_;
		}
		set
		{
			damageConversionRatio_ = value;
		}
	}

	public EValueClampType ValueClampType
	{
		get
		{
			return valueClampType_;
		}
		set
		{
			valueClampType_ = value;
		}
	}

	public float MinValue
	{
		get
		{
			return minValue_;
		}
		set
		{
			minValue_ = value;
		}
	}

	public float MaxValue
	{
		get
		{
			return maxValue_;
		}
		set
		{
			maxValue_ = value;
		}
	}

	public FUStPartHitAttrRecoverConfig()
	{
	}

	public FUStPartHitAttrRecoverConfig(FUStPartHitAttrRecoverConfig other)
		: this()
	{
		recoverAttrType_ = other.recoverAttrType_;
		recoverAttrConversionType_ = other.recoverAttrConversionType_;
		damageConversionRatio_ = other.damageConversionRatio_;
		valueClampType_ = other.valueClampType_;
		minValue_ = other.minValue_;
		maxValue_ = other.maxValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStPartHitAttrRecoverConfig Clone()
	{
		return new FUStPartHitAttrRecoverConfig(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStPartHitAttrRecoverConfig);
	}

	public bool Equals(FUStPartHitAttrRecoverConfig other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RecoverAttrType != other.RecoverAttrType)
		{
			return false;
		}
		if (RecoverAttrConversionType != other.RecoverAttrConversionType)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DamageConversionRatio, other.DamageConversionRatio))
		{
			return false;
		}
		if (ValueClampType != other.ValueClampType)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MinValue, other.MinValue))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MaxValue, other.MaxValue))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (RecoverAttrType != EHitPartRecoverAttrType.None)
		{
			num ^= RecoverAttrType.GetHashCode();
		}
		if (RecoverAttrConversionType != EHitPartRecoverAttrConversionType.ByValue)
		{
			num ^= RecoverAttrConversionType.GetHashCode();
		}
		if (DamageConversionRatio != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DamageConversionRatio);
		}
		if (ValueClampType != EValueClampType.None)
		{
			num ^= ValueClampType.GetHashCode();
		}
		if (MinValue != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MinValue);
		}
		if (MaxValue != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MaxValue);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (RecoverAttrType != EHitPartRecoverAttrType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)RecoverAttrType);
		}
		if (RecoverAttrConversionType != EHitPartRecoverAttrConversionType.ByValue)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)RecoverAttrConversionType);
		}
		if (DamageConversionRatio != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(DamageConversionRatio);
		}
		if (ValueClampType != EValueClampType.None)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)ValueClampType);
		}
		if (MinValue != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(MinValue);
		}
		if (MaxValue != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(MaxValue);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (RecoverAttrType != EHitPartRecoverAttrType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)RecoverAttrType);
		}
		if (RecoverAttrConversionType != EHitPartRecoverAttrConversionType.ByValue)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)RecoverAttrConversionType);
		}
		if (DamageConversionRatio != 0f)
		{
			num += 5;
		}
		if (ValueClampType != EValueClampType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ValueClampType);
		}
		if (MinValue != 0f)
		{
			num += 5;
		}
		if (MaxValue != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStPartHitAttrRecoverConfig other)
	{
		if (other != null)
		{
			if (other.RecoverAttrType != EHitPartRecoverAttrType.None)
			{
				RecoverAttrType = other.RecoverAttrType;
			}
			if (other.RecoverAttrConversionType != EHitPartRecoverAttrConversionType.ByValue)
			{
				RecoverAttrConversionType = other.RecoverAttrConversionType;
			}
			if (other.DamageConversionRatio != 0f)
			{
				DamageConversionRatio = other.DamageConversionRatio;
			}
			if (other.ValueClampType != EValueClampType.None)
			{
				ValueClampType = other.ValueClampType;
			}
			if (other.MinValue != 0f)
			{
				MinValue = other.MinValue;
			}
			if (other.MaxValue != 0f)
			{
				MaxValue = other.MaxValue;
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
				RecoverAttrType = (EHitPartRecoverAttrType)input.ReadEnum();
				break;
			case 16u:
				RecoverAttrConversionType = (EHitPartRecoverAttrConversionType)input.ReadEnum();
				break;
			case 29u:
				DamageConversionRatio = input.ReadFloat();
				break;
			case 32u:
				ValueClampType = (EValueClampType)input.ReadEnum();
				break;
			case 45u:
				MinValue = input.ReadFloat();
				break;
			case 53u:
				MaxValue = input.ReadFloat();
				break;
			}
		}
	}
}
