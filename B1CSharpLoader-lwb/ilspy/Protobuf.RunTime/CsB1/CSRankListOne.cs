using System;
using CommB1;
using Google.Protobuf;

namespace CsB1;

public sealed class CSRankListOne : IMessage<CSRankListOne>, IMessage, IEquatable<CSRankListOne>, IDeepCloneable<CSRankListOne>
{
	private static readonly MessageParser<CSRankListOne> _parser = new MessageParser<CSRankListOne>(() => new CSRankListOne());

	private UnknownFieldSet _unknownFields;

	private ulong id_;

	private long score_;

	private CSShareMsg brief_;

	public static MessageParser<CSRankListOne> Parser => _parser;

	public ulong Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public long Score
	{
		get
		{
			return score_;
		}
		set
		{
			score_ = value;
		}
	}

	public CSShareMsg Brief
	{
		get
		{
			return brief_;
		}
		set
		{
			brief_ = value;
		}
	}

	public CSRankListOne()
	{
	}

	public CSRankListOne(CSRankListOne other)
		: this()
	{
		id_ = other.id_;
		score_ = other.score_;
		brief_ = ((other.brief_ != null) ? other.brief_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSRankListOne Clone()
	{
		return new CSRankListOne(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSRankListOne);
	}

	public bool Equals(CSRankListOne other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (Score != other.Score)
		{
			return false;
		}
		if (!object.Equals(Brief, other.Brief))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0L)
		{
			num ^= Id.GetHashCode();
		}
		if (Score != 0L)
		{
			num ^= Score.GetHashCode();
		}
		if (brief_ != null)
		{
			num ^= Brief.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(Id);
		}
		if (Score != 0L)
		{
			output.WriteRawTag(16);
			output.WriteInt64(Score);
		}
		if (brief_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Brief);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(Id);
		}
		if (Score != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Score);
		}
		if (brief_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Brief);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSRankListOne other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Id != 0L)
		{
			Id = other.Id;
		}
		if (other.Score != 0L)
		{
			Score = other.Score;
		}
		if (other.brief_ != null)
		{
			if (brief_ == null)
			{
				Brief = new CSShareMsg();
			}
			Brief.MergeFrom(other.Brief);
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
			case 8u:
				Id = input.ReadUInt64();
				break;
			case 16u:
				Score = input.ReadInt64();
				break;
			case 26u:
				if (brief_ == null)
				{
					Brief = new CSShareMsg();
				}
				input.ReadMessage(Brief);
				break;
			}
		}
	}
}
