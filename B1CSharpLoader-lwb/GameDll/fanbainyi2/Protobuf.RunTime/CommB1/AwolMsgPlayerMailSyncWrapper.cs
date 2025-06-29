using System;
using Google.Protobuf;

namespace CommB1;

public sealed class AwolMsgPlayerMailSyncWrapper : IMessage<AwolMsgPlayerMailSyncWrapper>, IMessage, IEquatable<AwolMsgPlayerMailSyncWrapper>, IDeepCloneable<AwolMsgPlayerMailSyncWrapper>
{
	private static readonly MessageParser<AwolMsgPlayerMailSyncWrapper> _parser = new MessageParser<AwolMsgPlayerMailSyncWrapper>(() => new AwolMsgPlayerMailSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private MailBaseSyncWrapper base_;

	private PlayerMailContentSyncWrapper content_;

	public static MessageParser<AwolMsgPlayerMailSyncWrapper> Parser => _parser;

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

	public MailBaseSyncWrapper Base
	{
		get
		{
			return base_;
		}
		set
		{
			base_ = value;
		}
	}

	public PlayerMailContentSyncWrapper Content
	{
		get
		{
			return content_;
		}
		set
		{
			content_ = value;
		}
	}

	public AwolMsgPlayerMailSyncWrapper()
	{
	}

	public AwolMsgPlayerMailSyncWrapper(AwolMsgPlayerMailSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		base_ = ((other.base_ != null) ? other.base_.Clone() : null);
		content_ = ((other.content_ != null) ? other.content_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AwolMsgPlayerMailSyncWrapper Clone()
	{
		return new AwolMsgPlayerMailSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AwolMsgPlayerMailSyncWrapper);
	}

	public bool Equals(AwolMsgPlayerMailSyncWrapper other)
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
		if (!object.Equals(Base, other.Base))
		{
			return false;
		}
		if (!object.Equals(Content, other.Content))
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
		if (base_ != null)
		{
			num ^= Base.GetHashCode();
		}
		if (content_ != null)
		{
			num ^= Content.GetHashCode();
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
		if (base_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Base);
		}
		if (content_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Content);
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
		if (base_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Base);
		}
		if (content_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Content);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AwolMsgPlayerMailSyncWrapper other)
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
		if (other.base_ != null)
		{
			if (base_ == null)
			{
				Base = new MailBaseSyncWrapper();
			}
			Base.MergeFrom(other.Base);
		}
		if (other.content_ != null)
		{
			if (content_ == null)
			{
				Content = new PlayerMailContentSyncWrapper();
			}
			Content.MergeFrom(other.Content);
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
				if (base_ == null)
				{
					Base = new MailBaseSyncWrapper();
				}
				input.ReadMessage(Base);
				break;
			case 34u:
				if (content_ == null)
				{
					Content = new PlayerMailContentSyncWrapper();
				}
				input.ReadMessage(Content);
				break;
			}
		}
	}
}
