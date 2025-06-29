using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class ReportTrackMisc : IMessage<ReportTrackMisc>, IMessage, IEquatable<ReportTrackMisc>, IDeepCloneable<ReportTrackMisc>
{
	private static readonly MessageParser<ReportTrackMisc> _parser = new MessageParser<ReportTrackMisc>(() => new ReportTrackMisc());

	private UnknownFieldSet _unknownFields;

	private string roleId_ = "";

	private string devId_ = "";

	private string playMode_ = "";

	private string version_ = "";

	private string iip_ = "";

	private string oip_ = "";

	public static MessageParser<ReportTrackMisc> Parser => _parser;

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

	public string DevId
	{
		get
		{
			return devId_;
		}
		set
		{
			devId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string PlayMode
	{
		get
		{
			return playMode_;
		}
		set
		{
			playMode_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Version
	{
		get
		{
			return version_;
		}
		set
		{
			version_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Iip
	{
		get
		{
			return iip_;
		}
		set
		{
			iip_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Oip
	{
		get
		{
			return oip_;
		}
		set
		{
			oip_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ReportTrackMisc()
	{
	}

	public ReportTrackMisc(ReportTrackMisc other)
		: this()
	{
		roleId_ = other.roleId_;
		devId_ = other.devId_;
		playMode_ = other.playMode_;
		version_ = other.version_;
		iip_ = other.iip_;
		oip_ = other.oip_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportTrackMisc Clone()
	{
		return new ReportTrackMisc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportTrackMisc);
	}

	public bool Equals(ReportTrackMisc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoleId != other.RoleId)
		{
			return false;
		}
		if (DevId != other.DevId)
		{
			return false;
		}
		if (PlayMode != other.PlayMode)
		{
			return false;
		}
		if (Version != other.Version)
		{
			return false;
		}
		if (Iip != other.Iip)
		{
			return false;
		}
		if (Oip != other.Oip)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (RoleId.Length != 0)
		{
			num ^= RoleId.GetHashCode();
		}
		if (DevId.Length != 0)
		{
			num ^= DevId.GetHashCode();
		}
		if (PlayMode.Length != 0)
		{
			num ^= PlayMode.GetHashCode();
		}
		if (Version.Length != 0)
		{
			num ^= Version.GetHashCode();
		}
		if (Iip.Length != 0)
		{
			num ^= Iip.GetHashCode();
		}
		if (Oip.Length != 0)
		{
			num ^= Oip.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (RoleId.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(RoleId);
		}
		if (DevId.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(DevId);
		}
		if (PlayMode.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(PlayMode);
		}
		if (Version.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(Version);
		}
		if (Iip.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(Iip);
		}
		if (Oip.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(Oip);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (RoleId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RoleId);
		}
		if (DevId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DevId);
		}
		if (PlayMode.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PlayMode);
		}
		if (Version.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Version);
		}
		if (Iip.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Iip);
		}
		if (Oip.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Oip);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportTrackMisc other)
	{
		if (other != null)
		{
			if (other.RoleId.Length != 0)
			{
				RoleId = other.RoleId;
			}
			if (other.DevId.Length != 0)
			{
				DevId = other.DevId;
			}
			if (other.PlayMode.Length != 0)
			{
				PlayMode = other.PlayMode;
			}
			if (other.Version.Length != 0)
			{
				Version = other.Version;
			}
			if (other.Iip.Length != 0)
			{
				Iip = other.Iip;
			}
			if (other.Oip.Length != 0)
			{
				Oip = other.Oip;
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
				RoleId = input.ReadString();
				break;
			case 18u:
				DevId = input.ReadString();
				break;
			case 26u:
				PlayMode = input.ReadString();
				break;
			case 34u:
				Version = input.ReadString();
				break;
			case 42u:
				Iip = input.ReadString();
				break;
			case 50u:
				Oip = input.ReadString();
				break;
			}
		}
	}
}
