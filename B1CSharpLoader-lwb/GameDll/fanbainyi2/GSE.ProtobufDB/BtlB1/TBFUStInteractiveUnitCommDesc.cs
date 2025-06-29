using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStInteractiveUnitCommDesc : IMessage<TBFUStInteractiveUnitCommDesc>, IMessage, IEquatable<TBFUStInteractiveUnitCommDesc>, IDeepCloneable<TBFUStInteractiveUnitCommDesc>
{
	private static readonly MessageParser<TBFUStInteractiveUnitCommDesc> _parser = new MessageParser<TBFUStInteractiveUnitCommDesc>(() => new TBFUStInteractiveUnitCommDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStInteractiveUnitCommDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStInteractiveUnitCommDesc.Parser);

	private readonly RepeatedField<FUStInteractiveUnitCommDesc> list_ = new RepeatedField<FUStInteractiveUnitCommDesc>();

	public static MessageParser<TBFUStInteractiveUnitCommDesc> Parser => _parser;

	public RepeatedField<FUStInteractiveUnitCommDesc> List => list_;

	public TBFUStInteractiveUnitCommDesc()
	{
	}

	public TBFUStInteractiveUnitCommDesc(TBFUStInteractiveUnitCommDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStInteractiveUnitCommDesc Clone()
	{
		return new TBFUStInteractiveUnitCommDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStInteractiveUnitCommDesc);
	}

	public bool Equals(TBFUStInteractiveUnitCommDesc other)
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

	public void MergeFrom(TBFUStInteractiveUnitCommDesc other)
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
