using System;
using BtlB1;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class ActorWear : IMessage<ActorWear>, IMessage, IEquatable<ActorWear>, IDeepCloneable<ActorWear>
{
	private static readonly MessageParser<ActorWear> _parser = new MessageParser<ActorWear>(() => new ActorWear());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<WearEquip> _repeated_equipList_codec = FieldCodec.ForMessage(10u, WearEquip.Parser);

	private readonly RepeatedField<WearEquip> equipList_ = new RepeatedField<WearEquip>();

	private static readonly FieldCodec<ShortcutItem> _repeated_shortcutsList_codec = FieldCodec.ForMessage(18u, ShortcutItem.Parser);

	private readonly RepeatedField<ShortcutItem> shortcutsList_ = new RepeatedField<ShortcutItem>();

	private static readonly FieldCodec<SpellItem> _repeated_spellList_codec = FieldCodec.ForMessage(26u, SpellItem.Parser);

	private readonly RepeatedField<SpellItem> spellList_ = new RepeatedField<SpellItem>();

	private SpellType defaultSpellType_;

	private int wineId_;

	private Stance stance_;

	private WearSoulSkill wearSoulSkill_;

	private WearAccessory wearAccessory_;

	public static MessageParser<ActorWear> Parser => _parser;

	public RepeatedField<WearEquip> EquipList => equipList_;

	public RepeatedField<ShortcutItem> ShortcutsList => shortcutsList_;

	public RepeatedField<SpellItem> SpellList => spellList_;

	public SpellType DefaultSpellType
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

	public int WineId
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

	public Stance Stance
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

	public WearSoulSkill WearSoulSkill
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

	public WearAccessory WearAccessory
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

	public ActorWear()
	{
	}

	public ActorWear(ActorWear other)
		: this()
	{
		equipList_ = other.equipList_.Clone();
		shortcutsList_ = other.shortcutsList_.Clone();
		spellList_ = other.spellList_.Clone();
		defaultSpellType_ = other.defaultSpellType_;
		wineId_ = other.wineId_;
		stance_ = other.stance_;
		wearSoulSkill_ = ((other.wearSoulSkill_ != null) ? other.wearSoulSkill_.Clone() : null);
		wearAccessory_ = ((other.wearAccessory_ != null) ? other.wearAccessory_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ActorWear Clone()
	{
		return new ActorWear(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ActorWear);
	}

	public bool Equals(ActorWear other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
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
		if (DefaultSpellType != other.DefaultSpellType)
		{
			return false;
		}
		if (WineId != other.WineId)
		{
			return false;
		}
		if (Stance != other.Stance)
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
		num ^= equipList_.GetHashCode();
		num ^= shortcutsList_.GetHashCode();
		num ^= spellList_.GetHashCode();
		if (DefaultSpellType != SpellType.Min)
		{
			num ^= DefaultSpellType.GetHashCode();
		}
		if (WineId != 0)
		{
			num ^= WineId.GetHashCode();
		}
		if (Stance != Stance.Heavy)
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
		equipList_.WriteTo(output, _repeated_equipList_codec);
		shortcutsList_.WriteTo(output, _repeated_shortcutsList_codec);
		spellList_.WriteTo(output, _repeated_spellList_codec);
		if (DefaultSpellType != SpellType.Min)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)DefaultSpellType);
		}
		if (WineId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(WineId);
		}
		if (Stance != Stance.Heavy)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)Stance);
		}
		if (wearSoulSkill_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(WearSoulSkill);
		}
		if (wearAccessory_ != null)
		{
			output.WriteRawTag(82);
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
		num += equipList_.CalculateSize(_repeated_equipList_codec);
		num += shortcutsList_.CalculateSize(_repeated_shortcutsList_codec);
		num += spellList_.CalculateSize(_repeated_spellList_codec);
		if (DefaultSpellType != SpellType.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)DefaultSpellType);
		}
		if (WineId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(WineId);
		}
		if (Stance != Stance.Heavy)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Stance);
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

	public void MergeFrom(ActorWear other)
	{
		if (other == null)
		{
			return;
		}
		equipList_.Add(other.equipList_);
		shortcutsList_.Add(other.shortcutsList_);
		spellList_.Add(other.spellList_);
		if (other.DefaultSpellType != SpellType.Min)
		{
			DefaultSpellType = other.DefaultSpellType;
		}
		if (other.WineId != 0)
		{
			WineId = other.WineId;
		}
		if (other.Stance != Stance.Heavy)
		{
			Stance = other.Stance;
		}
		if (other.wearSoulSkill_ != null)
		{
			if (wearSoulSkill_ == null)
			{
				WearSoulSkill = new WearSoulSkill();
			}
			WearSoulSkill.MergeFrom(other.WearSoulSkill);
		}
		if (other.wearAccessory_ != null)
		{
			if (wearAccessory_ == null)
			{
				WearAccessory = new WearAccessory();
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
			case 10u:
				equipList_.AddEntriesFrom(input, _repeated_equipList_codec);
				break;
			case 18u:
				shortcutsList_.AddEntriesFrom(input, _repeated_shortcutsList_codec);
				break;
			case 26u:
				spellList_.AddEntriesFrom(input, _repeated_spellList_codec);
				break;
			case 40u:
				DefaultSpellType = (SpellType)input.ReadEnum();
				break;
			case 48u:
				WineId = input.ReadInt32();
				break;
			case 56u:
				Stance = (Stance)input.ReadEnum();
				break;
			case 74u:
				if (wearSoulSkill_ == null)
				{
					WearSoulSkill = new WearSoulSkill();
				}
				input.ReadMessage(WearSoulSkill);
				break;
			case 82u:
				if (wearAccessory_ == null)
				{
					WearAccessory = new WearAccessory();
				}
				input.ReadMessage(WearAccessory);
				break;
			}
		}
	}
}
