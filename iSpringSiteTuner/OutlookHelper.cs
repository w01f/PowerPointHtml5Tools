using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Outlook;

namespace iSpringSiteTuner
{
	class OutlookHelper
	{
		private static OutlookHelper _instance;
		private Application _outlookObject;

		public static OutlookHelper Instance
		{
			get
			{
				if(_instance==null)
					_instance = new OutlookHelper();
				return _instance;
			}
		}

		private OutlookHelper()
		{
			
		}

		public bool Connect()
		{
			try
			{
				_outlookObject = new Application();
				return true;
			}
			catch
			{
				return false;
			}
		}

		public void Disconnect()
		{
			ReleaseComObject(_outlookObject);
			GC.WaitForPendingFinalizers();
			GC.Collect();
		}

		public void SendMessage(string subject,string body, IEnumerable<string> recipients)
		{
			if (!Connect()) return;
			try
			{
				MessageFilter.Register();
				var nameSpace = _outlookObject.GetNamespace("MAPI");
				var draftsFolder = nameSpace.GetDefaultFolder(OlDefaultFolders.olFolderDrafts);
				var mi = (MailItem)draftsFolder.Items.Add(OlItemType.olMailItem);

				mi.BodyFormat = OlBodyFormat.olFormatHTML;
				mi.Subject = subject;
				mi.Body = body;
				foreach (string recipient in recipients)
					mi.Recipients.Add(recipient);
				mi.Send();
				//mi.Display();
			}
			catch
			{
			}
			finally
			{
				MessageFilter.Revoke();
			}
			Disconnect();
		}

		private void ReleaseComObject(object o)
		{
			try
			{
				Marshal.ReleaseComObject(o);
			}
			catch
			{
			}
			finally
			{
				o = null;
			}
		}
	}

	class MessageFilter : IOleMessageFilter
	{
		//
		// Class containing the IOleMessageFilter
		// thread error-handling functions.

		// Start the filter.
		public static void Register()
		{
			IOleMessageFilter newFilter = new MessageFilter();
			IOleMessageFilter oldFilter = null;
			CoRegisterMessageFilter(newFilter, out oldFilter);
		}

		// Done with the filter, close it.
		public static void Revoke()
		{
			IOleMessageFilter oldFilter = null;
			CoRegisterMessageFilter(null, out oldFilter);
		}

		//
		// IOleMessageFilter functions.
		// Handle incoming thread requests.
		int IOleMessageFilter.HandleInComingCall(int dwCallType,
		  System.IntPtr hTaskCaller, int dwTickCount, System.IntPtr
		  lpInterfaceInfo)
		{
			//Return the flag SERVERCALL_ISHANDLED.
			return 0;
		}

		// Thread call was rejected, so try again.
		int IOleMessageFilter.RetryRejectedCall(System.IntPtr
		  hTaskCallee, int dwTickCount, int dwRejectType)
		{
			if (dwRejectType == 2)
			// flag = SERVERCALL_RETRYLATER.
			{
				// Retry the thread call immediately if return >=0 & 
				// <100.
				return 99;
			}
			// Too busy; cancel call.
			return -1;
		}

		int IOleMessageFilter.MessagePending(System.IntPtr hTaskCallee,
		  int dwTickCount, int dwPendingType)
		{
			//Return the flag PENDINGMSG_WAITDEFPROCESS.
			return 2;
		}

		// Implement the IOleMessageFilter interface.
		[DllImport("Ole32.dll")]
		private static extern int
		  CoRegisterMessageFilter(IOleMessageFilter newFilter, out 
		  IOleMessageFilter oldFilter);
	}

	[ComImport(), Guid("00000016-0000-0000-C000-000000000046"),
	InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface IOleMessageFilter
	{
		[PreserveSig]
		int HandleInComingCall(
			int dwCallType,
			IntPtr hTaskCaller,
			int dwTickCount,
			IntPtr lpInterfaceInfo);

		[PreserveSig]
		int RetryRejectedCall(
			IntPtr hTaskCallee,
			int dwTickCount,
			int dwRejectType);

		[PreserveSig]
		int MessagePending(
			IntPtr hTaskCallee,
			int dwTickCount,
			int dwPendingType);
	}
}
