using System;
using Google.Protobuf;

namespace OssB1;

public sealed class PlayerInfo : IMessage<PlayerInfo>, IMessage, IEquatable<PlayerInfo>, IDeepCloneable<PlayerInfo>
{
	private static readonly MessageParser<PlayerInfo> _parser = new MessageParser<PlayerInfo>(() => new PlayerInfo());

	private UnknownFieldSet _unknownFields;

	private PlayerInfoBattle battle_;

	private PlayerInfoRole role_;

	public static MessageParser<PlayerInfo> Parser => _parser;

	public PlayerInfoBattle Battle
	{
		get
		{
			return battle_;
		}
		set
		{
			battle_ = value;
		}
	}

	public PlayerInfoRole Role
	{
		get
		{
			return role_;
		}
		set
		{
			role_ = value;
		}
	}

	public PlayerInfo()
	{
	}

	public PlayerInfo(PlayerInfo other)
		: this()
	{
		battle_ = ((other.battle_ != null) ? other.battle_.Clone() : null);
		role_ = ((other.role_ != null) ? other.role_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PlayerInfo Clone()
	{
		return new PlayerInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PlayerInfo);
	}

	public bool Equals(PlayerInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Battle, other.Battle))
		{
			return false;
		}
		if (!object.Equals(Role, other.Role))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (battle_ != null)
		{
			num ^= Battle.GetHashCode();
		}
		if (role_ != null)
		{
			num ^= Role.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (battle_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Battle);
		}
		if (role_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Role);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (battle_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Battle);
		}
		if (role_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Role);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PlayerInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.battle_ != null)
		{
			if (battle_ == null)
			{
				Battle = new PlayerInfoBattle();
			}
			Battle.MergeFrom(other.Battle);
		}
		if (other.role_ != null)
		{
			if (role_ == null)
			{
				Role = new PlayerInfoRole();
			}
			Role.MergeFrom(other.Role);
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
			case 10u:
				if (battle_ == null)
				{
					Battle = new PlayerInfoBattle();
				}
				input.ReadMessage(Battle);
				break;
			case 18u:
				if (role_ == null)
				{
					Role = new PlayerInfoRole();
				}
				input.ReadMessage(Role);
				break;
			}
		}
	}
}
