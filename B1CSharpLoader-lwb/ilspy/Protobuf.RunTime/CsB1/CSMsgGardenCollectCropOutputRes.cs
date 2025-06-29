using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgGardenCollectCropOutputRes : IMessage<CSMsgGardenCollectCropOutputRes>, IMessage, IEquatable<CSMsgGardenCollectCropOutputRes>, IDeepCloneable<CSMsgGardenCollectCropOutputRes>
{
	private static readonly MessageParser<CSMsgGardenCollectCropOutputRes> _parser = new MessageParser<CSMsgGardenCollectCropOutputRes>(() => new CSMsgGardenCollectCropOutputRes());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgGardenCollectCropOutputRes> Parser => _parser;

	public CSMsgGardenCollectCropOutputRes()
	{
	}

	public CSMsgGardenCollectCropOutputRes(CSMsgGardenCollectCropOutputRes other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgGardenCollectCropOutputRes Clone()
	{
		return new CSMsgGardenCollectCropOutputRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgGardenCollectCropOutputRes);
	}

	public bool Equals(CSMsgGardenCollectCropOutputRes other)
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

	public void MergeFrom(CSMsgGardenCollectCropOutputRes other)
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
