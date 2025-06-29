using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.CodeDom.Compiler;

[ToolboxItem(false)]
[ComVisible(true)]
[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
public abstract class CodeDomProvider : Component
{
	private static CodeDomCompilationConfiguration Config
	{
		get
		{
			CodeDomCompilationConfiguration codeDomCompilationConfiguration = (CodeDomCompilationConfiguration)System.Configuration.PrivilegedConfigurationManager.GetSection("system.codedom");
			if (codeDomCompilationConfiguration == null)
			{
				return CodeDomCompilationConfiguration.Default;
			}
			return codeDomCompilationConfiguration;
		}
	}

	public virtual string FileExtension => string.Empty;

	public virtual LanguageOptions LanguageOptions => LanguageOptions.None;

	[ComVisible(false)]
	public static CodeDomProvider CreateProvider(string language, IDictionary<string, string> providerOptions)
	{
		CompilerInfo compilerInfo = GetCompilerInfo(language);
		return compilerInfo.CreateProvider(providerOptions);
	}

	[ComVisible(false)]
	public static CodeDomProvider CreateProvider(string language)
	{
		CompilerInfo compilerInfo = GetCompilerInfo(language);
		return compilerInfo.CreateProvider();
	}

	[ComVisible(false)]
	public static string GetLanguageFromExtension(string extension)
	{
		CompilerInfo compilerInfoForExtensionNoThrow = GetCompilerInfoForExtensionNoThrow(extension);
		if (compilerInfoForExtensionNoThrow == null)
		{
			throw new ConfigurationErrorsException(SR.GetString("CodeDomProvider_NotDefined"));
		}
		return compilerInfoForExtensionNoThrow._compilerLanguages[0];
	}

	[ComVisible(false)]
	public static bool IsDefinedLanguage(string language)
	{
		return GetCompilerInfoForLanguageNoThrow(language) != null;
	}

	[ComVisible(false)]
	public static bool IsDefinedExtension(string extension)
	{
		return GetCompilerInfoForExtensionNoThrow(extension) != null;
	}

	[ComVisible(false)]
	public static CompilerInfo GetCompilerInfo(string language)
	{
		CompilerInfo compilerInfoForLanguageNoThrow = GetCompilerInfoForLanguageNoThrow(language);
		if (compilerInfoForLanguageNoThrow == null)
		{
			throw new ConfigurationErrorsException(SR.GetString("CodeDomProvider_NotDefined"));
		}
		return compilerInfoForLanguageNoThrow;
	}

	private static CompilerInfo GetCompilerInfoForLanguageNoThrow(string language)
	{
		if (language == null)
		{
			throw new ArgumentNullException("language");
		}
		return (CompilerInfo)Config._compilerLanguages[language.Trim()];
	}

	private static CompilerInfo GetCompilerInfoForExtensionNoThrow(string extension)
	{
		if (extension == null)
		{
			throw new ArgumentNullException("extension");
		}
		return (CompilerInfo)Config._compilerExtensions[extension.Trim()];
	}

	[ComVisible(false)]
	public static CompilerInfo[] GetAllCompilerInfo()
	{
		ArrayList allCompilerInfo = Config._allCompilerInfo;
		return (CompilerInfo[])allCompilerInfo.ToArray(typeof(CompilerInfo));
	}

	[Obsolete("Callers should not use the ICodeGenerator interface and should instead use the methods directly on the CodeDomProvider class. Those inheriting from CodeDomProvider must still implement this interface, and should exclude this warning or also obsolete this method.")]
	public abstract ICodeGenerator CreateGenerator();

	public virtual ICodeGenerator CreateGenerator(TextWriter output)
	{
		return CreateGenerator();
	}

	public virtual ICodeGenerator CreateGenerator(string fileName)
	{
		return CreateGenerator();
	}

	[Obsolete("Callers should not use the ICodeCompiler interface and should instead use the methods directly on the CodeDomProvider class. Those inheriting from CodeDomProvider must still implement this interface, and should exclude this warning or also obsolete this method.")]
	public abstract ICodeCompiler CreateCompiler();

	[Obsolete("Callers should not use the ICodeParser interface and should instead use the methods directly on the CodeDomProvider class. Those inheriting from CodeDomProvider must still implement this interface, and should exclude this warning or also obsolete this method.")]
	public virtual ICodeParser CreateParser()
	{
		return null;
	}

	public virtual TypeConverter GetConverter(Type type)
	{
		return TypeDescriptor.GetConverter(type);
	}

	public virtual CompilerResults CompileAssemblyFromDom(CompilerParameters options, params CodeCompileUnit[] compilationUnits)
	{
		return CreateCompilerHelper().CompileAssemblyFromDomBatch(options, compilationUnits);
	}

	public virtual CompilerResults CompileAssemblyFromFile(CompilerParameters options, params string[] fileNames)
	{
		return CreateCompilerHelper().CompileAssemblyFromFileBatch(options, fileNames);
	}

	public virtual CompilerResults CompileAssemblyFromSource(CompilerParameters options, params string[] sources)
	{
		return CreateCompilerHelper().CompileAssemblyFromSourceBatch(options, sources);
	}

	public virtual bool IsValidIdentifier(string value)
	{
		return CreateGeneratorHelper().IsValidIdentifier(value);
	}

	public virtual string CreateEscapedIdentifier(string value)
	{
		return CreateGeneratorHelper().CreateEscapedIdentifier(value);
	}

	public virtual string CreateValidIdentifier(string value)
	{
		return CreateGeneratorHelper().CreateValidIdentifier(value);
	}

	public virtual string GetTypeOutput(CodeTypeReference type)
	{
		return CreateGeneratorHelper().GetTypeOutput(type);
	}

	public virtual bool Supports(GeneratorSupport generatorSupport)
	{
		return CreateGeneratorHelper().Supports(generatorSupport);
	}

	public virtual void GenerateCodeFromExpression(CodeExpression expression, TextWriter writer, CodeGeneratorOptions options)
	{
		CreateGeneratorHelper().GenerateCodeFromExpression(expression, writer, options);
	}

	public virtual void GenerateCodeFromStatement(CodeStatement statement, TextWriter writer, CodeGeneratorOptions options)
	{
		CreateGeneratorHelper().GenerateCodeFromStatement(statement, writer, options);
	}

	public virtual void GenerateCodeFromNamespace(CodeNamespace codeNamespace, TextWriter writer, CodeGeneratorOptions options)
	{
		CreateGeneratorHelper().GenerateCodeFromNamespace(codeNamespace, writer, options);
	}

	public virtual void GenerateCodeFromCompileUnit(CodeCompileUnit compileUnit, TextWriter writer, CodeGeneratorOptions options)
	{
		CreateGeneratorHelper().GenerateCodeFromCompileUnit(compileUnit, writer, options);
	}

	public virtual void GenerateCodeFromType(CodeTypeDeclaration codeType, TextWriter writer, CodeGeneratorOptions options)
	{
		CreateGeneratorHelper().GenerateCodeFromType(codeType, writer, options);
	}

	public virtual void GenerateCodeFromMember(CodeTypeMember member, TextWriter writer, CodeGeneratorOptions options)
	{
		throw new NotImplementedException(SR.GetString("NotSupported_CodeDomAPI"));
	}

	public virtual CodeCompileUnit Parse(TextReader codeStream)
	{
		return CreateParserHelper().Parse(codeStream);
	}

	private ICodeCompiler CreateCompilerHelper()
	{
		ICodeCompiler codeCompiler = CreateCompiler();
		if (codeCompiler == null)
		{
			throw new NotImplementedException(SR.GetString("NotSupported_CodeDomAPI"));
		}
		return codeCompiler;
	}

	private ICodeGenerator CreateGeneratorHelper()
	{
		ICodeGenerator codeGenerator = CreateGenerator();
		if (codeGenerator == null)
		{
			throw new NotImplementedException(SR.GetString("NotSupported_CodeDomAPI"));
		}
		return codeGenerator;
	}

	private ICodeParser CreateParserHelper()
	{
		ICodeParser codeParser = CreateParser();
		if (codeParser == null)
		{
			throw new NotImplementedException(SR.GetString("NotSupported_CodeDomAPI"));
		}
		return codeParser;
	}

	internal static bool TryGetProbableCoreAssemblyFilePath(CompilerParameters parameters, out string coreAssemblyFilePath)
	{
		string text = null;
		char[] separator = new char[1] { Path.DirectorySeparatorChar };
		string value = Path.Combine("Reference Assemblies", "Microsoft", "Framework");
		StringEnumerator enumerator = parameters.ReferencedAssemblies.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				if (Path.GetFileName(current).Equals("mscorlib.dll", StringComparison.OrdinalIgnoreCase))
				{
					coreAssemblyFilePath = string.Empty;
					return false;
				}
				if (current.IndexOf(value, StringComparison.OrdinalIgnoreCase) < 0)
				{
					continue;
				}
				string[] array = current.Split(separator, StringSplitOptions.RemoveEmptyEntries);
				for (int i = 0; i < array.Length - 5; i++)
				{
					if (!string.Equals(array[i], "Reference Assemblies", StringComparison.OrdinalIgnoreCase) || !array[i + 4].StartsWith("v", StringComparison.OrdinalIgnoreCase))
					{
						continue;
					}
					if (text != null)
					{
						if (!string.Equals(text, Path.GetDirectoryName(current), StringComparison.OrdinalIgnoreCase))
						{
							coreAssemblyFilePath = string.Empty;
							return false;
						}
					}
					else
					{
						text = Path.GetDirectoryName(current);
					}
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable disposable)
			{
				disposable.Dispose();
			}
		}
		if (text != null)
		{
			coreAssemblyFilePath = Path.Combine(text, "mscorlib.dll");
			return true;
		}
		coreAssemblyFilePath = string.Empty;
		return false;
	}
}
