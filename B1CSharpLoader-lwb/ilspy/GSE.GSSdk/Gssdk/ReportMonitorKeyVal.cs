using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class ReportMonitorKeyVal : IMessage<ReportMonitorKeyVal>, IMessage, IEquatable<ReportMonitorKeyVal>, IDeepCloneable<ReportMonitorKeyVal>
{
	private static readonly MessageParser<ReportMonitorKeyVal> _parser = new MessageParser<ReportMonitorKeyVal>(() => new ReportMonitorKeyVal());

	private UnknownFieldSet _unknownFields;

	private string key_ = "";

	private string val_ = "";

	public static MessageParser<ReportMonitorKeyVal> Parser => _parser;

	public string Key
	{
		get
		{
			return key_;
		}
		set
		{
			key_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Val
	{
		get
		{
			return val_;
		}
		set
		{
			val_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ReportMonitorKeyVal()
	{
	}

	public ReportMonitorKeyVal(ReportMonitorKeyVal other)
		: this()
	{
		key_ = other.key_;
		val_ = other.val_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportMonitorKeyVal Clone()
	{
		return new ReportMonitorKeyVal(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportMonitorKeyVal);
	}

	public bool Equals(ReportMonitorKeyVal other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Key != other.Key)
		{
			return false;
		}
		if (Val != other.Val)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Key.Length != 0)
		{
			num ^= Key.GetHashCode();
		}
		if (Val.Length != 0)
		{
			num ^= Val.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Key.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Key);
		}
		if (Val.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Val);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Key.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Key);
		}
		if (Val.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Val);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportMonitorKeyVal other)
	{
		if (other != null)
		{
			if (other.Key.Length != 0)
			{
				Key = other.Key;
			}
			if (other.Val.Length != 0)
			{
				Val = other.Val;
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
				Key = input.ReadString();
				break;
			case 18u:
				Val = input.ReadString();
				break;
			}
		}
	}
}
