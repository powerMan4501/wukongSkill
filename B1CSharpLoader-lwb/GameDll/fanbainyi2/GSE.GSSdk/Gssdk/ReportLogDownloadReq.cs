using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class ReportLogDownloadReq : IMessage<ReportLogDownloadReq>, IMessage, IEquatable<ReportLogDownloadReq>, IDeepCloneable<ReportLogDownloadReq>
{
	private static readonly MessageParser<ReportLogDownloadReq> _parser = new MessageParser<ReportLogDownloadReq>(() => new ReportLogDownloadReq());

	private UnknownFieldSet _unknownFields;

	private string id_ = "";

	private string fileId_ = "";

	private string fileName_ = "";

	public static MessageParser<ReportLogDownloadReq> Parser => _parser;

	public string Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string FileId
	{
		get
		{
			return fileId_;
		}
		set
		{
			fileId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string FileName
	{
		get
		{
			return fileName_;
		}
		set
		{
			fileName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ReportLogDownloadReq()
	{
	}

	public ReportLogDownloadReq(ReportLogDownloadReq other)
		: this()
	{
		id_ = other.id_;
		fileId_ = other.fileId_;
		fileName_ = other.fileName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportLogDownloadReq Clone()
	{
		return new ReportLogDownloadReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportLogDownloadReq);
	}

	public bool Equals(ReportLogDownloadReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (FileId != other.FileId)
		{
			return false;
		}
		if (FileName != other.FileName)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id.Length != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (FileId.Length != 0)
		{
			num ^= FileId.GetHashCode();
		}
		if (FileName.Length != 0)
		{
			num ^= FileName.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Id);
		}
		if (FileId.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(FileId);
		}
		if (FileName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(FileName);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Id);
		}
		if (FileId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(FileId);
		}
		if (FileName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(FileName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportLogDownloadReq other)
	{
		if (other != null)
		{
			if (other.Id.Length != 0)
			{
				Id = other.Id;
			}
			if (other.FileId.Length != 0)
			{
				FileId = other.FileId;
			}
			if (other.FileName.Length != 0)
			{
				FileName = other.FileName;
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
				Id = input.ReadString();
				break;
			case 18u:
				FileId = input.ReadString();
				break;
			case 26u:
				FileName = input.ReadString();
				break;
			}
		}
	}
}
