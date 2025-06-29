using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace Gssdk;

public sealed class DirGetAllRes : IMessage<DirGetAllRes>, IMessage, IEquatable<DirGetAllRes>, IDeepCloneable<DirGetAllRes>
{
	private static readonly MessageParser<DirGetAllRes> _parser = new MessageParser<DirGetAllRes>(() => new DirGetAllRes());

	private UnknownFieldSet _unknownFields;

	private GssdkRet ret_;

	private int page_;

	private int limit_;

	private static readonly FieldCodec<ServerInfo> _repeated_data_codec = FieldCodec.ForMessage(34u, ServerInfo.Parser);

	private readonly RepeatedField<ServerInfo> data_ = new RepeatedField<ServerInfo>();

	public static MessageParser<DirGetAllRes> Parser => _parser;

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

	public RepeatedField<ServerInfo> Data => data_;

	public DirGetAllRes()
	{
	}

	public DirGetAllRes(DirGetAllRes other)
		: this()
	{
		ret_ = ((other.ret_ != null) ? other.ret_.Clone() : null);
		page_ = other.page_;
		limit_ = other.limit_;
		data_ = other.data_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DirGetAllRes Clone()
	{
		return new DirGetAllRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DirGetAllRes);
	}

	public bool Equals(DirGetAllRes other)
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
		if (Page != other.Page)
		{
			return false;
		}
		if (Limit != other.Limit)
		{
			return false;
		}
		if (!data_.Equals(other.data_))
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
		if (Page != 0)
		{
			num ^= Page.GetHashCode();
		}
		if (Limit != 0)
		{
			num ^= Limit.GetHashCode();
		}
		num ^= data_.GetHashCode();
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
		if (Page != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Page);
		}
		if (Limit != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Limit);
		}
		data_.WriteTo(output, _repeated_data_codec);
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
		if (Page != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Page);
		}
		if (Limit != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Limit);
		}
		num += data_.CalculateSize(_repeated_data_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(DirGetAllRes other)
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
		if (other.Page != 0)
		{
			Page = other.Page;
		}
		if (other.Limit != 0)
		{
			Limit = other.Limit;
		}
		data_.Add(other.data_);
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
				Page = input.ReadInt32();
				break;
			case 24u:
				Limit = input.ReadInt32();
				break;
			case 34u:
				data_.AddEntriesFrom(input, _repeated_data_codec);
				break;
			}
		}
	}
}
