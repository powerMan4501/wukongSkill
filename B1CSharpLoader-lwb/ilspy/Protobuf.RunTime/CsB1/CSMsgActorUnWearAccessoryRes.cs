using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorUnWearAccessoryRes : IMessage<CSMsgActorUnWearAccessoryRes>, IMessage, IEquatable<CSMsgActorUnWearAccessoryRes>, IDeepCloneable<CSMsgActorUnWearAccessoryRes>
{
	private static readonly MessageParser<CSMsgActorUnWearAccessoryRes> _parser = new MessageParser<CSMsgActorUnWearAccessoryRes>(() => new CSMsgActorUnWearAccessoryRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgActorUnWearAccessoryRes> Parser => _parser;

	public CSMsgActorUnWearAccessoryRes()
	{
	}

	public CSMsgActorUnWearAccessoryRes(CSMsgActorUnWearAccessoryRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorUnWearAccessoryRes Clone()
	{
		return new CSMsgActorUnWearAccessoryRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorUnWearAccessoryRes);
	}

	public bool Equals(CSMsgActorUnWearAccessoryRes other)
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

	public void MergeFrom(CSMsgActorUnWearAccessoryRes other)
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
