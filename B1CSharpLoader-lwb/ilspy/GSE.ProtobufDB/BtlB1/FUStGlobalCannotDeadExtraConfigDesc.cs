using System;
using BtlShare;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStGlobalCannotDeadExtraConfigDesc : IMessage<FUStGlobalCannotDeadExtraConfigDesc>, IMessage, IEquatable<FUStGlobalCannotDeadExtraConfigDesc>, IDeepCloneable<FUStGlobalCannotDeadExtraConfigDesc>
{
	private static readonly MessageParser<FUStGlobalCannotDeadExtraConfigDesc> _parser = new MessageParser<FUStGlobalCannotDeadExtraConfigDesc>(() => new FUStGlobalCannotDeadExtraConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int resID_;

	private EDeadReason canSkipDeadReason_;

	public static MessageParser<FUStGlobalCannotDeadExtraConfigDesc> Parser => _parser;

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

	public int ResID
	{
		get
		{
			return resID_;
		}
		set
		{
			resID_ = value;
		}
	}

	public EDeadReason CanSkipDeadReason
	{
		get
		{
			return canSkipDeadReason_;
		}
		set
		{
			canSkipDeadReason_ = value;
		}
	}

	public FUStGlobalCannotDeadExtraConfigDesc()
	{
	}

	public FUStGlobalCannotDeadExtraConfigDesc(FUStGlobalCannotDeadExtraConfigDesc other)
		: this()
	{
		iD_ = other.iD_;
		resID_ = other.resID_;
		canSkipDeadReason_ = other.canSkipDeadReason_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStGlobalCannotDeadExtraConfigDesc Clone()
	{
		return new FUStGlobalCannotDeadExtraConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStGlobalCannotDeadExtraConfigDesc);
	}

	public bool Equals(FUStGlobalCannotDeadExtraConfigDesc other)
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
		if (ResID != other.ResID)
		{
			return false;
		}
		if (CanSkipDeadReason != other.CanSkipDeadReason)
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
		if (ResID != 0)
		{
			num ^= ResID.GetHashCode();
		}
		if (CanSkipDeadReason != EDeadReason.None)
		{
			num ^= CanSkipDeadReason.GetHashCode();
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
		if (ResID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ResID);
		}
		if (CanSkipDeadReason != EDeadReason.None)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)CanSkipDeadReason);
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
		if (ResID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResID);
		}
		if (CanSkipDeadReason != EDeadReason.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CanSkipDeadReason);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStGlobalCannotDeadExtraConfigDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.ResID != 0)
			{
				ResID = other.ResID;
			}
			if (other.CanSkipDeadReason != EDeadReason.None)
			{
				CanSkipDeadReason = other.CanSkipDeadReason;
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
				ResID = input.ReadInt32();
				break;
			case 24u:
				CanSkipDeadReason = (EDeadReason)input.ReadEnum();
				break;
			}
		}
	}
}
