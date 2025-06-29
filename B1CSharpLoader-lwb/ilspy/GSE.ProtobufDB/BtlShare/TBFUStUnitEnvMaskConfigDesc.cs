using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class TBFUStUnitEnvMaskConfigDesc : IMessage<TBFUStUnitEnvMaskConfigDesc>, IMessage, IEquatable<TBFUStUnitEnvMaskConfigDesc>, IDeepCloneable<TBFUStUnitEnvMaskConfigDesc>
{
	private static readonly MessageParser<TBFUStUnitEnvMaskConfigDesc> _parser = new MessageParser<TBFUStUnitEnvMaskConfigDesc>(() => new TBFUStUnitEnvMaskConfigDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStUnitEnvMaskConfigDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStUnitEnvMaskConfigDesc.Parser);

	private readonly RepeatedField<FUStUnitEnvMaskConfigDesc> list_ = new RepeatedField<FUStUnitEnvMaskConfigDesc>();

	public static MessageParser<TBFUStUnitEnvMaskConfigDesc> Parser => _parser;

	public RepeatedField<FUStUnitEnvMaskConfigDesc> List => list_;

	public TBFUStUnitEnvMaskConfigDesc()
	{
	}

	public TBFUStUnitEnvMaskConfigDesc(TBFUStUnitEnvMaskConfigDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStUnitEnvMaskConfigDesc Clone()
	{
		return new TBFUStUnitEnvMaskConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStUnitEnvMaskConfigDesc);
	}

	public bool Equals(TBFUStUnitEnvMaskConfigDesc other)
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

	public void MergeFrom(TBFUStUnitEnvMaskConfigDesc other)
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
