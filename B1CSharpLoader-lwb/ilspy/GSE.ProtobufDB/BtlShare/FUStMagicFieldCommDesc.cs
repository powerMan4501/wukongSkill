using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class FUStMagicFieldCommDesc : IMessage<FUStMagicFieldCommDesc>, IMessage, IEquatable<FUStMagicFieldCommDesc>, IDeepCloneable<FUStMagicFieldCommDesc>
{
	private static readonly MessageParser<FUStMagicFieldCommDesc> _parser = new MessageParser<FUStMagicFieldCommDesc>(() => new FUStMagicFieldCommDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string magicBPTemplatePath_ = "";

	private EBGUMagicFieldGenType magicFieldGenType_;

	private EGSYesNo isDestroyWithCaster_;

	private float destroyTimer_;

	private EBulletOrMagicFieldMoveModeType magicFieldMoveModeType_;

	private static readonly FieldCodec<int> _repeated_attachBuffID_codec = FieldCodec.ForInt32(58u);

	private readonly RepeatedField<int> attachBuffID_ = new RepeatedField<int>();

	public static MessageParser<FUStMagicFieldCommDesc> Parser => _parser;

	public int ID
	{
		get
		{
			return iD_;
		}
		set
		{
			iD_ = value;
		}
	}

	public string MagicBPTemplatePath
	{
		get
		{
			return magicBPTemplatePath_;
		}
		set
		{
			magicBPTemplatePath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EBGUMagicFieldGenType MagicFieldGenType
	{
		get
		{
			return magicFieldGenType_;
		}
		set
		{
			magicFieldGenType_ = value;
		}
	}

	public EGSYesNo IsDestroyWithCaster
	{
		get
		{
			return isDestroyWithCaster_;
		}
		set
		{
			isDestroyWithCaster_ = value;
		}
	}

	public float DestroyTimer
	{
		get
		{
			return destroyTimer_;
		}
		set
		{
			destroyTimer_ = value;
		}
	}

	public EBulletOrMagicFieldMoveModeType MagicFieldMoveModeType
	{
		get
		{
			return magicFieldMoveModeType_;
		}
		set
		{
			magicFieldMoveModeType_ = value;
		}
	}

	public RepeatedField<int> AttachBuffID => attachBuffID_;

	public FUStMagicFieldCommDesc()
	{
	}

	public FUStMagicFieldCommDesc(FUStMagicFieldCommDesc other)
		: this()
	{
		iD_ = other.iD_;
		magicBPTemplatePath_ = other.magicBPTemplatePath_;
		magicFieldGenType_ = other.magicFieldGenType_;
		isDestroyWithCaster_ = other.isDestroyWithCaster_;
		destroyTimer_ = other.destroyTimer_;
		magicFieldMoveModeType_ = other.magicFieldMoveModeType_;
		attachBuffID_ = other.attachBuffID_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStMagicFieldCommDesc Clone()
	{
		return new FUStMagicFieldCommDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStMagicFieldCommDesc);
	}

	public bool Equals(FUStMagicFieldCommDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ID != other.ID)
		{
			return false;
		}
		if (MagicBPTemplatePath != other.MagicBPTemplatePath)
		{
			return false;
		}
		if (MagicFieldGenType != other.MagicFieldGenType)
		{
			return false;
		}
		if (IsDestroyWithCaster != other.IsDestroyWithCaster)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DestroyTimer, other.DestroyTimer))
		{
			return false;
		}
		if (MagicFieldMoveModeType != other.MagicFieldMoveModeType)
		{
			return false;
		}
		if (!attachBuffID_.Equals(other.attachBuffID_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ID != 0)
		{
			num ^= ID.GetHashCode();
		}
		if (MagicBPTemplatePath.Length != 0)
		{
			num ^= MagicBPTemplatePath.GetHashCode();
		}
		if (MagicFieldGenType != EBGUMagicFieldGenType.EbgumagicFieldGenTypeCaster)
		{
			num ^= MagicFieldGenType.GetHashCode();
		}
		if (IsDestroyWithCaster != EGSYesNo.No)
		{
			num ^= IsDestroyWithCaster.GetHashCode();
		}
		if (DestroyTimer != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DestroyTimer);
		}
		if (MagicFieldMoveModeType != EBulletOrMagicFieldMoveModeType.None)
		{
			num ^= MagicFieldMoveModeType.GetHashCode();
		}
		num ^= attachBuffID_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ID);
		}
		if (MagicBPTemplatePath.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(MagicBPTemplatePath);
		}
		if (MagicFieldGenType != EBGUMagicFieldGenType.EbgumagicFieldGenTypeCaster)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)MagicFieldGenType);
		}
		if (IsDestroyWithCaster != EGSYesNo.No)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)IsDestroyWithCaster);
		}
		if (DestroyTimer != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(DestroyTimer);
		}
		if (MagicFieldMoveModeType != EBulletOrMagicFieldMoveModeType.None)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)MagicFieldMoveModeType);
		}
		attachBuffID_.WriteTo(output, _repeated_attachBuffID_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ID);
		}
		if (MagicBPTemplatePath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MagicBPTemplatePath);
		}
		if (MagicFieldGenType != EBGUMagicFieldGenType.EbgumagicFieldGenTypeCaster)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MagicFieldGenType);
		}
		if (IsDestroyWithCaster != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsDestroyWithCaster);
		}
		if (DestroyTimer != 0f)
		{
			num += 5;
		}
		if (MagicFieldMoveModeType != EBulletOrMagicFieldMoveModeType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MagicFieldMoveModeType);
		}
		num += attachBuffID_.CalculateSize(_repeated_attachBuffID_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStMagicFieldCommDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.MagicBPTemplatePath.Length != 0)
			{
				MagicBPTemplatePath = other.MagicBPTemplatePath;
			}
			if (other.MagicFieldGenType != EBGUMagicFieldGenType.EbgumagicFieldGenTypeCaster)
			{
				MagicFieldGenType = other.MagicFieldGenType;
			}
			if (other.IsDestroyWithCaster != EGSYesNo.No)
			{
				IsDestroyWithCaster = other.IsDestroyWithCaster;
			}
			if (other.DestroyTimer != 0f)
			{
				DestroyTimer = other.DestroyTimer;
			}
			if (other.MagicFieldMoveModeType != EBulletOrMagicFieldMoveModeType.None)
			{
				MagicFieldMoveModeType = other.MagicFieldMoveModeType;
			}
			attachBuffID_.Add(other.attachBuffID_);
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
				ID = input.ReadInt32();
				break;
			case 18u:
				MagicBPTemplatePath = input.ReadString();
				break;
			case 24u:
				MagicFieldGenType = (EBGUMagicFieldGenType)input.ReadEnum();
				break;
			case 32u:
				IsDestroyWithCaster = (EGSYesNo)input.ReadEnum();
				break;
			case 45u:
				DestroyTimer = input.ReadFloat();
				break;
			case 48u:
				MagicFieldMoveModeType = (EBulletOrMagicFieldMoveModeType)input.ReadEnum();
				break;
			case 56u:
			case 58u:
				attachBuffID_.AddEntriesFrom(input, _repeated_attachBuffID_codec);
				break;
			}
		}
	}
}
