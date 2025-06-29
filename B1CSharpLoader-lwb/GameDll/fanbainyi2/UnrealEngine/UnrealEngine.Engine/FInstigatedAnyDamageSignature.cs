using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.InstigatedAnyDamageSignature__DelegateSignature")]
public class FInstigatedAnyDamageSignature : FMulticastDelegate<FInstigatedAnyDamageSignature.Signature>
{
	public delegate void Signature(float Damage, UDamageType DamageType, AActor DamagedActor, AActor DamageCauser);

	private static bool InstigatedAnyDamageSignature__DelegateSignature_IsValid;

	private static IntPtr InstigatedAnyDamageSignature__DelegateSignature_FunctionAddress;

	private static int InstigatedAnyDamageSignature__DelegateSignature_ParamsSize;

	private static bool InstigatedAnyDamageSignature__DelegateSignature_Damage_IsValid;

	private static FFieldAddress InstigatedAnyDamageSignature__DelegateSignature_Damage_PropertyAddress;

	private static int InstigatedAnyDamageSignature__DelegateSignature_Damage_Offset;

	private static bool InstigatedAnyDamageSignature__DelegateSignature_DamageType_IsValid;

	private static FFieldAddress InstigatedAnyDamageSignature__DelegateSignature_DamageType_PropertyAddress;

	private static int InstigatedAnyDamageSignature__DelegateSignature_DamageType_Offset;

	private static bool InstigatedAnyDamageSignature__DelegateSignature_DamagedActor_IsValid;

	private static FFieldAddress InstigatedAnyDamageSignature__DelegateSignature_DamagedActor_PropertyAddress;

	private static int InstigatedAnyDamageSignature__DelegateSignature_DamagedActor_Offset;

	private static bool InstigatedAnyDamageSignature__DelegateSignature_DamageCauser_IsValid;

	private static FFieldAddress InstigatedAnyDamageSignature__DelegateSignature_DamageCauser_PropertyAddress;

	private static int InstigatedAnyDamageSignature__DelegateSignature_DamageCauser_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FInstigatedAnyDamageSignature()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		InstigatedAnyDamageSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.InstigatedAnyDamageSignature__DelegateSignature");
		InstigatedAnyDamageSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(InstigatedAnyDamageSignature__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InstigatedAnyDamageSignature__DelegateSignature_Damage_PropertyAddress, InstigatedAnyDamageSignature__DelegateSignature_FunctionAddress, "Damage");
		InstigatedAnyDamageSignature__DelegateSignature_Damage_Offset = NativeReflectionCached.GetPropertyOffset(InstigatedAnyDamageSignature__DelegateSignature_FunctionAddress, "Damage");
		InstigatedAnyDamageSignature__DelegateSignature_Damage_IsValid = NativeReflectionCached.ValidatePropertyClass(InstigatedAnyDamageSignature__DelegateSignature_FunctionAddress, "Damage", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref InstigatedAnyDamageSignature__DelegateSignature_DamageType_PropertyAddress, InstigatedAnyDamageSignature__DelegateSignature_FunctionAddress, "DamageType");
		InstigatedAnyDamageSignature__DelegateSignature_DamageType_Offset = NativeReflectionCached.GetPropertyOffset(InstigatedAnyDamageSignature__DelegateSignature_FunctionAddress, "DamageType");
		InstigatedAnyDamageSignature__DelegateSignature_DamageType_IsValid = NativeReflectionCached.ValidatePropertyClass(InstigatedAnyDamageSignature__DelegateSignature_FunctionAddress, "DamageType", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref InstigatedAnyDamageSignature__DelegateSignature_DamagedActor_PropertyAddress, InstigatedAnyDamageSignature__DelegateSignature_FunctionAddress, "DamagedActor");
		InstigatedAnyDamageSignature__DelegateSignature_DamagedActor_Offset = NativeReflectionCached.GetPropertyOffset(InstigatedAnyDamageSignature__DelegateSignature_FunctionAddress, "DamagedActor");
		InstigatedAnyDamageSignature__DelegateSignature_DamagedActor_IsValid = NativeReflectionCached.ValidatePropertyClass(InstigatedAnyDamageSignature__DelegateSignature_FunctionAddress, "DamagedActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref InstigatedAnyDamageSignature__DelegateSignature_DamageCauser_PropertyAddress, InstigatedAnyDamageSignature__DelegateSignature_FunctionAddress, "DamageCauser");
		InstigatedAnyDamageSignature__DelegateSignature_DamageCauser_Offset = NativeReflectionCached.GetPropertyOffset(InstigatedAnyDamageSignature__DelegateSignature_FunctionAddress, "DamageCauser");
		InstigatedAnyDamageSignature__DelegateSignature_DamageCauser_IsValid = NativeReflectionCached.ValidatePropertyClass(InstigatedAnyDamageSignature__DelegateSignature_FunctionAddress, "DamageCauser", Classes.FObjectProperty);
		InstigatedAnyDamageSignature__DelegateSignature_IsValid = InstigatedAnyDamageSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && InstigatedAnyDamageSignature__DelegateSignature_Damage_IsValid && InstigatedAnyDamageSignature__DelegateSignature_DamageType_IsValid && InstigatedAnyDamageSignature__DelegateSignature_DamagedActor_IsValid && InstigatedAnyDamageSignature__DelegateSignature_DamageCauser_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.InstigatedAnyDamageSignature__DelegateSignature", InstigatedAnyDamageSignature__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(float Damage, UDamageType DamageType, AActor DamagedActor, AActor DamageCauser)
	{
		if (!InstigatedAnyDamageSignature__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.InstigatedAnyDamageSignature__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(InstigatedAnyDamageSignature__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InstigatedAnyDamageSignature__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, InstigatedAnyDamageSignature__DelegateSignature_Damage_Offset), 0, InstigatedAnyDamageSignature__DelegateSignature_Damage_PropertyAddress.Address, Damage);
			UObjectMarshaler<UDamageType>.ToNative(IntPtr.Add(intPtr, InstigatedAnyDamageSignature__DelegateSignature_DamageType_Offset), 0, InstigatedAnyDamageSignature__DelegateSignature_DamageType_PropertyAddress.Address, DamageType);
			UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, InstigatedAnyDamageSignature__DelegateSignature_DamagedActor_Offset), 0, InstigatedAnyDamageSignature__DelegateSignature_DamagedActor_PropertyAddress.Address, DamagedActor);
			UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, InstigatedAnyDamageSignature__DelegateSignature_DamageCauser_Offset), 0, InstigatedAnyDamageSignature__DelegateSignature_DamageCauser_PropertyAddress.Address, DamageCauser);
			ProcessDelegate(intPtr);
		}
	}
}
