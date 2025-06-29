using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStNianhuiAwardDesc : IMessage<TBFUStNianhuiAwardDesc>, IMessage, IEquatable<TBFUStNianhuiAwardDesc>, IDeepCloneable<TBFUStNianhuiAwardDesc>
{
	private static readonly MessageParser<TBFUStNianhuiAwardDesc> _parser = new MessageParser<TBFUStNianhuiAwardDesc>(() => new TBFUStNianhuiAwardDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStNianhuiAwardDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStNianhuiAwardDesc.Parser);

	private readonly RepeatedField<FUStNianhuiAwardDesc> list_ = new RepeatedField<FUStNianhuiAwardDesc>();

	public static MessageParser<TBFUStNianhuiAwardDesc> Parser => _parser;

	public RepeatedField<FUStNianhuiAwardDesc> List => list_;

	public TBFUStNianhuiAwardDesc()
	{
	}

	public TBFUStNianhuiAwardDesc(TBFUStNianhuiAwardDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStNianhuiAwardDesc Clone()
	{
		return new TBFUStNianhuiAwardDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStNianhuiAwardDesc);
	}

	public bool Equals(TBFUStNianhuiAwardDesc other)
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

	public void MergeFrom(TBFUStNianhuiAwardDesc other)
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
