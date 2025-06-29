using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStPartHitExpandDesc : IMessage<TBFUStPartHitExpandDesc>, IMessage, IEquatable<TBFUStPartHitExpandDesc>, IDeepCloneable<TBFUStPartHitExpandDesc>
{
	private static readonly MessageParser<TBFUStPartHitExpandDesc> _parser = new MessageParser<TBFUStPartHitExpandDesc>(() => new TBFUStPartHitExpandDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStPartHitExpandDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStPartHitExpandDesc.Parser);

	private readonly RepeatedField<FUStPartHitExpandDesc> list_ = new RepeatedField<FUStPartHitExpandDesc>();

	public static MessageParser<TBFUStPartHitExpandDesc> Parser => _parser;

	public RepeatedField<FUStPartHitExpandDesc> List => list_;

	public TBFUStPartHitExpandDesc()
	{
	}

	public TBFUStPartHitExpandDesc(TBFUStPartHitExpandDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStPartHitExpandDesc Clone()
	{
		return new TBFUStPartHitExpandDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStPartHitExpandDesc);
	}

	public bool Equals(TBFUStPartHitExpandDesc other)
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

	public void MergeFrom(TBFUStPartHitExpandDesc other)
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
