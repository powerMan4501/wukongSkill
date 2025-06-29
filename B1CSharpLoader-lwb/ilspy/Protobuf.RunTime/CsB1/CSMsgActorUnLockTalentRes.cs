using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorUnLockTalentRes : IMessage<CSMsgActorUnLockTalentRes>, IMessage, IEquatable<CSMsgActorUnLockTalentRes>, IDeepCloneable<CSMsgActorUnLockTalentRes>
{
	private static readonly MessageParser<CSMsgActorUnLockTalentRes> _parser = new MessageParser<CSMsgActorUnLockTalentRes>(() => new CSMsgActorUnLockTalentRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgActorUnLockTalentRes> Parser => _parser;

	public CSMsgActorUnLockTalentRes()
	{
	}

	public CSMsgActorUnLockTalentRes(CSMsgActorUnLockTalentRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorUnLockTalentRes Clone()
	{
		return new CSMsgActorUnLockTalentRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorUnLockTalentRes);
	}

	public bool Equals(CSMsgActorUnLockTalentRes other)
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

	public void MergeFrom(CSMsgActorUnLockTalentRes other)
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
