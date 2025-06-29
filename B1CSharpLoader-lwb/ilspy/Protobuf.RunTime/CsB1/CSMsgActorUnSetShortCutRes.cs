using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorUnSetShortCutRes : IMessage<CSMsgActorUnSetShortCutRes>, IMessage, IEquatable<CSMsgActorUnSetShortCutRes>, IDeepCloneable<CSMsgActorUnSetShortCutRes>
{
	private static readonly MessageParser<CSMsgActorUnSetShortCutRes> _parser = new MessageParser<CSMsgActorUnSetShortCutRes>(() => new CSMsgActorUnSetShortCutRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgActorUnSetShortCutRes> Parser => _parser;

	public CSMsgActorUnSetShortCutRes()
	{
	}

	public CSMsgActorUnSetShortCutRes(CSMsgActorUnSetShortCutRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorUnSetShortCutRes Clone()
	{
		return new CSMsgActorUnSetShortCutRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorUnSetShortCutRes);
	}

	public bool Equals(CSMsgActorUnSetShortCutRes other)
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

	public void MergeFrom(CSMsgActorUnSetShortCutRes other)
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
