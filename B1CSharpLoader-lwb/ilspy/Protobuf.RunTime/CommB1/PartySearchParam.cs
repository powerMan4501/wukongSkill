using System;
using Google.Protobuf;

namespace CommB1;

public sealed class PartySearchParam : IMessage<PartySearchParam>, IMessage, IEquatable<PartySearchParam>, IDeepCloneable<PartySearchParam>
{
	private static readonly MessageParser<PartySearchParam> _parser = new MessageParser<PartySearchParam>(() => new PartySearchParam());

	private UnknownFieldSet _unknownFields;

	private PartySearchType type_;

	public static MessageParser<PartySearchParam> Parser => _parser;

	public PartySearchType Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	public PartySearchParam()
	{
	}

	public PartySearchParam(PartySearchParam other)
		: this()
	{
		type_ = other.type_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PartySearchParam Clone()
	{
		return new PartySearchParam(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PartySearchParam);
	}

	public bool Equals(PartySearchParam other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Type != other.Type)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Type != PartySearchType.Party)
		{
			num ^= Type.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Type != PartySearchType.Party)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Type);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Type != PartySearchType.Party)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PartySearchParam other)
	{
		if (other != null)
		{
			if (other.Type != PartySearchType.Party)
			{
				Type = other.Type;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				Type = (PartySearchType)input.ReadEnum();
			}
		}
	}
}
