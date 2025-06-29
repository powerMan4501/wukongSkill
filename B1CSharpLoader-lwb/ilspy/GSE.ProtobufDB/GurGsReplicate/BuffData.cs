using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using GurGsStruct;

namespace GurGsReplicate;

public sealed class BuffData : IMessage<BuffData>, IMessage, IEquatable<BuffData>, IDeepCloneable<BuffData>
{
	private static readonly MessageParser<BuffData> _parser = new MessageParser<BuffData>(() => new BuffData());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<DictDeltaMsgInt_BuffInstData> _repeated_buffInstsDict_codec = FieldCodec.ForMessage(10u, DictDeltaMsgInt_BuffInstData.Parser);

	private readonly RepeatedField<DictDeltaMsgInt_BuffInstData> buffInstsDict_ = new RepeatedField<DictDeltaMsgInt_BuffInstData>();

	public static MessageParser<BuffData> Parser => _parser;

	public RepeatedField<DictDeltaMsgInt_BuffInstData> BuffInstsDict => buffInstsDict_;

	public BuffData()
	{
	}

	public BuffData(BuffData other)
		: this()
	{
		buffInstsDict_ = other.buffInstsDict_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BuffData Clone()
	{
		return new BuffData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BuffData);
	}

	public bool Equals(BuffData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!buffInstsDict_.Equals(other.buffInstsDict_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= buffInstsDict_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		buffInstsDict_.WriteTo(output, _repeated_buffInstsDict_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += buffInstsDict_.CalculateSize(_repeated_buffInstsDict_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BuffData other)
	{
		if (other != null)
		{
			buffInstsDict_.Add(other.buffInstsDict_);
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
				buffInstsDict_.AddEntriesFrom(input, _repeated_buffInstsDict_codec);
			}
		}
	}
}
