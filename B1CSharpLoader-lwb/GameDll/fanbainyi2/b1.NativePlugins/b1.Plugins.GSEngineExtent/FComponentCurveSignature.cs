using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSEngineExtent;

[UDelegate]
[UMetaPath("/Script/GSEngineExtent.ComponentCurveSignature__DelegateSignature")]
public class FComponentCurveSignature : FMulticastDelegate<FComponentCurveSignature.Signature>
{
	public delegate void Signature(float curvetime);

	private static bool ComponentCurveSignature__DelegateSignature_IsValid;

	private static IntPtr ComponentCurveSignature__DelegateSignature_FunctionAddress;

	private static int ComponentCurveSignature__DelegateSignature_ParamsSize;

	private static bool ComponentCurveSignature__DelegateSignature_curvetime_IsValid;

	private static FFieldAddress ComponentCurveSignature__DelegateSignature_curvetime_PropertyAddress;

	private static int ComponentCurveSignature__DelegateSignature_curvetime_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FComponentCurveSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		ComponentCurveSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/GSEngineExtent.ComponentCurveSignature__DelegateSignature");
		ComponentCurveSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(ComponentCurveSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ComponentCurveSignature__DelegateSignature_curvetime_PropertyAddress, ComponentCurveSignature__DelegateSignature_FunctionAddress, "curvetime");
		ComponentCurveSignature__DelegateSignature_curvetime_Offset = NativeReflectionCached.GetPropertyOffset(ComponentCurveSignature__DelegateSignature_FunctionAddress, "curvetime");
		ComponentCurveSignature__DelegateSignature_curvetime_IsValid = NativeReflectionCached.ValidatePropertyClass(ComponentCurveSignature__DelegateSignature_FunctionAddress, "curvetime", Classes.FFloatProperty);
		ComponentCurveSignature__DelegateSignature_IsValid = ComponentCurveSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && ComponentCurveSignature__DelegateSignature_curvetime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEngineExtent.ComponentCurveSignature__DelegateSignature", ComponentCurveSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(float curvetime)
	{
		if (!ComponentCurveSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEngineExtent.ComponentCurveSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(ComponentCurveSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ComponentCurveSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ComponentCurveSignature__DelegateSignature_curvetime_Offset), 0, ComponentCurveSignature__DelegateSignature_curvetime_PropertyAddress.Address, curvetime);
			ProcessDelegate(intPtr);
		}
	}
}
