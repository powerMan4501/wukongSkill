using System;
using Google.Protobuf;
using ResB1;

namespace ArchiveB1;

public sealed class SeedConfigSyncWrapper : IMessage<SeedConfigSyncWrapper>, IMessage, IEquatable<SeedConfigSyncWrapper>, IDeepCloneable<SeedConfigSyncWrapper>
{
	private static readonly MessageParser<SeedConfigSyncWrapper> _parser = new MessageParser<SeedConfigSyncWrapper>(() => new SeedConfigSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Int32SyncWrapper seedId_;

	private Int32SyncWrapper outputItemId_;

	private Int32SyncWrapper outputInterval_;

	private Int32SyncWrapper outputMaxCount_;

	public static MessageParser<SeedConfigSyncWrapper> Parser => _parser;

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

	public Int32SyncWrapper SeedId
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

	public Int32SyncWrapper OutputItemId
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

	public Int32SyncWrapper OutputInterval
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

	public Int32SyncWrapper OutputMaxCount
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

	public SeedConfigSyncWrapper()
	{
	}

	public SeedConfigSyncWrapper(SeedConfigSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		seedId_ = ((other.seedId_ != null) ? other.seedId_.Clone() : null);
		outputItemId_ = ((other.outputItemId_ != null) ? other.outputItemId_.Clone() : null);
		outputInterval_ = ((other.outputInterval_ != null) ? other.outputInterval_.Clone() : null);
		outputMaxCount_ = ((other.outputMaxCount_ != null) ? other.outputMaxCount_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public SeedConfigSyncWrapper Clone()
	{
		return new SeedConfigSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as SeedConfigSyncWrapper);
	}

	public bool Equals(SeedConfigSyncWrapper other)
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
		if (!object.Equals(SeedId, other.SeedId))
		{
			return false;
		}
		if (!object.Equals(OutputItemId, other.OutputItemId))
		{
			return false;
		}
		if (!object.Equals(OutputInterval, other.OutputInterval))
		{
			return false;
		}
		if (!object.Equals(OutputMaxCount, other.OutputMaxCount))
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
		if (seedId_ != null)
		{
			num ^= SeedId.GetHashCode();
		}
		if (outputItemId_ != null)
		{
			num ^= OutputItemId.GetHashCode();
		}
		if (outputInterval_ != null)
		{
			num ^= OutputInterval.GetHashCode();
		}
		if (outputMaxCount_ != null)
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
		if (seedId_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(SeedId);
		}
		if (outputItemId_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(OutputItemId);
		}
		if (outputInterval_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(OutputInterval);
		}
		if (outputMaxCount_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(OutputMaxCount);
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
		if (seedId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SeedId);
		}
		if (outputItemId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OutputItemId);
		}
		if (outputInterval_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OutputInterval);
		}
		if (outputMaxCount_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OutputMaxCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(SeedConfigSyncWrapper other)
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
		if (other.seedId_ != null)
		{
			if (seedId_ == null)
			{
				SeedId = new Int32SyncWrapper();
			}
			SeedId.MergeFrom(other.SeedId);
		}
		if (other.outputItemId_ != null)
		{
			if (outputItemId_ == null)
			{
				OutputItemId = new Int32SyncWrapper();
			}
			OutputItemId.MergeFrom(other.OutputItemId);
		}
		if (other.outputInterval_ != null)
		{
			if (outputInterval_ == null)
			{
				OutputInterval = new Int32SyncWrapper();
			}
			OutputInterval.MergeFrom(other.OutputInterval);
		}
		if (other.outputMaxCount_ != null)
		{
			if (outputMaxCount_ == null)
			{
				OutputMaxCount = new Int32SyncWrapper();
			}
			OutputMaxCount.MergeFrom(other.OutputMaxCount);
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
				if (seedId_ == null)
				{
					SeedId = new Int32SyncWrapper();
				}
				input.ReadMessage(SeedId);
				break;
			case 34u:
				if (outputItemId_ == null)
				{
					OutputItemId = new Int32SyncWrapper();
				}
				input.ReadMessage(OutputItemId);
				break;
			case 42u:
				if (outputInterval_ == null)
				{
					OutputInterval = new Int32SyncWrapper();
				}
				input.ReadMessage(OutputInterval);
				break;
			case 50u:
				if (outputMaxCount_ == null)
				{
					OutputMaxCount = new Int32SyncWrapper();
				}
				input.ReadMessage(OutputMaxCount);
				break;
			}
		}
	}
}
