using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStImmobilizeSkillConfigDesc : IMessage<FUStImmobilizeSkillConfigDesc>, IMessage, IEquatable<FUStImmobilizeSkillConfigDesc>, IDeepCloneable<FUStImmobilizeSkillConfigDesc>
{
	private static readonly MessageParser<FUStImmobilizeSkillConfigDesc> _parser = new MessageParser<FUStImmobilizeSkillConfigDesc>(() => new FUStImmobilizeSkillConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int durationMs_;

	private int almostEndAheadTimeMs_;

	private int minimalDurationMs_;

	private int targetFilter_;

	private int targetTypeFilter_;

	private int affiliationTypeFilter_;

	private int targetCount_;

	private int rangeRadius_;

	private int repeatedImmobilizedDef_;

	private int greatSageTalentActiveBuff_;

	private static readonly FieldCodec<FSpellEffect> _repeated_beginEffects_codec = FieldCodec.ForMessage(98u, FSpellEffect.Parser);

	private readonly RepeatedField<FSpellEffect> beginEffects_ = new RepeatedField<FSpellEffect>();

	private static readonly FieldCodec<FSpellEffect> _repeated_endEffects_codec = FieldCodec.ForMessage(106u, FSpellEffect.Parser);

	private readonly RepeatedField<FSpellEffect> endEffects_ = new RepeatedField<FSpellEffect>();

	private static readonly FieldCodec<FSpellEffect> _repeated_breakEffects_codec = FieldCodec.ForMessage(114u, FSpellEffect.Parser);

	private readonly RepeatedField<FSpellEffect> breakEffects_ = new RepeatedField<FSpellEffect>();

	private static readonly FieldCodec<FSpellEffect> _repeated_deadEffects_codec = FieldCodec.ForMessage(122u, FSpellEffect.Parser);

	private readonly RepeatedField<FSpellEffect> deadEffects_ = new RepeatedField<FSpellEffect>();

	private static readonly FieldCodec<FPlayFXByResID> _repeated_beginFXs_codec = FieldCodec.ForMessage(130u, FPlayFXByResID.Parser);

	private readonly RepeatedField<FPlayFXByResID> beginFXs_ = new RepeatedField<FPlayFXByResID>();

	private static readonly FieldCodec<FPlayFXByResID> _repeated_almostEndFXs_codec = FieldCodec.ForMessage(138u, FPlayFXByResID.Parser);

	private readonly RepeatedField<FPlayFXByResID> almostEndFXs_ = new RepeatedField<FPlayFXByResID>();

	private static readonly FieldCodec<FPlayFXByResID> _repeated_endFXs_codec = FieldCodec.ForMessage(146u, FPlayFXByResID.Parser);

	private readonly RepeatedField<FPlayFXByResID> endFXs_ = new RepeatedField<FPlayFXByResID>();

	private static readonly FieldCodec<FPlayFXByResID> _repeated_quickEndFXs_codec = FieldCodec.ForMessage(154u, FPlayFXByResID.Parser);

	private readonly RepeatedField<FPlayFXByResID> quickEndFXs_ = new RepeatedField<FPlayFXByResID>();

	private static readonly FieldCodec<FPlayFXByResID> _repeated_failedFXs_codec = FieldCodec.ForMessage(162u, FPlayFXByResID.Parser);

	private readonly RepeatedField<FPlayFXByResID> failedFXs_ = new RepeatedField<FPlayFXByResID>();

	private int breakingFXsTriggerRatio_;

	private static readonly FieldCodec<FPlayFXByResID> _repeated_breakingFXs_codec = FieldCodec.ForMessage(178u, FPlayFXByResID.Parser);

	private readonly RepeatedField<FPlayFXByResID> breakingFXs_ = new RepeatedField<FPlayFXByResID>();

	public static MessageParser<FUStImmobilizeSkillConfigDesc> Parser => _parser;

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

	public int DurationMs
	{
		get
		{
			return durationMs_;
		}
		set
		{
			durationMs_ = value;
		}
	}

	public int AlmostEndAheadTimeMs
	{
		get
		{
			return almostEndAheadTimeMs_;
		}
		set
		{
			almostEndAheadTimeMs_ = value;
		}
	}

	public int MinimalDurationMs
	{
		get
		{
			return minimalDurationMs_;
		}
		set
		{
			minimalDurationMs_ = value;
		}
	}

	public int TargetFilter
	{
		get
		{
			return targetFilter_;
		}
		set
		{
			targetFilter_ = value;
		}
	}

	public int TargetTypeFilter
	{
		get
		{
			return targetTypeFilter_;
		}
		set
		{
			targetTypeFilter_ = value;
		}
	}

	public int AffiliationTypeFilter
	{
		get
		{
			return affiliationTypeFilter_;
		}
		set
		{
			affiliationTypeFilter_ = value;
		}
	}

	public int TargetCount
	{
		get
		{
			return targetCount_;
		}
		set
		{
			targetCount_ = value;
		}
	}

	public int RangeRadius
	{
		get
		{
			return rangeRadius_;
		}
		set
		{
			rangeRadius_ = value;
		}
	}

	public int RepeatedImmobilizedDef
	{
		get
		{
			return repeatedImmobilizedDef_;
		}
		set
		{
			repeatedImmobilizedDef_ = value;
		}
	}

	public int GreatSageTalentActiveBuff
	{
		get
		{
			return greatSageTalentActiveBuff_;
		}
		set
		{
			greatSageTalentActiveBuff_ = value;
		}
	}

	public RepeatedField<FSpellEffect> BeginEffects => beginEffects_;

	public RepeatedField<FSpellEffect> EndEffects => endEffects_;

	public RepeatedField<FSpellEffect> BreakEffects => breakEffects_;

	public RepeatedField<FSpellEffect> DeadEffects => deadEffects_;

	public RepeatedField<FPlayFXByResID> BeginFXs => beginFXs_;

	public RepeatedField<FPlayFXByResID> AlmostEndFXs => almostEndFXs_;

	public RepeatedField<FPlayFXByResID> EndFXs => endFXs_;

	public RepeatedField<FPlayFXByResID> QuickEndFXs => quickEndFXs_;

	public RepeatedField<FPlayFXByResID> FailedFXs => failedFXs_;

	public int BreakingFXsTriggerRatio
	{
		get
		{
			return breakingFXsTriggerRatio_;
		}
		set
		{
			breakingFXsTriggerRatio_ = value;
		}
	}

	public RepeatedField<FPlayFXByResID> BreakingFXs => breakingFXs_;

	public FUStImmobilizeSkillConfigDesc()
	{
	}

	public FUStImmobilizeSkillConfigDesc(FUStImmobilizeSkillConfigDesc other)
		: this()
	{
		iD_ = other.iD_;
		durationMs_ = other.durationMs_;
		almostEndAheadTimeMs_ = other.almostEndAheadTimeMs_;
		minimalDurationMs_ = other.minimalDurationMs_;
		targetFilter_ = other.targetFilter_;
		targetTypeFilter_ = other.targetTypeFilter_;
		affiliationTypeFilter_ = other.affiliationTypeFilter_;
		targetCount_ = other.targetCount_;
		rangeRadius_ = other.rangeRadius_;
		repeatedImmobilizedDef_ = other.repeatedImmobilizedDef_;
		greatSageTalentActiveBuff_ = other.greatSageTalentActiveBuff_;
		beginEffects_ = other.beginEffects_.Clone();
		endEffects_ = other.endEffects_.Clone();
		breakEffects_ = other.breakEffects_.Clone();
		deadEffects_ = other.deadEffects_.Clone();
		beginFXs_ = other.beginFXs_.Clone();
		almostEndFXs_ = other.almostEndFXs_.Clone();
		endFXs_ = other.endFXs_.Clone();
		quickEndFXs_ = other.quickEndFXs_.Clone();
		failedFXs_ = other.failedFXs_.Clone();
		breakingFXsTriggerRatio_ = other.breakingFXsTriggerRatio_;
		breakingFXs_ = other.breakingFXs_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStImmobilizeSkillConfigDesc Clone()
	{
		return new FUStImmobilizeSkillConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStImmobilizeSkillConfigDesc);
	}

	public bool Equals(FUStImmobilizeSkillConfigDesc other)
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
		if (DurationMs != other.DurationMs)
		{
			return false;
		}
		if (AlmostEndAheadTimeMs != other.AlmostEndAheadTimeMs)
		{
			return false;
		}
		if (MinimalDurationMs != other.MinimalDurationMs)
		{
			return false;
		}
		if (TargetFilter != other.TargetFilter)
		{
			return false;
		}
		if (TargetTypeFilter != other.TargetTypeFilter)
		{
			return false;
		}
		if (AffiliationTypeFilter != other.AffiliationTypeFilter)
		{
			return false;
		}
		if (TargetCount != other.TargetCount)
		{
			return false;
		}
		if (RangeRadius != other.RangeRadius)
		{
			return false;
		}
		if (RepeatedImmobilizedDef != other.RepeatedImmobilizedDef)
		{
			return false;
		}
		if (GreatSageTalentActiveBuff != other.GreatSageTalentActiveBuff)
		{
			return false;
		}
		if (!beginEffects_.Equals(other.beginEffects_))
		{
			return false;
		}
		if (!endEffects_.Equals(other.endEffects_))
		{
			return false;
		}
		if (!breakEffects_.Equals(other.breakEffects_))
		{
			return false;
		}
		if (!deadEffects_.Equals(other.deadEffects_))
		{
			return false;
		}
		if (!beginFXs_.Equals(other.beginFXs_))
		{
			return false;
		}
		if (!almostEndFXs_.Equals(other.almostEndFXs_))
		{
			return false;
		}
		if (!endFXs_.Equals(other.endFXs_))
		{
			return false;
		}
		if (!quickEndFXs_.Equals(other.quickEndFXs_))
		{
			return false;
		}
		if (!failedFXs_.Equals(other.failedFXs_))
		{
			return false;
		}
		if (BreakingFXsTriggerRatio != other.BreakingFXsTriggerRatio)
		{
			return false;
		}
		if (!breakingFXs_.Equals(other.breakingFXs_))
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
		if (DurationMs != 0)
		{
			num ^= DurationMs.GetHashCode();
		}
		if (AlmostEndAheadTimeMs != 0)
		{
			num ^= AlmostEndAheadTimeMs.GetHashCode();
		}
		if (MinimalDurationMs != 0)
		{
			num ^= MinimalDurationMs.GetHashCode();
		}
		if (TargetFilter != 0)
		{
			num ^= TargetFilter.GetHashCode();
		}
		if (TargetTypeFilter != 0)
		{
			num ^= TargetTypeFilter.GetHashCode();
		}
		if (AffiliationTypeFilter != 0)
		{
			num ^= AffiliationTypeFilter.GetHashCode();
		}
		if (TargetCount != 0)
		{
			num ^= TargetCount.GetHashCode();
		}
		if (RangeRadius != 0)
		{
			num ^= RangeRadius.GetHashCode();
		}
		if (RepeatedImmobilizedDef != 0)
		{
			num ^= RepeatedImmobilizedDef.GetHashCode();
		}
		if (GreatSageTalentActiveBuff != 0)
		{
			num ^= GreatSageTalentActiveBuff.GetHashCode();
		}
		num ^= beginEffects_.GetHashCode();
		num ^= endEffects_.GetHashCode();
		num ^= breakEffects_.GetHashCode();
		num ^= deadEffects_.GetHashCode();
		num ^= beginFXs_.GetHashCode();
		num ^= almostEndFXs_.GetHashCode();
		num ^= endFXs_.GetHashCode();
		num ^= quickEndFXs_.GetHashCode();
		num ^= failedFXs_.GetHashCode();
		if (BreakingFXsTriggerRatio != 0)
		{
			num ^= BreakingFXsTriggerRatio.GetHashCode();
		}
		num ^= breakingFXs_.GetHashCode();
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
		if (DurationMs != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(DurationMs);
		}
		if (AlmostEndAheadTimeMs != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(AlmostEndAheadTimeMs);
		}
		if (MinimalDurationMs != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(MinimalDurationMs);
		}
		if (TargetFilter != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(TargetFilter);
		}
		if (TargetTypeFilter != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(TargetTypeFilter);
		}
		if (AffiliationTypeFilter != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(AffiliationTypeFilter);
		}
		if (TargetCount != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(TargetCount);
		}
		if (RangeRadius != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(RangeRadius);
		}
		if (RepeatedImmobilizedDef != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(RepeatedImmobilizedDef);
		}
		if (GreatSageTalentActiveBuff != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(GreatSageTalentActiveBuff);
		}
		beginEffects_.WriteTo(output, _repeated_beginEffects_codec);
		endEffects_.WriteTo(output, _repeated_endEffects_codec);
		breakEffects_.WriteTo(output, _repeated_breakEffects_codec);
		deadEffects_.WriteTo(output, _repeated_deadEffects_codec);
		beginFXs_.WriteTo(output, _repeated_beginFXs_codec);
		almostEndFXs_.WriteTo(output, _repeated_almostEndFXs_codec);
		endFXs_.WriteTo(output, _repeated_endFXs_codec);
		quickEndFXs_.WriteTo(output, _repeated_quickEndFXs_codec);
		failedFXs_.WriteTo(output, _repeated_failedFXs_codec);
		if (BreakingFXsTriggerRatio != 0)
		{
			output.WriteRawTag(168, 1);
			output.WriteInt32(BreakingFXsTriggerRatio);
		}
		breakingFXs_.WriteTo(output, _repeated_breakingFXs_codec);
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
		if (DurationMs != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DurationMs);
		}
		if (AlmostEndAheadTimeMs != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AlmostEndAheadTimeMs);
		}
		if (MinimalDurationMs != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MinimalDurationMs);
		}
		if (TargetFilter != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetFilter);
		}
		if (TargetTypeFilter != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetTypeFilter);
		}
		if (AffiliationTypeFilter != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AffiliationTypeFilter);
		}
		if (TargetCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetCount);
		}
		if (RangeRadius != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RangeRadius);
		}
		if (RepeatedImmobilizedDef != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RepeatedImmobilizedDef);
		}
		if (GreatSageTalentActiveBuff != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GreatSageTalentActiveBuff);
		}
		num += beginEffects_.CalculateSize(_repeated_beginEffects_codec);
		num += endEffects_.CalculateSize(_repeated_endEffects_codec);
		num += breakEffects_.CalculateSize(_repeated_breakEffects_codec);
		num += deadEffects_.CalculateSize(_repeated_deadEffects_codec);
		num += beginFXs_.CalculateSize(_repeated_beginFXs_codec);
		num += almostEndFXs_.CalculateSize(_repeated_almostEndFXs_codec);
		num += endFXs_.CalculateSize(_repeated_endFXs_codec);
		num += quickEndFXs_.CalculateSize(_repeated_quickEndFXs_codec);
		num += failedFXs_.CalculateSize(_repeated_failedFXs_codec);
		if (BreakingFXsTriggerRatio != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(BreakingFXsTriggerRatio);
		}
		num += breakingFXs_.CalculateSize(_repeated_breakingFXs_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStImmobilizeSkillConfigDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.DurationMs != 0)
			{
				DurationMs = other.DurationMs;
			}
			if (other.AlmostEndAheadTimeMs != 0)
			{
				AlmostEndAheadTimeMs = other.AlmostEndAheadTimeMs;
			}
			if (other.MinimalDurationMs != 0)
			{
				MinimalDurationMs = other.MinimalDurationMs;
			}
			if (other.TargetFilter != 0)
			{
				TargetFilter = other.TargetFilter;
			}
			if (other.TargetTypeFilter != 0)
			{
				TargetTypeFilter = other.TargetTypeFilter;
			}
			if (other.AffiliationTypeFilter != 0)
			{
				AffiliationTypeFilter = other.AffiliationTypeFilter;
			}
			if (other.TargetCount != 0)
			{
				TargetCount = other.TargetCount;
			}
			if (other.RangeRadius != 0)
			{
				RangeRadius = other.RangeRadius;
			}
			if (other.RepeatedImmobilizedDef != 0)
			{
				RepeatedImmobilizedDef = other.RepeatedImmobilizedDef;
			}
			if (other.GreatSageTalentActiveBuff != 0)
			{
				GreatSageTalentActiveBuff = other.GreatSageTalentActiveBuff;
			}
			beginEffects_.Add(other.beginEffects_);
			endEffects_.Add(other.endEffects_);
			breakEffects_.Add(other.breakEffects_);
			deadEffects_.Add(other.deadEffects_);
			beginFXs_.Add(other.beginFXs_);
			almostEndFXs_.Add(other.almostEndFXs_);
			endFXs_.Add(other.endFXs_);
			quickEndFXs_.Add(other.quickEndFXs_);
			failedFXs_.Add(other.failedFXs_);
			if (other.BreakingFXsTriggerRatio != 0)
			{
				BreakingFXsTriggerRatio = other.BreakingFXsTriggerRatio;
			}
			breakingFXs_.Add(other.breakingFXs_);
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
				DurationMs = input.ReadInt32();
				break;
			case 24u:
				AlmostEndAheadTimeMs = input.ReadInt32();
				break;
			case 32u:
				MinimalDurationMs = input.ReadInt32();
				break;
			case 40u:
				TargetFilter = input.ReadInt32();
				break;
			case 48u:
				TargetTypeFilter = input.ReadInt32();
				break;
			case 56u:
				AffiliationTypeFilter = input.ReadInt32();
				break;
			case 64u:
				TargetCount = input.ReadInt32();
				break;
			case 72u:
				RangeRadius = input.ReadInt32();
				break;
			case 80u:
				RepeatedImmobilizedDef = input.ReadInt32();
				break;
			case 88u:
				GreatSageTalentActiveBuff = input.ReadInt32();
				break;
			case 98u:
				beginEffects_.AddEntriesFrom(input, _repeated_beginEffects_codec);
				break;
			case 106u:
				endEffects_.AddEntriesFrom(input, _repeated_endEffects_codec);
				break;
			case 114u:
				breakEffects_.AddEntriesFrom(input, _repeated_breakEffects_codec);
				break;
			case 122u:
				deadEffects_.AddEntriesFrom(input, _repeated_deadEffects_codec);
				break;
			case 130u:
				beginFXs_.AddEntriesFrom(input, _repeated_beginFXs_codec);
				break;
			case 138u:
				almostEndFXs_.AddEntriesFrom(input, _repeated_almostEndFXs_codec);
				break;
			case 146u:
				endFXs_.AddEntriesFrom(input, _repeated_endFXs_codec);
				break;
			case 154u:
				quickEndFXs_.AddEntriesFrom(input, _repeated_quickEndFXs_codec);
				break;
			case 162u:
				failedFXs_.AddEntriesFrom(input, _repeated_failedFXs_codec);
				break;
			case 168u:
				BreakingFXsTriggerRatio = input.ReadInt32();
				break;
			case 178u:
				breakingFXs_.AddEntriesFrom(input, _repeated_breakingFXs_codec);
				break;
			}
		}
	}
}
