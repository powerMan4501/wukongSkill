using System;
using Google.Protobuf;
using ResB1;

namespace CommB1;

public sealed class PlayerMailContentSyncWrapper : IMessage<PlayerMailContentSyncWrapper>, IMessage, IEquatable<PlayerMailContentSyncWrapper>, IDeepCloneable<PlayerMailContentSyncWrapper>
{
	private static readonly MessageParser<PlayerMailContentSyncWrapper> _parser = new MessageParser<PlayerMailContentSyncWrapper>(() => new PlayerMailContentSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private MailContentTypeSyncWrapper contentType_;

	private StringSyncWrapper sender_;

	private StringSyncWrapper subject_;

	private BytesSyncWrapper data_;

	private StringSyncWrapper forwardButton_;

	private StringSyncWrapper forwardUrl_;

	public static MessageParser<PlayerMailContentSyncWrapper> Parser => _parser;

	public int SyncFlag
	{
		get
		{
			return syncFlag_;
		}
		set
		{
			syncFlag_ = value;
		}
	}

	public int SyncIdx
	{
		get
		{
			return syncIdx_;
		}
		set
		{
			syncIdx_ = value;
		}
	}

	public MailContentTypeSyncWrapper ContentType
	{
		get
		{
			return contentType_;
		}
		set
		{
			contentType_ = value;
		}
	}

	public StringSyncWrapper Sender
	{
		get
		{
			return sender_;
		}
		set
		{
			sender_ = value;
		}
	}

	public StringSyncWrapper Subject
	{
		get
		{
			return subject_;
		}
		set
		{
			subject_ = value;
		}
	}

	public BytesSyncWrapper Data
	{
		get
		{
			return data_;
		}
		set
		{
			data_ = value;
		}
	}

	public StringSyncWrapper ForwardButton
	{
		get
		{
			return forwardButton_;
		}
		set
		{
			forwardButton_ = value;
		}
	}

	public StringSyncWrapper ForwardUrl
	{
		get
		{
			return forwardUrl_;
		}
		set
		{
			forwardUrl_ = value;
		}
	}

	public PlayerMailContentSyncWrapper()
	{
	}

	public PlayerMailContentSyncWrapper(PlayerMailContentSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		contentType_ = ((other.contentType_ != null) ? other.contentType_.Clone() : null);
		sender_ = ((other.sender_ != null) ? other.sender_.Clone() : null);
		subject_ = ((other.subject_ != null) ? other.subject_.Clone() : null);
		data_ = ((other.data_ != null) ? other.data_.Clone() : null);
		forwardButton_ = ((other.forwardButton_ != null) ? other.forwardButton_.Clone() : null);
		forwardUrl_ = ((other.forwardUrl_ != null) ? other.forwardUrl_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PlayerMailContentSyncWrapper Clone()
	{
		return new PlayerMailContentSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PlayerMailContentSyncWrapper);
	}

	public bool Equals(PlayerMailContentSyncWrapper other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SyncFlag != other.SyncFlag)
		{
			return false;
		}
		if (SyncIdx != other.SyncIdx)
		{
			return false;
		}
		if (!object.Equals(ContentType, other.ContentType))
		{
			return false;
		}
		if (!object.Equals(Sender, other.Sender))
		{
			return false;
		}
		if (!object.Equals(Subject, other.Subject))
		{
			return false;
		}
		if (!object.Equals(Data, other.Data))
		{
			return false;
		}
		if (!object.Equals(ForwardButton, other.ForwardButton))
		{
			return false;
		}
		if (!object.Equals(ForwardUrl, other.ForwardUrl))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SyncFlag != 0)
		{
			num ^= SyncFlag.GetHashCode();
		}
		if (SyncIdx != 0)
		{
			num ^= SyncIdx.GetHashCode();
		}
		if (contentType_ != null)
		{
			num ^= ContentType.GetHashCode();
		}
		if (sender_ != null)
		{
			num ^= Sender.GetHashCode();
		}
		if (subject_ != null)
		{
			num ^= Subject.GetHashCode();
		}
		if (data_ != null)
		{
			num ^= Data.GetHashCode();
		}
		if (forwardButton_ != null)
		{
			num ^= ForwardButton.GetHashCode();
		}
		if (forwardUrl_ != null)
		{
			num ^= ForwardUrl.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SyncFlag != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SyncIdx);
		}
		if (contentType_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(ContentType);
		}
		if (sender_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Sender);
		}
		if (subject_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(Subject);
		}
		if (data_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(Data);
		}
		if (forwardButton_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(ForwardButton);
		}
		if (forwardUrl_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(ForwardUrl);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SyncFlag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncIdx);
		}
		if (contentType_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ContentType);
		}
		if (sender_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Sender);
		}
		if (subject_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Subject);
		}
		if (data_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Data);
		}
		if (forwardButton_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ForwardButton);
		}
		if (forwardUrl_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ForwardUrl);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PlayerMailContentSyncWrapper other)
	{
		if (other == null)
		{
			return;
		}
		if (other.SyncFlag != 0)
		{
			SyncFlag = other.SyncFlag;
		}
		if (other.SyncIdx != 0)
		{
			SyncIdx = other.SyncIdx;
		}
		if (other.contentType_ != null)
		{
			if (contentType_ == null)
			{
				ContentType = new MailContentTypeSyncWrapper();
			}
			ContentType.MergeFrom(other.ContentType);
		}
		if (other.sender_ != null)
		{
			if (sender_ == null)
			{
				Sender = new StringSyncWrapper();
			}
			Sender.MergeFrom(other.Sender);
		}
		if (other.subject_ != null)
		{
			if (subject_ == null)
			{
				Subject = new StringSyncWrapper();
			}
			Subject.MergeFrom(other.Subject);
		}
		if (other.data_ != null)
		{
			if (data_ == null)
			{
				Data = new BytesSyncWrapper();
			}
			Data.MergeFrom(other.Data);
		}
		if (other.forwardButton_ != null)
		{
			if (forwardButton_ == null)
			{
				ForwardButton = new StringSyncWrapper();
			}
			ForwardButton.MergeFrom(other.ForwardButton);
		}
		if (other.forwardUrl_ != null)
		{
			if (forwardUrl_ == null)
			{
				ForwardUrl = new StringSyncWrapper();
			}
			ForwardUrl.MergeFrom(other.ForwardUrl);
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
			case 8u:
				SyncFlag = input.ReadInt32();
				break;
			case 16u:
				SyncIdx = input.ReadInt32();
				break;
			case 26u:
				if (contentType_ == null)
				{
					ContentType = new MailContentTypeSyncWrapper();
				}
				input.ReadMessage(ContentType);
				break;
			case 34u:
				if (sender_ == null)
				{
					Sender = new StringSyncWrapper();
				}
				input.ReadMessage(Sender);
				break;
			case 42u:
				if (subject_ == null)
				{
					Subject = new StringSyncWrapper();
				}
				input.ReadMessage(Subject);
				break;
			case 50u:
				if (data_ == null)
				{
					Data = new BytesSyncWrapper();
				}
				input.ReadMessage(Data);
				break;
			case 58u:
				if (forwardButton_ == null)
				{
					ForwardButton = new StringSyncWrapper();
				}
				input.ReadMessage(ForwardButton);
				break;
			case 66u:
				if (forwardUrl_ == null)
				{
					ForwardUrl = new StringSyncWrapper();
				}
				input.ReadMessage(ForwardUrl);
				break;
			}
		}
	}
}
