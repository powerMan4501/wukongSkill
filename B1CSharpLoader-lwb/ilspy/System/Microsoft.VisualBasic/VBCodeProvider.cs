using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Security.Permissions;

namespace Microsoft.VisualBasic;

[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public class VBCodeProvider : CodeDomProvider
{
	private VBCodeGenerator generator;

	public override string FileExtension => "vb";

	public override LanguageOptions LanguageOptions => LanguageOptions.CaseInsensitive;

	public VBCodeProvider()
	{
		generator = new VBCodeGenerator();
	}

	public VBCodeProvider(IDictionary<string, string> providerOptions)
	{
		if (providerOptions == null)
		{
			throw new ArgumentNullException("providerOptions");
		}
		generator = new VBCodeGenerator(providerOptions);
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
			return VBMemberAttributeConverter.Default;
		}
		if (type == typeof(TypeAttributes))
		{
			return VBTypeAttributeConverter.Default;
		}
		return base.GetConverter(type);
	}

	public override void GenerateCodeFromMember(CodeTypeMember member, TextWriter writer, CodeGeneratorOptions options)
	{
		generator.GenerateCodeFromMember(member, writer, options);
	}
}
