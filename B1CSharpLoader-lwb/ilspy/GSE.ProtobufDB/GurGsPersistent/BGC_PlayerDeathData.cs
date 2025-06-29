using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsPersistent;

public sealed class BGC_PlayerDeathData : IMessage<BGC_PlayerDeathData>, IMessage, IEquatable<BGC_PlayerDeathData>, IDeepCloneable<BGC_PlayerDeathData>
{
	private static readonly MessageParser<BGC_PlayerDeathData> _parser = new MessageParser<BGC_PlayerDeathData>(() => new BGC_PlayerDeathData());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int playerDeathCount_;

	private static readonly FieldCodec<DictDeltaMsgInt_Int> _repeated_chapterDeathDict_codec = FieldCodec.ForMessage(18u, DictDeltaMsgInt_Int.Parser);

	private readonly RepeatedField<DictDeltaMsgInt_Int> chapterDeathDict_ = new RepeatedField<DictDeltaMsgInt_Int>();

	public static MessageParser<BGC_PlayerDeathData> Parser => _parser;

	public int PlayerDeathCount
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return playerDeathCount_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			playerDeathCount_ = value;
		}
	}

	public bool HasPlayerDeathCount => (_hasBits0 & 1) != 0;

	public RepeatedField<DictDeltaMsgInt_Int> ChapterDeathDict => chapterDeathDict_;

	public BGC_PlayerDeathData()
	{
	}

	public BGC_PlayerDeathData(BGC_PlayerDeathData other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		playerDeathCount_ = other.playerDeathCount_;
		chapterDeathDict_ = other.chapterDeathDict_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BGC_PlayerDeathData Clone()
	{
		return new BGC_PlayerDeathData(this);
	}

	public void ClearPlayerDeathCount()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as BGC_PlayerDeathData);
	}

	public bool Equals(BGC_PlayerDeathData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PlayerDeathCount != other.PlayerDeathCount)
		{
			return false;
		}
		if (!chapterDeathDict_.Equals(other.chapterDeathDict_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasPlayerDeathCount)
		{
			num ^= PlayerDeathCount.GetHashCode();
		}
		num ^= chapterDeathDict_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasPlayerDeathCount)
		{
			output.WriteRawTag(8);
			output.WriteInt32(PlayerDeathCount);
		}
		chapterDeathDict_.WriteTo(output, _repeated_chapterDeathDict_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasPlayerDeathCount)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PlayerDeathCount);
		}
		num += chapterDeathDict_.CalculateSize(_repeated_chapterDeathDict_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BGC_PlayerDeathData other)
	{
		if (other != null)
		{
			if (other.HasPlayerDeathCount)
			{
				PlayerDeathCount = other.PlayerDeathCount;
			}
			chapterDeathDict_.Add(other.chapterDeathDict_);
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
				PlayerDeathCount = input.ReadInt32();
				break;
			case 18u:
				chapterDeathDict_.AddEntriesFrom(input, _repeated_chapterDeathDict_codec);
				break;
			}
		}
	}
}
