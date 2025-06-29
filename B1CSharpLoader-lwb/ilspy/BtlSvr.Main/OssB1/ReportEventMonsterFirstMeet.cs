using System;
using Google.Protobuf;

namespace OssB1;

public sealed class ReportEventMonsterFirstMeet : IMessage<ReportEventMonsterFirstMeet>, IMessage, IEquatable<ReportEventMonsterFirstMeet>, IDeepCloneable<ReportEventMonsterFirstMeet>
{
	private static readonly MessageParser<ReportEventMonsterFirstMeet> _parser = new MessageParser<ReportEventMonsterFirstMeet>(() => new ReportEventMonsterFirstMeet());

	private UnknownFieldSet _unknownFields;

	private int extendId_;

	private string guid_ = "";

	private int quality_;

	private PlayerInfoBattle player_;

	public static MessageParser<ReportEventMonsterFirstMeet> Parser => _parser;

	public int ExtendId
	{
		get
		{
			return extendId_;
		}
		set
		{
			extendId_ = value;
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

	public int Quality
	{
		get
		{
			return quality_;
		}
		set
		{
			quality_ = value;
		}
	}

	public PlayerInfoBattle Player
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

	public ReportEventMonsterFirstMeet()
	{
	}

	public ReportEventMonsterFirstMeet(ReportEventMonsterFirstMeet other)
		: this()
	{
		extendId_ = other.extendId_;
		guid_ = other.guid_;
		quality_ = other.quality_;
		player_ = ((other.player_ != null) ? other.player_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportEventMonsterFirstMeet Clone()
	{
		return new ReportEventMonsterFirstMeet(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportEventMonsterFirstMeet);
	}

	public bool Equals(ReportEventMonsterFirstMeet other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ExtendId != other.ExtendId)
		{
			return false;
		}
		if (Guid != other.Guid)
		{
			return false;
		}
		if (Quality != other.Quality)
		{
			return false;
		}
		if (!object.Equals(Player, other.Player))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ExtendId != 0)
		{
			num ^= ExtendId.GetHashCode();
		}
		if (Guid.Length != 0)
		{
			num ^= Guid.GetHashCode();
		}
		if (Quality != 0)
		{
			num ^= Quality.GetHashCode();
		}
		if (player_ != null)
		{
			num ^= Player.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ExtendId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ExtendId);
		}
		if (Guid.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Guid);
		}
		if (Quality != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Quality);
		}
		if (player_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Player);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ExtendId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ExtendId);
		}
		if (Guid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Guid);
		}
		if (Quality != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Quality);
		}
		if (player_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Player);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportEventMonsterFirstMeet other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ExtendId != 0)
		{
			ExtendId = other.ExtendId;
		}
		if (other.Guid.Length != 0)
		{
			Guid = other.Guid;
		}
		if (other.Quality != 0)
		{
			Quality = other.Quality;
		}
		if (other.player_ != null)
		{
			if (player_ == null)
			{
				Player = new PlayerInfoBattle();
			}
			Player.MergeFrom(other.Player);
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
				ExtendId = input.ReadInt32();
				break;
			case 18u:
				Guid = input.ReadString();
				break;
			case 24u:
				Quality = input.ReadInt32();
				break;
			case 34u:
				if (player_ == null)
				{
					Player = new PlayerInfoBattle();
				}
				input.ReadMessage(Player);
				break;
			}
		}
	}
}
