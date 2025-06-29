using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class VersionCheckConfigUserInfo : IMessage<VersionCheckConfigUserInfo>, IMessage, IEquatable<VersionCheckConfigUserInfo>, IDeepCloneable<VersionCheckConfigUserInfo>
{
	private static readonly MessageParser<VersionCheckConfigUserInfo> _parser = new MessageParser<VersionCheckConfigUserInfo>(() => new VersionCheckConfigUserInfo());

	private UnknownFieldSet _unknownFields;

	private string env_ = "";

	private string platform_ = "";

	private string appChannel_ = "";

	private string deviceId_ = "";

	private string localIpList_ = "";

	private string devBranch_ = "";

	private string language_ = "";

	private string region_ = "";

	private string appVersion_ = "";

	private int buildRevision_;

	public static MessageParser<VersionCheckConfigUserInfo> Parser => _parser;

	public string Env
	{
		get
		{
			return env_;
		}
		set
		{
			env_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Platform
	{
		get
		{
			return platform_;
		}
		set
		{
			platform_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string AppChannel
	{
		get
		{
			return appChannel_;
		}
		set
		{
			appChannel_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DeviceId
	{
		get
		{
			return deviceId_;
		}
		set
		{
			deviceId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string LocalIpList
	{
		get
		{
			return localIpList_;
		}
		set
		{
			localIpList_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DevBranch
	{
		get
		{
			return devBranch_;
		}
		set
		{
			devBranch_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Language
	{
		get
		{
			return language_;
		}
		set
		{
			language_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Region
	{
		get
		{
			return region_;
		}
		set
		{
			region_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string AppVersion
	{
		get
		{
			return appVersion_;
		}
		set
		{
			appVersion_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int BuildRevision
	{
		get
		{
			return buildRevision_;
		}
		set
		{
			buildRevision_ = value;
		}
	}

	public VersionCheckConfigUserInfo()
	{
	}

	public VersionCheckConfigUserInfo(VersionCheckConfigUserInfo other)
		: this()
	{
		env_ = other.env_;
		platform_ = other.platform_;
		appChannel_ = other.appChannel_;
		deviceId_ = other.deviceId_;
		localIpList_ = other.localIpList_;
		devBranch_ = other.devBranch_;
		language_ = other.language_;
		region_ = other.region_;
		appVersion_ = other.appVersion_;
		buildRevision_ = other.buildRevision_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public VersionCheckConfigUserInfo Clone()
	{
		return new VersionCheckConfigUserInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as VersionCheckConfigUserInfo);
	}

	public bool Equals(VersionCheckConfigUserInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Env != other.Env)
		{
			return false;
		}
		if (Platform != other.Platform)
		{
			return false;
		}
		if (AppChannel != other.AppChannel)
		{
			return false;
		}
		if (DeviceId != other.DeviceId)
		{
			return false;
		}
		if (LocalIpList != other.LocalIpList)
		{
			return false;
		}
		if (DevBranch != other.DevBranch)
		{
			return false;
		}
		if (Language != other.Language)
		{
			return false;
		}
		if (Region != other.Region)
		{
			return false;
		}
		if (AppVersion != other.AppVersion)
		{
			return false;
		}
		if (BuildRevision != other.BuildRevision)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Env.Length != 0)
		{
			num ^= Env.GetHashCode();
		}
		if (Platform.Length != 0)
		{
			num ^= Platform.GetHashCode();
		}
		if (AppChannel.Length != 0)
		{
			num ^= AppChannel.GetHashCode();
		}
		if (DeviceId.Length != 0)
		{
			num ^= DeviceId.GetHashCode();
		}
		if (LocalIpList.Length != 0)
		{
			num ^= LocalIpList.GetHashCode();
		}
		if (DevBranch.Length != 0)
		{
			num ^= DevBranch.GetHashCode();
		}
		if (Language.Length != 0)
		{
			num ^= Language.GetHashCode();
		}
		if (Region.Length != 0)
		{
			num ^= Region.GetHashCode();
		}
		if (AppVersion.Length != 0)
		{
			num ^= AppVersion.GetHashCode();
		}
		if (BuildRevision != 0)
		{
			num ^= BuildRevision.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Env.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Env);
		}
		if (Platform.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Platform);
		}
		if (AppChannel.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(AppChannel);
		}
		if (DeviceId.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(DeviceId);
		}
		if (LocalIpList.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(LocalIpList);
		}
		if (DevBranch.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(DevBranch);
		}
		if (Language.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(Language);
		}
		if (Region.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(Region);
		}
		if (AppVersion.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(AppVersion);
		}
		if (BuildRevision != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(BuildRevision);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Env.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Env);
		}
		if (Platform.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Platform);
		}
		if (AppChannel.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AppChannel);
		}
		if (DeviceId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DeviceId);
		}
		if (LocalIpList.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LocalIpList);
		}
		if (DevBranch.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DevBranch);
		}
		if (Language.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Language);
		}
		if (Region.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Region);
		}
		if (AppVersion.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AppVersion);
		}
		if (BuildRevision != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuildRevision);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(VersionCheckConfigUserInfo other)
	{
		if (other != null)
		{
			if (other.Env.Length != 0)
			{
				Env = other.Env;
			}
			if (other.Platform.Length != 0)
			{
				Platform = other.Platform;
			}
			if (other.AppChannel.Length != 0)
			{
				AppChannel = other.AppChannel;
			}
			if (other.DeviceId.Length != 0)
			{
				DeviceId = other.DeviceId;
			}
			if (other.LocalIpList.Length != 0)
			{
				LocalIpList = other.LocalIpList;
			}
			if (other.DevBranch.Length != 0)
			{
				DevBranch = other.DevBranch;
			}
			if (other.Language.Length != 0)
			{
				Language = other.Language;
			}
			if (other.Region.Length != 0)
			{
				Region = other.Region;
			}
			if (other.AppVersion.Length != 0)
			{
				AppVersion = other.AppVersion;
			}
			if (other.BuildRevision != 0)
			{
				BuildRevision = other.BuildRevision;
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
				Env = input.ReadString();
				break;
			case 18u:
				Platform = input.ReadString();
				break;
			case 26u:
				AppChannel = input.ReadString();
				break;
			case 34u:
				DeviceId = input.ReadString();
				break;
			case 42u:
				LocalIpList = input.ReadString();
				break;
			case 50u:
				DevBranch = input.ReadString();
				break;
			case 58u:
				Language = input.ReadString();
				break;
			case 66u:
				Region = input.ReadString();
				break;
			case 74u:
				AppVersion = input.ReadString();
				break;
			case 80u:
				BuildRevision = input.ReadInt32();
				break;
			}
		}
	}
}
