using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyRoleSoulSkill
{
	private RoleSoulSkill mData;

	public int SoulSkillId => mData.SoulSkillId;

	public ulong Uid => mData.Uid;

	public ReadOnlyRoleSoulSkill(RoleSoulSkill data)
	{
		mData = data;
	}

	public ReadOnlyRoleSoulSkill Clone()
	{
		return new ReadOnlyRoleSoulSkill(mData.Clone());
	}

	public RoleSoulSkill ForceGetRef()
	{
		return mData;
	}

	public RoleSoulSkill CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyRoleSoulSkill>{\n");
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
