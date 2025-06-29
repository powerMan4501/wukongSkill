using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class VersionTestCheckConfigReq : IMessage<VersionTestCheckConfigReq>, IMessage, IEquatable<VersionTestCheckConfigReq>, IDeepCloneable<VersionTestCheckConfigReq>
{
	private static readonly MessageParser<VersionTestCheckConfigReq> _parser = new MessageParser<VersionTestCheckConfigReq>(() => new VersionTestCheckConfigReq());

	private UnknownFieldSet _unknownFields;

	private VersionCheckConfigUserInfo userInfo_;

	public static MessageParser<VersionTestCheckConfigReq> Parser => _parser;

	public VersionCheckConfigUserInfo UserInfo
	{
		get
		{
			return userInfo_;
		}
		set
		{
			userInfo_ = value;
		}
	}

	public VersionTestCheckConfigReq()
	{
	}

	public VersionTestCheckConfigReq(VersionTestCheckConfigReq other)
		: this()
	{
		userInfo_ = ((other.userInfo_ != null) ? other.userInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public VersionTestCheckConfigReq Clone()
	{
		return new VersionTestCheckConfigReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as VersionTestCheckConfigReq);
	}

	public bool Equals(VersionTestCheckConfigReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(UserInfo, other.UserInfo))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (userInfo_ != null)
		{
			num ^= UserInfo.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (userInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(UserInfo);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (userInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(UserInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(VersionTestCheckConfigReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.userInfo_ != null)
		{
			if (userInfo_ == null)
			{
				UserInfo = new VersionCheckConfigUserInfo();
			}
			UserInfo.MergeFrom(other.UserInfo);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				continue;
			}
			if (userInfo_ == null)
			{
				UserInfo = new VersionCheckConfigUserInfo();
			}
			input.ReadMessage(UserInfo);
		}
	}
}
