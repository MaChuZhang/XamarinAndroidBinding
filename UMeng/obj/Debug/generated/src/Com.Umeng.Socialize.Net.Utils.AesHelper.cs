using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Net.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='AesHelper']"
	[global::Android.Runtime.Register ("com/umeng/socialize/net/utils/AesHelper", DoNotGenerateAcw=true)]
	public partial class AesHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/net/utils/AesHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AesHelper); }
		}

		protected AesHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='AesHelper']/constructor[@name='AesHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AesHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AesHelper)) {
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

		static IntPtr id_decryptNoPadding_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='AesHelper']/method[@name='decryptNoPadding' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("decryptNoPadding", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string DecryptNoPadding (string p0, string p1)
		{
			if (id_decryptNoPadding_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_decryptNoPadding_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decryptNoPadding", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_decryptNoPadding_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_encryptNoPadding_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='AesHelper']/method[@name='encryptNoPadding' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("encryptNoPadding", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string EncryptNoPadding (string p0, string p1)
		{
			if (id_encryptNoPadding_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_encryptNoPadding_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "encryptNoPadding", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encryptNoPadding_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getBytesUnchecked_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='AesHelper']/method[@name='getBytesUnchecked' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getBytesUnchecked", "(Ljava/lang/String;Ljava/lang/String;)[B", "")]
		public static unsafe byte[] GetBytesUnchecked (string p0, string p1)
		{
			if (id_getBytesUnchecked_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getBytesUnchecked_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getBytesUnchecked", "(Ljava/lang/String;Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBytesUnchecked_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getBytesUtf8_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='AesHelper']/method[@name='getBytesUtf8' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBytesUtf8", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] GetBytesUtf8 (string p0)
		{
			if (id_getBytesUtf8_Ljava_lang_String_ == IntPtr.Zero)
				id_getBytesUtf8_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getBytesUtf8", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBytesUtf8_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_md5_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='AesHelper']/method[@name='md5' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("md5", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Md5 (string p0)
		{
			if (id_md5_Ljava_lang_String_ == IntPtr.Zero)
				id_md5_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "md5", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_md5_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_newString_arrayBLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='AesHelper']/method[@name='newString' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("newString", "([BLjava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string NewString (byte[] p0, string p1)
		{
			if (id_newString_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_newString_arrayBLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "newString", "([BLjava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_newString_arrayBLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_newStringUtf8_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='AesHelper']/method[@name='newStringUtf8' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("newStringUtf8", "([B)Ljava/lang/String;", "")]
		public static unsafe string NewStringUtf8 (byte[] p0)
		{
			if (id_newStringUtf8_arrayB == IntPtr.Zero)
				id_newStringUtf8_arrayB = JNIEnv.GetStaticMethodID (class_ref, "newStringUtf8", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_newStringUtf8_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_setPassword_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='AesHelper']/method[@name='setPassword' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPassword", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetPassword (string p0)
		{
			if (id_setPassword_Ljava_lang_String_ == IntPtr.Zero)
				id_setPassword_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setPassword", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setPassword_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
