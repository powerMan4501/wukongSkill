using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class ReportUploadFileOne : IMessage<ReportUploadFileOne>, IMessage, IEquatable<ReportUploadFileOne>, IDeepCloneable<ReportUploadFileOne>
{
	private static readonly MessageParser<ReportUploadFileOne> _parser = new MessageParser<ReportUploadFileOne>(() => new ReportUploadFileOne());

	private UnknownFieldSet _unknownFields;

	private string keyName_ = "";

	private ByteString valContent_ = ByteString.Empty;

	public static MessageParser<ReportUploadFileOne> Parser => _parser;

	public string KeyName
	{
		get
		{
			return keyName_;
		}
		set
		{
			keyName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ByteString ValContent
	{
		get
		{
			return valContent_;
		}
		set
		{
			valContent_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ReportUploadFileOne()
	{
	}

	public ReportUploadFileOne(ReportUploadFileOne other)
		: this()
	{
		keyName_ = other.keyName_;
		valContent_ = other.valContent_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportUploadFileOne Clone()
	{
		return new ReportUploadFileOne(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportUploadFileOne);
	}

	public bool Equals(ReportUploadFileOne other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KeyName != other.KeyName)
		{
			return false;
		}
		if (ValContent != other.ValContent)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (KeyName.Length != 0)
		{
			num ^= KeyName.GetHashCode();
		}
		if (ValContent.Length != 0)
		{
			num ^= ValContent.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (KeyName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(KeyName);
		}
		if (ValContent.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteBytes(ValContent);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (KeyName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(KeyName);
		}
		if (ValContent.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(ValContent);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportUploadFileOne other)
	{
		if (other != null)
		{
			if (other.KeyName.Length != 0)
			{
				KeyName = other.KeyName;
			}
			if (other.ValContent.Length != 0)
			{
				ValContent = other.ValContent;
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
				KeyName = input.ReadString();
				break;
			case 18u:
				ValContent = input.ReadBytes();
				break;
			}
		}
	}
}
