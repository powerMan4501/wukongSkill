using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class BuffInstData : IMessage<BuffInstData>, IMessage, IEquatable<BuffInstData>, IDeepCloneable<BuffInstData>
{
	private static readonly MessageParser<BuffInstData> _parser = new MessageParser<BuffInstData>(() => new BuffInstData());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<BuffInstData> Parser => _parser;

	public BuffInstData()
	{
	}

	public BuffInstData(BuffInstData other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BuffInstData Clone()
	{
		return new BuffInstData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BuffInstData);
	}

	public bool Equals(BuffInstData other)
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

	public void MergeFrom(BuffInstData other)
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
