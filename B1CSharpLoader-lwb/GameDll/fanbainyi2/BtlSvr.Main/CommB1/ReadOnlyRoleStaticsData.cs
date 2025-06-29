using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyRoleStaticsData
{
	private RoleStaticsData mData;

	private ReadOnlyArchiveStaticsOne _SummaryStatics;

	private ReadOnlyArchiveStaticsOneList _HistoryStatics;

	private ReadOnlyNewGameResetStaticsData _NewGameResetStatics;

	public ReadOnlyArchiveStaticsOne SummaryStatics
	{
		get
		{
			if (_SummaryStatics == null && mData.SummaryStatics != null)
			{
				_SummaryStatics = new ReadOnlyArchiveStaticsOne(mData.SummaryStatics);
			}
			return _SummaryStatics;
		}
	}

	public ReadOnlyArchiveStaticsOneList HistoryStatics
	{
		get
		{
			if (_HistoryStatics == null)
			{
				_HistoryStatics = new ReadOnlyArchiveStaticsOneList(mData.HistoryStatics);
			}
			return _HistoryStatics;
		}
	}

	public ReadOnlyNewGameResetStaticsData NewGameResetStatics
	{
		get
		{
			if (_NewGameResetStatics == null && mData.NewGameResetStatics != null)
			{
				_NewGameResetStatics = new ReadOnlyNewGameResetStaticsData(mData.NewGameResetStatics);
			}
			return _NewGameResetStatics;
		}
	}

	public ReadOnlyRoleStaticsData(RoleStaticsData data)
	{
		mData = data;
	}

	public ReadOnlyRoleStaticsData Clone()
	{
		return new ReadOnlyRoleStaticsData(mData.Clone());
	}

	public RoleStaticsData ForceGetRef()
	{
		return mData;
	}

	public RoleStaticsData CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyRoleStaticsData>{\n");
		if (SummaryStatics != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("SummaryStatics=");
			SummaryStatics.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("SummaryStatics=null,\n");
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("HistoryStatics=[\n");
		for (int i = 0; i < HistoryStatics.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			HistoryStatics[i].DumpAsString(builder, indent, cur_indent + indent + indent);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		if (NewGameResetStatics != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("NewGameResetStatics=");
			NewGameResetStatics.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("NewGameResetStatics=null,\n");
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
