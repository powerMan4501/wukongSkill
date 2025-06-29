using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class MovieCustom_SetStreamingLevelStateInfo : IMessage<MovieCustom_SetStreamingLevelStateInfo>, IMessage, IEquatable<MovieCustom_SetStreamingLevelStateInfo>, IDeepCloneable<MovieCustom_SetStreamingLevelStateInfo>
{
	private static readonly MessageParser<MovieCustom_SetStreamingLevelStateInfo> _parser = new MessageParser<MovieCustom_SetStreamingLevelStateInfo>(() => new MovieCustom_SetStreamingLevelStateInfo());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<CalliopeCustom_RequestLevelStateInfo> _repeated_levelStateRequestInfo_codec = FieldCodec.ForMessage(10u, CalliopeCustom_RequestLevelStateInfo.Parser);

	private readonly RepeatedField<CalliopeCustom_RequestLevelStateInfo> levelStateRequestInfo_ = new RepeatedField<CalliopeCustom_RequestLevelStateInfo>();

	public static MessageParser<MovieCustom_SetStreamingLevelStateInfo> Parser => _parser;

	public RepeatedField<CalliopeCustom_RequestLevelStateInfo> LevelStateRequestInfo => levelStateRequestInfo_;

	public MovieCustom_SetStreamingLevelStateInfo()
	{
	}

	public MovieCustom_SetStreamingLevelStateInfo(MovieCustom_SetStreamingLevelStateInfo other)
		: this()
	{
		levelStateRequestInfo_ = other.levelStateRequestInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MovieCustom_SetStreamingLevelStateInfo Clone()
	{
		return new MovieCustom_SetStreamingLevelStateInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MovieCustom_SetStreamingLevelStateInfo);
	}

	public bool Equals(MovieCustom_SetStreamingLevelStateInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!levelStateRequestInfo_.Equals(other.levelStateRequestInfo_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= levelStateRequestInfo_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		levelStateRequestInfo_.WriteTo(output, _repeated_levelStateRequestInfo_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += levelStateRequestInfo_.CalculateSize(_repeated_levelStateRequestInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MovieCustom_SetStreamingLevelStateInfo other)
	{
		if (other != null)
		{
			levelStateRequestInfo_.Add(other.levelStateRequestInfo_);
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
				levelStateRequestInfo_.AddEntriesFrom(input, _repeated_levelStateRequestInfo_codec);
			}
		}
	}
}
