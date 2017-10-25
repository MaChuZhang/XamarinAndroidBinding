using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Net {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.net']/class[@name='LinkcardRequest']"
	[global::Android.Runtime.Register ("com/umeng/socialize/net/LinkcardRequest", DoNotGenerateAcw=true)]
	public partial class LinkcardRequest : global::Com.Umeng.Socialize.Net.Base.SocializeRequest {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/net/LinkcardRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LinkcardRequest); }
		}

		protected LinkcardRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.net']/class[@name='LinkcardRequest']/constructor[@name='LinkcardRequest' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe LinkcardRequest (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (LinkcardRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getPath;
#pragma warning disable 0169
		static Delegate GetGetPathHandler ()
		{
			if (cb_getPath == null)
				cb_getPath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPath);
			return cb_getPath;
		}

		static IntPtr n_GetPath (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Net.LinkcardRequest __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.LinkcardRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Path);
		}
#pragma warning restore 0169

		static IntPtr id_getPath;
		protected override unsafe string Path {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net']/class[@name='LinkcardRequest']/method[@name='getPath' and count(parameter)=0]"
			[Register ("getPath", "()Ljava/lang/String;", "GetGetPathHandler")]
			get {
				if (id_getPath == IntPtr.Zero)
					id_getPath = JNIEnv.GetMethodID (class_ref, "getPath", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPath), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPath", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setMedia_Lcom_umeng_socialize_media_BaseMediaObject_;
#pragma warning disable 0169
		static Delegate GetSetMedia_Lcom_umeng_socialize_media_BaseMediaObject_Handler ()
		{
			if (cb_setMedia_Lcom_umeng_socialize_media_BaseMediaObject_ == null)
				cb_setMedia_Lcom_umeng_socialize_media_BaseMediaObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMedia_Lcom_umeng_socialize_media_BaseMediaObject_);
			return cb_setMedia_Lcom_umeng_socialize_media_BaseMediaObject_;
		}

		static void n_SetMedia_Lcom_umeng_socialize_media_BaseMediaObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Net.LinkcardRequest __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.LinkcardRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Media.BaseMediaObject p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.BaseMediaObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMedia (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMedia_Lcom_umeng_socialize_media_BaseMediaObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net']/class[@name='LinkcardRequest']/method[@name='setMedia' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.media.BaseMediaObject']]"
		[Register ("setMedia", "(Lcom/umeng/socialize/media/BaseMediaObject;)V", "GetSetMedia_Lcom_umeng_socialize_media_BaseMediaObject_Handler")]
		public virtual unsafe void SetMedia (global::Com.Umeng.Socialize.Media.BaseMediaObject p0)
		{
			if (id_setMedia_Lcom_umeng_socialize_media_BaseMediaObject_ == IntPtr.Zero)
				id_setMedia_Lcom_umeng_socialize_media_BaseMediaObject_ = JNIEnv.GetMethodID (class_ref, "setMedia", "(Lcom/umeng/socialize/media/BaseMediaObject;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMedia_Lcom_umeng_socialize_media_BaseMediaObject_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMedia", "(Lcom/umeng/socialize/media/BaseMediaObject;)V"), __args);
			} finally {
			}
		}

	}
}
