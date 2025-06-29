using System;
using System.Runtime.CompilerServices;
using UnrealEngine.PhysicsCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.RadialForceComponent", "Engine", UnrealModuleType.Engine)]
public class URadialForceComponent : USceneComponent
{
	private static bool Radius_IsValid;

	private static int Radius_Offset;

	private static bool Falloff_IsValid;

	private static FFieldAddress Falloff_PropertyAddress;

	private static int Falloff_Offset;

	private static bool ImpulseStrength_IsValid;

	private static int ImpulseStrength_Offset;

	private static bool ImpulseVelChange_IsValid;

	private static FFieldAddress ImpulseVelChange_PropertyAddress;

	private static int ImpulseVelChange_Offset;

	private static bool IgnoreOwningActor_IsValid;

	private static FFieldAddress IgnoreOwningActor_PropertyAddress;

	private static int IgnoreOwningActor_Offset;

	private static bool ForceStrength_IsValid;

	private static int ForceStrength_Offset;

	private static bool DestructibleDamage_IsValid;

	private static int DestructibleDamage_Offset;

	private static bool RemoveObjectTypeToAffect_IsValid;

	private static IntPtr RemoveObjectTypeToAffect_FunctionAddress;

	private static int RemoveObjectTypeToAffect_ParamsSize;

	private static bool RemoveObjectTypeToAffect_ObjectType_IsValid;

	private static FFieldAddress RemoveObjectTypeToAffect_ObjectType_PropertyAddress;

	private static int RemoveObjectTypeToAffect_ObjectType_Offset;

	private static bool FireImpulse_IsValid;

	private static IntPtr FireImpulse_FunctionAddress;

	private static int FireImpulse_ParamsSize;

	private static bool AddObjectTypeToAffect_IsValid;

	private static IntPtr AddObjectTypeToAffect_FunctionAddress;

	private static int AddObjectTypeToAffect_ParamsSize;

	private static bool AddObjectTypeToAffect_ObjectType_IsValid;

	private static FFieldAddress AddObjectTypeToAffect_ObjectType_PropertyAddress;

	private static int AddObjectTypeToAffect_ObjectType_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/Engine.RadialForceComponent:Radius")]
	public float Radius
	{
		get
		{
			CheckDestroyed();
			if (!Radius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RadialForceComponent:Radius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Radius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Radius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RadialForceComponent:Radius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Radius_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.RadialForceComponent:Falloff")]
	public ERadialImpulseFalloff Falloff
	{
		get
		{
			CheckDestroyed();
			if (!Falloff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RadialForceComponent:Falloff");
				return ERadialImpulseFalloff.RIF_Constant;
			}
			return EnumMarshaler<ERadialImpulseFalloff>.FromNative(IntPtr.Add(base.Address, Falloff_Offset), 0, Falloff_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Falloff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RadialForceComponent:Falloff");
			}
			else
			{
				EnumMarshaler<ERadialImpulseFalloff>.ToNative(IntPtr.Add(base.Address, Falloff_Offset), 0, Falloff_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.RadialForceComponent:ImpulseStrength")]
	public float ImpulseStrength
	{
		get
		{
			CheckDestroyed();
			if (!ImpulseStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RadialForceComponent:ImpulseStrength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ImpulseStrength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ImpulseStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RadialForceComponent:ImpulseStrength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ImpulseStrength_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.RadialForceComponent:bImpulseVelChange")]
	public bool ImpulseVelChange
	{
		get
		{
			CheckDestroyed();
			if (!ImpulseVelChange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RadialForceComponent:bImpulseVelChange");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ImpulseVelChange_Offset), 0, ImpulseVelChange_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ImpulseVelChange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RadialForceComponent:bImpulseVelChange");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ImpulseVelChange_Offset), 0, ImpulseVelChange_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.RadialForceComponent:bIgnoreOwningActor")]
	public bool IgnoreOwningActor
	{
		get
		{
			CheckDestroyed();
			if (!IgnoreOwningActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RadialForceComponent:bIgnoreOwningActor");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IgnoreOwningActor_Offset), 0, IgnoreOwningActor_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IgnoreOwningActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RadialForceComponent:bIgnoreOwningActor");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IgnoreOwningActor_Offset), 0, IgnoreOwningActor_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.RadialForceComponent:ForceStrength")]
	public float ForceStrength
	{
		get
		{
			CheckDestroyed();
			if (!ForceStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RadialForceComponent:ForceStrength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ForceStrength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForceStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RadialForceComponent:ForceStrength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ForceStrength_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.RadialForceComponent:DestructibleDamage")]
	public float DestructibleDamage
	{
		get
		{
			CheckDestroyed();
			if (!DestructibleDamage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RadialForceComponent:DestructibleDamage");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DestructibleDamage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DestructibleDamage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RadialForceComponent:DestructibleDamage");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DestructibleDamage_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.RadialForceComponent:RemoveObjectTypeToAffect")]
	public unsafe void RemoveObjectTypeToAffect(EObjectTypeQuery ObjectType)
	{
		CheckDestroyed();
		if (!RemoveObjectTypeToAffect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.RadialForceComponent:RemoveObjectTypeToAffect");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveObjectTypeToAffect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveObjectTypeToAffect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EObjectTypeQuery>.ToNative(IntPtr.Add(intPtr, RemoveObjectTypeToAffect_ObjectType_Offset), 0, RemoveObjectTypeToAffect_ObjectType_PropertyAddress.Address, ObjectType);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveObjectTypeToAffect_FunctionAddress, intPtr, RemoveObjectTypeToAffect_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.RadialForceComponent:FireImpulse")]
	public unsafe void FireImpulse()
	{
		CheckDestroyed();
		if (!FireImpulse_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.RadialForceComponent:FireImpulse");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FireImpulse_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FireImpulse_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: FireImpulse_FunctionAddress, argsSize: FireImpulse_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.RadialForceComponent:AddObjectTypeToAffect")]
	public unsafe void AddObjectTypeToAffect(EObjectTypeQuery ObjectType)
	{
		CheckDestroyed();
		if (!AddObjectTypeToAffect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.RadialForceComponent:AddObjectTypeToAffect");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddObjectTypeToAffect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddObjectTypeToAffect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EObjectTypeQuery>.ToNative(IntPtr.Add(intPtr, AddObjectTypeToAffect_ObjectType_Offset), 0, AddObjectTypeToAffect_ObjectType_PropertyAddress.Address, ObjectType);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddObjectTypeToAffect_FunctionAddress, intPtr, AddObjectTypeToAffect_ParamsSize);
	}

	static URadialForceComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(URadialForceComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(URadialForceComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.RadialForceComponent");
		Radius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Radius");
		Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Falloff_PropertyAddress, intPtr, "Falloff");
		Falloff_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Falloff");
		Falloff_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Falloff", Classes.FByteProperty);
		ImpulseStrength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ImpulseStrength");
		ImpulseStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ImpulseStrength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ImpulseVelChange_PropertyAddress, intPtr, "bImpulseVelChange");
		ImpulseVelChange_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bImpulseVelChange");
		ImpulseVelChange_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bImpulseVelChange", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IgnoreOwningActor_PropertyAddress, intPtr, "bIgnoreOwningActor");
		IgnoreOwningActor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIgnoreOwningActor");
		IgnoreOwningActor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIgnoreOwningActor", Classes.FBoolProperty);
		ForceStrength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ForceStrength");
		ForceStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ForceStrength", Classes.FFloatProperty);
		DestructibleDamage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DestructibleDamage");
		DestructibleDamage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DestructibleDamage", Classes.FFloatProperty);
		RemoveObjectTypeToAffect_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveObjectTypeToAffect");
		RemoveObjectTypeToAffect_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveObjectTypeToAffect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveObjectTypeToAffect_ObjectType_PropertyAddress, RemoveObjectTypeToAffect_FunctionAddress, "ObjectType");
		RemoveObjectTypeToAffect_ObjectType_Offset = NativeReflectionCached.GetPropertyOffset(RemoveObjectTypeToAffect_FunctionAddress, "ObjectType");
		RemoveObjectTypeToAffect_ObjectType_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveObjectTypeToAffect_FunctionAddress, "ObjectType", Classes.FByteProperty);
		RemoveObjectTypeToAffect_IsValid = RemoveObjectTypeToAffect_FunctionAddress != IntPtr.Zero && RemoveObjectTypeToAffect_ObjectType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.RadialForceComponent:RemoveObjectTypeToAffect", RemoveObjectTypeToAffect_IsValid);
		FireImpulse_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FireImpulse");
		FireImpulse_ParamsSize = NativeReflection.GetFunctionParamsSize(FireImpulse_FunctionAddress);
		FireImpulse_IsValid = FireImpulse_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.RadialForceComponent:FireImpulse", FireImpulse_IsValid);
		AddObjectTypeToAffect_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddObjectTypeToAffect");
		AddObjectTypeToAffect_ParamsSize = NativeReflection.GetFunctionParamsSize(AddObjectTypeToAffect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddObjectTypeToAffect_ObjectType_PropertyAddress, AddObjectTypeToAffect_FunctionAddress, "ObjectType");
		AddObjectTypeToAffect_ObjectType_Offset = NativeReflectionCached.GetPropertyOffset(AddObjectTypeToAffect_FunctionAddress, "ObjectType");
		AddObjectTypeToAffect_ObjectType_IsValid = NativeReflectionCached.ValidatePropertyClass(AddObjectTypeToAffect_FunctionAddress, "ObjectType", Classes.FByteProperty);
		AddObjectTypeToAffect_IsValid = AddObjectTypeToAffect_FunctionAddress != IntPtr.Zero && AddObjectTypeToAffect_ObjectType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.RadialForceComponent:AddObjectTypeToAffect", AddObjectTypeToAffect_IsValid);
	}
}
