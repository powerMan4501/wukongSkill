using System.Text;

namespace CommB1;

public class ReadOnlyEffectAttrList
{
	private EffectAttrList mData;

	private ReadOnlyEffectAttrFloatList _Attrs;

	public ReadOnlyEffectAttrFloatList Attrs
	{
		get
		{
			if (_Attrs == null)
			{
				_Attrs = new ReadOnlyEffectAttrFloatList(mData.Attrs);
			}
			return _Attrs;
		}
	}

	public ReadOnlyEffectAttrList(EffectAttrList data)
	{
		mData = data;
	}

	public ReadOnlyEffectAttrList Clone()
	{
		return new ReadOnlyEffectAttrList(mData.Clone());
	}

	public EffectAttrList ForceGetRef()
	{
		return mData;
	}

	public EffectAttrList CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyEffectAttrList>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("Attrs=[\n");
		for (int i = 0; i < Attrs.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			Attrs[i].DumpAsString(builder, indent, cur_indent + indent + indent);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
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
