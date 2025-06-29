using System.Text;
using ArchiveB1;
using BtlB1;

namespace CommB1;

public class ReadOnlyActorWear
{
	private ActorWear mData;

	private ReadOnlyWearEquipList _EquipList;

	private ReadOnlyShortcutItemList _ShortcutsList;

	private ReadOnlySpellItemList _SpellList;

	private ReadOnlyWearSoulSkill _WearSoulSkill;

	private ReadOnlyWearAccessory _WearAccessory;

	public ReadOnlyWearEquipList EquipList
	{
		get
		{
			if (_EquipList == null)
			{
				_EquipList = new ReadOnlyWearEquipList(mData.EquipList);
			}
			return _EquipList;
		}
	}

	public ReadOnlyShortcutItemList ShortcutsList
	{
		get
		{
			if (_ShortcutsList == null)
			{
				_ShortcutsList = new ReadOnlyShortcutItemList(mData.ShortcutsList);
			}
			return _ShortcutsList;
		}
	}

	public ReadOnlySpellItemList SpellList
	{
		get
		{
			if (_SpellList == null)
			{
				_SpellList = new ReadOnlySpellItemList(mData.SpellList);
			}
			return _SpellList;
		}
	}

	public SpellType DefaultSpellType => mData.DefaultSpellType;

	public int WineId => mData.WineId;

	public Stance Stance => mData.Stance;

	public ReadOnlyWearSoulSkill WearSoulSkill
	{
		get
		{
			if (_WearSoulSkill == null && mData.WearSoulSkill != null)
			{
				_WearSoulSkill = new ReadOnlyWearSoulSkill(mData.WearSoulSkill);
			}
			return _WearSoulSkill;
		}
	}

	public ReadOnlyWearAccessory WearAccessory
	{
		get
		{
			if (_WearAccessory == null && mData.WearAccessory != null)
			{
				_WearAccessory = new ReadOnlyWearAccessory(mData.WearAccessory);
			}
			return _WearAccessory;
		}
	}

	public ReadOnlyActorWear(ActorWear data)
	{
		mData = data;
	}

	public ReadOnlyActorWear Clone()
	{
		return new ReadOnlyActorWear(mData.Clone());
	}

	public ActorWear ForceGetRef()
	{
		return mData;
	}

	public ActorWear CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyActorWear>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("EquipList=[\n");
		for (int i = 0; i < EquipList.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			EquipList[i].DumpAsString(builder, indent, cur_indent + indent + indent);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("ShortcutsList=[\n");
		for (int j = 0; j < ShortcutsList.Count; j++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			ShortcutsList[j].DumpAsString(builder, indent, cur_indent + indent + indent);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("SpellList=[\n");
		for (int k = 0; k < SpellList.Count; k++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			SpellList[k].DumpAsString(builder, indent, cur_indent + indent + indent);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("DefaultSpellType={0},\n", DefaultSpellType);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("WineId={0},\n", WineId);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Stance={0},\n", Stance);
		if (WearSoulSkill != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("WearSoulSkill=");
			WearSoulSkill.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("WearSoulSkill=null,\n");
		}
		if (WearAccessory != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("WearAccessory=");
			WearAccessory.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("WearAccessory=null,\n");
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
