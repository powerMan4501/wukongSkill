using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgGardenUpdateCropOutputRes : IMessage<CSMsgGardenUpdateCropOutputRes>, IMessage, IEquatable<CSMsgGardenUpdateCropOutputRes>, IDeepCloneable<CSMsgGardenUpdateCropOutputRes>
{
	private static readonly MessageParser<CSMsgGardenUpdateCropOutputRes> _parser = new MessageParser<CSMsgGardenUpdateCropOutputRes>(() => new CSMsgGardenUpdateCropOutputRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgGardenUpdateCropOutputRes> Parser => _parser;

	public CSMsgGardenUpdateCropOutputRes()
	{
	}

	public CSMsgGardenUpdateCropOutputRes(CSMsgGardenUpdateCropOutputRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgGardenUpdateCropOutputRes Clone()
	{
		return new CSMsgGardenUpdateCropOutputRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgGardenUpdateCropOutputRes);
	}

	public bool Equals(CSMsgGardenUpdateCropOutputRes other)
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

	public void MergeFrom(CSMsgGardenUpdateCropOutputRes other)
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
