using System;
using Google.Protobuf;

namespace CommB1;

public sealed class GamepadPrefab : IMessage<GamepadPrefab>, IMessage, IEquatable<GamepadPrefab>, IDeepCloneable<GamepadPrefab>
{
	private static readonly MessageParser<GamepadPrefab> _parser = new MessageParser<GamepadPrefab>(() => new GamepadPrefab());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int actionId_;

	private int idx_;

	public static MessageParser<GamepadPrefab> Parser => _parser;

	public int ActionId
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return actionId_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			actionId_ = value;
		}
	}

	public bool HasActionId => (_hasBits0 & 1) != 0;

	public int Idx
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return idx_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 2;
			idx_ = value;
		}
	}

	public bool HasIdx => (_hasBits0 & 2) != 0;

	public GamepadPrefab()
	{
	}

	public GamepadPrefab(GamepadPrefab other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		actionId_ = other.actionId_;
		idx_ = other.idx_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GamepadPrefab Clone()
	{
		return new GamepadPrefab(this);
	}

	public void ClearActionId()
	{
		_hasBits0 &= -2;
	}

	public void ClearIdx()
	{
		_hasBits0 &= -3;
	}

	public override bool Equals(object other)
	{
		return Equals(other as GamepadPrefab);
	}

	public bool Equals(GamepadPrefab other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ActionId != other.ActionId)
		{
			return false;
		}
		if (Idx != other.Idx)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasActionId)
		{
			num ^= ActionId.GetHashCode();
		}
		if (HasIdx)
		{
			num ^= Idx.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasActionId)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ActionId);
		}
		if (HasIdx)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Idx);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasActionId)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ActionId);
		}
		if (HasIdx)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Idx);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GamepadPrefab other)
	{
		if (other != null)
		{
			if (other.HasActionId)
			{
				ActionId = other.ActionId;
			}
			if (other.HasIdx)
			{
				Idx = other.Idx;
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
			case 8u:
				ActionId = input.ReadInt32();
				break;
			case 16u:
				Idx = input.ReadInt32();
				break;
			}
		}
	}
}
