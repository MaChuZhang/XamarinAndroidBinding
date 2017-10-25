using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Weixin.Umengwx {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.weixin.umengwx']/class[@name='WeChat']"
	[global::Android.Runtime.Register ("com/umeng/weixin/umengwx/WeChat", DoNotGenerateAcw=true)]
	public partial class WeChat : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/weixin/umengwx/WeChat", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WeChat); }
		}

		protected WeChat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.weixin.umengwx']/class[@name='WeChat']/constructor[@name='WeChat' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public unsafe WeChat (global::Android.Content.Context p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (WeChat)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_isWXAppInstalled;
		public unsafe bool IsWXAppInstalled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.weixin.umengwx']/class[@name='WeChat']/method[@name='isWXAppInstalled' and count(parameter)=0]"
			[Register ("isWXAppInstalled", "()Z", "GetIsWXAppInstalledHandler")]
			get {
				if (id_isWXAppInstalled == IntPtr.Zero)
					id_isWXAppInstalled = JNIEnv.GetMethodID (class_ref, "isWXAppInstalled", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isWXAppInstalled);
				} finally {
				}
			}
		}

		static IntPtr id_isWXAppSupportAPI;
		public unsafe bool IsWXAppSupportAPI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.weixin.umengwx']/class[@name='WeChat']/method[@name='isWXAppSupportAPI' and count(parameter)=0]"
			[Register ("isWXAppSupportAPI", "()Z", "GetIsWXAppSupportAPIHandler")]
			get {
				if (id_isWXAppSupportAPI == IntPtr.Zero)
					id_isWXAppSupportAPI = JNIEnv.GetMethodID (class_ref, "isWXAppSupportAPI", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isWXAppSupportAPI);
				} finally {
				}
			}
		}

		static IntPtr id_launchShare_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.weixin.umengwx']/class[@name='WeChat']/method[@name='launchShare' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("launchShare", "(Landroid/os/Bundle;)Z", "")]
		public unsafe bool LaunchShare (global::Android.OS.Bundle p0)
		{
			if (id_launchShare_Landroid_os_Bundle_ == IntPtr.Zero)
				id_launchShare_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "launchShare", "(Landroid/os/Bundle;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_launchShare_Landroid_os_Bundle_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_pushare_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.weixin.umengwx']/class[@name='WeChat']/method[@name='pushare' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("pushare", "(Landroid/os/Bundle;)V", "")]
		public unsafe void Pushare (global::Android.OS.Bundle p0)
		{
			if (id_pushare_Landroid_os_Bundle_ == IntPtr.Zero)
				id_pushare_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "pushare", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pushare_Landroid_os_Bundle_, __args);
			} finally {
			}
		}

		static IntPtr id_registerApp_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.weixin.umengwx']/class[@name='WeChat']/method[@name='registerApp' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("registerApp", "(Ljava/lang/String;)Z", "")]
		public unsafe bool RegisterApp (string p0)
		{
			if (id_registerApp_Ljava_lang_String_ == IntPtr.Zero)
				id_registerApp_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "registerApp", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_registerApp_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
