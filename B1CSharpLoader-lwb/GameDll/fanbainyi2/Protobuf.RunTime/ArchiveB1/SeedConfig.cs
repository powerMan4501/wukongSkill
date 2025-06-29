using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class SeedConfig : IMessage<SeedConfig>, IMessage, IEquatable<SeedConfig>, IDeepCloneable<SeedConfig>
{
	private static readonly MessageParser<SeedConfig> _parser = new MessageParser<SeedConfig>(() => new SeedConfig());

	private UnknownFieldSet _unknownFields;

	private int seedId_;

	private int outputItemId_;

	private int outputInterval_;

	private int outputMaxCount_;

	public static MessageParser<SeedConfig> Parser => _parser;

	public int SeedId
	{
		get
		{
			return seedId_;
		}
		set
		{
			seedId_ = value;
		}
	}

	public int OutputItemId
	{
		get
		{
			return outputItemId_;
		}
		set
		{
			outputItemId_ = value;
		}
	}

	public int OutputInterval
	{
		get
		{
			return outputInterval_;
		}
		set
		{
			outputInterval_ = value;
		}
	}

	public int OutputMaxCount
	{
		get
		{
			return outputMaxCount_;
		}
		set
		{
			outputMaxCount_ = value;
		}
	}

	public SeedConfig()
	{
	}

	public SeedConfig(SeedConfig other)
		: this()
	{
		seedId_ = other.seedId_;
		outputItemId_ = other.outputItemId_;
		outputInterval_ = other.outputInterval_;
		outputMaxCount_ = other.outputMaxCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public SeedConfig Clone()
	{
		return new SeedConfig(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as SeedConfig);
	}

	public bool Equals(SeedConfig other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SeedId != other.SeedId)
		{
			return false;
		}
		if (OutputItemId != other.OutputItemId)
		{
			return false;
		}
		if (OutputInterval != other.OutputInterval)
		{
			return false;
		}
		if (OutputMaxCount != other.OutputMaxCount)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SeedId != 0)
		{
			num ^= SeedId.GetHashCode();
		}
		if (OutputItemId != 0)
		{
			num ^= OutputItemId.GetHashCode();
		}
		if (OutputInterval != 0)
		{
			num ^= OutputInterval.GetHashCode();
		}
		if (OutputMaxCount != 0)
		{
			num ^= OutputMaxCount.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SeedId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SeedId);
		}
		if (OutputItemId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(OutputItemId);
		}
		if (OutputInterval != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(OutputInterval);
		}
		if (OutputMaxCount != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(OutputMaxCount);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SeedId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SeedId);
		}
		if (OutputItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OutputItemId);
		}
		if (OutputInterval != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OutputInterval);
		}
		if (OutputMaxCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OutputMaxCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(SeedConfig other)
	{
		if (other != null)
		{
			if (other.SeedId != 0)
			{
				SeedId = other.SeedId;
			}
			if (other.OutputItemId != 0)
			{
				OutputItemId = other.OutputItemId;
			}
			if (other.OutputInterval != 0)
			{
				OutputInterval = other.OutputInterval;
			}
			if (other.OutputMaxCount != 0)
			{
				OutputMaxCount = other.OutputMaxCount;
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
				SeedId = input.ReadInt32();
				break;
			case 16u:
				OutputItemId = input.ReadInt32();
				break;
			case 24u:
				OutputInterval = input.ReadInt32();
				break;
			case 32u:
				OutputMaxCount = input.ReadInt32();
				break;
			}
		}
	}
}
