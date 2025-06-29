using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class NewGameResetStaticsData : IMessage<NewGameResetStaticsData>, IMessage, IEquatable<NewGameResetStaticsData>, IDeepCloneable<NewGameResetStaticsData>
{
	private static readonly MessageParser<NewGameResetStaticsData> _parser = new MessageParser<NewGameResetStaticsData>(() => new NewGameResetStaticsData());

	private UnknownFieldSet _unknownFields;

	private int lastGamePlusId_;

	private static readonly FieldCodec<LevelStaticsDataOne> _repeated_consoleLevelStatics_codec = FieldCodec.ForMessage(18u, LevelStaticsDataOne.Parser);

	private readonly RepeatedField<LevelStaticsDataOne> consoleLevelStatics_ = new RepeatedField<LevelStaticsDataOne>();

	private static readonly FieldCodec<ChapterStaticsDataOne> _repeated_chapterStatics_codec = FieldCodec.ForMessage(26u, ChapterStaticsDataOne.Parser);

	private readonly RepeatedField<ChapterStaticsDataOne> chapterStatics_ = new RepeatedField<ChapterStaticsDataOne>();

	public static MessageParser<NewGameResetStaticsData> Parser => _parser;

	public int LastGamePlusId
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

	public RepeatedField<LevelStaticsDataOne> ConsoleLevelStatics => consoleLevelStatics_;

	public RepeatedField<ChapterStaticsDataOne> ChapterStatics => chapterStatics_;

	public NewGameResetStaticsData()
	{
	}

	public NewGameResetStaticsData(NewGameResetStaticsData other)
		: this()
	{
		lastGamePlusId_ = other.lastGamePlusId_;
		consoleLevelStatics_ = other.consoleLevelStatics_.Clone();
		chapterStatics_ = other.chapterStatics_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public NewGameResetStaticsData Clone()
	{
		return new NewGameResetStaticsData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as NewGameResetStaticsData);
	}

	public bool Equals(NewGameResetStaticsData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LastGamePlusId != other.LastGamePlusId)
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
		if (LastGamePlusId != 0)
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
		if (LastGamePlusId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(LastGamePlusId);
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
		if (LastGamePlusId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LastGamePlusId);
		}
		num += consoleLevelStatics_.CalculateSize(_repeated_consoleLevelStatics_codec);
		num += chapterStatics_.CalculateSize(_repeated_chapterStatics_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(NewGameResetStaticsData other)
	{
		if (other != null)
		{
			if (other.LastGamePlusId != 0)
			{
				LastGamePlusId = other.LastGamePlusId;
			}
			consoleLevelStatics_.Add(other.consoleLevelStatics_);
			chapterStatics_.Add(other.chapterStatics_);
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
				LastGamePlusId = input.ReadInt32();
				break;
			case 18u:
				consoleLevelStatics_.AddEntriesFrom(input, _repeated_consoleLevelStatics_codec);
				break;
			case 26u:
				chapterStatics_.AddEntriesFrom(input, _repeated_chapterStatics_codec);
				break;
			}
		}
	}
}
