using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.PlatformEventsComponent", "Engine", UnrealModuleType.Engine)]
public class UPlatformEventsComponent : UActorComponent
{
	[UDelegate]
	[UMetaPath("/Script/Engine.PlatformEventsComponent:PlatformEventDelegate__DelegateSignature")]
	public class FPlatformEventDelegate : FMulticastDelegate<FPlatformEventDelegate.Signature>
	{
		public delegate void Signature();

		private static bool PlatformEventDelegate__DelegateSignature_IsValid;

		private static IntPtr PlatformEventDelegate__DelegateSignature_FunctionAddress;

		private static int PlatformEventDelegate__DelegateSignature_ParamsSize;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FPlatformEventDelegate()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			PlatformEventDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.PlatformEventsComponent:PlatformEventDelegate__DelegateSignature");
			PlatformEventDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(PlatformEventDelegate__DelegateSignature_FunctionAddress);
			PlatformEventDelegate__DelegateSignature_IsValid = PlatformEventDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero;
			NativeReflection.LogFunctionIsValid("/Script/Engine.PlatformEventsComponent:PlatformEventDelegate__DelegateSignature", PlatformEventDelegate__DelegateSignature_IsValid);
		}

		private unsafe void Invoker()
		{
			if (!PlatformEventDelegate__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlatformEventsComponent:PlatformEventDelegate__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(PlatformEventDelegate__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlatformEventDelegate__DelegateSignature_ParamsSize);
				IntPtr parameters = new IntPtr(ptr2);
				ProcessDelegate(parameters);
			}
		}
	}

	private static bool PlatformChangedToLaptopModeDelegate_IsValid;

	private static int PlatformChangedToLaptopModeDelegate_Offset;

	private FPlatformEventDelegate PlatformChangedToLaptopModeDelegate_DelegateCached;

	private static bool PlatformChangedToTabletModeDelegate_IsValid;

	private static int PlatformChangedToTabletModeDelegate_Offset;

	private FPlatformEventDelegate PlatformChangedToTabletModeDelegate_DelegateCached;

	private static bool SupportsConvertibleLaptops_IsValid;

	private static IntPtr SupportsConvertibleLaptops_FunctionAddress;

	private static int SupportsConvertibleLaptops_ParamsSize;

	private static bool SupportsConvertibleLaptops_ReturnValue_IsValid;

	private static FFieldAddress SupportsConvertibleLaptops_ReturnValue_PropertyAddress;

	private static int SupportsConvertibleLaptops_ReturnValue_Offset;

	private static bool IsInTabletMode_IsValid;

	private static IntPtr IsInTabletMode_FunctionAddress;

	private static int IsInTabletMode_ParamsSize;

	private static bool IsInTabletMode_ReturnValue_IsValid;

	private static FFieldAddress IsInTabletMode_ReturnValue_PropertyAddress;

	private static int IsInTabletMode_ReturnValue_Offset;

	private static bool IsInLaptopMode_IsValid;

	private static IntPtr IsInLaptopMode_FunctionAddress;

	private static int IsInLaptopMode_ParamsSize;

	private static bool IsInLaptopMode_ReturnValue_IsValid;

	private static FFieldAddress IsInLaptopMode_ReturnValue_PropertyAddress;

	private static int IsInLaptopMode_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.PlatformEventsComponent:PlatformChangedToLaptopModeDelegate")]
	public FPlatformEventDelegate PlatformChangedToLaptopModeDelegate
	{
		get
		{
			CheckDestroyed();
			if (!PlatformChangedToLaptopModeDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlatformEventsComponent:PlatformChangedToLaptopModeDelegate");
				return new FPlatformEventDelegate();
			}
			if (PlatformChangedToLaptopModeDelegate_DelegateCached == null)
			{
				PlatformChangedToLaptopModeDelegate_DelegateCached = new FPlatformEventDelegate();
				PlatformChangedToLaptopModeDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, PlatformChangedToLaptopModeDelegate_Offset));
			}
			return PlatformChangedToLaptopModeDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.PlatformEventsComponent:PlatformChangedToTabletModeDelegate")]
	public FPlatformEventDelegate PlatformChangedToTabletModeDelegate
	{
		get
		{
			CheckDestroyed();
			if (!PlatformChangedToTabletModeDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlatformEventsComponent:PlatformChangedToTabletModeDelegate");
				return new FPlatformEventDelegate();
			}
			if (PlatformChangedToTabletModeDelegate_DelegateCached == null)
			{
				PlatformChangedToTabletModeDelegate_DelegateCached = new FPlatformEventDelegate();
				PlatformChangedToTabletModeDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, PlatformChangedToTabletModeDelegate_Offset));
			}
			return PlatformChangedToTabletModeDelegate_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PlatformEventsComponent:SupportsConvertibleLaptops")]
	public unsafe bool SupportsConvertibleLaptops()
	{
		CheckDestroyed();
		if (!SupportsConvertibleLaptops_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlatformEventsComponent:SupportsConvertibleLaptops");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SupportsConvertibleLaptops_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SupportsConvertibleLaptops_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, SupportsConvertibleLaptops_FunctionAddress, intPtr, SupportsConvertibleLaptops_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SupportsConvertibleLaptops_ReturnValue_Offset), 0, SupportsConvertibleLaptops_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PlatformEventsComponent:IsInTabletMode")]
	public unsafe bool IsInTabletMode()
	{
		CheckDestroyed();
		if (!IsInTabletMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlatformEventsComponent:IsInTabletMode");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsInTabletMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsInTabletMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsInTabletMode_FunctionAddress, intPtr, IsInTabletMode_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsInTabletMode_ReturnValue_Offset), 0, IsInTabletMode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.PlatformEventsComponent:IsInLaptopMode")]
	public unsafe bool IsInLaptopMode()
	{
		CheckDestroyed();
		if (!IsInLaptopMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlatformEventsComponent:IsInLaptopMode");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsInLaptopMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsInLaptopMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsInLaptopMode_FunctionAddress, intPtr, IsInLaptopMode_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsInLaptopMode_ReturnValue_Offset), 0, IsInLaptopMode_ReturnValue_PropertyAddress.Address);
	}

	static UPlatformEventsComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPlatformEventsComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPlatformEventsComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.PlatformEventsComponent");
		PlatformChangedToLaptopModeDelegate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlatformChangedToLaptopModeDelegate");
		PlatformChangedToLaptopModeDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlatformChangedToLaptopModeDelegate", Classes.FMulticastDelegateProperty);
		PlatformChangedToTabletModeDelegate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlatformChangedToTabletModeDelegate");
		PlatformChangedToTabletModeDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlatformChangedToTabletModeDelegate", Classes.FMulticastDelegateProperty);
		SupportsConvertibleLaptops_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SupportsConvertibleLaptops");
		SupportsConvertibleLaptops_ParamsSize = NativeReflection.GetFunctionParamsSize(SupportsConvertibleLaptops_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SupportsConvertibleLaptops_ReturnValue_PropertyAddress, SupportsConvertibleLaptops_FunctionAddress, "ReturnValue");
		SupportsConvertibleLaptops_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SupportsConvertibleLaptops_FunctionAddress, "ReturnValue");
		SupportsConvertibleLaptops_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SupportsConvertibleLaptops_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SupportsConvertibleLaptops_IsValid = SupportsConvertibleLaptops_FunctionAddress != IntPtr.Zero && SupportsConvertibleLaptops_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlatformEventsComponent:SupportsConvertibleLaptops", SupportsConvertibleLaptops_IsValid);
		IsInTabletMode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsInTabletMode");
		IsInTabletMode_ParamsSize = NativeReflection.GetFunctionParamsSize(IsInTabletMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsInTabletMode_ReturnValue_PropertyAddress, IsInTabletMode_FunctionAddress, "ReturnValue");
		IsInTabletMode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsInTabletMode_FunctionAddress, "ReturnValue");
		IsInTabletMode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsInTabletMode_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsInTabletMode_IsValid = IsInTabletMode_FunctionAddress != IntPtr.Zero && IsInTabletMode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlatformEventsComponent:IsInTabletMode", IsInTabletMode_IsValid);
		IsInLaptopMode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsInLaptopMode");
		IsInLaptopMode_ParamsSize = NativeReflection.GetFunctionParamsSize(IsInLaptopMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsInLaptopMode_ReturnValue_PropertyAddress, IsInLaptopMode_FunctionAddress, "ReturnValue");
		IsInLaptopMode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsInLaptopMode_FunctionAddress, "ReturnValue");
		IsInLaptopMode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsInLaptopMode_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsInLaptopMode_IsValid = IsInLaptopMode_FunctionAddress != IntPtr.Zero && IsInLaptopMode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.PlatformEventsComponent:IsInLaptopMode", IsInLaptopMode_IsValid);
	}
}
