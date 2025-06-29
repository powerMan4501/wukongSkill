using System.Linq.Expressions.Compiler;

namespace System.Linq.Expressions;

internal sealed class SymbolDocumentWithGuids : SymbolDocumentInfo
{
	private readonly Guid _language;

	private readonly Guid _vendor;

	private readonly Guid _documentType;

	public override Guid Language => _language;

	public override Guid LanguageVendor => _vendor;

	public override Guid DocumentType => _documentType;

	internal SymbolDocumentWithGuids(string fileName, ref Guid language)
		: base(fileName)
	{
		_language = language;
		_documentType = SymbolGuids.DocumentType_Text;
	}

	internal SymbolDocumentWithGuids(string fileName, ref Guid language, ref Guid vendor)
		: base(fileName)
	{
		_language = language;
		_vendor = vendor;
		_documentType = SymbolGuids.DocumentType_Text;
	}

	internal SymbolDocumentWithGuids(string fileName, ref Guid language, ref Guid vendor, ref Guid documentType)
		: base(fileName)
	{
		_language = language;
		_vendor = vendor;
		_documentType = documentType;
	}
}
