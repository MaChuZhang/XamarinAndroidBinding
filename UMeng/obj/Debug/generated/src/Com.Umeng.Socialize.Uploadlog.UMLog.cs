using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Uploadlog {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.uploadlog']/class[@name='UMLog']"
	[global::Android.Runtime.Register ("com/umeng/socialize/uploadlog/UMLog", DoNotGenerateAcw=true)]
	public partial class UMLog : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/uploadlog/UMLog", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UMLog); }
		}

		protected UMLog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.uploadlog']/class[@name='UMLog']/constructor[@name='UMLog' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UMLog ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (UMLog)) {
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

		static IntPtr id_isOpenShareEdit;
		static IntPtr id_setIsOpenShareEdit_Z;
		public static unsafe bool IsOpenShareEdit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.uploadlog']/class[@name='UMLog']/method[@name='isOpenShareEdit' and count(parameter)=0]"
			[Register ("isOpenShareEdit", "()Z", "GetIsOpenShareEditHandler")]
			get {
				if (id_isOpenShareEdit == IntPtr.Zero)
					id_isOpenShareEdit = JNIEnv.GetStaticMethodID (class_ref, "isOpenShareEdit", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isOpenShareEdit);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.uploadlog']/class[@name='UMLog']/method[@name='setIsOpenShareEdit' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIsOpenShareEdit", "(Z)V", "GetSetIsOpenShareEdit_ZHandler")]
			set {
				if (id_setIsOpenShareEdit_Z == IntPtr.Zero)
					id_setIsOpenShareEdit_Z = JNIEnv.GetStaticMethodID (class_ref, "setIsOpenShareEdit", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setIsOpenShareEdit_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getShareAndAuth;
		public static unsafe global::Android.OS.Bundle ShareAndAuth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.uploadlog']/class[@name='UMLog']/method[@name='getShareAndAuth' and count(parameter)=0]"
			[Register ("getShareAndAuth", "()Landroid/os/Bundle;", "GetGetShareAndAuthHandler")]
			get {
				if (id_getShareAndAuth == IntPtr.Zero)
					id_getShareAndAuth = JNIEnv.GetStaticMethodID (class_ref, "getShareAndAuth", "()Landroid/os/Bundle;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getShareAndAuth), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_putAuth;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.uploadlog']/class[@name='UMLog']/method[@name='putAuth' and count(parameter)=0]"
		[Register ("putAuth", "()V", "")]
		public static unsafe void PutAuth ()
		{
			if (id_putAuth == IntPtr.Zero)
				id_putAuth = JNIEnv.GetStaticMethodID (class_ref, "putAuth", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_putAuth);
			} finally {
			}
		}

		static IntPtr id_putShare;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.uploadlog']/class[@name='UMLog']/method[@name='putShare' and count(parameter)=0]"
		[Register ("putShare", "()V", "")]
		public static unsafe void PutShare ()
		{
			if (id_putShare == IntPtr.Zero)
				id_putShare = JNIEnv.GetStaticMethodID (class_ref, "putShare", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_putShare);
			} finally {
			}
		}

	}
}
