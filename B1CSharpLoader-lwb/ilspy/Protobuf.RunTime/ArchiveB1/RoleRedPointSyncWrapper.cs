using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace ArchiveB1;

public sealed class RoleRedPointSyncWrapper : IMessage<RoleRedPointSyncWrapper>, IMessage, IEquatable<RoleRedPointSyncWrapper>, IDeepCloneable<RoleRedPointSyncWrapper>
{
	private static readonly MessageParser<RoleRedPointSyncWrapper> _parser = new MessageParser<RoleRedPointSyncWrapper>(() => new RoleRedPointSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_itemList_codec = FieldCodec.ForMessage(26u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> itemList_ = new RepeatedField<Int32SyncWrapper>();

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_equipList_codec = FieldCodec.ForMessage(34u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> equipList_ = new RepeatedField<Int32SyncWrapper>();

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_spellList_codec = FieldCodec.ForMessage(42u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> spellList_ = new RepeatedField<Int32SyncWrapper>();

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_attrList_codec = FieldCodec.ForMessage(50u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> attrList_ = new RepeatedField<Int32SyncWrapper>();

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_shopItemList_codec = FieldCodec.ForMessage(58u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> shopItemList_ = new RepeatedField<Int32SyncWrapper>();

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_collectionList_codec = FieldCodec.ForMessage(74u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> collectionList_ = new RepeatedField<Int32SyncWrapper>();

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_legacyList_codec = FieldCodec.ForMessage(82u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> legacyList_ = new RepeatedField<Int32SyncWrapper>();

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_legacyTalentList_codec = FieldCodec.ForMessage(90u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> legacyTalentList_ = new RepeatedField<Int32SyncWrapper>();

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_meditationList_codec = FieldCodec.ForMessage(106u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> meditationList_ = new RepeatedField<Int32SyncWrapper>();

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_cardStoryList_codec = FieldCodec.ForMessage(114u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> cardStoryList_ = new RepeatedField<Int32SyncWrapper>();

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_soulSkillList_codec = FieldCodec.ForMessage(130u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> soulSkillList_ = new RepeatedField<Int32SyncWrapper>();

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_canActivateEquipList_codec = FieldCodec.ForMessage(138u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> canActivateEquipList_ = new RepeatedField<Int32SyncWrapper>();

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_recipeList_codec = FieldCodec.ForMessage(146u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> recipeList_ = new RepeatedField<Int32SyncWrapper>();

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_newLegacyList_codec = FieldCodec.ForMessage(154u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> newLegacyList_ = new RepeatedField<Int32SyncWrapper>();

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_legacyTalentPointList_codec = FieldCodec.ForMessage(162u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> legacyTalentPointList_ = new RepeatedField<Int32SyncWrapper>();

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_canBuildWeaponList_codec = FieldCodec.ForMessage(178u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> canBuildWeaponList_ = new RepeatedField<Int32SyncWrapper>();

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_shrineSpellList_codec = FieldCodec.ForMessage(186u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> shrineSpellList_ = new RepeatedField<Int32SyncWrapper>();

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_interactionFuncList_codec = FieldCodec.ForMessage(194u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> interactionFuncList_ = new RepeatedField<Int32SyncWrapper>();

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_refightIdList_codec = FieldCodec.ForMessage(202u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> refightIdList_ = new RepeatedField<Int32SyncWrapper>();

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_continuousFightIdList_codec = FieldCodec.ForMessage(210u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> continuousFightIdList_ = new RepeatedField<Int32SyncWrapper>();

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_refightRecordIdList_codec = FieldCodec.ForMessage(226u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> refightRecordIdList_ = new RepeatedField<Int32SyncWrapper>();

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_continuousFightRecordIdList_codec = FieldCodec.ForMessage(234u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> continuousFightRecordIdList_ = new RepeatedField<Int32SyncWrapper>();

	public static MessageParser<RoleRedPointSyncWrapper> Parser => _parser;

	public int SyncFlag
	{
		get
		{
			return syncFlag_;
		}
		set
		{
			syncFlag_ = value;
		}
	}

	public int SyncIdx
	{
		get
		{
			return syncIdx_;
		}
		set
		{
			syncIdx_ = value;
		}
	}

	public RepeatedField<Int32SyncWrapper> ItemList => itemList_;

	public RepeatedField<Int32SyncWrapper> EquipList => equipList_;

	public RepeatedField<Int32SyncWrapper> SpellList => spellList_;

	public RepeatedField<Int32SyncWrapper> AttrList => attrList_;

	public RepeatedField<Int32SyncWrapper> ShopItemList => shopItemList_;

	public RepeatedField<Int32SyncWrapper> CollectionList => collectionList_;

	public RepeatedField<Int32SyncWrapper> LegacyList => legacyList_;

	public RepeatedField<Int32SyncWrapper> LegacyTalentList => legacyTalentList_;

	public RepeatedField<Int32SyncWrapper> MeditationList => meditationList_;

	public RepeatedField<Int32SyncWrapper> CardStoryList => cardStoryList_;

	public RepeatedField<Int32SyncWrapper> SoulSkillList => soulSkillList_;

	public RepeatedField<Int32SyncWrapper> CanActivateEquipList => canActivateEquipList_;

	public RepeatedField<Int32SyncWrapper> RecipeList => recipeList_;

	public RepeatedField<Int32SyncWrapper> NewLegacyList => newLegacyList_;

	public RepeatedField<Int32SyncWrapper> LegacyTalentPointList => legacyTalentPointList_;

	public RepeatedField<Int32SyncWrapper> CanBuildWeaponList => canBuildWeaponList_;

	public RepeatedField<Int32SyncWrapper> ShrineSpellList => shrineSpellList_;

	public RepeatedField<Int32SyncWrapper> InteractionFuncList => interactionFuncList_;

	public RepeatedField<Int32SyncWrapper> RefightIdList => refightIdList_;

	public RepeatedField<Int32SyncWrapper> ContinuousFightIdList => continuousFightIdList_;

	public RepeatedField<Int32SyncWrapper> RefightRecordIdList => refightRecordIdList_;

	public RepeatedField<Int32SyncWrapper> ContinuousFightRecordIdList => continuousFightRecordIdList_;

	public RoleRedPointSyncWrapper()
	{
	}

	public RoleRedPointSyncWrapper(RoleRedPointSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		itemList_ = other.itemList_.Clone();
		equipList_ = other.equipList_.Clone();
		spellList_ = other.spellList_.Clone();
		attrList_ = other.attrList_.Clone();
		shopItemList_ = other.shopItemList_.Clone();
		collectionList_ = other.collectionList_.Clone();
		legacyList_ = other.legacyList_.Clone();
		legacyTalentList_ = other.legacyTalentList_.Clone();
		meditationList_ = other.meditationList_.Clone();
		cardStoryList_ = other.cardStoryList_.Clone();
		soulSkillList_ = other.soulSkillList_.Clone();
		canActivateEquipList_ = other.canActivateEquipList_.Clone();
		recipeList_ = other.recipeList_.Clone();
		newLegacyList_ = other.newLegacyList_.Clone();
		legacyTalentPointList_ = other.legacyTalentPointList_.Clone();
		canBuildWeaponList_ = other.canBuildWeaponList_.Clone();
		shrineSpellList_ = other.shrineSpellList_.Clone();
		interactionFuncList_ = other.interactionFuncList_.Clone();
		refightIdList_ = other.refightIdList_.Clone();
		continuousFightIdList_ = other.continuousFightIdList_.Clone();
		refightRecordIdList_ = other.refightRecordIdList_.Clone();
		continuousFightRecordIdList_ = other.continuousFightRecordIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleRedPointSyncWrapper Clone()
	{
		return new RoleRedPointSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleRedPointSyncWrapper);
	}

	public bool Equals(RoleRedPointSyncWrapper other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SyncFlag != other.SyncFlag)
		{
			return false;
		}
		if (SyncIdx != other.SyncIdx)
		{
			return false;
		}
		if (!itemList_.Equals(other.itemList_))
		{
			return false;
		}
		if (!equipList_.Equals(other.equipList_))
		{
			return false;
		}
		if (!spellList_.Equals(other.spellList_))
		{
			return false;
		}
		if (!attrList_.Equals(other.attrList_))
		{
			return false;
		}
		if (!shopItemList_.Equals(other.shopItemList_))
		{
			return false;
		}
		if (!collectionList_.Equals(other.collectionList_))
		{
			return false;
		}
		if (!legacyList_.Equals(other.legacyList_))
		{
			return false;
		}
		if (!legacyTalentList_.Equals(other.legacyTalentList_))
		{
			return false;
		}
		if (!meditationList_.Equals(other.meditationList_))
		{
			return false;
		}
		if (!cardStoryList_.Equals(other.cardStoryList_))
		{
			return false;
		}
		if (!soulSkillList_.Equals(other.soulSkillList_))
		{
			return false;
		}
		if (!canActivateEquipList_.Equals(other.canActivateEquipList_))
		{
			return false;
		}
		if (!recipeList_.Equals(other.recipeList_))
		{
			return false;
		}
		if (!newLegacyList_.Equals(other.newLegacyList_))
		{
			return false;
		}
		if (!legacyTalentPointList_.Equals(other.legacyTalentPointList_))
		{
			return false;
		}
		if (!canBuildWeaponList_.Equals(other.canBuildWeaponList_))
		{
			return false;
		}
		if (!shrineSpellList_.Equals(other.shrineSpellList_))
		{
			return false;
		}
		if (!interactionFuncList_.Equals(other.interactionFuncList_))
		{
			return false;
		}
		if (!refightIdList_.Equals(other.refightIdList_))
		{
			return false;
		}
		if (!continuousFightIdList_.Equals(other.continuousFightIdList_))
		{
			return false;
		}
		if (!refightRecordIdList_.Equals(other.refightRecordIdList_))
		{
			return false;
		}
		if (!continuousFightRecordIdList_.Equals(other.continuousFightRecordIdList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SyncFlag != 0)
		{
			num ^= SyncFlag.GetHashCode();
		}
		if (SyncIdx != 0)
		{
			num ^= SyncIdx.GetHashCode();
		}
		num ^= itemList_.GetHashCode();
		num ^= equipList_.GetHashCode();
		num ^= spellList_.GetHashCode();
		num ^= attrList_.GetHashCode();
		num ^= shopItemList_.GetHashCode();
		num ^= collectionList_.GetHashCode();
		num ^= legacyList_.GetHashCode();
		num ^= legacyTalentList_.GetHashCode();
		num ^= meditationList_.GetHashCode();
		num ^= cardStoryList_.GetHashCode();
		num ^= soulSkillList_.GetHashCode();
		num ^= canActivateEquipList_.GetHashCode();
		num ^= recipeList_.GetHashCode();
		num ^= newLegacyList_.GetHashCode();
		num ^= legacyTalentPointList_.GetHashCode();
		num ^= canBuildWeaponList_.GetHashCode();
		num ^= shrineSpellList_.GetHashCode();
		num ^= interactionFuncList_.GetHashCode();
		num ^= refightIdList_.GetHashCode();
		num ^= continuousFightIdList_.GetHashCode();
		num ^= refightRecordIdList_.GetHashCode();
		num ^= continuousFightRecordIdList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SyncFlag != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SyncIdx);
		}
		itemList_.WriteTo(output, _repeated_itemList_codec);
		equipList_.WriteTo(output, _repeated_equipList_codec);
		spellList_.WriteTo(output, _repeated_spellList_codec);
		attrList_.WriteTo(output, _repeated_attrList_codec);
		shopItemList_.WriteTo(output, _repeated_shopItemList_codec);
		collectionList_.WriteTo(output, _repeated_collectionList_codec);
		legacyList_.WriteTo(output, _repeated_legacyList_codec);
		legacyTalentList_.WriteTo(output, _repeated_legacyTalentList_codec);
		meditationList_.WriteTo(output, _repeated_meditationList_codec);
		cardStoryList_.WriteTo(output, _repeated_cardStoryList_codec);
		soulSkillList_.WriteTo(output, _repeated_soulSkillList_codec);
		canActivateEquipList_.WriteTo(output, _repeated_canActivateEquipList_codec);
		recipeList_.WriteTo(output, _repeated_recipeList_codec);
		newLegacyList_.WriteTo(output, _repeated_newLegacyList_codec);
		legacyTalentPointList_.WriteTo(output, _repeated_legacyTalentPointList_codec);
		canBuildWeaponList_.WriteTo(output, _repeated_canBuildWeaponList_codec);
		shrineSpellList_.WriteTo(output, _repeated_shrineSpellList_codec);
		interactionFuncList_.WriteTo(output, _repeated_interactionFuncList_codec);
		refightIdList_.WriteTo(output, _repeated_refightIdList_codec);
		continuousFightIdList_.WriteTo(output, _repeated_continuousFightIdList_codec);
		refightRecordIdList_.WriteTo(output, _repeated_refightRecordIdList_codec);
		continuousFightRecordIdList_.WriteTo(output, _repeated_continuousFightRecordIdList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SyncFlag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncIdx);
		}
		num += itemList_.CalculateSize(_repeated_itemList_codec);
		num += equipList_.CalculateSize(_repeated_equipList_codec);
		num += spellList_.CalculateSize(_repeated_spellList_codec);
		num += attrList_.CalculateSize(_repeated_attrList_codec);
		num += shopItemList_.CalculateSize(_repeated_shopItemList_codec);
		num += collectionList_.CalculateSize(_repeated_collectionList_codec);
		num += legacyList_.CalculateSize(_repeated_legacyList_codec);
		num += legacyTalentList_.CalculateSize(_repeated_legacyTalentList_codec);
		num += meditationList_.CalculateSize(_repeated_meditationList_codec);
		num += cardStoryList_.CalculateSize(_repeated_cardStoryList_codec);
		num += soulSkillList_.CalculateSize(_repeated_soulSkillList_codec);
		num += canActivateEquipList_.CalculateSize(_repeated_canActivateEquipList_codec);
		num += recipeList_.CalculateSize(_repeated_recipeList_codec);
		num += newLegacyList_.CalculateSize(_repeated_newLegacyList_codec);
		num += legacyTalentPointList_.CalculateSize(_repeated_legacyTalentPointList_codec);
		num += canBuildWeaponList_.CalculateSize(_repeated_canBuildWeaponList_codec);
		num += shrineSpellList_.CalculateSize(_repeated_shrineSpellList_codec);
		num += interactionFuncList_.CalculateSize(_repeated_interactionFuncList_codec);
		num += refightIdList_.CalculateSize(_repeated_refightIdList_codec);
		num += continuousFightIdList_.CalculateSize(_repeated_continuousFightIdList_codec);
		num += refightRecordIdList_.CalculateSize(_repeated_refightRecordIdList_codec);
		num += continuousFightRecordIdList_.CalculateSize(_repeated_continuousFightRecordIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleRedPointSyncWrapper other)
	{
		if (other != null)
		{
			if (other.SyncFlag != 0)
			{
				SyncFlag = other.SyncFlag;
			}
			if (other.SyncIdx != 0)
			{
				SyncIdx = other.SyncIdx;
			}
			itemList_.Add(other.itemList_);
			equipList_.Add(other.equipList_);
			spellList_.Add(other.spellList_);
			attrList_.Add(other.attrList_);
			shopItemList_.Add(other.shopItemList_);
			collectionList_.Add(other.collectionList_);
			legacyList_.Add(other.legacyList_);
			legacyTalentList_.Add(other.legacyTalentList_);
			meditationList_.Add(other.meditationList_);
			cardStoryList_.Add(other.cardStoryList_);
			soulSkillList_.Add(other.soulSkillList_);
			canActivateEquipList_.Add(other.canActivateEquipList_);
			recipeList_.Add(other.recipeList_);
			newLegacyList_.Add(other.newLegacyList_);
			legacyTalentPointList_.Add(other.legacyTalentPointList_);
			canBuildWeaponList_.Add(other.canBuildWeaponList_);
			shrineSpellList_.Add(other.shrineSpellList_);
			interactionFuncList_.Add(other.interactionFuncList_);
			refightIdList_.Add(other.refightIdList_);
			continuousFightIdList_.Add(other.continuousFightIdList_);
			refightRecordIdList_.Add(other.refightRecordIdList_);
			continuousFightRecordIdList_.Add(other.continuousFightRecordIdList_);
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
				SyncFlag = input.ReadInt32();
				break;
			case 16u:
				SyncIdx = input.ReadInt32();
				break;
			case 26u:
				itemList_.AddEntriesFrom(input, _repeated_itemList_codec);
				break;
			case 34u:
				equipList_.AddEntriesFrom(input, _repeated_equipList_codec);
				break;
			case 42u:
				spellList_.AddEntriesFrom(input, _repeated_spellList_codec);
				break;
			case 50u:
				attrList_.AddEntriesFrom(input, _repeated_attrList_codec);
				break;
			case 58u:
				shopItemList_.AddEntriesFrom(input, _repeated_shopItemList_codec);
				break;
			case 74u:
				collectionList_.AddEntriesFrom(input, _repeated_collectionList_codec);
				break;
			case 82u:
				legacyList_.AddEntriesFrom(input, _repeated_legacyList_codec);
				break;
			case 90u:
				legacyTalentList_.AddEntriesFrom(input, _repeated_legacyTalentList_codec);
				break;
			case 106u:
				meditationList_.AddEntriesFrom(input, _repeated_meditationList_codec);
				break;
			case 114u:
				cardStoryList_.AddEntriesFrom(input, _repeated_cardStoryList_codec);
				break;
			case 130u:
				soulSkillList_.AddEntriesFrom(input, _repeated_soulSkillList_codec);
				break;
			case 138u:
				canActivateEquipList_.AddEntriesFrom(input, _repeated_canActivateEquipList_codec);
				break;
			case 146u:
				recipeList_.AddEntriesFrom(input, _repeated_recipeList_codec);
				break;
			case 154u:
				newLegacyList_.AddEntriesFrom(input, _repeated_newLegacyList_codec);
				break;
			case 162u:
				legacyTalentPointList_.AddEntriesFrom(input, _repeated_legacyTalentPointList_codec);
				break;
			case 178u:
				canBuildWeaponList_.AddEntriesFrom(input, _repeated_canBuildWeaponList_codec);
				break;
			case 186u:
				shrineSpellList_.AddEntriesFrom(input, _repeated_shrineSpellList_codec);
				break;
			case 194u:
				interactionFuncList_.AddEntriesFrom(input, _repeated_interactionFuncList_codec);
				break;
			case 202u:
				refightIdList_.AddEntriesFrom(input, _repeated_refightIdList_codec);
				break;
			case 210u:
				continuousFightIdList_.AddEntriesFrom(input, _repeated_continuousFightIdList_codec);
				break;
			case 226u:
				refightRecordIdList_.AddEntriesFrom(input, _repeated_refightRecordIdList_codec);
				break;
			case 234u:
				continuousFightRecordIdList_.AddEntriesFrom(input, _repeated_continuousFightRecordIdList_codec);
				break;
			}
		}
	}
}
