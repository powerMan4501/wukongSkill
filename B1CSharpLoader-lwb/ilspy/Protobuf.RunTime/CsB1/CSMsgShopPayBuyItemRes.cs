using System;
using CommB1;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgShopPayBuyItemRes : IMessage<CSMsgShopPayBuyItemRes>, IMessage, IEquatable<CSMsgShopPayBuyItemRes>, IDeepCloneable<CSMsgShopPayBuyItemRes>
{
	private static readonly MessageParser<CSMsgShopPayBuyItemRes> _parser = new MessageParser<CSMsgShopPayBuyItemRes>(() => new CSMsgShopPayBuyItemRes());

	private UnknownFieldSet _unknownFields;

	private AwardList awardList_;

	private bool beStored_;

	public static MessageParser<CSMsgShopPayBuyItemRes> Parser => _parser;

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

	public bool BeStored
	{
		get
		{
			return beStored_;
		}
		set
		{
			beStored_ = value;
		}
	}

	public CSMsgShopPayBuyItemRes()
	{
	}

	public CSMsgShopPayBuyItemRes(CSMsgShopPayBuyItemRes other)
		: this()
	{
		awardList_ = ((other.awardList_ != null) ? other.awardList_.Clone() : null);
		beStored_ = other.beStored_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgShopPayBuyItemRes Clone()
	{
		return new CSMsgShopPayBuyItemRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgShopPayBuyItemRes);
	}

	public bool Equals(CSMsgShopPayBuyItemRes other)
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
		if (BeStored != other.BeStored)
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
		if (BeStored)
		{
			num ^= BeStored.GetHashCode();
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
		if (BeStored)
		{
			output.WriteRawTag(16);
			output.WriteBool(BeStored);
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
		if (BeStored)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgShopPayBuyItemRes other)
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
		if (other.BeStored)
		{
			BeStored = other.BeStored;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 10u:
				if (awardList_ == null)
				{
					AwardList = new AwardList();
				}
				input.ReadMessage(AwardList);
				break;
			case 16u:
				BeStored = input.ReadBool();
				break;
			}
		}
	}
}
