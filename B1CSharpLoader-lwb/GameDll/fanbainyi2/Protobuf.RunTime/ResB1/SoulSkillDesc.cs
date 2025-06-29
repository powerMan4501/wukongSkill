using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class SoulSkillDesc : IMessage<SoulSkillDesc>, IMessage, IEquatable<SoulSkillDesc>, IDeepCloneable<SoulSkillDesc>
{
	private static readonly MessageParser<SoulSkillDesc> _parser = new MessageParser<SoulSkillDesc>(() => new SoulSkillDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private string skillName_ = "";

	private int userResId_;

	private string dAPath_ = "";

	private float castEnergy_;

	private int skillId_;

	private int skillIdWhenLeave_;

	private int skillIdReEnter_;

	private int buffId_;

	private float reEnterWaitTime_;

	private string leaveFXPath_ = "";

	private string reEnterFadeOutFXPath_ = "";

	private float delayTimeWithoutLeave_;

	private string cameraPreview_ = "";

	private SoulSkillType type_;

	private float mimicryMaxTime_;

	private int reuseModle_;

	private int reuseSkillIcon_;

	private int reuseSkillVideo_;

	private int upgradeNextId_;

	private static readonly FieldCodec<string> _repeated_upgradeDesc_codec = FieldCodec.ForString(170u);

	private readonly RepeatedField<string> upgradeDesc_ = new RepeatedField<string>();

	private int upgradeCostMoney_;

	private static readonly FieldCodec<ItemOne> _repeated_costItem_codec = FieldCodec.ForMessage(186u, ItemOne.Parser);

	private readonly RepeatedField<ItemOne> costItem_ = new RepeatedField<ItemOne>();

	private int localizationTag_;

	private int replaceDropId_;

	private int levelId_;

	private string mappingRandomId_ = "";

	private int attrEffectId_;

	private int effectTalentId_;

	private string effectTalentDesc_ = "";

	private int overrideAbnormalDispIDAttacker_;

	private int overrideAbnormalDispIDVictim_;

	public static MessageParser<SoulSkillDesc> Parser => _parser;

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

	public string SkillName
	{
		get
		{
			return skillName_;
		}
		set
		{
			skillName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int UserResId
	{
		get
		{
			return userResId_;
		}
		set
		{
			userResId_ = value;
		}
	}

	public string DAPath
	{
		get
		{
			return dAPath_;
		}
		set
		{
			dAPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public float CastEnergy
	{
		get
		{
			return castEnergy_;
		}
		set
		{
			castEnergy_ = value;
		}
	}

	public int SkillId
	{
		get
		{
			return skillId_;
		}
		set
		{
			skillId_ = value;
		}
	}

	public int SkillIdWhenLeave
	{
		get
		{
			return skillIdWhenLeave_;
		}
		set
		{
			skillIdWhenLeave_ = value;
		}
	}

	public int SkillIdReEnter
	{
		get
		{
			return skillIdReEnter_;
		}
		set
		{
			skillIdReEnter_ = value;
		}
	}

	public int BuffId
	{
		get
		{
			return buffId_;
		}
		set
		{
			buffId_ = value;
		}
	}

	public float ReEnterWaitTime
	{
		get
		{
			return reEnterWaitTime_;
		}
		set
		{
			reEnterWaitTime_ = value;
		}
	}

	public string LeaveFXPath
	{
		get
		{
			return leaveFXPath_;
		}
		set
		{
			leaveFXPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ReEnterFadeOutFXPath
	{
		get
		{
			return reEnterFadeOutFXPath_;
		}
		set
		{
			reEnterFadeOutFXPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public float DelayTimeWithoutLeave
	{
		get
		{
			return delayTimeWithoutLeave_;
		}
		set
		{
			delayTimeWithoutLeave_ = value;
		}
	}

	public string CameraPreview
	{
		get
		{
			return cameraPreview_;
		}
		set
		{
			cameraPreview_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public SoulSkillType Type
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

	public float MimicryMaxTime
	{
		get
		{
			return mimicryMaxTime_;
		}
		set
		{
			mimicryMaxTime_ = value;
		}
	}

	public int ReuseModle
	{
		get
		{
			return reuseModle_;
		}
		set
		{
			reuseModle_ = value;
		}
	}

	public int ReuseSkillIcon
	{
		get
		{
			return reuseSkillIcon_;
		}
		set
		{
			reuseSkillIcon_ = value;
		}
	}

	public int ReuseSkillVideo
	{
		get
		{
			return reuseSkillVideo_;
		}
		set
		{
			reuseSkillVideo_ = value;
		}
	}

	public int UpgradeNextId
	{
		get
		{
			return upgradeNextId_;
		}
		set
		{
			upgradeNextId_ = value;
		}
	}

	public RepeatedField<string> UpgradeDesc => upgradeDesc_;

	public int UpgradeCostMoney
	{
		get
		{
			return upgradeCostMoney_;
		}
		set
		{
			upgradeCostMoney_ = value;
		}
	}

	public RepeatedField<ItemOne> CostItem => costItem_;

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

	public int ReplaceDropId
	{
		get
		{
			return replaceDropId_;
		}
		set
		{
			replaceDropId_ = value;
		}
	}

	public int LevelId
	{
		get
		{
			return levelId_;
		}
		set
		{
			levelId_ = value;
		}
	}

	public string MappingRandomId
	{
		get
		{
			return mappingRandomId_;
		}
		set
		{
			mappingRandomId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int AttrEffectId
	{
		get
		{
			return attrEffectId_;
		}
		set
		{
			attrEffectId_ = value;
		}
	}

	public int EffectTalentId
	{
		get
		{
			return effectTalentId_;
		}
		set
		{
			effectTalentId_ = value;
		}
	}

	public string EffectTalentDesc
	{
		get
		{
			return effectTalentDesc_;
		}
		set
		{
			effectTalentDesc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int OverrideAbnormalDispIDAttacker
	{
		get
		{
			return overrideAbnormalDispIDAttacker_;
		}
		set
		{
			overrideAbnormalDispIDAttacker_ = value;
		}
	}

	public int OverrideAbnormalDispIDVictim
	{
		get
		{
			return overrideAbnormalDispIDVictim_;
		}
		set
		{
			overrideAbnormalDispIDVictim_ = value;
		}
	}

	public SoulSkillDesc()
	{
	}

	public SoulSkillDesc(SoulSkillDesc other)
		: this()
	{
		id_ = other.id_;
		skillName_ = other.skillName_;
		userResId_ = other.userResId_;
		dAPath_ = other.dAPath_;
		castEnergy_ = other.castEnergy_;
		skillId_ = other.skillId_;
		skillIdWhenLeave_ = other.skillIdWhenLeave_;
		skillIdReEnter_ = other.skillIdReEnter_;
		buffId_ = other.buffId_;
		reEnterWaitTime_ = other.reEnterWaitTime_;
		leaveFXPath_ = other.leaveFXPath_;
		reEnterFadeOutFXPath_ = other.reEnterFadeOutFXPath_;
		delayTimeWithoutLeave_ = other.delayTimeWithoutLeave_;
		cameraPreview_ = other.cameraPreview_;
		type_ = other.type_;
		mimicryMaxTime_ = other.mimicryMaxTime_;
		reuseModle_ = other.reuseModle_;
		reuseSkillIcon_ = other.reuseSkillIcon_;
		reuseSkillVideo_ = other.reuseSkillVideo_;
		upgradeNextId_ = other.upgradeNextId_;
		upgradeDesc_ = other.upgradeDesc_.Clone();
		upgradeCostMoney_ = other.upgradeCostMoney_;
		costItem_ = other.costItem_.Clone();
		localizationTag_ = other.localizationTag_;
		replaceDropId_ = other.replaceDropId_;
		levelId_ = other.levelId_;
		mappingRandomId_ = other.mappingRandomId_;
		attrEffectId_ = other.attrEffectId_;
		effectTalentId_ = other.effectTalentId_;
		effectTalentDesc_ = other.effectTalentDesc_;
		overrideAbnormalDispIDAttacker_ = other.overrideAbnormalDispIDAttacker_;
		overrideAbnormalDispIDVictim_ = other.overrideAbnormalDispIDVictim_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public SoulSkillDesc Clone()
	{
		return new SoulSkillDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as SoulSkillDesc);
	}

	public bool Equals(SoulSkillDesc other)
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
		if (SkillName != other.SkillName)
		{
			return false;
		}
		if (UserResId != other.UserResId)
		{
			return false;
		}
		if (DAPath != other.DAPath)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CastEnergy, other.CastEnergy))
		{
			return false;
		}
		if (SkillId != other.SkillId)
		{
			return false;
		}
		if (SkillIdWhenLeave != other.SkillIdWhenLeave)
		{
			return false;
		}
		if (SkillIdReEnter != other.SkillIdReEnter)
		{
			return false;
		}
		if (BuffId != other.BuffId)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ReEnterWaitTime, other.ReEnterWaitTime))
		{
			return false;
		}
		if (LeaveFXPath != other.LeaveFXPath)
		{
			return false;
		}
		if (ReEnterFadeOutFXPath != other.ReEnterFadeOutFXPath)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DelayTimeWithoutLeave, other.DelayTimeWithoutLeave))
		{
			return false;
		}
		if (CameraPreview != other.CameraPreview)
		{
			return false;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MimicryMaxTime, other.MimicryMaxTime))
		{
			return false;
		}
		if (ReuseModle != other.ReuseModle)
		{
			return false;
		}
		if (ReuseSkillIcon != other.ReuseSkillIcon)
		{
			return false;
		}
		if (ReuseSkillVideo != other.ReuseSkillVideo)
		{
			return false;
		}
		if (UpgradeNextId != other.UpgradeNextId)
		{
			return false;
		}
		if (!upgradeDesc_.Equals(other.upgradeDesc_))
		{
			return false;
		}
		if (UpgradeCostMoney != other.UpgradeCostMoney)
		{
			return false;
		}
		if (!costItem_.Equals(other.costItem_))
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
		{
			return false;
		}
		if (ReplaceDropId != other.ReplaceDropId)
		{
			return false;
		}
		if (LevelId != other.LevelId)
		{
			return false;
		}
		if (MappingRandomId != other.MappingRandomId)
		{
			return false;
		}
		if (AttrEffectId != other.AttrEffectId)
		{
			return false;
		}
		if (EffectTalentId != other.EffectTalentId)
		{
			return false;
		}
		if (EffectTalentDesc != other.EffectTalentDesc)
		{
			return false;
		}
		if (OverrideAbnormalDispIDAttacker != other.OverrideAbnormalDispIDAttacker)
		{
			return false;
		}
		if (OverrideAbnormalDispIDVictim != other.OverrideAbnormalDispIDVictim)
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
		if (SkillName.Length != 0)
		{
			num ^= SkillName.GetHashCode();
		}
		if (UserResId != 0)
		{
			num ^= UserResId.GetHashCode();
		}
		if (DAPath.Length != 0)
		{
			num ^= DAPath.GetHashCode();
		}
		if (CastEnergy != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CastEnergy);
		}
		if (SkillId != 0)
		{
			num ^= SkillId.GetHashCode();
		}
		if (SkillIdWhenLeave != 0)
		{
			num ^= SkillIdWhenLeave.GetHashCode();
		}
		if (SkillIdReEnter != 0)
		{
			num ^= SkillIdReEnter.GetHashCode();
		}
		if (BuffId != 0)
		{
			num ^= BuffId.GetHashCode();
		}
		if (ReEnterWaitTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ReEnterWaitTime);
		}
		if (LeaveFXPath.Length != 0)
		{
			num ^= LeaveFXPath.GetHashCode();
		}
		if (ReEnterFadeOutFXPath.Length != 0)
		{
			num ^= ReEnterFadeOutFXPath.GetHashCode();
		}
		if (DelayTimeWithoutLeave != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DelayTimeWithoutLeave);
		}
		if (CameraPreview.Length != 0)
		{
			num ^= CameraPreview.GetHashCode();
		}
		if (Type != SoulSkillType.MagicallyChange)
		{
			num ^= Type.GetHashCode();
		}
		if (MimicryMaxTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MimicryMaxTime);
		}
		if (ReuseModle != 0)
		{
			num ^= ReuseModle.GetHashCode();
		}
		if (ReuseSkillIcon != 0)
		{
			num ^= ReuseSkillIcon.GetHashCode();
		}
		if (ReuseSkillVideo != 0)
		{
			num ^= ReuseSkillVideo.GetHashCode();
		}
		if (UpgradeNextId != 0)
		{
			num ^= UpgradeNextId.GetHashCode();
		}
		num ^= upgradeDesc_.GetHashCode();
		if (UpgradeCostMoney != 0)
		{
			num ^= UpgradeCostMoney.GetHashCode();
		}
		num ^= costItem_.GetHashCode();
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
		}
		if (ReplaceDropId != 0)
		{
			num ^= ReplaceDropId.GetHashCode();
		}
		if (LevelId != 0)
		{
			num ^= LevelId.GetHashCode();
		}
		if (MappingRandomId.Length != 0)
		{
			num ^= MappingRandomId.GetHashCode();
		}
		if (AttrEffectId != 0)
		{
			num ^= AttrEffectId.GetHashCode();
		}
		if (EffectTalentId != 0)
		{
			num ^= EffectTalentId.GetHashCode();
		}
		if (EffectTalentDesc.Length != 0)
		{
			num ^= EffectTalentDesc.GetHashCode();
		}
		if (OverrideAbnormalDispIDAttacker != 0)
		{
			num ^= OverrideAbnormalDispIDAttacker.GetHashCode();
		}
		if (OverrideAbnormalDispIDVictim != 0)
		{
			num ^= OverrideAbnormalDispIDVictim.GetHashCode();
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
		if (SkillName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(SkillName);
		}
		if (UserResId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(UserResId);
		}
		if (DAPath.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(DAPath);
		}
		if (CastEnergy != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(CastEnergy);
		}
		if (SkillId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(SkillId);
		}
		if (SkillIdWhenLeave != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(SkillIdWhenLeave);
		}
		if (SkillIdReEnter != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(SkillIdReEnter);
		}
		if (BuffId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(BuffId);
		}
		if (ReEnterWaitTime != 0f)
		{
			output.WriteRawTag(85);
			output.WriteFloat(ReEnterWaitTime);
		}
		if (LeaveFXPath.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(LeaveFXPath);
		}
		if (ReEnterFadeOutFXPath.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(ReEnterFadeOutFXPath);
		}
		if (DelayTimeWithoutLeave != 0f)
		{
			output.WriteRawTag(109);
			output.WriteFloat(DelayTimeWithoutLeave);
		}
		if (CameraPreview.Length != 0)
		{
			output.WriteRawTag(114);
			output.WriteString(CameraPreview);
		}
		if (Type != SoulSkillType.MagicallyChange)
		{
			output.WriteRawTag(120);
			output.WriteEnum((int)Type);
		}
		if (MimicryMaxTime != 0f)
		{
			output.WriteRawTag(133, 1);
			output.WriteFloat(MimicryMaxTime);
		}
		if (ReuseModle != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(ReuseModle);
		}
		if (ReuseSkillIcon != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteInt32(ReuseSkillIcon);
		}
		if (ReuseSkillVideo != 0)
		{
			output.WriteRawTag(152, 1);
			output.WriteInt32(ReuseSkillVideo);
		}
		if (UpgradeNextId != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(UpgradeNextId);
		}
		upgradeDesc_.WriteTo(output, _repeated_upgradeDesc_codec);
		if (UpgradeCostMoney != 0)
		{
			output.WriteRawTag(176, 1);
			output.WriteInt32(UpgradeCostMoney);
		}
		costItem_.WriteTo(output, _repeated_costItem_codec);
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(192, 1);
			output.WriteInt32(LocalizationTag);
		}
		if (ReplaceDropId != 0)
		{
			output.WriteRawTag(200, 1);
			output.WriteInt32(ReplaceDropId);
		}
		if (LevelId != 0)
		{
			output.WriteRawTag(208, 1);
			output.WriteInt32(LevelId);
		}
		if (MappingRandomId.Length != 0)
		{
			output.WriteRawTag(218, 1);
			output.WriteString(MappingRandomId);
		}
		if (AttrEffectId != 0)
		{
			output.WriteRawTag(224, 1);
			output.WriteInt32(AttrEffectId);
		}
		if (EffectTalentId != 0)
		{
			output.WriteRawTag(232, 1);
			output.WriteInt32(EffectTalentId);
		}
		if (EffectTalentDesc.Length != 0)
		{
			output.WriteRawTag(242, 1);
			output.WriteString(EffectTalentDesc);
		}
		if (OverrideAbnormalDispIDAttacker != 0)
		{
			output.WriteRawTag(248, 1);
			output.WriteInt32(OverrideAbnormalDispIDAttacker);
		}
		if (OverrideAbnormalDispIDVictim != 0)
		{
			output.WriteRawTag(128, 2);
			output.WriteInt32(OverrideAbnormalDispIDVictim);
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
		if (SkillName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SkillName);
		}
		if (UserResId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UserResId);
		}
		if (DAPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DAPath);
		}
		if (CastEnergy != 0f)
		{
			num += 5;
		}
		if (SkillId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SkillId);
		}
		if (SkillIdWhenLeave != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SkillIdWhenLeave);
		}
		if (SkillIdReEnter != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SkillIdReEnter);
		}
		if (BuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffId);
		}
		if (ReEnterWaitTime != 0f)
		{
			num += 5;
		}
		if (LeaveFXPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LeaveFXPath);
		}
		if (ReEnterFadeOutFXPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ReEnterFadeOutFXPath);
		}
		if (DelayTimeWithoutLeave != 0f)
		{
			num += 5;
		}
		if (CameraPreview.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CameraPreview);
		}
		if (Type != SoulSkillType.MagicallyChange)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (MimicryMaxTime != 0f)
		{
			num += 6;
		}
		if (ReuseModle != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ReuseModle);
		}
		if (ReuseSkillIcon != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ReuseSkillIcon);
		}
		if (ReuseSkillVideo != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ReuseSkillVideo);
		}
		if (UpgradeNextId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(UpgradeNextId);
		}
		num += upgradeDesc_.CalculateSize(_repeated_upgradeDesc_codec);
		if (UpgradeCostMoney != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(UpgradeCostMoney);
		}
		num += costItem_.CalculateSize(_repeated_costItem_codec);
		if (LocalizationTag != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (ReplaceDropId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ReplaceDropId);
		}
		if (LevelId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(LevelId);
		}
		if (MappingRandomId.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(MappingRandomId);
		}
		if (AttrEffectId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(AttrEffectId);
		}
		if (EffectTalentId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(EffectTalentId);
		}
		if (EffectTalentDesc.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(EffectTalentDesc);
		}
		if (OverrideAbnormalDispIDAttacker != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(OverrideAbnormalDispIDAttacker);
		}
		if (OverrideAbnormalDispIDVictim != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(OverrideAbnormalDispIDVictim);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(SoulSkillDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.SkillName.Length != 0)
			{
				SkillName = other.SkillName;
			}
			if (other.UserResId != 0)
			{
				UserResId = other.UserResId;
			}
			if (other.DAPath.Length != 0)
			{
				DAPath = other.DAPath;
			}
			if (other.CastEnergy != 0f)
			{
				CastEnergy = other.CastEnergy;
			}
			if (other.SkillId != 0)
			{
				SkillId = other.SkillId;
			}
			if (other.SkillIdWhenLeave != 0)
			{
				SkillIdWhenLeave = other.SkillIdWhenLeave;
			}
			if (other.SkillIdReEnter != 0)
			{
				SkillIdReEnter = other.SkillIdReEnter;
			}
			if (other.BuffId != 0)
			{
				BuffId = other.BuffId;
			}
			if (other.ReEnterWaitTime != 0f)
			{
				ReEnterWaitTime = other.ReEnterWaitTime;
			}
			if (other.LeaveFXPath.Length != 0)
			{
				LeaveFXPath = other.LeaveFXPath;
			}
			if (other.ReEnterFadeOutFXPath.Length != 0)
			{
				ReEnterFadeOutFXPath = other.ReEnterFadeOutFXPath;
			}
			if (other.DelayTimeWithoutLeave != 0f)
			{
				DelayTimeWithoutLeave = other.DelayTimeWithoutLeave;
			}
			if (other.CameraPreview.Length != 0)
			{
				CameraPreview = other.CameraPreview;
			}
			if (other.Type != SoulSkillType.MagicallyChange)
			{
				Type = other.Type;
			}
			if (other.MimicryMaxTime != 0f)
			{
				MimicryMaxTime = other.MimicryMaxTime;
			}
			if (other.ReuseModle != 0)
			{
				ReuseModle = other.ReuseModle;
			}
			if (other.ReuseSkillIcon != 0)
			{
				ReuseSkillIcon = other.ReuseSkillIcon;
			}
			if (other.ReuseSkillVideo != 0)
			{
				ReuseSkillVideo = other.ReuseSkillVideo;
			}
			if (other.UpgradeNextId != 0)
			{
				UpgradeNextId = other.UpgradeNextId;
			}
			upgradeDesc_.Add(other.upgradeDesc_);
			if (other.UpgradeCostMoney != 0)
			{
				UpgradeCostMoney = other.UpgradeCostMoney;
			}
			costItem_.Add(other.costItem_);
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
			}
			if (other.ReplaceDropId != 0)
			{
				ReplaceDropId = other.ReplaceDropId;
			}
			if (other.LevelId != 0)
			{
				LevelId = other.LevelId;
			}
			if (other.MappingRandomId.Length != 0)
			{
				MappingRandomId = other.MappingRandomId;
			}
			if (other.AttrEffectId != 0)
			{
				AttrEffectId = other.AttrEffectId;
			}
			if (other.EffectTalentId != 0)
			{
				EffectTalentId = other.EffectTalentId;
			}
			if (other.EffectTalentDesc.Length != 0)
			{
				EffectTalentDesc = other.EffectTalentDesc;
			}
			if (other.OverrideAbnormalDispIDAttacker != 0)
			{
				OverrideAbnormalDispIDAttacker = other.OverrideAbnormalDispIDAttacker;
			}
			if (other.OverrideAbnormalDispIDVictim != 0)
			{
				OverrideAbnormalDispIDVictim = other.OverrideAbnormalDispIDVictim;
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
				SkillName = input.ReadString();
				break;
			case 24u:
				UserResId = input.ReadInt32();
				break;
			case 34u:
				DAPath = input.ReadString();
				break;
			case 45u:
				CastEnergy = input.ReadFloat();
				break;
			case 48u:
				SkillId = input.ReadInt32();
				break;
			case 56u:
				SkillIdWhenLeave = input.ReadInt32();
				break;
			case 64u:
				SkillIdReEnter = input.ReadInt32();
				break;
			case 72u:
				BuffId = input.ReadInt32();
				break;
			case 85u:
				ReEnterWaitTime = input.ReadFloat();
				break;
			case 90u:
				LeaveFXPath = input.ReadString();
				break;
			case 98u:
				ReEnterFadeOutFXPath = input.ReadString();
				break;
			case 109u:
				DelayTimeWithoutLeave = input.ReadFloat();
				break;
			case 114u:
				CameraPreview = input.ReadString();
				break;
			case 120u:
				Type = (SoulSkillType)input.ReadEnum();
				break;
			case 133u:
				MimicryMaxTime = input.ReadFloat();
				break;
			case 136u:
				ReuseModle = input.ReadInt32();
				break;
			case 144u:
				ReuseSkillIcon = input.ReadInt32();
				break;
			case 152u:
				ReuseSkillVideo = input.ReadInt32();
				break;
			case 160u:
				UpgradeNextId = input.ReadInt32();
				break;
			case 170u:
				upgradeDesc_.AddEntriesFrom(input, _repeated_upgradeDesc_codec);
				break;
			case 176u:
				UpgradeCostMoney = input.ReadInt32();
				break;
			case 186u:
				costItem_.AddEntriesFrom(input, _repeated_costItem_codec);
				break;
			case 192u:
				LocalizationTag = input.ReadInt32();
				break;
			case 200u:
				ReplaceDropId = input.ReadInt32();
				break;
			case 208u:
				LevelId = input.ReadInt32();
				break;
			case 218u:
				MappingRandomId = input.ReadString();
				break;
			case 224u:
				AttrEffectId = input.ReadInt32();
				break;
			case 232u:
				EffectTalentId = input.ReadInt32();
				break;
			case 242u:
				EffectTalentDesc = input.ReadString();
				break;
			case 248u:
				OverrideAbnormalDispIDAttacker = input.ReadInt32();
				break;
			case 256u:
				OverrideAbnormalDispIDVictim = input.ReadInt32();
				break;
			}
		}
	}
}
