using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace ArchiveB1;

public sealed class RoleChapterSyncWrapper : IMessage<RoleChapterSyncWrapper>, IMessage, IEquatable<RoleChapterSyncWrapper>, IDeepCloneable<RoleChapterSyncWrapper>
{
	private static readonly MessageParser<RoleChapterSyncWrapper> _parser = new MessageParser<RoleChapterSyncWrapper>(() => new RoleChapterSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Int32SyncWrapper curChapter_;

	private static readonly FieldCodec<ChapterDataSyncWrapper> _repeated_chapterList_codec = FieldCodec.ForMessage(34u, ChapterDataSyncWrapper.Parser);

	private readonly RepeatedField<ChapterDataSyncWrapper> chapterList_ = new RepeatedField<ChapterDataSyncWrapper>();

	private YesNoTypeSyncWrapper gameCompelete_;

	private static readonly FieldCodec<AwardItemSyncWrapper> _repeated_stashChapterAwardList_codec = FieldCodec.ForMessage(50u, AwardItemSyncWrapper.Parser);

	private readonly RepeatedField<AwardItemSyncWrapper> stashChapterAwardList_ = new RepeatedField<AwardItemSyncWrapper>();

	public static MessageParser<RoleChapterSyncWrapper> Parser => _parser;

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

	public Int32SyncWrapper CurChapter
	{
		get
		{
			return curChapter_;
		}
		set
		{
			curChapter_ = value;
		}
	}

	public RepeatedField<ChapterDataSyncWrapper> ChapterList => chapterList_;

	public YesNoTypeSyncWrapper GameCompelete
	{
		get
		{
			return gameCompelete_;
		}
		set
		{
			gameCompelete_ = value;
		}
	}

	public RepeatedField<AwardItemSyncWrapper> StashChapterAwardList => stashChapterAwardList_;

	public RoleChapterSyncWrapper()
	{
	}

	public RoleChapterSyncWrapper(RoleChapterSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		curChapter_ = ((other.curChapter_ != null) ? other.curChapter_.Clone() : null);
		chapterList_ = other.chapterList_.Clone();
		gameCompelete_ = ((other.gameCompelete_ != null) ? other.gameCompelete_.Clone() : null);
		stashChapterAwardList_ = other.stashChapterAwardList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleChapterSyncWrapper Clone()
	{
		return new RoleChapterSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleChapterSyncWrapper);
	}

	public bool Equals(RoleChapterSyncWrapper other)
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
		if (!object.Equals(CurChapter, other.CurChapter))
		{
			return false;
		}
		if (!chapterList_.Equals(other.chapterList_))
		{
			return false;
		}
		if (!object.Equals(GameCompelete, other.GameCompelete))
		{
			return false;
		}
		if (!stashChapterAwardList_.Equals(other.stashChapterAwardList_))
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
		if (curChapter_ != null)
		{
			num ^= CurChapter.GetHashCode();
		}
		num ^= chapterList_.GetHashCode();
		if (gameCompelete_ != null)
		{
			num ^= GameCompelete.GetHashCode();
		}
		num ^= stashChapterAwardList_.GetHashCode();
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
		if (curChapter_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(CurChapter);
		}
		chapterList_.WriteTo(output, _repeated_chapterList_codec);
		if (gameCompelete_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(GameCompelete);
		}
		stashChapterAwardList_.WriteTo(output, _repeated_stashChapterAwardList_codec);
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
		if (curChapter_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CurChapter);
		}
		num += chapterList_.CalculateSize(_repeated_chapterList_codec);
		if (gameCompelete_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GameCompelete);
		}
		num += stashChapterAwardList_.CalculateSize(_repeated_stashChapterAwardList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleChapterSyncWrapper other)
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
		if (other.curChapter_ != null)
		{
			if (curChapter_ == null)
			{
				CurChapter = new Int32SyncWrapper();
			}
			CurChapter.MergeFrom(other.CurChapter);
		}
		chapterList_.Add(other.chapterList_);
		if (other.gameCompelete_ != null)
		{
			if (gameCompelete_ == null)
			{
				GameCompelete = new YesNoTypeSyncWrapper();
			}
			GameCompelete.MergeFrom(other.GameCompelete);
		}
		stashChapterAwardList_.Add(other.stashChapterAwardList_);
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
				if (curChapter_ == null)
				{
					CurChapter = new Int32SyncWrapper();
				}
				input.ReadMessage(CurChapter);
				break;
			case 34u:
				chapterList_.AddEntriesFrom(input, _repeated_chapterList_codec);
				break;
			case 42u:
				if (gameCompelete_ == null)
				{
					GameCompelete = new YesNoTypeSyncWrapper();
				}
				input.ReadMessage(GameCompelete);
				break;
			case 50u:
				stashChapterAwardList_.AddEntriesFrom(input, _repeated_stashChapterAwardList_codec);
				break;
			}
		}
	}
}
