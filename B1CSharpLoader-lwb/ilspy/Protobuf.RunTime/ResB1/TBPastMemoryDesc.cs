using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TBPastMemoryDesc : IMessage<TBPastMemoryDesc>, IMessage, IEquatable<TBPastMemoryDesc>, IDeepCloneable<TBPastMemoryDesc>
{
	private static readonly MessageParser<TBPastMemoryDesc> _parser = new MessageParser<TBPastMemoryDesc>(() => new TBPastMemoryDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<PastMemoryDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, PastMemoryDesc.Parser);

	private readonly RepeatedField<PastMemoryDesc> list_ = new RepeatedField<PastMemoryDesc>();

	public static MessageParser<TBPastMemoryDesc> Parser => _parser;

	public RepeatedField<PastMemoryDesc> List => list_;

	public TBPastMemoryDesc()
	{
	}

	public TBPastMemoryDesc(TBPastMemoryDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBPastMemoryDesc Clone()
	{
		return new TBPastMemoryDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBPastMemoryDesc);
	}

	public bool Equals(TBPastMemoryDesc other)
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

	public void MergeFrom(TBPastMemoryDesc other)
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
