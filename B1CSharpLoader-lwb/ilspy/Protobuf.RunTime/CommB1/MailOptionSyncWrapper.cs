using System;
using Google.Protobuf;
using ResB1;

namespace CommB1;

public sealed class MailOptionSyncWrapper : IMessage<MailOptionSyncWrapper>, IMessage, IEquatable<MailOptionSyncWrapper>, IDeepCloneable<MailOptionSyncWrapper>
{
	private static readonly MessageParser<MailOptionSyncWrapper> _parser = new MessageParser<MailOptionSyncWrapper>(() => new MailOptionSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private MailFilterSyncWrapper filter_;

	private Uint32SyncWrapper expireTimestamp_;

	private Uint32SyncWrapper startTimestamp_;

	private Uint32SyncWrapper keepTime_;

	private Uint32SyncWrapper isFetchDelete_;

	public static MessageParser<MailOptionSyncWrapper> Parser => _parser;

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

	public MailFilterSyncWrapper Filter
	{
		get
		{
			return filter_;
		}
		set
		{
			filter_ = value;
		}
	}

	public Uint32SyncWrapper ExpireTimestamp
	{
		get
		{
			return expireTimestamp_;
		}
		set
		{
			expireTimestamp_ = value;
		}
	}

	public Uint32SyncWrapper StartTimestamp
	{
		get
		{
			return startTimestamp_;
		}
		set
		{
			startTimestamp_ = value;
		}
	}

	public Uint32SyncWrapper KeepTime
	{
		get
		{
			return keepTime_;
		}
		set
		{
			keepTime_ = value;
		}
	}

	public Uint32SyncWrapper IsFetchDelete
	{
		get
		{
			return isFetchDelete_;
		}
		set
		{
			isFetchDelete_ = value;
		}
	}

	public MailOptionSyncWrapper()
	{
	}

	public MailOptionSyncWrapper(MailOptionSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		filter_ = ((other.filter_ != null) ? other.filter_.Clone() : null);
		expireTimestamp_ = ((other.expireTimestamp_ != null) ? other.expireTimestamp_.Clone() : null);
		startTimestamp_ = ((other.startTimestamp_ != null) ? other.startTimestamp_.Clone() : null);
		keepTime_ = ((other.keepTime_ != null) ? other.keepTime_.Clone() : null);
		isFetchDelete_ = ((other.isFetchDelete_ != null) ? other.isFetchDelete_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MailOptionSyncWrapper Clone()
	{
		return new MailOptionSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MailOptionSyncWrapper);
	}

	public bool Equals(MailOptionSyncWrapper other)
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
		if (!object.Equals(Filter, other.Filter))
		{
			return false;
		}
		if (!object.Equals(ExpireTimestamp, other.ExpireTimestamp))
		{
			return false;
		}
		if (!object.Equals(StartTimestamp, other.StartTimestamp))
		{
			return false;
		}
		if (!object.Equals(KeepTime, other.KeepTime))
		{
			return false;
		}
		if (!object.Equals(IsFetchDelete, other.IsFetchDelete))
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
		if (filter_ != null)
		{
			num ^= Filter.GetHashCode();
		}
		if (expireTimestamp_ != null)
		{
			num ^= ExpireTimestamp.GetHashCode();
		}
		if (startTimestamp_ != null)
		{
			num ^= StartTimestamp.GetHashCode();
		}
		if (keepTime_ != null)
		{
			num ^= KeepTime.GetHashCode();
		}
		if (isFetchDelete_ != null)
		{
			num ^= IsFetchDelete.GetHashCode();
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
		if (filter_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Filter);
		}
		if (expireTimestamp_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(ExpireTimestamp);
		}
		if (startTimestamp_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(StartTimestamp);
		}
		if (keepTime_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(KeepTime);
		}
		if (isFetchDelete_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(IsFetchDelete);
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
		if (filter_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Filter);
		}
		if (expireTimestamp_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ExpireTimestamp);
		}
		if (startTimestamp_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(StartTimestamp);
		}
		if (keepTime_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KeepTime);
		}
		if (isFetchDelete_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IsFetchDelete);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MailOptionSyncWrapper other)
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
		if (other.filter_ != null)
		{
			if (filter_ == null)
			{
				Filter = new MailFilterSyncWrapper();
			}
			Filter.MergeFrom(other.Filter);
		}
		if (other.expireTimestamp_ != null)
		{
			if (expireTimestamp_ == null)
			{
				ExpireTimestamp = new Uint32SyncWrapper();
			}
			ExpireTimestamp.MergeFrom(other.ExpireTimestamp);
		}
		if (other.startTimestamp_ != null)
		{
			if (startTimestamp_ == null)
			{
				StartTimestamp = new Uint32SyncWrapper();
			}
			StartTimestamp.MergeFrom(other.StartTimestamp);
		}
		if (other.keepTime_ != null)
		{
			if (keepTime_ == null)
			{
				KeepTime = new Uint32SyncWrapper();
			}
			KeepTime.MergeFrom(other.KeepTime);
		}
		if (other.isFetchDelete_ != null)
		{
			if (isFetchDelete_ == null)
			{
				IsFetchDelete = new Uint32SyncWrapper();
			}
			IsFetchDelete.MergeFrom(other.IsFetchDelete);
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
				if (filter_ == null)
				{
					Filter = new MailFilterSyncWrapper();
				}
				input.ReadMessage(Filter);
				break;
			case 34u:
				if (expireTimestamp_ == null)
				{
					ExpireTimestamp = new Uint32SyncWrapper();
				}
				input.ReadMessage(ExpireTimestamp);
				break;
			case 42u:
				if (startTimestamp_ == null)
				{
					StartTimestamp = new Uint32SyncWrapper();
				}
				input.ReadMessage(StartTimestamp);
				break;
			case 50u:
				if (keepTime_ == null)
				{
					KeepTime = new Uint32SyncWrapper();
				}
				input.ReadMessage(KeepTime);
				break;
			case 58u:
				if (isFetchDelete_ == null)
				{
					IsFetchDelete = new Uint32SyncWrapper();
				}
				input.ReadMessage(IsFetchDelete);
				break;
			}
		}
	}
}
