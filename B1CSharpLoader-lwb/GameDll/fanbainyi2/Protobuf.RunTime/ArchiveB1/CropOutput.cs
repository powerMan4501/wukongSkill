using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class CropOutput : IMessage<CropOutput>, IMessage, IEquatable<CropOutput>, IDeepCloneable<CropOutput>
{
	private static readonly MessageParser<CropOutput> _parser = new MessageParser<CropOutput>(() => new CropOutput());

	private UnknownFieldSet _unknownFields;

	private OutputConfig outputConfig_;

	private int outputCount_;

	private float deltaTime_;

	public static MessageParser<CropOutput> Parser => _parser;

	public OutputConfig OutputConfig
	{
		get
		{
			return outputConfig_;
		}
		set
		{
			outputConfig_ = value;
		}
	}

	public int OutputCount
	{
		get
		{
			return outputCount_;
		}
		set
		{
			outputCount_ = value;
		}
	}

	public float DeltaTime
	{
		get
		{
			return deltaTime_;
		}
		set
		{
			deltaTime_ = value;
		}
	}

	public CropOutput()
	{
	}

	public CropOutput(CropOutput other)
		: this()
	{
		outputConfig_ = ((other.outputConfig_ != null) ? other.outputConfig_.Clone() : null);
		outputCount_ = other.outputCount_;
		deltaTime_ = other.deltaTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CropOutput Clone()
	{
		return new CropOutput(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CropOutput);
	}

	public bool Equals(CropOutput other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(OutputConfig, other.OutputConfig))
		{
			return false;
		}
		if (OutputCount != other.OutputCount)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DeltaTime, other.DeltaTime))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (outputConfig_ != null)
		{
			num ^= OutputConfig.GetHashCode();
		}
		if (OutputCount != 0)
		{
			num ^= OutputCount.GetHashCode();
		}
		if (DeltaTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DeltaTime);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (outputConfig_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(OutputConfig);
		}
		if (OutputCount != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(OutputCount);
		}
		if (DeltaTime != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(DeltaTime);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (outputConfig_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OutputConfig);
		}
		if (OutputCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OutputCount);
		}
		if (DeltaTime != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CropOutput other)
	{
		if (other == null)
		{
			return;
		}
		if (other.outputConfig_ != null)
		{
			if (outputConfig_ == null)
			{
				OutputConfig = new OutputConfig();
			}
			OutputConfig.MergeFrom(other.OutputConfig);
		}
		if (other.OutputCount != 0)
		{
			OutputCount = other.OutputCount;
		}
		if (other.DeltaTime != 0f)
		{
			DeltaTime = other.DeltaTime;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 10u:
				if (outputConfig_ == null)
				{
					OutputConfig = new OutputConfig();
				}
				input.ReadMessage(OutputConfig);
				break;
			case 16u:
				OutputCount = input.ReadInt32();
				break;
			case 29u:
				DeltaTime = input.ReadFloat();
				break;
			}
		}
	}
}
