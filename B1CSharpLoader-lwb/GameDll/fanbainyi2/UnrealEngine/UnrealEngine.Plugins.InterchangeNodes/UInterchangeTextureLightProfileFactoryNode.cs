using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangeNodes;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/InterchangeNodes.InterchangeTextureLightProfileFactoryNode", "InterchangeNodes", UnrealModuleType.EnginePlugin)]
public class UInterchangeTextureLightProfileFactoryNode : UInterchangeTextureFactoryNode
{
	private static bool SetCustomTextureMultiplier_IsValid;

	private static IntPtr SetCustomTextureMultiplier_FunctionAddress;

	private static int SetCustomTextureMultiplier_ParamsSize;

	private static bool SetCustomTextureMultiplier_AttributeValue_IsValid;

	private static FFieldAddress SetCustomTextureMultiplier_AttributeValue_PropertyAddress;

	private static int SetCustomTextureMultiplier_AttributeValue_Offset;

	private static bool SetCustomTextureMultiplier_bAddApplyDelegate_IsValid;

	private static FFieldAddress SetCustomTextureMultiplier_bAddApplyDelegate_PropertyAddress;

	private static int SetCustomTextureMultiplier_bAddApplyDelegate_Offset;

	private static bool SetCustomTextureMultiplier_ReturnValue_IsValid;

	private static FFieldAddress SetCustomTextureMultiplier_ReturnValue_PropertyAddress;

	private static int SetCustomTextureMultiplier_ReturnValue_Offset;

	private static bool SetCustomBrightness_IsValid;

	private static IntPtr SetCustomBrightness_FunctionAddress;

	private static int SetCustomBrightness_ParamsSize;

	private static bool SetCustomBrightness_AttributeValue_IsValid;

	private static FFieldAddress SetCustomBrightness_AttributeValue_PropertyAddress;

	private static int SetCustomBrightness_AttributeValue_Offset;

	private static bool SetCustomBrightness_bAddApplyDelegate_IsValid;

	private static FFieldAddress SetCustomBrightness_bAddApplyDelegate_PropertyAddress;

	private static int SetCustomBrightness_bAddApplyDelegate_Offset;

	private static bool SetCustomBrightness_ReturnValue_IsValid;

	private static FFieldAddress SetCustomBrightness_ReturnValue_PropertyAddress;

	private static int SetCustomBrightness_ReturnValue_Offset;

	private static bool GetCustomTextureMultiplier_IsValid;

	private static IntPtr GetCustomTextureMultiplier_FunctionAddress;

	private static int GetCustomTextureMultiplier_ParamsSize;

	private static bool GetCustomTextureMultiplier_AttributeValue_IsValid;

	private static FFieldAddress GetCustomTextureMultiplier_AttributeValue_PropertyAddress;

	private static int GetCustomTextureMultiplier_AttributeValue_Offset;

	private static bool GetCustomTextureMultiplier_ReturnValue_IsValid;

	private static FFieldAddress GetCustomTextureMultiplier_ReturnValue_PropertyAddress;

	private static int GetCustomTextureMultiplier_ReturnValue_Offset;

	private static bool GetCustomBrightness_IsValid;

	private static IntPtr GetCustomBrightness_FunctionAddress;

	private static int GetCustomBrightness_ParamsSize;

	private static bool GetCustomBrightness_AttributeValue_IsValid;

	private static FFieldAddress GetCustomBrightness_AttributeValue_PropertyAddress;

	private static int GetCustomBrightness_AttributeValue_Offset;

	private static bool GetCustomBrightness_ReturnValue_IsValid;

	private static FFieldAddress GetCustomBrightness_ReturnValue_PropertyAddress;

	private static int GetCustomBrightness_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeTextureLightProfileFactoryNode:SetCustomTextureMultiplier")]
	public unsafe bool SetCustomTextureMultiplier(float AttributeValue, bool bAddApplyDelegate = true)
	{
		CheckDestroyed();
		if (!SetCustomTextureMultiplier_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeTextureLightProfileFactoryNode:SetCustomTextureMultiplier");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomTextureMultiplier_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomTextureMultiplier_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetCustomTextureMultiplier_AttributeValue_Offset), 0, SetCustomTextureMultiplier_AttributeValue_PropertyAddress.Address, AttributeValue);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCustomTextureMultiplier_bAddApplyDelegate_Offset), 0, SetCustomTextureMultiplier_bAddApplyDelegate_PropertyAddress.Address, bAddApplyDelegate);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomTextureMultiplier_FunctionAddress, intPtr, SetCustomTextureMultiplier_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomTextureMultiplier_ReturnValue_Offset), 0, SetCustomTextureMultiplier_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeTextureLightProfileFactoryNode:SetCustomBrightness")]
	public unsafe bool SetCustomBrightness(float AttributeValue, bool bAddApplyDelegate = true)
	{
		CheckDestroyed();
		if (!SetCustomBrightness_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeTextureLightProfileFactoryNode:SetCustomBrightness");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomBrightness_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomBrightness_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetCustomBrightness_AttributeValue_Offset), 0, SetCustomBrightness_AttributeValue_PropertyAddress.Address, AttributeValue);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCustomBrightness_bAddApplyDelegate_Offset), 0, SetCustomBrightness_bAddApplyDelegate_PropertyAddress.Address, bAddApplyDelegate);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomBrightness_FunctionAddress, intPtr, SetCustomBrightness_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetCustomBrightness_ReturnValue_Offset), 0, SetCustomBrightness_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeTextureLightProfileFactoryNode:GetCustomTextureMultiplier")]
	public unsafe bool GetCustomTextureMultiplier(out float AttributeValue)
	{
		CheckDestroyed();
		if (!GetCustomTextureMultiplier_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeTextureLightProfileFactoryNode:GetCustomTextureMultiplier");
			AttributeValue = 0f;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomTextureMultiplier_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomTextureMultiplier_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomTextureMultiplier_FunctionAddress, intPtr, GetCustomTextureMultiplier_ParamsSize);
		AttributeValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetCustomTextureMultiplier_AttributeValue_Offset), 0, GetCustomTextureMultiplier_AttributeValue_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomTextureMultiplier_ReturnValue_Offset), 0, GetCustomTextureMultiplier_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/InterchangeNodes.InterchangeTextureLightProfileFactoryNode:GetCustomBrightness")]
	public unsafe bool GetCustomBrightness(out float AttributeValue)
	{
		CheckDestroyed();
		if (!GetCustomBrightness_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/InterchangeNodes.InterchangeTextureLightProfileFactoryNode:GetCustomBrightness");
			AttributeValue = 0f;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCustomBrightness_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCustomBrightness_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCustomBrightness_FunctionAddress, intPtr, GetCustomBrightness_ParamsSize);
		AttributeValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetCustomBrightness_AttributeValue_Offset), 0, GetCustomBrightness_AttributeValue_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCustomBrightness_ReturnValue_Offset), 0, GetCustomBrightness_ReturnValue_PropertyAddress.Address);
	}

	static UInterchangeTextureLightProfileFactoryNode()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInterchangeTextureLightProfileFactoryNode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInterchangeTextureLightProfileFactoryNode));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/InterchangeNodes.InterchangeTextureLightProfileFactoryNode");
		SetCustomTextureMultiplier_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomTextureMultiplier");
		SetCustomTextureMultiplier_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomTextureMultiplier_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomTextureMultiplier_AttributeValue_PropertyAddress, SetCustomTextureMultiplier_FunctionAddress, "AttributeValue");
		SetCustomTextureMultiplier_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomTextureMultiplier_FunctionAddress, "AttributeValue");
		SetCustomTextureMultiplier_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomTextureMultiplier_FunctionAddress, "AttributeValue", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomTextureMultiplier_bAddApplyDelegate_PropertyAddress, SetCustomTextureMultiplier_FunctionAddress, "bAddApplyDelegate");
		SetCustomTextureMultiplier_bAddApplyDelegate_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomTextureMultiplier_FunctionAddress, "bAddApplyDelegate");
		SetCustomTextureMultiplier_bAddApplyDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomTextureMultiplier_FunctionAddress, "bAddApplyDelegate", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomTextureMultiplier_ReturnValue_PropertyAddress, SetCustomTextureMultiplier_FunctionAddress, "ReturnValue");
		SetCustomTextureMultiplier_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomTextureMultiplier_FunctionAddress, "ReturnValue");
		SetCustomTextureMultiplier_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomTextureMultiplier_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomTextureMultiplier_IsValid = SetCustomTextureMultiplier_FunctionAddress != IntPtr.Zero && SetCustomTextureMultiplier_AttributeValue_IsValid && SetCustomTextureMultiplier_bAddApplyDelegate_IsValid && SetCustomTextureMultiplier_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeTextureLightProfileFactoryNode:SetCustomTextureMultiplier", SetCustomTextureMultiplier_IsValid);
		SetCustomBrightness_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCustomBrightness");
		SetCustomBrightness_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomBrightness_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomBrightness_AttributeValue_PropertyAddress, SetCustomBrightness_FunctionAddress, "AttributeValue");
		SetCustomBrightness_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomBrightness_FunctionAddress, "AttributeValue");
		SetCustomBrightness_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomBrightness_FunctionAddress, "AttributeValue", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomBrightness_bAddApplyDelegate_PropertyAddress, SetCustomBrightness_FunctionAddress, "bAddApplyDelegate");
		SetCustomBrightness_bAddApplyDelegate_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomBrightness_FunctionAddress, "bAddApplyDelegate");
		SetCustomBrightness_bAddApplyDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomBrightness_FunctionAddress, "bAddApplyDelegate", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomBrightness_ReturnValue_PropertyAddress, SetCustomBrightness_FunctionAddress, "ReturnValue");
		SetCustomBrightness_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomBrightness_FunctionAddress, "ReturnValue");
		SetCustomBrightness_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomBrightness_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetCustomBrightness_IsValid = SetCustomBrightness_FunctionAddress != IntPtr.Zero && SetCustomBrightness_AttributeValue_IsValid && SetCustomBrightness_bAddApplyDelegate_IsValid && SetCustomBrightness_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeTextureLightProfileFactoryNode:SetCustomBrightness", SetCustomBrightness_IsValid);
		GetCustomTextureMultiplier_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomTextureMultiplier");
		GetCustomTextureMultiplier_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomTextureMultiplier_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomTextureMultiplier_AttributeValue_PropertyAddress, GetCustomTextureMultiplier_FunctionAddress, "AttributeValue");
		GetCustomTextureMultiplier_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomTextureMultiplier_FunctionAddress, "AttributeValue");
		GetCustomTextureMultiplier_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomTextureMultiplier_FunctionAddress, "AttributeValue", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomTextureMultiplier_ReturnValue_PropertyAddress, GetCustomTextureMultiplier_FunctionAddress, "ReturnValue");
		GetCustomTextureMultiplier_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomTextureMultiplier_FunctionAddress, "ReturnValue");
		GetCustomTextureMultiplier_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomTextureMultiplier_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomTextureMultiplier_IsValid = GetCustomTextureMultiplier_FunctionAddress != IntPtr.Zero && GetCustomTextureMultiplier_AttributeValue_IsValid && GetCustomTextureMultiplier_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeTextureLightProfileFactoryNode:GetCustomTextureMultiplier", GetCustomTextureMultiplier_IsValid);
		GetCustomBrightness_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCustomBrightness");
		GetCustomBrightness_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCustomBrightness_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCustomBrightness_AttributeValue_PropertyAddress, GetCustomBrightness_FunctionAddress, "AttributeValue");
		GetCustomBrightness_AttributeValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomBrightness_FunctionAddress, "AttributeValue");
		GetCustomBrightness_AttributeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomBrightness_FunctionAddress, "AttributeValue", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCustomBrightness_ReturnValue_PropertyAddress, GetCustomBrightness_FunctionAddress, "ReturnValue");
		GetCustomBrightness_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCustomBrightness_FunctionAddress, "ReturnValue");
		GetCustomBrightness_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCustomBrightness_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCustomBrightness_IsValid = GetCustomBrightness_FunctionAddress != IntPtr.Zero && GetCustomBrightness_AttributeValue_IsValid && GetCustomBrightness_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/InterchangeNodes.InterchangeTextureLightProfileFactoryNode:GetCustomBrightness", GetCustomBrightness_IsValid);
	}
}
