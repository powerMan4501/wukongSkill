using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace Gssdk;

public sealed class VersionWhiteListRes : IMessage<VersionWhiteListRes>, IMessage, IEquatable<VersionWhiteListRes>, IDeepCloneable<VersionWhiteListRes>
{
	private static readonly MessageParser<VersionWhiteListRes> _parser = new MessageParser<VersionWhiteListRes>(() => new VersionWhiteListRes());

	private UnknownFieldSet _unknownFields;

	private GssdkRet ret_;

	private int affect_;

	private static readonly FieldCodec<GssdkWhiteList> _repeated_data_codec = FieldCodec.ForMessage(26u, GssdkWhiteList.Parser);

	private readonly RepeatedField<GssdkWhiteList> data_ = new RepeatedField<GssdkWhiteList>();

	private int page_;

	private int limit_;

	public static MessageParser<VersionWhiteListRes> Parser => _parser;

	public GssdkRet Ret
	{
		get
		{
			return ret_;
		}
		set
		{
			ret_ = value;
		}
	}

	public int Affect
	{
		get
		{
			return affect_;
		}
		set
		{
			affect_ = value;
		}
	}

	public RepeatedField<GssdkWhiteList> Data => data_;

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

	public VersionWhiteListRes()
	{
	}

	public VersionWhiteListRes(VersionWhiteListRes other)
		: this()
	{
		ret_ = ((other.ret_ != null) ? other.ret_.Clone() : null);
		affect_ = other.affect_;
		data_ = other.data_.Clone();
		page_ = other.page_;
		limit_ = other.limit_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public VersionWhiteListRes Clone()
	{
		return new VersionWhiteListRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as VersionWhiteListRes);
	}

	public bool Equals(VersionWhiteListRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Ret, other.Ret))
		{
			return false;
		}
		if (Affect != other.Affect)
		{
			return false;
		}
		if (!data_.Equals(other.data_))
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
		if (ret_ != null)
		{
			num ^= Ret.GetHashCode();
		}
		if (Affect != 0)
		{
			num ^= Affect.GetHashCode();
		}
		num ^= data_.GetHashCode();
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
		if (ret_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Ret);
		}
		if (Affect != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Affect);
		}
		data_.WriteTo(output, _repeated_data_codec);
		if (Page != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Page);
		}
		if (Limit != 0)
		{
			output.WriteRawTag(40);
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
		if (ret_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Ret);
		}
		if (Affect != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Affect);
		}
		num += data_.CalculateSize(_repeated_data_codec);
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

	public void MergeFrom(VersionWhiteListRes other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ret_ != null)
		{
			if (ret_ == null)
			{
				Ret = new GssdkRet();
			}
			Ret.MergeFrom(other.Ret);
		}
		if (other.Affect != 0)
		{
			Affect = other.Affect;
		}
		data_.Add(other.data_);
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
				if (ret_ == null)
				{
					Ret = new GssdkRet();
				}
				input.ReadMessage(Ret);
				break;
			case 16u:
				Affect = input.ReadInt32();
				break;
			case 26u:
				data_.AddEntriesFrom(input, _repeated_data_codec);
				break;
			case 32u:
				Page = input.ReadInt32();
				break;
			case 40u:
				Limit = input.ReadInt32();
				break;
			}
		}
	}
}
