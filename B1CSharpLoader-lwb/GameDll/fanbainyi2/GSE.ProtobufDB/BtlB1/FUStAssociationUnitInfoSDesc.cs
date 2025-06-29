using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStAssociationUnitInfoSDesc : IMessage<FUStAssociationUnitInfoSDesc>, IMessage, IEquatable<FUStAssociationUnitInfoSDesc>, IDeepCloneable<FUStAssociationUnitInfoSDesc>
{
	private static readonly MessageParser<FUStAssociationUnitInfoSDesc> _parser = new MessageParser<FUStAssociationUnitInfoSDesc>(() => new FUStAssociationUnitInfoSDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string unitResBPPath_ = "";

	private string bTPath_ = "";

	private int cBGTemplateID_;

	private string spawnEQSPath_ = "";

	private string spawnSceneItemTagName_ = "";

	private static readonly FieldCodec<int> _repeated_spawnBuffIDList_codec = FieldCodec.ForInt32(58u);

	private readonly RepeatedField<int> spawnBuffIDList_ = new RepeatedField<int>();

	public static MessageParser<FUStAssociationUnitInfoSDesc> Parser => _parser;

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

	public string UnitResBPPath
	{
		get
		{
			return unitResBPPath_;
		}
		set
		{
			unitResBPPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string BTPath
	{
		get
		{
			return bTPath_;
		}
		set
		{
			bTPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int CBGTemplateID
	{
		get
		{
			return cBGTemplateID_;
		}
		set
		{
			cBGTemplateID_ = value;
		}
	}

	public string SpawnEQSPath
	{
		get
		{
			return spawnEQSPath_;
		}
		set
		{
			spawnEQSPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string SpawnSceneItemTagName
	{
		get
		{
			return spawnSceneItemTagName_;
		}
		set
		{
			spawnSceneItemTagName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<int> SpawnBuffIDList => spawnBuffIDList_;

	public FUStAssociationUnitInfoSDesc()
	{
	}

	public FUStAssociationUnitInfoSDesc(FUStAssociationUnitInfoSDesc other)
		: this()
	{
		iD_ = other.iD_;
		unitResBPPath_ = other.unitResBPPath_;
		bTPath_ = other.bTPath_;
		cBGTemplateID_ = other.cBGTemplateID_;
		spawnEQSPath_ = other.spawnEQSPath_;
		spawnSceneItemTagName_ = other.spawnSceneItemTagName_;
		spawnBuffIDList_ = other.spawnBuffIDList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStAssociationUnitInfoSDesc Clone()
	{
		return new FUStAssociationUnitInfoSDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStAssociationUnitInfoSDesc);
	}

	public bool Equals(FUStAssociationUnitInfoSDesc other)
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
		if (UnitResBPPath != other.UnitResBPPath)
		{
			return false;
		}
		if (BTPath != other.BTPath)
		{
			return false;
		}
		if (CBGTemplateID != other.CBGTemplateID)
		{
			return false;
		}
		if (SpawnEQSPath != other.SpawnEQSPath)
		{
			return false;
		}
		if (SpawnSceneItemTagName != other.SpawnSceneItemTagName)
		{
			return false;
		}
		if (!spawnBuffIDList_.Equals(other.spawnBuffIDList_))
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
		if (UnitResBPPath.Length != 0)
		{
			num ^= UnitResBPPath.GetHashCode();
		}
		if (BTPath.Length != 0)
		{
			num ^= BTPath.GetHashCode();
		}
		if (CBGTemplateID != 0)
		{
			num ^= CBGTemplateID.GetHashCode();
		}
		if (SpawnEQSPath.Length != 0)
		{
			num ^= SpawnEQSPath.GetHashCode();
		}
		if (SpawnSceneItemTagName.Length != 0)
		{
			num ^= SpawnSceneItemTagName.GetHashCode();
		}
		num ^= spawnBuffIDList_.GetHashCode();
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
		if (UnitResBPPath.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(UnitResBPPath);
		}
		if (BTPath.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(BTPath);
		}
		if (CBGTemplateID != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(CBGTemplateID);
		}
		if (SpawnEQSPath.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(SpawnEQSPath);
		}
		if (SpawnSceneItemTagName.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(SpawnSceneItemTagName);
		}
		spawnBuffIDList_.WriteTo(output, _repeated_spawnBuffIDList_codec);
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
		if (UnitResBPPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UnitResBPPath);
		}
		if (BTPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BTPath);
		}
		if (CBGTemplateID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CBGTemplateID);
		}
		if (SpawnEQSPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SpawnEQSPath);
		}
		if (SpawnSceneItemTagName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SpawnSceneItemTagName);
		}
		num += spawnBuffIDList_.CalculateSize(_repeated_spawnBuffIDList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStAssociationUnitInfoSDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.UnitResBPPath.Length != 0)
			{
				UnitResBPPath = other.UnitResBPPath;
			}
			if (other.BTPath.Length != 0)
			{
				BTPath = other.BTPath;
			}
			if (other.CBGTemplateID != 0)
			{
				CBGTemplateID = other.CBGTemplateID;
			}
			if (other.SpawnEQSPath.Length != 0)
			{
				SpawnEQSPath = other.SpawnEQSPath;
			}
			if (other.SpawnSceneItemTagName.Length != 0)
			{
				SpawnSceneItemTagName = other.SpawnSceneItemTagName;
			}
			spawnBuffIDList_.Add(other.spawnBuffIDList_);
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
				UnitResBPPath = input.ReadString();
				break;
			case 26u:
				BTPath = input.ReadString();
				break;
			case 32u:
				CBGTemplateID = input.ReadInt32();
				break;
			case 42u:
				SpawnEQSPath = input.ReadString();
				break;
			case 50u:
				SpawnSceneItemTagName = input.ReadString();
				break;
			case 56u:
			case 58u:
				spawnBuffIDList_.AddEntriesFrom(input, _repeated_spawnBuffIDList_codec);
				break;
			}
		}
	}
}
