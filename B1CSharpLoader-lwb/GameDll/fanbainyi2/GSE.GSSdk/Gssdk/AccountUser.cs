using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class AccountUser : IMessage<AccountUser>, IMessage, IEquatable<AccountUser>, IDeepCloneable<AccountUser>
{
	private static readonly MessageParser<AccountUser> _parser = new MessageParser<AccountUser>(() => new AccountUser());

	private UnknownFieldSet _unknownFields;

	private long id_;

	private uint createTime_;

	private int bebindTimes_;

	public static MessageParser<AccountUser> Parser => _parser;

	public long Id
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

	public uint CreateTime
	{
		get
		{
			return createTime_;
		}
		set
		{
			createTime_ = value;
		}
	}

	public int BebindTimes
	{
		get
		{
			return bebindTimes_;
		}
		set
		{
			bebindTimes_ = value;
		}
	}

	public AccountUser()
	{
	}

	public AccountUser(AccountUser other)
		: this()
	{
		id_ = other.id_;
		createTime_ = other.createTime_;
		bebindTimes_ = other.bebindTimes_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AccountUser Clone()
	{
		return new AccountUser(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AccountUser);
	}

	public bool Equals(AccountUser other)
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
		if (CreateTime != other.CreateTime)
		{
			return false;
		}
		if (BebindTimes != other.BebindTimes)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0L)
		{
			num ^= Id.GetHashCode();
		}
		if (CreateTime != 0)
		{
			num ^= CreateTime.GetHashCode();
		}
		if (BebindTimes != 0)
		{
			num ^= BebindTimes.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(Id);
		}
		if (CreateTime != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(CreateTime);
		}
		if (BebindTimes != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BebindTimes);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Id);
		}
		if (CreateTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CreateTime);
		}
		if (BebindTimes != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BebindTimes);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AccountUser other)
	{
		if (other != null)
		{
			if (other.Id != 0L)
			{
				Id = other.Id;
			}
			if (other.CreateTime != 0)
			{
				CreateTime = other.CreateTime;
			}
			if (other.BebindTimes != 0)
			{
				BebindTimes = other.BebindTimes;
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
				Id = input.ReadInt64();
				break;
			case 16u:
				CreateTime = input.ReadUInt32();
				break;
			case 24u:
				BebindTimes = input.ReadInt32();
				break;
			}
		}
	}
}
