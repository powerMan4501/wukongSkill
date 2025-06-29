using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStMapSymbolDesc : IMessage<FUStMapSymbolDesc>, IMessage, IEquatable<FUStMapSymbolDesc>, IDeepCloneable<FUStMapSymbolDesc>
{
	private static readonly MessageParser<FUStMapSymbolDesc> _parser = new MessageParser<FUStMapSymbolDesc>(() => new FUStMapSymbolDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private string guid_ = "";

	private string name_ = "";

	private EMapSymbolType type_;

	private int unlockRadius_;

	private int unlockHeight_;

	private float symbolPosX_;

	private float symbolPosY_;

	private float symbolPosZ_;

	private int localizationTag_;

	private int paramInt_;

	public static MessageParser<FUStMapSymbolDesc> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public string Guid
	{
		get
		{
			return guid_;
		}
		set
		{
			guid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EMapSymbolType Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	public int UnlockRadius
	{
		get
		{
			return unlockRadius_;
		}
		set
		{
			unlockRadius_ = value;
		}
	}

	public int UnlockHeight
	{
		get
		{
			return unlockHeight_;
		}
		set
		{
			unlockHeight_ = value;
		}
	}

	public float SymbolPosX
	{
		get
		{
			return symbolPosX_;
		}
		set
		{
			symbolPosX_ = value;
		}
	}

	public float SymbolPosY
	{
		get
		{
			return symbolPosY_;
		}
		set
		{
			symbolPosY_ = value;
		}
	}

	public float SymbolPosZ
	{
		get
		{
			return symbolPosZ_;
		}
		set
		{
			symbolPosZ_ = value;
		}
	}

	public int LocalizationTag
	{
		get
		{
			return localizationTag_;
		}
		set
		{
			localizationTag_ = value;
		}
	}

	public int ParamInt
	{
		get
		{
			return paramInt_;
		}
		set
		{
			paramInt_ = value;
		}
	}

	public FUStMapSymbolDesc()
	{
	}

	public FUStMapSymbolDesc(FUStMapSymbolDesc other)
		: this()
	{
		id_ = other.id_;
		guid_ = other.guid_;
		name_ = other.name_;
		type_ = other.type_;
		unlockRadius_ = other.unlockRadius_;
		unlockHeight_ = other.unlockHeight_;
		symbolPosX_ = other.symbolPosX_;
		symbolPosY_ = other.symbolPosY_;
		symbolPosZ_ = other.symbolPosZ_;
		localizationTag_ = other.localizationTag_;
		paramInt_ = other.paramInt_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStMapSymbolDesc Clone()
	{
		return new FUStMapSymbolDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStMapSymbolDesc);
	}

	public bool Equals(FUStMapSymbolDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (Guid != other.Guid)
		{
			return false;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (UnlockRadius != other.UnlockRadius)
		{
			return false;
		}
		if (UnlockHeight != other.UnlockHeight)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SymbolPosX, other.SymbolPosX))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SymbolPosY, other.SymbolPosY))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(SymbolPosZ, other.SymbolPosZ))
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
		{
			return false;
		}
		if (ParamInt != other.ParamInt)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Guid.Length != 0)
		{
			num ^= Guid.GetHashCode();
		}
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (Type != EMapSymbolType.Min)
		{
			num ^= Type.GetHashCode();
		}
		if (UnlockRadius != 0)
		{
			num ^= UnlockRadius.GetHashCode();
		}
		if (UnlockHeight != 0)
		{
			num ^= UnlockHeight.GetHashCode();
		}
		if (SymbolPosX != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SymbolPosX);
		}
		if (SymbolPosY != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SymbolPosY);
		}
		if (SymbolPosZ != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(SymbolPosZ);
		}
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
		}
		if (ParamInt != 0)
		{
			num ^= ParamInt.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (Guid.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Guid);
		}
		if (Name.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Name);
		}
		if (Type != EMapSymbolType.Min)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)Type);
		}
		if (UnlockRadius != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(UnlockRadius);
		}
		if (UnlockHeight != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(UnlockHeight);
		}
		if (SymbolPosX != 0f)
		{
			output.WriteRawTag(61);
			output.WriteFloat(SymbolPosX);
		}
		if (SymbolPosY != 0f)
		{
			output.WriteRawTag(69);
			output.WriteFloat(SymbolPosY);
		}
		if (SymbolPosZ != 0f)
		{
			output.WriteRawTag(77);
			output.WriteFloat(SymbolPosZ);
		}
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(LocalizationTag);
		}
		if (ParamInt != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(ParamInt);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (Guid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Guid);
		}
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (Type != EMapSymbolType.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (UnlockRadius != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnlockRadius);
		}
		if (UnlockHeight != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnlockHeight);
		}
		if (SymbolPosX != 0f)
		{
			num += 5;
		}
		if (SymbolPosY != 0f)
		{
			num += 5;
		}
		if (SymbolPosZ != 0f)
		{
			num += 5;
		}
		if (LocalizationTag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (ParamInt != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ParamInt);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStMapSymbolDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Guid.Length != 0)
			{
				Guid = other.Guid;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.Type != EMapSymbolType.Min)
			{
				Type = other.Type;
			}
			if (other.UnlockRadius != 0)
			{
				UnlockRadius = other.UnlockRadius;
			}
			if (other.UnlockHeight != 0)
			{
				UnlockHeight = other.UnlockHeight;
			}
			if (other.SymbolPosX != 0f)
			{
				SymbolPosX = other.SymbolPosX;
			}
			if (other.SymbolPosY != 0f)
			{
				SymbolPosY = other.SymbolPosY;
			}
			if (other.SymbolPosZ != 0f)
			{
				SymbolPosZ = other.SymbolPosZ;
			}
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
			}
			if (other.ParamInt != 0)
			{
				ParamInt = other.ParamInt;
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
				Id = input.ReadInt32();
				break;
			case 18u:
				Guid = input.ReadString();
				break;
			case 26u:
				Name = input.ReadString();
				break;
			case 32u:
				Type = (EMapSymbolType)input.ReadEnum();
				break;
			case 40u:
				UnlockRadius = input.ReadInt32();
				break;
			case 48u:
				UnlockHeight = input.ReadInt32();
				break;
			case 61u:
				SymbolPosX = input.ReadFloat();
				break;
			case 69u:
				SymbolPosY = input.ReadFloat();
				break;
			case 77u:
				SymbolPosZ = input.ReadFloat();
				break;
			case 80u:
				LocalizationTag = input.ReadInt32();
				break;
			case 88u:
				ParamInt = input.ReadInt32();
				break;
			}
		}
	}
}
