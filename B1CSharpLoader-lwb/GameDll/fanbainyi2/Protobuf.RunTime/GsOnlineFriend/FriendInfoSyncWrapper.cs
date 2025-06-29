using System;
using Google.Protobuf;

namespace GsOnlineFriend;

public sealed class FriendInfoSyncWrapper : IMessage<FriendInfoSyncWrapper>, IMessage, IEquatable<FriendInfoSyncWrapper>, IDeepCloneable<FriendInfoSyncWrapper>
{
	private static readonly MessageParser<FriendInfoSyncWrapper> _parser = new MessageParser<FriendInfoSyncWrapper>(() => new FriendInfoSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private StringSyncWrapper sessionId_;

	private StringSyncWrapper displayName_;

	private StringSyncWrapper realName_;

	private BoolSyncWrapper online_;

	private BoolSyncWrapper playing_;

	private BoolSyncWrapper playingThisGame_;

	private BoolSyncWrapper joinable_;

	private BoolSyncWrapper voiceSupport_;

	private FriendStateTypeSyncWrapper status_;

	public static MessageParser<FriendInfoSyncWrapper> Parser => _parser;

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

	public StringSyncWrapper SessionId
	{
		get
		{
			return sessionId_;
		}
		set
		{
			sessionId_ = value;
		}
	}

	public StringSyncWrapper DisplayName
	{
		get
		{
			return displayName_;
		}
		set
		{
			displayName_ = value;
		}
	}

	public StringSyncWrapper RealName
	{
		get
		{
			return realName_;
		}
		set
		{
			realName_ = value;
		}
	}

	public BoolSyncWrapper Online
	{
		get
		{
			return online_;
		}
		set
		{
			online_ = value;
		}
	}

	public BoolSyncWrapper Playing
	{
		get
		{
			return playing_;
		}
		set
		{
			playing_ = value;
		}
	}

	public BoolSyncWrapper PlayingThisGame
	{
		get
		{
			return playingThisGame_;
		}
		set
		{
			playingThisGame_ = value;
		}
	}

	public BoolSyncWrapper Joinable
	{
		get
		{
			return joinable_;
		}
		set
		{
			joinable_ = value;
		}
	}

	public BoolSyncWrapper VoiceSupport
	{
		get
		{
			return voiceSupport_;
		}
		set
		{
			voiceSupport_ = value;
		}
	}

	public FriendStateTypeSyncWrapper Status
	{
		get
		{
			return status_;
		}
		set
		{
			status_ = value;
		}
	}

	public FriendInfoSyncWrapper()
	{
	}

	public FriendInfoSyncWrapper(FriendInfoSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		sessionId_ = ((other.sessionId_ != null) ? other.sessionId_.Clone() : null);
		displayName_ = ((other.displayName_ != null) ? other.displayName_.Clone() : null);
		realName_ = ((other.realName_ != null) ? other.realName_.Clone() : null);
		online_ = ((other.online_ != null) ? other.online_.Clone() : null);
		playing_ = ((other.playing_ != null) ? other.playing_.Clone() : null);
		playingThisGame_ = ((other.playingThisGame_ != null) ? other.playingThisGame_.Clone() : null);
		joinable_ = ((other.joinable_ != null) ? other.joinable_.Clone() : null);
		voiceSupport_ = ((other.voiceSupport_ != null) ? other.voiceSupport_.Clone() : null);
		status_ = ((other.status_ != null) ? other.status_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FriendInfoSyncWrapper Clone()
	{
		return new FriendInfoSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FriendInfoSyncWrapper);
	}

	public bool Equals(FriendInfoSyncWrapper other)
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
		if (!object.Equals(SessionId, other.SessionId))
		{
			return false;
		}
		if (!object.Equals(DisplayName, other.DisplayName))
		{
			return false;
		}
		if (!object.Equals(RealName, other.RealName))
		{
			return false;
		}
		if (!object.Equals(Online, other.Online))
		{
			return false;
		}
		if (!object.Equals(Playing, other.Playing))
		{
			return false;
		}
		if (!object.Equals(PlayingThisGame, other.PlayingThisGame))
		{
			return false;
		}
		if (!object.Equals(Joinable, other.Joinable))
		{
			return false;
		}
		if (!object.Equals(VoiceSupport, other.VoiceSupport))
		{
			return false;
		}
		if (!object.Equals(Status, other.Status))
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
		if (sessionId_ != null)
		{
			num ^= SessionId.GetHashCode();
		}
		if (displayName_ != null)
		{
			num ^= DisplayName.GetHashCode();
		}
		if (realName_ != null)
		{
			num ^= RealName.GetHashCode();
		}
		if (online_ != null)
		{
			num ^= Online.GetHashCode();
		}
		if (playing_ != null)
		{
			num ^= Playing.GetHashCode();
		}
		if (playingThisGame_ != null)
		{
			num ^= PlayingThisGame.GetHashCode();
		}
		if (joinable_ != null)
		{
			num ^= Joinable.GetHashCode();
		}
		if (voiceSupport_ != null)
		{
			num ^= VoiceSupport.GetHashCode();
		}
		if (status_ != null)
		{
			num ^= Status.GetHashCode();
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
		if (sessionId_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(SessionId);
		}
		if (displayName_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(DisplayName);
		}
		if (realName_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(RealName);
		}
		if (online_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(Online);
		}
		if (playing_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(Playing);
		}
		if (playingThisGame_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(PlayingThisGame);
		}
		if (joinable_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(Joinable);
		}
		if (voiceSupport_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(VoiceSupport);
		}
		if (status_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(Status);
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
		if (sessionId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SessionId);
		}
		if (displayName_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DisplayName);
		}
		if (realName_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RealName);
		}
		if (online_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Online);
		}
		if (playing_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Playing);
		}
		if (playingThisGame_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PlayingThisGame);
		}
		if (joinable_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Joinable);
		}
		if (voiceSupport_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(VoiceSupport);
		}
		if (status_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Status);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FriendInfoSyncWrapper other)
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
		if (other.sessionId_ != null)
		{
			if (sessionId_ == null)
			{
				SessionId = new StringSyncWrapper();
			}
			SessionId.MergeFrom(other.SessionId);
		}
		if (other.displayName_ != null)
		{
			if (displayName_ == null)
			{
				DisplayName = new StringSyncWrapper();
			}
			DisplayName.MergeFrom(other.DisplayName);
		}
		if (other.realName_ != null)
		{
			if (realName_ == null)
			{
				RealName = new StringSyncWrapper();
			}
			RealName.MergeFrom(other.RealName);
		}
		if (other.online_ != null)
		{
			if (online_ == null)
			{
				Online = new BoolSyncWrapper();
			}
			Online.MergeFrom(other.Online);
		}
		if (other.playing_ != null)
		{
			if (playing_ == null)
			{
				Playing = new BoolSyncWrapper();
			}
			Playing.MergeFrom(other.Playing);
		}
		if (other.playingThisGame_ != null)
		{
			if (playingThisGame_ == null)
			{
				PlayingThisGame = new BoolSyncWrapper();
			}
			PlayingThisGame.MergeFrom(other.PlayingThisGame);
		}
		if (other.joinable_ != null)
		{
			if (joinable_ == null)
			{
				Joinable = new BoolSyncWrapper();
			}
			Joinable.MergeFrom(other.Joinable);
		}
		if (other.voiceSupport_ != null)
		{
			if (voiceSupport_ == null)
			{
				VoiceSupport = new BoolSyncWrapper();
			}
			VoiceSupport.MergeFrom(other.VoiceSupport);
		}
		if (other.status_ != null)
		{
			if (status_ == null)
			{
				Status = new FriendStateTypeSyncWrapper();
			}
			Status.MergeFrom(other.Status);
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
				if (sessionId_ == null)
				{
					SessionId = new StringSyncWrapper();
				}
				input.ReadMessage(SessionId);
				break;
			case 34u:
				if (displayName_ == null)
				{
					DisplayName = new StringSyncWrapper();
				}
				input.ReadMessage(DisplayName);
				break;
			case 42u:
				if (realName_ == null)
				{
					RealName = new StringSyncWrapper();
				}
				input.ReadMessage(RealName);
				break;
			case 50u:
				if (online_ == null)
				{
					Online = new BoolSyncWrapper();
				}
				input.ReadMessage(Online);
				break;
			case 58u:
				if (playing_ == null)
				{
					Playing = new BoolSyncWrapper();
				}
				input.ReadMessage(Playing);
				break;
			case 66u:
				if (playingThisGame_ == null)
				{
					PlayingThisGame = new BoolSyncWrapper();
				}
				input.ReadMessage(PlayingThisGame);
				break;
			case 74u:
				if (joinable_ == null)
				{
					Joinable = new BoolSyncWrapper();
				}
				input.ReadMessage(Joinable);
				break;
			case 82u:
				if (voiceSupport_ == null)
				{
					VoiceSupport = new BoolSyncWrapper();
				}
				input.ReadMessage(VoiceSupport);
				break;
			case 90u:
				if (status_ == null)
				{
					Status = new FriendStateTypeSyncWrapper();
				}
				input.ReadMessage(Status);
				break;
			}
		}
	}
}
