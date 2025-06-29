using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Foliage;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_FoliageFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_FoliageFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool InstancedFoliageActorSetCullDistance_IsValid;

	private static IntPtr InstancedFoliageActorSetCullDistance_FunctionAddress;

	private static int InstancedFoliageActorSetCullDistance_ParamsSize;

	private static bool InstancedFoliageActorSetCullDistance_FoliageActor_IsValid;

	private static FFieldAddress InstancedFoliageActorSetCullDistance_FoliageActor_PropertyAddress;

	private static int InstancedFoliageActorSetCullDistance_FoliageActor_Offset;

	private static bool InstancedFoliageActorSetCullDistance_MinLodDist_IsValid;

	private static FFieldAddress InstancedFoliageActorSetCullDistance_MinLodDist_PropertyAddress;

	private static int InstancedFoliageActorSetCullDistance_MinLodDist_Offset;

	private static bool InstancedFoliageActorSetCullDistance_MaxLodDist_IsValid;

	private static FFieldAddress InstancedFoliageActorSetCullDistance_MaxLodDist_PropertyAddress;

	private static int InstancedFoliageActorSetCullDistance_MaxLodDist_Offset;

	private static bool IFA_GetSelectedInstanceName_IsValid;

	private static IntPtr IFA_GetSelectedInstanceName_FunctionAddress;

	private static int IFA_GetSelectedInstanceName_ParamsSize;

	private static bool IFA_GetSelectedInstanceName_FoliageActor_IsValid;

	private static FFieldAddress IFA_GetSelectedInstanceName_FoliageActor_PropertyAddress;

	private static int IFA_GetSelectedInstanceName_FoliageActor_Offset;

	private static bool IFA_GetSelectedInstanceName_ReturnValue_IsValid;

	private static FFieldAddress IFA_GetSelectedInstanceName_ReturnValue_PropertyAddress;

	private static int IFA_GetSelectedInstanceName_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_FoliageFuncLib:InstancedFoliageActorSetCullDistance")]
	public unsafe static void InstancedFoliageActorSetCullDistance(AInstancedFoliageActor FoliageActor, int MinLodDist, int MaxLodDist)
	{
		if (!InstancedFoliageActorSetCullDistance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_FoliageFuncLib:InstancedFoliageActorSetCullDistance");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InstancedFoliageActorSetCullDistance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InstancedFoliageActorSetCullDistance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AInstancedFoliageActor>.ToNative(IntPtr.Add(intPtr, InstancedFoliageActorSetCullDistance_FoliageActor_Offset), 0, InstancedFoliageActorSetCullDistance_FoliageActor_PropertyAddress.Address, FoliageActor);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, InstancedFoliageActorSetCullDistance_MinLodDist_Offset), 0, InstancedFoliageActorSetCullDistance_MinLodDist_PropertyAddress.Address, MinLodDist);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, InstancedFoliageActorSetCullDistance_MaxLodDist_Offset), 0, InstancedFoliageActorSetCullDistance_MaxLodDist_PropertyAddress.Address, MaxLodDist);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, InstancedFoliageActorSetCullDistance_FunctionAddress, intPtr, InstancedFoliageActorSetCullDistance_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_FoliageFuncLib:IFA_GetSelectedInstanceName")]
	public unsafe static string IFA_GetSelectedInstanceName(AInstancedFoliageActor FoliageActor)
	{
		if (!IFA_GetSelectedInstanceName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_FoliageFuncLib:IFA_GetSelectedInstanceName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IFA_GetSelectedInstanceName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IFA_GetSelectedInstanceName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AInstancedFoliageActor>.ToNative(IntPtr.Add(intPtr, IFA_GetSelectedInstanceName_FoliageActor_Offset), 0, IFA_GetSelectedInstanceName_FoliageActor_PropertyAddress.Address, FoliageActor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IFA_GetSelectedInstanceName_FunctionAddress, intPtr, IFA_GetSelectedInstanceName_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, IFA_GetSelectedInstanceName_ReturnValue_Offset), 0, IFA_GetSelectedInstanceName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(IFA_GetSelectedInstanceName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UGSE_FoliageFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_FoliageFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_FoliageFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_FoliageFuncLib");
		InstancedFoliageActorSetCullDistance_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "InstancedFoliageActorSetCullDistance");
		InstancedFoliageActorSetCullDistance_ParamsSize = NativeReflection.GetFunctionParamsSize(InstancedFoliageActorSetCullDistance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InstancedFoliageActorSetCullDistance_FoliageActor_PropertyAddress, InstancedFoliageActorSetCullDistance_FunctionAddress, "FoliageActor");
		InstancedFoliageActorSetCullDistance_FoliageActor_Offset = NativeReflectionCached.GetPropertyOffset(InstancedFoliageActorSetCullDistance_FunctionAddress, "FoliageActor");
		InstancedFoliageActorSetCullDistance_FoliageActor_IsValid = NativeReflectionCached.ValidatePropertyClass(InstancedFoliageActorSetCullDistance_FunctionAddress, "FoliageActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref InstancedFoliageActorSetCullDistance_MinLodDist_PropertyAddress, InstancedFoliageActorSetCullDistance_FunctionAddress, "MinLodDist");
		InstancedFoliageActorSetCullDistance_MinLodDist_Offset = NativeReflectionCached.GetPropertyOffset(InstancedFoliageActorSetCullDistance_FunctionAddress, "MinLodDist");
		InstancedFoliageActorSetCullDistance_MinLodDist_IsValid = NativeReflectionCached.ValidatePropertyClass(InstancedFoliageActorSetCullDistance_FunctionAddress, "MinLodDist", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref InstancedFoliageActorSetCullDistance_MaxLodDist_PropertyAddress, InstancedFoliageActorSetCullDistance_FunctionAddress, "MaxLodDist");
		InstancedFoliageActorSetCullDistance_MaxLodDist_Offset = NativeReflectionCached.GetPropertyOffset(InstancedFoliageActorSetCullDistance_FunctionAddress, "MaxLodDist");
		InstancedFoliageActorSetCullDistance_MaxLodDist_IsValid = NativeReflectionCached.ValidatePropertyClass(InstancedFoliageActorSetCullDistance_FunctionAddress, "MaxLodDist", Classes.FIntProperty);
		InstancedFoliageActorSetCullDistance_IsValid = InstancedFoliageActorSetCullDistance_FunctionAddress != IntPtr.Zero && InstancedFoliageActorSetCullDistance_FoliageActor_IsValid && InstancedFoliageActorSetCullDistance_MinLodDist_IsValid && InstancedFoliageActorSetCullDistance_MaxLodDist_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_FoliageFuncLib:InstancedFoliageActorSetCullDistance", InstancedFoliageActorSetCullDistance_IsValid);
		IFA_GetSelectedInstanceName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IFA_GetSelectedInstanceName");
		IFA_GetSelectedInstanceName_ParamsSize = NativeReflection.GetFunctionParamsSize(IFA_GetSelectedInstanceName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IFA_GetSelectedInstanceName_FoliageActor_PropertyAddress, IFA_GetSelectedInstanceName_FunctionAddress, "FoliageActor");
		IFA_GetSelectedInstanceName_FoliageActor_Offset = NativeReflectionCached.GetPropertyOffset(IFA_GetSelectedInstanceName_FunctionAddress, "FoliageActor");
		IFA_GetSelectedInstanceName_FoliageActor_IsValid = NativeReflectionCached.ValidatePropertyClass(IFA_GetSelectedInstanceName_FunctionAddress, "FoliageActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IFA_GetSelectedInstanceName_ReturnValue_PropertyAddress, IFA_GetSelectedInstanceName_FunctionAddress, "ReturnValue");
		IFA_GetSelectedInstanceName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IFA_GetSelectedInstanceName_FunctionAddress, "ReturnValue");
		IFA_GetSelectedInstanceName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IFA_GetSelectedInstanceName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		IFA_GetSelectedInstanceName_IsValid = IFA_GetSelectedInstanceName_FunctionAddress != IntPtr.Zero && IFA_GetSelectedInstanceName_FoliageActor_IsValid && IFA_GetSelectedInstanceName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_FoliageFuncLib:IFA_GetSelectedInstanceName", IFA_GetSelectedInstanceName_IsValid);
	}
}
