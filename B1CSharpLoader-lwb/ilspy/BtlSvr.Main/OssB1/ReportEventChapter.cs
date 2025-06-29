using System;
using Google.Protobuf;

namespace OssB1;

public sealed class ReportEventChapter : IMessage<ReportEventChapter>, IMessage, IEquatable<ReportEventChapter>, IDeepCloneable<ReportEventChapter>
{
	private static readonly MessageParser<ReportEventChapter> _parser = new MessageParser<ReportEventChapter>(() => new ReportEventChapter());

	private UnknownFieldSet _unknownFields;

	private ulong roleId_;

	private int chapterId_;

	private PlayerInfo player_;

	private int dieTimes_;

	public static MessageParser<ReportEventChapter> Parser => _parser;

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

	public int ChapterId
	{
		get
		{
			return chapterId_;
		}
		set
		{
			chapterId_ = value;
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

	public int DieTimes
	{
		get
		{
			return dieTimes_;
		}
		set
		{
			dieTimes_ = value;
		}
	}

	public ReportEventChapter()
	{
	}

	public ReportEventChapter(ReportEventChapter other)
		: this()
	{
		roleId_ = other.roleId_;
		chapterId_ = other.chapterId_;
		player_ = ((other.player_ != null) ? other.player_.Clone() : null);
		dieTimes_ = other.dieTimes_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportEventChapter Clone()
	{
		return new ReportEventChapter(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportEventChapter);
	}

	public bool Equals(ReportEventChapter other)
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
		if (ChapterId != other.ChapterId)
		{
			return false;
		}
		if (!object.Equals(Player, other.Player))
		{
			return false;
		}
		if (DieTimes != other.DieTimes)
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
		if (ChapterId != 0)
		{
			num ^= ChapterId.GetHashCode();
		}
		if (player_ != null)
		{
			num ^= Player.GetHashCode();
		}
		if (DieTimes != 0)
		{
			num ^= DieTimes.GetHashCode();
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
		if (ChapterId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ChapterId);
		}
		if (player_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Player);
		}
		if (DieTimes != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(DieTimes);
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
		if (ChapterId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChapterId);
		}
		if (player_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Player);
		}
		if (DieTimes != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DieTimes);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportEventChapter other)
	{
		if (other == null)
		{
			return;
		}
		if (other.RoleId != 0L)
		{
			RoleId = other.RoleId;
		}
		if (other.ChapterId != 0)
		{
			ChapterId = other.ChapterId;
		}
		if (other.player_ != null)
		{
			if (player_ == null)
			{
				Player = new PlayerInfo();
			}
			Player.MergeFrom(other.Player);
		}
		if (other.DieTimes != 0)
		{
			DieTimes = other.DieTimes;
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
			case 16u:
				ChapterId = input.ReadInt32();
				break;
			case 26u:
				if (player_ == null)
				{
					Player = new PlayerInfo();
				}
				input.ReadMessage(Player);
				break;
			case 32u:
				DieTimes = input.ReadInt32();
				break;
			}
		}
	}
}
