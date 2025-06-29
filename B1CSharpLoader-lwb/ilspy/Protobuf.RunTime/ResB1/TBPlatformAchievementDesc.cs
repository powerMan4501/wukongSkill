using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TBPlatformAchievementDesc : IMessage<TBPlatformAchievementDesc>, IMessage, IEquatable<TBPlatformAchievementDesc>, IDeepCloneable<TBPlatformAchievementDesc>
{
	private static readonly MessageParser<TBPlatformAchievementDesc> _parser = new MessageParser<TBPlatformAchievementDesc>(() => new TBPlatformAchievementDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<PlatformAchievementDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, PlatformAchievementDesc.Parser);

	private readonly RepeatedField<PlatformAchievementDesc> list_ = new RepeatedField<PlatformAchievementDesc>();

	public static MessageParser<TBPlatformAchievementDesc> Parser => _parser;

	public RepeatedField<PlatformAchievementDesc> List => list_;

	public TBPlatformAchievementDesc()
	{
	}

	public TBPlatformAchievementDesc(TBPlatformAchievementDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBPlatformAchievementDesc Clone()
	{
		return new TBPlatformAchievementDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBPlatformAchievementDesc);
	}

	public bool Equals(TBPlatformAchievementDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!list_.Equals(other.list_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= list_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		list_.WriteTo(output, _repeated_list_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += list_.CalculateSize(_repeated_list_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TBPlatformAchievementDesc other)
	{
		if (other != null)
		{
			list_.Add(other.list_);
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
				list_.AddEntriesFrom(input, _repeated_list_codec);
			}
		}
	}
}
