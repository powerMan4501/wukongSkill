using System;
using Google.Protobuf;

namespace OssB1;

public sealed class ReportEventAppLaunch : IMessage<ReportEventAppLaunch>, IMessage, IEquatable<ReportEventAppLaunch>, IDeepCloneable<ReportEventAppLaunch>
{
	private static readonly MessageParser<ReportEventAppLaunch> _parser = new MessageParser<ReportEventAppLaunch>(() => new ReportEventAppLaunch());

	private UnknownFieldSet _unknownFields;

	private string launchFrom_ = "";

	public static MessageParser<ReportEventAppLaunch> Parser => _parser;

	public string LaunchFrom
	{
		get
		{
			return launchFrom_;
		}
		set
		{
			launchFrom_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ReportEventAppLaunch()
	{
	}

	public ReportEventAppLaunch(ReportEventAppLaunch other)
		: this()
	{
		launchFrom_ = other.launchFrom_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportEventAppLaunch Clone()
	{
		return new ReportEventAppLaunch(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportEventAppLaunch);
	}

	public bool Equals(ReportEventAppLaunch other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LaunchFrom != other.LaunchFrom)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (LaunchFrom.Length != 0)
		{
			num ^= LaunchFrom.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (LaunchFrom.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(LaunchFrom);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (LaunchFrom.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LaunchFrom);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportEventAppLaunch other)
	{
		if (other != null)
		{
			if (other.LaunchFrom.Length != 0)
			{
				LaunchFrom = other.LaunchFrom;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				LaunchFrom = input.ReadString();
			}
		}
	}
}
