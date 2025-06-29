using System;
using Google.Protobuf;
using ResB1;

namespace CommB1;

public sealed class MailTempParamSyncWrapper : IMessage<MailTempParamSyncWrapper>, IMessage, IEquatable<MailTempParamSyncWrapper>, IDeepCloneable<MailTempParamSyncWrapper>
{
	private static readonly MessageParser<MailTempParamSyncWrapper> _parser = new MessageParser<MailTempParamSyncWrapper>(() => new MailTempParamSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Int32SyncWrapper intParam1_;

	private Int32SyncWrapper intParam2_;

	public static MessageParser<MailTempParamSyncWrapper> Parser => _parser;

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

	public Int32SyncWrapper IntParam1
	{
		get
		{
			return intParam1_;
		}
		set
		{
			intParam1_ = value;
		}
	}

	public Int32SyncWrapper IntParam2
	{
		get
		{
			return intParam2_;
		}
		set
		{
			intParam2_ = value;
		}
	}

	public MailTempParamSyncWrapper()
	{
	}

	public MailTempParamSyncWrapper(MailTempParamSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		intParam1_ = ((other.intParam1_ != null) ? other.intParam1_.Clone() : null);
		intParam2_ = ((other.intParam2_ != null) ? other.intParam2_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MailTempParamSyncWrapper Clone()
	{
		return new MailTempParamSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MailTempParamSyncWrapper);
	}

	public bool Equals(MailTempParamSyncWrapper other)
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
		if (!object.Equals(IntParam1, other.IntParam1))
		{
			return false;
		}
		if (!object.Equals(IntParam2, other.IntParam2))
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
		if (intParam1_ != null)
		{
			num ^= IntParam1.GetHashCode();
		}
		if (intParam2_ != null)
		{
			num ^= IntParam2.GetHashCode();
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
		if (intParam1_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(IntParam1);
		}
		if (intParam2_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(IntParam2);
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
		if (intParam1_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IntParam1);
		}
		if (intParam2_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IntParam2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MailTempParamSyncWrapper other)
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
		if (other.intParam1_ != null)
		{
			if (intParam1_ == null)
			{
				IntParam1 = new Int32SyncWrapper();
			}
			IntParam1.MergeFrom(other.IntParam1);
		}
		if (other.intParam2_ != null)
		{
			if (intParam2_ == null)
			{
				IntParam2 = new Int32SyncWrapper();
			}
			IntParam2.MergeFrom(other.IntParam2);
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
				if (intParam1_ == null)
				{
					IntParam1 = new Int32SyncWrapper();
				}
				input.ReadMessage(IntParam1);
				break;
			case 34u:
				if (intParam2_ == null)
				{
					IntParam2 = new Int32SyncWrapper();
				}
				input.ReadMessage(IntParam2);
				break;
			}
		}
	}
}
