using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorSetDefaultSpellRes : IMessage<CSMsgActorSetDefaultSpellRes>, IMessage, IEquatable<CSMsgActorSetDefaultSpellRes>, IDeepCloneable<CSMsgActorSetDefaultSpellRes>
{
	private static readonly MessageParser<CSMsgActorSetDefaultSpellRes> _parser = new MessageParser<CSMsgActorSetDefaultSpellRes>(() => new CSMsgActorSetDefaultSpellRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgActorSetDefaultSpellRes> Parser => _parser;

	public CSMsgActorSetDefaultSpellRes()
	{
	}

	public CSMsgActorSetDefaultSpellRes(CSMsgActorSetDefaultSpellRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorSetDefaultSpellRes Clone()
	{
		return new CSMsgActorSetDefaultSpellRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorSetDefaultSpellRes);
	}

	public bool Equals(CSMsgActorSetDefaultSpellRes other)
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

	public void MergeFrom(CSMsgActorSetDefaultSpellRes other)
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
