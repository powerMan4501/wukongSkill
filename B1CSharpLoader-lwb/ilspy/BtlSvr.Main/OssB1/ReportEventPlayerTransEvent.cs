using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace OssB1;

public sealed class ReportEventPlayerTransEvent : IMessage<ReportEventPlayerTransEvent>, IMessage, IEquatable<ReportEventPlayerTransEvent>, IDeepCloneable<ReportEventPlayerTransEvent>
{
	private static readonly MessageParser<ReportEventPlayerTransEvent> _parser = new MessageParser<ReportEventPlayerTransEvent>(() => new ReportEventPlayerTransEvent());

	private UnknownFieldSet _unknownFields;

	private ulong roleId_;

	private PlayerInfoBattle player_;

	private static readonly FieldCodec<Attack> _repeated_atk_codec = FieldCodec.ForMessage(26u, Attack.Parser);

	private readonly RepeatedField<Attack> atk_ = new RepeatedField<Attack>();

	private static readonly FieldCodec<Defence> _repeated_def_codec = FieldCodec.ForMessage(34u, Defence.Parser);

	private readonly RepeatedField<Defence> def_ = new RepeatedField<Defence>();

	private int dur_;

	private string endType_ = "";

	private int haveBattle_;

	private float attackDur_;

	private float rollDur_;

	private static readonly FieldCodec<PlayerTransDmg> _repeated_dmg_codec = FieldCodec.ForMessage(82u, PlayerTransDmg.Parser);

	private readonly RepeatedField<PlayerTransDmg> dmg_ = new RepeatedField<PlayerTransDmg>();

	private float exitEnergy_;

	private float exitHp_;

	public static MessageParser<ReportEventPlayerTransEvent> Parser => _parser;

	public ulong RoleId
	{
		get
		{
			return roleId_;
		}
		set
		{
			roleId_ = value;
		}
	}

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

	public string EndType
	{
		get
		{
			return endType_;
		}
		set
		{
			endType_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int HaveBattle
	{
		get
		{
			return haveBattle_;
		}
		set
		{
			haveBattle_ = value;
		}
	}

	public float AttackDur
	{
		get
		{
			return attackDur_;
		}
		set
		{
			attackDur_ = value;
		}
	}

	public float RollDur
	{
		get
		{
			return rollDur_;
		}
		set
		{
			rollDur_ = value;
		}
	}

	public RepeatedField<PlayerTransDmg> Dmg => dmg_;

	public float ExitEnergy
	{
		get
		{
			return exitEnergy_;
		}
		set
		{
			exitEnergy_ = value;
		}
	}

	public float ExitHp
	{
		get
		{
			return exitHp_;
		}
		set
		{
			exitHp_ = value;
		}
	}

	public ReportEventPlayerTransEvent()
	{
	}

	public ReportEventPlayerTransEvent(ReportEventPlayerTransEvent other)
		: this()
	{
		roleId_ = other.roleId_;
		player_ = ((other.player_ != null) ? other.player_.Clone() : null);
		atk_ = other.atk_.Clone();
		def_ = other.def_.Clone();
		dur_ = other.dur_;
		endType_ = other.endType_;
		haveBattle_ = other.haveBattle_;
		attackDur_ = other.attackDur_;
		rollDur_ = other.rollDur_;
		dmg_ = other.dmg_.Clone();
		exitEnergy_ = other.exitEnergy_;
		exitHp_ = other.exitHp_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportEventPlayerTransEvent Clone()
	{
		return new ReportEventPlayerTransEvent(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportEventPlayerTransEvent);
	}

	public bool Equals(ReportEventPlayerTransEvent other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoleId != other.RoleId)
		{
			return false;
		}
		if (!object.Equals(Player, other.Player))
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
		if (EndType != other.EndType)
		{
			return false;
		}
		if (HaveBattle != other.HaveBattle)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AttackDur, other.AttackDur))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(RollDur, other.RollDur))
		{
			return false;
		}
		if (!dmg_.Equals(other.dmg_))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ExitEnergy, other.ExitEnergy))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ExitHp, other.ExitHp))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (RoleId != 0L)
		{
			num ^= RoleId.GetHashCode();
		}
		if (player_ != null)
		{
			num ^= Player.GetHashCode();
		}
		num ^= atk_.GetHashCode();
		num ^= def_.GetHashCode();
		if (Dur != 0)
		{
			num ^= Dur.GetHashCode();
		}
		if (EndType.Length != 0)
		{
			num ^= EndType.GetHashCode();
		}
		if (HaveBattle != 0)
		{
			num ^= HaveBattle.GetHashCode();
		}
		if (AttackDur != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AttackDur);
		}
		if (RollDur != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(RollDur);
		}
		num ^= dmg_.GetHashCode();
		if (ExitEnergy != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ExitEnergy);
		}
		if (ExitHp != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ExitHp);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (RoleId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(RoleId);
		}
		if (player_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Player);
		}
		atk_.WriteTo(output, _repeated_atk_codec);
		def_.WriteTo(output, _repeated_def_codec);
		if (Dur != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Dur);
		}
		if (EndType.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(EndType);
		}
		if (HaveBattle != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(HaveBattle);
		}
		if (AttackDur != 0f)
		{
			output.WriteRawTag(69);
			output.WriteFloat(AttackDur);
		}
		if (RollDur != 0f)
		{
			output.WriteRawTag(77);
			output.WriteFloat(RollDur);
		}
		dmg_.WriteTo(output, _repeated_dmg_codec);
		if (ExitEnergy != 0f)
		{
			output.WriteRawTag(93);
			output.WriteFloat(ExitEnergy);
		}
		if (ExitHp != 0f)
		{
			output.WriteRawTag(101);
			output.WriteFloat(ExitHp);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (RoleId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(RoleId);
		}
		if (player_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Player);
		}
		num += atk_.CalculateSize(_repeated_atk_codec);
		num += def_.CalculateSize(_repeated_def_codec);
		if (Dur != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Dur);
		}
		if (EndType.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EndType);
		}
		if (HaveBattle != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HaveBattle);
		}
		if (AttackDur != 0f)
		{
			num += 5;
		}
		if (RollDur != 0f)
		{
			num += 5;
		}
		num += dmg_.CalculateSize(_repeated_dmg_codec);
		if (ExitEnergy != 0f)
		{
			num += 5;
		}
		if (ExitHp != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportEventPlayerTransEvent other)
	{
		if (other == null)
		{
			return;
		}
		if (other.RoleId != 0L)
		{
			RoleId = other.RoleId;
		}
		if (other.player_ != null)
		{
			if (player_ == null)
			{
				Player = new PlayerInfoBattle();
			}
			Player.MergeFrom(other.Player);
		}
		atk_.Add(other.atk_);
		def_.Add(other.def_);
		if (other.Dur != 0)
		{
			Dur = other.Dur;
		}
		if (other.EndType.Length != 0)
		{
			EndType = other.EndType;
		}
		if (other.HaveBattle != 0)
		{
			HaveBattle = other.HaveBattle;
		}
		if (other.AttackDur != 0f)
		{
			AttackDur = other.AttackDur;
		}
		if (other.RollDur != 0f)
		{
			RollDur = other.RollDur;
		}
		dmg_.Add(other.dmg_);
		if (other.ExitEnergy != 0f)
		{
			ExitEnergy = other.ExitEnergy;
		}
		if (other.ExitHp != 0f)
		{
			ExitHp = other.ExitHp;
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
				RoleId = input.ReadUInt64();
				break;
			case 18u:
				if (player_ == null)
				{
					Player = new PlayerInfoBattle();
				}
				input.ReadMessage(Player);
				break;
			case 26u:
				atk_.AddEntriesFrom(input, _repeated_atk_codec);
				break;
			case 34u:
				def_.AddEntriesFrom(input, _repeated_def_codec);
				break;
			case 40u:
				Dur = input.ReadInt32();
				break;
			case 50u:
				EndType = input.ReadString();
				break;
			case 56u:
				HaveBattle = input.ReadInt32();
				break;
			case 69u:
				AttackDur = input.ReadFloat();
				break;
			case 77u:
				RollDur = input.ReadFloat();
				break;
			case 82u:
				dmg_.AddEntriesFrom(input, _repeated_dmg_codec);
				break;
			case 93u:
				ExitEnergy = input.ReadFloat();
				break;
			case 101u:
				ExitHp = input.ReadFloat();
				break;
			}
		}
	}
}
