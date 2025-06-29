using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace GurGsReplicate;

public sealed class RoleBaseData : IMessage<RoleBaseData>, IMessage, IEquatable<RoleBaseData>, IDeepCloneable<RoleBaseData>
{
	private static readonly MessageParser<RoleBaseData> _parser = new MessageParser<RoleBaseData>(() => new RoleBaseData());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private string roleName_;

	private ulong roleId_;

	private int roleLevel_;

	private int soulSkillID_;

	private static readonly FieldCodec<DictDeltaMsgEquipPosition_Int> _repeated_equipList_codec = FieldCodec.ForMessage(42u, DictDeltaMsgEquipPosition_Int.Parser);

	private readonly RepeatedField<DictDeltaMsgEquipPosition_Int> equipList_ = new RepeatedField<DictDeltaMsgEquipPosition_Int>();

	private static readonly FieldCodec<DictDeltaMsgInt_Int> _repeated_talenList_codec = FieldCodec.ForMessage(50u, DictDeltaMsgInt_Int.Parser);

	private readonly RepeatedField<DictDeltaMsgInt_Int> talenList_ = new RepeatedField<DictDeltaMsgInt_Int>();

	public static MessageParser<RoleBaseData> Parser => _parser;

	public string RoleName
	{
		get
		{
			return roleName_ ?? "";
		}
		set
		{
			roleName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool HasRoleName => roleName_ != null;

	public ulong RoleId
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return roleId_;
			}
			return 0uL;
		}
		set
		{
			_hasBits0 |= 1;
			roleId_ = value;
		}
	}

	public bool HasRoleId => (_hasBits0 & 1) != 0;

	public int RoleLevel
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return roleLevel_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 2;
			roleLevel_ = value;
		}
	}

	public bool HasRoleLevel => (_hasBits0 & 2) != 0;

	public int SoulSkillID
	{
		get
		{
			if ((_hasBits0 & 4) != 0)
			{
				return soulSkillID_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 4;
			soulSkillID_ = value;
		}
	}

	public bool HasSoulSkillID => (_hasBits0 & 4) != 0;

	public RepeatedField<DictDeltaMsgEquipPosition_Int> EquipList => equipList_;

	public RepeatedField<DictDeltaMsgInt_Int> TalenList => talenList_;

	public RoleBaseData()
	{
	}

	public RoleBaseData(RoleBaseData other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		roleName_ = other.roleName_;
		roleId_ = other.roleId_;
		roleLevel_ = other.roleLevel_;
		soulSkillID_ = other.soulSkillID_;
		equipList_ = other.equipList_.Clone();
		talenList_ = other.talenList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleBaseData Clone()
	{
		return new RoleBaseData(this);
	}

	public void ClearRoleName()
	{
		roleName_ = null;
	}

	public void ClearRoleId()
	{
		_hasBits0 &= -2;
	}

	public void ClearRoleLevel()
	{
		_hasBits0 &= -3;
	}

	public void ClearSoulSkillID()
	{
		_hasBits0 &= -5;
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleBaseData);
	}

	public bool Equals(RoleBaseData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoleName != other.RoleName)
		{
			return false;
		}
		if (RoleId != other.RoleId)
		{
			return false;
		}
		if (RoleLevel != other.RoleLevel)
		{
			return false;
		}
		if (SoulSkillID != other.SoulSkillID)
		{
			return false;
		}
		if (!equipList_.Equals(other.equipList_))
		{
			return false;
		}
		if (!talenList_.Equals(other.talenList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasRoleName)
		{
			num ^= RoleName.GetHashCode();
		}
		if (HasRoleId)
		{
			num ^= RoleId.GetHashCode();
		}
		if (HasRoleLevel)
		{
			num ^= RoleLevel.GetHashCode();
		}
		if (HasSoulSkillID)
		{
			num ^= SoulSkillID.GetHashCode();
		}
		num ^= equipList_.GetHashCode();
		num ^= talenList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasRoleName)
		{
			output.WriteRawTag(10);
			output.WriteString(RoleName);
		}
		if (HasRoleId)
		{
			output.WriteRawTag(16);
			output.WriteUInt64(RoleId);
		}
		if (HasRoleLevel)
		{
			output.WriteRawTag(24);
			output.WriteInt32(RoleLevel);
		}
		if (HasSoulSkillID)
		{
			output.WriteRawTag(32);
			output.WriteInt32(SoulSkillID);
		}
		equipList_.WriteTo(output, _repeated_equipList_codec);
		talenList_.WriteTo(output, _repeated_talenList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasRoleName)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RoleName);
		}
		if (HasRoleId)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(RoleId);
		}
		if (HasRoleLevel)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RoleLevel);
		}
		if (HasSoulSkillID)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SoulSkillID);
		}
		num += equipList_.CalculateSize(_repeated_equipList_codec);
		num += talenList_.CalculateSize(_repeated_talenList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleBaseData other)
	{
		if (other != null)
		{
			if (other.HasRoleName)
			{
				RoleName = other.RoleName;
			}
			if (other.HasRoleId)
			{
				RoleId = other.RoleId;
			}
			if (other.HasRoleLevel)
			{
				RoleLevel = other.RoleLevel;
			}
			if (other.HasSoulSkillID)
			{
				SoulSkillID = other.SoulSkillID;
			}
			equipList_.Add(other.equipList_);
			talenList_.Add(other.talenList_);
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
			case 10u:
				RoleName = input.ReadString();
				break;
			case 16u:
				RoleId = input.ReadUInt64();
				break;
			case 24u:
				RoleLevel = input.ReadInt32();
				break;
			case 32u:
				SoulSkillID = input.ReadInt32();
				break;
			case 42u:
				equipList_.AddEntriesFrom(input, _repeated_equipList_codec);
				break;
			case 50u:
				talenList_.AddEntriesFrom(input, _repeated_talenList_codec);
				break;
			}
		}
	}
}
