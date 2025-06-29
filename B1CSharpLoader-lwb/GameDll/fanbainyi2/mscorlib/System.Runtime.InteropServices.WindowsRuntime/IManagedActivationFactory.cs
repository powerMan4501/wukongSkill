namespace System.Runtime.InteropServices.WindowsRuntime;

[ComImport]
[Guid("60D27C8D-5F61-4CCE-B751-690FAE66AA53")]
internal interface IManagedActivationFactory
{
	void RunClassConstructor();
}
