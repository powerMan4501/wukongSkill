using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class OutputConfig : IMessage<OutputConfig>, IMessage, IEquatable<OutputConfig>, IDeepCloneable<OutputConfig>
{
	private static readonly MessageParser<OutputConfig> _parser = new MessageParser<OutputConfig>(() => new OutputConfig());

	private UnknownFieldSet _unknownFields;

	private int outputItemId_;

	private int outputInterval_;

	private int outputMaxCount_;

	public static MessageParser<OutputConfig> Parser => _parser;

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

	public OutputConfig()
	{
	}

	public OutputConfig(OutputConfig other)
		: this()
	{
		outputItemId_ = other.outputItemId_;
		outputInterval_ = other.outputInterval_;
		outputMaxCount_ = other.outputMaxCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public OutputConfig Clone()
	{
		return new OutputConfig(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as OutputConfig);
	}

	public bool Equals(OutputConfig other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
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
		if (OutputItemId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(OutputItemId);
		}
		if (OutputInterval != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(OutputInterval);
		}
		if (OutputMaxCount != 0)
		{
			output.WriteRawTag(24);
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

	public void MergeFrom(OutputConfig other)
	{
		if (other != null)
		{
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
				OutputItemId = input.ReadInt32();
				break;
			case 16u:
				OutputInterval = input.ReadInt32();
				break;
			case 24u:
				OutputMaxCount = input.ReadInt32();
				break;
			}
		}
	}
}
