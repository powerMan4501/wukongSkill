using System;
using BtlB1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace ArchiveB1;

public sealed class ActorWearSyncWrapper : IMessage<ActorWearSyncWrapper>, IMessage, IEquatable<ActorWearSyncWrapper>, IDeepCloneable<ActorWearSyncWrapper>
{
	private static readonly MessageParser<ActorWearSyncWrapper> _parser = new MessageParser<ActorWearSyncWrapper>(() => new ActorWearSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private static readonly FieldCodec<WearEquipSyncWrapper> _repeated_equipList_codec = FieldCodec.ForMessage(26u, WearEquipSyncWrapper.Parser);

	private readonly RepeatedField<WearEquipSyncWrapper> equipList_ = new RepeatedField<WearEquipSyncWrapper>();

	private static readonly FieldCodec<ShortcutItemSyncWrapper> _repeated_shortcutsList_codec = FieldCodec.ForMessage(34u, ShortcutItemSyncWrapper.Parser);

	private readonly RepeatedField<ShortcutItemSyncWrapper> shortcutsList_ = new RepeatedField<ShortcutItemSyncWrapper>();

	private static readonly FieldCodec<SpellItemSyncWrapper> _repeated_spellList_codec = FieldCodec.ForMessage(42u, SpellItemSyncWrapper.Parser);

	private readonly RepeatedField<SpellItemSyncWrapper> spellList_ = new RepeatedField<SpellItemSyncWrapper>();

	private SpellTypeSyncWrapper defaultSpellType_;

	private Int32SyncWrapper wineId_;

	private StanceSyncWrapper stance_;

	private WearSoulSkillSyncWrapper wearSoulSkill_;

	private WearAccessorySyncWrapper wearAccessory_;

	public static MessageParser<ActorWearSyncWrapper> Parser => _parser;

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

	public RepeatedField<WearEquipSyncWrapper> EquipList => equipList_;

	public RepeatedField<ShortcutItemSyncWrapper> ShortcutsList => shortcutsList_;

	public RepeatedField<SpellItemSyncWrapper> SpellList => spellList_;

	public SpellTypeSyncWrapper DefaultSpellType
	{
		get
		{
			return defaultSpellType_;
		}
		set
		{
			defaultSpellType_ = value;
		}
	}

	public Int32SyncWrapper WineId
	{
		get
		{
			return wineId_;
		}
		set
		{
			wineId_ = value;
		}
	}

	public StanceSyncWrapper Stance
	{
		get
		{
			return stance_;
		}
		set
		{
			stance_ = value;
		}
	}

	public WearSoulSkillSyncWrapper WearSoulSkill
	{
		get
		{
			return wearSoulSkill_;
		}
		set
		{
			wearSoulSkill_ = value;
		}
	}

	public WearAccessorySyncWrapper WearAccessory
	{
		get
		{
			return wearAccessory_;
		}
		set
		{
			wearAccessory_ = value;
		}
	}

	public ActorWearSyncWrapper()
	{
	}

	public ActorWearSyncWrapper(ActorWearSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		equipList_ = other.equipList_.Clone();
		shortcutsList_ = other.shortcutsList_.Clone();
		spellList_ = other.spellList_.Clone();
		defaultSpellType_ = ((other.defaultSpellType_ != null) ? other.defaultSpellType_.Clone() : null);
		wineId_ = ((other.wineId_ != null) ? other.wineId_.Clone() : null);
		stance_ = ((other.stance_ != null) ? other.stance_.Clone() : null);
		wearSoulSkill_ = ((other.wearSoulSkill_ != null) ? other.wearSoulSkill_.Clone() : null);
		wearAccessory_ = ((other.wearAccessory_ != null) ? other.wearAccessory_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ActorWearSyncWrapper Clone()
	{
		return new ActorWearSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ActorWearSyncWrapper);
	}

	public bool Equals(ActorWearSyncWrapper other)
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
		if (!equipList_.Equals(other.equipList_))
		{
			return false;
		}
		if (!shortcutsList_.Equals(other.shortcutsList_))
		{
			return false;
		}
		if (!spellList_.Equals(other.spellList_))
		{
			return false;
		}
		if (!object.Equals(DefaultSpellType, other.DefaultSpellType))
		{
			return false;
		}
		if (!object.Equals(WineId, other.WineId))
		{
			return false;
		}
		if (!object.Equals(Stance, other.Stance))
		{
			return false;
		}
		if (!object.Equals(WearSoulSkill, other.WearSoulSkill))
		{
			return false;
		}
		if (!object.Equals(WearAccessory, other.WearAccessory))
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
		num ^= equipList_.GetHashCode();
		num ^= shortcutsList_.GetHashCode();
		num ^= spellList_.GetHashCode();
		if (defaultSpellType_ != null)
		{
			num ^= DefaultSpellType.GetHashCode();
		}
		if (wineId_ != null)
		{
			num ^= WineId.GetHashCode();
		}
		if (stance_ != null)
		{
			num ^= Stance.GetHashCode();
		}
		if (wearSoulSkill_ != null)
		{
			num ^= WearSoulSkill.GetHashCode();
		}
		if (wearAccessory_ != null)
		{
			num ^= WearAccessory.GetHashCode();
		}
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
		equipList_.WriteTo(output, _repeated_equipList_codec);
		shortcutsList_.WriteTo(output, _repeated_shortcutsList_codec);
		spellList_.WriteTo(output, _repeated_spellList_codec);
		if (defaultSpellType_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(DefaultSpellType);
		}
		if (wineId_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(WineId);
		}
		if (stance_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(Stance);
		}
		if (wearSoulSkill_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(WearSoulSkill);
		}
		if (wearAccessory_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(WearAccessory);
		}
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
		num += equipList_.CalculateSize(_repeated_equipList_codec);
		num += shortcutsList_.CalculateSize(_repeated_shortcutsList_codec);
		num += spellList_.CalculateSize(_repeated_spellList_codec);
		if (defaultSpellType_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DefaultSpellType);
		}
		if (wineId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(WineId);
		}
		if (stance_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Stance);
		}
		if (wearSoulSkill_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(WearSoulSkill);
		}
		if (wearAccessory_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(WearAccessory);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ActorWearSyncWrapper other)
	{
		if (other == null)
		{
			return;
		}
		if (other.SyncFlag != 0)
		{
			SyncFlag = other.SyncFlag;
		}
		if (other.SyncIdx != 0)
		{
			SyncIdx = other.SyncIdx;
		}
		equipList_.Add(other.equipList_);
		shortcutsList_.Add(other.shortcutsList_);
		spellList_.Add(other.spellList_);
		if (other.defaultSpellType_ != null)
		{
			if (defaultSpellType_ == null)
			{
				DefaultSpellType = new SpellTypeSyncWrapper();
			}
			DefaultSpellType.MergeFrom(other.DefaultSpellType);
		}
		if (other.wineId_ != null)
		{
			if (wineId_ == null)
			{
				WineId = new Int32SyncWrapper();
			}
			WineId.MergeFrom(other.WineId);
		}
		if (other.stance_ != null)
		{
			if (stance_ == null)
			{
				Stance = new StanceSyncWrapper();
			}
			Stance.MergeFrom(other.Stance);
		}
		if (other.wearSoulSkill_ != null)
		{
			if (wearSoulSkill_ == null)
			{
				WearSoulSkill = new WearSoulSkillSyncWrapper();
			}
			WearSoulSkill.MergeFrom(other.WearSoulSkill);
		}
		if (other.wearAccessory_ != null)
		{
			if (wearAccessory_ == null)
			{
				WearAccessory = new WearAccessorySyncWrapper();
			}
			WearAccessory.MergeFrom(other.WearAccessory);
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
				SyncFlag = input.ReadInt32();
				break;
			case 16u:
				SyncIdx = input.ReadInt32();
				break;
			case 26u:
				equipList_.AddEntriesFrom(input, _repeated_equipList_codec);
				break;
			case 34u:
				shortcutsList_.AddEntriesFrom(input, _repeated_shortcutsList_codec);
				break;
			case 42u:
				spellList_.AddEntriesFrom(input, _repeated_spellList_codec);
				break;
			case 58u:
				if (defaultSpellType_ == null)
				{
					DefaultSpellType = new SpellTypeSyncWrapper();
				}
				input.ReadMessage(DefaultSpellType);
				break;
			case 66u:
				if (wineId_ == null)
				{
					WineId = new Int32SyncWrapper();
				}
				input.ReadMessage(WineId);
				break;
			case 74u:
				if (stance_ == null)
				{
					Stance = new StanceSyncWrapper();
				}
				input.ReadMessage(Stance);
				break;
			case 90u:
				if (wearSoulSkill_ == null)
				{
					WearSoulSkill = new WearSoulSkillSyncWrapper();
				}
				input.ReadMessage(WearSoulSkill);
				break;
			case 98u:
				if (wearAccessory_ == null)
				{
					WearAccessory = new WearAccessorySyncWrapper();
				}
				input.ReadMessage(WearAccessory);
				break;
			}
		}
	}
}
