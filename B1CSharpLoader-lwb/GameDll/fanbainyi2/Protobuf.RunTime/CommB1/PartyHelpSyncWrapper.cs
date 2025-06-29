using System;
using Google.Protobuf;
using ResB1;

namespace CommB1;

public sealed class PartyHelpSyncWrapper : IMessage<PartyHelpSyncWrapper>, IMessage, IEquatable<PartyHelpSyncWrapper>, IDeepCloneable<PartyHelpSyncWrapper>
{
	private static readonly MessageParser<PartyHelpSyncWrapper> _parser = new MessageParser<PartyHelpSyncWrapper>(() => new PartyHelpSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private PartyHelpStateSyncWrapper state_;

	private PartyHelpParamSyncWrapper helpParam_;

	private Uint32SyncWrapper createTime_;

	private Uint32SyncWrapper lastActivityTime_;

	public static MessageParser<PartyHelpSyncWrapper> Parser => _parser;

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

	public PartyHelpStateSyncWrapper State
	{
		get
		{
			return state_;
		}
		set
		{
			state_ = value;
		}
	}

	public PartyHelpParamSyncWrapper HelpParam
	{
		get
		{
			return helpParam_;
		}
		set
		{
			helpParam_ = value;
		}
	}

	public Uint32SyncWrapper CreateTime
	{
		get
		{
			return createTime_;
		}
		set
		{
			createTime_ = value;
		}
	}

	public Uint32SyncWrapper LastActivityTime
	{
		get
		{
			return lastActivityTime_;
		}
		set
		{
			lastActivityTime_ = value;
		}
	}

	public PartyHelpSyncWrapper()
	{
	}

	public PartyHelpSyncWrapper(PartyHelpSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		state_ = ((other.state_ != null) ? other.state_.Clone() : null);
		helpParam_ = ((other.helpParam_ != null) ? other.helpParam_.Clone() : null);
		createTime_ = ((other.createTime_ != null) ? other.createTime_.Clone() : null);
		lastActivityTime_ = ((other.lastActivityTime_ != null) ? other.lastActivityTime_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PartyHelpSyncWrapper Clone()
	{
		return new PartyHelpSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PartyHelpSyncWrapper);
	}

	public bool Equals(PartyHelpSyncWrapper other)
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
		if (!object.Equals(State, other.State))
		{
			return false;
		}
		if (!object.Equals(HelpParam, other.HelpParam))
		{
			return false;
		}
		if (!object.Equals(CreateTime, other.CreateTime))
		{
			return false;
		}
		if (!object.Equals(LastActivityTime, other.LastActivityTime))
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
		if (state_ != null)
		{
			num ^= State.GetHashCode();
		}
		if (helpParam_ != null)
		{
			num ^= HelpParam.GetHashCode();
		}
		if (createTime_ != null)
		{
			num ^= CreateTime.GetHashCode();
		}
		if (lastActivityTime_ != null)
		{
			num ^= LastActivityTime.GetHashCode();
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
		if (state_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(State);
		}
		if (helpParam_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(HelpParam);
		}
		if (createTime_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(CreateTime);
		}
		if (lastActivityTime_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(LastActivityTime);
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
		if (state_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(State);
		}
		if (helpParam_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HelpParam);
		}
		if (createTime_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CreateTime);
		}
		if (lastActivityTime_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LastActivityTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PartyHelpSyncWrapper other)
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
		if (other.state_ != null)
		{
			if (state_ == null)
			{
				State = new PartyHelpStateSyncWrapper();
			}
			State.MergeFrom(other.State);
		}
		if (other.helpParam_ != null)
		{
			if (helpParam_ == null)
			{
				HelpParam = new PartyHelpParamSyncWrapper();
			}
			HelpParam.MergeFrom(other.HelpParam);
		}
		if (other.createTime_ != null)
		{
			if (createTime_ == null)
			{
				CreateTime = new Uint32SyncWrapper();
			}
			CreateTime.MergeFrom(other.CreateTime);
		}
		if (other.lastActivityTime_ != null)
		{
			if (lastActivityTime_ == null)
			{
				LastActivityTime = new Uint32SyncWrapper();
			}
			LastActivityTime.MergeFrom(other.LastActivityTime);
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
				if (state_ == null)
				{
					State = new PartyHelpStateSyncWrapper();
				}
				input.ReadMessage(State);
				break;
			case 34u:
				if (helpParam_ == null)
				{
					HelpParam = new PartyHelpParamSyncWrapper();
				}
				input.ReadMessage(HelpParam);
				break;
			case 42u:
				if (createTime_ == null)
				{
					CreateTime = new Uint32SyncWrapper();
				}
				input.ReadMessage(CreateTime);
				break;
			case 50u:
				if (lastActivityTime_ == null)
				{
					LastActivityTime = new Uint32SyncWrapper();
				}
				input.ReadMessage(LastActivityTime);
				break;
			}
		}
	}
}
