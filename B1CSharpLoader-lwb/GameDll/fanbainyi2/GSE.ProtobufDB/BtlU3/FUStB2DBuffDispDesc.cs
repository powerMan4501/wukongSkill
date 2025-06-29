using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlU3;

public sealed class FUStB2DBuffDispDesc : IMessage<FUStB2DBuffDispDesc>, IMessage, IEquatable<FUStB2DBuffDispDesc>, IDeepCloneable<FUStB2DBuffDispDesc>
{
	private static readonly MessageParser<FUStB2DBuffDispDesc> _parser = new MessageParser<FUStB2DBuffDispDesc>(() => new FUStB2DBuffDispDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private static readonly FieldCodec<FUStB2DFXSetting> _repeated_enterFx_codec = FieldCodec.ForMessage(18u, FUStB2DFXSetting.Parser);

	private readonly RepeatedField<FUStB2DFXSetting> enterFx_ = new RepeatedField<FUStB2DFXSetting>();

	private static readonly FieldCodec<FUStB2DFXSetting> _repeated_leaveFx_codec = FieldCodec.ForMessage(26u, FUStB2DFXSetting.Parser);

	private readonly RepeatedField<FUStB2DFXSetting> leaveFx_ = new RepeatedField<FUStB2DFXSetting>();

	private float leaveFxExistTime_;

	private int targetFlickerType_;

	private int targetFlickerPriority_;

	private float targetFlickerDuration_;

	private int targetFlickerLoop_;

	public static MessageParser<FUStB2DBuffDispDesc> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public RepeatedField<FUStB2DFXSetting> EnterFx => enterFx_;

	public RepeatedField<FUStB2DFXSetting> LeaveFx => leaveFx_;

	public float LeaveFxExistTime
	{
		get
		{
			return leaveFxExistTime_;
		}
		set
		{
			leaveFxExistTime_ = value;
		}
	}

	public int TargetFlickerType
	{
		get
		{
			return targetFlickerType_;
		}
		set
		{
			targetFlickerType_ = value;
		}
	}

	public int TargetFlickerPriority
	{
		get
		{
			return targetFlickerPriority_;
		}
		set
		{
			targetFlickerPriority_ = value;
		}
	}

	public float TargetFlickerDuration
	{
		get
		{
			return targetFlickerDuration_;
		}
		set
		{
			targetFlickerDuration_ = value;
		}
	}

	public int TargetFlickerLoop
	{
		get
		{
			return targetFlickerLoop_;
		}
		set
		{
			targetFlickerLoop_ = value;
		}
	}

	public FUStB2DBuffDispDesc()
	{
	}

	public FUStB2DBuffDispDesc(FUStB2DBuffDispDesc other)
		: this()
	{
		id_ = other.id_;
		enterFx_ = other.enterFx_.Clone();
		leaveFx_ = other.leaveFx_.Clone();
		leaveFxExistTime_ = other.leaveFxExistTime_;
		targetFlickerType_ = other.targetFlickerType_;
		targetFlickerPriority_ = other.targetFlickerPriority_;
		targetFlickerDuration_ = other.targetFlickerDuration_;
		targetFlickerLoop_ = other.targetFlickerLoop_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStB2DBuffDispDesc Clone()
	{
		return new FUStB2DBuffDispDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStB2DBuffDispDesc);
	}

	public bool Equals(FUStB2DBuffDispDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (!enterFx_.Equals(other.enterFx_))
		{
			return false;
		}
		if (!leaveFx_.Equals(other.leaveFx_))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(LeaveFxExistTime, other.LeaveFxExistTime))
		{
			return false;
		}
		if (TargetFlickerType != other.TargetFlickerType)
		{
			return false;
		}
		if (TargetFlickerPriority != other.TargetFlickerPriority)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TargetFlickerDuration, other.TargetFlickerDuration))
		{
			return false;
		}
		if (TargetFlickerLoop != other.TargetFlickerLoop)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		num ^= enterFx_.GetHashCode();
		num ^= leaveFx_.GetHashCode();
		if (LeaveFxExistTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(LeaveFxExistTime);
		}
		if (TargetFlickerType != 0)
		{
			num ^= TargetFlickerType.GetHashCode();
		}
		if (TargetFlickerPriority != 0)
		{
			num ^= TargetFlickerPriority.GetHashCode();
		}
		if (TargetFlickerDuration != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TargetFlickerDuration);
		}
		if (TargetFlickerLoop != 0)
		{
			num ^= TargetFlickerLoop.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		enterFx_.WriteTo(output, _repeated_enterFx_codec);
		leaveFx_.WriteTo(output, _repeated_leaveFx_codec);
		if (LeaveFxExistTime != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(LeaveFxExistTime);
		}
		if (TargetFlickerType != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(TargetFlickerType);
		}
		if (TargetFlickerPriority != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(TargetFlickerPriority);
		}
		if (TargetFlickerDuration != 0f)
		{
			output.WriteRawTag(61);
			output.WriteFloat(TargetFlickerDuration);
		}
		if (TargetFlickerLoop != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(TargetFlickerLoop);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		num += enterFx_.CalculateSize(_repeated_enterFx_codec);
		num += leaveFx_.CalculateSize(_repeated_leaveFx_codec);
		if (LeaveFxExistTime != 0f)
		{
			num += 5;
		}
		if (TargetFlickerType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetFlickerType);
		}
		if (TargetFlickerPriority != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetFlickerPriority);
		}
		if (TargetFlickerDuration != 0f)
		{
			num += 5;
		}
		if (TargetFlickerLoop != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetFlickerLoop);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStB2DBuffDispDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			enterFx_.Add(other.enterFx_);
			leaveFx_.Add(other.leaveFx_);
			if (other.LeaveFxExistTime != 0f)
			{
				LeaveFxExistTime = other.LeaveFxExistTime;
			}
			if (other.TargetFlickerType != 0)
			{
				TargetFlickerType = other.TargetFlickerType;
			}
			if (other.TargetFlickerPriority != 0)
			{
				TargetFlickerPriority = other.TargetFlickerPriority;
			}
			if (other.TargetFlickerDuration != 0f)
			{
				TargetFlickerDuration = other.TargetFlickerDuration;
			}
			if (other.TargetFlickerLoop != 0)
			{
				TargetFlickerLoop = other.TargetFlickerLoop;
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
				Id = input.ReadInt32();
				break;
			case 18u:
				enterFx_.AddEntriesFrom(input, _repeated_enterFx_codec);
				break;
			case 26u:
				leaveFx_.AddEntriesFrom(input, _repeated_leaveFx_codec);
				break;
			case 37u:
				LeaveFxExistTime = input.ReadFloat();
				break;
			case 40u:
				TargetFlickerType = input.ReadInt32();
				break;
			case 48u:
				TargetFlickerPriority = input.ReadInt32();
				break;
			case 61u:
				TargetFlickerDuration = input.ReadFloat();
				break;
			case 64u:
				TargetFlickerLoop = input.ReadInt32();
				break;
			}
		}
	}
}
