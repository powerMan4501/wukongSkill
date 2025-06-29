using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStBossRushAbilityLimitDesc : IMessage<FUStBossRushAbilityLimitDesc>, IMessage, IEquatable<FUStBossRushAbilityLimitDesc>, IDeepCloneable<FUStBossRushAbilityLimitDesc>
{
	private static readonly MessageParser<FUStBossRushAbilityLimitDesc> _parser = new MessageParser<FUStBossRushAbilityLimitDesc>(() => new FUStBossRushAbilityLimitDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private EBRLimitTargetType targetType_;

	private EBRLimitType limitType_;

	private static readonly FieldCodec<int> _repeated_paramInts_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> paramInts_ = new RepeatedField<int>();

	private static readonly FieldCodec<float> _repeated_paramFloats_codec = FieldCodec.ForFloat(42u);

	private readonly RepeatedField<float> paramFloats_ = new RepeatedField<float>();

	public static MessageParser<FUStBossRushAbilityLimitDesc> Parser => _parser;

	public int ID
	{
		get
		{
			return iD_;
		}
		set
		{
			iD_ = value;
		}
	}

	public EBRLimitTargetType TargetType
	{
		get
		{
			return targetType_;
		}
		set
		{
			targetType_ = value;
		}
	}

	public EBRLimitType LimitType
	{
		get
		{
			return limitType_;
		}
		set
		{
			limitType_ = value;
		}
	}

	public RepeatedField<int> ParamInts => paramInts_;

	public RepeatedField<float> ParamFloats => paramFloats_;

	public FUStBossRushAbilityLimitDesc()
	{
	}

	public FUStBossRushAbilityLimitDesc(FUStBossRushAbilityLimitDesc other)
		: this()
	{
		iD_ = other.iD_;
		targetType_ = other.targetType_;
		limitType_ = other.limitType_;
		paramInts_ = other.paramInts_.Clone();
		paramFloats_ = other.paramFloats_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStBossRushAbilityLimitDesc Clone()
	{
		return new FUStBossRushAbilityLimitDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStBossRushAbilityLimitDesc);
	}

	public bool Equals(FUStBossRushAbilityLimitDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ID != other.ID)
		{
			return false;
		}
		if (TargetType != other.TargetType)
		{
			return false;
		}
		if (LimitType != other.LimitType)
		{
			return false;
		}
		if (!paramInts_.Equals(other.paramInts_))
		{
			return false;
		}
		if (!paramFloats_.Equals(other.paramFloats_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ID != 0)
		{
			num ^= ID.GetHashCode();
		}
		if (TargetType != EBRLimitTargetType.None)
		{
			num ^= TargetType.GetHashCode();
		}
		if (LimitType != EBRLimitType.None)
		{
			num ^= LimitType.GetHashCode();
		}
		num ^= paramInts_.GetHashCode();
		num ^= paramFloats_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ID);
		}
		if (TargetType != EBRLimitTargetType.None)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)TargetType);
		}
		if (LimitType != EBRLimitType.None)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)LimitType);
		}
		paramInts_.WriteTo(output, _repeated_paramInts_codec);
		paramFloats_.WriteTo(output, _repeated_paramFloats_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ID);
		}
		if (TargetType != EBRLimitTargetType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)TargetType);
		}
		if (LimitType != EBRLimitType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)LimitType);
		}
		num += paramInts_.CalculateSize(_repeated_paramInts_codec);
		num += paramFloats_.CalculateSize(_repeated_paramFloats_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStBossRushAbilityLimitDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.TargetType != EBRLimitTargetType.None)
			{
				TargetType = other.TargetType;
			}
			if (other.LimitType != EBRLimitType.None)
			{
				LimitType = other.LimitType;
			}
			paramInts_.Add(other.paramInts_);
			paramFloats_.Add(other.paramFloats_);
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
				ID = input.ReadInt32();
				break;
			case 16u:
				TargetType = (EBRLimitTargetType)input.ReadEnum();
				break;
			case 24u:
				LimitType = (EBRLimitType)input.ReadEnum();
				break;
			case 32u:
			case 34u:
				paramInts_.AddEntriesFrom(input, _repeated_paramInts_codec);
				break;
			case 42u:
			case 45u:
				paramFloats_.AddEntriesFrom(input, _repeated_paramFloats_codec);
				break;
			}
		}
	}
}
