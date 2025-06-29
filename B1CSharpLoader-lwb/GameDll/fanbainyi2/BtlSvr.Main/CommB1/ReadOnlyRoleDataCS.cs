using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyRoleDataCS
{
	private RoleDataCS mData;

	private ReadOnlyRoleBase _Base;

	private ReadOnlyRoleBag _Bag;

	private ReadOnlyRoleActor _Actor;

	private ReadOnlyRoleShop _Shop;

	private ReadOnlyRoleTask _Task;

	private ReadOnlyRoleRedPoint _RedPoint;

	private ReadOnlyRoleDrop _Drop;

	private ReadOnlyRoleCollection _Collection;

	private ReadOnlyRoleInteraction _Interaction;

	private ReadOnlyRoleAchievement _Achievement;

	private ReadOnlyRoleChapter _Chapter;

	private ReadOnlyRoleMuseum _Museum;

	private ReadOnlyRoleGarden _Garden;

	private ReadOnlyRoleActivity _Activities;

	private ReadOnlyRoleBossRush _BossRush;

	public ReadOnlyRoleBase Base
	{
		get
		{
			if (_Base == null && mData.Base != null)
			{
				_Base = new ReadOnlyRoleBase(mData.Base);
			}
			return _Base;
		}
	}

	public ReadOnlyRoleBag Bag
	{
		get
		{
			if (_Bag == null && mData.Bag != null)
			{
				_Bag = new ReadOnlyRoleBag(mData.Bag);
			}
			return _Bag;
		}
	}

	public ReadOnlyRoleActor Actor
	{
		get
		{
			if (_Actor == null && mData.Actor != null)
			{
				_Actor = new ReadOnlyRoleActor(mData.Actor);
			}
			return _Actor;
		}
	}

	public ReadOnlyRoleShop Shop
	{
		get
		{
			if (_Shop == null && mData.Shop != null)
			{
				_Shop = new ReadOnlyRoleShop(mData.Shop);
			}
			return _Shop;
		}
	}

	public ReadOnlyRoleTask Task
	{
		get
		{
			if (_Task == null && mData.Task != null)
			{
				_Task = new ReadOnlyRoleTask(mData.Task);
			}
			return _Task;
		}
	}

	public ReadOnlyRoleRedPoint RedPoint
	{
		get
		{
			if (_RedPoint == null && mData.RedPoint != null)
			{
				_RedPoint = new ReadOnlyRoleRedPoint(mData.RedPoint);
			}
			return _RedPoint;
		}
	}

	public ReadOnlyRoleDrop Drop
	{
		get
		{
			if (_Drop == null && mData.Drop != null)
			{
				_Drop = new ReadOnlyRoleDrop(mData.Drop);
			}
			return _Drop;
		}
	}

	public ReadOnlyRoleCollection Collection
	{
		get
		{
			if (_Collection == null && mData.Collection != null)
			{
				_Collection = new ReadOnlyRoleCollection(mData.Collection);
			}
			return _Collection;
		}
	}

	public ReadOnlyRoleInteraction Interaction
	{
		get
		{
			if (_Interaction == null && mData.Interaction != null)
			{
				_Interaction = new ReadOnlyRoleInteraction(mData.Interaction);
			}
			return _Interaction;
		}
	}

	public ReadOnlyRoleAchievement Achievement
	{
		get
		{
			if (_Achievement == null && mData.Achievement != null)
			{
				_Achievement = new ReadOnlyRoleAchievement(mData.Achievement);
			}
			return _Achievement;
		}
	}

	public ReadOnlyRoleChapter Chapter
	{
		get
		{
			if (_Chapter == null && mData.Chapter != null)
			{
				_Chapter = new ReadOnlyRoleChapter(mData.Chapter);
			}
			return _Chapter;
		}
	}

	public ReadOnlyRoleMuseum Museum
	{
		get
		{
			if (_Museum == null && mData.Museum != null)
			{
				_Museum = new ReadOnlyRoleMuseum(mData.Museum);
			}
			return _Museum;
		}
	}

	public ReadOnlyRoleGarden Garden
	{
		get
		{
			if (_Garden == null && mData.Garden != null)
			{
				_Garden = new ReadOnlyRoleGarden(mData.Garden);
			}
			return _Garden;
		}
	}

	public ReadOnlyRoleActivity Activities
	{
		get
		{
			if (_Activities == null && mData.Activities != null)
			{
				_Activities = new ReadOnlyRoleActivity(mData.Activities);
			}
			return _Activities;
		}
	}

	public ReadOnlyRoleBossRush BossRush
	{
		get
		{
			if (_BossRush == null && mData.BossRush != null)
			{
				_BossRush = new ReadOnlyRoleBossRush(mData.BossRush);
			}
			return _BossRush;
		}
	}

	public ReadOnlyRoleDataCS(RoleDataCS data)
	{
		mData = data;
	}

	public ReadOnlyRoleDataCS Clone()
	{
		return new ReadOnlyRoleDataCS(mData.Clone());
	}

	public RoleDataCS ForceGetRef()
	{
		return mData;
	}

	public RoleDataCS CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyRoleDataCS>{\n");
		if (Base != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Base=");
			Base.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Base=null,\n");
		}
		if (Bag != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Bag=");
			Bag.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Bag=null,\n");
		}
		if (Actor != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Actor=");
			Actor.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Actor=null,\n");
		}
		if (Shop != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Shop=");
			Shop.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Shop=null,\n");
		}
		if (Task != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Task=");
			Task.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Task=null,\n");
		}
		if (RedPoint != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("RedPoint=");
			RedPoint.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("RedPoint=null,\n");
		}
		if (Drop != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Drop=");
			Drop.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Drop=null,\n");
		}
		if (Collection != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Collection=");
			Collection.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Collection=null,\n");
		}
		if (Interaction != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Interaction=");
			Interaction.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Interaction=null,\n");
		}
		if (Achievement != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Achievement=");
			Achievement.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Achievement=null,\n");
		}
		if (Chapter != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Chapter=");
			Chapter.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Chapter=null,\n");
		}
		if (Museum != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Museum=");
			Museum.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Museum=null,\n");
		}
		if (Garden != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Garden=");
			Garden.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Garden=null,\n");
		}
		if (Activities != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Activities=");
			Activities.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Activities=null,\n");
		}
		if (BossRush != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("BossRush=");
			BossRush.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("BossRush=null,\n");
		}
		builder.Append(' ', cur_indent);
		builder.Append("},\n");
	}

	public string GSToString(int indent = 4)
	{
		StringBuilder stringBuilder = new StringBuilder();
		DumpAsString(stringBuilder, indent, 0);
		stringBuilder.Insert(0, "\n", 1);
		return stringBuilder.ToString();
	}
}
