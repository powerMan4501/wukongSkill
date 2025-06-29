using System;
using Google.Protobuf;

namespace OssB1;

public sealed class PlayerInfoBattle : IMessage<PlayerInfoBattle>, IMessage, IEquatable<PlayerInfoBattle>, IDeepCloneable<PlayerInfoBattle>
{
	private static readonly MessageParser<PlayerInfoBattle> _parser = new MessageParser<PlayerInfoBattle>(() => new PlayerInfoBattle());

	private UnknownFieldSet _unknownFields;

	private ulong roleId_;

	private int resId_;

	private int maxHp_;

	private int maxMp_;

	private int maxPh_;

	private int curHp_;

	private int curMp_;

	private int maxGourd_;

	private PlayerInfoWear wearInfo_;

	private int curGourd_;

	private int curAtk_;

	private int curDefence_;

	public static MessageParser<PlayerInfoBattle> Parser => _parser;

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

	public int ResId
	{
		get
		{
			return resId_;
		}
		set
		{
			resId_ = value;
		}
	}

	public int MaxHp
	{
		get
		{
			return maxHp_;
		}
		set
		{
			maxHp_ = value;
		}
	}

	public int MaxMp
	{
		get
		{
			return maxMp_;
		}
		set
		{
			maxMp_ = value;
		}
	}

	public int MaxPh
	{
		get
		{
			return maxPh_;
		}
		set
		{
			maxPh_ = value;
		}
	}

	public int CurHp
	{
		get
		{
			return curHp_;
		}
		set
		{
			curHp_ = value;
		}
	}

	public int CurMp
	{
		get
		{
			return curMp_;
		}
		set
		{
			curMp_ = value;
		}
	}

	public int MaxGourd
	{
		get
		{
			return maxGourd_;
		}
		set
		{
			maxGourd_ = value;
		}
	}

	public PlayerInfoWear WearInfo
	{
		get
		{
			return wearInfo_;
		}
		set
		{
			wearInfo_ = value;
		}
	}

	public int CurGourd
	{
		get
		{
			return curGourd_;
		}
		set
		{
			curGourd_ = value;
		}
	}

	public int CurAtk
	{
		get
		{
			return curAtk_;
		}
		set
		{
			curAtk_ = value;
		}
	}

	public int CurDefence
	{
		get
		{
			return curDefence_;
		}
		set
		{
			curDefence_ = value;
		}
	}

	public PlayerInfoBattle()
	{
	}

	public PlayerInfoBattle(PlayerInfoBattle other)
		: this()
	{
		roleId_ = other.roleId_;
		resId_ = other.resId_;
		maxHp_ = other.maxHp_;
		maxMp_ = other.maxMp_;
		maxPh_ = other.maxPh_;
		curHp_ = other.curHp_;
		curMp_ = other.curMp_;
		maxGourd_ = other.maxGourd_;
		wearInfo_ = ((other.wearInfo_ != null) ? other.wearInfo_.Clone() : null);
		curGourd_ = other.curGourd_;
		curAtk_ = other.curAtk_;
		curDefence_ = other.curDefence_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PlayerInfoBattle Clone()
	{
		return new PlayerInfoBattle(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PlayerInfoBattle);
	}

	public bool Equals(PlayerInfoBattle other)
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
		if (ResId != other.ResId)
		{
			return false;
		}
		if (MaxHp != other.MaxHp)
		{
			return false;
		}
		if (MaxMp != other.MaxMp)
		{
			return false;
		}
		if (MaxPh != other.MaxPh)
		{
			return false;
		}
		if (CurHp != other.CurHp)
		{
			return false;
		}
		if (CurMp != other.CurMp)
		{
			return false;
		}
		if (MaxGourd != other.MaxGourd)
		{
			return false;
		}
		if (!object.Equals(WearInfo, other.WearInfo))
		{
			return false;
		}
		if (CurGourd != other.CurGourd)
		{
			return false;
		}
		if (CurAtk != other.CurAtk)
		{
			return false;
		}
		if (CurDefence != other.CurDefence)
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
		if (ResId != 0)
		{
			num ^= ResId.GetHashCode();
		}
		if (MaxHp != 0)
		{
			num ^= MaxHp.GetHashCode();
		}
		if (MaxMp != 0)
		{
			num ^= MaxMp.GetHashCode();
		}
		if (MaxPh != 0)
		{
			num ^= MaxPh.GetHashCode();
		}
		if (CurHp != 0)
		{
			num ^= CurHp.GetHashCode();
		}
		if (CurMp != 0)
		{
			num ^= CurMp.GetHashCode();
		}
		if (MaxGourd != 0)
		{
			num ^= MaxGourd.GetHashCode();
		}
		if (wearInfo_ != null)
		{
			num ^= WearInfo.GetHashCode();
		}
		if (CurGourd != 0)
		{
			num ^= CurGourd.GetHashCode();
		}
		if (CurAtk != 0)
		{
			num ^= CurAtk.GetHashCode();
		}
		if (CurDefence != 0)
		{
			num ^= CurDefence.GetHashCode();
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
		if (ResId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ResId);
		}
		if (MaxHp != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(MaxHp);
		}
		if (MaxMp != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(MaxMp);
		}
		if (MaxPh != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(MaxPh);
		}
		if (CurHp != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(CurHp);
		}
		if (CurMp != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(CurMp);
		}
		if (MaxGourd != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(MaxGourd);
		}
		if (wearInfo_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(WearInfo);
		}
		if (CurGourd != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(CurGourd);
		}
		if (CurAtk != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(CurAtk);
		}
		if (CurDefence != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(CurDefence);
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
		if (ResId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResId);
		}
		if (MaxHp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxHp);
		}
		if (MaxMp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxMp);
		}
		if (MaxPh != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxPh);
		}
		if (CurHp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CurHp);
		}
		if (CurMp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CurMp);
		}
		if (MaxGourd != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxGourd);
		}
		if (wearInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(WearInfo);
		}
		if (CurGourd != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CurGourd);
		}
		if (CurAtk != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CurAtk);
		}
		if (CurDefence != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CurDefence);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PlayerInfoBattle other)
	{
		if (other == null)
		{
			return;
		}
		if (other.RoleId != 0L)
		{
			RoleId = other.RoleId;
		}
		if (other.ResId != 0)
		{
			ResId = other.ResId;
		}
		if (other.MaxHp != 0)
		{
			MaxHp = other.MaxHp;
		}
		if (other.MaxMp != 0)
		{
			MaxMp = other.MaxMp;
		}
		if (other.MaxPh != 0)
		{
			MaxPh = other.MaxPh;
		}
		if (other.CurHp != 0)
		{
			CurHp = other.CurHp;
		}
		if (other.CurMp != 0)
		{
			CurMp = other.CurMp;
		}
		if (other.MaxGourd != 0)
		{
			MaxGourd = other.MaxGourd;
		}
		if (other.wearInfo_ != null)
		{
			if (wearInfo_ == null)
			{
				WearInfo = new PlayerInfoWear();
			}
			WearInfo.MergeFrom(other.WearInfo);
		}
		if (other.CurGourd != 0)
		{
			CurGourd = other.CurGourd;
		}
		if (other.CurAtk != 0)
		{
			CurAtk = other.CurAtk;
		}
		if (other.CurDefence != 0)
		{
			CurDefence = other.CurDefence;
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
			case 16u:
				ResId = input.ReadInt32();
				break;
			case 24u:
				MaxHp = input.ReadInt32();
				break;
			case 32u:
				MaxMp = input.ReadInt32();
				break;
			case 40u:
				MaxPh = input.ReadInt32();
				break;
			case 48u:
				CurHp = input.ReadInt32();
				break;
			case 56u:
				CurMp = input.ReadInt32();
				break;
			case 64u:
				MaxGourd = input.ReadInt32();
				break;
			case 74u:
				if (wearInfo_ == null)
				{
					WearInfo = new PlayerInfoWear();
				}
				input.ReadMessage(WearInfo);
				break;
			case 80u:
				CurGourd = input.ReadInt32();
				break;
			case 88u:
				CurAtk = input.ReadInt32();
				break;
			case 96u:
				CurDefence = input.ReadInt32();
				break;
			}
		}
	}
}
