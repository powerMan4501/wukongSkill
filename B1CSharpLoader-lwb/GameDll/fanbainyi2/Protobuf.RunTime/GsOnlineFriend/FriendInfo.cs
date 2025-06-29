using System;
using Google.Protobuf;

namespace GsOnlineFriend;

public sealed class FriendInfo : IMessage<FriendInfo>, IMessage, IEquatable<FriendInfo>, IDeepCloneable<FriendInfo>
{
	private static readonly MessageParser<FriendInfo> _parser = new MessageParser<FriendInfo>(() => new FriendInfo());

	private UnknownFieldSet _unknownFields;

	private string sessionId_ = "";

	private string displayName_ = "";

	private string realName_ = "";

	private bool online_;

	private bool playing_;

	private bool playingThisGame_;

	private bool joinable_;

	private bool voiceSupport_;

	private FriendStateType status_;

	public static MessageParser<FriendInfo> Parser => _parser;

	public string SessionId
	{
		get
		{
			return sessionId_;
		}
		set
		{
			sessionId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DisplayName
	{
		get
		{
			return displayName_;
		}
		set
		{
			displayName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string RealName
	{
		get
		{
			return realName_;
		}
		set
		{
			realName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool Online
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

	public bool Playing
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

	public bool PlayingThisGame
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

	public bool Joinable
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

	public bool VoiceSupport
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

	public FriendStateType Status
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

	public FriendInfo()
	{
	}

	public FriendInfo(FriendInfo other)
		: this()
	{
		sessionId_ = other.sessionId_;
		displayName_ = other.displayName_;
		realName_ = other.realName_;
		online_ = other.online_;
		playing_ = other.playing_;
		playingThisGame_ = other.playingThisGame_;
		joinable_ = other.joinable_;
		voiceSupport_ = other.voiceSupport_;
		status_ = other.status_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FriendInfo Clone()
	{
		return new FriendInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FriendInfo);
	}

	public bool Equals(FriendInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SessionId != other.SessionId)
		{
			return false;
		}
		if (DisplayName != other.DisplayName)
		{
			return false;
		}
		if (RealName != other.RealName)
		{
			return false;
		}
		if (Online != other.Online)
		{
			return false;
		}
		if (Playing != other.Playing)
		{
			return false;
		}
		if (PlayingThisGame != other.PlayingThisGame)
		{
			return false;
		}
		if (Joinable != other.Joinable)
		{
			return false;
		}
		if (VoiceSupport != other.VoiceSupport)
		{
			return false;
		}
		if (Status != other.Status)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SessionId.Length != 0)
		{
			num ^= SessionId.GetHashCode();
		}
		if (DisplayName.Length != 0)
		{
			num ^= DisplayName.GetHashCode();
		}
		if (RealName.Length != 0)
		{
			num ^= RealName.GetHashCode();
		}
		if (Online)
		{
			num ^= Online.GetHashCode();
		}
		if (Playing)
		{
			num ^= Playing.GetHashCode();
		}
		if (PlayingThisGame)
		{
			num ^= PlayingThisGame.GetHashCode();
		}
		if (Joinable)
		{
			num ^= Joinable.GetHashCode();
		}
		if (VoiceSupport)
		{
			num ^= VoiceSupport.GetHashCode();
		}
		if (Status != FriendStateType.Online)
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
		if (SessionId.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(SessionId);
		}
		if (DisplayName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(DisplayName);
		}
		if (RealName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(RealName);
		}
		if (Online)
		{
			output.WriteRawTag(32);
			output.WriteBool(Online);
		}
		if (Playing)
		{
			output.WriteRawTag(40);
			output.WriteBool(Playing);
		}
		if (PlayingThisGame)
		{
			output.WriteRawTag(48);
			output.WriteBool(PlayingThisGame);
		}
		if (Joinable)
		{
			output.WriteRawTag(56);
			output.WriteBool(Joinable);
		}
		if (VoiceSupport)
		{
			output.WriteRawTag(64);
			output.WriteBool(VoiceSupport);
		}
		if (Status != FriendStateType.Online)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)Status);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SessionId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SessionId);
		}
		if (DisplayName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DisplayName);
		}
		if (RealName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RealName);
		}
		if (Online)
		{
			num += 2;
		}
		if (Playing)
		{
			num += 2;
		}
		if (PlayingThisGame)
		{
			num += 2;
		}
		if (Joinable)
		{
			num += 2;
		}
		if (VoiceSupport)
		{
			num += 2;
		}
		if (Status != FriendStateType.Online)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FriendInfo other)
	{
		if (other != null)
		{
			if (other.SessionId.Length != 0)
			{
				SessionId = other.SessionId;
			}
			if (other.DisplayName.Length != 0)
			{
				DisplayName = other.DisplayName;
			}
			if (other.RealName.Length != 0)
			{
				RealName = other.RealName;
			}
			if (other.Online)
			{
				Online = other.Online;
			}
			if (other.Playing)
			{
				Playing = other.Playing;
			}
			if (other.PlayingThisGame)
			{
				PlayingThisGame = other.PlayingThisGame;
			}
			if (other.Joinable)
			{
				Joinable = other.Joinable;
			}
			if (other.VoiceSupport)
			{
				VoiceSupport = other.VoiceSupport;
			}
			if (other.Status != FriendStateType.Online)
			{
				Status = other.Status;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			case 10u:
				SessionId = input.ReadString();
				break;
			case 18u:
				DisplayName = input.ReadString();
				break;
			case 26u:
				RealName = input.ReadString();
				break;
			case 32u:
				Online = input.ReadBool();
				break;
			case 40u:
				Playing = input.ReadBool();
				break;
			case 48u:
				PlayingThisGame = input.ReadBool();
				break;
			case 56u:
				Joinable = input.ReadBool();
				break;
			case 64u:
				VoiceSupport = input.ReadBool();
				break;
			case 72u:
				Status = (FriendStateType)input.ReadEnum();
				break;
			}
		}
	}
}
