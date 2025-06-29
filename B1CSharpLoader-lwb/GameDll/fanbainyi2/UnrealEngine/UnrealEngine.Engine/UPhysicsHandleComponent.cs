using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821043364uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.PhysicsHandleComponent", "Engine", UnrealModuleType.Engine)]
public class UPhysicsHandleComponent : UActorComponent
{
	private static bool SoftAngularConstraint_IsValid;

	private static FFieldAddress SoftAngularConstraint_PropertyAddress;

	private static int SoftAngularConstraint_Offset;

	private static bool SoftLinearConstraint_IsValid;

	private static FFieldAddress SoftLinearConstraint_PropertyAddress;

	private static int SoftLinearConstraint_Offset;

	private static bool InterpolateTarget_IsValid;

	private static FFieldAddress InterpolateTarget_PropertyAddress;

	private static int InterpolateTarget_Offset;

	private static bool LinearDamping_IsValid;

	private static int LinearDamping_Offset;

	private static bool LinearStiffness_IsValid;

	private static int LinearStiffness_Offset;

	private static bool AngularDamping_IsValid;

	private static int AngularDamping_Offset;

	private static bool AngularStiffness_IsValid;

	private static int AngularStiffness_Offset;

	private static bool InterpolationSpeed_IsValid;

	private static int InterpolationSpeed_Offset;

	private static bool SetTargetRotation_IsValid;

	private static IntPtr SetTargetRotation_FunctionAddress;

	private static int SetTargetRotation_ParamsSize;

	private static bool SetTargetRotation_NewRotation_IsValid;

	private static FFieldAddress SetTargetRotation_NewRotation_PropertyAddress;

	private static int SetTargetRotation_NewRotation_Offset;

	private static bool SetTargetLocationAndRotation_IsValid;

	private static IntPtr SetTargetLocationAndRotation_FunctionAddress;

	private static int SetTargetLocationAndRotation_ParamsSize;

	private static bool SetTargetLocationAndRotation_NewLocation_IsValid;

	private static FFieldAddress SetTargetLocationAndRotation_NewLocation_PropertyAddress;

	private static int SetTargetLocationAndRotation_NewLocation_Offset;

	private static bool SetTargetLocationAndRotation_NewRotation_IsValid;

	private static FFieldAddress SetTargetLocationAndRotation_NewRotation_PropertyAddress;

	private static int SetTargetLocationAndRotation_NewRotation_Offset;

	private static bool SetTargetLocation_IsValid;

	private static IntPtr SetTargetLocation_FunctionAddress;

	private static int SetTargetLocation_ParamsSize;

	private static bool SetTargetLocation_NewLocation_IsValid;

	private static FFieldAddress SetTargetLocation_NewLocation_PropertyAddress;

	private static int SetTargetLocation_NewLocation_Offset;

	private static bool SetLinearStiffness_IsValid;

	private static IntPtr SetLinearStiffness_FunctionAddress;

	private static int SetLinearStiffness_ParamsSize;

	private static bool SetLinearStiffness_NewLinearStiffness_IsValid;

	private static FFieldAddress SetLinearStiffness_NewLinearStiffness_PropertyAddress;

	private static int SetLinearStiffness_NewLinearStiffness_Offset;

	private static bool SetLinearDamping_IsValid;

	private static IntPtr SetLinearDamping_FunctionAddress;

	private static int SetLinearDamping_ParamsSize;

	private static bool SetLinearDamping_NewLinearDamping_IsValid;

	private static FFieldAddress SetLinearDamping_NewLinearDamping_PropertyAddress;

	private static int SetLinearDamping_NewLinearDamping_Offset;

	private static bool SetInterpolationSpeed_IsValid;

	private static IntPtr SetInterpolationSpeed_FunctionAddress;

	private static int SetInterpolationSpeed_ParamsSize;

	private static bool SetInterpolationSpeed_NewInterpolationSpeed_IsValid;

	private static FFieldAddress SetInterpolationSpeed_NewInterpolationSpeed_PropertyAddress;

	private static int SetInterpolationSpeed_NewInterpolationSpeed_Offset;

	private static bool SetAngularStiffness_IsValid;

	private static IntPtr SetAngularStiffness_FunctionAddress;

	private static int SetAngularStiffness_ParamsSize;

	private static bool SetAngularStiffness_NewAngularStiffness_IsValid;

	private static FFieldAddress SetAngularStiffness_NewAngularStiffness_PropertyAddress;

	private static int SetAngularStiffness_NewAngularStiffness_Offset;

	private static bool SetAngularDamping_IsValid;

	private static IntPtr SetAngularDamping_FunctionAddress;

	private static int SetAngularDamping_ParamsSize;

	private static bool SetAngularDamping_NewAngularDamping_IsValid;

	private static FFieldAddress SetAngularDamping_NewAngularDamping_PropertyAddress;

	private static int SetAngularDamping_NewAngularDamping_Offset;

	private static bool ReleaseComponent_IsValid;

	private static IntPtr ReleaseComponent_FunctionAddress;

	private static int ReleaseComponent_ParamsSize;

	private static bool GrabComponentAtLocationWithRotation_IsValid;

	private static IntPtr GrabComponentAtLocationWithRotation_FunctionAddress;

	private static int GrabComponentAtLocationWithRotation_ParamsSize;

	private static bool GrabComponentAtLocationWithRotation_Component_IsValid;

	private static FFieldAddress GrabComponentAtLocationWithRotation_Component_PropertyAddress;

	private static int GrabComponentAtLocationWithRotation_Component_Offset;

	private static bool GrabComponentAtLocationWithRotation_InBoneName_IsValid;

	private static FFieldAddress GrabComponentAtLocationWithRotation_InBoneName_PropertyAddress;

	private static int GrabComponentAtLocationWithRotation_InBoneName_Offset;

	private static bool GrabComponentAtLocationWithRotation_Location_IsValid;

	private static FFieldAddress GrabComponentAtLocationWithRotation_Location_PropertyAddress;

	private static int GrabComponentAtLocationWithRotation_Location_Offset;

	private static bool GrabComponentAtLocationWithRotation_Rotation_IsValid;

	private static FFieldAddress GrabComponentAtLocationWithRotation_Rotation_PropertyAddress;

	private static int GrabComponentAtLocationWithRotation_Rotation_Offset;

	private static bool GrabComponentAtLocation_IsValid;

	private static IntPtr GrabComponentAtLocation_FunctionAddress;

	private static int GrabComponentAtLocation_ParamsSize;

	private static bool GrabComponentAtLocation_Component_IsValid;

	private static FFieldAddress GrabComponentAtLocation_Component_PropertyAddress;

	private static int GrabComponentAtLocation_Component_Offset;

	private static bool GrabComponentAtLocation_InBoneName_IsValid;

	private static FFieldAddress GrabComponentAtLocation_InBoneName_PropertyAddress;

	private static int GrabComponentAtLocation_InBoneName_Offset;

	private static bool GrabComponentAtLocation_GrabLocation_IsValid;

	private static FFieldAddress GrabComponentAtLocation_GrabLocation_PropertyAddress;

	private static int GrabComponentAtLocation_GrabLocation_Offset;

	private static bool GetTargetLocationAndRotation_IsValid;

	private static IntPtr GetTargetLocationAndRotation_FunctionAddress;

	private static int GetTargetLocationAndRotation_ParamsSize;

	private static bool GetTargetLocationAndRotation_TargetLocation_IsValid;

	private static FFieldAddress GetTargetLocationAndRotation_TargetLocation_PropertyAddress;

	private static int GetTargetLocationAndRotation_TargetLocation_Offset;

	private static bool GetTargetLocationAndRotation_TargetRotation_IsValid;

	private static FFieldAddress GetTargetLocationAndRotation_TargetRotation_PropertyAddress;

	private static int GetTargetLocationAndRotation_TargetRotation_Offset;

	private static bool GetGrabbedComponent_IsValid;

	private static IntPtr GetGrabbedComponent_FunctionAddress;

	private static int GetGrabbedComponent_ParamsSize;

	private static bool GetGrabbedComponent_ReturnValue_IsValid;

	private static FFieldAddress GetGrabbedComponent_ReturnValue_PropertyAddress;

	private static int GetGrabbedComponent_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.PhysicsHandleComponent:bSoftAngularConstraint")]
	public bool SoftAngularConstraint
	{
		get
		{
			CheckDestroyed();
			if (!SoftAngularConstraint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsHandleComponent:bSoftAngularConstraint");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SoftAngularConstraint_Offset), 0, SoftAngularConstraint_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SoftAngularConstraint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsHandleComponent:bSoftAngularConstraint");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SoftAngularConstraint_Offset), 0, SoftAngularConstraint_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.PhysicsHandleComponent:bSoftLinearConstraint")]
	public bool SoftLinearConstraint
	{
		get
		{
			CheckDestroyed();
			if (!SoftLinearConstraint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsHandleComponent:bSoftLinearConstraint");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SoftLinearConstraint_Offset), 0, SoftLinearConstraint_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SoftLinearConstraint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsHandleComponent:bSoftLinearConstraint");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SoftLinearConstraint_Offset), 0, SoftLinearConstraint_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.PhysicsHandleComponent:bInterpolateTarget")]
	public bool InterpolateTarget
	{
		get
		{
			CheckDestroyed();
			if (!InterpolateTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsHandleComponent:bInterpolateTarget");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InterpolateTarget_Offset), 0, InterpolateTarget_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InterpolateTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsHandleComponent:bInterpolateTarget");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, InterpolateTarget_Offset), 0, InterpolateTarget_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.PhysicsHandleComponent:LinearDamping")]
	public float LinearDamping
	{
		get
		{
			CheckDestroyed();
			if (!LinearDamping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsHandleComponent:LinearDamping");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LinearDamping_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LinearDamping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsHandleComponent:LinearDamping");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LinearDamping_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.PhysicsHandleComponent:LinearStiffness")]
	public float LinearStiffness
	{
		get
		{
			CheckDestroyed();
			if (!LinearStiffness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsHandleComponent:LinearStiffness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LinearStiffness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LinearStiffness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsHandleComponent:LinearStiffness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LinearStiffness_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.PhysicsHandleComponent:AngularDamping")]
	public float AngularDamping
	{
		get
		{
			CheckDestroyed();
			if (!AngularDamping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsHandleComponent:AngularDamping");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AngularDamping_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AngularDamping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsHandleComponent:AngularDamping");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AngularDamping_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.PhysicsHandleComponent:AngularStiffness")]
	public float AngularStiffness
	{
		get
		{
			CheckDestroyed();
			if (!AngularStiffness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsHandleComponent:AngularStiffness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AngularStiffness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AngularStiffness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsHandleComponent:AngularStiffness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AngularStiffness_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.PhysicsHandleComponent:InterpolationSpeed")]
	public float InterpolationSpeed
	{
		get
		{
			CheckDestroyed();
			if (!InterpolationSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsHandleComponent:InterpolationSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InterpolationSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InterpolationSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsHandleComponent:InterpolationSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InterpolationSpeed_Offset), value);
			}
		}
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.PhysicsHandleComponent:SetTargetRotation")]
	public unsafe void SetTargetRotation(FRotator NewRotation)
	{
		CheckDestroyed();
		if (!SetTargetRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsHandleComponent:SetTargetRotation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTargetRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTargetRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SetTargetRotation_NewRotation_Offset), 0, SetTargetRotation_NewRotation_PropertyAddress.Address, NewRotation);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTargetRotation_FunctionAddress, intPtr, SetTargetRotation_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.PhysicsHandleComponent:SetTargetLocationAndRotation")]
	public unsafe void SetTargetLocationAndRotation(FVector NewLocation, FRotator NewRotation)
	{
		CheckDestroyed();
		if (!SetTargetLocationAndRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsHandleComponent:SetTargetLocationAndRotation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTargetLocationAndRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTargetLocationAndRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetTargetLocationAndRotation_NewLocation_Offset), 0, SetTargetLocationAndRotation_NewLocation_PropertyAddress.Address, NewLocation);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SetTargetLocationAndRotation_NewRotation_Offset), 0, SetTargetLocationAndRotation_NewRotation_PropertyAddress.Address, NewRotation);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTargetLocationAndRotation_FunctionAddress, intPtr, SetTargetLocationAndRotation_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.PhysicsHandleComponent:SetTargetLocation")]
	public unsafe void SetTargetLocation(FVector NewLocation)
	{
		CheckDestroyed();
		if (!SetTargetLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsHandleComponent:SetTargetLocation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTargetLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTargetLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetTargetLocation_NewLocation_Offset), 0, SetTargetLocation_NewLocation_PropertyAddress.Address, NewLocation);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTargetLocation_FunctionAddress, intPtr, SetTargetLocation_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PhysicsHandleComponent:SetLinearStiffness")]
	public unsafe void SetLinearStiffness(float NewLinearStiffness)
	{
		CheckDestroyed();
		if (!SetLinearStiffness_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsHandleComponent:SetLinearStiffness");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLinearStiffness_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLinearStiffness_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLinearStiffness_NewLinearStiffness_Offset), 0, SetLinearStiffness_NewLinearStiffness_PropertyAddress.Address, NewLinearStiffness);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLinearStiffness_FunctionAddress, intPtr, SetLinearStiffness_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PhysicsHandleComponent:SetLinearDamping")]
	public unsafe void SetLinearDamping(float NewLinearDamping)
	{
		CheckDestroyed();
		if (!SetLinearDamping_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsHandleComponent:SetLinearDamping");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLinearDamping_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLinearDamping_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLinearDamping_NewLinearDamping_Offset), 0, SetLinearDamping_NewLinearDamping_PropertyAddress.Address, NewLinearDamping);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLinearDamping_FunctionAddress, intPtr, SetLinearDamping_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PhysicsHandleComponent:SetInterpolationSpeed")]
	public unsafe void SetInterpolationSpeed(float NewInterpolationSpeed)
	{
		CheckDestroyed();
		if (!SetInterpolationSpeed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsHandleComponent:SetInterpolationSpeed");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInterpolationSpeed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInterpolationSpeed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetInterpolationSpeed_NewInterpolationSpeed_Offset), 0, SetInterpolationSpeed_NewInterpolationSpeed_PropertyAddress.Address, NewInterpolationSpeed);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetInterpolationSpeed_FunctionAddress, intPtr, SetInterpolationSpeed_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PhysicsHandleComponent:SetAngularStiffness")]
	public unsafe void SetAngularStiffness(float NewAngularStiffness)
	{
		CheckDestroyed();
		if (!SetAngularStiffness_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsHandleComponent:SetAngularStiffness");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAngularStiffness_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAngularStiffness_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAngularStiffness_NewAngularStiffness_Offset), 0, SetAngularStiffness_NewAngularStiffness_PropertyAddress.Address, NewAngularStiffness);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAngularStiffness_FunctionAddress, intPtr, SetAngularStiffness_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PhysicsHandleComponent:SetAngularDamping")]
	public unsafe void SetAngularDamping(float NewAngularDamping)
	{
		CheckDestroyed();
		if (!SetAngularDamping_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsHandleComponent:SetAngularDamping");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAngularDamping_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAngularDamping_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAngularDamping_NewAngularDamping_Offset), 0, SetAngularDamping_NewAngularDamping_PropertyAddress.Address, NewAngularDamping);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAngularDamping_FunctionAddress, intPtr, SetAngularDamping_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.PhysicsHandleComponent:ReleaseComponent")]
	public unsafe void ReleaseComponent()
	{
		CheckDestroyed();
		if (!ReleaseComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsHandleComponent:ReleaseComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReleaseComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReleaseComponent_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReleaseComponent_FunctionAddress, argsSize: ReleaseComponent_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.PhysicsHandleComponent:GrabComponentAtLocationWithRotation")]
	public unsafe void GrabComponentAtLocationWithRotation(UPrimitiveComponent Component, FName InBoneName, FVector Location, FRotator Rotation)
	{
		CheckDestroyed();
		if (!GrabComponentAtLocationWithRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsHandleComponent:GrabComponentAtLocationWithRotation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GrabComponentAtLocationWithRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GrabComponentAtLocationWithRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, GrabComponentAtLocationWithRotation_Component_Offset), 0, GrabComponentAtLocationWithRotation_Component_PropertyAddress.Address, Component);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GrabComponentAtLocationWithRotation_InBoneName_Offset), 0, GrabComponentAtLocationWithRotation_InBoneName_PropertyAddress.Address, InBoneName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, GrabComponentAtLocationWithRotation_Location_Offset), 0, GrabComponentAtLocationWithRotation_Location_PropertyAddress.Address, Location);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, GrabComponentAtLocationWithRotation_Rotation_Offset), 0, GrabComponentAtLocationWithRotation_Rotation_PropertyAddress.Address, Rotation);
		NativeReflection.InvokeFunctionOptimized(base.Address, GrabComponentAtLocationWithRotation_FunctionAddress, intPtr, GrabComponentAtLocationWithRotation_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.PhysicsHandleComponent:GrabComponentAtLocation")]
	public unsafe void GrabComponentAtLocation(UPrimitiveComponent Component, FName InBoneName, FVector GrabLocation)
	{
		CheckDestroyed();
		if (!GrabComponentAtLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsHandleComponent:GrabComponentAtLocation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GrabComponentAtLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GrabComponentAtLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, GrabComponentAtLocation_Component_Offset), 0, GrabComponentAtLocation_Component_PropertyAddress.Address, Component);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GrabComponentAtLocation_InBoneName_Offset), 0, GrabComponentAtLocation_InBoneName_PropertyAddress.Address, InBoneName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, GrabComponentAtLocation_GrabLocation_Offset), 0, GrabComponentAtLocation_GrabLocation_PropertyAddress.Address, GrabLocation);
		NativeReflection.InvokeFunctionOptimized(base.Address, GrabComponentAtLocation_FunctionAddress, intPtr, GrabComponentAtLocation_ParamsSize);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/Engine.PhysicsHandleComponent:GetTargetLocationAndRotation")]
	public unsafe void GetTargetLocationAndRotation(out FVector TargetLocation, out FRotator TargetRotation)
	{
		CheckDestroyed();
		if (!GetTargetLocationAndRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsHandleComponent:GetTargetLocationAndRotation");
			TargetLocation = default(FVector);
			TargetRotation = default(FRotator);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTargetLocationAndRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTargetLocationAndRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTargetLocationAndRotation_FunctionAddress, intPtr, GetTargetLocationAndRotation_ParamsSize);
		TargetLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetTargetLocationAndRotation_TargetLocation_Offset), 0, GetTargetLocationAndRotation_TargetLocation_PropertyAddress.Address);
		TargetRotation = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetTargetLocationAndRotation_TargetRotation_Offset), 0, GetTargetLocationAndRotation_TargetRotation_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.PhysicsHandleComponent:GetGrabbedComponent")]
	public unsafe UPrimitiveComponent GetGrabbedComponent()
	{
		CheckDestroyed();
		if (!GetGrabbedComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsHandleComponent:GetGrabbedComponent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGrabbedComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGrabbedComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGrabbedComponent_FunctionAddress, intPtr, GetGrabbedComponent_ParamsSize);
		return UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(intPtr, GetGrabbedComponent_ReturnValue_Offset), 0, GetGrabbedComponent_ReturnValue_PropertyAddress.Address);
	}

	static UPhysicsHandleComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPhysicsHandleComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPhysicsHandleComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.PhysicsHandleComponent");
		NativeReflectionCached.GetPropertyRef(ref SoftAngularConstraint_PropertyAddress, intPtr, "bSoftAngularConstraint");
		SoftAngularConstraint_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSoftAngularConstraint");
		SoftAngularConstraint_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSoftAngularConstraint", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SoftLinearConstraint_PropertyAddress, intPtr, "bSoftLinearConstraint");
		SoftLinearConstraint_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSoftLinearConstraint");
		SoftLinearConstraint_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSoftLinearConstraint", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref InterpolateTarget_PropertyAddress, intPtr, "bInterpolateTarget");
		InterpolateTarget_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bInterpolateTarget");
		InterpolateTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bInterpolateTarget", Classes.FBoolProperty);
		LinearDamping_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LinearDamping");
		LinearDamping_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LinearDamping", Classes.FFloatProperty);
		LinearStiffness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LinearStiffness");
		LinearStiffness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LinearStiffness", Classes.FFloatProperty);
		AngularDamping_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AngularDamping");
		AngularDamping_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AngularDamping", Classes.FFloatProperty);
		AngularStiffness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AngularStiffness");
		AngularStiffness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AngularStiffness", Classes.FFloatProperty);
		InterpolationSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InterpolationSpeed");
		InterpolationSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InterpolationSpeed", Classes.FFloatProperty);
		SetTargetRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTargetRotation");
		SetTargetRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTargetRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTargetRotation_NewRotation_PropertyAddress, SetTargetRotation_FunctionAddress, "NewRotation");
		SetTargetRotation_NewRotation_Offset = NativeReflectionCached.GetPropertyOffset(SetTargetRotation_FunctionAddress, "NewRotation");
		SetTargetRotation_NewRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTargetRotation_FunctionAddress, "NewRotation", Classes.FStructProperty);
		SetTargetRotation_IsValid = SetTargetRotation_FunctionAddress != IntPtr.Zero && SetTargetRotation_NewRotation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsHandleComponent:SetTargetRotation", SetTargetRotation_IsValid);
		SetTargetLocationAndRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTargetLocationAndRotation");
		SetTargetLocationAndRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTargetLocationAndRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTargetLocationAndRotation_NewLocation_PropertyAddress, SetTargetLocationAndRotation_FunctionAddress, "NewLocation");
		SetTargetLocationAndRotation_NewLocation_Offset = NativeReflectionCached.GetPropertyOffset(SetTargetLocationAndRotation_FunctionAddress, "NewLocation");
		SetTargetLocationAndRotation_NewLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTargetLocationAndRotation_FunctionAddress, "NewLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTargetLocationAndRotation_NewRotation_PropertyAddress, SetTargetLocationAndRotation_FunctionAddress, "NewRotation");
		SetTargetLocationAndRotation_NewRotation_Offset = NativeReflectionCached.GetPropertyOffset(SetTargetLocationAndRotation_FunctionAddress, "NewRotation");
		SetTargetLocationAndRotation_NewRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTargetLocationAndRotation_FunctionAddress, "NewRotation", Classes.FStructProperty);
		SetTargetLocationAndRotation_IsValid = SetTargetLocationAndRotation_FunctionAddress != IntPtr.Zero && SetTargetLocationAndRotation_NewLocation_IsValid && SetTargetLocationAndRotation_NewRotation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsHandleComponent:SetTargetLocationAndRotation", SetTargetLocationAndRotation_IsValid);
		SetTargetLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTargetLocation");
		SetTargetLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTargetLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTargetLocation_NewLocation_PropertyAddress, SetTargetLocation_FunctionAddress, "NewLocation");
		SetTargetLocation_NewLocation_Offset = NativeReflectionCached.GetPropertyOffset(SetTargetLocation_FunctionAddress, "NewLocation");
		SetTargetLocation_NewLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTargetLocation_FunctionAddress, "NewLocation", Classes.FStructProperty);
		SetTargetLocation_IsValid = SetTargetLocation_FunctionAddress != IntPtr.Zero && SetTargetLocation_NewLocation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsHandleComponent:SetTargetLocation", SetTargetLocation_IsValid);
		SetLinearStiffness_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLinearStiffness");
		SetLinearStiffness_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLinearStiffness_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLinearStiffness_NewLinearStiffness_PropertyAddress, SetLinearStiffness_FunctionAddress, "NewLinearStiffness");
		SetLinearStiffness_NewLinearStiffness_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearStiffness_FunctionAddress, "NewLinearStiffness");
		SetLinearStiffness_NewLinearStiffness_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearStiffness_FunctionAddress, "NewLinearStiffness", Classes.FFloatProperty);
		SetLinearStiffness_IsValid = SetLinearStiffness_FunctionAddress != IntPtr.Zero && SetLinearStiffness_NewLinearStiffness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsHandleComponent:SetLinearStiffness", SetLinearStiffness_IsValid);
		SetLinearDamping_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLinearDamping");
		SetLinearDamping_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLinearDamping_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLinearDamping_NewLinearDamping_PropertyAddress, SetLinearDamping_FunctionAddress, "NewLinearDamping");
		SetLinearDamping_NewLinearDamping_Offset = NativeReflectionCached.GetPropertyOffset(SetLinearDamping_FunctionAddress, "NewLinearDamping");
		SetLinearDamping_NewLinearDamping_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLinearDamping_FunctionAddress, "NewLinearDamping", Classes.FFloatProperty);
		SetLinearDamping_IsValid = SetLinearDamping_FunctionAddress != IntPtr.Zero && SetLinearDamping_NewLinearDamping_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsHandleComponent:SetLinearDamping", SetLinearDamping_IsValid);
		SetInterpolationSpeed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetInterpolationSpeed");
		SetInterpolationSpeed_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInterpolationSpeed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInterpolationSpeed_NewInterpolationSpeed_PropertyAddress, SetInterpolationSpeed_FunctionAddress, "NewInterpolationSpeed");
		SetInterpolationSpeed_NewInterpolationSpeed_Offset = NativeReflectionCached.GetPropertyOffset(SetInterpolationSpeed_FunctionAddress, "NewInterpolationSpeed");
		SetInterpolationSpeed_NewInterpolationSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInterpolationSpeed_FunctionAddress, "NewInterpolationSpeed", Classes.FFloatProperty);
		SetInterpolationSpeed_IsValid = SetInterpolationSpeed_FunctionAddress != IntPtr.Zero && SetInterpolationSpeed_NewInterpolationSpeed_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsHandleComponent:SetInterpolationSpeed", SetInterpolationSpeed_IsValid);
		SetAngularStiffness_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAngularStiffness");
		SetAngularStiffness_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAngularStiffness_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAngularStiffness_NewAngularStiffness_PropertyAddress, SetAngularStiffness_FunctionAddress, "NewAngularStiffness");
		SetAngularStiffness_NewAngularStiffness_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularStiffness_FunctionAddress, "NewAngularStiffness");
		SetAngularStiffness_NewAngularStiffness_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularStiffness_FunctionAddress, "NewAngularStiffness", Classes.FFloatProperty);
		SetAngularStiffness_IsValid = SetAngularStiffness_FunctionAddress != IntPtr.Zero && SetAngularStiffness_NewAngularStiffness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsHandleComponent:SetAngularStiffness", SetAngularStiffness_IsValid);
		SetAngularDamping_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAngularDamping");
		SetAngularDamping_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAngularDamping_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAngularDamping_NewAngularDamping_PropertyAddress, SetAngularDamping_FunctionAddress, "NewAngularDamping");
		SetAngularDamping_NewAngularDamping_Offset = NativeReflectionCached.GetPropertyOffset(SetAngularDamping_FunctionAddress, "NewAngularDamping");
		SetAngularDamping_NewAngularDamping_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAngularDamping_FunctionAddress, "NewAngularDamping", Classes.FFloatProperty);
		SetAngularDamping_IsValid = SetAngularDamping_FunctionAddress != IntPtr.Zero && SetAngularDamping_NewAngularDamping_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsHandleComponent:SetAngularDamping", SetAngularDamping_IsValid);
		ReleaseComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReleaseComponent");
		ReleaseComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(ReleaseComponent_FunctionAddress);
		ReleaseComponent_IsValid = ReleaseComponent_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsHandleComponent:ReleaseComponent", ReleaseComponent_IsValid);
		GrabComponentAtLocationWithRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GrabComponentAtLocationWithRotation");
		GrabComponentAtLocationWithRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(GrabComponentAtLocationWithRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GrabComponentAtLocationWithRotation_Component_PropertyAddress, GrabComponentAtLocationWithRotation_FunctionAddress, "Component");
		GrabComponentAtLocationWithRotation_Component_Offset = NativeReflectionCached.GetPropertyOffset(GrabComponentAtLocationWithRotation_FunctionAddress, "Component");
		GrabComponentAtLocationWithRotation_Component_IsValid = NativeReflectionCached.ValidatePropertyClass(GrabComponentAtLocationWithRotation_FunctionAddress, "Component", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GrabComponentAtLocationWithRotation_InBoneName_PropertyAddress, GrabComponentAtLocationWithRotation_FunctionAddress, "InBoneName");
		GrabComponentAtLocationWithRotation_InBoneName_Offset = NativeReflectionCached.GetPropertyOffset(GrabComponentAtLocationWithRotation_FunctionAddress, "InBoneName");
		GrabComponentAtLocationWithRotation_InBoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(GrabComponentAtLocationWithRotation_FunctionAddress, "InBoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GrabComponentAtLocationWithRotation_Location_PropertyAddress, GrabComponentAtLocationWithRotation_FunctionAddress, "Location");
		GrabComponentAtLocationWithRotation_Location_Offset = NativeReflectionCached.GetPropertyOffset(GrabComponentAtLocationWithRotation_FunctionAddress, "Location");
		GrabComponentAtLocationWithRotation_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(GrabComponentAtLocationWithRotation_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GrabComponentAtLocationWithRotation_Rotation_PropertyAddress, GrabComponentAtLocationWithRotation_FunctionAddress, "Rotation");
		GrabComponentAtLocationWithRotation_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(GrabComponentAtLocationWithRotation_FunctionAddress, "Rotation");
		GrabComponentAtLocationWithRotation_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(GrabComponentAtLocationWithRotation_FunctionAddress, "Rotation", Classes.FStructProperty);
		GrabComponentAtLocationWithRotation_IsValid = GrabComponentAtLocationWithRotation_FunctionAddress != IntPtr.Zero && GrabComponentAtLocationWithRotation_Component_IsValid && GrabComponentAtLocationWithRotation_InBoneName_IsValid && GrabComponentAtLocationWithRotation_Location_IsValid && GrabComponentAtLocationWithRotation_Rotation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsHandleComponent:GrabComponentAtLocationWithRotation", GrabComponentAtLocationWithRotation_IsValid);
		GrabComponentAtLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GrabComponentAtLocation");
		GrabComponentAtLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(GrabComponentAtLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GrabComponentAtLocation_Component_PropertyAddress, GrabComponentAtLocation_FunctionAddress, "Component");
		GrabComponentAtLocation_Component_Offset = NativeReflectionCached.GetPropertyOffset(GrabComponentAtLocation_FunctionAddress, "Component");
		GrabComponentAtLocation_Component_IsValid = NativeReflectionCached.ValidatePropertyClass(GrabComponentAtLocation_FunctionAddress, "Component", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GrabComponentAtLocation_InBoneName_PropertyAddress, GrabComponentAtLocation_FunctionAddress, "InBoneName");
		GrabComponentAtLocation_InBoneName_Offset = NativeReflectionCached.GetPropertyOffset(GrabComponentAtLocation_FunctionAddress, "InBoneName");
		GrabComponentAtLocation_InBoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(GrabComponentAtLocation_FunctionAddress, "InBoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GrabComponentAtLocation_GrabLocation_PropertyAddress, GrabComponentAtLocation_FunctionAddress, "GrabLocation");
		GrabComponentAtLocation_GrabLocation_Offset = NativeReflectionCached.GetPropertyOffset(GrabComponentAtLocation_FunctionAddress, "GrabLocation");
		GrabComponentAtLocation_GrabLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(GrabComponentAtLocation_FunctionAddress, "GrabLocation", Classes.FStructProperty);
		GrabComponentAtLocation_IsValid = GrabComponentAtLocation_FunctionAddress != IntPtr.Zero && GrabComponentAtLocation_Component_IsValid && GrabComponentAtLocation_InBoneName_IsValid && GrabComponentAtLocation_GrabLocation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsHandleComponent:GrabComponentAtLocation", GrabComponentAtLocation_IsValid);
		GetTargetLocationAndRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTargetLocationAndRotation");
		GetTargetLocationAndRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTargetLocationAndRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTargetLocationAndRotation_TargetLocation_PropertyAddress, GetTargetLocationAndRotation_FunctionAddress, "TargetLocation");
		GetTargetLocationAndRotation_TargetLocation_Offset = NativeReflectionCached.GetPropertyOffset(GetTargetLocationAndRotation_FunctionAddress, "TargetLocation");
		GetTargetLocationAndRotation_TargetLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTargetLocationAndRotation_FunctionAddress, "TargetLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTargetLocationAndRotation_TargetRotation_PropertyAddress, GetTargetLocationAndRotation_FunctionAddress, "TargetRotation");
		GetTargetLocationAndRotation_TargetRotation_Offset = NativeReflectionCached.GetPropertyOffset(GetTargetLocationAndRotation_FunctionAddress, "TargetRotation");
		GetTargetLocationAndRotation_TargetRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTargetLocationAndRotation_FunctionAddress, "TargetRotation", Classes.FStructProperty);
		GetTargetLocationAndRotation_IsValid = GetTargetLocationAndRotation_FunctionAddress != IntPtr.Zero && GetTargetLocationAndRotation_TargetLocation_IsValid && GetTargetLocationAndRotation_TargetRotation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsHandleComponent:GetTargetLocationAndRotation", GetTargetLocationAndRotation_IsValid);
		GetGrabbedComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetGrabbedComponent");
		GetGrabbedComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGrabbedComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGrabbedComponent_ReturnValue_PropertyAddress, GetGrabbedComponent_FunctionAddress, "ReturnValue");
		GetGrabbedComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGrabbedComponent_FunctionAddress, "ReturnValue");
		GetGrabbedComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGrabbedComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetGrabbedComponent_IsValid = GetGrabbedComponent_FunctionAddress != IntPtr.Zero && GetGrabbedComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsHandleComponent:GetGrabbedComponent", GetGrabbedComponent_IsValid);
	}
}
