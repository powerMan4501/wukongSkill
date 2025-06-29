using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq.Expressions;
using System.Linq.Expressions.Compiler;
using System.Reflection;
using System.Reflection.Emit;

namespace System.Runtime.CompilerServices;

internal sealed class SymbolDocumentGenerator : DebugInfoGenerator
{
	private Dictionary<SymbolDocumentInfo, ISymbolDocumentWriter> _symbolWriters;

	private ISymbolDocumentWriter GetSymbolWriter(MethodBuilder method, SymbolDocumentInfo document)
	{
		if (_symbolWriters == null)
		{
			_symbolWriters = new Dictionary<SymbolDocumentInfo, ISymbolDocumentWriter>();
		}
		if (!_symbolWriters.TryGetValue(document, out var value))
		{
			value = ((ModuleBuilder)method.Module).DefineDocument(document.FileName, document.Language, document.LanguageVendor, SymbolGuids.DocumentType_Text);
			_symbolWriters.Add(document, value);
		}
		return value;
	}

	internal override void MarkSequencePoint(LambdaExpression method, MethodBase methodBase, ILGenerator ilg, DebugInfoExpression sequencePoint)
	{
		MethodBuilder methodBuilder = methodBase as MethodBuilder;
		if (methodBuilder != null)
		{
			ilg.MarkSequencePoint(GetSymbolWriter(methodBuilder, sequencePoint.Document), sequencePoint.StartLine, sequencePoint.StartColumn, sequencePoint.EndLine, sequencePoint.EndColumn);
		}
	}

	public override void MarkSequencePoint(LambdaExpression method, int ilOffset, DebugInfoExpression sequencePoint)
	{
		throw Error.PdbGeneratorNeedsExpressionCompiler();
	}

	internal override void SetLocalName(LocalBuilder localBuilder, string name)
	{
		localBuilder.SetLocalSymInfo(name);
	}
}
