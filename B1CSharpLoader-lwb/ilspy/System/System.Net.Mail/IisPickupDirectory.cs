using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Authentication;
using System.Security.Permissions;
using System.Text;

namespace System.Net.Mail;

[SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.UnmanagedCode)]
internal static class IisPickupDirectory
{
	private const int MaxPathSize = 260;

	private const int InfiniteTimeout = -1;

	private const int MetadataMaxNameLen = 256;

	internal unsafe static string GetPickupDirectory()
	{
		uint RequiredDataLen = 0u;
		string text = string.Empty;
		IMSAdminBase iMSAdminBase = null;
		IntPtr NewHandle = IntPtr.Zero;
		StringBuilder stringBuilder = new StringBuilder(256);
		uint num = 1040u;
		byte[] array = new byte[num];
		try
		{
			iMSAdminBase = new MSAdminBase() as IMSAdminBase;
			int num2 = iMSAdminBase.OpenKey(IntPtr.Zero, "LM/SmtpSvc", MBKeyAccess.Read, -1, ref NewHandle);
			if (num2 >= 0)
			{
				MetadataRecord data = default(MetadataRecord);
				fixed (byte* ptr = array)
				{
					int num3 = 0;
					while (true)
					{
						num2 = iMSAdminBase.EnumKeys(NewHandle, "", stringBuilder, num3);
						if (num2 != -2147024637)
						{
							if (num2 < 0)
							{
								break;
							}
							data.Identifier = 1016u;
							data.Attributes = 0u;
							data.UserType = 1u;
							data.DataType = 1u;
							data.DataTag = 0u;
							data.DataBuf = (IntPtr)ptr;
							data.DataLen = num;
							num2 = iMSAdminBase.GetData(NewHandle, stringBuilder.ToString(), ref data, ref RequiredDataLen);
							if (num2 < 0)
							{
								if (num2 != -2146646015 && num2 != -2147024891)
								{
									break;
								}
								goto IL_019f;
							}
							int num4 = Marshal.ReadInt32((IntPtr)ptr);
							if (num4 != 2)
							{
								goto IL_019f;
							}
							data.Identifier = 36880u;
							data.Attributes = 0u;
							data.UserType = 1u;
							data.DataType = 2u;
							data.DataTag = 0u;
							data.DataBuf = (IntPtr)ptr;
							data.DataLen = num;
							num2 = iMSAdminBase.GetData(NewHandle, stringBuilder.ToString(), ref data, ref RequiredDataLen);
							if (num2 < 0)
							{
								break;
							}
							text = Marshal.PtrToStringUni((IntPtr)ptr);
						}
						if (num2 != -2147024637)
						{
							break;
						}
						int num5 = 0;
						while (true)
						{
							num2 = iMSAdminBase.EnumKeys(NewHandle, "", stringBuilder, num5);
							if (num2 == -2147024637 || num2 < 0)
							{
								break;
							}
							data.Identifier = 36880u;
							data.Attributes = 0u;
							data.UserType = 1u;
							data.DataType = 2u;
							data.DataTag = 0u;
							data.DataBuf = (IntPtr)ptr;
							data.DataLen = num;
							num2 = iMSAdminBase.GetData(NewHandle, stringBuilder.ToString(), ref data, ref RequiredDataLen);
							if (num2 < 0)
							{
								if (num2 != -2146646015 && num2 != -2147024891)
								{
									break;
								}
							}
							else
							{
								text = Marshal.PtrToStringUni((IntPtr)ptr);
								if (Directory.Exists(text))
								{
									break;
								}
								text = string.Empty;
							}
							num5++;
						}
						break;
						IL_019f:
						num3++;
					}
				}
			}
		}
		catch (Exception ex)
		{
			if (ex is SecurityException || ex is AuthenticationException || ex is SmtpException)
			{
				throw;
			}
			throw new SmtpException(SR.GetString("SmtpGetIisPickupDirectoryFailed"));
		}
		finally
		{
			if (iMSAdminBase != null && NewHandle != IntPtr.Zero)
			{
				iMSAdminBase.CloseKey(NewHandle);
			}
		}
		if (text == string.Empty)
		{
			throw new SmtpException(SR.GetString("SmtpGetIisPickupDirectoryFailed"));
		}
		return text;
	}
}
