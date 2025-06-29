using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class ArchiveCheckRoot : IMessage<ArchiveCheckRoot>, IMessage, IEquatable<ArchiveCheckRoot>, IDeepCloneable<ArchiveCheckRoot>
{
	private static readonly MessageParser<ArchiveCheckRoot> _parser = new MessageParser<ArchiveCheckRoot>(() => new ArchiveCheckRoot());

	private UnknownFieldSet _unknownFields;

	private FUStBEDArchivesData archiveData_;

	private ShareArchiveFile shareArchiveData_;

	public static MessageParser<ArchiveCheckRoot> Parser => _parser;

	public FUStBEDArchivesData ArchiveData
	{
		get
		{
			return archiveData_;
		}
		set
		{
			archiveData_ = value;
		}
	}

	public ShareArchiveFile ShareArchiveData
	{
		get
		{
			return shareArchiveData_;
		}
		set
		{
			shareArchiveData_ = value;
		}
	}

	public ArchiveCheckRoot()
	{
	}

	public ArchiveCheckRoot(ArchiveCheckRoot other)
		: this()
	{
		archiveData_ = ((other.archiveData_ != null) ? other.archiveData_.Clone() : null);
		shareArchiveData_ = ((other.shareArchiveData_ != null) ? other.shareArchiveData_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ArchiveCheckRoot Clone()
	{
		return new ArchiveCheckRoot(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ArchiveCheckRoot);
	}

	public bool Equals(ArchiveCheckRoot other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ArchiveData, other.ArchiveData))
		{
			return false;
		}
		if (!object.Equals(ShareArchiveData, other.ShareArchiveData))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (archiveData_ != null)
		{
			num ^= ArchiveData.GetHashCode();
		}
		if (shareArchiveData_ != null)
		{
			num ^= ShareArchiveData.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (archiveData_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(ArchiveData);
		}
		if (shareArchiveData_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(ShareArchiveData);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (archiveData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ArchiveData);
		}
		if (shareArchiveData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ShareArchiveData);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ArchiveCheckRoot other)
	{
		if (other == null)
		{
			return;
		}
		if (other.archiveData_ != null)
		{
			if (archiveData_ == null)
			{
				ArchiveData = new FUStBEDArchivesData();
			}
			ArchiveData.MergeFrom(other.ArchiveData);
		}
		if (other.shareArchiveData_ != null)
		{
			if (shareArchiveData_ == null)
			{
				ShareArchiveData = new ShareArchiveFile();
			}
			ShareArchiveData.MergeFrom(other.ShareArchiveData);
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
				if (archiveData_ == null)
				{
					ArchiveData = new FUStBEDArchivesData();
				}
				input.ReadMessage(ArchiveData);
				break;
			case 18u:
				if (shareArchiveData_ == null)
				{
					ShareArchiveData = new ShareArchiveFile();
				}
				input.ReadMessage(ShareArchiveData);
				break;
			}
		}
	}
}
