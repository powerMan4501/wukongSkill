using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class ReportUserRes : IMessage<ReportUserRes>, IMessage, IEquatable<ReportUserRes>, IDeepCloneable<ReportUserRes>
{
	private static readonly MessageParser<ReportUserRes> _parser = new MessageParser<ReportUserRes>(() => new ReportUserRes());

	private UnknownFieldSet _unknownFields;

	private string dummy_ = "";

	public static MessageParser<ReportUserRes> Parser => _parser;

	public string Dummy
	{
		get
		{
			return dummy_;
		}
		set
		{
			dummy_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ReportUserRes()
	{
	}

	public ReportUserRes(ReportUserRes other)
		: this()
	{
		dummy_ = other.dummy_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportUserRes Clone()
	{
		return new ReportUserRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportUserRes);
	}

	public bool Equals(ReportUserRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Dummy != other.Dummy)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Dummy.Length != 0)
		{
			num ^= Dummy.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Dummy.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Dummy);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Dummy.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Dummy);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportUserRes other)
	{
		if (other != null)
		{
			if (other.Dummy.Length != 0)
			{
				Dummy = other.Dummy;
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
				Dummy = input.ReadString();
			}
		}
	}
}
