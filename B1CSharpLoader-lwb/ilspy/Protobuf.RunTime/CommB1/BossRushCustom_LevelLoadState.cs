using System;
using Google.Protobuf;

namespace CommB1;

public sealed class BossRushCustom_LevelLoadState : IMessage<BossRushCustom_LevelLoadState>, IMessage, IEquatable<BossRushCustom_LevelLoadState>, IDeepCloneable<BossRushCustom_LevelLoadState>
{
	private static readonly MessageParser<BossRushCustom_LevelLoadState> _parser = new MessageParser<BossRushCustom_LevelLoadState>(() => new BossRushCustom_LevelLoadState());

	private UnknownFieldSet _unknownFields;

	private string levelName_ = "";

	private int loadState_;

	public static MessageParser<BossRushCustom_LevelLoadState> Parser => _parser;

	public string LevelName
	{
		get
		{
			return levelName_;
		}
		set
		{
			levelName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int LoadState
	{
		get
		{
			return loadState_;
		}
		set
		{
			loadState_ = value;
		}
	}

	public BossRushCustom_LevelLoadState()
	{
	}

	public BossRushCustom_LevelLoadState(BossRushCustom_LevelLoadState other)
		: this()
	{
		levelName_ = other.levelName_;
		loadState_ = other.loadState_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossRushCustom_LevelLoadState Clone()
	{
		return new BossRushCustom_LevelLoadState(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossRushCustom_LevelLoadState);
	}

	public bool Equals(BossRushCustom_LevelLoadState other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LevelName != other.LevelName)
		{
			return false;
		}
		if (LoadState != other.LoadState)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (LevelName.Length != 0)
		{
			num ^= LevelName.GetHashCode();
		}
		if (LoadState != 0)
		{
			num ^= LoadState.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (LevelName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(LevelName);
		}
		if (LoadState != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(LoadState);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (LevelName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LevelName);
		}
		if (LoadState != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LoadState);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BossRushCustom_LevelLoadState other)
	{
		if (other != null)
		{
			if (other.LevelName.Length != 0)
			{
				LevelName = other.LevelName;
			}
			if (other.LoadState != 0)
			{
				LoadState = other.LoadState;
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
				LevelName = input.ReadString();
				break;
			case 16u:
				LoadState = input.ReadInt32();
				break;
			}
		}
	}
}
