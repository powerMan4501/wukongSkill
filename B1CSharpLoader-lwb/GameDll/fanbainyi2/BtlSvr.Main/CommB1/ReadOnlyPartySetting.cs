using System.Text;

namespace CommB1;

public class ReadOnlyPartySetting
{
	private PartySetting mData;

	public uint MaxMemberNum => mData.MaxMemberNum;

	public PartyAdvertiseType AdvertiseType => mData.AdvertiseType;

	public string Password => mData.Password;

	public int TaskType => mData.TaskType;

	public ReadOnlyPartySetting(PartySetting data)
	{
		mData = data;
	}

	public ReadOnlyPartySetting Clone()
	{
		return new ReadOnlyPartySetting(mData.Clone());
	}

	public PartySetting ForceGetRef()
	{
		return mData;
	}

	public PartySetting CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyPartySetting>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("MaxMemberNum={0},\n", MaxMemberNum);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("AdvertiseType={0},\n", AdvertiseType);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Password={0},\n", Password);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("TaskType={0},\n", TaskType);
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
