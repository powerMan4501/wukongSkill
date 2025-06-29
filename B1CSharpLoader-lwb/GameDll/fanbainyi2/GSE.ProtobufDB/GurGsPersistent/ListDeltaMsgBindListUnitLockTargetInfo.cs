using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsPersistent;

public sealed class ListDeltaMsgBindListUnitLockTargetInfo : IMessage<ListDeltaMsgBindListUnitLockTargetInfo>, IMessage, IEquatable<ListDeltaMsgBindListUnitLockTargetInfo>, IDeepCloneable<ListDeltaMsgBindListUnitLockTargetInfo>
{
	private static readonly MessageParser<ListDeltaMsgBindListUnitLockTargetInfo> _parser = new MessageParser<ListDeltaMsgBindListUnitLockTargetInfo>(() => new ListDeltaMsgBindListUnitLockTargetInfo());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<ListDeltaMsgUnitLockTargetInfo> _repeated_value_codec = FieldCodec.ForMessage(10u, ListDeltaMsgUnitLockTargetInfo.Parser);

	private readonly RepeatedField<ListDeltaMsgUnitLockTargetInfo> value_ = new RepeatedField<ListDeltaMsgUnitLockTargetInfo>();

	public static MessageParser<ListDeltaMsgBindListUnitLockTargetInfo> Parser => _parser;

	public RepeatedField<ListDeltaMsgUnitLockTargetInfo> Value => value_;

	public ListDeltaMsgBindListUnitLockTargetInfo()
	{
	}

	public ListDeltaMsgBindListUnitLockTargetInfo(ListDeltaMsgBindListUnitLockTargetInfo other)
		: this()
	{
		value_ = other.value_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ListDeltaMsgBindListUnitLockTargetInfo Clone()
	{
		return new ListDeltaMsgBindListUnitLockTargetInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ListDeltaMsgBindListUnitLockTargetInfo);
	}

	public bool Equals(ListDeltaMsgBindListUnitLockTargetInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!value_.Equals(other.value_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= value_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		value_.WriteTo(output, _repeated_value_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += value_.CalculateSize(_repeated_value_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ListDeltaMsgBindListUnitLockTargetInfo other)
	{
		if (other != null)
		{
			value_.Add(other.value_);
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
				value_.AddEntriesFrom(input, _repeated_value_codec);
			}
		}
	}
}
