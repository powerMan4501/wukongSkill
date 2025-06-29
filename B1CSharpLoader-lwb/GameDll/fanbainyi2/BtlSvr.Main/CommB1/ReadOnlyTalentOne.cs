using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyTalentOne
{
	private TalentOne mData;

	public int Id => mData.Id;

	public int Level => mData.Level;

	public ReadOnlyTalentOne(TalentOne data)
	{
		mData = data;
	}

	public ReadOnlyTalentOne Clone()
	{
		return new ReadOnlyTalentOne(mData.Clone());
	}

	public TalentOne ForceGetRef()
	{
		return mData;
	}

	public TalentOne CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyTalentOne>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Id={0},\n", Id);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Level={0},\n", Level);
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
