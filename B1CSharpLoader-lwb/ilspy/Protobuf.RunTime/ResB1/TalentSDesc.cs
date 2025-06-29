using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TalentSDesc : IMessage<TalentSDesc>, IMessage, IEquatable<TalentSDesc>, IDeepCloneable<TalentSDesc>
{
	private static readonly MessageParser<TalentSDesc> _parser = new MessageParser<TalentSDesc>(() => new TalentSDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private string name_ = "";

	private int talentGroupId_;

	private string unitResIDStrs_ = "";

	private string passiveSkillIDs_ = "";

	private string addBuffIDs_ = "";

	private static readonly FieldCodec<int> _repeated_requireTalentId_codec = FieldCodec.ForInt32(58u);

	private readonly RepeatedField<int> requireTalentId_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_requireSpellId_codec = FieldCodec.ForInt32(66u);

	private readonly RepeatedField<int> requireSpellId_ = new RepeatedField<int>();

	private int maxLevel_;

	private static readonly FieldCodec<TalentLevelUpCfg> _repeated_levelUpCfg_codec = FieldCodec.ForMessage(82u, TalentLevelUpCfg.Parser);

	private readonly RepeatedField<TalentLevelUpCfg> levelUpCfg_ = new RepeatedField<TalentLevelUpCfg>();

	private TalentType type_;

	private int rank_;

	private int requirePlayerLevel_;

	private YesNoType isSpellOnly_;

	private int localizationTag_;

	private YesNoType isHide_;

	public static MessageParser<TalentSDesc> Parser => _parser;

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

	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int TalentGroupId
	{
		get
		{
			return talentGroupId_;
		}
		set
		{
			talentGroupId_ = value;
		}
	}

	public string UnitResIDStrs
	{
		get
		{
			return unitResIDStrs_;
		}
		set
		{
			unitResIDStrs_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string PassiveSkillIDs
	{
		get
		{
			return passiveSkillIDs_;
		}
		set
		{
			passiveSkillIDs_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string AddBuffIDs
	{
		get
		{
			return addBuffIDs_;
		}
		set
		{
			addBuffIDs_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<int> RequireTalentId => requireTalentId_;

	public RepeatedField<int> RequireSpellId => requireSpellId_;

	public int MaxLevel
	{
		get
		{
			return maxLevel_;
		}
		set
		{
			maxLevel_ = value;
		}
	}

	public RepeatedField<TalentLevelUpCfg> LevelUpCfg => levelUpCfg_;

	public TalentType Type
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

	public int Rank
	{
		get
		{
			return rank_;
		}
		set
		{
			rank_ = value;
		}
	}

	public int RequirePlayerLevel
	{
		get
		{
			return requirePlayerLevel_;
		}
		set
		{
			requirePlayerLevel_ = value;
		}
	}

	public YesNoType IsSpellOnly
	{
		get
		{
			return isSpellOnly_;
		}
		set
		{
			isSpellOnly_ = value;
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

	public YesNoType IsHide
	{
		get
		{
			return isHide_;
		}
		set
		{
			isHide_ = value;
		}
	}

	public TalentSDesc()
	{
	}

	public TalentSDesc(TalentSDesc other)
		: this()
	{
		id_ = other.id_;
		name_ = other.name_;
		talentGroupId_ = other.talentGroupId_;
		unitResIDStrs_ = other.unitResIDStrs_;
		passiveSkillIDs_ = other.passiveSkillIDs_;
		addBuffIDs_ = other.addBuffIDs_;
		requireTalentId_ = other.requireTalentId_.Clone();
		requireSpellId_ = other.requireSpellId_.Clone();
		maxLevel_ = other.maxLevel_;
		levelUpCfg_ = other.levelUpCfg_.Clone();
		type_ = other.type_;
		rank_ = other.rank_;
		requirePlayerLevel_ = other.requirePlayerLevel_;
		isSpellOnly_ = other.isSpellOnly_;
		localizationTag_ = other.localizationTag_;
		isHide_ = other.isHide_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TalentSDesc Clone()
	{
		return new TalentSDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TalentSDesc);
	}

	public bool Equals(TalentSDesc other)
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
		if (Name != other.Name)
		{
			return false;
		}
		if (TalentGroupId != other.TalentGroupId)
		{
			return false;
		}
		if (UnitResIDStrs != other.UnitResIDStrs)
		{
			return false;
		}
		if (PassiveSkillIDs != other.PassiveSkillIDs)
		{
			return false;
		}
		if (AddBuffIDs != other.AddBuffIDs)
		{
			return false;
		}
		if (!requireTalentId_.Equals(other.requireTalentId_))
		{
			return false;
		}
		if (!requireSpellId_.Equals(other.requireSpellId_))
		{
			return false;
		}
		if (MaxLevel != other.MaxLevel)
		{
			return false;
		}
		if (!levelUpCfg_.Equals(other.levelUpCfg_))
		{
			return false;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (Rank != other.Rank)
		{
			return false;
		}
		if (RequirePlayerLevel != other.RequirePlayerLevel)
		{
			return false;
		}
		if (IsSpellOnly != other.IsSpellOnly)
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
		{
			return false;
		}
		if (IsHide != other.IsHide)
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
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (TalentGroupId != 0)
		{
			num ^= TalentGroupId.GetHashCode();
		}
		if (UnitResIDStrs.Length != 0)
		{
			num ^= UnitResIDStrs.GetHashCode();
		}
		if (PassiveSkillIDs.Length != 0)
		{
			num ^= PassiveSkillIDs.GetHashCode();
		}
		if (AddBuffIDs.Length != 0)
		{
			num ^= AddBuffIDs.GetHashCode();
		}
		num ^= requireTalentId_.GetHashCode();
		num ^= requireSpellId_.GetHashCode();
		if (MaxLevel != 0)
		{
			num ^= MaxLevel.GetHashCode();
		}
		num ^= levelUpCfg_.GetHashCode();
		if (Type != TalentType.Default)
		{
			num ^= Type.GetHashCode();
		}
		if (Rank != 0)
		{
			num ^= Rank.GetHashCode();
		}
		if (RequirePlayerLevel != 0)
		{
			num ^= RequirePlayerLevel.GetHashCode();
		}
		if (IsSpellOnly != YesNoType.No)
		{
			num ^= IsSpellOnly.GetHashCode();
		}
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
		}
		if (IsHide != YesNoType.No)
		{
			num ^= IsHide.GetHashCode();
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
		if (Name.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Name);
		}
		if (TalentGroupId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(TalentGroupId);
		}
		if (UnitResIDStrs.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(UnitResIDStrs);
		}
		if (PassiveSkillIDs.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(PassiveSkillIDs);
		}
		if (AddBuffIDs.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(AddBuffIDs);
		}
		requireTalentId_.WriteTo(output, _repeated_requireTalentId_codec);
		requireSpellId_.WriteTo(output, _repeated_requireSpellId_codec);
		if (MaxLevel != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(MaxLevel);
		}
		levelUpCfg_.WriteTo(output, _repeated_levelUpCfg_codec);
		if (Type != TalentType.Default)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)Type);
		}
		if (Rank != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(Rank);
		}
		if (RequirePlayerLevel != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(RequirePlayerLevel);
		}
		if (IsSpellOnly != YesNoType.No)
		{
			output.WriteRawTag(112);
			output.WriteEnum((int)IsSpellOnly);
		}
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(LocalizationTag);
		}
		if (IsHide != YesNoType.No)
		{
			output.WriteRawTag(128, 1);
			output.WriteEnum((int)IsHide);
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
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (TalentGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TalentGroupId);
		}
		if (UnitResIDStrs.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UnitResIDStrs);
		}
		if (PassiveSkillIDs.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PassiveSkillIDs);
		}
		if (AddBuffIDs.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AddBuffIDs);
		}
		num += requireTalentId_.CalculateSize(_repeated_requireTalentId_codec);
		num += requireSpellId_.CalculateSize(_repeated_requireSpellId_codec);
		if (MaxLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxLevel);
		}
		num += levelUpCfg_.CalculateSize(_repeated_levelUpCfg_codec);
		if (Type != TalentType.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (Rank != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Rank);
		}
		if (RequirePlayerLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RequirePlayerLevel);
		}
		if (IsSpellOnly != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsSpellOnly);
		}
		if (LocalizationTag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (IsHide != YesNoType.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)IsHide);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TalentSDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.TalentGroupId != 0)
			{
				TalentGroupId = other.TalentGroupId;
			}
			if (other.UnitResIDStrs.Length != 0)
			{
				UnitResIDStrs = other.UnitResIDStrs;
			}
			if (other.PassiveSkillIDs.Length != 0)
			{
				PassiveSkillIDs = other.PassiveSkillIDs;
			}
			if (other.AddBuffIDs.Length != 0)
			{
				AddBuffIDs = other.AddBuffIDs;
			}
			requireTalentId_.Add(other.requireTalentId_);
			requireSpellId_.Add(other.requireSpellId_);
			if (other.MaxLevel != 0)
			{
				MaxLevel = other.MaxLevel;
			}
			levelUpCfg_.Add(other.levelUpCfg_);
			if (other.Type != TalentType.Default)
			{
				Type = other.Type;
			}
			if (other.Rank != 0)
			{
				Rank = other.Rank;
			}
			if (other.RequirePlayerLevel != 0)
			{
				RequirePlayerLevel = other.RequirePlayerLevel;
			}
			if (other.IsSpellOnly != YesNoType.No)
			{
				IsSpellOnly = other.IsSpellOnly;
			}
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
			}
			if (other.IsHide != YesNoType.No)
			{
				IsHide = other.IsHide;
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
				Id = input.ReadInt32();
				break;
			case 18u:
				Name = input.ReadString();
				break;
			case 24u:
				TalentGroupId = input.ReadInt32();
				break;
			case 34u:
				UnitResIDStrs = input.ReadString();
				break;
			case 42u:
				PassiveSkillIDs = input.ReadString();
				break;
			case 50u:
				AddBuffIDs = input.ReadString();
				break;
			case 56u:
			case 58u:
				requireTalentId_.AddEntriesFrom(input, _repeated_requireTalentId_codec);
				break;
			case 64u:
			case 66u:
				requireSpellId_.AddEntriesFrom(input, _repeated_requireSpellId_codec);
				break;
			case 72u:
				MaxLevel = input.ReadInt32();
				break;
			case 82u:
				levelUpCfg_.AddEntriesFrom(input, _repeated_levelUpCfg_codec);
				break;
			case 88u:
				Type = (TalentType)input.ReadEnum();
				break;
			case 96u:
				Rank = input.ReadInt32();
				break;
			case 104u:
				RequirePlayerLevel = input.ReadInt32();
				break;
			case 112u:
				IsSpellOnly = (YesNoType)input.ReadEnum();
				break;
			case 120u:
				LocalizationTag = input.ReadInt32();
				break;
			case 128u:
				IsHide = (YesNoType)input.ReadEnum();
				break;
			}
		}
	}
}
