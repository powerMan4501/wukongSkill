using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.ContentBrowserData;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/ContentBrowserData.ContentBrowserItemLibrary", "ContentBrowserData", UnrealModuleType.Engine)]
public class UContentBrowserItemLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool IsFolder_IsValid;

	private static IntPtr IsFolder_FunctionAddress;

	private static int IsFolder_ParamsSize;

	private static bool IsFolder_Item_IsValid;

	private static FFieldAddress IsFolder_Item_PropertyAddress;

	private static int IsFolder_Item_Offset;

	private static bool IsFolder_ReturnValue_IsValid;

	private static FFieldAddress IsFolder_ReturnValue_PropertyAddress;

	private static int IsFolder_ReturnValue_Offset;

	private static bool IsFile_IsValid;

	private static IntPtr IsFile_FunctionAddress;

	private static int IsFile_ParamsSize;

	private static bool IsFile_Item_IsValid;

	private static FFieldAddress IsFile_Item_PropertyAddress;

	private static int IsFile_Item_Offset;

	private static bool IsFile_ReturnValue_IsValid;

	private static FFieldAddress IsFile_ReturnValue_PropertyAddress;

	private static int IsFile_ReturnValue_Offset;

	private static bool GetVirtualPath_IsValid;

	private static IntPtr GetVirtualPath_FunctionAddress;

	private static int GetVirtualPath_ParamsSize;

	private static bool GetVirtualPath_Item_IsValid;

	private static FFieldAddress GetVirtualPath_Item_PropertyAddress;

	private static int GetVirtualPath_Item_Offset;

	private static bool GetVirtualPath_ReturnValue_IsValid;

	private static FFieldAddress GetVirtualPath_ReturnValue_PropertyAddress;

	private static int GetVirtualPath_ReturnValue_Offset;

	private static bool GetDisplayName_IsValid;

	private static IntPtr GetDisplayName_FunctionAddress;

	private static int GetDisplayName_ParamsSize;

	private static bool GetDisplayName_Item_IsValid;

	private static FFieldAddress GetDisplayName_Item_PropertyAddress;

	private static int GetDisplayName_Item_Offset;

	private static bool GetDisplayName_ReturnValue_IsValid;

	private static FFieldAddress GetDisplayName_ReturnValue_PropertyAddress;

	private static int GetDisplayName_ReturnValue_Offset;

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/ContentBrowserData.ContentBrowserItemLibrary:IsFolder")]
	public unsafe static bool IsFolder(FContentBrowserItem Item)
	{
		if (!IsFolder_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ContentBrowserData.ContentBrowserItemLibrary:IsFolder");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsFolder_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsFolder_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsFolder_Item_PropertyAddress.Address, intPtr);
		FContentBrowserItem.ToNative(IntPtr.Add(intPtr, IsFolder_Item_Offset), 0, IsFolder_Item_PropertyAddress.Address, Item);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsFolder_FunctionAddress, intPtr, IsFolder_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsFolder_Item_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsFolder_ReturnValue_Offset), 0, IsFolder_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/ContentBrowserData.ContentBrowserItemLibrary:IsFile")]
	public unsafe static bool IsFile(FContentBrowserItem Item)
	{
		if (!IsFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ContentBrowserData.ContentBrowserItemLibrary:IsFile");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsFile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsFile_Item_PropertyAddress.Address, intPtr);
		FContentBrowserItem.ToNative(IntPtr.Add(intPtr, IsFile_Item_Offset), 0, IsFile_Item_PropertyAddress.Address, Item);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsFile_FunctionAddress, intPtr, IsFile_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsFile_Item_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsFile_ReturnValue_Offset), 0, IsFile_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/ContentBrowserData.ContentBrowserItemLibrary:GetVirtualPath")]
	public unsafe static FName GetVirtualPath(FContentBrowserItem Item)
	{
		if (!GetVirtualPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ContentBrowserData.ContentBrowserItemLibrary:GetVirtualPath");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVirtualPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVirtualPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetVirtualPath_Item_PropertyAddress.Address, intPtr);
		FContentBrowserItem.ToNative(IntPtr.Add(intPtr, GetVirtualPath_Item_Offset), 0, GetVirtualPath_Item_PropertyAddress.Address, Item);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetVirtualPath_FunctionAddress, intPtr, GetVirtualPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetVirtualPath_Item_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetVirtualPath_ReturnValue_Offset), 0, GetVirtualPath_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/ContentBrowserData.ContentBrowserItemLibrary:GetDisplayName")]
	public unsafe static string GetDisplayName(FContentBrowserItem Item)
	{
		if (!GetDisplayName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ContentBrowserData.ContentBrowserItemLibrary:GetDisplayName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDisplayName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDisplayName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetDisplayName_Item_PropertyAddress.Address, intPtr);
		FContentBrowserItem.ToNative(IntPtr.Add(intPtr, GetDisplayName_Item_Offset), 0, GetDisplayName_Item_PropertyAddress.Address, Item);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDisplayName_FunctionAddress, intPtr, GetDisplayName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetDisplayName_Item_PropertyAddress.Address, intPtr);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetDisplayName_ReturnValue_Offset), 0, GetDisplayName_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetDisplayName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UContentBrowserItemLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UContentBrowserItemLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UContentBrowserItemLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/ContentBrowserData.ContentBrowserItemLibrary");
		IsFolder_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsFolder");
		IsFolder_ParamsSize = NativeReflection.GetFunctionParamsSize(IsFolder_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsFolder_Item_PropertyAddress, IsFolder_FunctionAddress, "Item");
		IsFolder_Item_Offset = NativeReflectionCached.GetPropertyOffset(IsFolder_FunctionAddress, "Item");
		IsFolder_Item_IsValid = NativeReflectionCached.ValidatePropertyClass(IsFolder_FunctionAddress, "Item", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsFolder_ReturnValue_PropertyAddress, IsFolder_FunctionAddress, "ReturnValue");
		IsFolder_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsFolder_FunctionAddress, "ReturnValue");
		IsFolder_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsFolder_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsFolder_IsValid = IsFolder_FunctionAddress != IntPtr.Zero && IsFolder_Item_IsValid && IsFolder_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ContentBrowserData.ContentBrowserItemLibrary:IsFolder", IsFolder_IsValid);
		IsFile_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsFile");
		IsFile_ParamsSize = NativeReflection.GetFunctionParamsSize(IsFile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsFile_Item_PropertyAddress, IsFile_FunctionAddress, "Item");
		IsFile_Item_Offset = NativeReflectionCached.GetPropertyOffset(IsFile_FunctionAddress, "Item");
		IsFile_Item_IsValid = NativeReflectionCached.ValidatePropertyClass(IsFile_FunctionAddress, "Item", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsFile_ReturnValue_PropertyAddress, IsFile_FunctionAddress, "ReturnValue");
		IsFile_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsFile_FunctionAddress, "ReturnValue");
		IsFile_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsFile_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsFile_IsValid = IsFile_FunctionAddress != IntPtr.Zero && IsFile_Item_IsValid && IsFile_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ContentBrowserData.ContentBrowserItemLibrary:IsFile", IsFile_IsValid);
		GetVirtualPath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetVirtualPath");
		GetVirtualPath_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVirtualPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVirtualPath_Item_PropertyAddress, GetVirtualPath_FunctionAddress, "Item");
		GetVirtualPath_Item_Offset = NativeReflectionCached.GetPropertyOffset(GetVirtualPath_FunctionAddress, "Item");
		GetVirtualPath_Item_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVirtualPath_FunctionAddress, "Item", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVirtualPath_ReturnValue_PropertyAddress, GetVirtualPath_FunctionAddress, "ReturnValue");
		GetVirtualPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVirtualPath_FunctionAddress, "ReturnValue");
		GetVirtualPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVirtualPath_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetVirtualPath_IsValid = GetVirtualPath_FunctionAddress != IntPtr.Zero && GetVirtualPath_Item_IsValid && GetVirtualPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ContentBrowserData.ContentBrowserItemLibrary:GetVirtualPath", GetVirtualPath_IsValid);
		GetDisplayName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDisplayName");
		GetDisplayName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDisplayName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDisplayName_Item_PropertyAddress, GetDisplayName_FunctionAddress, "Item");
		GetDisplayName_Item_Offset = NativeReflectionCached.GetPropertyOffset(GetDisplayName_FunctionAddress, "Item");
		GetDisplayName_Item_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDisplayName_FunctionAddress, "Item", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDisplayName_ReturnValue_PropertyAddress, GetDisplayName_FunctionAddress, "ReturnValue");
		GetDisplayName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDisplayName_FunctionAddress, "ReturnValue");
		GetDisplayName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDisplayName_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetDisplayName_IsValid = GetDisplayName_FunctionAddress != IntPtr.Zero && GetDisplayName_Item_IsValid && GetDisplayName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ContentBrowserData.ContentBrowserItemLibrary:GetDisplayName", GetDisplayName_IsValid);
	}
}
