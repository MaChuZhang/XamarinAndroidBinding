using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize']/class[@name='SocializeException']"
	[global::Android.Runtime.Register ("com/umeng/socialize/SocializeException", DoNotGenerateAcw=true)]
	public partial class SocializeException : global::Java.Lang.RuntimeException {


		static IntPtr a_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='SocializeException']/field[@name='a']"
		[Register ("a")]
		protected int A {
			get {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Throwable) this).Handle, a_jfieldId);
			}
			set {
				if (a_jfieldId == IntPtr.Zero)
					a_jfieldId = JNIEnv.GetFieldID (class_ref, "a", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Throwable) this).Handle, a_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/SocializeException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SocializeException); }
		}

		protected SocializeException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize']/class[@name='SocializeException']/constructor[@name='SocializeException' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe SocializeException (string p0, global::Java.Lang.Throwable p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (SocializeException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/Throwable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Ljava/lang/String;Ljava/lang/Throwable;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Throwable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_ILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize']/class[@name='SocializeException']/constructor[@name='SocializeException' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(ILjava/lang/String;)V", "")]
		public unsafe SocializeException (int p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (SocializeException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(ILjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_ILjava_lang_String_ == IntPtr.Zero)
					id_ctor_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize']/class[@name='SocializeException']/constructor[@name='SocializeException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe SocializeException (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (SocializeException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getErrorCode;
#pragma warning disable 0169
		static Delegate GetGetErrorCodeHandler ()
		{
			if (cb_getErrorCode == null)
				cb_getErrorCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetErrorCode);
			return cb_getErrorCode;
		}

		static int n_GetErrorCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.SocializeException __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.SocializeException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ErrorCode;
		}
#pragma warning restore 0169

		static IntPtr id_getErrorCode;
		public virtual unsafe int ErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='SocializeException']/method[@name='getErrorCode' and count(parameter)=0]"
			[Register ("getErrorCode", "()I", "GetGetErrorCodeHandler")]
			get {
				if (id_getErrorCode == IntPtr.Zero)
					id_getErrorCode = JNIEnv.GetMethodID (class_ref, "getErrorCode", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Throwable) this).Handle, id_getErrorCode);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrorCode", "()I"));
				} finally {
				}
			}
		}

	}
}
