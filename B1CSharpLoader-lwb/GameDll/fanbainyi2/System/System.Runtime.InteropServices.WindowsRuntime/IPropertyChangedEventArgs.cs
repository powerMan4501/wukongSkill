namespace System.Runtime.InteropServices.WindowsRuntime;

[ComImport]
[Guid("4f33a9a0-5cf4-47a4-b16f-d7faaf17457e")]
internal interface IPropertyChangedEventArgs
{
	string PropertyName { get; }
}
