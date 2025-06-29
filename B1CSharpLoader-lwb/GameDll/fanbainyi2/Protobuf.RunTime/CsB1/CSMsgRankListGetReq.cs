using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRankListGetReq : IMessage<CSMsgRankListGetReq>, IMessage, IEquatable<CSMsgRankListGetReq>, IDeepCloneable<CSMsgRankListGetReq>
{
	private static readonly MessageParser<CSMsgRankListGetReq> _parser = new MessageParser<CSMsgRankListGetReq>(() => new CSMsgRankListGetReq());

	private UnknownFieldSet _unknownFields;

	private CSRankListGetParam param_;

	public static MessageParser<CSMsgRankListGetReq> Parser => _parser;

	public CSRankListGetParam Param
	{
		get
		{
			return param_;
		}
		set
		{
			param_ = value;
		}
	}

	public CSMsgRankListGetReq()
	{
	}

	public CSMsgRankListGetReq(CSMsgRankListGetReq other)
		: this()
	{
		param_ = ((other.param_ != null) ? other.param_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRankListGetReq Clone()
	{
		return new CSMsgRankListGetReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRankListGetReq);
	}

	public bool Equals(CSMsgRankListGetReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Param, other.Param))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (param_ != null)
		{
			num ^= Param.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (param_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Param);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (param_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Param);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgRankListGetReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.param_ != null)
		{
			if (param_ == null)
			{
				Param = new CSRankListGetParam();
			}
			Param.MergeFrom(other.Param);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				continue;
			}
			if (param_ == null)
			{
				Param = new CSRankListGetParam();
			}
			input.ReadMessage(Param);
		}
	}
}
