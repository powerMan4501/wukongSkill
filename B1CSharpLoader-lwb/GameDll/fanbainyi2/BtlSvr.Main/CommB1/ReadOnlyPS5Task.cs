using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyPS5Task
{
	private PS5Task mData;

	public int Id => mData.Id;

	public ReadOnlyPS5Task(PS5Task data)
	{
		mData = data;
	}

	public ReadOnlyPS5Task Clone()
	{
		return new ReadOnlyPS5Task(mData.Clone());
	}

	public PS5Task ForceGetRef()
	{
		return mData;
	}

	public PS5Task CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyPS5Task>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Id={0},\n", Id);
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
