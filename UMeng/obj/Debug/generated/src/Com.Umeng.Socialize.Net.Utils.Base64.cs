using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Net.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='Base64']"
	[global::Android.Runtime.Register ("com/umeng/socialize/net/utils/Base64", DoNotGenerateAcw=true)]
	public partial class Base64 : global::Com.Umeng.Socialize.Net.Utils.BaseNCodec {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/net/utils/Base64", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Base64); }
		}

		protected Base64 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IarrayBZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='Base64']/constructor[@name='Base64' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(I[BZ)V", "")]
		public unsafe Base64 (int p0, byte[] p1, bool p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (Base64)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I[BZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I[BZ)V", __args);
					return;
				}

				if (id_ctor_IarrayBZ == IntPtr.Zero)
					id_ctor_IarrayBZ = JNIEnv.GetMethodID (class_ref, "<init>", "(I[BZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IarrayBZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IarrayBZ, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_ctor_IarrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='Base64']/constructor[@name='Base64' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(I[B)V", "")]
		public unsafe Base64 (int p0, byte[] p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (Base64)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I[B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I[B)V", __args);
					return;
				}

				if (id_ctor_IarrayB == IntPtr.Zero)
					id_ctor_IarrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(I[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IarrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IarrayB, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='Base64']/constructor[@name='Base64' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe Base64 (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Base64)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='Base64']/constructor[@name='Base64' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register (".ctor", "(Z)V", "")]
		public unsafe Base64 (bool p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Base64)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Z)V", __args);
					return;
				}

				if (id_ctor_Z == IntPtr.Zero)
					id_ctor_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Z, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='Base64']/constructor[@name='Base64' and count(parameter)=0]"
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

		static IntPtr id_decodeBase64_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='Base64']/method[@name='decodeBase64' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decodeBase64", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] DecodeBase64 (string p0)
		{
			if (id_decodeBase64_Ljava_lang_String_ == IntPtr.Zero)
				id_decodeBase64_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "decodeBase64", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decodeBase64_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_encodeBase64_arrayBZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='Base64']/method[@name='encodeBase64' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='boolean']]"
		[Register ("encodeBase64", "([BZ)[B", "")]
		public static unsafe byte[] EncodeBase64 (byte[] p0, bool p1)
		{
			if (id_encodeBase64_arrayBZ == IntPtr.Zero)
				id_encodeBase64_arrayBZ = JNIEnv.GetStaticMethodID (class_ref, "encodeBase64", "([BZ)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeBase64_arrayBZ, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_encodeBase64_arrayBZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='Base64']/method[@name='encodeBase64' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("encodeBase64", "([BZZ)[B", "")]
		public static unsafe byte[] EncodeBase64 (byte[] p0, bool p1, bool p2)
		{
			if (id_encodeBase64_arrayBZZ == IntPtr.Zero)
				id_encodeBase64_arrayBZZ = JNIEnv.GetStaticMethodID (class_ref, "encodeBase64", "([BZZ)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeBase64_arrayBZZ, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_encodeBase64_arrayBZZI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='Base64']/method[@name='encodeBase64' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='int']]"
		[Register ("encodeBase64", "([BZZI)[B", "")]
		public static unsafe byte[] EncodeBase64 (byte[] p0, bool p1, bool p2, int p3)
		{
			if (id_encodeBase64_arrayBZZI == IntPtr.Zero)
				id_encodeBase64_arrayBZZI = JNIEnv.GetStaticMethodID (class_ref, "encodeBase64", "([BZZI)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeBase64_arrayBZZI, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_encodeBase64String_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='Base64']/method[@name='encodeBase64String' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encodeBase64String", "([B)Ljava/lang/String;", "")]
		public static unsafe string EncodeBase64String (byte[] p0)
		{
			if (id_encodeBase64String_arrayB == IntPtr.Zero)
				id_encodeBase64String_arrayB = JNIEnv.GetStaticMethodID (class_ref, "encodeBase64String", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeBase64String_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_isInAlphabet_B;
#pragma warning disable 0169
		static Delegate GetIsInAlphabet_BHandler ()
		{
			if (cb_isInAlphabet_B == null)
				cb_isInAlphabet_B = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte, bool>) n_IsInAlphabet_B);
			return cb_isInAlphabet_B;
		}

		static bool n_IsInAlphabet_B (IntPtr jnienv, IntPtr native__this, sbyte p0)
		{
			global::Com.Umeng.Socialize.Net.Utils.Base64 __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.Base64> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInAlphabet (p0);
		}
#pragma warning restore 0169

		static IntPtr id_isInAlphabet_B;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='Base64']/method[@name='isInAlphabet' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("isInAlphabet", "(B)Z", "GetIsInAlphabet_BHandler")]
		protected override unsafe bool IsInAlphabet (sbyte p0)
		{
			if (id_isInAlphabet_B == IntPtr.Zero)
				id_isInAlphabet_B = JNIEnv.GetMethodID (class_ref, "isInAlphabet", "(B)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInAlphabet_B, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInAlphabet", "(B)Z"), __args);
			} finally {
			}
		}

	}
}
