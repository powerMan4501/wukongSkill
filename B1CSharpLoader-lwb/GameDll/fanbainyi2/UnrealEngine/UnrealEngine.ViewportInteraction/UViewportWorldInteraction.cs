using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UnrealEd;

namespace UnrealEngine.ViewportInteraction;

[UClass(Flags = (ClassFlags)818938024uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/ViewportInteraction.ViewportWorldInteraction", "ViewportInteraction", UnrealModuleType.Engine)]
public class UViewportWorldInteraction : UEditorWorldExtension
{
	private static bool SetWorldToMetersScale_IsValid;

	private static IntPtr SetWorldToMetersScale_FunctionAddress;

	private static int SetWorldToMetersScale_ParamsSize;

	private static bool SetWorldToMetersScale_NewWorldToMetersScale_IsValid;

	private static FFieldAddress SetWorldToMetersScale_NewWorldToMetersScale_PropertyAddress;

	private static int SetWorldToMetersScale_NewWorldToMetersScale_Offset;

	private static bool SetWorldToMetersScale_bCompensateRoomWorldScale_IsValid;

	private static FFieldAddress SetWorldToMetersScale_bCompensateRoomWorldScale_PropertyAddress;

	private static int SetWorldToMetersScale_bCompensateRoomWorldScale_Offset;

	private static bool SetRoomTransformForNextFrame_IsValid;

	private static IntPtr SetRoomTransformForNextFrame_FunctionAddress;

	private static int SetRoomTransformForNextFrame_ParamsSize;

	private static bool SetRoomTransformForNextFrame_NewRoomTransform_IsValid;

	private static FFieldAddress SetRoomTransformForNextFrame_NewRoomTransform_PropertyAddress;

	private static int SetRoomTransformForNextFrame_NewRoomTransform_Offset;

	private static bool SetHeadTransform_IsValid;

	private static IntPtr SetHeadTransform_FunctionAddress;

	private static int SetHeadTransform_ParamsSize;

	private static bool SetHeadTransform_NewHeadTransform_IsValid;

	private static FFieldAddress SetHeadTransform_NewHeadTransform_PropertyAddress;

	private static int SetHeadTransform_NewHeadTransform_Offset;

	private static bool RemoveInteractor_IsValid;

	private static IntPtr RemoveInteractor_FunctionAddress;

	private static int RemoveInteractor_ParamsSize;

	private static bool RemoveInteractor_Interactor_IsValid;

	private static FFieldAddress RemoveInteractor_Interactor_PropertyAddress;

	private static int RemoveInteractor_Interactor_Offset;

	private static bool GetWorldScaleFactor_IsValid;

	private static IntPtr GetWorldScaleFactor_FunctionAddress;

	private static int GetWorldScaleFactor_ParamsSize;

	private static bool GetWorldScaleFactor_ReturnValue_IsValid;

	private static FFieldAddress GetWorldScaleFactor_ReturnValue_PropertyAddress;

	private static int GetWorldScaleFactor_ReturnValue_Offset;

	private static bool GetTransformGizmoActor_IsValid;

	private static IntPtr GetTransformGizmoActor_FunctionAddress;

	private static int GetTransformGizmoActor_ParamsSize;

	private static bool GetTransformGizmoActor_ReturnValue_IsValid;

	private static FFieldAddress GetTransformGizmoActor_ReturnValue_PropertyAddress;

	private static int GetTransformGizmoActor_ReturnValue_Offset;

	private static bool GetRoomTransform_IsValid;

	private static IntPtr GetRoomTransform_FunctionAddress;

	private static int GetRoomTransform_ParamsSize;

	private static bool GetRoomTransform_ReturnValue_IsValid;

	private static FFieldAddress GetRoomTransform_ReturnValue_PropertyAddress;

	private static int GetRoomTransform_ReturnValue_Offset;

	private static bool GetRoomSpaceHeadTransform_IsValid;

	private static IntPtr GetRoomSpaceHeadTransform_FunctionAddress;

	private static int GetRoomSpaceHeadTransform_ParamsSize;

	private static bool GetRoomSpaceHeadTransform_ReturnValue_IsValid;

	private static FFieldAddress GetRoomSpaceHeadTransform_ReturnValue_PropertyAddress;

	private static int GetRoomSpaceHeadTransform_ReturnValue_Offset;

	private static bool GetInteractors_IsValid;

	private static IntPtr GetInteractors_FunctionAddress;

	private static int GetInteractors_ParamsSize;

	private static bool GetInteractors_ReturnValue_IsValid;

	private static FFieldAddress GetInteractors_ReturnValue_PropertyAddress;

	private static int GetInteractors_ReturnValue_Offset;

	private static bool GetHeadTransform_IsValid;

	private static IntPtr GetHeadTransform_FunctionAddress;

	private static int GetHeadTransform_ParamsSize;

	private static bool GetHeadTransform_ReturnValue_IsValid;

	private static FFieldAddress GetHeadTransform_ReturnValue_PropertyAddress;

	private static int GetHeadTransform_ReturnValue_Offset;

	private static bool AddInteractor_IsValid;

	private static IntPtr AddInteractor_FunctionAddress;

	private static int AddInteractor_ParamsSize;

	private static bool AddInteractor_Interactor_IsValid;

	private static FFieldAddress AddInteractor_Interactor_PropertyAddress;

	private static int AddInteractor_Interactor_Offset;

	private static bool AddActorToExcludeFromHitTests_IsValid;

	private static IntPtr AddActorToExcludeFromHitTests_FunctionAddress;

	private static int AddActorToExcludeFromHitTests_ParamsSize;

	private static bool AddActorToExcludeFromHitTests_ActorToExcludeFromHitTests_IsValid;

	private static FFieldAddress AddActorToExcludeFromHitTests_ActorToExcludeFromHitTests_PropertyAddress;

	private static int AddActorToExcludeFromHitTests_ActorToExcludeFromHitTests_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ViewportInteraction.ViewportWorldInteraction:SetWorldToMetersScale")]
	public unsafe void SetWorldToMetersScale(float NewWorldToMetersScale, bool bCompensateRoomWorldScale = false)
	{
		CheckDestroyed();
		if (!SetWorldToMetersScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportWorldInteraction:SetWorldToMetersScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWorldToMetersScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWorldToMetersScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetWorldToMetersScale_NewWorldToMetersScale_Offset), 0, SetWorldToMetersScale_NewWorldToMetersScale_PropertyAddress.Address, NewWorldToMetersScale);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetWorldToMetersScale_bCompensateRoomWorldScale_Offset), 0, SetWorldToMetersScale_bCompensateRoomWorldScale_PropertyAddress.Address, bCompensateRoomWorldScale);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWorldToMetersScale_FunctionAddress, intPtr, SetWorldToMetersScale_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/ViewportInteraction.ViewportWorldInteraction:SetRoomTransformForNextFrame")]
	public unsafe void SetRoomTransformForNextFrame(FTransform NewRoomTransform)
	{
		CheckDestroyed();
		if (!SetRoomTransformForNextFrame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportWorldInteraction:SetRoomTransformForNextFrame");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRoomTransformForNextFrame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRoomTransformForNextFrame_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetRoomTransformForNextFrame_NewRoomTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetRoomTransformForNextFrame_NewRoomTransform_Offset), 0, SetRoomTransformForNextFrame_NewRoomTransform_PropertyAddress.Address, NewRoomTransform);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRoomTransformForNextFrame_FunctionAddress, intPtr, SetRoomTransformForNextFrame_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/ViewportInteraction.ViewportWorldInteraction:SetHeadTransform")]
	public unsafe void SetHeadTransform(FTransform NewHeadTransform)
	{
		CheckDestroyed();
		if (!SetHeadTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportWorldInteraction:SetHeadTransform");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetHeadTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetHeadTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetHeadTransform_NewHeadTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetHeadTransform_NewHeadTransform_Offset), 0, SetHeadTransform_NewHeadTransform_PropertyAddress.Address, NewHeadTransform);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetHeadTransform_FunctionAddress, intPtr, SetHeadTransform_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ViewportInteraction.ViewportWorldInteraction:RemoveInteractor")]
	public unsafe void RemoveInteractor(UViewportInteractor Interactor)
	{
		CheckDestroyed();
		if (!RemoveInteractor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportWorldInteraction:RemoveInteractor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveInteractor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveInteractor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UViewportInteractor>.ToNative(IntPtr.Add(intPtr, RemoveInteractor_Interactor_Offset), 0, RemoveInteractor_Interactor_PropertyAddress.Address, Interactor);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveInteractor_FunctionAddress, intPtr, RemoveInteractor_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ViewportInteraction.ViewportWorldInteraction:GetWorldScaleFactor")]
	public unsafe float GetWorldScaleFactor()
	{
		CheckDestroyed();
		if (!GetWorldScaleFactor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportWorldInteraction:GetWorldScaleFactor");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWorldScaleFactor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWorldScaleFactor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWorldScaleFactor_FunctionAddress, intPtr, GetWorldScaleFactor_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetWorldScaleFactor_ReturnValue_Offset), 0, GetWorldScaleFactor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ViewportInteraction.ViewportWorldInteraction:GetTransformGizmoActor")]
	public unsafe ABaseTransformGizmo GetTransformGizmoActor()
	{
		CheckDestroyed();
		if (!GetTransformGizmoActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportWorldInteraction:GetTransformGizmoActor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTransformGizmoActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTransformGizmoActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTransformGizmoActor_FunctionAddress, intPtr, GetTransformGizmoActor_ParamsSize);
		return UObjectMarshaler<ABaseTransformGizmo>.FromNative(IntPtr.Add(intPtr, GetTransformGizmoActor_ReturnValue_Offset), 0, GetTransformGizmoActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/ViewportInteraction.ViewportWorldInteraction:GetRoomTransform")]
	public unsafe FTransform GetRoomTransform()
	{
		CheckDestroyed();
		if (!GetRoomTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportWorldInteraction:GetRoomTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRoomTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRoomTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRoomTransform_FunctionAddress, intPtr, GetRoomTransform_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetRoomTransform_ReturnValue_Offset), 0, GetRoomTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/ViewportInteraction.ViewportWorldInteraction:GetRoomSpaceHeadTransform")]
	public unsafe FTransform GetRoomSpaceHeadTransform()
	{
		CheckDestroyed();
		if (!GetRoomSpaceHeadTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportWorldInteraction:GetRoomSpaceHeadTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRoomSpaceHeadTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRoomSpaceHeadTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRoomSpaceHeadTransform_FunctionAddress, intPtr, GetRoomSpaceHeadTransform_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetRoomSpaceHeadTransform_ReturnValue_Offset), 0, GetRoomSpaceHeadTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ViewportInteraction.ViewportWorldInteraction:GetInteractors")]
	public unsafe List<UViewportInteractor> GetInteractors()
	{
		CheckDestroyed();
		if (!GetInteractors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportWorldInteraction:GetInteractors");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInteractors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInteractors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInteractors_FunctionAddress, intPtr, GetInteractors_ParamsSize);
		List<UViewportInteractor> result = new TArrayCopyMarshaler<UViewportInteractor>(1, GetInteractors_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UViewportInteractor, UObjectMarshaler<UViewportInteractor>>.FromNative, CachedMarshalingDelegates<UViewportInteractor, UObjectMarshaler<UViewportInteractor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetInteractors_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetInteractors_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/ViewportInteraction.ViewportWorldInteraction:GetHeadTransform")]
	public unsafe FTransform GetHeadTransform()
	{
		CheckDestroyed();
		if (!GetHeadTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportWorldInteraction:GetHeadTransform");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHeadTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHeadTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetHeadTransform_FunctionAddress, intPtr, GetHeadTransform_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetHeadTransform_ReturnValue_Offset), 0, GetHeadTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ViewportInteraction.ViewportWorldInteraction:AddInteractor")]
	public unsafe void AddInteractor(UViewportInteractor Interactor)
	{
		CheckDestroyed();
		if (!AddInteractor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportWorldInteraction:AddInteractor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddInteractor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddInteractor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UViewportInteractor>.ToNative(IntPtr.Add(intPtr, AddInteractor_Interactor_Offset), 0, AddInteractor_Interactor_PropertyAddress.Address, Interactor);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddInteractor_FunctionAddress, intPtr, AddInteractor_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ViewportInteraction.ViewportWorldInteraction:AddActorToExcludeFromHitTests")]
	public unsafe void AddActorToExcludeFromHitTests(AActor ActorToExcludeFromHitTests)
	{
		CheckDestroyed();
		if (!AddActorToExcludeFromHitTests_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ViewportInteraction.ViewportWorldInteraction:AddActorToExcludeFromHitTests");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddActorToExcludeFromHitTests_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddActorToExcludeFromHitTests_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, AddActorToExcludeFromHitTests_ActorToExcludeFromHitTests_Offset), 0, AddActorToExcludeFromHitTests_ActorToExcludeFromHitTests_PropertyAddress.Address, ActorToExcludeFromHitTests);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddActorToExcludeFromHitTests_FunctionAddress, intPtr, AddActorToExcludeFromHitTests_ParamsSize);
	}

	static UViewportWorldInteraction()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UViewportWorldInteraction)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UViewportWorldInteraction));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/ViewportInteraction.ViewportWorldInteraction");
		SetWorldToMetersScale_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetWorldToMetersScale");
		SetWorldToMetersScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWorldToMetersScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWorldToMetersScale_NewWorldToMetersScale_PropertyAddress, SetWorldToMetersScale_FunctionAddress, "NewWorldToMetersScale");
		SetWorldToMetersScale_NewWorldToMetersScale_Offset = NativeReflectionCached.GetPropertyOffset(SetWorldToMetersScale_FunctionAddress, "NewWorldToMetersScale");
		SetWorldToMetersScale_NewWorldToMetersScale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWorldToMetersScale_FunctionAddress, "NewWorldToMetersScale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWorldToMetersScale_bCompensateRoomWorldScale_PropertyAddress, SetWorldToMetersScale_FunctionAddress, "bCompensateRoomWorldScale");
		SetWorldToMetersScale_bCompensateRoomWorldScale_Offset = NativeReflectionCached.GetPropertyOffset(SetWorldToMetersScale_FunctionAddress, "bCompensateRoomWorldScale");
		SetWorldToMetersScale_bCompensateRoomWorldScale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWorldToMetersScale_FunctionAddress, "bCompensateRoomWorldScale", Classes.FBoolProperty);
		SetWorldToMetersScale_IsValid = SetWorldToMetersScale_FunctionAddress != IntPtr.Zero && SetWorldToMetersScale_NewWorldToMetersScale_IsValid && SetWorldToMetersScale_bCompensateRoomWorldScale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ViewportInteraction.ViewportWorldInteraction:SetWorldToMetersScale", SetWorldToMetersScale_IsValid);
		SetRoomTransformForNextFrame_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetRoomTransformForNextFrame");
		SetRoomTransformForNextFrame_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRoomTransformForNextFrame_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRoomTransformForNextFrame_NewRoomTransform_PropertyAddress, SetRoomTransformForNextFrame_FunctionAddress, "NewRoomTransform");
		SetRoomTransformForNextFrame_NewRoomTransform_Offset = NativeReflectionCached.GetPropertyOffset(SetRoomTransformForNextFrame_FunctionAddress, "NewRoomTransform");
		SetRoomTransformForNextFrame_NewRoomTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRoomTransformForNextFrame_FunctionAddress, "NewRoomTransform", Classes.FStructProperty);
		SetRoomTransformForNextFrame_IsValid = SetRoomTransformForNextFrame_FunctionAddress != IntPtr.Zero && SetRoomTransformForNextFrame_NewRoomTransform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ViewportInteraction.ViewportWorldInteraction:SetRoomTransformForNextFrame", SetRoomTransformForNextFrame_IsValid);
		SetHeadTransform_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetHeadTransform");
		SetHeadTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHeadTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHeadTransform_NewHeadTransform_PropertyAddress, SetHeadTransform_FunctionAddress, "NewHeadTransform");
		SetHeadTransform_NewHeadTransform_Offset = NativeReflectionCached.GetPropertyOffset(SetHeadTransform_FunctionAddress, "NewHeadTransform");
		SetHeadTransform_NewHeadTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHeadTransform_FunctionAddress, "NewHeadTransform", Classes.FStructProperty);
		SetHeadTransform_IsValid = SetHeadTransform_FunctionAddress != IntPtr.Zero && SetHeadTransform_NewHeadTransform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ViewportInteraction.ViewportWorldInteraction:SetHeadTransform", SetHeadTransform_IsValid);
		RemoveInteractor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveInteractor");
		RemoveInteractor_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveInteractor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveInteractor_Interactor_PropertyAddress, RemoveInteractor_FunctionAddress, "Interactor");
		RemoveInteractor_Interactor_Offset = NativeReflectionCached.GetPropertyOffset(RemoveInteractor_FunctionAddress, "Interactor");
		RemoveInteractor_Interactor_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveInteractor_FunctionAddress, "Interactor", Classes.FObjectProperty);
		RemoveInteractor_IsValid = RemoveInteractor_FunctionAddress != IntPtr.Zero && RemoveInteractor_Interactor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ViewportInteraction.ViewportWorldInteraction:RemoveInteractor", RemoveInteractor_IsValid);
		GetWorldScaleFactor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetWorldScaleFactor");
		GetWorldScaleFactor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWorldScaleFactor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWorldScaleFactor_ReturnValue_PropertyAddress, GetWorldScaleFactor_FunctionAddress, "ReturnValue");
		GetWorldScaleFactor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWorldScaleFactor_FunctionAddress, "ReturnValue");
		GetWorldScaleFactor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWorldScaleFactor_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetWorldScaleFactor_IsValid = GetWorldScaleFactor_FunctionAddress != IntPtr.Zero && GetWorldScaleFactor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ViewportInteraction.ViewportWorldInteraction:GetWorldScaleFactor", GetWorldScaleFactor_IsValid);
		GetTransformGizmoActor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTransformGizmoActor");
		GetTransformGizmoActor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTransformGizmoActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTransformGizmoActor_ReturnValue_PropertyAddress, GetTransformGizmoActor_FunctionAddress, "ReturnValue");
		GetTransformGizmoActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformGizmoActor_FunctionAddress, "ReturnValue");
		GetTransformGizmoActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformGizmoActor_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetTransformGizmoActor_IsValid = GetTransformGizmoActor_FunctionAddress != IntPtr.Zero && GetTransformGizmoActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ViewportInteraction.ViewportWorldInteraction:GetTransformGizmoActor", GetTransformGizmoActor_IsValid);
		GetRoomTransform_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetRoomTransform");
		GetRoomTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRoomTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRoomTransform_ReturnValue_PropertyAddress, GetRoomTransform_FunctionAddress, "ReturnValue");
		GetRoomTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRoomTransform_FunctionAddress, "ReturnValue");
		GetRoomTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRoomTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetRoomTransform_IsValid = GetRoomTransform_FunctionAddress != IntPtr.Zero && GetRoomTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ViewportInteraction.ViewportWorldInteraction:GetRoomTransform", GetRoomTransform_IsValid);
		GetRoomSpaceHeadTransform_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetRoomSpaceHeadTransform");
		GetRoomSpaceHeadTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRoomSpaceHeadTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRoomSpaceHeadTransform_ReturnValue_PropertyAddress, GetRoomSpaceHeadTransform_FunctionAddress, "ReturnValue");
		GetRoomSpaceHeadTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRoomSpaceHeadTransform_FunctionAddress, "ReturnValue");
		GetRoomSpaceHeadTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRoomSpaceHeadTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetRoomSpaceHeadTransform_IsValid = GetRoomSpaceHeadTransform_FunctionAddress != IntPtr.Zero && GetRoomSpaceHeadTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ViewportInteraction.ViewportWorldInteraction:GetRoomSpaceHeadTransform", GetRoomSpaceHeadTransform_IsValid);
		GetInteractors_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetInteractors");
		GetInteractors_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInteractors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInteractors_ReturnValue_PropertyAddress, GetInteractors_FunctionAddress, "ReturnValue");
		GetInteractors_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInteractors_FunctionAddress, "ReturnValue");
		GetInteractors_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInteractors_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetInteractors_IsValid = GetInteractors_FunctionAddress != IntPtr.Zero && GetInteractors_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ViewportInteraction.ViewportWorldInteraction:GetInteractors", GetInteractors_IsValid);
		GetHeadTransform_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetHeadTransform");
		GetHeadTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHeadTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHeadTransform_ReturnValue_PropertyAddress, GetHeadTransform_FunctionAddress, "ReturnValue");
		GetHeadTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetHeadTransform_FunctionAddress, "ReturnValue");
		GetHeadTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHeadTransform_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetHeadTransform_IsValid = GetHeadTransform_FunctionAddress != IntPtr.Zero && GetHeadTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ViewportInteraction.ViewportWorldInteraction:GetHeadTransform", GetHeadTransform_IsValid);
		AddInteractor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddInteractor");
		AddInteractor_ParamsSize = NativeReflection.GetFunctionParamsSize(AddInteractor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddInteractor_Interactor_PropertyAddress, AddInteractor_FunctionAddress, "Interactor");
		AddInteractor_Interactor_Offset = NativeReflectionCached.GetPropertyOffset(AddInteractor_FunctionAddress, "Interactor");
		AddInteractor_Interactor_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInteractor_FunctionAddress, "Interactor", Classes.FObjectProperty);
		AddInteractor_IsValid = AddInteractor_FunctionAddress != IntPtr.Zero && AddInteractor_Interactor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ViewportInteraction.ViewportWorldInteraction:AddInteractor", AddInteractor_IsValid);
		AddActorToExcludeFromHitTests_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddActorToExcludeFromHitTests");
		AddActorToExcludeFromHitTests_ParamsSize = NativeReflection.GetFunctionParamsSize(AddActorToExcludeFromHitTests_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddActorToExcludeFromHitTests_ActorToExcludeFromHitTests_PropertyAddress, AddActorToExcludeFromHitTests_FunctionAddress, "ActorToExcludeFromHitTests");
		AddActorToExcludeFromHitTests_ActorToExcludeFromHitTests_Offset = NativeReflectionCached.GetPropertyOffset(AddActorToExcludeFromHitTests_FunctionAddress, "ActorToExcludeFromHitTests");
		AddActorToExcludeFromHitTests_ActorToExcludeFromHitTests_IsValid = NativeReflectionCached.ValidatePropertyClass(AddActorToExcludeFromHitTests_FunctionAddress, "ActorToExcludeFromHitTests", Classes.FObjectProperty);
		AddActorToExcludeFromHitTests_IsValid = AddActorToExcludeFromHitTests_FunctionAddress != IntPtr.Zero && AddActorToExcludeFromHitTests_ActorToExcludeFromHitTests_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ViewportInteraction.ViewportWorldInteraction:AddActorToExcludeFromHitTests", AddActorToExcludeFromHitTests_IsValid);
	}
}
