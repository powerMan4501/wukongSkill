using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyCropOutput
{
	private CropOutput mData;

	private ReadOnlyOutputConfig _OutputConfig;

	public ReadOnlyOutputConfig OutputConfig
	{
		get
		{
			if (_OutputConfig == null && mData.OutputConfig != null)
			{
				_OutputConfig = new ReadOnlyOutputConfig(mData.OutputConfig);
			}
			return _OutputConfig;
		}
	}

	public int OutputCount => mData.OutputCount;

	public float DeltaTime => mData.DeltaTime;

	public ReadOnlyCropOutput(CropOutput data)
	{
		mData = data;
	}

	public ReadOnlyCropOutput Clone()
	{
		return new ReadOnlyCropOutput(mData.Clone());
	}

	public CropOutput ForceGetRef()
	{
		return mData;
	}

	public CropOutput CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyCropOutput>{\n");
		if (OutputConfig != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("OutputConfig=");
			OutputConfig.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("OutputConfig=null,\n");
		}
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("OutputCount={0},\n", OutputCount);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("DeltaTime={0},\n", DeltaTime);
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
