using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class ChapterDesc : IMessage<ChapterDesc>, IMessage, IEquatable<ChapterDesc>, IDeepCloneable<ChapterDesc>
{
	private static readonly MessageParser<ChapterDesc> _parser = new MessageParser<ChapterDesc>(() => new ChapterDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private string chapterName_ = "";

	private string chapterPreName_ = "";

	private int chapterPerformId_;

	private float chapterAdaptorDelayTime_;

	private int chapterMovieId_;

	private int nextChapterId_;

	private int levelId_;

	private static readonly FieldCodec<int> _repeated_awardList_codec = FieldCodec.ForInt32(74u);

	private readonly RepeatedField<int> awardList_ = new RepeatedField<int>();

	private int localizationTag_;

	public static MessageParser<ChapterDesc> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public string ChapterName
	{
		get
		{
			return chapterName_;
		}
		set
		{
			chapterName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ChapterPreName
	{
		get
		{
			return chapterPreName_;
		}
		set
		{
			chapterPreName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int ChapterPerformId
	{
		get
		{
			return chapterPerformId_;
		}
		set
		{
			chapterPerformId_ = value;
		}
	}

	public float ChapterAdaptorDelayTime
	{
		get
		{
			return chapterAdaptorDelayTime_;
		}
		set
		{
			chapterAdaptorDelayTime_ = value;
		}
	}

	public int ChapterMovieId
	{
		get
		{
			return chapterMovieId_;
		}
		set
		{
			chapterMovieId_ = value;
		}
	}

	public int NextChapterId
	{
		get
		{
			return nextChapterId_;
		}
		set
		{
			nextChapterId_ = value;
		}
	}

	public int LevelId
	{
		get
		{
			return levelId_;
		}
		set
		{
			levelId_ = value;
		}
	}

	public RepeatedField<int> AwardList => awardList_;

	public int LocalizationTag
	{
		get
		{
			return localizationTag_;
		}
		set
		{
			localizationTag_ = value;
		}
	}

	public ChapterDesc()
	{
	}

	public ChapterDesc(ChapterDesc other)
		: this()
	{
		id_ = other.id_;
		chapterName_ = other.chapterName_;
		chapterPreName_ = other.chapterPreName_;
		chapterPerformId_ = other.chapterPerformId_;
		chapterAdaptorDelayTime_ = other.chapterAdaptorDelayTime_;
		chapterMovieId_ = other.chapterMovieId_;
		nextChapterId_ = other.nextChapterId_;
		levelId_ = other.levelId_;
		awardList_ = other.awardList_.Clone();
		localizationTag_ = other.localizationTag_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ChapterDesc Clone()
	{
		return new ChapterDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ChapterDesc);
	}

	public bool Equals(ChapterDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (ChapterName != other.ChapterName)
		{
			return false;
		}
		if (ChapterPreName != other.ChapterPreName)
		{
			return false;
		}
		if (ChapterPerformId != other.ChapterPerformId)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ChapterAdaptorDelayTime, other.ChapterAdaptorDelayTime))
		{
			return false;
		}
		if (ChapterMovieId != other.ChapterMovieId)
		{
			return false;
		}
		if (NextChapterId != other.NextChapterId)
		{
			return false;
		}
		if (LevelId != other.LevelId)
		{
			return false;
		}
		if (!awardList_.Equals(other.awardList_))
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (ChapterName.Length != 0)
		{
			num ^= ChapterName.GetHashCode();
		}
		if (ChapterPreName.Length != 0)
		{
			num ^= ChapterPreName.GetHashCode();
		}
		if (ChapterPerformId != 0)
		{
			num ^= ChapterPerformId.GetHashCode();
		}
		if (ChapterAdaptorDelayTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ChapterAdaptorDelayTime);
		}
		if (ChapterMovieId != 0)
		{
			num ^= ChapterMovieId.GetHashCode();
		}
		if (NextChapterId != 0)
		{
			num ^= NextChapterId.GetHashCode();
		}
		if (LevelId != 0)
		{
			num ^= LevelId.GetHashCode();
		}
		num ^= awardList_.GetHashCode();
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (ChapterName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(ChapterName);
		}
		if (ChapterPreName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(ChapterPreName);
		}
		if (ChapterPerformId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ChapterPerformId);
		}
		if (ChapterAdaptorDelayTime != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(ChapterAdaptorDelayTime);
		}
		if (ChapterMovieId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(ChapterMovieId);
		}
		if (NextChapterId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(NextChapterId);
		}
		if (LevelId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(LevelId);
		}
		awardList_.WriteTo(output, _repeated_awardList_codec);
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(LocalizationTag);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (ChapterName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ChapterName);
		}
		if (ChapterPreName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ChapterPreName);
		}
		if (ChapterPerformId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChapterPerformId);
		}
		if (ChapterAdaptorDelayTime != 0f)
		{
			num += 5;
		}
		if (ChapterMovieId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChapterMovieId);
		}
		if (NextChapterId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NextChapterId);
		}
		if (LevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelId);
		}
		num += awardList_.CalculateSize(_repeated_awardList_codec);
		if (LocalizationTag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ChapterDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.ChapterName.Length != 0)
			{
				ChapterName = other.ChapterName;
			}
			if (other.ChapterPreName.Length != 0)
			{
				ChapterPreName = other.ChapterPreName;
			}
			if (other.ChapterPerformId != 0)
			{
				ChapterPerformId = other.ChapterPerformId;
			}
			if (other.ChapterAdaptorDelayTime != 0f)
			{
				ChapterAdaptorDelayTime = other.ChapterAdaptorDelayTime;
			}
			if (other.ChapterMovieId != 0)
			{
				ChapterMovieId = other.ChapterMovieId;
			}
			if (other.NextChapterId != 0)
			{
				NextChapterId = other.NextChapterId;
			}
			if (other.LevelId != 0)
			{
				LevelId = other.LevelId;
			}
			awardList_.Add(other.awardList_);
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
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
				Id = input.ReadInt32();
				break;
			case 18u:
				ChapterName = input.ReadString();
				break;
			case 26u:
				ChapterPreName = input.ReadString();
				break;
			case 32u:
				ChapterPerformId = input.ReadInt32();
				break;
			case 45u:
				ChapterAdaptorDelayTime = input.ReadFloat();
				break;
			case 48u:
				ChapterMovieId = input.ReadInt32();
				break;
			case 56u:
				NextChapterId = input.ReadInt32();
				break;
			case 64u:
				LevelId = input.ReadInt32();
				break;
			case 72u:
			case 74u:
				awardList_.AddEntriesFrom(input, _repeated_awardList_codec);
				break;
			case 80u:
				LocalizationTag = input.ReadInt32();
				break;
			}
		}
	}
}
