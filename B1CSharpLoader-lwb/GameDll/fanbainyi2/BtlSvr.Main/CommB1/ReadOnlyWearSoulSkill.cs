using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyWearSoulSkill
{
	private WearSoulSkill mData;

	public int SoulSkillId => mData.SoulSkillId;

	public ulong Uid => mData.Uid;

	public ReadOnlyWearSoulSkill(WearSoulSkill data)
	{
		mData = data;
	}

	public ReadOnlyWearSoulSkill Clone()
	{
		return new ReadOnlyWearSoulSkill(mData.Clone());
	}

	public WearSoulSkill ForceGetRef()
	{
		return mData;
	}

	public WearSoulSkill CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyWearSoulSkill>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("SoulSkillId={0},\n", SoulSkillId);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Uid={0},\n", Uid);
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
