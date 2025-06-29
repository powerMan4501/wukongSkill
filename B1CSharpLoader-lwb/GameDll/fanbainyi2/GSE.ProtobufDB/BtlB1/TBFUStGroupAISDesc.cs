using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStGroupAISDesc : IMessage<TBFUStGroupAISDesc>, IMessage, IEquatable<TBFUStGroupAISDesc>, IDeepCloneable<TBFUStGroupAISDesc>
{
	private static readonly MessageParser<TBFUStGroupAISDesc> _parser = new MessageParser<TBFUStGroupAISDesc>(() => new TBFUStGroupAISDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStGroupAISDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStGroupAISDesc.Parser);

	private readonly RepeatedField<FUStGroupAISDesc> list_ = new RepeatedField<FUStGroupAISDesc>();

	public static MessageParser<TBFUStGroupAISDesc> Parser => _parser;

	public RepeatedField<FUStGroupAISDesc> List => list_;

	public TBFUStGroupAISDesc()
	{
	}

	public TBFUStGroupAISDesc(TBFUStGroupAISDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStGroupAISDesc Clone()
	{
		return new TBFUStGroupAISDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStGroupAISDesc);
	}

	public bool Equals(TBFUStGroupAISDesc other)
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

	public void MergeFrom(TBFUStGroupAISDesc other)
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
