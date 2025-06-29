using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.DonAINavigation;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/DonAINavigation.DonNavigationHelper", "DonAINavigation", UnrealModuleType.GamePlugin)]
public class UDonNavigationHelper : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool OnUpdateDynamicCollision_IsValid;

	private static IntPtr OnUpdateDynamicCollision_FunctionAddress;

	private static int OnUpdateDynamicCollision_ParamsSize;

	private static bool OnUpdateDynamicCollision_Mesh_IsValid;

	private static FFieldAddress OnUpdateDynamicCollision_Mesh_PropertyAddress;

	private static int OnUpdateDynamicCollision_Mesh_Offset;

	private static bool OnUpdateDynamicCollision_bDebug_IsValid;

	private static FFieldAddress OnUpdateDynamicCollision_bDebug_PropertyAddress;

	private static int OnUpdateDynamicCollision_bDebug_Offset;

	private static bool OnNextSegment_IsValid;

	private static IntPtr OnNextSegment_FunctionAddress;

	private static int OnNextSegment_ParamsSize;

	private static bool OnNextSegment_Object_IsValid;

	private static FFieldAddress OnNextSegment_Object_PropertyAddress;

	private static int OnNextSegment_Object_Offset;

	private static bool OnNextSegment_NextPoint_IsValid;

	private static FFieldAddress OnNextSegment_NextPoint_PropertyAddress;

	private static int OnNextSegment_NextPoint_Offset;

	private static bool OnLocomotionEnd_IsValid;

	private static IntPtr OnLocomotionEnd_FunctionAddress;

	private static int OnLocomotionEnd_ParamsSize;

	private static bool OnLocomotionEnd_Object_IsValid;

	private static FFieldAddress OnLocomotionEnd_Object_PropertyAddress;

	private static int OnLocomotionEnd_Object_Offset;

	private static bool OnLocomotionEnd_bLocomotionSuccess_IsValid;

	private static FFieldAddress OnLocomotionEnd_bLocomotionSuccess_PropertyAddress;

	private static int OnLocomotionEnd_bLocomotionSuccess_Offset;

	private static bool OnLocomotionBegin_IsValid;

	private static IntPtr OnLocomotionBegin_FunctionAddress;

	private static int OnLocomotionBegin_ParamsSize;

	private static bool OnLocomotionBegin_Object_IsValid;

	private static FFieldAddress OnLocomotionBegin_Object_PropertyAddress;

	private static int OnLocomotionBegin_Object_Offset;

	private static bool OnLocomotionAbort_IsValid;

	private static IntPtr OnLocomotionAbort_FunctionAddress;

	private static int OnLocomotionAbort_ParamsSize;

	private static bool OnLocomotionAbort_Object_IsValid;

	private static FFieldAddress OnLocomotionAbort_Object_PropertyAddress;

	private static int OnLocomotionAbort_Object_Offset;

	private static bool GetQueryDataVolumeSolutionOptimizedNum_IsValid;

	private static IntPtr GetQueryDataVolumeSolutionOptimizedNum_FunctionAddress;

	private static int GetQueryDataVolumeSolutionOptimizedNum_ParamsSize;

	private static bool GetQueryDataVolumeSolutionOptimizedNum_QueryData_IsValid;

	private static FFieldAddress GetQueryDataVolumeSolutionOptimizedNum_QueryData_PropertyAddress;

	private static int GetQueryDataVolumeSolutionOptimizedNum_QueryData_Offset;

	private static bool GetQueryDataVolumeSolutionOptimizedNum_ReturnValue_IsValid;

	private static FFieldAddress GetQueryDataVolumeSolutionOptimizedNum_ReturnValue_PropertyAddress;

	private static int GetQueryDataVolumeSolutionOptimizedNum_ReturnValue_Offset;

	private static bool GetQueryDataVolumeSolutionNum_IsValid;

	private static IntPtr GetQueryDataVolumeSolutionNum_FunctionAddress;

	private static int GetQueryDataVolumeSolutionNum_ParamsSize;

	private static bool GetQueryDataVolumeSolutionNum_QueryData_IsValid;

	private static FFieldAddress GetQueryDataVolumeSolutionNum_QueryData_PropertyAddress;

	private static int GetQueryDataVolumeSolutionNum_QueryData_Offset;

	private static bool GetQueryDataVolumeSolutionNum_ReturnValue_IsValid;

	private static FFieldAddress GetQueryDataVolumeSolutionNum_ReturnValue_PropertyAddress;

	private static int GetQueryDataVolumeSolutionNum_ReturnValue_Offset;

	private static bool DonNavigationManagerForActor_IsValid;

	private static IntPtr DonNavigationManagerForActor_FunctionAddress;

	private static int DonNavigationManagerForActor_ParamsSize;

	private static bool DonNavigationManagerForActor_Actor_IsValid;

	private static FFieldAddress DonNavigationManagerForActor_Actor_PropertyAddress;

	private static int DonNavigationManagerForActor_Actor_Offset;

	private static bool DonNavigationManagerForActor_ReturnValue_IsValid;

	private static FFieldAddress DonNavigationManagerForActor_ReturnValue_PropertyAddress;

	private static int DonNavigationManagerForActor_ReturnValue_Offset;

	private static bool DonNavigationManager_IsValid;

	private static IntPtr DonNavigationManager_FunctionAddress;

	private static int DonNavigationManager_ParamsSize;

	private static bool DonNavigationManager_WorldContextObject_IsValid;

	private static FFieldAddress DonNavigationManager_WorldContextObject_PropertyAddress;

	private static int DonNavigationManager_WorldContextObject_Offset;

	private static bool DonNavigationManager_ReturnValue_IsValid;

	private static FFieldAddress DonNavigationManager_ReturnValue_PropertyAddress;

	private static int DonNavigationManager_ReturnValue_Offset;

	private static bool AddMovementInputCustom_IsValid;

	private static IntPtr AddMovementInputCustom_FunctionAddress;

	private static int AddMovementInputCustom_ParamsSize;

	private static bool AddMovementInputCustom_Object_IsValid;

	private static FFieldAddress AddMovementInputCustom_Object_PropertyAddress;

	private static int AddMovementInputCustom_Object_Offset;

	private static bool AddMovementInputCustom_WorldDirection_IsValid;

	private static FFieldAddress AddMovementInputCustom_WorldDirection_PropertyAddress;

	private static int AddMovementInputCustom_WorldDirection_Offset;

	private static bool AddMovementInputCustom_ScaleValue_IsValid;

	private static FFieldAddress AddMovementInputCustom_ScaleValue_PropertyAddress;

	private static int AddMovementInputCustom_ScaleValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationHelper:OnUpdateDynamicCollision")]
	public unsafe static void OnUpdateDynamicCollision(UPrimitiveComponent Mesh, bool bDebug)
	{
		if (!OnUpdateDynamicCollision_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationHelper:OnUpdateDynamicCollision");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnUpdateDynamicCollision_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnUpdateDynamicCollision_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, OnUpdateDynamicCollision_Mesh_Offset), 0, OnUpdateDynamicCollision_Mesh_PropertyAddress.Address, Mesh);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnUpdateDynamicCollision_bDebug_Offset), 0, OnUpdateDynamicCollision_bDebug_PropertyAddress.Address, bDebug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OnUpdateDynamicCollision_FunctionAddress, intPtr, OnUpdateDynamicCollision_ParamsSize);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationHelper:OnNextSegment")]
	public unsafe static void OnNextSegment(UObject Object, FVector NextPoint)
	{
		if (!OnNextSegment_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationHelper:OnNextSegment");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnNextSegment_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnNextSegment_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnNextSegment_Object_Offset), 0, OnNextSegment_Object_PropertyAddress.Address, Object);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, OnNextSegment_NextPoint_Offset), 0, OnNextSegment_NextPoint_PropertyAddress.Address, NextPoint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OnNextSegment_FunctionAddress, intPtr, OnNextSegment_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationHelper:OnLocomotionEnd")]
	public unsafe static void OnLocomotionEnd(UObject Object, bool bLocomotionSuccess)
	{
		if (!OnLocomotionEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationHelper:OnLocomotionEnd");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnLocomotionEnd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnLocomotionEnd_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnLocomotionEnd_Object_Offset), 0, OnLocomotionEnd_Object_PropertyAddress.Address, Object);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnLocomotionEnd_bLocomotionSuccess_Offset), 0, OnLocomotionEnd_bLocomotionSuccess_PropertyAddress.Address, bLocomotionSuccess);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OnLocomotionEnd_FunctionAddress, intPtr, OnLocomotionEnd_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationHelper:OnLocomotionBegin")]
	public unsafe static void OnLocomotionBegin(UObject Object)
	{
		if (!OnLocomotionBegin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationHelper:OnLocomotionBegin");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnLocomotionBegin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnLocomotionBegin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnLocomotionBegin_Object_Offset), 0, OnLocomotionBegin_Object_PropertyAddress.Address, Object);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OnLocomotionBegin_FunctionAddress, intPtr, OnLocomotionBegin_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationHelper:OnLocomotionAbort")]
	public unsafe static void OnLocomotionAbort(UObject Object)
	{
		if (!OnLocomotionAbort_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationHelper:OnLocomotionAbort");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnLocomotionAbort_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnLocomotionAbort_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OnLocomotionAbort_Object_Offset), 0, OnLocomotionAbort_Object_PropertyAddress.Address, Object);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OnLocomotionAbort_FunctionAddress, intPtr, OnLocomotionAbort_ParamsSize);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationHelper:GetQueryDataVolumeSolutionOptimizedNum")]
	public unsafe static int GetQueryDataVolumeSolutionOptimizedNum(FDoNNavigationQueryData QueryData)
	{
		if (!GetQueryDataVolumeSolutionOptimizedNum_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationHelper:GetQueryDataVolumeSolutionOptimizedNum");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetQueryDataVolumeSolutionOptimizedNum_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetQueryDataVolumeSolutionOptimizedNum_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetQueryDataVolumeSolutionOptimizedNum_QueryData_PropertyAddress.Address, intPtr);
		FDoNNavigationQueryData.ToNative(IntPtr.Add(intPtr, GetQueryDataVolumeSolutionOptimizedNum_QueryData_Offset), 0, GetQueryDataVolumeSolutionOptimizedNum_QueryData_PropertyAddress.Address, QueryData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetQueryDataVolumeSolutionOptimizedNum_FunctionAddress, intPtr, GetQueryDataVolumeSolutionOptimizedNum_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetQueryDataVolumeSolutionOptimizedNum_QueryData_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetQueryDataVolumeSolutionOptimizedNum_ReturnValue_Offset), 0, GetQueryDataVolumeSolutionOptimizedNum_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationHelper:GetQueryDataVolumeSolutionNum")]
	public unsafe static int GetQueryDataVolumeSolutionNum(FDoNNavigationQueryData QueryData)
	{
		if (!GetQueryDataVolumeSolutionNum_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationHelper:GetQueryDataVolumeSolutionNum");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetQueryDataVolumeSolutionNum_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetQueryDataVolumeSolutionNum_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetQueryDataVolumeSolutionNum_QueryData_PropertyAddress.Address, intPtr);
		FDoNNavigationQueryData.ToNative(IntPtr.Add(intPtr, GetQueryDataVolumeSolutionNum_QueryData_Offset), 0, GetQueryDataVolumeSolutionNum_QueryData_PropertyAddress.Address, QueryData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetQueryDataVolumeSolutionNum_FunctionAddress, intPtr, GetQueryDataVolumeSolutionNum_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetQueryDataVolumeSolutionNum_QueryData_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetQueryDataVolumeSolutionNum_ReturnValue_Offset), 0, GetQueryDataVolumeSolutionNum_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationHelper:DonNavigationManagerForActor")]
	public unsafe static ADonNavigationManager DonNavigationManagerForActor(AActor Actor)
	{
		if (!DonNavigationManagerForActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationHelper:DonNavigationManagerForActor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DonNavigationManagerForActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DonNavigationManagerForActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, DonNavigationManagerForActor_Actor_Offset), 0, DonNavigationManagerForActor_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DonNavigationManagerForActor_FunctionAddress, intPtr, DonNavigationManagerForActor_ParamsSize);
		return UObjectMarshaler<ADonNavigationManager>.FromNative(IntPtr.Add(intPtr, DonNavigationManagerForActor_ReturnValue_Offset), 0, DonNavigationManagerForActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationHelper:DonNavigationManager")]
	public unsafe static ADonNavigationManager DonNavigationManager(UObject WorldContextObject)
	{
		if (!DonNavigationManager_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationHelper:DonNavigationManager");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DonNavigationManager_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DonNavigationManager_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, DonNavigationManager_WorldContextObject_Offset), 0, DonNavigationManager_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DonNavigationManager_FunctionAddress, intPtr, DonNavigationManager_ParamsSize);
		return UObjectMarshaler<ADonNavigationManager>.FromNative(IntPtr.Add(intPtr, DonNavigationManager_ReturnValue_Offset), 0, DonNavigationManager_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationHelper:AddMovementInputCustom")]
	public unsafe static void AddMovementInputCustom(UObject Object, FVector WorldDirection, float ScaleValue)
	{
		if (!AddMovementInputCustom_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationHelper:AddMovementInputCustom");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddMovementInputCustom_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddMovementInputCustom_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AddMovementInputCustom_Object_Offset), 0, AddMovementInputCustom_Object_PropertyAddress.Address, Object);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddMovementInputCustom_WorldDirection_Offset), 0, AddMovementInputCustom_WorldDirection_PropertyAddress.Address, WorldDirection);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddMovementInputCustom_ScaleValue_Offset), 0, AddMovementInputCustom_ScaleValue_PropertyAddress.Address, ScaleValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddMovementInputCustom_FunctionAddress, intPtr, AddMovementInputCustom_ParamsSize);
	}

	static UDonNavigationHelper()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDonNavigationHelper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDonNavigationHelper));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/DonAINavigation.DonNavigationHelper");
		OnUpdateDynamicCollision_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OnUpdateDynamicCollision");
		OnUpdateDynamicCollision_ParamsSize = NativeReflection.GetFunctionParamsSize(OnUpdateDynamicCollision_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnUpdateDynamicCollision_Mesh_PropertyAddress, OnUpdateDynamicCollision_FunctionAddress, "Mesh");
		OnUpdateDynamicCollision_Mesh_Offset = NativeReflectionCached.GetPropertyOffset(OnUpdateDynamicCollision_FunctionAddress, "Mesh");
		OnUpdateDynamicCollision_Mesh_IsValid = NativeReflectionCached.ValidatePropertyClass(OnUpdateDynamicCollision_FunctionAddress, "Mesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnUpdateDynamicCollision_bDebug_PropertyAddress, OnUpdateDynamicCollision_FunctionAddress, "bDebug");
		OnUpdateDynamicCollision_bDebug_Offset = NativeReflectionCached.GetPropertyOffset(OnUpdateDynamicCollision_FunctionAddress, "bDebug");
		OnUpdateDynamicCollision_bDebug_IsValid = NativeReflectionCached.ValidatePropertyClass(OnUpdateDynamicCollision_FunctionAddress, "bDebug", Classes.FBoolProperty);
		OnUpdateDynamicCollision_IsValid = OnUpdateDynamicCollision_FunctionAddress != IntPtr.Zero && OnUpdateDynamicCollision_Mesh_IsValid && OnUpdateDynamicCollision_bDebug_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationHelper:OnUpdateDynamicCollision", OnUpdateDynamicCollision_IsValid);
		OnNextSegment_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OnNextSegment");
		OnNextSegment_ParamsSize = NativeReflection.GetFunctionParamsSize(OnNextSegment_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnNextSegment_Object_PropertyAddress, OnNextSegment_FunctionAddress, "Object");
		OnNextSegment_Object_Offset = NativeReflectionCached.GetPropertyOffset(OnNextSegment_FunctionAddress, "Object");
		OnNextSegment_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(OnNextSegment_FunctionAddress, "Object", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnNextSegment_NextPoint_PropertyAddress, OnNextSegment_FunctionAddress, "NextPoint");
		OnNextSegment_NextPoint_Offset = NativeReflectionCached.GetPropertyOffset(OnNextSegment_FunctionAddress, "NextPoint");
		OnNextSegment_NextPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(OnNextSegment_FunctionAddress, "NextPoint", Classes.FStructProperty);
		OnNextSegment_IsValid = OnNextSegment_FunctionAddress != IntPtr.Zero && OnNextSegment_Object_IsValid && OnNextSegment_NextPoint_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationHelper:OnNextSegment", OnNextSegment_IsValid);
		OnLocomotionEnd_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OnLocomotionEnd");
		OnLocomotionEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(OnLocomotionEnd_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnLocomotionEnd_Object_PropertyAddress, OnLocomotionEnd_FunctionAddress, "Object");
		OnLocomotionEnd_Object_Offset = NativeReflectionCached.GetPropertyOffset(OnLocomotionEnd_FunctionAddress, "Object");
		OnLocomotionEnd_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(OnLocomotionEnd_FunctionAddress, "Object", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnLocomotionEnd_bLocomotionSuccess_PropertyAddress, OnLocomotionEnd_FunctionAddress, "bLocomotionSuccess");
		OnLocomotionEnd_bLocomotionSuccess_Offset = NativeReflectionCached.GetPropertyOffset(OnLocomotionEnd_FunctionAddress, "bLocomotionSuccess");
		OnLocomotionEnd_bLocomotionSuccess_IsValid = NativeReflectionCached.ValidatePropertyClass(OnLocomotionEnd_FunctionAddress, "bLocomotionSuccess", Classes.FBoolProperty);
		OnLocomotionEnd_IsValid = OnLocomotionEnd_FunctionAddress != IntPtr.Zero && OnLocomotionEnd_Object_IsValid && OnLocomotionEnd_bLocomotionSuccess_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationHelper:OnLocomotionEnd", OnLocomotionEnd_IsValid);
		OnLocomotionBegin_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OnLocomotionBegin");
		OnLocomotionBegin_ParamsSize = NativeReflection.GetFunctionParamsSize(OnLocomotionBegin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnLocomotionBegin_Object_PropertyAddress, OnLocomotionBegin_FunctionAddress, "Object");
		OnLocomotionBegin_Object_Offset = NativeReflectionCached.GetPropertyOffset(OnLocomotionBegin_FunctionAddress, "Object");
		OnLocomotionBegin_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(OnLocomotionBegin_FunctionAddress, "Object", Classes.FObjectProperty);
		OnLocomotionBegin_IsValid = OnLocomotionBegin_FunctionAddress != IntPtr.Zero && OnLocomotionBegin_Object_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationHelper:OnLocomotionBegin", OnLocomotionBegin_IsValid);
		OnLocomotionAbort_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OnLocomotionAbort");
		OnLocomotionAbort_ParamsSize = NativeReflection.GetFunctionParamsSize(OnLocomotionAbort_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnLocomotionAbort_Object_PropertyAddress, OnLocomotionAbort_FunctionAddress, "Object");
		OnLocomotionAbort_Object_Offset = NativeReflectionCached.GetPropertyOffset(OnLocomotionAbort_FunctionAddress, "Object");
		OnLocomotionAbort_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(OnLocomotionAbort_FunctionAddress, "Object", Classes.FObjectProperty);
		OnLocomotionAbort_IsValid = OnLocomotionAbort_FunctionAddress != IntPtr.Zero && OnLocomotionAbort_Object_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationHelper:OnLocomotionAbort", OnLocomotionAbort_IsValid);
		GetQueryDataVolumeSolutionOptimizedNum_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetQueryDataVolumeSolutionOptimizedNum");
		GetQueryDataVolumeSolutionOptimizedNum_ParamsSize = NativeReflection.GetFunctionParamsSize(GetQueryDataVolumeSolutionOptimizedNum_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetQueryDataVolumeSolutionOptimizedNum_QueryData_PropertyAddress, GetQueryDataVolumeSolutionOptimizedNum_FunctionAddress, "QueryData");
		GetQueryDataVolumeSolutionOptimizedNum_QueryData_Offset = NativeReflectionCached.GetPropertyOffset(GetQueryDataVolumeSolutionOptimizedNum_FunctionAddress, "QueryData");
		GetQueryDataVolumeSolutionOptimizedNum_QueryData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetQueryDataVolumeSolutionOptimizedNum_FunctionAddress, "QueryData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetQueryDataVolumeSolutionOptimizedNum_ReturnValue_PropertyAddress, GetQueryDataVolumeSolutionOptimizedNum_FunctionAddress, "ReturnValue");
		GetQueryDataVolumeSolutionOptimizedNum_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetQueryDataVolumeSolutionOptimizedNum_FunctionAddress, "ReturnValue");
		GetQueryDataVolumeSolutionOptimizedNum_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetQueryDataVolumeSolutionOptimizedNum_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetQueryDataVolumeSolutionOptimizedNum_IsValid = GetQueryDataVolumeSolutionOptimizedNum_FunctionAddress != IntPtr.Zero && GetQueryDataVolumeSolutionOptimizedNum_QueryData_IsValid && GetQueryDataVolumeSolutionOptimizedNum_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationHelper:GetQueryDataVolumeSolutionOptimizedNum", GetQueryDataVolumeSolutionOptimizedNum_IsValid);
		GetQueryDataVolumeSolutionNum_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetQueryDataVolumeSolutionNum");
		GetQueryDataVolumeSolutionNum_ParamsSize = NativeReflection.GetFunctionParamsSize(GetQueryDataVolumeSolutionNum_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetQueryDataVolumeSolutionNum_QueryData_PropertyAddress, GetQueryDataVolumeSolutionNum_FunctionAddress, "QueryData");
		GetQueryDataVolumeSolutionNum_QueryData_Offset = NativeReflectionCached.GetPropertyOffset(GetQueryDataVolumeSolutionNum_FunctionAddress, "QueryData");
		GetQueryDataVolumeSolutionNum_QueryData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetQueryDataVolumeSolutionNum_FunctionAddress, "QueryData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetQueryDataVolumeSolutionNum_ReturnValue_PropertyAddress, GetQueryDataVolumeSolutionNum_FunctionAddress, "ReturnValue");
		GetQueryDataVolumeSolutionNum_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetQueryDataVolumeSolutionNum_FunctionAddress, "ReturnValue");
		GetQueryDataVolumeSolutionNum_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetQueryDataVolumeSolutionNum_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetQueryDataVolumeSolutionNum_IsValid = GetQueryDataVolumeSolutionNum_FunctionAddress != IntPtr.Zero && GetQueryDataVolumeSolutionNum_QueryData_IsValid && GetQueryDataVolumeSolutionNum_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationHelper:GetQueryDataVolumeSolutionNum", GetQueryDataVolumeSolutionNum_IsValid);
		DonNavigationManagerForActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DonNavigationManagerForActor");
		DonNavigationManagerForActor_ParamsSize = NativeReflection.GetFunctionParamsSize(DonNavigationManagerForActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DonNavigationManagerForActor_Actor_PropertyAddress, DonNavigationManagerForActor_FunctionAddress, "Actor");
		DonNavigationManagerForActor_Actor_Offset = NativeReflectionCached.GetPropertyOffset(DonNavigationManagerForActor_FunctionAddress, "Actor");
		DonNavigationManagerForActor_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(DonNavigationManagerForActor_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DonNavigationManagerForActor_ReturnValue_PropertyAddress, DonNavigationManagerForActor_FunctionAddress, "ReturnValue");
		DonNavigationManagerForActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DonNavigationManagerForActor_FunctionAddress, "ReturnValue");
		DonNavigationManagerForActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DonNavigationManagerForActor_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		DonNavigationManagerForActor_IsValid = DonNavigationManagerForActor_FunctionAddress != IntPtr.Zero && DonNavigationManagerForActor_Actor_IsValid && DonNavigationManagerForActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationHelper:DonNavigationManagerForActor", DonNavigationManagerForActor_IsValid);
		DonNavigationManager_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DonNavigationManager");
		DonNavigationManager_ParamsSize = NativeReflection.GetFunctionParamsSize(DonNavigationManager_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DonNavigationManager_WorldContextObject_PropertyAddress, DonNavigationManager_FunctionAddress, "WorldContextObject");
		DonNavigationManager_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(DonNavigationManager_FunctionAddress, "WorldContextObject");
		DonNavigationManager_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(DonNavigationManager_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DonNavigationManager_ReturnValue_PropertyAddress, DonNavigationManager_FunctionAddress, "ReturnValue");
		DonNavigationManager_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DonNavigationManager_FunctionAddress, "ReturnValue");
		DonNavigationManager_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DonNavigationManager_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		DonNavigationManager_IsValid = DonNavigationManager_FunctionAddress != IntPtr.Zero && DonNavigationManager_WorldContextObject_IsValid && DonNavigationManager_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationHelper:DonNavigationManager", DonNavigationManager_IsValid);
		AddMovementInputCustom_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddMovementInputCustom");
		AddMovementInputCustom_ParamsSize = NativeReflection.GetFunctionParamsSize(AddMovementInputCustom_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddMovementInputCustom_Object_PropertyAddress, AddMovementInputCustom_FunctionAddress, "Object");
		AddMovementInputCustom_Object_Offset = NativeReflectionCached.GetPropertyOffset(AddMovementInputCustom_FunctionAddress, "Object");
		AddMovementInputCustom_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMovementInputCustom_FunctionAddress, "Object", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMovementInputCustom_WorldDirection_PropertyAddress, AddMovementInputCustom_FunctionAddress, "WorldDirection");
		AddMovementInputCustom_WorldDirection_Offset = NativeReflectionCached.GetPropertyOffset(AddMovementInputCustom_FunctionAddress, "WorldDirection");
		AddMovementInputCustom_WorldDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMovementInputCustom_FunctionAddress, "WorldDirection", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMovementInputCustom_ScaleValue_PropertyAddress, AddMovementInputCustom_FunctionAddress, "ScaleValue");
		AddMovementInputCustom_ScaleValue_Offset = NativeReflectionCached.GetPropertyOffset(AddMovementInputCustom_FunctionAddress, "ScaleValue");
		AddMovementInputCustom_ScaleValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMovementInputCustom_FunctionAddress, "ScaleValue", Classes.FFloatProperty);
		AddMovementInputCustom_IsValid = AddMovementInputCustom_FunctionAddress != IntPtr.Zero && AddMovementInputCustom_Object_IsValid && AddMovementInputCustom_WorldDirection_IsValid && AddMovementInputCustom_ScaleValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationHelper:AddMovementInputCustom", AddMovementInputCustom_IsValid);
	}
}
