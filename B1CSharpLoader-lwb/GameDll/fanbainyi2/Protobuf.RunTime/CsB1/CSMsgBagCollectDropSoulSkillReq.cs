using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgBagCollectDropSoulSkillReq : IMessage<CSMsgBagCollectDropSoulSkillReq>, IMessage, IEquatable<CSMsgBagCollectDropSoulSkillReq>, IDeepCloneable<CSMsgBagCollectDropSoulSkillReq>
{
	private static readonly MessageParser<CSMsgBagCollectDropSoulSkillReq> _parser = new MessageParser<CSMsgBagCollectDropSoulSkillReq>(() => new CSMsgBagCollectDropSoulSkillReq());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgBagCollectDropSoulSkillReq> Parser => _parser;

	public CSMsgBagCollectDropSoulSkillReq()
	{
	}

	public CSMsgBagCollectDropSoulSkillReq(CSMsgBagCollectDropSoulSkillReq other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagCollectDropSoulSkillReq Clone()
	{
		return new CSMsgBagCollectDropSoulSkillReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagCollectDropSoulSkillReq);
	}

	public bool Equals(CSMsgBagCollectDropSoulSkillReq other)
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

	public void MergeFrom(CSMsgBagCollectDropSoulSkillReq other)
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
