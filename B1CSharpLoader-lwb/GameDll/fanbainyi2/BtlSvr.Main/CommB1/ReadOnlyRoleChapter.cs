using System.Text;
using ArchiveB1;
using ResB1;

namespace CommB1;

public class ReadOnlyRoleChapter
{
	private RoleChapter mData;

	private ReadOnlyChapterDataList _ChapterList;

	private ReadOnlyAwardItemList _StashChapterAwardList;

	public int CurChapter => mData.CurChapter;

	public ReadOnlyChapterDataList ChapterList
	{
		get
		{
			if (_ChapterList == null)
			{
				_ChapterList = new ReadOnlyChapterDataList(mData.ChapterList);
			}
			return _ChapterList;
		}
	}

	public YesNoType GameCompelete => mData.GameCompelete;

	public ReadOnlyAwardItemList StashChapterAwardList
	{
		get
		{
			if (_StashChapterAwardList == null)
			{
				_StashChapterAwardList = new ReadOnlyAwardItemList(mData.StashChapterAwardList);
			}
			return _StashChapterAwardList;
		}
	}

	public ReadOnlyRoleChapter(RoleChapter data)
	{
		mData = data;
	}

	public ReadOnlyRoleChapter Clone()
	{
		return new ReadOnlyRoleChapter(mData.Clone());
	}

	public RoleChapter ForceGetRef()
	{
		return mData;
	}

	public RoleChapter CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyRoleChapter>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("CurChapter={0},\n", CurChapter);
		builder.Append(' ', cur_indent + indent);
		builder.Append("ChapterList=[\n");
		for (int i = 0; i < ChapterList.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			ChapterList[i].DumpAsString(builder, indent, cur_indent + indent + indent);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("GameCompelete={0},\n", GameCompelete);
		builder.Append(' ', cur_indent + indent);
		builder.Append("StashChapterAwardList=[\n");
		for (int j = 0; j < StashChapterAwardList.Count; j++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			StashChapterAwardList[j].DumpAsString(builder, indent, cur_indent + indent + indent);
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
