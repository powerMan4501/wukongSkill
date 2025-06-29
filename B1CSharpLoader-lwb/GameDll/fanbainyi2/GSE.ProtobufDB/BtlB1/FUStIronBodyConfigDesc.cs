using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStIronBodyConfigDesc : IMessage<FUStIronBodyConfigDesc>, IMessage, IEquatable<FUStIronBodyConfigDesc>, IDeepCloneable<FUStIronBodyConfigDesc>
{
	private static readonly MessageParser<FUStIronBodyConfigDesc> _parser = new MessageParser<FUStIronBodyConfigDesc>(() => new FUStIronBodyConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private float beginPreciseWindowTime_;

	private float endPreciseWindowTime_;

	private static readonly FieldCodec<FUStIronBodyBuffTriggerInfo> _repeated_startTriggerInfoList_codec = FieldCodec.ForMessage(34u, FUStIronBodyBuffTriggerInfo.Parser);

	private readonly RepeatedField<FUStIronBodyBuffTriggerInfo> startTriggerInfoList_ = new RepeatedField<FUStIronBodyBuffTriggerInfo>();

	private static readonly FieldCodec<FUStIronBodyBuffTriggerInfo> _repeated_defeatTriggerInfoList_codec = FieldCodec.ForMessage(42u, FUStIronBodyBuffTriggerInfo.Parser);

	private readonly RepeatedField<FUStIronBodyBuffTriggerInfo> defeatTriggerInfoList_ = new RepeatedField<FUStIronBodyBuffTriggerInfo>();

	private static readonly FieldCodec<FUStIronBodyBuffTriggerInfo> _repeated_preciseTriggerInfoList_codec = FieldCodec.ForMessage(50u, FUStIronBodyBuffTriggerInfo.Parser);

	private readonly RepeatedField<FUStIronBodyBuffTriggerInfo> preciseTriggerInfoList_ = new RepeatedField<FUStIronBodyBuffTriggerInfo>();

	private static readonly FieldCodec<FUStIronBodyBuffTriggerInfo> _repeated_notPreciseTriggerInfoList_codec = FieldCodec.ForMessage(58u, FUStIronBodyBuffTriggerInfo.Parser);

	private readonly RepeatedField<FUStIronBodyBuffTriggerInfo> notPreciseTriggerInfoList_ = new RepeatedField<FUStIronBodyBuffTriggerInfo>();

	private int playerDefense_;

	private int lowHitWeight_;

	private int mediueHitWeight_;

	private int heightHitWeight_;

	private int hugeHitWeight_;

	private int mustDefeatHitWeight_;

	public static MessageParser<FUStIronBodyConfigDesc> Parser => _parser;

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

	public float BeginPreciseWindowTime
	{
		get
		{
			return beginPreciseWindowTime_;
		}
		set
		{
			beginPreciseWindowTime_ = value;
		}
	}

	public float EndPreciseWindowTime
	{
		get
		{
			return endPreciseWindowTime_;
		}
		set
		{
			endPreciseWindowTime_ = value;
		}
	}

	public RepeatedField<FUStIronBodyBuffTriggerInfo> StartTriggerInfoList => startTriggerInfoList_;

	public RepeatedField<FUStIronBodyBuffTriggerInfo> DefeatTriggerInfoList => defeatTriggerInfoList_;

	public RepeatedField<FUStIronBodyBuffTriggerInfo> PreciseTriggerInfoList => preciseTriggerInfoList_;

	public RepeatedField<FUStIronBodyBuffTriggerInfo> NotPreciseTriggerInfoList => notPreciseTriggerInfoList_;

	public int PlayerDefense
	{
		get
		{
			return playerDefense_;
		}
		set
		{
			playerDefense_ = value;
		}
	}

	public int LowHitWeight
	{
		get
		{
			return lowHitWeight_;
		}
		set
		{
			lowHitWeight_ = value;
		}
	}

	public int MediueHitWeight
	{
		get
		{
			return mediueHitWeight_;
		}
		set
		{
			mediueHitWeight_ = value;
		}
	}

	public int HeightHitWeight
	{
		get
		{
			return heightHitWeight_;
		}
		set
		{
			heightHitWeight_ = value;
		}
	}

	public int HugeHitWeight
	{
		get
		{
			return hugeHitWeight_;
		}
		set
		{
			hugeHitWeight_ = value;
		}
	}

	public int MustDefeatHitWeight
	{
		get
		{
			return mustDefeatHitWeight_;
		}
		set
		{
			mustDefeatHitWeight_ = value;
		}
	}

	public FUStIronBodyConfigDesc()
	{
	}

	public FUStIronBodyConfigDesc(FUStIronBodyConfigDesc other)
		: this()
	{
		iD_ = other.iD_;
		beginPreciseWindowTime_ = other.beginPreciseWindowTime_;
		endPreciseWindowTime_ = other.endPreciseWindowTime_;
		startTriggerInfoList_ = other.startTriggerInfoList_.Clone();
		defeatTriggerInfoList_ = other.defeatTriggerInfoList_.Clone();
		preciseTriggerInfoList_ = other.preciseTriggerInfoList_.Clone();
		notPreciseTriggerInfoList_ = other.notPreciseTriggerInfoList_.Clone();
		playerDefense_ = other.playerDefense_;
		lowHitWeight_ = other.lowHitWeight_;
		mediueHitWeight_ = other.mediueHitWeight_;
		heightHitWeight_ = other.heightHitWeight_;
		hugeHitWeight_ = other.hugeHitWeight_;
		mustDefeatHitWeight_ = other.mustDefeatHitWeight_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStIronBodyConfigDesc Clone()
	{
		return new FUStIronBodyConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStIronBodyConfigDesc);
	}

	public bool Equals(FUStIronBodyConfigDesc other)
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
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BeginPreciseWindowTime, other.BeginPreciseWindowTime))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(EndPreciseWindowTime, other.EndPreciseWindowTime))
		{
			return false;
		}
		if (!startTriggerInfoList_.Equals(other.startTriggerInfoList_))
		{
			return false;
		}
		if (!defeatTriggerInfoList_.Equals(other.defeatTriggerInfoList_))
		{
			return false;
		}
		if (!preciseTriggerInfoList_.Equals(other.preciseTriggerInfoList_))
		{
			return false;
		}
		if (!notPreciseTriggerInfoList_.Equals(other.notPreciseTriggerInfoList_))
		{
			return false;
		}
		if (PlayerDefense != other.PlayerDefense)
		{
			return false;
		}
		if (LowHitWeight != other.LowHitWeight)
		{
			return false;
		}
		if (MediueHitWeight != other.MediueHitWeight)
		{
			return false;
		}
		if (HeightHitWeight != other.HeightHitWeight)
		{
			return false;
		}
		if (HugeHitWeight != other.HugeHitWeight)
		{
			return false;
		}
		if (MustDefeatHitWeight != other.MustDefeatHitWeight)
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
		if (BeginPreciseWindowTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BeginPreciseWindowTime);
		}
		if (EndPreciseWindowTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(EndPreciseWindowTime);
		}
		num ^= startTriggerInfoList_.GetHashCode();
		num ^= defeatTriggerInfoList_.GetHashCode();
		num ^= preciseTriggerInfoList_.GetHashCode();
		num ^= notPreciseTriggerInfoList_.GetHashCode();
		if (PlayerDefense != 0)
		{
			num ^= PlayerDefense.GetHashCode();
		}
		if (LowHitWeight != 0)
		{
			num ^= LowHitWeight.GetHashCode();
		}
		if (MediueHitWeight != 0)
		{
			num ^= MediueHitWeight.GetHashCode();
		}
		if (HeightHitWeight != 0)
		{
			num ^= HeightHitWeight.GetHashCode();
		}
		if (HugeHitWeight != 0)
		{
			num ^= HugeHitWeight.GetHashCode();
		}
		if (MustDefeatHitWeight != 0)
		{
			num ^= MustDefeatHitWeight.GetHashCode();
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
		if (BeginPreciseWindowTime != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(BeginPreciseWindowTime);
		}
		if (EndPreciseWindowTime != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(EndPreciseWindowTime);
		}
		startTriggerInfoList_.WriteTo(output, _repeated_startTriggerInfoList_codec);
		defeatTriggerInfoList_.WriteTo(output, _repeated_defeatTriggerInfoList_codec);
		preciseTriggerInfoList_.WriteTo(output, _repeated_preciseTriggerInfoList_codec);
		notPreciseTriggerInfoList_.WriteTo(output, _repeated_notPreciseTriggerInfoList_codec);
		if (PlayerDefense != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(PlayerDefense);
		}
		if (LowHitWeight != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(LowHitWeight);
		}
		if (MediueHitWeight != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(MediueHitWeight);
		}
		if (HeightHitWeight != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(HeightHitWeight);
		}
		if (HugeHitWeight != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(HugeHitWeight);
		}
		if (MustDefeatHitWeight != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(MustDefeatHitWeight);
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
		if (BeginPreciseWindowTime != 0f)
		{
			num += 5;
		}
		if (EndPreciseWindowTime != 0f)
		{
			num += 5;
		}
		num += startTriggerInfoList_.CalculateSize(_repeated_startTriggerInfoList_codec);
		num += defeatTriggerInfoList_.CalculateSize(_repeated_defeatTriggerInfoList_codec);
		num += preciseTriggerInfoList_.CalculateSize(_repeated_preciseTriggerInfoList_codec);
		num += notPreciseTriggerInfoList_.CalculateSize(_repeated_notPreciseTriggerInfoList_codec);
		if (PlayerDefense != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PlayerDefense);
		}
		if (LowHitWeight != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LowHitWeight);
		}
		if (MediueHitWeight != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MediueHitWeight);
		}
		if (HeightHitWeight != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HeightHitWeight);
		}
		if (HugeHitWeight != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HugeHitWeight);
		}
		if (MustDefeatHitWeight != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MustDefeatHitWeight);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStIronBodyConfigDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.BeginPreciseWindowTime != 0f)
			{
				BeginPreciseWindowTime = other.BeginPreciseWindowTime;
			}
			if (other.EndPreciseWindowTime != 0f)
			{
				EndPreciseWindowTime = other.EndPreciseWindowTime;
			}
			startTriggerInfoList_.Add(other.startTriggerInfoList_);
			defeatTriggerInfoList_.Add(other.defeatTriggerInfoList_);
			preciseTriggerInfoList_.Add(other.preciseTriggerInfoList_);
			notPreciseTriggerInfoList_.Add(other.notPreciseTriggerInfoList_);
			if (other.PlayerDefense != 0)
			{
				PlayerDefense = other.PlayerDefense;
			}
			if (other.LowHitWeight != 0)
			{
				LowHitWeight = other.LowHitWeight;
			}
			if (other.MediueHitWeight != 0)
			{
				MediueHitWeight = other.MediueHitWeight;
			}
			if (other.HeightHitWeight != 0)
			{
				HeightHitWeight = other.HeightHitWeight;
			}
			if (other.HugeHitWeight != 0)
			{
				HugeHitWeight = other.HugeHitWeight;
			}
			if (other.MustDefeatHitWeight != 0)
			{
				MustDefeatHitWeight = other.MustDefeatHitWeight;
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
			case 21u:
				BeginPreciseWindowTime = input.ReadFloat();
				break;
			case 29u:
				EndPreciseWindowTime = input.ReadFloat();
				break;
			case 34u:
				startTriggerInfoList_.AddEntriesFrom(input, _repeated_startTriggerInfoList_codec);
				break;
			case 42u:
				defeatTriggerInfoList_.AddEntriesFrom(input, _repeated_defeatTriggerInfoList_codec);
				break;
			case 50u:
				preciseTriggerInfoList_.AddEntriesFrom(input, _repeated_preciseTriggerInfoList_codec);
				break;
			case 58u:
				notPreciseTriggerInfoList_.AddEntriesFrom(input, _repeated_notPreciseTriggerInfoList_codec);
				break;
			case 64u:
				PlayerDefense = input.ReadInt32();
				break;
			case 72u:
				LowHitWeight = input.ReadInt32();
				break;
			case 80u:
				MediueHitWeight = input.ReadInt32();
				break;
			case 88u:
				HeightHitWeight = input.ReadInt32();
				break;
			case 96u:
				HugeHitWeight = input.ReadInt32();
				break;
			case 104u:
				MustDefeatHitWeight = input.ReadInt32();
				break;
			}
		}
	}
}
