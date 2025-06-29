using System;
using Google.Protobuf;

namespace GurGsStruct;

public sealed class FBirthPointInfo : IMessage<FBirthPointInfo>, IMessage, IEquatable<FBirthPointInfo>, IDeepCloneable<FBirthPointInfo>
{
	private static readonly MessageParser<FBirthPointInfo> _parser = new MessageParser<FBirthPointInfo>(() => new FBirthPointInfo());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<FBirthPointInfo> Parser => _parser;

	public FBirthPointInfo()
	{
	}

	public FBirthPointInfo(FBirthPointInfo other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FBirthPointInfo Clone()
	{
		return new FBirthPointInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FBirthPointInfo);
	}

	public bool Equals(FBirthPointInfo other)
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

	public void MergeFrom(FBirthPointInfo other)
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
