using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace CommB1;

public sealed class ServerMailDataSyncWrapper : IMessage<ServerMailDataSyncWrapper>, IMessage, IEquatable<ServerMailDataSyncWrapper>, IDeepCloneable<ServerMailDataSyncWrapper>
{
	private static readonly MessageParser<ServerMailDataSyncWrapper> _parser = new MessageParser<ServerMailDataSyncWrapper>(() => new ServerMailDataSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Uint32SyncWrapper lastCheckTime_;

	private Uint32SyncWrapper seq_;

	private Uint64SyncWrapper maxId_;

	private YesNoTypeSyncWrapper isReady_;

	private static readonly FieldCodec<AwolMsgServerMailSyncWrapper> _repeated_mails_codec = FieldCodec.ForMessage(58u, AwolMsgServerMailSyncWrapper.Parser);

	private readonly RepeatedField<AwolMsgServerMailSyncWrapper> mails_ = new RepeatedField<AwolMsgServerMailSyncWrapper>();

	public static MessageParser<ServerMailDataSyncWrapper> Parser => _parser;

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

	public Uint32SyncWrapper LastCheckTime
	{
		get
		{
			return lastCheckTime_;
		}
		set
		{
			lastCheckTime_ = value;
		}
	}

	public Uint32SyncWrapper Seq
	{
		get
		{
			return seq_;
		}
		set
		{
			seq_ = value;
		}
	}

	public Uint64SyncWrapper MaxId
	{
		get
		{
			return maxId_;
		}
		set
		{
			maxId_ = value;
		}
	}

	public YesNoTypeSyncWrapper IsReady
	{
		get
		{
			return isReady_;
		}
		set
		{
			isReady_ = value;
		}
	}

	public RepeatedField<AwolMsgServerMailSyncWrapper> Mails => mails_;

	public ServerMailDataSyncWrapper()
	{
	}

	public ServerMailDataSyncWrapper(ServerMailDataSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		lastCheckTime_ = ((other.lastCheckTime_ != null) ? other.lastCheckTime_.Clone() : null);
		seq_ = ((other.seq_ != null) ? other.seq_.Clone() : null);
		maxId_ = ((other.maxId_ != null) ? other.maxId_.Clone() : null);
		isReady_ = ((other.isReady_ != null) ? other.isReady_.Clone() : null);
		mails_ = other.mails_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ServerMailDataSyncWrapper Clone()
	{
		return new ServerMailDataSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ServerMailDataSyncWrapper);
	}

	public bool Equals(ServerMailDataSyncWrapper other)
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
		if (!object.Equals(LastCheckTime, other.LastCheckTime))
		{
			return false;
		}
		if (!object.Equals(Seq, other.Seq))
		{
			return false;
		}
		if (!object.Equals(MaxId, other.MaxId))
		{
			return false;
		}
		if (!object.Equals(IsReady, other.IsReady))
		{
			return false;
		}
		if (!mails_.Equals(other.mails_))
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
		if (lastCheckTime_ != null)
		{
			num ^= LastCheckTime.GetHashCode();
		}
		if (seq_ != null)
		{
			num ^= Seq.GetHashCode();
		}
		if (maxId_ != null)
		{
			num ^= MaxId.GetHashCode();
		}
		if (isReady_ != null)
		{
			num ^= IsReady.GetHashCode();
		}
		num ^= mails_.GetHashCode();
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
		if (lastCheckTime_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(LastCheckTime);
		}
		if (seq_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Seq);
		}
		if (maxId_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(MaxId);
		}
		if (isReady_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(IsReady);
		}
		mails_.WriteTo(output, _repeated_mails_codec);
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
		if (lastCheckTime_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LastCheckTime);
		}
		if (seq_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Seq);
		}
		if (maxId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MaxId);
		}
		if (isReady_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IsReady);
		}
		num += mails_.CalculateSize(_repeated_mails_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ServerMailDataSyncWrapper other)
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
		if (other.lastCheckTime_ != null)
		{
			if (lastCheckTime_ == null)
			{
				LastCheckTime = new Uint32SyncWrapper();
			}
			LastCheckTime.MergeFrom(other.LastCheckTime);
		}
		if (other.seq_ != null)
		{
			if (seq_ == null)
			{
				Seq = new Uint32SyncWrapper();
			}
			Seq.MergeFrom(other.Seq);
		}
		if (other.maxId_ != null)
		{
			if (maxId_ == null)
			{
				MaxId = new Uint64SyncWrapper();
			}
			MaxId.MergeFrom(other.MaxId);
		}
		if (other.isReady_ != null)
		{
			if (isReady_ == null)
			{
				IsReady = new YesNoTypeSyncWrapper();
			}
			IsReady.MergeFrom(other.IsReady);
		}
		mails_.Add(other.mails_);
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
				if (lastCheckTime_ == null)
				{
					LastCheckTime = new Uint32SyncWrapper();
				}
				input.ReadMessage(LastCheckTime);
				break;
			case 34u:
				if (seq_ == null)
				{
					Seq = new Uint32SyncWrapper();
				}
				input.ReadMessage(Seq);
				break;
			case 42u:
				if (maxId_ == null)
				{
					MaxId = new Uint64SyncWrapper();
				}
				input.ReadMessage(MaxId);
				break;
			case 50u:
				if (isReady_ == null)
				{
					IsReady = new YesNoTypeSyncWrapper();
				}
				input.ReadMessage(IsReady);
				break;
			case 58u:
				mails_.AddEntriesFrom(input, _repeated_mails_codec);
				break;
			}
		}
	}
}
