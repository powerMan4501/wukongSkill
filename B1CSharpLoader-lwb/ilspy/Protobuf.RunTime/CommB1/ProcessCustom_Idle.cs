using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class ProcessCustom_Idle : IMessage<ProcessCustom_Idle>, IMessage, IEquatable<ProcessCustom_Idle>, IDeepCloneable<ProcessCustom_Idle>
{
	private static readonly MessageParser<ProcessCustom_Idle> _parser = new MessageParser<ProcessCustom_Idle>(() => new ProcessCustom_Idle());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<CalliopeCustom_CompositeTransitionCondition_Idle> _repeated_transitionConditions_codec = FieldCodec.ForMessage(10u, CalliopeCustom_CompositeTransitionCondition_Idle.Parser);

	private readonly RepeatedField<CalliopeCustom_CompositeTransitionCondition_Idle> transitionConditions_ = new RepeatedField<CalliopeCustom_CompositeTransitionCondition_Idle>();

	private static readonly FieldCodec<CalliopeCustom_IdleProcessAction> _repeated_processActions_codec = FieldCodec.ForMessage(18u, CalliopeCustom_IdleProcessAction.Parser);

	private readonly RepeatedField<CalliopeCustom_IdleProcessAction> processActions_ = new RepeatedField<CalliopeCustom_IdleProcessAction>();

	private static readonly FieldCodec<CalliopeCustom_ManagedSceneObj> _repeated_managedObjs_codec = FieldCodec.ForMessage(26u, CalliopeCustom_ManagedSceneObj.Parser);

	private readonly RepeatedField<CalliopeCustom_ManagedSceneObj> managedObjs_ = new RepeatedField<CalliopeCustom_ManagedSceneObj>();

	private static readonly FieldCodec<CalliopeCustom_ManagedNPCUnit> _repeated_managedNpcUnits_codec = FieldCodec.ForMessage(34u, CalliopeCustom_ManagedNPCUnit.Parser);

	private readonly RepeatedField<CalliopeCustom_ManagedNPCUnit> managedNpcUnits_ = new RepeatedField<CalliopeCustom_ManagedNPCUnit>();

	private static readonly FieldCodec<CalliopeCustom_ManagedInteractor> _repeated_managedInteractors_codec = FieldCodec.ForMessage(42u, CalliopeCustom_ManagedInteractor.Parser);

	private readonly RepeatedField<CalliopeCustom_ManagedInteractor> managedInteractors_ = new RepeatedField<CalliopeCustom_ManagedInteractor>();

	private static readonly FieldCodec<CalliopeCustom_ManagedStreamingLevelStateConfig> _repeated_managedStreamingLevelStateConfigs_codec = FieldCodec.ForMessage(50u, CalliopeCustom_ManagedStreamingLevelStateConfig.Parser);

	private readonly RepeatedField<CalliopeCustom_ManagedStreamingLevelStateConfig> managedStreamingLevelStateConfigs_ = new RepeatedField<CalliopeCustom_ManagedStreamingLevelStateConfig>();

	private static readonly FieldCodec<CalliopeCustom_ManagedGroupUnit> _repeated_managedGroupUnits_codec = FieldCodec.ForMessage(58u, CalliopeCustom_ManagedGroupUnit.Parser);

	private readonly RepeatedField<CalliopeCustom_ManagedGroupUnit> managedGroupUnits_ = new RepeatedField<CalliopeCustom_ManagedGroupUnit>();

	public static MessageParser<ProcessCustom_Idle> Parser => _parser;

	public RepeatedField<CalliopeCustom_CompositeTransitionCondition_Idle> TransitionConditions => transitionConditions_;

	public RepeatedField<CalliopeCustom_IdleProcessAction> ProcessActions => processActions_;

	public RepeatedField<CalliopeCustom_ManagedSceneObj> ManagedObjs => managedObjs_;

	public RepeatedField<CalliopeCustom_ManagedNPCUnit> ManagedNpcUnits => managedNpcUnits_;

	public RepeatedField<CalliopeCustom_ManagedInteractor> ManagedInteractors => managedInteractors_;

	public RepeatedField<CalliopeCustom_ManagedStreamingLevelStateConfig> ManagedStreamingLevelStateConfigs => managedStreamingLevelStateConfigs_;

	public RepeatedField<CalliopeCustom_ManagedGroupUnit> ManagedGroupUnits => managedGroupUnits_;

	public ProcessCustom_Idle()
	{
	}

	public ProcessCustom_Idle(ProcessCustom_Idle other)
		: this()
	{
		transitionConditions_ = other.transitionConditions_.Clone();
		processActions_ = other.processActions_.Clone();
		managedObjs_ = other.managedObjs_.Clone();
		managedNpcUnits_ = other.managedNpcUnits_.Clone();
		managedInteractors_ = other.managedInteractors_.Clone();
		managedStreamingLevelStateConfigs_ = other.managedStreamingLevelStateConfigs_.Clone();
		managedGroupUnits_ = other.managedGroupUnits_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ProcessCustom_Idle Clone()
	{
		return new ProcessCustom_Idle(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ProcessCustom_Idle);
	}

	public bool Equals(ProcessCustom_Idle other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!transitionConditions_.Equals(other.transitionConditions_))
		{
			return false;
		}
		if (!processActions_.Equals(other.processActions_))
		{
			return false;
		}
		if (!managedObjs_.Equals(other.managedObjs_))
		{
			return false;
		}
		if (!managedNpcUnits_.Equals(other.managedNpcUnits_))
		{
			return false;
		}
		if (!managedInteractors_.Equals(other.managedInteractors_))
		{
			return false;
		}
		if (!managedStreamingLevelStateConfigs_.Equals(other.managedStreamingLevelStateConfigs_))
		{
			return false;
		}
		if (!managedGroupUnits_.Equals(other.managedGroupUnits_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= transitionConditions_.GetHashCode();
		num ^= processActions_.GetHashCode();
		num ^= managedObjs_.GetHashCode();
		num ^= managedNpcUnits_.GetHashCode();
		num ^= managedInteractors_.GetHashCode();
		num ^= managedStreamingLevelStateConfigs_.GetHashCode();
		num ^= managedGroupUnits_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		transitionConditions_.WriteTo(output, _repeated_transitionConditions_codec);
		processActions_.WriteTo(output, _repeated_processActions_codec);
		managedObjs_.WriteTo(output, _repeated_managedObjs_codec);
		managedNpcUnits_.WriteTo(output, _repeated_managedNpcUnits_codec);
		managedInteractors_.WriteTo(output, _repeated_managedInteractors_codec);
		managedStreamingLevelStateConfigs_.WriteTo(output, _repeated_managedStreamingLevelStateConfigs_codec);
		managedGroupUnits_.WriteTo(output, _repeated_managedGroupUnits_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += transitionConditions_.CalculateSize(_repeated_transitionConditions_codec);
		num += processActions_.CalculateSize(_repeated_processActions_codec);
		num += managedObjs_.CalculateSize(_repeated_managedObjs_codec);
		num += managedNpcUnits_.CalculateSize(_repeated_managedNpcUnits_codec);
		num += managedInteractors_.CalculateSize(_repeated_managedInteractors_codec);
		num += managedStreamingLevelStateConfigs_.CalculateSize(_repeated_managedStreamingLevelStateConfigs_codec);
		num += managedGroupUnits_.CalculateSize(_repeated_managedGroupUnits_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ProcessCustom_Idle other)
	{
		if (other != null)
		{
			transitionConditions_.Add(other.transitionConditions_);
			processActions_.Add(other.processActions_);
			managedObjs_.Add(other.managedObjs_);
			managedNpcUnits_.Add(other.managedNpcUnits_);
			managedInteractors_.Add(other.managedInteractors_);
			managedStreamingLevelStateConfigs_.Add(other.managedStreamingLevelStateConfigs_);
			managedGroupUnits_.Add(other.managedGroupUnits_);
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
			case 10u:
				transitionConditions_.AddEntriesFrom(input, _repeated_transitionConditions_codec);
				break;
			case 18u:
				processActions_.AddEntriesFrom(input, _repeated_processActions_codec);
				break;
			case 26u:
				managedObjs_.AddEntriesFrom(input, _repeated_managedObjs_codec);
				break;
			case 34u:
				managedNpcUnits_.AddEntriesFrom(input, _repeated_managedNpcUnits_codec);
				break;
			case 42u:
				managedInteractors_.AddEntriesFrom(input, _repeated_managedInteractors_codec);
				break;
			case 50u:
				managedStreamingLevelStateConfigs_.AddEntriesFrom(input, _repeated_managedStreamingLevelStateConfigs_codec);
				break;
			case 58u:
				managedGroupUnits_.AddEntriesFrom(input, _repeated_managedGroupUnits_codec);
				break;
			}
		}
	}
}
