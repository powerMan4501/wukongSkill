using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Security.Policy;
using Microsoft.Win32.SafeHandles;

namespace System.CodeDom.Compiler;

[Serializable]
[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public class CompilerParameters
{
	[OptionalField]
	private string coreAssemblyFileName = string.Empty;

	private StringCollection assemblyNames = new StringCollection();

	[OptionalField]
	private StringCollection embeddedResources = new StringCollection();

	[OptionalField]
	private StringCollection linkedResources = new StringCollection();

	private string outputName;

	private string mainClass;

	private bool generateInMemory;

	private bool includeDebugInformation;

	private int warningLevel = -1;

	private string compilerOptions;

	private string win32Resource;

	private bool treatWarningsAsErrors;

	private bool generateExecutable;

	private TempFileCollection tempFiles;

	[NonSerialized]
	private SafeUserTokenHandle userToken;

	private Evidence evidence;

	public string CoreAssemblyFileName
	{
		get
		{
			return coreAssemblyFileName;
		}
		set
		{
			coreAssemblyFileName = value;
		}
	}

	public bool GenerateExecutable
	{
		get
		{
			return generateExecutable;
		}
		set
		{
			generateExecutable = value;
		}
	}

	public bool GenerateInMemory
	{
		get
		{
			return generateInMemory;
		}
		set
		{
			generateInMemory = value;
		}
	}

	public StringCollection ReferencedAssemblies => assemblyNames;

	public string MainClass
	{
		get
		{
			return mainClass;
		}
		set
		{
			mainClass = value;
		}
	}

	public string OutputAssembly
	{
		get
		{
			return outputName;
		}
		set
		{
			outputName = value;
		}
	}

	public TempFileCollection TempFiles
	{
		get
		{
			if (tempFiles == null)
			{
				tempFiles = new TempFileCollection();
			}
			return tempFiles;
		}
		set
		{
			tempFiles = value;
		}
	}

	public bool IncludeDebugInformation
	{
		get
		{
			return includeDebugInformation;
		}
		set
		{
			includeDebugInformation = value;
		}
	}

	public bool TreatWarningsAsErrors
	{
		get
		{
			return treatWarningsAsErrors;
		}
		set
		{
			treatWarningsAsErrors = value;
		}
	}

	public int WarningLevel
	{
		get
		{
			return warningLevel;
		}
		set
		{
			warningLevel = value;
		}
	}

	public string CompilerOptions
	{
		get
		{
			return compilerOptions;
		}
		set
		{
			compilerOptions = value;
		}
	}

	public string Win32Resource
	{
		get
		{
			return win32Resource;
		}
		set
		{
			win32Resource = value;
		}
	}

	[ComVisible(false)]
	public StringCollection EmbeddedResources => embeddedResources;

	[ComVisible(false)]
	public StringCollection LinkedResources => linkedResources;

	public IntPtr UserToken
	{
		get
		{
			if (userToken != null)
			{
				return userToken.DangerousGetHandle();
			}
			return IntPtr.Zero;
		}
		set
		{
			if (userToken != null)
			{
				userToken.Close();
			}
			userToken = new SafeUserTokenHandle(value, ownsHandle: false);
		}
	}

	internal SafeUserTokenHandle SafeUserToken => userToken;

	[Obsolete("CAS policy is obsolete and will be removed in a future release of the .NET Framework. Please see http://go2.microsoft.com/fwlink/?LinkId=131738 for more information.")]
	public Evidence Evidence
	{
		get
		{
			Evidence result = null;
			if (evidence != null)
			{
				result = evidence.Clone();
			}
			return result;
		}
		[SecurityPermission(SecurityAction.Demand, ControlEvidence = true)]
		set
		{
			if (value != null)
			{
				evidence = value.Clone();
			}
			else
			{
				evidence = null;
			}
		}
	}

	public CompilerParameters()
		: this(null, null)
	{
	}

	public CompilerParameters(string[] assemblyNames)
		: this(assemblyNames, null, includeDebugInformation: false)
	{
	}

	public CompilerParameters(string[] assemblyNames, string outputName)
		: this(assemblyNames, outputName, includeDebugInformation: false)
	{
	}

	public CompilerParameters(string[] assemblyNames, string outputName, bool includeDebugInformation)
	{
		if (assemblyNames != null)
		{
			ReferencedAssemblies.AddRange(assemblyNames);
		}
		this.outputName = outputName;
		this.includeDebugInformation = includeDebugInformation;
	}
}
