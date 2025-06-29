namespace System.Runtime.InteropServices.WindowsRuntime;

[ComImport]
[Guid("7C925755-3E48-42B4-8677-76372267033F")]
internal interface ICustomPropertyProvider
{
	ICustomProperty GetCustomProperty(string name);

	ICustomProperty GetIndexedProperty(string name, Type indexParameterType);

	string GetStringRepresentation();

	Type Type { get; }
}
