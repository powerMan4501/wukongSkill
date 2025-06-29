using System.Dynamic.Utils;
using System.Linq.Expressions.Compiler;

namespace System.Linq.Expressions;

[global::__DynamicallyInvokable]
public class SymbolDocumentInfo
{
	private readonly string _fileName;

	[global::__DynamicallyInvokable]
	public string FileName
	{
		[global::__DynamicallyInvokable]
		get
		{
			return _fileName;
		}
	}

	[global::__DynamicallyInvokable]
	public virtual Guid Language
	{
		[global::__DynamicallyInvokable]
		get
		{
			return Guid.Empty;
		}
	}

	[global::__DynamicallyInvokable]
	public virtual Guid LanguageVendor
	{
		[global::__DynamicallyInvokable]
		get
		{
			return Guid.Empty;
		}
	}

	[global::__DynamicallyInvokable]
	public virtual Guid DocumentType
	{
		[global::__DynamicallyInvokable]
		get
		{
			return SymbolGuids.DocumentType_Text;
		}
	}

	internal SymbolDocumentInfo(string fileName)
	{
		ContractUtils.RequiresNotNull(fileName, "fileName");
		_fileName = fileName;
	}
}
