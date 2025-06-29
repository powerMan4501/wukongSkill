using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlU3;

public sealed class FUStB2DArchivesData : IMessage<FUStB2DArchivesData>, IMessage, IEquatable<FUStB2DArchivesData>, IDeepCloneable<FUStB2DArchivesData>
{
	private static readonly MessageParser<FUStB2DArchivesData> _parser = new MessageParser<FUStB2DArchivesData>(() => new FUStB2DArchivesData());

	private UnknownFieldSet _unknownFields;

	private int archiveId_;

	private static readonly FieldCodec<FUStB2DArchivesHeroData> _repeated_heroData_codec = FieldCodec.ForMessage(18u, FUStB2DArchivesHeroData.Parser);

	private readonly RepeatedField<FUStB2DArchivesHeroData> heroData_ = new RepeatedField<FUStB2DArchivesHeroData>();

	private static readonly FieldCodec<FUStB2DArchivesMonsterData> _repeated_monsterData_codec = FieldCodec.ForMessage(26u, FUStB2DArchivesMonsterData.Parser);

	private readonly RepeatedField<FUStB2DArchivesMonsterData> monsterData_ = new RepeatedField<FUStB2DArchivesMonsterData>();

	public static MessageParser<FUStB2DArchivesData> Parser => _parser;

	public int ArchiveId
	{
		get
		{
			return archiveId_;
		}
		set
		{
			archiveId_ = value;
		}
	}

	public RepeatedField<FUStB2DArchivesHeroData> HeroData => heroData_;

	public RepeatedField<FUStB2DArchivesMonsterData> MonsterData => monsterData_;

	public FUStB2DArchivesData()
	{
	}

	public FUStB2DArchivesData(FUStB2DArchivesData other)
		: this()
	{
		archiveId_ = other.archiveId_;
		heroData_ = other.heroData_.Clone();
		monsterData_ = other.monsterData_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStB2DArchivesData Clone()
	{
		return new FUStB2DArchivesData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStB2DArchivesData);
	}

	public bool Equals(FUStB2DArchivesData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ArchiveId != other.ArchiveId)
		{
			return false;
		}
		if (!heroData_.Equals(other.heroData_))
		{
			return false;
		}
		if (!monsterData_.Equals(other.monsterData_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ArchiveId != 0)
		{
			num ^= ArchiveId.GetHashCode();
		}
		num ^= heroData_.GetHashCode();
		num ^= monsterData_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ArchiveId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ArchiveId);
		}
		heroData_.WriteTo(output, _repeated_heroData_codec);
		monsterData_.WriteTo(output, _repeated_monsterData_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ArchiveId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ArchiveId);
		}
		num += heroData_.CalculateSize(_repeated_heroData_codec);
		num += monsterData_.CalculateSize(_repeated_monsterData_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStB2DArchivesData other)
	{
		if (other != null)
		{
			if (other.ArchiveId != 0)
			{
				ArchiveId = other.ArchiveId;
			}
			heroData_.Add(other.heroData_);
			monsterData_.Add(other.monsterData_);
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
				ArchiveId = input.ReadInt32();
				break;
			case 18u:
				heroData_.AddEntriesFrom(input, _repeated_heroData_codec);
				break;
			case 26u:
				monsterData_.AddEntriesFrom(input, _repeated_monsterData_codec);
				break;
			}
		}
	}
}
