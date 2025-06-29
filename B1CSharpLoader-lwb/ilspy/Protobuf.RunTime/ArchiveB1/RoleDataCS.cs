using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class RoleDataCS : IMessage<RoleDataCS>, IMessage, IEquatable<RoleDataCS>, IDeepCloneable<RoleDataCS>
{
	private static readonly MessageParser<RoleDataCS> _parser = new MessageParser<RoleDataCS>(() => new RoleDataCS());

	private UnknownFieldSet _unknownFields;

	private RoleBase base_;

	private RoleBag bag_;

	private RoleActor actor_;

	private RoleShop shop_;

	private RoleTask task_;

	private RoleRedPoint redPoint_;

	private RoleDrop drop_;

	private RoleCollection collection_;

	private RoleInteraction interaction_;

	private RoleAchievement achievement_;

	private RoleChapter chapter_;

	private RoleMuseum museum_;

	private RoleGarden garden_;

	private RoleActivity activities_;

	private RoleBossRush bossRush_;

	public static MessageParser<RoleDataCS> Parser => _parser;

	public RoleBase Base
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

	public RoleBag Bag
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

	public RoleActor Actor
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

	public RoleShop Shop
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

	public RoleTask Task
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

	public RoleRedPoint RedPoint
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

	public RoleDrop Drop
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

	public RoleCollection Collection
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

	public RoleInteraction Interaction
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

	public RoleAchievement Achievement
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

	public RoleChapter Chapter
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

	public RoleMuseum Museum
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

	public RoleGarden Garden
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

	public RoleActivity Activities
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

	public RoleBossRush BossRush
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

	public RoleDataCS()
	{
	}

	public RoleDataCS(RoleDataCS other)
		: this()
	{
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

	public RoleDataCS Clone()
	{
		return new RoleDataCS(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleDataCS);
	}

	public bool Equals(RoleDataCS other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
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
		if (base_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Base);
		}
		if (bag_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Bag);
		}
		if (actor_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Actor);
		}
		if (shop_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Shop);
		}
		if (task_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(Task);
		}
		if (redPoint_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(RedPoint);
		}
		if (drop_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(Drop);
		}
		if (collection_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(Collection);
		}
		if (interaction_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(Interaction);
		}
		if (achievement_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(Achievement);
		}
		if (chapter_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(Chapter);
		}
		if (museum_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(Museum);
		}
		if (garden_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(Garden);
		}
		if (activities_ != null)
		{
			output.WriteRawTag(130, 1);
			output.WriteMessage(Activities);
		}
		if (bossRush_ != null)
		{
			output.WriteRawTag(138, 1);
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
			num += 1 + CodedOutputStream.ComputeMessageSize(Garden);
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

	public void MergeFrom(RoleDataCS other)
	{
		if (other == null)
		{
			return;
		}
		if (other.base_ != null)
		{
			if (base_ == null)
			{
				Base = new RoleBase();
			}
			Base.MergeFrom(other.Base);
		}
		if (other.bag_ != null)
		{
			if (bag_ == null)
			{
				Bag = new RoleBag();
			}
			Bag.MergeFrom(other.Bag);
		}
		if (other.actor_ != null)
		{
			if (actor_ == null)
			{
				Actor = new RoleActor();
			}
			Actor.MergeFrom(other.Actor);
		}
		if (other.shop_ != null)
		{
			if (shop_ == null)
			{
				Shop = new RoleShop();
			}
			Shop.MergeFrom(other.Shop);
		}
		if (other.task_ != null)
		{
			if (task_ == null)
			{
				Task = new RoleTask();
			}
			Task.MergeFrom(other.Task);
		}
		if (other.redPoint_ != null)
		{
			if (redPoint_ == null)
			{
				RedPoint = new RoleRedPoint();
			}
			RedPoint.MergeFrom(other.RedPoint);
		}
		if (other.drop_ != null)
		{
			if (drop_ == null)
			{
				Drop = new RoleDrop();
			}
			Drop.MergeFrom(other.Drop);
		}
		if (other.collection_ != null)
		{
			if (collection_ == null)
			{
				Collection = new RoleCollection();
			}
			Collection.MergeFrom(other.Collection);
		}
		if (other.interaction_ != null)
		{
			if (interaction_ == null)
			{
				Interaction = new RoleInteraction();
			}
			Interaction.MergeFrom(other.Interaction);
		}
		if (other.achievement_ != null)
		{
			if (achievement_ == null)
			{
				Achievement = new RoleAchievement();
			}
			Achievement.MergeFrom(other.Achievement);
		}
		if (other.chapter_ != null)
		{
			if (chapter_ == null)
			{
				Chapter = new RoleChapter();
			}
			Chapter.MergeFrom(other.Chapter);
		}
		if (other.museum_ != null)
		{
			if (museum_ == null)
			{
				Museum = new RoleMuseum();
			}
			Museum.MergeFrom(other.Museum);
		}
		if (other.garden_ != null)
		{
			if (garden_ == null)
			{
				Garden = new RoleGarden();
			}
			Garden.MergeFrom(other.Garden);
		}
		if (other.activities_ != null)
		{
			if (activities_ == null)
			{
				Activities = new RoleActivity();
			}
			Activities.MergeFrom(other.Activities);
		}
		if (other.bossRush_ != null)
		{
			if (bossRush_ == null)
			{
				BossRush = new RoleBossRush();
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
			case 10u:
				if (base_ == null)
				{
					Base = new RoleBase();
				}
				input.ReadMessage(Base);
				break;
			case 18u:
				if (bag_ == null)
				{
					Bag = new RoleBag();
				}
				input.ReadMessage(Bag);
				break;
			case 26u:
				if (actor_ == null)
				{
					Actor = new RoleActor();
				}
				input.ReadMessage(Actor);
				break;
			case 34u:
				if (shop_ == null)
				{
					Shop = new RoleShop();
				}
				input.ReadMessage(Shop);
				break;
			case 42u:
				if (task_ == null)
				{
					Task = new RoleTask();
				}
				input.ReadMessage(Task);
				break;
			case 50u:
				if (redPoint_ == null)
				{
					RedPoint = new RoleRedPoint();
				}
				input.ReadMessage(RedPoint);
				break;
			case 58u:
				if (drop_ == null)
				{
					Drop = new RoleDrop();
				}
				input.ReadMessage(Drop);
				break;
			case 66u:
				if (collection_ == null)
				{
					Collection = new RoleCollection();
				}
				input.ReadMessage(Collection);
				break;
			case 74u:
				if (interaction_ == null)
				{
					Interaction = new RoleInteraction();
				}
				input.ReadMessage(Interaction);
				break;
			case 82u:
				if (achievement_ == null)
				{
					Achievement = new RoleAchievement();
				}
				input.ReadMessage(Achievement);
				break;
			case 90u:
				if (chapter_ == null)
				{
					Chapter = new RoleChapter();
				}
				input.ReadMessage(Chapter);
				break;
			case 98u:
				if (museum_ == null)
				{
					Museum = new RoleMuseum();
				}
				input.ReadMessage(Museum);
				break;
			case 122u:
				if (garden_ == null)
				{
					Garden = new RoleGarden();
				}
				input.ReadMessage(Garden);
				break;
			case 130u:
				if (activities_ == null)
				{
					Activities = new RoleActivity();
				}
				input.ReadMessage(Activities);
				break;
			case 138u:
				if (bossRush_ == null)
				{
					BossRush = new RoleBossRush();
				}
				input.ReadMessage(BossRush);
				break;
			}
		}
	}
}
