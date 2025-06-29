using System;
using Google.Protobuf;
using ResB1;

namespace CsB1;

public sealed class CSRankListGetParam : IMessage<CSRankListGetParam>, IMessage, IEquatable<CSRankListGetParam>, IDeepCloneable<CSRankListGetParam>
{
	private static readonly MessageParser<CSRankListGetParam> _parser = new MessageParser<CSRankListGetParam>(() => new CSRankListGetParam());

	private UnknownFieldSet _unknownFields;

	private RankType rankType_;

	private int offset_;

	private int limit_;

	private YesNoType getBrief_;

	public static MessageParser<CSRankListGetParam> Parser => _parser;

	public RankType RankType
	{
		get
		{
			return rankType_;
		}
		set
		{
			rankType_ = value;
		}
	}

	public int Offset
	{
		get
		{
			return offset_;
		}
		set
		{
			offset_ = value;
		}
	}

	public int Limit
	{
		get
		{
			return limit_;
		}
		set
		{
			limit_ = value;
		}
	}

	public YesNoType GetBrief
	{
		get
		{
			return getBrief_;
		}
		set
		{
			getBrief_ = value;
		}
	}

	public CSRankListGetParam()
	{
	}

	public CSRankListGetParam(CSRankListGetParam other)
		: this()
	{
		rankType_ = other.rankType_;
		offset_ = other.offset_;
		limit_ = other.limit_;
		getBrief_ = other.getBrief_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSRankListGetParam Clone()
	{
		return new CSRankListGetParam(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSRankListGetParam);
	}

	public bool Equals(CSRankListGetParam other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RankType != other.RankType)
		{
			return false;
		}
		if (Offset != other.Offset)
		{
			return false;
		}
		if (Limit != other.Limit)
		{
			return false;
		}
		if (GetBrief != other.GetBrief)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (RankType != RankType.None)
		{
			num ^= RankType.GetHashCode();
		}
		if (Offset != 0)
		{
			num ^= Offset.GetHashCode();
		}
		if (Limit != 0)
		{
			num ^= Limit.GetHashCode();
		}
		if (GetBrief != YesNoType.No)
		{
			num ^= GetBrief.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (RankType != RankType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)RankType);
		}
		if (Offset != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Offset);
		}
		if (Limit != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Limit);
		}
		if (GetBrief != YesNoType.No)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)GetBrief);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (RankType != RankType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)RankType);
		}
		if (Offset != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Offset);
		}
		if (Limit != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Limit);
		}
		if (GetBrief != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)GetBrief);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSRankListGetParam other)
	{
		if (other != null)
		{
			if (other.RankType != RankType.None)
			{
				RankType = other.RankType;
			}
			if (other.Offset != 0)
			{
				Offset = other.Offset;
			}
			if (other.Limit != 0)
			{
				Limit = other.Limit;
			}
			if (other.GetBrief != YesNoType.No)
			{
				GetBrief = other.GetBrief;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			case 8u:
				RankType = (RankType)input.ReadEnum();
				break;
			case 16u:
				Offset = input.ReadInt32();
				break;
			case 24u:
				Limit = input.ReadInt32();
				break;
			case 32u:
				GetBrief = (YesNoType)input.ReadEnum();
				break;
			}
		}
	}
}
