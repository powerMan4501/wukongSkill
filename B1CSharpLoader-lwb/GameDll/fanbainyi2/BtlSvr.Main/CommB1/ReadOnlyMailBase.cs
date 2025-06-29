using System.Text;

namespace CommB1;

public class ReadOnlyMailBase
{
	private MailBase mData;

	private ReadOnlyMailOption _Option;

	private ReadOnlyRoleItemList _Attachements;

	private ReadOnlyMailExt _Ext;

	public uint Id => mData.Id;

	public MailType MailType => mData.MailType;

	public MailState State => mData.State;

	public ReadOnlyMailOption Option
	{
		get
		{
			if (_Option == null && mData.Option != null)
			{
				_Option = new ReadOnlyMailOption(mData.Option);
			}
			return _Option;
		}
	}

	public ReadOnlyRoleItemList Attachements
	{
		get
		{
			if (_Attachements == null)
			{
				_Attachements = new ReadOnlyRoleItemList(mData.Attachements);
			}
			return _Attachements;
		}
	}

	public ReadOnlyMailExt Ext
	{
		get
		{
			if (_Ext == null && mData.Ext != null)
			{
				_Ext = new ReadOnlyMailExt(mData.Ext);
			}
			return _Ext;
		}
	}

	public ReadOnlyMailBase(MailBase data)
	{
		mData = data;
	}

	public ReadOnlyMailBase Clone()
	{
		return new ReadOnlyMailBase(mData.Clone());
	}

	public MailBase ForceGetRef()
	{
		return mData;
	}

	public MailBase CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyMailBase>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("Id={0},\n", Id);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("MailType={0},\n", MailType);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("State={0},\n", State);
		if (Option != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Option=");
			Option.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Option=null,\n");
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("Attachements=[\n");
		for (int i = 0; i < Attachements.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			Attachements[i].DumpAsString(builder, indent, cur_indent + indent + indent);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		if (Ext != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Ext=");
			Ext.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Ext=null,\n");
		}
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
