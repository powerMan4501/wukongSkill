using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class ArchiveFile : IMessage<ArchiveFile>, IMessage, IEquatable<ArchiveFile>, IDeepCloneable<ArchiveFile>
{
	private static readonly MessageParser<ArchiveFile> _parser = new MessageParser<ArchiveFile>(() => new ArchiveFile());

	private UnknownFieldSet _unknownFields;

	private ArchiveInfo archiveInfo_;

	private ByteString gameArchivesDataBytes_ = ByteString.Empty;

	public static MessageParser<ArchiveFile> Parser => _parser;

	public ArchiveInfo ArchiveInfo
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

	public ByteString GameArchivesDataBytes
	{
		get
		{
			return gameArchivesDataBytes_;
		}
		set
		{
			gameArchivesDataBytes_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ArchiveFile()
	{
	}

	public ArchiveFile(ArchiveFile other)
		: this()
	{
		archiveInfo_ = ((other.archiveInfo_ != null) ? other.archiveInfo_.Clone() : null);
		gameArchivesDataBytes_ = other.gameArchivesDataBytes_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ArchiveFile Clone()
	{
		return new ArchiveFile(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ArchiveFile);
	}

	public bool Equals(ArchiveFile other)
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
		if (GameArchivesDataBytes != other.GameArchivesDataBytes)
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
		if (GameArchivesDataBytes.Length != 0)
		{
			num ^= GameArchivesDataBytes.GetHashCode();
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
		if (GameArchivesDataBytes.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteBytes(GameArchivesDataBytes);
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
		if (GameArchivesDataBytes.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(GameArchivesDataBytes);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ArchiveFile other)
	{
		if (other == null)
		{
			return;
		}
		if (other.archiveInfo_ != null)
		{
			if (archiveInfo_ == null)
			{
				ArchiveInfo = new ArchiveInfo();
			}
			ArchiveInfo.MergeFrom(other.ArchiveInfo);
		}
		if (other.GameArchivesDataBytes.Length != 0)
		{
			GameArchivesDataBytes = other.GameArchivesDataBytes;
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
					ArchiveInfo = new ArchiveInfo();
				}
				input.ReadMessage(ArchiveInfo);
				break;
			case 18u:
				GameArchivesDataBytes = input.ReadBytes();
				break;
			}
		}
	}
}
