using System.Globalization;
using System.Security.Permissions;

namespace System.CodeDom.Compiler;

[Serializable]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public class CompilerError
{
	private int line;

	private int column;

	private string errorNumber;

	private bool warning;

	private string errorText;

	private string fileName;

	public int Line
	{
		get
		{
			return line;
		}
		set
		{
			line = value;
		}
	}

	public int Column
	{
		get
		{
			return column;
		}
		set
		{
			column = value;
		}
	}

	public string ErrorNumber
	{
		get
		{
			return errorNumber;
		}
		set
		{
			errorNumber = value;
		}
	}

	public string ErrorText
	{
		get
		{
			return errorText;
		}
		set
		{
			errorText = value;
		}
	}

	public bool IsWarning
	{
		get
		{
			return warning;
		}
		set
		{
			warning = value;
		}
	}

	public string FileName
	{
		get
		{
			return fileName;
		}
		set
		{
			fileName = value;
		}
	}

	public CompilerError()
	{
		line = 0;
		column = 0;
		errorNumber = string.Empty;
		errorText = string.Empty;
		fileName = string.Empty;
	}

	public CompilerError(string fileName, int line, int column, string errorNumber, string errorText)
	{
		this.line = line;
		this.column = column;
		this.errorNumber = errorNumber;
		this.errorText = errorText;
		this.fileName = fileName;
	}

	public override string ToString()
	{
		if (FileName.Length > 0)
		{
			return string.Format(CultureInfo.InvariantCulture, "{0}({1},{2}) : {3} {4}: {5}", FileName, Line, Column, IsWarning ? "warning" : "error", ErrorNumber, ErrorText);
		}
		return string.Format(CultureInfo.InvariantCulture, "{0} {1}: {2}", new object[3]
		{
			IsWarning ? "warning" : "error",
			ErrorNumber,
			ErrorText
		});
	}
}
