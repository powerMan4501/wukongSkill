using System.Runtime.InteropServices;

namespace System.Diagnostics.SymbolStore;

[ComVisible(true)]
public interface ISymbolScope
{
	ISymbolMethod Method { get; }

	ISymbolScope Parent { get; }

	int StartOffset { get; }

	int EndOffset { get; }

	ISymbolScope[] GetChildren();

	ISymbolVariable[] GetLocals();

	ISymbolNamespace[] GetNamespaces();
}
