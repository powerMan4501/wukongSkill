using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_AnimationFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_AnimationFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SaveAsset_IsValid;

	private static IntPtr SaveAsset_FunctionAddress;

	private static int SaveAsset_ParamsSize;

	private static bool SaveAsset_InAnimation_IsValid;

	private static FFieldAddress SaveAsset_InAnimation_PropertyAddress;

	private static int SaveAsset_InAnimation_Offset;

	private static bool SaveAsset_Path_IsValid;

	private static FFieldAddress SaveAsset_Path_PropertyAddress;

	private static int SaveAsset_Path_Offset;

	private static bool SaveAsset_Name_IsValid;

	private static FFieldAddress SaveAsset_Name_PropertyAddress;

	private static int SaveAsset_Name_Offset;

	private static bool SaveAsset_ReturnValue_IsValid;

	private static FFieldAddress SaveAsset_ReturnValue_PropertyAddress;

	private static int SaveAsset_ReturnValue_Offset;

	private static bool GetAnimationBindingIDByNameCS_IsValid;

	private static IntPtr GetAnimationBindingIDByNameCS_FunctionAddress;

	private static int GetAnimationBindingIDByNameCS_ParamsSize;

	private static bool GetAnimationBindingIDByNameCS_Animation_IsValid;

	private static FFieldAddress GetAnimationBindingIDByNameCS_Animation_PropertyAddress;

	private static int GetAnimationBindingIDByNameCS_Animation_Offset;

	private static bool GetAnimationBindingIDByNameCS_TargetName_IsValid;

	private static FFieldAddress GetAnimationBindingIDByNameCS_TargetName_PropertyAddress;

	private static int GetAnimationBindingIDByNameCS_TargetName_Offset;

	private static bool GetAnimationBindingIDByNameCS_ReturnValue_IsValid;

	private static FFieldAddress GetAnimationBindingIDByNameCS_ReturnValue_PropertyAddress;

	private static int GetAnimationBindingIDByNameCS_ReturnValue_Offset;

	private static bool GetAnimationBindingIDByName_IsValid;

	private static IntPtr GetAnimationBindingIDByName_FunctionAddress;

	private static int GetAnimationBindingIDByName_ParamsSize;

	private static bool GetAnimationBindingIDByName_Animation_IsValid;

	private static FFieldAddress GetAnimationBindingIDByName_Animation_PropertyAddress;

	private static int GetAnimationBindingIDByName_Animation_Offset;

	private static bool GetAnimationBindingIDByName_TargetName_IsValid;

	private static FFieldAddress GetAnimationBindingIDByName_TargetName_PropertyAddress;

	private static int GetAnimationBindingIDByName_TargetName_Offset;

	private static bool GetAnimationBindingIDByName_ReturnValue_IsValid;

	private static FFieldAddress GetAnimationBindingIDByName_ReturnValue_PropertyAddress;

	private static int GetAnimationBindingIDByName_ReturnValue_Offset;

	private static bool GetAnimationBindingIDByDisplayName_IsValid;

	private static IntPtr GetAnimationBindingIDByDisplayName_FunctionAddress;

	private static int GetAnimationBindingIDByDisplayName_ParamsSize;

	private static bool GetAnimationBindingIDByDisplayName_Animation_IsValid;

	private static FFieldAddress GetAnimationBindingIDByDisplayName_Animation_PropertyAddress;

	private static int GetAnimationBindingIDByDisplayName_Animation_Offset;

	private static bool GetAnimationBindingIDByDisplayName_TargetName_IsValid;

	private static FFieldAddress GetAnimationBindingIDByDisplayName_TargetName_PropertyAddress;

	private static int GetAnimationBindingIDByDisplayName_TargetName_Offset;

	private static bool GetAnimationBindingIDByDisplayName_ReturnValue_IsValid;

	private static FFieldAddress GetAnimationBindingIDByDisplayName_ReturnValue_PropertyAddress;

	private static int GetAnimationBindingIDByDisplayName_ReturnValue_Offset;

	private static bool DuplicateAnimation_IsValid;

	private static IntPtr DuplicateAnimation_FunctionAddress;

	private static int DuplicateAnimation_ParamsSize;

	private static bool DuplicateAnimation_InAnimation_IsValid;

	private static FFieldAddress DuplicateAnimation_InAnimation_PropertyAddress;

	private static int DuplicateAnimation_InAnimation_Offset;

	private static bool DuplicateAnimation_Outer_IsValid;

	private static FFieldAddress DuplicateAnimation_Outer_PropertyAddress;

	private static int DuplicateAnimation_Outer_Offset;

	private static bool DuplicateAnimation_Name_IsValid;

	private static FFieldAddress DuplicateAnimation_Name_PropertyAddress;

	private static int DuplicateAnimation_Name_Offset;

	private static bool DuplicateAnimation_ReturnValue_IsValid;

	private static FFieldAddress DuplicateAnimation_ReturnValue_PropertyAddress;

	private static int DuplicateAnimation_ReturnValue_Offset;

	private static bool AnimationBindPossessableObjectCS_IsValid;

	private static IntPtr AnimationBindPossessableObjectCS_FunctionAddress;

	private static int AnimationBindPossessableObjectCS_ParamsSize;

	private static bool AnimationBindPossessableObjectCS_Animation_IsValid;

	private static FFieldAddress AnimationBindPossessableObjectCS_Animation_PropertyAddress;

	private static int AnimationBindPossessableObjectCS_Animation_Offset;

	private static bool AnimationBindPossessableObjectCS_BindingID_IsValid;

	private static FFieldAddress AnimationBindPossessableObjectCS_BindingID_PropertyAddress;

	private static int AnimationBindPossessableObjectCS_BindingID_Offset;

	private static bool AnimationBindPossessableObjectCS_BindObj_IsValid;

	private static FFieldAddress AnimationBindPossessableObjectCS_BindObj_PropertyAddress;

	private static int AnimationBindPossessableObjectCS_BindObj_Offset;

	private static bool AnimationBindPossessableObjectCS_Ctx_IsValid;

	private static FFieldAddress AnimationBindPossessableObjectCS_Ctx_PropertyAddress;

	private static int AnimationBindPossessableObjectCS_Ctx_Offset;

	private static bool AnimationBindAllPossessableObject_IsValid;

	private static IntPtr AnimationBindAllPossessableObject_FunctionAddress;

	private static int AnimationBindAllPossessableObject_ParamsSize;

	private static bool AnimationBindAllPossessableObject_RootWidget_IsValid;

	private static FFieldAddress AnimationBindAllPossessableObject_RootWidget_PropertyAddress;

	private static int AnimationBindAllPossessableObject_RootWidget_Offset;

	private static bool AnimationBindAllPossessableObject_Animation_IsValid;

	private static FFieldAddress AnimationBindAllPossessableObject_Animation_PropertyAddress;

	private static int AnimationBindAllPossessableObject_Animation_Offset;

	private static bool AnimationBindAllPossessableObject_UseDisplayName_IsValid;

	private static FFieldAddress AnimationBindAllPossessableObject_UseDisplayName_PropertyAddress;

	private static int AnimationBindAllPossessableObject_UseDisplayName_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimationFuncLib:SaveAsset")]
	public unsafe static bool SaveAsset(UWidgetAnimation InAnimation, string Path, string Name)
	{
		if (!SaveAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimationFuncLib:SaveAsset");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidgetAnimation>.ToNative(IntPtr.Add(intPtr, SaveAsset_InAnimation_Offset), 0, SaveAsset_InAnimation_PropertyAddress.Address, InAnimation);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SaveAsset_Path_Offset), 0, SaveAsset_Path_PropertyAddress.Address, Path);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SaveAsset_Name_Offset), 0, SaveAsset_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SaveAsset_FunctionAddress, intPtr, SaveAsset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SaveAsset_Path_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SaveAsset_Name_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SaveAsset_ReturnValue_Offset), 0, SaveAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimationFuncLib:GetAnimationBindingIDByNameCS")]
	public unsafe static FSequenceBindingIDInCS GetAnimationBindingIDByNameCS(UWidgetAnimation Animation, FName TargetName)
	{
		if (!GetAnimationBindingIDByNameCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimationFuncLib:GetAnimationBindingIDByNameCS");
			return default(FSequenceBindingIDInCS);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimationBindingIDByNameCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimationBindingIDByNameCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidgetAnimation>.ToNative(IntPtr.Add(intPtr, GetAnimationBindingIDByNameCS_Animation_Offset), 0, GetAnimationBindingIDByNameCS_Animation_PropertyAddress.Address, Animation);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetAnimationBindingIDByNameCS_TargetName_Offset), 0, GetAnimationBindingIDByNameCS_TargetName_PropertyAddress.Address, TargetName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnimationBindingIDByNameCS_FunctionAddress, intPtr, GetAnimationBindingIDByNameCS_ParamsSize);
		return FSequenceBindingIDInCS.FromNative(IntPtr.Add(intPtr, GetAnimationBindingIDByNameCS_ReturnValue_Offset), 0, GetAnimationBindingIDByNameCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimationFuncLib:GetAnimationBindingIDByName")]
	public unsafe static FMovieSceneObjectBindingID GetAnimationBindingIDByName(UWidgetAnimation Animation, FName TargetName)
	{
		if (!GetAnimationBindingIDByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimationFuncLib:GetAnimationBindingIDByName");
			return default(FMovieSceneObjectBindingID);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimationBindingIDByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimationBindingIDByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidgetAnimation>.ToNative(IntPtr.Add(intPtr, GetAnimationBindingIDByName_Animation_Offset), 0, GetAnimationBindingIDByName_Animation_PropertyAddress.Address, Animation);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetAnimationBindingIDByName_TargetName_Offset), 0, GetAnimationBindingIDByName_TargetName_PropertyAddress.Address, TargetName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnimationBindingIDByName_FunctionAddress, intPtr, GetAnimationBindingIDByName_ParamsSize);
		return FMovieSceneObjectBindingID.FromNative(IntPtr.Add(intPtr, GetAnimationBindingIDByName_ReturnValue_Offset), 0, GetAnimationBindingIDByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimationFuncLib:GetAnimationBindingIDByDisplayName")]
	public unsafe static FMovieSceneObjectBindingID GetAnimationBindingIDByDisplayName(UWidgetAnimation Animation, FName TargetName)
	{
		if (!GetAnimationBindingIDByDisplayName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimationFuncLib:GetAnimationBindingIDByDisplayName");
			return default(FMovieSceneObjectBindingID);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAnimationBindingIDByDisplayName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAnimationBindingIDByDisplayName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidgetAnimation>.ToNative(IntPtr.Add(intPtr, GetAnimationBindingIDByDisplayName_Animation_Offset), 0, GetAnimationBindingIDByDisplayName_Animation_PropertyAddress.Address, Animation);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetAnimationBindingIDByDisplayName_TargetName_Offset), 0, GetAnimationBindingIDByDisplayName_TargetName_PropertyAddress.Address, TargetName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAnimationBindingIDByDisplayName_FunctionAddress, intPtr, GetAnimationBindingIDByDisplayName_ParamsSize);
		return FMovieSceneObjectBindingID.FromNative(IntPtr.Add(intPtr, GetAnimationBindingIDByDisplayName_ReturnValue_Offset), 0, GetAnimationBindingIDByDisplayName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimationFuncLib:DuplicateAnimation")]
	public unsafe static UWidgetAnimation DuplicateAnimation(UWidgetAnimation InAnimation, UObject Outer, FName Name)
	{
		if (!DuplicateAnimation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimationFuncLib:DuplicateAnimation");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DuplicateAnimation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DuplicateAnimation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidgetAnimation>.ToNative(IntPtr.Add(intPtr, DuplicateAnimation_InAnimation_Offset), 0, DuplicateAnimation_InAnimation_PropertyAddress.Address, InAnimation);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, DuplicateAnimation_Outer_Offset), 0, DuplicateAnimation_Outer_PropertyAddress.Address, Outer);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, DuplicateAnimation_Name_Offset), 0, DuplicateAnimation_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DuplicateAnimation_FunctionAddress, intPtr, DuplicateAnimation_ParamsSize);
		return UObjectMarshaler<UWidgetAnimation>.FromNative(IntPtr.Add(intPtr, DuplicateAnimation_ReturnValue_Offset), 0, DuplicateAnimation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimationFuncLib:AnimationBindPossessableObjectCS")]
	public unsafe static void AnimationBindPossessableObjectCS(UWidgetAnimation Animation, FSequenceBindingIDInCS BindingID, UObject BindObj, UObject Ctx)
	{
		if (!AnimationBindPossessableObjectCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimationFuncLib:AnimationBindPossessableObjectCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AnimationBindPossessableObjectCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AnimationBindPossessableObjectCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidgetAnimation>.ToNative(IntPtr.Add(intPtr, AnimationBindPossessableObjectCS_Animation_Offset), 0, AnimationBindPossessableObjectCS_Animation_PropertyAddress.Address, Animation);
		NativeReflection.InitializeValue_InContainer(AnimationBindPossessableObjectCS_BindingID_PropertyAddress.Address, intPtr);
		FSequenceBindingIDInCS.ToNative(IntPtr.Add(intPtr, AnimationBindPossessableObjectCS_BindingID_Offset), 0, AnimationBindPossessableObjectCS_BindingID_PropertyAddress.Address, BindingID);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AnimationBindPossessableObjectCS_BindObj_Offset), 0, AnimationBindPossessableObjectCS_BindObj_PropertyAddress.Address, BindObj);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AnimationBindPossessableObjectCS_Ctx_Offset), 0, AnimationBindPossessableObjectCS_Ctx_PropertyAddress.Address, Ctx);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AnimationBindPossessableObjectCS_FunctionAddress, intPtr, AnimationBindPossessableObjectCS_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AnimationFuncLib:AnimationBindAllPossessableObject")]
	public unsafe static void AnimationBindAllPossessableObject(UUserWidget RootWidget, UWidgetAnimation Animation, bool UseDisplayName)
	{
		if (!AnimationBindAllPossessableObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AnimationFuncLib:AnimationBindAllPossessableObject");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AnimationBindAllPossessableObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AnimationBindAllPossessableObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UUserWidget>.ToNative(IntPtr.Add(intPtr, AnimationBindAllPossessableObject_RootWidget_Offset), 0, AnimationBindAllPossessableObject_RootWidget_PropertyAddress.Address, RootWidget);
		UObjectMarshaler<UWidgetAnimation>.ToNative(IntPtr.Add(intPtr, AnimationBindAllPossessableObject_Animation_Offset), 0, AnimationBindAllPossessableObject_Animation_PropertyAddress.Address, Animation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AnimationBindAllPossessableObject_UseDisplayName_Offset), 0, AnimationBindAllPossessableObject_UseDisplayName_PropertyAddress.Address, UseDisplayName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AnimationBindAllPossessableObject_FunctionAddress, intPtr, AnimationBindAllPossessableObject_ParamsSize);
	}

	static UGSE_AnimationFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_AnimationFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_AnimationFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_AnimationFuncLib");
		SaveAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SaveAsset");
		SaveAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SaveAsset_InAnimation_PropertyAddress, SaveAsset_FunctionAddress, "InAnimation");
		SaveAsset_InAnimation_Offset = NativeReflectionCached.GetPropertyOffset(SaveAsset_FunctionAddress, "InAnimation");
		SaveAsset_InAnimation_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveAsset_FunctionAddress, "InAnimation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveAsset_Path_PropertyAddress, SaveAsset_FunctionAddress, "Path");
		SaveAsset_Path_Offset = NativeReflectionCached.GetPropertyOffset(SaveAsset_FunctionAddress, "Path");
		SaveAsset_Path_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveAsset_FunctionAddress, "Path", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveAsset_Name_PropertyAddress, SaveAsset_FunctionAddress, "Name");
		SaveAsset_Name_Offset = NativeReflectionCached.GetPropertyOffset(SaveAsset_FunctionAddress, "Name");
		SaveAsset_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveAsset_FunctionAddress, "Name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveAsset_ReturnValue_PropertyAddress, SaveAsset_FunctionAddress, "ReturnValue");
		SaveAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SaveAsset_FunctionAddress, "ReturnValue");
		SaveAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveAsset_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SaveAsset_IsValid = SaveAsset_FunctionAddress != IntPtr.Zero && SaveAsset_InAnimation_IsValid && SaveAsset_Path_IsValid && SaveAsset_Name_IsValid && SaveAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimationFuncLib:SaveAsset", SaveAsset_IsValid);
		GetAnimationBindingIDByNameCS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnimationBindingIDByNameCS");
		GetAnimationBindingIDByNameCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimationBindingIDByNameCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationBindingIDByNameCS_Animation_PropertyAddress, GetAnimationBindingIDByNameCS_FunctionAddress, "Animation");
		GetAnimationBindingIDByNameCS_Animation_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationBindingIDByNameCS_FunctionAddress, "Animation");
		GetAnimationBindingIDByNameCS_Animation_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationBindingIDByNameCS_FunctionAddress, "Animation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationBindingIDByNameCS_TargetName_PropertyAddress, GetAnimationBindingIDByNameCS_FunctionAddress, "TargetName");
		GetAnimationBindingIDByNameCS_TargetName_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationBindingIDByNameCS_FunctionAddress, "TargetName");
		GetAnimationBindingIDByNameCS_TargetName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationBindingIDByNameCS_FunctionAddress, "TargetName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationBindingIDByNameCS_ReturnValue_PropertyAddress, GetAnimationBindingIDByNameCS_FunctionAddress, "ReturnValue");
		GetAnimationBindingIDByNameCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationBindingIDByNameCS_FunctionAddress, "ReturnValue");
		GetAnimationBindingIDByNameCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationBindingIDByNameCS_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetAnimationBindingIDByNameCS_IsValid = GetAnimationBindingIDByNameCS_FunctionAddress != IntPtr.Zero && GetAnimationBindingIDByNameCS_Animation_IsValid && GetAnimationBindingIDByNameCS_TargetName_IsValid && GetAnimationBindingIDByNameCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimationFuncLib:GetAnimationBindingIDByNameCS", GetAnimationBindingIDByNameCS_IsValid);
		GetAnimationBindingIDByName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnimationBindingIDByName");
		GetAnimationBindingIDByName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimationBindingIDByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationBindingIDByName_Animation_PropertyAddress, GetAnimationBindingIDByName_FunctionAddress, "Animation");
		GetAnimationBindingIDByName_Animation_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationBindingIDByName_FunctionAddress, "Animation");
		GetAnimationBindingIDByName_Animation_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationBindingIDByName_FunctionAddress, "Animation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationBindingIDByName_TargetName_PropertyAddress, GetAnimationBindingIDByName_FunctionAddress, "TargetName");
		GetAnimationBindingIDByName_TargetName_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationBindingIDByName_FunctionAddress, "TargetName");
		GetAnimationBindingIDByName_TargetName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationBindingIDByName_FunctionAddress, "TargetName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationBindingIDByName_ReturnValue_PropertyAddress, GetAnimationBindingIDByName_FunctionAddress, "ReturnValue");
		GetAnimationBindingIDByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationBindingIDByName_FunctionAddress, "ReturnValue");
		GetAnimationBindingIDByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationBindingIDByName_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetAnimationBindingIDByName_IsValid = GetAnimationBindingIDByName_FunctionAddress != IntPtr.Zero && GetAnimationBindingIDByName_Animation_IsValid && GetAnimationBindingIDByName_TargetName_IsValid && GetAnimationBindingIDByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimationFuncLib:GetAnimationBindingIDByName", GetAnimationBindingIDByName_IsValid);
		GetAnimationBindingIDByDisplayName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAnimationBindingIDByDisplayName");
		GetAnimationBindingIDByDisplayName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimationBindingIDByDisplayName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationBindingIDByDisplayName_Animation_PropertyAddress, GetAnimationBindingIDByDisplayName_FunctionAddress, "Animation");
		GetAnimationBindingIDByDisplayName_Animation_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationBindingIDByDisplayName_FunctionAddress, "Animation");
		GetAnimationBindingIDByDisplayName_Animation_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationBindingIDByDisplayName_FunctionAddress, "Animation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationBindingIDByDisplayName_TargetName_PropertyAddress, GetAnimationBindingIDByDisplayName_FunctionAddress, "TargetName");
		GetAnimationBindingIDByDisplayName_TargetName_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationBindingIDByDisplayName_FunctionAddress, "TargetName");
		GetAnimationBindingIDByDisplayName_TargetName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationBindingIDByDisplayName_FunctionAddress, "TargetName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAnimationBindingIDByDisplayName_ReturnValue_PropertyAddress, GetAnimationBindingIDByDisplayName_FunctionAddress, "ReturnValue");
		GetAnimationBindingIDByDisplayName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAnimationBindingIDByDisplayName_FunctionAddress, "ReturnValue");
		GetAnimationBindingIDByDisplayName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAnimationBindingIDByDisplayName_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetAnimationBindingIDByDisplayName_IsValid = GetAnimationBindingIDByDisplayName_FunctionAddress != IntPtr.Zero && GetAnimationBindingIDByDisplayName_Animation_IsValid && GetAnimationBindingIDByDisplayName_TargetName_IsValid && GetAnimationBindingIDByDisplayName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimationFuncLib:GetAnimationBindingIDByDisplayName", GetAnimationBindingIDByDisplayName_IsValid);
		DuplicateAnimation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DuplicateAnimation");
		DuplicateAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(DuplicateAnimation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAnimation_InAnimation_PropertyAddress, DuplicateAnimation_FunctionAddress, "InAnimation");
		DuplicateAnimation_InAnimation_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAnimation_FunctionAddress, "InAnimation");
		DuplicateAnimation_InAnimation_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAnimation_FunctionAddress, "InAnimation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAnimation_Outer_PropertyAddress, DuplicateAnimation_FunctionAddress, "Outer");
		DuplicateAnimation_Outer_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAnimation_FunctionAddress, "Outer");
		DuplicateAnimation_Outer_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAnimation_FunctionAddress, "Outer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAnimation_Name_PropertyAddress, DuplicateAnimation_FunctionAddress, "Name");
		DuplicateAnimation_Name_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAnimation_FunctionAddress, "Name");
		DuplicateAnimation_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAnimation_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAnimation_ReturnValue_PropertyAddress, DuplicateAnimation_FunctionAddress, "ReturnValue");
		DuplicateAnimation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAnimation_FunctionAddress, "ReturnValue");
		DuplicateAnimation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAnimation_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		DuplicateAnimation_IsValid = DuplicateAnimation_FunctionAddress != IntPtr.Zero && DuplicateAnimation_InAnimation_IsValid && DuplicateAnimation_Outer_IsValid && DuplicateAnimation_Name_IsValid && DuplicateAnimation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimationFuncLib:DuplicateAnimation", DuplicateAnimation_IsValid);
		AnimationBindPossessableObjectCS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AnimationBindPossessableObjectCS");
		AnimationBindPossessableObjectCS_ParamsSize = NativeReflection.GetFunctionParamsSize(AnimationBindPossessableObjectCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AnimationBindPossessableObjectCS_Animation_PropertyAddress, AnimationBindPossessableObjectCS_FunctionAddress, "Animation");
		AnimationBindPossessableObjectCS_Animation_Offset = NativeReflectionCached.GetPropertyOffset(AnimationBindPossessableObjectCS_FunctionAddress, "Animation");
		AnimationBindPossessableObjectCS_Animation_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimationBindPossessableObjectCS_FunctionAddress, "Animation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimationBindPossessableObjectCS_BindingID_PropertyAddress, AnimationBindPossessableObjectCS_FunctionAddress, "BindingID");
		AnimationBindPossessableObjectCS_BindingID_Offset = NativeReflectionCached.GetPropertyOffset(AnimationBindPossessableObjectCS_FunctionAddress, "BindingID");
		AnimationBindPossessableObjectCS_BindingID_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimationBindPossessableObjectCS_FunctionAddress, "BindingID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimationBindPossessableObjectCS_BindObj_PropertyAddress, AnimationBindPossessableObjectCS_FunctionAddress, "BindObj");
		AnimationBindPossessableObjectCS_BindObj_Offset = NativeReflectionCached.GetPropertyOffset(AnimationBindPossessableObjectCS_FunctionAddress, "BindObj");
		AnimationBindPossessableObjectCS_BindObj_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimationBindPossessableObjectCS_FunctionAddress, "BindObj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimationBindPossessableObjectCS_Ctx_PropertyAddress, AnimationBindPossessableObjectCS_FunctionAddress, "Ctx");
		AnimationBindPossessableObjectCS_Ctx_Offset = NativeReflectionCached.GetPropertyOffset(AnimationBindPossessableObjectCS_FunctionAddress, "Ctx");
		AnimationBindPossessableObjectCS_Ctx_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimationBindPossessableObjectCS_FunctionAddress, "Ctx", Classes.FObjectProperty);
		AnimationBindPossessableObjectCS_IsValid = AnimationBindPossessableObjectCS_FunctionAddress != IntPtr.Zero && AnimationBindPossessableObjectCS_Animation_IsValid && AnimationBindPossessableObjectCS_BindingID_IsValid && AnimationBindPossessableObjectCS_BindObj_IsValid && AnimationBindPossessableObjectCS_Ctx_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimationFuncLib:AnimationBindPossessableObjectCS", AnimationBindPossessableObjectCS_IsValid);
		AnimationBindAllPossessableObject_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AnimationBindAllPossessableObject");
		AnimationBindAllPossessableObject_ParamsSize = NativeReflection.GetFunctionParamsSize(AnimationBindAllPossessableObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AnimationBindAllPossessableObject_RootWidget_PropertyAddress, AnimationBindAllPossessableObject_FunctionAddress, "RootWidget");
		AnimationBindAllPossessableObject_RootWidget_Offset = NativeReflectionCached.GetPropertyOffset(AnimationBindAllPossessableObject_FunctionAddress, "RootWidget");
		AnimationBindAllPossessableObject_RootWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimationBindAllPossessableObject_FunctionAddress, "RootWidget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimationBindAllPossessableObject_Animation_PropertyAddress, AnimationBindAllPossessableObject_FunctionAddress, "Animation");
		AnimationBindAllPossessableObject_Animation_Offset = NativeReflectionCached.GetPropertyOffset(AnimationBindAllPossessableObject_FunctionAddress, "Animation");
		AnimationBindAllPossessableObject_Animation_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimationBindAllPossessableObject_FunctionAddress, "Animation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AnimationBindAllPossessableObject_UseDisplayName_PropertyAddress, AnimationBindAllPossessableObject_FunctionAddress, "UseDisplayName");
		AnimationBindAllPossessableObject_UseDisplayName_Offset = NativeReflectionCached.GetPropertyOffset(AnimationBindAllPossessableObject_FunctionAddress, "UseDisplayName");
		AnimationBindAllPossessableObject_UseDisplayName_IsValid = NativeReflectionCached.ValidatePropertyClass(AnimationBindAllPossessableObject_FunctionAddress, "UseDisplayName", Classes.FBoolProperty);
		AnimationBindAllPossessableObject_IsValid = AnimationBindAllPossessableObject_FunctionAddress != IntPtr.Zero && AnimationBindAllPossessableObject_RootWidget_IsValid && AnimationBindAllPossessableObject_Animation_IsValid && AnimationBindAllPossessableObject_UseDisplayName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AnimationFuncLib:AnimationBindAllPossessableObject", AnimationBindAllPossessableObject_IsValid);
	}
}
