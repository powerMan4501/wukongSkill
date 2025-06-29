using System;
using Google.Protobuf;

namespace OssB1;

public sealed class ReportEventPlayerDie : IMessage<ReportEventPlayerDie>, IMessage, IEquatable<ReportEventPlayerDie>, IDeepCloneable<ReportEventPlayerDie>
{
	private static readonly MessageParser<ReportEventPlayerDie> _parser = new MessageParser<ReportEventPlayerDie>(() => new ReportEventPlayerDie());

	private UnknownFieldSet _unknownFields;

	private ulong roleId_;

	private PlayerInfo player_;

	private DieType type_;

	private int unitId_;

	private int dmgId_;

	private DamageType dmgType_;

	private int extendId_;

	public static MessageParser<ReportEventPlayerDie> Parser => _parser;

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

	public PlayerInfo Player
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

	public DieType Type
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

	public int UnitId
	{
		get
		{
			return unitId_;
		}
		set
		{
			unitId_ = value;
		}
	}

	public int DmgId
	{
		get
		{
			return dmgId_;
		}
		set
		{
			dmgId_ = value;
		}
	}

	public DamageType DmgType
	{
		get
		{
			return dmgType_;
		}
		set
		{
			dmgType_ = value;
		}
	}

	public int ExtendId
	{
		get
		{
			return extendId_;
		}
		set
		{
			extendId_ = value;
		}
	}

	public ReportEventPlayerDie()
	{
	}

	public ReportEventPlayerDie(ReportEventPlayerDie other)
		: this()
	{
		roleId_ = other.roleId_;
		player_ = ((other.player_ != null) ? other.player_.Clone() : null);
		type_ = other.type_;
		unitId_ = other.unitId_;
		dmgId_ = other.dmgId_;
		dmgType_ = other.dmgType_;
		extendId_ = other.extendId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportEventPlayerDie Clone()
	{
		return new ReportEventPlayerDie(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportEventPlayerDie);
	}

	public bool Equals(ReportEventPlayerDie other)
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
		if (Type != other.Type)
		{
			return false;
		}
		if (UnitId != other.UnitId)
		{
			return false;
		}
		if (DmgId != other.DmgId)
		{
			return false;
		}
		if (DmgType != other.DmgType)
		{
			return false;
		}
		if (ExtendId != other.ExtendId)
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
		if (Type != DieType.Killed)
		{
			num ^= Type.GetHashCode();
		}
		if (UnitId != 0)
		{
			num ^= UnitId.GetHashCode();
		}
		if (DmgId != 0)
		{
			num ^= DmgId.GetHashCode();
		}
		if (DmgType != DamageType.Skill)
		{
			num ^= DmgType.GetHashCode();
		}
		if (ExtendId != 0)
		{
			num ^= ExtendId.GetHashCode();
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
		if (Type != DieType.Killed)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)Type);
		}
		if (UnitId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(UnitId);
		}
		if (DmgId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(DmgId);
		}
		if (DmgType != DamageType.Skill)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)DmgType);
		}
		if (ExtendId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(ExtendId);
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
		if (Type != DieType.Killed)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (UnitId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnitId);
		}
		if (DmgId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DmgId);
		}
		if (DmgType != DamageType.Skill)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)DmgType);
		}
		if (ExtendId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ExtendId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportEventPlayerDie other)
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
				Player = new PlayerInfo();
			}
			Player.MergeFrom(other.Player);
		}
		if (other.Type != DieType.Killed)
		{
			Type = other.Type;
		}
		if (other.UnitId != 0)
		{
			UnitId = other.UnitId;
		}
		if (other.DmgId != 0)
		{
			DmgId = other.DmgId;
		}
		if (other.DmgType != DamageType.Skill)
		{
			DmgType = other.DmgType;
		}
		if (other.ExtendId != 0)
		{
			ExtendId = other.ExtendId;
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
					Player = new PlayerInfo();
				}
				input.ReadMessage(Player);
				break;
			case 24u:
				Type = (DieType)input.ReadEnum();
				break;
			case 32u:
				UnitId = input.ReadInt32();
				break;
			case 40u:
				DmgId = input.ReadInt32();
				break;
			case 48u:
				DmgType = (DamageType)input.ReadEnum();
				break;
			case 56u:
				ExtendId = input.ReadInt32();
				break;
			}
		}
	}
}
