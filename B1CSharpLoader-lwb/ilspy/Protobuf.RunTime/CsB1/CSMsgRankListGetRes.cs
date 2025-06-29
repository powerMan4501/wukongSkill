using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CsB1;

public sealed class CSMsgRankListGetRes : IMessage<CSMsgRankListGetRes>, IMessage, IEquatable<CSMsgRankListGetRes>, IDeepCloneable<CSMsgRankListGetRes>
{
	private static readonly MessageParser<CSMsgRankListGetRes> _parser = new MessageParser<CSMsgRankListGetRes>(() => new CSMsgRankListGetRes());

	private UnknownFieldSet _unknownFields;

	private CSRankListGetParam param_;

	private static readonly FieldCodec<CSRankListOne> _repeated_rankList_codec = FieldCodec.ForMessage(18u, CSRankListOne.Parser);

	private readonly RepeatedField<CSRankListOne> rankList_ = new RepeatedField<CSRankListOne>();

	private CSRankListOne selfRankValue_;

	private int selfRank_;

	private int total_;

	public static MessageParser<CSMsgRankListGetRes> Parser => _parser;

	public CSRankListGetParam Param
	{
		get
		{
			return param_;
		}
		set
		{
			param_ = value;
		}
	}

	public RepeatedField<CSRankListOne> RankList => rankList_;

	public CSRankListOne SelfRankValue
	{
		get
		{
			return selfRankValue_;
		}
		set
		{
			selfRankValue_ = value;
		}
	}

	public int SelfRank
	{
		get
		{
			return selfRank_;
		}
		set
		{
			selfRank_ = value;
		}
	}

	public int Total
	{
		get
		{
			return total_;
		}
		set
		{
			total_ = value;
		}
	}

	public CSMsgRankListGetRes()
	{
	}

	public CSMsgRankListGetRes(CSMsgRankListGetRes other)
		: this()
	{
		param_ = ((other.param_ != null) ? other.param_.Clone() : null);
		rankList_ = other.rankList_.Clone();
		selfRankValue_ = ((other.selfRankValue_ != null) ? other.selfRankValue_.Clone() : null);
		selfRank_ = other.selfRank_;
		total_ = other.total_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRankListGetRes Clone()
	{
		return new CSMsgRankListGetRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRankListGetRes);
	}

	public bool Equals(CSMsgRankListGetRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Param, other.Param))
		{
			return false;
		}
		if (!rankList_.Equals(other.rankList_))
		{
			return false;
		}
		if (!object.Equals(SelfRankValue, other.SelfRankValue))
		{
			return false;
		}
		if (SelfRank != other.SelfRank)
		{
			return false;
		}
		if (Total != other.Total)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (param_ != null)
		{
			num ^= Param.GetHashCode();
		}
		num ^= rankList_.GetHashCode();
		if (selfRankValue_ != null)
		{
			num ^= SelfRankValue.GetHashCode();
		}
		if (SelfRank != 0)
		{
			num ^= SelfRank.GetHashCode();
		}
		if (Total != 0)
		{
			num ^= Total.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (param_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Param);
		}
		rankList_.WriteTo(output, _repeated_rankList_codec);
		if (selfRankValue_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(SelfRankValue);
		}
		if (SelfRank != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(SelfRank);
		}
		if (Total != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Total);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (param_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Param);
		}
		num += rankList_.CalculateSize(_repeated_rankList_codec);
		if (selfRankValue_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SelfRankValue);
		}
		if (SelfRank != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SelfRank);
		}
		if (Total != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Total);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgRankListGetRes other)
	{
		if (other == null)
		{
			return;
		}
		if (other.param_ != null)
		{
			if (param_ == null)
			{
				Param = new CSRankListGetParam();
			}
			Param.MergeFrom(other.Param);
		}
		rankList_.Add(other.rankList_);
		if (other.selfRankValue_ != null)
		{
			if (selfRankValue_ == null)
			{
				SelfRankValue = new CSRankListOne();
			}
			SelfRankValue.MergeFrom(other.SelfRankValue);
		}
		if (other.SelfRank != 0)
		{
			SelfRank = other.SelfRank;
		}
		if (other.Total != 0)
		{
			Total = other.Total;
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
				if (param_ == null)
				{
					Param = new CSRankListGetParam();
				}
				input.ReadMessage(Param);
				break;
			case 18u:
				rankList_.AddEntriesFrom(input, _repeated_rankList_codec);
				break;
			case 26u:
				if (selfRankValue_ == null)
				{
					SelfRankValue = new CSRankListOne();
				}
				input.ReadMessage(SelfRankValue);
				break;
			case 32u:
				SelfRank = input.ReadInt32();
				break;
			case 40u:
				Total = input.ReadInt32();
				break;
			}
		}
	}
}
