using System;
using Google.Protobuf;
using ResB1;

namespace CommB1;

public sealed class MailExtSyncWrapper : IMessage<MailExtSyncWrapper>, IMessage, IEquatable<MailExtSyncWrapper>, IDeepCloneable<MailExtSyncWrapper>
{
	private static readonly MessageParser<MailExtSyncWrapper> _parser = new MessageParser<MailExtSyncWrapper>(() => new MailExtSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Uint64SyncWrapper msgId_;

	private MailInnerTypeSyncWrapper mailInnerType_;

	private Uint64SyncWrapper batchId_;

	private Uint32SyncWrapper templId_;

	private MailTempParamSyncWrapper funcParam_;

	private ForwardFuncTypeSyncWrapper forwardFunc_;

	public static MessageParser<MailExtSyncWrapper> Parser => _parser;

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

	public Uint64SyncWrapper MsgId
	{
		get
		{
			return msgId_;
		}
		set
		{
			msgId_ = value;
		}
	}

	public MailInnerTypeSyncWrapper MailInnerType
	{
		get
		{
			return mailInnerType_;
		}
		set
		{
			mailInnerType_ = value;
		}
	}

	public Uint64SyncWrapper BatchId
	{
		get
		{
			return batchId_;
		}
		set
		{
			batchId_ = value;
		}
	}

	public Uint32SyncWrapper TemplId
	{
		get
		{
			return templId_;
		}
		set
		{
			templId_ = value;
		}
	}

	public MailTempParamSyncWrapper FuncParam
	{
		get
		{
			return funcParam_;
		}
		set
		{
			funcParam_ = value;
		}
	}

	public ForwardFuncTypeSyncWrapper ForwardFunc
	{
		get
		{
			return forwardFunc_;
		}
		set
		{
			forwardFunc_ = value;
		}
	}

	public MailExtSyncWrapper()
	{
	}

	public MailExtSyncWrapper(MailExtSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		msgId_ = ((other.msgId_ != null) ? other.msgId_.Clone() : null);
		mailInnerType_ = ((other.mailInnerType_ != null) ? other.mailInnerType_.Clone() : null);
		batchId_ = ((other.batchId_ != null) ? other.batchId_.Clone() : null);
		templId_ = ((other.templId_ != null) ? other.templId_.Clone() : null);
		funcParam_ = ((other.funcParam_ != null) ? other.funcParam_.Clone() : null);
		forwardFunc_ = ((other.forwardFunc_ != null) ? other.forwardFunc_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MailExtSyncWrapper Clone()
	{
		return new MailExtSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MailExtSyncWrapper);
	}

	public bool Equals(MailExtSyncWrapper other)
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
		if (!object.Equals(MsgId, other.MsgId))
		{
			return false;
		}
		if (!object.Equals(MailInnerType, other.MailInnerType))
		{
			return false;
		}
		if (!object.Equals(BatchId, other.BatchId))
		{
			return false;
		}
		if (!object.Equals(TemplId, other.TemplId))
		{
			return false;
		}
		if (!object.Equals(FuncParam, other.FuncParam))
		{
			return false;
		}
		if (!object.Equals(ForwardFunc, other.ForwardFunc))
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
		if (msgId_ != null)
		{
			num ^= MsgId.GetHashCode();
		}
		if (mailInnerType_ != null)
		{
			num ^= MailInnerType.GetHashCode();
		}
		if (batchId_ != null)
		{
			num ^= BatchId.GetHashCode();
		}
		if (templId_ != null)
		{
			num ^= TemplId.GetHashCode();
		}
		if (funcParam_ != null)
		{
			num ^= FuncParam.GetHashCode();
		}
		if (forwardFunc_ != null)
		{
			num ^= ForwardFunc.GetHashCode();
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
		if (msgId_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(MsgId);
		}
		if (mailInnerType_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(MailInnerType);
		}
		if (batchId_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(BatchId);
		}
		if (templId_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(TemplId);
		}
		if (funcParam_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(FuncParam);
		}
		if (forwardFunc_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(ForwardFunc);
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
		if (msgId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MsgId);
		}
		if (mailInnerType_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MailInnerType);
		}
		if (batchId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BatchId);
		}
		if (templId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TemplId);
		}
		if (funcParam_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FuncParam);
		}
		if (forwardFunc_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ForwardFunc);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MailExtSyncWrapper other)
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
		if (other.msgId_ != null)
		{
			if (msgId_ == null)
			{
				MsgId = new Uint64SyncWrapper();
			}
			MsgId.MergeFrom(other.MsgId);
		}
		if (other.mailInnerType_ != null)
		{
			if (mailInnerType_ == null)
			{
				MailInnerType = new MailInnerTypeSyncWrapper();
			}
			MailInnerType.MergeFrom(other.MailInnerType);
		}
		if (other.batchId_ != null)
		{
			if (batchId_ == null)
			{
				BatchId = new Uint64SyncWrapper();
			}
			BatchId.MergeFrom(other.BatchId);
		}
		if (other.templId_ != null)
		{
			if (templId_ == null)
			{
				TemplId = new Uint32SyncWrapper();
			}
			TemplId.MergeFrom(other.TemplId);
		}
		if (other.funcParam_ != null)
		{
			if (funcParam_ == null)
			{
				FuncParam = new MailTempParamSyncWrapper();
			}
			FuncParam.MergeFrom(other.FuncParam);
		}
		if (other.forwardFunc_ != null)
		{
			if (forwardFunc_ == null)
			{
				ForwardFunc = new ForwardFuncTypeSyncWrapper();
			}
			ForwardFunc.MergeFrom(other.ForwardFunc);
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
				if (msgId_ == null)
				{
					MsgId = new Uint64SyncWrapper();
				}
				input.ReadMessage(MsgId);
				break;
			case 34u:
				if (mailInnerType_ == null)
				{
					MailInnerType = new MailInnerTypeSyncWrapper();
				}
				input.ReadMessage(MailInnerType);
				break;
			case 42u:
				if (batchId_ == null)
				{
					BatchId = new Uint64SyncWrapper();
				}
				input.ReadMessage(BatchId);
				break;
			case 50u:
				if (templId_ == null)
				{
					TemplId = new Uint32SyncWrapper();
				}
				input.ReadMessage(TemplId);
				break;
			case 58u:
				if (funcParam_ == null)
				{
					FuncParam = new MailTempParamSyncWrapper();
				}
				input.ReadMessage(FuncParam);
				break;
			case 66u:
				if (forwardFunc_ == null)
				{
					ForwardFunc = new ForwardFuncTypeSyncWrapper();
				}
				input.ReadMessage(ForwardFunc);
				break;
			}
		}
	}
}
