using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using GurCalliopeState;

namespace CommB1;

public sealed class CalliopeCustom_CompositeTransitionCondition_State : IMessage<CalliopeCustom_CompositeTransitionCondition_State>, IMessage, IEquatable<CalliopeCustom_CompositeTransitionCondition_State>, IDeepCloneable<CalliopeCustom_CompositeTransitionCondition_State>
{
	private static readonly MessageParser<CalliopeCustom_CompositeTransitionCondition_State> _parser = new MessageParser<CalliopeCustom_CompositeTransitionCondition_State>(() => new CalliopeCustom_CompositeTransitionCondition_State());

	private UnknownFieldSet _unknownFields;

	private CalliopeCustom_TransitionCondition_State single_;

	private bool isUseCompositeCondition_;

	private static readonly FieldCodec<CalliopeCustom_TransitionCondition_State> _repeated_conditions_codec = FieldCodec.ForMessage(26u, CalliopeCustom_TransitionCondition_State.Parser);

	private readonly RepeatedField<CalliopeCustom_TransitionCondition_State> conditions_ = new RepeatedField<CalliopeCustom_TransitionCondition_State>();

	private int conditionalRelation_;

	private string pinName_ = "";

	private CalliopeCustom_FBossPhaseInfo bossPhaseInfo_;

	public static MessageParser<CalliopeCustom_CompositeTransitionCondition_State> Parser => _parser;

	public CalliopeCustom_TransitionCondition_State Single
	{
		get
		{
			return single_;
		}
		set
		{
			single_ = value;
		}
	}

	public bool IsUseCompositeCondition
	{
		get
		{
			return isUseCompositeCondition_;
		}
		set
		{
			isUseCompositeCondition_ = value;
		}
	}

	public RepeatedField<CalliopeCustom_TransitionCondition_State> Conditions => conditions_;

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

	public CalliopeCustom_CompositeTransitionCondition_State()
	{
	}

	public CalliopeCustom_CompositeTransitionCondition_State(CalliopeCustom_CompositeTransitionCondition_State other)
		: this()
	{
		single_ = ((other.single_ != null) ? other.single_.Clone() : null);
		isUseCompositeCondition_ = other.isUseCompositeCondition_;
		conditions_ = other.conditions_.Clone();
		conditionalRelation_ = other.conditionalRelation_;
		pinName_ = other.pinName_;
		bossPhaseInfo_ = ((other.bossPhaseInfo_ != null) ? other.bossPhaseInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_CompositeTransitionCondition_State Clone()
	{
		return new CalliopeCustom_CompositeTransitionCondition_State(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_CompositeTransitionCondition_State);
	}

	public bool Equals(CalliopeCustom_CompositeTransitionCondition_State other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Single, other.Single))
		{
			return false;
		}
		if (IsUseCompositeCondition != other.IsUseCompositeCondition)
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
		if (single_ != null)
		{
			num ^= Single.GetHashCode();
		}
		if (IsUseCompositeCondition)
		{
			num ^= IsUseCompositeCondition.GetHashCode();
		}
		num ^= conditions_.GetHashCode();
		if (ConditionalRelation != 0)
		{
			num ^= ConditionalRelation.GetHashCode();
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
		if (single_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Single);
		}
		if (IsUseCompositeCondition)
		{
			output.WriteRawTag(16);
			output.WriteBool(IsUseCompositeCondition);
		}
		conditions_.WriteTo(output, _repeated_conditions_codec);
		if (ConditionalRelation != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ConditionalRelation);
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
		if (single_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Single);
		}
		if (IsUseCompositeCondition)
		{
			num += 2;
		}
		num += conditions_.CalculateSize(_repeated_conditions_codec);
		if (ConditionalRelation != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionalRelation);
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

	public void MergeFrom(CalliopeCustom_CompositeTransitionCondition_State other)
	{
		if (other == null)
		{
			return;
		}
		if (other.single_ != null)
		{
			if (single_ == null)
			{
				Single = new CalliopeCustom_TransitionCondition_State();
			}
			Single.MergeFrom(other.Single);
		}
		if (other.IsUseCompositeCondition)
		{
			IsUseCompositeCondition = other.IsUseCompositeCondition;
		}
		conditions_.Add(other.conditions_);
		if (other.ConditionalRelation != 0)
		{
			ConditionalRelation = other.ConditionalRelation;
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
			case 10u:
				if (single_ == null)
				{
					Single = new CalliopeCustom_TransitionCondition_State();
				}
				input.ReadMessage(Single);
				break;
			case 16u:
				IsUseCompositeCondition = input.ReadBool();
				break;
			case 26u:
				conditions_.AddEntriesFrom(input, _repeated_conditions_codec);
				break;
			case 32u:
				ConditionalRelation = input.ReadInt32();
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
