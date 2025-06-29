using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class FCrusadeUnitInfo : IMessage<FCrusadeUnitInfo>, IMessage, IEquatable<FCrusadeUnitInfo>, IDeepCloneable<FCrusadeUnitInfo>
{
	private static readonly MessageParser<FCrusadeUnitInfo> _parser = new MessageParser<FCrusadeUnitInfo>(() => new FCrusadeUnitInfo());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<FCrusadeUnitInfo> Parser => _parser;

	public FCrusadeUnitInfo()
	{
	}

	public FCrusadeUnitInfo(FCrusadeUnitInfo other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FCrusadeUnitInfo Clone()
	{
		return new FCrusadeUnitInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FCrusadeUnitInfo);
	}

	public bool Equals(FCrusadeUnitInfo other)
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

	public void MergeFrom(FCrusadeUnitInfo other)
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
