using System.Configuration;

namespace System.Diagnostics;

internal class SwitchesDictionarySectionHandler : DictionarySectionHandler
{
	protected override string KeyAttributeName => "name";

	internal override bool ValueRequired => true;
}
