using System;
using Google.Protobuf;

namespace CommB1;

public sealed class PartySetting : IMessage<PartySetting>, IMessage, IEquatable<PartySetting>, IDeepCloneable<PartySetting>
{
	private static readonly MessageParser<PartySetting> _parser = new MessageParser<PartySetting>(() => new PartySetting());

	private UnknownFieldSet _unknownFields;

	private uint maxMemberNum_;

	private PartyAdvertiseType advertiseType_;

	private string password_ = "";

	private int taskType_;

	public static MessageParser<PartySetting> Parser => _parser;

	public uint MaxMemberNum
	{
		get
		{
			return maxMemberNum_;
		}
		set
		{
			maxMemberNum_ = value;
		}
	}

	public PartyAdvertiseType AdvertiseType
	{
		get
		{
			return advertiseType_;
		}
		set
		{
			advertiseType_ = value;
		}
	}

	public string Password
	{
		get
		{
			return password_;
		}
		set
		{
			password_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int TaskType
	{
		get
		{
			return taskType_;
		}
		set
		{
			taskType_ = value;
		}
	}

	public PartySetting()
	{
	}

	public PartySetting(PartySetting other)
		: this()
	{
		maxMemberNum_ = other.maxMemberNum_;
		advertiseType_ = other.advertiseType_;
		password_ = other.password_;
		taskType_ = other.taskType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PartySetting Clone()
	{
		return new PartySetting(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PartySetting);
	}

	public bool Equals(PartySetting other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MaxMemberNum != other.MaxMemberNum)
		{
			return false;
		}
		if (AdvertiseType != other.AdvertiseType)
		{
			return false;
		}
		if (Password != other.Password)
		{
			return false;
		}
		if (TaskType != other.TaskType)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (MaxMemberNum != 0)
		{
			num ^= MaxMemberNum.GetHashCode();
		}
		if (AdvertiseType != PartyAdvertiseType.Public)
		{
			num ^= AdvertiseType.GetHashCode();
		}
		if (Password.Length != 0)
		{
			num ^= Password.GetHashCode();
		}
		if (TaskType != 0)
		{
			num ^= TaskType.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (MaxMemberNum != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(MaxMemberNum);
		}
		if (AdvertiseType != PartyAdvertiseType.Public)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)AdvertiseType);
		}
		if (Password.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Password);
		}
		if (TaskType != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(TaskType);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (MaxMemberNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MaxMemberNum);
		}
		if (AdvertiseType != PartyAdvertiseType.Public)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)AdvertiseType);
		}
		if (Password.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Password);
		}
		if (TaskType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TaskType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PartySetting other)
	{
		if (other != null)
		{
			if (other.MaxMemberNum != 0)
			{
				MaxMemberNum = other.MaxMemberNum;
			}
			if (other.AdvertiseType != PartyAdvertiseType.Public)
			{
				AdvertiseType = other.AdvertiseType;
			}
			if (other.Password.Length != 0)
			{
				Password = other.Password;
			}
			if (other.TaskType != 0)
			{
				TaskType = other.TaskType;
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
				MaxMemberNum = input.ReadUInt32();
				break;
			case 16u:
				AdvertiseType = (PartyAdvertiseType)input.ReadEnum();
				break;
			case 26u:
				Password = input.ReadString();
				break;
			case 32u:
				TaskType = input.ReadInt32();
				break;
			}
		}
	}
}
