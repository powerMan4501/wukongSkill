using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyGlobalData
{
	private GlobalData mData;

	public bool ShowSoulSkillBtn => mData.ShowSoulSkillBtn;

	public bool ShowFabaoBtn => mData.ShowFabaoBtn;

	public bool ShowJinDouYunBtn => mData.ShowJinDouYunBtn;

	public bool ShowPropStanceBtn => mData.ShowPropStanceBtn;

	public bool ShowPokeStanceBtn => mData.ShowPokeStanceBtn;

	public bool ReachEndA => mData.ReachEndA;

	public bool ReachEndB => mData.ReachEndB;

	public bool HaveShowGameLevelPassTips => mData.HaveShowGameLevelPassTips;

	public bool HaveShowBossRushTips => mData.HaveShowBossRushTips;

	public bool HaveShowMapTips => mData.HaveShowMapTips;

	public ReadOnlyGlobalData(GlobalData data)
	{
		mData = data;
	}

	public ReadOnlyGlobalData Clone()
	{
		return new ReadOnlyGlobalData(mData.Clone());
	}

	public GlobalData ForceGetRef()
	{
		return mData;
	}

	public GlobalData CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyGlobalData>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("ShowSoulSkillBtn={0},\n", ShowSoulSkillBtn);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("ShowFabaoBtn={0},\n", ShowFabaoBtn);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("ShowJinDouYunBtn={0},\n", ShowJinDouYunBtn);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("ShowPropStanceBtn={0},\n", ShowPropStanceBtn);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("ShowPokeStanceBtn={0},\n", ShowPokeStanceBtn);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("ReachEndA={0},\n", ReachEndA);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("ReachEndB={0},\n", ReachEndB);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("HaveShowGameLevelPassTips={0},\n", HaveShowGameLevelPassTips);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("HaveShowBossRushTips={0},\n", HaveShowBossRushTips);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("HaveShowMapTips={0},\n", HaveShowMapTips);
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
