using System;
using Google.Protobuf;

namespace OssB1;

public sealed class ReportEventGameCrash : IMessage<ReportEventGameCrash>, IMessage, IEquatable<ReportEventGameCrash>, IDeepCloneable<ReportEventGameCrash>
{
	private static readonly MessageParser<ReportEventGameCrash> _parser = new MessageParser<ReportEventGameCrash>(() => new ReportEventGameCrash());

	private UnknownFieldSet _unknownFields;

	private GameCrashType crashType_;

	private string gameSessionId_ = "";

	private string userConfig_ = "";

	private string userFeed_ = "";

	private string ext_ = "";

	private long timestamp_;

	private string errorDesc_ = "";

	private string stackTrace_ = "";

	private bool isLastCrash_;

	private string crashGuid_ = "";

	private string lastCrashTime_ = "";

	private string lastCrashLogTail_ = "";

	public static MessageParser<ReportEventGameCrash> Parser => _parser;

	public GameCrashType CrashType
	{
		get
		{
			return crashType_;
		}
		set
		{
			crashType_ = value;
		}
	}

	public string GameSessionId
	{
		get
		{
			return gameSessionId_;
		}
		set
		{
			gameSessionId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string UserConfig
	{
		get
		{
			return userConfig_;
		}
		set
		{
			userConfig_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string UserFeed
	{
		get
		{
			return userFeed_;
		}
		set
		{
			userFeed_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Ext
	{
		get
		{
			return ext_;
		}
		set
		{
			ext_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public long Timestamp
	{
		get
		{
			return timestamp_;
		}
		set
		{
			timestamp_ = value;
		}
	}

	public string ErrorDesc
	{
		get
		{
			return errorDesc_;
		}
		set
		{
			errorDesc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string StackTrace
	{
		get
		{
			return stackTrace_;
		}
		set
		{
			stackTrace_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool IsLastCrash
	{
		get
		{
			return isLastCrash_;
		}
		set
		{
			isLastCrash_ = value;
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

	public string LastCrashTime
	{
		get
		{
			return lastCrashTime_;
		}
		set
		{
			lastCrashTime_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string LastCrashLogTail
	{
		get
		{
			return lastCrashLogTail_;
		}
		set
		{
			lastCrashLogTail_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ReportEventGameCrash()
	{
	}

	public ReportEventGameCrash(ReportEventGameCrash other)
		: this()
	{
		crashType_ = other.crashType_;
		gameSessionId_ = other.gameSessionId_;
		userConfig_ = other.userConfig_;
		userFeed_ = other.userFeed_;
		ext_ = other.ext_;
		timestamp_ = other.timestamp_;
		errorDesc_ = other.errorDesc_;
		stackTrace_ = other.stackTrace_;
		isLastCrash_ = other.isLastCrash_;
		crashGuid_ = other.crashGuid_;
		lastCrashTime_ = other.lastCrashTime_;
		lastCrashLogTail_ = other.lastCrashLogTail_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportEventGameCrash Clone()
	{
		return new ReportEventGameCrash(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportEventGameCrash);
	}

	public bool Equals(ReportEventGameCrash other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CrashType != other.CrashType)
		{
			return false;
		}
		if (GameSessionId != other.GameSessionId)
		{
			return false;
		}
		if (UserConfig != other.UserConfig)
		{
			return false;
		}
		if (UserFeed != other.UserFeed)
		{
			return false;
		}
		if (Ext != other.Ext)
		{
			return false;
		}
		if (Timestamp != other.Timestamp)
		{
			return false;
		}
		if (ErrorDesc != other.ErrorDesc)
		{
			return false;
		}
		if (StackTrace != other.StackTrace)
		{
			return false;
		}
		if (IsLastCrash != other.IsLastCrash)
		{
			return false;
		}
		if (CrashGuid != other.CrashGuid)
		{
			return false;
		}
		if (LastCrashTime != other.LastCrashTime)
		{
			return false;
		}
		if (LastCrashLogTail != other.LastCrashLogTail)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (CrashType != GameCrashType.Default)
		{
			num ^= CrashType.GetHashCode();
		}
		if (GameSessionId.Length != 0)
		{
			num ^= GameSessionId.GetHashCode();
		}
		if (UserConfig.Length != 0)
		{
			num ^= UserConfig.GetHashCode();
		}
		if (UserFeed.Length != 0)
		{
			num ^= UserFeed.GetHashCode();
		}
		if (Ext.Length != 0)
		{
			num ^= Ext.GetHashCode();
		}
		if (Timestamp != 0L)
		{
			num ^= Timestamp.GetHashCode();
		}
		if (ErrorDesc.Length != 0)
		{
			num ^= ErrorDesc.GetHashCode();
		}
		if (StackTrace.Length != 0)
		{
			num ^= StackTrace.GetHashCode();
		}
		if (IsLastCrash)
		{
			num ^= IsLastCrash.GetHashCode();
		}
		if (CrashGuid.Length != 0)
		{
			num ^= CrashGuid.GetHashCode();
		}
		if (LastCrashTime.Length != 0)
		{
			num ^= LastCrashTime.GetHashCode();
		}
		if (LastCrashLogTail.Length != 0)
		{
			num ^= LastCrashLogTail.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (CrashType != GameCrashType.Default)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)CrashType);
		}
		if (GameSessionId.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(GameSessionId);
		}
		if (UserConfig.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(UserConfig);
		}
		if (UserFeed.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(UserFeed);
		}
		if (Ext.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(Ext);
		}
		if (Timestamp != 0L)
		{
			output.WriteRawTag(48);
			output.WriteInt64(Timestamp);
		}
		if (ErrorDesc.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(ErrorDesc);
		}
		if (StackTrace.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(StackTrace);
		}
		if (IsLastCrash)
		{
			output.WriteRawTag(72);
			output.WriteBool(IsLastCrash);
		}
		if (CrashGuid.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(CrashGuid);
		}
		if (LastCrashTime.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(LastCrashTime);
		}
		if (LastCrashLogTail.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(LastCrashLogTail);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (CrashType != GameCrashType.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CrashType);
		}
		if (GameSessionId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GameSessionId);
		}
		if (UserConfig.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UserConfig);
		}
		if (UserFeed.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UserFeed);
		}
		if (Ext.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Ext);
		}
		if (Timestamp != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Timestamp);
		}
		if (ErrorDesc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ErrorDesc);
		}
		if (StackTrace.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(StackTrace);
		}
		if (IsLastCrash)
		{
			num += 2;
		}
		if (CrashGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CrashGuid);
		}
		if (LastCrashTime.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LastCrashTime);
		}
		if (LastCrashLogTail.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LastCrashLogTail);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportEventGameCrash other)
	{
		if (other != null)
		{
			if (other.CrashType != GameCrashType.Default)
			{
				CrashType = other.CrashType;
			}
			if (other.GameSessionId.Length != 0)
			{
				GameSessionId = other.GameSessionId;
			}
			if (other.UserConfig.Length != 0)
			{
				UserConfig = other.UserConfig;
			}
			if (other.UserFeed.Length != 0)
			{
				UserFeed = other.UserFeed;
			}
			if (other.Ext.Length != 0)
			{
				Ext = other.Ext;
			}
			if (other.Timestamp != 0L)
			{
				Timestamp = other.Timestamp;
			}
			if (other.ErrorDesc.Length != 0)
			{
				ErrorDesc = other.ErrorDesc;
			}
			if (other.StackTrace.Length != 0)
			{
				StackTrace = other.StackTrace;
			}
			if (other.IsLastCrash)
			{
				IsLastCrash = other.IsLastCrash;
			}
			if (other.CrashGuid.Length != 0)
			{
				CrashGuid = other.CrashGuid;
			}
			if (other.LastCrashTime.Length != 0)
			{
				LastCrashTime = other.LastCrashTime;
			}
			if (other.LastCrashLogTail.Length != 0)
			{
				LastCrashLogTail = other.LastCrashLogTail;
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
			case 8u:
				CrashType = (GameCrashType)input.ReadEnum();
				break;
			case 18u:
				GameSessionId = input.ReadString();
				break;
			case 26u:
				UserConfig = input.ReadString();
				break;
			case 34u:
				UserFeed = input.ReadString();
				break;
			case 42u:
				Ext = input.ReadString();
				break;
			case 48u:
				Timestamp = input.ReadInt64();
				break;
			case 58u:
				ErrorDesc = input.ReadString();
				break;
			case 66u:
				StackTrace = input.ReadString();
				break;
			case 72u:
				IsLastCrash = input.ReadBool();
				break;
			case 82u:
				CrashGuid = input.ReadString();
				break;
			case 90u:
				LastCrashTime = input.ReadString();
				break;
			case 98u:
				LastCrashLogTail = input.ReadString();
				break;
			}
		}
	}
}
