using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgMiscCheckResRes : IMessage<CSMsgMiscCheckResRes>, IMessage, IEquatable<CSMsgMiscCheckResRes>, IDeepCloneable<CSMsgMiscCheckResRes>
{
	private static readonly MessageParser<CSMsgMiscCheckResRes> _parser = new MessageParser<CSMsgMiscCheckResRes>(() => new CSMsgMiscCheckResRes());

	private UnknownFieldSet _unknownFields;

	private CSCheckResList pathDiff_;

	public static MessageParser<CSMsgMiscCheckResRes> Parser => _parser;

	public CSCheckResList PathDiff
	{
		get
		{
			return pathDiff_;
		}
		set
		{
			pathDiff_ = value;
		}
	}

	public CSMsgMiscCheckResRes()
	{
	}

	public CSMsgMiscCheckResRes(CSMsgMiscCheckResRes other)
		: this()
	{
		pathDiff_ = ((other.pathDiff_ != null) ? other.pathDiff_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgMiscCheckResRes Clone()
	{
		return new CSMsgMiscCheckResRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgMiscCheckResRes);
	}

	public bool Equals(CSMsgMiscCheckResRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(PathDiff, other.PathDiff))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (pathDiff_ != null)
		{
			num ^= PathDiff.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (pathDiff_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(PathDiff);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (pathDiff_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PathDiff);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgMiscCheckResRes other)
	{
		if (other == null)
		{
			return;
		}
		if (other.pathDiff_ != null)
		{
			if (pathDiff_ == null)
			{
				PathDiff = new CSCheckResList();
			}
			PathDiff.MergeFrom(other.PathDiff);
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
			if (pathDiff_ == null)
			{
				PathDiff = new CSCheckResList();
			}
			input.ReadMessage(PathDiff);
		}
	}
}
