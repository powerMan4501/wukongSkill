using System.Text;
using BtlShare;

namespace CommB1;

public class ReadOnlyEffectAttrFloat
{
	private EffectAttrFloat mData;

	public EBGUAttrFloat Type => mData.Type;

	public float Value => mData.Value;

	public ReadOnlyEffectAttrFloat(EffectAttrFloat data)
	{
		mData = data;
	}

	public ReadOnlyEffectAttrFloat Clone()
	{
		return new ReadOnlyEffectAttrFloat(mData.Clone());
	}

	public EffectAttrFloat ForceGetRef()
	{
		return mData;
	}

	public EffectAttrFloat CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyEffectAttrFloat>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Type={0},\n", Type);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Value={0},\n", Value);
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
