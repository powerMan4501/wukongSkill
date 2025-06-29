using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.VariantManagerContent;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/VariantManagerContent.Variant", "VariantManagerContent", UnrealModuleType.EnginePlugin)]
public class UVariant : UObject
{
	private static bool SwitchOn_IsValid;

	private static IntPtr SwitchOn_FunctionAddress;

	private static int SwitchOn_ParamsSize;

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

	private static bool IsActive_IsValid;

	private static IntPtr IsActive_FunctionAddress;

	private static int IsActive_ParamsSize;

	private static bool IsActive_ReturnValue_IsValid;

	private static FFieldAddress IsActive_ReturnValue_PropertyAddress;

	private static int IsActive_ReturnValue_Offset;

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

	private static bool GetNumDependencies_IsValid;

	private static IntPtr GetNumDependencies_FunctionAddress;

	private static int GetNumDependencies_ParamsSize;

	private static bool GetNumDependencies_ReturnValue_IsValid;

	private static FFieldAddress GetNumDependencies_ReturnValue_PropertyAddress;

	private static int GetNumDependencies_ReturnValue_Offset;

	private static bool GetNumActors_IsValid;

	private static IntPtr GetNumActors_FunctionAddress;

	private static int GetNumActors_ParamsSize;

	private static bool GetNumActors_ReturnValue_IsValid;

	private static FFieldAddress GetNumActors_ReturnValue_PropertyAddress;

	private static int GetNumActors_ReturnValue_Offset;

	private static bool GetDisplayText_IsValid;

	private static IntPtr GetDisplayText_FunctionAddress;

	private static int GetDisplayText_ParamsSize;

	private static bool GetDisplayText_ReturnValue_IsValid;

	private static FFieldAddress GetDisplayText_ReturnValue_PropertyAddress;

	private static int GetDisplayText_ReturnValue_Offset;

	private static bool GetDependents_IsValid;

	private static IntPtr GetDependents_FunctionAddress;

	private static int GetDependents_ParamsSize;

	private static bool GetDependents_LevelVariantSets_IsValid;

	private static FFieldAddress GetDependents_LevelVariantSets_PropertyAddress;

	private static int GetDependents_LevelVariantSets_Offset;

	private static bool GetDependents_bOnlyEnabledDependencies_IsValid;

	private static FFieldAddress GetDependents_bOnlyEnabledDependencies_PropertyAddress;

	private static int GetDependents_bOnlyEnabledDependencies_Offset;

	private static bool GetDependents_ReturnValue_IsValid;

	private static FFieldAddress GetDependents_ReturnValue_PropertyAddress;

	private static int GetDependents_ReturnValue_Offset;

	private static bool GetDependency_IsValid;

	private static IntPtr GetDependency_FunctionAddress;

	private static int GetDependency_ParamsSize;

	private static bool GetDependency_Index_IsValid;

	private static FFieldAddress GetDependency_Index_PropertyAddress;

	private static int GetDependency_Index_Offset;

	private static bool GetDependency_ReturnValue_IsValid;

	private static FFieldAddress GetDependency_ReturnValue_PropertyAddress;

	private static int GetDependency_ReturnValue_Offset;

	private static bool GetActor_IsValid;

	private static IntPtr GetActor_FunctionAddress;

	private static int GetActor_ParamsSize;

	private static bool GetActor_ActorIndex_IsValid;

	private static FFieldAddress GetActor_ActorIndex_PropertyAddress;

	private static int GetActor_ActorIndex_Offset;

	private static bool GetActor_ReturnValue_IsValid;

	private static FFieldAddress GetActor_ReturnValue_PropertyAddress;

	private static int GetActor_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/VariantManagerContent.Variant:SwitchOn")]
	public unsafe void SwitchOn()
	{
		CheckDestroyed();
		if (!SwitchOn_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.Variant:SwitchOn");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SwitchOn_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SwitchOn_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: SwitchOn_FunctionAddress, argsSize: SwitchOn_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/VariantManagerContent.Variant:SetThumbnailFromTexture")]
	public unsafe void SetThumbnailFromTexture(UTexture2D NewThumbnail)
	{
		CheckDestroyed();
		if (!SetThumbnailFromTexture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.Variant:SetThumbnailFromTexture");
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
	[UMetaPath("/Script/VariantManagerContent.Variant:SetThumbnailFromFile")]
	public unsafe void SetThumbnailFromFile(string FilePath)
	{
		CheckDestroyed();
		if (!SetThumbnailFromFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.Variant:SetThumbnailFromFile");
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
	[UMetaPath("/Script/VariantManagerContent.Variant:SetThumbnailFromEditorViewport")]
	public unsafe void SetThumbnailFromEditorViewport()
	{
		CheckDestroyed();
		if (!SetThumbnailFromEditorViewport_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.Variant:SetThumbnailFromEditorViewport");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetThumbnailFromEditorViewport_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetThumbnailFromEditorViewport_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: SetThumbnailFromEditorViewport_FunctionAddress, argsSize: SetThumbnailFromEditorViewport_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/VariantManagerContent.Variant:SetThumbnailFromCamera")]
	public unsafe void SetThumbnailFromCamera(UObject WorldContextObject, FTransform CameraTransform, float FOVDegrees = 50f, float MinZ = 50f, float Gamma = 2.2f)
	{
		CheckDestroyed();
		if (!SetThumbnailFromCamera_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.Variant:SetThumbnailFromCamera");
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
	[UMetaPath("/Script/VariantManagerContent.Variant:SetDisplayText")]
	public unsafe void SetDisplayText(FText NewDisplayText)
	{
		CheckDestroyed();
		if (!SetDisplayText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.Variant:SetDisplayText");
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

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/VariantManagerContent.Variant:IsActive")]
	public unsafe bool IsActive()
	{
		CheckDestroyed();
		if (!IsActive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.Variant:IsActive");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsActive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsActive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsActive_FunctionAddress, intPtr, IsActive_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsActive_ReturnValue_Offset), 0, IsActive_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/VariantManagerContent.Variant:GetThumbnail")]
	public unsafe UTexture2D GetThumbnail()
	{
		CheckDestroyed();
		if (!GetThumbnail_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.Variant:GetThumbnail");
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
	[UMetaPath("/Script/VariantManagerContent.Variant:GetParent")]
	public unsafe UVariantSet GetParent()
	{
		CheckDestroyed();
		if (!GetParent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.Variant:GetParent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParent_FunctionAddress, intPtr, GetParent_ParamsSize);
		return UObjectMarshaler<UVariantSet>.FromNative(IntPtr.Add(intPtr, GetParent_ReturnValue_Offset), 0, GetParent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/VariantManagerContent.Variant:GetNumDependencies")]
	public unsafe int GetNumDependencies()
	{
		CheckDestroyed();
		if (!GetNumDependencies_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.Variant:GetNumDependencies");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumDependencies_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumDependencies_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumDependencies_FunctionAddress, intPtr, GetNumDependencies_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumDependencies_ReturnValue_Offset), 0, GetNumDependencies_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/VariantManagerContent.Variant:GetNumActors")]
	public unsafe int GetNumActors()
	{
		CheckDestroyed();
		if (!GetNumActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.Variant:GetNumActors");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNumActors_FunctionAddress, intPtr, GetNumActors_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumActors_ReturnValue_Offset), 0, GetNumActors_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/VariantManagerContent.Variant:GetDisplayText")]
	public unsafe string GetDisplayText()
	{
		CheckDestroyed();
		if (!GetDisplayText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.Variant:GetDisplayText");
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

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/VariantManagerContent.Variant:GetDependents")]
	public unsafe List<UVariant> GetDependents(ULevelVariantSets LevelVariantSets, bool bOnlyEnabledDependencies)
	{
		CheckDestroyed();
		if (!GetDependents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.Variant:GetDependents");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDependents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDependents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevelVariantSets>.ToNative(IntPtr.Add(intPtr, GetDependents_LevelVariantSets_Offset), 0, GetDependents_LevelVariantSets_PropertyAddress.Address, LevelVariantSets);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetDependents_bOnlyEnabledDependencies_Offset), 0, GetDependents_bOnlyEnabledDependencies_PropertyAddress.Address, bOnlyEnabledDependencies);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDependents_FunctionAddress, intPtr, GetDependents_ParamsSize);
		List<UVariant> result = new TArrayCopyMarshaler<UVariant>(1, GetDependents_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UVariant, UObjectMarshaler<UVariant>>.FromNative, CachedMarshalingDelegates<UVariant, UObjectMarshaler<UVariant>>.ToNative).FromNative(IntPtr.Add(intPtr, GetDependents_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetDependents_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/VariantManagerContent.Variant:GetDependency")]
	public unsafe FVariantDependency GetDependency(int Index)
	{
		CheckDestroyed();
		if (!GetDependency_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.Variant:GetDependency");
			return default(FVariantDependency);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDependency_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDependency_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetDependency_Index_Offset), 0, GetDependency_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDependency_FunctionAddress, intPtr, GetDependency_ParamsSize);
		FVariantDependency result = FVariantDependency.FromNative(IntPtr.Add(intPtr, GetDependency_ReturnValue_Offset), 0, GetDependency_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetDependency_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/VariantManagerContent.Variant:GetActor")]
	public unsafe AActor GetActor(int ActorIndex)
	{
		CheckDestroyed();
		if (!GetActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/VariantManagerContent.Variant:GetActor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetActor_ActorIndex_Offset), 0, GetActor_ActorIndex_PropertyAddress.Address, ActorIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetActor_FunctionAddress, intPtr, GetActor_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, GetActor_ReturnValue_Offset), 0, GetActor_ReturnValue_PropertyAddress.Address);
	}

	static UVariant()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UVariant)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UVariant));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/VariantManagerContent.Variant");
		SwitchOn_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SwitchOn");
		SwitchOn_ParamsSize = NativeReflection.GetFunctionParamsSize(SwitchOn_FunctionAddress);
		SwitchOn_IsValid = SwitchOn_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.Variant:SwitchOn", SwitchOn_IsValid);
		SetThumbnailFromTexture_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetThumbnailFromTexture");
		SetThumbnailFromTexture_ParamsSize = NativeReflection.GetFunctionParamsSize(SetThumbnailFromTexture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetThumbnailFromTexture_NewThumbnail_PropertyAddress, SetThumbnailFromTexture_FunctionAddress, "NewThumbnail");
		SetThumbnailFromTexture_NewThumbnail_Offset = NativeReflectionCached.GetPropertyOffset(SetThumbnailFromTexture_FunctionAddress, "NewThumbnail");
		SetThumbnailFromTexture_NewThumbnail_IsValid = NativeReflectionCached.ValidatePropertyClass(SetThumbnailFromTexture_FunctionAddress, "NewThumbnail", Classes.FObjectProperty);
		SetThumbnailFromTexture_IsValid = SetThumbnailFromTexture_FunctionAddress != IntPtr.Zero && SetThumbnailFromTexture_NewThumbnail_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.Variant:SetThumbnailFromTexture", SetThumbnailFromTexture_IsValid);
		SetThumbnailFromFile_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetThumbnailFromFile");
		SetThumbnailFromFile_ParamsSize = NativeReflection.GetFunctionParamsSize(SetThumbnailFromFile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetThumbnailFromFile_FilePath_PropertyAddress, SetThumbnailFromFile_FunctionAddress, "FilePath");
		SetThumbnailFromFile_FilePath_Offset = NativeReflectionCached.GetPropertyOffset(SetThumbnailFromFile_FunctionAddress, "FilePath");
		SetThumbnailFromFile_FilePath_IsValid = NativeReflectionCached.ValidatePropertyClass(SetThumbnailFromFile_FunctionAddress, "FilePath", Classes.FStrProperty);
		SetThumbnailFromFile_IsValid = SetThumbnailFromFile_FunctionAddress != IntPtr.Zero && SetThumbnailFromFile_FilePath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.Variant:SetThumbnailFromFile", SetThumbnailFromFile_IsValid);
		SetThumbnailFromEditorViewport_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetThumbnailFromEditorViewport");
		SetThumbnailFromEditorViewport_ParamsSize = NativeReflection.GetFunctionParamsSize(SetThumbnailFromEditorViewport_FunctionAddress);
		SetThumbnailFromEditorViewport_IsValid = SetThumbnailFromEditorViewport_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.Variant:SetThumbnailFromEditorViewport", SetThumbnailFromEditorViewport_IsValid);
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
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.Variant:SetThumbnailFromCamera", SetThumbnailFromCamera_IsValid);
		SetDisplayText_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetDisplayText");
		SetDisplayText_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDisplayText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDisplayText_NewDisplayText_PropertyAddress, SetDisplayText_FunctionAddress, "NewDisplayText");
		SetDisplayText_NewDisplayText_Offset = NativeReflectionCached.GetPropertyOffset(SetDisplayText_FunctionAddress, "NewDisplayText");
		SetDisplayText_NewDisplayText_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDisplayText_FunctionAddress, "NewDisplayText", Classes.FTextProperty);
		SetDisplayText_IsValid = SetDisplayText_FunctionAddress != IntPtr.Zero && SetDisplayText_NewDisplayText_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.Variant:SetDisplayText", SetDisplayText_IsValid);
		IsActive_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsActive");
		IsActive_ParamsSize = NativeReflection.GetFunctionParamsSize(IsActive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsActive_ReturnValue_PropertyAddress, IsActive_FunctionAddress, "ReturnValue");
		IsActive_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsActive_FunctionAddress, "ReturnValue");
		IsActive_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsActive_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsActive_IsValid = IsActive_FunctionAddress != IntPtr.Zero && IsActive_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.Variant:IsActive", IsActive_IsValid);
		GetThumbnail_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetThumbnail");
		GetThumbnail_ParamsSize = NativeReflection.GetFunctionParamsSize(GetThumbnail_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetThumbnail_ReturnValue_PropertyAddress, GetThumbnail_FunctionAddress, "ReturnValue");
		GetThumbnail_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetThumbnail_FunctionAddress, "ReturnValue");
		GetThumbnail_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetThumbnail_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetThumbnail_IsValid = GetThumbnail_FunctionAddress != IntPtr.Zero && GetThumbnail_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.Variant:GetThumbnail", GetThumbnail_IsValid);
		GetParent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetParent");
		GetParent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParent_ReturnValue_PropertyAddress, GetParent_FunctionAddress, "ReturnValue");
		GetParent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParent_FunctionAddress, "ReturnValue");
		GetParent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetParent_IsValid = GetParent_FunctionAddress != IntPtr.Zero && GetParent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.Variant:GetParent", GetParent_IsValid);
		GetNumDependencies_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNumDependencies");
		GetNumDependencies_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumDependencies_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumDependencies_ReturnValue_PropertyAddress, GetNumDependencies_FunctionAddress, "ReturnValue");
		GetNumDependencies_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumDependencies_FunctionAddress, "ReturnValue");
		GetNumDependencies_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumDependencies_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumDependencies_IsValid = GetNumDependencies_FunctionAddress != IntPtr.Zero && GetNumDependencies_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.Variant:GetNumDependencies", GetNumDependencies_IsValid);
		GetNumActors_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetNumActors");
		GetNumActors_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumActors_ReturnValue_PropertyAddress, GetNumActors_FunctionAddress, "ReturnValue");
		GetNumActors_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumActors_FunctionAddress, "ReturnValue");
		GetNumActors_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumActors_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumActors_IsValid = GetNumActors_FunctionAddress != IntPtr.Zero && GetNumActors_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.Variant:GetNumActors", GetNumActors_IsValid);
		GetDisplayText_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDisplayText");
		GetDisplayText_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDisplayText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDisplayText_ReturnValue_PropertyAddress, GetDisplayText_FunctionAddress, "ReturnValue");
		GetDisplayText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDisplayText_FunctionAddress, "ReturnValue");
		GetDisplayText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDisplayText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetDisplayText_IsValid = GetDisplayText_FunctionAddress != IntPtr.Zero && GetDisplayText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.Variant:GetDisplayText", GetDisplayText_IsValid);
		GetDependents_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDependents");
		GetDependents_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDependents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDependents_LevelVariantSets_PropertyAddress, GetDependents_FunctionAddress, "LevelVariantSets");
		GetDependents_LevelVariantSets_Offset = NativeReflectionCached.GetPropertyOffset(GetDependents_FunctionAddress, "LevelVariantSets");
		GetDependents_LevelVariantSets_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDependents_FunctionAddress, "LevelVariantSets", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDependents_bOnlyEnabledDependencies_PropertyAddress, GetDependents_FunctionAddress, "bOnlyEnabledDependencies");
		GetDependents_bOnlyEnabledDependencies_Offset = NativeReflectionCached.GetPropertyOffset(GetDependents_FunctionAddress, "bOnlyEnabledDependencies");
		GetDependents_bOnlyEnabledDependencies_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDependents_FunctionAddress, "bOnlyEnabledDependencies", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDependents_ReturnValue_PropertyAddress, GetDependents_FunctionAddress, "ReturnValue");
		GetDependents_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDependents_FunctionAddress, "ReturnValue");
		GetDependents_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDependents_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetDependents_IsValid = GetDependents_FunctionAddress != IntPtr.Zero && GetDependents_LevelVariantSets_IsValid && GetDependents_bOnlyEnabledDependencies_IsValid && GetDependents_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.Variant:GetDependents", GetDependents_IsValid);
		GetDependency_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDependency");
		GetDependency_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDependency_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDependency_Index_PropertyAddress, GetDependency_FunctionAddress, "Index");
		GetDependency_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetDependency_FunctionAddress, "Index");
		GetDependency_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDependency_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDependency_ReturnValue_PropertyAddress, GetDependency_FunctionAddress, "ReturnValue");
		GetDependency_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDependency_FunctionAddress, "ReturnValue");
		GetDependency_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDependency_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetDependency_IsValid = GetDependency_FunctionAddress != IntPtr.Zero && GetDependency_Index_IsValid && GetDependency_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.Variant:GetDependency", GetDependency_IsValid);
		GetActor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetActor");
		GetActor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActor_ActorIndex_PropertyAddress, GetActor_FunctionAddress, "ActorIndex");
		GetActor_ActorIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetActor_FunctionAddress, "ActorIndex");
		GetActor_ActorIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActor_FunctionAddress, "ActorIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActor_ReturnValue_PropertyAddress, GetActor_FunctionAddress, "ReturnValue");
		GetActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActor_FunctionAddress, "ReturnValue");
		GetActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActor_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetActor_IsValid = GetActor_FunctionAddress != IntPtr.Zero && GetActor_ActorIndex_IsValid && GetActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/VariantManagerContent.Variant:GetActor", GetActor_IsValid);
	}
}
