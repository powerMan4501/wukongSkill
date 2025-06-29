using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyActorProgress
{
	private ActorProgress mData;

	private ReadOnlyInt32List _SpellList;

	private ReadOnlyTalentOneList _TalenList;

	private ReadOnlyLegacyAbilityList _LegacyList;

	private ReadOnlyInt32List _AwardMeditationList;

	private ReadOnlyMeditationOneList _MeditationsList;

	private ReadOnlyInt32List _AwardTalentPointMeditationList;

	public int Xp => mData.Xp;

	public int TalenPoint => mData.TalenPoint;

	public ReadOnlyInt32List SpellList
	{
		get
		{
			if (_SpellList == null)
			{
				_SpellList = new ReadOnlyInt32List(mData.SpellList);
			}
			return _SpellList;
		}
	}

	public ReadOnlyTalentOneList TalenList
	{
		get
		{
			if (_TalenList == null)
			{
				_TalenList = new ReadOnlyTalentOneList(mData.TalenList);
			}
			return _TalenList;
		}
	}

	public int XpTotal => mData.XpTotal;

	public ReadOnlyLegacyAbilityList LegacyList
	{
		get
		{
			if (_LegacyList == null)
			{
				_LegacyList = new ReadOnlyLegacyAbilityList(mData.LegacyList);
			}
			return _LegacyList;
		}
	}

	public ReadOnlyInt32List AwardMeditationList
	{
		get
		{
			if (_AwardMeditationList == null)
			{
				_AwardMeditationList = new ReadOnlyInt32List(mData.AwardMeditationList);
			}
			return _AwardMeditationList;
		}
	}

	public ReadOnlyMeditationOneList MeditationsList
	{
		get
		{
			if (_MeditationsList == null)
			{
				_MeditationsList = new ReadOnlyMeditationOneList(mData.MeditationsList);
			}
			return _MeditationsList;
		}
	}

	public ReadOnlyInt32List AwardTalentPointMeditationList
	{
		get
		{
			if (_AwardTalentPointMeditationList == null)
			{
				_AwardTalentPointMeditationList = new ReadOnlyInt32List(mData.AwardTalentPointMeditationList);
			}
			return _AwardTalentPointMeditationList;
		}
	}

	public ReadOnlyActorProgress(ActorProgress data)
	{
		mData = data;
	}

	public ReadOnlyActorProgress Clone()
	{
		return new ReadOnlyActorProgress(mData.Clone());
	}

	public ActorProgress ForceGetRef()
	{
		return mData;
	}

	public ActorProgress CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyActorProgress>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Xp={0},\n", Xp);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("TalenPoint={0},\n", TalenPoint);
		builder.Append(' ', cur_indent + indent);
		builder.Append("SpellList=[\n");
		for (int i = 0; i < SpellList.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", SpellList[i]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("TalenList=[\n");
		for (int j = 0; j < TalenList.Count; j++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			TalenList[j].DumpAsString(builder, indent, cur_indent + indent + indent);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("XpTotal={0},\n", XpTotal);
		builder.Append(' ', cur_indent + indent);
		builder.Append("LegacyList=[\n");
		for (int k = 0; k < LegacyList.Count; k++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			LegacyList[k].DumpAsString(builder, indent, cur_indent + indent + indent);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("AwardMeditationList=[\n");
		for (int l = 0; l < AwardMeditationList.Count; l++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", AwardMeditationList[l]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("MeditationsList=[\n");
		for (int m = 0; m < MeditationsList.Count; m++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			MeditationsList[m].DumpAsString(builder, indent, cur_indent + indent + indent);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("AwardTalentPointMeditationList=[\n");
		for (int n = 0; n < AwardTalentPointMeditationList.Count; n++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", AwardTalentPointMeditationList[n]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
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
