using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.ToolMenus;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/ToolMenus.ToolMenuSectionDynamic", "ToolMenus", UnrealModuleType.Engine)]
public class UToolMenuSectionDynamic : UObject
{
	private static bool ConstructSections_IsValid;

	private IntPtr ConstructSections_InstanceFunctionAddress;

	private static IntPtr ConstructSections_FunctionAddress;

	private static int ConstructSections_ParamsSize;

	private static bool ConstructSections_Menu_IsValid;

	private static FFieldAddress ConstructSections_Menu_PropertyAddress;

	private static int ConstructSections_Menu_Offset;

	private static bool ConstructSections_Context_IsValid;

	private static FFieldAddress ConstructSections_Context_PropertyAddress;

	private static int ConstructSections_Context_Offset;

	[UFunction(Flags = 138545152u)]
	[UMetaPath("/Script/ToolMenus.ToolMenuSectionDynamic:ConstructSections")]
	public unsafe void ConstructSections(UToolMenu Menu, FToolMenuContext Context)
	{
		CheckDestroyed();
		if (!ConstructSections_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ToolMenus.ToolMenuSectionDynamic:ConstructSections");
			return;
		}
		if (ConstructSections_InstanceFunctionAddress == IntPtr.Zero)
		{
			ConstructSections_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ConstructSections");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConstructSections_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConstructSections_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UToolMenu>.ToNative(IntPtr.Add(intPtr, ConstructSections_Menu_Offset), 0, ConstructSections_Menu_PropertyAddress.Address, Menu);
		NativeReflection.InitializeValue_InContainer(ConstructSections_Context_PropertyAddress.Address, intPtr);
		FToolMenuContext.ToNative(IntPtr.Add(intPtr, ConstructSections_Context_Offset), 0, ConstructSections_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeFunctionOptimized(base.Address, ConstructSections_InstanceFunctionAddress, intPtr, ConstructSections_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConstructSections_Context_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void ConstructSections_Implementation(UToolMenu Menu, FToolMenuContext Context)
	{
		CheckDestroyed();
		if (!ConstructSections_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ToolMenus.ToolMenuSectionDynamic:ConstructSections");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConstructSections_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConstructSections_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UToolMenu>.ToNative(IntPtr.Add(intPtr, ConstructSections_Menu_Offset), 0, ConstructSections_Menu_PropertyAddress.Address, Menu);
		NativeReflection.InitializeValue_InContainer(ConstructSections_Context_PropertyAddress.Address, intPtr);
		FToolMenuContext.ToNative(IntPtr.Add(intPtr, ConstructSections_Context_Offset), 0, ConstructSections_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeFunctionOptimized(base.Address, ConstructSections_FunctionAddress, intPtr, ConstructSections_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConstructSections_Context_PropertyAddress.Address, intPtr);
	}

	static UToolMenuSectionDynamic()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UToolMenuSectionDynamic)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UToolMenuSectionDynamic));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/ToolMenus.ToolMenuSectionDynamic");
		ConstructSections_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ConstructSections");
		ConstructSections_ParamsSize = NativeReflection.GetFunctionParamsSize(ConstructSections_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConstructSections_Menu_PropertyAddress, ConstructSections_FunctionAddress, "Menu");
		ConstructSections_Menu_Offset = NativeReflectionCached.GetPropertyOffset(ConstructSections_FunctionAddress, "Menu");
		ConstructSections_Menu_IsValid = NativeReflectionCached.ValidatePropertyClass(ConstructSections_FunctionAddress, "Menu", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ConstructSections_Context_PropertyAddress, ConstructSections_FunctionAddress, "Context");
		ConstructSections_Context_Offset = NativeReflectionCached.GetPropertyOffset(ConstructSections_FunctionAddress, "Context");
		ConstructSections_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(ConstructSections_FunctionAddress, "Context", Classes.FStructProperty);
		ConstructSections_IsValid = ConstructSections_FunctionAddress != IntPtr.Zero && ConstructSections_Menu_IsValid && ConstructSections_Context_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ToolMenus.ToolMenuSectionDynamic:ConstructSections", ConstructSections_IsValid);
	}
}
