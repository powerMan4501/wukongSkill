using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class LevelArchivePlayerData : IMessage<LevelArchivePlayerData>, IMessage, IEquatable<LevelArchivePlayerData>, IDeepCloneable<LevelArchivePlayerData>
{
	private static readonly MessageParser<LevelArchivePlayerData> _parser = new MessageParser<LevelArchivePlayerData>(() => new LevelArchivePlayerData());

	private UnknownFieldSet _unknownFields;

	private float playerPosX_;

	private float playerPosY_;

	private float playerPosZ_;

	private float playerPosPitch_;

	private float playerPosRoll_;

	private float playerPosYaw_;

	private static readonly FieldCodec<string> _repeated_requireLevelNames_codec = FieldCodec.ForString(58u);

	private readonly RepeatedField<string> requireLevelNames_ = new RepeatedField<string>();

	public static MessageParser<LevelArchivePlayerData> Parser => _parser;

	public float PlayerPosX
	{
		get
		{
			return playerPosX_;
		}
		set
		{
			playerPosX_ = value;
		}
	}

	public float PlayerPosY
	{
		get
		{
			return playerPosY_;
		}
		set
		{
			playerPosY_ = value;
		}
	}

	public float PlayerPosZ
	{
		get
		{
			return playerPosZ_;
		}
		set
		{
			playerPosZ_ = value;
		}
	}

	public float PlayerPosPitch
	{
		get
		{
			return playerPosPitch_;
		}
		set
		{
			playerPosPitch_ = value;
		}
	}

	public float PlayerPosRoll
	{
		get
		{
			return playerPosRoll_;
		}
		set
		{
			playerPosRoll_ = value;
		}
	}

	public float PlayerPosYaw
	{
		get
		{
			return playerPosYaw_;
		}
		set
		{
			playerPosYaw_ = value;
		}
	}

	public RepeatedField<string> RequireLevelNames => requireLevelNames_;

	public LevelArchivePlayerData()
	{
	}

	public LevelArchivePlayerData(LevelArchivePlayerData other)
		: this()
	{
		playerPosX_ = other.playerPosX_;
		playerPosY_ = other.playerPosY_;
		playerPosZ_ = other.playerPosZ_;
		playerPosPitch_ = other.playerPosPitch_;
		playerPosRoll_ = other.playerPosRoll_;
		playerPosYaw_ = other.playerPosYaw_;
		requireLevelNames_ = other.requireLevelNames_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LevelArchivePlayerData Clone()
	{
		return new LevelArchivePlayerData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LevelArchivePlayerData);
	}

	public bool Equals(LevelArchivePlayerData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PlayerPosX, other.PlayerPosX))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PlayerPosY, other.PlayerPosY))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PlayerPosZ, other.PlayerPosZ))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PlayerPosPitch, other.PlayerPosPitch))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PlayerPosRoll, other.PlayerPosRoll))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PlayerPosYaw, other.PlayerPosYaw))
		{
			return false;
		}
		if (!requireLevelNames_.Equals(other.requireLevelNames_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (PlayerPosX != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PlayerPosX);
		}
		if (PlayerPosY != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PlayerPosY);
		}
		if (PlayerPosZ != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PlayerPosZ);
		}
		if (PlayerPosPitch != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PlayerPosPitch);
		}
		if (PlayerPosRoll != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PlayerPosRoll);
		}
		if (PlayerPosYaw != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PlayerPosYaw);
		}
		num ^= requireLevelNames_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (PlayerPosX != 0f)
		{
			output.WriteRawTag(13);
			output.WriteFloat(PlayerPosX);
		}
		if (PlayerPosY != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(PlayerPosY);
		}
		if (PlayerPosZ != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(PlayerPosZ);
		}
		if (PlayerPosPitch != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(PlayerPosPitch);
		}
		if (PlayerPosRoll != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(PlayerPosRoll);
		}
		if (PlayerPosYaw != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(PlayerPosYaw);
		}
		requireLevelNames_.WriteTo(output, _repeated_requireLevelNames_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (PlayerPosX != 0f)
		{
			num += 5;
		}
		if (PlayerPosY != 0f)
		{
			num += 5;
		}
		if (PlayerPosZ != 0f)
		{
			num += 5;
		}
		if (PlayerPosPitch != 0f)
		{
			num += 5;
		}
		if (PlayerPosRoll != 0f)
		{
			num += 5;
		}
		if (PlayerPosYaw != 0f)
		{
			num += 5;
		}
		num += requireLevelNames_.CalculateSize(_repeated_requireLevelNames_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LevelArchivePlayerData other)
	{
		if (other != null)
		{
			if (other.PlayerPosX != 0f)
			{
				PlayerPosX = other.PlayerPosX;
			}
			if (other.PlayerPosY != 0f)
			{
				PlayerPosY = other.PlayerPosY;
			}
			if (other.PlayerPosZ != 0f)
			{
				PlayerPosZ = other.PlayerPosZ;
			}
			if (other.PlayerPosPitch != 0f)
			{
				PlayerPosPitch = other.PlayerPosPitch;
			}
			if (other.PlayerPosRoll != 0f)
			{
				PlayerPosRoll = other.PlayerPosRoll;
			}
			if (other.PlayerPosYaw != 0f)
			{
				PlayerPosYaw = other.PlayerPosYaw;
			}
			requireLevelNames_.Add(other.requireLevelNames_);
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
			case 13u:
				PlayerPosX = input.ReadFloat();
				break;
			case 21u:
				PlayerPosY = input.ReadFloat();
				break;
			case 29u:
				PlayerPosZ = input.ReadFloat();
				break;
			case 37u:
				PlayerPosPitch = input.ReadFloat();
				break;
			case 45u:
				PlayerPosRoll = input.ReadFloat();
				break;
			case 53u:
				PlayerPosYaw = input.ReadFloat();
				break;
			case 58u:
				requireLevelNames_.AddEntriesFrom(input, _repeated_requireLevelNames_codec);
				break;
			}
		}
	}
}
