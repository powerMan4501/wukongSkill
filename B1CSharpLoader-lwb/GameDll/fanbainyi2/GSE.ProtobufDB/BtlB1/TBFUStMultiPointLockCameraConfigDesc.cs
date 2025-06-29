using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStMultiPointLockCameraConfigDesc : IMessage<TBFUStMultiPointLockCameraConfigDesc>, IMessage, IEquatable<TBFUStMultiPointLockCameraConfigDesc>, IDeepCloneable<TBFUStMultiPointLockCameraConfigDesc>
{
	private static readonly MessageParser<TBFUStMultiPointLockCameraConfigDesc> _parser = new MessageParser<TBFUStMultiPointLockCameraConfigDesc>(() => new TBFUStMultiPointLockCameraConfigDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStMultiPointLockCameraConfigDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStMultiPointLockCameraConfigDesc.Parser);

	private readonly RepeatedField<FUStMultiPointLockCameraConfigDesc> list_ = new RepeatedField<FUStMultiPointLockCameraConfigDesc>();

	public static MessageParser<TBFUStMultiPointLockCameraConfigDesc> Parser => _parser;

	public RepeatedField<FUStMultiPointLockCameraConfigDesc> List => list_;

	public TBFUStMultiPointLockCameraConfigDesc()
	{
	}

	public TBFUStMultiPointLockCameraConfigDesc(TBFUStMultiPointLockCameraConfigDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStMultiPointLockCameraConfigDesc Clone()
	{
		return new TBFUStMultiPointLockCameraConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStMultiPointLockCameraConfigDesc);
	}

	public bool Equals(TBFUStMultiPointLockCameraConfigDesc other)
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

	public void MergeFrom(TBFUStMultiPointLockCameraConfigDesc other)
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
