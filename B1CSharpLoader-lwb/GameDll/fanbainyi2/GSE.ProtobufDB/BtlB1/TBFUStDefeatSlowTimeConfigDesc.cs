using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStDefeatSlowTimeConfigDesc : IMessage<TBFUStDefeatSlowTimeConfigDesc>, IMessage, IEquatable<TBFUStDefeatSlowTimeConfigDesc>, IDeepCloneable<TBFUStDefeatSlowTimeConfigDesc>
{
	private static readonly MessageParser<TBFUStDefeatSlowTimeConfigDesc> _parser = new MessageParser<TBFUStDefeatSlowTimeConfigDesc>(() => new TBFUStDefeatSlowTimeConfigDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStDefeatSlowTimeConfigDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStDefeatSlowTimeConfigDesc.Parser);

	private readonly RepeatedField<FUStDefeatSlowTimeConfigDesc> list_ = new RepeatedField<FUStDefeatSlowTimeConfigDesc>();

	public static MessageParser<TBFUStDefeatSlowTimeConfigDesc> Parser => _parser;

	public RepeatedField<FUStDefeatSlowTimeConfigDesc> List => list_;

	public TBFUStDefeatSlowTimeConfigDesc()
	{
	}

	public TBFUStDefeatSlowTimeConfigDesc(TBFUStDefeatSlowTimeConfigDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStDefeatSlowTimeConfigDesc Clone()
	{
		return new TBFUStDefeatSlowTimeConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStDefeatSlowTimeConfigDesc);
	}

	public bool Equals(TBFUStDefeatSlowTimeConfigDesc other)
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

	public void MergeFrom(TBFUStDefeatSlowTimeConfigDesc other)
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
