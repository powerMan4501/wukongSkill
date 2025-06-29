using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class UserGameSession : IMessage<UserGameSession>, IMessage, IEquatable<UserGameSession>, IDeepCloneable<UserGameSession>
{
	private static readonly MessageParser<UserGameSession> _parser = new MessageParser<UserGameSession>(() => new UserGameSession());

	private UnknownFieldSet _unknownFields;

	private string startSessionUuid_ = "";

	private long startTimestamp_;

	private string loginId_ = "";

	private string machineId_ = "";

	private string platformName_ = "";

	private string processId_ = "";

	private int secondsSinceStart_;

	private string engineMode_ = "";

	private string gameName_ = "";

	private string languageLcid_ = "";

	private string rootDir_ = "";

	private string baseDir_ = "";

	private string buildConfiguration_ = "";

	private string crashGuid_ = "";

	private string resolution_ = "";

	public static MessageParser<UserGameSession> Parser => _parser;

	public string StartSessionUuid
	{
		get
		{
			return startSessionUuid_;
		}
		set
		{
			startSessionUuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public long StartTimestamp
	{
		get
		{
			return startTimestamp_;
		}
		set
		{
			startTimestamp_ = value;
		}
	}

	public string LoginId
	{
		get
		{
			return loginId_;
		}
		set
		{
			loginId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string MachineId
	{
		get
		{
			return machineId_;
		}
		set
		{
			machineId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string PlatformName
	{
		get
		{
			return platformName_;
		}
		set
		{
			platformName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ProcessId
	{
		get
		{
			return processId_;
		}
		set
		{
			processId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int SecondsSinceStart
	{
		get
		{
			return secondsSinceStart_;
		}
		set
		{
			secondsSinceStart_ = value;
		}
	}

	public string EngineMode
	{
		get
		{
			return engineMode_;
		}
		set
		{
			engineMode_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string GameName
	{
		get
		{
			return gameName_;
		}
		set
		{
			gameName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string LanguageLcid
	{
		get
		{
			return languageLcid_;
		}
		set
		{
			languageLcid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string RootDir
	{
		get
		{
			return rootDir_;
		}
		set
		{
			rootDir_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string BaseDir
	{
		get
		{
			return baseDir_;
		}
		set
		{
			baseDir_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string BuildConfiguration
	{
		get
		{
			return buildConfiguration_;
		}
		set
		{
			buildConfiguration_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string CrashGuid
	{
		get
		{
			return crashGuid_;
		}
		set
		{
			crashGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Resolution
	{
		get
		{
			return resolution_;
		}
		set
		{
			resolution_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public UserGameSession()
	{
	}

	public UserGameSession(UserGameSession other)
		: this()
	{
		startSessionUuid_ = other.startSessionUuid_;
		startTimestamp_ = other.startTimestamp_;
		loginId_ = other.loginId_;
		machineId_ = other.machineId_;
		platformName_ = other.platformName_;
		processId_ = other.processId_;
		secondsSinceStart_ = other.secondsSinceStart_;
		engineMode_ = other.engineMode_;
		gameName_ = other.gameName_;
		languageLcid_ = other.languageLcid_;
		rootDir_ = other.rootDir_;
		baseDir_ = other.baseDir_;
		buildConfiguration_ = other.buildConfiguration_;
		crashGuid_ = other.crashGuid_;
		resolution_ = other.resolution_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public UserGameSession Clone()
	{
		return new UserGameSession(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as UserGameSession);
	}

	public bool Equals(UserGameSession other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (StartSessionUuid != other.StartSessionUuid)
		{
			return false;
		}
		if (StartTimestamp != other.StartTimestamp)
		{
			return false;
		}
		if (LoginId != other.LoginId)
		{
			return false;
		}
		if (MachineId != other.MachineId)
		{
			return false;
		}
		if (PlatformName != other.PlatformName)
		{
			return false;
		}
		if (ProcessId != other.ProcessId)
		{
			return false;
		}
		if (SecondsSinceStart != other.SecondsSinceStart)
		{
			return false;
		}
		if (EngineMode != other.EngineMode)
		{
			return false;
		}
		if (GameName != other.GameName)
		{
			return false;
		}
		if (LanguageLcid != other.LanguageLcid)
		{
			return false;
		}
		if (RootDir != other.RootDir)
		{
			return false;
		}
		if (BaseDir != other.BaseDir)
		{
			return false;
		}
		if (BuildConfiguration != other.BuildConfiguration)
		{
			return false;
		}
		if (CrashGuid != other.CrashGuid)
		{
			return false;
		}
		if (Resolution != other.Resolution)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (StartSessionUuid.Length != 0)
		{
			num ^= StartSessionUuid.GetHashCode();
		}
		if (StartTimestamp != 0L)
		{
			num ^= StartTimestamp.GetHashCode();
		}
		if (LoginId.Length != 0)
		{
			num ^= LoginId.GetHashCode();
		}
		if (MachineId.Length != 0)
		{
			num ^= MachineId.GetHashCode();
		}
		if (PlatformName.Length != 0)
		{
			num ^= PlatformName.GetHashCode();
		}
		if (ProcessId.Length != 0)
		{
			num ^= ProcessId.GetHashCode();
		}
		if (SecondsSinceStart != 0)
		{
			num ^= SecondsSinceStart.GetHashCode();
		}
		if (EngineMode.Length != 0)
		{
			num ^= EngineMode.GetHashCode();
		}
		if (GameName.Length != 0)
		{
			num ^= GameName.GetHashCode();
		}
		if (LanguageLcid.Length != 0)
		{
			num ^= LanguageLcid.GetHashCode();
		}
		if (RootDir.Length != 0)
		{
			num ^= RootDir.GetHashCode();
		}
		if (BaseDir.Length != 0)
		{
			num ^= BaseDir.GetHashCode();
		}
		if (BuildConfiguration.Length != 0)
		{
			num ^= BuildConfiguration.GetHashCode();
		}
		if (CrashGuid.Length != 0)
		{
			num ^= CrashGuid.GetHashCode();
		}
		if (Resolution.Length != 0)
		{
			num ^= Resolution.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (StartSessionUuid.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(StartSessionUuid);
		}
		if (StartTimestamp != 0L)
		{
			output.WriteRawTag(16);
			output.WriteInt64(StartTimestamp);
		}
		if (LoginId.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(LoginId);
		}
		if (MachineId.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(MachineId);
		}
		if (PlatformName.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(PlatformName);
		}
		if (ProcessId.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(ProcessId);
		}
		if (SecondsSinceStart != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(SecondsSinceStart);
		}
		if (EngineMode.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(EngineMode);
		}
		if (GameName.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(GameName);
		}
		if (LanguageLcid.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(LanguageLcid);
		}
		if (RootDir.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(RootDir);
		}
		if (BaseDir.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(BaseDir);
		}
		if (BuildConfiguration.Length != 0)
		{
			output.WriteRawTag(106);
			output.WriteString(BuildConfiguration);
		}
		if (CrashGuid.Length != 0)
		{
			output.WriteRawTag(114);
			output.WriteString(CrashGuid);
		}
		if (Resolution.Length != 0)
		{
			output.WriteRawTag(122);
			output.WriteString(Resolution);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (StartSessionUuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(StartSessionUuid);
		}
		if (StartTimestamp != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(StartTimestamp);
		}
		if (LoginId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LoginId);
		}
		if (MachineId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MachineId);
		}
		if (PlatformName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PlatformName);
		}
		if (ProcessId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ProcessId);
		}
		if (SecondsSinceStart != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SecondsSinceStart);
		}
		if (EngineMode.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EngineMode);
		}
		if (GameName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GameName);
		}
		if (LanguageLcid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LanguageLcid);
		}
		if (RootDir.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RootDir);
		}
		if (BaseDir.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BaseDir);
		}
		if (BuildConfiguration.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BuildConfiguration);
		}
		if (CrashGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CrashGuid);
		}
		if (Resolution.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Resolution);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(UserGameSession other)
	{
		if (other != null)
		{
			if (other.StartSessionUuid.Length != 0)
			{
				StartSessionUuid = other.StartSessionUuid;
			}
			if (other.StartTimestamp != 0L)
			{
				StartTimestamp = other.StartTimestamp;
			}
			if (other.LoginId.Length != 0)
			{
				LoginId = other.LoginId;
			}
			if (other.MachineId.Length != 0)
			{
				MachineId = other.MachineId;
			}
			if (other.PlatformName.Length != 0)
			{
				PlatformName = other.PlatformName;
			}
			if (other.ProcessId.Length != 0)
			{
				ProcessId = other.ProcessId;
			}
			if (other.SecondsSinceStart != 0)
			{
				SecondsSinceStart = other.SecondsSinceStart;
			}
			if (other.EngineMode.Length != 0)
			{
				EngineMode = other.EngineMode;
			}
			if (other.GameName.Length != 0)
			{
				GameName = other.GameName;
			}
			if (other.LanguageLcid.Length != 0)
			{
				LanguageLcid = other.LanguageLcid;
			}
			if (other.RootDir.Length != 0)
			{
				RootDir = other.RootDir;
			}
			if (other.BaseDir.Length != 0)
			{
				BaseDir = other.BaseDir;
			}
			if (other.BuildConfiguration.Length != 0)
			{
				BuildConfiguration = other.BuildConfiguration;
			}
			if (other.CrashGuid.Length != 0)
			{
				CrashGuid = other.CrashGuid;
			}
			if (other.Resolution.Length != 0)
			{
				Resolution = other.Resolution;
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
				StartSessionUuid = input.ReadString();
				break;
			case 16u:
				StartTimestamp = input.ReadInt64();
				break;
			case 26u:
				LoginId = input.ReadString();
				break;
			case 34u:
				MachineId = input.ReadString();
				break;
			case 42u:
				PlatformName = input.ReadString();
				break;
			case 50u:
				ProcessId = input.ReadString();
				break;
			case 56u:
				SecondsSinceStart = input.ReadInt32();
				break;
			case 66u:
				EngineMode = input.ReadString();
				break;
			case 74u:
				GameName = input.ReadString();
				break;
			case 82u:
				LanguageLcid = input.ReadString();
				break;
			case 90u:
				RootDir = input.ReadString();
				break;
			case 98u:
				BaseDir = input.ReadString();
				break;
			case 106u:
				BuildConfiguration = input.ReadString();
				break;
			case 114u:
				CrashGuid = input.ReadString();
				break;
			case 122u:
				Resolution = input.ReadString();
				break;
			}
		}
	}
}
