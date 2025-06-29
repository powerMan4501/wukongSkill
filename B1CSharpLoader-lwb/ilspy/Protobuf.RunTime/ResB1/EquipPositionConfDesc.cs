using System;
using BtlB1;
using Google.Protobuf;

namespace ResB1;

public sealed class EquipPositionConfDesc : IMessage<EquipPositionConfDesc>, IMessage, IEquatable<EquipPositionConfDesc>, IDeepCloneable<EquipPositionConfDesc>
{
	private static readonly MessageParser<EquipPositionConfDesc> _parser = new MessageParser<EquipPositionConfDesc>(() => new EquipPositionConfDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private EquipPosition equipPosition_;

	private string skeletalMeshComponentTag_ = "";

	private int defaultEquipId_;

	public static MessageParser<EquipPositionConfDesc> Parser => _parser;

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

	public EquipPosition EquipPosition
	{
		get
		{
			return equipPosition_;
		}
		set
		{
			equipPosition_ = value;
		}
	}

	public string SkeletalMeshComponentTag
	{
		get
		{
			return skeletalMeshComponentTag_;
		}
		set
		{
			skeletalMeshComponentTag_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int DefaultEquipId
	{
		get
		{
			return defaultEquipId_;
		}
		set
		{
			defaultEquipId_ = value;
		}
	}

	public EquipPositionConfDesc()
	{
	}

	public EquipPositionConfDesc(EquipPositionConfDesc other)
		: this()
	{
		id_ = other.id_;
		equipPosition_ = other.equipPosition_;
		skeletalMeshComponentTag_ = other.skeletalMeshComponentTag_;
		defaultEquipId_ = other.defaultEquipId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EquipPositionConfDesc Clone()
	{
		return new EquipPositionConfDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EquipPositionConfDesc);
	}

	public bool Equals(EquipPositionConfDesc other)
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
		if (EquipPosition != other.EquipPosition)
		{
			return false;
		}
		if (SkeletalMeshComponentTag != other.SkeletalMeshComponentTag)
		{
			return false;
		}
		if (DefaultEquipId != other.DefaultEquipId)
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
		if (EquipPosition != EquipPosition.Head)
		{
			num ^= EquipPosition.GetHashCode();
		}
		if (SkeletalMeshComponentTag.Length != 0)
		{
			num ^= SkeletalMeshComponentTag.GetHashCode();
		}
		if (DefaultEquipId != 0)
		{
			num ^= DefaultEquipId.GetHashCode();
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
		if (EquipPosition != EquipPosition.Head)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)EquipPosition);
		}
		if (SkeletalMeshComponentTag.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(SkeletalMeshComponentTag);
		}
		if (DefaultEquipId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(DefaultEquipId);
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
		if (EquipPosition != EquipPosition.Head)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EquipPosition);
		}
		if (SkeletalMeshComponentTag.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SkeletalMeshComponentTag);
		}
		if (DefaultEquipId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DefaultEquipId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EquipPositionConfDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.EquipPosition != EquipPosition.Head)
			{
				EquipPosition = other.EquipPosition;
			}
			if (other.SkeletalMeshComponentTag.Length != 0)
			{
				SkeletalMeshComponentTag = other.SkeletalMeshComponentTag;
			}
			if (other.DefaultEquipId != 0)
			{
				DefaultEquipId = other.DefaultEquipId;
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
			case 16u:
				EquipPosition = (EquipPosition)input.ReadEnum();
				break;
			case 26u:
				SkeletalMeshComponentTag = input.ReadString();
				break;
			case 32u:
				DefaultEquipId = input.ReadInt32();
				break;
			}
		}
	}
}
