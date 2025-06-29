using System.Collections.Concurrent;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Net.Configuration;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace System.Net;

internal static class SSPIWrapper
{
	private enum OP
	{
		Encrypt = 1,
		Decrypt,
		MakeSignature,
		VerifySignature
	}

	private static int s_DefaultCredentialsHandleCacheSize = SettingsSectionInternal.Section.DefaultCredentialsHandleCacheSize;

	private static bool s_DefaultCredentialsHandleCacheEnabled = s_DefaultCredentialsHandleCacheSize > 0;

	private static readonly Lazy<ConcurrentDictionary<string, SafeFreeCredentials>> s_DefaultCredentialsHandleCache = new Lazy<ConcurrentDictionary<string, SafeFreeCredentials>>(InitDefaultCredentialsHandleCache);

	internal static SecurityPackageInfoClass[] EnumerateSecurityPackages(SSPIInterface SecModule)
	{
		if (SecModule.SecurityPackages == null)
		{
			lock (SecModule)
			{
				if (SecModule.SecurityPackages == null)
				{
					int pkgnum = 0;
					SafeFreeContextBuffer pkgArray = null;
					try
					{
						int num = SecModule.EnumerateSecurityPackages(out pkgnum, out pkgArray);
						if (num != 0)
						{
							throw new Win32Exception(num);
						}
						SecurityPackageInfoClass[] array = new SecurityPackageInfoClass[pkgnum];
						if (Logging.On)
						{
							Logging.PrintInfo(Logging.Web, SR.GetString("net_log_sspi_enumerating_security_packages"));
						}
						for (int i = 0; i < pkgnum; i++)
						{
							array[i] = new SecurityPackageInfoClass(pkgArray, i);
							if (Logging.On)
							{
								Logging.PrintInfo(Logging.Web, "    " + array[i].Name);
							}
						}
						SecModule.SecurityPackages = array;
					}
					finally
					{
						pkgArray?.Close();
					}
				}
			}
		}
		return SecModule.SecurityPackages;
	}

	internal static SecurityPackageInfoClass GetVerifyPackageInfo(SSPIInterface secModule, string packageName)
	{
		return GetVerifyPackageInfo(secModule, packageName, throwIfMissing: false);
	}

	internal static SecurityPackageInfoClass GetVerifyPackageInfo(SSPIInterface secModule, string packageName, bool throwIfMissing)
	{
		SecurityPackageInfoClass[] array = EnumerateSecurityPackages(secModule);
		if (array != null)
		{
			for (int i = 0; i < array.Length; i++)
			{
				if (string.Compare(array[i].Name, packageName, StringComparison.OrdinalIgnoreCase) == 0)
				{
					return array[i];
				}
			}
		}
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, SR.GetString("net_log_sspi_security_package_not_found", packageName));
		}
		if (throwIfMissing)
		{
			throw new NotSupportedException(SR.GetString("net_securitypackagesupport"));
		}
		return null;
	}

	private static ConcurrentDictionary<string, SafeFreeCredentials> InitDefaultCredentialsHandleCache()
	{
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, string.Format("{0}: {1} = {2}", "InitDefaultCredentialsHandleCache", "defaultCredentialsHandleCacheSize", s_DefaultCredentialsHandleCacheSize));
		}
		return new ConcurrentDictionary<string, SafeFreeCredentials>(Environment.ProcessorCount, s_DefaultCredentialsHandleCacheSize);
	}

	public static SafeFreeCredentials AcquireDefaultCredential(SSPIInterface SecModule, string package, CredentialUse intent)
	{
		SafeFreeCredentials value = null;
		string text = null;
		bool flag;
		if (s_DefaultCredentialsHandleCacheEnabled)
		{
			text = $"{package}_{intent.ToString()}_{WindowsIdentity.GetCurrent().Name}";
			flag = s_DefaultCredentialsHandleCache.Value.TryGetValue(text, out value);
		}
		else
		{
			flag = false;
		}
		if (Logging.On)
		{
			if (text == null)
			{
				text = $"{package}_{intent.ToString()}_{WindowsIdentity.GetCurrent().Name}";
			}
			Logging.PrintInfo(Logging.Web, "AcquireDefaultCredential(package = " + package + ", intent = " + intent.ToString() + ", identity = " + text + ", cached = " + flag + ")");
		}
		if (!flag)
		{
			int num = SecModule.AcquireDefaultCredential(package, intent, out value);
			if (num != 0)
			{
				if (Logging.On)
				{
					Logging.PrintError(Logging.Web, SR.GetString("net_log_operation_failed_with_error", "AcquireDefaultCredential()", string.Format(CultureInfo.CurrentCulture, "0X{0:X}", new object[1] { num })));
				}
				throw new Win32Exception(num);
			}
			if (s_DefaultCredentialsHandleCacheEnabled && s_DefaultCredentialsHandleCache.Value.Count < s_DefaultCredentialsHandleCacheSize)
			{
				try
				{
					s_DefaultCredentialsHandleCache.Value.TryAdd(text, value);
				}
				catch (OverflowException)
				{
				}
			}
		}
		return value;
	}

	public static SafeFreeCredentials AcquireCredentialsHandle(SSPIInterface SecModule, string package, CredentialUse intent, ref AuthIdentity authdata)
	{
		if (Logging.On)
		{
			TraceSource web = Logging.Web;
			string[] obj = new string[7]
			{
				"AcquireCredentialsHandle(package  = ",
				package,
				", intent   = ",
				intent.ToString(),
				", authdata = ",
				null,
				null
			};
			AuthIdentity authIdentity = authdata;
			obj[5] = authIdentity.ToString();
			obj[6] = ")";
			Logging.PrintInfo(web, string.Concat(obj));
		}
		SafeFreeCredentials outCredential = null;
		int num = SecModule.AcquireCredentialsHandle(package, intent, ref authdata, out outCredential);
		if (num != 0)
		{
			if (Logging.On)
			{
				Logging.PrintError(Logging.Web, SR.GetString("net_log_operation_failed_with_error", "AcquireCredentialsHandle()", string.Format(CultureInfo.CurrentCulture, "0X{0:X}", new object[1] { num })));
			}
			throw new Win32Exception(num);
		}
		return outCredential;
	}

	public static SafeFreeCredentials AcquireCredentialsHandle(SSPIInterface SecModule, string package, CredentialUse intent, ref SafeSspiAuthDataHandle authdata)
	{
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, "AcquireCredentialsHandle(package  = " + package + ", intent   = " + intent.ToString() + ", authdata = " + authdata?.ToString() + ")");
		}
		SafeFreeCredentials outCredential = null;
		int num = SecModule.AcquireCredentialsHandle(package, intent, ref authdata, out outCredential);
		if (num != 0)
		{
			if (Logging.On)
			{
				Logging.PrintError(Logging.Web, SR.GetString("net_log_operation_failed_with_error", "AcquireCredentialsHandle()", string.Format(CultureInfo.CurrentCulture, "0X{0:X}", new object[1] { num })));
			}
			throw new Win32Exception(num);
		}
		return outCredential;
	}

	public static SafeFreeCredentials AcquireCredentialsHandle(SSPIInterface SecModule, string package, CredentialUse intent, SecureCredential scc)
	{
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, "AcquireCredentialsHandle(package = " + package + ", intent  = " + intent.ToString() + ", scc     = " + scc.ToString() + ")");
		}
		SafeFreeCredentials outCredential = null;
		int num = SecModule.AcquireCredentialsHandle(package, intent, ref scc, out outCredential);
		if (num != 0)
		{
			if (Logging.On)
			{
				Logging.PrintError(Logging.Web, SR.GetString("net_log_operation_failed_with_error", "AcquireCredentialsHandle()", string.Format(CultureInfo.CurrentCulture, "0X{0:X}", new object[1] { num })));
			}
			throw new Win32Exception(num);
		}
		return outCredential;
	}

	public static SafeFreeCredentials AcquireCredentialsHandle(SSPIInterface SecModule, string package, CredentialUse intent, SecureCredential2 scc)
	{
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, "AcquireCredentialsHandle(package = " + package + ", intent  = " + intent.ToString() + ", scc     = " + scc.ToString() + ")");
		}
		SafeFreeCredentials outCredential = null;
		int num = SecModule.AcquireCredentialsHandle(package, intent, ref scc, out outCredential);
		if (num != 0)
		{
			if (Logging.On)
			{
				Logging.PrintError(Logging.Web, SR.GetString("net_log_operation_failed_with_error", "AcquireCredentialsHandle()", string.Format(CultureInfo.CurrentCulture, "0X{0:X}", new object[1] { num })));
			}
			throw new Win32Exception(num);
		}
		return outCredential;
	}

	internal static int InitializeSecurityContext(SSPIInterface SecModule, ref SafeFreeCredentials credential, ref SafeDeleteContext context, string targetName, ContextFlags inFlags, Endianness datarep, SecurityBuffer inputBuffer, SecurityBuffer outputBuffer, ref ContextFlags outFlags)
	{
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, "InitializeSecurityContext(credential = " + credential.ToString() + ", context = " + ValidationHelper.ToString(context) + ", targetName = " + targetName + ", inFlags = " + inFlags.ToString() + ")");
		}
		int num = SecModule.InitializeSecurityContext(ref credential, ref context, targetName, inFlags, datarep, inputBuffer, outputBuffer, ref outFlags);
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, SR.GetString("net_log_sspi_security_context_input_buffer", "InitializeSecurityContext", inputBuffer?.size ?? 0, outputBuffer.size, (SecurityStatus)num));
		}
		return num;
	}

	internal static int InitializeSecurityContext(SSPIInterface SecModule, SafeFreeCredentials credential, ref SafeDeleteContext context, string targetName, ContextFlags inFlags, Endianness datarep, SecurityBuffer[] inputBuffers, SecurityBuffer outputBuffer, ref ContextFlags outFlags)
	{
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, "InitializeSecurityContext(credential = " + credential.ToString() + ", context = " + ValidationHelper.ToString(context) + ", targetName = " + targetName + ", inFlags = " + inFlags.ToString() + ")");
		}
		int num = SecModule.InitializeSecurityContext(credential, ref context, targetName, inFlags, datarep, inputBuffers, outputBuffer, ref outFlags);
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, SR.GetString("net_log_sspi_security_context_input_buffers", "InitializeSecurityContext", (inputBuffers != null) ? inputBuffers.Length : 0, outputBuffer.size, (SecurityStatus)num));
		}
		return num;
	}

	internal static int AcceptSecurityContext(SSPIInterface SecModule, ref SafeFreeCredentials credential, ref SafeDeleteContext context, ContextFlags inFlags, Endianness datarep, SecurityBuffer inputBuffer, SecurityBuffer outputBuffer, ref ContextFlags outFlags)
	{
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, "AcceptSecurityContext(credential = " + credential.ToString() + ", context = " + ValidationHelper.ToString(context) + ", inFlags = " + inFlags.ToString() + ")");
		}
		int num = SecModule.AcceptSecurityContext(ref credential, ref context, inputBuffer, inFlags, datarep, outputBuffer, ref outFlags);
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, SR.GetString("net_log_sspi_security_context_input_buffer", "AcceptSecurityContext", inputBuffer?.size ?? 0, outputBuffer.size, (SecurityStatus)num));
		}
		return num;
	}

	internal static int AcceptSecurityContext(SSPIInterface SecModule, SafeFreeCredentials credential, ref SafeDeleteContext context, ContextFlags inFlags, Endianness datarep, SecurityBuffer[] inputBuffers, SecurityBuffer outputBuffer, ref ContextFlags outFlags)
	{
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, "AcceptSecurityContext(credential = " + credential.ToString() + ", context = " + ValidationHelper.ToString(context) + ", inFlags = " + inFlags.ToString() + ")");
		}
		int num = SecModule.AcceptSecurityContext(credential, ref context, inputBuffers, inFlags, datarep, outputBuffer, ref outFlags);
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, SR.GetString("net_log_sspi_security_context_input_buffers", "AcceptSecurityContext", (inputBuffers != null) ? inputBuffers.Length : 0, outputBuffer.size, (SecurityStatus)num));
		}
		return num;
	}

	internal static int CompleteAuthToken(SSPIInterface SecModule, ref SafeDeleteContext context, SecurityBuffer[] inputBuffers)
	{
		int num = SecModule.CompleteAuthToken(ref context, inputBuffers);
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, SR.GetString("net_log_operation_returned_something", "CompleteAuthToken()", (SecurityStatus)num));
		}
		return num;
	}

	internal static int ApplyControlToken(SSPIInterface SecModule, ref SafeDeleteContext context, SecurityBuffer[] inputBuffers)
	{
		int num = SecModule.ApplyControlToken(ref context, inputBuffers);
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.Web, SR.GetString("net_log_operation_returned_something", "ApplyControlToken()", (SecurityStatus)num));
		}
		return num;
	}

	public static int QuerySecurityContextToken(SSPIInterface SecModule, SafeDeleteContext context, out SafeCloseHandle token)
	{
		return SecModule.QuerySecurityContextToken(context, out token);
	}

	public static int EncryptMessage(SSPIInterface secModule, SafeDeleteContext context, SecurityBuffer[] input, uint sequenceNumber)
	{
		return EncryptDecryptHelper(OP.Encrypt, secModule, context, input, sequenceNumber);
	}

	public static int DecryptMessage(SSPIInterface secModule, SafeDeleteContext context, SecurityBuffer[] input, uint sequenceNumber)
	{
		return EncryptDecryptHelper(OP.Decrypt, secModule, context, input, sequenceNumber);
	}

	public static int ApplyAlertToken(SSPIInterface secModule, ref SafeFreeCredentials credentialsHandle, SafeDeleteContext securityContext, TlsAlertType alertType, TlsAlertMessage alertMessage)
	{
		Interop.SChannel.SCHANNEL_ALERT_TOKEN sCHANNEL_ALERT_TOKEN = default(Interop.SChannel.SCHANNEL_ALERT_TOKEN);
		sCHANNEL_ALERT_TOKEN.dwTokenType = 2u;
		sCHANNEL_ALERT_TOKEN.dwAlertType = (uint)alertType;
		sCHANNEL_ALERT_TOKEN.dwAlertNumber = (uint)alertMessage;
		SecurityBuffer[] array = new SecurityBuffer[1];
		int num = Marshal.SizeOf(typeof(Interop.SChannel.SCHANNEL_ALERT_TOKEN));
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		try
		{
			byte[] array2 = new byte[num];
			Marshal.StructureToPtr((object)sCHANNEL_ALERT_TOKEN, intPtr, fDeleteOld: false);
			Marshal.Copy(intPtr, array2, 0, num);
			array[0] = new SecurityBuffer(array2, BufferType.Token);
			return ApplyControlToken(secModule, ref securityContext, array);
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}

	public static int ApplyShutdownToken(SSPIInterface secModule, ref SafeFreeCredentials credentialsHandle, SafeDeleteContext securityContext)
	{
		int value = 1;
		SecurityBuffer[] array = new SecurityBuffer[1];
		byte[] bytes = BitConverter.GetBytes(value);
		array[0] = new SecurityBuffer(bytes, BufferType.Token);
		return ApplyControlToken(secModule, ref securityContext, array);
	}

	internal static int MakeSignature(SSPIInterface secModule, SafeDeleteContext context, SecurityBuffer[] input, uint sequenceNumber)
	{
		return EncryptDecryptHelper(OP.MakeSignature, secModule, context, input, sequenceNumber);
	}

	public static int VerifySignature(SSPIInterface secModule, SafeDeleteContext context, SecurityBuffer[] input, uint sequenceNumber)
	{
		return EncryptDecryptHelper(OP.VerifySignature, secModule, context, input, sequenceNumber);
	}

	private unsafe static int EncryptDecryptHelper(OP op, SSPIInterface SecModule, SafeDeleteContext context, SecurityBuffer[] input, uint sequenceNumber)
	{
		SecurityBufferDescriptor securityBufferDescriptor = new SecurityBufferDescriptor(input.Length);
		SecurityBufferStruct[] array = new SecurityBufferStruct[input.Length];
		fixed (SecurityBufferStruct* unmanagedPointer = array)
		{
			securityBufferDescriptor.UnmanagedPointer = unmanagedPointer;
			GCHandle[] array2 = new GCHandle[input.Length];
			byte[][] array3 = new byte[input.Length][];
			try
			{
				for (int i = 0; i < input.Length; i++)
				{
					SecurityBuffer securityBuffer = input[i];
					array[i].count = securityBuffer.size;
					array[i].type = securityBuffer.type;
					if (securityBuffer.token == null || securityBuffer.token.Length == 0)
					{
						array[i].token = IntPtr.Zero;
						continue;
					}
					array2[i] = GCHandle.Alloc(securityBuffer.token, GCHandleType.Pinned);
					array[i].token = Marshal.UnsafeAddrOfPinnedArrayElement((Array)securityBuffer.token, securityBuffer.offset);
					array3[i] = securityBuffer.token;
				}
				int num = op switch
				{
					OP.Encrypt => SecModule.EncryptMessage(context, securityBufferDescriptor, sequenceNumber), 
					OP.Decrypt => SecModule.DecryptMessage(context, securityBufferDescriptor, sequenceNumber), 
					OP.MakeSignature => SecModule.MakeSignature(context, securityBufferDescriptor, sequenceNumber), 
					OP.VerifySignature => SecModule.VerifySignature(context, securityBufferDescriptor, sequenceNumber), 
					_ => throw ExceptionHelper.MethodNotImplementedException, 
				};
				for (int j = 0; j < input.Length; j++)
				{
					SecurityBuffer securityBuffer2 = input[j];
					securityBuffer2.size = array[j].count;
					securityBuffer2.type = array[j].type;
					if (securityBuffer2.size == 0)
					{
						securityBuffer2.offset = 0;
						securityBuffer2.token = null;
						continue;
					}
					checked
					{
						int k;
						for (k = 0; k < input.Length; k++)
						{
							if (array3[k] != null)
							{
								byte* ptr = unchecked((byte*)(void*)Marshal.UnsafeAddrOfPinnedArrayElement((Array)array3[k], 0));
								if ((void*)array[j].token >= ptr && unchecked((nuint)(void*)array[j].token) + unchecked((nuint)securityBuffer2.size) <= unchecked((nuint)ptr) + unchecked((nuint)array3[k].Length))
								{
									securityBuffer2.offset = (int)(unchecked((byte*)(void*)array[j].token) - ptr);
									securityBuffer2.token = array3[k];
									break;
								}
							}
						}
						if (k >= input.Length)
						{
							securityBuffer2.size = 0;
							securityBuffer2.offset = 0;
							securityBuffer2.token = null;
						}
					}
				}
				if (num != 0 && Logging.On)
				{
					if (num == 590625)
					{
						Logging.PrintError(Logging.Web, SR.GetString("net_log_operation_returned_something", op, "SEC_I_RENEGOTIATE"));
					}
					else
					{
						Logging.PrintError(Logging.Web, SR.GetString("net_log_operation_failed_with_error", op, string.Format(CultureInfo.CurrentCulture, "0X{0:X}", new object[1] { num })));
					}
				}
				return num;
			}
			finally
			{
				for (int l = 0; l < array2.Length; l++)
				{
					if (array2[l].IsAllocated)
					{
						array2[l].Free();
					}
				}
			}
		}
	}

	public static SafeFreeContextBufferChannelBinding QueryContextChannelBinding(SSPIInterface SecModule, SafeDeleteContext securityContext, ContextAttribute contextAttribute)
	{
		if (SecModule.QueryContextChannelBinding(securityContext, contextAttribute, out var refHandle) != 0)
		{
			return null;
		}
		return refHandle;
	}

	public static object QueryContextAttributes(SSPIInterface SecModule, SafeDeleteContext securityContext, ContextAttribute contextAttribute)
	{
		int errorCode;
		return QueryContextAttributes(SecModule, securityContext, contextAttribute, out errorCode);
	}

	public unsafe static object QueryContextAttributes(SSPIInterface SecModule, SafeDeleteContext securityContext, ContextAttribute contextAttribute, out int errorCode)
	{
		int num = IntPtr.Size;
		Type handleType = null;
		switch (contextAttribute)
		{
		case ContextAttribute.Sizes:
			num = SecSizes.SizeOf;
			break;
		case ContextAttribute.StreamSizes:
			num = StreamSizes.SizeOf;
			break;
		case ContextAttribute.Names:
			handleType = typeof(SafeFreeContextBuffer);
			break;
		case ContextAttribute.PackageInfo:
			handleType = typeof(SafeFreeContextBuffer);
			break;
		case ContextAttribute.NegotiationInfo:
			handleType = typeof(SafeFreeContextBuffer);
			num = Marshal.SizeOf(typeof(NegotiationInfo));
			break;
		case ContextAttribute.ClientSpecifiedSpn:
			handleType = typeof(SafeFreeContextBuffer);
			break;
		case ContextAttribute.RemoteCertificate:
			handleType = typeof(SafeFreeCertContext);
			break;
		case ContextAttribute.LocalCertificate:
			handleType = typeof(SafeFreeCertContext);
			break;
		case ContextAttribute.IssuerListInfoEx:
			num = Marshal.SizeOf(typeof(IssuerListInfoEx));
			handleType = typeof(SafeFreeContextBuffer);
			break;
		case ContextAttribute.ConnectionInfo:
			num = Marshal.SizeOf(typeof(SslConnectionInfo));
			break;
		default:
			throw new ArgumentException(SR.GetString("net_invalid_enum", "ContextAttribute"), "contextAttribute");
		}
		SafeHandle refHandle = null;
		object result = null;
		try
		{
			byte[] array = new byte[num];
			errorCode = SecModule.QueryContextAttributes(securityContext, contextAttribute, array, handleType, out refHandle);
			if (errorCode != 0)
			{
				return null;
			}
			switch (contextAttribute)
			{
			case ContextAttribute.Sizes:
				result = new SecSizes(array);
				break;
			case ContextAttribute.StreamSizes:
				result = new StreamSizes(array);
				break;
			case ContextAttribute.Names:
				result = Marshal.PtrToStringUni(refHandle.DangerousGetHandle());
				break;
			case ContextAttribute.PackageInfo:
				result = new SecurityPackageInfoClass(refHandle, 0);
				break;
			case ContextAttribute.NegotiationInfo:
				fixed (byte* ptr = array)
				{
					void* value = ptr;
					result = new NegotiationInfoClass(refHandle, Marshal.ReadInt32(new IntPtr(value), NegotiationInfo.NegotiationStateOffest));
				}
				break;
			case ContextAttribute.ClientSpecifiedSpn:
				result = Marshal.PtrToStringUni(refHandle.DangerousGetHandle());
				break;
			case ContextAttribute.RemoteCertificate:
			case ContextAttribute.LocalCertificate:
				result = refHandle;
				refHandle = null;
				break;
			case ContextAttribute.IssuerListInfoEx:
				result = new IssuerListInfoEx(refHandle, array);
				refHandle = null;
				break;
			case ContextAttribute.ConnectionInfo:
				result = new SslConnectionInfo(array);
				break;
			}
		}
		finally
		{
			refHandle?.Close();
		}
		return result;
	}

	public static int SetContextAttributes(SSPIInterface SecModule, SafeDeleteContext securityContext, ContextAttribute contextAttribute, object value)
	{
		if (contextAttribute == ContextAttribute.UiInfo)
		{
			IntPtr intPtr = (IntPtr)value;
			byte[] array = new byte[IntPtr.Size];
			if (IntPtr.Size == 4)
			{
				int num = intPtr.ToInt32();
				array[0] = (byte)num;
				array[1] = (byte)(num >> 8);
				array[2] = (byte)(num >> 16);
				array[3] = (byte)(num >> 24);
			}
			else
			{
				long num2 = intPtr.ToInt64();
				array[0] = (byte)num2;
				array[1] = (byte)(num2 >> 8);
				array[2] = (byte)(num2 >> 16);
				array[3] = (byte)(num2 >> 24);
				array[4] = (byte)(num2 >> 32);
				array[5] = (byte)(num2 >> 40);
				array[6] = (byte)(num2 >> 48);
				array[7] = (byte)(num2 >> 56);
			}
			return SecModule.SetContextAttributes(securityContext, contextAttribute, array);
		}
		throw new ArgumentException(SR.GetString("net_invalid_enum", "ContextAttribute"), "contextAttribute");
	}

	public static string ErrorDescription(int errorCode)
	{
		if (errorCode == -1)
		{
			return "An exception when invoking Win32 API";
		}
		return (SecurityStatus)errorCode switch
		{
			SecurityStatus.InvalidHandle => "Invalid handle", 
			SecurityStatus.InvalidToken => "Invalid token", 
			SecurityStatus.ContinueNeeded => "Continue needed", 
			SecurityStatus.IncompleteMessage => "Message incomplete", 
			SecurityStatus.WrongPrincipal => "Wrong principal", 
			SecurityStatus.TargetUnknown => "Target unknown", 
			SecurityStatus.PackageNotFound => "Package not found", 
			SecurityStatus.BufferNotEnough => "Buffer not enough", 
			SecurityStatus.MessageAltered => "Message altered", 
			SecurityStatus.UntrustedRoot => "Untrusted root", 
			_ => "0x" + errorCode.ToString("x", NumberFormatInfo.InvariantInfo), 
		};
	}
}
