using System;
using CommB1;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgBagDropCollectionAwardRes : IMessage<CSMsgBagDropCollectionAwardRes>, IMessage, IEquatable<CSMsgBagDropCollectionAwardRes>, IDeepCloneable<CSMsgBagDropCollectionAwardRes>
{
	private static readonly MessageParser<CSMsgBagDropCollectionAwardRes> _parser = new MessageParser<CSMsgBagDropCollectionAwardRes>(() => new CSMsgBagDropCollectionAwardRes());

	private UnknownFieldSet _unknownFields;

	private AwardList awardList_;

	public static MessageParser<CSMsgBagDropCollectionAwardRes> Parser => _parser;

	public AwardList AwardList
	{
		get
		{
			return awardList_;
		}
		set
		{
			awardList_ = value;
		}
	}

	public CSMsgBagDropCollectionAwardRes()
	{
	}

	public CSMsgBagDropCollectionAwardRes(CSMsgBagDropCollectionAwardRes other)
		: this()
	{
		awardList_ = ((other.awardList_ != null) ? other.awardList_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagDropCollectionAwardRes Clone()
	{
		return new CSMsgBagDropCollectionAwardRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagDropCollectionAwardRes);
	}

	public bool Equals(CSMsgBagDropCollectionAwardRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(AwardList, other.AwardList))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (awardList_ != null)
		{
			num ^= AwardList.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (awardList_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(AwardList);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (awardList_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AwardList);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgBagDropCollectionAwardRes other)
	{
		if (other == null)
		{
			return;
		}
		if (other.awardList_ != null)
		{
			if (awardList_ == null)
			{
				AwardList = new AwardList();
			}
			AwardList.MergeFrom(other.AwardList);
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
			if (awardList_ == null)
			{
				AwardList = new AwardList();
			}
			input.ReadMessage(AwardList);
		}
	}
}
