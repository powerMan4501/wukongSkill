using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.CameraComponent", "Engine", UnrealModuleType.Engine)]
public class UCameraComponent : USceneComponent
{
	private static bool FieldOfView_IsValid;

	private static int FieldOfView_Offset;

	private static bool OrthoWidth_IsValid;

	private static int OrthoWidth_Offset;

	private static bool OrthoNearClipPlane_IsValid;

	private static int OrthoNearClipPlane_Offset;

	private static bool OrthoFarClipPlane_IsValid;

	private static int OrthoFarClipPlane_Offset;

	private static bool AspectRatio_IsValid;

	private static int AspectRatio_Offset;

	private static bool ConstrainAspectRatio_IsValid;

	private static FFieldAddress ConstrainAspectRatio_PropertyAddress;

	private static int ConstrainAspectRatio_Offset;

	private static bool UseFieldOfViewForLOD_IsValid;

	private static FFieldAddress UseFieldOfViewForLOD_PropertyAddress;

	private static int UseFieldOfViewForLOD_Offset;

	private static bool DrawFrustumAllowed_IsValid;

	private static FFieldAddress DrawFrustumAllowed_PropertyAddress;

	private static int DrawFrustumAllowed_Offset;

	private static bool CameraMeshHiddenInGame_IsValid;

	private static FFieldAddress CameraMeshHiddenInGame_PropertyAddress;

	private static int CameraMeshHiddenInGame_Offset;

	private static bool LockToHmd_IsValid;

	private static FFieldAddress LockToHmd_PropertyAddress;

	private static int LockToHmd_Offset;

	private static bool UsePawnControlRotation_IsValid;

	private static FFieldAddress UsePawnControlRotation_PropertyAddress;

	private static int UsePawnControlRotation_Offset;

	private static bool ProjectionMode_IsValid;

	private static FFieldAddress ProjectionMode_PropertyAddress;

	private static int ProjectionMode_Offset;

	private static bool CameraMesh_IsValid;

	private static int CameraMesh_Offset;

	private static bool PostProcessBlendWeight_IsValid;

	private static int PostProcessBlendWeight_Offset;

	private static bool PostProcessSettings_IsValid;

	private static int PostProcessSettings_Offset;

	private static bool SetUseFieldOfViewForLOD_IsValid;

	private static IntPtr SetUseFieldOfViewForLOD_FunctionAddress;

	private static int SetUseFieldOfViewForLOD_ParamsSize;

	private static bool SetUseFieldOfViewForLOD_bInUseFieldOfViewForLOD_IsValid;

	private static FFieldAddress SetUseFieldOfViewForLOD_bInUseFieldOfViewForLOD_PropertyAddress;

	private static int SetUseFieldOfViewForLOD_bInUseFieldOfViewForLOD_Offset;

	private static bool SetProjectionMode_IsValid;

	private static IntPtr SetProjectionMode_FunctionAddress;

	private static int SetProjectionMode_ParamsSize;

	private static bool SetProjectionMode_InProjectionMode_IsValid;

	private static FFieldAddress SetProjectionMode_InProjectionMode_PropertyAddress;

	private static int SetProjectionMode_InProjectionMode_Offset;

	private static bool SetPostProcessBlendWeight_IsValid;

	private static IntPtr SetPostProcessBlendWeight_FunctionAddress;

	private static int SetPostProcessBlendWeight_ParamsSize;

	private static bool SetPostProcessBlendWeight_InPostProcessBlendWeight_IsValid;

	private static FFieldAddress SetPostProcessBlendWeight_InPostProcessBlendWeight_PropertyAddress;

	private static int SetPostProcessBlendWeight_InPostProcessBlendWeight_Offset;

	private static bool SetOrthoWidth_IsValid;

	private static IntPtr SetOrthoWidth_FunctionAddress;

	private static int SetOrthoWidth_ParamsSize;

	private static bool SetOrthoWidth_InOrthoWidth_IsValid;

	private static FFieldAddress SetOrthoWidth_InOrthoWidth_PropertyAddress;

	private static int SetOrthoWidth_InOrthoWidth_Offset;

	private static bool SetOrthoNearClipPlane_IsValid;

	private static IntPtr SetOrthoNearClipPlane_FunctionAddress;

	private static int SetOrthoNearClipPlane_ParamsSize;

	private static bool SetOrthoNearClipPlane_InOrthoNearClipPlane_IsValid;

	private static FFieldAddress SetOrthoNearClipPlane_InOrthoNearClipPlane_PropertyAddress;

	private static int SetOrthoNearClipPlane_InOrthoNearClipPlane_Offset;

	private static bool SetOrthoFarClipPlane_IsValid;

	private static IntPtr SetOrthoFarClipPlane_FunctionAddress;

	private static int SetOrthoFarClipPlane_ParamsSize;

	private static bool SetOrthoFarClipPlane_InOrthoFarClipPlane_IsValid;

	private static FFieldAddress SetOrthoFarClipPlane_InOrthoFarClipPlane_PropertyAddress;

	private static int SetOrthoFarClipPlane_InOrthoFarClipPlane_Offset;

	private static bool SetFieldOfView_IsValid;

	private static IntPtr SetFieldOfView_FunctionAddress;

	private static int SetFieldOfView_ParamsSize;

	private static bool SetFieldOfView_InFieldOfView_IsValid;

	private static FFieldAddress SetFieldOfView_InFieldOfView_PropertyAddress;

	private static int SetFieldOfView_InFieldOfView_Offset;

	private static bool SetConstraintAspectRatio_IsValid;

	private static IntPtr SetConstraintAspectRatio_FunctionAddress;

	private static int SetConstraintAspectRatio_ParamsSize;

	private static bool SetConstraintAspectRatio_bInConstrainAspectRatio_IsValid;

	private static FFieldAddress SetConstraintAspectRatio_bInConstrainAspectRatio_PropertyAddress;

	private static int SetConstraintAspectRatio_bInConstrainAspectRatio_Offset;

	private static bool SetAspectRatio_IsValid;

	private static IntPtr SetAspectRatio_FunctionAddress;

	private static int SetAspectRatio_ParamsSize;

	private static bool SetAspectRatio_InAspectRatio_IsValid;

	private static FFieldAddress SetAspectRatio_InAspectRatio_PropertyAddress;

	private static int SetAspectRatio_InAspectRatio_Offset;

	private static bool RemoveBlendable_IsValid;

	private static IntPtr RemoveBlendable_FunctionAddress;

	private static int RemoveBlendable_ParamsSize;

	private static bool RemoveBlendable_InBlendableObject_IsValid;

	private static FFieldAddress RemoveBlendable_InBlendableObject_PropertyAddress;

	private static int RemoveBlendable_InBlendableObject_Offset;

	private static bool OnCameraMeshHiddenChanged_IsValid;

	private static IntPtr OnCameraMeshHiddenChanged_FunctionAddress;

	private static int OnCameraMeshHiddenChanged_ParamsSize;

	private static bool GetCameraView_IsValid;

	private static IntPtr GetCameraView_FunctionAddress;

	private static int GetCameraView_ParamsSize;

	private static bool GetCameraView_DeltaTime_IsValid;

	private static FFieldAddress GetCameraView_DeltaTime_PropertyAddress;

	private static int GetCameraView_DeltaTime_Offset;

	private static bool GetCameraView_DesiredView_IsValid;

	private static FFieldAddress GetCameraView_DesiredView_PropertyAddress;

	private static int GetCameraView_DesiredView_Offset;

	private static bool AddOrUpdateBlendable_IsValid;

	private static IntPtr AddOrUpdateBlendable_FunctionAddress;

	private static int AddOrUpdateBlendable_ParamsSize;

	private static bool AddOrUpdateBlendable_InBlendableObject_IsValid;

	private static FFieldAddress AddOrUpdateBlendable_InBlendableObject_PropertyAddress;

	private static int AddOrUpdateBlendable_InBlendableObject_Offset;

	private static bool AddOrUpdateBlendable_InWeight_IsValid;

	private static FFieldAddress AddOrUpdateBlendable_InWeight_PropertyAddress;

	private static int AddOrUpdateBlendable_InWeight_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.CameraComponent:FieldOfView")]
	public float FieldOfView
	{
		get
		{
			CheckDestroyed();
			if (!FieldOfView_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraComponent:FieldOfView");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FieldOfView_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FieldOfView_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraComponent:FieldOfView");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FieldOfView_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.CameraComponent:OrthoWidth")]
	public float OrthoWidth
	{
		get
		{
			CheckDestroyed();
			if (!OrthoWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraComponent:OrthoWidth");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OrthoWidth_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OrthoWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraComponent:OrthoWidth");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OrthoWidth_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.CameraComponent:OrthoNearClipPlane")]
	public float OrthoNearClipPlane
	{
		get
		{
			CheckDestroyed();
			if (!OrthoNearClipPlane_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraComponent:OrthoNearClipPlane");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OrthoNearClipPlane_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OrthoNearClipPlane_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraComponent:OrthoNearClipPlane");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OrthoNearClipPlane_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.CameraComponent:OrthoFarClipPlane")]
	public float OrthoFarClipPlane
	{
		get
		{
			CheckDestroyed();
			if (!OrthoFarClipPlane_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraComponent:OrthoFarClipPlane");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OrthoFarClipPlane_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OrthoFarClipPlane_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraComponent:OrthoFarClipPlane");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OrthoFarClipPlane_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.CameraComponent:AspectRatio")]
	public float AspectRatio
	{
		get
		{
			CheckDestroyed();
			if (!AspectRatio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraComponent:AspectRatio");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AspectRatio_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AspectRatio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraComponent:AspectRatio");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AspectRatio_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755476750467077uL)]
	[UMetaPath("/Script/Engine.CameraComponent:bConstrainAspectRatio")]
	public bool ConstrainAspectRatio
	{
		get
		{
			CheckDestroyed();
			if (!ConstrainAspectRatio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraComponent:bConstrainAspectRatio");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ConstrainAspectRatio_Offset), 0, ConstrainAspectRatio_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ConstrainAspectRatio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraComponent:bConstrainAspectRatio");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ConstrainAspectRatio_Offset), 0, ConstrainAspectRatio_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759874796978181uL)]
	[UMetaPath("/Script/Engine.CameraComponent:bUseFieldOfViewForLOD")]
	public bool UseFieldOfViewForLOD
	{
		get
		{
			CheckDestroyed();
			if (!UseFieldOfViewForLOD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraComponent:bUseFieldOfViewForLOD");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseFieldOfViewForLOD_Offset), 0, UseFieldOfViewForLOD_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseFieldOfViewForLOD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraComponent:bUseFieldOfViewForLOD");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseFieldOfViewForLOD_Offset), 0, UseFieldOfViewForLOD_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594013189uL)]
	[UMetaPath("/Script/Engine.CameraComponent:bDrawFrustumAllowed")]
	public bool DrawFrustumAllowed
	{
		get
		{
			CheckDestroyed();
			if (!DrawFrustumAllowed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraComponent:bDrawFrustumAllowed");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DrawFrustumAllowed_Offset), 0, DrawFrustumAllowed_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DrawFrustumAllowed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraComponent:bDrawFrustumAllowed");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DrawFrustumAllowed_Offset), 0, DrawFrustumAllowed_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755502520270853uL)]
	[UMetaPath("/Script/Engine.CameraComponent:bCameraMeshHiddenInGame")]
	public bool CameraMeshHiddenInGame
	{
		get
		{
			CheckDestroyed();
			if (!CameraMeshHiddenInGame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraComponent:bCameraMeshHiddenInGame");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CameraMeshHiddenInGame_Offset), 0, CameraMeshHiddenInGame_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CameraMeshHiddenInGame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraComponent:bCameraMeshHiddenInGame");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CameraMeshHiddenInGame_Offset), 0, CameraMeshHiddenInGame_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.CameraComponent:bLockToHmd")]
	public bool LockToHmd
	{
		get
		{
			CheckDestroyed();
			if (!LockToHmd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraComponent:bLockToHmd");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, LockToHmd_Offset), 0, LockToHmd_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LockToHmd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraComponent:bLockToHmd");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, LockToHmd_Offset), 0, LockToHmd_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.CameraComponent:bUsePawnControlRotation")]
	public bool UsePawnControlRotation
	{
		get
		{
			CheckDestroyed();
			if (!UsePawnControlRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraComponent:bUsePawnControlRotation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UsePawnControlRotation_Offset), 0, UsePawnControlRotation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UsePawnControlRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraComponent:bUsePawnControlRotation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UsePawnControlRotation_Offset), 0, UsePawnControlRotation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.CameraComponent:ProjectionMode")]
	public ECameraProjectionMode ProjectionMode
	{
		get
		{
			CheckDestroyed();
			if (!ProjectionMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraComponent:ProjectionMode");
				return ECameraProjectionMode.Perspective;
			}
			return EnumMarshaler<ECameraProjectionMode>.FromNative(IntPtr.Add(base.Address, ProjectionMode_Offset), 0, ProjectionMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ProjectionMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraComponent:ProjectionMode");
			}
			else
			{
				EnumMarshaler<ECameraProjectionMode>.ToNative(IntPtr.Add(base.Address, ProjectionMode_Offset), 0, ProjectionMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12393799221248517uL)]
	[UMetaPath("/Script/Engine.CameraComponent:CameraMesh")]
	protected UStaticMesh CameraMesh
	{
		get
		{
			CheckDestroyed();
			if (!CameraMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraComponent:CameraMesh");
				return null;
			}
			return UObjectMarshaler<UStaticMesh>.FromNative(IntPtr.Add(base.Address, CameraMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraComponent:CameraMesh");
			}
			else
			{
				UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(base.Address, CameraMesh_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.CameraComponent:PostProcessBlendWeight")]
	public float PostProcessBlendWeight
	{
		get
		{
			CheckDestroyed();
			if (!PostProcessBlendWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraComponent:PostProcessBlendWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PostProcessBlendWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PostProcessBlendWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraComponent:PostProcessBlendWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PostProcessBlendWeight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503608217305093uL)]
	[UMetaPath("/Script/Engine.CameraComponent:PostProcessSettings")]
	public FPostProcessSettings PostProcessSettings
	{
		get
		{
			CheckDestroyed();
			if (!PostProcessSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraComponent:PostProcessSettings");
				return default(FPostProcessSettings);
			}
			return FPostProcessSettings.FromNative(IntPtr.Add(base.Address, PostProcessSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PostProcessSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CameraComponent:PostProcessSettings");
			}
			else
			{
				FPostProcessSettings.ToNative(IntPtr.Add(base.Address, PostProcessSettings_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.CameraComponent:SetUseFieldOfViewForLOD")]
	public unsafe void SetUseFieldOfViewForLOD(bool bInUseFieldOfViewForLOD)
	{
		CheckDestroyed();
		if (!SetUseFieldOfViewForLOD_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraComponent:SetUseFieldOfViewForLOD");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetUseFieldOfViewForLOD_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetUseFieldOfViewForLOD_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetUseFieldOfViewForLOD_bInUseFieldOfViewForLOD_Offset), 0, SetUseFieldOfViewForLOD_bInUseFieldOfViewForLOD_PropertyAddress.Address, bInUseFieldOfViewForLOD);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetUseFieldOfViewForLOD_FunctionAddress, intPtr, SetUseFieldOfViewForLOD_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.CameraComponent:SetProjectionMode")]
	public unsafe void SetProjectionMode(ECameraProjectionMode InProjectionMode)
	{
		CheckDestroyed();
		if (!SetProjectionMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraComponent:SetProjectionMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetProjectionMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetProjectionMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ECameraProjectionMode>.ToNative(IntPtr.Add(intPtr, SetProjectionMode_InProjectionMode_Offset), 0, SetProjectionMode_InProjectionMode_PropertyAddress.Address, InProjectionMode);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetProjectionMode_FunctionAddress, intPtr, SetProjectionMode_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.CameraComponent:SetPostProcessBlendWeight")]
	public unsafe void SetPostProcessBlendWeight(float InPostProcessBlendWeight)
	{
		CheckDestroyed();
		if (!SetPostProcessBlendWeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraComponent:SetPostProcessBlendWeight");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPostProcessBlendWeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPostProcessBlendWeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPostProcessBlendWeight_InPostProcessBlendWeight_Offset), 0, SetPostProcessBlendWeight_InPostProcessBlendWeight_PropertyAddress.Address, InPostProcessBlendWeight);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPostProcessBlendWeight_FunctionAddress, intPtr, SetPostProcessBlendWeight_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.CameraComponent:SetOrthoWidth")]
	public unsafe void SetOrthoWidth(float InOrthoWidth)
	{
		CheckDestroyed();
		if (!SetOrthoWidth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraComponent:SetOrthoWidth");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOrthoWidth_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOrthoWidth_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetOrthoWidth_InOrthoWidth_Offset), 0, SetOrthoWidth_InOrthoWidth_PropertyAddress.Address, InOrthoWidth);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOrthoWidth_FunctionAddress, intPtr, SetOrthoWidth_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.CameraComponent:SetOrthoNearClipPlane")]
	public unsafe void SetOrthoNearClipPlane(float InOrthoNearClipPlane)
	{
		CheckDestroyed();
		if (!SetOrthoNearClipPlane_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraComponent:SetOrthoNearClipPlane");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOrthoNearClipPlane_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOrthoNearClipPlane_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetOrthoNearClipPlane_InOrthoNearClipPlane_Offset), 0, SetOrthoNearClipPlane_InOrthoNearClipPlane_PropertyAddress.Address, InOrthoNearClipPlane);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOrthoNearClipPlane_FunctionAddress, intPtr, SetOrthoNearClipPlane_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.CameraComponent:SetOrthoFarClipPlane")]
	public unsafe void SetOrthoFarClipPlane(float InOrthoFarClipPlane)
	{
		CheckDestroyed();
		if (!SetOrthoFarClipPlane_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraComponent:SetOrthoFarClipPlane");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOrthoFarClipPlane_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOrthoFarClipPlane_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetOrthoFarClipPlane_InOrthoFarClipPlane_Offset), 0, SetOrthoFarClipPlane_InOrthoFarClipPlane_PropertyAddress.Address, InOrthoFarClipPlane);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOrthoFarClipPlane_FunctionAddress, intPtr, SetOrthoFarClipPlane_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.CameraComponent:SetFieldOfView")]
	public unsafe void SetFieldOfView(float InFieldOfView)
	{
		CheckDestroyed();
		if (!SetFieldOfView_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraComponent:SetFieldOfView");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFieldOfView_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFieldOfView_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFieldOfView_InFieldOfView_Offset), 0, SetFieldOfView_InFieldOfView_PropertyAddress.Address, InFieldOfView);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFieldOfView_FunctionAddress, intPtr, SetFieldOfView_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.CameraComponent:SetConstraintAspectRatio")]
	public unsafe void SetConstraintAspectRatio(bool bInConstrainAspectRatio)
	{
		CheckDestroyed();
		if (!SetConstraintAspectRatio_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraComponent:SetConstraintAspectRatio");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetConstraintAspectRatio_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetConstraintAspectRatio_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetConstraintAspectRatio_bInConstrainAspectRatio_Offset), 0, SetConstraintAspectRatio_bInConstrainAspectRatio_PropertyAddress.Address, bInConstrainAspectRatio);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetConstraintAspectRatio_FunctionAddress, intPtr, SetConstraintAspectRatio_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.CameraComponent:SetAspectRatio")]
	public unsafe void SetAspectRatio(float InAspectRatio)
	{
		CheckDestroyed();
		if (!SetAspectRatio_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraComponent:SetAspectRatio");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAspectRatio_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAspectRatio_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAspectRatio_InAspectRatio_Offset), 0, SetAspectRatio_InAspectRatio_PropertyAddress.Address, InAspectRatio);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAspectRatio_FunctionAddress, intPtr, SetAspectRatio_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.CameraComponent:RemoveBlendable")]
	public unsafe void RemoveBlendable(IBlendableInterface InBlendableObject)
	{
		CheckDestroyed();
		if (!RemoveBlendable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraComponent:RemoveBlendable");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveBlendable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveBlendable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		InterfaceMarshaler<IBlendableInterface>.ToNative(IntPtr.Add(intPtr, RemoveBlendable_InBlendableObject_Offset), 0, RemoveBlendable_InBlendableObject_PropertyAddress.Address, InBlendableObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveBlendable_FunctionAddress, intPtr, RemoveBlendable_ParamsSize);
	}

	[UFunction(Flags = 67634177u)]
	[UMetaPath("/Script/Engine.CameraComponent:OnCameraMeshHiddenChanged")]
	protected unsafe void OnCameraMeshHiddenChanged()
	{
		CheckDestroyed();
		if (!OnCameraMeshHiddenChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraComponent:OnCameraMeshHiddenChanged");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnCameraMeshHiddenChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnCameraMeshHiddenChanged_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnCameraMeshHiddenChanged_FunctionAddress, argsSize: OnCameraMeshHiddenChanged_ParamsSize);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.CameraComponent:GetCameraView")]
	public unsafe void GetCameraView(float DeltaTime, out FMinimalViewInfo DesiredView)
	{
		CheckDestroyed();
		if (!GetCameraView_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraComponent:GetCameraView");
			DesiredView = default(FMinimalViewInfo);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCameraView_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCameraView_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetCameraView_DeltaTime_Offset), 0, GetCameraView_DeltaTime_PropertyAddress.Address, DeltaTime);
		NativeReflection.InitializeValue_InContainer(GetCameraView_DesiredView_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCameraView_FunctionAddress, intPtr, GetCameraView_ParamsSize);
		DesiredView = FMinimalViewInfo.FromNative(IntPtr.Add(intPtr, GetCameraView_DesiredView_Offset), 0, GetCameraView_DesiredView_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCameraView_DesiredView_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.CameraComponent:AddOrUpdateBlendable")]
	public unsafe void AddOrUpdateBlendable(IBlendableInterface InBlendableObject, float InWeight = 1f)
	{
		CheckDestroyed();
		if (!AddOrUpdateBlendable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CameraComponent:AddOrUpdateBlendable");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddOrUpdateBlendable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddOrUpdateBlendable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		InterfaceMarshaler<IBlendableInterface>.ToNative(IntPtr.Add(intPtr, AddOrUpdateBlendable_InBlendableObject_Offset), 0, AddOrUpdateBlendable_InBlendableObject_PropertyAddress.Address, InBlendableObject);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddOrUpdateBlendable_InWeight_Offset), 0, AddOrUpdateBlendable_InWeight_PropertyAddress.Address, InWeight);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddOrUpdateBlendable_FunctionAddress, intPtr, AddOrUpdateBlendable_ParamsSize);
	}

	static UCameraComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCameraComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCameraComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.CameraComponent");
		FieldOfView_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FieldOfView");
		FieldOfView_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FieldOfView", Classes.FFloatProperty);
		OrthoWidth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OrthoWidth");
		OrthoWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OrthoWidth", Classes.FFloatProperty);
		OrthoNearClipPlane_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OrthoNearClipPlane");
		OrthoNearClipPlane_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OrthoNearClipPlane", Classes.FFloatProperty);
		OrthoFarClipPlane_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OrthoFarClipPlane");
		OrthoFarClipPlane_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OrthoFarClipPlane", Classes.FFloatProperty);
		AspectRatio_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AspectRatio");
		AspectRatio_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AspectRatio", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ConstrainAspectRatio_PropertyAddress, intPtr, "bConstrainAspectRatio");
		ConstrainAspectRatio_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bConstrainAspectRatio");
		ConstrainAspectRatio_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bConstrainAspectRatio", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseFieldOfViewForLOD_PropertyAddress, intPtr, "bUseFieldOfViewForLOD");
		UseFieldOfViewForLOD_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseFieldOfViewForLOD");
		UseFieldOfViewForLOD_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseFieldOfViewForLOD", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawFrustumAllowed_PropertyAddress, intPtr, "bDrawFrustumAllowed");
		DrawFrustumAllowed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDrawFrustumAllowed");
		DrawFrustumAllowed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDrawFrustumAllowed", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CameraMeshHiddenInGame_PropertyAddress, intPtr, "bCameraMeshHiddenInGame");
		CameraMeshHiddenInGame_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCameraMeshHiddenInGame");
		CameraMeshHiddenInGame_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCameraMeshHiddenInGame", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LockToHmd_PropertyAddress, intPtr, "bLockToHmd");
		LockToHmd_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bLockToHmd");
		LockToHmd_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bLockToHmd", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UsePawnControlRotation_PropertyAddress, intPtr, "bUsePawnControlRotation");
		UsePawnControlRotation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUsePawnControlRotation");
		UsePawnControlRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUsePawnControlRotation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ProjectionMode_PropertyAddress, intPtr, "ProjectionMode");
		ProjectionMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ProjectionMode");
		ProjectionMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ProjectionMode", Classes.FByteProperty);
		CameraMesh_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CameraMesh");
		CameraMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CameraMesh", Classes.FObjectProperty);
		PostProcessBlendWeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PostProcessBlendWeight");
		PostProcessBlendWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PostProcessBlendWeight", Classes.FFloatProperty);
		PostProcessSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PostProcessSettings");
		PostProcessSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PostProcessSettings", Classes.FStructProperty);
		SetUseFieldOfViewForLOD_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetUseFieldOfViewForLOD");
		SetUseFieldOfViewForLOD_ParamsSize = NativeReflection.GetFunctionParamsSize(SetUseFieldOfViewForLOD_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetUseFieldOfViewForLOD_bInUseFieldOfViewForLOD_PropertyAddress, SetUseFieldOfViewForLOD_FunctionAddress, "bInUseFieldOfViewForLOD");
		SetUseFieldOfViewForLOD_bInUseFieldOfViewForLOD_Offset = NativeReflectionCached.GetPropertyOffset(SetUseFieldOfViewForLOD_FunctionAddress, "bInUseFieldOfViewForLOD");
		SetUseFieldOfViewForLOD_bInUseFieldOfViewForLOD_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUseFieldOfViewForLOD_FunctionAddress, "bInUseFieldOfViewForLOD", Classes.FBoolProperty);
		SetUseFieldOfViewForLOD_IsValid = SetUseFieldOfViewForLOD_FunctionAddress != IntPtr.Zero && SetUseFieldOfViewForLOD_bInUseFieldOfViewForLOD_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraComponent:SetUseFieldOfViewForLOD", SetUseFieldOfViewForLOD_IsValid);
		SetProjectionMode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetProjectionMode");
		SetProjectionMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetProjectionMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetProjectionMode_InProjectionMode_PropertyAddress, SetProjectionMode_FunctionAddress, "InProjectionMode");
		SetProjectionMode_InProjectionMode_Offset = NativeReflectionCached.GetPropertyOffset(SetProjectionMode_FunctionAddress, "InProjectionMode");
		SetProjectionMode_InProjectionMode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetProjectionMode_FunctionAddress, "InProjectionMode", Classes.FByteProperty);
		SetProjectionMode_IsValid = SetProjectionMode_FunctionAddress != IntPtr.Zero && SetProjectionMode_InProjectionMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraComponent:SetProjectionMode", SetProjectionMode_IsValid);
		SetPostProcessBlendWeight_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPostProcessBlendWeight");
		SetPostProcessBlendWeight_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPostProcessBlendWeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPostProcessBlendWeight_InPostProcessBlendWeight_PropertyAddress, SetPostProcessBlendWeight_FunctionAddress, "InPostProcessBlendWeight");
		SetPostProcessBlendWeight_InPostProcessBlendWeight_Offset = NativeReflectionCached.GetPropertyOffset(SetPostProcessBlendWeight_FunctionAddress, "InPostProcessBlendWeight");
		SetPostProcessBlendWeight_InPostProcessBlendWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPostProcessBlendWeight_FunctionAddress, "InPostProcessBlendWeight", Classes.FFloatProperty);
		SetPostProcessBlendWeight_IsValid = SetPostProcessBlendWeight_FunctionAddress != IntPtr.Zero && SetPostProcessBlendWeight_InPostProcessBlendWeight_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraComponent:SetPostProcessBlendWeight", SetPostProcessBlendWeight_IsValid);
		SetOrthoWidth_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOrthoWidth");
		SetOrthoWidth_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOrthoWidth_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOrthoWidth_InOrthoWidth_PropertyAddress, SetOrthoWidth_FunctionAddress, "InOrthoWidth");
		SetOrthoWidth_InOrthoWidth_Offset = NativeReflectionCached.GetPropertyOffset(SetOrthoWidth_FunctionAddress, "InOrthoWidth");
		SetOrthoWidth_InOrthoWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOrthoWidth_FunctionAddress, "InOrthoWidth", Classes.FFloatProperty);
		SetOrthoWidth_IsValid = SetOrthoWidth_FunctionAddress != IntPtr.Zero && SetOrthoWidth_InOrthoWidth_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraComponent:SetOrthoWidth", SetOrthoWidth_IsValid);
		SetOrthoNearClipPlane_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOrthoNearClipPlane");
		SetOrthoNearClipPlane_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOrthoNearClipPlane_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOrthoNearClipPlane_InOrthoNearClipPlane_PropertyAddress, SetOrthoNearClipPlane_FunctionAddress, "InOrthoNearClipPlane");
		SetOrthoNearClipPlane_InOrthoNearClipPlane_Offset = NativeReflectionCached.GetPropertyOffset(SetOrthoNearClipPlane_FunctionAddress, "InOrthoNearClipPlane");
		SetOrthoNearClipPlane_InOrthoNearClipPlane_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOrthoNearClipPlane_FunctionAddress, "InOrthoNearClipPlane", Classes.FFloatProperty);
		SetOrthoNearClipPlane_IsValid = SetOrthoNearClipPlane_FunctionAddress != IntPtr.Zero && SetOrthoNearClipPlane_InOrthoNearClipPlane_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraComponent:SetOrthoNearClipPlane", SetOrthoNearClipPlane_IsValid);
		SetOrthoFarClipPlane_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOrthoFarClipPlane");
		SetOrthoFarClipPlane_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOrthoFarClipPlane_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOrthoFarClipPlane_InOrthoFarClipPlane_PropertyAddress, SetOrthoFarClipPlane_FunctionAddress, "InOrthoFarClipPlane");
		SetOrthoFarClipPlane_InOrthoFarClipPlane_Offset = NativeReflectionCached.GetPropertyOffset(SetOrthoFarClipPlane_FunctionAddress, "InOrthoFarClipPlane");
		SetOrthoFarClipPlane_InOrthoFarClipPlane_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOrthoFarClipPlane_FunctionAddress, "InOrthoFarClipPlane", Classes.FFloatProperty);
		SetOrthoFarClipPlane_IsValid = SetOrthoFarClipPlane_FunctionAddress != IntPtr.Zero && SetOrthoFarClipPlane_InOrthoFarClipPlane_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraComponent:SetOrthoFarClipPlane", SetOrthoFarClipPlane_IsValid);
		SetFieldOfView_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFieldOfView");
		SetFieldOfView_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFieldOfView_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFieldOfView_InFieldOfView_PropertyAddress, SetFieldOfView_FunctionAddress, "InFieldOfView");
		SetFieldOfView_InFieldOfView_Offset = NativeReflectionCached.GetPropertyOffset(SetFieldOfView_FunctionAddress, "InFieldOfView");
		SetFieldOfView_InFieldOfView_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFieldOfView_FunctionAddress, "InFieldOfView", Classes.FFloatProperty);
		SetFieldOfView_IsValid = SetFieldOfView_FunctionAddress != IntPtr.Zero && SetFieldOfView_InFieldOfView_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraComponent:SetFieldOfView", SetFieldOfView_IsValid);
		SetConstraintAspectRatio_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetConstraintAspectRatio");
		SetConstraintAspectRatio_ParamsSize = NativeReflection.GetFunctionParamsSize(SetConstraintAspectRatio_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetConstraintAspectRatio_bInConstrainAspectRatio_PropertyAddress, SetConstraintAspectRatio_FunctionAddress, "bInConstrainAspectRatio");
		SetConstraintAspectRatio_bInConstrainAspectRatio_Offset = NativeReflectionCached.GetPropertyOffset(SetConstraintAspectRatio_FunctionAddress, "bInConstrainAspectRatio");
		SetConstraintAspectRatio_bInConstrainAspectRatio_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConstraintAspectRatio_FunctionAddress, "bInConstrainAspectRatio", Classes.FBoolProperty);
		SetConstraintAspectRatio_IsValid = SetConstraintAspectRatio_FunctionAddress != IntPtr.Zero && SetConstraintAspectRatio_bInConstrainAspectRatio_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraComponent:SetConstraintAspectRatio", SetConstraintAspectRatio_IsValid);
		SetAspectRatio_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAspectRatio");
		SetAspectRatio_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAspectRatio_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAspectRatio_InAspectRatio_PropertyAddress, SetAspectRatio_FunctionAddress, "InAspectRatio");
		SetAspectRatio_InAspectRatio_Offset = NativeReflectionCached.GetPropertyOffset(SetAspectRatio_FunctionAddress, "InAspectRatio");
		SetAspectRatio_InAspectRatio_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAspectRatio_FunctionAddress, "InAspectRatio", Classes.FFloatProperty);
		SetAspectRatio_IsValid = SetAspectRatio_FunctionAddress != IntPtr.Zero && SetAspectRatio_InAspectRatio_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraComponent:SetAspectRatio", SetAspectRatio_IsValid);
		RemoveBlendable_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveBlendable");
		RemoveBlendable_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveBlendable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveBlendable_InBlendableObject_PropertyAddress, RemoveBlendable_FunctionAddress, "InBlendableObject");
		RemoveBlendable_InBlendableObject_Offset = NativeReflectionCached.GetPropertyOffset(RemoveBlendable_FunctionAddress, "InBlendableObject");
		RemoveBlendable_InBlendableObject_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveBlendable_FunctionAddress, "InBlendableObject", Classes.FInterfaceProperty);
		RemoveBlendable_IsValid = RemoveBlendable_FunctionAddress != IntPtr.Zero && RemoveBlendable_InBlendableObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraComponent:RemoveBlendable", RemoveBlendable_IsValid);
		OnCameraMeshHiddenChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnCameraMeshHiddenChanged");
		OnCameraMeshHiddenChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnCameraMeshHiddenChanged_FunctionAddress);
		OnCameraMeshHiddenChanged_IsValid = OnCameraMeshHiddenChanged_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraComponent:OnCameraMeshHiddenChanged", OnCameraMeshHiddenChanged_IsValid);
		GetCameraView_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCameraView");
		GetCameraView_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCameraView_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCameraView_DeltaTime_PropertyAddress, GetCameraView_FunctionAddress, "DeltaTime");
		GetCameraView_DeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(GetCameraView_FunctionAddress, "DeltaTime");
		GetCameraView_DeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCameraView_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCameraView_DesiredView_PropertyAddress, GetCameraView_FunctionAddress, "DesiredView");
		GetCameraView_DesiredView_Offset = NativeReflectionCached.GetPropertyOffset(GetCameraView_FunctionAddress, "DesiredView");
		GetCameraView_DesiredView_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCameraView_FunctionAddress, "DesiredView", Classes.FStructProperty);
		GetCameraView_IsValid = GetCameraView_FunctionAddress != IntPtr.Zero && GetCameraView_DeltaTime_IsValid && GetCameraView_DesiredView_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraComponent:GetCameraView", GetCameraView_IsValid);
		AddOrUpdateBlendable_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddOrUpdateBlendable");
		AddOrUpdateBlendable_ParamsSize = NativeReflection.GetFunctionParamsSize(AddOrUpdateBlendable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddOrUpdateBlendable_InBlendableObject_PropertyAddress, AddOrUpdateBlendable_FunctionAddress, "InBlendableObject");
		AddOrUpdateBlendable_InBlendableObject_Offset = NativeReflectionCached.GetPropertyOffset(AddOrUpdateBlendable_FunctionAddress, "InBlendableObject");
		AddOrUpdateBlendable_InBlendableObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AddOrUpdateBlendable_FunctionAddress, "InBlendableObject", Classes.FInterfaceProperty);
		NativeReflectionCached.GetPropertyRef(ref AddOrUpdateBlendable_InWeight_PropertyAddress, AddOrUpdateBlendable_FunctionAddress, "InWeight");
		AddOrUpdateBlendable_InWeight_Offset = NativeReflectionCached.GetPropertyOffset(AddOrUpdateBlendable_FunctionAddress, "InWeight");
		AddOrUpdateBlendable_InWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(AddOrUpdateBlendable_FunctionAddress, "InWeight", Classes.FFloatProperty);
		AddOrUpdateBlendable_IsValid = AddOrUpdateBlendable_FunctionAddress != IntPtr.Zero && AddOrUpdateBlendable_InBlendableObject_IsValid && AddOrUpdateBlendable_InWeight_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CameraComponent:AddOrUpdateBlendable", AddOrUpdateBlendable_IsValid);
	}
}
