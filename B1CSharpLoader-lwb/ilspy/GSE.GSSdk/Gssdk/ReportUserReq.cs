using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class ReportUserReq : IMessage<ReportUserReq>, IMessage, IEquatable<ReportUserReq>, IDeepCloneable<ReportUserReq>
{
	private static readonly MessageParser<ReportUserReq> _parser = new MessageParser<ReportUserReq>(() => new ReportUserReq());

	private UnknownFieldSet _unknownFields;

	private ReportUserKey userKey_;

	private UserInfo info_;

	public static MessageParser<ReportUserReq> Parser => _parser;

	public ReportUserKey UserKey
	{
		get
		{
			return userKey_;
		}
		set
		{
			userKey_ = value;
		}
	}

	public UserInfo Info
	{
		get
		{
			return info_;
		}
		set
		{
			info_ = value;
		}
	}

	public ReportUserReq()
	{
	}

	public ReportUserReq(ReportUserReq other)
		: this()
	{
		userKey_ = ((other.userKey_ != null) ? other.userKey_.Clone() : null);
		info_ = ((other.info_ != null) ? other.info_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportUserReq Clone()
	{
		return new ReportUserReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportUserReq);
	}

	public bool Equals(ReportUserReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(UserKey, other.UserKey))
		{
			return false;
		}
		if (!object.Equals(Info, other.Info))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (userKey_ != null)
		{
			num ^= UserKey.GetHashCode();
		}
		if (info_ != null)
		{
			num ^= Info.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (userKey_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(UserKey);
		}
		if (info_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Info);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (userKey_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(UserKey);
		}
		if (info_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Info);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportUserReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.userKey_ != null)
		{
			if (userKey_ == null)
			{
				UserKey = new ReportUserKey();
			}
			UserKey.MergeFrom(other.UserKey);
		}
		if (other.info_ != null)
		{
			if (info_ == null)
			{
				Info = new UserInfo();
			}
			Info.MergeFrom(other.Info);
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
				if (userKey_ == null)
				{
					UserKey = new ReportUserKey();
				}
				input.ReadMessage(UserKey);
				break;
			case 18u:
				if (info_ == null)
				{
					Info = new UserInfo();
				}
				input.ReadMessage(Info);
				break;
			}
		}
	}
}
