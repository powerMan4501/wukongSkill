using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlX2;

public sealed class FUStB2DBuffDesc : IMessage<FUStB2DBuffDesc>, IMessage, IEquatable<FUStB2DBuffDesc>, IDeepCloneable<FUStB2DBuffDesc>
{
	private static readonly MessageParser<FUStB2DBuffDesc> _parser = new MessageParser<FUStB2DBuffDesc>(() => new FUStB2DBuffDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int delay_;

	private long duration_;

	private int interval_;

	private int maxLayer_;

	private EB2DBuffRangeTargetBase targetBase_;

	private int targetCount_;

	private int targetFilter_;

	private FUStB2DRange range_;

	private static readonly FieldCodec<FUStB2DBuffEffectAttr> _repeated_buffEffects_codec = FieldCodec.ForMessage(82u, FUStB2DBuffEffectAttr.Parser);

	private readonly RepeatedField<FUStB2DBuffEffectAttr> buffEffects_ = new RepeatedField<FUStB2DBuffEffectAttr>();

	private static readonly FieldCodec<int> _repeated_buffEffectFollowLevel_codec = FieldCodec.ForInt32(90u);

	private readonly RepeatedField<int> buffEffectFollowLevel_ = new RepeatedField<int>();

	private EB2DBuffHarmType harmType_;

	private int isOpenHatred_;

	public static MessageParser<FUStB2DBuffDesc> Parser => _parser;

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

	public long Duration
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

	public EB2DBuffRangeTargetBase TargetBase
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

	public FUStB2DRange Range
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

	public RepeatedField<FUStB2DBuffEffectAttr> BuffEffects => buffEffects_;

	public RepeatedField<int> BuffEffectFollowLevel => buffEffectFollowLevel_;

	public EB2DBuffHarmType HarmType
	{
		get
		{
			return harmType_;
		}
		set
		{
			harmType_ = value;
		}
	}

	public int IsOpenHatred
	{
		get
		{
			return isOpenHatred_;
		}
		set
		{
			isOpenHatred_ = value;
		}
	}

	public FUStB2DBuffDesc()
	{
	}

	public FUStB2DBuffDesc(FUStB2DBuffDesc other)
		: this()
	{
		id_ = other.id_;
		delay_ = other.delay_;
		duration_ = other.duration_;
		interval_ = other.interval_;
		maxLayer_ = other.maxLayer_;
		targetBase_ = other.targetBase_;
		targetCount_ = other.targetCount_;
		targetFilter_ = other.targetFilter_;
		range_ = ((other.range_ != null) ? other.range_.Clone() : null);
		buffEffects_ = other.buffEffects_.Clone();
		buffEffectFollowLevel_ = other.buffEffectFollowLevel_.Clone();
		harmType_ = other.harmType_;
		isOpenHatred_ = other.isOpenHatred_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStB2DBuffDesc Clone()
	{
		return new FUStB2DBuffDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStB2DBuffDesc);
	}

	public bool Equals(FUStB2DBuffDesc other)
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
		if (!object.Equals(Range, other.Range))
		{
			return false;
		}
		if (!buffEffects_.Equals(other.buffEffects_))
		{
			return false;
		}
		if (!buffEffectFollowLevel_.Equals(other.buffEffectFollowLevel_))
		{
			return false;
		}
		if (HarmType != other.HarmType)
		{
			return false;
		}
		if (IsOpenHatred != other.IsOpenHatred)
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
		if (Delay != 0)
		{
			num ^= Delay.GetHashCode();
		}
		if (Duration != 0L)
		{
			num ^= Duration.GetHashCode();
		}
		if (Interval != 0)
		{
			num ^= Interval.GetHashCode();
		}
		if (MaxLayer != 0)
		{
			num ^= MaxLayer.GetHashCode();
		}
		if (TargetBase != EB2DBuffRangeTargetBase.RootCaster)
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
		if (range_ != null)
		{
			num ^= Range.GetHashCode();
		}
		num ^= buffEffects_.GetHashCode();
		num ^= buffEffectFollowLevel_.GetHashCode();
		if (HarmType != EB2DBuffHarmType.EhtNeutral)
		{
			num ^= HarmType.GetHashCode();
		}
		if (IsOpenHatred != 0)
		{
			num ^= IsOpenHatred.GetHashCode();
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
		if (Delay != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Delay);
		}
		if (Duration != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(Duration);
		}
		if (Interval != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Interval);
		}
		if (MaxLayer != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(MaxLayer);
		}
		if (TargetBase != EB2DBuffRangeTargetBase.RootCaster)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)TargetBase);
		}
		if (TargetCount != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(TargetCount);
		}
		if (TargetFilter != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(TargetFilter);
		}
		if (range_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(Range);
		}
		buffEffects_.WriteTo(output, _repeated_buffEffects_codec);
		buffEffectFollowLevel_.WriteTo(output, _repeated_buffEffectFollowLevel_codec);
		if (HarmType != EB2DBuffHarmType.EhtNeutral)
		{
			output.WriteRawTag(96);
			output.WriteEnum((int)HarmType);
		}
		if (IsOpenHatred != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(IsOpenHatred);
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
		if (Delay != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Delay);
		}
		if (Duration != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Duration);
		}
		if (Interval != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Interval);
		}
		if (MaxLayer != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxLayer);
		}
		if (TargetBase != EB2DBuffRangeTargetBase.RootCaster)
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
		if (range_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Range);
		}
		num += buffEffects_.CalculateSize(_repeated_buffEffects_codec);
		num += buffEffectFollowLevel_.CalculateSize(_repeated_buffEffectFollowLevel_codec);
		if (HarmType != EB2DBuffHarmType.EhtNeutral)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)HarmType);
		}
		if (IsOpenHatred != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsOpenHatred);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStB2DBuffDesc other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Id != 0)
		{
			Id = other.Id;
		}
		if (other.Delay != 0)
		{
			Delay = other.Delay;
		}
		if (other.Duration != 0L)
		{
			Duration = other.Duration;
		}
		if (other.Interval != 0)
		{
			Interval = other.Interval;
		}
		if (other.MaxLayer != 0)
		{
			MaxLayer = other.MaxLayer;
		}
		if (other.TargetBase != EB2DBuffRangeTargetBase.RootCaster)
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
		if (other.range_ != null)
		{
			if (range_ == null)
			{
				Range = new FUStB2DRange();
			}
			Range.MergeFrom(other.Range);
		}
		buffEffects_.Add(other.buffEffects_);
		buffEffectFollowLevel_.Add(other.buffEffectFollowLevel_);
		if (other.HarmType != EB2DBuffHarmType.EhtNeutral)
		{
			HarmType = other.HarmType;
		}
		if (other.IsOpenHatred != 0)
		{
			IsOpenHatred = other.IsOpenHatred;
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
				Id = input.ReadInt32();
				break;
			case 16u:
				Delay = input.ReadInt32();
				break;
			case 24u:
				Duration = input.ReadInt64();
				break;
			case 32u:
				Interval = input.ReadInt32();
				break;
			case 40u:
				MaxLayer = input.ReadInt32();
				break;
			case 48u:
				TargetBase = (EB2DBuffRangeTargetBase)input.ReadEnum();
				break;
			case 56u:
				TargetCount = input.ReadInt32();
				break;
			case 64u:
				TargetFilter = input.ReadInt32();
				break;
			case 74u:
				if (range_ == null)
				{
					Range = new FUStB2DRange();
				}
				input.ReadMessage(Range);
				break;
			case 82u:
				buffEffects_.AddEntriesFrom(input, _repeated_buffEffects_codec);
				break;
			case 88u:
			case 90u:
				buffEffectFollowLevel_.AddEntriesFrom(input, _repeated_buffEffectFollowLevel_codec);
				break;
			case 96u:
				HarmType = (EB2DBuffHarmType)input.ReadEnum();
				break;
			case 104u:
				IsOpenHatred = input.ReadInt32();
				break;
			}
		}
	}
}
