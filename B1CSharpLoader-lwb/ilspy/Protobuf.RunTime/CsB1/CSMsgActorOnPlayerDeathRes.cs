using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorOnPlayerDeathRes : IMessage<CSMsgActorOnPlayerDeathRes>, IMessage, IEquatable<CSMsgActorOnPlayerDeathRes>, IDeepCloneable<CSMsgActorOnPlayerDeathRes>
{
	private static readonly MessageParser<CSMsgActorOnPlayerDeathRes> _parser = new MessageParser<CSMsgActorOnPlayerDeathRes>(() => new CSMsgActorOnPlayerDeathRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgActorOnPlayerDeathRes> Parser => _parser;

	public CSMsgActorOnPlayerDeathRes()
	{
	}

	public CSMsgActorOnPlayerDeathRes(CSMsgActorOnPlayerDeathRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorOnPlayerDeathRes Clone()
	{
		return new CSMsgActorOnPlayerDeathRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorOnPlayerDeathRes);
	}

	public bool Equals(CSMsgActorOnPlayerDeathRes other)
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

	public void MergeFrom(CSMsgActorOnPlayerDeathRes other)
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
