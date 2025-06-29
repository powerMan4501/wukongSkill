using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class ByteDanceVerify : IMessage<ByteDanceVerify>, IMessage, IEquatable<ByteDanceVerify>, IDeepCloneable<ByteDanceVerify>
{
	private static readonly MessageParser<ByteDanceVerify> _parser = new MessageParser<ByteDanceVerify>(() => new ByteDanceVerify());

	private UnknownFieldSet _unknownFields;

	private string accessToken_ = "";

	private string bytedanceDid_ = "";

	public static MessageParser<ByteDanceVerify> Parser => _parser;

	public string AccessToken
	{
		get
		{
			return accessToken_;
		}
		set
		{
			accessToken_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string BytedanceDid
	{
		get
		{
			return bytedanceDid_;
		}
		set
		{
			bytedanceDid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ByteDanceVerify()
	{
	}

	public ByteDanceVerify(ByteDanceVerify other)
		: this()
	{
		accessToken_ = other.accessToken_;
		bytedanceDid_ = other.bytedanceDid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ByteDanceVerify Clone()
	{
		return new ByteDanceVerify(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ByteDanceVerify);
	}

	public bool Equals(ByteDanceVerify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AccessToken != other.AccessToken)
		{
			return false;
		}
		if (BytedanceDid != other.BytedanceDid)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (AccessToken.Length != 0)
		{
			num ^= AccessToken.GetHashCode();
		}
		if (BytedanceDid.Length != 0)
		{
			num ^= BytedanceDid.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (AccessToken.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(AccessToken);
		}
		if (BytedanceDid.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(BytedanceDid);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (AccessToken.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AccessToken);
		}
		if (BytedanceDid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BytedanceDid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ByteDanceVerify other)
	{
		if (other != null)
		{
			if (other.AccessToken.Length != 0)
			{
				AccessToken = other.AccessToken;
			}
			if (other.BytedanceDid.Length != 0)
			{
				BytedanceDid = other.BytedanceDid;
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
			case 10u:
				AccessToken = input.ReadString();
				break;
			case 18u:
				BytedanceDid = input.ReadString();
				break;
			}
		}
	}
}
