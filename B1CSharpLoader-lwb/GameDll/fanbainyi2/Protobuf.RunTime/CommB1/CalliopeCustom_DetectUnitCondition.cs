using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using GurCalliopeState;

namespace CommB1;

public sealed class CalliopeCustom_DetectUnitCondition : IMessage<CalliopeCustom_DetectUnitCondition>, IMessage, IEquatable<CalliopeCustom_DetectUnitCondition>, IDeepCloneable<CalliopeCustom_DetectUnitCondition>
{
	private static readonly MessageParser<CalliopeCustom_DetectUnitCondition> _parser = new MessageParser<CalliopeCustom_DetectUnitCondition>(() => new CalliopeCustom_DetectUnitCondition());

	private UnknownFieldSet _unknownFields;

	private int unitType_;

	private static readonly FieldCodec<CalliopeCustom_DetectCondition> _repeated_conditions_codec = FieldCodec.ForMessage(18u, CalliopeCustom_DetectCondition.Parser);

	private readonly RepeatedField<CalliopeCustom_DetectCondition> conditions_ = new RepeatedField<CalliopeCustom_DetectCondition>();

	private int conditionalRelation_;

	private string smartUnitGuid_ = "";

	private string pinName_ = "";

	private CalliopeCustom_FBossPhaseInfo bossPhaseInfo_;

	public static MessageParser<CalliopeCustom_DetectUnitCondition> Parser => _parser;

	public int UnitType
	{
		get
		{
			return unitType_;
		}
		set
		{
			unitType_ = value;
		}
	}

	public RepeatedField<CalliopeCustom_DetectCondition> Conditions => conditions_;

	public int ConditionalRelation
	{
		get
		{
			return conditionalRelation_;
		}
		set
		{
			conditionalRelation_ = value;
		}
	}

	public string SmartUnitGuid
	{
		get
		{
			return smartUnitGuid_;
		}
		set
		{
			smartUnitGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string PinName
	{
		get
		{
			return pinName_;
		}
		set
		{
			pinName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public CalliopeCustom_FBossPhaseInfo BossPhaseInfo
	{
		get
		{
			return bossPhaseInfo_;
		}
		set
		{
			bossPhaseInfo_ = value;
		}
	}

	public CalliopeCustom_DetectUnitCondition()
	{
	}

	public CalliopeCustom_DetectUnitCondition(CalliopeCustom_DetectUnitCondition other)
		: this()
	{
		unitType_ = other.unitType_;
		conditions_ = other.conditions_.Clone();
		conditionalRelation_ = other.conditionalRelation_;
		smartUnitGuid_ = other.smartUnitGuid_;
		pinName_ = other.pinName_;
		bossPhaseInfo_ = ((other.bossPhaseInfo_ != null) ? other.bossPhaseInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_DetectUnitCondition Clone()
	{
		return new CalliopeCustom_DetectUnitCondition(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_DetectUnitCondition);
	}

	public bool Equals(CalliopeCustom_DetectUnitCondition other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UnitType != other.UnitType)
		{
			return false;
		}
		if (!conditions_.Equals(other.conditions_))
		{
			return false;
		}
		if (ConditionalRelation != other.ConditionalRelation)
		{
			return false;
		}
		if (SmartUnitGuid != other.SmartUnitGuid)
		{
			return false;
		}
		if (PinName != other.PinName)
		{
			return false;
		}
		if (!object.Equals(BossPhaseInfo, other.BossPhaseInfo))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (UnitType != 0)
		{
			num ^= UnitType.GetHashCode();
		}
		num ^= conditions_.GetHashCode();
		if (ConditionalRelation != 0)
		{
			num ^= ConditionalRelation.GetHashCode();
		}
		if (SmartUnitGuid.Length != 0)
		{
			num ^= SmartUnitGuid.GetHashCode();
		}
		if (PinName.Length != 0)
		{
			num ^= PinName.GetHashCode();
		}
		if (bossPhaseInfo_ != null)
		{
			num ^= BossPhaseInfo.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (UnitType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(UnitType);
		}
		conditions_.WriteTo(output, _repeated_conditions_codec);
		if (ConditionalRelation != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ConditionalRelation);
		}
		if (SmartUnitGuid.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(SmartUnitGuid);
		}
		if (PinName.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(PinName);
		}
		if (bossPhaseInfo_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(BossPhaseInfo);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (UnitType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnitType);
		}
		num += conditions_.CalculateSize(_repeated_conditions_codec);
		if (ConditionalRelation != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionalRelation);
		}
		if (SmartUnitGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SmartUnitGuid);
		}
		if (PinName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PinName);
		}
		if (bossPhaseInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BossPhaseInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_DetectUnitCondition other)
	{
		if (other == null)
		{
			return;
		}
		if (other.UnitType != 0)
		{
			UnitType = other.UnitType;
		}
		conditions_.Add(other.conditions_);
		if (other.ConditionalRelation != 0)
		{
			ConditionalRelation = other.ConditionalRelation;
		}
		if (other.SmartUnitGuid.Length != 0)
		{
			SmartUnitGuid = other.SmartUnitGuid;
		}
		if (other.PinName.Length != 0)
		{
			PinName = other.PinName;
		}
		if (other.bossPhaseInfo_ != null)
		{
			if (bossPhaseInfo_ == null)
			{
				BossPhaseInfo = new CalliopeCustom_FBossPhaseInfo();
			}
			BossPhaseInfo.MergeFrom(other.BossPhaseInfo);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				UnitType = input.ReadInt32();
				break;
			case 18u:
				conditions_.AddEntriesFrom(input, _repeated_conditions_codec);
				break;
			case 24u:
				ConditionalRelation = input.ReadInt32();
				break;
			case 34u:
				SmartUnitGuid = input.ReadString();
				break;
			case 42u:
				PinName = input.ReadString();
				break;
			case 50u:
				if (bossPhaseInfo_ == null)
				{
					BossPhaseInfo = new CalliopeCustom_FBossPhaseInfo();
				}
				input.ReadMessage(BossPhaseInfo);
				break;
			}
		}
	}
}
