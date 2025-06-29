using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class PersistentBUCData : IMessage<PersistentBUCData>, IMessage, IEquatable<PersistentBUCData>, IDeepCloneable<PersistentBUCData>
{
	private static readonly MessageParser<PersistentBUCData> _parser = new MessageParser<PersistentBUCData>(() => new PersistentBUCData());

	private UnknownFieldSet _unknownFields;

	private string guid_ = "";

	private BUC_ActorInitData bUCActorInitData_;

	private BUC_ReplicateTestData bUCReplicateTestData_;

	private BUC_CollectionData bUCCollectionData_;

	private BUC_InteractData bUCInteractData_;

	private BUC_TaskCollectionData bUCTaskCollectionData_;

	private BUC_GamePlusSpawnData bUCGamePlusSpawnData_;

	private BUC_LifeSavingData bUCLifeSavingData_;

	public static MessageParser<PersistentBUCData> Parser => _parser;

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

	public BUC_ActorInitData BUCActorInitData
	{
		get
		{
			return bUCActorInitData_;
		}
		set
		{
			bUCActorInitData_ = value;
		}
	}

	public BUC_ReplicateTestData BUCReplicateTestData
	{
		get
		{
			return bUCReplicateTestData_;
		}
		set
		{
			bUCReplicateTestData_ = value;
		}
	}

	public BUC_CollectionData BUCCollectionData
	{
		get
		{
			return bUCCollectionData_;
		}
		set
		{
			bUCCollectionData_ = value;
		}
	}

	public BUC_InteractData BUCInteractData
	{
		get
		{
			return bUCInteractData_;
		}
		set
		{
			bUCInteractData_ = value;
		}
	}

	public BUC_TaskCollectionData BUCTaskCollectionData
	{
		get
		{
			return bUCTaskCollectionData_;
		}
		set
		{
			bUCTaskCollectionData_ = value;
		}
	}

	public BUC_GamePlusSpawnData BUCGamePlusSpawnData
	{
		get
		{
			return bUCGamePlusSpawnData_;
		}
		set
		{
			bUCGamePlusSpawnData_ = value;
		}
	}

	public BUC_LifeSavingData BUCLifeSavingData
	{
		get
		{
			return bUCLifeSavingData_;
		}
		set
		{
			bUCLifeSavingData_ = value;
		}
	}

	public PersistentBUCData()
	{
	}

	public PersistentBUCData(PersistentBUCData other)
		: this()
	{
		guid_ = other.guid_;
		bUCActorInitData_ = ((other.bUCActorInitData_ != null) ? other.bUCActorInitData_.Clone() : null);
		bUCReplicateTestData_ = ((other.bUCReplicateTestData_ != null) ? other.bUCReplicateTestData_.Clone() : null);
		bUCCollectionData_ = ((other.bUCCollectionData_ != null) ? other.bUCCollectionData_.Clone() : null);
		bUCInteractData_ = ((other.bUCInteractData_ != null) ? other.bUCInteractData_.Clone() : null);
		bUCTaskCollectionData_ = ((other.bUCTaskCollectionData_ != null) ? other.bUCTaskCollectionData_.Clone() : null);
		bUCGamePlusSpawnData_ = ((other.bUCGamePlusSpawnData_ != null) ? other.bUCGamePlusSpawnData_.Clone() : null);
		bUCLifeSavingData_ = ((other.bUCLifeSavingData_ != null) ? other.bUCLifeSavingData_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PersistentBUCData Clone()
	{
		return new PersistentBUCData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PersistentBUCData);
	}

	public bool Equals(PersistentBUCData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Guid != other.Guid)
		{
			return false;
		}
		if (!object.Equals(BUCActorInitData, other.BUCActorInitData))
		{
			return false;
		}
		if (!object.Equals(BUCReplicateTestData, other.BUCReplicateTestData))
		{
			return false;
		}
		if (!object.Equals(BUCCollectionData, other.BUCCollectionData))
		{
			return false;
		}
		if (!object.Equals(BUCInteractData, other.BUCInteractData))
		{
			return false;
		}
		if (!object.Equals(BUCTaskCollectionData, other.BUCTaskCollectionData))
		{
			return false;
		}
		if (!object.Equals(BUCGamePlusSpawnData, other.BUCGamePlusSpawnData))
		{
			return false;
		}
		if (!object.Equals(BUCLifeSavingData, other.BUCLifeSavingData))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Guid.Length != 0)
		{
			num ^= Guid.GetHashCode();
		}
		if (bUCActorInitData_ != null)
		{
			num ^= BUCActorInitData.GetHashCode();
		}
		if (bUCReplicateTestData_ != null)
		{
			num ^= BUCReplicateTestData.GetHashCode();
		}
		if (bUCCollectionData_ != null)
		{
			num ^= BUCCollectionData.GetHashCode();
		}
		if (bUCInteractData_ != null)
		{
			num ^= BUCInteractData.GetHashCode();
		}
		if (bUCTaskCollectionData_ != null)
		{
			num ^= BUCTaskCollectionData.GetHashCode();
		}
		if (bUCGamePlusSpawnData_ != null)
		{
			num ^= BUCGamePlusSpawnData.GetHashCode();
		}
		if (bUCLifeSavingData_ != null)
		{
			num ^= BUCLifeSavingData.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Guid.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Guid);
		}
		if (bUCActorInitData_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(BUCActorInitData);
		}
		if (bUCReplicateTestData_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(BUCReplicateTestData);
		}
		if (bUCCollectionData_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(BUCCollectionData);
		}
		if (bUCInteractData_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(BUCInteractData);
		}
		if (bUCTaskCollectionData_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(BUCTaskCollectionData);
		}
		if (bUCGamePlusSpawnData_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(BUCGamePlusSpawnData);
		}
		if (bUCLifeSavingData_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(BUCLifeSavingData);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Guid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Guid);
		}
		if (bUCActorInitData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BUCActorInitData);
		}
		if (bUCReplicateTestData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BUCReplicateTestData);
		}
		if (bUCCollectionData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BUCCollectionData);
		}
		if (bUCInteractData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BUCInteractData);
		}
		if (bUCTaskCollectionData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BUCTaskCollectionData);
		}
		if (bUCGamePlusSpawnData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BUCGamePlusSpawnData);
		}
		if (bUCLifeSavingData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BUCLifeSavingData);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PersistentBUCData other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Guid.Length != 0)
		{
			Guid = other.Guid;
		}
		if (other.bUCActorInitData_ != null)
		{
			if (bUCActorInitData_ == null)
			{
				BUCActorInitData = new BUC_ActorInitData();
			}
			BUCActorInitData.MergeFrom(other.BUCActorInitData);
		}
		if (other.bUCReplicateTestData_ != null)
		{
			if (bUCReplicateTestData_ == null)
			{
				BUCReplicateTestData = new BUC_ReplicateTestData();
			}
			BUCReplicateTestData.MergeFrom(other.BUCReplicateTestData);
		}
		if (other.bUCCollectionData_ != null)
		{
			if (bUCCollectionData_ == null)
			{
				BUCCollectionData = new BUC_CollectionData();
			}
			BUCCollectionData.MergeFrom(other.BUCCollectionData);
		}
		if (other.bUCInteractData_ != null)
		{
			if (bUCInteractData_ == null)
			{
				BUCInteractData = new BUC_InteractData();
			}
			BUCInteractData.MergeFrom(other.BUCInteractData);
		}
		if (other.bUCTaskCollectionData_ != null)
		{
			if (bUCTaskCollectionData_ == null)
			{
				BUCTaskCollectionData = new BUC_TaskCollectionData();
			}
			BUCTaskCollectionData.MergeFrom(other.BUCTaskCollectionData);
		}
		if (other.bUCGamePlusSpawnData_ != null)
		{
			if (bUCGamePlusSpawnData_ == null)
			{
				BUCGamePlusSpawnData = new BUC_GamePlusSpawnData();
			}
			BUCGamePlusSpawnData.MergeFrom(other.BUCGamePlusSpawnData);
		}
		if (other.bUCLifeSavingData_ != null)
		{
			if (bUCLifeSavingData_ == null)
			{
				BUCLifeSavingData = new BUC_LifeSavingData();
			}
			BUCLifeSavingData.MergeFrom(other.BUCLifeSavingData);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				Guid = input.ReadString();
				break;
			case 18u:
				if (bUCActorInitData_ == null)
				{
					BUCActorInitData = new BUC_ActorInitData();
				}
				input.ReadMessage(BUCActorInitData);
				break;
			case 26u:
				if (bUCReplicateTestData_ == null)
				{
					BUCReplicateTestData = new BUC_ReplicateTestData();
				}
				input.ReadMessage(BUCReplicateTestData);
				break;
			case 34u:
				if (bUCCollectionData_ == null)
				{
					BUCCollectionData = new BUC_CollectionData();
				}
				input.ReadMessage(BUCCollectionData);
				break;
			case 42u:
				if (bUCInteractData_ == null)
				{
					BUCInteractData = new BUC_InteractData();
				}
				input.ReadMessage(BUCInteractData);
				break;
			case 50u:
				if (bUCTaskCollectionData_ == null)
				{
					BUCTaskCollectionData = new BUC_TaskCollectionData();
				}
				input.ReadMessage(BUCTaskCollectionData);
				break;
			case 58u:
				if (bUCGamePlusSpawnData_ == null)
				{
					BUCGamePlusSpawnData = new BUC_GamePlusSpawnData();
				}
				input.ReadMessage(BUCGamePlusSpawnData);
				break;
			case 66u:
				if (bUCLifeSavingData_ == null)
				{
					BUCLifeSavingData = new BUC_LifeSavingData();
				}
				input.ReadMessage(BUCLifeSavingData);
				break;
			}
		}
	}
}
