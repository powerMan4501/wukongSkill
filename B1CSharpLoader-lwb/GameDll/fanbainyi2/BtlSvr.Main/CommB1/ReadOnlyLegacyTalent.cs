using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyLegacyTalent
{
	private LegacyTalent mData;

	public int TalentId => mData.TalentId;

	public bool IsActive => mData.IsActive;

	public ReadOnlyLegacyTalent(LegacyTalent data)
	{
		mData = data;
	}

	public ReadOnlyLegacyTalent Clone()
	{
		return new ReadOnlyLegacyTalent(mData.Clone());
	}

	public LegacyTalent ForceGetRef()
	{
		return mData;
	}

	public LegacyTalent CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyLegacyTalent>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("TalentId={0},\n", TalentId);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("IsActive={0},\n", IsActive);
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
