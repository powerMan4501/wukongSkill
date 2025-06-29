using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class VersionReviewRecReq : IMessage<VersionReviewRecReq>, IMessage, IEquatable<VersionReviewRecReq>, IDeepCloneable<VersionReviewRecReq>
{
	private static readonly MessageParser<VersionReviewRecReq> _parser = new MessageParser<VersionReviewRecReq>(() => new VersionReviewRecReq());

	private UnknownFieldSet _unknownFields;

	private string opname_ = "";

	private GssdkReviewRec data_;

	private int page_;

	private int limit_;

	public static MessageParser<VersionReviewRecReq> Parser => _parser;

	public string Opname
	{
		get
		{
			return opname_;
		}
		set
		{
			opname_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public GssdkReviewRec Data
	{
		get
		{
			return data_;
		}
		set
		{
			data_ = value;
		}
	}

	public int Page
	{
		get
		{
			return page_;
		}
		set
		{
			page_ = value;
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

	public VersionReviewRecReq()
	{
	}

	public VersionReviewRecReq(VersionReviewRecReq other)
		: this()
	{
		opname_ = other.opname_;
		data_ = ((other.data_ != null) ? other.data_.Clone() : null);
		page_ = other.page_;
		limit_ = other.limit_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public VersionReviewRecReq Clone()
	{
		return new VersionReviewRecReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as VersionReviewRecReq);
	}

	public bool Equals(VersionReviewRecReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Opname != other.Opname)
		{
			return false;
		}
		if (!object.Equals(Data, other.Data))
		{
			return false;
		}
		if (Page != other.Page)
		{
			return false;
		}
		if (Limit != other.Limit)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Opname.Length != 0)
		{
			num ^= Opname.GetHashCode();
		}
		if (data_ != null)
		{
			num ^= Data.GetHashCode();
		}
		if (Page != 0)
		{
			num ^= Page.GetHashCode();
		}
		if (Limit != 0)
		{
			num ^= Limit.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Opname.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Opname);
		}
		if (data_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Data);
		}
		if (Page != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Page);
		}
		if (Limit != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Limit);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Opname.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Opname);
		}
		if (data_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Data);
		}
		if (Page != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Page);
		}
		if (Limit != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Limit);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(VersionReviewRecReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Opname.Length != 0)
		{
			Opname = other.Opname;
		}
		if (other.data_ != null)
		{
			if (data_ == null)
			{
				Data = new GssdkReviewRec();
			}
			Data.MergeFrom(other.Data);
		}
		if (other.Page != 0)
		{
			Page = other.Page;
		}
		if (other.Limit != 0)
		{
			Limit = other.Limit;
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
				Opname = input.ReadString();
				break;
			case 18u:
				if (data_ == null)
				{
					Data = new GssdkReviewRec();
				}
				input.ReadMessage(Data);
				break;
			case 24u:
				Page = input.ReadInt32();
				break;
			case 32u:
				Limit = input.ReadInt32();
				break;
			}
		}
	}
}
