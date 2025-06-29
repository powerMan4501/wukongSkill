using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class FUStBuffDesc : IMessage<FUStBuffDesc>, IMessage, IEquatable<FUStBuffDesc>, IDeepCloneable<FUStBuffDesc>
{
	private static readonly MessageParser<FUStBuffDesc> _parser = new MessageParser<FUStBuffDesc>(() => new FUStBuffDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string buffTips_ = "";

	private FUStBuffEffectActiveCondition buffActiveCondition_;

	private EGSBuffLayerCounterType buffLayerCounterType_;

	private EBuffAndSkillEffectCategory buffCategory_;

	private EGSYesNo canRemoveWhenAttackHit_;

	private EGSYesNo canRemoveWhenAttacked_;

	private int delay_;

	private int duration_;

	private int interval_;

	private int almostEndAheadTime_;

	private int maxLayer_;

	private EBuffRangeTargetBase targetBase_;

	private int targetCount_;

	private int targetFilter_;

	private int targetTypeFilter_;

	private int affiliationTypeFilter_;

	private FUStRange range_;

	private static readonly FieldCodec<FUStBuffEffectAttr> _repeated_buffEffects_codec = FieldCodec.ForMessage(154u, FUStBuffEffectAttr.Parser);

	private readonly RepeatedField<FUStBuffEffectAttr> buffEffects_ = new RepeatedField<FUStBuffEffectAttr>();

	private EGSYesNo isExclusiveBuff_;

	private EGSYesNo canBeInherited_;

	private string guard_ = "";

	public static MessageParser<FUStBuffDesc> Parser => _parser;

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

	public string BuffTips
	{
		get
		{
			return buffTips_;
		}
		set
		{
			buffTips_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStBuffEffectActiveCondition BuffActiveCondition
	{
		get
		{
			return buffActiveCondition_;
		}
		set
		{
			buffActiveCondition_ = value;
		}
	}

	public EGSBuffLayerCounterType BuffLayerCounterType
	{
		get
		{
			return buffLayerCounterType_;
		}
		set
		{
			buffLayerCounterType_ = value;
		}
	}

	public EBuffAndSkillEffectCategory BuffCategory
	{
		get
		{
			return buffCategory_;
		}
		set
		{
			buffCategory_ = value;
		}
	}

	public EGSYesNo CanRemoveWhenAttackHit
	{
		get
		{
			return canRemoveWhenAttackHit_;
		}
		set
		{
			canRemoveWhenAttackHit_ = value;
		}
	}

	public EGSYesNo CanRemoveWhenAttacked
	{
		get
		{
			return canRemoveWhenAttacked_;
		}
		set
		{
			canRemoveWhenAttacked_ = value;
		}
	}

	public int Delay
	{
		get
		{
			return delay_;
		}
		set
		{
			delay_ = value;
		}
	}

	public int Duration
	{
		get
		{
			return duration_;
		}
		set
		{
			duration_ = value;
		}
	}

	public int Interval
	{
		get
		{
			return interval_;
		}
		set
		{
			interval_ = value;
		}
	}

	public int AlmostEndAheadTime
	{
		get
		{
			return almostEndAheadTime_;
		}
		set
		{
			almostEndAheadTime_ = value;
		}
	}

	public int MaxLayer
	{
		get
		{
			return maxLayer_;
		}
		set
		{
			maxLayer_ = value;
		}
	}

	public EBuffRangeTargetBase TargetBase
	{
		get
		{
			return targetBase_;
		}
		set
		{
			targetBase_ = value;
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

	public FUStRange Range
	{
		get
		{
			return range_;
		}
		set
		{
			range_ = value;
		}
	}

	public RepeatedField<FUStBuffEffectAttr> BuffEffects => buffEffects_;

	public EGSYesNo IsExclusiveBuff
	{
		get
		{
			return isExclusiveBuff_;
		}
		set
		{
			isExclusiveBuff_ = value;
		}
	}

	public EGSYesNo CanBeInherited
	{
		get
		{
			return canBeInherited_;
		}
		set
		{
			canBeInherited_ = value;
		}
	}

	public string Guard
	{
		get
		{
			return guard_;
		}
		set
		{
			guard_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStBuffDesc()
	{
	}

	public FUStBuffDesc(FUStBuffDesc other)
		: this()
	{
		iD_ = other.iD_;
		buffTips_ = other.buffTips_;
		buffActiveCondition_ = ((other.buffActiveCondition_ != null) ? other.buffActiveCondition_.Clone() : null);
		buffLayerCounterType_ = other.buffLayerCounterType_;
		buffCategory_ = other.buffCategory_;
		canRemoveWhenAttackHit_ = other.canRemoveWhenAttackHit_;
		canRemoveWhenAttacked_ = other.canRemoveWhenAttacked_;
		delay_ = other.delay_;
		duration_ = other.duration_;
		interval_ = other.interval_;
		almostEndAheadTime_ = other.almostEndAheadTime_;
		maxLayer_ = other.maxLayer_;
		targetBase_ = other.targetBase_;
		targetCount_ = other.targetCount_;
		targetFilter_ = other.targetFilter_;
		targetTypeFilter_ = other.targetTypeFilter_;
		affiliationTypeFilter_ = other.affiliationTypeFilter_;
		range_ = ((other.range_ != null) ? other.range_.Clone() : null);
		buffEffects_ = other.buffEffects_.Clone();
		isExclusiveBuff_ = other.isExclusiveBuff_;
		canBeInherited_ = other.canBeInherited_;
		guard_ = other.guard_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStBuffDesc Clone()
	{
		return new FUStBuffDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStBuffDesc);
	}

	public bool Equals(FUStBuffDesc other)
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
		if (BuffTips != other.BuffTips)
		{
			return false;
		}
		if (!object.Equals(BuffActiveCondition, other.BuffActiveCondition))
		{
			return false;
		}
		if (BuffLayerCounterType != other.BuffLayerCounterType)
		{
			return false;
		}
		if (BuffCategory != other.BuffCategory)
		{
			return false;
		}
		if (CanRemoveWhenAttackHit != other.CanRemoveWhenAttackHit)
		{
			return false;
		}
		if (CanRemoveWhenAttacked != other.CanRemoveWhenAttacked)
		{
			return false;
		}
		if (Delay != other.Delay)
		{
			return false;
		}
		if (Duration != other.Duration)
		{
			return false;
		}
		if (Interval != other.Interval)
		{
			return false;
		}
		if (AlmostEndAheadTime != other.AlmostEndAheadTime)
		{
			return false;
		}
		if (MaxLayer != other.MaxLayer)
		{
			return false;
		}
		if (TargetBase != other.TargetBase)
		{
			return false;
		}
		if (TargetCount != other.TargetCount)
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
		if (!object.Equals(Range, other.Range))
		{
			return false;
		}
		if (!buffEffects_.Equals(other.buffEffects_))
		{
			return false;
		}
		if (IsExclusiveBuff != other.IsExclusiveBuff)
		{
			return false;
		}
		if (CanBeInherited != other.CanBeInherited)
		{
			return false;
		}
		if (Guard != other.Guard)
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
		if (BuffTips.Length != 0)
		{
			num ^= BuffTips.GetHashCode();
		}
		if (buffActiveCondition_ != null)
		{
			num ^= BuffActiveCondition.GetHashCode();
		}
		if (BuffLayerCounterType != EGSBuffLayerCounterType.ReduceLayer)
		{
			num ^= BuffLayerCounterType.GetHashCode();
		}
		if (BuffCategory != EBuffAndSkillEffectCategory.Neutral)
		{
			num ^= BuffCategory.GetHashCode();
		}
		if (CanRemoveWhenAttackHit != EGSYesNo.No)
		{
			num ^= CanRemoveWhenAttackHit.GetHashCode();
		}
		if (CanRemoveWhenAttacked != EGSYesNo.No)
		{
			num ^= CanRemoveWhenAttacked.GetHashCode();
		}
		if (Delay != 0)
		{
			num ^= Delay.GetHashCode();
		}
		if (Duration != 0)
		{
			num ^= Duration.GetHashCode();
		}
		if (Interval != 0)
		{
			num ^= Interval.GetHashCode();
		}
		if (AlmostEndAheadTime != 0)
		{
			num ^= AlmostEndAheadTime.GetHashCode();
		}
		if (MaxLayer != 0)
		{
			num ^= MaxLayer.GetHashCode();
		}
		if (TargetBase != EBuffRangeTargetBase.RootCaster)
		{
			num ^= TargetBase.GetHashCode();
		}
		if (TargetCount != 0)
		{
			num ^= TargetCount.GetHashCode();
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
		if (range_ != null)
		{
			num ^= Range.GetHashCode();
		}
		num ^= buffEffects_.GetHashCode();
		if (IsExclusiveBuff != EGSYesNo.No)
		{
			num ^= IsExclusiveBuff.GetHashCode();
		}
		if (CanBeInherited != EGSYesNo.No)
		{
			num ^= CanBeInherited.GetHashCode();
		}
		if (Guard.Length != 0)
		{
			num ^= Guard.GetHashCode();
		}
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
		if (BuffTips.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(BuffTips);
		}
		if (buffActiveCondition_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(BuffActiveCondition);
		}
		if (BuffLayerCounterType != EGSBuffLayerCounterType.ReduceLayer)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)BuffLayerCounterType);
		}
		if (BuffCategory != EBuffAndSkillEffectCategory.Neutral)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)BuffCategory);
		}
		if (CanRemoveWhenAttackHit != EGSYesNo.No)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)CanRemoveWhenAttackHit);
		}
		if (CanRemoveWhenAttacked != EGSYesNo.No)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)CanRemoveWhenAttacked);
		}
		if (Delay != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(Delay);
		}
		if (Duration != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(Duration);
		}
		if (Interval != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(Interval);
		}
		if (AlmostEndAheadTime != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(AlmostEndAheadTime);
		}
		if (MaxLayer != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(MaxLayer);
		}
		if (TargetBase != EBuffRangeTargetBase.RootCaster)
		{
			output.WriteRawTag(104);
			output.WriteEnum((int)TargetBase);
		}
		if (TargetCount != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(TargetCount);
		}
		if (TargetFilter != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(TargetFilter);
		}
		if (TargetTypeFilter != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(TargetTypeFilter);
		}
		if (AffiliationTypeFilter != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(AffiliationTypeFilter);
		}
		if (range_ != null)
		{
			output.WriteRawTag(146, 1);
			output.WriteMessage(Range);
		}
		buffEffects_.WriteTo(output, _repeated_buffEffects_codec);
		if (IsExclusiveBuff != EGSYesNo.No)
		{
			output.WriteRawTag(160, 1);
			output.WriteEnum((int)IsExclusiveBuff);
		}
		if (CanBeInherited != EGSYesNo.No)
		{
			output.WriteRawTag(168, 1);
			output.WriteEnum((int)CanBeInherited);
		}
		if (Guard.Length != 0)
		{
			output.WriteRawTag(178, 1);
			output.WriteString(Guard);
		}
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
		if (BuffTips.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BuffTips);
		}
		if (buffActiveCondition_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BuffActiveCondition);
		}
		if (BuffLayerCounterType != EGSBuffLayerCounterType.ReduceLayer)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)BuffLayerCounterType);
		}
		if (BuffCategory != EBuffAndSkillEffectCategory.Neutral)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)BuffCategory);
		}
		if (CanRemoveWhenAttackHit != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CanRemoveWhenAttackHit);
		}
		if (CanRemoveWhenAttacked != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CanRemoveWhenAttacked);
		}
		if (Delay != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Delay);
		}
		if (Duration != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Duration);
		}
		if (Interval != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Interval);
		}
		if (AlmostEndAheadTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AlmostEndAheadTime);
		}
		if (MaxLayer != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxLayer);
		}
		if (TargetBase != EBuffRangeTargetBase.RootCaster)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)TargetBase);
		}
		if (TargetCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetCount);
		}
		if (TargetFilter != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetFilter);
		}
		if (TargetTypeFilter != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TargetTypeFilter);
		}
		if (AffiliationTypeFilter != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(AffiliationTypeFilter);
		}
		if (range_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(Range);
		}
		num += buffEffects_.CalculateSize(_repeated_buffEffects_codec);
		if (IsExclusiveBuff != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)IsExclusiveBuff);
		}
		if (CanBeInherited != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)CanBeInherited);
		}
		if (Guard.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(Guard);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStBuffDesc other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ID != 0)
		{
			ID = other.ID;
		}
		if (other.BuffTips.Length != 0)
		{
			BuffTips = other.BuffTips;
		}
		if (other.buffActiveCondition_ != null)
		{
			if (buffActiveCondition_ == null)
			{
				BuffActiveCondition = new FUStBuffEffectActiveCondition();
			}
			BuffActiveCondition.MergeFrom(other.BuffActiveCondition);
		}
		if (other.BuffLayerCounterType != EGSBuffLayerCounterType.ReduceLayer)
		{
			BuffLayerCounterType = other.BuffLayerCounterType;
		}
		if (other.BuffCategory != EBuffAndSkillEffectCategory.Neutral)
		{
			BuffCategory = other.BuffCategory;
		}
		if (other.CanRemoveWhenAttackHit != EGSYesNo.No)
		{
			CanRemoveWhenAttackHit = other.CanRemoveWhenAttackHit;
		}
		if (other.CanRemoveWhenAttacked != EGSYesNo.No)
		{
			CanRemoveWhenAttacked = other.CanRemoveWhenAttacked;
		}
		if (other.Delay != 0)
		{
			Delay = other.Delay;
		}
		if (other.Duration != 0)
		{
			Duration = other.Duration;
		}
		if (other.Interval != 0)
		{
			Interval = other.Interval;
		}
		if (other.AlmostEndAheadTime != 0)
		{
			AlmostEndAheadTime = other.AlmostEndAheadTime;
		}
		if (other.MaxLayer != 0)
		{
			MaxLayer = other.MaxLayer;
		}
		if (other.TargetBase != EBuffRangeTargetBase.RootCaster)
		{
			TargetBase = other.TargetBase;
		}
		if (other.TargetCount != 0)
		{
			TargetCount = other.TargetCount;
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
		if (other.range_ != null)
		{
			if (range_ == null)
			{
				Range = new FUStRange();
			}
			Range.MergeFrom(other.Range);
		}
		buffEffects_.Add(other.buffEffects_);
		if (other.IsExclusiveBuff != EGSYesNo.No)
		{
			IsExclusiveBuff = other.IsExclusiveBuff;
		}
		if (other.CanBeInherited != EGSYesNo.No)
		{
			CanBeInherited = other.CanBeInherited;
		}
		if (other.Guard.Length != 0)
		{
			Guard = other.Guard;
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
				ID = input.ReadInt32();
				break;
			case 18u:
				BuffTips = input.ReadString();
				break;
			case 26u:
				if (buffActiveCondition_ == null)
				{
					BuffActiveCondition = new FUStBuffEffectActiveCondition();
				}
				input.ReadMessage(BuffActiveCondition);
				break;
			case 32u:
				BuffLayerCounterType = (EGSBuffLayerCounterType)input.ReadEnum();
				break;
			case 40u:
				BuffCategory = (EBuffAndSkillEffectCategory)input.ReadEnum();
				break;
			case 48u:
				CanRemoveWhenAttackHit = (EGSYesNo)input.ReadEnum();
				break;
			case 56u:
				CanRemoveWhenAttacked = (EGSYesNo)input.ReadEnum();
				break;
			case 64u:
				Delay = input.ReadInt32();
				break;
			case 72u:
				Duration = input.ReadInt32();
				break;
			case 80u:
				Interval = input.ReadInt32();
				break;
			case 88u:
				AlmostEndAheadTime = input.ReadInt32();
				break;
			case 96u:
				MaxLayer = input.ReadInt32();
				break;
			case 104u:
				TargetBase = (EBuffRangeTargetBase)input.ReadEnum();
				break;
			case 112u:
				TargetCount = input.ReadInt32();
				break;
			case 120u:
				TargetFilter = input.ReadInt32();
				break;
			case 128u:
				TargetTypeFilter = input.ReadInt32();
				break;
			case 136u:
				AffiliationTypeFilter = input.ReadInt32();
				break;
			case 146u:
				if (range_ == null)
				{
					Range = new FUStRange();
				}
				input.ReadMessage(Range);
				break;
			case 154u:
				buffEffects_.AddEntriesFrom(input, _repeated_buffEffects_codec);
				break;
			case 160u:
				IsExclusiveBuff = (EGSYesNo)input.ReadEnum();
				break;
			case 168u:
				CanBeInherited = (EGSYesNo)input.ReadEnum();
				break;
			case 178u:
				Guard = input.ReadString();
				break;
			}
		}
	}
}
