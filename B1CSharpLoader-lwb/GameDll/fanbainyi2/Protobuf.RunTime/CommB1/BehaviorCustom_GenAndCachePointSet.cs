using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class BehaviorCustom_GenAndCachePointSet : IMessage<BehaviorCustom_GenAndCachePointSet>, IMessage, IEquatable<BehaviorCustom_GenAndCachePointSet>, IDeepCloneable<BehaviorCustom_GenAndCachePointSet>
{
	private static readonly MessageParser<BehaviorCustom_GenAndCachePointSet> _parser = new MessageParser<BehaviorCustom_GenAndCachePointSet>(() => new BehaviorCustom_GenAndCachePointSet());

	private UnknownFieldSet _unknownFields;

	private int genType_;

	private string eqsPath_ = "";

	private string sceneItemTag_ = "";

	private int explodeDesiredNum_;

	private float explodeLineTraceMaxLength_;

	private int explodeTraceTypeQuery_;

	private float explodePointMinBetween_;

	private float explodeRangeDirXMin_;

	private int explodeRangeDirXMinRangeType_;

	private float explodeRangeDirXMax_;

	private int explodeRangeDirXMaxRangeType_;

	private float explodeRangeDirYMin_;

	private int explodeRangeDirYMinRangeType_;

	private float explodeRangeDirYMax_;

	private int explodeRangeDirYMaxRangeType_;

	private float explodeRangeDirZMin_;

	private int explodeRangeDirZMinRangeType_;

	private float explodeRangeDirZMax_;

	private int explodeRangeDirZMaxRangeType_;

	private int registerId_;

	private string socketName_ = "";

	public static MessageParser<BehaviorCustom_GenAndCachePointSet> Parser => _parser;

	public int GenType
	{
		get
		{
			return genType_;
		}
		set
		{
			genType_ = value;
		}
	}

	public string EqsPath
	{
		get
		{
			return eqsPath_;
		}
		set
		{
			eqsPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string SceneItemTag
	{
		get
		{
			return sceneItemTag_;
		}
		set
		{
			sceneItemTag_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int ExplodeDesiredNum
	{
		get
		{
			return explodeDesiredNum_;
		}
		set
		{
			explodeDesiredNum_ = value;
		}
	}

	public float ExplodeLineTraceMaxLength
	{
		get
		{
			return explodeLineTraceMaxLength_;
		}
		set
		{
			explodeLineTraceMaxLength_ = value;
		}
	}

	public int ExplodeTraceTypeQuery
	{
		get
		{
			return explodeTraceTypeQuery_;
		}
		set
		{
			explodeTraceTypeQuery_ = value;
		}
	}

	public float ExplodePointMinBetween
	{
		get
		{
			return explodePointMinBetween_;
		}
		set
		{
			explodePointMinBetween_ = value;
		}
	}

	public float ExplodeRangeDirXMin
	{
		get
		{
			return explodeRangeDirXMin_;
		}
		set
		{
			explodeRangeDirXMin_ = value;
		}
	}

	public int ExplodeRangeDirXMinRangeType
	{
		get
		{
			return explodeRangeDirXMinRangeType_;
		}
		set
		{
			explodeRangeDirXMinRangeType_ = value;
		}
	}

	public float ExplodeRangeDirXMax
	{
		get
		{
			return explodeRangeDirXMax_;
		}
		set
		{
			explodeRangeDirXMax_ = value;
		}
	}

	public int ExplodeRangeDirXMaxRangeType
	{
		get
		{
			return explodeRangeDirXMaxRangeType_;
		}
		set
		{
			explodeRangeDirXMaxRangeType_ = value;
		}
	}

	public float ExplodeRangeDirYMin
	{
		get
		{
			return explodeRangeDirYMin_;
		}
		set
		{
			explodeRangeDirYMin_ = value;
		}
	}

	public int ExplodeRangeDirYMinRangeType
	{
		get
		{
			return explodeRangeDirYMinRangeType_;
		}
		set
		{
			explodeRangeDirYMinRangeType_ = value;
		}
	}

	public float ExplodeRangeDirYMax
	{
		get
		{
			return explodeRangeDirYMax_;
		}
		set
		{
			explodeRangeDirYMax_ = value;
		}
	}

	public int ExplodeRangeDirYMaxRangeType
	{
		get
		{
			return explodeRangeDirYMaxRangeType_;
		}
		set
		{
			explodeRangeDirYMaxRangeType_ = value;
		}
	}

	public float ExplodeRangeDirZMin
	{
		get
		{
			return explodeRangeDirZMin_;
		}
		set
		{
			explodeRangeDirZMin_ = value;
		}
	}

	public int ExplodeRangeDirZMinRangeType
	{
		get
		{
			return explodeRangeDirZMinRangeType_;
		}
		set
		{
			explodeRangeDirZMinRangeType_ = value;
		}
	}

	public float ExplodeRangeDirZMax
	{
		get
		{
			return explodeRangeDirZMax_;
		}
		set
		{
			explodeRangeDirZMax_ = value;
		}
	}

	public int ExplodeRangeDirZMaxRangeType
	{
		get
		{
			return explodeRangeDirZMaxRangeType_;
		}
		set
		{
			explodeRangeDirZMaxRangeType_ = value;
		}
	}

	public int RegisterId
	{
		get
		{
			return registerId_;
		}
		set
		{
			registerId_ = value;
		}
	}

	public string SocketName
	{
		get
		{
			return socketName_;
		}
		set
		{
			socketName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public BehaviorCustom_GenAndCachePointSet()
	{
	}

	public BehaviorCustom_GenAndCachePointSet(BehaviorCustom_GenAndCachePointSet other)
		: this()
	{
		genType_ = other.genType_;
		eqsPath_ = other.eqsPath_;
		sceneItemTag_ = other.sceneItemTag_;
		explodeDesiredNum_ = other.explodeDesiredNum_;
		explodeLineTraceMaxLength_ = other.explodeLineTraceMaxLength_;
		explodeTraceTypeQuery_ = other.explodeTraceTypeQuery_;
		explodePointMinBetween_ = other.explodePointMinBetween_;
		explodeRangeDirXMin_ = other.explodeRangeDirXMin_;
		explodeRangeDirXMinRangeType_ = other.explodeRangeDirXMinRangeType_;
		explodeRangeDirXMax_ = other.explodeRangeDirXMax_;
		explodeRangeDirXMaxRangeType_ = other.explodeRangeDirXMaxRangeType_;
		explodeRangeDirYMin_ = other.explodeRangeDirYMin_;
		explodeRangeDirYMinRangeType_ = other.explodeRangeDirYMinRangeType_;
		explodeRangeDirYMax_ = other.explodeRangeDirYMax_;
		explodeRangeDirYMaxRangeType_ = other.explodeRangeDirYMaxRangeType_;
		explodeRangeDirZMin_ = other.explodeRangeDirZMin_;
		explodeRangeDirZMinRangeType_ = other.explodeRangeDirZMinRangeType_;
		explodeRangeDirZMax_ = other.explodeRangeDirZMax_;
		explodeRangeDirZMaxRangeType_ = other.explodeRangeDirZMaxRangeType_;
		registerId_ = other.registerId_;
		socketName_ = other.socketName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BehaviorCustom_GenAndCachePointSet Clone()
	{
		return new BehaviorCustom_GenAndCachePointSet(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BehaviorCustom_GenAndCachePointSet);
	}

	public bool Equals(BehaviorCustom_GenAndCachePointSet other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GenType != other.GenType)
		{
			return false;
		}
		if (EqsPath != other.EqsPath)
		{
			return false;
		}
		if (SceneItemTag != other.SceneItemTag)
		{
			return false;
		}
		if (ExplodeDesiredNum != other.ExplodeDesiredNum)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ExplodeLineTraceMaxLength, other.ExplodeLineTraceMaxLength))
		{
			return false;
		}
		if (ExplodeTraceTypeQuery != other.ExplodeTraceTypeQuery)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ExplodePointMinBetween, other.ExplodePointMinBetween))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ExplodeRangeDirXMin, other.ExplodeRangeDirXMin))
		{
			return false;
		}
		if (ExplodeRangeDirXMinRangeType != other.ExplodeRangeDirXMinRangeType)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ExplodeRangeDirXMax, other.ExplodeRangeDirXMax))
		{
			return false;
		}
		if (ExplodeRangeDirXMaxRangeType != other.ExplodeRangeDirXMaxRangeType)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ExplodeRangeDirYMin, other.ExplodeRangeDirYMin))
		{
			return false;
		}
		if (ExplodeRangeDirYMinRangeType != other.ExplodeRangeDirYMinRangeType)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ExplodeRangeDirYMax, other.ExplodeRangeDirYMax))
		{
			return false;
		}
		if (ExplodeRangeDirYMaxRangeType != other.ExplodeRangeDirYMaxRangeType)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ExplodeRangeDirZMin, other.ExplodeRangeDirZMin))
		{
			return false;
		}
		if (ExplodeRangeDirZMinRangeType != other.ExplodeRangeDirZMinRangeType)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ExplodeRangeDirZMax, other.ExplodeRangeDirZMax))
		{
			return false;
		}
		if (ExplodeRangeDirZMaxRangeType != other.ExplodeRangeDirZMaxRangeType)
		{
			return false;
		}
		if (RegisterId != other.RegisterId)
		{
			return false;
		}
		if (SocketName != other.SocketName)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (GenType != 0)
		{
			num ^= GenType.GetHashCode();
		}
		if (EqsPath.Length != 0)
		{
			num ^= EqsPath.GetHashCode();
		}
		if (SceneItemTag.Length != 0)
		{
			num ^= SceneItemTag.GetHashCode();
		}
		if (ExplodeDesiredNum != 0)
		{
			num ^= ExplodeDesiredNum.GetHashCode();
		}
		if (ExplodeLineTraceMaxLength != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ExplodeLineTraceMaxLength);
		}
		if (ExplodeTraceTypeQuery != 0)
		{
			num ^= ExplodeTraceTypeQuery.GetHashCode();
		}
		if (ExplodePointMinBetween != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ExplodePointMinBetween);
		}
		if (ExplodeRangeDirXMin != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ExplodeRangeDirXMin);
		}
		if (ExplodeRangeDirXMinRangeType != 0)
		{
			num ^= ExplodeRangeDirXMinRangeType.GetHashCode();
		}
		if (ExplodeRangeDirXMax != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ExplodeRangeDirXMax);
		}
		if (ExplodeRangeDirXMaxRangeType != 0)
		{
			num ^= ExplodeRangeDirXMaxRangeType.GetHashCode();
		}
		if (ExplodeRangeDirYMin != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ExplodeRangeDirYMin);
		}
		if (ExplodeRangeDirYMinRangeType != 0)
		{
			num ^= ExplodeRangeDirYMinRangeType.GetHashCode();
		}
		if (ExplodeRangeDirYMax != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ExplodeRangeDirYMax);
		}
		if (ExplodeRangeDirYMaxRangeType != 0)
		{
			num ^= ExplodeRangeDirYMaxRangeType.GetHashCode();
		}
		if (ExplodeRangeDirZMin != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ExplodeRangeDirZMin);
		}
		if (ExplodeRangeDirZMinRangeType != 0)
		{
			num ^= ExplodeRangeDirZMinRangeType.GetHashCode();
		}
		if (ExplodeRangeDirZMax != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ExplodeRangeDirZMax);
		}
		if (ExplodeRangeDirZMaxRangeType != 0)
		{
			num ^= ExplodeRangeDirZMaxRangeType.GetHashCode();
		}
		if (RegisterId != 0)
		{
			num ^= RegisterId.GetHashCode();
		}
		if (SocketName.Length != 0)
		{
			num ^= SocketName.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (GenType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(GenType);
		}
		if (EqsPath.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(EqsPath);
		}
		if (SceneItemTag.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(SceneItemTag);
		}
		if (ExplodeDesiredNum != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ExplodeDesiredNum);
		}
		if (ExplodeLineTraceMaxLength != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(ExplodeLineTraceMaxLength);
		}
		if (ExplodeTraceTypeQuery != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(ExplodeTraceTypeQuery);
		}
		if (ExplodePointMinBetween != 0f)
		{
			output.WriteRawTag(61);
			output.WriteFloat(ExplodePointMinBetween);
		}
		if (ExplodeRangeDirXMin != 0f)
		{
			output.WriteRawTag(69);
			output.WriteFloat(ExplodeRangeDirXMin);
		}
		if (ExplodeRangeDirXMinRangeType != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(ExplodeRangeDirXMinRangeType);
		}
		if (ExplodeRangeDirXMax != 0f)
		{
			output.WriteRawTag(85);
			output.WriteFloat(ExplodeRangeDirXMax);
		}
		if (ExplodeRangeDirXMaxRangeType != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(ExplodeRangeDirXMaxRangeType);
		}
		if (ExplodeRangeDirYMin != 0f)
		{
			output.WriteRawTag(101);
			output.WriteFloat(ExplodeRangeDirYMin);
		}
		if (ExplodeRangeDirYMinRangeType != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(ExplodeRangeDirYMinRangeType);
		}
		if (ExplodeRangeDirYMax != 0f)
		{
			output.WriteRawTag(117);
			output.WriteFloat(ExplodeRangeDirYMax);
		}
		if (ExplodeRangeDirYMaxRangeType != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(ExplodeRangeDirYMaxRangeType);
		}
		if (ExplodeRangeDirZMin != 0f)
		{
			output.WriteRawTag(133, 1);
			output.WriteFloat(ExplodeRangeDirZMin);
		}
		if (ExplodeRangeDirZMinRangeType != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(ExplodeRangeDirZMinRangeType);
		}
		if (ExplodeRangeDirZMax != 0f)
		{
			output.WriteRawTag(149, 1);
			output.WriteFloat(ExplodeRangeDirZMax);
		}
		if (ExplodeRangeDirZMaxRangeType != 0)
		{
			output.WriteRawTag(152, 1);
			output.WriteInt32(ExplodeRangeDirZMaxRangeType);
		}
		if (RegisterId != 0)
		{
			output.WriteRawTag(160, 1);
			output.WriteInt32(RegisterId);
		}
		if (SocketName.Length != 0)
		{
			output.WriteRawTag(170, 1);
			output.WriteString(SocketName);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (GenType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GenType);
		}
		if (EqsPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EqsPath);
		}
		if (SceneItemTag.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SceneItemTag);
		}
		if (ExplodeDesiredNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ExplodeDesiredNum);
		}
		if (ExplodeLineTraceMaxLength != 0f)
		{
			num += 5;
		}
		if (ExplodeTraceTypeQuery != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ExplodeTraceTypeQuery);
		}
		if (ExplodePointMinBetween != 0f)
		{
			num += 5;
		}
		if (ExplodeRangeDirXMin != 0f)
		{
			num += 5;
		}
		if (ExplodeRangeDirXMinRangeType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ExplodeRangeDirXMinRangeType);
		}
		if (ExplodeRangeDirXMax != 0f)
		{
			num += 5;
		}
		if (ExplodeRangeDirXMaxRangeType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ExplodeRangeDirXMaxRangeType);
		}
		if (ExplodeRangeDirYMin != 0f)
		{
			num += 5;
		}
		if (ExplodeRangeDirYMinRangeType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ExplodeRangeDirYMinRangeType);
		}
		if (ExplodeRangeDirYMax != 0f)
		{
			num += 5;
		}
		if (ExplodeRangeDirYMaxRangeType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ExplodeRangeDirYMaxRangeType);
		}
		if (ExplodeRangeDirZMin != 0f)
		{
			num += 6;
		}
		if (ExplodeRangeDirZMinRangeType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ExplodeRangeDirZMinRangeType);
		}
		if (ExplodeRangeDirZMax != 0f)
		{
			num += 6;
		}
		if (ExplodeRangeDirZMaxRangeType != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ExplodeRangeDirZMaxRangeType);
		}
		if (RegisterId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(RegisterId);
		}
		if (SocketName.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(SocketName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BehaviorCustom_GenAndCachePointSet other)
	{
		if (other != null)
		{
			if (other.GenType != 0)
			{
				GenType = other.GenType;
			}
			if (other.EqsPath.Length != 0)
			{
				EqsPath = other.EqsPath;
			}
			if (other.SceneItemTag.Length != 0)
			{
				SceneItemTag = other.SceneItemTag;
			}
			if (other.ExplodeDesiredNum != 0)
			{
				ExplodeDesiredNum = other.ExplodeDesiredNum;
			}
			if (other.ExplodeLineTraceMaxLength != 0f)
			{
				ExplodeLineTraceMaxLength = other.ExplodeLineTraceMaxLength;
			}
			if (other.ExplodeTraceTypeQuery != 0)
			{
				ExplodeTraceTypeQuery = other.ExplodeTraceTypeQuery;
			}
			if (other.ExplodePointMinBetween != 0f)
			{
				ExplodePointMinBetween = other.ExplodePointMinBetween;
			}
			if (other.ExplodeRangeDirXMin != 0f)
			{
				ExplodeRangeDirXMin = other.ExplodeRangeDirXMin;
			}
			if (other.ExplodeRangeDirXMinRangeType != 0)
			{
				ExplodeRangeDirXMinRangeType = other.ExplodeRangeDirXMinRangeType;
			}
			if (other.ExplodeRangeDirXMax != 0f)
			{
				ExplodeRangeDirXMax = other.ExplodeRangeDirXMax;
			}
			if (other.ExplodeRangeDirXMaxRangeType != 0)
			{
				ExplodeRangeDirXMaxRangeType = other.ExplodeRangeDirXMaxRangeType;
			}
			if (other.ExplodeRangeDirYMin != 0f)
			{
				ExplodeRangeDirYMin = other.ExplodeRangeDirYMin;
			}
			if (other.ExplodeRangeDirYMinRangeType != 0)
			{
				ExplodeRangeDirYMinRangeType = other.ExplodeRangeDirYMinRangeType;
			}
			if (other.ExplodeRangeDirYMax != 0f)
			{
				ExplodeRangeDirYMax = other.ExplodeRangeDirYMax;
			}
			if (other.ExplodeRangeDirYMaxRangeType != 0)
			{
				ExplodeRangeDirYMaxRangeType = other.ExplodeRangeDirYMaxRangeType;
			}
			if (other.ExplodeRangeDirZMin != 0f)
			{
				ExplodeRangeDirZMin = other.ExplodeRangeDirZMin;
			}
			if (other.ExplodeRangeDirZMinRangeType != 0)
			{
				ExplodeRangeDirZMinRangeType = other.ExplodeRangeDirZMinRangeType;
			}
			if (other.ExplodeRangeDirZMax != 0f)
			{
				ExplodeRangeDirZMax = other.ExplodeRangeDirZMax;
			}
			if (other.ExplodeRangeDirZMaxRangeType != 0)
			{
				ExplodeRangeDirZMaxRangeType = other.ExplodeRangeDirZMaxRangeType;
			}
			if (other.RegisterId != 0)
			{
				RegisterId = other.RegisterId;
			}
			if (other.SocketName.Length != 0)
			{
				SocketName = other.SocketName;
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
				GenType = input.ReadInt32();
				break;
			case 18u:
				EqsPath = input.ReadString();
				break;
			case 26u:
				SceneItemTag = input.ReadString();
				break;
			case 32u:
				ExplodeDesiredNum = input.ReadInt32();
				break;
			case 45u:
				ExplodeLineTraceMaxLength = input.ReadFloat();
				break;
			case 48u:
				ExplodeTraceTypeQuery = input.ReadInt32();
				break;
			case 61u:
				ExplodePointMinBetween = input.ReadFloat();
				break;
			case 69u:
				ExplodeRangeDirXMin = input.ReadFloat();
				break;
			case 72u:
				ExplodeRangeDirXMinRangeType = input.ReadInt32();
				break;
			case 85u:
				ExplodeRangeDirXMax = input.ReadFloat();
				break;
			case 88u:
				ExplodeRangeDirXMaxRangeType = input.ReadInt32();
				break;
			case 101u:
				ExplodeRangeDirYMin = input.ReadFloat();
				break;
			case 104u:
				ExplodeRangeDirYMinRangeType = input.ReadInt32();
				break;
			case 117u:
				ExplodeRangeDirYMax = input.ReadFloat();
				break;
			case 120u:
				ExplodeRangeDirYMaxRangeType = input.ReadInt32();
				break;
			case 133u:
				ExplodeRangeDirZMin = input.ReadFloat();
				break;
			case 136u:
				ExplodeRangeDirZMinRangeType = input.ReadInt32();
				break;
			case 149u:
				ExplodeRangeDirZMax = input.ReadFloat();
				break;
			case 152u:
				ExplodeRangeDirZMaxRangeType = input.ReadInt32();
				break;
			case 160u:
				RegisterId = input.ReadInt32();
				break;
			case 170u:
				SocketName = input.ReadString();
				break;
			}
		}
	}
}
