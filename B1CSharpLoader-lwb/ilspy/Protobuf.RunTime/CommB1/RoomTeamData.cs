using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class RoomTeamData : IMessage<RoomTeamData>, IMessage, IEquatable<RoomTeamData>, IDeepCloneable<RoomTeamData>
{
	private static readonly MessageParser<RoomTeamData> _parser = new MessageParser<RoomTeamData>(() => new RoomTeamData());

	private UnknownFieldSet _unknownFields;

	private ulong teamId_;

	private ulong master_;

	private uint createTime_;

	private TeamState state_;

	private static readonly FieldCodec<TeamMember> _repeated_members_codec = FieldCodec.ForMessage(42u, TeamMember.Parser);

	private readonly RepeatedField<TeamMember> members_ = new RepeatedField<TeamMember>();

	private BattleSimInfo battleInfo_;

	public static MessageParser<RoomTeamData> Parser => _parser;

	public ulong TeamId
	{
		get
		{
			return teamId_;
		}
		set
		{
			teamId_ = value;
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

	public TeamState State
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

	public RepeatedField<TeamMember> Members => members_;

	public BattleSimInfo BattleInfo
	{
		get
		{
			return battleInfo_;
		}
		set
		{
			battleInfo_ = value;
		}
	}

	public RoomTeamData()
	{
	}

	public RoomTeamData(RoomTeamData other)
		: this()
	{
		teamId_ = other.teamId_;
		master_ = other.master_;
		createTime_ = other.createTime_;
		state_ = other.state_;
		members_ = other.members_.Clone();
		battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoomTeamData Clone()
	{
		return new RoomTeamData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoomTeamData);
	}

	public bool Equals(RoomTeamData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TeamId != other.TeamId)
		{
			return false;
		}
		if (Master != other.Master)
		{
			return false;
		}
		if (CreateTime != other.CreateTime)
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
		if (!object.Equals(BattleInfo, other.BattleInfo))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (TeamId != 0L)
		{
			num ^= TeamId.GetHashCode();
		}
		if (Master != 0L)
		{
			num ^= Master.GetHashCode();
		}
		if (CreateTime != 0)
		{
			num ^= CreateTime.GetHashCode();
		}
		if (State != TeamState.Init)
		{
			num ^= State.GetHashCode();
		}
		num ^= members_.GetHashCode();
		if (battleInfo_ != null)
		{
			num ^= BattleInfo.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (TeamId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(TeamId);
		}
		if (Master != 0L)
		{
			output.WriteRawTag(16);
			output.WriteUInt64(Master);
		}
		if (CreateTime != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(CreateTime);
		}
		if (State != TeamState.Init)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)State);
		}
		members_.WriteTo(output, _repeated_members_codec);
		if (battleInfo_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(BattleInfo);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (TeamId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(TeamId);
		}
		if (Master != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(Master);
		}
		if (CreateTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CreateTime);
		}
		if (State != TeamState.Init)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)State);
		}
		num += members_.CalculateSize(_repeated_members_codec);
		if (battleInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BattleInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoomTeamData other)
	{
		if (other == null)
		{
			return;
		}
		if (other.TeamId != 0L)
		{
			TeamId = other.TeamId;
		}
		if (other.Master != 0L)
		{
			Master = other.Master;
		}
		if (other.CreateTime != 0)
		{
			CreateTime = other.CreateTime;
		}
		if (other.State != TeamState.Init)
		{
			State = other.State;
		}
		members_.Add(other.members_);
		if (other.battleInfo_ != null)
		{
			if (battleInfo_ == null)
			{
				BattleInfo = new BattleSimInfo();
			}
			BattleInfo.MergeFrom(other.BattleInfo);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				TeamId = input.ReadUInt64();
				break;
			case 16u:
				Master = input.ReadUInt64();
				break;
			case 24u:
				CreateTime = input.ReadUInt32();
				break;
			case 32u:
				State = (TeamState)input.ReadEnum();
				break;
			case 42u:
				members_.AddEntriesFrom(input, _repeated_members_codec);
				break;
			case 50u:
				if (battleInfo_ == null)
				{
					BattleInfo = new BattleSimInfo();
				}
				input.ReadMessage(BattleInfo);
				break;
			}
		}
	}
}
