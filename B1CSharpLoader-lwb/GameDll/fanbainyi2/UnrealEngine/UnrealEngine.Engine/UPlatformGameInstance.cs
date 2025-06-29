using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938024uL, Config = "Game")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.PlatformGameInstance", "Engine", UnrealModuleType.Engine)]
public class UPlatformGameInstance : UGameInstance
{
	[UDelegate]
	[UMetaPath("/Script/Engine.PlatformGameInstance:PlatformStartupArgumentsDelegate__DelegateSignature")]
	public class FPlatformStartupArgumentsDelegate : FMulticastDelegate<FPlatformStartupArgumentsDelegate.Signature>
	{
		public delegate void Signature(List<string> StartupArguments);

		private static bool PlatformStartupArgumentsDelegate__DelegateSignature_IsValid;

		private static IntPtr PlatformStartupArgumentsDelegate__DelegateSignature_FunctionAddress;

		private static int PlatformStartupArgumentsDelegate__DelegateSignature_ParamsSize;

		private static bool PlatformStartupArgumentsDelegate__DelegateSignature_StartupArguments_IsValid;

		private static FFieldAddress PlatformStartupArgumentsDelegate__DelegateSignature_StartupArguments_PropertyAddress;

		private static int PlatformStartupArgumentsDelegate__DelegateSignature_StartupArguments_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FPlatformStartupArgumentsDelegate()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			PlatformStartupArgumentsDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.PlatformGameInstance:PlatformStartupArgumentsDelegate__DelegateSignature");
			PlatformStartupArgumentsDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(PlatformStartupArgumentsDelegate__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref PlatformStartupArgumentsDelegate__DelegateSignature_StartupArguments_PropertyAddress, PlatformStartupArgumentsDelegate__DelegateSignature_FunctionAddress, "StartupArguments");
			PlatformStartupArgumentsDelegate__DelegateSignature_StartupArguments_Offset = NativeReflectionCached.GetPropertyOffset(PlatformStartupArgumentsDelegate__DelegateSignature_FunctionAddress, "StartupArguments");
			PlatformStartupArgumentsDelegate__DelegateSignature_StartupArguments_IsValid = NativeReflectionCached.ValidatePropertyClass(PlatformStartupArgumentsDelegate__DelegateSignature_FunctionAddress, "StartupArguments", Classes.FArrayProperty);
			PlatformStartupArgumentsDelegate__DelegateSignature_IsValid = PlatformStartupArgumentsDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && PlatformStartupArgumentsDelegate__DelegateSignature_StartupArguments_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/Engine.PlatformGameInstance:PlatformStartupArgumentsDelegate__DelegateSignature", PlatformStartupArgumentsDelegate__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(List<string> StartupArguments)
		{
			if (!PlatformStartupArgumentsDelegate__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlatformGameInstance:PlatformStartupArgumentsDelegate__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(PlatformStartupArgumentsDelegate__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlatformStartupArgumentsDelegate__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				new TArrayCopyMarshaler<string>(1, PlatformStartupArgumentsDelegate__DelegateSignature_StartupArguments_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, PlatformStartupArgumentsDelegate__DelegateSignature_StartupArguments_Offset), StartupArguments);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(PlatformStartupArgumentsDelegate__DelegateSignature_StartupArguments_PropertyAddress.Address, intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/Engine.PlatformGameInstance:PlatformScreenOrientationChangedDelegate__DelegateSignature")]
	public class FPlatformScreenOrientationChangedDelegate : FMulticastDelegate<FPlatformScreenOrientationChangedDelegate.Signature>
	{
		public delegate void Signature(EScreenOrientation inScreenOrientation);

		private static bool PlatformScreenOrientationChangedDelegate__DelegateSignature_IsValid;

		private static IntPtr PlatformScreenOrientationChangedDelegate__DelegateSignature_FunctionAddress;

		private static int PlatformScreenOrientationChangedDelegate__DelegateSignature_ParamsSize;

		private static bool PlatformScreenOrientationChangedDelegate__DelegateSignature_inScreenOrientation_IsValid;

		private static FFieldAddress PlatformScreenOrientationChangedDelegate__DelegateSignature_inScreenOrientation_PropertyAddress;

		private static int PlatformScreenOrientationChangedDelegate__DelegateSignature_inScreenOrientation_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FPlatformScreenOrientationChangedDelegate()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			PlatformScreenOrientationChangedDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.PlatformGameInstance:PlatformScreenOrientationChangedDelegate__DelegateSignature");
			PlatformScreenOrientationChangedDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(PlatformScreenOrientationChangedDelegate__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref PlatformScreenOrientationChangedDelegate__DelegateSignature_inScreenOrientation_PropertyAddress, PlatformScreenOrientationChangedDelegate__DelegateSignature_FunctionAddress, "inScreenOrientation");
			PlatformScreenOrientationChangedDelegate__DelegateSignature_inScreenOrientation_Offset = NativeReflectionCached.GetPropertyOffset(PlatformScreenOrientationChangedDelegate__DelegateSignature_FunctionAddress, "inScreenOrientation");
			PlatformScreenOrientationChangedDelegate__DelegateSignature_inScreenOrientation_IsValid = NativeReflectionCached.ValidatePropertyClass(PlatformScreenOrientationChangedDelegate__DelegateSignature_FunctionAddress, "inScreenOrientation", Classes.FByteProperty);
			PlatformScreenOrientationChangedDelegate__DelegateSignature_IsValid = PlatformScreenOrientationChangedDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && PlatformScreenOrientationChangedDelegate__DelegateSignature_inScreenOrientation_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/Engine.PlatformGameInstance:PlatformScreenOrientationChangedDelegate__DelegateSignature", PlatformScreenOrientationChangedDelegate__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(EScreenOrientation inScreenOrientation)
		{
			if (!PlatformScreenOrientationChangedDelegate__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlatformGameInstance:PlatformScreenOrientationChangedDelegate__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(PlatformScreenOrientationChangedDelegate__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlatformScreenOrientationChangedDelegate__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				EnumMarshaler<EScreenOrientation>.ToNative(IntPtr.Add(intPtr, PlatformScreenOrientationChangedDelegate__DelegateSignature_inScreenOrientation_Offset), 0, PlatformScreenOrientationChangedDelegate__DelegateSignature_inScreenOrientation_PropertyAddress.Address, inScreenOrientation);
				ProcessDelegate(intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/Engine.PlatformGameInstance:PlatformRegisteredForUserNotificationsDelegate__DelegateSignature")]
	public class FPlatformRegisteredForUserNotificationsDelegate : FMulticastDelegate<FPlatformRegisteredForUserNotificationsDelegate.Signature>
	{
		public delegate void Signature(int inInt);

		private static bool PlatformRegisteredForUserNotificationsDelegate__DelegateSignature_IsValid;

		private static IntPtr PlatformRegisteredForUserNotificationsDelegate__DelegateSignature_FunctionAddress;

		private static int PlatformRegisteredForUserNotificationsDelegate__DelegateSignature_ParamsSize;

		private static bool PlatformRegisteredForUserNotificationsDelegate__DelegateSignature_inInt_IsValid;

		private static FFieldAddress PlatformRegisteredForUserNotificationsDelegate__DelegateSignature_inInt_PropertyAddress;

		private static int PlatformRegisteredForUserNotificationsDelegate__DelegateSignature_inInt_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FPlatformRegisteredForUserNotificationsDelegate()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			PlatformRegisteredForUserNotificationsDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.PlatformGameInstance:PlatformRegisteredForUserNotificationsDelegate__DelegateSignature");
			PlatformRegisteredForUserNotificationsDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(PlatformRegisteredForUserNotificationsDelegate__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref PlatformRegisteredForUserNotificationsDelegate__DelegateSignature_inInt_PropertyAddress, PlatformRegisteredForUserNotificationsDelegate__DelegateSignature_FunctionAddress, "inInt");
			PlatformRegisteredForUserNotificationsDelegate__DelegateSignature_inInt_Offset = NativeReflectionCached.GetPropertyOffset(PlatformRegisteredForUserNotificationsDelegate__DelegateSignature_FunctionAddress, "inInt");
			PlatformRegisteredForUserNotificationsDelegate__DelegateSignature_inInt_IsValid = NativeReflectionCached.ValidatePropertyClass(PlatformRegisteredForUserNotificationsDelegate__DelegateSignature_FunctionAddress, "inInt", Classes.FIntProperty);
			PlatformRegisteredForUserNotificationsDelegate__DelegateSignature_IsValid = PlatformRegisteredForUserNotificationsDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && PlatformRegisteredForUserNotificationsDelegate__DelegateSignature_inInt_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/Engine.PlatformGameInstance:PlatformRegisteredForUserNotificationsDelegate__DelegateSignature", PlatformRegisteredForUserNotificationsDelegate__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(int inInt)
		{
			if (!PlatformRegisteredForUserNotificationsDelegate__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlatformGameInstance:PlatformRegisteredForUserNotificationsDelegate__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(PlatformRegisteredForUserNotificationsDelegate__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlatformRegisteredForUserNotificationsDelegate__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, PlatformRegisteredForUserNotificationsDelegate__DelegateSignature_inInt_Offset), 0, PlatformRegisteredForUserNotificationsDelegate__DelegateSignature_inInt_PropertyAddress.Address, inInt);
				ProcessDelegate(intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/Engine.PlatformGameInstance:PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature")]
	public class FPlatformRegisteredForRemoteNotificationsDelegate : FMulticastDelegate<FPlatformRegisteredForRemoteNotificationsDelegate.Signature>
	{
		public delegate void Signature(List<byte> inArray);

		private static bool PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature_IsValid;

		private static IntPtr PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature_FunctionAddress;

		private static int PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature_ParamsSize;

		private static bool PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature_inArray_IsValid;

		private static FFieldAddress PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature_inArray_PropertyAddress;

		private static int PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature_inArray_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FPlatformRegisteredForRemoteNotificationsDelegate()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.PlatformGameInstance:PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature");
			PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature_inArray_PropertyAddress, PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature_FunctionAddress, "inArray");
			PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature_inArray_Offset = NativeReflectionCached.GetPropertyOffset(PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature_FunctionAddress, "inArray");
			PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature_inArray_IsValid = NativeReflectionCached.ValidatePropertyClass(PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature_FunctionAddress, "inArray", Classes.FArrayProperty);
			PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature_IsValid = PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature_inArray_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/Engine.PlatformGameInstance:PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature", PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(List<byte> inArray)
		{
			if (!PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlatformGameInstance:PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				new TArrayCopyMarshaler<byte>(1, PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature_inArray_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).ToNative(IntPtr.Add(intPtr, PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature_inArray_Offset), inArray);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(PlatformRegisteredForRemoteNotificationsDelegate__DelegateSignature_inArray_PropertyAddress.Address, intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/Engine.PlatformGameInstance:PlatformReceivedRemoteNotificationDelegate__DelegateSignature")]
	public class FPlatformReceivedRemoteNotificationDelegate : FMulticastDelegate<FPlatformReceivedRemoteNotificationDelegate.Signature>
	{
		public delegate void Signature(string inString, EApplicationState inAppState);

		private static bool PlatformReceivedRemoteNotificationDelegate__DelegateSignature_IsValid;

		private static IntPtr PlatformReceivedRemoteNotificationDelegate__DelegateSignature_FunctionAddress;

		private static int PlatformReceivedRemoteNotificationDelegate__DelegateSignature_ParamsSize;

		private static bool PlatformReceivedRemoteNotificationDelegate__DelegateSignature_inString_IsValid;

		private static FFieldAddress PlatformReceivedRemoteNotificationDelegate__DelegateSignature_inString_PropertyAddress;

		private static int PlatformReceivedRemoteNotificationDelegate__DelegateSignature_inString_Offset;

		private static bool PlatformReceivedRemoteNotificationDelegate__DelegateSignature_inAppState_IsValid;

		private static FFieldAddress PlatformReceivedRemoteNotificationDelegate__DelegateSignature_inAppState_PropertyAddress;

		private static int PlatformReceivedRemoteNotificationDelegate__DelegateSignature_inAppState_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FPlatformReceivedRemoteNotificationDelegate()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			PlatformReceivedRemoteNotificationDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.PlatformGameInstance:PlatformReceivedRemoteNotificationDelegate__DelegateSignature");
			PlatformReceivedRemoteNotificationDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(PlatformReceivedRemoteNotificationDelegate__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref PlatformReceivedRemoteNotificationDelegate__DelegateSignature_inString_PropertyAddress, PlatformReceivedRemoteNotificationDelegate__DelegateSignature_FunctionAddress, "inString");
			PlatformReceivedRemoteNotificationDelegate__DelegateSignature_inString_Offset = NativeReflectionCached.GetPropertyOffset(PlatformReceivedRemoteNotificationDelegate__DelegateSignature_FunctionAddress, "inString");
			PlatformReceivedRemoteNotificationDelegate__DelegateSignature_inString_IsValid = NativeReflectionCached.ValidatePropertyClass(PlatformReceivedRemoteNotificationDelegate__DelegateSignature_FunctionAddress, "inString", Classes.FStrProperty);
			NativeReflectionCached.GetPropertyRef(ref PlatformReceivedRemoteNotificationDelegate__DelegateSignature_inAppState_PropertyAddress, PlatformReceivedRemoteNotificationDelegate__DelegateSignature_FunctionAddress, "inAppState");
			PlatformReceivedRemoteNotificationDelegate__DelegateSignature_inAppState_Offset = NativeReflectionCached.GetPropertyOffset(PlatformReceivedRemoteNotificationDelegate__DelegateSignature_FunctionAddress, "inAppState");
			PlatformReceivedRemoteNotificationDelegate__DelegateSignature_inAppState_IsValid = NativeReflectionCached.ValidatePropertyClass(PlatformReceivedRemoteNotificationDelegate__DelegateSignature_FunctionAddress, "inAppState", Classes.FByteProperty);
			PlatformReceivedRemoteNotificationDelegate__DelegateSignature_IsValid = PlatformReceivedRemoteNotificationDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && PlatformReceivedRemoteNotificationDelegate__DelegateSignature_inString_IsValid && PlatformReceivedRemoteNotificationDelegate__DelegateSignature_inAppState_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/Engine.PlatformGameInstance:PlatformReceivedRemoteNotificationDelegate__DelegateSignature", PlatformReceivedRemoteNotificationDelegate__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(string inString, EApplicationState inAppState)
		{
			if (!PlatformReceivedRemoteNotificationDelegate__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlatformGameInstance:PlatformReceivedRemoteNotificationDelegate__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(PlatformReceivedRemoteNotificationDelegate__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlatformReceivedRemoteNotificationDelegate__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				FStringMarshaler.ToNative(IntPtr.Add(intPtr, PlatformReceivedRemoteNotificationDelegate__DelegateSignature_inString_Offset), 0, PlatformReceivedRemoteNotificationDelegate__DelegateSignature_inString_PropertyAddress.Address, inString);
				EnumMarshaler<EApplicationState>.ToNative(IntPtr.Add(intPtr, PlatformReceivedRemoteNotificationDelegate__DelegateSignature_inAppState_Offset), 0, PlatformReceivedRemoteNotificationDelegate__DelegateSignature_inAppState_PropertyAddress.Address, inAppState);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(PlatformReceivedRemoteNotificationDelegate__DelegateSignature_inString_PropertyAddress.Address, intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/Engine.PlatformGameInstance:PlatformReceivedLocalNotificationDelegate__DelegateSignature")]
	public class FPlatformReceivedLocalNotificationDelegate : FMulticastDelegate<FPlatformReceivedLocalNotificationDelegate.Signature>
	{
		public delegate void Signature(string inString, int inInt, EApplicationState inAppState);

		private static bool PlatformReceivedLocalNotificationDelegate__DelegateSignature_IsValid;

		private static IntPtr PlatformReceivedLocalNotificationDelegate__DelegateSignature_FunctionAddress;

		private static int PlatformReceivedLocalNotificationDelegate__DelegateSignature_ParamsSize;

		private static bool PlatformReceivedLocalNotificationDelegate__DelegateSignature_inString_IsValid;

		private static FFieldAddress PlatformReceivedLocalNotificationDelegate__DelegateSignature_inString_PropertyAddress;

		private static int PlatformReceivedLocalNotificationDelegate__DelegateSignature_inString_Offset;

		private static bool PlatformReceivedLocalNotificationDelegate__DelegateSignature_inInt_IsValid;

		private static FFieldAddress PlatformReceivedLocalNotificationDelegate__DelegateSignature_inInt_PropertyAddress;

		private static int PlatformReceivedLocalNotificationDelegate__DelegateSignature_inInt_Offset;

		private static bool PlatformReceivedLocalNotificationDelegate__DelegateSignature_inAppState_IsValid;

		private static FFieldAddress PlatformReceivedLocalNotificationDelegate__DelegateSignature_inAppState_PropertyAddress;

		private static int PlatformReceivedLocalNotificationDelegate__DelegateSignature_inAppState_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FPlatformReceivedLocalNotificationDelegate()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			PlatformReceivedLocalNotificationDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.PlatformGameInstance:PlatformReceivedLocalNotificationDelegate__DelegateSignature");
			PlatformReceivedLocalNotificationDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(PlatformReceivedLocalNotificationDelegate__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref PlatformReceivedLocalNotificationDelegate__DelegateSignature_inString_PropertyAddress, PlatformReceivedLocalNotificationDelegate__DelegateSignature_FunctionAddress, "inString");
			PlatformReceivedLocalNotificationDelegate__DelegateSignature_inString_Offset = NativeReflectionCached.GetPropertyOffset(PlatformReceivedLocalNotificationDelegate__DelegateSignature_FunctionAddress, "inString");
			PlatformReceivedLocalNotificationDelegate__DelegateSignature_inString_IsValid = NativeReflectionCached.ValidatePropertyClass(PlatformReceivedLocalNotificationDelegate__DelegateSignature_FunctionAddress, "inString", Classes.FStrProperty);
			NativeReflectionCached.GetPropertyRef(ref PlatformReceivedLocalNotificationDelegate__DelegateSignature_inInt_PropertyAddress, PlatformReceivedLocalNotificationDelegate__DelegateSignature_FunctionAddress, "inInt");
			PlatformReceivedLocalNotificationDelegate__DelegateSignature_inInt_Offset = NativeReflectionCached.GetPropertyOffset(PlatformReceivedLocalNotificationDelegate__DelegateSignature_FunctionAddress, "inInt");
			PlatformReceivedLocalNotificationDelegate__DelegateSignature_inInt_IsValid = NativeReflectionCached.ValidatePropertyClass(PlatformReceivedLocalNotificationDelegate__DelegateSignature_FunctionAddress, "inInt", Classes.FIntProperty);
			NativeReflectionCached.GetPropertyRef(ref PlatformReceivedLocalNotificationDelegate__DelegateSignature_inAppState_PropertyAddress, PlatformReceivedLocalNotificationDelegate__DelegateSignature_FunctionAddress, "inAppState");
			PlatformReceivedLocalNotificationDelegate__DelegateSignature_inAppState_Offset = NativeReflectionCached.GetPropertyOffset(PlatformReceivedLocalNotificationDelegate__DelegateSignature_FunctionAddress, "inAppState");
			PlatformReceivedLocalNotificationDelegate__DelegateSignature_inAppState_IsValid = NativeReflectionCached.ValidatePropertyClass(PlatformReceivedLocalNotificationDelegate__DelegateSignature_FunctionAddress, "inAppState", Classes.FByteProperty);
			PlatformReceivedLocalNotificationDelegate__DelegateSignature_IsValid = PlatformReceivedLocalNotificationDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && PlatformReceivedLocalNotificationDelegate__DelegateSignature_inString_IsValid && PlatformReceivedLocalNotificationDelegate__DelegateSignature_inInt_IsValid && PlatformReceivedLocalNotificationDelegate__DelegateSignature_inAppState_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/Engine.PlatformGameInstance:PlatformReceivedLocalNotificationDelegate__DelegateSignature", PlatformReceivedLocalNotificationDelegate__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(string inString, int inInt, EApplicationState inAppState)
		{
			if (!PlatformReceivedLocalNotificationDelegate__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlatformGameInstance:PlatformReceivedLocalNotificationDelegate__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(PlatformReceivedLocalNotificationDelegate__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlatformReceivedLocalNotificationDelegate__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				FStringMarshaler.ToNative(IntPtr.Add(intPtr, PlatformReceivedLocalNotificationDelegate__DelegateSignature_inString_Offset), 0, PlatformReceivedLocalNotificationDelegate__DelegateSignature_inString_PropertyAddress.Address, inString);
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, PlatformReceivedLocalNotificationDelegate__DelegateSignature_inInt_Offset), 0, PlatformReceivedLocalNotificationDelegate__DelegateSignature_inInt_PropertyAddress.Address, inInt);
				EnumMarshaler<EApplicationState>.ToNative(IntPtr.Add(intPtr, PlatformReceivedLocalNotificationDelegate__DelegateSignature_inAppState_Offset), 0, PlatformReceivedLocalNotificationDelegate__DelegateSignature_inAppState_PropertyAddress.Address, inAppState);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(PlatformReceivedLocalNotificationDelegate__DelegateSignature_inString_PropertyAddress.Address, intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/Engine.PlatformGameInstance:PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature")]
	public class FPlatformFailedToRegisterForRemoteNotificationsDelegate : FMulticastDelegate<FPlatformFailedToRegisterForRemoteNotificationsDelegate.Signature>
	{
		public delegate void Signature(string inString);

		private static bool PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature_IsValid;

		private static IntPtr PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature_FunctionAddress;

		private static int PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature_ParamsSize;

		private static bool PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature_inString_IsValid;

		private static FFieldAddress PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature_inString_PropertyAddress;

		private static int PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature_inString_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FPlatformFailedToRegisterForRemoteNotificationsDelegate()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.PlatformGameInstance:PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature");
			PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature_inString_PropertyAddress, PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature_FunctionAddress, "inString");
			PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature_inString_Offset = NativeReflectionCached.GetPropertyOffset(PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature_FunctionAddress, "inString");
			PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature_inString_IsValid = NativeReflectionCached.ValidatePropertyClass(PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature_FunctionAddress, "inString", Classes.FStrProperty);
			PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature_IsValid = PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature_inString_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/Engine.PlatformGameInstance:PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature", PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(string inString)
		{
			if (!PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlatformGameInstance:PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				FStringMarshaler.ToNative(IntPtr.Add(intPtr, PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature_inString_Offset), 0, PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature_inString_PropertyAddress.Address, inString);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(PlatformFailedToRegisterForRemoteNotificationsDelegate__DelegateSignature_inString_PropertyAddress.Address, intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/Engine.PlatformGameInstance:PlatformDelegate__DelegateSignature")]
	public class FPlatformDelegate : FMulticastDelegate<FPlatformDelegate.Signature>
	{
		public delegate void Signature();

		private static bool PlatformDelegate__DelegateSignature_IsValid;

		private static IntPtr PlatformDelegate__DelegateSignature_FunctionAddress;

		private static int PlatformDelegate__DelegateSignature_ParamsSize;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FPlatformDelegate()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			PlatformDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.PlatformGameInstance:PlatformDelegate__DelegateSignature");
			PlatformDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(PlatformDelegate__DelegateSignature_FunctionAddress);
			PlatformDelegate__DelegateSignature_IsValid = PlatformDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero;
			NativeReflection.LogFunctionIsValid("/Script/Engine.PlatformGameInstance:PlatformDelegate__DelegateSignature", PlatformDelegate__DelegateSignature_IsValid);
		}

		private unsafe void Invoker()
		{
			if (!PlatformDelegate__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.PlatformGameInstance:PlatformDelegate__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(PlatformDelegate__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlatformDelegate__DelegateSignature_ParamsSize);
				IntPtr parameters = new IntPtr(ptr2);
				ProcessDelegate(parameters);
			}
		}
	}

	private static bool ApplicationWillDeactivateDelegate_IsValid;

	private static int ApplicationWillDeactivateDelegate_Offset;

	private FPlatformDelegate ApplicationWillDeactivateDelegate_DelegateCached;

	private static bool ApplicationHasReactivatedDelegate_IsValid;

	private static int ApplicationHasReactivatedDelegate_Offset;

	private FPlatformDelegate ApplicationHasReactivatedDelegate_DelegateCached;

	private static bool ApplicationWillEnterBackgroundDelegate_IsValid;

	private static int ApplicationWillEnterBackgroundDelegate_Offset;

	private FPlatformDelegate ApplicationWillEnterBackgroundDelegate_DelegateCached;

	private static bool ApplicationHasEnteredForegroundDelegate_IsValid;

	private static int ApplicationHasEnteredForegroundDelegate_Offset;

	private FPlatformDelegate ApplicationHasEnteredForegroundDelegate_DelegateCached;

	private static bool ApplicationWillTerminateDelegate_IsValid;

	private static int ApplicationWillTerminateDelegate_Offset;

	private FPlatformDelegate ApplicationWillTerminateDelegate_DelegateCached;

	private static bool ApplicationShouldUnloadResourcesDelegate_IsValid;

	private static int ApplicationShouldUnloadResourcesDelegate_Offset;

	private FPlatformDelegate ApplicationShouldUnloadResourcesDelegate_DelegateCached;

	private static bool ApplicationReceivedStartupArgumentsDelegate_IsValid;

	private static int ApplicationReceivedStartupArgumentsDelegate_Offset;

	private FPlatformStartupArgumentsDelegate ApplicationReceivedStartupArgumentsDelegate_DelegateCached;

	private static bool ApplicationRegisteredForRemoteNotificationsDelegate_IsValid;

	private static int ApplicationRegisteredForRemoteNotificationsDelegate_Offset;

	private FPlatformRegisteredForRemoteNotificationsDelegate ApplicationRegisteredForRemoteNotificationsDelegate_DelegateCached;

	private static bool ApplicationRegisteredForUserNotificationsDelegate_IsValid;

	private static int ApplicationRegisteredForUserNotificationsDelegate_Offset;

	private FPlatformRegisteredForUserNotificationsDelegate ApplicationRegisteredForUserNotificationsDelegate_DelegateCached;

	private static bool ApplicationFailedToRegisterForRemoteNotificationsDelegate_IsValid;

	private static int ApplicationFailedToRegisterForRemoteNotificationsDelegate_Offset;

	private FPlatformFailedToRegisterForRemoteNotificationsDelegate ApplicationFailedToRegisterForRemoteNotificationsDelegate_DelegateCached;

	private static bool ApplicationReceivedRemoteNotificationDelegate_IsValid;

	private static int ApplicationReceivedRemoteNotificationDelegate_Offset;

	private FPlatformReceivedRemoteNotificationDelegate ApplicationReceivedRemoteNotificationDelegate_DelegateCached;

	private static bool ApplicationReceivedLocalNotificationDelegate_IsValid;

	private static int ApplicationReceivedLocalNotificationDelegate_Offset;

	private FPlatformReceivedLocalNotificationDelegate ApplicationReceivedLocalNotificationDelegate_DelegateCached;

	private static bool ApplicationReceivedScreenOrientationChangedNotificationDelegate_IsValid;

	private static int ApplicationReceivedScreenOrientationChangedNotificationDelegate_Offset;

	private FPlatformScreenOrientationChangedDelegate ApplicationReceivedScreenOrientationChangedNotificationDelegate_DelegateCached;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.PlatformGameInstance:ApplicationWillDeactivateDelegate")]
	public FPlatformDelegate ApplicationWillDeactivateDelegate
	{
		get
		{
			CheckDestroyed();
			if (!ApplicationWillDeactivateDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlatformGameInstance:ApplicationWillDeactivateDelegate");
				return new FPlatformDelegate();
			}
			if (ApplicationWillDeactivateDelegate_DelegateCached == null)
			{
				ApplicationWillDeactivateDelegate_DelegateCached = new FPlatformDelegate();
				ApplicationWillDeactivateDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, ApplicationWillDeactivateDelegate_Offset));
			}
			return ApplicationWillDeactivateDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.PlatformGameInstance:ApplicationHasReactivatedDelegate")]
	public FPlatformDelegate ApplicationHasReactivatedDelegate
	{
		get
		{
			CheckDestroyed();
			if (!ApplicationHasReactivatedDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlatformGameInstance:ApplicationHasReactivatedDelegate");
				return new FPlatformDelegate();
			}
			if (ApplicationHasReactivatedDelegate_DelegateCached == null)
			{
				ApplicationHasReactivatedDelegate_DelegateCached = new FPlatformDelegate();
				ApplicationHasReactivatedDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, ApplicationHasReactivatedDelegate_Offset));
			}
			return ApplicationHasReactivatedDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.PlatformGameInstance:ApplicationWillEnterBackgroundDelegate")]
	public FPlatformDelegate ApplicationWillEnterBackgroundDelegate
	{
		get
		{
			CheckDestroyed();
			if (!ApplicationWillEnterBackgroundDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlatformGameInstance:ApplicationWillEnterBackgroundDelegate");
				return new FPlatformDelegate();
			}
			if (ApplicationWillEnterBackgroundDelegate_DelegateCached == null)
			{
				ApplicationWillEnterBackgroundDelegate_DelegateCached = new FPlatformDelegate();
				ApplicationWillEnterBackgroundDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, ApplicationWillEnterBackgroundDelegate_Offset));
			}
			return ApplicationWillEnterBackgroundDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.PlatformGameInstance:ApplicationHasEnteredForegroundDelegate")]
	public FPlatformDelegate ApplicationHasEnteredForegroundDelegate
	{
		get
		{
			CheckDestroyed();
			if (!ApplicationHasEnteredForegroundDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlatformGameInstance:ApplicationHasEnteredForegroundDelegate");
				return new FPlatformDelegate();
			}
			if (ApplicationHasEnteredForegroundDelegate_DelegateCached == null)
			{
				ApplicationHasEnteredForegroundDelegate_DelegateCached = new FPlatformDelegate();
				ApplicationHasEnteredForegroundDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, ApplicationHasEnteredForegroundDelegate_Offset));
			}
			return ApplicationHasEnteredForegroundDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.PlatformGameInstance:ApplicationWillTerminateDelegate")]
	public FPlatformDelegate ApplicationWillTerminateDelegate
	{
		get
		{
			CheckDestroyed();
			if (!ApplicationWillTerminateDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlatformGameInstance:ApplicationWillTerminateDelegate");
				return new FPlatformDelegate();
			}
			if (ApplicationWillTerminateDelegate_DelegateCached == null)
			{
				ApplicationWillTerminateDelegate_DelegateCached = new FPlatformDelegate();
				ApplicationWillTerminateDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, ApplicationWillTerminateDelegate_Offset));
			}
			return ApplicationWillTerminateDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.PlatformGameInstance:ApplicationShouldUnloadResourcesDelegate")]
	public FPlatformDelegate ApplicationShouldUnloadResourcesDelegate
	{
		get
		{
			CheckDestroyed();
			if (!ApplicationShouldUnloadResourcesDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlatformGameInstance:ApplicationShouldUnloadResourcesDelegate");
				return new FPlatformDelegate();
			}
			if (ApplicationShouldUnloadResourcesDelegate_DelegateCached == null)
			{
				ApplicationShouldUnloadResourcesDelegate_DelegateCached = new FPlatformDelegate();
				ApplicationShouldUnloadResourcesDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, ApplicationShouldUnloadResourcesDelegate_Offset));
			}
			return ApplicationShouldUnloadResourcesDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.PlatformGameInstance:ApplicationReceivedStartupArgumentsDelegate")]
	public FPlatformStartupArgumentsDelegate ApplicationReceivedStartupArgumentsDelegate
	{
		get
		{
			CheckDestroyed();
			if (!ApplicationReceivedStartupArgumentsDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlatformGameInstance:ApplicationReceivedStartupArgumentsDelegate");
				return new FPlatformStartupArgumentsDelegate();
			}
			if (ApplicationReceivedStartupArgumentsDelegate_DelegateCached == null)
			{
				ApplicationReceivedStartupArgumentsDelegate_DelegateCached = new FPlatformStartupArgumentsDelegate();
				ApplicationReceivedStartupArgumentsDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, ApplicationReceivedStartupArgumentsDelegate_Offset));
			}
			return ApplicationReceivedStartupArgumentsDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.PlatformGameInstance:ApplicationRegisteredForRemoteNotificationsDelegate")]
	public FPlatformRegisteredForRemoteNotificationsDelegate ApplicationRegisteredForRemoteNotificationsDelegate
	{
		get
		{
			CheckDestroyed();
			if (!ApplicationRegisteredForRemoteNotificationsDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlatformGameInstance:ApplicationRegisteredForRemoteNotificationsDelegate");
				return new FPlatformRegisteredForRemoteNotificationsDelegate();
			}
			if (ApplicationRegisteredForRemoteNotificationsDelegate_DelegateCached == null)
			{
				ApplicationRegisteredForRemoteNotificationsDelegate_DelegateCached = new FPlatformRegisteredForRemoteNotificationsDelegate();
				ApplicationRegisteredForRemoteNotificationsDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, ApplicationRegisteredForRemoteNotificationsDelegate_Offset));
			}
			return ApplicationRegisteredForRemoteNotificationsDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.PlatformGameInstance:ApplicationRegisteredForUserNotificationsDelegate")]
	public FPlatformRegisteredForUserNotificationsDelegate ApplicationRegisteredForUserNotificationsDelegate
	{
		get
		{
			CheckDestroyed();
			if (!ApplicationRegisteredForUserNotificationsDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlatformGameInstance:ApplicationRegisteredForUserNotificationsDelegate");
				return new FPlatformRegisteredForUserNotificationsDelegate();
			}
			if (ApplicationRegisteredForUserNotificationsDelegate_DelegateCached == null)
			{
				ApplicationRegisteredForUserNotificationsDelegate_DelegateCached = new FPlatformRegisteredForUserNotificationsDelegate();
				ApplicationRegisteredForUserNotificationsDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, ApplicationRegisteredForUserNotificationsDelegate_Offset));
			}
			return ApplicationRegisteredForUserNotificationsDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.PlatformGameInstance:ApplicationFailedToRegisterForRemoteNotificationsDelegate")]
	public FPlatformFailedToRegisterForRemoteNotificationsDelegate ApplicationFailedToRegisterForRemoteNotificationsDelegate
	{
		get
		{
			CheckDestroyed();
			if (!ApplicationFailedToRegisterForRemoteNotificationsDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlatformGameInstance:ApplicationFailedToRegisterForRemoteNotificationsDelegate");
				return new FPlatformFailedToRegisterForRemoteNotificationsDelegate();
			}
			if (ApplicationFailedToRegisterForRemoteNotificationsDelegate_DelegateCached == null)
			{
				ApplicationFailedToRegisterForRemoteNotificationsDelegate_DelegateCached = new FPlatformFailedToRegisterForRemoteNotificationsDelegate();
				ApplicationFailedToRegisterForRemoteNotificationsDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, ApplicationFailedToRegisterForRemoteNotificationsDelegate_Offset));
			}
			return ApplicationFailedToRegisterForRemoteNotificationsDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.PlatformGameInstance:ApplicationReceivedRemoteNotificationDelegate")]
	public FPlatformReceivedRemoteNotificationDelegate ApplicationReceivedRemoteNotificationDelegate
	{
		get
		{
			CheckDestroyed();
			if (!ApplicationReceivedRemoteNotificationDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlatformGameInstance:ApplicationReceivedRemoteNotificationDelegate");
				return new FPlatformReceivedRemoteNotificationDelegate();
			}
			if (ApplicationReceivedRemoteNotificationDelegate_DelegateCached == null)
			{
				ApplicationReceivedRemoteNotificationDelegate_DelegateCached = new FPlatformReceivedRemoteNotificationDelegate();
				ApplicationReceivedRemoteNotificationDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, ApplicationReceivedRemoteNotificationDelegate_Offset));
			}
			return ApplicationReceivedRemoteNotificationDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.PlatformGameInstance:ApplicationReceivedLocalNotificationDelegate")]
	public FPlatformReceivedLocalNotificationDelegate ApplicationReceivedLocalNotificationDelegate
	{
		get
		{
			CheckDestroyed();
			if (!ApplicationReceivedLocalNotificationDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlatformGameInstance:ApplicationReceivedLocalNotificationDelegate");
				return new FPlatformReceivedLocalNotificationDelegate();
			}
			if (ApplicationReceivedLocalNotificationDelegate_DelegateCached == null)
			{
				ApplicationReceivedLocalNotificationDelegate_DelegateCached = new FPlatformReceivedLocalNotificationDelegate();
				ApplicationReceivedLocalNotificationDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, ApplicationReceivedLocalNotificationDelegate_Offset));
			}
			return ApplicationReceivedLocalNotificationDelegate_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.PlatformGameInstance:ApplicationReceivedScreenOrientationChangedNotificationDelegate")]
	public FPlatformScreenOrientationChangedDelegate ApplicationReceivedScreenOrientationChangedNotificationDelegate
	{
		get
		{
			CheckDestroyed();
			if (!ApplicationReceivedScreenOrientationChangedNotificationDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PlatformGameInstance:ApplicationReceivedScreenOrientationChangedNotificationDelegate");
				return new FPlatformScreenOrientationChangedDelegate();
			}
			if (ApplicationReceivedScreenOrientationChangedNotificationDelegate_DelegateCached == null)
			{
				ApplicationReceivedScreenOrientationChangedNotificationDelegate_DelegateCached = new FPlatformScreenOrientationChangedDelegate();
				ApplicationReceivedScreenOrientationChangedNotificationDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, ApplicationReceivedScreenOrientationChangedNotificationDelegate_Offset));
			}
			return ApplicationReceivedScreenOrientationChangedNotificationDelegate_DelegateCached;
		}
	}

	static UPlatformGameInstance()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPlatformGameInstance)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPlatformGameInstance));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.PlatformGameInstance");
		ApplicationWillDeactivateDelegate_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ApplicationWillDeactivateDelegate");
		ApplicationWillDeactivateDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ApplicationWillDeactivateDelegate", Classes.FMulticastDelegateProperty);
		ApplicationHasReactivatedDelegate_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ApplicationHasReactivatedDelegate");
		ApplicationHasReactivatedDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ApplicationHasReactivatedDelegate", Classes.FMulticastDelegateProperty);
		ApplicationWillEnterBackgroundDelegate_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ApplicationWillEnterBackgroundDelegate");
		ApplicationWillEnterBackgroundDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ApplicationWillEnterBackgroundDelegate", Classes.FMulticastDelegateProperty);
		ApplicationHasEnteredForegroundDelegate_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ApplicationHasEnteredForegroundDelegate");
		ApplicationHasEnteredForegroundDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ApplicationHasEnteredForegroundDelegate", Classes.FMulticastDelegateProperty);
		ApplicationWillTerminateDelegate_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ApplicationWillTerminateDelegate");
		ApplicationWillTerminateDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ApplicationWillTerminateDelegate", Classes.FMulticastDelegateProperty);
		ApplicationShouldUnloadResourcesDelegate_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ApplicationShouldUnloadResourcesDelegate");
		ApplicationShouldUnloadResourcesDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ApplicationShouldUnloadResourcesDelegate", Classes.FMulticastDelegateProperty);
		ApplicationReceivedStartupArgumentsDelegate_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ApplicationReceivedStartupArgumentsDelegate");
		ApplicationReceivedStartupArgumentsDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ApplicationReceivedStartupArgumentsDelegate", Classes.FMulticastDelegateProperty);
		ApplicationRegisteredForRemoteNotificationsDelegate_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ApplicationRegisteredForRemoteNotificationsDelegate");
		ApplicationRegisteredForRemoteNotificationsDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ApplicationRegisteredForRemoteNotificationsDelegate", Classes.FMulticastDelegateProperty);
		ApplicationRegisteredForUserNotificationsDelegate_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ApplicationRegisteredForUserNotificationsDelegate");
		ApplicationRegisteredForUserNotificationsDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ApplicationRegisteredForUserNotificationsDelegate", Classes.FMulticastDelegateProperty);
		ApplicationFailedToRegisterForRemoteNotificationsDelegate_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ApplicationFailedToRegisterForRemoteNotificationsDelegate");
		ApplicationFailedToRegisterForRemoteNotificationsDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ApplicationFailedToRegisterForRemoteNotificationsDelegate", Classes.FMulticastDelegateProperty);
		ApplicationReceivedRemoteNotificationDelegate_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ApplicationReceivedRemoteNotificationDelegate");
		ApplicationReceivedRemoteNotificationDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ApplicationReceivedRemoteNotificationDelegate", Classes.FMulticastDelegateProperty);
		ApplicationReceivedLocalNotificationDelegate_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ApplicationReceivedLocalNotificationDelegate");
		ApplicationReceivedLocalNotificationDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ApplicationReceivedLocalNotificationDelegate", Classes.FMulticastDelegateProperty);
		ApplicationReceivedScreenOrientationChangedNotificationDelegate_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ApplicationReceivedScreenOrientationChangedNotificationDelegate");
		ApplicationReceivedScreenOrientationChangedNotificationDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ApplicationReceivedScreenOrientationChangedNotificationDelegate", Classes.FMulticastDelegateProperty);
	}
}
