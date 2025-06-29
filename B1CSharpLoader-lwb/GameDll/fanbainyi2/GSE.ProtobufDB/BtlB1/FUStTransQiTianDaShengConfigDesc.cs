using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStTransQiTianDaShengConfigDesc : IMessage<FUStTransQiTianDaShengConfigDesc>, IMessage, IEquatable<FUStTransQiTianDaShengConfigDesc>, IDeepCloneable<FUStTransQiTianDaShengConfigDesc>
{
	private static readonly MessageParser<FUStTransQiTianDaShengConfigDesc> _parser = new MessageParser<FUStTransQiTianDaShengConfigDesc>(() => new FUStTransQiTianDaShengConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private static readonly FieldCodec<int> _repeated_preDaShengBeginTriggerEffectIDList_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> preDaShengBeginTriggerEffectIDList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_preDaShengBeginTriggerBuffIDList_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> preDaShengBeginTriggerBuffIDList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_preDaShengSustainTriggerBuffIDList_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> preDaShengSustainTriggerBuffIDList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_daShengBeginTriggerEffectIDList_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> daShengBeginTriggerEffectIDList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_daShengBeginTriggerBuffIDList_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> daShengBeginTriggerBuffIDList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_daShengSustainTriggerBuffIDList_codec = FieldCodec.ForInt32(58u);

	private readonly RepeatedField<int> daShengSustainTriggerBuffIDList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_relatedEquipIDList_codec = FieldCodec.ForInt32(66u);

	private readonly RepeatedField<int> relatedEquipIDList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_relatedTalentIDList_codec = FieldCodec.ForInt32(74u);

	private readonly RepeatedField<int> relatedTalentIDList_ = new RepeatedField<int>();

	private int duration_;

	public static MessageParser<FUStTransQiTianDaShengConfigDesc> Parser => _parser;

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

	public RepeatedField<int> PreDaShengBeginTriggerEffectIDList => preDaShengBeginTriggerEffectIDList_;

	public RepeatedField<int> PreDaShengBeginTriggerBuffIDList => preDaShengBeginTriggerBuffIDList_;

	public RepeatedField<int> PreDaShengSustainTriggerBuffIDList => preDaShengSustainTriggerBuffIDList_;

	public RepeatedField<int> DaShengBeginTriggerEffectIDList => daShengBeginTriggerEffectIDList_;

	public RepeatedField<int> DaShengBeginTriggerBuffIDList => daShengBeginTriggerBuffIDList_;

	public RepeatedField<int> DaShengSustainTriggerBuffIDList => daShengSustainTriggerBuffIDList_;

	public RepeatedField<int> RelatedEquipIDList => relatedEquipIDList_;

	public RepeatedField<int> RelatedTalentIDList => relatedTalentIDList_;

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

	public FUStTransQiTianDaShengConfigDesc()
	{
	}

	public FUStTransQiTianDaShengConfigDesc(FUStTransQiTianDaShengConfigDesc other)
		: this()
	{
		iD_ = other.iD_;
		preDaShengBeginTriggerEffectIDList_ = other.preDaShengBeginTriggerEffectIDList_.Clone();
		preDaShengBeginTriggerBuffIDList_ = other.preDaShengBeginTriggerBuffIDList_.Clone();
		preDaShengSustainTriggerBuffIDList_ = other.preDaShengSustainTriggerBuffIDList_.Clone();
		daShengBeginTriggerEffectIDList_ = other.daShengBeginTriggerEffectIDList_.Clone();
		daShengBeginTriggerBuffIDList_ = other.daShengBeginTriggerBuffIDList_.Clone();
		daShengSustainTriggerBuffIDList_ = other.daShengSustainTriggerBuffIDList_.Clone();
		relatedEquipIDList_ = other.relatedEquipIDList_.Clone();
		relatedTalentIDList_ = other.relatedTalentIDList_.Clone();
		duration_ = other.duration_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStTransQiTianDaShengConfigDesc Clone()
	{
		return new FUStTransQiTianDaShengConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStTransQiTianDaShengConfigDesc);
	}

	public bool Equals(FUStTransQiTianDaShengConfigDesc other)
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
		if (!preDaShengBeginTriggerEffectIDList_.Equals(other.preDaShengBeginTriggerEffectIDList_))
		{
			return false;
		}
		if (!preDaShengBeginTriggerBuffIDList_.Equals(other.preDaShengBeginTriggerBuffIDList_))
		{
			return false;
		}
		if (!preDaShengSustainTriggerBuffIDList_.Equals(other.preDaShengSustainTriggerBuffIDList_))
		{
			return false;
		}
		if (!daShengBeginTriggerEffectIDList_.Equals(other.daShengBeginTriggerEffectIDList_))
		{
			return false;
		}
		if (!daShengBeginTriggerBuffIDList_.Equals(other.daShengBeginTriggerBuffIDList_))
		{
			return false;
		}
		if (!daShengSustainTriggerBuffIDList_.Equals(other.daShengSustainTriggerBuffIDList_))
		{
			return false;
		}
		if (!relatedEquipIDList_.Equals(other.relatedEquipIDList_))
		{
			return false;
		}
		if (!relatedTalentIDList_.Equals(other.relatedTalentIDList_))
		{
			return false;
		}
		if (Duration != other.Duration)
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
		num ^= preDaShengBeginTriggerEffectIDList_.GetHashCode();
		num ^= preDaShengBeginTriggerBuffIDList_.GetHashCode();
		num ^= preDaShengSustainTriggerBuffIDList_.GetHashCode();
		num ^= daShengBeginTriggerEffectIDList_.GetHashCode();
		num ^= daShengBeginTriggerBuffIDList_.GetHashCode();
		num ^= daShengSustainTriggerBuffIDList_.GetHashCode();
		num ^= relatedEquipIDList_.GetHashCode();
		num ^= relatedTalentIDList_.GetHashCode();
		if (Duration != 0)
		{
			num ^= Duration.GetHashCode();
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
		preDaShengBeginTriggerEffectIDList_.WriteTo(output, _repeated_preDaShengBeginTriggerEffectIDList_codec);
		preDaShengBeginTriggerBuffIDList_.WriteTo(output, _repeated_preDaShengBeginTriggerBuffIDList_codec);
		preDaShengSustainTriggerBuffIDList_.WriteTo(output, _repeated_preDaShengSustainTriggerBuffIDList_codec);
		daShengBeginTriggerEffectIDList_.WriteTo(output, _repeated_daShengBeginTriggerEffectIDList_codec);
		daShengBeginTriggerBuffIDList_.WriteTo(output, _repeated_daShengBeginTriggerBuffIDList_codec);
		daShengSustainTriggerBuffIDList_.WriteTo(output, _repeated_daShengSustainTriggerBuffIDList_codec);
		relatedEquipIDList_.WriteTo(output, _repeated_relatedEquipIDList_codec);
		relatedTalentIDList_.WriteTo(output, _repeated_relatedTalentIDList_codec);
		if (Duration != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(Duration);
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
		num += preDaShengBeginTriggerEffectIDList_.CalculateSize(_repeated_preDaShengBeginTriggerEffectIDList_codec);
		num += preDaShengBeginTriggerBuffIDList_.CalculateSize(_repeated_preDaShengBeginTriggerBuffIDList_codec);
		num += preDaShengSustainTriggerBuffIDList_.CalculateSize(_repeated_preDaShengSustainTriggerBuffIDList_codec);
		num += daShengBeginTriggerEffectIDList_.CalculateSize(_repeated_daShengBeginTriggerEffectIDList_codec);
		num += daShengBeginTriggerBuffIDList_.CalculateSize(_repeated_daShengBeginTriggerBuffIDList_codec);
		num += daShengSustainTriggerBuffIDList_.CalculateSize(_repeated_daShengSustainTriggerBuffIDList_codec);
		num += relatedEquipIDList_.CalculateSize(_repeated_relatedEquipIDList_codec);
		num += relatedTalentIDList_.CalculateSize(_repeated_relatedTalentIDList_codec);
		if (Duration != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Duration);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStTransQiTianDaShengConfigDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			preDaShengBeginTriggerEffectIDList_.Add(other.preDaShengBeginTriggerEffectIDList_);
			preDaShengBeginTriggerBuffIDList_.Add(other.preDaShengBeginTriggerBuffIDList_);
			preDaShengSustainTriggerBuffIDList_.Add(other.preDaShengSustainTriggerBuffIDList_);
			daShengBeginTriggerEffectIDList_.Add(other.daShengBeginTriggerEffectIDList_);
			daShengBeginTriggerBuffIDList_.Add(other.daShengBeginTriggerBuffIDList_);
			daShengSustainTriggerBuffIDList_.Add(other.daShengSustainTriggerBuffIDList_);
			relatedEquipIDList_.Add(other.relatedEquipIDList_);
			relatedTalentIDList_.Add(other.relatedTalentIDList_);
			if (other.Duration != 0)
			{
				Duration = other.Duration;
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
				ID = input.ReadInt32();
				break;
			case 16u:
			case 18u:
				preDaShengBeginTriggerEffectIDList_.AddEntriesFrom(input, _repeated_preDaShengBeginTriggerEffectIDList_codec);
				break;
			case 24u:
			case 26u:
				preDaShengBeginTriggerBuffIDList_.AddEntriesFrom(input, _repeated_preDaShengBeginTriggerBuffIDList_codec);
				break;
			case 32u:
			case 34u:
				preDaShengSustainTriggerBuffIDList_.AddEntriesFrom(input, _repeated_preDaShengSustainTriggerBuffIDList_codec);
				break;
			case 40u:
			case 42u:
				daShengBeginTriggerEffectIDList_.AddEntriesFrom(input, _repeated_daShengBeginTriggerEffectIDList_codec);
				break;
			case 48u:
			case 50u:
				daShengBeginTriggerBuffIDList_.AddEntriesFrom(input, _repeated_daShengBeginTriggerBuffIDList_codec);
				break;
			case 56u:
			case 58u:
				daShengSustainTriggerBuffIDList_.AddEntriesFrom(input, _repeated_daShengSustainTriggerBuffIDList_codec);
				break;
			case 64u:
			case 66u:
				relatedEquipIDList_.AddEntriesFrom(input, _repeated_relatedEquipIDList_codec);
				break;
			case 72u:
			case 74u:
				relatedTalentIDList_.AddEntriesFrom(input, _repeated_relatedTalentIDList_codec);
				break;
			case 80u:
				Duration = input.ReadInt32();
				break;
			}
		}
	}
}
