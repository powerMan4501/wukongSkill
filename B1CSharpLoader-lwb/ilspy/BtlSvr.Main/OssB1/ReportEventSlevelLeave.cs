using System;
using Google.Protobuf;

namespace OssB1;

public sealed class ReportEventSlevelLeave : IMessage<ReportEventSlevelLeave>, IMessage, IEquatable<ReportEventSlevelLeave>, IDeepCloneable<ReportEventSlevelLeave>
{
	private static readonly MessageParser<ReportEventSlevelLeave> _parser = new MessageParser<ReportEventSlevelLeave>(() => new ReportEventSlevelLeave());

	private UnknownFieldSet _unknownFields;

	private ulong roleId_;

	private int stayTime_;

	private int levelMapId_;

	private int levelAreaId_;

	public static MessageParser<ReportEventSlevelLeave> Parser => _parser;

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

	public int StayTime
	{
		get
		{
			return stayTime_;
		}
		set
		{
			stayTime_ = value;
		}
	}

	public int LevelMapId
	{
		get
		{
			return levelMapId_;
		}
		set
		{
			levelMapId_ = value;
		}
	}

	public int LevelAreaId
	{
		get
		{
			return levelAreaId_;
		}
		set
		{
			levelAreaId_ = value;
		}
	}

	public ReportEventSlevelLeave()
	{
	}

	public ReportEventSlevelLeave(ReportEventSlevelLeave other)
		: this()
	{
		roleId_ = other.roleId_;
		stayTime_ = other.stayTime_;
		levelMapId_ = other.levelMapId_;
		levelAreaId_ = other.levelAreaId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportEventSlevelLeave Clone()
	{
		return new ReportEventSlevelLeave(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportEventSlevelLeave);
	}

	public bool Equals(ReportEventSlevelLeave other)
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
		if (StayTime != other.StayTime)
		{
			return false;
		}
		if (LevelMapId != other.LevelMapId)
		{
			return false;
		}
		if (LevelAreaId != other.LevelAreaId)
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
		if (StayTime != 0)
		{
			num ^= StayTime.GetHashCode();
		}
		if (LevelMapId != 0)
		{
			num ^= LevelMapId.GetHashCode();
		}
		if (LevelAreaId != 0)
		{
			num ^= LevelAreaId.GetHashCode();
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
		if (StayTime != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(StayTime);
		}
		if (LevelMapId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(LevelMapId);
		}
		if (LevelAreaId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(LevelAreaId);
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
		if (StayTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StayTime);
		}
		if (LevelMapId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelMapId);
		}
		if (LevelAreaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelAreaId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportEventSlevelLeave other)
	{
		if (other != null)
		{
			if (other.RoleId != 0L)
			{
				RoleId = other.RoleId;
			}
			if (other.StayTime != 0)
			{
				StayTime = other.StayTime;
			}
			if (other.LevelMapId != 0)
			{
				LevelMapId = other.LevelMapId;
			}
			if (other.LevelAreaId != 0)
			{
				LevelAreaId = other.LevelAreaId;
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
				StayTime = input.ReadInt32();
				break;
			case 24u:
				LevelMapId = input.ReadInt32();
				break;
			case 32u:
				LevelAreaId = input.ReadInt32();
				break;
			}
		}
	}
}
