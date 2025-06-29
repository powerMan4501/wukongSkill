using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgMiscCheckResReq : IMessage<CSMsgMiscCheckResReq>, IMessage, IEquatable<CSMsgMiscCheckResReq>, IDeepCloneable<CSMsgMiscCheckResReq>
{
	private static readonly MessageParser<CSMsgMiscCheckResReq> _parser = new MessageParser<CSMsgMiscCheckResReq>(() => new CSMsgMiscCheckResReq());

	private UnknownFieldSet _unknownFields;

	private CSCheckResList pathCheck_;

	public static MessageParser<CSMsgMiscCheckResReq> Parser => _parser;

	public CSCheckResList PathCheck
	{
		get
		{
			return pathCheck_;
		}
		set
		{
			pathCheck_ = value;
		}
	}

	public CSMsgMiscCheckResReq()
	{
	}

	public CSMsgMiscCheckResReq(CSMsgMiscCheckResReq other)
		: this()
	{
		pathCheck_ = ((other.pathCheck_ != null) ? other.pathCheck_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgMiscCheckResReq Clone()
	{
		return new CSMsgMiscCheckResReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgMiscCheckResReq);
	}

	public bool Equals(CSMsgMiscCheckResReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(PathCheck, other.PathCheck))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (pathCheck_ != null)
		{
			num ^= PathCheck.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (pathCheck_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(PathCheck);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (pathCheck_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PathCheck);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgMiscCheckResReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.pathCheck_ != null)
		{
			if (pathCheck_ == null)
			{
				PathCheck = new CSCheckResList();
			}
			PathCheck.MergeFrom(other.PathCheck);
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
			if (pathCheck_ == null)
			{
				PathCheck = new CSCheckResList();
			}
			input.ReadMessage(PathCheck);
		}
	}
}
