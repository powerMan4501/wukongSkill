using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class ReportLogEventUploadReq : IMessage<ReportLogEventUploadReq>, IMessage, IEquatable<ReportLogEventUploadReq>, IDeepCloneable<ReportLogEventUploadReq>
{
	private static readonly MessageParser<ReportLogEventUploadReq> _parser = new MessageParser<ReportLogEventUploadReq>(() => new ReportLogEventUploadReq());

	private UnknownFieldSet _unknownFields;

	private string fileplace_ = "";

	public static MessageParser<ReportLogEventUploadReq> Parser => _parser;

	public string Fileplace
	{
		get
		{
			return fileplace_;
		}
		set
		{
			fileplace_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ReportLogEventUploadReq()
	{
	}

	public ReportLogEventUploadReq(ReportLogEventUploadReq other)
		: this()
	{
		fileplace_ = other.fileplace_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportLogEventUploadReq Clone()
	{
		return new ReportLogEventUploadReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportLogEventUploadReq);
	}

	public bool Equals(ReportLogEventUploadReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Fileplace != other.Fileplace)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Fileplace.Length != 0)
		{
			num ^= Fileplace.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Fileplace.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Fileplace);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Fileplace.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Fileplace);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportLogEventUploadReq other)
	{
		if (other != null)
		{
			if (other.Fileplace.Length != 0)
			{
				Fileplace = other.Fileplace;
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
				Fileplace = input.ReadString();
			}
		}
	}
}
