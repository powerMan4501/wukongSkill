using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace OssB1;

public sealed class BattlePlayer : IMessage<BattlePlayer>, IMessage, IEquatable<BattlePlayer>, IDeepCloneable<BattlePlayer>
{
	private static readonly MessageParser<BattlePlayer> _parser = new MessageParser<BattlePlayer>(() => new BattlePlayer());

	private UnknownFieldSet _unknownFields;

	private PlayerInfoBattle player_;

	private BattleEndType endType_;

	private static readonly FieldCodec<Item> _repeated_itemUse_codec = FieldCodec.ForMessage(26u, Item.Parser);

	private readonly RepeatedField<Item> itemUse_ = new RepeatedField<Item>();

	private static readonly FieldCodec<Attack> _repeated_atk_codec = FieldCodec.ForMessage(34u, Attack.Parser);

	private readonly RepeatedField<Attack> atk_ = new RepeatedField<Attack>();

	private static readonly FieldCodec<Defence> _repeated_def_codec = FieldCodec.ForMessage(42u, Defence.Parser);

	private readonly RepeatedField<Defence> def_ = new RepeatedField<Defence>();

	private int dur_;

	private static readonly FieldCodec<Item> _repeated_fullItems_codec = FieldCodec.ForMessage(58u, Item.Parser);

	private readonly RepeatedField<Item> fullItems_ = new RepeatedField<Item>();

	public static MessageParser<BattlePlayer> Parser => _parser;

	public PlayerInfoBattle Player
	{
		get
		{
			return player_;
		}
		set
		{
			player_ = value;
		}
	}

	public BattleEndType EndType
	{
		get
		{
			return endType_;
		}
		set
		{
			endType_ = value;
		}
	}

	public RepeatedField<Item> ItemUse => itemUse_;

	public RepeatedField<Attack> Atk => atk_;

	public RepeatedField<Defence> Def => def_;

	public int Dur
	{
		get
		{
			return dur_;
		}
		set
		{
			dur_ = value;
		}
	}

	public RepeatedField<Item> FullItems => fullItems_;

	public BattlePlayer()
	{
	}

	public BattlePlayer(BattlePlayer other)
		: this()
	{
		player_ = ((other.player_ != null) ? other.player_.Clone() : null);
		endType_ = other.endType_;
		itemUse_ = other.itemUse_.Clone();
		atk_ = other.atk_.Clone();
		def_ = other.def_.Clone();
		dur_ = other.dur_;
		fullItems_ = other.fullItems_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BattlePlayer Clone()
	{
		return new BattlePlayer(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BattlePlayer);
	}

	public bool Equals(BattlePlayer other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Player, other.Player))
		{
			return false;
		}
		if (EndType != other.EndType)
		{
			return false;
		}
		if (!itemUse_.Equals(other.itemUse_))
		{
			return false;
		}
		if (!atk_.Equals(other.atk_))
		{
			return false;
		}
		if (!def_.Equals(other.def_))
		{
			return false;
		}
		if (Dur != other.Dur)
		{
			return false;
		}
		if (!fullItems_.Equals(other.fullItems_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (player_ != null)
		{
			num ^= Player.GetHashCode();
		}
		if (EndType != BattleEndType.Detach)
		{
			num ^= EndType.GetHashCode();
		}
		num ^= itemUse_.GetHashCode();
		num ^= atk_.GetHashCode();
		num ^= def_.GetHashCode();
		if (Dur != 0)
		{
			num ^= Dur.GetHashCode();
		}
		num ^= fullItems_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (player_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Player);
		}
		if (EndType != BattleEndType.Detach)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)EndType);
		}
		itemUse_.WriteTo(output, _repeated_itemUse_codec);
		atk_.WriteTo(output, _repeated_atk_codec);
		def_.WriteTo(output, _repeated_def_codec);
		if (Dur != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(Dur);
		}
		fullItems_.WriteTo(output, _repeated_fullItems_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (player_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Player);
		}
		if (EndType != BattleEndType.Detach)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EndType);
		}
		num += itemUse_.CalculateSize(_repeated_itemUse_codec);
		num += atk_.CalculateSize(_repeated_atk_codec);
		num += def_.CalculateSize(_repeated_def_codec);
		if (Dur != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Dur);
		}
		num += fullItems_.CalculateSize(_repeated_fullItems_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BattlePlayer other)
	{
		if (other == null)
		{
			return;
		}
		if (other.player_ != null)
		{
			if (player_ == null)
			{
				Player = new PlayerInfoBattle();
			}
			Player.MergeFrom(other.Player);
		}
		if (other.EndType != BattleEndType.Detach)
		{
			EndType = other.EndType;
		}
		itemUse_.Add(other.itemUse_);
		atk_.Add(other.atk_);
		def_.Add(other.def_);
		if (other.Dur != 0)
		{
			Dur = other.Dur;
		}
		fullItems_.Add(other.fullItems_);
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
				if (player_ == null)
				{
					Player = new PlayerInfoBattle();
				}
				input.ReadMessage(Player);
				break;
			case 16u:
				EndType = (BattleEndType)input.ReadEnum();
				break;
			case 26u:
				itemUse_.AddEntriesFrom(input, _repeated_itemUse_codec);
				break;
			case 34u:
				atk_.AddEntriesFrom(input, _repeated_atk_codec);
				break;
			case 42u:
				def_.AddEntriesFrom(input, _repeated_def_codec);
				break;
			case 48u:
				Dur = input.ReadInt32();
				break;
			case 58u:
				fullItems_.AddEntriesFrom(input, _repeated_fullItems_codec);
				break;
			}
		}
	}
}
