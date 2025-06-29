namespace System.Runtime.InteropServices.WindowsRuntime;

[ComImport]
[Guid("61c17706-2d65-11e0-9ae8-d48564015472")]
internal interface IReference<T> : IPropertyValue
{
	T Value { get; }
}
