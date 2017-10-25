using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Net.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeNetUtils']"
	[global::Android.Runtime.Register ("com/umeng/socialize/net/utils/SocializeNetUtils", DoNotGenerateAcw=true)]
	public partial class SocializeNetUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/net/utils/SocializeNetUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SocializeNetUtils); }
		}

		protected SocializeNetUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeNetUtils']/constructor[@name='SocializeNetUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SocializeNetUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SocializeNetUtils)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_convertStreamToString_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeNetUtils']/method[@name='convertStreamToString' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("convertStreamToString", "(Ljava/io/InputStream;)Ljava/lang/String;", "")]
		public static unsafe string ConvertStreamToString (global::System.IO.Stream p0)
		{
			if (id_convertStreamToString_Ljava_io_InputStream_ == IntPtr.Zero)
				id_convertStreamToString_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "convertStreamToString", "(Ljava/io/InputStream;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_convertStreamToString_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_decodeUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeNetUtils']/method[@name='decodeUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decodeUrl", "(Ljava/lang/String;)Landroid/os/Bundle;", "")]
		public static unsafe global::Android.OS.Bundle DecodeUrl (string p0)
		{
			if (id_decodeUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_decodeUrl_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decodeUrl", "(Ljava/lang/String;)Landroid/os/Bundle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getNetData_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeNetUtils']/method[@name='getNetData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getNetData", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] GetNetData (string p0)
		{
			if (id_getNetData_Ljava_lang_String_ == IntPtr.Zero)
				id_getNetData_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getNetData", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getNetData_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_isConSpeCharacters_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeNetUtils']/method[@name='isConSpeCharacters' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isConSpeCharacters", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsConSpeCharacters (string p0)
		{
			if (id_isConSpeCharacters_Ljava_lang_String_ == IntPtr.Zero)
				id_isConSpeCharacters_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isConSpeCharacters", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isConSpeCharacters_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_isSelfAppkey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeNetUtils']/method[@name='isSelfAppkey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isSelfAppkey", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsSelfAppkey (string p0)
		{
			if (id_isSelfAppkey_Ljava_lang_String_ == IntPtr.Zero)
				id_isSelfAppkey_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isSelfAppkey", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSelfAppkey_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_parseUri_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeNetUtils']/method[@name='parseUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseUri", "(Ljava/lang/String;)Landroid/os/Bundle;", "")]
		public static unsafe global::Android.OS.Bundle ParseUri (string p0)
		{
			if (id_parseUri_Ljava_lang_String_ == IntPtr.Zero)
				id_parseUri_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parseUri", "(Ljava/lang/String;)Landroid/os/Bundle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseUri_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_parseUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeNetUtils']/method[@name='parseUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseUrl", "(Ljava/lang/String;)Landroid/os/Bundle;", "")]
		public static unsafe global::Android.OS.Bundle ParseUrl (string p0)
		{
			if (id_parseUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_parseUrl_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parseUrl", "(Ljava/lang/String;)Landroid/os/Bundle;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_request_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeNetUtils']/method[@name='request' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("request", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Request (string p0)
		{
			if (id_request_Ljava_lang_String_ == IntPtr.Zero)
				id_request_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "request", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_request_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_startWithHttp_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='SocializeNetUtils']/method[@name='startWithHttp' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("startWithHttp", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool StartWithHttp (string p0)
		{
			if (id_startWithHttp_Ljava_lang_String_ == IntPtr.Zero)
				id_startWithHttp_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "startWithHttp", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_startWithHttp_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
