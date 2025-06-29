using System;
using Google.Protobuf;

namespace OssB1;

public sealed class Defence : IMessage<Defence>, IMessage, IEquatable<Defence>, IDeepCloneable<Defence>
{
	private static readonly MessageParser<Defence> _parser = new MessageParser<Defence>(() => new Defence());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int num_;

	private int dmg_;

	private int isKill_;

	private int isMonst_;

	private ulong roleId_;

	public static MessageParser<Defence> Parser => _parser;

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

	public int Num
	{
		get
		{
			return num_;
		}
		set
		{
			num_ = value;
		}
	}

	public int Dmg
	{
		get
		{
			return dmg_;
		}
		set
		{
			dmg_ = value;
		}
	}

	public int IsKill
	{
		get
		{
			return isKill_;
		}
		set
		{
			isKill_ = value;
		}
	}

	public int IsMonst
	{
		get
		{
			return isMonst_;
		}
		set
		{
			isMonst_ = value;
		}
	}

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

	public Defence()
	{
	}

	public Defence(Defence other)
		: this()
	{
		id_ = other.id_;
		num_ = other.num_;
		dmg_ = other.dmg_;
		isKill_ = other.isKill_;
		isMonst_ = other.isMonst_;
		roleId_ = other.roleId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public Defence Clone()
	{
		return new Defence(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as Defence);
	}

	public bool Equals(Defence other)
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
		if (Num != other.Num)
		{
			return false;
		}
		if (Dmg != other.Dmg)
		{
			return false;
		}
		if (IsKill != other.IsKill)
		{
			return false;
		}
		if (IsMonst != other.IsMonst)
		{
			return false;
		}
		if (RoleId != other.RoleId)
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
		if (Num != 0)
		{
			num ^= Num.GetHashCode();
		}
		if (Dmg != 0)
		{
			num ^= Dmg.GetHashCode();
		}
		if (IsKill != 0)
		{
			num ^= IsKill.GetHashCode();
		}
		if (IsMonst != 0)
		{
			num ^= IsMonst.GetHashCode();
		}
		if (RoleId != 0L)
		{
			num ^= RoleId.GetHashCode();
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
		if (Num != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Num);
		}
		if (Dmg != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Dmg);
		}
		if (IsKill != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(IsKill);
		}
		if (IsMonst != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(IsMonst);
		}
		if (RoleId != 0L)
		{
			output.WriteRawTag(48);
			output.WriteUInt64(RoleId);
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
		if (Num != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Num);
		}
		if (Dmg != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Dmg);
		}
		if (IsKill != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsKill);
		}
		if (IsMonst != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsMonst);
		}
		if (RoleId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(RoleId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(Defence other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Num != 0)
			{
				Num = other.Num;
			}
			if (other.Dmg != 0)
			{
				Dmg = other.Dmg;
			}
			if (other.IsKill != 0)
			{
				IsKill = other.IsKill;
			}
			if (other.IsMonst != 0)
			{
				IsMonst = other.IsMonst;
			}
			if (other.RoleId != 0L)
			{
				RoleId = other.RoleId;
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
				Num = input.ReadInt32();
				break;
			case 24u:
				Dmg = input.ReadInt32();
				break;
			case 32u:
				IsKill = input.ReadInt32();
				break;
			case 40u:
				IsMonst = input.ReadInt32();
				break;
			case 48u:
				RoleId = input.ReadUInt64();
				break;
			}
		}
	}
}
