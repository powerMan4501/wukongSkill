using System;
using Google.Protobuf;

namespace OssB1;

public sealed class ReportClientInfo : IMessage<ReportClientInfo>, IMessage, IEquatable<ReportClientInfo>, IDeepCloneable<ReportClientInfo>
{
	private static readonly MessageParser<ReportClientInfo> _parser = new MessageParser<ReportClientInfo>(() => new ReportClientInfo());

	private UnknownFieldSet _unknownFields;

	private ReportClientBase clientBase_;

	private ReportRoleBase roleBase_;

	private ReportRoleCommMisc roleMisc_;

	public static MessageParser<ReportClientInfo> Parser => _parser;

	public ReportClientBase ClientBase
	{
		get
		{
			return clientBase_;
		}
		set
		{
			clientBase_ = value;
		}
	}

	public ReportRoleBase RoleBase
	{
		get
		{
			return roleBase_;
		}
		set
		{
			roleBase_ = value;
		}
	}

	public ReportRoleCommMisc RoleMisc
	{
		get
		{
			return roleMisc_;
		}
		set
		{
			roleMisc_ = value;
		}
	}

	public ReportClientInfo()
	{
	}

	public ReportClientInfo(ReportClientInfo other)
		: this()
	{
		clientBase_ = ((other.clientBase_ != null) ? other.clientBase_.Clone() : null);
		roleBase_ = ((other.roleBase_ != null) ? other.roleBase_.Clone() : null);
		roleMisc_ = ((other.roleMisc_ != null) ? other.roleMisc_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportClientInfo Clone()
	{
		return new ReportClientInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportClientInfo);
	}

	public bool Equals(ReportClientInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ClientBase, other.ClientBase))
		{
			return false;
		}
		if (!object.Equals(RoleBase, other.RoleBase))
		{
			return false;
		}
		if (!object.Equals(RoleMisc, other.RoleMisc))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (clientBase_ != null)
		{
			num ^= ClientBase.GetHashCode();
		}
		if (roleBase_ != null)
		{
			num ^= RoleBase.GetHashCode();
		}
		if (roleMisc_ != null)
		{
			num ^= RoleMisc.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (clientBase_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(ClientBase);
		}
		if (roleBase_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(RoleBase);
		}
		if (roleMisc_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(RoleMisc);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (clientBase_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ClientBase);
		}
		if (roleBase_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RoleBase);
		}
		if (roleMisc_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RoleMisc);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportClientInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.clientBase_ != null)
		{
			if (clientBase_ == null)
			{
				ClientBase = new ReportClientBase();
			}
			ClientBase.MergeFrom(other.ClientBase);
		}
		if (other.roleBase_ != null)
		{
			if (roleBase_ == null)
			{
				RoleBase = new ReportRoleBase();
			}
			RoleBase.MergeFrom(other.RoleBase);
		}
		if (other.roleMisc_ != null)
		{
			if (roleMisc_ == null)
			{
				RoleMisc = new ReportRoleCommMisc();
			}
			RoleMisc.MergeFrom(other.RoleMisc);
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
				if (clientBase_ == null)
				{
					ClientBase = new ReportClientBase();
				}
				input.ReadMessage(ClientBase);
				break;
			case 18u:
				if (roleBase_ == null)
				{
					RoleBase = new ReportRoleBase();
				}
				input.ReadMessage(RoleBase);
				break;
			case 26u:
				if (roleMisc_ == null)
				{
					RoleMisc = new ReportRoleCommMisc();
				}
				input.ReadMessage(RoleMisc);
				break;
			}
		}
	}
}
