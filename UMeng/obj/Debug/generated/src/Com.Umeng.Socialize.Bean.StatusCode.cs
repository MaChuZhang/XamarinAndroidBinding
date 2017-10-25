using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Bean {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='StatusCode']"
	[global::Android.Runtime.Register ("com/umeng/socialize/bean/StatusCode", DoNotGenerateAcw=true)]
	public partial class StatusCode : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='StatusCode']/field[@name='ST_CODE_SDK_NORESPONSE']"
		[Register ("ST_CODE_SDK_NORESPONSE")]
		public const int StCodeSdkNoresponse = (int) -103;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='StatusCode']/field[@name='ST_CODE_SUCCESSED']"
		[Register ("ST_CODE_SUCCESSED")]
		public const int StCodeSuccessed = (int) 200;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/bean/StatusCode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StatusCode); }
		}

		protected StatusCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='StatusCode']/constructor[@name='StatusCode' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StatusCode ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (StatusCode)) {
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

	}
}
