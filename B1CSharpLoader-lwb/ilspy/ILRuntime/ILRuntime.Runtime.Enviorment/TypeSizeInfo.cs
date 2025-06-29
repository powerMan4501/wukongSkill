using ILRuntime.CLR.TypeSystem;

namespace ILRuntime.Runtime.Enviorment;

public struct TypeSizeInfo
{
	public ILType Type;

	public int StaticFieldSize;

	public int MethodBodySize;

	public int TotalSize;
}
