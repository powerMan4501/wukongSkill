using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TBConsumeDesc : IMessage<TBConsumeDesc>, IMessage, IEquatable<TBConsumeDesc>, IDeepCloneable<TBConsumeDesc>
{
	private static readonly MessageParser<TBConsumeDesc> _parser = new MessageParser<TBConsumeDesc>(() => new TBConsumeDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<ConsumeDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, ConsumeDesc.Parser);

	private readonly RepeatedField<ConsumeDesc> list_ = new RepeatedField<ConsumeDesc>();

	public static MessageParser<TBConsumeDesc> Parser => _parser;

	public RepeatedField<ConsumeDesc> List => list_;

	public TBConsumeDesc()
	{
	}

	public TBConsumeDesc(TBConsumeDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBConsumeDesc Clone()
	{
		return new TBConsumeDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBConsumeDesc);
	}

	public bool Equals(TBConsumeDesc other)
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

	public void MergeFrom(TBConsumeDesc other)
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
