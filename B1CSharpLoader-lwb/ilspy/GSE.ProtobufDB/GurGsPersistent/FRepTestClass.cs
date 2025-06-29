using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class FRepTestClass : IMessage<FRepTestClass>, IMessage, IEquatable<FRepTestClass>, IDeepCloneable<FRepTestClass>
{
	private static readonly MessageParser<FRepTestClass> _parser = new MessageParser<FRepTestClass>(() => new FRepTestClass());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<FRepTestClass> Parser => _parser;

	public FRepTestClass()
	{
	}

	public FRepTestClass(FRepTestClass other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FRepTestClass Clone()
	{
		return new FRepTestClass(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FRepTestClass);
	}

	public bool Equals(FRepTestClass other)
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

	public void MergeFrom(FRepTestClass other)
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
