using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgAttrChangeNotifyRes : IMessage<CSMsgAttrChangeNotifyRes>, IMessage, IEquatable<CSMsgAttrChangeNotifyRes>, IDeepCloneable<CSMsgAttrChangeNotifyRes>
{
	private static readonly MessageParser<CSMsgAttrChangeNotifyRes> _parser = new MessageParser<CSMsgAttrChangeNotifyRes>(() => new CSMsgAttrChangeNotifyRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgAttrChangeNotifyRes> Parser => _parser;

	public CSMsgAttrChangeNotifyRes()
	{
	}

	public CSMsgAttrChangeNotifyRes(CSMsgAttrChangeNotifyRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgAttrChangeNotifyRes Clone()
	{
		return new CSMsgAttrChangeNotifyRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgAttrChangeNotifyRes);
	}

	public bool Equals(CSMsgAttrChangeNotifyRes other)
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

	public void MergeFrom(CSMsgAttrChangeNotifyRes other)
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
