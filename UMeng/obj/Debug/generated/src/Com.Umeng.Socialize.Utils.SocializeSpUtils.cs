using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeSpUtils']"
	[global::Android.Runtime.Register ("com/umeng/socialize/utils/SocializeSpUtils", DoNotGenerateAcw=true)]
	public partial class SocializeSpUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/utils/SocializeSpUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SocializeSpUtils); }
		}

		protected SocializeSpUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeSpUtils']/constructor[@name='SocializeSpUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SocializeSpUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SocializeSpUtils)) {
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

		static IntPtr id_getInt_Landroid_content_Context_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeSpUtils']/method[@name='getInt' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("getInt", "(Landroid/content/Context;Ljava/lang/String;I)I", "")]
		public static unsafe int GetInt (global::Android.Content.Context p0, string p1, int p2)
		{
			if (id_getInt_Landroid_content_Context_Ljava_lang_String_I == IntPtr.Zero)
				id_getInt_Landroid_content_Context_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "getInt", "(Landroid/content/Context;Ljava/lang/String;I)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getInt_Landroid_content_Context_Ljava_lang_String_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getMac_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeSpUtils']/method[@name='getMac' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
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

		static IntPtr id_getShareBoardConfig_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeSpUtils']/method[@name='getShareBoardConfig' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getShareBoardConfig", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetShareBoardConfig (global::Android.Content.Context p0)
		{
			if (id_getShareBoardConfig_Landroid_content_Context_ == IntPtr.Zero)
				id_getShareBoardConfig_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getShareBoardConfig", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getShareBoardConfig_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getString_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeSpUtils']/method[@name='getString' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getString", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetString (global::Android.Content.Context p0, string p1)
		{
			if (id_getString_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getString_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getString", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getString_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getTime_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeSpUtils']/method[@name='getTime' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getTime", "(Landroid/content/Context;)J", "")]
		public static unsafe long GetTime (global::Android.Content.Context p0)
		{
			if (id_getTime_Landroid_content_Context_ == IntPtr.Zero)
				id_getTime_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getTime", "(Landroid/content/Context;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getTime_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getUMEk_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeSpUtils']/method[@name='getUMEk' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getUMEk", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetUMEk (global::Android.Content.Context p0)
		{
			if (id_getUMEk_Landroid_content_Context_ == IntPtr.Zero)
				id_getUMEk_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getUMEk", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUMEk_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getUMId_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeSpUtils']/method[@name='getUMId' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getUMId", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetUMId (global::Android.Content.Context p0)
		{
			if (id_getUMId_Landroid_content_Context_ == IntPtr.Zero)
				id_getUMId_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getUMId", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUMId_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_putInt_Landroid_content_Context_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeSpUtils']/method[@name='putInt' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("putInt", "(Landroid/content/Context;Ljava/lang/String;I)V", "")]
		public static unsafe void PutInt (global::Android.Content.Context p0, string p1, int p2)
		{
			if (id_putInt_Landroid_content_Context_Ljava_lang_String_I == IntPtr.Zero)
				id_putInt_Landroid_content_Context_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "putInt", "(Landroid/content/Context;Ljava/lang/String;I)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_putInt_Landroid_content_Context_Ljava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_putMac_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeSpUtils']/method[@name='putMac' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("putMac", "(Landroid/content/Context;Ljava/lang/String;)Z", "")]
		public static unsafe bool PutMac (global::Android.Content.Context p0, string p1)
		{
			if (id_putMac_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_putMac_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "putMac", "(Landroid/content/Context;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_putMac_Landroid_content_Context_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_putShareBoardConfig_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeSpUtils']/method[@name='putShareBoardConfig' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("putShareBoardConfig", "(Landroid/content/Context;Ljava/lang/String;)Z", "")]
		public static unsafe bool PutShareBoardConfig (global::Android.Content.Context p0, string p1)
		{
			if (id_putShareBoardConfig_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_putShareBoardConfig_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "putShareBoardConfig", "(Landroid/content/Context;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_putShareBoardConfig_Landroid_content_Context_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_putString_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeSpUtils']/method[@name='putString' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("putString", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void PutString (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_putString_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_putString_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "putString", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_putString_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_putTime_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeSpUtils']/method[@name='putTime' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("putTime", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool PutTime (global::Android.Content.Context p0)
		{
			if (id_putTime_Landroid_content_Context_ == IntPtr.Zero)
				id_putTime_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "putTime", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_putTime_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_putUMEk_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeSpUtils']/method[@name='putUMEk' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("putUMEk", "(Landroid/content/Context;Ljava/lang/String;)Z", "")]
		public static unsafe bool PutUMEk (global::Android.Content.Context p0, string p1)
		{
			if (id_putUMEk_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_putUMEk_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "putUMEk", "(Landroid/content/Context;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_putUMEk_Landroid_content_Context_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_putUMId_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeSpUtils']/method[@name='putUMId' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("putUMId", "(Landroid/content/Context;Ljava/lang/String;)Z", "")]
		public static unsafe bool PutUMId (global::Android.Content.Context p0, string p1)
		{
			if (id_putUMId_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_putUMId_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "putUMId", "(Landroid/content/Context;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_putUMId_Landroid_content_Context_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_remove_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='SocializeSpUtils']/method[@name='remove' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("remove", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void Remove (global::Android.Content.Context p0, string p1)
		{
			if (id_remove_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_remove_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "remove", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_remove_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
