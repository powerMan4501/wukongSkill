using System.Security.Permissions;

namespace System.CodeDom.Compiler;

public interface ICodeCompiler
{
	[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
	[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
	CompilerResults CompileAssemblyFromDom(CompilerParameters options, CodeCompileUnit compilationUnit);

	[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
	[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
	CompilerResults CompileAssemblyFromFile(CompilerParameters options, string fileName);

	[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
	[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
	CompilerResults CompileAssemblyFromSource(CompilerParameters options, string source);

	[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
	[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
	CompilerResults CompileAssemblyFromDomBatch(CompilerParameters options, CodeCompileUnit[] compilationUnits);

	[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
	[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
	CompilerResults CompileAssemblyFromFileBatch(CompilerParameters options, string[] fileNames);

	[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
	[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
	CompilerResults CompileAssemblyFromSourceBatch(CompilerParameters options, string[] sources);
}
