using System.Text;

namespace CommB1;

public class ReadOnlyPartyTaskParam
{
	private PartyTaskParam mData;

	public int LevelId => mData.LevelId;

	public ReadOnlyPartyTaskParam(PartyTaskParam data)
	{
		mData = data;
	}

	public ReadOnlyPartyTaskParam Clone()
	{
		return new ReadOnlyPartyTaskParam(mData.Clone());
	}

	public PartyTaskParam ForceGetRef()
	{
		return mData;
	}

	public PartyTaskParam CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyPartyTaskParam>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("LevelId={0},\n", LevelId);
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
