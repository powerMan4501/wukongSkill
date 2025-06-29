using System;
using Google.Protobuf;

namespace OssB1;

public sealed class ReportEventInteract : IMessage<ReportEventInteract>, IMessage, IEquatable<ReportEventInteract>, IDeepCloneable<ReportEventInteract>
{
	private static readonly MessageParser<ReportEventInteract> _parser = new MessageParser<ReportEventInteract>(() => new ReportEventInteract());

	private UnknownFieldSet _unknownFields;

	private ulong roleId_;

	private PlayerInfo player_;

	private InteractType type_;

	private int interactId_;

	private int isFirst_;

	private int lastDur_;

	private string guid_ = "";

	public static MessageParser<ReportEventInteract> Parser => _parser;

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

	public InteractType Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	public int InteractId
	{
		get
		{
			return interactId_;
		}
		set
		{
			interactId_ = value;
		}
	}

	public int IsFirst
	{
		get
		{
			return isFirst_;
		}
		set
		{
			isFirst_ = value;
		}
	}

	public int LastDur
	{
		get
		{
			return lastDur_;
		}
		set
		{
			lastDur_ = value;
		}
	}

	public string Guid
	{
		get
		{
			return guid_;
		}
		set
		{
			guid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ReportEventInteract()
	{
	}

	public ReportEventInteract(ReportEventInteract other)
		: this()
	{
		roleId_ = other.roleId_;
		player_ = ((other.player_ != null) ? other.player_.Clone() : null);
		type_ = other.type_;
		interactId_ = other.interactId_;
		isFirst_ = other.isFirst_;
		lastDur_ = other.lastDur_;
		guid_ = other.guid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportEventInteract Clone()
	{
		return new ReportEventInteract(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportEventInteract);
	}

	public bool Equals(ReportEventInteract other)
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
		if (Type != other.Type)
		{
			return false;
		}
		if (InteractId != other.InteractId)
		{
			return false;
		}
		if (IsFirst != other.IsFirst)
		{
			return false;
		}
		if (LastDur != other.LastDur)
		{
			return false;
		}
		if (Guid != other.Guid)
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
		if (Type != InteractType.RevivePoint)
		{
			num ^= Type.GetHashCode();
		}
		if (InteractId != 0)
		{
			num ^= InteractId.GetHashCode();
		}
		if (IsFirst != 0)
		{
			num ^= IsFirst.GetHashCode();
		}
		if (LastDur != 0)
		{
			num ^= LastDur.GetHashCode();
		}
		if (Guid.Length != 0)
		{
			num ^= Guid.GetHashCode();
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
		if (Type != InteractType.RevivePoint)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)Type);
		}
		if (InteractId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(InteractId);
		}
		if (IsFirst != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(IsFirst);
		}
		if (LastDur != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(LastDur);
		}
		if (Guid.Length != 0)
		{
			output.WriteRawTag(58);
			output.WriteString(Guid);
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
		if (Type != InteractType.RevivePoint)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (InteractId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(InteractId);
		}
		if (IsFirst != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsFirst);
		}
		if (LastDur != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LastDur);
		}
		if (Guid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Guid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportEventInteract other)
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
		if (other.Type != InteractType.RevivePoint)
		{
			Type = other.Type;
		}
		if (other.InteractId != 0)
		{
			InteractId = other.InteractId;
		}
		if (other.IsFirst != 0)
		{
			IsFirst = other.IsFirst;
		}
		if (other.LastDur != 0)
		{
			LastDur = other.LastDur;
		}
		if (other.Guid.Length != 0)
		{
			Guid = other.Guid;
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
			case 24u:
				Type = (InteractType)input.ReadEnum();
				break;
			case 32u:
				InteractId = input.ReadInt32();
				break;
			case 40u:
				IsFirst = input.ReadInt32();
				break;
			case 48u:
				LastDur = input.ReadInt32();
				break;
			case 58u:
				Guid = input.ReadString();
				break;
			}
		}
	}
}
