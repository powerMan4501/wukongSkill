using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class FUStBuffLayerDispConfig : IMessage<FUStBuffLayerDispConfig>, IMessage, IEquatable<FUStBuffLayerDispConfig>, IDeepCloneable<FUStBuffLayerDispConfig>
{
	private static readonly MessageParser<FUStBuffLayerDispConfig> _parser = new MessageParser<FUStBuffLayerDispConfig>(() => new FUStBuffLayerDispConfig());

	private UnknownFieldSet _unknownFields;

	private int layerIndex_;

	private EBuffLayerDispMixType mixType_;

	private string dBCPath_ = "";

	public static MessageParser<FUStBuffLayerDispConfig> Parser => _parser;

	public int LayerIndex
	{
		get
		{
			return layerIndex_;
		}
		set
		{
			layerIndex_ = value;
		}
	}

	public EBuffLayerDispMixType MixType
	{
		get
		{
			return mixType_;
		}
		set
		{
			mixType_ = value;
		}
	}

	public string DBCPath
	{
		get
		{
			return dBCPath_;
		}
		set
		{
			dBCPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStBuffLayerDispConfig()
	{
	}

	public FUStBuffLayerDispConfig(FUStBuffLayerDispConfig other)
		: this()
	{
		layerIndex_ = other.layerIndex_;
		mixType_ = other.mixType_;
		dBCPath_ = other.dBCPath_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStBuffLayerDispConfig Clone()
	{
		return new FUStBuffLayerDispConfig(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStBuffLayerDispConfig);
	}

	public bool Equals(FUStBuffLayerDispConfig other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LayerIndex != other.LayerIndex)
		{
			return false;
		}
		if (MixType != other.MixType)
		{
			return false;
		}
		if (DBCPath != other.DBCPath)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (LayerIndex != 0)
		{
			num ^= LayerIndex.GetHashCode();
		}
		if (MixType != EBuffLayerDispMixType.Override)
		{
			num ^= MixType.GetHashCode();
		}
		if (DBCPath.Length != 0)
		{
			num ^= DBCPath.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (LayerIndex != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(LayerIndex);
		}
		if (MixType != EBuffLayerDispMixType.Override)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)MixType);
		}
		if (DBCPath.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(DBCPath);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (LayerIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LayerIndex);
		}
		if (MixType != EBuffLayerDispMixType.Override)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MixType);
		}
		if (DBCPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DBCPath);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStBuffLayerDispConfig other)
	{
		if (other != null)
		{
			if (other.LayerIndex != 0)
			{
				LayerIndex = other.LayerIndex;
			}
			if (other.MixType != EBuffLayerDispMixType.Override)
			{
				MixType = other.MixType;
			}
			if (other.DBCPath.Length != 0)
			{
				DBCPath = other.DBCPath;
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
				LayerIndex = input.ReadInt32();
				break;
			case 16u:
				MixType = (EBuffLayerDispMixType)input.ReadEnum();
				break;
			case 26u:
				DBCPath = input.ReadString();
				break;
			}
		}
	}
}
