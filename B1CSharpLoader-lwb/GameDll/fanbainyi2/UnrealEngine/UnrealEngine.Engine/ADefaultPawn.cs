using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Game")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.DefaultPawn", "Engine", UnrealModuleType.Engine)]
public class ADefaultPawn : APawn
{
	private static bool BaseTurnRate_IsValid;

	private static int BaseTurnRate_Offset;

	private static bool BaseLookUpRate_IsValid;

	private static int BaseLookUpRate_Offset;

	private static bool MovementComponent_IsValid;

	private static int MovementComponent_Offset;

	private static bool CollisionComponent_IsValid;

	private static int CollisionComponent_Offset;

	private static bool MeshComponent_IsValid;

	private static int MeshComponent_Offset;

	private static bool AddDefaultMovementBindings_IsValid;

	private static FFieldAddress AddDefaultMovementBindings_PropertyAddress;

	private static int AddDefaultMovementBindings_Offset;

	private static bool TurnAtRate_IsValid;

	private static IntPtr TurnAtRate_FunctionAddress;

	private static int TurnAtRate_ParamsSize;

	private static bool TurnAtRate_Rate_IsValid;

	private static FFieldAddress TurnAtRate_Rate_PropertyAddress;

	private static int TurnAtRate_Rate_Offset;

	private static bool MoveUp_World_IsValid;

	private static IntPtr MoveUp_World_FunctionAddress;

	private static int MoveUp_World_ParamsSize;

	private static bool MoveUp_World_Val_IsValid;

	private static FFieldAddress MoveUp_World_Val_PropertyAddress;

	private static int MoveUp_World_Val_Offset;

	private static bool MoveRight_IsValid;

	private static IntPtr MoveRight_FunctionAddress;

	private static int MoveRight_ParamsSize;

	private static bool MoveRight_Val_IsValid;

	private static FFieldAddress MoveRight_Val_PropertyAddress;

	private static int MoveRight_Val_Offset;

	private static bool MoveForward_IsValid;

	private static IntPtr MoveForward_FunctionAddress;

	private static int MoveForward_ParamsSize;

	private static bool MoveForward_Val_IsValid;

	private static FFieldAddress MoveForward_Val_PropertyAddress;

	private static int MoveForward_Val_Offset;

	private static bool LookUpAtRate_IsValid;

	private static IntPtr LookUpAtRate_FunctionAddress;

	private static int LookUpAtRate_ParamsSize;

	private static bool LookUpAtRate_Rate_IsValid;

	private static FFieldAddress LookUpAtRate_Rate_PropertyAddress;

	private static int LookUpAtRate_Rate_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/Engine.DefaultPawn:BaseTurnRate")]
	public float BaseTurnRate
	{
		get
		{
			CheckDestroyed();
			if (!BaseTurnRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DefaultPawn:BaseTurnRate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BaseTurnRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BaseTurnRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DefaultPawn:BaseTurnRate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BaseTurnRate_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/Engine.DefaultPawn:BaseLookUpRate")]
	public float BaseLookUpRate
	{
		get
		{
			CheckDestroyed();
			if (!BaseLookUpRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DefaultPawn:BaseLookUpRate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BaseLookUpRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BaseLookUpRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DefaultPawn:BaseLookUpRate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BaseLookUpRate_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12393764862165533uL)]
	[UMetaPath("/Script/Engine.DefaultPawn:MovementComponent")]
	protected UPawnMovementComponent MovementComponent
	{
		get
		{
			CheckDestroyed();
			if (!MovementComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DefaultPawn:MovementComponent");
				return null;
			}
			return UObjectMarshaler<UPawnMovementComponent>.FromNative(IntPtr.Add(base.Address, MovementComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MovementComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DefaultPawn:MovementComponent");
			}
			else
			{
				UObjectMarshaler<UPawnMovementComponent>.ToNative(IntPtr.Add(base.Address, MovementComponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Engine.DefaultPawn:CollisionComponent")]
	public USphereComponent CollisionComponent
	{
		get
		{
			CheckDestroyed();
			if (!CollisionComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DefaultPawn:CollisionComponent");
				return null;
			}
			return UObjectMarshaler<USphereComponent>.FromNative(IntPtr.Add(base.Address, CollisionComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CollisionComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DefaultPawn:CollisionComponent");
			}
			else
			{
				UObjectMarshaler<USphereComponent>.ToNative(IntPtr.Add(base.Address, CollisionComponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Engine.DefaultPawn:MeshComponent")]
	public UStaticMeshComponent MeshComponent
	{
		get
		{
			CheckDestroyed();
			if (!MeshComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DefaultPawn:MeshComponent");
				return null;
			}
			return UObjectMarshaler<UStaticMeshComponent>.FromNative(IntPtr.Add(base.Address, MeshComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MeshComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DefaultPawn:MeshComponent");
			}
			else
			{
				UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(base.Address, MeshComponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.DefaultPawn:bAddDefaultMovementBindings")]
	public bool AddDefaultMovementBindings
	{
		get
		{
			CheckDestroyed();
			if (!AddDefaultMovementBindings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DefaultPawn:bAddDefaultMovementBindings");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AddDefaultMovementBindings_Offset), 0, AddDefaultMovementBindings_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AddDefaultMovementBindings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DefaultPawn:bAddDefaultMovementBindings");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AddDefaultMovementBindings_Offset), 0, AddDefaultMovementBindings_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.DefaultPawn:TurnAtRate")]
	public unsafe void TurnAtRate(float Rate)
	{
		CheckDestroyed();
		if (!TurnAtRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DefaultPawn:TurnAtRate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TurnAtRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TurnAtRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, TurnAtRate_Rate_Offset), 0, TurnAtRate_Rate_PropertyAddress.Address, Rate);
		NativeReflection.InvokeFunctionOptimized(base.Address, TurnAtRate_FunctionAddress, intPtr, TurnAtRate_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.DefaultPawn:MoveUp_World")]
	public unsafe void MoveUp_World(float Val)
	{
		CheckDestroyed();
		if (!MoveUp_World_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DefaultPawn:MoveUp_World");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MoveUp_World_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MoveUp_World_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MoveUp_World_Val_Offset), 0, MoveUp_World_Val_PropertyAddress.Address, Val);
		NativeReflection.InvokeFunctionOptimized(base.Address, MoveUp_World_FunctionAddress, intPtr, MoveUp_World_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.DefaultPawn:MoveRight")]
	public unsafe void MoveRight(float Val)
	{
		CheckDestroyed();
		if (!MoveRight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DefaultPawn:MoveRight");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MoveRight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MoveRight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MoveRight_Val_Offset), 0, MoveRight_Val_PropertyAddress.Address, Val);
		NativeReflection.InvokeFunctionOptimized(base.Address, MoveRight_FunctionAddress, intPtr, MoveRight_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.DefaultPawn:MoveForward")]
	public unsafe void MoveForward(float Val)
	{
		CheckDestroyed();
		if (!MoveForward_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DefaultPawn:MoveForward");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MoveForward_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MoveForward_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MoveForward_Val_Offset), 0, MoveForward_Val_PropertyAddress.Address, Val);
		NativeReflection.InvokeFunctionOptimized(base.Address, MoveForward_FunctionAddress, intPtr, MoveForward_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.DefaultPawn:LookUpAtRate")]
	public unsafe void LookUpAtRate(float Rate)
	{
		CheckDestroyed();
		if (!LookUpAtRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DefaultPawn:LookUpAtRate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LookUpAtRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LookUpAtRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, LookUpAtRate_Rate_Offset), 0, LookUpAtRate_Rate_PropertyAddress.Address, Rate);
		NativeReflection.InvokeFunctionOptimized(base.Address, LookUpAtRate_FunctionAddress, intPtr, LookUpAtRate_ParamsSize);
	}

	static ADefaultPawn()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ADefaultPawn)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ADefaultPawn));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.DefaultPawn");
		BaseTurnRate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BaseTurnRate");
		BaseTurnRate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BaseTurnRate", Classes.FFloatProperty);
		BaseLookUpRate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BaseLookUpRate");
		BaseLookUpRate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BaseLookUpRate", Classes.FFloatProperty);
		MovementComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MovementComponent");
		MovementComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MovementComponent", Classes.FObjectProperty);
		CollisionComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CollisionComponent");
		CollisionComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CollisionComponent", Classes.FObjectProperty);
		MeshComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MeshComponent");
		MeshComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MeshComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddDefaultMovementBindings_PropertyAddress, intPtr, "bAddDefaultMovementBindings");
		AddDefaultMovementBindings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAddDefaultMovementBindings");
		AddDefaultMovementBindings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAddDefaultMovementBindings", Classes.FBoolProperty);
		TurnAtRate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TurnAtRate");
		TurnAtRate_ParamsSize = NativeReflection.GetFunctionParamsSize(TurnAtRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TurnAtRate_Rate_PropertyAddress, TurnAtRate_FunctionAddress, "Rate");
		TurnAtRate_Rate_Offset = NativeReflectionCached.GetPropertyOffset(TurnAtRate_FunctionAddress, "Rate");
		TurnAtRate_Rate_IsValid = NativeReflectionCached.ValidatePropertyClass(TurnAtRate_FunctionAddress, "Rate", Classes.FFloatProperty);
		TurnAtRate_IsValid = TurnAtRate_FunctionAddress != IntPtr.Zero && TurnAtRate_Rate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DefaultPawn:TurnAtRate", TurnAtRate_IsValid);
		MoveUp_World_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "MoveUp_World");
		MoveUp_World_ParamsSize = NativeReflection.GetFunctionParamsSize(MoveUp_World_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MoveUp_World_Val_PropertyAddress, MoveUp_World_FunctionAddress, "Val");
		MoveUp_World_Val_Offset = NativeReflectionCached.GetPropertyOffset(MoveUp_World_FunctionAddress, "Val");
		MoveUp_World_Val_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveUp_World_FunctionAddress, "Val", Classes.FFloatProperty);
		MoveUp_World_IsValid = MoveUp_World_FunctionAddress != IntPtr.Zero && MoveUp_World_Val_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DefaultPawn:MoveUp_World", MoveUp_World_IsValid);
		MoveRight_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "MoveRight");
		MoveRight_ParamsSize = NativeReflection.GetFunctionParamsSize(MoveRight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MoveRight_Val_PropertyAddress, MoveRight_FunctionAddress, "Val");
		MoveRight_Val_Offset = NativeReflectionCached.GetPropertyOffset(MoveRight_FunctionAddress, "Val");
		MoveRight_Val_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveRight_FunctionAddress, "Val", Classes.FFloatProperty);
		MoveRight_IsValid = MoveRight_FunctionAddress != IntPtr.Zero && MoveRight_Val_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DefaultPawn:MoveRight", MoveRight_IsValid);
		MoveForward_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "MoveForward");
		MoveForward_ParamsSize = NativeReflection.GetFunctionParamsSize(MoveForward_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MoveForward_Val_PropertyAddress, MoveForward_FunctionAddress, "Val");
		MoveForward_Val_Offset = NativeReflectionCached.GetPropertyOffset(MoveForward_FunctionAddress, "Val");
		MoveForward_Val_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveForward_FunctionAddress, "Val", Classes.FFloatProperty);
		MoveForward_IsValid = MoveForward_FunctionAddress != IntPtr.Zero && MoveForward_Val_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DefaultPawn:MoveForward", MoveForward_IsValid);
		LookUpAtRate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "LookUpAtRate");
		LookUpAtRate_ParamsSize = NativeReflection.GetFunctionParamsSize(LookUpAtRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LookUpAtRate_Rate_PropertyAddress, LookUpAtRate_FunctionAddress, "Rate");
		LookUpAtRate_Rate_Offset = NativeReflectionCached.GetPropertyOffset(LookUpAtRate_FunctionAddress, "Rate");
		LookUpAtRate_Rate_IsValid = NativeReflectionCached.ValidatePropertyClass(LookUpAtRate_FunctionAddress, "Rate", Classes.FFloatProperty);
		LookUpAtRate_IsValid = LookUpAtRate_FunctionAddress != IntPtr.Zero && LookUpAtRate_Rate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DefaultPawn:LookUpAtRate", LookUpAtRate_IsValid);
	}
}
