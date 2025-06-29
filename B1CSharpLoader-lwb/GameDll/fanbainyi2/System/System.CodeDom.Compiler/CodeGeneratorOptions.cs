using System.Collections;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.CodeDom.Compiler;

[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public class CodeGeneratorOptions
{
	private IDictionary options = new ListDictionary();

	public object this[string index]
	{
		get
		{
			return options[index];
		}
		set
		{
			options[index] = value;
		}
	}

	public string IndentString
	{
		get
		{
			object obj = options["IndentString"];
			if (obj != null)
			{
				return (string)obj;
			}
			return "    ";
		}
		set
		{
			options["IndentString"] = value;
		}
	}

	public string BracingStyle
	{
		get
		{
			object obj = options["BracingStyle"];
			if (obj != null)
			{
				return (string)obj;
			}
			return "Block";
		}
		set
		{
			options["BracingStyle"] = value;
		}
	}

	public bool ElseOnClosing
	{
		get
		{
			object obj = options["ElseOnClosing"];
			if (obj != null)
			{
				return (bool)obj;
			}
			return false;
		}
		set
		{
			options["ElseOnClosing"] = value;
		}
	}

	public bool BlankLinesBetweenMembers
	{
		get
		{
			object obj = options["BlankLinesBetweenMembers"];
			if (obj != null)
			{
				return (bool)obj;
			}
			return true;
		}
		set
		{
			options["BlankLinesBetweenMembers"] = value;
		}
	}

	[ComVisible(false)]
	public bool VerbatimOrder
	{
		get
		{
			object obj = options["VerbatimOrder"];
			if (obj != null)
			{
				return (bool)obj;
			}
			return false;
		}
		set
		{
			options["VerbatimOrder"] = value;
		}
	}
}
