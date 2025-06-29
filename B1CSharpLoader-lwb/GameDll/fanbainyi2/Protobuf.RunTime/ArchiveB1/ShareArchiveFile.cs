using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class ShareArchiveFile : IMessage<ShareArchiveFile>, IMessage, IEquatable<ShareArchiveFile>, IDeepCloneable<ShareArchiveFile>
{
	private static readonly MessageParser<ShareArchiveFile> _parser = new MessageParser<ShareArchiveFile>(() => new ShareArchiveFile());

	private UnknownFieldSet _unknownFields;

	private ShareArchiveInfo archiveInfo_;

	private ByteString shareArchiveDataBytes_ = ByteString.Empty;

	public static MessageParser<ShareArchiveFile> Parser => _parser;

	public ShareArchiveInfo ArchiveInfo
	{
		get
		{
			return archiveInfo_;
		}
		set
		{
			archiveInfo_ = value;
		}
	}

	public ByteString ShareArchiveDataBytes
	{
		get
		{
			return shareArchiveDataBytes_;
		}
		set
		{
			shareArchiveDataBytes_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ShareArchiveFile()
	{
	}

	public ShareArchiveFile(ShareArchiveFile other)
		: this()
	{
		archiveInfo_ = ((other.archiveInfo_ != null) ? other.archiveInfo_.Clone() : null);
		shareArchiveDataBytes_ = other.shareArchiveDataBytes_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ShareArchiveFile Clone()
	{
		return new ShareArchiveFile(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ShareArchiveFile);
	}

	public bool Equals(ShareArchiveFile other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ArchiveInfo, other.ArchiveInfo))
		{
			return false;
		}
		if (ShareArchiveDataBytes != other.ShareArchiveDataBytes)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (archiveInfo_ != null)
		{
			num ^= ArchiveInfo.GetHashCode();
		}
		if (ShareArchiveDataBytes.Length != 0)
		{
			num ^= ShareArchiveDataBytes.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (archiveInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(ArchiveInfo);
		}
		if (ShareArchiveDataBytes.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteBytes(ShareArchiveDataBytes);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (archiveInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ArchiveInfo);
		}
		if (ShareArchiveDataBytes.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(ShareArchiveDataBytes);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ShareArchiveFile other)
	{
		if (other == null)
		{
			return;
		}
		if (other.archiveInfo_ != null)
		{
			if (archiveInfo_ == null)
			{
				ArchiveInfo = new ShareArchiveInfo();
			}
			ArchiveInfo.MergeFrom(other.ArchiveInfo);
		}
		if (other.ShareArchiveDataBytes.Length != 0)
		{
			ShareArchiveDataBytes = other.ShareArchiveDataBytes;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				if (archiveInfo_ == null)
				{
					ArchiveInfo = new ShareArchiveInfo();
				}
				input.ReadMessage(ArchiveInfo);
				break;
			case 18u:
				ShareArchiveDataBytes = input.ReadBytes();
				break;
			}
		}
	}
}
