using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class DirGetAllReq : IMessage<DirGetAllReq>, IMessage, IEquatable<DirGetAllReq>, IDeepCloneable<DirGetAllReq>
{
	private static readonly MessageParser<DirGetAllReq> _parser = new MessageParser<DirGetAllReq>(() => new DirGetAllReq());

	private UnknownFieldSet _unknownFields;

	private int page_;

	private int limit_;

	public static MessageParser<DirGetAllReq> Parser => _parser;

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

	public DirGetAllReq()
	{
	}

	public DirGetAllReq(DirGetAllReq other)
		: this()
	{
		page_ = other.page_;
		limit_ = other.limit_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DirGetAllReq Clone()
	{
		return new DirGetAllReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DirGetAllReq);
	}

	public bool Equals(DirGetAllReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
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
		if (Page != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Page);
		}
		if (Limit != 0)
		{
			output.WriteRawTag(16);
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

	public void MergeFrom(DirGetAllReq other)
	{
		if (other != null)
		{
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
				Page = input.ReadInt32();
				break;
			case 16u:
				Limit = input.ReadInt32();
				break;
			}
		}
	}
}
