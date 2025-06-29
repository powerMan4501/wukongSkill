using System;
using Google.Protobuf;
using ResB1;

namespace CommB1;

public sealed class MailFilterSyncWrapper : IMessage<MailFilterSyncWrapper>, IMessage, IEquatable<MailFilterSyncWrapper>, IDeepCloneable<MailFilterSyncWrapper>
{
	private static readonly MessageParser<MailFilterSyncWrapper> _parser = new MessageParser<MailFilterSyncWrapper>(() => new MailFilterSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Uint32SyncWrapper minLv_;

	private Uint32SyncWrapper maxLv_;

	private Uint32SyncWrapper ltRegisTime_;

	private Uint32SyncWrapper gtRegisTime_;

	private Uint32SyncWrapper world_;

	public static MessageParser<MailFilterSyncWrapper> Parser => _parser;

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

	public Uint32SyncWrapper MinLv
	{
		get
		{
			return minLv_;
		}
		set
		{
			minLv_ = value;
		}
	}

	public Uint32SyncWrapper MaxLv
	{
		get
		{
			return maxLv_;
		}
		set
		{
			maxLv_ = value;
		}
	}

	public Uint32SyncWrapper LtRegisTime
	{
		get
		{
			return ltRegisTime_;
		}
		set
		{
			ltRegisTime_ = value;
		}
	}

	public Uint32SyncWrapper GtRegisTime
	{
		get
		{
			return gtRegisTime_;
		}
		set
		{
			gtRegisTime_ = value;
		}
	}

	public Uint32SyncWrapper World
	{
		get
		{
			return world_;
		}
		set
		{
			world_ = value;
		}
	}

	public MailFilterSyncWrapper()
	{
	}

	public MailFilterSyncWrapper(MailFilterSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		minLv_ = ((other.minLv_ != null) ? other.minLv_.Clone() : null);
		maxLv_ = ((other.maxLv_ != null) ? other.maxLv_.Clone() : null);
		ltRegisTime_ = ((other.ltRegisTime_ != null) ? other.ltRegisTime_.Clone() : null);
		gtRegisTime_ = ((other.gtRegisTime_ != null) ? other.gtRegisTime_.Clone() : null);
		world_ = ((other.world_ != null) ? other.world_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MailFilterSyncWrapper Clone()
	{
		return new MailFilterSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MailFilterSyncWrapper);
	}

	public bool Equals(MailFilterSyncWrapper other)
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
		if (!object.Equals(MinLv, other.MinLv))
		{
			return false;
		}
		if (!object.Equals(MaxLv, other.MaxLv))
		{
			return false;
		}
		if (!object.Equals(LtRegisTime, other.LtRegisTime))
		{
			return false;
		}
		if (!object.Equals(GtRegisTime, other.GtRegisTime))
		{
			return false;
		}
		if (!object.Equals(World, other.World))
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
		if (minLv_ != null)
		{
			num ^= MinLv.GetHashCode();
		}
		if (maxLv_ != null)
		{
			num ^= MaxLv.GetHashCode();
		}
		if (ltRegisTime_ != null)
		{
			num ^= LtRegisTime.GetHashCode();
		}
		if (gtRegisTime_ != null)
		{
			num ^= GtRegisTime.GetHashCode();
		}
		if (world_ != null)
		{
			num ^= World.GetHashCode();
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
		if (minLv_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(MinLv);
		}
		if (maxLv_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(MaxLv);
		}
		if (ltRegisTime_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(LtRegisTime);
		}
		if (gtRegisTime_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(GtRegisTime);
		}
		if (world_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(World);
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
		if (minLv_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MinLv);
		}
		if (maxLv_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MaxLv);
		}
		if (ltRegisTime_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LtRegisTime);
		}
		if (gtRegisTime_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GtRegisTime);
		}
		if (world_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(World);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MailFilterSyncWrapper other)
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
		if (other.minLv_ != null)
		{
			if (minLv_ == null)
			{
				MinLv = new Uint32SyncWrapper();
			}
			MinLv.MergeFrom(other.MinLv);
		}
		if (other.maxLv_ != null)
		{
			if (maxLv_ == null)
			{
				MaxLv = new Uint32SyncWrapper();
			}
			MaxLv.MergeFrom(other.MaxLv);
		}
		if (other.ltRegisTime_ != null)
		{
			if (ltRegisTime_ == null)
			{
				LtRegisTime = new Uint32SyncWrapper();
			}
			LtRegisTime.MergeFrom(other.LtRegisTime);
		}
		if (other.gtRegisTime_ != null)
		{
			if (gtRegisTime_ == null)
			{
				GtRegisTime = new Uint32SyncWrapper();
			}
			GtRegisTime.MergeFrom(other.GtRegisTime);
		}
		if (other.world_ != null)
		{
			if (world_ == null)
			{
				World = new Uint32SyncWrapper();
			}
			World.MergeFrom(other.World);
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
				if (minLv_ == null)
				{
					MinLv = new Uint32SyncWrapper();
				}
				input.ReadMessage(MinLv);
				break;
			case 34u:
				if (maxLv_ == null)
				{
					MaxLv = new Uint32SyncWrapper();
				}
				input.ReadMessage(MaxLv);
				break;
			case 42u:
				if (ltRegisTime_ == null)
				{
					LtRegisTime = new Uint32SyncWrapper();
				}
				input.ReadMessage(LtRegisTime);
				break;
			case 50u:
				if (gtRegisTime_ == null)
				{
					GtRegisTime = new Uint32SyncWrapper();
				}
				input.ReadMessage(GtRegisTime);
				break;
			case 58u:
				if (world_ == null)
				{
					World = new Uint32SyncWrapper();
				}
				input.ReadMessage(World);
				break;
			}
		}
	}
}
