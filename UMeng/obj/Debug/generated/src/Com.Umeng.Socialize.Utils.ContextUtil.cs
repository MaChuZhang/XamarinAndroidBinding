using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='ContextUtil']"
	[global::Android.Runtime.Register ("com/umeng/socialize/utils/ContextUtil", DoNotGenerateAcw=true)]
	public partial class ContextUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/utils/ContextUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ContextUtil); }
		}

		protected ContextUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='ContextUtil']/constructor[@name='ContextUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ContextUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ContextUtil)) {
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

		static IntPtr id_getContext;
		static IntPtr id_setContext_Landroid_content_Context_;
		public static unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='ContextUtil']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get {
				if (id_getContext == IntPtr.Zero)
					id_getContext = JNIEnv.GetStaticMethodID (class_ref, "getContext", "()Landroid/content/Context;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getContext), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='ContextUtil']/method[@name='setContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register ("setContext", "(Landroid/content/Context;)V", "GetSetContext_Landroid_content_Context_Handler")]
			set {
				if (id_setContext_Landroid_content_Context_ == IntPtr.Zero)
					id_setContext_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "setContext", "(Landroid/content/Context;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setContext_Landroid_content_Context_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getPackageName;
		public static unsafe string PackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='ContextUtil']/method[@name='getPackageName' and count(parameter)=0]"
			[Register ("getPackageName", "()Ljava/lang/String;", "GetGetPackageNameHandler")]
			get {
				if (id_getPackageName == IntPtr.Zero)
					id_getPackageName = JNIEnv.GetStaticMethodID (class_ref, "getPackageName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPackageName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
