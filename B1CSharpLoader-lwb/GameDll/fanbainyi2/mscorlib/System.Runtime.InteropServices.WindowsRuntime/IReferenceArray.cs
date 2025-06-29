namespace System.Runtime.InteropServices.WindowsRuntime;

[ComImport]
[Guid("61c17707-2d65-11e0-9ae8-d48564015472")]
internal interface IReferenceArray<T> : IPropertyValue
{
	T[] Value { get; }
}
