using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyPastMemoriesOne
{
	private PastMemoriesOne mData;

	private ReadOnlyInt32List _WearEquip;

	public int Id => mData.Id;

	public ReadOnlyInt32List WearEquip
	{
		get
		{
			if (_WearEquip == null)
			{
				_WearEquip = new ReadOnlyInt32List(mData.WearEquip);
			}
			return _WearEquip;
		}
	}

	public ReadOnlyPastMemoriesOne(PastMemoriesOne data)
	{
		mData = data;
	}

	public ReadOnlyPastMemoriesOne Clone()
	{
		return new ReadOnlyPastMemoriesOne(mData.Clone());
	}

	public PastMemoriesOne ForceGetRef()
	{
		return mData;
	}

	public PastMemoriesOne CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyPastMemoriesOne>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Id={0},\n", Id);
		builder.Append(' ', cur_indent + indent);
		builder.Append("WearEquip=[\n");
		for (int i = 0; i < WearEquip.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", WearEquip[i]);
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
