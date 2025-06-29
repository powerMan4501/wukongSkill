using System;
using Google.Protobuf;
using ResB1;

namespace CommB1;

public sealed class PartyHelpParamSyncWrapper : IMessage<PartyHelpParamSyncWrapper>, IMessage, IEquatable<PartyHelpParamSyncWrapper>, IDeepCloneable<PartyHelpParamSyncWrapper>
{
	private static readonly MessageParser<PartyHelpParamSyncWrapper> _parser = new MessageParser<PartyHelpParamSyncWrapper>(() => new PartyHelpParamSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Int32SyncWrapper dummy_;

	public static MessageParser<PartyHelpParamSyncWrapper> Parser => _parser;

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

	public Int32SyncWrapper Dummy
	{
		get
		{
			return dummy_;
		}
		set
		{
			dummy_ = value;
		}
	}

	public PartyHelpParamSyncWrapper()
	{
	}

	public PartyHelpParamSyncWrapper(PartyHelpParamSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		dummy_ = ((other.dummy_ != null) ? other.dummy_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PartyHelpParamSyncWrapper Clone()
	{
		return new PartyHelpParamSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PartyHelpParamSyncWrapper);
	}

	public bool Equals(PartyHelpParamSyncWrapper other)
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
		if (!object.Equals(Dummy, other.Dummy))
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
		if (dummy_ != null)
		{
			num ^= Dummy.GetHashCode();
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
		if (dummy_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Dummy);
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
		if (dummy_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Dummy);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PartyHelpParamSyncWrapper other)
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
		if (other.dummy_ != null)
		{
			if (dummy_ == null)
			{
				Dummy = new Int32SyncWrapper();
			}
			Dummy.MergeFrom(other.Dummy);
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
				if (dummy_ == null)
				{
					Dummy = new Int32SyncWrapper();
				}
				input.ReadMessage(Dummy);
				break;
			}
		}
	}
}
