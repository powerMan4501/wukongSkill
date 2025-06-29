using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.PhysicsSpringComponent", "Engine", UnrealModuleType.Engine)]
public class UPhysicsSpringComponent : USceneComponent
{
	private static bool SpringStiffness_IsValid;

	private static int SpringStiffness_Offset;

	private static bool SpringDamping_IsValid;

	private static int SpringDamping_Offset;

	private static bool SpringLengthAtRest_IsValid;

	private static int SpringLengthAtRest_Offset;

	private static bool SpringRadius_IsValid;

	private static int SpringRadius_Offset;

	private static bool SpringChannel_IsValid;

	private static FFieldAddress SpringChannel_PropertyAddress;

	private static int SpringChannel_Offset;

	private static bool IgnoreSelf_IsValid;

	private static FFieldAddress IgnoreSelf_PropertyAddress;

	private static int IgnoreSelf_Offset;

	private static bool SpringCompression_IsValid;

	private static int SpringCompression_Offset;

	private static bool GetSpringRestingPoint_IsValid;

	private static IntPtr GetSpringRestingPoint_FunctionAddress;

	private static int GetSpringRestingPoint_ParamsSize;

	private static bool GetSpringRestingPoint_ReturnValue_IsValid;

	private static FFieldAddress GetSpringRestingPoint_ReturnValue_PropertyAddress;

	private static int GetSpringRestingPoint_ReturnValue_Offset;

	private static bool GetSpringDirection_IsValid;

	private static IntPtr GetSpringDirection_FunctionAddress;

	private static int GetSpringDirection_ParamsSize;

	private static bool GetSpringDirection_ReturnValue_IsValid;

	private static FFieldAddress GetSpringDirection_ReturnValue_PropertyAddress;

	private static int GetSpringDirection_ReturnValue_Offset;

	private static bool GetSpringCurrentEndPoint_IsValid;

	private static IntPtr GetSpringCurrentEndPoint_FunctionAddress;

	private static int GetSpringCurrentEndPoint_ParamsSize;

	private static bool GetSpringCurrentEndPoint_ReturnValue_IsValid;

	private static FFieldAddress GetSpringCurrentEndPoint_ReturnValue_PropertyAddress;

	private static int GetSpringCurrentEndPoint_ReturnValue_Offset;

	private static bool GetNormalizedCompressionScalar_IsValid;

	private static IntPtr GetNormalizedCompressionScalar_FunctionAddress;

	private static int GetNormalizedCompressionScalar_ParamsSize;

	private static bool GetNormalizedCompressionScalar_ReturnValue_IsValid;

	private static FFieldAddress GetNormalizedCompressionScalar_ReturnValue_PropertyAddress;

	private static int GetNormalizedCompressionScalar_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PhysicsSpringComponent:SpringStiffness")]
	public float SpringStiffness
	{
		get
		{
			CheckDestroyed();
			if (!SpringStiffness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsSpringComponent:SpringStiffness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SpringStiffness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpringStiffness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsSpringComponent:SpringStiffness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SpringStiffness_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PhysicsSpringComponent:SpringDamping")]
	public float SpringDamping
	{
		get
		{
			CheckDestroyed();
			if (!SpringDamping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsSpringComponent:SpringDamping");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SpringDamping_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpringDamping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsSpringComponent:SpringDamping");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SpringDamping_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PhysicsSpringComponent:SpringLengthAtRest")]
	public float SpringLengthAtRest
	{
		get
		{
			CheckDestroyed();
			if (!SpringLengthAtRest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsSpringComponent:SpringLengthAtRest");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SpringLengthAtRest_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpringLengthAtRest_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsSpringComponent:SpringLengthAtRest");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SpringLengthAtRest_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PhysicsSpringComponent:SpringRadius")]
	public float SpringRadius
	{
		get
		{
			CheckDestroyed();
			if (!SpringRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsSpringComponent:SpringRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SpringRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpringRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsSpringComponent:SpringRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SpringRadius_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Engine.PhysicsSpringComponent:SpringChannel")]
	public ECollisionChannel SpringChannel
	{
		get
		{
			CheckDestroyed();
			if (!SpringChannel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsSpringComponent:SpringChannel");
				return ECollisionChannel.ECC_WorldStatic;
			}
			return EnumMarshaler<ECollisionChannel>.FromNative(IntPtr.Add(base.Address, SpringChannel_Offset), 0, SpringChannel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SpringChannel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsSpringComponent:SpringChannel");
			}
			else
			{
				EnumMarshaler<ECollisionChannel>.ToNative(IntPtr.Add(base.Address, SpringChannel_Offset), 0, SpringChannel_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.PhysicsSpringComponent:bIgnoreSelf")]
	public bool IgnoreSelf
	{
		get
		{
			CheckDestroyed();
			if (!IgnoreSelf_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsSpringComponent:bIgnoreSelf");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IgnoreSelf_Offset), 0, IgnoreSelf_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IgnoreSelf_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsSpringComponent:bIgnoreSelf");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IgnoreSelf_Offset), 0, IgnoreSelf_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234283028uL)]
	[UMetaPath("/Script/Engine.PhysicsSpringComponent:SpringCompression")]
	public float SpringCompression
	{
		get
		{
			CheckDestroyed();
			if (!SpringCompression_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsSpringComponent:SpringCompression");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SpringCompression_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpringCompression_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PhysicsSpringComponent:SpringCompression");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SpringCompression_Offset), value);
			}
		}
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.PhysicsSpringComponent:GetSpringRestingPoint")]
	public unsafe FVector GetSpringRestingPoint()
	{
		CheckDestroyed();
		if (!GetSpringRestingPoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsSpringComponent:GetSpringRestingPoint");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSpringRestingPoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSpringRestingPoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSpringRestingPoint_FunctionAddress, intPtr, GetSpringRestingPoint_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetSpringRestingPoint_ReturnValue_Offset), 0, GetSpringRestingPoint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.PhysicsSpringComponent:GetSpringDirection")]
	public unsafe FVector GetSpringDirection()
	{
		CheckDestroyed();
		if (!GetSpringDirection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsSpringComponent:GetSpringDirection");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSpringDirection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSpringDirection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSpringDirection_FunctionAddress, intPtr, GetSpringDirection_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetSpringDirection_ReturnValue_Offset), 0, GetSpringDirection_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.PhysicsSpringComponent:GetSpringCurrentEndPoint")]
	public unsafe FVector GetSpringCurrentEndPoint()
	{
		CheckDestroyed();
		if (!GetSpringCurrentEndPoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsSpringComponent:GetSpringCurrentEndPoint");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSpringCurrentEndPoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSpringCurrentEndPoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSpringCurrentEndPoint_FunctionAddress, intPtr, GetSpringCurrentEndPoint_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetSpringCurrentEndPoint_ReturnValue_Offset), 0, GetSpringCurrentEndPoint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.PhysicsSpringComponent:GetNormalizedCompressionScalar")]
	public unsafe float GetNormalizedCompressionScalar()
	{
		CheckDestroyed();
		if (!GetNormalizedCompressionScalar_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PhysicsSpringComponent:GetNormalizedCompressionScalar");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNormalizedCompressionScalar_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNormalizedCompressionScalar_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNormalizedCompressionScalar_FunctionAddress, intPtr, GetNormalizedCompressionScalar_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetNormalizedCompressionScalar_ReturnValue_Offset), 0, GetNormalizedCompressionScalar_ReturnValue_PropertyAddress.Address);
	}

	static UPhysicsSpringComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPhysicsSpringComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPhysicsSpringComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.PhysicsSpringComponent");
		SpringStiffness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpringStiffness");
		SpringStiffness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpringStiffness", Classes.FFloatProperty);
		SpringDamping_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpringDamping");
		SpringDamping_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpringDamping", Classes.FFloatProperty);
		SpringLengthAtRest_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpringLengthAtRest");
		SpringLengthAtRest_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpringLengthAtRest", Classes.FFloatProperty);
		SpringRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpringRadius");
		SpringRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpringRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SpringChannel_PropertyAddress, intPtr, "SpringChannel");
		SpringChannel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpringChannel");
		SpringChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpringChannel", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref IgnoreSelf_PropertyAddress, intPtr, "bIgnoreSelf");
		IgnoreSelf_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIgnoreSelf");
		IgnoreSelf_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIgnoreSelf", Classes.FBoolProperty);
		SpringCompression_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpringCompression");
		SpringCompression_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpringCompression", Classes.FFloatProperty);
		GetSpringRestingPoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSpringRestingPoint");
		GetSpringRestingPoint_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSpringRestingPoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSpringRestingPoint_ReturnValue_PropertyAddress, GetSpringRestingPoint_FunctionAddress, "ReturnValue");
		GetSpringRestingPoint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSpringRestingPoint_FunctionAddress, "ReturnValue");
		GetSpringRestingPoint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSpringRestingPoint_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetSpringRestingPoint_IsValid = GetSpringRestingPoint_FunctionAddress != IntPtr.Zero && GetSpringRestingPoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsSpringComponent:GetSpringRestingPoint", GetSpringRestingPoint_IsValid);
		GetSpringDirection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSpringDirection");
		GetSpringDirection_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSpringDirection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSpringDirection_ReturnValue_PropertyAddress, GetSpringDirection_FunctionAddress, "ReturnValue");
		GetSpringDirection_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSpringDirection_FunctionAddress, "ReturnValue");
		GetSpringDirection_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSpringDirection_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetSpringDirection_IsValid = GetSpringDirection_FunctionAddress != IntPtr.Zero && GetSpringDirection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsSpringComponent:GetSpringDirection", GetSpringDirection_IsValid);
		GetSpringCurrentEndPoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSpringCurrentEndPoint");
		GetSpringCurrentEndPoint_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSpringCurrentEndPoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSpringCurrentEndPoint_ReturnValue_PropertyAddress, GetSpringCurrentEndPoint_FunctionAddress, "ReturnValue");
		GetSpringCurrentEndPoint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSpringCurrentEndPoint_FunctionAddress, "ReturnValue");
		GetSpringCurrentEndPoint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSpringCurrentEndPoint_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetSpringCurrentEndPoint_IsValid = GetSpringCurrentEndPoint_FunctionAddress != IntPtr.Zero && GetSpringCurrentEndPoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsSpringComponent:GetSpringCurrentEndPoint", GetSpringCurrentEndPoint_IsValid);
		GetNormalizedCompressionScalar_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNormalizedCompressionScalar");
		GetNormalizedCompressionScalar_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNormalizedCompressionScalar_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNormalizedCompressionScalar_ReturnValue_PropertyAddress, GetNormalizedCompressionScalar_FunctionAddress, "ReturnValue");
		GetNormalizedCompressionScalar_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNormalizedCompressionScalar_FunctionAddress, "ReturnValue");
		GetNormalizedCompressionScalar_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNormalizedCompressionScalar_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetNormalizedCompressionScalar_IsValid = GetNormalizedCompressionScalar_FunctionAddress != IntPtr.Zero && GetNormalizedCompressionScalar_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PhysicsSpringComponent:GetNormalizedCompressionScalar", GetNormalizedCompressionScalar_IsValid);
	}
}
