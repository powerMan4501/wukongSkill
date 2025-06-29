using System;
using Google.Protobuf;

namespace CommB1;

public sealed class MailFilter : IMessage<MailFilter>, IMessage, IEquatable<MailFilter>, IDeepCloneable<MailFilter>
{
	private static readonly MessageParser<MailFilter> _parser = new MessageParser<MailFilter>(() => new MailFilter());

	private UnknownFieldSet _unknownFields;

	private uint minLv_;

	private uint maxLv_;

	private uint ltRegisTime_;

	private uint gtRegisTime_;

	private uint world_;

	public static MessageParser<MailFilter> Parser => _parser;

	public uint MinLv
	{
		get
		{
			return minLv_;
		}
		set
		{
			minLv_ = value;
		}
	}

	public uint MaxLv
	{
		get
		{
			return maxLv_;
		}
		set
		{
			maxLv_ = value;
		}
	}

	public uint LtRegisTime
	{
		get
		{
			return ltRegisTime_;
		}
		set
		{
			ltRegisTime_ = value;
		}
	}

	public uint GtRegisTime
	{
		get
		{
			return gtRegisTime_;
		}
		set
		{
			gtRegisTime_ = value;
		}
	}

	public uint World
	{
		get
		{
			return world_;
		}
		set
		{
			world_ = value;
		}
	}

	public MailFilter()
	{
	}

	public MailFilter(MailFilter other)
		: this()
	{
		minLv_ = other.minLv_;
		maxLv_ = other.maxLv_;
		ltRegisTime_ = other.ltRegisTime_;
		gtRegisTime_ = other.gtRegisTime_;
		world_ = other.world_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MailFilter Clone()
	{
		return new MailFilter(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MailFilter);
	}

	public bool Equals(MailFilter other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MinLv != other.MinLv)
		{
			return false;
		}
		if (MaxLv != other.MaxLv)
		{
			return false;
		}
		if (LtRegisTime != other.LtRegisTime)
		{
			return false;
		}
		if (GtRegisTime != other.GtRegisTime)
		{
			return false;
		}
		if (World != other.World)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (MinLv != 0)
		{
			num ^= MinLv.GetHashCode();
		}
		if (MaxLv != 0)
		{
			num ^= MaxLv.GetHashCode();
		}
		if (LtRegisTime != 0)
		{
			num ^= LtRegisTime.GetHashCode();
		}
		if (GtRegisTime != 0)
		{
			num ^= GtRegisTime.GetHashCode();
		}
		if (World != 0)
		{
			num ^= World.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (MinLv != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(MinLv);
		}
		if (MaxLv != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(MaxLv);
		}
		if (LtRegisTime != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(LtRegisTime);
		}
		if (GtRegisTime != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(GtRegisTime);
		}
		if (World != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(World);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (MinLv != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MinLv);
		}
		if (MaxLv != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MaxLv);
		}
		if (LtRegisTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LtRegisTime);
		}
		if (GtRegisTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GtRegisTime);
		}
		if (World != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(World);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MailFilter other)
	{
		if (other != null)
		{
			if (other.MinLv != 0)
			{
				MinLv = other.MinLv;
			}
			if (other.MaxLv != 0)
			{
				MaxLv = other.MaxLv;
			}
			if (other.LtRegisTime != 0)
			{
				LtRegisTime = other.LtRegisTime;
			}
			if (other.GtRegisTime != 0)
			{
				GtRegisTime = other.GtRegisTime;
			}
			if (other.World != 0)
			{
				World = other.World;
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
				MinLv = input.ReadUInt32();
				break;
			case 16u:
				MaxLv = input.ReadUInt32();
				break;
			case 24u:
				LtRegisTime = input.ReadUInt32();
				break;
			case 32u:
				GtRegisTime = input.ReadUInt32();
				break;
			case 40u:
				World = input.ReadUInt32();
				break;
			}
		}
	}
}
