using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorSetSpellRes : IMessage<CSMsgActorSetSpellRes>, IMessage, IEquatable<CSMsgActorSetSpellRes>, IDeepCloneable<CSMsgActorSetSpellRes>
{
	private static readonly MessageParser<CSMsgActorSetSpellRes> _parser = new MessageParser<CSMsgActorSetSpellRes>(() => new CSMsgActorSetSpellRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgActorSetSpellRes> Parser => _parser;

	public CSMsgActorSetSpellRes()
	{
	}

	public CSMsgActorSetSpellRes(CSMsgActorSetSpellRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorSetSpellRes Clone()
	{
		return new CSMsgActorSetSpellRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorSetSpellRes);
	}

	public bool Equals(CSMsgActorSetSpellRes other)
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

	public void MergeFrom(CSMsgActorSetSpellRes other)
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
