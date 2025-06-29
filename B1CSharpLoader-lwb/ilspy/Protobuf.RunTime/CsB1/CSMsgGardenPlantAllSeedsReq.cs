using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgGardenPlantAllSeedsReq : IMessage<CSMsgGardenPlantAllSeedsReq>, IMessage, IEquatable<CSMsgGardenPlantAllSeedsReq>, IDeepCloneable<CSMsgGardenPlantAllSeedsReq>
{
	private static readonly MessageParser<CSMsgGardenPlantAllSeedsReq> _parser = new MessageParser<CSMsgGardenPlantAllSeedsReq>(() => new CSMsgGardenPlantAllSeedsReq());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CSMsgGardenPlantAllSeedsReq> Parser => _parser;

	public CSMsgGardenPlantAllSeedsReq()
	{
	}

	public CSMsgGardenPlantAllSeedsReq(CSMsgGardenPlantAllSeedsReq other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgGardenPlantAllSeedsReq Clone()
	{
		return new CSMsgGardenPlantAllSeedsReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgGardenPlantAllSeedsReq);
	}

	public bool Equals(CSMsgGardenPlantAllSeedsReq other)
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

	public void MergeFrom(CSMsgGardenPlantAllSeedsReq other)
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
