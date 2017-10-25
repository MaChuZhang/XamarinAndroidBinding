using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='DeviceConfig']"
	[global::Android.Runtime.Register ("com/umeng/socialize/utils/DeviceConfig", DoNotGenerateAcw=true)]
	public partial class DeviceConfig : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='DeviceConfig']/field[@name='LOG_TAG']"
		[Register ("LOG_TAG")]
		protected const string LogTag = (string) "DeviceConfig";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='DeviceConfig']/field[@name='UNKNOW']"
		[Register ("UNKNOW")]
		protected const string Unknow = (string) "Unknown";

		static IntPtr context_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='DeviceConfig']/field[@name='context']"
		[Register ("context")]
		public static global::Android.Content.Context Context {
			get {
				if (context_jfieldId == IntPtr.Zero)
					context_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "context", "Landroid/content/Context;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, context_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (context_jfieldId == IntPtr.Zero)
					context_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "context", "Landroid/content/Context;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, context_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/utils/DeviceConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeviceConfig); }
		}

		protected DeviceConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='DeviceConfig']/constructor[@name='DeviceConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DeviceConfig ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DeviceConfig)) {
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

		static IntPtr id_getDeviceSN;
		public static unsafe string DeviceSN {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='DeviceConfig']/method[@name='getDeviceSN' and count(parameter)=0]"
			[Register ("getDeviceSN", "()Ljava/lang/String;", "GetGetDeviceSNHandler")]
			get {
				if (id_getDeviceSN == IntPtr.Zero)
					id_getDeviceSN = JNIEnv.GetStaticMethodID (class_ref, "getDeviceSN", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDeviceSN), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isSdCardWrittenable;
		public static unsafe bool IsSdCardWrittenable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='DeviceConfig']/method[@name='isSdCardWrittenable' and count(parameter)=0]"
			[Register ("isSdCardWrittenable", "()Z", "GetIsSdCardWrittenableHandler")]
			get {
				if (id_isSdCardWrittenable == IntPtr.Zero)
					id_isSdCardWrittenable = JNIEnv.GetStaticMethodID (class_ref, "isSdCardWrittenable", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSdCardWrittenable);
				} finally {
				}
			}
		}

		static IntPtr id_getOsVersion;
		public static unsafe string OsVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='DeviceConfig']/method[@name='getOsVersion' and count(parameter)=0]"
			[Register ("getOsVersion", "()Ljava/lang/String;", "GetGetOsVersionHandler")]
			get {
				if (id_getOsVersion == IntPtr.Zero)
					id_getOsVersion = JNIEnv.GetStaticMethodID (class_ref, "getOsVersion", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOsVersion), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_checkPermission_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='DeviceConfig']/method[@name='checkPermission' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("checkPermission", "(Landroid/content/Context;Ljava/lang/String;)Z", "")]
		public static unsafe bool CheckPermission (global::Android.Content.Context p0, string p1)
		{
			if (id_checkPermission_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_checkPermission_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "checkPermission", "(Landroid/content/Context;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkPermission_Landroid_content_Context_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getAndroidID_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='DeviceConfig']/method[@name='getAndroidID' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAndroidID", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetAndroidID (global::Android.Content.Context p0)
		{
			if (id_getAndroidID_Landroid_content_Context_ == IntPtr.Zero)
				id_getAndroidID_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getAndroidID", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAndroidID_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getAppVersion_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='DeviceConfig']/method[@name='getAppVersion' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("getAppVersion", "(Ljava/lang/String;Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetAppVersion (string p0, global::Android.Content.Context p1)
		{
			if (id_getAppVersion_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_getAppVersion_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getAppVersion", "(Ljava/lang/String;Landroid/content/Context;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAppVersion_Ljava_lang_String_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getDeviceId_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='DeviceConfig']/method[@name='getDeviceId' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDeviceId", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetDeviceId (global::Android.Content.Context p0)
		{
			if (id_getDeviceId_Landroid_content_Context_ == IntPtr.Zero)
				id_getDeviceId_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getDeviceId", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDeviceId_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getMac_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='DeviceConfig']/method[@name='getMac' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getMac", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetMac (global::Android.Content.Context p0)
		{
			if (id_getMac_Landroid_content_Context_ == IntPtr.Zero)
				id_getMac_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getMac", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMac_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getNetworkAccessMode_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='DeviceConfig']/method[@name='getNetworkAccessMode' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getNetworkAccessMode", "(Landroid/content/Context;)[Ljava/lang/String;", "")]
		public static unsafe string[] GetNetworkAccessMode (global::Android.Content.Context p0)
		{
			if (id_getNetworkAccessMode_Landroid_content_Context_ == IntPtr.Zero)
				id_getNetworkAccessMode_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getNetworkAccessMode", "(Landroid/content/Context;)[Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getNetworkAccessMode_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getPackageName_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='DeviceConfig']/method[@name='getPackageName' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getPackageName", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetPackageName (global::Android.Content.Context p0)
		{
			if (id_getPackageName_Landroid_content_Context_ == IntPtr.Zero)
				id_getPackageName_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getPackageName", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPackageName_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isAppInstalled_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='DeviceConfig']/method[@name='isAppInstalled' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("isAppInstalled", "(Ljava/lang/String;Landroid/content/Context;)Z", "")]
		public static unsafe bool IsAppInstalled (string p0, global::Android.Content.Context p1)
		{
			if (id_isAppInstalled_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_isAppInstalled_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isAppInstalled", "(Ljava/lang/String;Landroid/content/Context;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAppInstalled_Ljava_lang_String_Landroid_content_Context_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_isNetworkAvailable_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='DeviceConfig']/method[@name='isNetworkAvailable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isNetworkAvailable", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsNetworkAvailable (global::Android.Content.Context p0)
		{
			if (id_isNetworkAvailable_Landroid_content_Context_ == IntPtr.Zero)
				id_isNetworkAvailable_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isNetworkAvailable", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNetworkAvailable_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isOnline_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='DeviceConfig']/method[@name='isOnline' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isOnline", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsOnline (global::Android.Content.Context p0)
		{
			if (id_isOnline_Landroid_content_Context_ == IntPtr.Zero)
				id_isOnline_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isOnline", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isOnline_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
