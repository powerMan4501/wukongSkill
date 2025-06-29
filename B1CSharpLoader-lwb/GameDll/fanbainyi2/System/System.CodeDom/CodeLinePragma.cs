using System.Runtime.InteropServices;

namespace System.CodeDom;

[Serializable]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
public class CodeLinePragma
{
	private string fileName;

	private int lineNumber;

	public string FileName
	{
		get
		{
			if (fileName != null)
			{
				return fileName;
			}
			return string.Empty;
		}
		set
		{
			fileName = value;
		}
	}

	public int LineNumber
	{
		get
		{
			return lineNumber;
		}
		set
		{
			lineNumber = value;
		}
	}

	public CodeLinePragma()
	{
	}

	public CodeLinePragma(string fileName, int lineNumber)
	{
		FileName = fileName;
		LineNumber = lineNumber;
	}
}
