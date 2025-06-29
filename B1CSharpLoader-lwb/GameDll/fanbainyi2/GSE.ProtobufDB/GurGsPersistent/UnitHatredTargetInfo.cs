using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class UnitHatredTargetInfo : IMessage<UnitHatredTargetInfo>, IMessage, IEquatable<UnitHatredTargetInfo>, IDeepCloneable<UnitHatredTargetInfo>
{
	private static readonly MessageParser<UnitHatredTargetInfo> _parser = new MessageParser<UnitHatredTargetInfo>(() => new UnitHatredTargetInfo());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<UnitHatredTargetInfo> Parser => _parser;

	public UnitHatredTargetInfo()
	{
	}

	public UnitHatredTargetInfo(UnitHatredTargetInfo other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public UnitHatredTargetInfo Clone()
	{
		return new UnitHatredTargetInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as UnitHatredTargetInfo);
	}

	public bool Equals(UnitHatredTargetInfo other)
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

	public void MergeFrom(UnitHatredTargetInfo other)
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
