using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsReplicate;

public sealed class MontageSyncData : IMessage<MontageSyncData>, IMessage, IEquatable<MontageSyncData>, IDeepCloneable<MontageSyncData>
{
	private static readonly MessageParser<MontageSyncData> _parser = new MessageParser<MontageSyncData>(() => new MontageSyncData());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private bool isPlayingMontage_;

	private string montagePath_;

	private float position_;

	public static MessageParser<MontageSyncData> Parser => _parser;

	public bool IsPlayingMontage
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return isPlayingMontage_;
			}
			return false;
		}
		set
		{
			_hasBits0 |= 1;
			isPlayingMontage_ = value;
		}
	}

	public bool HasIsPlayingMontage => (_hasBits0 & 1) != 0;

	public string MontagePath
	{
		get
		{
			return montagePath_ ?? "";
		}
		set
		{
			montagePath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool HasMontagePath => montagePath_ != null;

	public float Position
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return position_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 2;
			position_ = value;
		}
	}

	public bool HasPosition => (_hasBits0 & 2) != 0;

	public MontageSyncData()
	{
	}

	public MontageSyncData(MontageSyncData other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		isPlayingMontage_ = other.isPlayingMontage_;
		montagePath_ = other.montagePath_;
		position_ = other.position_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MontageSyncData Clone()
	{
		return new MontageSyncData(this);
	}

	public void ClearIsPlayingMontage()
	{
		_hasBits0 &= -2;
	}

	public void ClearMontagePath()
	{
		montagePath_ = null;
	}

	public void ClearPosition()
	{
		_hasBits0 &= -3;
	}

	public override bool Equals(object other)
	{
		return Equals(other as MontageSyncData);
	}

	public bool Equals(MontageSyncData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsPlayingMontage != other.IsPlayingMontage)
		{
			return false;
		}
		if (MontagePath != other.MontagePath)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Position, other.Position))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasIsPlayingMontage)
		{
			num ^= IsPlayingMontage.GetHashCode();
		}
		if (HasMontagePath)
		{
			num ^= MontagePath.GetHashCode();
		}
		if (HasPosition)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Position);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasIsPlayingMontage)
		{
			output.WriteRawTag(8);
			output.WriteBool(IsPlayingMontage);
		}
		if (HasMontagePath)
		{
			output.WriteRawTag(18);
			output.WriteString(MontagePath);
		}
		if (HasPosition)
		{
			output.WriteRawTag(29);
			output.WriteFloat(Position);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasIsPlayingMontage)
		{
			num += 2;
		}
		if (HasMontagePath)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MontagePath);
		}
		if (HasPosition)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MontageSyncData other)
	{
		if (other != null)
		{
			if (other.HasIsPlayingMontage)
			{
				IsPlayingMontage = other.IsPlayingMontage;
			}
			if (other.HasMontagePath)
			{
				MontagePath = other.MontagePath;
			}
			if (other.HasPosition)
			{
				Position = other.Position;
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
				IsPlayingMontage = input.ReadBool();
				break;
			case 18u:
				MontagePath = input.ReadString();
				break;
			case 29u:
				Position = input.ReadFloat();
				break;
			}
		}
	}
}
