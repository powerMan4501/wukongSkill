using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class FRepInnerClass : IMessage<FRepInnerClass>, IMessage, IEquatable<FRepInnerClass>, IDeepCloneable<FRepInnerClass>
{
	private static readonly MessageParser<FRepInnerClass> _parser = new MessageParser<FRepInnerClass>(() => new FRepInnerClass());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<FRepInnerClass> Parser => _parser;

	public FRepInnerClass()
	{
	}

	public FRepInnerClass(FRepInnerClass other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FRepInnerClass Clone()
	{
		return new FRepInnerClass(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FRepInnerClass);
	}

	public bool Equals(FRepInnerClass other)
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

	public void MergeFrom(FRepInnerClass other)
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
