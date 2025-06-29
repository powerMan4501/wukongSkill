using System;
using ArchiveB1;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRoleLoginReq : IMessage<CSMsgRoleLoginReq>, IMessage, IEquatable<CSMsgRoleLoginReq>, IDeepCloneable<CSMsgRoleLoginReq>
{
	private static readonly MessageParser<CSMsgRoleLoginReq> _parser = new MessageParser<CSMsgRoleLoginReq>(() => new CSMsgRoleLoginReq());

	private UnknownFieldSet _unknownFields;

	private int reconnect_;

	private LoginRoleReport reportEnvMisc_;

	private RoleData roleData_;

	public static MessageParser<CSMsgRoleLoginReq> Parser => _parser;

	public int Reconnect
	{
		get
		{
			return reconnect_;
		}
		set
		{
			reconnect_ = value;
		}
	}

	public LoginRoleReport ReportEnvMisc
	{
		get
		{
			return reportEnvMisc_;
		}
		set
		{
			reportEnvMisc_ = value;
		}
	}

	public RoleData RoleData
	{
		get
		{
			return roleData_;
		}
		set
		{
			roleData_ = value;
		}
	}

	public CSMsgRoleLoginReq()
	{
	}

	public CSMsgRoleLoginReq(CSMsgRoleLoginReq other)
		: this()
	{
		reconnect_ = other.reconnect_;
		reportEnvMisc_ = ((other.reportEnvMisc_ != null) ? other.reportEnvMisc_.Clone() : null);
		roleData_ = ((other.roleData_ != null) ? other.roleData_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRoleLoginReq Clone()
	{
		return new CSMsgRoleLoginReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRoleLoginReq);
	}

	public bool Equals(CSMsgRoleLoginReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Reconnect != other.Reconnect)
		{
			return false;
		}
		if (!object.Equals(ReportEnvMisc, other.ReportEnvMisc))
		{
			return false;
		}
		if (!object.Equals(RoleData, other.RoleData))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Reconnect != 0)
		{
			num ^= Reconnect.GetHashCode();
		}
		if (reportEnvMisc_ != null)
		{
			num ^= ReportEnvMisc.GetHashCode();
		}
		if (roleData_ != null)
		{
			num ^= RoleData.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Reconnect != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Reconnect);
		}
		if (reportEnvMisc_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(ReportEnvMisc);
		}
		if (roleData_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(RoleData);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Reconnect != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Reconnect);
		}
		if (reportEnvMisc_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ReportEnvMisc);
		}
		if (roleData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RoleData);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgRoleLoginReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Reconnect != 0)
		{
			Reconnect = other.Reconnect;
		}
		if (other.reportEnvMisc_ != null)
		{
			if (reportEnvMisc_ == null)
			{
				ReportEnvMisc = new LoginRoleReport();
			}
			ReportEnvMisc.MergeFrom(other.ReportEnvMisc);
		}
		if (other.roleData_ != null)
		{
			if (roleData_ == null)
			{
				RoleData = new RoleData();
			}
			RoleData.MergeFrom(other.RoleData);
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
				Reconnect = input.ReadInt32();
				break;
			case 18u:
				if (reportEnvMisc_ == null)
				{
					ReportEnvMisc = new LoginRoleReport();
				}
				input.ReadMessage(ReportEnvMisc);
				break;
			case 26u:
				if (roleData_ == null)
				{
					RoleData = new RoleData();
				}
				input.ReadMessage(RoleData);
				break;
			}
		}
	}
}
