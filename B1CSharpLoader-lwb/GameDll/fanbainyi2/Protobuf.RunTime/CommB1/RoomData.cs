using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class RoomData : IMessage<RoomData>, IMessage, IEquatable<RoomData>, IDeepCloneable<RoomData>
{
	private static readonly MessageParser<RoomData> _parser = new MessageParser<RoomData>(() => new RoomData());

	private UnknownFieldSet _unknownFields;

	private ulong roomId_;

	private ulong master_;

	private uint task_;

	private uint createTime_;

	private uint maxNum_;

	private string passwd_ = "";

	private RoomState state_;

	private static readonly FieldCodec<RoomMember> _repeated_members_codec = FieldCodec.ForMessage(66u, RoomMember.Parser);

	private readonly RepeatedField<RoomMember> members_ = new RepeatedField<RoomMember>();

	private string name_ = "";

	private int taskLevel_;

	public static MessageParser<RoomData> Parser => _parser;

	public ulong RoomId
	{
		get
		{
			return roomId_;
		}
		set
		{
			roomId_ = value;
		}
	}

	public ulong Master
	{
		get
		{
			return master_;
		}
		set
		{
			master_ = value;
		}
	}

	public uint Task
	{
		get
		{
			return task_;
		}
		set
		{
			task_ = value;
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

	public uint MaxNum
	{
		get
		{
			return maxNum_;
		}
		set
		{
			maxNum_ = value;
		}
	}

	public string Passwd
	{
		get
		{
			return passwd_;
		}
		set
		{
			passwd_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RoomState State
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

	public RepeatedField<RoomMember> Members => members_;

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

	public int TaskLevel
	{
		get
		{
			return taskLevel_;
		}
		set
		{
			taskLevel_ = value;
		}
	}

	public RoomData()
	{
	}

	public RoomData(RoomData other)
		: this()
	{
		roomId_ = other.roomId_;
		master_ = other.master_;
		task_ = other.task_;
		createTime_ = other.createTime_;
		maxNum_ = other.maxNum_;
		passwd_ = other.passwd_;
		state_ = other.state_;
		members_ = other.members_.Clone();
		name_ = other.name_;
		taskLevel_ = other.taskLevel_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoomData Clone()
	{
		return new RoomData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoomData);
	}

	public bool Equals(RoomData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoomId != other.RoomId)
		{
			return false;
		}
		if (Master != other.Master)
		{
			return false;
		}
		if (Task != other.Task)
		{
			return false;
		}
		if (CreateTime != other.CreateTime)
		{
			return false;
		}
		if (MaxNum != other.MaxNum)
		{
			return false;
		}
		if (Passwd != other.Passwd)
		{
			return false;
		}
		if (State != other.State)
		{
			return false;
		}
		if (!members_.Equals(other.members_))
		{
			return false;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (TaskLevel != other.TaskLevel)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (RoomId != 0L)
		{
			num ^= RoomId.GetHashCode();
		}
		if (Master != 0L)
		{
			num ^= Master.GetHashCode();
		}
		if (Task != 0)
		{
			num ^= Task.GetHashCode();
		}
		if (CreateTime != 0)
		{
			num ^= CreateTime.GetHashCode();
		}
		if (MaxNum != 0)
		{
			num ^= MaxNum.GetHashCode();
		}
		if (Passwd.Length != 0)
		{
			num ^= Passwd.GetHashCode();
		}
		if (State != RoomState.Init)
		{
			num ^= State.GetHashCode();
		}
		num ^= members_.GetHashCode();
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (TaskLevel != 0)
		{
			num ^= TaskLevel.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (RoomId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(RoomId);
		}
		if (Master != 0L)
		{
			output.WriteRawTag(16);
			output.WriteUInt64(Master);
		}
		if (Task != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Task);
		}
		if (CreateTime != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(CreateTime);
		}
		if (MaxNum != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(MaxNum);
		}
		if (Passwd.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(Passwd);
		}
		if (State != RoomState.Init)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)State);
		}
		members_.WriteTo(output, _repeated_members_codec);
		if (Name.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(Name);
		}
		if (TaskLevel != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(TaskLevel);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (RoomId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(RoomId);
		}
		if (Master != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(Master);
		}
		if (Task != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Task);
		}
		if (CreateTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CreateTime);
		}
		if (MaxNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MaxNum);
		}
		if (Passwd.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Passwd);
		}
		if (State != RoomState.Init)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)State);
		}
		num += members_.CalculateSize(_repeated_members_codec);
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (TaskLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TaskLevel);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoomData other)
	{
		if (other != null)
		{
			if (other.RoomId != 0L)
			{
				RoomId = other.RoomId;
			}
			if (other.Master != 0L)
			{
				Master = other.Master;
			}
			if (other.Task != 0)
			{
				Task = other.Task;
			}
			if (other.CreateTime != 0)
			{
				CreateTime = other.CreateTime;
			}
			if (other.MaxNum != 0)
			{
				MaxNum = other.MaxNum;
			}
			if (other.Passwd.Length != 0)
			{
				Passwd = other.Passwd;
			}
			if (other.State != RoomState.Init)
			{
				State = other.State;
			}
			members_.Add(other.members_);
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.TaskLevel != 0)
			{
				TaskLevel = other.TaskLevel;
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
				RoomId = input.ReadUInt64();
				break;
			case 16u:
				Master = input.ReadUInt64();
				break;
			case 24u:
				Task = input.ReadUInt32();
				break;
			case 32u:
				CreateTime = input.ReadUInt32();
				break;
			case 40u:
				MaxNum = input.ReadUInt32();
				break;
			case 50u:
				Passwd = input.ReadString();
				break;
			case 56u:
				State = (RoomState)input.ReadEnum();
				break;
			case 66u:
				members_.AddEntriesFrom(input, _repeated_members_codec);
				break;
			case 74u:
				Name = input.ReadString();
				break;
			case 80u:
				TaskLevel = input.ReadInt32();
				break;
			}
		}
	}
}
