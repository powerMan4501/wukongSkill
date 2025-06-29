using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class LevelArchiveData : IMessage<LevelArchiveData>, IMessage, IEquatable<LevelArchiveData>, IDeepCloneable<LevelArchiveData>
{
	private static readonly MessageParser<LevelArchiveData> _parser = new MessageParser<LevelArchiveData>(() => new LevelArchiveData());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<LevelArchiveBaseData> _repeated_levelBaseData_codec = FieldCodec.ForMessage(10u, LevelArchiveBaseData.Parser);

	private readonly RepeatedField<LevelArchiveBaseData> levelBaseData_ = new RepeatedField<LevelArchiveBaseData>();

	private static readonly FieldCodec<LevelArchiveDetailData> _repeated_levelDetailData_codec = FieldCodec.ForMessage(18u, LevelArchiveDetailData.Parser);

	private readonly RepeatedField<LevelArchiveDetailData> levelDetailData_ = new RepeatedField<LevelArchiveDetailData>();

	public static MessageParser<LevelArchiveData> Parser => _parser;

	public RepeatedField<LevelArchiveBaseData> LevelBaseData => levelBaseData_;

	public RepeatedField<LevelArchiveDetailData> LevelDetailData => levelDetailData_;

	public LevelArchiveData()
	{
	}

	public LevelArchiveData(LevelArchiveData other)
		: this()
	{
		levelBaseData_ = other.levelBaseData_.Clone();
		levelDetailData_ = other.levelDetailData_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LevelArchiveData Clone()
	{
		return new LevelArchiveData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LevelArchiveData);
	}

	public bool Equals(LevelArchiveData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!levelBaseData_.Equals(other.levelBaseData_))
		{
			return false;
		}
		if (!levelDetailData_.Equals(other.levelDetailData_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= levelBaseData_.GetHashCode();
		num ^= levelDetailData_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		levelBaseData_.WriteTo(output, _repeated_levelBaseData_codec);
		levelDetailData_.WriteTo(output, _repeated_levelDetailData_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += levelBaseData_.CalculateSize(_repeated_levelBaseData_codec);
		num += levelDetailData_.CalculateSize(_repeated_levelDetailData_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LevelArchiveData other)
	{
		if (other != null)
		{
			levelBaseData_.Add(other.levelBaseData_);
			levelDetailData_.Add(other.levelDetailData_);
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
			case 10u:
				levelBaseData_.AddEntriesFrom(input, _repeated_levelBaseData_codec);
				break;
			case 18u:
				levelDetailData_.AddEntriesFrom(input, _repeated_levelDetailData_codec);
				break;
			}
		}
	}
}
