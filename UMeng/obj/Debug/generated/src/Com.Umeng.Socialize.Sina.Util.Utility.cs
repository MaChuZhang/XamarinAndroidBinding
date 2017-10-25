using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Sina.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.sina.util']/class[@name='Utility']"
	[global::Android.Runtime.Register ("com/umeng/socialize/sina/util/Utility", DoNotGenerateAcw=true)]
	public partial class Utility : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/sina/util/Utility", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Utility); }
		}

		protected Utility (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.sina.util']/class[@name='Utility']/constructor[@name='Utility' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Utility ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Utility)) {
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

		static IntPtr id_generateGUID;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.util']/class[@name='Utility']/method[@name='generateGUID' and count(parameter)=0]"
		[Register ("generateGUID", "()Ljava/lang/String;", "")]
		public static unsafe string GenerateGUID ()
		{
			if (id_generateGUID == IntPtr.Zero)
				id_generateGUID = JNIEnv.GetStaticMethodID (class_ref, "generateGUID", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_generateGUID), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_generateUA_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.util']/class[@name='Utility']/method[@name='generateUA' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("generateUA", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GenerateUA (global::Android.Content.Context p0)
		{
			if (id_generateUA_Landroid_content_Context_ == IntPtr.Zero)
				id_generateUA_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "generateUA", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_generateUA_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getAid_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.util']/class[@name='Utility']/method[@name='getAid' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getAid", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetAid (global::Android.Content.Context p0, string p1)
		{
			if (id_getAid_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getAid_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getAid", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAid_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getSign_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.util']/class[@name='Utility']/method[@name='getSign' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getSign", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetSign (global::Android.Content.Context p0, string p1)
		{
			if (id_getSign_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getSign_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getSign", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSign_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
