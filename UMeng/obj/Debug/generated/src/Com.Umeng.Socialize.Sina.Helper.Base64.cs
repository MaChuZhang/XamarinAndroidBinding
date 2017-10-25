using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Sina.Helper {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.sina.helper']/class[@name='Base64']"
	[global::Android.Runtime.Register ("com/umeng/socialize/sina/helper/Base64", DoNotGenerateAcw=true)]
	public sealed partial class Base64 : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/sina/helper/Base64", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Base64); }
		}

		internal Base64 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.sina.helper']/class[@name='Base64']/constructor[@name='Base64' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Base64 ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Base64)) {
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

		static IntPtr id_decode_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.helper']/class[@name='Base64']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("decode", "([B)[B", "")]
		public static unsafe byte[] Decode (byte[] p0)
		{
			if (id_decode_arrayB == IntPtr.Zero)
				id_decode_arrayB = JNIEnv.GetStaticMethodID (class_ref, "decode", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decode_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_encode_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.helper']/class[@name='Base64']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encode", "([B)[C", "")]
		public static unsafe char[] Encode (byte[] p0)
		{
			if (id_encode_arrayB == IntPtr.Zero)
				id_encode_arrayB = JNIEnv.GetStaticMethodID (class_ref, "encode", "([B)[C");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				char[] __ret = (char[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encode_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (char));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_encodebyte_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.helper']/class[@name='Base64']/method[@name='encodebyte' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encodebyte", "([B)[B", "")]
		public static unsafe byte[] Encodebyte (byte[] p0)
		{
			if (id_encodebyte_arrayB == IntPtr.Zero)
				id_encodebyte_arrayB = JNIEnv.GetStaticMethodID (class_ref, "encodebyte", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodebyte_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
