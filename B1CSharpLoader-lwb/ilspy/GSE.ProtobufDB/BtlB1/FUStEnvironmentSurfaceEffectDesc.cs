using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStEnvironmentSurfaceEffectDesc : IMessage<FUStEnvironmentSurfaceEffectDesc>, IMessage, IEquatable<FUStEnvironmentSurfaceEffectDesc>, IDeepCloneable<FUStEnvironmentSurfaceEffectDesc>
{
	private static readonly MessageParser<FUStEnvironmentSurfaceEffectDesc> _parser = new MessageParser<FUStEnvironmentSurfaceEffectDesc>(() => new FUStEnvironmentSurfaceEffectDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int targetFilter_;

	private ESceneItemSurfaceType surfaceType_;

	private static readonly FieldCodec<int> _repeated_surfaceBuffList_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> surfaceBuffList_ = new RepeatedField<int>();

	private string environmentAbnormalEffectDA_ = "";

	public static MessageParser<FUStEnvironmentSurfaceEffectDesc> Parser => _parser;

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

	public int TargetFilter
	{
		get
		{
			return targetFilter_;
		}
		set
		{
			targetFilter_ = value;
		}
	}

	public ESceneItemSurfaceType SurfaceType
	{
		get
		{
			return surfaceType_;
		}
		set
		{
			surfaceType_ = value;
		}
	}

	public RepeatedField<int> SurfaceBuffList => surfaceBuffList_;

	public string EnvironmentAbnormalEffectDA
	{
		get
		{
			return environmentAbnormalEffectDA_;
		}
		set
		{
			environmentAbnormalEffectDA_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStEnvironmentSurfaceEffectDesc()
	{
	}

	public FUStEnvironmentSurfaceEffectDesc(FUStEnvironmentSurfaceEffectDesc other)
		: this()
	{
		iD_ = other.iD_;
		targetFilter_ = other.targetFilter_;
		surfaceType_ = other.surfaceType_;
		surfaceBuffList_ = other.surfaceBuffList_.Clone();
		environmentAbnormalEffectDA_ = other.environmentAbnormalEffectDA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStEnvironmentSurfaceEffectDesc Clone()
	{
		return new FUStEnvironmentSurfaceEffectDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStEnvironmentSurfaceEffectDesc);
	}

	public bool Equals(FUStEnvironmentSurfaceEffectDesc other)
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
		if (TargetFilter != other.TargetFilter)
		{
			return false;
		}
		if (SurfaceType != other.SurfaceType)
		{
			return false;
		}
		if (!surfaceBuffList_.Equals(other.surfaceBuffList_))
		{
			return false;
		}
		if (EnvironmentAbnormalEffectDA != other.EnvironmentAbnormalEffectDA)
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
		if (TargetFilter != 0)
		{
			num ^= TargetFilter.GetHashCode();
		}
		if (SurfaceType != ESceneItemSurfaceType.DefaultSurface)
		{
			num ^= SurfaceType.GetHashCode();
		}
		num ^= surfaceBuffList_.GetHashCode();
		if (EnvironmentAbnormalEffectDA.Length != 0)
		{
			num ^= EnvironmentAbnormalEffectDA.GetHashCode();
		}
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
		if (TargetFilter != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(TargetFilter);
		}
		if (SurfaceType != ESceneItemSurfaceType.DefaultSurface)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)SurfaceType);
		}
		surfaceBuffList_.WriteTo(output, _repeated_surfaceBuffList_codec);
		if (EnvironmentAbnormalEffectDA.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(EnvironmentAbnormalEffectDA);
		}
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
		if (TargetFilter != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetFilter);
		}
		if (SurfaceType != ESceneItemSurfaceType.DefaultSurface)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SurfaceType);
		}
		num += surfaceBuffList_.CalculateSize(_repeated_surfaceBuffList_codec);
		if (EnvironmentAbnormalEffectDA.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EnvironmentAbnormalEffectDA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStEnvironmentSurfaceEffectDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.TargetFilter != 0)
			{
				TargetFilter = other.TargetFilter;
			}
			if (other.SurfaceType != ESceneItemSurfaceType.DefaultSurface)
			{
				SurfaceType = other.SurfaceType;
			}
			surfaceBuffList_.Add(other.surfaceBuffList_);
			if (other.EnvironmentAbnormalEffectDA.Length != 0)
			{
				EnvironmentAbnormalEffectDA = other.EnvironmentAbnormalEffectDA;
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
				ID = input.ReadInt32();
				break;
			case 16u:
				TargetFilter = input.ReadInt32();
				break;
			case 24u:
				SurfaceType = (ESceneItemSurfaceType)input.ReadEnum();
				break;
			case 32u:
			case 34u:
				surfaceBuffList_.AddEntriesFrom(input, _repeated_surfaceBuffList_codec);
				break;
			case 42u:
				EnvironmentAbnormalEffectDA = input.ReadString();
				break;
			}
		}
	}
}
