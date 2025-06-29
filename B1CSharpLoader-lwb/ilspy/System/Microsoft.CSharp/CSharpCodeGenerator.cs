using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;

namespace Microsoft.CSharp;

internal class CSharpCodeGenerator : ICodeCompiler, ICodeGenerator
{
	private IndentedTextWriter output;

	private CodeGeneratorOptions options;

	private CodeTypeDeclaration currentClass;

	private CodeTypeMember currentMember;

	private bool inNestedBinary;

	private IDictionary<string, string> provOptions;

	private const int ParameterMultilineThreshold = 15;

	private const int MaxLineLength = 80;

	private const GeneratorSupport LanguageSupport = GeneratorSupport.ArraysOfArrays | GeneratorSupport.EntryPointMethod | GeneratorSupport.GotoStatements | GeneratorSupport.MultidimensionalArrays | GeneratorSupport.StaticConstructors | GeneratorSupport.TryCatchStatements | GeneratorSupport.ReturnTypeAttributes | GeneratorSupport.DeclareValueTypes | GeneratorSupport.DeclareEnums | GeneratorSupport.DeclareDelegates | GeneratorSupport.DeclareInterfaces | GeneratorSupport.DeclareEvents | GeneratorSupport.AssemblyAttributes | GeneratorSupport.ParameterAttributes | GeneratorSupport.ReferenceParameters | GeneratorSupport.ChainedConstructorArguments | GeneratorSupport.NestedTypes | GeneratorSupport.MultipleInterfaceMembers | GeneratorSupport.PublicStaticMembers | GeneratorSupport.ComplexExpressions | GeneratorSupport.Win32Resources | GeneratorSupport.Resources | GeneratorSupport.PartialTypes | GeneratorSupport.GenericTypeReference | GeneratorSupport.GenericTypeDeclaration | GeneratorSupport.DeclareIndexerProperties;

	private static volatile Regex outputRegWithFileAndLine;

	private static volatile Regex outputRegSimple;

	private static readonly string[][] keywords = new string[10][]
	{
		null,
		new string[5] { "as", "do", "if", "in", "is" },
		new string[6] { "for", "int", "new", "out", "ref", "try" },
		new string[15]
		{
			"base", "bool", "byte", "case", "char", "else", "enum", "goto", "lock", "long",
			"null", "this", "true", "uint", "void"
		},
		new string[14]
		{
			"break", "catch", "class", "const", "event", "false", "fixed", "float", "sbyte", "short",
			"throw", "ulong", "using", "while"
		},
		new string[15]
		{
			"double", "extern", "object", "params", "public", "return", "sealed", "sizeof", "static", "string",
			"struct", "switch", "typeof", "unsafe", "ushort"
		},
		new string[7] { "checked", "decimal", "default", "finally", "foreach", "private", "virtual" },
		new string[10] { "abstract", "continue", "delegate", "explicit", "implicit", "internal", "operator", "override", "readonly", "volatile" },
		new string[7] { "__arglist", "__makeref", "__reftype", "interface", "namespace", "protected", "unchecked" },
		new string[2] { "__refvalue", "stackalloc" }
	};

	private bool generatingForLoop;

	private string FileExtension => ".cs";

	private string CompilerName => "csc.exe";

	private string CurrentTypeName
	{
		get
		{
			if (currentClass != null)
			{
				return currentClass.Name;
			}
			return "<% unknown %>";
		}
	}

	private int Indent
	{
		get
		{
			return output.Indent;
		}
		set
		{
			output.Indent = value;
		}
	}

	private bool IsCurrentInterface
	{
		get
		{
			if (currentClass != null && !(currentClass is CodeTypeDelegate))
			{
				return currentClass.IsInterface;
			}
			return false;
		}
	}

	private bool IsCurrentClass
	{
		get
		{
			if (currentClass != null && !(currentClass is CodeTypeDelegate))
			{
				return currentClass.IsClass;
			}
			return false;
		}
	}

	private bool IsCurrentStruct
	{
		get
		{
			if (currentClass != null && !(currentClass is CodeTypeDelegate))
			{
				return currentClass.IsStruct;
			}
			return false;
		}
	}

	private bool IsCurrentEnum
	{
		get
		{
			if (currentClass != null && !(currentClass is CodeTypeDelegate))
			{
				return currentClass.IsEnum;
			}
			return false;
		}
	}

	private bool IsCurrentDelegate
	{
		get
		{
			if (currentClass != null && currentClass is CodeTypeDelegate)
			{
				return true;
			}
			return false;
		}
	}

	private string NullToken => "null";

	private CodeGeneratorOptions Options => options;

	private TextWriter Output => output;

	internal CSharpCodeGenerator()
	{
	}

	internal CSharpCodeGenerator(IDictionary<string, string> providerOptions)
	{
		provOptions = providerOptions;
	}

	private string QuoteSnippetStringCStyle(string value)
	{
		StringBuilder stringBuilder = new StringBuilder(value.Length + 5);
		Indentation indentation = new Indentation((IndentedTextWriter)Output, Indent + 1);
		stringBuilder.Append("\"");
		for (int i = 0; i < value.Length; i++)
		{
			switch (value[i])
			{
			case '\r':
				stringBuilder.Append("\\r");
				break;
			case '\t':
				stringBuilder.Append("\\t");
				break;
			case '"':
				stringBuilder.Append("\\\"");
				break;
			case '\'':
				stringBuilder.Append("\\'");
				break;
			case '\\':
				stringBuilder.Append("\\\\");
				break;
			case '\0':
				stringBuilder.Append("\\0");
				break;
			case '\n':
				stringBuilder.Append("\\n");
				break;
			case '\u2028':
			case '\u2029':
				AppendEscapedChar(stringBuilder, value[i]);
				break;
			default:
				stringBuilder.Append(value[i]);
				break;
			}
			if (i > 0 && i % 80 == 0)
			{
				if (char.IsHighSurrogate(value[i]) && i < value.Length - 1 && char.IsLowSurrogate(value[i + 1]))
				{
					stringBuilder.Append(value[++i]);
				}
				stringBuilder.Append("\" +");
				stringBuilder.Append(Environment.NewLine);
				stringBuilder.Append(indentation.IndentationString);
				stringBuilder.Append('"');
			}
		}
		stringBuilder.Append("\"");
		return stringBuilder.ToString();
	}

	private string QuoteSnippetStringVerbatimStyle(string value)
	{
		StringBuilder stringBuilder = new StringBuilder(value.Length + 5);
		stringBuilder.Append("@\"");
		for (int i = 0; i < value.Length; i++)
		{
			if (value[i] == '"')
			{
				stringBuilder.Append("\"\"");
			}
			else
			{
				stringBuilder.Append(value[i]);
			}
		}
		stringBuilder.Append("\"");
		return stringBuilder.ToString();
	}

	private string QuoteSnippetString(string value)
	{
		if (value.Length < 256 || value.Length > 1500 || value.IndexOf('\0') != -1)
		{
			return QuoteSnippetStringCStyle(value);
		}
		return QuoteSnippetStringVerbatimStyle(value);
	}

	private void ProcessCompilerOutputLine(CompilerResults results, string line)
	{
		if (outputRegSimple == null)
		{
			outputRegWithFileAndLine = new Regex("(^(.*)(\\(([0-9]+),([0-9]+)\\)): )(error|warning) ([A-Z]+[0-9]+) ?: (.*)");
			outputRegSimple = new Regex("(error|warning) ([A-Z]+[0-9]+) ?: (.*)");
		}
		Match match = outputRegWithFileAndLine.Match(line);
		bool flag;
		if (match.Success)
		{
			flag = true;
		}
		else
		{
			match = outputRegSimple.Match(line);
			flag = false;
		}
		if (match.Success)
		{
			CompilerError compilerError = new CompilerError();
			if (flag)
			{
				compilerError.FileName = match.Groups[2].Value;
				compilerError.Line = int.Parse(match.Groups[4].Value, CultureInfo.InvariantCulture);
				compilerError.Column = int.Parse(match.Groups[5].Value, CultureInfo.InvariantCulture);
			}
			if (string.Compare(match.Groups[(!flag) ? 1 : 6].Value, "warning", StringComparison.OrdinalIgnoreCase) == 0)
			{
				compilerError.IsWarning = true;
			}
			compilerError.ErrorNumber = match.Groups[flag ? 7 : 2].Value;
			compilerError.ErrorText = match.Groups[flag ? 8 : 3].Value;
			results.Errors.Add(compilerError);
		}
	}

	private string CmdArgsFromParameters(CompilerParameters options)
	{
		StringBuilder stringBuilder = new StringBuilder(128);
		if (options.GenerateExecutable)
		{
			stringBuilder.Append("/t:exe ");
			if (options.MainClass != null && options.MainClass.Length > 0)
			{
				stringBuilder.Append("/main:");
				stringBuilder.Append(options.MainClass);
				stringBuilder.Append(" ");
			}
		}
		else
		{
			stringBuilder.Append("/t:library ");
		}
		stringBuilder.Append("/utf8output ");
		if (FileIntegrity.IsEnabled)
		{
			stringBuilder.Append("/EnforceCodeIntegrity ");
		}
		string text = options.CoreAssemblyFileName;
		if (string.IsNullOrWhiteSpace(options.CoreAssemblyFileName) && CodeDomProvider.TryGetProbableCoreAssemblyFilePath(options, out var coreAssemblyFilePath))
		{
			text = coreAssemblyFilePath;
		}
		if (!string.IsNullOrWhiteSpace(text))
		{
			stringBuilder.Append("/nostdlib+ ");
			stringBuilder.Append("/R:\"").Append(text.Trim()).Append("\" ");
		}
		StringEnumerator enumerator = options.ReferencedAssemblies.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				stringBuilder.Append("/R:");
				stringBuilder.Append("\"");
				stringBuilder.Append(current);
				stringBuilder.Append("\"");
				stringBuilder.Append(" ");
			}
		}
		finally
		{
			if (enumerator is IDisposable disposable)
			{
				disposable.Dispose();
			}
		}
		stringBuilder.Append("/out:");
		stringBuilder.Append("\"");
		stringBuilder.Append(options.OutputAssembly);
		stringBuilder.Append("\"");
		stringBuilder.Append(" ");
		if (options.IncludeDebugInformation)
		{
			stringBuilder.Append("/D:DEBUG ");
			stringBuilder.Append("/debug+ ");
			stringBuilder.Append("/optimize- ");
		}
		else
		{
			stringBuilder.Append("/debug- ");
			stringBuilder.Append("/optimize+ ");
		}
		if (options.Win32Resource != null)
		{
			stringBuilder.Append("/win32res:\"" + options.Win32Resource + "\" ");
		}
		StringEnumerator enumerator2 = options.EmbeddedResources.GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				string current2 = enumerator2.Current;
				stringBuilder.Append("/res:\"");
				stringBuilder.Append(current2);
				stringBuilder.Append("\" ");
			}
		}
		finally
		{
			if (enumerator2 is IDisposable disposable2)
			{
				disposable2.Dispose();
			}
		}
		StringEnumerator enumerator3 = options.LinkedResources.GetEnumerator();
		try
		{
			while (enumerator3.MoveNext())
			{
				string current3 = enumerator3.Current;
				stringBuilder.Append("/linkres:\"");
				stringBuilder.Append(current3);
				stringBuilder.Append("\" ");
			}
		}
		finally
		{
			if (enumerator3 is IDisposable disposable3)
			{
				disposable3.Dispose();
			}
		}
		if (options.TreatWarningsAsErrors)
		{
			stringBuilder.Append("/warnaserror ");
		}
		if (options.WarningLevel >= 0)
		{
			stringBuilder.Append("/w:" + options.WarningLevel + " ");
		}
		if (options.CompilerOptions != null)
		{
			stringBuilder.Append(options.CompilerOptions + " ");
		}
		return stringBuilder.ToString();
	}

	private void ContinueOnNewLine(string st)
	{
		Output.WriteLine(st);
	}

	private string GetResponseFileCmdArgs(CompilerParameters options, string cmdArgs)
	{
		string text = options.TempFiles.AddExtension("cmdline");
		Stream stream = new FileStream(text, FileMode.Create, FileAccess.Write, FileShare.Read);
		try
		{
			using StreamWriter streamWriter = new StreamWriter(stream, Encoding.UTF8);
			streamWriter.Write(cmdArgs);
			streamWriter.Flush();
		}
		finally
		{
			stream.Close();
		}
		return "/noconfig /fullpaths @\"" + text + "\"";
	}

	private void OutputIdentifier(string ident)
	{
		Output.Write(CreateEscapedIdentifier(ident));
	}

	private void OutputType(CodeTypeReference typeRef)
	{
		Output.Write(GetTypeOutput(typeRef));
	}

	private void GenerateArrayCreateExpression(CodeArrayCreateExpression e)
	{
		Output.Write("new ");
		CodeExpressionCollection initializers = e.Initializers;
		if (initializers.Count > 0)
		{
			OutputType(e.CreateType);
			if (e.CreateType.ArrayRank == 0)
			{
				Output.Write("[]");
			}
			Output.WriteLine(" {");
			Indent++;
			OutputExpressionList(initializers, newlineBetweenItems: true);
			Indent--;
			Output.Write("}");
			return;
		}
		Output.Write(GetBaseTypeOutput(e.CreateType));
		Output.Write("[");
		if (e.SizeExpression != null)
		{
			GenerateExpression(e.SizeExpression);
		}
		else
		{
			Output.Write(e.Size);
		}
		Output.Write("]");
		int nestedArrayDepth = e.CreateType.NestedArrayDepth;
		for (int i = 0; i < nestedArrayDepth - 1; i++)
		{
			Output.Write("[]");
		}
	}

	private void GenerateBaseReferenceExpression(CodeBaseReferenceExpression e)
	{
		Output.Write("base");
	}

	private void GenerateBinaryOperatorExpression(CodeBinaryOperatorExpression e)
	{
		bool flag = false;
		Output.Write("(");
		GenerateExpression(e.Left);
		Output.Write(" ");
		if (e.Left is CodeBinaryOperatorExpression || e.Right is CodeBinaryOperatorExpression)
		{
			if (!inNestedBinary)
			{
				flag = true;
				inNestedBinary = true;
				Indent += 3;
			}
			ContinueOnNewLine("");
		}
		OutputOperator(e.Operator);
		Output.Write(" ");
		GenerateExpression(e.Right);
		Output.Write(")");
		if (flag)
		{
			Indent -= 3;
			inNestedBinary = false;
		}
	}

	private void GenerateCastExpression(CodeCastExpression e)
	{
		Output.Write("((");
		OutputType(e.TargetType);
		Output.Write(")(");
		GenerateExpression(e.Expression);
		Output.Write("))");
	}

	public void GenerateCodeFromMember(CodeTypeMember member, TextWriter writer, CodeGeneratorOptions options)
	{
		if (output != null)
		{
			throw new InvalidOperationException(SR.GetString("CodeGenReentrance"));
		}
		this.options = ((options == null) ? new CodeGeneratorOptions() : options);
		output = new IndentedTextWriter(writer, this.options.IndentString);
		try
		{
			GenerateTypeMember(member, currentClass = new CodeTypeDeclaration());
		}
		finally
		{
			currentClass = null;
			output = null;
			this.options = null;
		}
	}

	private void GenerateDefaultValueExpression(CodeDefaultValueExpression e)
	{
		Output.Write("default(");
		OutputType(e.Type);
		Output.Write(")");
	}

	private void GenerateDelegateCreateExpression(CodeDelegateCreateExpression e)
	{
		Output.Write("new ");
		OutputType(e.DelegateType);
		Output.Write("(");
		GenerateExpression(e.TargetObject);
		Output.Write(".");
		OutputIdentifier(e.MethodName);
		Output.Write(")");
	}

	private void GenerateEvents(CodeTypeDeclaration e)
	{
		IEnumerator enumerator = e.Members.GetEnumerator();
		while (enumerator.MoveNext())
		{
			if (enumerator.Current is CodeMemberEvent)
			{
				currentMember = (CodeTypeMember)enumerator.Current;
				if (options.BlankLinesBetweenMembers)
				{
					Output.WriteLine();
				}
				if (currentMember.StartDirectives.Count > 0)
				{
					GenerateDirectives(currentMember.StartDirectives);
				}
				GenerateCommentStatements(currentMember.Comments);
				CodeMemberEvent codeMemberEvent = (CodeMemberEvent)enumerator.Current;
				if (codeMemberEvent.LinePragma != null)
				{
					GenerateLinePragmaStart(codeMemberEvent.LinePragma);
				}
				GenerateEvent(codeMemberEvent, e);
				if (codeMemberEvent.LinePragma != null)
				{
					GenerateLinePragmaEnd(codeMemberEvent.LinePragma);
				}
				if (currentMember.EndDirectives.Count > 0)
				{
					GenerateDirectives(currentMember.EndDirectives);
				}
			}
		}
	}

	private void GenerateFields(CodeTypeDeclaration e)
	{
		IEnumerator enumerator = e.Members.GetEnumerator();
		while (enumerator.MoveNext())
		{
			if (enumerator.Current is CodeMemberField)
			{
				currentMember = (CodeTypeMember)enumerator.Current;
				if (options.BlankLinesBetweenMembers)
				{
					Output.WriteLine();
				}
				if (currentMember.StartDirectives.Count > 0)
				{
					GenerateDirectives(currentMember.StartDirectives);
				}
				GenerateCommentStatements(currentMember.Comments);
				CodeMemberField codeMemberField = (CodeMemberField)enumerator.Current;
				if (codeMemberField.LinePragma != null)
				{
					GenerateLinePragmaStart(codeMemberField.LinePragma);
				}
				GenerateField(codeMemberField);
				if (codeMemberField.LinePragma != null)
				{
					GenerateLinePragmaEnd(codeMemberField.LinePragma);
				}
				if (currentMember.EndDirectives.Count > 0)
				{
					GenerateDirectives(currentMember.EndDirectives);
				}
			}
		}
	}

	private void GenerateFieldReferenceExpression(CodeFieldReferenceExpression e)
	{
		if (e.TargetObject != null)
		{
			GenerateExpression(e.TargetObject);
			Output.Write(".");
		}
		OutputIdentifier(e.FieldName);
	}

	private void GenerateArgumentReferenceExpression(CodeArgumentReferenceExpression e)
	{
		OutputIdentifier(e.ParameterName);
	}

	private void GenerateVariableReferenceExpression(CodeVariableReferenceExpression e)
	{
		OutputIdentifier(e.VariableName);
	}

	private void GenerateIndexerExpression(CodeIndexerExpression e)
	{
		GenerateExpression(e.TargetObject);
		Output.Write("[");
		bool flag = true;
		foreach (CodeExpression index in e.Indices)
		{
			if (flag)
			{
				flag = false;
			}
			else
			{
				Output.Write(", ");
			}
			GenerateExpression(index);
		}
		Output.Write("]");
	}

	private void GenerateArrayIndexerExpression(CodeArrayIndexerExpression e)
	{
		GenerateExpression(e.TargetObject);
		Output.Write("[");
		bool flag = true;
		foreach (CodeExpression index in e.Indices)
		{
			if (flag)
			{
				flag = false;
			}
			else
			{
				Output.Write(", ");
			}
			GenerateExpression(index);
		}
		Output.Write("]");
	}

	private void GenerateSnippetCompileUnit(CodeSnippetCompileUnit e)
	{
		GenerateDirectives(e.StartDirectives);
		if (e.LinePragma != null)
		{
			GenerateLinePragmaStart(e.LinePragma);
		}
		Output.WriteLine(e.Value);
		if (e.LinePragma != null)
		{
			GenerateLinePragmaEnd(e.LinePragma);
		}
		if (e.EndDirectives.Count > 0)
		{
			GenerateDirectives(e.EndDirectives);
		}
	}

	private void GenerateSnippetExpression(CodeSnippetExpression e)
	{
		Output.Write(e.Value);
	}

	private void GenerateMethodInvokeExpression(CodeMethodInvokeExpression e)
	{
		GenerateMethodReferenceExpression(e.Method);
		Output.Write("(");
		OutputExpressionList(e.Parameters);
		Output.Write(")");
	}

	private void GenerateMethodReferenceExpression(CodeMethodReferenceExpression e)
	{
		if (e.TargetObject != null)
		{
			if (e.TargetObject is CodeBinaryOperatorExpression)
			{
				Output.Write("(");
				GenerateExpression(e.TargetObject);
				Output.Write(")");
			}
			else
			{
				GenerateExpression(e.TargetObject);
			}
			Output.Write(".");
		}
		OutputIdentifier(e.MethodName);
		if (e.TypeArguments.Count > 0)
		{
			Output.Write(GetTypeArgumentsOutput(e.TypeArguments));
		}
	}

	private bool GetUserData(CodeObject e, string property, bool defaultValue)
	{
		object obj = e.UserData[property];
		if (obj != null && obj is bool)
		{
			return (bool)obj;
		}
		return defaultValue;
	}

	private void GenerateNamespace(CodeNamespace e)
	{
		GenerateCommentStatements(e.Comments);
		GenerateNamespaceStart(e);
		if (GetUserData(e, "GenerateImports", defaultValue: true))
		{
			GenerateNamespaceImports(e);
		}
		Output.WriteLine("");
		GenerateTypes(e);
		GenerateNamespaceEnd(e);
	}

	private void GenerateStatement(CodeStatement e)
	{
		if (e.StartDirectives.Count > 0)
		{
			GenerateDirectives(e.StartDirectives);
		}
		if (e.LinePragma != null)
		{
			GenerateLinePragmaStart(e.LinePragma);
		}
		if (e is CodeCommentStatement)
		{
			GenerateCommentStatement((CodeCommentStatement)e);
		}
		else if (e is CodeMethodReturnStatement)
		{
			GenerateMethodReturnStatement((CodeMethodReturnStatement)e);
		}
		else if (e is CodeConditionStatement)
		{
			GenerateConditionStatement((CodeConditionStatement)e);
		}
		else if (e is CodeTryCatchFinallyStatement)
		{
			GenerateTryCatchFinallyStatement((CodeTryCatchFinallyStatement)e);
		}
		else if (e is CodeAssignStatement)
		{
			GenerateAssignStatement((CodeAssignStatement)e);
		}
		else if (e is CodeExpressionStatement)
		{
			GenerateExpressionStatement((CodeExpressionStatement)e);
		}
		else if (e is CodeIterationStatement)
		{
			GenerateIterationStatement((CodeIterationStatement)e);
		}
		else if (e is CodeThrowExceptionStatement)
		{
			GenerateThrowExceptionStatement((CodeThrowExceptionStatement)e);
		}
		else if (e is CodeSnippetStatement)
		{
			int indent = Indent;
			Indent = 0;
			GenerateSnippetStatement((CodeSnippetStatement)e);
			Indent = indent;
		}
		else if (e is CodeVariableDeclarationStatement)
		{
			GenerateVariableDeclarationStatement((CodeVariableDeclarationStatement)e);
		}
		else if (e is CodeAttachEventStatement)
		{
			GenerateAttachEventStatement((CodeAttachEventStatement)e);
		}
		else if (e is CodeRemoveEventStatement)
		{
			GenerateRemoveEventStatement((CodeRemoveEventStatement)e);
		}
		else if (e is CodeGotoStatement)
		{
			GenerateGotoStatement((CodeGotoStatement)e);
		}
		else
		{
			if (!(e is CodeLabeledStatement))
			{
				throw new ArgumentException(SR.GetString("InvalidElementType", e.GetType().FullName), "e");
			}
			GenerateLabeledStatement((CodeLabeledStatement)e);
		}
		if (e.LinePragma != null)
		{
			GenerateLinePragmaEnd(e.LinePragma);
		}
		if (e.EndDirectives.Count > 0)
		{
			GenerateDirectives(e.EndDirectives);
		}
	}

	private void GenerateStatements(CodeStatementCollection stms)
	{
		IEnumerator enumerator = stms.GetEnumerator();
		while (enumerator.MoveNext())
		{
			((ICodeGenerator)this).GenerateCodeFromStatement((CodeStatement)enumerator.Current, output.InnerWriter, options);
		}
	}

	private void GenerateNamespaceImports(CodeNamespace e)
	{
		IEnumerator enumerator = e.Imports.GetEnumerator();
		while (enumerator.MoveNext())
		{
			CodeNamespaceImport codeNamespaceImport = (CodeNamespaceImport)enumerator.Current;
			if (codeNamespaceImport.LinePragma != null)
			{
				GenerateLinePragmaStart(codeNamespaceImport.LinePragma);
			}
			GenerateNamespaceImport(codeNamespaceImport);
			if (codeNamespaceImport.LinePragma != null)
			{
				GenerateLinePragmaEnd(codeNamespaceImport.LinePragma);
			}
		}
	}

	private void GenerateEventReferenceExpression(CodeEventReferenceExpression e)
	{
		if (e.TargetObject != null)
		{
			GenerateExpression(e.TargetObject);
			Output.Write(".");
		}
		OutputIdentifier(e.EventName);
	}

	private void GenerateDelegateInvokeExpression(CodeDelegateInvokeExpression e)
	{
		if (e.TargetObject != null)
		{
			GenerateExpression(e.TargetObject);
		}
		Output.Write("(");
		OutputExpressionList(e.Parameters);
		Output.Write(")");
	}

	private void GenerateObjectCreateExpression(CodeObjectCreateExpression e)
	{
		Output.Write("new ");
		OutputType(e.CreateType);
		Output.Write("(");
		OutputExpressionList(e.Parameters);
		Output.Write(")");
	}

	private void GeneratePrimitiveExpression(CodePrimitiveExpression e)
	{
		if (e.Value is char)
		{
			GeneratePrimitiveChar((char)e.Value);
		}
		else if (e.Value is sbyte)
		{
			Output.Write(((sbyte)e.Value).ToString(CultureInfo.InvariantCulture));
		}
		else if (e.Value is ushort)
		{
			Output.Write(((ushort)e.Value).ToString(CultureInfo.InvariantCulture));
		}
		else if (e.Value is uint)
		{
			Output.Write(((uint)e.Value).ToString(CultureInfo.InvariantCulture));
			Output.Write("u");
		}
		else if (e.Value is ulong)
		{
			Output.Write(((ulong)e.Value).ToString(CultureInfo.InvariantCulture));
			Output.Write("ul");
		}
		else
		{
			GeneratePrimitiveExpressionBase(e);
		}
	}

	private void GeneratePrimitiveExpressionBase(CodePrimitiveExpression e)
	{
		if (e.Value == null)
		{
			Output.Write(NullToken);
			return;
		}
		if (e.Value is string)
		{
			Output.Write(QuoteSnippetString((string)e.Value));
			return;
		}
		if (e.Value is char)
		{
			Output.Write("'" + e.Value.ToString() + "'");
			return;
		}
		if (e.Value is byte)
		{
			Output.Write(((byte)e.Value).ToString(CultureInfo.InvariantCulture));
			return;
		}
		if (e.Value is short)
		{
			Output.Write(((short)e.Value).ToString(CultureInfo.InvariantCulture));
			return;
		}
		if (e.Value is int)
		{
			Output.Write(((int)e.Value).ToString(CultureInfo.InvariantCulture));
			return;
		}
		if (e.Value is long)
		{
			Output.Write(((long)e.Value).ToString(CultureInfo.InvariantCulture));
			return;
		}
		if (e.Value is float)
		{
			GenerateSingleFloatValue((float)e.Value);
			return;
		}
		if (e.Value is double)
		{
			GenerateDoubleValue((double)e.Value);
			return;
		}
		if (e.Value is decimal)
		{
			GenerateDecimalValue((decimal)e.Value);
			return;
		}
		if (e.Value is bool)
		{
			if ((bool)e.Value)
			{
				Output.Write("true");
			}
			else
			{
				Output.Write("false");
			}
			return;
		}
		throw new ArgumentException(SR.GetString("InvalidPrimitiveType", e.Value.GetType().ToString()));
	}

	private void GeneratePrimitiveChar(char c)
	{
		Output.Write('\'');
		switch (c)
		{
		case '\r':
			Output.Write("\\r");
			break;
		case '\t':
			Output.Write("\\t");
			break;
		case '"':
			Output.Write("\\\"");
			break;
		case '\'':
			Output.Write("\\'");
			break;
		case '\\':
			Output.Write("\\\\");
			break;
		case '\0':
			Output.Write("\\0");
			break;
		case '\n':
			Output.Write("\\n");
			break;
		case '\u0084':
		case '\u0085':
		case '\u2028':
		case '\u2029':
			AppendEscapedChar(null, c);
			break;
		default:
			if (char.IsSurrogate(c))
			{
				AppendEscapedChar(null, c);
			}
			else
			{
				Output.Write(c);
			}
			break;
		}
		Output.Write('\'');
	}

	private void AppendEscapedChar(StringBuilder b, char value)
	{
		if (b == null)
		{
			Output.Write("\\u");
			TextWriter textWriter = Output;
			int num = value;
			textWriter.Write(num.ToString("X4", CultureInfo.InvariantCulture));
		}
		else
		{
			b.Append("\\u");
			int num = value;
			b.Append(num.ToString("X4", CultureInfo.InvariantCulture));
		}
	}

	private void GeneratePropertySetValueReferenceExpression(CodePropertySetValueReferenceExpression e)
	{
		Output.Write("value");
	}

	private void GenerateThisReferenceExpression(CodeThisReferenceExpression e)
	{
		Output.Write("this");
	}

	private void GenerateExpressionStatement(CodeExpressionStatement e)
	{
		GenerateExpression(e.Expression);
		if (!generatingForLoop)
		{
			Output.WriteLine(";");
		}
	}

	private void GenerateIterationStatement(CodeIterationStatement e)
	{
		generatingForLoop = true;
		Output.Write("for (");
		GenerateStatement(e.InitStatement);
		Output.Write("; ");
		GenerateExpression(e.TestExpression);
		Output.Write("; ");
		GenerateStatement(e.IncrementStatement);
		Output.Write(")");
		OutputStartingBrace();
		generatingForLoop = false;
		Indent++;
		GenerateStatements(e.Statements);
		Indent--;
		Output.WriteLine("}");
	}

	private void GenerateThrowExceptionStatement(CodeThrowExceptionStatement e)
	{
		Output.Write("throw");
		if (e.ToThrow != null)
		{
			Output.Write(" ");
			GenerateExpression(e.ToThrow);
		}
		Output.WriteLine(";");
	}

	private void GenerateComment(CodeComment e)
	{
		string value = (e.DocComment ? "///" : "//");
		Output.Write(value);
		Output.Write(" ");
		string text = e.Text;
		for (int i = 0; i < text.Length; i++)
		{
			if (text[i] == '\0')
			{
				continue;
			}
			Output.Write(text[i]);
			if (text[i] == '\r')
			{
				if (i < text.Length - 1 && text[i + 1] == '\n')
				{
					Output.Write('\n');
					i++;
				}
				((IndentedTextWriter)Output).InternalOutputTabs();
				Output.Write(value);
			}
			else if (text[i] == '\n')
			{
				((IndentedTextWriter)Output).InternalOutputTabs();
				Output.Write(value);
			}
			else if (text[i] == '\u2028' || text[i] == '\u2029' || text[i] == '\u0085')
			{
				Output.Write(value);
			}
		}
		Output.WriteLine();
	}

	private void GenerateCommentStatement(CodeCommentStatement e)
	{
		if (e.Comment == null)
		{
			throw new ArgumentException(SR.GetString("Argument_NullComment", "e"), "e");
		}
		GenerateComment(e.Comment);
	}

	private void GenerateCommentStatements(CodeCommentStatementCollection e)
	{
		foreach (CodeCommentStatement item in e)
		{
			GenerateCommentStatement(item);
		}
	}

	private void GenerateMethodReturnStatement(CodeMethodReturnStatement e)
	{
		Output.Write("return");
		if (e.Expression != null)
		{
			Output.Write(" ");
			GenerateExpression(e.Expression);
		}
		Output.WriteLine(";");
	}

	private void GenerateConditionStatement(CodeConditionStatement e)
	{
		Output.Write("if (");
		GenerateExpression(e.Condition);
		Output.Write(")");
		OutputStartingBrace();
		Indent++;
		GenerateStatements(e.TrueStatements);
		Indent--;
		CodeStatementCollection falseStatements = e.FalseStatements;
		if (falseStatements.Count > 0)
		{
			Output.Write("}");
			if (Options.ElseOnClosing)
			{
				Output.Write(" ");
			}
			else
			{
				Output.WriteLine("");
			}
			Output.Write("else");
			OutputStartingBrace();
			Indent++;
			GenerateStatements(e.FalseStatements);
			Indent--;
		}
		Output.WriteLine("}");
	}

	private void GenerateTryCatchFinallyStatement(CodeTryCatchFinallyStatement e)
	{
		Output.Write("try");
		OutputStartingBrace();
		Indent++;
		GenerateStatements(e.TryStatements);
		Indent--;
		CodeCatchClauseCollection catchClauses = e.CatchClauses;
		if (catchClauses.Count > 0)
		{
			IEnumerator enumerator = catchClauses.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Output.Write("}");
				if (Options.ElseOnClosing)
				{
					Output.Write(" ");
				}
				else
				{
					Output.WriteLine("");
				}
				CodeCatchClause codeCatchClause = (CodeCatchClause)enumerator.Current;
				Output.Write("catch (");
				OutputType(codeCatchClause.CatchExceptionType);
				Output.Write(" ");
				OutputIdentifier(codeCatchClause.LocalName);
				Output.Write(")");
				OutputStartingBrace();
				Indent++;
				GenerateStatements(codeCatchClause.Statements);
				Indent--;
			}
		}
		CodeStatementCollection finallyStatements = e.FinallyStatements;
		if (finallyStatements.Count > 0)
		{
			Output.Write("}");
			if (Options.ElseOnClosing)
			{
				Output.Write(" ");
			}
			else
			{
				Output.WriteLine("");
			}
			Output.Write("finally");
			OutputStartingBrace();
			Indent++;
			GenerateStatements(finallyStatements);
			Indent--;
		}
		Output.WriteLine("}");
	}

	private void GenerateAssignStatement(CodeAssignStatement e)
	{
		GenerateExpression(e.Left);
		Output.Write(" = ");
		GenerateExpression(e.Right);
		if (!generatingForLoop)
		{
			Output.WriteLine(";");
		}
	}

	private void GenerateAttachEventStatement(CodeAttachEventStatement e)
	{
		GenerateEventReferenceExpression(e.Event);
		Output.Write(" += ");
		GenerateExpression(e.Listener);
		Output.WriteLine(";");
	}

	private void GenerateRemoveEventStatement(CodeRemoveEventStatement e)
	{
		GenerateEventReferenceExpression(e.Event);
		Output.Write(" -= ");
		GenerateExpression(e.Listener);
		Output.WriteLine(";");
	}

	private void GenerateSnippetStatement(CodeSnippetStatement e)
	{
		Output.WriteLine(e.Value);
	}

	private void GenerateGotoStatement(CodeGotoStatement e)
	{
		Output.Write("goto ");
		Output.Write(e.Label);
		Output.WriteLine(";");
	}

	private void GenerateLabeledStatement(CodeLabeledStatement e)
	{
		Indent--;
		Output.Write(e.Label);
		Output.WriteLine(":");
		Indent++;
		if (e.Statement != null)
		{
			GenerateStatement(e.Statement);
		}
	}

	private void GenerateVariableDeclarationStatement(CodeVariableDeclarationStatement e)
	{
		OutputTypeNamePair(e.Type, e.Name);
		if (e.InitExpression != null)
		{
			Output.Write(" = ");
			GenerateExpression(e.InitExpression);
		}
		if (!generatingForLoop)
		{
			Output.WriteLine(";");
		}
	}

	private void GenerateLinePragmaStart(CodeLinePragma e)
	{
		Output.WriteLine("");
		Output.Write("#line ");
		Output.Write(e.LineNumber);
		Output.Write(" \"");
		Output.Write(e.FileName);
		Output.Write("\"");
		Output.WriteLine("");
	}

	private void GenerateLinePragmaEnd(CodeLinePragma e)
	{
		Output.WriteLine();
		Output.WriteLine("#line default");
		Output.WriteLine("#line hidden");
	}

	private void GenerateEvent(CodeMemberEvent e, CodeTypeDeclaration c)
	{
		if (!IsCurrentDelegate && !IsCurrentEnum)
		{
			if (e.CustomAttributes.Count > 0)
			{
				GenerateAttributes(e.CustomAttributes);
			}
			if (e.PrivateImplementationType == null)
			{
				OutputMemberAccessModifier(e.Attributes);
			}
			Output.Write("event ");
			string text = e.Name;
			if (e.PrivateImplementationType != null)
			{
				text = GetBaseTypeOutput(e.PrivateImplementationType) + "." + text;
			}
			OutputTypeNamePair(e.Type, text);
			Output.WriteLine(";");
		}
	}

	private void GenerateExpression(CodeExpression e)
	{
		if (e is CodeArrayCreateExpression)
		{
			GenerateArrayCreateExpression((CodeArrayCreateExpression)e);
			return;
		}
		if (e is CodeBaseReferenceExpression)
		{
			GenerateBaseReferenceExpression((CodeBaseReferenceExpression)e);
			return;
		}
		if (e is CodeBinaryOperatorExpression)
		{
			GenerateBinaryOperatorExpression((CodeBinaryOperatorExpression)e);
			return;
		}
		if (e is CodeCastExpression)
		{
			GenerateCastExpression((CodeCastExpression)e);
			return;
		}
		if (e is CodeDelegateCreateExpression)
		{
			GenerateDelegateCreateExpression((CodeDelegateCreateExpression)e);
			return;
		}
		if (e is CodeFieldReferenceExpression)
		{
			GenerateFieldReferenceExpression((CodeFieldReferenceExpression)e);
			return;
		}
		if (e is CodeArgumentReferenceExpression)
		{
			GenerateArgumentReferenceExpression((CodeArgumentReferenceExpression)e);
			return;
		}
		if (e is CodeVariableReferenceExpression)
		{
			GenerateVariableReferenceExpression((CodeVariableReferenceExpression)e);
			return;
		}
		if (e is CodeIndexerExpression)
		{
			GenerateIndexerExpression((CodeIndexerExpression)e);
			return;
		}
		if (e is CodeArrayIndexerExpression)
		{
			GenerateArrayIndexerExpression((CodeArrayIndexerExpression)e);
			return;
		}
		if (e is CodeSnippetExpression)
		{
			GenerateSnippetExpression((CodeSnippetExpression)e);
			return;
		}
		if (e is CodeMethodInvokeExpression)
		{
			GenerateMethodInvokeExpression((CodeMethodInvokeExpression)e);
			return;
		}
		if (e is CodeMethodReferenceExpression)
		{
			GenerateMethodReferenceExpression((CodeMethodReferenceExpression)e);
			return;
		}
		if (e is CodeEventReferenceExpression)
		{
			GenerateEventReferenceExpression((CodeEventReferenceExpression)e);
			return;
		}
		if (e is CodeDelegateInvokeExpression)
		{
			GenerateDelegateInvokeExpression((CodeDelegateInvokeExpression)e);
			return;
		}
		if (e is CodeObjectCreateExpression)
		{
			GenerateObjectCreateExpression((CodeObjectCreateExpression)e);
			return;
		}
		if (e is CodeParameterDeclarationExpression)
		{
			GenerateParameterDeclarationExpression((CodeParameterDeclarationExpression)e);
			return;
		}
		if (e is CodeDirectionExpression)
		{
			GenerateDirectionExpression((CodeDirectionExpression)e);
			return;
		}
		if (e is CodePrimitiveExpression)
		{
			GeneratePrimitiveExpression((CodePrimitiveExpression)e);
			return;
		}
		if (e is CodePropertyReferenceExpression)
		{
			GeneratePropertyReferenceExpression((CodePropertyReferenceExpression)e);
			return;
		}
		if (e is CodePropertySetValueReferenceExpression)
		{
			GeneratePropertySetValueReferenceExpression((CodePropertySetValueReferenceExpression)e);
			return;
		}
		if (e is CodeThisReferenceExpression)
		{
			GenerateThisReferenceExpression((CodeThisReferenceExpression)e);
			return;
		}
		if (e is CodeTypeReferenceExpression)
		{
			GenerateTypeReferenceExpression((CodeTypeReferenceExpression)e);
			return;
		}
		if (e is CodeTypeOfExpression)
		{
			GenerateTypeOfExpression((CodeTypeOfExpression)e);
			return;
		}
		if (e is CodeDefaultValueExpression)
		{
			GenerateDefaultValueExpression((CodeDefaultValueExpression)e);
			return;
		}
		if (e == null)
		{
			throw new ArgumentNullException("e");
		}
		throw new ArgumentException(SR.GetString("InvalidElementType", e.GetType().FullName), "e");
	}

	private void GenerateField(CodeMemberField e)
	{
		if (IsCurrentDelegate || IsCurrentInterface)
		{
			return;
		}
		if (IsCurrentEnum)
		{
			if (e.CustomAttributes.Count > 0)
			{
				GenerateAttributes(e.CustomAttributes);
			}
			OutputIdentifier(e.Name);
			if (e.InitExpression != null)
			{
				Output.Write(" = ");
				GenerateExpression(e.InitExpression);
			}
			Output.WriteLine(",");
			return;
		}
		if (e.CustomAttributes.Count > 0)
		{
			GenerateAttributes(e.CustomAttributes);
		}
		OutputMemberAccessModifier(e.Attributes);
		OutputVTableModifier(e.Attributes);
		OutputFieldScopeModifier(e.Attributes);
		OutputTypeNamePair(e.Type, e.Name);
		if (e.InitExpression != null)
		{
			Output.Write(" = ");
			GenerateExpression(e.InitExpression);
		}
		Output.WriteLine(";");
	}

	private void GenerateSnippetMember(CodeSnippetTypeMember e)
	{
		Output.Write(e.Text);
	}

	private void GenerateParameterDeclarationExpression(CodeParameterDeclarationExpression e)
	{
		if (e.CustomAttributes.Count > 0)
		{
			GenerateAttributes(e.CustomAttributes, null, inLine: true);
		}
		OutputDirection(e.Direction);
		OutputTypeNamePair(e.Type, e.Name);
	}

	private void GenerateEntryPointMethod(CodeEntryPointMethod e, CodeTypeDeclaration c)
	{
		if (e.CustomAttributes.Count > 0)
		{
			GenerateAttributes(e.CustomAttributes);
		}
		Output.Write("public static ");
		OutputType(e.ReturnType);
		Output.Write(" Main()");
		OutputStartingBrace();
		Indent++;
		GenerateStatements(e.Statements);
		Indent--;
		Output.WriteLine("}");
	}

	private void GenerateMethods(CodeTypeDeclaration e)
	{
		IEnumerator enumerator = e.Members.GetEnumerator();
		while (enumerator.MoveNext())
		{
			if (enumerator.Current is CodeMemberMethod && !(enumerator.Current is CodeTypeConstructor) && !(enumerator.Current is CodeConstructor))
			{
				currentMember = (CodeTypeMember)enumerator.Current;
				if (options.BlankLinesBetweenMembers)
				{
					Output.WriteLine();
				}
				if (currentMember.StartDirectives.Count > 0)
				{
					GenerateDirectives(currentMember.StartDirectives);
				}
				GenerateCommentStatements(currentMember.Comments);
				CodeMemberMethod codeMemberMethod = (CodeMemberMethod)enumerator.Current;
				if (codeMemberMethod.LinePragma != null)
				{
					GenerateLinePragmaStart(codeMemberMethod.LinePragma);
				}
				if (enumerator.Current is CodeEntryPointMethod)
				{
					GenerateEntryPointMethod((CodeEntryPointMethod)enumerator.Current, e);
				}
				else
				{
					GenerateMethod(codeMemberMethod, e);
				}
				if (codeMemberMethod.LinePragma != null)
				{
					GenerateLinePragmaEnd(codeMemberMethod.LinePragma);
				}
				if (currentMember.EndDirectives.Count > 0)
				{
					GenerateDirectives(currentMember.EndDirectives);
				}
			}
		}
	}

	private void GenerateMethod(CodeMemberMethod e, CodeTypeDeclaration c)
	{
		if (!IsCurrentClass && !IsCurrentStruct && !IsCurrentInterface)
		{
			return;
		}
		if (e.CustomAttributes.Count > 0)
		{
			GenerateAttributes(e.CustomAttributes);
		}
		if (e.ReturnTypeCustomAttributes.Count > 0)
		{
			GenerateAttributes(e.ReturnTypeCustomAttributes, "return: ");
		}
		if (!IsCurrentInterface)
		{
			if (e.PrivateImplementationType == null)
			{
				OutputMemberAccessModifier(e.Attributes);
				OutputVTableModifier(e.Attributes);
				OutputMemberScopeModifier(e.Attributes);
			}
		}
		else
		{
			OutputVTableModifier(e.Attributes);
		}
		OutputType(e.ReturnType);
		Output.Write(" ");
		if (e.PrivateImplementationType != null)
		{
			Output.Write(GetBaseTypeOutput(e.PrivateImplementationType));
			Output.Write(".");
		}
		OutputIdentifier(e.Name);
		OutputTypeParameters(e.TypeParameters);
		Output.Write("(");
		OutputParameters(e.Parameters);
		Output.Write(")");
		OutputTypeParameterConstraints(e.TypeParameters);
		if (!IsCurrentInterface && (e.Attributes & MemberAttributes.ScopeMask) != MemberAttributes.Abstract)
		{
			OutputStartingBrace();
			Indent++;
			GenerateStatements(e.Statements);
			Indent--;
			Output.WriteLine("}");
		}
		else
		{
			Output.WriteLine(";");
		}
	}

	private void GenerateProperties(CodeTypeDeclaration e)
	{
		IEnumerator enumerator = e.Members.GetEnumerator();
		while (enumerator.MoveNext())
		{
			if (enumerator.Current is CodeMemberProperty)
			{
				currentMember = (CodeTypeMember)enumerator.Current;
				if (options.BlankLinesBetweenMembers)
				{
					Output.WriteLine();
				}
				if (currentMember.StartDirectives.Count > 0)
				{
					GenerateDirectives(currentMember.StartDirectives);
				}
				GenerateCommentStatements(currentMember.Comments);
				CodeMemberProperty codeMemberProperty = (CodeMemberProperty)enumerator.Current;
				if (codeMemberProperty.LinePragma != null)
				{
					GenerateLinePragmaStart(codeMemberProperty.LinePragma);
				}
				GenerateProperty(codeMemberProperty, e);
				if (codeMemberProperty.LinePragma != null)
				{
					GenerateLinePragmaEnd(codeMemberProperty.LinePragma);
				}
				if (currentMember.EndDirectives.Count > 0)
				{
					GenerateDirectives(currentMember.EndDirectives);
				}
			}
		}
	}

	private void GenerateProperty(CodeMemberProperty e, CodeTypeDeclaration c)
	{
		if (!IsCurrentClass && !IsCurrentStruct && !IsCurrentInterface)
		{
			return;
		}
		if (e.CustomAttributes.Count > 0)
		{
			GenerateAttributes(e.CustomAttributes);
		}
		if (!IsCurrentInterface)
		{
			if (e.PrivateImplementationType == null)
			{
				OutputMemberAccessModifier(e.Attributes);
				OutputVTableModifier(e.Attributes);
				OutputMemberScopeModifier(e.Attributes);
			}
		}
		else
		{
			OutputVTableModifier(e.Attributes);
		}
		OutputType(e.Type);
		Output.Write(" ");
		if (e.PrivateImplementationType != null && !IsCurrentInterface)
		{
			Output.Write(GetBaseTypeOutput(e.PrivateImplementationType));
			Output.Write(".");
		}
		if (e.Parameters.Count > 0 && string.Compare(e.Name, "Item", StringComparison.OrdinalIgnoreCase) == 0)
		{
			Output.Write("this[");
			OutputParameters(e.Parameters);
			Output.Write("]");
		}
		else
		{
			OutputIdentifier(e.Name);
		}
		OutputStartingBrace();
		Indent++;
		if (e.HasGet)
		{
			if (IsCurrentInterface || (e.Attributes & MemberAttributes.ScopeMask) == MemberAttributes.Abstract)
			{
				Output.WriteLine("get;");
			}
			else
			{
				Output.Write("get");
				OutputStartingBrace();
				Indent++;
				GenerateStatements(e.GetStatements);
				Indent--;
				Output.WriteLine("}");
			}
		}
		if (e.HasSet)
		{
			if (IsCurrentInterface || (e.Attributes & MemberAttributes.ScopeMask) == MemberAttributes.Abstract)
			{
				Output.WriteLine("set;");
			}
			else
			{
				Output.Write("set");
				OutputStartingBrace();
				Indent++;
				GenerateStatements(e.SetStatements);
				Indent--;
				Output.WriteLine("}");
			}
		}
		Indent--;
		Output.WriteLine("}");
	}

	private void GenerateSingleFloatValue(float s)
	{
		if (float.IsNaN(s))
		{
			Output.Write("float.NaN");
			return;
		}
		if (float.IsNegativeInfinity(s))
		{
			Output.Write("float.NegativeInfinity");
			return;
		}
		if (float.IsPositiveInfinity(s))
		{
			Output.Write("float.PositiveInfinity");
			return;
		}
		Output.Write(s.ToString(CultureInfo.InvariantCulture));
		Output.Write('F');
	}

	private void GenerateDoubleValue(double d)
	{
		if (double.IsNaN(d))
		{
			Output.Write("double.NaN");
			return;
		}
		if (double.IsNegativeInfinity(d))
		{
			Output.Write("double.NegativeInfinity");
			return;
		}
		if (double.IsPositiveInfinity(d))
		{
			Output.Write("double.PositiveInfinity");
			return;
		}
		Output.Write(d.ToString("R", CultureInfo.InvariantCulture));
		Output.Write("D");
	}

	private void GenerateDecimalValue(decimal d)
	{
		Output.Write(d.ToString(CultureInfo.InvariantCulture));
		Output.Write('m');
	}

	private void OutputVTableModifier(MemberAttributes attributes)
	{
		MemberAttributes memberAttributes = attributes & MemberAttributes.VTableMask;
		if (memberAttributes == MemberAttributes.New)
		{
			Output.Write("new ");
		}
	}

	private void OutputMemberAccessModifier(MemberAttributes attributes)
	{
		switch (attributes & MemberAttributes.AccessMask)
		{
		case MemberAttributes.Assembly:
			Output.Write("internal ");
			break;
		case MemberAttributes.FamilyAndAssembly:
			Output.Write("internal ");
			break;
		case MemberAttributes.Family:
			Output.Write("protected ");
			break;
		case MemberAttributes.FamilyOrAssembly:
			Output.Write("protected internal ");
			break;
		case MemberAttributes.Private:
			Output.Write("private ");
			break;
		case MemberAttributes.Public:
			Output.Write("public ");
			break;
		}
	}

	private void OutputMemberScopeModifier(MemberAttributes attributes)
	{
		switch (attributes & MemberAttributes.ScopeMask)
		{
		case MemberAttributes.Abstract:
			Output.Write("abstract ");
			return;
		case MemberAttributes.Final:
			Output.Write("");
			return;
		case MemberAttributes.Static:
			Output.Write("static ");
			return;
		case MemberAttributes.Override:
			Output.Write("override ");
			return;
		}
		MemberAttributes memberAttributes = attributes & MemberAttributes.AccessMask;
		if (memberAttributes == MemberAttributes.Assembly || memberAttributes == MemberAttributes.Family || memberAttributes == MemberAttributes.Public)
		{
			Output.Write("virtual ");
		}
	}

	private void OutputOperator(CodeBinaryOperatorType op)
	{
		switch (op)
		{
		case CodeBinaryOperatorType.Add:
			Output.Write("+");
			break;
		case CodeBinaryOperatorType.Subtract:
			Output.Write("-");
			break;
		case CodeBinaryOperatorType.Multiply:
			Output.Write("*");
			break;
		case CodeBinaryOperatorType.Divide:
			Output.Write("/");
			break;
		case CodeBinaryOperatorType.Modulus:
			Output.Write("%");
			break;
		case CodeBinaryOperatorType.Assign:
			Output.Write("=");
			break;
		case CodeBinaryOperatorType.IdentityInequality:
			Output.Write("!=");
			break;
		case CodeBinaryOperatorType.IdentityEquality:
			Output.Write("==");
			break;
		case CodeBinaryOperatorType.ValueEquality:
			Output.Write("==");
			break;
		case CodeBinaryOperatorType.BitwiseOr:
			Output.Write("|");
			break;
		case CodeBinaryOperatorType.BitwiseAnd:
			Output.Write("&");
			break;
		case CodeBinaryOperatorType.BooleanOr:
			Output.Write("||");
			break;
		case CodeBinaryOperatorType.BooleanAnd:
			Output.Write("&&");
			break;
		case CodeBinaryOperatorType.LessThan:
			Output.Write("<");
			break;
		case CodeBinaryOperatorType.LessThanOrEqual:
			Output.Write("<=");
			break;
		case CodeBinaryOperatorType.GreaterThan:
			Output.Write(">");
			break;
		case CodeBinaryOperatorType.GreaterThanOrEqual:
			Output.Write(">=");
			break;
		}
	}

	private void OutputFieldScopeModifier(MemberAttributes attributes)
	{
		switch (attributes & MemberAttributes.ScopeMask)
		{
		case MemberAttributes.Static:
			Output.Write("static ");
			break;
		case MemberAttributes.Const:
			Output.Write("const ");
			break;
		case MemberAttributes.Final:
		case MemberAttributes.Override:
			break;
		}
	}

	private void GeneratePropertyReferenceExpression(CodePropertyReferenceExpression e)
	{
		if (e.TargetObject != null)
		{
			GenerateExpression(e.TargetObject);
			Output.Write(".");
		}
		OutputIdentifier(e.PropertyName);
	}

	private void GenerateConstructors(CodeTypeDeclaration e)
	{
		IEnumerator enumerator = e.Members.GetEnumerator();
		while (enumerator.MoveNext())
		{
			if (enumerator.Current is CodeConstructor)
			{
				currentMember = (CodeTypeMember)enumerator.Current;
				if (options.BlankLinesBetweenMembers)
				{
					Output.WriteLine();
				}
				if (currentMember.StartDirectives.Count > 0)
				{
					GenerateDirectives(currentMember.StartDirectives);
				}
				GenerateCommentStatements(currentMember.Comments);
				CodeConstructor codeConstructor = (CodeConstructor)enumerator.Current;
				if (codeConstructor.LinePragma != null)
				{
					GenerateLinePragmaStart(codeConstructor.LinePragma);
				}
				GenerateConstructor(codeConstructor, e);
				if (codeConstructor.LinePragma != null)
				{
					GenerateLinePragmaEnd(codeConstructor.LinePragma);
				}
				if (currentMember.EndDirectives.Count > 0)
				{
					GenerateDirectives(currentMember.EndDirectives);
				}
			}
		}
	}

	private void GenerateConstructor(CodeConstructor e, CodeTypeDeclaration c)
	{
		if (IsCurrentClass || IsCurrentStruct)
		{
			if (e.CustomAttributes.Count > 0)
			{
				GenerateAttributes(e.CustomAttributes);
			}
			OutputMemberAccessModifier(e.Attributes);
			OutputIdentifier(CurrentTypeName);
			Output.Write("(");
			OutputParameters(e.Parameters);
			Output.Write(")");
			CodeExpressionCollection baseConstructorArgs = e.BaseConstructorArgs;
			CodeExpressionCollection chainedConstructorArgs = e.ChainedConstructorArgs;
			if (baseConstructorArgs.Count > 0)
			{
				Output.WriteLine(" : ");
				Indent++;
				Indent++;
				Output.Write("base(");
				OutputExpressionList(baseConstructorArgs);
				Output.Write(")");
				Indent--;
				Indent--;
			}
			if (chainedConstructorArgs.Count > 0)
			{
				Output.WriteLine(" : ");
				Indent++;
				Indent++;
				Output.Write("this(");
				OutputExpressionList(chainedConstructorArgs);
				Output.Write(")");
				Indent--;
				Indent--;
			}
			OutputStartingBrace();
			Indent++;
			GenerateStatements(e.Statements);
			Indent--;
			Output.WriteLine("}");
		}
	}

	private void GenerateTypeConstructor(CodeTypeConstructor e)
	{
		if (IsCurrentClass || IsCurrentStruct)
		{
			if (e.CustomAttributes.Count > 0)
			{
				GenerateAttributes(e.CustomAttributes);
			}
			Output.Write("static ");
			Output.Write(CurrentTypeName);
			Output.Write("()");
			OutputStartingBrace();
			Indent++;
			GenerateStatements(e.Statements);
			Indent--;
			Output.WriteLine("}");
		}
	}

	private void GenerateTypeReferenceExpression(CodeTypeReferenceExpression e)
	{
		OutputType(e.Type);
	}

	private void GenerateTypeOfExpression(CodeTypeOfExpression e)
	{
		Output.Write("typeof(");
		OutputType(e.Type);
		Output.Write(")");
	}

	private void GenerateType(CodeTypeDeclaration e)
	{
		currentClass = e;
		if (e.StartDirectives.Count > 0)
		{
			GenerateDirectives(e.StartDirectives);
		}
		GenerateCommentStatements(e.Comments);
		if (e.LinePragma != null)
		{
			GenerateLinePragmaStart(e.LinePragma);
		}
		GenerateTypeStart(e);
		if (Options.VerbatimOrder)
		{
			foreach (CodeTypeMember member in e.Members)
			{
				GenerateTypeMember(member, e);
			}
		}
		else
		{
			GenerateFields(e);
			GenerateSnippetMembers(e);
			GenerateTypeConstructors(e);
			GenerateConstructors(e);
			GenerateProperties(e);
			GenerateEvents(e);
			GenerateMethods(e);
			GenerateNestedTypes(e);
		}
		currentClass = e;
		GenerateTypeEnd(e);
		if (e.LinePragma != null)
		{
			GenerateLinePragmaEnd(e.LinePragma);
		}
		if (e.EndDirectives.Count > 0)
		{
			GenerateDirectives(e.EndDirectives);
		}
	}

	private void GenerateTypes(CodeNamespace e)
	{
		foreach (CodeTypeDeclaration type in e.Types)
		{
			if (options.BlankLinesBetweenMembers)
			{
				Output.WriteLine();
			}
			((ICodeGenerator)this).GenerateCodeFromType(type, output.InnerWriter, options);
		}
	}

	private void GenerateTypeStart(CodeTypeDeclaration e)
	{
		if (e.CustomAttributes.Count > 0)
		{
			GenerateAttributes(e.CustomAttributes);
		}
		if (IsCurrentDelegate)
		{
			TypeAttributes typeAttributes = e.TypeAttributes & TypeAttributes.VisibilityMask;
			if (typeAttributes != TypeAttributes.NotPublic && typeAttributes == TypeAttributes.Public)
			{
				Output.Write("public ");
			}
			CodeTypeDelegate codeTypeDelegate = (CodeTypeDelegate)e;
			Output.Write("delegate ");
			OutputType(codeTypeDelegate.ReturnType);
			Output.Write(" ");
			OutputIdentifier(e.Name);
			Output.Write("(");
			OutputParameters(codeTypeDelegate.Parameters);
			Output.WriteLine(");");
			return;
		}
		OutputTypeAttributes(e);
		OutputIdentifier(e.Name);
		OutputTypeParameters(e.TypeParameters);
		bool flag = true;
		foreach (CodeTypeReference baseType in e.BaseTypes)
		{
			if (flag)
			{
				Output.Write(" : ");
				flag = false;
			}
			else
			{
				Output.Write(", ");
			}
			OutputType(baseType);
		}
		OutputTypeParameterConstraints(e.TypeParameters);
		OutputStartingBrace();
		Indent++;
	}

	private void GenerateTypeMember(CodeTypeMember member, CodeTypeDeclaration declaredType)
	{
		if (options.BlankLinesBetweenMembers)
		{
			Output.WriteLine();
		}
		if (member is CodeTypeDeclaration)
		{
			((ICodeGenerator)this).GenerateCodeFromType((CodeTypeDeclaration)member, output.InnerWriter, options);
			currentClass = declaredType;
			return;
		}
		if (member.StartDirectives.Count > 0)
		{
			GenerateDirectives(member.StartDirectives);
		}
		GenerateCommentStatements(member.Comments);
		if (member.LinePragma != null)
		{
			GenerateLinePragmaStart(member.LinePragma);
		}
		if (member is CodeMemberField)
		{
			GenerateField((CodeMemberField)member);
		}
		else if (member is CodeMemberProperty)
		{
			GenerateProperty((CodeMemberProperty)member, declaredType);
		}
		else if (member is CodeMemberMethod)
		{
			if (member is CodeConstructor)
			{
				GenerateConstructor((CodeConstructor)member, declaredType);
			}
			else if (member is CodeTypeConstructor)
			{
				GenerateTypeConstructor((CodeTypeConstructor)member);
			}
			else if (member is CodeEntryPointMethod)
			{
				GenerateEntryPointMethod((CodeEntryPointMethod)member, declaredType);
			}
			else
			{
				GenerateMethod((CodeMemberMethod)member, declaredType);
			}
		}
		else if (member is CodeMemberEvent)
		{
			GenerateEvent((CodeMemberEvent)member, declaredType);
		}
		else if (member is CodeSnippetTypeMember)
		{
			int indent = Indent;
			Indent = 0;
			GenerateSnippetMember((CodeSnippetTypeMember)member);
			Indent = indent;
			Output.WriteLine();
		}
		if (member.LinePragma != null)
		{
			GenerateLinePragmaEnd(member.LinePragma);
		}
		if (member.EndDirectives.Count > 0)
		{
			GenerateDirectives(member.EndDirectives);
		}
	}

	private void GenerateTypeConstructors(CodeTypeDeclaration e)
	{
		IEnumerator enumerator = e.Members.GetEnumerator();
		while (enumerator.MoveNext())
		{
			if (enumerator.Current is CodeTypeConstructor)
			{
				currentMember = (CodeTypeMember)enumerator.Current;
				if (options.BlankLinesBetweenMembers)
				{
					Output.WriteLine();
				}
				if (currentMember.StartDirectives.Count > 0)
				{
					GenerateDirectives(currentMember.StartDirectives);
				}
				GenerateCommentStatements(currentMember.Comments);
				CodeTypeConstructor codeTypeConstructor = (CodeTypeConstructor)enumerator.Current;
				if (codeTypeConstructor.LinePragma != null)
				{
					GenerateLinePragmaStart(codeTypeConstructor.LinePragma);
				}
				GenerateTypeConstructor(codeTypeConstructor);
				if (codeTypeConstructor.LinePragma != null)
				{
					GenerateLinePragmaEnd(codeTypeConstructor.LinePragma);
				}
				if (currentMember.EndDirectives.Count > 0)
				{
					GenerateDirectives(currentMember.EndDirectives);
				}
			}
		}
	}

	private void GenerateSnippetMembers(CodeTypeDeclaration e)
	{
		IEnumerator enumerator = e.Members.GetEnumerator();
		bool flag = false;
		while (enumerator.MoveNext())
		{
			if (enumerator.Current is CodeSnippetTypeMember)
			{
				flag = true;
				currentMember = (CodeTypeMember)enumerator.Current;
				if (options.BlankLinesBetweenMembers)
				{
					Output.WriteLine();
				}
				if (currentMember.StartDirectives.Count > 0)
				{
					GenerateDirectives(currentMember.StartDirectives);
				}
				GenerateCommentStatements(currentMember.Comments);
				CodeSnippetTypeMember codeSnippetTypeMember = (CodeSnippetTypeMember)enumerator.Current;
				if (codeSnippetTypeMember.LinePragma != null)
				{
					GenerateLinePragmaStart(codeSnippetTypeMember.LinePragma);
				}
				int indent = Indent;
				Indent = 0;
				GenerateSnippetMember(codeSnippetTypeMember);
				Indent = indent;
				if (codeSnippetTypeMember.LinePragma != null)
				{
					GenerateLinePragmaEnd(codeSnippetTypeMember.LinePragma);
				}
				if (currentMember.EndDirectives.Count > 0)
				{
					GenerateDirectives(currentMember.EndDirectives);
				}
			}
		}
		if (flag)
		{
			Output.WriteLine();
		}
	}

	private void GenerateNestedTypes(CodeTypeDeclaration e)
	{
		IEnumerator enumerator = e.Members.GetEnumerator();
		while (enumerator.MoveNext())
		{
			if (enumerator.Current is CodeTypeDeclaration)
			{
				if (options.BlankLinesBetweenMembers)
				{
					Output.WriteLine();
				}
				CodeTypeDeclaration e2 = (CodeTypeDeclaration)enumerator.Current;
				((ICodeGenerator)this).GenerateCodeFromType(e2, output.InnerWriter, options);
			}
		}
	}

	private void GenerateNamespaces(CodeCompileUnit e)
	{
		foreach (CodeNamespace @namespace in e.Namespaces)
		{
			((ICodeGenerator)this).GenerateCodeFromNamespace(@namespace, output.InnerWriter, options);
		}
	}

	private void OutputAttributeArgument(CodeAttributeArgument arg)
	{
		if (arg.Name != null && arg.Name.Length > 0)
		{
			OutputIdentifier(arg.Name);
			Output.Write("=");
		}
		((ICodeGenerator)this).GenerateCodeFromExpression(arg.Value, output.InnerWriter, options);
	}

	private void OutputDirection(FieldDirection dir)
	{
		switch (dir)
		{
		case FieldDirection.Out:
			Output.Write("out ");
			break;
		case FieldDirection.Ref:
			Output.Write("ref ");
			break;
		case FieldDirection.In:
			break;
		}
	}

	private void OutputExpressionList(CodeExpressionCollection expressions)
	{
		OutputExpressionList(expressions, newlineBetweenItems: false);
	}

	private void OutputExpressionList(CodeExpressionCollection expressions, bool newlineBetweenItems)
	{
		bool flag = true;
		IEnumerator enumerator = expressions.GetEnumerator();
		Indent++;
		while (enumerator.MoveNext())
		{
			if (flag)
			{
				flag = false;
			}
			else if (newlineBetweenItems)
			{
				ContinueOnNewLine(",");
			}
			else
			{
				Output.Write(", ");
			}
			((ICodeGenerator)this).GenerateCodeFromExpression((CodeExpression)enumerator.Current, output.InnerWriter, options);
		}
		Indent--;
	}

	private void OutputParameters(CodeParameterDeclarationExpressionCollection parameters)
	{
		bool flag = true;
		bool flag2 = parameters.Count > 15;
		if (flag2)
		{
			Indent += 3;
		}
		IEnumerator enumerator = parameters.GetEnumerator();
		while (enumerator.MoveNext())
		{
			CodeParameterDeclarationExpression e = (CodeParameterDeclarationExpression)enumerator.Current;
			if (flag)
			{
				flag = false;
			}
			else
			{
				Output.Write(", ");
			}
			if (flag2)
			{
				ContinueOnNewLine("");
			}
			GenerateExpression(e);
		}
		if (flag2)
		{
			Indent -= 3;
		}
	}

	private void OutputTypeNamePair(CodeTypeReference typeRef, string name)
	{
		OutputType(typeRef);
		Output.Write(" ");
		OutputIdentifier(name);
	}

	private void OutputTypeParameters(CodeTypeParameterCollection typeParameters)
	{
		if (typeParameters.Count == 0)
		{
			return;
		}
		Output.Write('<');
		bool flag = true;
		for (int i = 0; i < typeParameters.Count; i++)
		{
			if (flag)
			{
				flag = false;
			}
			else
			{
				Output.Write(", ");
			}
			if (typeParameters[i].CustomAttributes.Count > 0)
			{
				GenerateAttributes(typeParameters[i].CustomAttributes, null, inLine: true);
				Output.Write(' ');
			}
			Output.Write(typeParameters[i].Name);
		}
		Output.Write('>');
	}

	private void OutputTypeParameterConstraints(CodeTypeParameterCollection typeParameters)
	{
		if (typeParameters.Count == 0)
		{
			return;
		}
		for (int i = 0; i < typeParameters.Count; i++)
		{
			Output.WriteLine();
			Indent++;
			bool flag = true;
			if (typeParameters[i].Constraints.Count > 0)
			{
				foreach (CodeTypeReference constraint in typeParameters[i].Constraints)
				{
					if (flag)
					{
						Output.Write("where ");
						Output.Write(typeParameters[i].Name);
						Output.Write(" : ");
						flag = false;
					}
					else
					{
						Output.Write(", ");
					}
					OutputType(constraint);
				}
			}
			if (typeParameters[i].HasConstructorConstraint)
			{
				if (flag)
				{
					Output.Write("where ");
					Output.Write(typeParameters[i].Name);
					Output.Write(" : new()");
				}
				else
				{
					Output.Write(", new ()");
				}
			}
			Indent--;
		}
	}

	private void OutputTypeAttributes(CodeTypeDeclaration e)
	{
		if ((e.Attributes & MemberAttributes.New) != 0)
		{
			Output.Write("new ");
		}
		TypeAttributes typeAttributes = e.TypeAttributes;
		switch (typeAttributes & TypeAttributes.VisibilityMask)
		{
		case TypeAttributes.Public:
		case TypeAttributes.NestedPublic:
			Output.Write("public ");
			break;
		case TypeAttributes.NestedPrivate:
			Output.Write("private ");
			break;
		case TypeAttributes.NestedFamily:
			Output.Write("protected ");
			break;
		case TypeAttributes.NotPublic:
		case TypeAttributes.NestedAssembly:
		case TypeAttributes.NestedFamANDAssem:
			Output.Write("internal ");
			break;
		case TypeAttributes.VisibilityMask:
			Output.Write("protected internal ");
			break;
		}
		if (e.IsStruct)
		{
			if (e.IsPartial)
			{
				Output.Write("partial ");
			}
			Output.Write("struct ");
			return;
		}
		if (e.IsEnum)
		{
			Output.Write("enum ");
			return;
		}
		switch (typeAttributes & TypeAttributes.ClassSemanticsMask)
		{
		case TypeAttributes.NotPublic:
			if ((typeAttributes & TypeAttributes.Sealed) == TypeAttributes.Sealed)
			{
				Output.Write("sealed ");
			}
			if ((typeAttributes & TypeAttributes.Abstract) == TypeAttributes.Abstract)
			{
				Output.Write("abstract ");
			}
			if (e.IsPartial)
			{
				Output.Write("partial ");
			}
			Output.Write("class ");
			break;
		case TypeAttributes.ClassSemanticsMask:
			if (e.IsPartial)
			{
				Output.Write("partial ");
			}
			Output.Write("interface ");
			break;
		}
	}

	private void GenerateTypeEnd(CodeTypeDeclaration e)
	{
		if (!IsCurrentDelegate)
		{
			Indent--;
			Output.WriteLine("}");
		}
	}

	private void GenerateNamespaceStart(CodeNamespace e)
	{
		if (e.Name != null && e.Name.Length > 0)
		{
			Output.Write("namespace ");
			string[] array = e.Name.Split('.');
			OutputIdentifier(array[0]);
			for (int i = 1; i < array.Length; i++)
			{
				Output.Write(".");
				OutputIdentifier(array[i]);
			}
			OutputStartingBrace();
			Indent++;
		}
	}

	private void GenerateCompileUnit(CodeCompileUnit e)
	{
		GenerateCompileUnitStart(e);
		GenerateNamespaces(e);
		GenerateCompileUnitEnd(e);
	}

	private void GenerateCompileUnitStart(CodeCompileUnit e)
	{
		if (e.StartDirectives.Count > 0)
		{
			GenerateDirectives(e.StartDirectives);
		}
		Output.WriteLine("//------------------------------------------------------------------------------");
		Output.Write("// <");
		Output.WriteLine(SR.GetString("AutoGen_Comment_Line1"));
		Output.Write("//     ");
		Output.WriteLine(SR.GetString("AutoGen_Comment_Line2"));
		Output.Write("//     ");
		Output.Write(SR.GetString("AutoGen_Comment_Line3"));
		Output.WriteLine(Environment.Version.ToString());
		Output.WriteLine("//");
		Output.Write("//     ");
		Output.WriteLine(SR.GetString("AutoGen_Comment_Line4"));
		Output.Write("//     ");
		Output.WriteLine(SR.GetString("AutoGen_Comment_Line5"));
		Output.Write("// </");
		Output.WriteLine(SR.GetString("AutoGen_Comment_Line1"));
		Output.WriteLine("//------------------------------------------------------------------------------");
		Output.WriteLine("");
		SortedList sortedList = new SortedList(StringComparer.Ordinal);
		foreach (CodeNamespace @namespace in e.Namespaces)
		{
			if (!string.IsNullOrEmpty(@namespace.Name))
			{
				continue;
			}
			@namespace.UserData["GenerateImports"] = false;
			foreach (CodeNamespaceImport import in @namespace.Imports)
			{
				if (!sortedList.Contains(import.Namespace))
				{
					sortedList.Add(import.Namespace, import.Namespace);
				}
			}
		}
		foreach (string key in sortedList.Keys)
		{
			Output.Write("using ");
			OutputIdentifier(key);
			Output.WriteLine(";");
		}
		if (sortedList.Keys.Count > 0)
		{
			Output.WriteLine("");
		}
		if (e.AssemblyCustomAttributes.Count > 0)
		{
			GenerateAttributes(e.AssemblyCustomAttributes, "assembly: ");
			Output.WriteLine("");
		}
	}

	private void GenerateCompileUnitEnd(CodeCompileUnit e)
	{
		if (e.EndDirectives.Count > 0)
		{
			GenerateDirectives(e.EndDirectives);
		}
	}

	private void GenerateDirectionExpression(CodeDirectionExpression e)
	{
		OutputDirection(e.Direction);
		GenerateExpression(e.Expression);
	}

	private void GenerateDirectives(CodeDirectiveCollection directives)
	{
		for (int i = 0; i < directives.Count; i++)
		{
			CodeDirective codeDirective = directives[i];
			if (codeDirective is CodeChecksumPragma)
			{
				GenerateChecksumPragma((CodeChecksumPragma)codeDirective);
			}
			else if (codeDirective is CodeRegionDirective)
			{
				GenerateCodeRegionDirective((CodeRegionDirective)codeDirective);
			}
		}
	}

	private void GenerateChecksumPragma(CodeChecksumPragma checksumPragma)
	{
		Output.Write("#pragma checksum \"");
		Output.Write(checksumPragma.FileName);
		Output.Write("\" \"");
		Output.Write(checksumPragma.ChecksumAlgorithmId.ToString("B", CultureInfo.InvariantCulture));
		Output.Write("\" \"");
		if (checksumPragma.ChecksumData != null)
		{
			byte[] checksumData = checksumPragma.ChecksumData;
			foreach (byte b in checksumData)
			{
				Output.Write(b.ToString("X2", CultureInfo.InvariantCulture));
			}
		}
		Output.WriteLine("\"");
	}

	private void GenerateCodeRegionDirective(CodeRegionDirective regionDirective)
	{
		if (regionDirective.RegionMode == CodeRegionMode.Start)
		{
			Output.Write("#region ");
			Output.WriteLine(regionDirective.RegionText);
		}
		else if (regionDirective.RegionMode == CodeRegionMode.End)
		{
			Output.WriteLine("#endregion");
		}
	}

	private void GenerateNamespaceEnd(CodeNamespace e)
	{
		if (e.Name != null && e.Name.Length > 0)
		{
			Indent--;
			Output.WriteLine("}");
		}
	}

	private void GenerateNamespaceImport(CodeNamespaceImport e)
	{
		Output.Write("using ");
		OutputIdentifier(e.Namespace);
		Output.WriteLine(";");
	}

	private void GenerateAttributeDeclarationsStart(CodeAttributeDeclarationCollection attributes)
	{
		Output.Write("[");
	}

	private void GenerateAttributeDeclarationsEnd(CodeAttributeDeclarationCollection attributes)
	{
		Output.Write("]");
	}

	private void GenerateAttributes(CodeAttributeDeclarationCollection attributes)
	{
		GenerateAttributes(attributes, null, inLine: false);
	}

	private void GenerateAttributes(CodeAttributeDeclarationCollection attributes, string prefix)
	{
		GenerateAttributes(attributes, prefix, inLine: false);
	}

	private void GenerateAttributes(CodeAttributeDeclarationCollection attributes, string prefix, bool inLine)
	{
		if (attributes.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = attributes.GetEnumerator();
		bool flag = false;
		while (enumerator.MoveNext())
		{
			CodeAttributeDeclaration codeAttributeDeclaration = (CodeAttributeDeclaration)enumerator.Current;
			if (codeAttributeDeclaration.Name.Equals("system.paramarrayattribute", StringComparison.OrdinalIgnoreCase))
			{
				flag = true;
				continue;
			}
			GenerateAttributeDeclarationsStart(attributes);
			if (prefix != null)
			{
				Output.Write(prefix);
			}
			if (codeAttributeDeclaration.AttributeType != null)
			{
				Output.Write(GetTypeOutput(codeAttributeDeclaration.AttributeType));
			}
			Output.Write("(");
			bool flag2 = true;
			foreach (CodeAttributeArgument argument in codeAttributeDeclaration.Arguments)
			{
				if (flag2)
				{
					flag2 = false;
				}
				else
				{
					Output.Write(", ");
				}
				OutputAttributeArgument(argument);
			}
			Output.Write(")");
			GenerateAttributeDeclarationsEnd(attributes);
			if (inLine)
			{
				Output.Write(" ");
			}
			else
			{
				Output.WriteLine();
			}
		}
		if (flag)
		{
			if (prefix != null)
			{
				Output.Write(prefix);
			}
			Output.Write("params");
			if (inLine)
			{
				Output.Write(" ");
			}
			else
			{
				Output.WriteLine();
			}
		}
	}

	private static bool IsKeyword(string value)
	{
		return FixedStringLookup.Contains(keywords, value, ignoreCase: false);
	}

	private static bool IsPrefixTwoUnderscore(string value)
	{
		if (value.Length < 3)
		{
			return false;
		}
		if (value[0] == '_' && value[1] == '_')
		{
			return value[2] != '_';
		}
		return false;
	}

	public bool Supports(GeneratorSupport support)
	{
		return (support & (GeneratorSupport.ArraysOfArrays | GeneratorSupport.EntryPointMethod | GeneratorSupport.GotoStatements | GeneratorSupport.MultidimensionalArrays | GeneratorSupport.StaticConstructors | GeneratorSupport.TryCatchStatements | GeneratorSupport.ReturnTypeAttributes | GeneratorSupport.DeclareValueTypes | GeneratorSupport.DeclareEnums | GeneratorSupport.DeclareDelegates | GeneratorSupport.DeclareInterfaces | GeneratorSupport.DeclareEvents | GeneratorSupport.AssemblyAttributes | GeneratorSupport.ParameterAttributes | GeneratorSupport.ReferenceParameters | GeneratorSupport.ChainedConstructorArguments | GeneratorSupport.NestedTypes | GeneratorSupport.MultipleInterfaceMembers | GeneratorSupport.PublicStaticMembers | GeneratorSupport.ComplexExpressions | GeneratorSupport.Win32Resources | GeneratorSupport.Resources | GeneratorSupport.PartialTypes | GeneratorSupport.GenericTypeReference | GeneratorSupport.GenericTypeDeclaration | GeneratorSupport.DeclareIndexerProperties)) == support;
	}

	public bool IsValidIdentifier(string value)
	{
		if (value == null || value.Length == 0)
		{
			return false;
		}
		if (value.Length > 512)
		{
			return false;
		}
		if (value[0] != '@')
		{
			if (IsKeyword(value))
			{
				return false;
			}
		}
		else
		{
			value = value.Substring(1);
		}
		return CodeGenerator.IsValidLanguageIndependentIdentifier(value);
	}

	public void ValidateIdentifier(string value)
	{
		if (!IsValidIdentifier(value))
		{
			throw new ArgumentException(SR.GetString("InvalidIdentifier", value));
		}
	}

	public string CreateValidIdentifier(string name)
	{
		if (IsPrefixTwoUnderscore(name))
		{
			name = "_" + name;
		}
		while (IsKeyword(name))
		{
			name = "_" + name;
		}
		return name;
	}

	public string CreateEscapedIdentifier(string name)
	{
		if (IsKeyword(name) || IsPrefixTwoUnderscore(name))
		{
			return "@" + name;
		}
		return name;
	}

	private string GetBaseTypeOutput(CodeTypeReference typeRef)
	{
		string baseType = typeRef.BaseType;
		if (baseType.Length == 0)
		{
			return "void";
		}
		switch (baseType.ToLower(CultureInfo.InvariantCulture).Trim())
		{
		case "system.int16":
			return "short";
		case "system.int32":
			return "int";
		case "system.int64":
			return "long";
		case "system.string":
			return "string";
		case "system.object":
			return "object";
		case "system.boolean":
			return "bool";
		case "system.void":
			return "void";
		case "system.char":
			return "char";
		case "system.byte":
			return "byte";
		case "system.uint16":
			return "ushort";
		case "system.uint32":
			return "uint";
		case "system.uint64":
			return "ulong";
		case "system.sbyte":
			return "sbyte";
		case "system.single":
			return "float";
		case "system.double":
			return "double";
		case "system.decimal":
			return "decimal";
		default:
		{
			StringBuilder stringBuilder = new StringBuilder(baseType.Length + 10);
			if ((typeRef.Options & CodeTypeReferenceOptions.GlobalReference) != 0)
			{
				stringBuilder.Append("global::");
			}
			string baseType2 = typeRef.BaseType;
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < baseType2.Length; i++)
			{
				switch (baseType2[i])
				{
				case '+':
				case '.':
					stringBuilder.Append(CreateEscapedIdentifier(baseType2.Substring(num, i - num)));
					stringBuilder.Append('.');
					i++;
					num = i;
					break;
				case '`':
				{
					stringBuilder.Append(CreateEscapedIdentifier(baseType2.Substring(num, i - num)));
					i++;
					int num3 = 0;
					for (; i < baseType2.Length && baseType2[i] >= '0' && baseType2[i] <= '9'; i++)
					{
						num3 = num3 * 10 + (baseType2[i] - 48);
					}
					GetTypeArgumentsOutput(typeRef.TypeArguments, num2, num3, stringBuilder);
					num2 += num3;
					if (i < baseType2.Length && (baseType2[i] == '+' || baseType2[i] == '.'))
					{
						stringBuilder.Append('.');
						i++;
					}
					num = i;
					break;
				}
				}
			}
			if (num < baseType2.Length)
			{
				stringBuilder.Append(CreateEscapedIdentifier(baseType2.Substring(num)));
			}
			return stringBuilder.ToString();
		}
		}
	}

	private string GetTypeArgumentsOutput(CodeTypeReferenceCollection typeArguments)
	{
		StringBuilder stringBuilder = new StringBuilder(128);
		GetTypeArgumentsOutput(typeArguments, 0, typeArguments.Count, stringBuilder);
		return stringBuilder.ToString();
	}

	private void GetTypeArgumentsOutput(CodeTypeReferenceCollection typeArguments, int start, int length, StringBuilder sb)
	{
		sb.Append('<');
		bool flag = true;
		for (int i = start; i < start + length; i++)
		{
			if (flag)
			{
				flag = false;
			}
			else
			{
				sb.Append(", ");
			}
			if (i < typeArguments.Count)
			{
				sb.Append(GetTypeOutput(typeArguments[i]));
			}
		}
		sb.Append('>');
	}

	public string GetTypeOutput(CodeTypeReference typeRef)
	{
		string empty = string.Empty;
		CodeTypeReference codeTypeReference = typeRef;
		while (codeTypeReference.ArrayElementType != null)
		{
			codeTypeReference = codeTypeReference.ArrayElementType;
		}
		empty += GetBaseTypeOutput(codeTypeReference);
		while (typeRef != null && typeRef.ArrayRank > 0)
		{
			char[] array = new char[typeRef.ArrayRank + 1];
			array[0] = '[';
			array[typeRef.ArrayRank] = ']';
			for (int i = 1; i < typeRef.ArrayRank; i++)
			{
				array[i] = ',';
			}
			empty += new string(array);
			typeRef = typeRef.ArrayElementType;
		}
		return empty;
	}

	private void OutputStartingBrace()
	{
		if (Options.BracingStyle == "C")
		{
			Output.WriteLine("");
			Output.WriteLine("{");
		}
		else
		{
			Output.WriteLine(" {");
		}
	}

	private CompilerResults FromFileBatch(CompilerParameters options, string[] fileNames)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (fileNames == null)
		{
			throw new ArgumentNullException("fileNames");
		}
		new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
		string outputFile = null;
		int nativeReturnValue = 0;
		CompilerResults compilerResults = new CompilerResults(options.TempFiles);
		SecurityPermission securityPermission = new SecurityPermission(SecurityPermissionFlag.ControlEvidence);
		securityPermission.Assert();
		try
		{
			compilerResults.Evidence = options.Evidence;
		}
		finally
		{
			CodeAccessPermission.RevertAssert();
		}
		bool flag = false;
		if (options.OutputAssembly == null || options.OutputAssembly.Length == 0)
		{
			string fileExtension = (options.GenerateExecutable ? "exe" : "dll");
			options.OutputAssembly = compilerResults.TempFiles.AddExtension(fileExtension, !options.GenerateInMemory);
			new FileStream(options.OutputAssembly, FileMode.Create, FileAccess.ReadWrite).Close();
			flag = true;
		}
		string text = "pdb";
		if (options.CompilerOptions != null && -1 != CultureInfo.InvariantCulture.CompareInfo.IndexOf(options.CompilerOptions, "/debug:pdbonly", CompareOptions.IgnoreCase))
		{
			compilerResults.TempFiles.AddExtension(text, keepFile: true);
		}
		else
		{
			compilerResults.TempFiles.AddExtension(text);
		}
		string text2 = CmdArgsFromParameters(options) + " " + JoinStringArray(fileNames, " ");
		string responseFileCmdArgs = GetResponseFileCmdArgs(options, text2);
		string trueArgs = null;
		if (responseFileCmdArgs != null)
		{
			trueArgs = text2;
			text2 = responseFileCmdArgs;
		}
		Compile(options, RedistVersionInfo.GetCompilerPath(provOptions, CompilerName), CompilerName, text2, ref outputFile, ref nativeReturnValue, trueArgs);
		compilerResults.NativeCompilerReturnValue = nativeReturnValue;
		if (nativeReturnValue != 0 || options.WarningLevel > 0)
		{
			string[] array = ReadAllLines(outputFile, Encoding.UTF8, FileShare.ReadWrite);
			string[] array2 = array;
			foreach (string text3 in array2)
			{
				compilerResults.Output.Add(text3);
				ProcessCompilerOutputLine(compilerResults, text3);
			}
			if (nativeReturnValue != 0 && flag)
			{
				File.Delete(options.OutputAssembly);
			}
		}
		if (compilerResults.Errors.HasErrors || !options.GenerateInMemory)
		{
			compilerResults.PathToAssembly = options.OutputAssembly;
			return compilerResults;
		}
		byte[] array3;
		if (!FileIntegrity.IsEnabled)
		{
			array3 = File.ReadAllBytes(options.OutputAssembly);
		}
		else
		{
			using FileStream fileStream = new FileStream(options.OutputAssembly, FileMode.Open, FileAccess.Read, FileShare.Read);
			if (!FileIntegrity.IsTrusted(fileStream.SafeFileHandle))
			{
				throw new IOException(SR.GetString("FileIntegrityCheckFailed", options.OutputAssembly));
			}
			int num = (int)fileStream.Length;
			array3 = new byte[num];
			fileStream.Read(array3, 0, num);
		}
		byte[] rawSymbolStore = null;
		try
		{
			string path = options.TempFiles.BasePath + "." + text;
			if (File.Exists(path))
			{
				rawSymbolStore = File.ReadAllBytes(path);
			}
		}
		catch
		{
			rawSymbolStore = null;
		}
		SecurityPermission securityPermission2 = new SecurityPermission(SecurityPermissionFlag.ControlEvidence);
		securityPermission2.Assert();
		try
		{
			if (!FileIntegrity.IsEnabled)
			{
				compilerResults.CompiledAssembly = Assembly.Load(array3, rawSymbolStore, options.Evidence);
			}
			else
			{
				compilerResults.CompiledAssembly = CodeCompiler.LoadImageSkipIntegrityCheck(array3, rawSymbolStore, options.Evidence);
			}
		}
		finally
		{
			CodeAccessPermission.RevertAssert();
		}
		return compilerResults;
	}

	private static string[] ReadAllLines(string file, Encoding encoding, FileShare share)
	{
		using FileStream stream = File.Open(file, FileMode.Open, FileAccess.Read, share);
		List<string> list = new List<string>();
		using (StreamReader streamReader = new StreamReader(stream, encoding))
		{
			string item;
			while ((item = streamReader.ReadLine()) != null)
			{
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	CompilerResults ICodeCompiler.CompileAssemblyFromDom(CompilerParameters options, CodeCompileUnit e)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		try
		{
			return FromDom(options, e);
		}
		finally
		{
			options.TempFiles.SafeDelete();
		}
	}

	CompilerResults ICodeCompiler.CompileAssemblyFromFile(CompilerParameters options, string fileName)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		try
		{
			return FromFile(options, fileName);
		}
		finally
		{
			options.TempFiles.SafeDelete();
		}
	}

	CompilerResults ICodeCompiler.CompileAssemblyFromSource(CompilerParameters options, string source)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		try
		{
			return FromSource(options, source);
		}
		finally
		{
			options.TempFiles.SafeDelete();
		}
	}

	CompilerResults ICodeCompiler.CompileAssemblyFromSourceBatch(CompilerParameters options, string[] sources)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		try
		{
			return FromSourceBatch(options, sources);
		}
		finally
		{
			options.TempFiles.SafeDelete();
		}
	}

	CompilerResults ICodeCompiler.CompileAssemblyFromFileBatch(CompilerParameters options, string[] fileNames)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (fileNames == null)
		{
			throw new ArgumentNullException("fileNames");
		}
		try
		{
			foreach (string path in fileNames)
			{
				using (File.OpenRead(path))
				{
				}
			}
			return FromFileBatch(options, fileNames);
		}
		finally
		{
			options.TempFiles.SafeDelete();
		}
	}

	CompilerResults ICodeCompiler.CompileAssemblyFromDomBatch(CompilerParameters options, CodeCompileUnit[] ea)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		try
		{
			return FromDomBatch(options, ea);
		}
		finally
		{
			options.TempFiles.SafeDelete();
		}
	}

	internal void Compile(CompilerParameters options, string compilerDirectory, string compilerExe, string arguments, ref string outputFile, ref int nativeReturnValue, string trueArgs)
	{
		string errorName = null;
		outputFile = options.TempFiles.AddExtension("out");
		string text = Path.Combine(compilerDirectory, compilerExe);
		if (File.Exists(text))
		{
			string trueCmdLine = null;
			if (trueArgs != null)
			{
				trueCmdLine = "\"" + text + "\" " + trueArgs;
			}
			nativeReturnValue = Executor.ExecWaitWithCapture(options.SafeUserToken, "\"" + text + "\" " + arguments, Environment.CurrentDirectory, options.TempFiles, ref outputFile, ref errorName, trueCmdLine);
			return;
		}
		throw new InvalidOperationException(SR.GetString("CompilerNotFound", text));
	}

	private CompilerResults FromDom(CompilerParameters options, CodeCompileUnit e)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
		return FromDomBatch(options, new CodeCompileUnit[1] { e });
	}

	private CompilerResults FromFile(CompilerParameters options, string fileName)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
		using (File.OpenRead(fileName))
		{
		}
		return FromFileBatch(options, new string[1] { fileName });
	}

	private CompilerResults FromSource(CompilerParameters options, string source)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
		return FromSourceBatch(options, new string[1] { source });
	}

	private CompilerResults FromDomBatch(CompilerParameters options, CodeCompileUnit[] ea)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (ea == null)
		{
			throw new ArgumentNullException("ea");
		}
		new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
		string[] array = new string[ea.Length];
		CompilerResults compilerResults = null;
		try
		{
			WindowsImpersonationContext impersonation = Executor.RevertImpersonation();
			try
			{
				for (int i = 0; i < ea.Length; i++)
				{
					if (ea[i] == null)
					{
						continue;
					}
					ResolveReferencedAssemblies(options, ea[i]);
					array[i] = options.TempFiles.AddExtension(i + FileExtension);
					Stream stream = new FileStream(array[i], FileMode.Create, FileAccess.Write, FileShare.Read);
					try
					{
						using StreamWriter streamWriter = new StreamWriter(stream, Encoding.UTF8);
						((ICodeGenerator)this).GenerateCodeFromCompileUnit(ea[i], (TextWriter)streamWriter, Options);
						streamWriter.Flush();
					}
					finally
					{
						stream.Close();
					}
				}
				return FromFileBatch(options, array);
			}
			finally
			{
				Executor.ReImpersonate(impersonation);
			}
		}
		catch
		{
			throw;
		}
	}

	private void ResolveReferencedAssemblies(CompilerParameters options, CodeCompileUnit e)
	{
		if (e.ReferencedAssemblies.Count <= 0)
		{
			return;
		}
		StringEnumerator enumerator = e.ReferencedAssemblies.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				if (!options.ReferencedAssemblies.Contains(current))
				{
					options.ReferencedAssemblies.Add(current);
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
	}

	private CompilerResults FromSourceBatch(CompilerParameters options, string[] sources)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (sources == null)
		{
			throw new ArgumentNullException("sources");
		}
		new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
		string[] array = new string[sources.Length];
		FileStream[] array2 = new FileStream[sources.Length];
		CompilerResults compilerResults = null;
		try
		{
			WindowsImpersonationContext impersonation = Executor.RevertImpersonation();
			try
			{
				try
				{
					bool isEnabled = FileIntegrity.IsEnabled;
					for (int i = 0; i < sources.Length; i++)
					{
						string text = options.TempFiles.AddExtension(i + FileExtension);
						FileStream fileStream = (array2[i] = new FileStream(text, FileMode.Create, FileAccess.ReadWrite, FileShare.Read));
						using (StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8))
						{
							streamWriter.Write(sources[i]);
							streamWriter.Flush();
							if (isEnabled)
							{
								FileIntegrity.MarkAsTrusted(fileStream.SafeFileHandle);
							}
						}
						array[i] = text;
					}
					return FromFileBatch(options, array);
				}
				finally
				{
					for (int j = 0; j < array2.Length && array2[j] != null; j++)
					{
						array2[j].Close();
					}
				}
			}
			finally
			{
				Executor.ReImpersonate(impersonation);
			}
		}
		catch
		{
			throw;
		}
	}

	private static string JoinStringArray(string[] sa, string separator)
	{
		if (sa == null || sa.Length == 0)
		{
			return string.Empty;
		}
		if (sa.Length == 1)
		{
			return "\"" + sa[0] + "\"";
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < sa.Length - 1; i++)
		{
			stringBuilder.Append("\"");
			stringBuilder.Append(sa[i]);
			stringBuilder.Append("\"");
			stringBuilder.Append(separator);
		}
		stringBuilder.Append("\"");
		stringBuilder.Append(sa[sa.Length - 1]);
		stringBuilder.Append("\"");
		return stringBuilder.ToString();
	}

	void ICodeGenerator.GenerateCodeFromType(CodeTypeDeclaration e, TextWriter w, CodeGeneratorOptions o)
	{
		bool flag = false;
		if (output != null && w != output.InnerWriter)
		{
			throw new InvalidOperationException(SR.GetString("CodeGenOutputWriter"));
		}
		if (output == null)
		{
			flag = true;
			options = ((o == null) ? new CodeGeneratorOptions() : o);
			output = new IndentedTextWriter(w, options.IndentString);
		}
		try
		{
			GenerateType(e);
		}
		finally
		{
			if (flag)
			{
				output = null;
				options = null;
			}
		}
	}

	void ICodeGenerator.GenerateCodeFromExpression(CodeExpression e, TextWriter w, CodeGeneratorOptions o)
	{
		bool flag = false;
		if (output != null && w != output.InnerWriter)
		{
			throw new InvalidOperationException(SR.GetString("CodeGenOutputWriter"));
		}
		if (output == null)
		{
			flag = true;
			options = ((o == null) ? new CodeGeneratorOptions() : o);
			output = new IndentedTextWriter(w, options.IndentString);
		}
		try
		{
			GenerateExpression(e);
		}
		finally
		{
			if (flag)
			{
				output = null;
				options = null;
			}
		}
	}

	void ICodeGenerator.GenerateCodeFromCompileUnit(CodeCompileUnit e, TextWriter w, CodeGeneratorOptions o)
	{
		bool flag = false;
		if (output != null && w != output.InnerWriter)
		{
			throw new InvalidOperationException(SR.GetString("CodeGenOutputWriter"));
		}
		if (output == null)
		{
			flag = true;
			options = ((o == null) ? new CodeGeneratorOptions() : o);
			output = new IndentedTextWriter(w, options.IndentString);
		}
		try
		{
			if (e is CodeSnippetCompileUnit)
			{
				GenerateSnippetCompileUnit((CodeSnippetCompileUnit)e);
			}
			else
			{
				GenerateCompileUnit(e);
			}
		}
		finally
		{
			if (flag)
			{
				output = null;
				options = null;
			}
		}
	}

	void ICodeGenerator.GenerateCodeFromNamespace(CodeNamespace e, TextWriter w, CodeGeneratorOptions o)
	{
		bool flag = false;
		if (output != null && w != output.InnerWriter)
		{
			throw new InvalidOperationException(SR.GetString("CodeGenOutputWriter"));
		}
		if (output == null)
		{
			flag = true;
			options = ((o == null) ? new CodeGeneratorOptions() : o);
			output = new IndentedTextWriter(w, options.IndentString);
		}
		try
		{
			GenerateNamespace(e);
		}
		finally
		{
			if (flag)
			{
				output = null;
				options = null;
			}
		}
	}

	void ICodeGenerator.GenerateCodeFromStatement(CodeStatement e, TextWriter w, CodeGeneratorOptions o)
	{
		bool flag = false;
		if (output != null && w != output.InnerWriter)
		{
			throw new InvalidOperationException(SR.GetString("CodeGenOutputWriter"));
		}
		if (output == null)
		{
			flag = true;
			options = ((o == null) ? new CodeGeneratorOptions() : o);
			output = new IndentedTextWriter(w, options.IndentString);
		}
		try
		{
			GenerateStatement(e);
		}
		finally
		{
			if (flag)
			{
				output = null;
				options = null;
			}
		}
	}
}
