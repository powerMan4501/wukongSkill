using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsPersistent;

public sealed class BGC_PigsyStoryData : IMessage<BGC_PigsyStoryData>, IMessage, IEquatable<BGC_PigsyStoryData>, IDeepCloneable<BGC_PigsyStoryData>
{
	private static readonly MessageParser<BGC_PigsyStoryData> _parser = new MessageParser<BGC_PigsyStoryData>(() => new BGC_PigsyStoryData());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<ListDeltaMsgInt> _repeated_finishedStoryMemory_codec = FieldCodec.ForMessage(10u, ListDeltaMsgInt.Parser);

	private readonly RepeatedField<ListDeltaMsgInt> finishedStoryMemory_ = new RepeatedField<ListDeltaMsgInt>();

	public static MessageParser<BGC_PigsyStoryData> Parser => _parser;

	public RepeatedField<ListDeltaMsgInt> FinishedStoryMemory => finishedStoryMemory_;

	public BGC_PigsyStoryData()
	{
	}

	public BGC_PigsyStoryData(BGC_PigsyStoryData other)
		: this()
	{
		finishedStoryMemory_ = other.finishedStoryMemory_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BGC_PigsyStoryData Clone()
	{
		return new BGC_PigsyStoryData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BGC_PigsyStoryData);
	}

	public bool Equals(BGC_PigsyStoryData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!finishedStoryMemory_.Equals(other.finishedStoryMemory_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= finishedStoryMemory_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		finishedStoryMemory_.WriteTo(output, _repeated_finishedStoryMemory_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += finishedStoryMemory_.CalculateSize(_repeated_finishedStoryMemory_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BGC_PigsyStoryData other)
	{
		if (other != null)
		{
			finishedStoryMemory_.Add(other.finishedStoryMemory_);
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
				finishedStoryMemory_.AddEntriesFrom(input, _repeated_finishedStoryMemory_codec);
			}
		}
	}
}
