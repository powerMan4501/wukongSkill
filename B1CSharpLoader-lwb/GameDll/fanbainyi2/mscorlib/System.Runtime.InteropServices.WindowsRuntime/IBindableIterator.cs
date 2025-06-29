namespace System.Runtime.InteropServices.WindowsRuntime;

[ComImport]
[Guid("6a1d6c07-076d-49f2-8314-f52c9c9a8331")]
internal interface IBindableIterator
{
	object Current { get; }

	bool HasCurrent { get; }

	bool MoveNext();
}
