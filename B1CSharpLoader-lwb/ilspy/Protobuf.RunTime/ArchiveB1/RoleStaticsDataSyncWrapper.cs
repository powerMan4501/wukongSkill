using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class RoleStaticsDataSyncWrapper : IMessage<RoleStaticsDataSyncWrapper>, IMessage, IEquatable<RoleStaticsDataSyncWrapper>, IDeepCloneable<RoleStaticsDataSyncWrapper>
{
	private static readonly MessageParser<RoleStaticsDataSyncWrapper> _parser = new MessageParser<RoleStaticsDataSyncWrapper>(() => new RoleStaticsDataSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private ArchiveStaticsOneSyncWrapper summaryStatics_;

	private static readonly FieldCodec<ArchiveStaticsOneSyncWrapper> _repeated_historyStatics_codec = FieldCodec.ForMessage(34u, ArchiveStaticsOneSyncWrapper.Parser);

	private readonly RepeatedField<ArchiveStaticsOneSyncWrapper> historyStatics_ = new RepeatedField<ArchiveStaticsOneSyncWrapper>();

	private NewGameResetStaticsDataSyncWrapper newGameResetStatics_;

	public static MessageParser<RoleStaticsDataSyncWrapper> Parser => _parser;

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

	public ArchiveStaticsOneSyncWrapper SummaryStatics
	{
		get
		{
			return summaryStatics_;
		}
		set
		{
			summaryStatics_ = value;
		}
	}

	public RepeatedField<ArchiveStaticsOneSyncWrapper> HistoryStatics => historyStatics_;

	public NewGameResetStaticsDataSyncWrapper NewGameResetStatics
	{
		get
		{
			return newGameResetStatics_;
		}
		set
		{
			newGameResetStatics_ = value;
		}
	}

	public RoleStaticsDataSyncWrapper()
	{
	}

	public RoleStaticsDataSyncWrapper(RoleStaticsDataSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		summaryStatics_ = ((other.summaryStatics_ != null) ? other.summaryStatics_.Clone() : null);
		historyStatics_ = other.historyStatics_.Clone();
		newGameResetStatics_ = ((other.newGameResetStatics_ != null) ? other.newGameResetStatics_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleStaticsDataSyncWrapper Clone()
	{
		return new RoleStaticsDataSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleStaticsDataSyncWrapper);
	}

	public bool Equals(RoleStaticsDataSyncWrapper other)
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
		if (!object.Equals(SummaryStatics, other.SummaryStatics))
		{
			return false;
		}
		if (!historyStatics_.Equals(other.historyStatics_))
		{
			return false;
		}
		if (!object.Equals(NewGameResetStatics, other.NewGameResetStatics))
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
		if (summaryStatics_ != null)
		{
			num ^= SummaryStatics.GetHashCode();
		}
		num ^= historyStatics_.GetHashCode();
		if (newGameResetStatics_ != null)
		{
			num ^= NewGameResetStatics.GetHashCode();
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
		if (summaryStatics_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(SummaryStatics);
		}
		historyStatics_.WriteTo(output, _repeated_historyStatics_codec);
		if (newGameResetStatics_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(NewGameResetStatics);
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
		if (summaryStatics_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SummaryStatics);
		}
		num += historyStatics_.CalculateSize(_repeated_historyStatics_codec);
		if (newGameResetStatics_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NewGameResetStatics);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleStaticsDataSyncWrapper other)
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
		if (other.summaryStatics_ != null)
		{
			if (summaryStatics_ == null)
			{
				SummaryStatics = new ArchiveStaticsOneSyncWrapper();
			}
			SummaryStatics.MergeFrom(other.SummaryStatics);
		}
		historyStatics_.Add(other.historyStatics_);
		if (other.newGameResetStatics_ != null)
		{
			if (newGameResetStatics_ == null)
			{
				NewGameResetStatics = new NewGameResetStaticsDataSyncWrapper();
			}
			NewGameResetStatics.MergeFrom(other.NewGameResetStatics);
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
				if (summaryStatics_ == null)
				{
					SummaryStatics = new ArchiveStaticsOneSyncWrapper();
				}
				input.ReadMessage(SummaryStatics);
				break;
			case 34u:
				historyStatics_.AddEntriesFrom(input, _repeated_historyStatics_codec);
				break;
			case 42u:
				if (newGameResetStatics_ == null)
				{
					NewGameResetStatics = new NewGameResetStaticsDataSyncWrapper();
				}
				input.ReadMessage(NewGameResetStatics);
				break;
			}
		}
	}
}
