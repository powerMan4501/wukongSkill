using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TBAlchemyOutputDesc : IMessage<TBAlchemyOutputDesc>, IMessage, IEquatable<TBAlchemyOutputDesc>, IDeepCloneable<TBAlchemyOutputDesc>
{
	private static readonly MessageParser<TBAlchemyOutputDesc> _parser = new MessageParser<TBAlchemyOutputDesc>(() => new TBAlchemyOutputDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<AlchemyOutputDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, AlchemyOutputDesc.Parser);

	private readonly RepeatedField<AlchemyOutputDesc> list_ = new RepeatedField<AlchemyOutputDesc>();

	public static MessageParser<TBAlchemyOutputDesc> Parser => _parser;

	public RepeatedField<AlchemyOutputDesc> List => list_;

	public TBAlchemyOutputDesc()
	{
	}

	public TBAlchemyOutputDesc(TBAlchemyOutputDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBAlchemyOutputDesc Clone()
	{
		return new TBAlchemyOutputDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBAlchemyOutputDesc);
	}

	public bool Equals(TBAlchemyOutputDesc other)
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

	public void MergeFrom(TBAlchemyOutputDesc other)
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
