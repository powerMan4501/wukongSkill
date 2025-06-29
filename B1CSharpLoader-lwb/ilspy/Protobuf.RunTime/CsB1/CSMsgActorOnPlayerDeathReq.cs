using System;
using Google.Protobuf;
using ResB1;

namespace CsB1;

public sealed class CSMsgActorOnPlayerDeathReq : IMessage<CSMsgActorOnPlayerDeathReq>, IMessage, IEquatable<CSMsgActorOnPlayerDeathReq>, IDeepCloneable<CSMsgActorOnPlayerDeathReq>
{
	private static readonly MessageParser<CSMsgActorOnPlayerDeathReq> _parser = new MessageParser<CSMsgActorOnPlayerDeathReq>(() => new CSMsgActorOnPlayerDeathReq());

	private UnknownFieldSet _unknownFields;

	private YesNoType isPunish_;

	public static MessageParser<CSMsgActorOnPlayerDeathReq> Parser => _parser;

	public YesNoType IsPunish
	{
		get
		{
			return isPunish_;
		}
		set
		{
			isPunish_ = value;
		}
	}

	public CSMsgActorOnPlayerDeathReq()
	{
	}

	public CSMsgActorOnPlayerDeathReq(CSMsgActorOnPlayerDeathReq other)
		: this()
	{
		isPunish_ = other.isPunish_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorOnPlayerDeathReq Clone()
	{
		return new CSMsgActorOnPlayerDeathReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorOnPlayerDeathReq);
	}

	public bool Equals(CSMsgActorOnPlayerDeathReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsPunish != other.IsPunish)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (IsPunish != YesNoType.No)
		{
			num ^= IsPunish.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (IsPunish != YesNoType.No)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)IsPunish);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (IsPunish != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsPunish);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgActorOnPlayerDeathReq other)
	{
		if (other != null)
		{
			if (other.IsPunish != YesNoType.No)
			{
				IsPunish = other.IsPunish;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				IsPunish = (YesNoType)input.ReadEnum();
			}
		}
	}
}
