using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.GSEditorUMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/GSEditorUMG.NativeWidgetHostFilePathPicker", "GSEditorUMG", UnrealModuleType.GamePlugin)]
public class UNativeWidgetHostFilePathPicker : UNativeWidgetHost
{
	private static bool OnPathPickedEvent_IsValid;

	private static int OnPathPickedEvent_Offset;

	private FGSOnPathPicked OnPathPickedEvent_DelegateCached;

	private static bool GetFilePath_IsValid;

	private static IntPtr GetFilePath_FunctionAddress;

	private static int GetFilePath_ParamsSize;

	private static bool GetFilePath_ReturnValue_IsValid;

	private static FFieldAddress GetFilePath_ReturnValue_PropertyAddress;

	private static int GetFilePath_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/GSEditorUMG.NativeWidgetHostFilePathPicker:OnPathPickedEvent")]
	public FGSOnPathPicked OnPathPickedEvent
	{
		get
		{
			CheckDestroyed();
			if (!OnPathPickedEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSEditorUMG.NativeWidgetHostFilePathPicker:OnPathPickedEvent");
				return new FGSOnPathPicked();
			}
			if (OnPathPickedEvent_DelegateCached == null)
			{
				OnPathPickedEvent_DelegateCached = new FGSOnPathPicked();
				OnPathPickedEvent_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnPathPickedEvent_Offset));
			}
			return OnPathPickedEvent_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSEditorUMG.NativeWidgetHostFilePathPicker:GetFilePath")]
	public unsafe string GetFilePath()
	{
		CheckDestroyed();
		if (!GetFilePath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEditorUMG.NativeWidgetHostFilePathPicker:GetFilePath");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFilePath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFilePath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFilePath_FunctionAddress, intPtr, GetFilePath_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetFilePath_ReturnValue_Offset), 0, GetFilePath_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetFilePath_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UNativeWidgetHostFilePathPicker()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UNativeWidgetHostFilePathPicker)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UNativeWidgetHostFilePathPicker));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/GSEditorUMG.NativeWidgetHostFilePathPicker");
		OnPathPickedEvent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnPathPickedEvent");
		OnPathPickedEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnPathPickedEvent", Classes.FMulticastDelegateProperty);
		GetFilePath_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetFilePath");
		GetFilePath_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFilePath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFilePath_ReturnValue_PropertyAddress, GetFilePath_FunctionAddress, "ReturnValue");
		GetFilePath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFilePath_FunctionAddress, "ReturnValue");
		GetFilePath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFilePath_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetFilePath_IsValid = GetFilePath_FunctionAddress != IntPtr.Zero && GetFilePath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEditorUMG.NativeWidgetHostFilePathPicker:GetFilePath", GetFilePath_IsValid);
	}
}
