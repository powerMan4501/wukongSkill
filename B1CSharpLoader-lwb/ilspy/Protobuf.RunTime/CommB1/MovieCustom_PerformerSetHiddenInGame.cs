using System;
using Google.Protobuf;

namespace CommB1;

public sealed class MovieCustom_PerformerSetHiddenInGame : IMessage<MovieCustom_PerformerSetHiddenInGame>, IMessage, IEquatable<MovieCustom_PerformerSetHiddenInGame>, IDeepCloneable<MovieCustom_PerformerSetHiddenInGame>
{
	private static readonly MessageParser<MovieCustom_PerformerSetHiddenInGame> _parser = new MessageParser<MovieCustom_PerformerSetHiddenInGame>(() => new MovieCustom_PerformerSetHiddenInGame());

	private UnknownFieldSet _unknownFields;

	private string performerGuid_ = "";

	private bool hiddenInGame_;

	public static MessageParser<MovieCustom_PerformerSetHiddenInGame> Parser => _parser;

	public string PerformerGuid
	{
		get
		{
			return performerGuid_;
		}
		set
		{
			performerGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool HiddenInGame
	{
		get
		{
			return hiddenInGame_;
		}
		set
		{
			hiddenInGame_ = value;
		}
	}

	public MovieCustom_PerformerSetHiddenInGame()
	{
	}

	public MovieCustom_PerformerSetHiddenInGame(MovieCustom_PerformerSetHiddenInGame other)
		: this()
	{
		performerGuid_ = other.performerGuid_;
		hiddenInGame_ = other.hiddenInGame_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MovieCustom_PerformerSetHiddenInGame Clone()
	{
		return new MovieCustom_PerformerSetHiddenInGame(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MovieCustom_PerformerSetHiddenInGame);
	}

	public bool Equals(MovieCustom_PerformerSetHiddenInGame other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PerformerGuid != other.PerformerGuid)
		{
			return false;
		}
		if (HiddenInGame != other.HiddenInGame)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (PerformerGuid.Length != 0)
		{
			num ^= PerformerGuid.GetHashCode();
		}
		if (HiddenInGame)
		{
			num ^= HiddenInGame.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (PerformerGuid.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(PerformerGuid);
		}
		if (HiddenInGame)
		{
			output.WriteRawTag(16);
			output.WriteBool(HiddenInGame);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (PerformerGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PerformerGuid);
		}
		if (HiddenInGame)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MovieCustom_PerformerSetHiddenInGame other)
	{
		if (other != null)
		{
			if (other.PerformerGuid.Length != 0)
			{
				PerformerGuid = other.PerformerGuid;
			}
			if (other.HiddenInGame)
			{
				HiddenInGame = other.HiddenInGame;
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
				PerformerGuid = input.ReadString();
				break;
			case 16u:
				HiddenInGame = input.ReadBool();
				break;
			}
		}
	}
}
