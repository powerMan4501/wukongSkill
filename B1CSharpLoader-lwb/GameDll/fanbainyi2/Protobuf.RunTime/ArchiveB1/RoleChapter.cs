using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace ArchiveB1;

public sealed class RoleChapter : IMessage<RoleChapter>, IMessage, IEquatable<RoleChapter>, IDeepCloneable<RoleChapter>
{
	private static readonly MessageParser<RoleChapter> _parser = new MessageParser<RoleChapter>(() => new RoleChapter());

	private UnknownFieldSet _unknownFields;

	private int curChapter_;

	private static readonly FieldCodec<ChapterData> _repeated_chapterList_codec = FieldCodec.ForMessage(18u, ChapterData.Parser);

	private readonly RepeatedField<ChapterData> chapterList_ = new RepeatedField<ChapterData>();

	private YesNoType gameCompelete_;

	private static readonly FieldCodec<AwardItem> _repeated_stashChapterAwardList_codec = FieldCodec.ForMessage(34u, AwardItem.Parser);

	private readonly RepeatedField<AwardItem> stashChapterAwardList_ = new RepeatedField<AwardItem>();

	public static MessageParser<RoleChapter> Parser => _parser;

	public int CurChapter
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

	public RepeatedField<ChapterData> ChapterList => chapterList_;

	public YesNoType GameCompelete
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

	public RepeatedField<AwardItem> StashChapterAwardList => stashChapterAwardList_;

	public RoleChapter()
	{
	}

	public RoleChapter(RoleChapter other)
		: this()
	{
		curChapter_ = other.curChapter_;
		chapterList_ = other.chapterList_.Clone();
		gameCompelete_ = other.gameCompelete_;
		stashChapterAwardList_ = other.stashChapterAwardList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleChapter Clone()
	{
		return new RoleChapter(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleChapter);
	}

	public bool Equals(RoleChapter other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CurChapter != other.CurChapter)
		{
			return false;
		}
		if (!chapterList_.Equals(other.chapterList_))
		{
			return false;
		}
		if (GameCompelete != other.GameCompelete)
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
		if (CurChapter != 0)
		{
			num ^= CurChapter.GetHashCode();
		}
		num ^= chapterList_.GetHashCode();
		if (GameCompelete != YesNoType.No)
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
		if (CurChapter != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(CurChapter);
		}
		chapterList_.WriteTo(output, _repeated_chapterList_codec);
		if (GameCompelete != YesNoType.No)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)GameCompelete);
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
		if (CurChapter != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CurChapter);
		}
		num += chapterList_.CalculateSize(_repeated_chapterList_codec);
		if (GameCompelete != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)GameCompelete);
		}
		num += stashChapterAwardList_.CalculateSize(_repeated_stashChapterAwardList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleChapter other)
	{
		if (other != null)
		{
			if (other.CurChapter != 0)
			{
				CurChapter = other.CurChapter;
			}
			chapterList_.Add(other.chapterList_);
			if (other.GameCompelete != YesNoType.No)
			{
				GameCompelete = other.GameCompelete;
			}
			stashChapterAwardList_.Add(other.stashChapterAwardList_);
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
				CurChapter = input.ReadInt32();
				break;
			case 18u:
				chapterList_.AddEntriesFrom(input, _repeated_chapterList_codec);
				break;
			case 24u:
				GameCompelete = (YesNoType)input.ReadEnum();
				break;
			case 34u:
				stashChapterAwardList_.AddEntriesFrom(input, _repeated_stashChapterAwardList_codec);
				break;
			}
		}
	}
}
