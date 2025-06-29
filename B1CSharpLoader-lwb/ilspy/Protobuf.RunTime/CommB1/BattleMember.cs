using System;
using Google.Protobuf;

namespace CommB1;

public sealed class BattleMember : IMessage<BattleMember>, IMessage, IEquatable<BattleMember>, IDeepCloneable<BattleMember>
{
	private static readonly MessageParser<BattleMember> _parser = new MessageParser<BattleMember>(() => new BattleMember());

	private UnknownFieldSet _unknownFields;

	private ulong roleId_;

	private uint svrId_;

	private bool isEnter_;

	public static MessageParser<BattleMember> Parser => _parser;

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

	public uint SvrId
	{
		get
		{
			return svrId_;
		}
		set
		{
			svrId_ = value;
		}
	}

	public bool IsEnter
	{
		get
		{
			return isEnter_;
		}
		set
		{
			isEnter_ = value;
		}
	}

	public BattleMember()
	{
	}

	public BattleMember(BattleMember other)
		: this()
	{
		roleId_ = other.roleId_;
		svrId_ = other.svrId_;
		isEnter_ = other.isEnter_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BattleMember Clone()
	{
		return new BattleMember(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BattleMember);
	}

	public bool Equals(BattleMember other)
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
		if (SvrId != other.SvrId)
		{
			return false;
		}
		if (IsEnter != other.IsEnter)
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
		if (SvrId != 0)
		{
			num ^= SvrId.GetHashCode();
		}
		if (IsEnter)
		{
			num ^= IsEnter.GetHashCode();
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
		if (SvrId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(SvrId);
		}
		if (IsEnter)
		{
			output.WriteRawTag(24);
			output.WriteBool(IsEnter);
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
		if (SvrId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SvrId);
		}
		if (IsEnter)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BattleMember other)
	{
		if (other != null)
		{
			if (other.RoleId != 0L)
			{
				RoleId = other.RoleId;
			}
			if (other.SvrId != 0)
			{
				SvrId = other.SvrId;
			}
			if (other.IsEnter)
			{
				IsEnter = other.IsEnter;
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
			case 16u:
				SvrId = input.ReadUInt32();
				break;
			case 24u:
				IsEnter = input.ReadBool();
				break;
			}
		}
	}
}
