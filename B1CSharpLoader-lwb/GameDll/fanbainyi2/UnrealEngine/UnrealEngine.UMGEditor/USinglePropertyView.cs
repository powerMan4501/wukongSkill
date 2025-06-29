using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMGEditor;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMGEditor.SinglePropertyView", "UMGEditor", UnrealModuleType.Engine)]
public class USinglePropertyView : UPropertyViewBase
{
	private static bool SetPropertyName_IsValid;

	private static IntPtr SetPropertyName_FunctionAddress;

	private static int SetPropertyName_ParamsSize;

	private static bool SetPropertyName_NewPropertyName_IsValid;

	private static FFieldAddress SetPropertyName_NewPropertyName_PropertyAddress;

	private static int SetPropertyName_NewPropertyName_Offset;

	private static bool SetNameOverride_IsValid;

	private static IntPtr SetNameOverride_FunctionAddress;

	private static int SetNameOverride_ParamsSize;

	private static bool SetNameOverride_NewPropertyName_IsValid;

	private static FFieldAddress SetNameOverride_NewPropertyName_PropertyAddress;

	private static int SetNameOverride_NewPropertyName_Offset;

	private static bool GetPropertyName_IsValid;

	private static IntPtr GetPropertyName_FunctionAddress;

	private static int GetPropertyName_ParamsSize;

	private static bool GetPropertyName_ReturnValue_IsValid;

	private static FFieldAddress GetPropertyName_ReturnValue_PropertyAddress;

	private static int GetPropertyName_ReturnValue_Offset;

	private static bool GetNameOverride_IsValid;

	private static IntPtr GetNameOverride_FunctionAddress;

	private static int GetNameOverride_ParamsSize;

	private static bool GetNameOverride_ReturnValue_IsValid;

	private static FFieldAddress GetNameOverride_ReturnValue_PropertyAddress;

	private static int GetNameOverride_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMGEditor.SinglePropertyView:SetPropertyName")]
	public unsafe void SetPropertyName(FName NewPropertyName)
	{
		CheckDestroyed();
		if (!SetPropertyName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMGEditor.SinglePropertyView:SetPropertyName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPropertyName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPropertyName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetPropertyName_NewPropertyName_Offset), 0, SetPropertyName_NewPropertyName_PropertyAddress.Address, NewPropertyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPropertyName_FunctionAddress, intPtr, SetPropertyName_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMGEditor.SinglePropertyView:SetNameOverride")]
	public unsafe void SetNameOverride(FText NewPropertyName)
	{
		CheckDestroyed();
		if (!SetNameOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMGEditor.SinglePropertyView:SetNameOverride");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNameOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNameOverride_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetNameOverride_NewPropertyName_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, SetNameOverride_NewPropertyName_Offset), 0, SetNameOverride_NewPropertyName_PropertyAddress.Address, NewPropertyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNameOverride_FunctionAddress, intPtr, SetNameOverride_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetNameOverride_NewPropertyName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMGEditor.SinglePropertyView:GetPropertyName")]
	public unsafe FName GetPropertyName()
	{
		CheckDestroyed();
		if (!GetPropertyName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMGEditor.SinglePropertyView:GetPropertyName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPropertyName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPropertyName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPropertyName_FunctionAddress, intPtr, GetPropertyName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetPropertyName_ReturnValue_Offset), 0, GetPropertyName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMGEditor.SinglePropertyView:GetNameOverride")]
	public unsafe string GetNameOverride()
	{
		CheckDestroyed();
		if (!GetNameOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMGEditor.SinglePropertyView:GetNameOverride");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNameOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNameOverride_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNameOverride_FunctionAddress, intPtr, GetNameOverride_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetNameOverride_ReturnValue_Offset), 0, GetNameOverride_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetNameOverride_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static USinglePropertyView()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USinglePropertyView)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USinglePropertyView));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/UMGEditor.SinglePropertyView");
		SetPropertyName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetPropertyName");
		SetPropertyName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPropertyName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPropertyName_NewPropertyName_PropertyAddress, SetPropertyName_FunctionAddress, "NewPropertyName");
		SetPropertyName_NewPropertyName_Offset = NativeReflectionCached.GetPropertyOffset(SetPropertyName_FunctionAddress, "NewPropertyName");
		SetPropertyName_NewPropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPropertyName_FunctionAddress, "NewPropertyName", Classes.FNameProperty);
		SetPropertyName_IsValid = SetPropertyName_FunctionAddress != IntPtr.Zero && SetPropertyName_NewPropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMGEditor.SinglePropertyView:SetPropertyName", SetPropertyName_IsValid);
		SetNameOverride_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetNameOverride");
		SetNameOverride_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNameOverride_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNameOverride_NewPropertyName_PropertyAddress, SetNameOverride_FunctionAddress, "NewPropertyName");
		SetNameOverride_NewPropertyName_Offset = NativeReflectionCached.GetPropertyOffset(SetNameOverride_FunctionAddress, "NewPropertyName");
		SetNameOverride_NewPropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNameOverride_FunctionAddress, "NewPropertyName", Classes.FTextProperty);
		SetNameOverride_IsValid = SetNameOverride_FunctionAddress != IntPtr.Zero && SetNameOverride_NewPropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMGEditor.SinglePropertyView:SetNameOverride", SetNameOverride_IsValid);
		GetPropertyName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPropertyName");
		GetPropertyName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPropertyName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPropertyName_ReturnValue_PropertyAddress, GetPropertyName_FunctionAddress, "ReturnValue");
		GetPropertyName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPropertyName_FunctionAddress, "ReturnValue");
		GetPropertyName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPropertyName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetPropertyName_IsValid = GetPropertyName_FunctionAddress != IntPtr.Zero && GetPropertyName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMGEditor.SinglePropertyView:GetPropertyName", GetPropertyName_IsValid);
		GetNameOverride_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNameOverride");
		GetNameOverride_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNameOverride_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNameOverride_ReturnValue_PropertyAddress, GetNameOverride_FunctionAddress, "ReturnValue");
		GetNameOverride_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNameOverride_FunctionAddress, "ReturnValue");
		GetNameOverride_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNameOverride_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetNameOverride_IsValid = GetNameOverride_FunctionAddress != IntPtr.Zero && GetNameOverride_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMGEditor.SinglePropertyView:GetNameOverride", GetNameOverride_IsValid);
	}
}
