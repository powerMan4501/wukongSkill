using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgMuseumRecordMemoriesRes : IMessage<CSMsgMuseumRecordMemoriesRes>, IMessage, IEquatable<CSMsgMuseumRecordMemoriesRes>, IDeepCloneable<CSMsgMuseumRecordMemoriesRes>
{
	private static readonly MessageParser<CSMsgMuseumRecordMemoriesRes> _parser = new MessageParser<CSMsgMuseumRecordMemoriesRes>(() => new CSMsgMuseumRecordMemoriesRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgMuseumRecordMemoriesRes> Parser => _parser;

	public CSMsgMuseumRecordMemoriesRes()
	{
	}

	public CSMsgMuseumRecordMemoriesRes(CSMsgMuseumRecordMemoriesRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgMuseumRecordMemoriesRes Clone()
	{
		return new CSMsgMuseumRecordMemoriesRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgMuseumRecordMemoriesRes);
	}

	public bool Equals(CSMsgMuseumRecordMemoriesRes other)
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

	public void MergeFrom(CSMsgMuseumRecordMemoriesRes other)
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
