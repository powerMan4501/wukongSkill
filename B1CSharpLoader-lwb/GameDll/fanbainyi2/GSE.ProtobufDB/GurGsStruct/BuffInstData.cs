using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsStruct;

public sealed class BuffInstData : IMessage<BuffInstData>, IMessage, IEquatable<BuffInstData>, IDeepCloneable<BuffInstData>
{
	private static readonly MessageParser<BuffInstData> _parser = new MessageParser<BuffInstData>(() => new BuffInstData());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int buffID_;

	private int layer_;

	private uint casterRef_;

	private float duration_;

	private int buffSourceType_;

	private static readonly FieldCodec<ListDeltaMsgFloat> _repeated_cachedFixFunctionReturnValues_codec = FieldCodec.ForMessage(50u, ListDeltaMsgFloat.Parser);

	private readonly RepeatedField<ListDeltaMsgFloat> cachedFixFunctionReturnValues_ = new RepeatedField<ListDeltaMsgFloat>();

	private static readonly FieldCodec<DictDeltaMsgEPropType_UInt> _repeated_propMgrHandleID_codec = FieldCodec.ForMessage(58u, DictDeltaMsgEPropType_UInt.Parser);

	private readonly RepeatedField<DictDeltaMsgEPropType_UInt> propMgrHandleID_ = new RepeatedField<DictDeltaMsgEPropType_UInt>();

	public static MessageParser<BuffInstData> Parser => _parser;

	public int BuffID
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return buffID_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			buffID_ = value;
		}
	}

	public bool HasBuffID => (_hasBits0 & 1) != 0;

	public int Layer
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return layer_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 2;
			layer_ = value;
		}
	}

	public bool HasLayer => (_hasBits0 & 2) != 0;

	public uint CasterRef
	{
		get
		{
			if ((_hasBits0 & 4) != 0)
			{
				return casterRef_;
			}
			return 0u;
		}
		set
		{
			_hasBits0 |= 4;
			casterRef_ = value;
		}
	}

	public bool HasCasterRef => (_hasBits0 & 4) != 0;

	public float Duration
	{
		get
		{
			if ((_hasBits0 & 8) != 0)
			{
				return duration_;
			}
			return 0f;
		}
		set
		{
			_hasBits0 |= 8;
			duration_ = value;
		}
	}

	public bool HasDuration => (_hasBits0 & 8) != 0;

	public int BuffSourceType
	{
		get
		{
			if ((_hasBits0 & 0x10) != 0)
			{
				return buffSourceType_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 16;
			buffSourceType_ = value;
		}
	}

	public bool HasBuffSourceType => (_hasBits0 & 0x10) != 0;

	public RepeatedField<ListDeltaMsgFloat> CachedFixFunctionReturnValues => cachedFixFunctionReturnValues_;

	public RepeatedField<DictDeltaMsgEPropType_UInt> PropMgrHandleID => propMgrHandleID_;

	public BuffInstData()
	{
	}

	public BuffInstData(BuffInstData other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		buffID_ = other.buffID_;
		layer_ = other.layer_;
		casterRef_ = other.casterRef_;
		duration_ = other.duration_;
		buffSourceType_ = other.buffSourceType_;
		cachedFixFunctionReturnValues_ = other.cachedFixFunctionReturnValues_.Clone();
		propMgrHandleID_ = other.propMgrHandleID_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BuffInstData Clone()
	{
		return new BuffInstData(this);
	}

	public void ClearBuffID()
	{
		_hasBits0 &= -2;
	}

	public void ClearLayer()
	{
		_hasBits0 &= -3;
	}

	public void ClearCasterRef()
	{
		_hasBits0 &= -5;
	}

	public void ClearDuration()
	{
		_hasBits0 &= -9;
	}

	public void ClearBuffSourceType()
	{
		_hasBits0 &= -17;
	}

	public override bool Equals(object other)
	{
		return Equals(other as BuffInstData);
	}

	public bool Equals(BuffInstData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BuffID != other.BuffID)
		{
			return false;
		}
		if (Layer != other.Layer)
		{
			return false;
		}
		if (CasterRef != other.CasterRef)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Duration, other.Duration))
		{
			return false;
		}
		if (BuffSourceType != other.BuffSourceType)
		{
			return false;
		}
		if (!cachedFixFunctionReturnValues_.Equals(other.cachedFixFunctionReturnValues_))
		{
			return false;
		}
		if (!propMgrHandleID_.Equals(other.propMgrHandleID_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasBuffID)
		{
			num ^= BuffID.GetHashCode();
		}
		if (HasLayer)
		{
			num ^= Layer.GetHashCode();
		}
		if (HasCasterRef)
		{
			num ^= CasterRef.GetHashCode();
		}
		if (HasDuration)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Duration);
		}
		if (HasBuffSourceType)
		{
			num ^= BuffSourceType.GetHashCode();
		}
		num ^= cachedFixFunctionReturnValues_.GetHashCode();
		num ^= propMgrHandleID_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasBuffID)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BuffID);
		}
		if (HasLayer)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Layer);
		}
		if (HasCasterRef)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(CasterRef);
		}
		if (HasDuration)
		{
			output.WriteRawTag(37);
			output.WriteFloat(Duration);
		}
		if (HasBuffSourceType)
		{
			output.WriteRawTag(40);
			output.WriteInt32(BuffSourceType);
		}
		cachedFixFunctionReturnValues_.WriteTo(output, _repeated_cachedFixFunctionReturnValues_codec);
		propMgrHandleID_.WriteTo(output, _repeated_propMgrHandleID_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasBuffID)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffID);
		}
		if (HasLayer)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Layer);
		}
		if (HasCasterRef)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CasterRef);
		}
		if (HasDuration)
		{
			num += 5;
		}
		if (HasBuffSourceType)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffSourceType);
		}
		num += cachedFixFunctionReturnValues_.CalculateSize(_repeated_cachedFixFunctionReturnValues_codec);
		num += propMgrHandleID_.CalculateSize(_repeated_propMgrHandleID_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BuffInstData other)
	{
		if (other != null)
		{
			if (other.HasBuffID)
			{
				BuffID = other.BuffID;
			}
			if (other.HasLayer)
			{
				Layer = other.Layer;
			}
			if (other.HasCasterRef)
			{
				CasterRef = other.CasterRef;
			}
			if (other.HasDuration)
			{
				Duration = other.Duration;
			}
			if (other.HasBuffSourceType)
			{
				BuffSourceType = other.BuffSourceType;
			}
			cachedFixFunctionReturnValues_.Add(other.cachedFixFunctionReturnValues_);
			propMgrHandleID_.Add(other.propMgrHandleID_);
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
				BuffID = input.ReadInt32();
				break;
			case 16u:
				Layer = input.ReadInt32();
				break;
			case 24u:
				CasterRef = input.ReadUInt32();
				break;
			case 37u:
				Duration = input.ReadFloat();
				break;
			case 40u:
				BuffSourceType = input.ReadInt32();
				break;
			case 50u:
				cachedFixFunctionReturnValues_.AddEntriesFrom(input, _repeated_cachedFixFunctionReturnValues_codec);
				break;
			case 58u:
				propMgrHandleID_.AddEntriesFrom(input, _repeated_propMgrHandleID_codec);
				break;
			}
		}
	}
}
