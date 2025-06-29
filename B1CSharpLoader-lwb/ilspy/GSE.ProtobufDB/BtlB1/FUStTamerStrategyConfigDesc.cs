using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStTamerStrategyConfigDesc : IMessage<FUStTamerStrategyConfigDesc>, IMessage, IEquatable<FUStTamerStrategyConfigDesc>, IDeepCloneable<FUStTamerStrategyConfigDesc>
{
	private static readonly MessageParser<FUStTamerStrategyConfigDesc> _parser = new MessageParser<FUStTamerStrategyConfigDesc>(() => new FUStTamerStrategyConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string unitGuid_ = "";

	private int battleDist_;

	private int visibleDist_;

	private int destroyDist_;

	private int battleZOffset_;

	private int destroyZOffset_;

	public static MessageParser<FUStTamerStrategyConfigDesc> Parser => _parser;

	public int ID
	{
		get
		{
			return iD_;
		}
		set
		{
			iD_ = value;
		}
	}

	public string UnitGuid
	{
		get
		{
			return unitGuid_;
		}
		set
		{
			unitGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int BattleDist
	{
		get
		{
			return battleDist_;
		}
		set
		{
			battleDist_ = value;
		}
	}

	public int VisibleDist
	{
		get
		{
			return visibleDist_;
		}
		set
		{
			visibleDist_ = value;
		}
	}

	public int DestroyDist
	{
		get
		{
			return destroyDist_;
		}
		set
		{
			destroyDist_ = value;
		}
	}

	public int BattleZOffset
	{
		get
		{
			return battleZOffset_;
		}
		set
		{
			battleZOffset_ = value;
		}
	}

	public int DestroyZOffset
	{
		get
		{
			return destroyZOffset_;
		}
		set
		{
			destroyZOffset_ = value;
		}
	}

	public FUStTamerStrategyConfigDesc()
	{
	}

	public FUStTamerStrategyConfigDesc(FUStTamerStrategyConfigDesc other)
		: this()
	{
		iD_ = other.iD_;
		unitGuid_ = other.unitGuid_;
		battleDist_ = other.battleDist_;
		visibleDist_ = other.visibleDist_;
		destroyDist_ = other.destroyDist_;
		battleZOffset_ = other.battleZOffset_;
		destroyZOffset_ = other.destroyZOffset_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStTamerStrategyConfigDesc Clone()
	{
		return new FUStTamerStrategyConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStTamerStrategyConfigDesc);
	}

	public bool Equals(FUStTamerStrategyConfigDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ID != other.ID)
		{
			return false;
		}
		if (UnitGuid != other.UnitGuid)
		{
			return false;
		}
		if (BattleDist != other.BattleDist)
		{
			return false;
		}
		if (VisibleDist != other.VisibleDist)
		{
			return false;
		}
		if (DestroyDist != other.DestroyDist)
		{
			return false;
		}
		if (BattleZOffset != other.BattleZOffset)
		{
			return false;
		}
		if (DestroyZOffset != other.DestroyZOffset)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ID != 0)
		{
			num ^= ID.GetHashCode();
		}
		if (UnitGuid.Length != 0)
		{
			num ^= UnitGuid.GetHashCode();
		}
		if (BattleDist != 0)
		{
			num ^= BattleDist.GetHashCode();
		}
		if (VisibleDist != 0)
		{
			num ^= VisibleDist.GetHashCode();
		}
		if (DestroyDist != 0)
		{
			num ^= DestroyDist.GetHashCode();
		}
		if (BattleZOffset != 0)
		{
			num ^= BattleZOffset.GetHashCode();
		}
		if (DestroyZOffset != 0)
		{
			num ^= DestroyZOffset.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ID);
		}
		if (UnitGuid.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(UnitGuid);
		}
		if (BattleDist != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BattleDist);
		}
		if (VisibleDist != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(VisibleDist);
		}
		if (DestroyDist != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(DestroyDist);
		}
		if (BattleZOffset != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(BattleZOffset);
		}
		if (DestroyZOffset != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(DestroyZOffset);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ID);
		}
		if (UnitGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UnitGuid);
		}
		if (BattleDist != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleDist);
		}
		if (VisibleDist != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(VisibleDist);
		}
		if (DestroyDist != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DestroyDist);
		}
		if (BattleZOffset != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleZOffset);
		}
		if (DestroyZOffset != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DestroyZOffset);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStTamerStrategyConfigDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.UnitGuid.Length != 0)
			{
				UnitGuid = other.UnitGuid;
			}
			if (other.BattleDist != 0)
			{
				BattleDist = other.BattleDist;
			}
			if (other.VisibleDist != 0)
			{
				VisibleDist = other.VisibleDist;
			}
			if (other.DestroyDist != 0)
			{
				DestroyDist = other.DestroyDist;
			}
			if (other.BattleZOffset != 0)
			{
				BattleZOffset = other.BattleZOffset;
			}
			if (other.DestroyZOffset != 0)
			{
				DestroyZOffset = other.DestroyZOffset;
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
				ID = input.ReadInt32();
				break;
			case 18u:
				UnitGuid = input.ReadString();
				break;
			case 24u:
				BattleDist = input.ReadInt32();
				break;
			case 32u:
				VisibleDist = input.ReadInt32();
				break;
			case 40u:
				DestroyDist = input.ReadInt32();
				break;
			case 48u:
				BattleZOffset = input.ReadInt32();
				break;
			case 56u:
				DestroyZOffset = input.ReadInt32();
				break;
			}
		}
	}
}
