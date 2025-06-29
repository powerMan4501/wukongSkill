using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStTransQiTianDaShengConfigDesc : IMessage<TBFUStTransQiTianDaShengConfigDesc>, IMessage, IEquatable<TBFUStTransQiTianDaShengConfigDesc>, IDeepCloneable<TBFUStTransQiTianDaShengConfigDesc>
{
	private static readonly MessageParser<TBFUStTransQiTianDaShengConfigDesc> _parser = new MessageParser<TBFUStTransQiTianDaShengConfigDesc>(() => new TBFUStTransQiTianDaShengConfigDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStTransQiTianDaShengConfigDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStTransQiTianDaShengConfigDesc.Parser);

	private readonly RepeatedField<FUStTransQiTianDaShengConfigDesc> list_ = new RepeatedField<FUStTransQiTianDaShengConfigDesc>();

	public static MessageParser<TBFUStTransQiTianDaShengConfigDesc> Parser => _parser;

	public RepeatedField<FUStTransQiTianDaShengConfigDesc> List => list_;

	public TBFUStTransQiTianDaShengConfigDesc()
	{
	}

	public TBFUStTransQiTianDaShengConfigDesc(TBFUStTransQiTianDaShengConfigDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStTransQiTianDaShengConfigDesc Clone()
	{
		return new TBFUStTransQiTianDaShengConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStTransQiTianDaShengConfigDesc);
	}

	public bool Equals(TBFUStTransQiTianDaShengConfigDesc other)
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

	public void MergeFrom(TBFUStTransQiTianDaShengConfigDesc other)
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
