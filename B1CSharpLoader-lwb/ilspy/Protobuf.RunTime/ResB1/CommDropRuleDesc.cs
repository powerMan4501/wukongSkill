using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class CommDropRuleDesc : IMessage<CommDropRuleDesc>, IMessage, IEquatable<CommDropRuleDesc>, IDeepCloneable<CommDropRuleDesc>
{
	private static readonly MessageParser<CommDropRuleDesc> _parser = new MessageParser<CommDropRuleDesc>(() => new CommDropRuleDesc());

	private UnknownFieldSet _unknownFields;

	private int dropId_;

	private DropConfigType type_;

	private static readonly FieldCodec<DropLibConfig> _repeated_dropLib_codec = FieldCodec.ForMessage(26u, DropLibConfig.Parser);

	private readonly RepeatedField<DropLibConfig> dropLib_ = new RepeatedField<DropLibConfig>();

	private LimitParam limitParam_;

	private YesNoType isAffectByGameCount_;

	private int extraMoney_;

	private int extraExp_;

	private static readonly FieldCodec<ItemOne> _repeated_uniqueDropOnce_codec = FieldCodec.ForMessage(66u, ItemOne.Parser);

	private readonly RepeatedField<ItemOne> uniqueDropOnce_ = new RepeatedField<ItemOne>();

	private static readonly FieldCodec<UniqueDropItem> _repeated_uniqueDropReplace_codec = FieldCodec.ForMessage(74u, UniqueDropItem.Parser);

	private readonly RepeatedField<UniqueDropItem> uniqueDropReplace_ = new RepeatedField<UniqueDropItem>();

	private int groupDropRate_;

	private DropRollType rollType_;

	private int rollNum_;

	private static readonly FieldCodec<DropItemOne> _repeated_randDrop_codec = FieldCodec.ForMessage(106u, DropItemOne.Parser);

	private readonly RepeatedField<DropItemOne> randDrop_ = new RepeatedField<DropItemOne>();

	private int uniqueDropRepeat_;

	private int levelStrength_;

	private EUnitQualityType quality_;

	public static MessageParser<CommDropRuleDesc> Parser => _parser;

	public int DropId
	{
		get
		{
			return dropId_;
		}
		set
		{
			dropId_ = value;
		}
	}

	public DropConfigType Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	public RepeatedField<DropLibConfig> DropLib => dropLib_;

	public LimitParam LimitParam
	{
		get
		{
			return limitParam_;
		}
		set
		{
			limitParam_ = value;
		}
	}

	public YesNoType IsAffectByGameCount
	{
		get
		{
			return isAffectByGameCount_;
		}
		set
		{
			isAffectByGameCount_ = value;
		}
	}

	public int ExtraMoney
	{
		get
		{
			return extraMoney_;
		}
		set
		{
			extraMoney_ = value;
		}
	}

	public int ExtraExp
	{
		get
		{
			return extraExp_;
		}
		set
		{
			extraExp_ = value;
		}
	}

	public RepeatedField<ItemOne> UniqueDropOnce => uniqueDropOnce_;

	public RepeatedField<UniqueDropItem> UniqueDropReplace => uniqueDropReplace_;

	public int GroupDropRate
	{
		get
		{
			return groupDropRate_;
		}
		set
		{
			groupDropRate_ = value;
		}
	}

	public DropRollType RollType
	{
		get
		{
			return rollType_;
		}
		set
		{
			rollType_ = value;
		}
	}

	public int RollNum
	{
		get
		{
			return rollNum_;
		}
		set
		{
			rollNum_ = value;
		}
	}

	public RepeatedField<DropItemOne> RandDrop => randDrop_;

	public int UniqueDropRepeat
	{
		get
		{
			return uniqueDropRepeat_;
		}
		set
		{
			uniqueDropRepeat_ = value;
		}
	}

	public int LevelStrength
	{
		get
		{
			return levelStrength_;
		}
		set
		{
			levelStrength_ = value;
		}
	}

	public EUnitQualityType Quality
	{
		get
		{
			return quality_;
		}
		set
		{
			quality_ = value;
		}
	}

	public CommDropRuleDesc()
	{
	}

	public CommDropRuleDesc(CommDropRuleDesc other)
		: this()
	{
		dropId_ = other.dropId_;
		type_ = other.type_;
		dropLib_ = other.dropLib_.Clone();
		limitParam_ = ((other.limitParam_ != null) ? other.limitParam_.Clone() : null);
		isAffectByGameCount_ = other.isAffectByGameCount_;
		extraMoney_ = other.extraMoney_;
		extraExp_ = other.extraExp_;
		uniqueDropOnce_ = other.uniqueDropOnce_.Clone();
		uniqueDropReplace_ = other.uniqueDropReplace_.Clone();
		groupDropRate_ = other.groupDropRate_;
		rollType_ = other.rollType_;
		rollNum_ = other.rollNum_;
		randDrop_ = other.randDrop_.Clone();
		uniqueDropRepeat_ = other.uniqueDropRepeat_;
		levelStrength_ = other.levelStrength_;
		quality_ = other.quality_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CommDropRuleDesc Clone()
	{
		return new CommDropRuleDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CommDropRuleDesc);
	}

	public bool Equals(CommDropRuleDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DropId != other.DropId)
		{
			return false;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (!dropLib_.Equals(other.dropLib_))
		{
			return false;
		}
		if (!object.Equals(LimitParam, other.LimitParam))
		{
			return false;
		}
		if (IsAffectByGameCount != other.IsAffectByGameCount)
		{
			return false;
		}
		if (ExtraMoney != other.ExtraMoney)
		{
			return false;
		}
		if (ExtraExp != other.ExtraExp)
		{
			return false;
		}
		if (!uniqueDropOnce_.Equals(other.uniqueDropOnce_))
		{
			return false;
		}
		if (!uniqueDropReplace_.Equals(other.uniqueDropReplace_))
		{
			return false;
		}
		if (GroupDropRate != other.GroupDropRate)
		{
			return false;
		}
		if (RollType != other.RollType)
		{
			return false;
		}
		if (RollNum != other.RollNum)
		{
			return false;
		}
		if (!randDrop_.Equals(other.randDrop_))
		{
			return false;
		}
		if (UniqueDropRepeat != other.UniqueDropRepeat)
		{
			return false;
		}
		if (LevelStrength != other.LevelStrength)
		{
			return false;
		}
		if (Quality != other.Quality)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (DropId != 0)
		{
			num ^= DropId.GetHashCode();
		}
		if (Type != DropConfigType.Default)
		{
			num ^= Type.GetHashCode();
		}
		num ^= dropLib_.GetHashCode();
		if (limitParam_ != null)
		{
			num ^= LimitParam.GetHashCode();
		}
		if (IsAffectByGameCount != YesNoType.No)
		{
			num ^= IsAffectByGameCount.GetHashCode();
		}
		if (ExtraMoney != 0)
		{
			num ^= ExtraMoney.GetHashCode();
		}
		if (ExtraExp != 0)
		{
			num ^= ExtraExp.GetHashCode();
		}
		num ^= uniqueDropOnce_.GetHashCode();
		num ^= uniqueDropReplace_.GetHashCode();
		if (GroupDropRate != 0)
		{
			num ^= GroupDropRate.GetHashCode();
		}
		if (RollType != DropRollType.All)
		{
			num ^= RollType.GetHashCode();
		}
		if (RollNum != 0)
		{
			num ^= RollNum.GetHashCode();
		}
		num ^= randDrop_.GetHashCode();
		if (UniqueDropRepeat != 0)
		{
			num ^= UniqueDropRepeat.GetHashCode();
		}
		if (LevelStrength != 0)
		{
			num ^= LevelStrength.GetHashCode();
		}
		if (Quality != EUnitQualityType.None)
		{
			num ^= Quality.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (DropId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(DropId);
		}
		if (Type != DropConfigType.Default)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Type);
		}
		dropLib_.WriteTo(output, _repeated_dropLib_codec);
		if (limitParam_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(LimitParam);
		}
		if (IsAffectByGameCount != YesNoType.No)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)IsAffectByGameCount);
		}
		if (ExtraMoney != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(ExtraMoney);
		}
		if (ExtraExp != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(ExtraExp);
		}
		uniqueDropOnce_.WriteTo(output, _repeated_uniqueDropOnce_codec);
		uniqueDropReplace_.WriteTo(output, _repeated_uniqueDropReplace_codec);
		if (GroupDropRate != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(GroupDropRate);
		}
		if (RollType != DropRollType.All)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)RollType);
		}
		if (RollNum != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(RollNum);
		}
		randDrop_.WriteTo(output, _repeated_randDrop_codec);
		if (UniqueDropRepeat != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(UniqueDropRepeat);
		}
		if (LevelStrength != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(LevelStrength);
		}
		if (Quality != EUnitQualityType.None)
		{
			output.WriteRawTag(128, 1);
			output.WriteEnum((int)Quality);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (DropId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DropId);
		}
		if (Type != DropConfigType.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		num += dropLib_.CalculateSize(_repeated_dropLib_codec);
		if (limitParam_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LimitParam);
		}
		if (IsAffectByGameCount != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsAffectByGameCount);
		}
		if (ExtraMoney != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ExtraMoney);
		}
		if (ExtraExp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ExtraExp);
		}
		num += uniqueDropOnce_.CalculateSize(_repeated_uniqueDropOnce_codec);
		num += uniqueDropReplace_.CalculateSize(_repeated_uniqueDropReplace_codec);
		if (GroupDropRate != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupDropRate);
		}
		if (RollType != DropRollType.All)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)RollType);
		}
		if (RollNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RollNum);
		}
		num += randDrop_.CalculateSize(_repeated_randDrop_codec);
		if (UniqueDropRepeat != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UniqueDropRepeat);
		}
		if (LevelStrength != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelStrength);
		}
		if (Quality != EUnitQualityType.None)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)Quality);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CommDropRuleDesc other)
	{
		if (other == null)
		{
			return;
		}
		if (other.DropId != 0)
		{
			DropId = other.DropId;
		}
		if (other.Type != DropConfigType.Default)
		{
			Type = other.Type;
		}
		dropLib_.Add(other.dropLib_);
		if (other.limitParam_ != null)
		{
			if (limitParam_ == null)
			{
				LimitParam = new LimitParam();
			}
			LimitParam.MergeFrom(other.LimitParam);
		}
		if (other.IsAffectByGameCount != YesNoType.No)
		{
			IsAffectByGameCount = other.IsAffectByGameCount;
		}
		if (other.ExtraMoney != 0)
		{
			ExtraMoney = other.ExtraMoney;
		}
		if (other.ExtraExp != 0)
		{
			ExtraExp = other.ExtraExp;
		}
		uniqueDropOnce_.Add(other.uniqueDropOnce_);
		uniqueDropReplace_.Add(other.uniqueDropReplace_);
		if (other.GroupDropRate != 0)
		{
			GroupDropRate = other.GroupDropRate;
		}
		if (other.RollType != DropRollType.All)
		{
			RollType = other.RollType;
		}
		if (other.RollNum != 0)
		{
			RollNum = other.RollNum;
		}
		randDrop_.Add(other.randDrop_);
		if (other.UniqueDropRepeat != 0)
		{
			UniqueDropRepeat = other.UniqueDropRepeat;
		}
		if (other.LevelStrength != 0)
		{
			LevelStrength = other.LevelStrength;
		}
		if (other.Quality != EUnitQualityType.None)
		{
			Quality = other.Quality;
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
				DropId = input.ReadInt32();
				break;
			case 16u:
				Type = (DropConfigType)input.ReadEnum();
				break;
			case 26u:
				dropLib_.AddEntriesFrom(input, _repeated_dropLib_codec);
				break;
			case 34u:
				if (limitParam_ == null)
				{
					LimitParam = new LimitParam();
				}
				input.ReadMessage(LimitParam);
				break;
			case 40u:
				IsAffectByGameCount = (YesNoType)input.ReadEnum();
				break;
			case 48u:
				ExtraMoney = input.ReadInt32();
				break;
			case 56u:
				ExtraExp = input.ReadInt32();
				break;
			case 66u:
				uniqueDropOnce_.AddEntriesFrom(input, _repeated_uniqueDropOnce_codec);
				break;
			case 74u:
				uniqueDropReplace_.AddEntriesFrom(input, _repeated_uniqueDropReplace_codec);
				break;
			case 80u:
				GroupDropRate = input.ReadInt32();
				break;
			case 88u:
				RollType = (DropRollType)input.ReadEnum();
				break;
			case 96u:
				RollNum = input.ReadInt32();
				break;
			case 106u:
				randDrop_.AddEntriesFrom(input, _repeated_randDrop_codec);
				break;
			case 112u:
				UniqueDropRepeat = input.ReadInt32();
				break;
			case 120u:
				LevelStrength = input.ReadInt32();
				break;
			case 128u:
				Quality = (EUnitQualityType)input.ReadEnum();
				break;
			}
		}
	}
}
