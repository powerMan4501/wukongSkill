using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class ProcessCustom_Battle : IMessage<ProcessCustom_Battle>, IMessage, IEquatable<ProcessCustom_Battle>, IDeepCloneable<ProcessCustom_Battle>
{
	private static readonly MessageParser<ProcessCustom_Battle> _parser = new MessageParser<ProcessCustom_Battle>(() => new ProcessCustom_Battle());

	private UnknownFieldSet _unknownFields;

	private CalliopeCustom_BattleStartCondition startCondition_;

	private static readonly FieldCodec<string> _repeated_battleStartActiveList_codec = FieldCodec.ForString(18u);

	private readonly RepeatedField<string> battleStartActiveList_ = new RepeatedField<string>();

	private static readonly FieldCodec<string> _repeated_battleStartActiveGroupUnitList_codec = FieldCodec.ForString(26u);

	private readonly RepeatedField<string> battleStartActiveGroupUnitList_ = new RepeatedField<string>();

	private static readonly FieldCodec<CalliopeCustom_CompositeTransitionCondition_Battle> _repeated_transitionConditions_codec = FieldCodec.ForMessage(34u, CalliopeCustom_CompositeTransitionCondition_Battle.Parser);

	private readonly RepeatedField<CalliopeCustom_CompositeTransitionCondition_Battle> transitionConditions_ = new RepeatedField<CalliopeCustom_CompositeTransitionCondition_Battle>();

	private static readonly FieldCodec<CalliopeCustom_ManagedSceneObj> _repeated_managedObjs_codec = FieldCodec.ForMessage(42u, CalliopeCustom_ManagedSceneObj.Parser);

	private readonly RepeatedField<CalliopeCustom_ManagedSceneObj> managedObjs_ = new RepeatedField<CalliopeCustom_ManagedSceneObj>();

	private static readonly FieldCodec<CalliopeCustom_ManagedNPCUnit> _repeated_managedNpcUnits_codec = FieldCodec.ForMessage(50u, CalliopeCustom_ManagedNPCUnit.Parser);

	private readonly RepeatedField<CalliopeCustom_ManagedNPCUnit> managedNpcUnits_ = new RepeatedField<CalliopeCustom_ManagedNPCUnit>();

	private static readonly FieldCodec<CalliopeCustom_ManagedInteractor> _repeated_managedInteractors_codec = FieldCodec.ForMessage(58u, CalliopeCustom_ManagedInteractor.Parser);

	private readonly RepeatedField<CalliopeCustom_ManagedInteractor> managedInteractors_ = new RepeatedField<CalliopeCustom_ManagedInteractor>();

	private static readonly FieldCodec<CalliopeCustom_ManagedStreamingLevelStateConfig> _repeated_managedStreamingLevelStateConfigs_codec = FieldCodec.ForMessage(66u, CalliopeCustom_ManagedStreamingLevelStateConfig.Parser);

	private readonly RepeatedField<CalliopeCustom_ManagedStreamingLevelStateConfig> managedStreamingLevelStateConfigs_ = new RepeatedField<CalliopeCustom_ManagedStreamingLevelStateConfig>();

	private static readonly FieldCodec<CalliopeCustom_ManagedGroupUnit> _repeated_managedGroupUnits_codec = FieldCodec.ForMessage(74u, CalliopeCustom_ManagedGroupUnit.Parser);

	private readonly RepeatedField<CalliopeCustom_ManagedGroupUnit> managedGroupUnits_ = new RepeatedField<CalliopeCustom_ManagedGroupUnit>();

	public static MessageParser<ProcessCustom_Battle> Parser => _parser;

	public CalliopeCustom_BattleStartCondition StartCondition
	{
		get
		{
			return startCondition_;
		}
		set
		{
			startCondition_ = value;
		}
	}

	public RepeatedField<string> BattleStartActiveList => battleStartActiveList_;

	public RepeatedField<string> BattleStartActiveGroupUnitList => battleStartActiveGroupUnitList_;

	public RepeatedField<CalliopeCustom_CompositeTransitionCondition_Battle> TransitionConditions => transitionConditions_;

	public RepeatedField<CalliopeCustom_ManagedSceneObj> ManagedObjs => managedObjs_;

	public RepeatedField<CalliopeCustom_ManagedNPCUnit> ManagedNpcUnits => managedNpcUnits_;

	public RepeatedField<CalliopeCustom_ManagedInteractor> ManagedInteractors => managedInteractors_;

	public RepeatedField<CalliopeCustom_ManagedStreamingLevelStateConfig> ManagedStreamingLevelStateConfigs => managedStreamingLevelStateConfigs_;

	public RepeatedField<CalliopeCustom_ManagedGroupUnit> ManagedGroupUnits => managedGroupUnits_;

	public ProcessCustom_Battle()
	{
	}

	public ProcessCustom_Battle(ProcessCustom_Battle other)
		: this()
	{
		startCondition_ = ((other.startCondition_ != null) ? other.startCondition_.Clone() : null);
		battleStartActiveList_ = other.battleStartActiveList_.Clone();
		battleStartActiveGroupUnitList_ = other.battleStartActiveGroupUnitList_.Clone();
		transitionConditions_ = other.transitionConditions_.Clone();
		managedObjs_ = other.managedObjs_.Clone();
		managedNpcUnits_ = other.managedNpcUnits_.Clone();
		managedInteractors_ = other.managedInteractors_.Clone();
		managedStreamingLevelStateConfigs_ = other.managedStreamingLevelStateConfigs_.Clone();
		managedGroupUnits_ = other.managedGroupUnits_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ProcessCustom_Battle Clone()
	{
		return new ProcessCustom_Battle(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ProcessCustom_Battle);
	}

	public bool Equals(ProcessCustom_Battle other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(StartCondition, other.StartCondition))
		{
			return false;
		}
		if (!battleStartActiveList_.Equals(other.battleStartActiveList_))
		{
			return false;
		}
		if (!battleStartActiveGroupUnitList_.Equals(other.battleStartActiveGroupUnitList_))
		{
			return false;
		}
		if (!transitionConditions_.Equals(other.transitionConditions_))
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
		if (startCondition_ != null)
		{
			num ^= StartCondition.GetHashCode();
		}
		num ^= battleStartActiveList_.GetHashCode();
		num ^= battleStartActiveGroupUnitList_.GetHashCode();
		num ^= transitionConditions_.GetHashCode();
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
		if (startCondition_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(StartCondition);
		}
		battleStartActiveList_.WriteTo(output, _repeated_battleStartActiveList_codec);
		battleStartActiveGroupUnitList_.WriteTo(output, _repeated_battleStartActiveGroupUnitList_codec);
		transitionConditions_.WriteTo(output, _repeated_transitionConditions_codec);
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
		if (startCondition_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(StartCondition);
		}
		num += battleStartActiveList_.CalculateSize(_repeated_battleStartActiveList_codec);
		num += battleStartActiveGroupUnitList_.CalculateSize(_repeated_battleStartActiveGroupUnitList_codec);
		num += transitionConditions_.CalculateSize(_repeated_transitionConditions_codec);
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

	public void MergeFrom(ProcessCustom_Battle other)
	{
		if (other == null)
		{
			return;
		}
		if (other.startCondition_ != null)
		{
			if (startCondition_ == null)
			{
				StartCondition = new CalliopeCustom_BattleStartCondition();
			}
			StartCondition.MergeFrom(other.StartCondition);
		}
		battleStartActiveList_.Add(other.battleStartActiveList_);
		battleStartActiveGroupUnitList_.Add(other.battleStartActiveGroupUnitList_);
		transitionConditions_.Add(other.transitionConditions_);
		managedObjs_.Add(other.managedObjs_);
		managedNpcUnits_.Add(other.managedNpcUnits_);
		managedInteractors_.Add(other.managedInteractors_);
		managedStreamingLevelStateConfigs_.Add(other.managedStreamingLevelStateConfigs_);
		managedGroupUnits_.Add(other.managedGroupUnits_);
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
				if (startCondition_ == null)
				{
					StartCondition = new CalliopeCustom_BattleStartCondition();
				}
				input.ReadMessage(StartCondition);
				break;
			case 18u:
				battleStartActiveList_.AddEntriesFrom(input, _repeated_battleStartActiveList_codec);
				break;
			case 26u:
				battleStartActiveGroupUnitList_.AddEntriesFrom(input, _repeated_battleStartActiveGroupUnitList_codec);
				break;
			case 34u:
				transitionConditions_.AddEntriesFrom(input, _repeated_transitionConditions_codec);
				break;
			case 42u:
				managedObjs_.AddEntriesFrom(input, _repeated_managedObjs_codec);
				break;
			case 50u:
				managedNpcUnits_.AddEntriesFrom(input, _repeated_managedNpcUnits_codec);
				break;
			case 58u:
				managedInteractors_.AddEntriesFrom(input, _repeated_managedInteractors_codec);
				break;
			case 66u:
				managedStreamingLevelStateConfigs_.AddEntriesFrom(input, _repeated_managedStreamingLevelStateConfigs_codec);
				break;
			case 74u:
				managedGroupUnits_.AddEntriesFrom(input, _repeated_managedGroupUnits_codec);
				break;
			}
		}
	}
}
