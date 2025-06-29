using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Chaos;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.FieldSystemEngine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/FieldSystemEngine.FieldSystemComponent", "FieldSystemEngine", UnrealModuleType.Engine)]
public class UFieldSystemComponent : UPrimitiveComponent
{
	private static bool FieldSystem_IsValid;

	private static int FieldSystem_Offset;

	private static bool ResetFieldSystem_IsValid;

	private static IntPtr ResetFieldSystem_FunctionAddress;

	private static int ResetFieldSystem_ParamsSize;

	private static bool RemovePersistentFields_IsValid;

	private static IntPtr RemovePersistentFields_FunctionAddress;

	private static int RemovePersistentFields_ParamsSize;

	private static bool ApplyUniformVectorFalloffForce_IsValid;

	private static IntPtr ApplyUniformVectorFalloffForce_FunctionAddress;

	private static int ApplyUniformVectorFalloffForce_ParamsSize;

	private static bool ApplyUniformVectorFalloffForce_Enabled_IsValid;

	private static FFieldAddress ApplyUniformVectorFalloffForce_Enabled_PropertyAddress;

	private static int ApplyUniformVectorFalloffForce_Enabled_Offset;

	private static bool ApplyUniformVectorFalloffForce_Position_IsValid;

	private static FFieldAddress ApplyUniformVectorFalloffForce_Position_PropertyAddress;

	private static int ApplyUniformVectorFalloffForce_Position_Offset;

	private static bool ApplyUniformVectorFalloffForce_Direction_IsValid;

	private static FFieldAddress ApplyUniformVectorFalloffForce_Direction_PropertyAddress;

	private static int ApplyUniformVectorFalloffForce_Direction_Offset;

	private static bool ApplyUniformVectorFalloffForce_Radius_IsValid;

	private static FFieldAddress ApplyUniformVectorFalloffForce_Radius_PropertyAddress;

	private static int ApplyUniformVectorFalloffForce_Radius_Offset;

	private static bool ApplyUniformVectorFalloffForce_Magnitude_IsValid;

	private static FFieldAddress ApplyUniformVectorFalloffForce_Magnitude_PropertyAddress;

	private static int ApplyUniformVectorFalloffForce_Magnitude_Offset;

	private static bool ApplyStrainField_IsValid;

	private static IntPtr ApplyStrainField_FunctionAddress;

	private static int ApplyStrainField_ParamsSize;

	private static bool ApplyStrainField_Enabled_IsValid;

	private static FFieldAddress ApplyStrainField_Enabled_PropertyAddress;

	private static int ApplyStrainField_Enabled_Offset;

	private static bool ApplyStrainField_Position_IsValid;

	private static FFieldAddress ApplyStrainField_Position_PropertyAddress;

	private static int ApplyStrainField_Position_Offset;

	private static bool ApplyStrainField_Radius_IsValid;

	private static FFieldAddress ApplyStrainField_Radius_PropertyAddress;

	private static int ApplyStrainField_Radius_Offset;

	private static bool ApplyStrainField_Magnitude_IsValid;

	private static FFieldAddress ApplyStrainField_Magnitude_PropertyAddress;

	private static int ApplyStrainField_Magnitude_Offset;

	private static bool ApplyStrainField_Iterations_IsValid;

	private static FFieldAddress ApplyStrainField_Iterations_PropertyAddress;

	private static int ApplyStrainField_Iterations_Offset;

	private static bool ApplyStayDynamicField_IsValid;

	private static IntPtr ApplyStayDynamicField_FunctionAddress;

	private static int ApplyStayDynamicField_ParamsSize;

	private static bool ApplyStayDynamicField_Enabled_IsValid;

	private static FFieldAddress ApplyStayDynamicField_Enabled_PropertyAddress;

	private static int ApplyStayDynamicField_Enabled_Offset;

	private static bool ApplyStayDynamicField_Position_IsValid;

	private static FFieldAddress ApplyStayDynamicField_Position_PropertyAddress;

	private static int ApplyStayDynamicField_Position_Offset;

	private static bool ApplyStayDynamicField_Radius_IsValid;

	private static FFieldAddress ApplyStayDynamicField_Radius_PropertyAddress;

	private static int ApplyStayDynamicField_Radius_Offset;

	private static bool ApplyRadialVectorFalloffForce_IsValid;

	private static IntPtr ApplyRadialVectorFalloffForce_FunctionAddress;

	private static int ApplyRadialVectorFalloffForce_ParamsSize;

	private static bool ApplyRadialVectorFalloffForce_Enabled_IsValid;

	private static FFieldAddress ApplyRadialVectorFalloffForce_Enabled_PropertyAddress;

	private static int ApplyRadialVectorFalloffForce_Enabled_Offset;

	private static bool ApplyRadialVectorFalloffForce_Position_IsValid;

	private static FFieldAddress ApplyRadialVectorFalloffForce_Position_PropertyAddress;

	private static int ApplyRadialVectorFalloffForce_Position_Offset;

	private static bool ApplyRadialVectorFalloffForce_Radius_IsValid;

	private static FFieldAddress ApplyRadialVectorFalloffForce_Radius_PropertyAddress;

	private static int ApplyRadialVectorFalloffForce_Radius_Offset;

	private static bool ApplyRadialVectorFalloffForce_Magnitude_IsValid;

	private static FFieldAddress ApplyRadialVectorFalloffForce_Magnitude_PropertyAddress;

	private static int ApplyRadialVectorFalloffForce_Magnitude_Offset;

	private static bool ApplyRadialForce_IsValid;

	private static IntPtr ApplyRadialForce_FunctionAddress;

	private static int ApplyRadialForce_ParamsSize;

	private static bool ApplyRadialForce_Enabled_IsValid;

	private static FFieldAddress ApplyRadialForce_Enabled_PropertyAddress;

	private static int ApplyRadialForce_Enabled_Offset;

	private static bool ApplyRadialForce_Position_IsValid;

	private static FFieldAddress ApplyRadialForce_Position_PropertyAddress;

	private static int ApplyRadialForce_Position_Offset;

	private static bool ApplyRadialForce_Magnitude_IsValid;

	private static FFieldAddress ApplyRadialForce_Magnitude_PropertyAddress;

	private static int ApplyRadialForce_Magnitude_Offset;

	private static bool ApplyPhysicsField_IsValid;

	private static IntPtr ApplyPhysicsField_FunctionAddress;

	private static int ApplyPhysicsField_ParamsSize;

	private static bool ApplyPhysicsField_Enabled_IsValid;

	private static FFieldAddress ApplyPhysicsField_Enabled_PropertyAddress;

	private static int ApplyPhysicsField_Enabled_Offset;

	private static bool ApplyPhysicsField_Target_IsValid;

	private static FFieldAddress ApplyPhysicsField_Target_PropertyAddress;

	private static int ApplyPhysicsField_Target_Offset;

	private static bool ApplyPhysicsField_MetaData_IsValid;

	private static FFieldAddress ApplyPhysicsField_MetaData_PropertyAddress;

	private static int ApplyPhysicsField_MetaData_Offset;

	private static bool ApplyPhysicsField_Field_IsValid;

	private static FFieldAddress ApplyPhysicsField_Field_PropertyAddress;

	private static int ApplyPhysicsField_Field_Offset;

	private static bool ApplyLinearForce_IsValid;

	private static IntPtr ApplyLinearForce_FunctionAddress;

	private static int ApplyLinearForce_ParamsSize;

	private static bool ApplyLinearForce_Enabled_IsValid;

	private static FFieldAddress ApplyLinearForce_Enabled_PropertyAddress;

	private static int ApplyLinearForce_Enabled_Offset;

	private static bool ApplyLinearForce_Direction_IsValid;

	private static FFieldAddress ApplyLinearForce_Direction_PropertyAddress;

	private static int ApplyLinearForce_Direction_Offset;

	private static bool ApplyLinearForce_Magnitude_IsValid;

	private static FFieldAddress ApplyLinearForce_Magnitude_PropertyAddress;

	private static int ApplyLinearForce_Magnitude_Offset;

	private static bool AddPersistentField_IsValid;

	private static IntPtr AddPersistentField_FunctionAddress;

	private static int AddPersistentField_ParamsSize;

	private static bool AddPersistentField_Enabled_IsValid;

	private static FFieldAddress AddPersistentField_Enabled_PropertyAddress;

	private static int AddPersistentField_Enabled_Offset;

	private static bool AddPersistentField_Target_IsValid;

	private static FFieldAddress AddPersistentField_Target_PropertyAddress;

	private static int AddPersistentField_Target_Offset;

	private static bool AddPersistentField_MetaData_IsValid;

	private static FFieldAddress AddPersistentField_MetaData_PropertyAddress;

	private static int AddPersistentField_MetaData_Offset;

	private static bool AddPersistentField_Field_IsValid;

	private static FFieldAddress AddPersistentField_Field_PropertyAddress;

	private static int AddPersistentField_Field_Offset;

	private static bool AddFieldCommand_IsValid;

	private static IntPtr AddFieldCommand_FunctionAddress;

	private static int AddFieldCommand_ParamsSize;

	private static bool AddFieldCommand_Enabled_IsValid;

	private static FFieldAddress AddFieldCommand_Enabled_PropertyAddress;

	private static int AddFieldCommand_Enabled_Offset;

	private static bool AddFieldCommand_Target_IsValid;

	private static FFieldAddress AddFieldCommand_Target_PropertyAddress;

	private static int AddFieldCommand_Target_Offset;

	private static bool AddFieldCommand_MetaData_IsValid;

	private static FFieldAddress AddFieldCommand_MetaData_PropertyAddress;

	private static int AddFieldCommand_MetaData_Offset;

	private static bool AddFieldCommand_Field_IsValid;

	private static FFieldAddress AddFieldCommand_Field_PropertyAddress;

	private static int AddFieldCommand_Field_Offset;

	[UProperty(Flags = (PropFlags)7885767187628565uL)]
	[UMetaPath("/Script/FieldSystemEngine.FieldSystemComponent:FieldSystem")]
	public UFieldSystem FieldSystem
	{
		get
		{
			CheckDestroyed();
			if (!FieldSystem_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.FieldSystemComponent:FieldSystem");
				return null;
			}
			return UObjectMarshaler<UFieldSystem>.FromNative(IntPtr.Add(base.Address, FieldSystem_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FieldSystem_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FieldSystemEngine.FieldSystemComponent:FieldSystem");
			}
			else
			{
				UObjectMarshaler<UFieldSystem>.ToNative(IntPtr.Add(base.Address, FieldSystem_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FieldSystemEngine.FieldSystemComponent:ResetFieldSystem")]
	public unsafe void ResetFieldSystem()
	{
		CheckDestroyed();
		if (!ResetFieldSystem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FieldSystemEngine.FieldSystemComponent:ResetFieldSystem");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetFieldSystem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetFieldSystem_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetFieldSystem_FunctionAddress, argsSize: ResetFieldSystem_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FieldSystemEngine.FieldSystemComponent:RemovePersistentFields")]
	public unsafe void RemovePersistentFields()
	{
		CheckDestroyed();
		if (!RemovePersistentFields_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FieldSystemEngine.FieldSystemComponent:RemovePersistentFields");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemovePersistentFields_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemovePersistentFields_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RemovePersistentFields_FunctionAddress, argsSize: RemovePersistentFields_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/FieldSystemEngine.FieldSystemComponent:ApplyUniformVectorFalloffForce")]
	public unsafe void ApplyUniformVectorFalloffForce(bool Enabled, FVector Position, FVector Direction, float Radius, float Magnitude)
	{
		CheckDestroyed();
		if (!ApplyUniformVectorFalloffForce_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FieldSystemEngine.FieldSystemComponent:ApplyUniformVectorFalloffForce");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyUniformVectorFalloffForce_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyUniformVectorFalloffForce_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ApplyUniformVectorFalloffForce_Enabled_Offset), 0, ApplyUniformVectorFalloffForce_Enabled_PropertyAddress.Address, Enabled);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ApplyUniformVectorFalloffForce_Position_Offset), 0, ApplyUniformVectorFalloffForce_Position_PropertyAddress.Address, Position);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ApplyUniformVectorFalloffForce_Direction_Offset), 0, ApplyUniformVectorFalloffForce_Direction_PropertyAddress.Address, Direction);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ApplyUniformVectorFalloffForce_Radius_Offset), 0, ApplyUniformVectorFalloffForce_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ApplyUniformVectorFalloffForce_Magnitude_Offset), 0, ApplyUniformVectorFalloffForce_Magnitude_PropertyAddress.Address, Magnitude);
		NativeReflection.InvokeFunctionOptimized(base.Address, ApplyUniformVectorFalloffForce_FunctionAddress, intPtr, ApplyUniformVectorFalloffForce_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/FieldSystemEngine.FieldSystemComponent:ApplyStrainField")]
	public unsafe void ApplyStrainField(bool Enabled, FVector Position, float Radius, float Magnitude, int Iterations)
	{
		CheckDestroyed();
		if (!ApplyStrainField_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FieldSystemEngine.FieldSystemComponent:ApplyStrainField");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyStrainField_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyStrainField_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ApplyStrainField_Enabled_Offset), 0, ApplyStrainField_Enabled_PropertyAddress.Address, Enabled);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ApplyStrainField_Position_Offset), 0, ApplyStrainField_Position_PropertyAddress.Address, Position);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ApplyStrainField_Radius_Offset), 0, ApplyStrainField_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ApplyStrainField_Magnitude_Offset), 0, ApplyStrainField_Magnitude_PropertyAddress.Address, Magnitude);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ApplyStrainField_Iterations_Offset), 0, ApplyStrainField_Iterations_PropertyAddress.Address, Iterations);
		NativeReflection.InvokeFunctionOptimized(base.Address, ApplyStrainField_FunctionAddress, intPtr, ApplyStrainField_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/FieldSystemEngine.FieldSystemComponent:ApplyStayDynamicField")]
	public unsafe void ApplyStayDynamicField(bool Enabled, FVector Position, float Radius)
	{
		CheckDestroyed();
		if (!ApplyStayDynamicField_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FieldSystemEngine.FieldSystemComponent:ApplyStayDynamicField");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyStayDynamicField_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyStayDynamicField_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ApplyStayDynamicField_Enabled_Offset), 0, ApplyStayDynamicField_Enabled_PropertyAddress.Address, Enabled);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ApplyStayDynamicField_Position_Offset), 0, ApplyStayDynamicField_Position_PropertyAddress.Address, Position);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ApplyStayDynamicField_Radius_Offset), 0, ApplyStayDynamicField_Radius_PropertyAddress.Address, Radius);
		NativeReflection.InvokeFunctionOptimized(base.Address, ApplyStayDynamicField_FunctionAddress, intPtr, ApplyStayDynamicField_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/FieldSystemEngine.FieldSystemComponent:ApplyRadialVectorFalloffForce")]
	public unsafe void ApplyRadialVectorFalloffForce(bool Enabled, FVector Position, float Radius, float Magnitude)
	{
		CheckDestroyed();
		if (!ApplyRadialVectorFalloffForce_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FieldSystemEngine.FieldSystemComponent:ApplyRadialVectorFalloffForce");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyRadialVectorFalloffForce_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyRadialVectorFalloffForce_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ApplyRadialVectorFalloffForce_Enabled_Offset), 0, ApplyRadialVectorFalloffForce_Enabled_PropertyAddress.Address, Enabled);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ApplyRadialVectorFalloffForce_Position_Offset), 0, ApplyRadialVectorFalloffForce_Position_PropertyAddress.Address, Position);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ApplyRadialVectorFalloffForce_Radius_Offset), 0, ApplyRadialVectorFalloffForce_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ApplyRadialVectorFalloffForce_Magnitude_Offset), 0, ApplyRadialVectorFalloffForce_Magnitude_PropertyAddress.Address, Magnitude);
		NativeReflection.InvokeFunctionOptimized(base.Address, ApplyRadialVectorFalloffForce_FunctionAddress, intPtr, ApplyRadialVectorFalloffForce_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/FieldSystemEngine.FieldSystemComponent:ApplyRadialForce")]
	public unsafe void ApplyRadialForce(bool Enabled, FVector Position, float Magnitude)
	{
		CheckDestroyed();
		if (!ApplyRadialForce_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FieldSystemEngine.FieldSystemComponent:ApplyRadialForce");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyRadialForce_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyRadialForce_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ApplyRadialForce_Enabled_Offset), 0, ApplyRadialForce_Enabled_PropertyAddress.Address, Enabled);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ApplyRadialForce_Position_Offset), 0, ApplyRadialForce_Position_PropertyAddress.Address, Position);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ApplyRadialForce_Magnitude_Offset), 0, ApplyRadialForce_Magnitude_PropertyAddress.Address, Magnitude);
		NativeReflection.InvokeFunctionOptimized(base.Address, ApplyRadialForce_FunctionAddress, intPtr, ApplyRadialForce_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FieldSystemEngine.FieldSystemComponent:ApplyPhysicsField")]
	public unsafe void ApplyPhysicsField(bool Enabled, EFieldPhysicsType Target, UFieldSystemMetaData MetaData, UFieldNodeBase Field)
	{
		CheckDestroyed();
		if (!ApplyPhysicsField_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FieldSystemEngine.FieldSystemComponent:ApplyPhysicsField");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyPhysicsField_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyPhysicsField_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ApplyPhysicsField_Enabled_Offset), 0, ApplyPhysicsField_Enabled_PropertyAddress.Address, Enabled);
		EnumMarshaler<EFieldPhysicsType>.ToNative(IntPtr.Add(intPtr, ApplyPhysicsField_Target_Offset), 0, ApplyPhysicsField_Target_PropertyAddress.Address, Target);
		UObjectMarshaler<UFieldSystemMetaData>.ToNative(IntPtr.Add(intPtr, ApplyPhysicsField_MetaData_Offset), 0, ApplyPhysicsField_MetaData_PropertyAddress.Address, MetaData);
		UObjectMarshaler<UFieldNodeBase>.ToNative(IntPtr.Add(intPtr, ApplyPhysicsField_Field_Offset), 0, ApplyPhysicsField_Field_PropertyAddress.Address, Field);
		NativeReflection.InvokeFunctionOptimized(base.Address, ApplyPhysicsField_FunctionAddress, intPtr, ApplyPhysicsField_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/FieldSystemEngine.FieldSystemComponent:ApplyLinearForce")]
	public unsafe void ApplyLinearForce(bool Enabled, FVector Direction, float Magnitude)
	{
		CheckDestroyed();
		if (!ApplyLinearForce_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FieldSystemEngine.FieldSystemComponent:ApplyLinearForce");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyLinearForce_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyLinearForce_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ApplyLinearForce_Enabled_Offset), 0, ApplyLinearForce_Enabled_PropertyAddress.Address, Enabled);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ApplyLinearForce_Direction_Offset), 0, ApplyLinearForce_Direction_PropertyAddress.Address, Direction);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ApplyLinearForce_Magnitude_Offset), 0, ApplyLinearForce_Magnitude_PropertyAddress.Address, Magnitude);
		NativeReflection.InvokeFunctionOptimized(base.Address, ApplyLinearForce_FunctionAddress, intPtr, ApplyLinearForce_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FieldSystemEngine.FieldSystemComponent:AddPersistentField")]
	public unsafe void AddPersistentField(bool Enabled, EFieldPhysicsType Target, UFieldSystemMetaData MetaData, UFieldNodeBase Field)
	{
		CheckDestroyed();
		if (!AddPersistentField_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FieldSystemEngine.FieldSystemComponent:AddPersistentField");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddPersistentField_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddPersistentField_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddPersistentField_Enabled_Offset), 0, AddPersistentField_Enabled_PropertyAddress.Address, Enabled);
		EnumMarshaler<EFieldPhysicsType>.ToNative(IntPtr.Add(intPtr, AddPersistentField_Target_Offset), 0, AddPersistentField_Target_PropertyAddress.Address, Target);
		UObjectMarshaler<UFieldSystemMetaData>.ToNative(IntPtr.Add(intPtr, AddPersistentField_MetaData_Offset), 0, AddPersistentField_MetaData_PropertyAddress.Address, MetaData);
		UObjectMarshaler<UFieldNodeBase>.ToNative(IntPtr.Add(intPtr, AddPersistentField_Field_Offset), 0, AddPersistentField_Field_PropertyAddress.Address, Field);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddPersistentField_FunctionAddress, intPtr, AddPersistentField_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/FieldSystemEngine.FieldSystemComponent:AddFieldCommand")]
	public unsafe void AddFieldCommand(bool Enabled, EFieldPhysicsType Target, UFieldSystemMetaData MetaData, UFieldNodeBase Field)
	{
		CheckDestroyed();
		if (!AddFieldCommand_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FieldSystemEngine.FieldSystemComponent:AddFieldCommand");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddFieldCommand_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddFieldCommand_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddFieldCommand_Enabled_Offset), 0, AddFieldCommand_Enabled_PropertyAddress.Address, Enabled);
		EnumMarshaler<EFieldPhysicsType>.ToNative(IntPtr.Add(intPtr, AddFieldCommand_Target_Offset), 0, AddFieldCommand_Target_PropertyAddress.Address, Target);
		UObjectMarshaler<UFieldSystemMetaData>.ToNative(IntPtr.Add(intPtr, AddFieldCommand_MetaData_Offset), 0, AddFieldCommand_MetaData_PropertyAddress.Address, MetaData);
		UObjectMarshaler<UFieldNodeBase>.ToNative(IntPtr.Add(intPtr, AddFieldCommand_Field_Offset), 0, AddFieldCommand_Field_PropertyAddress.Address, Field);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddFieldCommand_FunctionAddress, intPtr, AddFieldCommand_ParamsSize);
	}

	static UFieldSystemComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UFieldSystemComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UFieldSystemComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/FieldSystemEngine.FieldSystemComponent");
		FieldSystem_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FieldSystem");
		FieldSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FieldSystem", Classes.FObjectProperty);
		ResetFieldSystem_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResetFieldSystem");
		ResetFieldSystem_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetFieldSystem_FunctionAddress);
		ResetFieldSystem_IsValid = ResetFieldSystem_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FieldSystemEngine.FieldSystemComponent:ResetFieldSystem", ResetFieldSystem_IsValid);
		RemovePersistentFields_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemovePersistentFields");
		RemovePersistentFields_ParamsSize = NativeReflection.GetFunctionParamsSize(RemovePersistentFields_FunctionAddress);
		RemovePersistentFields_IsValid = RemovePersistentFields_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FieldSystemEngine.FieldSystemComponent:RemovePersistentFields", RemovePersistentFields_IsValid);
		ApplyUniformVectorFalloffForce_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ApplyUniformVectorFalloffForce");
		ApplyUniformVectorFalloffForce_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyUniformVectorFalloffForce_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyUniformVectorFalloffForce_Enabled_PropertyAddress, ApplyUniformVectorFalloffForce_FunctionAddress, "Enabled");
		ApplyUniformVectorFalloffForce_Enabled_Offset = NativeReflectionCached.GetPropertyOffset(ApplyUniformVectorFalloffForce_FunctionAddress, "Enabled");
		ApplyUniformVectorFalloffForce_Enabled_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyUniformVectorFalloffForce_FunctionAddress, "Enabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyUniformVectorFalloffForce_Position_PropertyAddress, ApplyUniformVectorFalloffForce_FunctionAddress, "Position");
		ApplyUniformVectorFalloffForce_Position_Offset = NativeReflectionCached.GetPropertyOffset(ApplyUniformVectorFalloffForce_FunctionAddress, "Position");
		ApplyUniformVectorFalloffForce_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyUniformVectorFalloffForce_FunctionAddress, "Position", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyUniformVectorFalloffForce_Direction_PropertyAddress, ApplyUniformVectorFalloffForce_FunctionAddress, "Direction");
		ApplyUniformVectorFalloffForce_Direction_Offset = NativeReflectionCached.GetPropertyOffset(ApplyUniformVectorFalloffForce_FunctionAddress, "Direction");
		ApplyUniformVectorFalloffForce_Direction_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyUniformVectorFalloffForce_FunctionAddress, "Direction", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyUniformVectorFalloffForce_Radius_PropertyAddress, ApplyUniformVectorFalloffForce_FunctionAddress, "Radius");
		ApplyUniformVectorFalloffForce_Radius_Offset = NativeReflectionCached.GetPropertyOffset(ApplyUniformVectorFalloffForce_FunctionAddress, "Radius");
		ApplyUniformVectorFalloffForce_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyUniformVectorFalloffForce_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyUniformVectorFalloffForce_Magnitude_PropertyAddress, ApplyUniformVectorFalloffForce_FunctionAddress, "Magnitude");
		ApplyUniformVectorFalloffForce_Magnitude_Offset = NativeReflectionCached.GetPropertyOffset(ApplyUniformVectorFalloffForce_FunctionAddress, "Magnitude");
		ApplyUniformVectorFalloffForce_Magnitude_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyUniformVectorFalloffForce_FunctionAddress, "Magnitude", Classes.FFloatProperty);
		ApplyUniformVectorFalloffForce_IsValid = ApplyUniformVectorFalloffForce_FunctionAddress != IntPtr.Zero && ApplyUniformVectorFalloffForce_Enabled_IsValid && ApplyUniformVectorFalloffForce_Position_IsValid && ApplyUniformVectorFalloffForce_Direction_IsValid && ApplyUniformVectorFalloffForce_Radius_IsValid && ApplyUniformVectorFalloffForce_Magnitude_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FieldSystemEngine.FieldSystemComponent:ApplyUniformVectorFalloffForce", ApplyUniformVectorFalloffForce_IsValid);
		ApplyStrainField_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ApplyStrainField");
		ApplyStrainField_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyStrainField_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyStrainField_Enabled_PropertyAddress, ApplyStrainField_FunctionAddress, "Enabled");
		ApplyStrainField_Enabled_Offset = NativeReflectionCached.GetPropertyOffset(ApplyStrainField_FunctionAddress, "Enabled");
		ApplyStrainField_Enabled_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyStrainField_FunctionAddress, "Enabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyStrainField_Position_PropertyAddress, ApplyStrainField_FunctionAddress, "Position");
		ApplyStrainField_Position_Offset = NativeReflectionCached.GetPropertyOffset(ApplyStrainField_FunctionAddress, "Position");
		ApplyStrainField_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyStrainField_FunctionAddress, "Position", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyStrainField_Radius_PropertyAddress, ApplyStrainField_FunctionAddress, "Radius");
		ApplyStrainField_Radius_Offset = NativeReflectionCached.GetPropertyOffset(ApplyStrainField_FunctionAddress, "Radius");
		ApplyStrainField_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyStrainField_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyStrainField_Magnitude_PropertyAddress, ApplyStrainField_FunctionAddress, "Magnitude");
		ApplyStrainField_Magnitude_Offset = NativeReflectionCached.GetPropertyOffset(ApplyStrainField_FunctionAddress, "Magnitude");
		ApplyStrainField_Magnitude_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyStrainField_FunctionAddress, "Magnitude", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyStrainField_Iterations_PropertyAddress, ApplyStrainField_FunctionAddress, "Iterations");
		ApplyStrainField_Iterations_Offset = NativeReflectionCached.GetPropertyOffset(ApplyStrainField_FunctionAddress, "Iterations");
		ApplyStrainField_Iterations_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyStrainField_FunctionAddress, "Iterations", Classes.FIntProperty);
		ApplyStrainField_IsValid = ApplyStrainField_FunctionAddress != IntPtr.Zero && ApplyStrainField_Enabled_IsValid && ApplyStrainField_Position_IsValid && ApplyStrainField_Radius_IsValid && ApplyStrainField_Magnitude_IsValid && ApplyStrainField_Iterations_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FieldSystemEngine.FieldSystemComponent:ApplyStrainField", ApplyStrainField_IsValid);
		ApplyStayDynamicField_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ApplyStayDynamicField");
		ApplyStayDynamicField_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyStayDynamicField_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyStayDynamicField_Enabled_PropertyAddress, ApplyStayDynamicField_FunctionAddress, "Enabled");
		ApplyStayDynamicField_Enabled_Offset = NativeReflectionCached.GetPropertyOffset(ApplyStayDynamicField_FunctionAddress, "Enabled");
		ApplyStayDynamicField_Enabled_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyStayDynamicField_FunctionAddress, "Enabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyStayDynamicField_Position_PropertyAddress, ApplyStayDynamicField_FunctionAddress, "Position");
		ApplyStayDynamicField_Position_Offset = NativeReflectionCached.GetPropertyOffset(ApplyStayDynamicField_FunctionAddress, "Position");
		ApplyStayDynamicField_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyStayDynamicField_FunctionAddress, "Position", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyStayDynamicField_Radius_PropertyAddress, ApplyStayDynamicField_FunctionAddress, "Radius");
		ApplyStayDynamicField_Radius_Offset = NativeReflectionCached.GetPropertyOffset(ApplyStayDynamicField_FunctionAddress, "Radius");
		ApplyStayDynamicField_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyStayDynamicField_FunctionAddress, "Radius", Classes.FFloatProperty);
		ApplyStayDynamicField_IsValid = ApplyStayDynamicField_FunctionAddress != IntPtr.Zero && ApplyStayDynamicField_Enabled_IsValid && ApplyStayDynamicField_Position_IsValid && ApplyStayDynamicField_Radius_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FieldSystemEngine.FieldSystemComponent:ApplyStayDynamicField", ApplyStayDynamicField_IsValid);
		ApplyRadialVectorFalloffForce_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ApplyRadialVectorFalloffForce");
		ApplyRadialVectorFalloffForce_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyRadialVectorFalloffForce_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyRadialVectorFalloffForce_Enabled_PropertyAddress, ApplyRadialVectorFalloffForce_FunctionAddress, "Enabled");
		ApplyRadialVectorFalloffForce_Enabled_Offset = NativeReflectionCached.GetPropertyOffset(ApplyRadialVectorFalloffForce_FunctionAddress, "Enabled");
		ApplyRadialVectorFalloffForce_Enabled_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyRadialVectorFalloffForce_FunctionAddress, "Enabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyRadialVectorFalloffForce_Position_PropertyAddress, ApplyRadialVectorFalloffForce_FunctionAddress, "Position");
		ApplyRadialVectorFalloffForce_Position_Offset = NativeReflectionCached.GetPropertyOffset(ApplyRadialVectorFalloffForce_FunctionAddress, "Position");
		ApplyRadialVectorFalloffForce_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyRadialVectorFalloffForce_FunctionAddress, "Position", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyRadialVectorFalloffForce_Radius_PropertyAddress, ApplyRadialVectorFalloffForce_FunctionAddress, "Radius");
		ApplyRadialVectorFalloffForce_Radius_Offset = NativeReflectionCached.GetPropertyOffset(ApplyRadialVectorFalloffForce_FunctionAddress, "Radius");
		ApplyRadialVectorFalloffForce_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyRadialVectorFalloffForce_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyRadialVectorFalloffForce_Magnitude_PropertyAddress, ApplyRadialVectorFalloffForce_FunctionAddress, "Magnitude");
		ApplyRadialVectorFalloffForce_Magnitude_Offset = NativeReflectionCached.GetPropertyOffset(ApplyRadialVectorFalloffForce_FunctionAddress, "Magnitude");
		ApplyRadialVectorFalloffForce_Magnitude_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyRadialVectorFalloffForce_FunctionAddress, "Magnitude", Classes.FFloatProperty);
		ApplyRadialVectorFalloffForce_IsValid = ApplyRadialVectorFalloffForce_FunctionAddress != IntPtr.Zero && ApplyRadialVectorFalloffForce_Enabled_IsValid && ApplyRadialVectorFalloffForce_Position_IsValid && ApplyRadialVectorFalloffForce_Radius_IsValid && ApplyRadialVectorFalloffForce_Magnitude_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FieldSystemEngine.FieldSystemComponent:ApplyRadialVectorFalloffForce", ApplyRadialVectorFalloffForce_IsValid);
		ApplyRadialForce_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ApplyRadialForce");
		ApplyRadialForce_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyRadialForce_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyRadialForce_Enabled_PropertyAddress, ApplyRadialForce_FunctionAddress, "Enabled");
		ApplyRadialForce_Enabled_Offset = NativeReflectionCached.GetPropertyOffset(ApplyRadialForce_FunctionAddress, "Enabled");
		ApplyRadialForce_Enabled_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyRadialForce_FunctionAddress, "Enabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyRadialForce_Position_PropertyAddress, ApplyRadialForce_FunctionAddress, "Position");
		ApplyRadialForce_Position_Offset = NativeReflectionCached.GetPropertyOffset(ApplyRadialForce_FunctionAddress, "Position");
		ApplyRadialForce_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyRadialForce_FunctionAddress, "Position", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyRadialForce_Magnitude_PropertyAddress, ApplyRadialForce_FunctionAddress, "Magnitude");
		ApplyRadialForce_Magnitude_Offset = NativeReflectionCached.GetPropertyOffset(ApplyRadialForce_FunctionAddress, "Magnitude");
		ApplyRadialForce_Magnitude_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyRadialForce_FunctionAddress, "Magnitude", Classes.FFloatProperty);
		ApplyRadialForce_IsValid = ApplyRadialForce_FunctionAddress != IntPtr.Zero && ApplyRadialForce_Enabled_IsValid && ApplyRadialForce_Position_IsValid && ApplyRadialForce_Magnitude_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FieldSystemEngine.FieldSystemComponent:ApplyRadialForce", ApplyRadialForce_IsValid);
		ApplyPhysicsField_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ApplyPhysicsField");
		ApplyPhysicsField_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyPhysicsField_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyPhysicsField_Enabled_PropertyAddress, ApplyPhysicsField_FunctionAddress, "Enabled");
		ApplyPhysicsField_Enabled_Offset = NativeReflectionCached.GetPropertyOffset(ApplyPhysicsField_FunctionAddress, "Enabled");
		ApplyPhysicsField_Enabled_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyPhysicsField_FunctionAddress, "Enabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyPhysicsField_Target_PropertyAddress, ApplyPhysicsField_FunctionAddress, "Target");
		ApplyPhysicsField_Target_Offset = NativeReflectionCached.GetPropertyOffset(ApplyPhysicsField_FunctionAddress, "Target");
		ApplyPhysicsField_Target_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyPhysicsField_FunctionAddress, "Target", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyPhysicsField_MetaData_PropertyAddress, ApplyPhysicsField_FunctionAddress, "MetaData");
		ApplyPhysicsField_MetaData_Offset = NativeReflectionCached.GetPropertyOffset(ApplyPhysicsField_FunctionAddress, "MetaData");
		ApplyPhysicsField_MetaData_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyPhysicsField_FunctionAddress, "MetaData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyPhysicsField_Field_PropertyAddress, ApplyPhysicsField_FunctionAddress, "Field");
		ApplyPhysicsField_Field_Offset = NativeReflectionCached.GetPropertyOffset(ApplyPhysicsField_FunctionAddress, "Field");
		ApplyPhysicsField_Field_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyPhysicsField_FunctionAddress, "Field", Classes.FObjectProperty);
		ApplyPhysicsField_IsValid = ApplyPhysicsField_FunctionAddress != IntPtr.Zero && ApplyPhysicsField_Enabled_IsValid && ApplyPhysicsField_Target_IsValid && ApplyPhysicsField_MetaData_IsValid && ApplyPhysicsField_Field_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FieldSystemEngine.FieldSystemComponent:ApplyPhysicsField", ApplyPhysicsField_IsValid);
		ApplyLinearForce_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ApplyLinearForce");
		ApplyLinearForce_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyLinearForce_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyLinearForce_Enabled_PropertyAddress, ApplyLinearForce_FunctionAddress, "Enabled");
		ApplyLinearForce_Enabled_Offset = NativeReflectionCached.GetPropertyOffset(ApplyLinearForce_FunctionAddress, "Enabled");
		ApplyLinearForce_Enabled_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyLinearForce_FunctionAddress, "Enabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyLinearForce_Direction_PropertyAddress, ApplyLinearForce_FunctionAddress, "Direction");
		ApplyLinearForce_Direction_Offset = NativeReflectionCached.GetPropertyOffset(ApplyLinearForce_FunctionAddress, "Direction");
		ApplyLinearForce_Direction_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyLinearForce_FunctionAddress, "Direction", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyLinearForce_Magnitude_PropertyAddress, ApplyLinearForce_FunctionAddress, "Magnitude");
		ApplyLinearForce_Magnitude_Offset = NativeReflectionCached.GetPropertyOffset(ApplyLinearForce_FunctionAddress, "Magnitude");
		ApplyLinearForce_Magnitude_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyLinearForce_FunctionAddress, "Magnitude", Classes.FFloatProperty);
		ApplyLinearForce_IsValid = ApplyLinearForce_FunctionAddress != IntPtr.Zero && ApplyLinearForce_Enabled_IsValid && ApplyLinearForce_Direction_IsValid && ApplyLinearForce_Magnitude_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FieldSystemEngine.FieldSystemComponent:ApplyLinearForce", ApplyLinearForce_IsValid);
		AddPersistentField_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddPersistentField");
		AddPersistentField_ParamsSize = NativeReflection.GetFunctionParamsSize(AddPersistentField_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddPersistentField_Enabled_PropertyAddress, AddPersistentField_FunctionAddress, "Enabled");
		AddPersistentField_Enabled_Offset = NativeReflectionCached.GetPropertyOffset(AddPersistentField_FunctionAddress, "Enabled");
		AddPersistentField_Enabled_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPersistentField_FunctionAddress, "Enabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddPersistentField_Target_PropertyAddress, AddPersistentField_FunctionAddress, "Target");
		AddPersistentField_Target_Offset = NativeReflectionCached.GetPropertyOffset(AddPersistentField_FunctionAddress, "Target");
		AddPersistentField_Target_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPersistentField_FunctionAddress, "Target", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref AddPersistentField_MetaData_PropertyAddress, AddPersistentField_FunctionAddress, "MetaData");
		AddPersistentField_MetaData_Offset = NativeReflectionCached.GetPropertyOffset(AddPersistentField_FunctionAddress, "MetaData");
		AddPersistentField_MetaData_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPersistentField_FunctionAddress, "MetaData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddPersistentField_Field_PropertyAddress, AddPersistentField_FunctionAddress, "Field");
		AddPersistentField_Field_Offset = NativeReflectionCached.GetPropertyOffset(AddPersistentField_FunctionAddress, "Field");
		AddPersistentField_Field_IsValid = NativeReflectionCached.ValidatePropertyClass(AddPersistentField_FunctionAddress, "Field", Classes.FObjectProperty);
		AddPersistentField_IsValid = AddPersistentField_FunctionAddress != IntPtr.Zero && AddPersistentField_Enabled_IsValid && AddPersistentField_Target_IsValid && AddPersistentField_MetaData_IsValid && AddPersistentField_Field_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FieldSystemEngine.FieldSystemComponent:AddPersistentField", AddPersistentField_IsValid);
		AddFieldCommand_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddFieldCommand");
		AddFieldCommand_ParamsSize = NativeReflection.GetFunctionParamsSize(AddFieldCommand_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddFieldCommand_Enabled_PropertyAddress, AddFieldCommand_FunctionAddress, "Enabled");
		AddFieldCommand_Enabled_Offset = NativeReflectionCached.GetPropertyOffset(AddFieldCommand_FunctionAddress, "Enabled");
		AddFieldCommand_Enabled_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFieldCommand_FunctionAddress, "Enabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFieldCommand_Target_PropertyAddress, AddFieldCommand_FunctionAddress, "Target");
		AddFieldCommand_Target_Offset = NativeReflectionCached.GetPropertyOffset(AddFieldCommand_FunctionAddress, "Target");
		AddFieldCommand_Target_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFieldCommand_FunctionAddress, "Target", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFieldCommand_MetaData_PropertyAddress, AddFieldCommand_FunctionAddress, "MetaData");
		AddFieldCommand_MetaData_Offset = NativeReflectionCached.GetPropertyOffset(AddFieldCommand_FunctionAddress, "MetaData");
		AddFieldCommand_MetaData_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFieldCommand_FunctionAddress, "MetaData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFieldCommand_Field_PropertyAddress, AddFieldCommand_FunctionAddress, "Field");
		AddFieldCommand_Field_Offset = NativeReflectionCached.GetPropertyOffset(AddFieldCommand_FunctionAddress, "Field");
		AddFieldCommand_Field_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFieldCommand_FunctionAddress, "Field", Classes.FObjectProperty);
		AddFieldCommand_IsValid = AddFieldCommand_FunctionAddress != IntPtr.Zero && AddFieldCommand_Enabled_IsValid && AddFieldCommand_Target_IsValid && AddFieldCommand_MetaData_IsValid && AddFieldCommand_Field_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FieldSystemEngine.FieldSystemComponent:AddFieldCommand", AddFieldCommand_IsValid);
	}
}
