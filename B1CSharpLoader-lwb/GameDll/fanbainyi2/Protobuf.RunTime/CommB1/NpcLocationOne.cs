using System;
using Google.Protobuf;

namespace CommB1;

public sealed class NpcLocationOne : IMessage<NpcLocationOne>, IMessage, IEquatable<NpcLocationOne>, IDeepCloneable<NpcLocationOne>
{
	private static readonly MessageParser<NpcLocationOne> _parser = new MessageParser<NpcLocationOne>(() => new NpcLocationOne());

	private UnknownFieldSet _unknownFields;

	private int npcId_;

	private int rebirthPointId_;

	private int sortId_;

	public static MessageParser<NpcLocationOne> Parser => _parser;

	public int NpcId
	{
		get
		{
			return npcId_;
		}
		set
		{
			npcId_ = value;
		}
	}

	public int RebirthPointId
	{
		get
		{
			return rebirthPointId_;
		}
		set
		{
			rebirthPointId_ = value;
		}
	}

	public int SortId
	{
		get
		{
			return sortId_;
		}
		set
		{
			sortId_ = value;
		}
	}

	public NpcLocationOne()
	{
	}

	public NpcLocationOne(NpcLocationOne other)
		: this()
	{
		npcId_ = other.npcId_;
		rebirthPointId_ = other.rebirthPointId_;
		sortId_ = other.sortId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public NpcLocationOne Clone()
	{
		return new NpcLocationOne(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as NpcLocationOne);
	}

	public bool Equals(NpcLocationOne other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NpcId != other.NpcId)
		{
			return false;
		}
		if (RebirthPointId != other.RebirthPointId)
		{
			return false;
		}
		if (SortId != other.SortId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (NpcId != 0)
		{
			num ^= NpcId.GetHashCode();
		}
		if (RebirthPointId != 0)
		{
			num ^= RebirthPointId.GetHashCode();
		}
		if (SortId != 0)
		{
			num ^= SortId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (NpcId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(NpcId);
		}
		if (RebirthPointId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(RebirthPointId);
		}
		if (SortId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(SortId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (NpcId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NpcId);
		}
		if (RebirthPointId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RebirthPointId);
		}
		if (SortId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SortId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(NpcLocationOne other)
	{
		if (other != null)
		{
			if (other.NpcId != 0)
			{
				NpcId = other.NpcId;
			}
			if (other.RebirthPointId != 0)
			{
				RebirthPointId = other.RebirthPointId;
			}
			if (other.SortId != 0)
			{
				SortId = other.SortId;
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
				NpcId = input.ReadInt32();
				break;
			case 16u:
				RebirthPointId = input.ReadInt32();
				break;
			case 24u:
				SortId = input.ReadInt32();
				break;
			}
		}
	}
}
