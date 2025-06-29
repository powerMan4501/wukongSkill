using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorUnSetSpellRes : IMessage<CSMsgActorUnSetSpellRes>, IMessage, IEquatable<CSMsgActorUnSetSpellRes>, IDeepCloneable<CSMsgActorUnSetSpellRes>
{
	private static readonly MessageParser<CSMsgActorUnSetSpellRes> _parser = new MessageParser<CSMsgActorUnSetSpellRes>(() => new CSMsgActorUnSetSpellRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgActorUnSetSpellRes> Parser => _parser;

	public CSMsgActorUnSetSpellRes()
	{
	}

	public CSMsgActorUnSetSpellRes(CSMsgActorUnSetSpellRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorUnSetSpellRes Clone()
	{
		return new CSMsgActorUnSetSpellRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorUnSetSpellRes);
	}

	public bool Equals(CSMsgActorUnSetSpellRes other)
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

	public void MergeFrom(CSMsgActorUnSetSpellRes other)
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
