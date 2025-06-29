using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStPotentialEnergyLevelDetailConfig : IMessage<FUStPotentialEnergyLevelDetailConfig>, IMessage, IEquatable<FUStPotentialEnergyLevelDetailConfig>, IDeepCloneable<FUStPotentialEnergyLevelDetailConfig>
{
	private static readonly MessageParser<FUStPotentialEnergyLevelDetailConfig> _parser = new MessageParser<FUStPotentialEnergyLevelDetailConfig>(() => new FUStPotentialEnergyLevelDetailConfig());

	private UnknownFieldSet _unknownFields;

	private int pELevel_;

	private float protectTime_;

	private float decreaseValuePerSecond_;

	private float levelValue_;

	private EGSYesNo isNomalMaxLevel_;

	private string dBCDAPath_ = "";

	private static readonly FieldCodec<int> _repeated_buffIDList_codec = FieldCodec.ForInt32(58u);

	private readonly RepeatedField<int> buffIDList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_buffIDListLevelUp_codec = FieldCodec.ForInt32(66u);

	private readonly RepeatedField<int> buffIDListLevelUp_ = new RepeatedField<int>();

	private int switchPEConfigBuffID_;

	public static MessageParser<FUStPotentialEnergyLevelDetailConfig> Parser => _parser;

	public int PELevel
	{
		get
		{
			return pELevel_;
		}
		set
		{
			pELevel_ = value;
		}
	}

	public float ProtectTime
	{
		get
		{
			return protectTime_;
		}
		set
		{
			protectTime_ = value;
		}
	}

	public float DecreaseValuePerSecond
	{
		get
		{
			return decreaseValuePerSecond_;
		}
		set
		{
			decreaseValuePerSecond_ = value;
		}
	}

	public float LevelValue
	{
		get
		{
			return levelValue_;
		}
		set
		{
			levelValue_ = value;
		}
	}

	public EGSYesNo IsNomalMaxLevel
	{
		get
		{
			return isNomalMaxLevel_;
		}
		set
		{
			isNomalMaxLevel_ = value;
		}
	}

	public string DBCDAPath
	{
		get
		{
			return dBCDAPath_;
		}
		set
		{
			dBCDAPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<int> BuffIDList => buffIDList_;

	public RepeatedField<int> BuffIDListLevelUp => buffIDListLevelUp_;

	public int SwitchPEConfigBuffID
	{
		get
		{
			return switchPEConfigBuffID_;
		}
		set
		{
			switchPEConfigBuffID_ = value;
		}
	}

	public FUStPotentialEnergyLevelDetailConfig()
	{
	}

	public FUStPotentialEnergyLevelDetailConfig(FUStPotentialEnergyLevelDetailConfig other)
		: this()
	{
		pELevel_ = other.pELevel_;
		protectTime_ = other.protectTime_;
		decreaseValuePerSecond_ = other.decreaseValuePerSecond_;
		levelValue_ = other.levelValue_;
		isNomalMaxLevel_ = other.isNomalMaxLevel_;
		dBCDAPath_ = other.dBCDAPath_;
		buffIDList_ = other.buffIDList_.Clone();
		buffIDListLevelUp_ = other.buffIDListLevelUp_.Clone();
		switchPEConfigBuffID_ = other.switchPEConfigBuffID_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStPotentialEnergyLevelDetailConfig Clone()
	{
		return new FUStPotentialEnergyLevelDetailConfig(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStPotentialEnergyLevelDetailConfig);
	}

	public bool Equals(FUStPotentialEnergyLevelDetailConfig other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PELevel != other.PELevel)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ProtectTime, other.ProtectTime))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DecreaseValuePerSecond, other.DecreaseValuePerSecond))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(LevelValue, other.LevelValue))
		{
			return false;
		}
		if (IsNomalMaxLevel != other.IsNomalMaxLevel)
		{
			return false;
		}
		if (DBCDAPath != other.DBCDAPath)
		{
			return false;
		}
		if (!buffIDList_.Equals(other.buffIDList_))
		{
			return false;
		}
		if (!buffIDListLevelUp_.Equals(other.buffIDListLevelUp_))
		{
			return false;
		}
		if (SwitchPEConfigBuffID != other.SwitchPEConfigBuffID)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (PELevel != 0)
		{
			num ^= PELevel.GetHashCode();
		}
		if (ProtectTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ProtectTime);
		}
		if (DecreaseValuePerSecond != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DecreaseValuePerSecond);
		}
		if (LevelValue != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(LevelValue);
		}
		if (IsNomalMaxLevel != EGSYesNo.No)
		{
			num ^= IsNomalMaxLevel.GetHashCode();
		}
		if (DBCDAPath.Length != 0)
		{
			num ^= DBCDAPath.GetHashCode();
		}
		num ^= buffIDList_.GetHashCode();
		num ^= buffIDListLevelUp_.GetHashCode();
		if (SwitchPEConfigBuffID != 0)
		{
			num ^= SwitchPEConfigBuffID.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (PELevel != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(PELevel);
		}
		if (ProtectTime != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(ProtectTime);
		}
		if (DecreaseValuePerSecond != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(DecreaseValuePerSecond);
		}
		if (LevelValue != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(LevelValue);
		}
		if (IsNomalMaxLevel != EGSYesNo.No)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)IsNomalMaxLevel);
		}
		if (DBCDAPath.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(DBCDAPath);
		}
		buffIDList_.WriteTo(output, _repeated_buffIDList_codec);
		buffIDListLevelUp_.WriteTo(output, _repeated_buffIDListLevelUp_codec);
		if (SwitchPEConfigBuffID != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(SwitchPEConfigBuffID);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (PELevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PELevel);
		}
		if (ProtectTime != 0f)
		{
			num += 5;
		}
		if (DecreaseValuePerSecond != 0f)
		{
			num += 5;
		}
		if (LevelValue != 0f)
		{
			num += 5;
		}
		if (IsNomalMaxLevel != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsNomalMaxLevel);
		}
		if (DBCDAPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DBCDAPath);
		}
		num += buffIDList_.CalculateSize(_repeated_buffIDList_codec);
		num += buffIDListLevelUp_.CalculateSize(_repeated_buffIDListLevelUp_codec);
		if (SwitchPEConfigBuffID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SwitchPEConfigBuffID);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStPotentialEnergyLevelDetailConfig other)
	{
		if (other != null)
		{
			if (other.PELevel != 0)
			{
				PELevel = other.PELevel;
			}
			if (other.ProtectTime != 0f)
			{
				ProtectTime = other.ProtectTime;
			}
			if (other.DecreaseValuePerSecond != 0f)
			{
				DecreaseValuePerSecond = other.DecreaseValuePerSecond;
			}
			if (other.LevelValue != 0f)
			{
				LevelValue = other.LevelValue;
			}
			if (other.IsNomalMaxLevel != EGSYesNo.No)
			{
				IsNomalMaxLevel = other.IsNomalMaxLevel;
			}
			if (other.DBCDAPath.Length != 0)
			{
				DBCDAPath = other.DBCDAPath;
			}
			buffIDList_.Add(other.buffIDList_);
			buffIDListLevelUp_.Add(other.buffIDListLevelUp_);
			if (other.SwitchPEConfigBuffID != 0)
			{
				SwitchPEConfigBuffID = other.SwitchPEConfigBuffID;
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
				PELevel = input.ReadInt32();
				break;
			case 21u:
				ProtectTime = input.ReadFloat();
				break;
			case 29u:
				DecreaseValuePerSecond = input.ReadFloat();
				break;
			case 37u:
				LevelValue = input.ReadFloat();
				break;
			case 40u:
				IsNomalMaxLevel = (EGSYesNo)input.ReadEnum();
				break;
			case 50u:
				DBCDAPath = input.ReadString();
				break;
			case 56u:
			case 58u:
				buffIDList_.AddEntriesFrom(input, _repeated_buffIDList_codec);
				break;
			case 64u:
			case 66u:
				buffIDListLevelUp_.AddEntriesFrom(input, _repeated_buffIDListLevelUp_codec);
				break;
			case 72u:
				SwitchPEConfigBuffID = input.ReadInt32();
				break;
			}
		}
	}
}
