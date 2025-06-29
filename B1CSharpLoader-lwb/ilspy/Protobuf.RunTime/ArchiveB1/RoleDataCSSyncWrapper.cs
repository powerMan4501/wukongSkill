using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class RoleDataCSSyncWrapper : IMessage<RoleDataCSSyncWrapper>, IMessage, IEquatable<RoleDataCSSyncWrapper>, IDeepCloneable<RoleDataCSSyncWrapper>
{
	private static readonly MessageParser<RoleDataCSSyncWrapper> _parser = new MessageParser<RoleDataCSSyncWrapper>(() => new RoleDataCSSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private RoleBaseSyncWrapper base_;

	private RoleBagSyncWrapper bag_;

	private RoleActorSyncWrapper actor_;

	private RoleShopSyncWrapper shop_;

	private RoleTaskSyncWrapper task_;

	private RoleRedPointSyncWrapper redPoint_;

	private RoleDropSyncWrapper drop_;

	private RoleCollectionSyncWrapper collection_;

	private RoleInteractionSyncWrapper interaction_;

	private RoleAchievementSyncWrapper achievement_;

	private RoleChapterSyncWrapper chapter_;

	private RoleMuseumSyncWrapper museum_;

	private RoleGardenSyncWrapper garden_;

	private RoleActivitySyncWrapper activities_;

	private RoleBossRushSyncWrapper bossRush_;

	public static MessageParser<RoleDataCSSyncWrapper> Parser => _parser;

	public int SyncFlag
	{
		get
		{
			return syncFlag_;
		}
		set
		{
			syncFlag_ = value;
		}
	}

	public int SyncIdx
	{
		get
		{
			return syncIdx_;
		}
		set
		{
			syncIdx_ = value;
		}
	}

	public RoleBaseSyncWrapper Base
	{
		get
		{
			return base_;
		}
		set
		{
			base_ = value;
		}
	}

	public RoleBagSyncWrapper Bag
	{
		get
		{
			return bag_;
		}
		set
		{
			bag_ = value;
		}
	}

	public RoleActorSyncWrapper Actor
	{
		get
		{
			return actor_;
		}
		set
		{
			actor_ = value;
		}
	}

	public RoleShopSyncWrapper Shop
	{
		get
		{
			return shop_;
		}
		set
		{
			shop_ = value;
		}
	}

	public RoleTaskSyncWrapper Task
	{
		get
		{
			return task_;
		}
		set
		{
			task_ = value;
		}
	}

	public RoleRedPointSyncWrapper RedPoint
	{
		get
		{
			return redPoint_;
		}
		set
		{
			redPoint_ = value;
		}
	}

	public RoleDropSyncWrapper Drop
	{
		get
		{
			return drop_;
		}
		set
		{
			drop_ = value;
		}
	}

	public RoleCollectionSyncWrapper Collection
	{
		get
		{
			return collection_;
		}
		set
		{
			collection_ = value;
		}
	}

	public RoleInteractionSyncWrapper Interaction
	{
		get
		{
			return interaction_;
		}
		set
		{
			interaction_ = value;
		}
	}

	public RoleAchievementSyncWrapper Achievement
	{
		get
		{
			return achievement_;
		}
		set
		{
			achievement_ = value;
		}
	}

	public RoleChapterSyncWrapper Chapter
	{
		get
		{
			return chapter_;
		}
		set
		{
			chapter_ = value;
		}
	}

	public RoleMuseumSyncWrapper Museum
	{
		get
		{
			return museum_;
		}
		set
		{
			museum_ = value;
		}
	}

	public RoleGardenSyncWrapper Garden
	{
		get
		{
			return garden_;
		}
		set
		{
			garden_ = value;
		}
	}

	public RoleActivitySyncWrapper Activities
	{
		get
		{
			return activities_;
		}
		set
		{
			activities_ = value;
		}
	}

	public RoleBossRushSyncWrapper BossRush
	{
		get
		{
			return bossRush_;
		}
		set
		{
			bossRush_ = value;
		}
	}

	public RoleDataCSSyncWrapper()
	{
	}

	public RoleDataCSSyncWrapper(RoleDataCSSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		base_ = ((other.base_ != null) ? other.base_.Clone() : null);
		bag_ = ((other.bag_ != null) ? other.bag_.Clone() : null);
		actor_ = ((other.actor_ != null) ? other.actor_.Clone() : null);
		shop_ = ((other.shop_ != null) ? other.shop_.Clone() : null);
		task_ = ((other.task_ != null) ? other.task_.Clone() : null);
		redPoint_ = ((other.redPoint_ != null) ? other.redPoint_.Clone() : null);
		drop_ = ((other.drop_ != null) ? other.drop_.Clone() : null);
		collection_ = ((other.collection_ != null) ? other.collection_.Clone() : null);
		interaction_ = ((other.interaction_ != null) ? other.interaction_.Clone() : null);
		achievement_ = ((other.achievement_ != null) ? other.achievement_.Clone() : null);
		chapter_ = ((other.chapter_ != null) ? other.chapter_.Clone() : null);
		museum_ = ((other.museum_ != null) ? other.museum_.Clone() : null);
		garden_ = ((other.garden_ != null) ? other.garden_.Clone() : null);
		activities_ = ((other.activities_ != null) ? other.activities_.Clone() : null);
		bossRush_ = ((other.bossRush_ != null) ? other.bossRush_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleDataCSSyncWrapper Clone()
	{
		return new RoleDataCSSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleDataCSSyncWrapper);
	}

	public bool Equals(RoleDataCSSyncWrapper other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SyncFlag != other.SyncFlag)
		{
			return false;
		}
		if (SyncIdx != other.SyncIdx)
		{
			return false;
		}
		if (!object.Equals(Base, other.Base))
		{
			return false;
		}
		if (!object.Equals(Bag, other.Bag))
		{
			return false;
		}
		if (!object.Equals(Actor, other.Actor))
		{
			return false;
		}
		if (!object.Equals(Shop, other.Shop))
		{
			return false;
		}
		if (!object.Equals(Task, other.Task))
		{
			return false;
		}
		if (!object.Equals(RedPoint, other.RedPoint))
		{
			return false;
		}
		if (!object.Equals(Drop, other.Drop))
		{
			return false;
		}
		if (!object.Equals(Collection, other.Collection))
		{
			return false;
		}
		if (!object.Equals(Interaction, other.Interaction))
		{
			return false;
		}
		if (!object.Equals(Achievement, other.Achievement))
		{
			return false;
		}
		if (!object.Equals(Chapter, other.Chapter))
		{
			return false;
		}
		if (!object.Equals(Museum, other.Museum))
		{
			return false;
		}
		if (!object.Equals(Garden, other.Garden))
		{
			return false;
		}
		if (!object.Equals(Activities, other.Activities))
		{
			return false;
		}
		if (!object.Equals(BossRush, other.BossRush))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SyncFlag != 0)
		{
			num ^= SyncFlag.GetHashCode();
		}
		if (SyncIdx != 0)
		{
			num ^= SyncIdx.GetHashCode();
		}
		if (base_ != null)
		{
			num ^= Base.GetHashCode();
		}
		if (bag_ != null)
		{
			num ^= Bag.GetHashCode();
		}
		if (actor_ != null)
		{
			num ^= Actor.GetHashCode();
		}
		if (shop_ != null)
		{
			num ^= Shop.GetHashCode();
		}
		if (task_ != null)
		{
			num ^= Task.GetHashCode();
		}
		if (redPoint_ != null)
		{
			num ^= RedPoint.GetHashCode();
		}
		if (drop_ != null)
		{
			num ^= Drop.GetHashCode();
		}
		if (collection_ != null)
		{
			num ^= Collection.GetHashCode();
		}
		if (interaction_ != null)
		{
			num ^= Interaction.GetHashCode();
		}
		if (achievement_ != null)
		{
			num ^= Achievement.GetHashCode();
		}
		if (chapter_ != null)
		{
			num ^= Chapter.GetHashCode();
		}
		if (museum_ != null)
		{
			num ^= Museum.GetHashCode();
		}
		if (garden_ != null)
		{
			num ^= Garden.GetHashCode();
		}
		if (activities_ != null)
		{
			num ^= Activities.GetHashCode();
		}
		if (bossRush_ != null)
		{
			num ^= BossRush.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SyncFlag != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SyncIdx);
		}
		if (base_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Base);
		}
		if (bag_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Bag);
		}
		if (actor_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(Actor);
		}
		if (shop_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(Shop);
		}
		if (task_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(Task);
		}
		if (redPoint_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(RedPoint);
		}
		if (drop_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(Drop);
		}
		if (collection_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(Collection);
		}
		if (interaction_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(Interaction);
		}
		if (achievement_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(Achievement);
		}
		if (chapter_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(Chapter);
		}
		if (museum_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(Museum);
		}
		if (garden_ != null)
		{
			output.WriteRawTag(138, 1);
			output.WriteMessage(Garden);
		}
		if (activities_ != null)
		{
			output.WriteRawTag(146, 1);
			output.WriteMessage(Activities);
		}
		if (bossRush_ != null)
		{
			output.WriteRawTag(154, 1);
			output.WriteMessage(BossRush);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SyncFlag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncIdx);
		}
		if (base_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Base);
		}
		if (bag_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Bag);
		}
		if (actor_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Actor);
		}
		if (shop_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Shop);
		}
		if (task_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Task);
		}
		if (redPoint_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RedPoint);
		}
		if (drop_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Drop);
		}
		if (collection_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Collection);
		}
		if (interaction_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Interaction);
		}
		if (achievement_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Achievement);
		}
		if (chapter_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Chapter);
		}
		if (museum_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Museum);
		}
		if (garden_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(Garden);
		}
		if (activities_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(Activities);
		}
		if (bossRush_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(BossRush);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleDataCSSyncWrapper other)
	{
		if (other == null)
		{
			return;
		}
		if (other.SyncFlag != 0)
		{
			SyncFlag = other.SyncFlag;
		}
		if (other.SyncIdx != 0)
		{
			SyncIdx = other.SyncIdx;
		}
		if (other.base_ != null)
		{
			if (base_ == null)
			{
				Base = new RoleBaseSyncWrapper();
			}
			Base.MergeFrom(other.Base);
		}
		if (other.bag_ != null)
		{
			if (bag_ == null)
			{
				Bag = new RoleBagSyncWrapper();
			}
			Bag.MergeFrom(other.Bag);
		}
		if (other.actor_ != null)
		{
			if (actor_ == null)
			{
				Actor = new RoleActorSyncWrapper();
			}
			Actor.MergeFrom(other.Actor);
		}
		if (other.shop_ != null)
		{
			if (shop_ == null)
			{
				Shop = new RoleShopSyncWrapper();
			}
			Shop.MergeFrom(other.Shop);
		}
		if (other.task_ != null)
		{
			if (task_ == null)
			{
				Task = new RoleTaskSyncWrapper();
			}
			Task.MergeFrom(other.Task);
		}
		if (other.redPoint_ != null)
		{
			if (redPoint_ == null)
			{
				RedPoint = new RoleRedPointSyncWrapper();
			}
			RedPoint.MergeFrom(other.RedPoint);
		}
		if (other.drop_ != null)
		{
			if (drop_ == null)
			{
				Drop = new RoleDropSyncWrapper();
			}
			Drop.MergeFrom(other.Drop);
		}
		if (other.collection_ != null)
		{
			if (collection_ == null)
			{
				Collection = new RoleCollectionSyncWrapper();
			}
			Collection.MergeFrom(other.Collection);
		}
		if (other.interaction_ != null)
		{
			if (interaction_ == null)
			{
				Interaction = new RoleInteractionSyncWrapper();
			}
			Interaction.MergeFrom(other.Interaction);
		}
		if (other.achievement_ != null)
		{
			if (achievement_ == null)
			{
				Achievement = new RoleAchievementSyncWrapper();
			}
			Achievement.MergeFrom(other.Achievement);
		}
		if (other.chapter_ != null)
		{
			if (chapter_ == null)
			{
				Chapter = new RoleChapterSyncWrapper();
			}
			Chapter.MergeFrom(other.Chapter);
		}
		if (other.museum_ != null)
		{
			if (museum_ == null)
			{
				Museum = new RoleMuseumSyncWrapper();
			}
			Museum.MergeFrom(other.Museum);
		}
		if (other.garden_ != null)
		{
			if (garden_ == null)
			{
				Garden = new RoleGardenSyncWrapper();
			}
			Garden.MergeFrom(other.Garden);
		}
		if (other.activities_ != null)
		{
			if (activities_ == null)
			{
				Activities = new RoleActivitySyncWrapper();
			}
			Activities.MergeFrom(other.Activities);
		}
		if (other.bossRush_ != null)
		{
			if (bossRush_ == null)
			{
				BossRush = new RoleBossRushSyncWrapper();
			}
			BossRush.MergeFrom(other.BossRush);
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
			case 8u:
				SyncFlag = input.ReadInt32();
				break;
			case 16u:
				SyncIdx = input.ReadInt32();
				break;
			case 26u:
				if (base_ == null)
				{
					Base = new RoleBaseSyncWrapper();
				}
				input.ReadMessage(Base);
				break;
			case 34u:
				if (bag_ == null)
				{
					Bag = new RoleBagSyncWrapper();
				}
				input.ReadMessage(Bag);
				break;
			case 42u:
				if (actor_ == null)
				{
					Actor = new RoleActorSyncWrapper();
				}
				input.ReadMessage(Actor);
				break;
			case 50u:
				if (shop_ == null)
				{
					Shop = new RoleShopSyncWrapper();
				}
				input.ReadMessage(Shop);
				break;
			case 58u:
				if (task_ == null)
				{
					Task = new RoleTaskSyncWrapper();
				}
				input.ReadMessage(Task);
				break;
			case 66u:
				if (redPoint_ == null)
				{
					RedPoint = new RoleRedPointSyncWrapper();
				}
				input.ReadMessage(RedPoint);
				break;
			case 74u:
				if (drop_ == null)
				{
					Drop = new RoleDropSyncWrapper();
				}
				input.ReadMessage(Drop);
				break;
			case 82u:
				if (collection_ == null)
				{
					Collection = new RoleCollectionSyncWrapper();
				}
				input.ReadMessage(Collection);
				break;
			case 90u:
				if (interaction_ == null)
				{
					Interaction = new RoleInteractionSyncWrapper();
				}
				input.ReadMessage(Interaction);
				break;
			case 98u:
				if (achievement_ == null)
				{
					Achievement = new RoleAchievementSyncWrapper();
				}
				input.ReadMessage(Achievement);
				break;
			case 106u:
				if (chapter_ == null)
				{
					Chapter = new RoleChapterSyncWrapper();
				}
				input.ReadMessage(Chapter);
				break;
			case 114u:
				if (museum_ == null)
				{
					Museum = new RoleMuseumSyncWrapper();
				}
				input.ReadMessage(Museum);
				break;
			case 138u:
				if (garden_ == null)
				{
					Garden = new RoleGardenSyncWrapper();
				}
				input.ReadMessage(Garden);
				break;
			case 146u:
				if (activities_ == null)
				{
					Activities = new RoleActivitySyncWrapper();
				}
				input.ReadMessage(Activities);
				break;
			case 154u:
				if (bossRush_ == null)
				{
					BossRush = new RoleBossRushSyncWrapper();
				}
				input.ReadMessage(BossRush);
				break;
			}
		}
	}
}
