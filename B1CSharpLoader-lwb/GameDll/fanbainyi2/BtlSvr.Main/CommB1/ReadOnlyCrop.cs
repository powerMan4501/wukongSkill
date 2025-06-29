using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyCrop
{
	private Crop mData;

	private ReadOnlyCropOutputList _OutputList;

	public int SeedId => mData.SeedId;

	public ReadOnlyCropOutputList OutputList
	{
		get
		{
			if (_OutputList == null)
			{
				_OutputList = new ReadOnlyCropOutputList(mData.OutputList);
			}
			return _OutputList;
		}
	}

	public ReadOnlyCrop(Crop data)
	{
		mData = data;
	}

	public ReadOnlyCrop Clone()
	{
		return new ReadOnlyCrop(mData.Clone());
	}

	public Crop ForceGetRef()
	{
		return mData;
	}

	public Crop CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyCrop>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("SeedId={0},\n", SeedId);
		builder.Append(' ', cur_indent + indent);
		builder.Append("OutputList=[\n");
		for (int i = 0; i < OutputList.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			OutputList[i].DumpAsString(builder, indent, cur_indent + indent + indent);
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
