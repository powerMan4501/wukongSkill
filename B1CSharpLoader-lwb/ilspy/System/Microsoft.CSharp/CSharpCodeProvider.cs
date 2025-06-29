using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Security.Permissions;

namespace Microsoft.CSharp;

[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public class CSharpCodeProvider : CodeDomProvider
{
	private CSharpCodeGenerator generator;

	public override string FileExtension => "cs";

	public CSharpCodeProvider()
	{
		generator = new CSharpCodeGenerator();
	}

	public CSharpCodeProvider(IDictionary<string, string> providerOptions)
	{
		if (providerOptions == null)
		{
			throw new ArgumentNullException("providerOptions");
		}
		generator = new CSharpCodeGenerator(providerOptions);
	}

	[Obsolete("Callers should not use the ICodeGenerator interface and should instead use the methods directly on the CodeDomProvider class.")]
	public override ICodeGenerator CreateGenerator()
	{
		return generator;
	}

	[Obsolete("Callers should not use the ICodeCompiler interface and should instead use the methods directly on the CodeDomProvider class.")]
	public override ICodeCompiler CreateCompiler()
	{
		return generator;
	}

	public override TypeConverter GetConverter(Type type)
	{
		if (type == typeof(MemberAttributes))
		{
			return CSharpMemberAttributeConverter.Default;
		}
		if (type == typeof(TypeAttributes))
		{
			return CSharpTypeAttributeConverter.Default;
		}
		return base.GetConverter(type);
	}

	public override void GenerateCodeFromMember(CodeTypeMember member, TextWriter writer, CodeGeneratorOptions options)
	{
		generator.GenerateCodeFromMember(member, writer, options);
	}
}
