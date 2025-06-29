using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace OssB1;

public sealed class ReportEventLoad : IMessage<ReportEventLoad>, IMessage, IEquatable<ReportEventLoad>, IDeepCloneable<ReportEventLoad>
{
	private static readonly MessageParser<ReportEventLoad> _parser = new MessageParser<ReportEventLoad>(() => new ReportEventLoad());

	private UnknownFieldSet _unknownFields;

	private ulong roleId_;

	private PlayerInfoRole playerInfoRole_;

	private static readonly FieldCodec<RecLen> _repeated_allRecs_codec = FieldCodec.ForMessage(26u, RecLen.Parser);

	private readonly RepeatedField<RecLen> allRecs_ = new RepeatedField<RecLen>();

	private string settingInfo_ = "";

	public static MessageParser<ReportEventLoad> Parser => _parser;

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

	public PlayerInfoRole PlayerInfoRole
	{
		get
		{
			return playerInfoRole_;
		}
		set
		{
			playerInfoRole_ = value;
		}
	}

	public RepeatedField<RecLen> AllRecs => allRecs_;

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

	public ReportEventLoad()
	{
	}

	public ReportEventLoad(ReportEventLoad other)
		: this()
	{
		roleId_ = other.roleId_;
		playerInfoRole_ = ((other.playerInfoRole_ != null) ? other.playerInfoRole_.Clone() : null);
		allRecs_ = other.allRecs_.Clone();
		settingInfo_ = other.settingInfo_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportEventLoad Clone()
	{
		return new ReportEventLoad(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportEventLoad);
	}

	public bool Equals(ReportEventLoad other)
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
		if (!object.Equals(PlayerInfoRole, other.PlayerInfoRole))
		{
			return false;
		}
		if (!allRecs_.Equals(other.allRecs_))
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
		if (playerInfoRole_ != null)
		{
			num ^= PlayerInfoRole.GetHashCode();
		}
		num ^= allRecs_.GetHashCode();
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
		if (playerInfoRole_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(PlayerInfoRole);
		}
		allRecs_.WriteTo(output, _repeated_allRecs_codec);
		if (SettingInfo.Length != 0)
		{
			output.WriteRawTag(34);
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
		if (playerInfoRole_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PlayerInfoRole);
		}
		num += allRecs_.CalculateSize(_repeated_allRecs_codec);
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

	public void MergeFrom(ReportEventLoad other)
	{
		if (other == null)
		{
			return;
		}
		if (other.RoleId != 0L)
		{
			RoleId = other.RoleId;
		}
		if (other.playerInfoRole_ != null)
		{
			if (playerInfoRole_ == null)
			{
				PlayerInfoRole = new PlayerInfoRole();
			}
			PlayerInfoRole.MergeFrom(other.PlayerInfoRole);
		}
		allRecs_.Add(other.allRecs_);
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
				if (playerInfoRole_ == null)
				{
					PlayerInfoRole = new PlayerInfoRole();
				}
				input.ReadMessage(PlayerInfoRole);
				break;
			case 26u:
				allRecs_.AddEntriesFrom(input, _repeated_allRecs_codec);
				break;
			case 34u:
				SettingInfo = input.ReadString();
				break;
			}
		}
	}
}
