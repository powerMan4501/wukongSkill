using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemUtils;

[UDelegate]
[UMetaPath("/Script/OnlineSubsystemUtils.AchievementWriteDelegate__DelegateSignature")]
public class FAchievementWriteDelegate : FMulticastDelegate<FAchievementWriteDelegate.Signature>
{
	public delegate void Signature(FName WrittenAchievementName, float WrittenProgress, int WrittenUserTag);

	private static bool AchievementWriteDelegate__DelegateSignature_IsValid;

	private static IntPtr AchievementWriteDelegate__DelegateSignature_FunctionAddress;

	private static int AchievementWriteDelegate__DelegateSignature_ParamsSize;

	private static bool AchievementWriteDelegate__DelegateSignature_WrittenAchievementName_IsValid;

	private static FFieldAddress AchievementWriteDelegate__DelegateSignature_WrittenAchievementName_PropertyAddress;

	private static int AchievementWriteDelegate__DelegateSignature_WrittenAchievementName_Offset;

	private static bool AchievementWriteDelegate__DelegateSignature_WrittenProgress_IsValid;

	private static FFieldAddress AchievementWriteDelegate__DelegateSignature_WrittenProgress_PropertyAddress;

	private static int AchievementWriteDelegate__DelegateSignature_WrittenProgress_Offset;

	private static bool AchievementWriteDelegate__DelegateSignature_WrittenUserTag_IsValid;

	private static FFieldAddress AchievementWriteDelegate__DelegateSignature_WrittenUserTag_PropertyAddress;

	private static int AchievementWriteDelegate__DelegateSignature_WrittenUserTag_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FAchievementWriteDelegate()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		AchievementWriteDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/OnlineSubsystemUtils.AchievementWriteDelegate__DelegateSignature");
		AchievementWriteDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(AchievementWriteDelegate__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AchievementWriteDelegate__DelegateSignature_WrittenAchievementName_PropertyAddress, AchievementWriteDelegate__DelegateSignature_FunctionAddress, "WrittenAchievementName");
		AchievementWriteDelegate__DelegateSignature_WrittenAchievementName_Offset = NativeReflectionCached.GetPropertyOffset(AchievementWriteDelegate__DelegateSignature_FunctionAddress, "WrittenAchievementName");
		AchievementWriteDelegate__DelegateSignature_WrittenAchievementName_IsValid = NativeReflectionCached.ValidatePropertyClass(AchievementWriteDelegate__DelegateSignature_FunctionAddress, "WrittenAchievementName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AchievementWriteDelegate__DelegateSignature_WrittenProgress_PropertyAddress, AchievementWriteDelegate__DelegateSignature_FunctionAddress, "WrittenProgress");
		AchievementWriteDelegate__DelegateSignature_WrittenProgress_Offset = NativeReflectionCached.GetPropertyOffset(AchievementWriteDelegate__DelegateSignature_FunctionAddress, "WrittenProgress");
		AchievementWriteDelegate__DelegateSignature_WrittenProgress_IsValid = NativeReflectionCached.ValidatePropertyClass(AchievementWriteDelegate__DelegateSignature_FunctionAddress, "WrittenProgress", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AchievementWriteDelegate__DelegateSignature_WrittenUserTag_PropertyAddress, AchievementWriteDelegate__DelegateSignature_FunctionAddress, "WrittenUserTag");
		AchievementWriteDelegate__DelegateSignature_WrittenUserTag_Offset = NativeReflectionCached.GetPropertyOffset(AchievementWriteDelegate__DelegateSignature_FunctionAddress, "WrittenUserTag");
		AchievementWriteDelegate__DelegateSignature_WrittenUserTag_IsValid = NativeReflectionCached.ValidatePropertyClass(AchievementWriteDelegate__DelegateSignature_FunctionAddress, "WrittenUserTag", Classes.FIntProperty);
		AchievementWriteDelegate__DelegateSignature_IsValid = AchievementWriteDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && AchievementWriteDelegate__DelegateSignature_WrittenAchievementName_IsValid && AchievementWriteDelegate__DelegateSignature_WrittenProgress_IsValid && AchievementWriteDelegate__DelegateSignature_WrittenUserTag_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OnlineSubsystemUtils.AchievementWriteDelegate__DelegateSignature", AchievementWriteDelegate__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FName WrittenAchievementName, float WrittenProgress, int WrittenUserTag)
	{
		if (!AchievementWriteDelegate__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OnlineSubsystemUtils.AchievementWriteDelegate__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(AchievementWriteDelegate__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AchievementWriteDelegate__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AchievementWriteDelegate__DelegateSignature_WrittenAchievementName_Offset), 0, AchievementWriteDelegate__DelegateSignature_WrittenAchievementName_PropertyAddress.Address, WrittenAchievementName);
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AchievementWriteDelegate__DelegateSignature_WrittenProgress_Offset), 0, AchievementWriteDelegate__DelegateSignature_WrittenProgress_PropertyAddress.Address, WrittenProgress);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AchievementWriteDelegate__DelegateSignature_WrittenUserTag_Offset), 0, AchievementWriteDelegate__DelegateSignature_WrittenUserTag_PropertyAddress.Address, WrittenUserTag);
			ProcessDelegate(intPtr);
		}
	}
}
