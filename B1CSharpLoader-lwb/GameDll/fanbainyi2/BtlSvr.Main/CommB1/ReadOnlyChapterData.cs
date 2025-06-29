using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyChapterData
{
	private ChapterData mData;

	private ReadOnlyInt32List _SurpriseList;

	public int Id => mData.Id;

	public ChapterStage Stage => mData.Stage;

	public ReadOnlyInt32List SurpriseList
	{
		get
		{
			if (_SurpriseList == null)
			{
				_SurpriseList = new ReadOnlyInt32List(mData.SurpriseList);
			}
			return _SurpriseList;
		}
	}

	public ReadOnlyChapterData(ChapterData data)
	{
		mData = data;
	}

	public ReadOnlyChapterData Clone()
	{
		return new ReadOnlyChapterData(mData.Clone());
	}

	public ChapterData ForceGetRef()
	{
		return mData;
	}

	public ChapterData CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyChapterData>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Id={0},\n", Id);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Stage={0},\n", Stage);
		builder.Append(' ', cur_indent + indent);
		builder.Append("SurpriseList=[\n");
		for (int i = 0; i < SurpriseList.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", SurpriseList[i]);
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
