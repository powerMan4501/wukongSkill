using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.PlasticDeformationEventSignature__DelegateSignature")]
public class FPlasticDeformationEventSignature : FMulticastDelegate<FPlasticDeformationEventSignature.Signature>
{
	public delegate void Signature(int ConstraintIndex);

	private static bool PlasticDeformationEventSignature__DelegateSignature_IsValid;

	private static IntPtr PlasticDeformationEventSignature__DelegateSignature_FunctionAddress;

	private static int PlasticDeformationEventSignature__DelegateSignature_ParamsSize;

	private static bool PlasticDeformationEventSignature__DelegateSignature_ConstraintIndex_IsValid;

	private static FFieldAddress PlasticDeformationEventSignature__DelegateSignature_ConstraintIndex_PropertyAddress;

	private static int PlasticDeformationEventSignature__DelegateSignature_ConstraintIndex_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FPlasticDeformationEventSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		PlasticDeformationEventSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.PlasticDeformationEventSignature__DelegateSignature");
		PlasticDeformationEventSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(PlasticDeformationEventSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PlasticDeformationEventSignature__DelegateSignature_ConstraintIndex_PropertyAddress, PlasticDeformationEventSignature__DelegateSignature_FunctionAddress, "ConstraintIndex");
		PlasticDeformationEventSignature__DelegateSignature_ConstraintIndex_Offset = NativeReflectionCached.GetPropertyOffset(PlasticDeformationEventSignature__DelegateSignature_FunctionAddress, "ConstraintIndex");
		PlasticDeformationEventSignature__DelegateSignature_ConstraintIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(PlasticDeformationEventSignature__DelegateSignature_FunctionAddress, "ConstraintIndex", Classes.FIntProperty);
		PlasticDeformationEventSignature__DelegateSignature_IsValid = PlasticDeformationEventSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && PlasticDeformationEventSignature__DelegateSignature_ConstraintIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlasticDeformationEventSignature__DelegateSignature", PlasticDeformationEventSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(int ConstraintIndex)
	{
		if (!PlasticDeformationEventSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlasticDeformationEventSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(PlasticDeformationEventSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlasticDeformationEventSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, PlasticDeformationEventSignature__DelegateSignature_ConstraintIndex_Offset), 0, PlasticDeformationEventSignature__DelegateSignature_ConstraintIndex_PropertyAddress.Address, ConstraintIndex);
			ProcessDelegate(intPtr);
		}
	}
}
