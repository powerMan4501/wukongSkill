using System;
using Google.Protobuf;

namespace CommB1;

public sealed class BehaviorCustom_Log : IMessage<BehaviorCustom_Log>, IMessage, IEquatable<BehaviorCustom_Log>, IDeepCloneable<BehaviorCustom_Log>
{
	private static readonly MessageParser<BehaviorCustom_Log> _parser = new MessageParser<BehaviorCustom_Log>(() => new BehaviorCustom_Log());

	private UnknownFieldSet _unknownFields;

	private string logString_ = "";

	private int logTime_;

	public static MessageParser<BehaviorCustom_Log> Parser => _parser;

	public string LogString
	{
		get
		{
			return logString_;
		}
		set
		{
			logString_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int LogTime
	{
		get
		{
			return logTime_;
		}
		set
		{
			logTime_ = value;
		}
	}

	public BehaviorCustom_Log()
	{
	}

	public BehaviorCustom_Log(BehaviorCustom_Log other)
		: this()
	{
		logString_ = other.logString_;
		logTime_ = other.logTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_Log Clone()
	{
		return new BehaviorCustom_Log(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_Log);
	}

	public bool Equals(BehaviorCustom_Log other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LogString != other.LogString)
		{
			return false;
		}
		if (LogTime != other.LogTime)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (LogString.Length != 0)
		{
			num ^= LogString.GetHashCode();
		}
		if (LogTime != 0)
		{
			num ^= LogTime.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (LogString.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(LogString);
		}
		if (LogTime != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(LogTime);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (LogString.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LogString);
		}
		if (LogTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LogTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_Log other)
	{
		if (other != null)
		{
			if (other.LogString.Length != 0)
			{
				LogString = other.LogString;
			}
			if (other.LogTime != 0)
			{
				LogTime = other.LogTime;
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
				LogString = input.ReadString();
				break;
			case 16u:
				LogTime = input.ReadInt32();
				break;
			}
		}
	}
}
