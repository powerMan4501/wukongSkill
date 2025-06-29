using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810025120uL, Config = "Engine")]
[UMetaPath("/Script/Engine.SkeletalMeshSocket", "Engine", UnrealModuleType.Engine)]
public class USkeletalMeshSocket : UObject
{
	private static bool SocketName_IsValid;

	private static int SocketName_Offset;

	private static bool BoneName_IsValid;

	private static int BoneName_Offset;

	private static bool RelativeLocation_IsValid;

	private static int RelativeLocation_Offset;

	private static bool RelativeRotation_IsValid;

	private static int RelativeRotation_Offset;

	private static bool RelativeScale_IsValid;

	private static int RelativeScale_Offset;

	private static bool ForceAlwaysAnimated_IsValid;

	private static FFieldAddress ForceAlwaysAnimated_PropertyAddress;

	private static int ForceAlwaysAnimated_Offset;

	private static bool InitializeSocketFromLocation_IsValid;

	private static IntPtr InitializeSocketFromLocation_FunctionAddress;

	private static int InitializeSocketFromLocation_ParamsSize;

	private static bool InitializeSocketFromLocation_SkelComp_IsValid;

	private static FFieldAddress InitializeSocketFromLocation_SkelComp_PropertyAddress;

	private static int InitializeSocketFromLocation_SkelComp_Offset;

	private static bool InitializeSocketFromLocation_WorldLocation_IsValid;

	private static FFieldAddress InitializeSocketFromLocation_WorldLocation_PropertyAddress;

	private static int InitializeSocketFromLocation_WorldLocation_Offset;

	private static bool InitializeSocketFromLocation_WorldNormal_IsValid;

	private static FFieldAddress InitializeSocketFromLocation_WorldNormal_PropertyAddress;

	private static int InitializeSocketFromLocation_WorldNormal_Offset;

	private static bool GetSocketLocation_IsValid;

	private static IntPtr GetSocketLocation_FunctionAddress;

	private static int GetSocketLocation_ParamsSize;

	private static bool GetSocketLocation_SkelComp_IsValid;

	private static FFieldAddress GetSocketLocation_SkelComp_PropertyAddress;

	private static int GetSocketLocation_SkelComp_Offset;

	private static bool GetSocketLocation_ReturnValue_IsValid;

	private static FFieldAddress GetSocketLocation_ReturnValue_PropertyAddress;

	private static int GetSocketLocation_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/Engine.SkeletalMeshSocket:SocketName")]
	public FName SocketName
	{
		get
		{
			CheckDestroyed();
			if (!SocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMeshSocket:SocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMeshSocket:SocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SocketName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/Engine.SkeletalMeshSocket:BoneName")]
	public FName BoneName
	{
		get
		{
			CheckDestroyed();
			if (!BoneName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMeshSocket:BoneName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, BoneName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BoneName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMeshSocket:BoneName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, BoneName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SkeletalMeshSocket:RelativeLocation")]
	public FVector RelativeLocation
	{
		get
		{
			CheckDestroyed();
			if (!RelativeLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMeshSocket:RelativeLocation");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, RelativeLocation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RelativeLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMeshSocket:RelativeLocation");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, RelativeLocation_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589589uL)]
	[UMetaPath("/Script/Engine.SkeletalMeshSocket:RelativeRotation")]
	public FRotator RelativeRotation
	{
		get
		{
			CheckDestroyed();
			if (!RelativeRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMeshSocket:RelativeRotation");
				return default(FRotator);
			}
			return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(base.Address, RelativeRotation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RelativeRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMeshSocket:RelativeRotation");
			}
			else
			{
				BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(base.Address, RelativeRotation_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SkeletalMeshSocket:RelativeScale")]
	public FVector RelativeScale
	{
		get
		{
			CheckDestroyed();
			if (!RelativeScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMeshSocket:RelativeScale");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, RelativeScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RelativeScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMeshSocket:RelativeScale");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, RelativeScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SkeletalMeshSocket:bForceAlwaysAnimated")]
	public bool ForceAlwaysAnimated
	{
		get
		{
			CheckDestroyed();
			if (!ForceAlwaysAnimated_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMeshSocket:bForceAlwaysAnimated");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ForceAlwaysAnimated_Offset), 0, ForceAlwaysAnimated_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ForceAlwaysAnimated_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkeletalMeshSocket:bForceAlwaysAnimated");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ForceAlwaysAnimated_Offset), 0, ForceAlwaysAnimated_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 75629571u)]
	[UMetaPath("/Script/Engine.SkeletalMeshSocket:InitializeSocketFromLocation")]
	public unsafe void InitializeSocketFromLocation(USkeletalMeshComponent SkelComp, FVector WorldLocation, FVector WorldNormal)
	{
		CheckDestroyed();
		if (!InitializeSocketFromLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkeletalMeshSocket:InitializeSocketFromLocation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitializeSocketFromLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitializeSocketFromLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, InitializeSocketFromLocation_SkelComp_Offset), 0, InitializeSocketFromLocation_SkelComp_PropertyAddress.Address, SkelComp);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, InitializeSocketFromLocation_WorldLocation_Offset), 0, InitializeSocketFromLocation_WorldLocation_PropertyAddress.Address, WorldLocation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, InitializeSocketFromLocation_WorldNormal_Offset), 0, InitializeSocketFromLocation_WorldNormal_PropertyAddress.Address, WorldNormal);
		NativeReflection.InvokeFunctionOptimized(base.Address, InitializeSocketFromLocation_FunctionAddress, intPtr, InitializeSocketFromLocation_ParamsSize);
	}

	[UFunction(Flags = 1417806851u)]
	[UMetaPath("/Script/Engine.SkeletalMeshSocket:GetSocketLocation")]
	public unsafe FVector GetSocketLocation(USkeletalMeshComponent SkelComp)
	{
		CheckDestroyed();
		if (!GetSocketLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SkeletalMeshSocket:GetSocketLocation");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSocketLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSocketLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, GetSocketLocation_SkelComp_Offset), 0, GetSocketLocation_SkelComp_PropertyAddress.Address, SkelComp);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSocketLocation_FunctionAddress, intPtr, GetSocketLocation_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetSocketLocation_ReturnValue_Offset), 0, GetSocketLocation_ReturnValue_PropertyAddress.Address);
	}

	static USkeletalMeshSocket()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USkeletalMeshSocket)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USkeletalMeshSocket));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.SkeletalMeshSocket");
		SocketName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SocketName");
		SocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SocketName", Classes.FNameProperty);
		BoneName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BoneName");
		BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BoneName", Classes.FNameProperty);
		RelativeLocation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RelativeLocation");
		RelativeLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RelativeLocation", Classes.FStructProperty);
		RelativeRotation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RelativeRotation");
		RelativeRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RelativeRotation", Classes.FStructProperty);
		RelativeScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RelativeScale");
		RelativeScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RelativeScale", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ForceAlwaysAnimated_PropertyAddress, intPtr, "bForceAlwaysAnimated");
		ForceAlwaysAnimated_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bForceAlwaysAnimated");
		ForceAlwaysAnimated_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bForceAlwaysAnimated", Classes.FBoolProperty);
		InitializeSocketFromLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InitializeSocketFromLocation");
		InitializeSocketFromLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(InitializeSocketFromLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InitializeSocketFromLocation_SkelComp_PropertyAddress, InitializeSocketFromLocation_FunctionAddress, "SkelComp");
		InitializeSocketFromLocation_SkelComp_Offset = NativeReflectionCached.GetPropertyOffset(InitializeSocketFromLocation_FunctionAddress, "SkelComp");
		InitializeSocketFromLocation_SkelComp_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializeSocketFromLocation_FunctionAddress, "SkelComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref InitializeSocketFromLocation_WorldLocation_PropertyAddress, InitializeSocketFromLocation_FunctionAddress, "WorldLocation");
		InitializeSocketFromLocation_WorldLocation_Offset = NativeReflectionCached.GetPropertyOffset(InitializeSocketFromLocation_FunctionAddress, "WorldLocation");
		InitializeSocketFromLocation_WorldLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializeSocketFromLocation_FunctionAddress, "WorldLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref InitializeSocketFromLocation_WorldNormal_PropertyAddress, InitializeSocketFromLocation_FunctionAddress, "WorldNormal");
		InitializeSocketFromLocation_WorldNormal_Offset = NativeReflectionCached.GetPropertyOffset(InitializeSocketFromLocation_FunctionAddress, "WorldNormal");
		InitializeSocketFromLocation_WorldNormal_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializeSocketFromLocation_FunctionAddress, "WorldNormal", Classes.FStructProperty);
		InitializeSocketFromLocation_IsValid = InitializeSocketFromLocation_FunctionAddress != IntPtr.Zero && InitializeSocketFromLocation_SkelComp_IsValid && InitializeSocketFromLocation_WorldLocation_IsValid && InitializeSocketFromLocation_WorldNormal_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkeletalMeshSocket:InitializeSocketFromLocation", InitializeSocketFromLocation_IsValid);
		GetSocketLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSocketLocation");
		GetSocketLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSocketLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSocketLocation_SkelComp_PropertyAddress, GetSocketLocation_FunctionAddress, "SkelComp");
		GetSocketLocation_SkelComp_Offset = NativeReflectionCached.GetPropertyOffset(GetSocketLocation_FunctionAddress, "SkelComp");
		GetSocketLocation_SkelComp_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSocketLocation_FunctionAddress, "SkelComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSocketLocation_ReturnValue_PropertyAddress, GetSocketLocation_FunctionAddress, "ReturnValue");
		GetSocketLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSocketLocation_FunctionAddress, "ReturnValue");
		GetSocketLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSocketLocation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetSocketLocation_IsValid = GetSocketLocation_FunctionAddress != IntPtr.Zero && GetSocketLocation_SkelComp_IsValid && GetSocketLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SkeletalMeshSocket:GetSocketLocation", GetSocketLocation_IsValid);
	}
}
