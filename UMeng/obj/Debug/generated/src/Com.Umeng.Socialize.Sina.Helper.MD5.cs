using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Sina.Helper {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.sina.helper']/class[@name='MD5']"
	[global::Android.Runtime.Register ("com/umeng/socialize/sina/helper/MD5", DoNotGenerateAcw=true)]
	public partial class MD5 : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/sina/helper/MD5", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MD5); }
		}

		protected MD5 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.sina.helper']/class[@name='MD5']/constructor[@name='MD5' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MD5 ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MD5)) {
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

		static IntPtr id_hexdigest_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.helper']/class[@name='MD5']/method[@name='hexdigest' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("hexdigest", "([B)Ljava/lang/String;", "")]
		public static unsafe string Hexdigest (byte[] p0)
		{
			if (id_hexdigest_arrayB == IntPtr.Zero)
				id_hexdigest_arrayB = JNIEnv.GetStaticMethodID (class_ref, "hexdigest", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_hexdigest_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_hexdigest_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.helper']/class[@name='MD5']/method[@name='hexdigest' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hexdigest", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Hexdigest (string p0)
		{
			if (id_hexdigest_Ljava_lang_String_ == IntPtr.Zero)
				id_hexdigest_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "hexdigest", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_hexdigest_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_main_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.helper']/class[@name='MD5']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("main", "([Ljava/lang/String;)V", "")]
		public static unsafe void Main (string[] p0)
		{
			if (id_main_arrayLjava_lang_String_ == IntPtr.Zero)
				id_main_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "main", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_main_arrayLjava_lang_String_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
