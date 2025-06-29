using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorOnPlayerRestRes : IMessage<CSMsgActorOnPlayerRestRes>, IMessage, IEquatable<CSMsgActorOnPlayerRestRes>, IDeepCloneable<CSMsgActorOnPlayerRestRes>
{
	private static readonly MessageParser<CSMsgActorOnPlayerRestRes> _parser = new MessageParser<CSMsgActorOnPlayerRestRes>(() => new CSMsgActorOnPlayerRestRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgActorOnPlayerRestRes> Parser => _parser;

	public CSMsgActorOnPlayerRestRes()
	{
	}

	public CSMsgActorOnPlayerRestRes(CSMsgActorOnPlayerRestRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorOnPlayerRestRes Clone()
	{
		return new CSMsgActorOnPlayerRestRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorOnPlayerRestRes);
	}

	public bool Equals(CSMsgActorOnPlayerRestRes other)
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

	public void MergeFrom(CSMsgActorOnPlayerRestRes other)
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
