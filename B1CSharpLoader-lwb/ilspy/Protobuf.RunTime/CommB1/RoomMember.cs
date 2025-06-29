using System;
using Google.Protobuf;

namespace CommB1;

public sealed class RoomMember : IMessage<RoomMember>, IMessage, IEquatable<RoomMember>, IDeepCloneable<RoomMember>
{
	private static readonly MessageParser<RoomMember> _parser = new MessageParser<RoomMember>(() => new RoomMember());

	private UnknownFieldSet _unknownFields;

	private ulong roleId_;

	private string roleName_ = "";

	private uint icon_;

	private uint level_;

	private uint joinTime_;

	private RoomMemberState state_;

	private string ip_ = "";

	private string unrealIp_ = "";

	public static MessageParser<RoomMember> Parser => _parser;

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

	public string RoleName
	{
		get
		{
			return roleName_;
		}
		set
		{
			roleName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public uint Icon
	{
		get
		{
			return icon_;
		}
		set
		{
			icon_ = value;
		}
	}

	public uint Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	public uint JoinTime
	{
		get
		{
			return joinTime_;
		}
		set
		{
			joinTime_ = value;
		}
	}

	public RoomMemberState State
	{
		get
		{
			return state_;
		}
		set
		{
			state_ = value;
		}
	}

	public string Ip
	{
		get
		{
			return ip_;
		}
		set
		{
			ip_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string UnrealIp
	{
		get
		{
			return unrealIp_;
		}
		set
		{
			unrealIp_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RoomMember()
	{
	}

	public RoomMember(RoomMember other)
		: this()
	{
		roleId_ = other.roleId_;
		roleName_ = other.roleName_;
		icon_ = other.icon_;
		level_ = other.level_;
		joinTime_ = other.joinTime_;
		state_ = other.state_;
		ip_ = other.ip_;
		unrealIp_ = other.unrealIp_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoomMember Clone()
	{
		return new RoomMember(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoomMember);
	}

	public bool Equals(RoomMember other)
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
		if (RoleName != other.RoleName)
		{
			return false;
		}
		if (Icon != other.Icon)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (JoinTime != other.JoinTime)
		{
			return false;
		}
		if (State != other.State)
		{
			return false;
		}
		if (Ip != other.Ip)
		{
			return false;
		}
		if (UnrealIp != other.UnrealIp)
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
		if (RoleName.Length != 0)
		{
			num ^= RoleName.GetHashCode();
		}
		if (Icon != 0)
		{
			num ^= Icon.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (JoinTime != 0)
		{
			num ^= JoinTime.GetHashCode();
		}
		if (State != RoomMemberState.Init)
		{
			num ^= State.GetHashCode();
		}
		if (Ip.Length != 0)
		{
			num ^= Ip.GetHashCode();
		}
		if (UnrealIp.Length != 0)
		{
			num ^= UnrealIp.GetHashCode();
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
		if (RoleName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(RoleName);
		}
		if (Icon != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Icon);
		}
		if (Level != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Level);
		}
		if (JoinTime != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(JoinTime);
		}
		if (State != RoomMemberState.Init)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)State);
		}
		if (Ip.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(Ip);
		}
		if (UnrealIp.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(UnrealIp);
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
		if (RoleName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RoleName);
		}
		if (Icon != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Icon);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (JoinTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JoinTime);
		}
		if (State != RoomMemberState.Init)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)State);
		}
		if (Ip.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Ip);
		}
		if (UnrealIp.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UnrealIp);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoomMember other)
	{
		if (other != null)
		{
			if (other.RoleId != 0L)
			{
				RoleId = other.RoleId;
			}
			if (other.RoleName.Length != 0)
			{
				RoleName = other.RoleName;
			}
			if (other.Icon != 0)
			{
				Icon = other.Icon;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.JoinTime != 0)
			{
				JoinTime = other.JoinTime;
			}
			if (other.State != RoomMemberState.Init)
			{
				State = other.State;
			}
			if (other.Ip.Length != 0)
			{
				Ip = other.Ip;
			}
			if (other.UnrealIp.Length != 0)
			{
				UnrealIp = other.UnrealIp;
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
				RoleId = input.ReadUInt64();
				break;
			case 18u:
				RoleName = input.ReadString();
				break;
			case 24u:
				Icon = input.ReadUInt32();
				break;
			case 32u:
				Level = input.ReadUInt32();
				break;
			case 40u:
				JoinTime = input.ReadUInt32();
				break;
			case 48u:
				State = (RoomMemberState)input.ReadEnum();
				break;
			case 58u:
				Ip = input.ReadString();
				break;
			case 66u:
				UnrealIp = input.ReadString();
				break;
			}
		}
	}
}
