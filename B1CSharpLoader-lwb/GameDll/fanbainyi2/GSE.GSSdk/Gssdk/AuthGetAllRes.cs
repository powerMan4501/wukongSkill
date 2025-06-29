using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace Gssdk;

public sealed class AuthGetAllRes : IMessage<AuthGetAllRes>, IMessage, IEquatable<AuthGetAllRes>, IDeepCloneable<AuthGetAllRes>
{
	private static readonly MessageParser<AuthGetAllRes> _parser = new MessageParser<AuthGetAllRes>(() => new AuthGetAllRes());

	private UnknownFieldSet _unknownFields;

	private int page_;

	private int limit_;

	private static readonly FieldCodec<AccountProfile> _repeated_data_codec = FieldCodec.ForMessage(26u, AccountProfile.Parser);

	private readonly RepeatedField<AccountProfile> data_ = new RepeatedField<AccountProfile>();

	public static MessageParser<AuthGetAllRes> Parser => _parser;

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

	public RepeatedField<AccountProfile> Data => data_;

	public AuthGetAllRes()
	{
	}

	public AuthGetAllRes(AuthGetAllRes other)
		: this()
	{
		page_ = other.page_;
		limit_ = other.limit_;
		data_ = other.data_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AuthGetAllRes Clone()
	{
		return new AuthGetAllRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AuthGetAllRes);
	}

	public bool Equals(AuthGetAllRes other)
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
		if (!data_.Equals(other.data_))
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
		num ^= data_.GetHashCode();
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
		data_.WriteTo(output, _repeated_data_codec);
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
		num += data_.CalculateSize(_repeated_data_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AuthGetAllRes other)
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
			data_.Add(other.data_);
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
			case 26u:
				data_.AddEntriesFrom(input, _repeated_data_codec);
				break;
			}
		}
	}
}
