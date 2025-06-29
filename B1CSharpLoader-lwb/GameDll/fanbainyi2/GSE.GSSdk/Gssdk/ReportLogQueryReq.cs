using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class ReportLogQueryReq : IMessage<ReportLogQueryReq>, IMessage, IEquatable<ReportLogQueryReq>, IDeepCloneable<ReportLogQueryReq>
{
	private static readonly MessageParser<ReportLogQueryReq> _parser = new MessageParser<ReportLogQueryReq>(() => new ReportLogQueryReq());

	private UnknownFieldSet _unknownFields;

	private string beginTime_ = "";

	private string endTime_ = "";

	private string ip_ = "";

	private string roleId_ = "";

	private string tag_ = "";

	private string keyword_ = "";

	private int page_;

	private int limit_;

	private int hasRes_;

	private int mergeMsgstr_;

	public static MessageParser<ReportLogQueryReq> Parser => _parser;

	public string BeginTime
	{
		get
		{
			return beginTime_;
		}
		set
		{
			beginTime_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string EndTime
	{
		get
		{
			return endTime_;
		}
		set
		{
			endTime_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Ip
	{
		get
		{
			return ip_;
		}
		set
		{
			ip_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string RoleId
	{
		get
		{
			return roleId_;
		}
		set
		{
			roleId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Tag
	{
		get
		{
			return tag_;
		}
		set
		{
			tag_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Keyword
	{
		get
		{
			return keyword_;
		}
		set
		{
			keyword_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public int HasRes
	{
		get
		{
			return hasRes_;
		}
		set
		{
			hasRes_ = value;
		}
	}

	public int MergeMsgstr
	{
		get
		{
			return mergeMsgstr_;
		}
		set
		{
			mergeMsgstr_ = value;
		}
	}

	public ReportLogQueryReq()
	{
	}

	public ReportLogQueryReq(ReportLogQueryReq other)
		: this()
	{
		beginTime_ = other.beginTime_;
		endTime_ = other.endTime_;
		ip_ = other.ip_;
		roleId_ = other.roleId_;
		tag_ = other.tag_;
		keyword_ = other.keyword_;
		page_ = other.page_;
		limit_ = other.limit_;
		hasRes_ = other.hasRes_;
		mergeMsgstr_ = other.mergeMsgstr_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportLogQueryReq Clone()
	{
		return new ReportLogQueryReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportLogQueryReq);
	}

	public bool Equals(ReportLogQueryReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BeginTime != other.BeginTime)
		{
			return false;
		}
		if (EndTime != other.EndTime)
		{
			return false;
		}
		if (Ip != other.Ip)
		{
			return false;
		}
		if (RoleId != other.RoleId)
		{
			return false;
		}
		if (Tag != other.Tag)
		{
			return false;
		}
		if (Keyword != other.Keyword)
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
		if (HasRes != other.HasRes)
		{
			return false;
		}
		if (MergeMsgstr != other.MergeMsgstr)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (BeginTime.Length != 0)
		{
			num ^= BeginTime.GetHashCode();
		}
		if (EndTime.Length != 0)
		{
			num ^= EndTime.GetHashCode();
		}
		if (Ip.Length != 0)
		{
			num ^= Ip.GetHashCode();
		}
		if (RoleId.Length != 0)
		{
			num ^= RoleId.GetHashCode();
		}
		if (Tag.Length != 0)
		{
			num ^= Tag.GetHashCode();
		}
		if (Keyword.Length != 0)
		{
			num ^= Keyword.GetHashCode();
		}
		if (Page != 0)
		{
			num ^= Page.GetHashCode();
		}
		if (Limit != 0)
		{
			num ^= Limit.GetHashCode();
		}
		if (HasRes != 0)
		{
			num ^= HasRes.GetHashCode();
		}
		if (MergeMsgstr != 0)
		{
			num ^= MergeMsgstr.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (BeginTime.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(BeginTime);
		}
		if (EndTime.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(EndTime);
		}
		if (Ip.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Ip);
		}
		if (RoleId.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(RoleId);
		}
		if (Tag.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(Tag);
		}
		if (Keyword.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(Keyword);
		}
		if (Page != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(Page);
		}
		if (Limit != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(Limit);
		}
		if (HasRes != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(HasRes);
		}
		if (MergeMsgstr != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(MergeMsgstr);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (BeginTime.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BeginTime);
		}
		if (EndTime.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EndTime);
		}
		if (Ip.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Ip);
		}
		if (RoleId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RoleId);
		}
		if (Tag.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Tag);
		}
		if (Keyword.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Keyword);
		}
		if (Page != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Page);
		}
		if (Limit != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Limit);
		}
		if (HasRes != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(HasRes);
		}
		if (MergeMsgstr != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MergeMsgstr);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportLogQueryReq other)
	{
		if (other != null)
		{
			if (other.BeginTime.Length != 0)
			{
				BeginTime = other.BeginTime;
			}
			if (other.EndTime.Length != 0)
			{
				EndTime = other.EndTime;
			}
			if (other.Ip.Length != 0)
			{
				Ip = other.Ip;
			}
			if (other.RoleId.Length != 0)
			{
				RoleId = other.RoleId;
			}
			if (other.Tag.Length != 0)
			{
				Tag = other.Tag;
			}
			if (other.Keyword.Length != 0)
			{
				Keyword = other.Keyword;
			}
			if (other.Page != 0)
			{
				Page = other.Page;
			}
			if (other.Limit != 0)
			{
				Limit = other.Limit;
			}
			if (other.HasRes != 0)
			{
				HasRes = other.HasRes;
			}
			if (other.MergeMsgstr != 0)
			{
				MergeMsgstr = other.MergeMsgstr;
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
				BeginTime = input.ReadString();
				break;
			case 18u:
				EndTime = input.ReadString();
				break;
			case 26u:
				Ip = input.ReadString();
				break;
			case 34u:
				RoleId = input.ReadString();
				break;
			case 42u:
				Tag = input.ReadString();
				break;
			case 50u:
				Keyword = input.ReadString();
				break;
			case 56u:
				Page = input.ReadInt32();
				break;
			case 64u:
				Limit = input.ReadInt32();
				break;
			case 72u:
				HasRes = input.ReadInt32();
				break;
			case 80u:
				MergeMsgstr = input.ReadInt32();
				break;
			}
		}
	}
}
