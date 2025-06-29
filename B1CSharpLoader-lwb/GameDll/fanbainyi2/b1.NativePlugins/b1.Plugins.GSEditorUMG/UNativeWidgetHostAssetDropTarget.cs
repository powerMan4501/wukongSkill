using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.GSEditorUMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/GSEditorUMG.NativeWidgetHostAssetDropTarget", "GSEditorUMG", UnrealModuleType.GamePlugin)]
public class UNativeWidgetHostAssetDropTarget : UNativeWidgetHost
{
	private static bool OnDropTargetValueChanged_IsValid;

	private static int OnDropTargetValueChanged_Offset;

	private FOnAssetDropTargetValueChanged OnDropTargetValueChanged_DelegateCached;

	private static bool GetSelectedActor_IsValid;

	private static IntPtr GetSelectedActor_FunctionAddress;

	private static int GetSelectedActor_ParamsSize;

	private static bool GetSelectedActor_ReturnValue_IsValid;

	private static FFieldAddress GetSelectedActor_ReturnValue_PropertyAddress;

	private static int GetSelectedActor_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/GSEditorUMG.NativeWidgetHostAssetDropTarget:OnDropTargetValueChanged")]
	public FOnAssetDropTargetValueChanged OnDropTargetValueChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnDropTargetValueChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSEditorUMG.NativeWidgetHostAssetDropTarget:OnDropTargetValueChanged");
				return new FOnAssetDropTargetValueChanged();
			}
			if (OnDropTargetValueChanged_DelegateCached == null)
			{
				OnDropTargetValueChanged_DelegateCached = new FOnAssetDropTargetValueChanged();
				OnDropTargetValueChanged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnDropTargetValueChanged_Offset));
			}
			return OnDropTargetValueChanged_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/GSEditorUMG.NativeWidgetHostAssetDropTarget:GetSelectedActor")]
	public unsafe AActor GetSelectedActor()
	{
		CheckDestroyed();
		if (!GetSelectedActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSEditorUMG.NativeWidgetHostAssetDropTarget:GetSelectedActor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSelectedActor_FunctionAddress, intPtr, GetSelectedActor_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, GetSelectedActor_ReturnValue_Offset), 0, GetSelectedActor_ReturnValue_PropertyAddress.Address);
	}

	static UNativeWidgetHostAssetDropTarget()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UNativeWidgetHostAssetDropTarget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UNativeWidgetHostAssetDropTarget));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/GSEditorUMG.NativeWidgetHostAssetDropTarget");
		OnDropTargetValueChanged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnDropTargetValueChanged");
		OnDropTargetValueChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnDropTargetValueChanged", Classes.FMulticastDelegateProperty);
		GetSelectedActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSelectedActor");
		GetSelectedActor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectedActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedActor_ReturnValue_PropertyAddress, GetSelectedActor_FunctionAddress, "ReturnValue");
		GetSelectedActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedActor_FunctionAddress, "ReturnValue");
		GetSelectedActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedActor_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSelectedActor_IsValid = GetSelectedActor_FunctionAddress != IntPtr.Zero && GetSelectedActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSEditorUMG.NativeWidgetHostAssetDropTarget:GetSelectedActor", GetSelectedActor_IsValid);
	}
}
