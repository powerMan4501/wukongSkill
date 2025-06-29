using System.Collections.Specialized;
using System.Reflection;
using System.Security.Permissions;
using System.Security.Policy;

namespace System.CodeDom.Compiler;

[Serializable]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public class CompilerResults
{
	private CompilerErrorCollection errors = new CompilerErrorCollection();

	private StringCollection output = new StringCollection();

	private Assembly compiledAssembly;

	private string pathToAssembly;

	private int nativeCompilerReturnValue;

	private TempFileCollection tempFiles;

	private Evidence evidence;

	public TempFileCollection TempFiles
	{
		[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
		get
		{
			return tempFiles;
		}
		[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
		set
		{
			tempFiles = value;
		}
	}

	[Obsolete("CAS policy is obsolete and will be removed in a future release of the .NET Framework. Please see http://go2.microsoft.com/fwlink/?LinkId=131738 for more information.")]
	public Evidence Evidence
	{
		[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
		get
		{
			Evidence result = null;
			if (evidence != null)
			{
				result = evidence.Clone();
			}
			return result;
		}
		[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
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

	public Assembly CompiledAssembly
	{
		[SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.ControlEvidence)]
		get
		{
			if (compiledAssembly == null && pathToAssembly != null)
			{
				AssemblyName assemblyName = new AssemblyName();
				assemblyName.CodeBase = pathToAssembly;
				compiledAssembly = Assembly.Load(assemblyName, evidence);
			}
			return compiledAssembly;
		}
		[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
		set
		{
			compiledAssembly = value;
		}
	}

	public CompilerErrorCollection Errors => errors;

	public StringCollection Output
	{
		[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
		get
		{
			return output;
		}
	}

	public string PathToAssembly
	{
		[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
		get
		{
			return pathToAssembly;
		}
		[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
		set
		{
			pathToAssembly = value;
		}
	}

	public int NativeCompilerReturnValue
	{
		get
		{
			return nativeCompilerReturnValue;
		}
		[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
		set
		{
			nativeCompilerReturnValue = value;
		}
	}

	[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
	public CompilerResults(TempFileCollection tempFiles)
	{
		this.tempFiles = tempFiles;
	}
}
