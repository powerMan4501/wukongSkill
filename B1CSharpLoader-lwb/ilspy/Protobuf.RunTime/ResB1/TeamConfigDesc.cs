using System;
using Google.Protobuf;

namespace ResB1;

public sealed class TeamConfigDesc : IMessage<TeamConfigDesc>, IMessage, IEquatable<TeamConfigDesc>, IDeepCloneable<TeamConfigDesc>
{
	private static readonly MessageParser<TeamConfigDesc> _parser = new MessageParser<TeamConfigDesc>(() => new TeamConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private string leaderName_ = "";

	private int teamMemberNum_;

	public static MessageParser<TeamConfigDesc> Parser => _parser;

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

	public string LeaderName
	{
		get
		{
			return leaderName_;
		}
		set
		{
			leaderName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int TeamMemberNum
	{
		get
		{
			return teamMemberNum_;
		}
		set
		{
			teamMemberNum_ = value;
		}
	}

	public TeamConfigDesc()
	{
	}

	public TeamConfigDesc(TeamConfigDesc other)
		: this()
	{
		id_ = other.id_;
		leaderName_ = other.leaderName_;
		teamMemberNum_ = other.teamMemberNum_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TeamConfigDesc Clone()
	{
		return new TeamConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TeamConfigDesc);
	}

	public bool Equals(TeamConfigDesc other)
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
		if (LeaderName != other.LeaderName)
		{
			return false;
		}
		if (TeamMemberNum != other.TeamMemberNum)
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
		if (LeaderName.Length != 0)
		{
			num ^= LeaderName.GetHashCode();
		}
		if (TeamMemberNum != 0)
		{
			num ^= TeamMemberNum.GetHashCode();
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
		if (LeaderName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(LeaderName);
		}
		if (TeamMemberNum != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(TeamMemberNum);
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
		if (LeaderName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LeaderName);
		}
		if (TeamMemberNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TeamMemberNum);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TeamConfigDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.LeaderName.Length != 0)
			{
				LeaderName = other.LeaderName;
			}
			if (other.TeamMemberNum != 0)
			{
				TeamMemberNum = other.TeamMemberNum;
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
			case 18u:
				LeaderName = input.ReadString();
				break;
			case 24u:
				TeamMemberNum = input.ReadInt32();
				break;
			}
		}
	}
}
