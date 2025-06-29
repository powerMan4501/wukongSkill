using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorSetShortCutRes : IMessage<CSMsgActorSetShortCutRes>, IMessage, IEquatable<CSMsgActorSetShortCutRes>, IDeepCloneable<CSMsgActorSetShortCutRes>
{
	private static readonly MessageParser<CSMsgActorSetShortCutRes> _parser = new MessageParser<CSMsgActorSetShortCutRes>(() => new CSMsgActorSetShortCutRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgActorSetShortCutRes> Parser => _parser;

	public CSMsgActorSetShortCutRes()
	{
	}

	public CSMsgActorSetShortCutRes(CSMsgActorSetShortCutRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorSetShortCutRes Clone()
	{
		return new CSMsgActorSetShortCutRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorSetShortCutRes);
	}

	public bool Equals(CSMsgActorSetShortCutRes other)
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

	public void MergeFrom(CSMsgActorSetShortCutRes other)
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
