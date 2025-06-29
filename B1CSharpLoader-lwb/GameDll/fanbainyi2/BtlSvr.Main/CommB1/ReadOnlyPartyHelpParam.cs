using System.Text;

namespace CommB1;

public class ReadOnlyPartyHelpParam
{
	private PartyHelpParam mData;

	public int Dummy => mData.Dummy;

	public ReadOnlyPartyHelpParam(PartyHelpParam data)
	{
		mData = data;
	}

	public ReadOnlyPartyHelpParam Clone()
	{
		return new ReadOnlyPartyHelpParam(mData.Clone());
	}

	public PartyHelpParam ForceGetRef()
	{
		return mData;
	}

	public PartyHelpParam CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyPartyHelpParam>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Dummy={0},\n", Dummy);
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
