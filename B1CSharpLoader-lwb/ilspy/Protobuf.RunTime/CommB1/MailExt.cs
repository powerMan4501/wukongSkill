using System;
using Google.Protobuf;

namespace CommB1;

public sealed class MailExt : IMessage<MailExt>, IMessage, IEquatable<MailExt>, IDeepCloneable<MailExt>
{
	private static readonly MessageParser<MailExt> _parser = new MessageParser<MailExt>(() => new MailExt());

	private UnknownFieldSet _unknownFields;

	private ulong msgId_;

	private MailInnerType mailInnerType_;

	private ulong batchId_;

	private uint templId_;

	private MailTempParam funcParam_;

	private ForwardFuncType forwardFunc_;

	public static MessageParser<MailExt> Parser => _parser;

	public ulong MsgId
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

	public MailInnerType MailInnerType
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

	public ulong BatchId
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

	public uint TemplId
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

	public MailTempParam FuncParam
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

	public ForwardFuncType ForwardFunc
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

	public MailExt()
	{
	}

	public MailExt(MailExt other)
		: this()
	{
		msgId_ = other.msgId_;
		mailInnerType_ = other.mailInnerType_;
		batchId_ = other.batchId_;
		templId_ = other.templId_;
		funcParam_ = ((other.funcParam_ != null) ? other.funcParam_.Clone() : null);
		forwardFunc_ = other.forwardFunc_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MailExt Clone()
	{
		return new MailExt(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MailExt);
	}

	public bool Equals(MailExt other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MsgId != other.MsgId)
		{
			return false;
		}
		if (MailInnerType != other.MailInnerType)
		{
			return false;
		}
		if (BatchId != other.BatchId)
		{
			return false;
		}
		if (TemplId != other.TemplId)
		{
			return false;
		}
		if (!object.Equals(FuncParam, other.FuncParam))
		{
			return false;
		}
		if (ForwardFunc != other.ForwardFunc)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (MsgId != 0L)
		{
			num ^= MsgId.GetHashCode();
		}
		if (MailInnerType != MailInnerType.Default)
		{
			num ^= MailInnerType.GetHashCode();
		}
		if (BatchId != 0L)
		{
			num ^= BatchId.GetHashCode();
		}
		if (TemplId != 0)
		{
			num ^= TemplId.GetHashCode();
		}
		if (funcParam_ != null)
		{
			num ^= FuncParam.GetHashCode();
		}
		if (ForwardFunc != ForwardFuncType.None)
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
		if (MsgId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(MsgId);
		}
		if (MailInnerType != MailInnerType.Default)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)MailInnerType);
		}
		if (BatchId != 0L)
		{
			output.WriteRawTag(24);
			output.WriteUInt64(BatchId);
		}
		if (TemplId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(TemplId);
		}
		if (funcParam_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(FuncParam);
		}
		if (ForwardFunc != ForwardFuncType.None)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)ForwardFunc);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (MsgId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(MsgId);
		}
		if (MailInnerType != MailInnerType.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MailInnerType);
		}
		if (BatchId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(BatchId);
		}
		if (TemplId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TemplId);
		}
		if (funcParam_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FuncParam);
		}
		if (ForwardFunc != ForwardFuncType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ForwardFunc);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MailExt other)
	{
		if (other == null)
		{
			return;
		}
		if (other.MsgId != 0L)
		{
			MsgId = other.MsgId;
		}
		if (other.MailInnerType != MailInnerType.Default)
		{
			MailInnerType = other.MailInnerType;
		}
		if (other.BatchId != 0L)
		{
			BatchId = other.BatchId;
		}
		if (other.TemplId != 0)
		{
			TemplId = other.TemplId;
		}
		if (other.funcParam_ != null)
		{
			if (funcParam_ == null)
			{
				FuncParam = new MailTempParam();
			}
			FuncParam.MergeFrom(other.FuncParam);
		}
		if (other.ForwardFunc != ForwardFuncType.None)
		{
			ForwardFunc = other.ForwardFunc;
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
				MsgId = input.ReadUInt64();
				break;
			case 16u:
				MailInnerType = (MailInnerType)input.ReadEnum();
				break;
			case 24u:
				BatchId = input.ReadUInt64();
				break;
			case 32u:
				TemplId = input.ReadUInt32();
				break;
			case 42u:
				if (funcParam_ == null)
				{
					FuncParam = new MailTempParam();
				}
				input.ReadMessage(FuncParam);
				break;
			case 48u:
				ForwardFunc = (ForwardFuncType)input.ReadEnum();
				break;
			}
		}
	}
}
