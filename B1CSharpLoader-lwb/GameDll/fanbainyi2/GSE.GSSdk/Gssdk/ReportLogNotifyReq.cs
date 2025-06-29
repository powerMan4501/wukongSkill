using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class ReportLogNotifyReq : IMessage<ReportLogNotifyReq>, IMessage, IEquatable<ReportLogNotifyReq>, IDeepCloneable<ReportLogNotifyReq>
{
	private static readonly MessageParser<ReportLogNotifyReq> _parser = new MessageParser<ReportLogNotifyReq>(() => new ReportLogNotifyReq());

	private UnknownFieldSet _unknownFields;

	private string beginTime_ = "";

	private string endTime_ = "";

	private string tag_ = "";

	public static MessageParser<ReportLogNotifyReq> Parser => _parser;

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

	public ReportLogNotifyReq()
	{
	}

	public ReportLogNotifyReq(ReportLogNotifyReq other)
		: this()
	{
		beginTime_ = other.beginTime_;
		endTime_ = other.endTime_;
		tag_ = other.tag_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportLogNotifyReq Clone()
	{
		return new ReportLogNotifyReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportLogNotifyReq);
	}

	public bool Equals(ReportLogNotifyReq other)
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
		if (Tag != other.Tag)
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
		if (Tag.Length != 0)
		{
			num ^= Tag.GetHashCode();
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
		if (Tag.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Tag);
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
		if (Tag.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Tag);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportLogNotifyReq other)
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
			if (other.Tag.Length != 0)
			{
				Tag = other.Tag;
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
				Tag = input.ReadString();
				break;
			}
		}
	}
}
