using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace ArchiveB1;

public sealed class NewGameResetStaticsDataSyncWrapper : IMessage<NewGameResetStaticsDataSyncWrapper>, IMessage, IEquatable<NewGameResetStaticsDataSyncWrapper>, IDeepCloneable<NewGameResetStaticsDataSyncWrapper>
{
	private static readonly MessageParser<NewGameResetStaticsDataSyncWrapper> _parser = new MessageParser<NewGameResetStaticsDataSyncWrapper>(() => new NewGameResetStaticsDataSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Int32SyncWrapper lastGamePlusId_;

	private static readonly FieldCodec<LevelStaticsDataOneSyncWrapper> _repeated_consoleLevelStatics_codec = FieldCodec.ForMessage(34u, LevelStaticsDataOneSyncWrapper.Parser);

	private readonly RepeatedField<LevelStaticsDataOneSyncWrapper> consoleLevelStatics_ = new RepeatedField<LevelStaticsDataOneSyncWrapper>();

	private static readonly FieldCodec<ChapterStaticsDataOneSyncWrapper> _repeated_chapterStatics_codec = FieldCodec.ForMessage(42u, ChapterStaticsDataOneSyncWrapper.Parser);

	private readonly RepeatedField<ChapterStaticsDataOneSyncWrapper> chapterStatics_ = new RepeatedField<ChapterStaticsDataOneSyncWrapper>();

	public static MessageParser<NewGameResetStaticsDataSyncWrapper> Parser => _parser;

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

	public Int32SyncWrapper LastGamePlusId
	{
		get
		{
			return lastGamePlusId_;
		}
		set
		{
			lastGamePlusId_ = value;
		}
	}

	public RepeatedField<LevelStaticsDataOneSyncWrapper> ConsoleLevelStatics => consoleLevelStatics_;

	public RepeatedField<ChapterStaticsDataOneSyncWrapper> ChapterStatics => chapterStatics_;

	public NewGameResetStaticsDataSyncWrapper()
	{
	}

	public NewGameResetStaticsDataSyncWrapper(NewGameResetStaticsDataSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		lastGamePlusId_ = ((other.lastGamePlusId_ != null) ? other.lastGamePlusId_.Clone() : null);
		consoleLevelStatics_ = other.consoleLevelStatics_.Clone();
		chapterStatics_ = other.chapterStatics_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public NewGameResetStaticsDataSyncWrapper Clone()
	{
		return new NewGameResetStaticsDataSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as NewGameResetStaticsDataSyncWrapper);
	}

	public bool Equals(NewGameResetStaticsDataSyncWrapper other)
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
		if (!object.Equals(LastGamePlusId, other.LastGamePlusId))
		{
			return false;
		}
		if (!consoleLevelStatics_.Equals(other.consoleLevelStatics_))
		{
			return false;
		}
		if (!chapterStatics_.Equals(other.chapterStatics_))
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
		if (lastGamePlusId_ != null)
		{
			num ^= LastGamePlusId.GetHashCode();
		}
		num ^= consoleLevelStatics_.GetHashCode();
		num ^= chapterStatics_.GetHashCode();
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
		if (lastGamePlusId_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(LastGamePlusId);
		}
		consoleLevelStatics_.WriteTo(output, _repeated_consoleLevelStatics_codec);
		chapterStatics_.WriteTo(output, _repeated_chapterStatics_codec);
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
		if (lastGamePlusId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LastGamePlusId);
		}
		num += consoleLevelStatics_.CalculateSize(_repeated_consoleLevelStatics_codec);
		num += chapterStatics_.CalculateSize(_repeated_chapterStatics_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(NewGameResetStaticsDataSyncWrapper other)
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
		if (other.lastGamePlusId_ != null)
		{
			if (lastGamePlusId_ == null)
			{
				LastGamePlusId = new Int32SyncWrapper();
			}
			LastGamePlusId.MergeFrom(other.LastGamePlusId);
		}
		consoleLevelStatics_.Add(other.consoleLevelStatics_);
		chapterStatics_.Add(other.chapterStatics_);
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
				if (lastGamePlusId_ == null)
				{
					LastGamePlusId = new Int32SyncWrapper();
				}
				input.ReadMessage(LastGamePlusId);
				break;
			case 34u:
				consoleLevelStatics_.AddEntriesFrom(input, _repeated_consoleLevelStatics_codec);
				break;
			case 42u:
				chapterStatics_.AddEntriesFrom(input, _repeated_chapterStatics_codec);
				break;
			}
		}
	}
}
