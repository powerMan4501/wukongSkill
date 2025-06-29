using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class LevelArchiveBaseData : IMessage<LevelArchiveBaseData>, IMessage, IEquatable<LevelArchiveBaseData>, IDeepCloneable<LevelArchiveBaseData>
{
	private static readonly MessageParser<LevelArchiveBaseData> _parser = new MessageParser<LevelArchiveBaseData>(() => new LevelArchiveBaseData());

	private UnknownFieldSet _unknownFields;

	private int mapId_;

	private LevelArchivePlayerData playerData_;

	private static readonly FieldCodec<DeadUnitData> _repeated_deadUnitData_codec = FieldCodec.ForMessage(26u, ArchiveB1.DeadUnitData.Parser);

	private readonly RepeatedField<DeadUnitData> deadUnitData_ = new RepeatedField<DeadUnitData>();

	public static MessageParser<LevelArchiveBaseData> Parser => _parser;

	public int MapId
	{
		get
		{
			return mapId_;
		}
		set
		{
			mapId_ = value;
		}
	}

	public LevelArchivePlayerData PlayerData
	{
		get
		{
			return playerData_;
		}
		set
		{
			playerData_ = value;
		}
	}

	public RepeatedField<DeadUnitData> DeadUnitData => deadUnitData_;

	public LevelArchiveBaseData()
	{
	}

	public LevelArchiveBaseData(LevelArchiveBaseData other)
		: this()
	{
		mapId_ = other.mapId_;
		playerData_ = ((other.playerData_ != null) ? other.playerData_.Clone() : null);
		deadUnitData_ = other.deadUnitData_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LevelArchiveBaseData Clone()
	{
		return new LevelArchiveBaseData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LevelArchiveBaseData);
	}

	public bool Equals(LevelArchiveBaseData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MapId != other.MapId)
		{
			return false;
		}
		if (!object.Equals(PlayerData, other.PlayerData))
		{
			return false;
		}
		if (!deadUnitData_.Equals(other.deadUnitData_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (MapId != 0)
		{
			num ^= MapId.GetHashCode();
		}
		if (playerData_ != null)
		{
			num ^= PlayerData.GetHashCode();
		}
		num ^= deadUnitData_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (MapId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(MapId);
		}
		if (playerData_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(PlayerData);
		}
		deadUnitData_.WriteTo(output, _repeated_deadUnitData_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (MapId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MapId);
		}
		if (playerData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PlayerData);
		}
		num += deadUnitData_.CalculateSize(_repeated_deadUnitData_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LevelArchiveBaseData other)
	{
		if (other == null)
		{
			return;
		}
		if (other.MapId != 0)
		{
			MapId = other.MapId;
		}
		if (other.playerData_ != null)
		{
			if (playerData_ == null)
			{
				PlayerData = new LevelArchivePlayerData();
			}
			PlayerData.MergeFrom(other.PlayerData);
		}
		deadUnitData_.Add(other.deadUnitData_);
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
				MapId = input.ReadInt32();
				break;
			case 18u:
				if (playerData_ == null)
				{
					PlayerData = new LevelArchivePlayerData();
				}
				input.ReadMessage(PlayerData);
				break;
			case 26u:
				deadUnitData_.AddEntriesFrom(input, _repeated_deadUnitData_codec);
				break;
			}
		}
	}
}
