using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class SoulSkillDropRecord : IMessage<SoulSkillDropRecord>, IMessage, IEquatable<SoulSkillDropRecord>, IDeepCloneable<SoulSkillDropRecord>
{
	private static readonly MessageParser<SoulSkillDropRecord> _parser = new MessageParser<SoulSkillDropRecord>(() => new SoulSkillDropRecord());

	private UnknownFieldSet _unknownFields;

	private int soulSkillId_;

	private uint dropCount_;

	private SoulSkillDropStatus state_;

	public static MessageParser<SoulSkillDropRecord> Parser => _parser;

	public int SoulSkillId
	{
		get
		{
			return soulSkillId_;
		}
		set
		{
			soulSkillId_ = value;
		}
	}

	public uint DropCount
	{
		get
		{
			return dropCount_;
		}
		set
		{
			dropCount_ = value;
		}
	}

	public SoulSkillDropStatus State
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

	public SoulSkillDropRecord()
	{
	}

	public SoulSkillDropRecord(SoulSkillDropRecord other)
		: this()
	{
		soulSkillId_ = other.soulSkillId_;
		dropCount_ = other.dropCount_;
		state_ = other.state_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public SoulSkillDropRecord Clone()
	{
		return new SoulSkillDropRecord(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as SoulSkillDropRecord);
	}

	public bool Equals(SoulSkillDropRecord other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SoulSkillId != other.SoulSkillId)
		{
			return false;
		}
		if (DropCount != other.DropCount)
		{
			return false;
		}
		if (State != other.State)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SoulSkillId != 0)
		{
			num ^= SoulSkillId.GetHashCode();
		}
		if (DropCount != 0)
		{
			num ^= DropCount.GetHashCode();
		}
		if (State != SoulSkillDropStatus.None)
		{
			num ^= State.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SoulSkillId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SoulSkillId);
		}
		if (DropCount != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(DropCount);
		}
		if (State != SoulSkillDropStatus.None)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)State);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SoulSkillId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SoulSkillId);
		}
		if (DropCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DropCount);
		}
		if (State != SoulSkillDropStatus.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)State);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(SoulSkillDropRecord other)
	{
		if (other != null)
		{
			if (other.SoulSkillId != 0)
			{
				SoulSkillId = other.SoulSkillId;
			}
			if (other.DropCount != 0)
			{
				DropCount = other.DropCount;
			}
			if (other.State != SoulSkillDropStatus.None)
			{
				State = other.State;
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
				SoulSkillId = input.ReadInt32();
				break;
			case 16u:
				DropCount = input.ReadUInt32();
				break;
			case 24u:
				State = (SoulSkillDropStatus)input.ReadEnum();
				break;
			}
		}
	}
}
