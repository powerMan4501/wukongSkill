namespace System.Configuration;

internal sealed class SchemeSettingInternal
{
	private string name;

	private GenericUriParserOptions options;

	public string Name => name;

	public GenericUriParserOptions Options => options;

	public SchemeSettingInternal(string name, GenericUriParserOptions options)
	{
		this.name = name.ToLowerInvariant();
		this.options = options;
	}
}
