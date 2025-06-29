using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyNewGameResetStaticsData
{
	private NewGameResetStaticsData mData;

	private ReadOnlyLevelStaticsDataOneList _ConsoleLevelStatics;

	private ReadOnlyChapterStaticsDataOneList _ChapterStatics;

	public int LastGamePlusId => mData.LastGamePlusId;

	public ReadOnlyLevelStaticsDataOneList ConsoleLevelStatics
	{
		get
		{
			if (_ConsoleLevelStatics == null)
			{
				_ConsoleLevelStatics = new ReadOnlyLevelStaticsDataOneList(mData.ConsoleLevelStatics);
			}
			return _ConsoleLevelStatics;
		}
	}

	public ReadOnlyChapterStaticsDataOneList ChapterStatics
	{
		get
		{
			if (_ChapterStatics == null)
			{
				_ChapterStatics = new ReadOnlyChapterStaticsDataOneList(mData.ChapterStatics);
			}
			return _ChapterStatics;
		}
	}

	public ReadOnlyNewGameResetStaticsData(NewGameResetStaticsData data)
	{
		mData = data;
	}

	public ReadOnlyNewGameResetStaticsData Clone()
	{
		return new ReadOnlyNewGameResetStaticsData(mData.Clone());
	}

	public NewGameResetStaticsData ForceGetRef()
	{
		return mData;
	}

	public NewGameResetStaticsData CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyNewGameResetStaticsData>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("LastGamePlusId={0},\n", LastGamePlusId);
		builder.Append(' ', cur_indent + indent);
		builder.Append("ConsoleLevelStatics=[\n");
		for (int i = 0; i < ConsoleLevelStatics.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			ConsoleLevelStatics[i].DumpAsString(builder, indent, cur_indent + indent + indent);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("ChapterStatics=[\n");
		for (int j = 0; j < ChapterStatics.Count; j++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			ChapterStatics[j].DumpAsString(builder, indent, cur_indent + indent + indent);
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
