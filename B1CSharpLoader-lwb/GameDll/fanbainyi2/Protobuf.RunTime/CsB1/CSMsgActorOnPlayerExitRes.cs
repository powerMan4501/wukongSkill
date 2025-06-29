using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorOnPlayerExitRes : IMessage<CSMsgActorOnPlayerExitRes>, IMessage, IEquatable<CSMsgActorOnPlayerExitRes>, IDeepCloneable<CSMsgActorOnPlayerExitRes>
{
	private static readonly MessageParser<CSMsgActorOnPlayerExitRes> _parser = new MessageParser<CSMsgActorOnPlayerExitRes>(() => new CSMsgActorOnPlayerExitRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgActorOnPlayerExitRes> Parser => _parser;

	public CSMsgActorOnPlayerExitRes()
	{
	}

	public CSMsgActorOnPlayerExitRes(CSMsgActorOnPlayerExitRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorOnPlayerExitRes Clone()
	{
		return new CSMsgActorOnPlayerExitRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorOnPlayerExitRes);
	}

	public bool Equals(CSMsgActorOnPlayerExitRes other)
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

	public void MergeFrom(CSMsgActorOnPlayerExitRes other)
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
