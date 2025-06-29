using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStBossRushConfigDesc : IMessage<FUStBossRushConfigDesc>, IMessage, IEquatable<FUStBossRushConfigDesc>, IDeepCloneable<FUStBossRushConfigDesc>
{
	private static readonly MessageParser<FUStBossRushConfigDesc> _parser = new MessageParser<FUStBossRushConfigDesc>(() => new FUStBossRushConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int levelID_;

	private EGSYesNo isUseBossRoom_;

	private string graphPath_ = "";

	private string levelName_ = "";

	private static readonly FieldCodec<string> _repeated_tamerPath_codec = FieldCodec.ForString(50u);

	private readonly RepeatedField<string> tamerPath_ = new RepeatedField<string>();

	private int extendID_;

	private int uIwordID_;

	private int uIDelayTime_;

	private int teleportDelayTime_;

	private float totalSlowTime_;

	private string unitDefeatType_ = "";

	private string defeatedSound_ = "";

	private string timeDilationCurve_ = "";

	private float additionalHPMaxMul_;

	private float additionalAtkMul_;

	private int localizationTag_;

	public static MessageParser<FUStBossRushConfigDesc> Parser => _parser;

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

	public int LevelID
	{
		get
		{
			return levelID_;
		}
		set
		{
			levelID_ = value;
		}
	}

	public EGSYesNo IsUseBossRoom
	{
		get
		{
			return isUseBossRoom_;
		}
		set
		{
			isUseBossRoom_ = value;
		}
	}

	public string GraphPath
	{
		get
		{
			return graphPath_;
		}
		set
		{
			graphPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string LevelName
	{
		get
		{
			return levelName_;
		}
		set
		{
			levelName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<string> TamerPath => tamerPath_;

	public int ExtendID
	{
		get
		{
			return extendID_;
		}
		set
		{
			extendID_ = value;
		}
	}

	public int UIwordID
	{
		get
		{
			return uIwordID_;
		}
		set
		{
			uIwordID_ = value;
		}
	}

	public int UIDelayTime
	{
		get
		{
			return uIDelayTime_;
		}
		set
		{
			uIDelayTime_ = value;
		}
	}

	public int TeleportDelayTime
	{
		get
		{
			return teleportDelayTime_;
		}
		set
		{
			teleportDelayTime_ = value;
		}
	}

	public float TotalSlowTime
	{
		get
		{
			return totalSlowTime_;
		}
		set
		{
			totalSlowTime_ = value;
		}
	}

	public string UnitDefeatType
	{
		get
		{
			return unitDefeatType_;
		}
		set
		{
			unitDefeatType_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public float AdditionalHPMaxMul
	{
		get
		{
			return additionalHPMaxMul_;
		}
		set
		{
			additionalHPMaxMul_ = value;
		}
	}

	public float AdditionalAtkMul
	{
		get
		{
			return additionalAtkMul_;
		}
		set
		{
			additionalAtkMul_ = value;
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

	public FUStBossRushConfigDesc()
	{
	}

	public FUStBossRushConfigDesc(FUStBossRushConfigDesc other)
		: this()
	{
		iD_ = other.iD_;
		levelID_ = other.levelID_;
		isUseBossRoom_ = other.isUseBossRoom_;
		graphPath_ = other.graphPath_;
		levelName_ = other.levelName_;
		tamerPath_ = other.tamerPath_.Clone();
		extendID_ = other.extendID_;
		uIwordID_ = other.uIwordID_;
		uIDelayTime_ = other.uIDelayTime_;
		teleportDelayTime_ = other.teleportDelayTime_;
		totalSlowTime_ = other.totalSlowTime_;
		unitDefeatType_ = other.unitDefeatType_;
		defeatedSound_ = other.defeatedSound_;
		timeDilationCurve_ = other.timeDilationCurve_;
		additionalHPMaxMul_ = other.additionalHPMaxMul_;
		additionalAtkMul_ = other.additionalAtkMul_;
		localizationTag_ = other.localizationTag_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStBossRushConfigDesc Clone()
	{
		return new FUStBossRushConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStBossRushConfigDesc);
	}

	public bool Equals(FUStBossRushConfigDesc other)
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
		if (LevelID != other.LevelID)
		{
			return false;
		}
		if (IsUseBossRoom != other.IsUseBossRoom)
		{
			return false;
		}
		if (GraphPath != other.GraphPath)
		{
			return false;
		}
		if (LevelName != other.LevelName)
		{
			return false;
		}
		if (!tamerPath_.Equals(other.tamerPath_))
		{
			return false;
		}
		if (ExtendID != other.ExtendID)
		{
			return false;
		}
		if (UIwordID != other.UIwordID)
		{
			return false;
		}
		if (UIDelayTime != other.UIDelayTime)
		{
			return false;
		}
		if (TeleportDelayTime != other.TeleportDelayTime)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TotalSlowTime, other.TotalSlowTime))
		{
			return false;
		}
		if (UnitDefeatType != other.UnitDefeatType)
		{
			return false;
		}
		if (DefeatedSound != other.DefeatedSound)
		{
			return false;
		}
		if (TimeDilationCurve != other.TimeDilationCurve)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AdditionalHPMaxMul, other.AdditionalHPMaxMul))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AdditionalAtkMul, other.AdditionalAtkMul))
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
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
		if (LevelID != 0)
		{
			num ^= LevelID.GetHashCode();
		}
		if (IsUseBossRoom != EGSYesNo.No)
		{
			num ^= IsUseBossRoom.GetHashCode();
		}
		if (GraphPath.Length != 0)
		{
			num ^= GraphPath.GetHashCode();
		}
		if (LevelName.Length != 0)
		{
			num ^= LevelName.GetHashCode();
		}
		num ^= tamerPath_.GetHashCode();
		if (ExtendID != 0)
		{
			num ^= ExtendID.GetHashCode();
		}
		if (UIwordID != 0)
		{
			num ^= UIwordID.GetHashCode();
		}
		if (UIDelayTime != 0)
		{
			num ^= UIDelayTime.GetHashCode();
		}
		if (TeleportDelayTime != 0)
		{
			num ^= TeleportDelayTime.GetHashCode();
		}
		if (TotalSlowTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TotalSlowTime);
		}
		if (UnitDefeatType.Length != 0)
		{
			num ^= UnitDefeatType.GetHashCode();
		}
		if (DefeatedSound.Length != 0)
		{
			num ^= DefeatedSound.GetHashCode();
		}
		if (TimeDilationCurve.Length != 0)
		{
			num ^= TimeDilationCurve.GetHashCode();
		}
		if (AdditionalHPMaxMul != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AdditionalHPMaxMul);
		}
		if (AdditionalAtkMul != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AdditionalAtkMul);
		}
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
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
		if (LevelID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(LevelID);
		}
		if (IsUseBossRoom != EGSYesNo.No)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)IsUseBossRoom);
		}
		if (GraphPath.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(GraphPath);
		}
		if (LevelName.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(LevelName);
		}
		tamerPath_.WriteTo(output, _repeated_tamerPath_codec);
		if (ExtendID != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(ExtendID);
		}
		if (UIwordID != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(UIwordID);
		}
		if (UIDelayTime != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(UIDelayTime);
		}
		if (TeleportDelayTime != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(TeleportDelayTime);
		}
		if (TotalSlowTime != 0f)
		{
			output.WriteRawTag(93);
			output.WriteFloat(TotalSlowTime);
		}
		if (UnitDefeatType.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(UnitDefeatType);
		}
		if (DefeatedSound.Length != 0)
		{
			output.WriteRawTag(106);
			output.WriteString(DefeatedSound);
		}
		if (TimeDilationCurve.Length != 0)
		{
			output.WriteRawTag(114);
			output.WriteString(TimeDilationCurve);
		}
		if (AdditionalHPMaxMul != 0f)
		{
			output.WriteRawTag(125);
			output.WriteFloat(AdditionalHPMaxMul);
		}
		if (AdditionalAtkMul != 0f)
		{
			output.WriteRawTag(133, 1);
			output.WriteFloat(AdditionalAtkMul);
		}
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(LocalizationTag);
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
		if (LevelID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelID);
		}
		if (IsUseBossRoom != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsUseBossRoom);
		}
		if (GraphPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GraphPath);
		}
		if (LevelName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LevelName);
		}
		num += tamerPath_.CalculateSize(_repeated_tamerPath_codec);
		if (ExtendID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ExtendID);
		}
		if (UIwordID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UIwordID);
		}
		if (UIDelayTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UIDelayTime);
		}
		if (TeleportDelayTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TeleportDelayTime);
		}
		if (TotalSlowTime != 0f)
		{
			num += 5;
		}
		if (UnitDefeatType.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UnitDefeatType);
		}
		if (DefeatedSound.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DefeatedSound);
		}
		if (TimeDilationCurve.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TimeDilationCurve);
		}
		if (AdditionalHPMaxMul != 0f)
		{
			num += 5;
		}
		if (AdditionalAtkMul != 0f)
		{
			num += 6;
		}
		if (LocalizationTag != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStBossRushConfigDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.LevelID != 0)
			{
				LevelID = other.LevelID;
			}
			if (other.IsUseBossRoom != EGSYesNo.No)
			{
				IsUseBossRoom = other.IsUseBossRoom;
			}
			if (other.GraphPath.Length != 0)
			{
				GraphPath = other.GraphPath;
			}
			if (other.LevelName.Length != 0)
			{
				LevelName = other.LevelName;
			}
			tamerPath_.Add(other.tamerPath_);
			if (other.ExtendID != 0)
			{
				ExtendID = other.ExtendID;
			}
			if (other.UIwordID != 0)
			{
				UIwordID = other.UIwordID;
			}
			if (other.UIDelayTime != 0)
			{
				UIDelayTime = other.UIDelayTime;
			}
			if (other.TeleportDelayTime != 0)
			{
				TeleportDelayTime = other.TeleportDelayTime;
			}
			if (other.TotalSlowTime != 0f)
			{
				TotalSlowTime = other.TotalSlowTime;
			}
			if (other.UnitDefeatType.Length != 0)
			{
				UnitDefeatType = other.UnitDefeatType;
			}
			if (other.DefeatedSound.Length != 0)
			{
				DefeatedSound = other.DefeatedSound;
			}
			if (other.TimeDilationCurve.Length != 0)
			{
				TimeDilationCurve = other.TimeDilationCurve;
			}
			if (other.AdditionalHPMaxMul != 0f)
			{
				AdditionalHPMaxMul = other.AdditionalHPMaxMul;
			}
			if (other.AdditionalAtkMul != 0f)
			{
				AdditionalAtkMul = other.AdditionalAtkMul;
			}
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
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
				LevelID = input.ReadInt32();
				break;
			case 24u:
				IsUseBossRoom = (EGSYesNo)input.ReadEnum();
				break;
			case 34u:
				GraphPath = input.ReadString();
				break;
			case 42u:
				LevelName = input.ReadString();
				break;
			case 50u:
				tamerPath_.AddEntriesFrom(input, _repeated_tamerPath_codec);
				break;
			case 56u:
				ExtendID = input.ReadInt32();
				break;
			case 64u:
				UIwordID = input.ReadInt32();
				break;
			case 72u:
				UIDelayTime = input.ReadInt32();
				break;
			case 80u:
				TeleportDelayTime = input.ReadInt32();
				break;
			case 93u:
				TotalSlowTime = input.ReadFloat();
				break;
			case 98u:
				UnitDefeatType = input.ReadString();
				break;
			case 106u:
				DefeatedSound = input.ReadString();
				break;
			case 114u:
				TimeDilationCurve = input.ReadString();
				break;
			case 125u:
				AdditionalHPMaxMul = input.ReadFloat();
				break;
			case 133u:
				AdditionalAtkMul = input.ReadFloat();
				break;
			case 136u:
				LocalizationTag = input.ReadInt32();
				break;
			}
		}
	}
}
