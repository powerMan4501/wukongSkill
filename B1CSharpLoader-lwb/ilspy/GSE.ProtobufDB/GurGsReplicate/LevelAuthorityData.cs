using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace GurGsReplicate;

public sealed class LevelAuthorityData : IMessage<LevelAuthorityData>, IMessage, IEquatable<LevelAuthorityData>, IDeepCloneable<LevelAuthorityData>
{
	private static readonly MessageParser<LevelAuthorityData> _parser = new MessageParser<LevelAuthorityData>(() => new LevelAuthorityData());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<DictDeltaMsgString_String> _repeated_levelAuthorityMap_codec = FieldCodec.ForMessage(10u, DictDeltaMsgString_String.Parser);

	private readonly RepeatedField<DictDeltaMsgString_String> levelAuthorityMap_ = new RepeatedField<DictDeltaMsgString_String>();

	public static MessageParser<LevelAuthorityData> Parser => _parser;

	public RepeatedField<DictDeltaMsgString_String> LevelAuthorityMap => levelAuthorityMap_;

	public LevelAuthorityData()
	{
	}

	public LevelAuthorityData(LevelAuthorityData other)
		: this()
	{
		levelAuthorityMap_ = other.levelAuthorityMap_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LevelAuthorityData Clone()
	{
		return new LevelAuthorityData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LevelAuthorityData);
	}

	public bool Equals(LevelAuthorityData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!levelAuthorityMap_.Equals(other.levelAuthorityMap_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= levelAuthorityMap_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		levelAuthorityMap_.WriteTo(output, _repeated_levelAuthorityMap_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += levelAuthorityMap_.CalculateSize(_repeated_levelAuthorityMap_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LevelAuthorityData other)
	{
		if (other != null)
		{
			levelAuthorityMap_.Add(other.levelAuthorityMap_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				levelAuthorityMap_.AddEntriesFrom(input, _repeated_levelAuthorityMap_codec);
			}
		}
	}
}
