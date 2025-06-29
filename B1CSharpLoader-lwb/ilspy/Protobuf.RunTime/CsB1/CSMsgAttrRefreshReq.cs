using System;
using Google.Protobuf;
using ResB1;

namespace CsB1;

public sealed class CSMsgAttrRefreshReq : IMessage<CSMsgAttrRefreshReq>, IMessage, IEquatable<CSMsgAttrRefreshReq>, IDeepCloneable<CSMsgAttrRefreshReq>
{
	private static readonly MessageParser<CSMsgAttrRefreshReq> _parser = new MessageParser<CSMsgAttrRefreshReq>(() => new CSMsgAttrRefreshReq());

	private UnknownFieldSet _unknownFields;

	private OPReason reason_;

	public static MessageParser<CSMsgAttrRefreshReq> Parser => _parser;

	public OPReason Reason
	{
		get
		{
			return reason_;
		}
		set
		{
			reason_ = value;
		}
	}

	public CSMsgAttrRefreshReq()
	{
	}

	public CSMsgAttrRefreshReq(CSMsgAttrRefreshReq other)
		: this()
	{
		reason_ = other.reason_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgAttrRefreshReq Clone()
	{
		return new CSMsgAttrRefreshReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgAttrRefreshReq);
	}

	public bool Equals(CSMsgAttrRefreshReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Reason != other.Reason)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Reason != OPReason.None)
		{
			num ^= Reason.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Reason != OPReason.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Reason);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Reason != OPReason.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Reason);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgAttrRefreshReq other)
	{
		if (other != null)
		{
			if (other.Reason != OPReason.None)
			{
				Reason = other.Reason;
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
				Reason = (OPReason)input.ReadEnum();
			}
		}
	}
}
