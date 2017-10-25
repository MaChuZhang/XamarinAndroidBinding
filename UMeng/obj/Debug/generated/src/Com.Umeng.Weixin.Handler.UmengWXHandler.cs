using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Weixin.Handler {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.weixin.handler']/class[@name='UmengWXHandler']"
	[global::Android.Runtime.Register ("com/umeng/weixin/handler/UmengWXHandler", DoNotGenerateAcw=true)]
	public partial class UmengWXHandler : global::Com.Umeng.Socialize.Handler.UMSSOHandler {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.weixin.handler']/class[@name='UmengWXHandler']/field[@name='WXSceneFavorite']"
		[Register ("WXSceneFavorite")]
		public const int WXSceneFavorite = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.weixin.handler']/class[@name='UmengWXHandler']/field[@name='WXSceneSession']"
		[Register ("WXSceneSession")]
		public const int WXSceneSession = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.weixin.handler']/class[@name='UmengWXHandler']/field[@name='WXSceneTimeline']"
		[Register ("WXSceneTimeline")]
		public const int WXSceneTimeline = (int) 1;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/weixin/handler/UmengWXHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UmengWXHandler); }
		}

		protected UmengWXHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.weixin.handler']/class[@name='UmengWXHandler']/constructor[@name='UmengWXHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UmengWXHandler ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (UmengWXHandler)) {
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

		static Delegate cb_getWXApi;
#pragma warning disable 0169
		static Delegate GetGetWXApiHandler ()
		{
			if (cb_getWXApi == null)
				cb_getWXApi = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWXApi);
			return cb_getWXApi;
		}

		static IntPtr n_GetWXApi (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Weixin.Handler.UmengWXHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Weixin.Handler.UmengWXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WXApi);
		}
#pragma warning restore 0169

		static IntPtr id_getWXApi;
		public virtual unsafe global::Com.Umeng.Weixin.Umengwx.WeChat WXApi {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.weixin.handler']/class[@name='UmengWXHandler']/method[@name='getWXApi' and count(parameter)=0]"
			[Register ("getWXApi", "()Lcom/umeng/weixin/umengwx/WeChat;", "GetGetWXApiHandler")]
			get {
				if (id_getWXApi == IntPtr.Zero)
					id_getWXApi = JNIEnv.GetMethodID (class_ref, "getWXApi", "()Lcom/umeng/weixin/umengwx/WeChat;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Umeng.Weixin.Umengwx.WeChat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWXApi), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Umeng.Weixin.Umengwx.WeChat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWXApi", "()Lcom/umeng/weixin/umengwx/WeChat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getWXAppSupportAPI;
#pragma warning disable 0169
		static Delegate GetGetWXAppSupportAPIHandler ()
		{
			if (cb_getWXAppSupportAPI == null)
				cb_getWXAppSupportAPI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWXAppSupportAPI);
			return cb_getWXAppSupportAPI;
		}

		static int n_GetWXAppSupportAPI (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Weixin.Handler.UmengWXHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Weixin.Handler.UmengWXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WXAppSupportAPI;
		}
#pragma warning restore 0169

		static IntPtr id_getWXAppSupportAPI;
		public virtual unsafe int WXAppSupportAPI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.weixin.handler']/class[@name='UmengWXHandler']/method[@name='getWXAppSupportAPI' and count(parameter)=0]"
			[Register ("getWXAppSupportAPI", "()I", "GetGetWXAppSupportAPIHandler")]
			get {
				if (id_getWXAppSupportAPI == IntPtr.Zero)
					id_getWXAppSupportAPI = JNIEnv.GetMethodID (class_ref, "getWXAppSupportAPI", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWXAppSupportAPI);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWXAppSupportAPI", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_share_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_;
#pragma warning disable 0169
		static Delegate GetShare_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_Handler ()
		{
			if (cb_share_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_ == null)
				cb_share_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Share_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_);
			return cb_share_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_;
		}

		static bool n_Share_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Weixin.Handler.UmengWXHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Weixin.Handler.UmengWXHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.ShareContent p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareContent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.IUMShareListener p1 = (global::Com.Umeng.Socialize.IUMShareListener)global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.IUMShareListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Share (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_share_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.weixin.handler']/class[@name='UmengWXHandler']/method[@name='share' and count(parameter)=2 and parameter[1][@type='com.umeng.socialize.ShareContent'] and parameter[2][@type='com.umeng.socialize.UMShareListener']]"
		[Register ("share", "(Lcom/umeng/socialize/ShareContent;Lcom/umeng/socialize/UMShareListener;)Z", "GetShare_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_Handler")]
		public override unsafe bool Share (global::Com.Umeng.Socialize.ShareContent p0, global::Com.Umeng.Socialize.IUMShareListener p1)
		{
			if (id_share_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_ == IntPtr.Zero)
				id_share_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_ = JNIEnv.GetMethodID (class_ref, "share", "(Lcom/umeng/socialize/ShareContent;Lcom/umeng/socialize/UMShareListener;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_share_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "share", "(Lcom/umeng/socialize/ShareContent;Lcom/umeng/socialize/UMShareListener;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
