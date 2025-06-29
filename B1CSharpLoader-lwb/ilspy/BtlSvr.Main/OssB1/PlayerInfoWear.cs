using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace OssB1;

public sealed class PlayerInfoWear : IMessage<PlayerInfoWear>, IMessage, IEquatable<PlayerInfoWear>, IDeepCloneable<PlayerInfoWear>
{
	private static readonly MessageParser<PlayerInfoWear> _parser = new MessageParser<PlayerInfoWear>(() => new PlayerInfoWear());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<Equip> _repeated_equips_codec = FieldCodec.ForMessage(10u, Equip.Parser);

	private readonly RepeatedField<Equip> equips_ = new RepeatedField<Equip>();

	private static readonly FieldCodec<Spell> _repeated_spells_codec = FieldCodec.ForMessage(18u, Spell.Parser);

	private readonly RepeatedField<Spell> spells_ = new RepeatedField<Spell>();

	private static readonly FieldCodec<Item> _repeated_items_codec = FieldCodec.ForMessage(26u, Item.Parser);

	private readonly RepeatedField<Item> items_ = new RepeatedField<Item>();

	private static readonly FieldCodec<Genius> _repeated_gens_codec = FieldCodec.ForMessage(34u, Genius.Parser);

	private readonly RepeatedField<Genius> gens_ = new RepeatedField<Genius>();

	private static readonly FieldCodec<Legacy> _repeated_legacies_codec = FieldCodec.ForMessage(42u, Legacy.Parser);

	private readonly RepeatedField<Legacy> legacies_ = new RepeatedField<Legacy>();

	private Wine wine_;

	private Accessory accessory_;

	private int soulSkill_;

	public static MessageParser<PlayerInfoWear> Parser => _parser;

	public RepeatedField<Equip> Equips => equips_;

	public RepeatedField<Spell> Spells => spells_;

	public RepeatedField<Item> Items => items_;

	public RepeatedField<Genius> Gens => gens_;

	public RepeatedField<Legacy> Legacies => legacies_;

	public Wine Wine
	{
		get
		{
			return wine_;
		}
		set
		{
			wine_ = value;
		}
	}

	public Accessory Accessory
	{
		get
		{
			return accessory_;
		}
		set
		{
			accessory_ = value;
		}
	}

	public int SoulSkill
	{
		get
		{
			return soulSkill_;
		}
		set
		{
			soulSkill_ = value;
		}
	}

	public PlayerInfoWear()
	{
	}

	public PlayerInfoWear(PlayerInfoWear other)
		: this()
	{
		equips_ = other.equips_.Clone();
		spells_ = other.spells_.Clone();
		items_ = other.items_.Clone();
		gens_ = other.gens_.Clone();
		legacies_ = other.legacies_.Clone();
		wine_ = ((other.wine_ != null) ? other.wine_.Clone() : null);
		accessory_ = ((other.accessory_ != null) ? other.accessory_.Clone() : null);
		soulSkill_ = other.soulSkill_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PlayerInfoWear Clone()
	{
		return new PlayerInfoWear(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PlayerInfoWear);
	}

	public bool Equals(PlayerInfoWear other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!equips_.Equals(other.equips_))
		{
			return false;
		}
		if (!spells_.Equals(other.spells_))
		{
			return false;
		}
		if (!items_.Equals(other.items_))
		{
			return false;
		}
		if (!gens_.Equals(other.gens_))
		{
			return false;
		}
		if (!legacies_.Equals(other.legacies_))
		{
			return false;
		}
		if (!object.Equals(Wine, other.Wine))
		{
			return false;
		}
		if (!object.Equals(Accessory, other.Accessory))
		{
			return false;
		}
		if (SoulSkill != other.SoulSkill)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= equips_.GetHashCode();
		num ^= spells_.GetHashCode();
		num ^= items_.GetHashCode();
		num ^= gens_.GetHashCode();
		num ^= legacies_.GetHashCode();
		if (wine_ != null)
		{
			num ^= Wine.GetHashCode();
		}
		if (accessory_ != null)
		{
			num ^= Accessory.GetHashCode();
		}
		if (SoulSkill != 0)
		{
			num ^= SoulSkill.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		equips_.WriteTo(output, _repeated_equips_codec);
		spells_.WriteTo(output, _repeated_spells_codec);
		items_.WriteTo(output, _repeated_items_codec);
		gens_.WriteTo(output, _repeated_gens_codec);
		legacies_.WriteTo(output, _repeated_legacies_codec);
		if (wine_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(Wine);
		}
		if (accessory_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(Accessory);
		}
		if (SoulSkill != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(SoulSkill);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += equips_.CalculateSize(_repeated_equips_codec);
		num += spells_.CalculateSize(_repeated_spells_codec);
		num += items_.CalculateSize(_repeated_items_codec);
		num += gens_.CalculateSize(_repeated_gens_codec);
		num += legacies_.CalculateSize(_repeated_legacies_codec);
		if (wine_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Wine);
		}
		if (accessory_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Accessory);
		}
		if (SoulSkill != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SoulSkill);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PlayerInfoWear other)
	{
		if (other == null)
		{
			return;
		}
		equips_.Add(other.equips_);
		spells_.Add(other.spells_);
		items_.Add(other.items_);
		gens_.Add(other.gens_);
		legacies_.Add(other.legacies_);
		if (other.wine_ != null)
		{
			if (wine_ == null)
			{
				Wine = new Wine();
			}
			Wine.MergeFrom(other.Wine);
		}
		if (other.accessory_ != null)
		{
			if (accessory_ == null)
			{
				Accessory = new Accessory();
			}
			Accessory.MergeFrom(other.Accessory);
		}
		if (other.SoulSkill != 0)
		{
			SoulSkill = other.SoulSkill;
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
				equips_.AddEntriesFrom(input, _repeated_equips_codec);
				break;
			case 18u:
				spells_.AddEntriesFrom(input, _repeated_spells_codec);
				break;
			case 26u:
				items_.AddEntriesFrom(input, _repeated_items_codec);
				break;
			case 34u:
				gens_.AddEntriesFrom(input, _repeated_gens_codec);
				break;
			case 42u:
				legacies_.AddEntriesFrom(input, _repeated_legacies_codec);
				break;
			case 50u:
				if (wine_ == null)
				{
					Wine = new Wine();
				}
				input.ReadMessage(Wine);
				break;
			case 58u:
				if (accessory_ == null)
				{
					Accessory = new Accessory();
				}
				input.ReadMessage(Accessory);
				break;
			case 64u:
				SoulSkill = input.ReadInt32();
				break;
			}
		}
	}
}
