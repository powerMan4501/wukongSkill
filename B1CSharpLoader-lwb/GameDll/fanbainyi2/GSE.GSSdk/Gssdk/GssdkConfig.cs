using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class GssdkConfig : IMessage<GssdkConfig>, IMessage, IEquatable<GssdkConfig>, IDeepCloneable<GssdkConfig>
{
	private static readonly MessageParser<GssdkConfig> _parser = new MessageParser<GssdkConfig>(() => new GssdkConfig());

	private UnknownFieldSet _unknownFields;

	private GssdkAuthConfig auth_;

	private GssdkDirConfig dir_;

	private GssdkReportConfig report_;

	private GssdkVersionConfig version_;

	public static MessageParser<GssdkConfig> Parser => _parser;

	public GssdkAuthConfig Auth
	{
		get
		{
			return auth_;
		}
		set
		{
			auth_ = value;
		}
	}

	public GssdkDirConfig Dir
	{
		get
		{
			return dir_;
		}
		set
		{
			dir_ = value;
		}
	}

	public GssdkReportConfig Report
	{
		get
		{
			return report_;
		}
		set
		{
			report_ = value;
		}
	}

	public GssdkVersionConfig Version
	{
		get
		{
			return version_;
		}
		set
		{
			version_ = value;
		}
	}

	public GssdkConfig()
	{
	}

	public GssdkConfig(GssdkConfig other)
		: this()
	{
		auth_ = ((other.auth_ != null) ? other.auth_.Clone() : null);
		dir_ = ((other.dir_ != null) ? other.dir_.Clone() : null);
		report_ = ((other.report_ != null) ? other.report_.Clone() : null);
		version_ = ((other.version_ != null) ? other.version_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GssdkConfig Clone()
	{
		return new GssdkConfig(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GssdkConfig);
	}

	public bool Equals(GssdkConfig other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Auth, other.Auth))
		{
			return false;
		}
		if (!object.Equals(Dir, other.Dir))
		{
			return false;
		}
		if (!object.Equals(Report, other.Report))
		{
			return false;
		}
		if (!object.Equals(Version, other.Version))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (auth_ != null)
		{
			num ^= Auth.GetHashCode();
		}
		if (dir_ != null)
		{
			num ^= Dir.GetHashCode();
		}
		if (report_ != null)
		{
			num ^= Report.GetHashCode();
		}
		if (version_ != null)
		{
			num ^= Version.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (auth_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Auth);
		}
		if (dir_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Dir);
		}
		if (report_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Report);
		}
		if (version_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Version);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (auth_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Auth);
		}
		if (dir_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Dir);
		}
		if (report_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Report);
		}
		if (version_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Version);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GssdkConfig other)
	{
		if (other == null)
		{
			return;
		}
		if (other.auth_ != null)
		{
			if (auth_ == null)
			{
				Auth = new GssdkAuthConfig();
			}
			Auth.MergeFrom(other.Auth);
		}
		if (other.dir_ != null)
		{
			if (dir_ == null)
			{
				Dir = new GssdkDirConfig();
			}
			Dir.MergeFrom(other.Dir);
		}
		if (other.report_ != null)
		{
			if (report_ == null)
			{
				Report = new GssdkReportConfig();
			}
			Report.MergeFrom(other.Report);
		}
		if (other.version_ != null)
		{
			if (version_ == null)
			{
				Version = new GssdkVersionConfig();
			}
			Version.MergeFrom(other.Version);
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
				if (auth_ == null)
				{
					Auth = new GssdkAuthConfig();
				}
				input.ReadMessage(Auth);
				break;
			case 18u:
				if (dir_ == null)
				{
					Dir = new GssdkDirConfig();
				}
				input.ReadMessage(Dir);
				break;
			case 26u:
				if (report_ == null)
				{
					Report = new GssdkReportConfig();
				}
				input.ReadMessage(Report);
				break;
			case 34u:
				if (version_ == null)
				{
					Version = new GssdkVersionConfig();
				}
				input.ReadMessage(Version);
				break;
			}
		}
	}
}
