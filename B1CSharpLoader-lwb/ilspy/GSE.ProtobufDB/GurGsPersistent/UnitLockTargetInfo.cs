using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class UnitLockTargetInfo : IMessage<UnitLockTargetInfo>, IMessage, IEquatable<UnitLockTargetInfo>, IDeepCloneable<UnitLockTargetInfo>
{
	private static readonly MessageParser<UnitLockTargetInfo> _parser = new MessageParser<UnitLockTargetInfo>(() => new UnitLockTargetInfo());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<UnitLockTargetInfo> Parser => _parser;

	public UnitLockTargetInfo()
	{
	}

	public UnitLockTargetInfo(UnitLockTargetInfo other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public UnitLockTargetInfo Clone()
	{
		return new UnitLockTargetInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as UnitLockTargetInfo);
	}

	public bool Equals(UnitLockTargetInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(UnitLockTargetInfo other)
	{
		if (other != null)
		{
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		while (input.ReadTag() != 0)
		{
			_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
		}
	}
}
