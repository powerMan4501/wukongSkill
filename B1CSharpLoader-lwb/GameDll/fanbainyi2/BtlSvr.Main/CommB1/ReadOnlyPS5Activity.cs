using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyPS5Activity
{
	private PS5Activity mData;

	private ReadOnlyInt32List _TaskIdList;

	public int Id => mData.Id;

	public ReadOnlyInt32List TaskIdList
	{
		get
		{
			if (_TaskIdList == null)
			{
				_TaskIdList = new ReadOnlyInt32List(mData.TaskIdList);
			}
			return _TaskIdList;
		}
	}

	public ReadOnlyPS5Activity(PS5Activity data)
	{
		mData = data;
	}

	public ReadOnlyPS5Activity Clone()
	{
		return new ReadOnlyPS5Activity(mData.Clone());
	}

	public PS5Activity ForceGetRef()
	{
		return mData;
	}

	public PS5Activity CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyPS5Activity>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Id={0},\n", Id);
		builder.Append(' ', cur_indent + indent);
		builder.Append("TaskIdList=[\n");
		for (int i = 0; i < TaskIdList.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", TaskIdList[i]);
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
