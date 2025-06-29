using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class BattleData : IMessage<BattleData>, IMessage, IEquatable<BattleData>, IDeepCloneable<BattleData>
{
	private static readonly MessageParser<BattleData> _parser = new MessageParser<BattleData>(() => new BattleData());

	private UnknownFieldSet _unknownFields;

	private ulong battleId_;

	private ulong cellId_;

	private int battleType_;

	private uint createTime_;

	private uint cellActivityTime_;

	private uint srcId_;

	private BattleState state_;

	private static readonly FieldCodec<BattleMember> _repeated_members_codec = FieldCodec.ForMessage(66u, BattleMember.Parser);

	private readonly RepeatedField<BattleMember> members_ = new RepeatedField<BattleMember>();

	private string addr_ = "";

	public static MessageParser<BattleData> Parser => _parser;

	public ulong BattleId
	{
		get
		{
			return battleId_;
		}
		set
		{
			battleId_ = value;
		}
	}

	public ulong CellId
	{
		get
		{
			return cellId_;
		}
		set
		{
			cellId_ = value;
		}
	}

	public int BattleType
	{
		get
		{
			return battleType_;
		}
		set
		{
			battleType_ = value;
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

	public uint CellActivityTime
	{
		get
		{
			return cellActivityTime_;
		}
		set
		{
			cellActivityTime_ = value;
		}
	}

	public uint SrcId
	{
		get
		{
			return srcId_;
		}
		set
		{
			srcId_ = value;
		}
	}

	public BattleState State
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

	public RepeatedField<BattleMember> Members => members_;

	public string Addr
	{
		get
		{
			return addr_;
		}
		set
		{
			addr_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public BattleData()
	{
	}

	public BattleData(BattleData other)
		: this()
	{
		battleId_ = other.battleId_;
		cellId_ = other.cellId_;
		battleType_ = other.battleType_;
		createTime_ = other.createTime_;
		cellActivityTime_ = other.cellActivityTime_;
		srcId_ = other.srcId_;
		state_ = other.state_;
		members_ = other.members_.Clone();
		addr_ = other.addr_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BattleData Clone()
	{
		return new BattleData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BattleData);
	}

	public bool Equals(BattleData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BattleId != other.BattleId)
		{
			return false;
		}
		if (CellId != other.CellId)
		{
			return false;
		}
		if (BattleType != other.BattleType)
		{
			return false;
		}
		if (CreateTime != other.CreateTime)
		{
			return false;
		}
		if (CellActivityTime != other.CellActivityTime)
		{
			return false;
		}
		if (SrcId != other.SrcId)
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
		if (Addr != other.Addr)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (BattleId != 0L)
		{
			num ^= BattleId.GetHashCode();
		}
		if (CellId != 0L)
		{
			num ^= CellId.GetHashCode();
		}
		if (BattleType != 0)
		{
			num ^= BattleType.GetHashCode();
		}
		if (CreateTime != 0)
		{
			num ^= CreateTime.GetHashCode();
		}
		if (CellActivityTime != 0)
		{
			num ^= CellActivityTime.GetHashCode();
		}
		if (SrcId != 0)
		{
			num ^= SrcId.GetHashCode();
		}
		if (State != BattleState.None)
		{
			num ^= State.GetHashCode();
		}
		num ^= members_.GetHashCode();
		if (Addr.Length != 0)
		{
			num ^= Addr.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (BattleId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(BattleId);
		}
		if (CellId != 0L)
		{
			output.WriteRawTag(16);
			output.WriteUInt64(CellId);
		}
		if (BattleType != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BattleType);
		}
		if (CreateTime != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(CreateTime);
		}
		if (CellActivityTime != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(CellActivityTime);
		}
		if (SrcId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(SrcId);
		}
		if (State != BattleState.None)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)State);
		}
		members_.WriteTo(output, _repeated_members_codec);
		if (Addr.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(Addr);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (BattleId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(BattleId);
		}
		if (CellId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(CellId);
		}
		if (BattleType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleType);
		}
		if (CreateTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CreateTime);
		}
		if (CellActivityTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CellActivityTime);
		}
		if (SrcId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SrcId);
		}
		if (State != BattleState.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)State);
		}
		num += members_.CalculateSize(_repeated_members_codec);
		if (Addr.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Addr);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BattleData other)
	{
		if (other != null)
		{
			if (other.BattleId != 0L)
			{
				BattleId = other.BattleId;
			}
			if (other.CellId != 0L)
			{
				CellId = other.CellId;
			}
			if (other.BattleType != 0)
			{
				BattleType = other.BattleType;
			}
			if (other.CreateTime != 0)
			{
				CreateTime = other.CreateTime;
			}
			if (other.CellActivityTime != 0)
			{
				CellActivityTime = other.CellActivityTime;
			}
			if (other.SrcId != 0)
			{
				SrcId = other.SrcId;
			}
			if (other.State != BattleState.None)
			{
				State = other.State;
			}
			members_.Add(other.members_);
			if (other.Addr.Length != 0)
			{
				Addr = other.Addr;
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
				BattleId = input.ReadUInt64();
				break;
			case 16u:
				CellId = input.ReadUInt64();
				break;
			case 24u:
				BattleType = input.ReadInt32();
				break;
			case 32u:
				CreateTime = input.ReadUInt32();
				break;
			case 40u:
				CellActivityTime = input.ReadUInt32();
				break;
			case 48u:
				SrcId = input.ReadUInt32();
				break;
			case 56u:
				State = (BattleState)input.ReadEnum();
				break;
			case 66u:
				members_.AddEntriesFrom(input, _repeated_members_codec);
				break;
			case 74u:
				Addr = input.ReadString();
				break;
			}
		}
	}
}
