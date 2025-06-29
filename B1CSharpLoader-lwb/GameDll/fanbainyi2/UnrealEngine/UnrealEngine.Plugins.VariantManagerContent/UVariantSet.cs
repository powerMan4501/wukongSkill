using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.VariantManagerContent;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/VariantManagerContent.VariantSet", "VariantManagerContent", UnrealModuleType.EnginePlugin)]
public class UVariantSet : UObject
{
	private static bool SetThumbnailFromTexture_IsValid;

	private static IntPtr SetThumbnailFromTexture_FunctionAddress;

	private static int SetThumbnailFromTexture_ParamsSize;

	private static bool SetThumbnailFromTexture_NewThumbnail_IsValid;

	private static FFieldAddress SetThumbnailFromTexture_NewThumbnail_PropertyAddress;

	private static int SetThumbnailFromTexture_NewThumbnail_Offset;

	private static bool SetThumbnailFromFile_IsValid;

	private static IntPtr SetThumbnailFromFile_FunctionAddress;

	private static int SetThumbnailFromFile_ParamsSize;

	private static bool SetThumbnailFromFile_FilePath_IsValid;

	private static FFieldAddress SetThumbnailFromFile_FilePath_PropertyAddress;

	private static int SetThumbnailFromFile_FilePath_Offset;

	private static bool SetThumbnailFromEditorViewport_IsValid;

	private static IntPtr SetThumbnailFromEditorViewport_FunctionAddress;

	private static int SetThumbnailFromEditorViewport_ParamsSize;

	private static bool SetThumbnailFromCamera_IsValid;

	private static IntPtr SetThumbnailFromCamera_FunctionAddress;

	private static int SetThumbnailFromCamera_ParamsSize;

	private static bool SetThumbnailFromCamera_WorldContextObject_IsValid;

	private static FFieldAddress SetThumbnailFromCamera_WorldContextObject_PropertyAddress;

	private static int SetThumbnailFromCamera_WorldContextObject_Offset;

	private static bool SetThumbnailFromCamera_CameraTransform_IsValid;

	private static FFieldAddress SetThumbnailFromCamera_CameraTransform_PropertyAddress;

	private static int SetThumbnailFromCamera_CameraTransform_Offset;

	private static bool SetThumbnailFromCamera_FOVDegrees_IsValid;

	private static FFieldAddress SetThumbnailFromCamera_FOVDegrees_PropertyAddress;

	private static int SetThumbnailFromCamera_FOVDegrees_Offset;

	private static bool SetThumbnailFromCamera_MinZ_IsValid;

	private static FFieldAddress SetThumbnailFromCamera_MinZ_PropertyAddress;

	private static int SetThumbnailFromCamera_MinZ_Offset;

	private static bool SetThumbnailFromCamera_Gamma_IsValid;

	private static FFieldAddress SetThumbnailFromCamera_Gamma_PropertyAddress;

	private static int SetThumbnailFromCamera_Gamma_Offset;

	private static bool SetDisplayText_IsValid;

	private static IntPtr SetDisplayText_FunctionAddress;

	private static int SetDisplayText_ParamsSize;

	private static bool SetDisplayText_NewDisplayText_IsValid;

	private static FFieldAddress SetDisplayText_NewDisplayText_PropertyAddress;

	private static int SetDisplayText_NewDisplayText_Offset;

	private static bool GetVariantByName_IsValid;

	private static IntPtr GetVariantByName_FunctionAddress;

	private static int GetVariantByName_ParamsSize;

	private static bool GetVariantByName_VariantName_IsValid;

	private static FFieldAddress GetVariantByName_VariantName_PropertyAddress;

	private static int GetVariantByName_VariantName_Offset;

	private static bool GetVariantByName_ReturnValue_IsValid;

	private static FFieldAddress GetVariantByName_ReturnValue_PropertyAddress;

	private static int GetVariantByName_ReturnValue_Offset;

	private static bool GetVariant_IsValid;

	private static IntPtr GetVariant_FunctionAddress;

	private static int GetVariant_ParamsSize;

	private static bool GetVariant_VariantIndex_IsValid;

	private static FFieldAddress GetVariant_VariantIndex_PropertyAddress;

	private static int GetVariant_VariantIndex_Offset;

	private static bool GetVariant_ReturnValue_IsValid;

	private static FFieldAddress GetVariant_ReturnValue_PropertyAddress;

	private static int GetVariant_ReturnValue_Offset;

	private static bool GetThumbnail_IsValid;

	private static IntPtr GetThumbnail_FunctionAddress;

	private static int GetThumbnail_ParamsSize;

	private static bool GetThumbnail_ReturnValue_IsValid;

	private static FFieldAddress GetThumbnail_ReturnValue_PropertyAddress;

	private static int GetThumbnail_ReturnValue_Offset;

	private static bool GetParent_IsValid;

	private static IntPtr GetParent_FunctionAddress;

	private static int GetParent_ParamsSize;

	private static bool GetParent_ReturnValue_IsValid;

	private static FFieldAddress GetParent_ReturnValue_PropertyAddress;

	private static int GetParent_ReturnValue_Offset;

	private static bool GetNumVariants_IsValid;

	private static IntPtr GetNumVariants_FunctionAddress;

	private static int GetNumVariants_ParamsSize;

	private static bool GetNumVariants_ReturnValue_IsValid;

	private static FFieldAddress GetNumVariants_ReturnValue_PropertyAddress;

	private static int GetNumVariants_ReturnValue_Offset;

	private static bool GetDisplayText_IsValid;

	private static IntPtr GetDisplayText_FunctionAddress;

	private static int GetDisplayText_ParamsSize;

	private static bool GetDisplayText_ReturnValue_IsValid;

	private static FFieldAddress GetDisplayText_ReturnValue_PropertyAddress;

	private static int GetDisplayText_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/VariantManagerContent.VariantSet:SetThumbnailFromTexture")]
	public unsafe void SetThumbnailFromTexture(UTexture2D NewThumbnail)
	{
		CheckDestroyed();
		if (!SetThumbnailFromTexture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.VariantSet:SetThumbnailFromTexture");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetThumbnailFromTexture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetThumbnailFromTexture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(intPtr, SetThumbnailFromTexture_NewThumbnail_Offset), 0, SetThumbnailFromTexture_NewThumbnail_PropertyAddress.Address, NewThumbnail);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetThumbnailFromTexture_FunctionAddress, intPtr, SetThumbnailFromTexture_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/VariantManagerContent.VariantSet:SetThumbnailFromFile")]
	public unsafe void SetThumbnailFromFile(string FilePath)
	{
		CheckDestroyed();
		if (!SetThumbnailFromFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.VariantSet:SetThumbnailFromFile");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetThumbnailFromFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetThumbnailFromFile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetThumbnailFromFile_FilePath_Offset), 0, SetThumbnailFromFile_FilePath_PropertyAddress.Address, FilePath);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetThumbnailFromFile_FunctionAddress, intPtr, SetThumbnailFromFile_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetThumbnailFromFile_FilePath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/VariantManagerContent.VariantSet:SetThumbnailFromEditorViewport")]
	public unsafe void SetThumbnailFromEditorViewport()
	{
		CheckDestroyed();
		if (!SetThumbnailFromEditorViewport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.VariantSet:SetThumbnailFromEditorViewport");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetThumbnailFromEditorViewport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetThumbnailFromEditorViewport_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: SetThumbnailFromEditorViewport_FunctionAddress, argsSize: SetThumbnailFromEditorViewport_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/VariantManagerContent.VariantSet:SetThumbnailFromCamera")]
	public unsafe void SetThumbnailFromCamera(UObject WorldContextObject, FTransform CameraTransform, float FOVDegrees = 50f, float MinZ = 50f, float Gamma = 2.2f)
	{
		CheckDestroyed();
		if (!SetThumbnailFromCamera_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.VariantSet:SetThumbnailFromCamera");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetThumbnailFromCamera_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetThumbnailFromCamera_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetThumbnailFromCamera_WorldContextObject_Offset), 0, SetThumbnailFromCamera_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InitializeValue_InContainer(SetThumbnailFromCamera_CameraTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetThumbnailFromCamera_CameraTransform_Offset), 0, SetThumbnailFromCamera_CameraTransform_PropertyAddress.Address, CameraTransform);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetThumbnailFromCamera_FOVDegrees_Offset), 0, SetThumbnailFromCamera_FOVDegrees_PropertyAddress.Address, FOVDegrees);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetThumbnailFromCamera_MinZ_Offset), 0, SetThumbnailFromCamera_MinZ_PropertyAddress.Address, MinZ);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetThumbnailFromCamera_Gamma_Offset), 0, SetThumbnailFromCamera_Gamma_PropertyAddress.Address, Gamma);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetThumbnailFromCamera_FunctionAddress, intPtr, SetThumbnailFromCamera_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/VariantManagerContent.VariantSet:SetDisplayText")]
	public unsafe void SetDisplayText(FText NewDisplayText)
	{
		CheckDestroyed();
		if (!SetDisplayText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.VariantSet:SetDisplayText");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDisplayText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDisplayText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetDisplayText_NewDisplayText_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, SetDisplayText_NewDisplayText_Offset), 0, SetDisplayText_NewDisplayText_PropertyAddress.Address, NewDisplayText);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDisplayText_FunctionAddress, intPtr, SetDisplayText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetDisplayText_NewDisplayText_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/VariantManagerContent.VariantSet:GetVariantByName")]
	public unsafe UVariant GetVariantByName(string VariantName)
	{
		CheckDestroyed();
		if (!GetVariantByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.VariantSet:GetVariantByName");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVariantByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVariantByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetVariantByName_VariantName_Offset), 0, GetVariantByName_VariantName_PropertyAddress.Address, VariantName);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVariantByName_FunctionAddress, intPtr, GetVariantByName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetVariantByName_VariantName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UVariant>.FromNative(IntPtr.Add(intPtr, GetVariantByName_ReturnValue_Offset), 0, GetVariantByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/VariantManagerContent.VariantSet:GetVariant")]
	public unsafe UVariant GetVariant(int VariantIndex)
	{
		CheckDestroyed();
		if (!GetVariant_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.VariantSet:GetVariant");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVariant_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVariant_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetVariant_VariantIndex_Offset), 0, GetVariant_VariantIndex_PropertyAddress.Address, VariantIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVariant_FunctionAddress, intPtr, GetVariant_ParamsSize);
		return UObjectMarshaler<UVariant>.FromNative(IntPtr.Add(intPtr, GetVariant_ReturnValue_Offset), 0, GetVariant_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/VariantManagerContent.VariantSet:GetThumbnail")]
	public unsafe UTexture2D GetThumbnail()
	{
		CheckDestroyed();
		if (!GetThumbnail_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.VariantSet:GetThumbnail");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetThumbnail_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetThumbnail_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetThumbnail_FunctionAddress, intPtr, GetThumbnail_ParamsSize);
		return UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(intPtr, GetThumbnail_ReturnValue_Offset), 0, GetThumbnail_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/VariantManagerContent.VariantSet:GetParent")]
	public unsafe ULevelVariantSets GetParent()
	{
		CheckDestroyed();
		if (!GetParent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.VariantSet:GetParent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParent_FunctionAddress, intPtr, GetParent_ParamsSize);
		return UObjectMarshaler<ULevelVariantSets>.FromNative(IntPtr.Add(intPtr, GetParent_ReturnValue_Offset), 0, GetParent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/VariantManagerContent.VariantSet:GetNumVariants")]
	public unsafe int GetNumVariants()
	{
		CheckDestroyed();
		if (!GetNumVariants_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.VariantSet:GetNumVariants");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumVariants_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumVariants_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumVariants_FunctionAddress, intPtr, GetNumVariants_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumVariants_ReturnValue_Offset), 0, GetNumVariants_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/VariantManagerContent.VariantSet:GetDisplayText")]
	public unsafe string GetDisplayText()
	{
		CheckDestroyed();
		if (!GetDisplayText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.VariantSet:GetDisplayText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDisplayText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDisplayText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDisplayText_FunctionAddress, intPtr, GetDisplayText_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetDisplayText_ReturnValue_Offset), 0, GetDisplayText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetDisplayText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UVariantSet()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UVariantSet)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UVariantSet));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/VariantManagerContent.VariantSet");
		SetThumbnailFromTexture_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetThumbnailFromTexture");
		SetThumbnailFromTexture_ParamsSize = NativeReflection.GetFunctionParamsSize(SetThumbnailFromTexture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetThumbnailFromTexture_NewThumbnail_PropertyAddress, SetThumbnailFromTexture_FunctionAddress, "NewThumbnail");
		SetThumbnailFromTexture_NewThumbnail_Offset = NativeReflectionCached.GetPropertyOffset(SetThumbnailFromTexture_FunctionAddress, "NewThumbnail");
		SetThumbnailFromTexture_NewThumbnail_IsValid = NativeReflectionCached.ValidatePropertyClass(SetThumbnailFromTexture_FunctionAddress, "NewThumbnail", Classes.FObjectProperty);
		SetThumbnailFromTexture_IsValid = SetThumbnailFromTexture_FunctionAddress != IntPtr.Zero && SetThumbnailFromTexture_NewThumbnail_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.VariantSet:SetThumbnailFromTexture", SetThumbnailFromTexture_IsValid);
		SetThumbnailFromFile_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetThumbnailFromFile");
		SetThumbnailFromFile_ParamsSize = NativeReflection.GetFunctionParamsSize(SetThumbnailFromFile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetThumbnailFromFile_FilePath_PropertyAddress, SetThumbnailFromFile_FunctionAddress, "FilePath");
		SetThumbnailFromFile_FilePath_Offset = NativeReflectionCached.GetPropertyOffset(SetThumbnailFromFile_FunctionAddress, "FilePath");
		SetThumbnailFromFile_FilePath_IsValid = NativeReflectionCached.ValidatePropertyClass(SetThumbnailFromFile_FunctionAddress, "FilePath", Classes.FStrProperty);
		SetThumbnailFromFile_IsValid = SetThumbnailFromFile_FunctionAddress != IntPtr.Zero && SetThumbnailFromFile_FilePath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.VariantSet:SetThumbnailFromFile", SetThumbnailFromFile_IsValid);
		SetThumbnailFromEditorViewport_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetThumbnailFromEditorViewport");
		SetThumbnailFromEditorViewport_ParamsSize = NativeReflection.GetFunctionParamsSize(SetThumbnailFromEditorViewport_FunctionAddress);
		SetThumbnailFromEditorViewport_IsValid = SetThumbnailFromEditorViewport_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.VariantSet:SetThumbnailFromEditorViewport", SetThumbnailFromEditorViewport_IsValid);
		SetThumbnailFromCamera_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetThumbnailFromCamera");
		SetThumbnailFromCamera_ParamsSize = NativeReflection.GetFunctionParamsSize(SetThumbnailFromCamera_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetThumbnailFromCamera_WorldContextObject_PropertyAddress, SetThumbnailFromCamera_FunctionAddress, "WorldContextObject");
		SetThumbnailFromCamera_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(SetThumbnailFromCamera_FunctionAddress, "WorldContextObject");
		SetThumbnailFromCamera_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SetThumbnailFromCamera_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetThumbnailFromCamera_CameraTransform_PropertyAddress, SetThumbnailFromCamera_FunctionAddress, "CameraTransform");
		SetThumbnailFromCamera_CameraTransform_Offset = NativeReflectionCached.GetPropertyOffset(SetThumbnailFromCamera_FunctionAddress, "CameraTransform");
		SetThumbnailFromCamera_CameraTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetThumbnailFromCamera_FunctionAddress, "CameraTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetThumbnailFromCamera_FOVDegrees_PropertyAddress, SetThumbnailFromCamera_FunctionAddress, "FOVDegrees");
		SetThumbnailFromCamera_FOVDegrees_Offset = NativeReflectionCached.GetPropertyOffset(SetThumbnailFromCamera_FunctionAddress, "FOVDegrees");
		SetThumbnailFromCamera_FOVDegrees_IsValid = NativeReflectionCached.ValidatePropertyClass(SetThumbnailFromCamera_FunctionAddress, "FOVDegrees", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetThumbnailFromCamera_MinZ_PropertyAddress, SetThumbnailFromCamera_FunctionAddress, "MinZ");
		SetThumbnailFromCamera_MinZ_Offset = NativeReflectionCached.GetPropertyOffset(SetThumbnailFromCamera_FunctionAddress, "MinZ");
		SetThumbnailFromCamera_MinZ_IsValid = NativeReflectionCached.ValidatePropertyClass(SetThumbnailFromCamera_FunctionAddress, "MinZ", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetThumbnailFromCamera_Gamma_PropertyAddress, SetThumbnailFromCamera_FunctionAddress, "Gamma");
		SetThumbnailFromCamera_Gamma_Offset = NativeReflectionCached.GetPropertyOffset(SetThumbnailFromCamera_FunctionAddress, "Gamma");
		SetThumbnailFromCamera_Gamma_IsValid = NativeReflectionCached.ValidatePropertyClass(SetThumbnailFromCamera_FunctionAddress, "Gamma", Classes.FFloatProperty);
		SetThumbnailFromCamera_IsValid = SetThumbnailFromCamera_FunctionAddress != IntPtr.Zero && SetThumbnailFromCamera_WorldContextObject_IsValid && SetThumbnailFromCamera_CameraTransform_IsValid && SetThumbnailFromCamera_FOVDegrees_IsValid && SetThumbnailFromCamera_MinZ_IsValid && SetThumbnailFromCamera_Gamma_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.VariantSet:SetThumbnailFromCamera", SetThumbnailFromCamera_IsValid);
		SetDisplayText_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetDisplayText");
		SetDisplayText_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDisplayText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDisplayText_NewDisplayText_PropertyAddress, SetDisplayText_FunctionAddress, "NewDisplayText");
		SetDisplayText_NewDisplayText_Offset = NativeReflectionCached.GetPropertyOffset(SetDisplayText_FunctionAddress, "NewDisplayText");
		SetDisplayText_NewDisplayText_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDisplayText_FunctionAddress, "NewDisplayText", Classes.FTextProperty);
		SetDisplayText_IsValid = SetDisplayText_FunctionAddress != IntPtr.Zero && SetDisplayText_NewDisplayText_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.VariantSet:SetDisplayText", SetDisplayText_IsValid);
		GetVariantByName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetVariantByName");
		GetVariantByName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVariantByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVariantByName_VariantName_PropertyAddress, GetVariantByName_FunctionAddress, "VariantName");
		GetVariantByName_VariantName_Offset = NativeReflectionCached.GetPropertyOffset(GetVariantByName_FunctionAddress, "VariantName");
		GetVariantByName_VariantName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVariantByName_FunctionAddress, "VariantName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVariantByName_ReturnValue_PropertyAddress, GetVariantByName_FunctionAddress, "ReturnValue");
		GetVariantByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVariantByName_FunctionAddress, "ReturnValue");
		GetVariantByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVariantByName_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetVariantByName_IsValid = GetVariantByName_FunctionAddress != IntPtr.Zero && GetVariantByName_VariantName_IsValid && GetVariantByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.VariantSet:GetVariantByName", GetVariantByName_IsValid);
		GetVariant_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetVariant");
		GetVariant_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVariant_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVariant_VariantIndex_PropertyAddress, GetVariant_FunctionAddress, "VariantIndex");
		GetVariant_VariantIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetVariant_FunctionAddress, "VariantIndex");
		GetVariant_VariantIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVariant_FunctionAddress, "VariantIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVariant_ReturnValue_PropertyAddress, GetVariant_FunctionAddress, "ReturnValue");
		GetVariant_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVariant_FunctionAddress, "ReturnValue");
		GetVariant_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVariant_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetVariant_IsValid = GetVariant_FunctionAddress != IntPtr.Zero && GetVariant_VariantIndex_IsValid && GetVariant_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.VariantSet:GetVariant", GetVariant_IsValid);
		GetThumbnail_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetThumbnail");
		GetThumbnail_ParamsSize = NativeReflection.GetFunctionParamsSize(GetThumbnail_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetThumbnail_ReturnValue_PropertyAddress, GetThumbnail_FunctionAddress, "ReturnValue");
		GetThumbnail_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetThumbnail_FunctionAddress, "ReturnValue");
		GetThumbnail_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetThumbnail_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetThumbnail_IsValid = GetThumbnail_FunctionAddress != IntPtr.Zero && GetThumbnail_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.VariantSet:GetThumbnail", GetThumbnail_IsValid);
		GetParent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetParent");
		GetParent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParent_ReturnValue_PropertyAddress, GetParent_FunctionAddress, "ReturnValue");
		GetParent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParent_FunctionAddress, "ReturnValue");
		GetParent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetParent_IsValid = GetParent_FunctionAddress != IntPtr.Zero && GetParent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.VariantSet:GetParent", GetParent_IsValid);
		GetNumVariants_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNumVariants");
		GetNumVariants_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumVariants_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumVariants_ReturnValue_PropertyAddress, GetNumVariants_FunctionAddress, "ReturnValue");
		GetNumVariants_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumVariants_FunctionAddress, "ReturnValue");
		GetNumVariants_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumVariants_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumVariants_IsValid = GetNumVariants_FunctionAddress != IntPtr.Zero && GetNumVariants_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.VariantSet:GetNumVariants", GetNumVariants_IsValid);
		GetDisplayText_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDisplayText");
		GetDisplayText_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDisplayText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDisplayText_ReturnValue_PropertyAddress, GetDisplayText_FunctionAddress, "ReturnValue");
		GetDisplayText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDisplayText_FunctionAddress, "ReturnValue");
		GetDisplayText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDisplayText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetDisplayText_IsValid = GetDisplayText_FunctionAddress != IntPtr.Zero && GetDisplayText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.VariantSet:GetDisplayText", GetDisplayText_IsValid);
	}
}
