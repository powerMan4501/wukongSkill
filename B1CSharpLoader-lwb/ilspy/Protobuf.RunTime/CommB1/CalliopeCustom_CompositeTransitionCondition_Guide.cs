using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class CalliopeCustom_CompositeTransitionCondition_Guide : IMessage<CalliopeCustom_CompositeTransitionCondition_Guide>, IMessage, IEquatable<CalliopeCustom_CompositeTransitionCondition_Guide>, IDeepCloneable<CalliopeCustom_CompositeTransitionCondition_Guide>
{
	private static readonly MessageParser<CalliopeCustom_CompositeTransitionCondition_Guide> _parser = new MessageParser<CalliopeCustom_CompositeTransitionCondition_Guide>(() => new CalliopeCustom_CompositeTransitionCondition_Guide());

	private UnknownFieldSet _unknownFields;

	private CalliopeCustom_TransitionCondition_Guide single_;

	private bool isUseCompositeCondition_;

	private static readonly FieldCodec<CalliopeCustom_TransitionCondition_Guide> _repeated_conditions_codec = FieldCodec.ForMessage(26u, CalliopeCustom_TransitionCondition_Guide.Parser);

	private readonly RepeatedField<CalliopeCustom_TransitionCondition_Guide> conditions_ = new RepeatedField<CalliopeCustom_TransitionCondition_Guide>();

	private int conditionalRelation_;

	private bool isReverseCondition_;

	private string pinName_ = "";

	public static MessageParser<CalliopeCustom_CompositeTransitionCondition_Guide> Parser => _parser;

	public CalliopeCustom_TransitionCondition_Guide Single
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

	public RepeatedField<CalliopeCustom_TransitionCondition_Guide> Conditions => conditions_;

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

	public bool IsReverseCondition
	{
		get
		{
			return isReverseCondition_;
		}
		set
		{
			isReverseCondition_ = value;
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

	public CalliopeCustom_CompositeTransitionCondition_Guide()
	{
	}

	public CalliopeCustom_CompositeTransitionCondition_Guide(CalliopeCustom_CompositeTransitionCondition_Guide other)
		: this()
	{
		single_ = ((other.single_ != null) ? other.single_.Clone() : null);
		isUseCompositeCondition_ = other.isUseCompositeCondition_;
		conditions_ = other.conditions_.Clone();
		conditionalRelation_ = other.conditionalRelation_;
		isReverseCondition_ = other.isReverseCondition_;
		pinName_ = other.pinName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_CompositeTransitionCondition_Guide Clone()
	{
		return new CalliopeCustom_CompositeTransitionCondition_Guide(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_CompositeTransitionCondition_Guide);
	}

	public bool Equals(CalliopeCustom_CompositeTransitionCondition_Guide other)
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
		if (IsReverseCondition != other.IsReverseCondition)
		{
			return false;
		}
		if (PinName != other.PinName)
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
		if (IsReverseCondition)
		{
			num ^= IsReverseCondition.GetHashCode();
		}
		if (PinName.Length != 0)
		{
			num ^= PinName.GetHashCode();
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
		if (IsReverseCondition)
		{
			output.WriteRawTag(40);
			output.WriteBool(IsReverseCondition);
		}
		if (PinName.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(PinName);
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
		if (IsReverseCondition)
		{
			num += 2;
		}
		if (PinName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PinName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_CompositeTransitionCondition_Guide other)
	{
		if (other == null)
		{
			return;
		}
		if (other.single_ != null)
		{
			if (single_ == null)
			{
				Single = new CalliopeCustom_TransitionCondition_Guide();
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
		if (other.IsReverseCondition)
		{
			IsReverseCondition = other.IsReverseCondition;
		}
		if (other.PinName.Length != 0)
		{
			PinName = other.PinName;
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
					Single = new CalliopeCustom_TransitionCondition_Guide();
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
			case 40u:
				IsReverseCondition = input.ReadBool();
				break;
			case 50u:
				PinName = input.ReadString();
				break;
			}
		}
	}
}
