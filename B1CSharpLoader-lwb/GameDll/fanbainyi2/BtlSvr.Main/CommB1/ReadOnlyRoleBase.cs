using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyRoleBase
{
	private RoleBase mData;

	public ulong Roleid => mData.Roleid;

	public string Name => mData.Name;

	public int Level => mData.Level;

	public int ArchiveId => mData.ArchiveId;

	public ProtocolTag ProtoTag => mData.ProtoTag;

	public ReadOnlyRoleBase(RoleBase data)
	{
		mData = data;
	}

	public ReadOnlyRoleBase Clone()
	{
		return new ReadOnlyRoleBase(mData.Clone());
	}

	public RoleBase ForceGetRef()
	{
		return mData;
	}

	public RoleBase CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyRoleBase>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Roleid={0},\n", Roleid);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Name={0},\n", Name);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Level={0},\n", Level);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("ArchiveId={0},\n", ArchiveId);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("ProtoTag={0},\n", ProtoTag);
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
