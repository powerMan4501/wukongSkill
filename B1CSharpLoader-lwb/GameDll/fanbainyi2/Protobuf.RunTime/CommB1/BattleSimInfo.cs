using System;
using Google.Protobuf;

namespace CommB1;

public sealed class BattleSimInfo : IMessage<BattleSimInfo>, IMessage, IEquatable<BattleSimInfo>, IDeepCloneable<BattleSimInfo>
{
	private static readonly MessageParser<BattleSimInfo> _parser = new MessageParser<BattleSimInfo>(() => new BattleSimInfo());

	private UnknownFieldSet _unknownFields;

	private ulong battleId_;

	private int battleType_;

	private uint srcId_;

	private uint dstId_;

	private ulong cellId_;

	private BattleState state_;

	private string connAddr_ = "";

	public static MessageParser<BattleSimInfo> Parser => _parser;

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

	public uint DstId
	{
		get
		{
			return dstId_;
		}
		set
		{
			dstId_ = value;
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

	public string ConnAddr
	{
		get
		{
			return connAddr_;
		}
		set
		{
			connAddr_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public BattleSimInfo()
	{
	}

	public BattleSimInfo(BattleSimInfo other)
		: this()
	{
		battleId_ = other.battleId_;
		battleType_ = other.battleType_;
		srcId_ = other.srcId_;
		dstId_ = other.dstId_;
		cellId_ = other.cellId_;
		state_ = other.state_;
		connAddr_ = other.connAddr_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BattleSimInfo Clone()
	{
		return new BattleSimInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BattleSimInfo);
	}

	public bool Equals(BattleSimInfo other)
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
		if (BattleType != other.BattleType)
		{
			return false;
		}
		if (SrcId != other.SrcId)
		{
			return false;
		}
		if (DstId != other.DstId)
		{
			return false;
		}
		if (CellId != other.CellId)
		{
			return false;
		}
		if (State != other.State)
		{
			return false;
		}
		if (ConnAddr != other.ConnAddr)
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
		if (BattleType != 0)
		{
			num ^= BattleType.GetHashCode();
		}
		if (SrcId != 0)
		{
			num ^= SrcId.GetHashCode();
		}
		if (DstId != 0)
		{
			num ^= DstId.GetHashCode();
		}
		if (CellId != 0L)
		{
			num ^= CellId.GetHashCode();
		}
		if (State != BattleState.None)
		{
			num ^= State.GetHashCode();
		}
		if (ConnAddr.Length != 0)
		{
			num ^= ConnAddr.GetHashCode();
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
		if (BattleType != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BattleType);
		}
		if (SrcId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(SrcId);
		}
		if (DstId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(DstId);
		}
		if (CellId != 0L)
		{
			output.WriteRawTag(40);
			output.WriteUInt64(CellId);
		}
		if (State != BattleState.None)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)State);
		}
		if (ConnAddr.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(ConnAddr);
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
		if (BattleType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleType);
		}
		if (SrcId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SrcId);
		}
		if (DstId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DstId);
		}
		if (CellId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(CellId);
		}
		if (State != BattleState.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)State);
		}
		if (ConnAddr.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ConnAddr);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BattleSimInfo other)
	{
		if (other != null)
		{
			if (other.BattleId != 0L)
			{
				BattleId = other.BattleId;
			}
			if (other.BattleType != 0)
			{
				BattleType = other.BattleType;
			}
			if (other.SrcId != 0)
			{
				SrcId = other.SrcId;
			}
			if (other.DstId != 0)
			{
				DstId = other.DstId;
			}
			if (other.CellId != 0L)
			{
				CellId = other.CellId;
			}
			if (other.State != BattleState.None)
			{
				State = other.State;
			}
			if (other.ConnAddr.Length != 0)
			{
				ConnAddr = other.ConnAddr;
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
				BattleType = input.ReadInt32();
				break;
			case 24u:
				SrcId = input.ReadUInt32();
				break;
			case 32u:
				DstId = input.ReadUInt32();
				break;
			case 40u:
				CellId = input.ReadUInt64();
				break;
			case 48u:
				State = (BattleState)input.ReadEnum();
				break;
			case 58u:
				ConnAddr = input.ReadString();
				break;
			}
		}
	}
}
