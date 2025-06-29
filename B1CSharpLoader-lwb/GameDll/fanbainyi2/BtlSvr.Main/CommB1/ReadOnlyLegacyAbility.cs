using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyLegacyAbility
{
	private LegacyAbility mData;

	private ReadOnlyLegacyTalentList _TalentList;

	public int LegacyId => mData.LegacyId;

	public int TalentPoint => mData.TalentPoint;

	public ReadOnlyLegacyTalentList TalentList
	{
		get
		{
			if (_TalentList == null)
			{
				_TalentList = new ReadOnlyLegacyTalentList(mData.TalentList);
			}
			return _TalentList;
		}
	}

	public ReadOnlyLegacyAbility(LegacyAbility data)
	{
		mData = data;
	}

	public ReadOnlyLegacyAbility Clone()
	{
		return new ReadOnlyLegacyAbility(mData.Clone());
	}

	public LegacyAbility ForceGetRef()
	{
		return mData;
	}

	public LegacyAbility CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyLegacyAbility>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("LegacyId={0},\n", LegacyId);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("TalentPoint={0},\n", TalentPoint);
		builder.Append(' ', cur_indent + indent);
		builder.Append("TalentList=[\n");
		for (int i = 0; i < TalentList.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			TalentList[i].DumpAsString(builder, indent, cur_indent + indent + indent);
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
