using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace OssB1;

public sealed class ReportEventDeleteArchive : IMessage<ReportEventDeleteArchive>, IMessage, IEquatable<ReportEventDeleteArchive>, IDeepCloneable<ReportEventDeleteArchive>
{
	private static readonly MessageParser<ReportEventDeleteArchive> _parser = new MessageParser<ReportEventDeleteArchive>(() => new ReportEventDeleteArchive());

	private UnknownFieldSet _unknownFields;

	private ulong roleId_;

	private PlayerInfo player_;

	private RecLen delRec_;

	private static readonly FieldCodec<RecLen> _repeated_allRecs_codec = FieldCodec.ForMessage(34u, RecLen.Parser);

	private readonly RepeatedField<RecLen> allRecs_ = new RepeatedField<RecLen>();

	private string settingInfo_ = "";

	private string reason_ = "";

	private string archiveType_ = "";

	public static MessageParser<ReportEventDeleteArchive> Parser => _parser;

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

	public RecLen DelRec
	{
		get
		{
			return delRec_;
		}
		set
		{
			delRec_ = value;
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

	public string Reason
	{
		get
		{
			return reason_;
		}
		set
		{
			reason_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ArchiveType
	{
		get
		{
			return archiveType_;
		}
		set
		{
			archiveType_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ReportEventDeleteArchive()
	{
	}

	public ReportEventDeleteArchive(ReportEventDeleteArchive other)
		: this()
	{
		roleId_ = other.roleId_;
		player_ = ((other.player_ != null) ? other.player_.Clone() : null);
		delRec_ = ((other.delRec_ != null) ? other.delRec_.Clone() : null);
		allRecs_ = other.allRecs_.Clone();
		settingInfo_ = other.settingInfo_;
		reason_ = other.reason_;
		archiveType_ = other.archiveType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportEventDeleteArchive Clone()
	{
		return new ReportEventDeleteArchive(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportEventDeleteArchive);
	}

	public bool Equals(ReportEventDeleteArchive other)
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
		if (!object.Equals(DelRec, other.DelRec))
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
		if (Reason != other.Reason)
		{
			return false;
		}
		if (ArchiveType != other.ArchiveType)
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
		if (delRec_ != null)
		{
			num ^= DelRec.GetHashCode();
		}
		num ^= allRecs_.GetHashCode();
		if (SettingInfo.Length != 0)
		{
			num ^= SettingInfo.GetHashCode();
		}
		if (Reason.Length != 0)
		{
			num ^= Reason.GetHashCode();
		}
		if (ArchiveType.Length != 0)
		{
			num ^= ArchiveType.GetHashCode();
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
		if (delRec_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(DelRec);
		}
		allRecs_.WriteTo(output, _repeated_allRecs_codec);
		if (SettingInfo.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(SettingInfo);
		}
		if (Reason.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(Reason);
		}
		if (ArchiveType.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(ArchiveType);
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
		if (delRec_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DelRec);
		}
		num += allRecs_.CalculateSize(_repeated_allRecs_codec);
		if (SettingInfo.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SettingInfo);
		}
		if (Reason.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Reason);
		}
		if (ArchiveType.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ArchiveType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportEventDeleteArchive other)
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
		if (other.delRec_ != null)
		{
			if (delRec_ == null)
			{
				DelRec = new RecLen();
			}
			DelRec.MergeFrom(other.DelRec);
		}
		allRecs_.Add(other.allRecs_);
		if (other.SettingInfo.Length != 0)
		{
			SettingInfo = other.SettingInfo;
		}
		if (other.Reason.Length != 0)
		{
			Reason = other.Reason;
		}
		if (other.ArchiveType.Length != 0)
		{
			ArchiveType = other.ArchiveType;
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
				if (delRec_ == null)
				{
					DelRec = new RecLen();
				}
				input.ReadMessage(DelRec);
				break;
			case 34u:
				allRecs_.AddEntriesFrom(input, _repeated_allRecs_codec);
				break;
			case 42u:
				SettingInfo = input.ReadString();
				break;
			case 50u:
				Reason = input.ReadString();
				break;
			case 58u:
				ArchiveType = input.ReadString();
				break;
			}
		}
	}
}
