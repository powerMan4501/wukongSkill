using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorWearAccessoryRes : IMessage<CSMsgActorWearAccessoryRes>, IMessage, IEquatable<CSMsgActorWearAccessoryRes>, IDeepCloneable<CSMsgActorWearAccessoryRes>
{
	private static readonly MessageParser<CSMsgActorWearAccessoryRes> _parser = new MessageParser<CSMsgActorWearAccessoryRes>(() => new CSMsgActorWearAccessoryRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgActorWearAccessoryRes> Parser => _parser;

	public CSMsgActorWearAccessoryRes()
	{
	}

	public CSMsgActorWearAccessoryRes(CSMsgActorWearAccessoryRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorWearAccessoryRes Clone()
	{
		return new CSMsgActorWearAccessoryRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorWearAccessoryRes);
	}

	public bool Equals(CSMsgActorWearAccessoryRes other)
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

	public void MergeFrom(CSMsgActorWearAccessoryRes other)
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
