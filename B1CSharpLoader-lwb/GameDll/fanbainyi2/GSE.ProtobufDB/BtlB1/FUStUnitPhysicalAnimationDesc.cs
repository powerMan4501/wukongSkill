using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStUnitPhysicalAnimationDesc : IMessage<FUStUnitPhysicalAnimationDesc>, IMessage, IEquatable<FUStUnitPhysicalAnimationDesc>, IDeepCloneable<FUStUnitPhysicalAnimationDesc>
{
	private static readonly MessageParser<FUStUnitPhysicalAnimationDesc> _parser = new MessageParser<FUStUnitPhysicalAnimationDesc>(() => new FUStUnitPhysicalAnimationDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string normalPhysAnimDataAsset_ = "";

	private string beCatchThrowPhysAnimDataAsset_ = "";

	private string physMoveAnimDataAsset_ = "";

	private string guard_ = "";

	public static MessageParser<FUStUnitPhysicalAnimationDesc> Parser => _parser;

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

	public string NormalPhysAnimDataAsset
	{
		get
		{
			return normalPhysAnimDataAsset_;
		}
		set
		{
			normalPhysAnimDataAsset_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string BeCatchThrowPhysAnimDataAsset
	{
		get
		{
			return beCatchThrowPhysAnimDataAsset_;
		}
		set
		{
			beCatchThrowPhysAnimDataAsset_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string PhysMoveAnimDataAsset
	{
		get
		{
			return physMoveAnimDataAsset_;
		}
		set
		{
			physMoveAnimDataAsset_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Guard
	{
		get
		{
			return guard_;
		}
		set
		{
			guard_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStUnitPhysicalAnimationDesc()
	{
	}

	public FUStUnitPhysicalAnimationDesc(FUStUnitPhysicalAnimationDesc other)
		: this()
	{
		iD_ = other.iD_;
		normalPhysAnimDataAsset_ = other.normalPhysAnimDataAsset_;
		beCatchThrowPhysAnimDataAsset_ = other.beCatchThrowPhysAnimDataAsset_;
		physMoveAnimDataAsset_ = other.physMoveAnimDataAsset_;
		guard_ = other.guard_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStUnitPhysicalAnimationDesc Clone()
	{
		return new FUStUnitPhysicalAnimationDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStUnitPhysicalAnimationDesc);
	}

	public bool Equals(FUStUnitPhysicalAnimationDesc other)
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
		if (NormalPhysAnimDataAsset != other.NormalPhysAnimDataAsset)
		{
			return false;
		}
		if (BeCatchThrowPhysAnimDataAsset != other.BeCatchThrowPhysAnimDataAsset)
		{
			return false;
		}
		if (PhysMoveAnimDataAsset != other.PhysMoveAnimDataAsset)
		{
			return false;
		}
		if (Guard != other.Guard)
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
		if (NormalPhysAnimDataAsset.Length != 0)
		{
			num ^= NormalPhysAnimDataAsset.GetHashCode();
		}
		if (BeCatchThrowPhysAnimDataAsset.Length != 0)
		{
			num ^= BeCatchThrowPhysAnimDataAsset.GetHashCode();
		}
		if (PhysMoveAnimDataAsset.Length != 0)
		{
			num ^= PhysMoveAnimDataAsset.GetHashCode();
		}
		if (Guard.Length != 0)
		{
			num ^= Guard.GetHashCode();
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
		if (NormalPhysAnimDataAsset.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(NormalPhysAnimDataAsset);
		}
		if (BeCatchThrowPhysAnimDataAsset.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(BeCatchThrowPhysAnimDataAsset);
		}
		if (PhysMoveAnimDataAsset.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(PhysMoveAnimDataAsset);
		}
		if (Guard.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(Guard);
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
		if (NormalPhysAnimDataAsset.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(NormalPhysAnimDataAsset);
		}
		if (BeCatchThrowPhysAnimDataAsset.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BeCatchThrowPhysAnimDataAsset);
		}
		if (PhysMoveAnimDataAsset.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PhysMoveAnimDataAsset);
		}
		if (Guard.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Guard);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStUnitPhysicalAnimationDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.NormalPhysAnimDataAsset.Length != 0)
			{
				NormalPhysAnimDataAsset = other.NormalPhysAnimDataAsset;
			}
			if (other.BeCatchThrowPhysAnimDataAsset.Length != 0)
			{
				BeCatchThrowPhysAnimDataAsset = other.BeCatchThrowPhysAnimDataAsset;
			}
			if (other.PhysMoveAnimDataAsset.Length != 0)
			{
				PhysMoveAnimDataAsset = other.PhysMoveAnimDataAsset;
			}
			if (other.Guard.Length != 0)
			{
				Guard = other.Guard;
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
			case 18u:
				NormalPhysAnimDataAsset = input.ReadString();
				break;
			case 26u:
				BeCatchThrowPhysAnimDataAsset = input.ReadString();
				break;
			case 34u:
				PhysMoveAnimDataAsset = input.ReadString();
				break;
			case 42u:
				Guard = input.ReadString();
				break;
			}
		}
	}
}
