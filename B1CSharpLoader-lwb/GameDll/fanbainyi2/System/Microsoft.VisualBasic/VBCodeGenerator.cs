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
using System.Text;
using System.Text.RegularExpressions;

namespace Microsoft.VisualBasic;

internal class VBCodeGenerator : CodeCompiler
{
	private const int MaxLineLength = 80;

	private const GeneratorSupport LanguageSupport = GeneratorSupport.ArraysOfArrays | GeneratorSupport.EntryPointMethod | GeneratorSupport.GotoStatements | GeneratorSupport.MultidimensionalArrays | GeneratorSupport.StaticConstructors | GeneratorSupport.TryCatchStatements | GeneratorSupport.ReturnTypeAttributes | GeneratorSupport.DeclareValueTypes | GeneratorSupport.DeclareEnums | GeneratorSupport.DeclareDelegates | GeneratorSupport.DeclareInterfaces | GeneratorSupport.DeclareEvents | GeneratorSupport.AssemblyAttributes | GeneratorSupport.ParameterAttributes | GeneratorSupport.ReferenceParameters | GeneratorSupport.ChainedConstructorArguments | GeneratorSupport.NestedTypes | GeneratorSupport.MultipleInterfaceMembers | GeneratorSupport.PublicStaticMembers | GeneratorSupport.ComplexExpressions | GeneratorSupport.Win32Resources | GeneratorSupport.Resources | GeneratorSupport.PartialTypes | GeneratorSupport.GenericTypeReference | GeneratorSupport.GenericTypeDeclaration | GeneratorSupport.DeclareIndexerProperties;

	private static volatile Regex outputReg;

	private int statementDepth;

	private IDictionary<string, string> provOptions;

	private static readonly string[][] keywords = new string[16][]
	{
		null,
		new string[10] { "as", "do", "if", "in", "is", "me", "of", "on", "or", "to" },
		new string[15]
		{
			"and", "dim", "end", "for", "get", "let", "lib", "mod", "new", "not",
			"rem", "set", "sub", "try", "xor"
		},
		new string[30]
		{
			"ansi", "auto", "byte", "call", "case", "cdbl", "cdec", "char", "cint", "clng",
			"cobj", "csng", "cstr", "date", "each", "else", "enum", "exit", "goto", "like",
			"long", "loop", "next", "step", "stop", "then", "true", "wend", "when", "with"
		},
		new string[28]
		{
			"alias", "byref", "byval", "catch", "cbool", "cbyte", "cchar", "cdate", "class", "const",
			"ctype", "cuint", "culng", "endif", "erase", "error", "event", "false", "gosub", "isnot",
			"redim", "sbyte", "short", "throw", "ulong", "until", "using", "while"
		},
		new string[21]
		{
			"csbyte", "cshort", "double", "elseif", "friend", "global", "module", "mybase", "object", "option",
			"orelse", "public", "resume", "return", "select", "shared", "single", "static", "string", "typeof",
			"ushort"
		},
		new string[19]
		{
			"andalso", "boolean", "cushort", "decimal", "declare", "default", "finally", "gettype", "handles", "imports",
			"integer", "myclass", "nothing", "partial", "private", "shadows", "trycast", "unicode", "variant"
		},
		new string[13]
		{
			"assembly", "continue", "delegate", "function", "inherits", "operator", "optional", "preserve", "property", "readonly",
			"synclock", "uinteger", "widening"
		},
		new string[9] { "addressof", "interface", "namespace", "narrowing", "overloads", "overrides", "protected", "structure", "writeonly" },
		new string[6] { "addhandler", "directcast", "implements", "paramarray", "raiseevent", "withevents" },
		new string[2] { "mustinherit", "overridable" },
		new string[1] { "mustoverride" },
		new string[1] { "removehandler" },
		new string[3] { "class_finalize", "notinheritable", "notoverridable" },
		null,
		new string[1] { "class_initialize" }
	};

	protected override string FileExtension => ".vb";

	protected override string CompilerName => "vbc.exe";

	private bool IsCurrentModule
	{
		get
		{
			if (base.IsCurrentClass)
			{
				return GetUserData(base.CurrentClass, "Module", defaultValue: false);
			}
			return false;
		}
	}

	protected override string NullToken => "Nothing";

	internal VBCodeGenerator()
	{
	}

	internal VBCodeGenerator(IDictionary<string, string> providerOptions)
	{
		provOptions = providerOptions;
	}

	private void EnsureInDoubleQuotes(ref bool fInDoubleQuotes, StringBuilder b)
	{
		if (!fInDoubleQuotes)
		{
			b.Append("&\"");
			fInDoubleQuotes = true;
		}
	}

	private void EnsureNotInDoubleQuotes(ref bool fInDoubleQuotes, StringBuilder b)
	{
		if (fInDoubleQuotes)
		{
			b.Append("\"");
			fInDoubleQuotes = false;
		}
	}

	protected override string QuoteSnippetString(string value)
	{
		StringBuilder stringBuilder = new StringBuilder(value.Length + 5);
		bool fInDoubleQuotes = true;
		Indentation indentation = new Indentation((IndentedTextWriter)base.Output, base.Indent + 1);
		stringBuilder.Append("\"");
		for (int i = 0; i < value.Length; i++)
		{
			char c = value[i];
			switch (c)
			{
			case '"':
			case '“':
			case '”':
			case '＂':
				EnsureInDoubleQuotes(ref fInDoubleQuotes, stringBuilder);
				stringBuilder.Append(c);
				stringBuilder.Append(c);
				break;
			case '\r':
				EnsureNotInDoubleQuotes(ref fInDoubleQuotes, stringBuilder);
				if (i < value.Length - 1 && value[i + 1] == '\n')
				{
					stringBuilder.Append("&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)");
					i++;
				}
				else
				{
					stringBuilder.Append("&Global.Microsoft.VisualBasic.ChrW(13)");
				}
				break;
			case '\t':
				EnsureNotInDoubleQuotes(ref fInDoubleQuotes, stringBuilder);
				stringBuilder.Append("&Global.Microsoft.VisualBasic.ChrW(9)");
				break;
			case '\0':
				EnsureNotInDoubleQuotes(ref fInDoubleQuotes, stringBuilder);
				stringBuilder.Append("&Global.Microsoft.VisualBasic.ChrW(0)");
				break;
			case '\n':
				EnsureNotInDoubleQuotes(ref fInDoubleQuotes, stringBuilder);
				stringBuilder.Append("&Global.Microsoft.VisualBasic.ChrW(10)");
				break;
			case '\u2028':
			case '\u2029':
				EnsureNotInDoubleQuotes(ref fInDoubleQuotes, stringBuilder);
				AppendEscapedChar(stringBuilder, c);
				break;
			default:
				EnsureInDoubleQuotes(ref fInDoubleQuotes, stringBuilder);
				stringBuilder.Append(value[i]);
				break;
			}
			if (i > 0 && i % 80 == 0)
			{
				if (char.IsHighSurrogate(value[i]) && i < value.Length - 1 && char.IsLowSurrogate(value[i + 1]))
				{
					stringBuilder.Append(value[++i]);
				}
				if (fInDoubleQuotes)
				{
					stringBuilder.Append("\"");
				}
				fInDoubleQuotes = true;
				stringBuilder.Append("& _ ");
				stringBuilder.Append(Environment.NewLine);
				stringBuilder.Append(indentation.IndentationString);
				stringBuilder.Append('"');
			}
		}
		if (fInDoubleQuotes)
		{
			stringBuilder.Append("\"");
		}
		return stringBuilder.ToString();
	}

	private static void AppendEscapedChar(StringBuilder b, char value)
	{
		b.Append("&Global.Microsoft.VisualBasic.ChrW(");
		int num = value;
		b.Append(num.ToString(CultureInfo.InvariantCulture));
		b.Append(")");
	}

	protected override void ProcessCompilerOutputLine(CompilerResults results, string line)
	{
		if (outputReg == null)
		{
			outputReg = new Regex("^([^(]*)\\(?([0-9]*)\\)? ?:? ?(error|warning) ([A-Z]+[0-9]+) ?: ((.|\\n)*)");
		}
		Match match = outputReg.Match(line);
		if (match.Success)
		{
			CompilerError compilerError = new CompilerError();
			compilerError.FileName = match.Groups[1].Value;
			string value = match.Groups[2].Value;
			if (value != null && value.Length > 0)
			{
				compilerError.Line = int.Parse(value, CultureInfo.InvariantCulture);
			}
			if (string.Compare(match.Groups[3].Value, "warning", StringComparison.OrdinalIgnoreCase) == 0)
			{
				compilerError.IsWarning = true;
			}
			compilerError.ErrorNumber = match.Groups[4].Value;
			compilerError.ErrorText = match.Groups[5].Value;
			results.Errors.Add(compilerError);
		}
	}

	protected override string CmdArgsFromParameters(CompilerParameters options)
	{
		StringEnumerator enumerator = options.ReferencedAssemblies.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				if (string.IsNullOrEmpty(current))
				{
					throw new ArgumentException(SR.GetString("NullOrEmpty_Value_in_Property", "ReferencedAssemblies"), "options");
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
		string text = options.CoreAssemblyFileName;
		if (string.IsNullOrWhiteSpace(options.CoreAssemblyFileName) && CodeDomProvider.TryGetProbableCoreAssemblyFilePath(options, out var coreAssemblyFilePath))
		{
			text = coreAssemblyFilePath;
		}
		if (!string.IsNullOrWhiteSpace(text))
		{
			string text2 = text.Trim();
			string directoryName = Path.GetDirectoryName(text2);
			stringBuilder.Append("/nostdlib ");
			stringBuilder.Append("/sdkpath:\"").Append(directoryName).Append("\" ");
			stringBuilder.Append("/R:\"").Append(text2).Append("\" ");
		}
		StringEnumerator enumerator2 = options.ReferencedAssemblies.GetEnumerator();
		try
		{
			while (enumerator2.MoveNext())
			{
				string current2 = enumerator2.Current;
				string fileName = Path.GetFileName(current2);
				if (string.Compare(fileName, "Microsoft.VisualBasic.dll", StringComparison.OrdinalIgnoreCase) != 0 && string.Compare(fileName, "mscorlib.dll", StringComparison.OrdinalIgnoreCase) != 0)
				{
					stringBuilder.Append("/R:");
					stringBuilder.Append("\"");
					stringBuilder.Append(current2);
					stringBuilder.Append("\"");
					stringBuilder.Append(" ");
				}
			}
		}
		finally
		{
			if (enumerator2 is IDisposable disposable2)
			{
				disposable2.Dispose();
			}
		}
		stringBuilder.Append("/out:");
		stringBuilder.Append("\"");
		stringBuilder.Append(options.OutputAssembly);
		stringBuilder.Append("\"");
		stringBuilder.Append(" ");
		if (options.IncludeDebugInformation)
		{
			stringBuilder.Append("/D:DEBUG=1 ");
			stringBuilder.Append("/debug+ ");
		}
		else
		{
			stringBuilder.Append("/debug- ");
		}
		if (options.Win32Resource != null)
		{
			stringBuilder.Append("/win32resource:\"" + options.Win32Resource + "\" ");
		}
		StringEnumerator enumerator3 = options.EmbeddedResources.GetEnumerator();
		try
		{
			while (enumerator3.MoveNext())
			{
				string current3 = enumerator3.Current;
				stringBuilder.Append("/res:\"");
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
		StringEnumerator enumerator4 = options.LinkedResources.GetEnumerator();
		try
		{
			while (enumerator4.MoveNext())
			{
				string current4 = enumerator4.Current;
				stringBuilder.Append("/linkres:\"");
				stringBuilder.Append(current4);
				stringBuilder.Append("\" ");
			}
		}
		finally
		{
			if (enumerator4 is IDisposable disposable4)
			{
				disposable4.Dispose();
			}
		}
		if (options.TreatWarningsAsErrors)
		{
			stringBuilder.Append("/warnaserror+ ");
		}
		if (options.CompilerOptions != null)
		{
			stringBuilder.Append(options.CompilerOptions + " ");
		}
		return stringBuilder.ToString();
	}

	protected override void OutputAttributeArgument(CodeAttributeArgument arg)
	{
		if (arg.Name != null && arg.Name.Length > 0)
		{
			OutputIdentifier(arg.Name);
			base.Output.Write(":=");
		}
		((ICodeGenerator)this).GenerateCodeFromExpression(arg.Value, ((IndentedTextWriter)base.Output).InnerWriter, base.Options);
	}

	private void OutputAttributes(CodeAttributeDeclarationCollection attributes, bool inLine)
	{
		OutputAttributes(attributes, inLine, null, closingLine: false);
	}

	private void OutputAttributes(CodeAttributeDeclarationCollection attributes, bool inLine, string prefix, bool closingLine)
	{
		if (attributes.Count == 0)
		{
			return;
		}
		IEnumerator enumerator = attributes.GetEnumerator();
		bool flag = true;
		GenerateAttributeDeclarationsStart(attributes);
		while (enumerator.MoveNext())
		{
			if (flag)
			{
				flag = false;
			}
			else
			{
				base.Output.Write(", ");
				if (!inLine)
				{
					ContinueOnNewLine("");
					base.Output.Write(" ");
				}
			}
			if (prefix != null && prefix.Length > 0)
			{
				base.Output.Write(prefix);
			}
			CodeAttributeDeclaration codeAttributeDeclaration = (CodeAttributeDeclaration)enumerator.Current;
			if (codeAttributeDeclaration.AttributeType != null)
			{
				base.Output.Write(GetTypeOutput(codeAttributeDeclaration.AttributeType));
			}
			base.Output.Write("(");
			bool flag2 = true;
			foreach (CodeAttributeArgument argument in codeAttributeDeclaration.Arguments)
			{
				if (flag2)
				{
					flag2 = false;
				}
				else
				{
					base.Output.Write(", ");
				}
				OutputAttributeArgument(argument);
			}
			base.Output.Write(")");
		}
		GenerateAttributeDeclarationsEnd(attributes);
		base.Output.Write(" ");
		if (!inLine)
		{
			if (closingLine)
			{
				base.Output.WriteLine();
			}
			else
			{
				ContinueOnNewLine("");
			}
		}
	}

	protected override void OutputDirection(FieldDirection dir)
	{
		switch (dir)
		{
		case FieldDirection.In:
			base.Output.Write("ByVal ");
			break;
		case FieldDirection.Out:
		case FieldDirection.Ref:
			base.Output.Write("ByRef ");
			break;
		}
	}

	protected override void GenerateDefaultValueExpression(CodeDefaultValueExpression e)
	{
		base.Output.Write("CType(Nothing, " + GetTypeOutput(e.Type) + ")");
	}

	protected override void GenerateDirectionExpression(CodeDirectionExpression e)
	{
		GenerateExpression(e.Expression);
	}

	protected override void OutputFieldScopeModifier(MemberAttributes attributes)
	{
		switch (attributes & MemberAttributes.ScopeMask)
		{
		case MemberAttributes.Final:
			base.Output.Write("");
			break;
		case MemberAttributes.Static:
			if (!IsCurrentModule)
			{
				base.Output.Write("Shared ");
			}
			break;
		case MemberAttributes.Const:
			base.Output.Write("Const ");
			break;
		default:
			base.Output.Write("");
			break;
		}
	}

	protected override void OutputMemberAccessModifier(MemberAttributes attributes)
	{
		switch (attributes & MemberAttributes.AccessMask)
		{
		case MemberAttributes.Assembly:
			base.Output.Write("Friend ");
			break;
		case MemberAttributes.FamilyAndAssembly:
			base.Output.Write("Friend ");
			break;
		case MemberAttributes.Family:
			base.Output.Write("Protected ");
			break;
		case MemberAttributes.FamilyOrAssembly:
			base.Output.Write("Protected Friend ");
			break;
		case MemberAttributes.Private:
			base.Output.Write("Private ");
			break;
		case MemberAttributes.Public:
			base.Output.Write("Public ");
			break;
		}
	}

	private void OutputVTableModifier(MemberAttributes attributes)
	{
		MemberAttributes memberAttributes = attributes & MemberAttributes.VTableMask;
		if (memberAttributes == MemberAttributes.New)
		{
			base.Output.Write("Shadows ");
		}
	}

	protected override void OutputMemberScopeModifier(MemberAttributes attributes)
	{
		switch (attributes & MemberAttributes.ScopeMask)
		{
		case MemberAttributes.Abstract:
			base.Output.Write("MustOverride ");
			return;
		case MemberAttributes.Final:
			base.Output.Write("");
			return;
		case MemberAttributes.Static:
			if (!IsCurrentModule)
			{
				base.Output.Write("Shared ");
			}
			return;
		case MemberAttributes.Override:
			base.Output.Write("Overrides ");
			return;
		case MemberAttributes.Private:
			base.Output.Write("Private ");
			return;
		}
		MemberAttributes memberAttributes = attributes & MemberAttributes.AccessMask;
		if (memberAttributes == MemberAttributes.Assembly || memberAttributes == MemberAttributes.Family || memberAttributes == MemberAttributes.Public)
		{
			base.Output.Write("Overridable ");
		}
	}

	protected override void OutputOperator(CodeBinaryOperatorType op)
	{
		switch (op)
		{
		case CodeBinaryOperatorType.IdentityInequality:
			base.Output.Write("<>");
			break;
		case CodeBinaryOperatorType.IdentityEquality:
			base.Output.Write("Is");
			break;
		case CodeBinaryOperatorType.BooleanOr:
			base.Output.Write("OrElse");
			break;
		case CodeBinaryOperatorType.BooleanAnd:
			base.Output.Write("AndAlso");
			break;
		case CodeBinaryOperatorType.ValueEquality:
			base.Output.Write("=");
			break;
		case CodeBinaryOperatorType.Modulus:
			base.Output.Write("Mod");
			break;
		case CodeBinaryOperatorType.BitwiseOr:
			base.Output.Write("Or");
			break;
		case CodeBinaryOperatorType.BitwiseAnd:
			base.Output.Write("And");
			break;
		default:
			base.OutputOperator(op);
			break;
		}
	}

	private void GenerateNotIsNullExpression(CodeExpression e)
	{
		base.Output.Write("(Not (");
		GenerateExpression(e);
		base.Output.Write(") Is ");
		base.Output.Write(NullToken);
		base.Output.Write(")");
	}

	protected override void GenerateBinaryOperatorExpression(CodeBinaryOperatorExpression e)
	{
		if (e.Operator != CodeBinaryOperatorType.IdentityInequality)
		{
			base.GenerateBinaryOperatorExpression(e);
		}
		else if (e.Right is CodePrimitiveExpression && ((CodePrimitiveExpression)e.Right).Value == null)
		{
			GenerateNotIsNullExpression(e.Left);
		}
		else if (e.Left is CodePrimitiveExpression && ((CodePrimitiveExpression)e.Left).Value == null)
		{
			GenerateNotIsNullExpression(e.Right);
		}
		else
		{
			base.GenerateBinaryOperatorExpression(e);
		}
	}

	protected override string GetResponseFileCmdArgs(CompilerParameters options, string cmdArgs)
	{
		return "/noconfig " + base.GetResponseFileCmdArgs(options, cmdArgs);
	}

	protected override void OutputIdentifier(string ident)
	{
		base.Output.Write(CreateEscapedIdentifier(ident));
	}

	protected override void OutputType(CodeTypeReference typeRef)
	{
		base.Output.Write(GetTypeOutputWithoutArrayPostFix(typeRef));
	}

	private void OutputTypeAttributes(CodeTypeDeclaration e)
	{
		if ((e.Attributes & MemberAttributes.New) != 0)
		{
			base.Output.Write("Shadows ");
		}
		TypeAttributes typeAttributes = e.TypeAttributes;
		if (e.IsPartial)
		{
			base.Output.Write("Partial ");
		}
		switch (typeAttributes & TypeAttributes.VisibilityMask)
		{
		case TypeAttributes.Public:
		case TypeAttributes.NestedPublic:
			base.Output.Write("Public ");
			break;
		case TypeAttributes.NestedPrivate:
			base.Output.Write("Private ");
			break;
		case TypeAttributes.NestedFamily:
			base.Output.Write("Protected ");
			break;
		case TypeAttributes.NotPublic:
		case TypeAttributes.NestedAssembly:
		case TypeAttributes.NestedFamANDAssem:
			base.Output.Write("Friend ");
			break;
		case TypeAttributes.VisibilityMask:
			base.Output.Write("Protected Friend ");
			break;
		}
		if (e.IsStruct)
		{
			base.Output.Write("Structure ");
			return;
		}
		if (e.IsEnum)
		{
			base.Output.Write("Enum ");
			return;
		}
		switch (typeAttributes & TypeAttributes.ClassSemanticsMask)
		{
		case TypeAttributes.NotPublic:
			if (IsCurrentModule)
			{
				base.Output.Write("Module ");
				break;
			}
			if ((typeAttributes & TypeAttributes.Sealed) == TypeAttributes.Sealed)
			{
				base.Output.Write("NotInheritable ");
			}
			if ((typeAttributes & TypeAttributes.Abstract) == TypeAttributes.Abstract)
			{
				base.Output.Write("MustInherit ");
			}
			base.Output.Write("Class ");
			break;
		case TypeAttributes.ClassSemanticsMask:
			base.Output.Write("Interface ");
			break;
		}
	}

	protected override void OutputTypeNamePair(CodeTypeReference typeRef, string name)
	{
		if (string.IsNullOrEmpty(name))
		{
			name = "__exception";
		}
		OutputIdentifier(name);
		OutputArrayPostfix(typeRef);
		base.Output.Write(" As ");
		OutputType(typeRef);
	}

	private string GetArrayPostfix(CodeTypeReference typeRef)
	{
		string text = "";
		if (typeRef.ArrayElementType != null)
		{
			text = GetArrayPostfix(typeRef.ArrayElementType);
		}
		if (typeRef.ArrayRank > 0)
		{
			char[] array = new char[typeRef.ArrayRank + 1];
			array[0] = '(';
			array[typeRef.ArrayRank] = ')';
			for (int i = 1; i < typeRef.ArrayRank; i++)
			{
				array[i] = ',';
			}
			text = new string(array) + text;
		}
		return text;
	}

	private void OutputArrayPostfix(CodeTypeReference typeRef)
	{
		if (typeRef.ArrayRank > 0)
		{
			base.Output.Write(GetArrayPostfix(typeRef));
		}
	}

	protected override void GenerateIterationStatement(CodeIterationStatement e)
	{
		GenerateStatement(e.InitStatement);
		base.Output.Write("Do While ");
		GenerateExpression(e.TestExpression);
		base.Output.WriteLine("");
		base.Indent++;
		GenerateVBStatements(e.Statements);
		GenerateStatement(e.IncrementStatement);
		base.Indent--;
		base.Output.WriteLine("Loop");
	}

	protected override void GeneratePrimitiveExpression(CodePrimitiveExpression e)
	{
		if (e.Value is char)
		{
			base.Output.Write("Global.Microsoft.VisualBasic.ChrW(" + ((IConvertible)e.Value).ToInt32(CultureInfo.InvariantCulture).ToString(CultureInfo.InvariantCulture) + ")");
		}
		else if (e.Value is sbyte)
		{
			base.Output.Write("CSByte(");
			base.Output.Write(((sbyte)e.Value).ToString(CultureInfo.InvariantCulture));
			base.Output.Write(")");
		}
		else if (e.Value is ushort)
		{
			base.Output.Write(((ushort)e.Value).ToString(CultureInfo.InvariantCulture));
			base.Output.Write("US");
		}
		else if (e.Value is uint)
		{
			base.Output.Write(((uint)e.Value).ToString(CultureInfo.InvariantCulture));
			base.Output.Write("UI");
		}
		else if (e.Value is ulong)
		{
			base.Output.Write(((ulong)e.Value).ToString(CultureInfo.InvariantCulture));
			base.Output.Write("UL");
		}
		else
		{
			base.GeneratePrimitiveExpression(e);
		}
	}

	protected override void GenerateThrowExceptionStatement(CodeThrowExceptionStatement e)
	{
		base.Output.Write("Throw");
		if (e.ToThrow != null)
		{
			base.Output.Write(" ");
			GenerateExpression(e.ToThrow);
		}
		base.Output.WriteLine("");
	}

	protected override void GenerateArrayCreateExpression(CodeArrayCreateExpression e)
	{
		base.Output.Write("New ");
		CodeExpressionCollection initializers = e.Initializers;
		if (initializers.Count > 0)
		{
			string typeOutput = GetTypeOutput(e.CreateType);
			base.Output.Write(typeOutput);
			if (typeOutput.IndexOf('(') == -1)
			{
				base.Output.Write("()");
			}
			base.Output.Write(" {");
			base.Indent++;
			OutputExpressionList(initializers);
			base.Indent--;
			base.Output.Write("}");
			return;
		}
		string typeOutput2 = GetTypeOutput(e.CreateType);
		int num = typeOutput2.IndexOf('(');
		if (num == -1)
		{
			base.Output.Write(typeOutput2);
			base.Output.Write('(');
		}
		else
		{
			base.Output.Write(typeOutput2.Substring(0, num + 1));
		}
		if (e.SizeExpression != null)
		{
			base.Output.Write("(");
			GenerateExpression(e.SizeExpression);
			base.Output.Write(") - 1");
		}
		else
		{
			base.Output.Write(e.Size - 1);
		}
		if (num == -1)
		{
			base.Output.Write(')');
		}
		else
		{
			base.Output.Write(typeOutput2.Substring(num + 1));
		}
		base.Output.Write(" {}");
	}

	protected override void GenerateBaseReferenceExpression(CodeBaseReferenceExpression e)
	{
		base.Output.Write("MyBase");
	}

	protected override void GenerateCastExpression(CodeCastExpression e)
	{
		base.Output.Write("CType(");
		GenerateExpression(e.Expression);
		base.Output.Write(",");
		OutputType(e.TargetType);
		OutputArrayPostfix(e.TargetType);
		base.Output.Write(")");
	}

	protected override void GenerateDelegateCreateExpression(CodeDelegateCreateExpression e)
	{
		base.Output.Write("AddressOf ");
		GenerateExpression(e.TargetObject);
		base.Output.Write(".");
		OutputIdentifier(e.MethodName);
	}

	protected override void GenerateFieldReferenceExpression(CodeFieldReferenceExpression e)
	{
		if (e.TargetObject != null)
		{
			GenerateExpression(e.TargetObject);
			base.Output.Write(".");
		}
		OutputIdentifier(e.FieldName);
	}

	protected override void GenerateSingleFloatValue(float s)
	{
		if (float.IsNaN(s))
		{
			base.Output.Write("Single.NaN");
			return;
		}
		if (float.IsNegativeInfinity(s))
		{
			base.Output.Write("Single.NegativeInfinity");
			return;
		}
		if (float.IsPositiveInfinity(s))
		{
			base.Output.Write("Single.PositiveInfinity");
			return;
		}
		base.Output.Write(s.ToString(CultureInfo.InvariantCulture));
		base.Output.Write('!');
	}

	protected override void GenerateDoubleValue(double d)
	{
		if (double.IsNaN(d))
		{
			base.Output.Write("Double.NaN");
			return;
		}
		if (double.IsNegativeInfinity(d))
		{
			base.Output.Write("Double.NegativeInfinity");
			return;
		}
		if (double.IsPositiveInfinity(d))
		{
			base.Output.Write("Double.PositiveInfinity");
			return;
		}
		base.Output.Write(d.ToString("R", CultureInfo.InvariantCulture));
		base.Output.Write("R");
	}

	protected override void GenerateDecimalValue(decimal d)
	{
		base.Output.Write(d.ToString(CultureInfo.InvariantCulture));
		base.Output.Write('D');
	}

	protected override void GenerateArgumentReferenceExpression(CodeArgumentReferenceExpression e)
	{
		OutputIdentifier(e.ParameterName);
	}

	protected override void GenerateVariableReferenceExpression(CodeVariableReferenceExpression e)
	{
		OutputIdentifier(e.VariableName);
	}

	protected override void GenerateIndexerExpression(CodeIndexerExpression e)
	{
		GenerateExpression(e.TargetObject);
		if (e.TargetObject is CodeBaseReferenceExpression)
		{
			base.Output.Write(".Item");
		}
		base.Output.Write("(");
		bool flag = true;
		foreach (CodeExpression index in e.Indices)
		{
			if (flag)
			{
				flag = false;
			}
			else
			{
				base.Output.Write(", ");
			}
			GenerateExpression(index);
		}
		base.Output.Write(")");
	}

	protected override void GenerateArrayIndexerExpression(CodeArrayIndexerExpression e)
	{
		GenerateExpression(e.TargetObject);
		base.Output.Write("(");
		bool flag = true;
		foreach (CodeExpression index in e.Indices)
		{
			if (flag)
			{
				flag = false;
			}
			else
			{
				base.Output.Write(", ");
			}
			GenerateExpression(index);
		}
		base.Output.Write(")");
	}

	protected override void GenerateSnippetExpression(CodeSnippetExpression e)
	{
		base.Output.Write(e.Value);
	}

	protected override void GenerateMethodInvokeExpression(CodeMethodInvokeExpression e)
	{
		GenerateMethodReferenceExpression(e.Method);
		CodeExpressionCollection parameters = e.Parameters;
		if (parameters.Count > 0)
		{
			base.Output.Write("(");
			OutputExpressionList(e.Parameters);
			base.Output.Write(")");
		}
	}

	protected override void GenerateMethodReferenceExpression(CodeMethodReferenceExpression e)
	{
		if (e.TargetObject != null)
		{
			GenerateExpression(e.TargetObject);
			base.Output.Write(".");
			base.Output.Write(e.MethodName);
		}
		else
		{
			OutputIdentifier(e.MethodName);
		}
		if (e.TypeArguments.Count > 0)
		{
			base.Output.Write(GetTypeArgumentsOutput(e.TypeArguments));
		}
	}

	protected override void GenerateEventReferenceExpression(CodeEventReferenceExpression e)
	{
		if (e.TargetObject != null)
		{
			bool flag = e.TargetObject is CodeThisReferenceExpression;
			GenerateExpression(e.TargetObject);
			base.Output.Write(".");
			if (flag)
			{
				base.Output.Write(e.EventName + "Event");
			}
			else
			{
				base.Output.Write(e.EventName);
			}
		}
		else
		{
			OutputIdentifier(e.EventName + "Event");
		}
	}

	private void GenerateFormalEventReferenceExpression(CodeEventReferenceExpression e)
	{
		if (e.TargetObject != null && !(e.TargetObject is CodeThisReferenceExpression))
		{
			GenerateExpression(e.TargetObject);
			base.Output.Write(".");
		}
		OutputIdentifier(e.EventName);
	}

	protected override void GenerateDelegateInvokeExpression(CodeDelegateInvokeExpression e)
	{
		if (e.TargetObject != null)
		{
			if (e.TargetObject is CodeEventReferenceExpression)
			{
				base.Output.Write("RaiseEvent ");
				GenerateFormalEventReferenceExpression((CodeEventReferenceExpression)e.TargetObject);
			}
			else
			{
				GenerateExpression(e.TargetObject);
			}
		}
		CodeExpressionCollection parameters = e.Parameters;
		if (parameters.Count > 0)
		{
			base.Output.Write("(");
			OutputExpressionList(e.Parameters);
			base.Output.Write(")");
		}
	}

	protected override void GenerateObjectCreateExpression(CodeObjectCreateExpression e)
	{
		base.Output.Write("New ");
		OutputType(e.CreateType);
		base.Output.Write("(");
		OutputExpressionList(e.Parameters);
		base.Output.Write(")");
	}

	protected override void GenerateParameterDeclarationExpression(CodeParameterDeclarationExpression e)
	{
		if (e.CustomAttributes.Count > 0)
		{
			OutputAttributes(e.CustomAttributes, inLine: true);
		}
		OutputDirection(e.Direction);
		OutputTypeNamePair(e.Type, e.Name);
	}

	protected override void GeneratePropertySetValueReferenceExpression(CodePropertySetValueReferenceExpression e)
	{
		base.Output.Write("value");
	}

	protected override void GenerateThisReferenceExpression(CodeThisReferenceExpression e)
	{
		base.Output.Write("Me");
	}

	protected override void GenerateExpressionStatement(CodeExpressionStatement e)
	{
		GenerateExpression(e.Expression);
		base.Output.WriteLine("");
	}

	private bool IsDocComment(CodeCommentStatement comment)
	{
		if (comment != null && comment.Comment != null)
		{
			return comment.Comment.DocComment;
		}
		return false;
	}

	protected override void GenerateCommentStatements(CodeCommentStatementCollection e)
	{
		foreach (CodeCommentStatement item in e)
		{
			if (!IsDocComment(item))
			{
				GenerateCommentStatement(item);
			}
		}
		foreach (CodeCommentStatement item2 in e)
		{
			if (IsDocComment(item2))
			{
				GenerateCommentStatement(item2);
			}
		}
	}

	protected override void GenerateComment(CodeComment e)
	{
		string value = (e.DocComment ? "'''" : "'");
		base.Output.Write(value);
		string text = e.Text;
		for (int i = 0; i < text.Length; i++)
		{
			base.Output.Write(text[i]);
			if (text[i] == '\r')
			{
				if (i < text.Length - 1 && text[i + 1] == '\n')
				{
					base.Output.Write('\n');
					i++;
				}
				((IndentedTextWriter)base.Output).InternalOutputTabs();
				base.Output.Write(value);
			}
			else if (text[i] == '\n')
			{
				((IndentedTextWriter)base.Output).InternalOutputTabs();
				base.Output.Write(value);
			}
			else if (text[i] == '\u2028' || text[i] == '\u2029' || text[i] == '\u0085')
			{
				base.Output.Write(value);
			}
		}
		base.Output.WriteLine();
	}

	protected override void GenerateMethodReturnStatement(CodeMethodReturnStatement e)
	{
		if (e.Expression != null)
		{
			base.Output.Write("Return ");
			GenerateExpression(e.Expression);
			base.Output.WriteLine("");
		}
		else
		{
			base.Output.WriteLine("Return");
		}
	}

	protected override void GenerateConditionStatement(CodeConditionStatement e)
	{
		base.Output.Write("If ");
		GenerateExpression(e.Condition);
		base.Output.WriteLine(" Then");
		base.Indent++;
		GenerateVBStatements(e.TrueStatements);
		base.Indent--;
		CodeStatementCollection falseStatements = e.FalseStatements;
		if (falseStatements.Count > 0)
		{
			base.Output.Write("Else");
			base.Output.WriteLine("");
			base.Indent++;
			GenerateVBStatements(e.FalseStatements);
			base.Indent--;
		}
		base.Output.WriteLine("End If");
	}

	protected override void GenerateTryCatchFinallyStatement(CodeTryCatchFinallyStatement e)
	{
		base.Output.WriteLine("Try ");
		base.Indent++;
		GenerateVBStatements(e.TryStatements);
		base.Indent--;
		CodeCatchClauseCollection catchClauses = e.CatchClauses;
		if (catchClauses.Count > 0)
		{
			IEnumerator enumerator = catchClauses.GetEnumerator();
			while (enumerator.MoveNext())
			{
				CodeCatchClause codeCatchClause = (CodeCatchClause)enumerator.Current;
				base.Output.Write("Catch ");
				OutputTypeNamePair(codeCatchClause.CatchExceptionType, codeCatchClause.LocalName);
				base.Output.WriteLine("");
				base.Indent++;
				GenerateVBStatements(codeCatchClause.Statements);
				base.Indent--;
			}
		}
		CodeStatementCollection finallyStatements = e.FinallyStatements;
		if (finallyStatements.Count > 0)
		{
			base.Output.WriteLine("Finally");
			base.Indent++;
			GenerateVBStatements(finallyStatements);
			base.Indent--;
		}
		base.Output.WriteLine("End Try");
	}

	protected override void GenerateAssignStatement(CodeAssignStatement e)
	{
		GenerateExpression(e.Left);
		base.Output.Write(" = ");
		GenerateExpression(e.Right);
		base.Output.WriteLine("");
	}

	protected override void GenerateAttachEventStatement(CodeAttachEventStatement e)
	{
		base.Output.Write("AddHandler ");
		GenerateFormalEventReferenceExpression(e.Event);
		base.Output.Write(", ");
		GenerateExpression(e.Listener);
		base.Output.WriteLine("");
	}

	protected override void GenerateRemoveEventStatement(CodeRemoveEventStatement e)
	{
		base.Output.Write("RemoveHandler ");
		GenerateFormalEventReferenceExpression(e.Event);
		base.Output.Write(", ");
		GenerateExpression(e.Listener);
		base.Output.WriteLine("");
	}

	protected override void GenerateSnippetStatement(CodeSnippetStatement e)
	{
		base.Output.WriteLine(e.Value);
	}

	protected override void GenerateGotoStatement(CodeGotoStatement e)
	{
		base.Output.Write("goto ");
		base.Output.WriteLine(e.Label);
	}

	protected override void GenerateLabeledStatement(CodeLabeledStatement e)
	{
		base.Indent--;
		base.Output.Write(e.Label);
		base.Output.WriteLine(":");
		base.Indent++;
		if (e.Statement != null)
		{
			GenerateStatement(e.Statement);
		}
	}

	protected override void GenerateVariableDeclarationStatement(CodeVariableDeclarationStatement e)
	{
		bool flag = true;
		base.Output.Write("Dim ");
		CodeTypeReference type = e.Type;
		if (type.ArrayRank == 1 && e.InitExpression != null)
		{
			if (e.InitExpression is CodeArrayCreateExpression codeArrayCreateExpression && codeArrayCreateExpression.Initializers.Count == 0)
			{
				flag = false;
				OutputIdentifier(e.Name);
				base.Output.Write("(");
				if (codeArrayCreateExpression.SizeExpression != null)
				{
					base.Output.Write("(");
					GenerateExpression(codeArrayCreateExpression.SizeExpression);
					base.Output.Write(") - 1");
				}
				else
				{
					base.Output.Write(codeArrayCreateExpression.Size - 1);
				}
				base.Output.Write(")");
				if (type.ArrayElementType != null)
				{
					OutputArrayPostfix(type.ArrayElementType);
				}
				base.Output.Write(" As ");
				OutputType(type);
			}
			else
			{
				OutputTypeNamePair(e.Type, e.Name);
			}
		}
		else
		{
			OutputTypeNamePair(e.Type, e.Name);
		}
		if (flag && e.InitExpression != null)
		{
			base.Output.Write(" = ");
			GenerateExpression(e.InitExpression);
		}
		base.Output.WriteLine("");
	}

	protected override void GenerateLinePragmaStart(CodeLinePragma e)
	{
		base.Output.WriteLine("");
		base.Output.Write("#ExternalSource(\"");
		base.Output.Write(e.FileName);
		base.Output.Write("\",");
		base.Output.Write(e.LineNumber);
		base.Output.WriteLine(")");
	}

	protected override void GenerateLinePragmaEnd(CodeLinePragma e)
	{
		base.Output.WriteLine("");
		base.Output.WriteLine("#End ExternalSource");
	}

	protected override void GenerateEvent(CodeMemberEvent e, CodeTypeDeclaration c)
	{
		if (base.IsCurrentDelegate || base.IsCurrentEnum)
		{
			return;
		}
		if (e.CustomAttributes.Count > 0)
		{
			OutputAttributes(e.CustomAttributes, inLine: false);
		}
		string name = e.Name;
		if (e.PrivateImplementationType != null)
		{
			string baseTypeOutput = GetBaseTypeOutput(e.PrivateImplementationType);
			baseTypeOutput = baseTypeOutput.Replace('.', '_');
			e.Name = baseTypeOutput + "_" + e.Name;
		}
		OutputMemberAccessModifier(e.Attributes);
		base.Output.Write("Event ");
		OutputTypeNamePair(e.Type, e.Name);
		if (e.ImplementationTypes.Count > 0)
		{
			base.Output.Write(" Implements ");
			bool flag = true;
			foreach (CodeTypeReference implementationType in e.ImplementationTypes)
			{
				if (flag)
				{
					flag = false;
				}
				else
				{
					base.Output.Write(" , ");
				}
				OutputType(implementationType);
				base.Output.Write(".");
				OutputIdentifier(name);
			}
		}
		else if (e.PrivateImplementationType != null)
		{
			base.Output.Write(" Implements ");
			OutputType(e.PrivateImplementationType);
			base.Output.Write(".");
			OutputIdentifier(name);
		}
		base.Output.WriteLine("");
	}

	protected override void GenerateField(CodeMemberField e)
	{
		if (base.IsCurrentDelegate || base.IsCurrentInterface)
		{
			return;
		}
		if (base.IsCurrentEnum)
		{
			if (e.CustomAttributes.Count > 0)
			{
				OutputAttributes(e.CustomAttributes, inLine: false);
			}
			OutputIdentifier(e.Name);
			if (e.InitExpression != null)
			{
				base.Output.Write(" = ");
				GenerateExpression(e.InitExpression);
			}
			base.Output.WriteLine("");
			return;
		}
		if (e.CustomAttributes.Count > 0)
		{
			OutputAttributes(e.CustomAttributes, inLine: false);
		}
		OutputMemberAccessModifier(e.Attributes);
		OutputVTableModifier(e.Attributes);
		OutputFieldScopeModifier(e.Attributes);
		if (GetUserData(e, "WithEvents", defaultValue: false))
		{
			base.Output.Write("WithEvents ");
		}
		OutputTypeNamePair(e.Type, e.Name);
		if (e.InitExpression != null)
		{
			base.Output.Write(" = ");
			GenerateExpression(e.InitExpression);
		}
		base.Output.WriteLine("");
	}

	private bool MethodIsOverloaded(CodeMemberMethod e, CodeTypeDeclaration c)
	{
		if ((e.Attributes & MemberAttributes.Overloaded) != 0)
		{
			return true;
		}
		IEnumerator enumerator = c.Members.GetEnumerator();
		while (enumerator.MoveNext())
		{
			if (enumerator.Current is CodeMemberMethod)
			{
				CodeMemberMethod codeMemberMethod = (CodeMemberMethod)enumerator.Current;
				if (!(enumerator.Current is CodeTypeConstructor) && !(enumerator.Current is CodeConstructor) && codeMemberMethod != e && codeMemberMethod.Name.Equals(e.Name, StringComparison.OrdinalIgnoreCase) && codeMemberMethod.PrivateImplementationType == null)
				{
					return true;
				}
			}
		}
		return false;
	}

	protected override void GenerateSnippetMember(CodeSnippetTypeMember e)
	{
		base.Output.Write(e.Text);
	}

	protected override void GenerateMethod(CodeMemberMethod e, CodeTypeDeclaration c)
	{
		if (!base.IsCurrentClass && !base.IsCurrentStruct && !base.IsCurrentInterface)
		{
			return;
		}
		if (e.CustomAttributes.Count > 0)
		{
			OutputAttributes(e.CustomAttributes, inLine: false);
		}
		string name = e.Name;
		if (e.PrivateImplementationType != null)
		{
			string baseTypeOutput = GetBaseTypeOutput(e.PrivateImplementationType);
			baseTypeOutput = baseTypeOutput.Replace('.', '_');
			e.Name = baseTypeOutput + "_" + e.Name;
		}
		if (!base.IsCurrentInterface)
		{
			if (e.PrivateImplementationType == null)
			{
				OutputMemberAccessModifier(e.Attributes);
				if (MethodIsOverloaded(e, c))
				{
					base.Output.Write("Overloads ");
				}
			}
			OutputVTableModifier(e.Attributes);
			OutputMemberScopeModifier(e.Attributes);
		}
		else
		{
			OutputVTableModifier(e.Attributes);
		}
		bool flag = false;
		if (e.ReturnType.BaseType.Length == 0 || string.Compare(e.ReturnType.BaseType, typeof(void).FullName, StringComparison.OrdinalIgnoreCase) == 0)
		{
			flag = true;
		}
		if (flag)
		{
			base.Output.Write("Sub ");
		}
		else
		{
			base.Output.Write("Function ");
		}
		OutputIdentifier(e.Name);
		OutputTypeParameters(e.TypeParameters);
		base.Output.Write("(");
		OutputParameters(e.Parameters);
		base.Output.Write(")");
		if (!flag)
		{
			base.Output.Write(" As ");
			if (e.ReturnTypeCustomAttributes.Count > 0)
			{
				OutputAttributes(e.ReturnTypeCustomAttributes, inLine: true);
			}
			OutputType(e.ReturnType);
			OutputArrayPostfix(e.ReturnType);
		}
		if (e.ImplementationTypes.Count > 0)
		{
			base.Output.Write(" Implements ");
			bool flag2 = true;
			foreach (CodeTypeReference implementationType in e.ImplementationTypes)
			{
				if (flag2)
				{
					flag2 = false;
				}
				else
				{
					base.Output.Write(" , ");
				}
				OutputType(implementationType);
				base.Output.Write(".");
				OutputIdentifier(name);
			}
		}
		else if (e.PrivateImplementationType != null)
		{
			base.Output.Write(" Implements ");
			OutputType(e.PrivateImplementationType);
			base.Output.Write(".");
			OutputIdentifier(name);
		}
		base.Output.WriteLine("");
		if (!base.IsCurrentInterface && (e.Attributes & MemberAttributes.ScopeMask) != MemberAttributes.Abstract)
		{
			base.Indent++;
			GenerateVBStatements(e.Statements);
			base.Indent--;
			if (flag)
			{
				base.Output.WriteLine("End Sub");
			}
			else
			{
				base.Output.WriteLine("End Function");
			}
		}
		e.Name = name;
	}

	protected override void GenerateEntryPointMethod(CodeEntryPointMethod e, CodeTypeDeclaration c)
	{
		if (e.CustomAttributes.Count > 0)
		{
			OutputAttributes(e.CustomAttributes, inLine: false);
		}
		base.Output.WriteLine("Public Shared Sub Main()");
		base.Indent++;
		GenerateVBStatements(e.Statements);
		base.Indent--;
		base.Output.WriteLine("End Sub");
	}

	private bool PropertyIsOverloaded(CodeMemberProperty e, CodeTypeDeclaration c)
	{
		if ((e.Attributes & MemberAttributes.Overloaded) != 0)
		{
			return true;
		}
		IEnumerator enumerator = c.Members.GetEnumerator();
		while (enumerator.MoveNext())
		{
			if (enumerator.Current is CodeMemberProperty)
			{
				CodeMemberProperty codeMemberProperty = (CodeMemberProperty)enumerator.Current;
				if (codeMemberProperty != e && codeMemberProperty.Name.Equals(e.Name, StringComparison.OrdinalIgnoreCase) && codeMemberProperty.PrivateImplementationType == null)
				{
					return true;
				}
			}
		}
		return false;
	}

	protected override void GenerateProperty(CodeMemberProperty e, CodeTypeDeclaration c)
	{
		if (!base.IsCurrentClass && !base.IsCurrentStruct && !base.IsCurrentInterface)
		{
			return;
		}
		if (e.CustomAttributes.Count > 0)
		{
			OutputAttributes(e.CustomAttributes, inLine: false);
		}
		string name = e.Name;
		if (e.PrivateImplementationType != null)
		{
			string baseTypeOutput = GetBaseTypeOutput(e.PrivateImplementationType);
			baseTypeOutput = baseTypeOutput.Replace('.', '_');
			e.Name = baseTypeOutput + "_" + e.Name;
		}
		if (!base.IsCurrentInterface)
		{
			if (e.PrivateImplementationType == null)
			{
				OutputMemberAccessModifier(e.Attributes);
				if (PropertyIsOverloaded(e, c))
				{
					base.Output.Write("Overloads ");
				}
			}
			OutputVTableModifier(e.Attributes);
			OutputMemberScopeModifier(e.Attributes);
		}
		else
		{
			OutputVTableModifier(e.Attributes);
		}
		if (e.Parameters.Count > 0 && string.Compare(e.Name, "Item", StringComparison.OrdinalIgnoreCase) == 0)
		{
			base.Output.Write("Default ");
		}
		if (e.HasGet)
		{
			if (!e.HasSet)
			{
				base.Output.Write("ReadOnly ");
			}
		}
		else if (e.HasSet)
		{
			base.Output.Write("WriteOnly ");
		}
		base.Output.Write("Property ");
		OutputIdentifier(e.Name);
		base.Output.Write("(");
		if (e.Parameters.Count > 0)
		{
			OutputParameters(e.Parameters);
		}
		base.Output.Write(")");
		base.Output.Write(" As ");
		OutputType(e.Type);
		OutputArrayPostfix(e.Type);
		if (e.ImplementationTypes.Count > 0)
		{
			base.Output.Write(" Implements ");
			bool flag = true;
			foreach (CodeTypeReference implementationType in e.ImplementationTypes)
			{
				if (flag)
				{
					flag = false;
				}
				else
				{
					base.Output.Write(" , ");
				}
				OutputType(implementationType);
				base.Output.Write(".");
				OutputIdentifier(name);
			}
		}
		else if (e.PrivateImplementationType != null)
		{
			base.Output.Write(" Implements ");
			OutputType(e.PrivateImplementationType);
			base.Output.Write(".");
			OutputIdentifier(name);
		}
		base.Output.WriteLine("");
		if (!c.IsInterface && (e.Attributes & MemberAttributes.ScopeMask) != MemberAttributes.Abstract)
		{
			base.Indent++;
			if (e.HasGet)
			{
				base.Output.WriteLine("Get");
				if (!base.IsCurrentInterface)
				{
					base.Indent++;
					GenerateVBStatements(e.GetStatements);
					e.Name = name;
					base.Indent--;
					base.Output.WriteLine("End Get");
				}
			}
			if (e.HasSet)
			{
				base.Output.WriteLine("Set");
				if (!base.IsCurrentInterface)
				{
					base.Indent++;
					GenerateVBStatements(e.SetStatements);
					base.Indent--;
					base.Output.WriteLine("End Set");
				}
			}
			base.Indent--;
			base.Output.WriteLine("End Property");
		}
		e.Name = name;
	}

	protected override void GeneratePropertyReferenceExpression(CodePropertyReferenceExpression e)
	{
		if (e.TargetObject != null)
		{
			GenerateExpression(e.TargetObject);
			base.Output.Write(".");
			base.Output.Write(e.PropertyName);
		}
		else
		{
			OutputIdentifier(e.PropertyName);
		}
	}

	protected override void GenerateConstructor(CodeConstructor e, CodeTypeDeclaration c)
	{
		if (base.IsCurrentClass || base.IsCurrentStruct)
		{
			if (e.CustomAttributes.Count > 0)
			{
				OutputAttributes(e.CustomAttributes, inLine: false);
			}
			OutputMemberAccessModifier(e.Attributes);
			base.Output.Write("Sub New(");
			OutputParameters(e.Parameters);
			base.Output.WriteLine(")");
			base.Indent++;
			CodeExpressionCollection baseConstructorArgs = e.BaseConstructorArgs;
			CodeExpressionCollection chainedConstructorArgs = e.ChainedConstructorArgs;
			if (chainedConstructorArgs.Count > 0)
			{
				base.Output.Write("Me.New(");
				OutputExpressionList(chainedConstructorArgs);
				base.Output.Write(")");
				base.Output.WriteLine("");
			}
			else if (baseConstructorArgs.Count > 0)
			{
				base.Output.Write("MyBase.New(");
				OutputExpressionList(baseConstructorArgs);
				base.Output.Write(")");
				base.Output.WriteLine("");
			}
			else if (base.IsCurrentClass)
			{
				base.Output.WriteLine("MyBase.New");
			}
			GenerateVBStatements(e.Statements);
			base.Indent--;
			base.Output.WriteLine("End Sub");
		}
	}

	protected override void GenerateTypeConstructor(CodeTypeConstructor e)
	{
		if (base.IsCurrentClass || base.IsCurrentStruct)
		{
			if (e.CustomAttributes.Count > 0)
			{
				OutputAttributes(e.CustomAttributes, inLine: false);
			}
			base.Output.WriteLine("Shared Sub New()");
			base.Indent++;
			GenerateVBStatements(e.Statements);
			base.Indent--;
			base.Output.WriteLine("End Sub");
		}
	}

	protected override void GenerateTypeOfExpression(CodeTypeOfExpression e)
	{
		base.Output.Write("GetType(");
		base.Output.Write(GetTypeOutput(e.Type));
		base.Output.Write(")");
	}

	protected override void GenerateTypeStart(CodeTypeDeclaration e)
	{
		if (base.IsCurrentDelegate)
		{
			if (e.CustomAttributes.Count > 0)
			{
				OutputAttributes(e.CustomAttributes, inLine: false);
			}
			TypeAttributes typeAttributes = e.TypeAttributes & TypeAttributes.VisibilityMask;
			if (typeAttributes != TypeAttributes.NotPublic && typeAttributes == TypeAttributes.Public)
			{
				base.Output.Write("Public ");
			}
			CodeTypeDelegate codeTypeDelegate = (CodeTypeDelegate)e;
			if (codeTypeDelegate.ReturnType.BaseType.Length > 0 && string.Compare(codeTypeDelegate.ReturnType.BaseType, "System.Void", StringComparison.OrdinalIgnoreCase) != 0)
			{
				base.Output.Write("Delegate Function ");
			}
			else
			{
				base.Output.Write("Delegate Sub ");
			}
			OutputIdentifier(e.Name);
			base.Output.Write("(");
			OutputParameters(codeTypeDelegate.Parameters);
			base.Output.Write(")");
			if (codeTypeDelegate.ReturnType.BaseType.Length > 0 && string.Compare(codeTypeDelegate.ReturnType.BaseType, "System.Void", StringComparison.OrdinalIgnoreCase) != 0)
			{
				base.Output.Write(" As ");
				OutputType(codeTypeDelegate.ReturnType);
				OutputArrayPostfix(codeTypeDelegate.ReturnType);
			}
			base.Output.WriteLine("");
			return;
		}
		if (e.IsEnum)
		{
			if (e.CustomAttributes.Count > 0)
			{
				OutputAttributes(e.CustomAttributes, inLine: false);
			}
			OutputTypeAttributes(e);
			OutputIdentifier(e.Name);
			if (e.BaseTypes.Count > 0)
			{
				base.Output.Write(" As ");
				OutputType(e.BaseTypes[0]);
			}
			base.Output.WriteLine("");
			base.Indent++;
			return;
		}
		if (e.CustomAttributes.Count > 0)
		{
			OutputAttributes(e.CustomAttributes, inLine: false);
		}
		OutputTypeAttributes(e);
		OutputIdentifier(e.Name);
		OutputTypeParameters(e.TypeParameters);
		bool flag = false;
		bool flag2 = false;
		if (e.IsStruct)
		{
			flag = true;
		}
		if (e.IsInterface)
		{
			flag2 = true;
		}
		base.Indent++;
		foreach (CodeTypeReference baseType in e.BaseTypes)
		{
			if (!flag && (e.IsInterface || !baseType.IsInterface))
			{
				base.Output.WriteLine("");
				base.Output.Write("Inherits ");
				flag = true;
			}
			else if (!flag2)
			{
				base.Output.WriteLine("");
				base.Output.Write("Implements ");
				flag2 = true;
			}
			else
			{
				base.Output.Write(", ");
			}
			OutputType(baseType);
		}
		base.Output.WriteLine("");
	}

	private void OutputTypeParameters(CodeTypeParameterCollection typeParameters)
	{
		if (typeParameters.Count == 0)
		{
			return;
		}
		base.Output.Write("(Of ");
		bool flag = true;
		for (int i = 0; i < typeParameters.Count; i++)
		{
			if (flag)
			{
				flag = false;
			}
			else
			{
				base.Output.Write(", ");
			}
			base.Output.Write(typeParameters[i].Name);
			OutputTypeParameterConstraints(typeParameters[i]);
		}
		base.Output.Write(')');
	}

	private void OutputTypeParameterConstraints(CodeTypeParameter typeParameter)
	{
		CodeTypeReferenceCollection constraints = typeParameter.Constraints;
		int num = constraints.Count;
		if (typeParameter.HasConstructorConstraint)
		{
			num++;
		}
		if (num == 0)
		{
			return;
		}
		base.Output.Write(" As ");
		if (num > 1)
		{
			base.Output.Write(" {");
		}
		bool flag = true;
		foreach (CodeTypeReference item in constraints)
		{
			if (flag)
			{
				flag = false;
			}
			else
			{
				base.Output.Write(", ");
			}
			base.Output.Write(GetTypeOutput(item));
		}
		if (typeParameter.HasConstructorConstraint)
		{
			if (!flag)
			{
				base.Output.Write(", ");
			}
			base.Output.Write("New");
		}
		if (num > 1)
		{
			base.Output.Write('}');
		}
	}

	protected override void GenerateTypeEnd(CodeTypeDeclaration e)
	{
		if (!base.IsCurrentDelegate)
		{
			base.Indent--;
			string value = (e.IsEnum ? "End Enum" : (e.IsInterface ? "End Interface" : (e.IsStruct ? "End Structure" : ((!IsCurrentModule) ? "End Class" : "End Module"))));
			base.Output.WriteLine(value);
		}
	}

	protected override void GenerateNamespace(CodeNamespace e)
	{
		if (GetUserData(e, "GenerateImports", defaultValue: true))
		{
			GenerateNamespaceImports(e);
		}
		base.Output.WriteLine();
		GenerateCommentStatements(e.Comments);
		GenerateNamespaceStart(e);
		GenerateTypes(e);
		GenerateNamespaceEnd(e);
	}

	protected bool AllowLateBound(CodeCompileUnit e)
	{
		object obj = e.UserData["AllowLateBound"];
		if (obj != null && obj is bool)
		{
			return (bool)obj;
		}
		return true;
	}

	protected bool RequireVariableDeclaration(CodeCompileUnit e)
	{
		object obj = e.UserData["RequireVariableDeclaration"];
		if (obj != null && obj is bool)
		{
			return (bool)obj;
		}
		return true;
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

	protected override void GenerateCompileUnitStart(CodeCompileUnit e)
	{
		base.GenerateCompileUnitStart(e);
		base.Output.WriteLine("'------------------------------------------------------------------------------");
		base.Output.Write("' <");
		base.Output.WriteLine(SR.GetString("AutoGen_Comment_Line1"));
		base.Output.Write("'     ");
		base.Output.WriteLine(SR.GetString("AutoGen_Comment_Line2"));
		base.Output.Write("'     ");
		base.Output.Write(SR.GetString("AutoGen_Comment_Line3"));
		base.Output.WriteLine(Environment.Version.ToString());
		base.Output.WriteLine("'");
		base.Output.Write("'     ");
		base.Output.WriteLine(SR.GetString("AutoGen_Comment_Line4"));
		base.Output.Write("'     ");
		base.Output.WriteLine(SR.GetString("AutoGen_Comment_Line5"));
		base.Output.Write("' </");
		base.Output.WriteLine(SR.GetString("AutoGen_Comment_Line1"));
		base.Output.WriteLine("'------------------------------------------------------------------------------");
		base.Output.WriteLine("");
		if (AllowLateBound(e))
		{
			base.Output.WriteLine("Option Strict Off");
		}
		else
		{
			base.Output.WriteLine("Option Strict On");
		}
		if (!RequireVariableDeclaration(e))
		{
			base.Output.WriteLine("Option Explicit Off");
		}
		else
		{
			base.Output.WriteLine("Option Explicit On");
		}
		base.Output.WriteLine();
	}

	protected override void GenerateCompileUnit(CodeCompileUnit e)
	{
		GenerateCompileUnitStart(e);
		SortedList sortedList = new SortedList(StringComparer.OrdinalIgnoreCase);
		foreach (CodeNamespace @namespace in e.Namespaces)
		{
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
			base.Output.Write("Imports ");
			OutputIdentifier(key);
			base.Output.WriteLine("");
		}
		if (e.AssemblyCustomAttributes.Count > 0)
		{
			OutputAttributes(e.AssemblyCustomAttributes, inLine: false, "Assembly: ", closingLine: true);
		}
		GenerateNamespaces(e);
		GenerateCompileUnitEnd(e);
	}

	protected override void GenerateDirectives(CodeDirectiveCollection directives)
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
		base.Output.Write("#ExternalChecksum(\"");
		base.Output.Write(checksumPragma.FileName);
		base.Output.Write("\",\"");
		base.Output.Write(checksumPragma.ChecksumAlgorithmId.ToString("B", CultureInfo.InvariantCulture));
		base.Output.Write("\",\"");
		if (checksumPragma.ChecksumData != null)
		{
			byte[] checksumData = checksumPragma.ChecksumData;
			foreach (byte b in checksumData)
			{
				base.Output.Write(b.ToString("X2", CultureInfo.InvariantCulture));
			}
		}
		base.Output.WriteLine("\")");
	}

	private void GenerateCodeRegionDirective(CodeRegionDirective regionDirective)
	{
		if (!IsGeneratingStatements())
		{
			if (regionDirective.RegionMode == CodeRegionMode.Start)
			{
				base.Output.Write("#Region \"");
				base.Output.Write(regionDirective.RegionText);
				base.Output.WriteLine("\"");
			}
			else if (regionDirective.RegionMode == CodeRegionMode.End)
			{
				base.Output.WriteLine("#End Region");
			}
		}
	}

	protected override void GenerateNamespaceStart(CodeNamespace e)
	{
		if (e.Name != null && e.Name.Length > 0)
		{
			base.Output.Write("Namespace ");
			string[] array = e.Name.Split('.');
			OutputIdentifier(array[0]);
			for (int i = 1; i < array.Length; i++)
			{
				base.Output.Write(".");
				OutputIdentifier(array[i]);
			}
			base.Output.WriteLine();
			base.Indent++;
		}
	}

	protected override void GenerateNamespaceEnd(CodeNamespace e)
	{
		if (e.Name != null && e.Name.Length > 0)
		{
			base.Indent--;
			base.Output.WriteLine("End Namespace");
		}
	}

	protected override void GenerateNamespaceImport(CodeNamespaceImport e)
	{
		base.Output.Write("Imports ");
		OutputIdentifier(e.Namespace);
		base.Output.WriteLine("");
	}

	protected override void GenerateAttributeDeclarationsStart(CodeAttributeDeclarationCollection attributes)
	{
		base.Output.Write("<");
	}

	protected override void GenerateAttributeDeclarationsEnd(CodeAttributeDeclarationCollection attributes)
	{
		base.Output.Write(">");
	}

	public static bool IsKeyword(string value)
	{
		return FixedStringLookup.Contains(keywords, value, ignoreCase: true);
	}

	protected override bool Supports(GeneratorSupport support)
	{
		return (support & (GeneratorSupport.ArraysOfArrays | GeneratorSupport.EntryPointMethod | GeneratorSupport.GotoStatements | GeneratorSupport.MultidimensionalArrays | GeneratorSupport.StaticConstructors | GeneratorSupport.TryCatchStatements | GeneratorSupport.ReturnTypeAttributes | GeneratorSupport.DeclareValueTypes | GeneratorSupport.DeclareEnums | GeneratorSupport.DeclareDelegates | GeneratorSupport.DeclareInterfaces | GeneratorSupport.DeclareEvents | GeneratorSupport.AssemblyAttributes | GeneratorSupport.ParameterAttributes | GeneratorSupport.ReferenceParameters | GeneratorSupport.ChainedConstructorArguments | GeneratorSupport.NestedTypes | GeneratorSupport.MultipleInterfaceMembers | GeneratorSupport.PublicStaticMembers | GeneratorSupport.ComplexExpressions | GeneratorSupport.Win32Resources | GeneratorSupport.Resources | GeneratorSupport.PartialTypes | GeneratorSupport.GenericTypeReference | GeneratorSupport.GenericTypeDeclaration | GeneratorSupport.DeclareIndexerProperties)) == support;
	}

	protected override bool IsValidIdentifier(string value)
	{
		if (value == null || value.Length == 0)
		{
			return false;
		}
		if (value.Length > 1023)
		{
			return false;
		}
		if (value[0] != '[' || value[value.Length - 1] != ']')
		{
			if (IsKeyword(value))
			{
				return false;
			}
		}
		else
		{
			value = value.Substring(1, value.Length - 2);
		}
		if (value.Length == 1 && value[0] == '_')
		{
			return false;
		}
		return CodeGenerator.IsValidLanguageIndependentIdentifier(value);
	}

	protected override string CreateValidIdentifier(string name)
	{
		if (IsKeyword(name))
		{
			return "_" + name;
		}
		return name;
	}

	protected override string CreateEscapedIdentifier(string name)
	{
		if (IsKeyword(name))
		{
			return "[" + name + "]";
		}
		return name;
	}

	private string GetBaseTypeOutput(CodeTypeReference typeRef)
	{
		string baseType = typeRef.BaseType;
		if (baseType.Length == 0)
		{
			return "Void";
		}
		if (string.Compare(baseType, "System.Byte", StringComparison.OrdinalIgnoreCase) == 0)
		{
			return "Byte";
		}
		if (string.Compare(baseType, "System.SByte", StringComparison.OrdinalIgnoreCase) == 0)
		{
			return "SByte";
		}
		if (string.Compare(baseType, "System.Int16", StringComparison.OrdinalIgnoreCase) == 0)
		{
			return "Short";
		}
		if (string.Compare(baseType, "System.Int32", StringComparison.OrdinalIgnoreCase) == 0)
		{
			return "Integer";
		}
		if (string.Compare(baseType, "System.Int64", StringComparison.OrdinalIgnoreCase) == 0)
		{
			return "Long";
		}
		if (string.Compare(baseType, "System.UInt16", StringComparison.OrdinalIgnoreCase) == 0)
		{
			return "UShort";
		}
		if (string.Compare(baseType, "System.UInt32", StringComparison.OrdinalIgnoreCase) == 0)
		{
			return "UInteger";
		}
		if (string.Compare(baseType, "System.UInt64", StringComparison.OrdinalIgnoreCase) == 0)
		{
			return "ULong";
		}
		if (string.Compare(baseType, "System.String", StringComparison.OrdinalIgnoreCase) == 0)
		{
			return "String";
		}
		if (string.Compare(baseType, "System.DateTime", StringComparison.OrdinalIgnoreCase) == 0)
		{
			return "Date";
		}
		if (string.Compare(baseType, "System.Decimal", StringComparison.OrdinalIgnoreCase) == 0)
		{
			return "Decimal";
		}
		if (string.Compare(baseType, "System.Single", StringComparison.OrdinalIgnoreCase) == 0)
		{
			return "Single";
		}
		if (string.Compare(baseType, "System.Double", StringComparison.OrdinalIgnoreCase) == 0)
		{
			return "Double";
		}
		if (string.Compare(baseType, "System.Boolean", StringComparison.OrdinalIgnoreCase) == 0)
		{
			return "Boolean";
		}
		if (string.Compare(baseType, "System.Char", StringComparison.OrdinalIgnoreCase) == 0)
		{
			return "Char";
		}
		if (string.Compare(baseType, "System.Object", StringComparison.OrdinalIgnoreCase) == 0)
		{
			return "Object";
		}
		StringBuilder stringBuilder = new StringBuilder(baseType.Length + 10);
		if ((typeRef.Options & CodeTypeReferenceOptions.GlobalReference) != 0)
		{
			stringBuilder.Append("Global.");
		}
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < baseType.Length; i++)
		{
			switch (baseType[i])
			{
			case '+':
			case '.':
				stringBuilder.Append(CreateEscapedIdentifier(baseType.Substring(num, i - num)));
				stringBuilder.Append('.');
				i++;
				num = i;
				break;
			case '`':
			{
				stringBuilder.Append(CreateEscapedIdentifier(baseType.Substring(num, i - num)));
				i++;
				int num3 = 0;
				for (; i < baseType.Length && baseType[i] >= '0' && baseType[i] <= '9'; i++)
				{
					num3 = num3 * 10 + (baseType[i] - 48);
				}
				GetTypeArgumentsOutput(typeRef.TypeArguments, num2, num3, stringBuilder);
				num2 += num3;
				if (i < baseType.Length && (baseType[i] == '+' || baseType[i] == '.'))
				{
					stringBuilder.Append('.');
					i++;
				}
				num = i;
				break;
			}
			}
		}
		if (num < baseType.Length)
		{
			stringBuilder.Append(CreateEscapedIdentifier(baseType.Substring(num)));
		}
		return stringBuilder.ToString();
	}

	private string GetTypeOutputWithoutArrayPostFix(CodeTypeReference typeRef)
	{
		StringBuilder stringBuilder = new StringBuilder();
		while (typeRef.ArrayElementType != null)
		{
			typeRef = typeRef.ArrayElementType;
		}
		stringBuilder.Append(GetBaseTypeOutput(typeRef));
		return stringBuilder.ToString();
	}

	private string GetTypeArgumentsOutput(CodeTypeReferenceCollection typeArguments)
	{
		StringBuilder stringBuilder = new StringBuilder(128);
		GetTypeArgumentsOutput(typeArguments, 0, typeArguments.Count, stringBuilder);
		return stringBuilder.ToString();
	}

	private void GetTypeArgumentsOutput(CodeTypeReferenceCollection typeArguments, int start, int length, StringBuilder sb)
	{
		sb.Append("(Of ");
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
		sb.Append(')');
	}

	protected override string GetTypeOutput(CodeTypeReference typeRef)
	{
		string empty = string.Empty;
		empty += GetTypeOutputWithoutArrayPostFix(typeRef);
		if (typeRef.ArrayRank > 0)
		{
			empty += GetArrayPostfix(typeRef);
		}
		return empty;
	}

	protected override void ContinueOnNewLine(string st)
	{
		base.Output.Write(st);
		base.Output.WriteLine(" _");
	}

	private bool IsGeneratingStatements()
	{
		return statementDepth > 0;
	}

	private void GenerateVBStatements(CodeStatementCollection stms)
	{
		statementDepth++;
		try
		{
			GenerateStatements(stms);
		}
		finally
		{
			statementDepth--;
		}
	}

	protected override CompilerResults FromFileBatch(CompilerParameters options, string[] fileNames)
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
		string text = (options.GenerateExecutable ? "exe" : "dll");
		string text2 = "." + text;
		if (options.OutputAssembly == null || options.OutputAssembly.Length == 0)
		{
			options.OutputAssembly = compilerResults.TempFiles.AddExtension(text, !options.GenerateInMemory);
			new FileStream(options.OutputAssembly, FileMode.Create, FileAccess.ReadWrite).Close();
			flag = true;
		}
		string text3 = options.OutputAssembly;
		if (!Path.GetExtension(text3).Equals(text2, StringComparison.OrdinalIgnoreCase))
		{
			text3 += text2;
		}
		string fileExtension = "pdb";
		if (options.CompilerOptions != null && options.CompilerOptions.IndexOf("/debug:pdbonly", StringComparison.OrdinalIgnoreCase) != -1)
		{
			compilerResults.TempFiles.AddExtension(fileExtension, keepFile: true);
		}
		else
		{
			compilerResults.TempFiles.AddExtension(fileExtension);
		}
		string text4 = CmdArgsFromParameters(options) + " " + CodeCompiler.JoinStringArray(fileNames, " ");
		string responseFileCmdArgs = GetResponseFileCmdArgs(options, text4);
		string trueArgs = null;
		if (responseFileCmdArgs != null)
		{
			trueArgs = text4;
			text4 = responseFileCmdArgs;
		}
		Compile(options, RedistVersionInfo.GetCompilerPath(provOptions, CompilerName), CompilerName, text4, ref outputFile, ref nativeReturnValue, trueArgs);
		compilerResults.NativeCompilerReturnValue = nativeReturnValue;
		if (nativeReturnValue != 0 || options.WarningLevel > 0)
		{
			byte[] bytes = ReadAllBytes(outputFile, FileShare.ReadWrite);
			string input = Encoding.UTF8.GetString(bytes);
			string[] array = Regex.Split(input, "\\r\\n");
			string[] array2 = array;
			foreach (string text5 in array2)
			{
				compilerResults.Output.Add(text5);
				ProcessCompilerOutputLine(compilerResults, text5);
			}
			if (nativeReturnValue != 0 && flag)
			{
				File.Delete(text3);
			}
		}
		if (!compilerResults.Errors.HasErrors && options.GenerateInMemory)
		{
			FileStream fileStream = new FileStream(text3, FileMode.Open, FileAccess.Read, FileShare.Read);
			try
			{
				int num = (int)fileStream.Length;
				byte[] array3 = new byte[num];
				fileStream.Read(array3, 0, num);
				SecurityPermission securityPermission2 = new SecurityPermission(SecurityPermissionFlag.ControlEvidence);
				securityPermission2.Assert();
				try
				{
					if (!FileIntegrity.IsEnabled)
					{
						compilerResults.CompiledAssembly = Assembly.Load(array3, null, options.Evidence);
					}
					else
					{
						if (!FileIntegrity.IsTrusted(fileStream.SafeFileHandle))
						{
							throw new IOException(SR.GetString("FileIntegrityCheckFailed", text3));
						}
						compilerResults.CompiledAssembly = CodeCompiler.LoadImageSkipIntegrityCheck(array3, null, options.Evidence);
					}
				}
				finally
				{
					CodeAccessPermission.RevertAssert();
				}
			}
			finally
			{
				fileStream.Close();
			}
		}
		else
		{
			compilerResults.PathToAssembly = text3;
		}
		return compilerResults;
	}

	private static byte[] ReadAllBytes(string file, FileShare share)
	{
		using FileStream fileStream = File.Open(file, FileMode.Open, FileAccess.Read, share);
		int num = 0;
		long length = fileStream.Length;
		if (length > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException("file");
		}
		int num2 = (int)length;
		byte[] array = new byte[num2];
		while (num2 > 0)
		{
			int num3 = fileStream.Read(array, num, num2);
			if (num3 == 0)
			{
				throw new EndOfStreamException();
			}
			num += num3;
			num2 -= num3;
		}
		return array;
	}
}
