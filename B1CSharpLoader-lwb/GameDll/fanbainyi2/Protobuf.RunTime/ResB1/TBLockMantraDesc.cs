using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TBLockMantraDesc : IMessage<TBLockMantraDesc>, IMessage, IEquatable<TBLockMantraDesc>, IDeepCloneable<TBLockMantraDesc>
{
	private static readonly MessageParser<TBLockMantraDesc> _parser = new MessageParser<TBLockMantraDesc>(() => new TBLockMantraDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<LockMantraDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, LockMantraDesc.Parser);

	private readonly RepeatedField<LockMantraDesc> list_ = new RepeatedField<LockMantraDesc>();

	public static MessageParser<TBLockMantraDesc> Parser => _parser;

	public RepeatedField<LockMantraDesc> List => list_;

	public TBLockMantraDesc()
	{
	}

	public TBLockMantraDesc(TBLockMantraDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBLockMantraDesc Clone()
	{
		return new TBLockMantraDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBLockMantraDesc);
	}

	public bool Equals(TBLockMantraDesc other)
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

	public void MergeFrom(TBLockMantraDesc other)
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
