using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class StateCustom_Single : IMessage<StateCustom_Single>, IMessage, IEquatable<StateCustom_Single>, IDeepCloneable<StateCustom_Single>
{
	private static readonly MessageParser<StateCustom_Single> _parser = new MessageParser<StateCustom_Single>(() => new StateCustom_Single());

	private UnknownFieldSet _unknownFields;

	private string stateName_ = "";

	private string subStateMachinePath_ = "";

	private static readonly FieldCodec<CalliopeCustom_DetectUnitCondition> _repeated_detectUnitConditions_codec = FieldCodec.ForMessage(26u, CalliopeCustom_DetectUnitCondition.Parser);

	private readonly RepeatedField<CalliopeCustom_DetectUnitCondition> detectUnitConditions_ = new RepeatedField<CalliopeCustom_DetectUnitCondition>();

	private static readonly FieldCodec<CalliopeCustom_CompositeTransitionCondition_State> _repeated_otherConditions_codec = FieldCodec.ForMessage(34u, CalliopeCustom_CompositeTransitionCondition_State.Parser);

	private readonly RepeatedField<CalliopeCustom_CompositeTransitionCondition_State> otherConditions_ = new RepeatedField<CalliopeCustom_CompositeTransitionCondition_State>();

	private static readonly FieldCodec<string> _repeated_customEnterEvents_codec = FieldCodec.ForString(42u);

	private readonly RepeatedField<string> customEnterEvents_ = new RepeatedField<string>();

	private static readonly FieldCodec<string> _repeated_customExitEvents_codec = FieldCodec.ForString(50u);

	private readonly RepeatedField<string> customExitEvents_ = new RepeatedField<string>();

	private CalliopeCustom_StateNodeChildActorControl childActorCollection_;

	public static MessageParser<StateCustom_Single> Parser => _parser;

	public string StateName
	{
		get
		{
			return stateName_;
		}
		set
		{
			stateName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string SubStateMachinePath
	{
		get
		{
			return subStateMachinePath_;
		}
		set
		{
			subStateMachinePath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<CalliopeCustom_DetectUnitCondition> DetectUnitConditions => detectUnitConditions_;

	public RepeatedField<CalliopeCustom_CompositeTransitionCondition_State> OtherConditions => otherConditions_;

	public RepeatedField<string> CustomEnterEvents => customEnterEvents_;

	public RepeatedField<string> CustomExitEvents => customExitEvents_;

	public CalliopeCustom_StateNodeChildActorControl ChildActorCollection
	{
		get
		{
			return childActorCollection_;
		}
		set
		{
			childActorCollection_ = value;
		}
	}

	public StateCustom_Single()
	{
	}

	public StateCustom_Single(StateCustom_Single other)
		: this()
	{
		stateName_ = other.stateName_;
		subStateMachinePath_ = other.subStateMachinePath_;
		detectUnitConditions_ = other.detectUnitConditions_.Clone();
		otherConditions_ = other.otherConditions_.Clone();
		customEnterEvents_ = other.customEnterEvents_.Clone();
		customExitEvents_ = other.customExitEvents_.Clone();
		childActorCollection_ = ((other.childActorCollection_ != null) ? other.childActorCollection_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public StateCustom_Single Clone()
	{
		return new StateCustom_Single(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as StateCustom_Single);
	}

	public bool Equals(StateCustom_Single other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (StateName != other.StateName)
		{
			return false;
		}
		if (SubStateMachinePath != other.SubStateMachinePath)
		{
			return false;
		}
		if (!detectUnitConditions_.Equals(other.detectUnitConditions_))
		{
			return false;
		}
		if (!otherConditions_.Equals(other.otherConditions_))
		{
			return false;
		}
		if (!customEnterEvents_.Equals(other.customEnterEvents_))
		{
			return false;
		}
		if (!customExitEvents_.Equals(other.customExitEvents_))
		{
			return false;
		}
		if (!object.Equals(ChildActorCollection, other.ChildActorCollection))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (StateName.Length != 0)
		{
			num ^= StateName.GetHashCode();
		}
		if (SubStateMachinePath.Length != 0)
		{
			num ^= SubStateMachinePath.GetHashCode();
		}
		num ^= detectUnitConditions_.GetHashCode();
		num ^= otherConditions_.GetHashCode();
		num ^= customEnterEvents_.GetHashCode();
		num ^= customExitEvents_.GetHashCode();
		if (childActorCollection_ != null)
		{
			num ^= ChildActorCollection.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (StateName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(StateName);
		}
		if (SubStateMachinePath.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(SubStateMachinePath);
		}
		detectUnitConditions_.WriteTo(output, _repeated_detectUnitConditions_codec);
		otherConditions_.WriteTo(output, _repeated_otherConditions_codec);
		customEnterEvents_.WriteTo(output, _repeated_customEnterEvents_codec);
		customExitEvents_.WriteTo(output, _repeated_customExitEvents_codec);
		if (childActorCollection_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(ChildActorCollection);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (StateName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(StateName);
		}
		if (SubStateMachinePath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SubStateMachinePath);
		}
		num += detectUnitConditions_.CalculateSize(_repeated_detectUnitConditions_codec);
		num += otherConditions_.CalculateSize(_repeated_otherConditions_codec);
		num += customEnterEvents_.CalculateSize(_repeated_customEnterEvents_codec);
		num += customExitEvents_.CalculateSize(_repeated_customExitEvents_codec);
		if (childActorCollection_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ChildActorCollection);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(StateCustom_Single other)
	{
		if (other == null)
		{
			return;
		}
		if (other.StateName.Length != 0)
		{
			StateName = other.StateName;
		}
		if (other.SubStateMachinePath.Length != 0)
		{
			SubStateMachinePath = other.SubStateMachinePath;
		}
		detectUnitConditions_.Add(other.detectUnitConditions_);
		otherConditions_.Add(other.otherConditions_);
		customEnterEvents_.Add(other.customEnterEvents_);
		customExitEvents_.Add(other.customExitEvents_);
		if (other.childActorCollection_ != null)
		{
			if (childActorCollection_ == null)
			{
				ChildActorCollection = new CalliopeCustom_StateNodeChildActorControl();
			}
			ChildActorCollection.MergeFrom(other.ChildActorCollection);
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
				StateName = input.ReadString();
				break;
			case 18u:
				SubStateMachinePath = input.ReadString();
				break;
			case 26u:
				detectUnitConditions_.AddEntriesFrom(input, _repeated_detectUnitConditions_codec);
				break;
			case 34u:
				otherConditions_.AddEntriesFrom(input, _repeated_otherConditions_codec);
				break;
			case 42u:
				customEnterEvents_.AddEntriesFrom(input, _repeated_customEnterEvents_codec);
				break;
			case 50u:
				customExitEvents_.AddEntriesFrom(input, _repeated_customExitEvents_codec);
				break;
			case 58u:
				if (childActorCollection_ == null)
				{
					ChildActorCollection = new CalliopeCustom_StateNodeChildActorControl();
				}
				input.ReadMessage(ChildActorCollection);
				break;
			}
		}
	}
}
