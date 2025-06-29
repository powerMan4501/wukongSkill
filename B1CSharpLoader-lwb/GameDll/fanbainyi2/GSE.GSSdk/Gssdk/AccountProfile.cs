using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class AccountProfile : IMessage<AccountProfile>, IMessage, IEquatable<AccountProfile>, IDeepCloneable<AccountProfile>
{
	private static readonly MessageParser<AccountProfile> _parser = new MessageParser<AccountProfile>(() => new AccountProfile());

	private UnknownFieldSet _unknownFields;

	private long aid_;

	private int serverId_;

	private uint updateTime_;

	private int level_;

	private string name_ = "";

	private int paid_;

	public static MessageParser<AccountProfile> Parser => _parser;

	public long Aid
	{
		get
		{
			return aid_;
		}
		set
		{
			aid_ = value;
		}
	}

	public int ServerId
	{
		get
		{
			return serverId_;
		}
		set
		{
			serverId_ = value;
		}
	}

	public uint UpdateTime
	{
		get
		{
			return updateTime_;
		}
		set
		{
			updateTime_ = value;
		}
	}

	public int Level
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

	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int Paid
	{
		get
		{
			return paid_;
		}
		set
		{
			paid_ = value;
		}
	}

	public AccountProfile()
	{
	}

	public AccountProfile(AccountProfile other)
		: this()
	{
		aid_ = other.aid_;
		serverId_ = other.serverId_;
		updateTime_ = other.updateTime_;
		level_ = other.level_;
		name_ = other.name_;
		paid_ = other.paid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AccountProfile Clone()
	{
		return new AccountProfile(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AccountProfile);
	}

	public bool Equals(AccountProfile other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Aid != other.Aid)
		{
			return false;
		}
		if (ServerId != other.ServerId)
		{
			return false;
		}
		if (UpdateTime != other.UpdateTime)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (Paid != other.Paid)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Aid != 0L)
		{
			num ^= Aid.GetHashCode();
		}
		if (ServerId != 0)
		{
			num ^= ServerId.GetHashCode();
		}
		if (UpdateTime != 0)
		{
			num ^= UpdateTime.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (Paid != 0)
		{
			num ^= Paid.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Aid != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(Aid);
		}
		if (ServerId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ServerId);
		}
		if (UpdateTime != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(UpdateTime);
		}
		if (Level != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Level);
		}
		if (Name.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(Name);
		}
		if (Paid != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(Paid);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Aid != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Aid);
		}
		if (ServerId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ServerId);
		}
		if (UpdateTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UpdateTime);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Level);
		}
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (Paid != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Paid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AccountProfile other)
	{
		if (other != null)
		{
			if (other.Aid != 0L)
			{
				Aid = other.Aid;
			}
			if (other.ServerId != 0)
			{
				ServerId = other.ServerId;
			}
			if (other.UpdateTime != 0)
			{
				UpdateTime = other.UpdateTime;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.Paid != 0)
			{
				Paid = other.Paid;
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
				Aid = input.ReadInt64();
				break;
			case 16u:
				ServerId = input.ReadInt32();
				break;
			case 24u:
				UpdateTime = input.ReadUInt32();
				break;
			case 32u:
				Level = input.ReadInt32();
				break;
			case 42u:
				Name = input.ReadString();
				break;
			case 48u:
				Paid = input.ReadInt32();
				break;
			}
		}
	}
}
