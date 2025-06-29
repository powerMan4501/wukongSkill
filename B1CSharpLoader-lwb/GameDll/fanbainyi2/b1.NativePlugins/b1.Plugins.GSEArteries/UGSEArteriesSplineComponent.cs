using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSEArteries;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/GSEArteries.GSEArteriesSplineComponent", "GSEArteries", UnrealModuleType.GamePlugin)]
public class UGSEArteriesSplineComponent : USplineComponent
{
	private static bool SetGSArteriesSplineMinUnitLength_IsValid;

	private static IntPtr SetGSArteriesSplineMinUnitLength_FunctionAddress;

	private static int SetGSArteriesSplineMinUnitLength_ParamsSize;

	private static bool SetGSArteriesSplineMinUnitLength_Length_IsValid;

	private static FFieldAddress SetGSArteriesSplineMinUnitLength_Length_PropertyAddress;

	private static int SetGSArteriesSplineMinUnitLength_Length_Offset;

	private static bool MakeGSArteriesSplineClosedAsRect_IsValid;

	private static IntPtr MakeGSArteriesSplineClosedAsRect_FunctionAddress;

	private static int MakeGSArteriesSplineClosedAsRect_ParamsSize;

	private static bool MakeGSArteriesSplineClosedAsRect_CloseDistance_IsValid;

	private static FFieldAddress MakeGSArteriesSplineClosedAsRect_CloseDistance_PropertyAddress;

	private static int MakeGSArteriesSplineClosedAsRect_CloseDistance_Offset;

	private static bool MakeGSArteriesSplineClosedAsRect_ReturnValue_IsValid;

	private static FFieldAddress MakeGSArteriesSplineClosedAsRect_ReturnValue_PropertyAddress;

	private static int MakeGSArteriesSplineClosedAsRect_ReturnValue_Offset;

	private static bool IsGSArteriesSplineClosed_IsValid;

	private static IntPtr IsGSArteriesSplineClosed_FunctionAddress;

	private static int IsGSArteriesSplineClosed_ParamsSize;

	private static bool IsGSArteriesSplineClosed_ReturnValue_IsValid;

	private static FFieldAddress IsGSArteriesSplineClosed_ReturnValue_PropertyAddress;

	private static int IsGSArteriesSplineClosed_ReturnValue_Offset;

	private static bool BindSplineToBoxExtent_IsValid;

	private static IntPtr BindSplineToBoxExtent_FunctionAddress;

	private static int BindSplineToBoxExtent_ParamsSize;

	private static bool BindSplineToBoxExtent_InBoxExtent_IsValid;

	private static FFieldAddress BindSplineToBoxExtent_InBoxExtent_PropertyAddress;

	private static int BindSplineToBoxExtent_InBoxExtent_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSEArteries.GSEArteriesSplineComponent:SetGSArteriesSplineMinUnitLength")]
	public unsafe void SetGSArteriesSplineMinUnitLength(float Length)
	{
		CheckDestroyed();
		if (!SetGSArteriesSplineMinUnitLength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEArteries.GSEArteriesSplineComponent:SetGSArteriesSplineMinUnitLength");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGSArteriesSplineMinUnitLength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGSArteriesSplineMinUnitLength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetGSArteriesSplineMinUnitLength_Length_Offset), 0, SetGSArteriesSplineMinUnitLength_Length_PropertyAddress.Address, Length);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGSArteriesSplineMinUnitLength_FunctionAddress, intPtr, SetGSArteriesSplineMinUnitLength_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSEArteries.GSEArteriesSplineComponent:MakeGSArteriesSplineClosedAsRect")]
	public unsafe bool MakeGSArteriesSplineClosedAsRect(float CloseDistance)
	{
		CheckDestroyed();
		if (!MakeGSArteriesSplineClosedAsRect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEArteries.GSEArteriesSplineComponent:MakeGSArteriesSplineClosedAsRect");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeGSArteriesSplineClosedAsRect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeGSArteriesSplineClosedAsRect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MakeGSArteriesSplineClosedAsRect_CloseDistance_Offset), 0, MakeGSArteriesSplineClosedAsRect_CloseDistance_PropertyAddress.Address, CloseDistance);
		NativeReflection.InvokeFunctionOptimized(base.Address, MakeGSArteriesSplineClosedAsRect_FunctionAddress, intPtr, MakeGSArteriesSplineClosedAsRect_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, MakeGSArteriesSplineClosedAsRect_ReturnValue_Offset), 0, MakeGSArteriesSplineClosedAsRect_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSEArteries.GSEArteriesSplineComponent:IsGSArteriesSplineClosed")]
	public unsafe bool IsGSArteriesSplineClosed()
	{
		CheckDestroyed();
		if (!IsGSArteriesSplineClosed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEArteries.GSEArteriesSplineComponent:IsGSArteriesSplineClosed");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsGSArteriesSplineClosed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsGSArteriesSplineClosed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsGSArteriesSplineClosed_FunctionAddress, intPtr, IsGSArteriesSplineClosed_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsGSArteriesSplineClosed_ReturnValue_Offset), 0, IsGSArteriesSplineClosed_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/GSEArteries.GSEArteriesSplineComponent:BindSplineToBoxExtent")]
	public unsafe void BindSplineToBoxExtent(FVector InBoxExtent)
	{
		CheckDestroyed();
		if (!BindSplineToBoxExtent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEArteries.GSEArteriesSplineComponent:BindSplineToBoxExtent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BindSplineToBoxExtent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BindSplineToBoxExtent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BindSplineToBoxExtent_InBoxExtent_Offset), 0, BindSplineToBoxExtent_InBoxExtent_PropertyAddress.Address, InBoxExtent);
		NativeReflection.InvokeFunctionOptimized(base.Address, BindSplineToBoxExtent_FunctionAddress, intPtr, BindSplineToBoxExtent_ParamsSize);
	}

	static UGSEArteriesSplineComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSEArteriesSplineComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSEArteriesSplineComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/GSEArteries.GSEArteriesSplineComponent");
		SetGSArteriesSplineMinUnitLength_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetGSArteriesSplineMinUnitLength");
		SetGSArteriesSplineMinUnitLength_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGSArteriesSplineMinUnitLength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGSArteriesSplineMinUnitLength_Length_PropertyAddress, SetGSArteriesSplineMinUnitLength_FunctionAddress, "Length");
		SetGSArteriesSplineMinUnitLength_Length_Offset = NativeReflectionCached.GetPropertyOffset(SetGSArteriesSplineMinUnitLength_FunctionAddress, "Length");
		SetGSArteriesSplineMinUnitLength_Length_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGSArteriesSplineMinUnitLength_FunctionAddress, "Length", Classes.FFloatProperty);
		SetGSArteriesSplineMinUnitLength_IsValid = SetGSArteriesSplineMinUnitLength_FunctionAddress != IntPtr.Zero && SetGSArteriesSplineMinUnitLength_Length_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEArteries.GSEArteriesSplineComponent:SetGSArteriesSplineMinUnitLength", SetGSArteriesSplineMinUnitLength_IsValid);
		MakeGSArteriesSplineClosedAsRect_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "MakeGSArteriesSplineClosedAsRect");
		MakeGSArteriesSplineClosedAsRect_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeGSArteriesSplineClosedAsRect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeGSArteriesSplineClosedAsRect_CloseDistance_PropertyAddress, MakeGSArteriesSplineClosedAsRect_FunctionAddress, "CloseDistance");
		MakeGSArteriesSplineClosedAsRect_CloseDistance_Offset = NativeReflectionCached.GetPropertyOffset(MakeGSArteriesSplineClosedAsRect_FunctionAddress, "CloseDistance");
		MakeGSArteriesSplineClosedAsRect_CloseDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeGSArteriesSplineClosedAsRect_FunctionAddress, "CloseDistance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeGSArteriesSplineClosedAsRect_ReturnValue_PropertyAddress, MakeGSArteriesSplineClosedAsRect_FunctionAddress, "ReturnValue");
		MakeGSArteriesSplineClosedAsRect_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeGSArteriesSplineClosedAsRect_FunctionAddress, "ReturnValue");
		MakeGSArteriesSplineClosedAsRect_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeGSArteriesSplineClosedAsRect_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		MakeGSArteriesSplineClosedAsRect_IsValid = MakeGSArteriesSplineClosedAsRect_FunctionAddress != IntPtr.Zero && MakeGSArteriesSplineClosedAsRect_CloseDistance_IsValid && MakeGSArteriesSplineClosedAsRect_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEArteries.GSEArteriesSplineComponent:MakeGSArteriesSplineClosedAsRect", MakeGSArteriesSplineClosedAsRect_IsValid);
		IsGSArteriesSplineClosed_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsGSArteriesSplineClosed");
		IsGSArteriesSplineClosed_ParamsSize = NativeReflection.GetFunctionParamsSize(IsGSArteriesSplineClosed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsGSArteriesSplineClosed_ReturnValue_PropertyAddress, IsGSArteriesSplineClosed_FunctionAddress, "ReturnValue");
		IsGSArteriesSplineClosed_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsGSArteriesSplineClosed_FunctionAddress, "ReturnValue");
		IsGSArteriesSplineClosed_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsGSArteriesSplineClosed_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsGSArteriesSplineClosed_IsValid = IsGSArteriesSplineClosed_FunctionAddress != IntPtr.Zero && IsGSArteriesSplineClosed_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEArteries.GSEArteriesSplineComponent:IsGSArteriesSplineClosed", IsGSArteriesSplineClosed_IsValid);
		BindSplineToBoxExtent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BindSplineToBoxExtent");
		BindSplineToBoxExtent_ParamsSize = NativeReflection.GetFunctionParamsSize(BindSplineToBoxExtent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BindSplineToBoxExtent_InBoxExtent_PropertyAddress, BindSplineToBoxExtent_FunctionAddress, "InBoxExtent");
		BindSplineToBoxExtent_InBoxExtent_Offset = NativeReflectionCached.GetPropertyOffset(BindSplineToBoxExtent_FunctionAddress, "InBoxExtent");
		BindSplineToBoxExtent_InBoxExtent_IsValid = NativeReflectionCached.ValidatePropertyClass(BindSplineToBoxExtent_FunctionAddress, "InBoxExtent", Classes.FStructProperty);
		BindSplineToBoxExtent_IsValid = BindSplineToBoxExtent_FunctionAddress != IntPtr.Zero && BindSplineToBoxExtent_InBoxExtent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEArteries.GSEArteriesSplineComponent:BindSplineToBoxExtent", BindSplineToBoxExtent_IsValid);
	}
}
