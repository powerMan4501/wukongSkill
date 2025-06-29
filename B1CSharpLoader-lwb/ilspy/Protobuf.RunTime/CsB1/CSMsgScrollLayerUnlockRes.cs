using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgScrollLayerUnlockRes : IMessage<CSMsgScrollLayerUnlockRes>, IMessage, IEquatable<CSMsgScrollLayerUnlockRes>, IDeepCloneable<CSMsgScrollLayerUnlockRes>
{
	private static readonly MessageParser<CSMsgScrollLayerUnlockRes> _parser = new MessageParser<CSMsgScrollLayerUnlockRes>(() => new CSMsgScrollLayerUnlockRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgScrollLayerUnlockRes> Parser => _parser;

	public CSMsgScrollLayerUnlockRes()
	{
	}

	public CSMsgScrollLayerUnlockRes(CSMsgScrollLayerUnlockRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgScrollLayerUnlockRes Clone()
	{
		return new CSMsgScrollLayerUnlockRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgScrollLayerUnlockRes);
	}

	public bool Equals(CSMsgScrollLayerUnlockRes other)
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

	public void MergeFrom(CSMsgScrollLayerUnlockRes other)
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
