using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class TBFUStUnitCommDesc : IMessage<TBFUStUnitCommDesc>, IMessage, IEquatable<TBFUStUnitCommDesc>, IDeepCloneable<TBFUStUnitCommDesc>
{
	private static readonly MessageParser<TBFUStUnitCommDesc> _parser = new MessageParser<TBFUStUnitCommDesc>(() => new TBFUStUnitCommDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStUnitCommDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStUnitCommDesc.Parser);

	private readonly RepeatedField<FUStUnitCommDesc> list_ = new RepeatedField<FUStUnitCommDesc>();

	public static MessageParser<TBFUStUnitCommDesc> Parser => _parser;

	public RepeatedField<FUStUnitCommDesc> List => list_;

	public TBFUStUnitCommDesc()
	{
	}

	public TBFUStUnitCommDesc(TBFUStUnitCommDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStUnitCommDesc Clone()
	{
		return new TBFUStUnitCommDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStUnitCommDesc);
	}

	public bool Equals(TBFUStUnitCommDesc other)
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

	public void MergeFrom(TBFUStUnitCommDesc other)
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
