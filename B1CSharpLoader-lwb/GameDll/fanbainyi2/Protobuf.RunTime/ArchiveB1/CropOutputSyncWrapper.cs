using System;
using Google.Protobuf;
using ResB1;

namespace ArchiveB1;

public sealed class CropOutputSyncWrapper : IMessage<CropOutputSyncWrapper>, IMessage, IEquatable<CropOutputSyncWrapper>, IDeepCloneable<CropOutputSyncWrapper>
{
	private static readonly MessageParser<CropOutputSyncWrapper> _parser = new MessageParser<CropOutputSyncWrapper>(() => new CropOutputSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private OutputConfigSyncWrapper outputConfig_;

	private Int32SyncWrapper outputCount_;

	private FloatSyncWrapper deltaTime_;

	public static MessageParser<CropOutputSyncWrapper> Parser => _parser;

	public int SyncFlag
	{
		get
		{
			return syncFlag_;
		}
		set
		{
			syncFlag_ = value;
		}
	}

	public int SyncIdx
	{
		get
		{
			return syncIdx_;
		}
		set
		{
			syncIdx_ = value;
		}
	}

	public OutputConfigSyncWrapper OutputConfig
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

	public Int32SyncWrapper OutputCount
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

	public FloatSyncWrapper DeltaTime
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

	public CropOutputSyncWrapper()
	{
	}

	public CropOutputSyncWrapper(CropOutputSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		outputConfig_ = ((other.outputConfig_ != null) ? other.outputConfig_.Clone() : null);
		outputCount_ = ((other.outputCount_ != null) ? other.outputCount_.Clone() : null);
		deltaTime_ = ((other.deltaTime_ != null) ? other.deltaTime_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CropOutputSyncWrapper Clone()
	{
		return new CropOutputSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CropOutputSyncWrapper);
	}

	public bool Equals(CropOutputSyncWrapper other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SyncFlag != other.SyncFlag)
		{
			return false;
		}
		if (SyncIdx != other.SyncIdx)
		{
			return false;
		}
		if (!object.Equals(OutputConfig, other.OutputConfig))
		{
			return false;
		}
		if (!object.Equals(OutputCount, other.OutputCount))
		{
			return false;
		}
		if (!object.Equals(DeltaTime, other.DeltaTime))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SyncFlag != 0)
		{
			num ^= SyncFlag.GetHashCode();
		}
		if (SyncIdx != 0)
		{
			num ^= SyncIdx.GetHashCode();
		}
		if (outputConfig_ != null)
		{
			num ^= OutputConfig.GetHashCode();
		}
		if (outputCount_ != null)
		{
			num ^= OutputCount.GetHashCode();
		}
		if (deltaTime_ != null)
		{
			num ^= DeltaTime.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SyncFlag != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SyncIdx);
		}
		if (outputConfig_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(OutputConfig);
		}
		if (outputCount_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(OutputCount);
		}
		if (deltaTime_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(DeltaTime);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SyncFlag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncIdx);
		}
		if (outputConfig_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OutputConfig);
		}
		if (outputCount_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OutputCount);
		}
		if (deltaTime_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DeltaTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CropOutputSyncWrapper other)
	{
		if (other == null)
		{
			return;
		}
		if (other.SyncFlag != 0)
		{
			SyncFlag = other.SyncFlag;
		}
		if (other.SyncIdx != 0)
		{
			SyncIdx = other.SyncIdx;
		}
		if (other.outputConfig_ != null)
		{
			if (outputConfig_ == null)
			{
				OutputConfig = new OutputConfigSyncWrapper();
			}
			OutputConfig.MergeFrom(other.OutputConfig);
		}
		if (other.outputCount_ != null)
		{
			if (outputCount_ == null)
			{
				OutputCount = new Int32SyncWrapper();
			}
			OutputCount.MergeFrom(other.OutputCount);
		}
		if (other.deltaTime_ != null)
		{
			if (deltaTime_ == null)
			{
				DeltaTime = new FloatSyncWrapper();
			}
			DeltaTime.MergeFrom(other.DeltaTime);
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
			case 8u:
				SyncFlag = input.ReadInt32();
				break;
			case 16u:
				SyncIdx = input.ReadInt32();
				break;
			case 26u:
				if (outputConfig_ == null)
				{
					OutputConfig = new OutputConfigSyncWrapper();
				}
				input.ReadMessage(OutputConfig);
				break;
			case 34u:
				if (outputCount_ == null)
				{
					OutputCount = new Int32SyncWrapper();
				}
				input.ReadMessage(OutputCount);
				break;
			case 42u:
				if (deltaTime_ == null)
				{
					DeltaTime = new FloatSyncWrapper();
				}
				input.ReadMessage(DeltaTime);
				break;
			}
		}
	}
}
