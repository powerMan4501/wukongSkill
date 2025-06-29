using System;
using BtlB1;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class EquipDesc : IMessage<EquipDesc>, IMessage, IEquatable<EquipDesc>, IDeepCloneable<EquipDesc>
{
	private static readonly MessageParser<EquipDesc> _parser = new MessageParser<EquipDesc>(() => new EquipDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private EquipPosition equipPosition_;

	private string equipName_ = "";

	private string skeletalMesh_ = "";

	private ECharacterModularType modularType_;

	private ECharacterModularType modularTypeForCharacterAI_;

	private string attachSocketName_ = "";

	private string animBlueprintClass_ = "";

	private static readonly FieldCodec<string> _repeated_staticMesh_codec = FieldCodec.ForString(74u);

	private readonly RepeatedField<string> staticMesh_ = new RepeatedField<string>();

	private EBGUWeaponElement weaponElement_;

	private int suitId_;

	private int attrEffectId_;

	private int equipEffectId_;

	private string equipEffectDesc_ = "";

	private int defaultCombatSkillId_;

	private int isUniqueCombatSkill_;

	private int audioMappingId_;

	private int audioHitMappingId_;

	private YesNoType isFlexible_;

	private int localizationTag_;

	private YesNoType autoWear_;

	private YesNoType hideTail_;

	public static MessageParser<EquipDesc> Parser => _parser;

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

	public EquipPosition EquipPosition
	{
		get
		{
			return equipPosition_;
		}
		set
		{
			equipPosition_ = value;
		}
	}

	public string EquipName
	{
		get
		{
			return equipName_;
		}
		set
		{
			equipName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string SkeletalMesh
	{
		get
		{
			return skeletalMesh_;
		}
		set
		{
			skeletalMesh_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ECharacterModularType ModularType
	{
		get
		{
			return modularType_;
		}
		set
		{
			modularType_ = value;
		}
	}

	public ECharacterModularType ModularTypeForCharacterAI
	{
		get
		{
			return modularTypeForCharacterAI_;
		}
		set
		{
			modularTypeForCharacterAI_ = value;
		}
	}

	public string AttachSocketName
	{
		get
		{
			return attachSocketName_;
		}
		set
		{
			attachSocketName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string AnimBlueprintClass
	{
		get
		{
			return animBlueprintClass_;
		}
		set
		{
			animBlueprintClass_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<string> StaticMesh => staticMesh_;

	public EBGUWeaponElement WeaponElement
	{
		get
		{
			return weaponElement_;
		}
		set
		{
			weaponElement_ = value;
		}
	}

	public int SuitId
	{
		get
		{
			return suitId_;
		}
		set
		{
			suitId_ = value;
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

	public int EquipEffectId
	{
		get
		{
			return equipEffectId_;
		}
		set
		{
			equipEffectId_ = value;
		}
	}

	public string EquipEffectDesc
	{
		get
		{
			return equipEffectDesc_;
		}
		set
		{
			equipEffectDesc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int DefaultCombatSkillId
	{
		get
		{
			return defaultCombatSkillId_;
		}
		set
		{
			defaultCombatSkillId_ = value;
		}
	}

	public int IsUniqueCombatSkill
	{
		get
		{
			return isUniqueCombatSkill_;
		}
		set
		{
			isUniqueCombatSkill_ = value;
		}
	}

	public int AudioMappingId
	{
		get
		{
			return audioMappingId_;
		}
		set
		{
			audioMappingId_ = value;
		}
	}

	public int AudioHitMappingId
	{
		get
		{
			return audioHitMappingId_;
		}
		set
		{
			audioHitMappingId_ = value;
		}
	}

	public YesNoType IsFlexible
	{
		get
		{
			return isFlexible_;
		}
		set
		{
			isFlexible_ = value;
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

	public YesNoType AutoWear
	{
		get
		{
			return autoWear_;
		}
		set
		{
			autoWear_ = value;
		}
	}

	public YesNoType HideTail
	{
		get
		{
			return hideTail_;
		}
		set
		{
			hideTail_ = value;
		}
	}

	public EquipDesc()
	{
	}

	public EquipDesc(EquipDesc other)
		: this()
	{
		id_ = other.id_;
		equipPosition_ = other.equipPosition_;
		equipName_ = other.equipName_;
		skeletalMesh_ = other.skeletalMesh_;
		modularType_ = other.modularType_;
		modularTypeForCharacterAI_ = other.modularTypeForCharacterAI_;
		attachSocketName_ = other.attachSocketName_;
		animBlueprintClass_ = other.animBlueprintClass_;
		staticMesh_ = other.staticMesh_.Clone();
		weaponElement_ = other.weaponElement_;
		suitId_ = other.suitId_;
		attrEffectId_ = other.attrEffectId_;
		equipEffectId_ = other.equipEffectId_;
		equipEffectDesc_ = other.equipEffectDesc_;
		defaultCombatSkillId_ = other.defaultCombatSkillId_;
		isUniqueCombatSkill_ = other.isUniqueCombatSkill_;
		audioMappingId_ = other.audioMappingId_;
		audioHitMappingId_ = other.audioHitMappingId_;
		isFlexible_ = other.isFlexible_;
		localizationTag_ = other.localizationTag_;
		autoWear_ = other.autoWear_;
		hideTail_ = other.hideTail_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EquipDesc Clone()
	{
		return new EquipDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EquipDesc);
	}

	public bool Equals(EquipDesc other)
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
		if (EquipPosition != other.EquipPosition)
		{
			return false;
		}
		if (EquipName != other.EquipName)
		{
			return false;
		}
		if (SkeletalMesh != other.SkeletalMesh)
		{
			return false;
		}
		if (ModularType != other.ModularType)
		{
			return false;
		}
		if (ModularTypeForCharacterAI != other.ModularTypeForCharacterAI)
		{
			return false;
		}
		if (AttachSocketName != other.AttachSocketName)
		{
			return false;
		}
		if (AnimBlueprintClass != other.AnimBlueprintClass)
		{
			return false;
		}
		if (!staticMesh_.Equals(other.staticMesh_))
		{
			return false;
		}
		if (WeaponElement != other.WeaponElement)
		{
			return false;
		}
		if (SuitId != other.SuitId)
		{
			return false;
		}
		if (AttrEffectId != other.AttrEffectId)
		{
			return false;
		}
		if (EquipEffectId != other.EquipEffectId)
		{
			return false;
		}
		if (EquipEffectDesc != other.EquipEffectDesc)
		{
			return false;
		}
		if (DefaultCombatSkillId != other.DefaultCombatSkillId)
		{
			return false;
		}
		if (IsUniqueCombatSkill != other.IsUniqueCombatSkill)
		{
			return false;
		}
		if (AudioMappingId != other.AudioMappingId)
		{
			return false;
		}
		if (AudioHitMappingId != other.AudioHitMappingId)
		{
			return false;
		}
		if (IsFlexible != other.IsFlexible)
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
		{
			return false;
		}
		if (AutoWear != other.AutoWear)
		{
			return false;
		}
		if (HideTail != other.HideTail)
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
		if (EquipPosition != EquipPosition.Head)
		{
			num ^= EquipPosition.GetHashCode();
		}
		if (EquipName.Length != 0)
		{
			num ^= EquipName.GetHashCode();
		}
		if (SkeletalMesh.Length != 0)
		{
			num ^= SkeletalMesh.GetHashCode();
		}
		if (ModularType != ECharacterModularType.MasterPose)
		{
			num ^= ModularType.GetHashCode();
		}
		if (ModularTypeForCharacterAI != ECharacterModularType.MasterPose)
		{
			num ^= ModularTypeForCharacterAI.GetHashCode();
		}
		if (AttachSocketName.Length != 0)
		{
			num ^= AttachSocketName.GetHashCode();
		}
		if (AnimBlueprintClass.Length != 0)
		{
			num ^= AnimBlueprintClass.GetHashCode();
		}
		num ^= staticMesh_.GetHashCode();
		if (WeaponElement != EBGUWeaponElement.None)
		{
			num ^= WeaponElement.GetHashCode();
		}
		if (SuitId != 0)
		{
			num ^= SuitId.GetHashCode();
		}
		if (AttrEffectId != 0)
		{
			num ^= AttrEffectId.GetHashCode();
		}
		if (EquipEffectId != 0)
		{
			num ^= EquipEffectId.GetHashCode();
		}
		if (EquipEffectDesc.Length != 0)
		{
			num ^= EquipEffectDesc.GetHashCode();
		}
		if (DefaultCombatSkillId != 0)
		{
			num ^= DefaultCombatSkillId.GetHashCode();
		}
		if (IsUniqueCombatSkill != 0)
		{
			num ^= IsUniqueCombatSkill.GetHashCode();
		}
		if (AudioMappingId != 0)
		{
			num ^= AudioMappingId.GetHashCode();
		}
		if (AudioHitMappingId != 0)
		{
			num ^= AudioHitMappingId.GetHashCode();
		}
		if (IsFlexible != YesNoType.No)
		{
			num ^= IsFlexible.GetHashCode();
		}
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
		}
		if (AutoWear != YesNoType.No)
		{
			num ^= AutoWear.GetHashCode();
		}
		if (HideTail != YesNoType.No)
		{
			num ^= HideTail.GetHashCode();
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
		if (EquipPosition != EquipPosition.Head)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)EquipPosition);
		}
		if (EquipName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(EquipName);
		}
		if (SkeletalMesh.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(SkeletalMesh);
		}
		if (ModularType != ECharacterModularType.MasterPose)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)ModularType);
		}
		if (ModularTypeForCharacterAI != ECharacterModularType.MasterPose)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)ModularTypeForCharacterAI);
		}
		if (AttachSocketName.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(AttachSocketName);
		}
		if (AnimBlueprintClass.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(AnimBlueprintClass);
		}
		staticMesh_.WriteTo(output, _repeated_staticMesh_codec);
		if (WeaponElement != EBGUWeaponElement.None)
		{
			output.WriteRawTag(80);
			output.WriteEnum((int)WeaponElement);
		}
		if (SuitId != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(SuitId);
		}
		if (AttrEffectId != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(AttrEffectId);
		}
		if (EquipEffectId != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(EquipEffectId);
		}
		if (EquipEffectDesc.Length != 0)
		{
			output.WriteRawTag(114);
			output.WriteString(EquipEffectDesc);
		}
		if (DefaultCombatSkillId != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(DefaultCombatSkillId);
		}
		if (IsUniqueCombatSkill != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(IsUniqueCombatSkill);
		}
		if (AudioMappingId != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(AudioMappingId);
		}
		if (AudioHitMappingId != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteInt32(AudioHitMappingId);
		}
		if (IsFlexible != YesNoType.No)
		{
			output.WriteRawTag(152, 1);
			output.WriteEnum((int)IsFlexible);
		}
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(LocalizationTag);
		}
		if (AutoWear != YesNoType.No)
		{
			output.WriteRawTag(168, 1);
			output.WriteEnum((int)AutoWear);
		}
		if (HideTail != YesNoType.No)
		{
			output.WriteRawTag(176, 1);
			output.WriteEnum((int)HideTail);
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
		if (EquipPosition != EquipPosition.Head)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EquipPosition);
		}
		if (EquipName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EquipName);
		}
		if (SkeletalMesh.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SkeletalMesh);
		}
		if (ModularType != ECharacterModularType.MasterPose)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ModularType);
		}
		if (ModularTypeForCharacterAI != ECharacterModularType.MasterPose)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ModularTypeForCharacterAI);
		}
		if (AttachSocketName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AttachSocketName);
		}
		if (AnimBlueprintClass.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AnimBlueprintClass);
		}
		num += staticMesh_.CalculateSize(_repeated_staticMesh_codec);
		if (WeaponElement != EBGUWeaponElement.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)WeaponElement);
		}
		if (SuitId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SuitId);
		}
		if (AttrEffectId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AttrEffectId);
		}
		if (EquipEffectId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EquipEffectId);
		}
		if (EquipEffectDesc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EquipEffectDesc);
		}
		if (DefaultCombatSkillId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DefaultCombatSkillId);
		}
		if (IsUniqueCombatSkill != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(IsUniqueCombatSkill);
		}
		if (AudioMappingId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(AudioMappingId);
		}
		if (AudioHitMappingId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(AudioHitMappingId);
		}
		if (IsFlexible != YesNoType.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)IsFlexible);
		}
		if (LocalizationTag != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (AutoWear != YesNoType.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)AutoWear);
		}
		if (HideTail != YesNoType.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)HideTail);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EquipDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.EquipPosition != EquipPosition.Head)
			{
				EquipPosition = other.EquipPosition;
			}
			if (other.EquipName.Length != 0)
			{
				EquipName = other.EquipName;
			}
			if (other.SkeletalMesh.Length != 0)
			{
				SkeletalMesh = other.SkeletalMesh;
			}
			if (other.ModularType != ECharacterModularType.MasterPose)
			{
				ModularType = other.ModularType;
			}
			if (other.ModularTypeForCharacterAI != ECharacterModularType.MasterPose)
			{
				ModularTypeForCharacterAI = other.ModularTypeForCharacterAI;
			}
			if (other.AttachSocketName.Length != 0)
			{
				AttachSocketName = other.AttachSocketName;
			}
			if (other.AnimBlueprintClass.Length != 0)
			{
				AnimBlueprintClass = other.AnimBlueprintClass;
			}
			staticMesh_.Add(other.staticMesh_);
			if (other.WeaponElement != EBGUWeaponElement.None)
			{
				WeaponElement = other.WeaponElement;
			}
			if (other.SuitId != 0)
			{
				SuitId = other.SuitId;
			}
			if (other.AttrEffectId != 0)
			{
				AttrEffectId = other.AttrEffectId;
			}
			if (other.EquipEffectId != 0)
			{
				EquipEffectId = other.EquipEffectId;
			}
			if (other.EquipEffectDesc.Length != 0)
			{
				EquipEffectDesc = other.EquipEffectDesc;
			}
			if (other.DefaultCombatSkillId != 0)
			{
				DefaultCombatSkillId = other.DefaultCombatSkillId;
			}
			if (other.IsUniqueCombatSkill != 0)
			{
				IsUniqueCombatSkill = other.IsUniqueCombatSkill;
			}
			if (other.AudioMappingId != 0)
			{
				AudioMappingId = other.AudioMappingId;
			}
			if (other.AudioHitMappingId != 0)
			{
				AudioHitMappingId = other.AudioHitMappingId;
			}
			if (other.IsFlexible != YesNoType.No)
			{
				IsFlexible = other.IsFlexible;
			}
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
			}
			if (other.AutoWear != YesNoType.No)
			{
				AutoWear = other.AutoWear;
			}
			if (other.HideTail != YesNoType.No)
			{
				HideTail = other.HideTail;
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
			case 16u:
				EquipPosition = (EquipPosition)input.ReadEnum();
				break;
			case 26u:
				EquipName = input.ReadString();
				break;
			case 34u:
				SkeletalMesh = input.ReadString();
				break;
			case 40u:
				ModularType = (ECharacterModularType)input.ReadEnum();
				break;
			case 48u:
				ModularTypeForCharacterAI = (ECharacterModularType)input.ReadEnum();
				break;
			case 58u:
				AttachSocketName = input.ReadString();
				break;
			case 66u:
				AnimBlueprintClass = input.ReadString();
				break;
			case 74u:
				staticMesh_.AddEntriesFrom(input, _repeated_staticMesh_codec);
				break;
			case 80u:
				WeaponElement = (EBGUWeaponElement)input.ReadEnum();
				break;
			case 88u:
				SuitId = input.ReadInt32();
				break;
			case 96u:
				AttrEffectId = input.ReadInt32();
				break;
			case 104u:
				EquipEffectId = input.ReadInt32();
				break;
			case 114u:
				EquipEffectDesc = input.ReadString();
				break;
			case 120u:
				DefaultCombatSkillId = input.ReadInt32();
				break;
			case 128u:
				IsUniqueCombatSkill = input.ReadInt32();
				break;
			case 136u:
				AudioMappingId = input.ReadInt32();
				break;
			case 144u:
				AudioHitMappingId = input.ReadInt32();
				break;
			case 152u:
				IsFlexible = (YesNoType)input.ReadEnum();
				break;
			case 160u:
				LocalizationTag = input.ReadInt32();
				break;
			case 168u:
				AutoWear = (YesNoType)input.ReadEnum();
				break;
			case 176u:
				HideTail = (YesNoType)input.ReadEnum();
				break;
			}
		}
	}
}
