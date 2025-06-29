using System;
using Google.Protobuf;

namespace OssB1;

public sealed class RecLen : IMessage<RecLen>, IMessage, IEquatable<RecLen>, IDeepCloneable<RecLen>
{
	private static readonly MessageParser<RecLen> _parser = new MessageParser<RecLen>(() => new RecLen());

	private UnknownFieldSet _unknownFields;

	private int playTime_;

	private string archiveUid_ = "";

	private int fileSizeKb_;

	private string archiveStatus_ = "";

	public static MessageParser<RecLen> Parser => _parser;

	public int PlayTime
	{
		get
		{
			return playTime_;
		}
		set
		{
			playTime_ = value;
		}
	}

	public string ArchiveUid
	{
		get
		{
			return archiveUid_;
		}
		set
		{
			archiveUid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int FileSizeKb
	{
		get
		{
			return fileSizeKb_;
		}
		set
		{
			fileSizeKb_ = value;
		}
	}

	public string ArchiveStatus
	{
		get
		{
			return archiveStatus_;
		}
		set
		{
			archiveStatus_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RecLen()
	{
	}

	public RecLen(RecLen other)
		: this()
	{
		playTime_ = other.playTime_;
		archiveUid_ = other.archiveUid_;
		fileSizeKb_ = other.fileSizeKb_;
		archiveStatus_ = other.archiveStatus_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RecLen Clone()
	{
		return new RecLen(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RecLen);
	}

	public bool Equals(RecLen other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PlayTime != other.PlayTime)
		{
			return false;
		}
		if (ArchiveUid != other.ArchiveUid)
		{
			return false;
		}
		if (FileSizeKb != other.FileSizeKb)
		{
			return false;
		}
		if (ArchiveStatus != other.ArchiveStatus)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (PlayTime != 0)
		{
			num ^= PlayTime.GetHashCode();
		}
		if (ArchiveUid.Length != 0)
		{
			num ^= ArchiveUid.GetHashCode();
		}
		if (FileSizeKb != 0)
		{
			num ^= FileSizeKb.GetHashCode();
		}
		if (ArchiveStatus.Length != 0)
		{
			num ^= ArchiveStatus.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (PlayTime != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(PlayTime);
		}
		if (ArchiveUid.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(ArchiveUid);
		}
		if (FileSizeKb != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(FileSizeKb);
		}
		if (ArchiveStatus.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(ArchiveStatus);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (PlayTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PlayTime);
		}
		if (ArchiveUid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ArchiveUid);
		}
		if (FileSizeKb != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FileSizeKb);
		}
		if (ArchiveStatus.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ArchiveStatus);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RecLen other)
	{
		if (other != null)
		{
			if (other.PlayTime != 0)
			{
				PlayTime = other.PlayTime;
			}
			if (other.ArchiveUid.Length != 0)
			{
				ArchiveUid = other.ArchiveUid;
			}
			if (other.FileSizeKb != 0)
			{
				FileSizeKb = other.FileSizeKb;
			}
			if (other.ArchiveStatus.Length != 0)
			{
				ArchiveStatus = other.ArchiveStatus;
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
			case 8u:
				PlayTime = input.ReadInt32();
				break;
			case 18u:
				ArchiveUid = input.ReadString();
				break;
			case 24u:
				FileSizeKb = input.ReadInt32();
				break;
			case 34u:
				ArchiveStatus = input.ReadString();
				break;
			}
		}
	}
}
