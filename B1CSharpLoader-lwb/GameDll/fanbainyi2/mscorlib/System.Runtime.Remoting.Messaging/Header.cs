using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Messaging;

[Serializable]
[ComVisible(true)]
public class Header
{
	public string Name;

	public object Value;

	public bool MustUnderstand;

	public string HeaderNamespace;

	public Header(string _Name, object _Value)
		: this(_Name, _Value, _MustUnderstand: true)
	{
	}

	public Header(string _Name, object _Value, bool _MustUnderstand)
	{
		Name = _Name;
		Value = _Value;
		MustUnderstand = _MustUnderstand;
	}

	public Header(string _Name, object _Value, bool _MustUnderstand, string _HeaderNamespace)
	{
		Name = _Name;
		Value = _Value;
		MustUnderstand = _MustUnderstand;
		HeaderNamespace = _HeaderNamespace;
	}
}
