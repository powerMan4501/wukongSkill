using System.Text;

namespace CommB1;

public class ReadOnlyAwolMsgPlayerCommand
{
	private AwolMsgPlayerCommand mData;

	private ReadOnlyPlayerCommandParam _Param;

	public PlayerCommandType CmdType => mData.CmdType;

	public ReadOnlyPlayerCommandParam Param
	{
		get
		{
			if (_Param == null && mData.Param != null)
			{
				_Param = new ReadOnlyPlayerCommandParam(mData.Param);
			}
			return _Param;
		}
	}

	public ReadOnlyAwolMsgPlayerCommand(AwolMsgPlayerCommand data)
	{
		mData = data;
	}

	public ReadOnlyAwolMsgPlayerCommand Clone()
	{
		return new ReadOnlyAwolMsgPlayerCommand(mData.Clone());
	}

	public AwolMsgPlayerCommand ForceGetRef()
	{
		return mData;
	}

	public AwolMsgPlayerCommand CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyAwolMsgPlayerCommand>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("CmdType={0},\n", CmdType);
		if (Param != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Param=");
			Param.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Param=null,\n");
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
