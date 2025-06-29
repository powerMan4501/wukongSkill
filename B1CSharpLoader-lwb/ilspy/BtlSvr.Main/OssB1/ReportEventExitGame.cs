using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace OssB1;

public sealed class ReportEventExitGame : IMessage<ReportEventExitGame>, IMessage, IEquatable<ReportEventExitGame>, IDeepCloneable<ReportEventExitGame>
{
	private static readonly MessageParser<ReportEventExitGame> _parser = new MessageParser<ReportEventExitGame>(() => new ReportEventExitGame());

	private UnknownFieldSet _unknownFields;

	private ulong roleId_;

	private PlayerInfo player_;

	private static readonly FieldCodec<RecLen> _repeated_allRecs_codec = FieldCodec.ForMessage(26u, RecLen.Parser);

	private readonly RepeatedField<RecLen> allRecs_ = new RepeatedField<RecLen>();

	private ESettingExitType exitType_;

	private string settingInfo_ = "";

	public static MessageParser<ReportEventExitGame> Parser => _parser;

	public ulong RoleId
	{
		get
		{
			return roleId_;
		}
		set
		{
			roleId_ = value;
		}
	}

	public PlayerInfo Player
	{
		get
		{
			return player_;
		}
		set
		{
			player_ = value;
		}
	}

	public RepeatedField<RecLen> AllRecs => allRecs_;

	public ESettingExitType ExitType
	{
		get
		{
			return exitType_;
		}
		set
		{
			exitType_ = value;
		}
	}

	public string SettingInfo
	{
		get
		{
			return settingInfo_;
		}
		set
		{
			settingInfo_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ReportEventExitGame()
	{
	}

	public ReportEventExitGame(ReportEventExitGame other)
		: this()
	{
		roleId_ = other.roleId_;
		player_ = ((other.player_ != null) ? other.player_.Clone() : null);
		allRecs_ = other.allRecs_.Clone();
		exitType_ = other.exitType_;
		settingInfo_ = other.settingInfo_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportEventExitGame Clone()
	{
		return new ReportEventExitGame(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportEventExitGame);
	}

	public bool Equals(ReportEventExitGame other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoleId != other.RoleId)
		{
			return false;
		}
		if (!object.Equals(Player, other.Player))
		{
			return false;
		}
		if (!allRecs_.Equals(other.allRecs_))
		{
			return false;
		}
		if (ExitType != other.ExitType)
		{
			return false;
		}
		if (SettingInfo != other.SettingInfo)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (RoleId != 0L)
		{
			num ^= RoleId.GetHashCode();
		}
		if (player_ != null)
		{
			num ^= Player.GetHashCode();
		}
		num ^= allRecs_.GetHashCode();
		if (ExitType != ESettingExitType.BackToMainMeum)
		{
			num ^= ExitType.GetHashCode();
		}
		if (SettingInfo.Length != 0)
		{
			num ^= SettingInfo.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (RoleId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(RoleId);
		}
		if (player_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Player);
		}
		allRecs_.WriteTo(output, _repeated_allRecs_codec);
		if (ExitType != ESettingExitType.BackToMainMeum)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)ExitType);
		}
		if (SettingInfo.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(SettingInfo);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (RoleId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(RoleId);
		}
		if (player_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Player);
		}
		num += allRecs_.CalculateSize(_repeated_allRecs_codec);
		if (ExitType != ESettingExitType.BackToMainMeum)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ExitType);
		}
		if (SettingInfo.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SettingInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportEventExitGame other)
	{
		if (other == null)
		{
			return;
		}
		if (other.RoleId != 0L)
		{
			RoleId = other.RoleId;
		}
		if (other.player_ != null)
		{
			if (player_ == null)
			{
				Player = new PlayerInfo();
			}
			Player.MergeFrom(other.Player);
		}
		allRecs_.Add(other.allRecs_);
		if (other.ExitType != ESettingExitType.BackToMainMeum)
		{
			ExitType = other.ExitType;
		}
		if (other.SettingInfo.Length != 0)
		{
			SettingInfo = other.SettingInfo;
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
				RoleId = input.ReadUInt64();
				break;
			case 18u:
				if (player_ == null)
				{
					Player = new PlayerInfo();
				}
				input.ReadMessage(Player);
				break;
			case 26u:
				allRecs_.AddEntriesFrom(input, _repeated_allRecs_codec);
				break;
			case 32u:
				ExitType = (ESettingExitType)input.ReadEnum();
				break;
			case 42u:
				SettingInfo = input.ReadString();
				break;
			}
		}
	}
}
