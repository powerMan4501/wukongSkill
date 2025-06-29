using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class DropRecord : IMessage<DropRecord>, IMessage, IEquatable<DropRecord>, IDeepCloneable<DropRecord>
{
	private static readonly MessageParser<DropRecord> _parser = new MessageParser<DropRecord>(() => new DropRecord());

	private UnknownFieldSet _unknownFields;

	private int dropId_;

	private uint dropCount_;

	private uint guaranteeDropCount_;

	public static MessageParser<DropRecord> Parser => _parser;

	public int DropId
	{
		get
		{
			return dropId_;
		}
		set
		{
			dropId_ = value;
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

	public uint GuaranteeDropCount
	{
		get
		{
			return guaranteeDropCount_;
		}
		set
		{
			guaranteeDropCount_ = value;
		}
	}

	public DropRecord()
	{
	}

	public DropRecord(DropRecord other)
		: this()
	{
		dropId_ = other.dropId_;
		dropCount_ = other.dropCount_;
		guaranteeDropCount_ = other.guaranteeDropCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DropRecord Clone()
	{
		return new DropRecord(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DropRecord);
	}

	public bool Equals(DropRecord other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DropId != other.DropId)
		{
			return false;
		}
		if (DropCount != other.DropCount)
		{
			return false;
		}
		if (GuaranteeDropCount != other.GuaranteeDropCount)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (DropId != 0)
		{
			num ^= DropId.GetHashCode();
		}
		if (DropCount != 0)
		{
			num ^= DropCount.GetHashCode();
		}
		if (GuaranteeDropCount != 0)
		{
			num ^= GuaranteeDropCount.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (DropId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(DropId);
		}
		if (DropCount != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(DropCount);
		}
		if (GuaranteeDropCount != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(GuaranteeDropCount);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (DropId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DropId);
		}
		if (DropCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DropCount);
		}
		if (GuaranteeDropCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GuaranteeDropCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(DropRecord other)
	{
		if (other != null)
		{
			if (other.DropId != 0)
			{
				DropId = other.DropId;
			}
			if (other.DropCount != 0)
			{
				DropCount = other.DropCount;
			}
			if (other.GuaranteeDropCount != 0)
			{
				GuaranteeDropCount = other.GuaranteeDropCount;
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
				DropId = input.ReadInt32();
				break;
			case 16u:
				DropCount = input.ReadUInt32();
				break;
			case 24u:
				GuaranteeDropCount = input.ReadUInt32();
				break;
			}
		}
	}
}
