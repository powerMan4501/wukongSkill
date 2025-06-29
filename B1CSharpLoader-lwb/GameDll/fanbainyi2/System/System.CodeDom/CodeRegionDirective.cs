using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeRegionDirective : CodeDirective
{
	private string regionText;

	private CodeRegionMode regionMode;

	public string RegionText
	{
		get
		{
			if (regionText != null)
			{
				return regionText;
			}
			return string.Empty;
		}
		set
		{
			regionText = value;
		}
	}

	public CodeRegionMode RegionMode
	{
		get
		{
			return regionMode;
		}
		set
		{
			regionMode = value;
		}
	}

	public CodeRegionDirective()
	{
	}

	public CodeRegionDirective(CodeRegionMode regionMode, string regionText)
	{
		RegionText = regionText;
		this.regionMode = regionMode;
	}
}
