using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class RoleGarden : IMessage<RoleGarden>, IMessage, IEquatable<RoleGarden>, IDeepCloneable<RoleGarden>
{
	private static readonly MessageParser<RoleGarden> _parser = new MessageParser<RoleGarden>(() => new RoleGarden());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<Crop> _repeated_cropList_codec = FieldCodec.ForMessage(10u, Crop.Parser);

	private readonly RepeatedField<Crop> cropList_ = new RepeatedField<Crop>();

	private float lastUpdateTime_;

	private float lastCollectTime_;

	public static MessageParser<RoleGarden> Parser => _parser;

	public RepeatedField<Crop> CropList => cropList_;

	public float LastUpdateTime
	{
		get
		{
			return lastUpdateTime_;
		}
		set
		{
			lastUpdateTime_ = value;
		}
	}

	public float LastCollectTime
	{
		get
		{
			return lastCollectTime_;
		}
		set
		{
			lastCollectTime_ = value;
		}
	}

	public RoleGarden()
	{
	}

	public RoleGarden(RoleGarden other)
		: this()
	{
		cropList_ = other.cropList_.Clone();
		lastUpdateTime_ = other.lastUpdateTime_;
		lastCollectTime_ = other.lastCollectTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleGarden Clone()
	{
		return new RoleGarden(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleGarden);
	}

	public bool Equals(RoleGarden other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cropList_.Equals(other.cropList_))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(LastUpdateTime, other.LastUpdateTime))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(LastCollectTime, other.LastCollectTime))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= cropList_.GetHashCode();
		if (LastUpdateTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(LastUpdateTime);
		}
		if (LastCollectTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(LastCollectTime);
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		cropList_.WriteTo(output, _repeated_cropList_codec);
		if (LastUpdateTime != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(LastUpdateTime);
		}
		if (LastCollectTime != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(LastCollectTime);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += cropList_.CalculateSize(_repeated_cropList_codec);
		if (LastUpdateTime != 0f)
		{
			num += 5;
		}
		if (LastCollectTime != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleGarden other)
	{
		if (other != null)
		{
			cropList_.Add(other.cropList_);
			if (other.LastUpdateTime != 0f)
			{
				LastUpdateTime = other.LastUpdateTime;
			}
			if (other.LastCollectTime != 0f)
			{
				LastCollectTime = other.LastCollectTime;
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
				cropList_.AddEntriesFrom(input, _repeated_cropList_codec);
				break;
			case 21u:
				LastUpdateTime = input.ReadFloat();
				break;
			case 29u:
				LastCollectTime = input.ReadFloat();
				break;
			}
		}
	}
}
