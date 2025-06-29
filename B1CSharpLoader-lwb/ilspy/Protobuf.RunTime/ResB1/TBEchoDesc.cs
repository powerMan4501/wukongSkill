using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TBEchoDesc : IMessage<TBEchoDesc>, IMessage, IEquatable<TBEchoDesc>, IDeepCloneable<TBEchoDesc>
{
	private static readonly MessageParser<TBEchoDesc> _parser = new MessageParser<TBEchoDesc>(() => new TBEchoDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<EchoDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, EchoDesc.Parser);

	private readonly RepeatedField<EchoDesc> list_ = new RepeatedField<EchoDesc>();

	public static MessageParser<TBEchoDesc> Parser => _parser;

	public RepeatedField<EchoDesc> List => list_;

	public TBEchoDesc()
	{
	}

	public TBEchoDesc(TBEchoDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBEchoDesc Clone()
	{
		return new TBEchoDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBEchoDesc);
	}

	public bool Equals(TBEchoDesc other)
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

	public void MergeFrom(TBEchoDesc other)
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
