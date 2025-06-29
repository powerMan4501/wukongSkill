using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyEquipMantra
{
	private EquipMantra mData;

	public int Pos => mData.Pos;

	public int MantraId => mData.MantraId;

	public ReadOnlyEquipMantra(EquipMantra data)
	{
		mData = data;
	}

	public ReadOnlyEquipMantra Clone()
	{
		return new ReadOnlyEquipMantra(mData.Clone());
	}

	public EquipMantra ForceGetRef()
	{
		return mData;
	}

	public EquipMantra CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyEquipMantra>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Pos={0},\n", Pos);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("MantraId={0},\n", MantraId);
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
