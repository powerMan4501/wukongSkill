using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class MovieCustom_PerformerSyncTransformToRefObj : IMessage<MovieCustom_PerformerSyncTransformToRefObj>, IMessage, IEquatable<MovieCustom_PerformerSyncTransformToRefObj>, IDeepCloneable<MovieCustom_PerformerSyncTransformToRefObj>
{
	private static readonly MessageParser<MovieCustom_PerformerSyncTransformToRefObj> _parser = new MessageParser<MovieCustom_PerformerSyncTransformToRefObj>(() => new MovieCustom_PerformerSyncTransformToRefObj());

	private UnknownFieldSet _unknownFields;

	private string performerGuid_ = "";

	private string refObjGuid_ = "";

	private float localOffsetX_;

	private float localOffsetY_;

	private float localOffsetZ_;

	private string performerTag_ = "";

	private bool isPlayerAsPerformer_;

	public static MessageParser<MovieCustom_PerformerSyncTransformToRefObj> Parser => _parser;

	public string PerformerGuid
	{
		get
		{
			return performerGuid_;
		}
		set
		{
			performerGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string RefObjGuid
	{
		get
		{
			return refObjGuid_;
		}
		set
		{
			refObjGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public float LocalOffsetX
	{
		get
		{
			return localOffsetX_;
		}
		set
		{
			localOffsetX_ = value;
		}
	}

	public float LocalOffsetY
	{
		get
		{
			return localOffsetY_;
		}
		set
		{
			localOffsetY_ = value;
		}
	}

	public float LocalOffsetZ
	{
		get
		{
			return localOffsetZ_;
		}
		set
		{
			localOffsetZ_ = value;
		}
	}

	public string PerformerTag
	{
		get
		{
			return performerTag_;
		}
		set
		{
			performerTag_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public bool IsPlayerAsPerformer
	{
		get
		{
			return isPlayerAsPerformer_;
		}
		set
		{
			isPlayerAsPerformer_ = value;
		}
	}

	public MovieCustom_PerformerSyncTransformToRefObj()
	{
	}

	public MovieCustom_PerformerSyncTransformToRefObj(MovieCustom_PerformerSyncTransformToRefObj other)
		: this()
	{
		performerGuid_ = other.performerGuid_;
		refObjGuid_ = other.refObjGuid_;
		localOffsetX_ = other.localOffsetX_;
		localOffsetY_ = other.localOffsetY_;
		localOffsetZ_ = other.localOffsetZ_;
		performerTag_ = other.performerTag_;
		isPlayerAsPerformer_ = other.isPlayerAsPerformer_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MovieCustom_PerformerSyncTransformToRefObj Clone()
	{
		return new MovieCustom_PerformerSyncTransformToRefObj(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MovieCustom_PerformerSyncTransformToRefObj);
	}

	public bool Equals(MovieCustom_PerformerSyncTransformToRefObj other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PerformerGuid != other.PerformerGuid)
		{
			return false;
		}
		if (RefObjGuid != other.RefObjGuid)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(LocalOffsetX, other.LocalOffsetX))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(LocalOffsetY, other.LocalOffsetY))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(LocalOffsetZ, other.LocalOffsetZ))
		{
			return false;
		}
		if (PerformerTag != other.PerformerTag)
		{
			return false;
		}
		if (IsPlayerAsPerformer != other.IsPlayerAsPerformer)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (PerformerGuid.Length != 0)
		{
			num ^= PerformerGuid.GetHashCode();
		}
		if (RefObjGuid.Length != 0)
		{
			num ^= RefObjGuid.GetHashCode();
		}
		if (LocalOffsetX != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(LocalOffsetX);
		}
		if (LocalOffsetY != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(LocalOffsetY);
		}
		if (LocalOffsetZ != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(LocalOffsetZ);
		}
		if (PerformerTag.Length != 0)
		{
			num ^= PerformerTag.GetHashCode();
		}
		if (IsPlayerAsPerformer)
		{
			num ^= IsPlayerAsPerformer.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (PerformerGuid.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(PerformerGuid);
		}
		if (RefObjGuid.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(RefObjGuid);
		}
		if (LocalOffsetX != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(LocalOffsetX);
		}
		if (LocalOffsetY != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(LocalOffsetY);
		}
		if (LocalOffsetZ != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(LocalOffsetZ);
		}
		if (PerformerTag.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(PerformerTag);
		}
		if (IsPlayerAsPerformer)
		{
			output.WriteRawTag(56);
			output.WriteBool(IsPlayerAsPerformer);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (PerformerGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PerformerGuid);
		}
		if (RefObjGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RefObjGuid);
		}
		if (LocalOffsetX != 0f)
		{
			num += 5;
		}
		if (LocalOffsetY != 0f)
		{
			num += 5;
		}
		if (LocalOffsetZ != 0f)
		{
			num += 5;
		}
		if (PerformerTag.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PerformerTag);
		}
		if (IsPlayerAsPerformer)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MovieCustom_PerformerSyncTransformToRefObj other)
	{
		if (other != null)
		{
			if (other.PerformerGuid.Length != 0)
			{
				PerformerGuid = other.PerformerGuid;
			}
			if (other.RefObjGuid.Length != 0)
			{
				RefObjGuid = other.RefObjGuid;
			}
			if (other.LocalOffsetX != 0f)
			{
				LocalOffsetX = other.LocalOffsetX;
			}
			if (other.LocalOffsetY != 0f)
			{
				LocalOffsetY = other.LocalOffsetY;
			}
			if (other.LocalOffsetZ != 0f)
			{
				LocalOffsetZ = other.LocalOffsetZ;
			}
			if (other.PerformerTag.Length != 0)
			{
				PerformerTag = other.PerformerTag;
			}
			if (other.IsPlayerAsPerformer)
			{
				IsPlayerAsPerformer = other.IsPlayerAsPerformer;
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
				PerformerGuid = input.ReadString();
				break;
			case 18u:
				RefObjGuid = input.ReadString();
				break;
			case 29u:
				LocalOffsetX = input.ReadFloat();
				break;
			case 37u:
				LocalOffsetY = input.ReadFloat();
				break;
			case 45u:
				LocalOffsetZ = input.ReadFloat();
				break;
			case 50u:
				PerformerTag = input.ReadString();
				break;
			case 56u:
				IsPlayerAsPerformer = input.ReadBool();
				break;
			}
		}
	}
}
