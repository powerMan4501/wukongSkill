using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgMuseumRemoveRedpointRes : IMessage<CSMsgMuseumRemoveRedpointRes>, IMessage, IEquatable<CSMsgMuseumRemoveRedpointRes>, IDeepCloneable<CSMsgMuseumRemoveRedpointRes>
{
	private static readonly MessageParser<CSMsgMuseumRemoveRedpointRes> _parser = new MessageParser<CSMsgMuseumRemoveRedpointRes>(() => new CSMsgMuseumRemoveRedpointRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgMuseumRemoveRedpointRes> Parser => _parser;

	public CSMsgMuseumRemoveRedpointRes()
	{
	}

	public CSMsgMuseumRemoveRedpointRes(CSMsgMuseumRemoveRedpointRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgMuseumRemoveRedpointRes Clone()
	{
		return new CSMsgMuseumRemoveRedpointRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgMuseumRemoveRedpointRes);
	}

	public bool Equals(CSMsgMuseumRemoveRedpointRes other)
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

	public void MergeFrom(CSMsgMuseumRemoveRedpointRes other)
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
