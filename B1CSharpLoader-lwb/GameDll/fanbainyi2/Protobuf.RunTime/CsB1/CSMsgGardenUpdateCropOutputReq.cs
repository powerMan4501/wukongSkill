using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgGardenUpdateCropOutputReq : IMessage<CSMsgGardenUpdateCropOutputReq>, IMessage, IEquatable<CSMsgGardenUpdateCropOutputReq>, IDeepCloneable<CSMsgGardenUpdateCropOutputReq>
{
	private static readonly MessageParser<CSMsgGardenUpdateCropOutputReq> _parser = new MessageParser<CSMsgGardenUpdateCropOutputReq>(() => new CSMsgGardenUpdateCropOutputReq());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgGardenUpdateCropOutputReq> Parser => _parser;

	public CSMsgGardenUpdateCropOutputReq()
	{
	}

	public CSMsgGardenUpdateCropOutputReq(CSMsgGardenUpdateCropOutputReq other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgGardenUpdateCropOutputReq Clone()
	{
		return new CSMsgGardenUpdateCropOutputReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgGardenUpdateCropOutputReq);
	}

	public bool Equals(CSMsgGardenUpdateCropOutputReq other)
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

	public void MergeFrom(CSMsgGardenUpdateCropOutputReq other)
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
