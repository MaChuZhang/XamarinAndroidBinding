using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Media {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SinaShareContent']"
	[global::Android.Runtime.Register ("com/umeng/socialize/media/SinaShareContent", DoNotGenerateAcw=true)]
	public partial class SinaShareContent : global::Com.Umeng.Socialize.Media.SimpleShareContent {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/media/SinaShareContent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SinaShareContent); }
		}

		protected SinaShareContent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_umeng_socialize_ShareContent_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SinaShareContent']/constructor[@name='SinaShareContent' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.ShareContent']]"
		[Register (".ctor", "(Lcom/umeng/socialize/ShareContent;)V", "")]
		public unsafe SinaShareContent (global::Com.Umeng.Socialize.ShareContent p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (SinaShareContent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/umeng/socialize/ShareContent;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/umeng/socialize/ShareContent;)V", __args);
					return;
				}

				if (id_ctor_Lcom_umeng_socialize_ShareContent_ == IntPtr.Zero)
					id_ctor_Lcom_umeng_socialize_ShareContent_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/umeng/socialize/ShareContent;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_umeng_socialize_ShareContent_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_umeng_socialize_ShareContent_, __args);
			} finally {
			}
		}

		static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_A);
			return cb_a;
		}

		static IntPtr n_A (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Media.SinaShareContent __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.SinaShareContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.A ());
		}
#pragma warning restore 0169

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.media']/class[@name='SinaShareContent']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Lcom/sina/weibo/sdk/api/WeiboMultiMessage;", "GetAHandler")]
		public virtual unsafe global::Com.Sina.Weibo.Sdk.Api.WeiboMultiMessage A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()Lcom/sina/weibo/sdk/api/WeiboMultiMessage;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Sina.Weibo.Sdk.Api.WeiboMultiMessage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_a), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Sina.Weibo.Sdk.Api.WeiboMultiMessage> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "()Lcom/sina/weibo/sdk/api/WeiboMultiMessage;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
