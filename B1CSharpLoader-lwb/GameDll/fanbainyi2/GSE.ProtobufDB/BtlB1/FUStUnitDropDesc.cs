using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStUnitDropDesc : IMessage<FUStUnitDropDesc>, IMessage, IEquatable<FUStUnitDropDesc>, IDeepCloneable<FUStUnitDropDesc>
{
	private static readonly MessageParser<FUStUnitDropDesc> _parser = new MessageParser<FUStUnitDropDesc>(() => new FUStUnitDropDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int dropNum_;

	private int roomIdx_;

	public static MessageParser<FUStUnitDropDesc> Parser => _parser;

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

	public int DropNum
	{
		get
		{
			return dropNum_;
		}
		set
		{
			dropNum_ = value;
		}
	}

	public int RoomIdx
	{
		get
		{
			return roomIdx_;
		}
		set
		{
			roomIdx_ = value;
		}
	}

	public FUStUnitDropDesc()
	{
	}

	public FUStUnitDropDesc(FUStUnitDropDesc other)
		: this()
	{
		iD_ = other.iD_;
		dropNum_ = other.dropNum_;
		roomIdx_ = other.roomIdx_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStUnitDropDesc Clone()
	{
		return new FUStUnitDropDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStUnitDropDesc);
	}

	public bool Equals(FUStUnitDropDesc other)
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
		if (DropNum != other.DropNum)
		{
			return false;
		}
		if (RoomIdx != other.RoomIdx)
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
		if (DropNum != 0)
		{
			num ^= DropNum.GetHashCode();
		}
		if (RoomIdx != 0)
		{
			num ^= RoomIdx.GetHashCode();
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
		if (DropNum != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(DropNum);
		}
		if (RoomIdx != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(RoomIdx);
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
		if (DropNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DropNum);
		}
		if (RoomIdx != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RoomIdx);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStUnitDropDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.DropNum != 0)
			{
				DropNum = other.DropNum;
			}
			if (other.RoomIdx != 0)
			{
				RoomIdx = other.RoomIdx;
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
			case 16u:
				DropNum = input.ReadInt32();
				break;
			case 24u:
				RoomIdx = input.ReadInt32();
				break;
			}
		}
	}
}
