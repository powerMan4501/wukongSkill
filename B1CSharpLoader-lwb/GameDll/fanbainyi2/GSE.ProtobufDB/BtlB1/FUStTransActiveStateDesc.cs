using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStTransActiveStateDesc : IMessage<FUStTransActiveStateDesc>, IMessage, IEquatable<FUStTransActiveStateDesc>, IDeepCloneable<FUStTransActiveStateDesc>
{
	private static readonly MessageParser<FUStTransActiveStateDesc> _parser = new MessageParser<FUStTransActiveStateDesc>(() => new FUStTransActiveStateDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int stateOneBuffID_;

	private int stateTwoBuffID_;

	private int stateThreeBuffID_;

	public static MessageParser<FUStTransActiveStateDesc> Parser => _parser;

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

	public int StateOneBuffID
	{
		get
		{
			return stateOneBuffID_;
		}
		set
		{
			stateOneBuffID_ = value;
		}
	}

	public int StateTwoBuffID
	{
		get
		{
			return stateTwoBuffID_;
		}
		set
		{
			stateTwoBuffID_ = value;
		}
	}

	public int StateThreeBuffID
	{
		get
		{
			return stateThreeBuffID_;
		}
		set
		{
			stateThreeBuffID_ = value;
		}
	}

	public FUStTransActiveStateDesc()
	{
	}

	public FUStTransActiveStateDesc(FUStTransActiveStateDesc other)
		: this()
	{
		iD_ = other.iD_;
		stateOneBuffID_ = other.stateOneBuffID_;
		stateTwoBuffID_ = other.stateTwoBuffID_;
		stateThreeBuffID_ = other.stateThreeBuffID_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStTransActiveStateDesc Clone()
	{
		return new FUStTransActiveStateDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStTransActiveStateDesc);
	}

	public bool Equals(FUStTransActiveStateDesc other)
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
		if (StateOneBuffID != other.StateOneBuffID)
		{
			return false;
		}
		if (StateTwoBuffID != other.StateTwoBuffID)
		{
			return false;
		}
		if (StateThreeBuffID != other.StateThreeBuffID)
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
		if (StateOneBuffID != 0)
		{
			num ^= StateOneBuffID.GetHashCode();
		}
		if (StateTwoBuffID != 0)
		{
			num ^= StateTwoBuffID.GetHashCode();
		}
		if (StateThreeBuffID != 0)
		{
			num ^= StateThreeBuffID.GetHashCode();
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
		if (StateOneBuffID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(StateOneBuffID);
		}
		if (StateTwoBuffID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(StateTwoBuffID);
		}
		if (StateThreeBuffID != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(StateThreeBuffID);
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
		if (StateOneBuffID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StateOneBuffID);
		}
		if (StateTwoBuffID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StateTwoBuffID);
		}
		if (StateThreeBuffID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(StateThreeBuffID);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStTransActiveStateDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.StateOneBuffID != 0)
			{
				StateOneBuffID = other.StateOneBuffID;
			}
			if (other.StateTwoBuffID != 0)
			{
				StateTwoBuffID = other.StateTwoBuffID;
			}
			if (other.StateThreeBuffID != 0)
			{
				StateThreeBuffID = other.StateThreeBuffID;
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
				StateOneBuffID = input.ReadInt32();
				break;
			case 24u:
				StateTwoBuffID = input.ReadInt32();
				break;
			case 32u:
				StateThreeBuffID = input.ReadInt32();
				break;
			}
		}
	}
}
