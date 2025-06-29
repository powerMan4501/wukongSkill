using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.TakeAnyDamageSignature__DelegateSignature")]
public class FTakeAnyDamageSignature : FMulticastDelegate<FTakeAnyDamageSignature.Signature>
{
	public delegate void Signature(AActor DamagedActor, float Damage, UDamageType DamageType, AController InstigatedBy, AActor DamageCauser);

	private static bool TakeAnyDamageSignature__DelegateSignature_IsValid;

	private static IntPtr TakeAnyDamageSignature__DelegateSignature_FunctionAddress;

	private static int TakeAnyDamageSignature__DelegateSignature_ParamsSize;

	private static bool TakeAnyDamageSignature__DelegateSignature_DamagedActor_IsValid;

	private static FFieldAddress TakeAnyDamageSignature__DelegateSignature_DamagedActor_PropertyAddress;

	private static int TakeAnyDamageSignature__DelegateSignature_DamagedActor_Offset;

	private static bool TakeAnyDamageSignature__DelegateSignature_Damage_IsValid;

	private static FFieldAddress TakeAnyDamageSignature__DelegateSignature_Damage_PropertyAddress;

	private static int TakeAnyDamageSignature__DelegateSignature_Damage_Offset;

	private static bool TakeAnyDamageSignature__DelegateSignature_DamageType_IsValid;

	private static FFieldAddress TakeAnyDamageSignature__DelegateSignature_DamageType_PropertyAddress;

	private static int TakeAnyDamageSignature__DelegateSignature_DamageType_Offset;

	private static bool TakeAnyDamageSignature__DelegateSignature_InstigatedBy_IsValid;

	private static FFieldAddress TakeAnyDamageSignature__DelegateSignature_InstigatedBy_PropertyAddress;

	private static int TakeAnyDamageSignature__DelegateSignature_InstigatedBy_Offset;

	private static bool TakeAnyDamageSignature__DelegateSignature_DamageCauser_IsValid;

	private static FFieldAddress TakeAnyDamageSignature__DelegateSignature_DamageCauser_PropertyAddress;

	private static int TakeAnyDamageSignature__DelegateSignature_DamageCauser_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FTakeAnyDamageSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		TakeAnyDamageSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.TakeAnyDamageSignature__DelegateSignature");
		TakeAnyDamageSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(TakeAnyDamageSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TakeAnyDamageSignature__DelegateSignature_DamagedActor_PropertyAddress, TakeAnyDamageSignature__DelegateSignature_FunctionAddress, "DamagedActor");
		TakeAnyDamageSignature__DelegateSignature_DamagedActor_Offset = NativeReflectionCached.GetPropertyOffset(TakeAnyDamageSignature__DelegateSignature_FunctionAddress, "DamagedActor");
		TakeAnyDamageSignature__DelegateSignature_DamagedActor_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeAnyDamageSignature__DelegateSignature_FunctionAddress, "DamagedActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref TakeAnyDamageSignature__DelegateSignature_Damage_PropertyAddress, TakeAnyDamageSignature__DelegateSignature_FunctionAddress, "Damage");
		TakeAnyDamageSignature__DelegateSignature_Damage_Offset = NativeReflectionCached.GetPropertyOffset(TakeAnyDamageSignature__DelegateSignature_FunctionAddress, "Damage");
		TakeAnyDamageSignature__DelegateSignature_Damage_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeAnyDamageSignature__DelegateSignature_FunctionAddress, "Damage", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref TakeAnyDamageSignature__DelegateSignature_DamageType_PropertyAddress, TakeAnyDamageSignature__DelegateSignature_FunctionAddress, "DamageType");
		TakeAnyDamageSignature__DelegateSignature_DamageType_Offset = NativeReflectionCached.GetPropertyOffset(TakeAnyDamageSignature__DelegateSignature_FunctionAddress, "DamageType");
		TakeAnyDamageSignature__DelegateSignature_DamageType_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeAnyDamageSignature__DelegateSignature_FunctionAddress, "DamageType", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref TakeAnyDamageSignature__DelegateSignature_InstigatedBy_PropertyAddress, TakeAnyDamageSignature__DelegateSignature_FunctionAddress, "InstigatedBy");
		TakeAnyDamageSignature__DelegateSignature_InstigatedBy_Offset = NativeReflectionCached.GetPropertyOffset(TakeAnyDamageSignature__DelegateSignature_FunctionAddress, "InstigatedBy");
		TakeAnyDamageSignature__DelegateSignature_InstigatedBy_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeAnyDamageSignature__DelegateSignature_FunctionAddress, "InstigatedBy", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref TakeAnyDamageSignature__DelegateSignature_DamageCauser_PropertyAddress, TakeAnyDamageSignature__DelegateSignature_FunctionAddress, "DamageCauser");
		TakeAnyDamageSignature__DelegateSignature_DamageCauser_Offset = NativeReflectionCached.GetPropertyOffset(TakeAnyDamageSignature__DelegateSignature_FunctionAddress, "DamageCauser");
		TakeAnyDamageSignature__DelegateSignature_DamageCauser_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeAnyDamageSignature__DelegateSignature_FunctionAddress, "DamageCauser", Classes.FObjectProperty);
		TakeAnyDamageSignature__DelegateSignature_IsValid = TakeAnyDamageSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && TakeAnyDamageSignature__DelegateSignature_DamagedActor_IsValid && TakeAnyDamageSignature__DelegateSignature_Damage_IsValid && TakeAnyDamageSignature__DelegateSignature_DamageType_IsValid && TakeAnyDamageSignature__DelegateSignature_InstigatedBy_IsValid && TakeAnyDamageSignature__DelegateSignature_DamageCauser_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TakeAnyDamageSignature__DelegateSignature", TakeAnyDamageSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(AActor DamagedActor, float Damage, UDamageType DamageType, AController InstigatedBy, AActor DamageCauser)
	{
		if (!TakeAnyDamageSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TakeAnyDamageSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(TakeAnyDamageSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TakeAnyDamageSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, TakeAnyDamageSignature__DelegateSignature_DamagedActor_Offset), 0, TakeAnyDamageSignature__DelegateSignature_DamagedActor_PropertyAddress.Address, DamagedActor);
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, TakeAnyDamageSignature__DelegateSignature_Damage_Offset), 0, TakeAnyDamageSignature__DelegateSignature_Damage_PropertyAddress.Address, Damage);
			UObjectMarshaler<UDamageType>.ToNative(IntPtr.Add(intPtr, TakeAnyDamageSignature__DelegateSignature_DamageType_Offset), 0, TakeAnyDamageSignature__DelegateSignature_DamageType_PropertyAddress.Address, DamageType);
			UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, TakeAnyDamageSignature__DelegateSignature_InstigatedBy_Offset), 0, TakeAnyDamageSignature__DelegateSignature_InstigatedBy_PropertyAddress.Address, InstigatedBy);
			UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, TakeAnyDamageSignature__DelegateSignature_DamageCauser_Offset), 0, TakeAnyDamageSignature__DelegateSignature_DamageCauser_PropertyAddress.Address, DamageCauser);
			ProcessDelegate(intPtr);
		}
	}
}
