using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStDefeatSlowTimeConfigDesc : IMessage<FUStDefeatSlowTimeConfigDesc>, IMessage, IEquatable<FUStDefeatSlowTimeConfigDesc>, IDeepCloneable<FUStDefeatSlowTimeConfigDesc>
{
	private static readonly MessageParser<FUStDefeatSlowTimeConfigDesc> _parser = new MessageParser<FUStDefeatSlowTimeConfigDesc>(() => new FUStDefeatSlowTimeConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private float totalTime_;

	private string unitDefeatedType_ = "";

	private int uIWordId_;

	private EDefeatUITriggerType triggerType_;

	private static readonly FieldCodec<int> _repeated_seqIDList_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> seqIDList_ = new RepeatedField<int>();

	private string timeDilationCurve_ = "";

	private EDefeatUIShowType defeatUIShowType_;

	private int localizationTag_;

	private string defeatedSound_ = "";

	public static MessageParser<FUStDefeatSlowTimeConfigDesc> Parser => _parser;

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

	public float TotalTime
	{
		get
		{
			return totalTime_;
		}
		set
		{
			totalTime_ = value;
		}
	}

	public string UnitDefeatedType
	{
		get
		{
			return unitDefeatedType_;
		}
		set
		{
			unitDefeatedType_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int UIWordId
	{
		get
		{
			return uIWordId_;
		}
		set
		{
			uIWordId_ = value;
		}
	}

	public EDefeatUITriggerType TriggerType
	{
		get
		{
			return triggerType_;
		}
		set
		{
			triggerType_ = value;
		}
	}

	public RepeatedField<int> SeqIDList => seqIDList_;

	public string TimeDilationCurve
	{
		get
		{
			return timeDilationCurve_;
		}
		set
		{
			timeDilationCurve_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EDefeatUIShowType DefeatUIShowType
	{
		get
		{
			return defeatUIShowType_;
		}
		set
		{
			defeatUIShowType_ = value;
		}
	}

	public int LocalizationTag
	{
		get
		{
			return localizationTag_;
		}
		set
		{
			localizationTag_ = value;
		}
	}

	public string DefeatedSound
	{
		get
		{
			return defeatedSound_;
		}
		set
		{
			defeatedSound_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStDefeatSlowTimeConfigDesc()
	{
	}

	public FUStDefeatSlowTimeConfigDesc(FUStDefeatSlowTimeConfigDesc other)
		: this()
	{
		iD_ = other.iD_;
		totalTime_ = other.totalTime_;
		unitDefeatedType_ = other.unitDefeatedType_;
		uIWordId_ = other.uIWordId_;
		triggerType_ = other.triggerType_;
		seqIDList_ = other.seqIDList_.Clone();
		timeDilationCurve_ = other.timeDilationCurve_;
		defeatUIShowType_ = other.defeatUIShowType_;
		localizationTag_ = other.localizationTag_;
		defeatedSound_ = other.defeatedSound_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStDefeatSlowTimeConfigDesc Clone()
	{
		return new FUStDefeatSlowTimeConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStDefeatSlowTimeConfigDesc);
	}

	public bool Equals(FUStDefeatSlowTimeConfigDesc other)
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
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TotalTime, other.TotalTime))
		{
			return false;
		}
		if (UnitDefeatedType != other.UnitDefeatedType)
		{
			return false;
		}
		if (UIWordId != other.UIWordId)
		{
			return false;
		}
		if (TriggerType != other.TriggerType)
		{
			return false;
		}
		if (!seqIDList_.Equals(other.seqIDList_))
		{
			return false;
		}
		if (TimeDilationCurve != other.TimeDilationCurve)
		{
			return false;
		}
		if (DefeatUIShowType != other.DefeatUIShowType)
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
		{
			return false;
		}
		if (DefeatedSound != other.DefeatedSound)
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
		if (TotalTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TotalTime);
		}
		if (UnitDefeatedType.Length != 0)
		{
			num ^= UnitDefeatedType.GetHashCode();
		}
		if (UIWordId != 0)
		{
			num ^= UIWordId.GetHashCode();
		}
		if (TriggerType != EDefeatUITriggerType.None)
		{
			num ^= TriggerType.GetHashCode();
		}
		num ^= seqIDList_.GetHashCode();
		if (TimeDilationCurve.Length != 0)
		{
			num ^= TimeDilationCurve.GetHashCode();
		}
		if (DefeatUIShowType != EDefeatUIShowType.Defeat)
		{
			num ^= DefeatUIShowType.GetHashCode();
		}
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
		}
		if (DefeatedSound.Length != 0)
		{
			num ^= DefeatedSound.GetHashCode();
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
		if (TotalTime != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(TotalTime);
		}
		if (UnitDefeatedType.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(UnitDefeatedType);
		}
		if (UIWordId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(UIWordId);
		}
		if (TriggerType != EDefeatUITriggerType.None)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)TriggerType);
		}
		seqIDList_.WriteTo(output, _repeated_seqIDList_codec);
		if (TimeDilationCurve.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(TimeDilationCurve);
		}
		if (DefeatUIShowType != EDefeatUIShowType.Defeat)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)DefeatUIShowType);
		}
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(LocalizationTag);
		}
		if (DefeatedSound.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(DefeatedSound);
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
		if (TotalTime != 0f)
		{
			num += 5;
		}
		if (UnitDefeatedType.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UnitDefeatedType);
		}
		if (UIWordId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UIWordId);
		}
		if (TriggerType != EDefeatUITriggerType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)TriggerType);
		}
		num += seqIDList_.CalculateSize(_repeated_seqIDList_codec);
		if (TimeDilationCurve.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TimeDilationCurve);
		}
		if (DefeatUIShowType != EDefeatUIShowType.Defeat)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)DefeatUIShowType);
		}
		if (LocalizationTag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (DefeatedSound.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DefeatedSound);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStDefeatSlowTimeConfigDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.TotalTime != 0f)
			{
				TotalTime = other.TotalTime;
			}
			if (other.UnitDefeatedType.Length != 0)
			{
				UnitDefeatedType = other.UnitDefeatedType;
			}
			if (other.UIWordId != 0)
			{
				UIWordId = other.UIWordId;
			}
			if (other.TriggerType != EDefeatUITriggerType.None)
			{
				TriggerType = other.TriggerType;
			}
			seqIDList_.Add(other.seqIDList_);
			if (other.TimeDilationCurve.Length != 0)
			{
				TimeDilationCurve = other.TimeDilationCurve;
			}
			if (other.DefeatUIShowType != EDefeatUIShowType.Defeat)
			{
				DefeatUIShowType = other.DefeatUIShowType;
			}
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
			}
			if (other.DefeatedSound.Length != 0)
			{
				DefeatedSound = other.DefeatedSound;
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
				TotalTime = input.ReadFloat();
				break;
			case 26u:
				UnitDefeatedType = input.ReadString();
				break;
			case 32u:
				UIWordId = input.ReadInt32();
				break;
			case 40u:
				TriggerType = (EDefeatUITriggerType)input.ReadEnum();
				break;
			case 48u:
			case 50u:
				seqIDList_.AddEntriesFrom(input, _repeated_seqIDList_codec);
				break;
			case 58u:
				TimeDilationCurve = input.ReadString();
				break;
			case 64u:
				DefeatUIShowType = (EDefeatUIShowType)input.ReadEnum();
				break;
			case 72u:
				LocalizationTag = input.ReadInt32();
				break;
			case 82u:
				DefeatedSound = input.ReadString();
				break;
			}
		}
	}
}
