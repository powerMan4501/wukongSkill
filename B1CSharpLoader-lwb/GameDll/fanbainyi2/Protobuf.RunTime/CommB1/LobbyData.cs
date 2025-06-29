using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class LobbyData : IMessage<LobbyData>, IMessage, IEquatable<LobbyData>, IDeepCloneable<LobbyData>
{
	private static readonly MessageParser<LobbyData> _parser = new MessageParser<LobbyData>(() => new LobbyData());

	private UnknownFieldSet _unknownFields;

	private LobbySetting setting_;

	private ulong lobbyId_;

	private ulong owner_;

	private string ownerName_ = "";

	private LobbyState state_;

	private string hostAddr_ = "";

	private string hostPort_ = "";

	private static readonly FieldCodec<LobbyMember> _repeated_members_codec = FieldCodec.ForMessage(66u, LobbyMember.Parser);

	private readonly RepeatedField<LobbyMember> members_ = new RepeatedField<LobbyMember>();

	public static MessageParser<LobbyData> Parser => _parser;

	public LobbySetting Setting
	{
		get
		{
			return setting_;
		}
		set
		{
			setting_ = value;
		}
	}

	public ulong LobbyId
	{
		get
		{
			return lobbyId_;
		}
		set
		{
			lobbyId_ = value;
		}
	}

	public ulong Owner
	{
		get
		{
			return owner_;
		}
		set
		{
			owner_ = value;
		}
	}

	public string OwnerName
	{
		get
		{
			return ownerName_;
		}
		set
		{
			ownerName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public LobbyState State
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

	public string HostAddr
	{
		get
		{
			return hostAddr_;
		}
		set
		{
			hostAddr_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string HostPort
	{
		get
		{
			return hostPort_;
		}
		set
		{
			hostPort_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<LobbyMember> Members => members_;

	public LobbyData()
	{
	}

	public LobbyData(LobbyData other)
		: this()
	{
		setting_ = ((other.setting_ != null) ? other.setting_.Clone() : null);
		lobbyId_ = other.lobbyId_;
		owner_ = other.owner_;
		ownerName_ = other.ownerName_;
		state_ = other.state_;
		hostAddr_ = other.hostAddr_;
		hostPort_ = other.hostPort_;
		members_ = other.members_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LobbyData Clone()
	{
		return new LobbyData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LobbyData);
	}

	public bool Equals(LobbyData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Setting, other.Setting))
		{
			return false;
		}
		if (LobbyId != other.LobbyId)
		{
			return false;
		}
		if (Owner != other.Owner)
		{
			return false;
		}
		if (OwnerName != other.OwnerName)
		{
			return false;
		}
		if (State != other.State)
		{
			return false;
		}
		if (HostAddr != other.HostAddr)
		{
			return false;
		}
		if (HostPort != other.HostPort)
		{
			return false;
		}
		if (!members_.Equals(other.members_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (setting_ != null)
		{
			num ^= Setting.GetHashCode();
		}
		if (LobbyId != 0L)
		{
			num ^= LobbyId.GetHashCode();
		}
		if (Owner != 0L)
		{
			num ^= Owner.GetHashCode();
		}
		if (OwnerName.Length != 0)
		{
			num ^= OwnerName.GetHashCode();
		}
		if (State != LobbyState.Create)
		{
			num ^= State.GetHashCode();
		}
		if (HostAddr.Length != 0)
		{
			num ^= HostAddr.GetHashCode();
		}
		if (HostPort.Length != 0)
		{
			num ^= HostPort.GetHashCode();
		}
		num ^= members_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (setting_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Setting);
		}
		if (LobbyId != 0L)
		{
			output.WriteRawTag(16);
			output.WriteUInt64(LobbyId);
		}
		if (Owner != 0L)
		{
			output.WriteRawTag(24);
			output.WriteUInt64(Owner);
		}
		if (OwnerName.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(OwnerName);
		}
		if (State != LobbyState.Create)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)State);
		}
		if (HostAddr.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(HostAddr);
		}
		if (HostPort.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(HostPort);
		}
		members_.WriteTo(output, _repeated_members_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (setting_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Setting);
		}
		if (LobbyId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(LobbyId);
		}
		if (Owner != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(Owner);
		}
		if (OwnerName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(OwnerName);
		}
		if (State != LobbyState.Create)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)State);
		}
		if (HostAddr.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(HostAddr);
		}
		if (HostPort.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(HostPort);
		}
		num += members_.CalculateSize(_repeated_members_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LobbyData other)
	{
		if (other == null)
		{
			return;
		}
		if (other.setting_ != null)
		{
			if (setting_ == null)
			{
				Setting = new LobbySetting();
			}
			Setting.MergeFrom(other.Setting);
		}
		if (other.LobbyId != 0L)
		{
			LobbyId = other.LobbyId;
		}
		if (other.Owner != 0L)
		{
			Owner = other.Owner;
		}
		if (other.OwnerName.Length != 0)
		{
			OwnerName = other.OwnerName;
		}
		if (other.State != LobbyState.Create)
		{
			State = other.State;
		}
		if (other.HostAddr.Length != 0)
		{
			HostAddr = other.HostAddr;
		}
		if (other.HostPort.Length != 0)
		{
			HostPort = other.HostPort;
		}
		members_.Add(other.members_);
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
			case 10u:
				if (setting_ == null)
				{
					Setting = new LobbySetting();
				}
				input.ReadMessage(Setting);
				break;
			case 16u:
				LobbyId = input.ReadUInt64();
				break;
			case 24u:
				Owner = input.ReadUInt64();
				break;
			case 34u:
				OwnerName = input.ReadString();
				break;
			case 40u:
				State = (LobbyState)input.ReadEnum();
				break;
			case 50u:
				HostAddr = input.ReadString();
				break;
			case 58u:
				HostPort = input.ReadString();
				break;
			case 66u:
				members_.AddEntriesFrom(input, _repeated_members_codec);
				break;
			}
		}
	}
}
