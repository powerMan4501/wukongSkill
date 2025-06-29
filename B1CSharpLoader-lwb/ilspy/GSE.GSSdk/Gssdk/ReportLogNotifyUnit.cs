using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class ReportLogNotifyUnit : IMessage<ReportLogNotifyUnit>, IMessage, IEquatable<ReportLogNotifyUnit>, IDeepCloneable<ReportLogNotifyUnit>
{
	private static readonly MessageParser<ReportLogNotifyUnit> _parser = new MessageParser<ReportLogNotifyUnit>(() => new ReportLogNotifyUnit());

	private UnknownFieldSet _unknownFields;

	private string name_ = "";

	private string value_ = "";

	public static MessageParser<ReportLogNotifyUnit> Parser => _parser;

	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Value
	{
		get
		{
			return value_;
		}
		set
		{
			value_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ReportLogNotifyUnit()
	{
	}

	public ReportLogNotifyUnit(ReportLogNotifyUnit other)
		: this()
	{
		name_ = other.name_;
		value_ = other.value_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportLogNotifyUnit Clone()
	{
		return new ReportLogNotifyUnit(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportLogNotifyUnit);
	}

	public bool Equals(ReportLogNotifyUnit other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (Value != other.Value)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (Value.Length != 0)
		{
			num ^= Value.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Name.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Name);
		}
		if (Value.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Value);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (Value.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Value);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportLogNotifyUnit other)
	{
		if (other != null)
		{
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.Value.Length != 0)
			{
				Value = other.Value;
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
				Name = input.ReadString();
				break;
			case 18u:
				Value = input.ReadString();
				break;
			}
		}
	}
}
