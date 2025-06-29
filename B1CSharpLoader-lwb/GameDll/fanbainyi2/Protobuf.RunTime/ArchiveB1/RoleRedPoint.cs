using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class RoleRedPoint : IMessage<RoleRedPoint>, IMessage, IEquatable<RoleRedPoint>, IDeepCloneable<RoleRedPoint>
{
	private static readonly MessageParser<RoleRedPoint> _parser = new MessageParser<RoleRedPoint>(() => new RoleRedPoint());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<int> _repeated_itemList_codec = FieldCodec.ForInt32(10u);

	private readonly RepeatedField<int> itemList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_equipList_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> equipList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_spellList_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> spellList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_attrList_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> attrList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_shopItemList_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> shopItemList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_collectionList_codec = FieldCodec.ForInt32(58u);

	private readonly RepeatedField<int> collectionList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_legacyList_codec = FieldCodec.ForInt32(66u);

	private readonly RepeatedField<int> legacyList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_legacyTalentList_codec = FieldCodec.ForInt32(74u);

	private readonly RepeatedField<int> legacyTalentList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_meditationList_codec = FieldCodec.ForInt32(90u);

	private readonly RepeatedField<int> meditationList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_cardStoryList_codec = FieldCodec.ForInt32(98u);

	private readonly RepeatedField<int> cardStoryList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_soulSkillList_codec = FieldCodec.ForInt32(114u);

	private readonly RepeatedField<int> soulSkillList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_canActivateEquipList_codec = FieldCodec.ForInt32(122u);

	private readonly RepeatedField<int> canActivateEquipList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_recipeList_codec = FieldCodec.ForInt32(130u);

	private readonly RepeatedField<int> recipeList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_newLegacyList_codec = FieldCodec.ForInt32(138u);

	private readonly RepeatedField<int> newLegacyList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_legacyTalentPointList_codec = FieldCodec.ForInt32(146u);

	private readonly RepeatedField<int> legacyTalentPointList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_canBuildWeaponList_codec = FieldCodec.ForInt32(162u);

	private readonly RepeatedField<int> canBuildWeaponList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_shrineSpellList_codec = FieldCodec.ForInt32(170u);

	private readonly RepeatedField<int> shrineSpellList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_interactionFuncList_codec = FieldCodec.ForInt32(178u);

	private readonly RepeatedField<int> interactionFuncList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_refightIdList_codec = FieldCodec.ForInt32(186u);

	private readonly RepeatedField<int> refightIdList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_continuousFightIdList_codec = FieldCodec.ForInt32(194u);

	private readonly RepeatedField<int> continuousFightIdList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_refightRecordIdList_codec = FieldCodec.ForInt32(210u);

	private readonly RepeatedField<int> refightRecordIdList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_continuousFightRecordIdList_codec = FieldCodec.ForInt32(218u);

	private readonly RepeatedField<int> continuousFightRecordIdList_ = new RepeatedField<int>();

	public static MessageParser<RoleRedPoint> Parser => _parser;

	public RepeatedField<int> ItemList => itemList_;

	public RepeatedField<int> EquipList => equipList_;

	public RepeatedField<int> SpellList => spellList_;

	public RepeatedField<int> AttrList => attrList_;

	public RepeatedField<int> ShopItemList => shopItemList_;

	public RepeatedField<int> CollectionList => collectionList_;

	public RepeatedField<int> LegacyList => legacyList_;

	public RepeatedField<int> LegacyTalentList => legacyTalentList_;

	public RepeatedField<int> MeditationList => meditationList_;

	public RepeatedField<int> CardStoryList => cardStoryList_;

	public RepeatedField<int> SoulSkillList => soulSkillList_;

	public RepeatedField<int> CanActivateEquipList => canActivateEquipList_;

	public RepeatedField<int> RecipeList => recipeList_;

	public RepeatedField<int> NewLegacyList => newLegacyList_;

	public RepeatedField<int> LegacyTalentPointList => legacyTalentPointList_;

	public RepeatedField<int> CanBuildWeaponList => canBuildWeaponList_;

	public RepeatedField<int> ShrineSpellList => shrineSpellList_;

	public RepeatedField<int> InteractionFuncList => interactionFuncList_;

	public RepeatedField<int> RefightIdList => refightIdList_;

	public RepeatedField<int> ContinuousFightIdList => continuousFightIdList_;

	public RepeatedField<int> RefightRecordIdList => refightRecordIdList_;

	public RepeatedField<int> ContinuousFightRecordIdList => continuousFightRecordIdList_;

	public RoleRedPoint()
	{
	}

	public RoleRedPoint(RoleRedPoint other)
		: this()
	{
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

	public RoleRedPoint Clone()
	{
		return new RoleRedPoint(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleRedPoint);
	}

	public bool Equals(RoleRedPoint other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
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

	public void MergeFrom(RoleRedPoint other)
	{
		if (other != null)
		{
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
			case 10u:
				itemList_.AddEntriesFrom(input, _repeated_itemList_codec);
				break;
			case 16u:
			case 18u:
				equipList_.AddEntriesFrom(input, _repeated_equipList_codec);
				break;
			case 24u:
			case 26u:
				spellList_.AddEntriesFrom(input, _repeated_spellList_codec);
				break;
			case 32u:
			case 34u:
				attrList_.AddEntriesFrom(input, _repeated_attrList_codec);
				break;
			case 40u:
			case 42u:
				shopItemList_.AddEntriesFrom(input, _repeated_shopItemList_codec);
				break;
			case 56u:
			case 58u:
				collectionList_.AddEntriesFrom(input, _repeated_collectionList_codec);
				break;
			case 64u:
			case 66u:
				legacyList_.AddEntriesFrom(input, _repeated_legacyList_codec);
				break;
			case 72u:
			case 74u:
				legacyTalentList_.AddEntriesFrom(input, _repeated_legacyTalentList_codec);
				break;
			case 88u:
			case 90u:
				meditationList_.AddEntriesFrom(input, _repeated_meditationList_codec);
				break;
			case 96u:
			case 98u:
				cardStoryList_.AddEntriesFrom(input, _repeated_cardStoryList_codec);
				break;
			case 112u:
			case 114u:
				soulSkillList_.AddEntriesFrom(input, _repeated_soulSkillList_codec);
				break;
			case 120u:
			case 122u:
				canActivateEquipList_.AddEntriesFrom(input, _repeated_canActivateEquipList_codec);
				break;
			case 128u:
			case 130u:
				recipeList_.AddEntriesFrom(input, _repeated_recipeList_codec);
				break;
			case 136u:
			case 138u:
				newLegacyList_.AddEntriesFrom(input, _repeated_newLegacyList_codec);
				break;
			case 144u:
			case 146u:
				legacyTalentPointList_.AddEntriesFrom(input, _repeated_legacyTalentPointList_codec);
				break;
			case 160u:
			case 162u:
				canBuildWeaponList_.AddEntriesFrom(input, _repeated_canBuildWeaponList_codec);
				break;
			case 168u:
			case 170u:
				shrineSpellList_.AddEntriesFrom(input, _repeated_shrineSpellList_codec);
				break;
			case 176u:
			case 178u:
				interactionFuncList_.AddEntriesFrom(input, _repeated_interactionFuncList_codec);
				break;
			case 184u:
			case 186u:
				refightIdList_.AddEntriesFrom(input, _repeated_refightIdList_codec);
				break;
			case 192u:
			case 194u:
				continuousFightIdList_.AddEntriesFrom(input, _repeated_continuousFightIdList_codec);
				break;
			case 208u:
			case 210u:
				refightRecordIdList_.AddEntriesFrom(input, _repeated_refightRecordIdList_codec);
				break;
			case 216u:
			case 218u:
				continuousFightRecordIdList_.AddEntriesFrom(input, _repeated_continuousFightRecordIdList_codec);
				break;
			}
		}
	}
}
