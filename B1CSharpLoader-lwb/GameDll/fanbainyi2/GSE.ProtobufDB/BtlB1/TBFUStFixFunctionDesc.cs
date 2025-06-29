using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStFixFunctionDesc : IMessage<TBFUStFixFunctionDesc>, IMessage, IEquatable<TBFUStFixFunctionDesc>, IDeepCloneable<TBFUStFixFunctionDesc>
{
	private static readonly MessageParser<TBFUStFixFunctionDesc> _parser = new MessageParser<TBFUStFixFunctionDesc>(() => new TBFUStFixFunctionDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStFixFunctionDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStFixFunctionDesc.Parser);

	private readonly RepeatedField<FUStFixFunctionDesc> list_ = new RepeatedField<FUStFixFunctionDesc>();

	public static MessageParser<TBFUStFixFunctionDesc> Parser => _parser;

	public RepeatedField<FUStFixFunctionDesc> List => list_;

	public TBFUStFixFunctionDesc()
	{
	}

	public TBFUStFixFunctionDesc(TBFUStFixFunctionDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStFixFunctionDesc Clone()
	{
		return new TBFUStFixFunctionDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStFixFunctionDesc);
	}

	public bool Equals(TBFUStFixFunctionDesc other)
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

	public void MergeFrom(TBFUStFixFunctionDesc other)
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
