using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Sina {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.sina']/class[@name='SinaAPI']"
	[global::Android.Runtime.Register ("com/umeng/socialize/sina/SinaAPI", DoNotGenerateAcw=true)]
	public partial class SinaAPI : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/sina/SinaAPI", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SinaAPI); }
		}

		protected SinaAPI (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.sina']/class[@name='SinaAPI']/constructor[@name='SinaAPI' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Z)V", "")]
		public unsafe SinaAPI (global::Android.Content.Context p0, string p1, bool p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (SinaAPI)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/lang/String;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/lang/String;Z)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_Z == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_doResultIntent_Landroid_content_Intent_Lcom_sina_weibo_sdk_share_WbShareCallback_;
#pragma warning disable 0169
		static Delegate GetDoResultIntent_Landroid_content_Intent_Lcom_sina_weibo_sdk_share_WbShareCallback_Handler ()
		{
			if (cb_doResultIntent_Landroid_content_Intent_Lcom_sina_weibo_sdk_share_WbShareCallback_ == null)
				cb_doResultIntent_Landroid_content_Intent_Lcom_sina_weibo_sdk_share_WbShareCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoResultIntent_Landroid_content_Intent_Lcom_sina_weibo_sdk_share_WbShareCallback_);
			return cb_doResultIntent_Landroid_content_Intent_Lcom_sina_weibo_sdk_share_WbShareCallback_;
		}

		static void n_DoResultIntent_Landroid_content_Intent_Lcom_sina_weibo_sdk_share_WbShareCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Socialize.Sina.SinaAPI __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.SinaAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Sina.Weibo.Sdk.Share.IWbShareCallback p1 = (global::Com.Sina.Weibo.Sdk.Share.IWbShareCallback)global::Java.Lang.Object.GetObject<global::Com.Sina.Weibo.Sdk.Share.IWbShareCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DoResultIntent (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_doResultIntent_Landroid_content_Intent_Lcom_sina_weibo_sdk_share_WbShareCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina']/class[@name='SinaAPI']/method[@name='doResultIntent' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.sina.weibo.sdk.share.WbShareCallback']]"
		[Register ("doResultIntent", "(Landroid/content/Intent;Lcom/sina/weibo/sdk/share/WbShareCallback;)V", "GetDoResultIntent_Landroid_content_Intent_Lcom_sina_weibo_sdk_share_WbShareCallback_Handler")]
		public virtual unsafe void DoResultIntent (global::Android.Content.Intent p0, global::Com.Sina.Weibo.Sdk.Share.IWbShareCallback p1)
		{
			if (id_doResultIntent_Landroid_content_Intent_Lcom_sina_weibo_sdk_share_WbShareCallback_ == IntPtr.Zero)
				id_doResultIntent_Landroid_content_Intent_Lcom_sina_weibo_sdk_share_WbShareCallback_ = JNIEnv.GetMethodID (class_ref, "doResultIntent", "(Landroid/content/Intent;Lcom/sina/weibo/sdk/share/WbShareCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_doResultIntent_Landroid_content_Intent_Lcom_sina_weibo_sdk_share_WbShareCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doResultIntent", "(Landroid/content/Intent;Lcom/sina/weibo/sdk/share/WbShareCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_handleWeiboResponse_Landroid_content_Intent_Lcom_umeng_socialize_media_IWeiboHandler_Response_;
#pragma warning disable 0169
		static Delegate GetHandleWeiboResponse_Landroid_content_Intent_Lcom_umeng_socialize_media_IWeiboHandler_Response_Handler ()
		{
			if (cb_handleWeiboResponse_Landroid_content_Intent_Lcom_umeng_socialize_media_IWeiboHandler_Response_ == null)
				cb_handleWeiboResponse_Landroid_content_Intent_Lcom_umeng_socialize_media_IWeiboHandler_Response_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_HandleWeiboResponse_Landroid_content_Intent_Lcom_umeng_socialize_media_IWeiboHandler_Response_);
			return cb_handleWeiboResponse_Landroid_content_Intent_Lcom_umeng_socialize_media_IWeiboHandler_Response_;
		}

		static bool n_HandleWeiboResponse_Landroid_content_Intent_Lcom_umeng_socialize_media_IWeiboHandler_Response_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Socialize.Sina.SinaAPI __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.SinaAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Media.IWeiboHandlerResponse p1 = (global::Com.Umeng.Socialize.Media.IWeiboHandlerResponse)global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.IWeiboHandlerResponse> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HandleWeiboResponse (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_handleWeiboResponse_Landroid_content_Intent_Lcom_umeng_socialize_media_IWeiboHandler_Response_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina']/class[@name='SinaAPI']/method[@name='handleWeiboResponse' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='com.umeng.socialize.media.IWeiboHandler.Response']]"
		[Register ("handleWeiboResponse", "(Landroid/content/Intent;Lcom/umeng/socialize/media/IWeiboHandler$Response;)Z", "GetHandleWeiboResponse_Landroid_content_Intent_Lcom_umeng_socialize_media_IWeiboHandler_Response_Handler")]
		public virtual unsafe bool HandleWeiboResponse (global::Android.Content.Intent p0, global::Com.Umeng.Socialize.Media.IWeiboHandlerResponse p1)
		{
			if (id_handleWeiboResponse_Landroid_content_Intent_Lcom_umeng_socialize_media_IWeiboHandler_Response_ == IntPtr.Zero)
				id_handleWeiboResponse_Landroid_content_Intent_Lcom_umeng_socialize_media_IWeiboHandler_Response_ = JNIEnv.GetMethodID (class_ref, "handleWeiboResponse", "(Landroid/content/Intent;Lcom/umeng/socialize/media/IWeiboHandler$Response;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_handleWeiboResponse_Landroid_content_Intent_Lcom_umeng_socialize_media_IWeiboHandler_Response_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleWeiboResponse", "(Landroid/content/Intent;Lcom/umeng/socialize/media/IWeiboHandler$Response;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_launchWeiboActivity_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetLaunchWeiboActivity_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_launchWeiboActivity_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == null)
				cb_launchWeiboActivity_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_LaunchWeiboActivity_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_);
			return cb_launchWeiboActivity_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		}

		static bool n_LaunchWeiboActivity_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Umeng.Socialize.Sina.SinaAPI __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.SinaAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p4 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p4, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.LaunchWeiboActivity (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_launchWeiboActivity_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina']/class[@name='SinaAPI']/method[@name='launchWeiboActivity' and count(parameter)=5 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='android.os.Bundle']]"
		[Register ("launchWeiboActivity", "(Landroid/app/Activity;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Z", "GetLaunchWeiboActivity_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public virtual unsafe bool LaunchWeiboActivity (global::Android.App.Activity p0, string p1, string p2, string p3, global::Android.OS.Bundle p4)
		{
			if (id_launchWeiboActivity_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_launchWeiboActivity_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "launchWeiboActivity", "(Landroid/app/Activity;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_launchWeiboActivity_Landroid_app_Activity_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_os_Bundle_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "launchWeiboActivity", "(Landroid/app/Activity;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/os/Bundle;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_registerApp;
#pragma warning disable 0169
		static Delegate GetRegisterAppHandler ()
		{
			if (cb_registerApp == null)
				cb_registerApp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_RegisterApp);
			return cb_registerApp;
		}

		static bool n_RegisterApp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Sina.SinaAPI __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.SinaAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RegisterApp ();
		}
#pragma warning restore 0169

		static IntPtr id_registerApp;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina']/class[@name='SinaAPI']/method[@name='registerApp' and count(parameter)=0]"
		[Register ("registerApp", "()Z", "GetRegisterAppHandler")]
		public virtual unsafe bool RegisterApp ()
		{
			if (id_registerApp == IntPtr.Zero)
				id_registerApp = JNIEnv.GetMethodID (class_ref, "registerApp", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_registerApp);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerApp", "()Z"));
			} finally {
			}
		}

		static Delegate cb_sendRequest_Landroid_app_Activity_Lcom_umeng_socialize_sina_message_BaseRequest_Lcom_umeng_socialize_sina_auth_AuthInfo_Ljava_lang_String_Lcom_umeng_socialize_UMShareListener_Z;
#pragma warning disable 0169
		static Delegate GetSendRequest_Landroid_app_Activity_Lcom_umeng_socialize_sina_message_BaseRequest_Lcom_umeng_socialize_sina_auth_AuthInfo_Ljava_lang_String_Lcom_umeng_socialize_UMShareListener_ZHandler ()
		{
			if (cb_sendRequest_Landroid_app_Activity_Lcom_umeng_socialize_sina_message_BaseRequest_Lcom_umeng_socialize_sina_auth_AuthInfo_Ljava_lang_String_Lcom_umeng_socialize_UMShareListener_Z == null)
				cb_sendRequest_Landroid_app_Activity_Lcom_umeng_socialize_sina_message_BaseRequest_Lcom_umeng_socialize_sina_auth_AuthInfo_Ljava_lang_String_Lcom_umeng_socialize_UMShareListener_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, bool>) n_SendRequest_Landroid_app_Activity_Lcom_umeng_socialize_sina_message_BaseRequest_Lcom_umeng_socialize_sina_auth_AuthInfo_Ljava_lang_String_Lcom_umeng_socialize_UMShareListener_Z);
			return cb_sendRequest_Landroid_app_Activity_Lcom_umeng_socialize_sina_message_BaseRequest_Lcom_umeng_socialize_sina_auth_AuthInfo_Ljava_lang_String_Lcom_umeng_socialize_UMShareListener_Z;
		}

		static bool n_SendRequest_Landroid_app_Activity_Lcom_umeng_socialize_sina_message_BaseRequest_Lcom_umeng_socialize_sina_auth_AuthInfo_Ljava_lang_String_Lcom_umeng_socialize_UMShareListener_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, bool p5)
		{
			global::Com.Umeng.Socialize.Sina.SinaAPI __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.SinaAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Sina.Message.BaseRequest p1 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Message.BaseRequest> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Sina.Auth.AuthInfo p2 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Auth.AuthInfo> (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.IUMShareListener p4 = (global::Com.Umeng.Socialize.IUMShareListener)global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.IUMShareListener> (native_p4, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SendRequest (p0, p1, p2, p3, p4, p5);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sendRequest_Landroid_app_Activity_Lcom_umeng_socialize_sina_message_BaseRequest_Lcom_umeng_socialize_sina_auth_AuthInfo_Ljava_lang_String_Lcom_umeng_socialize_UMShareListener_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina']/class[@name='SinaAPI']/method[@name='sendRequest' and count(parameter)=6 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.umeng.socialize.sina.message.BaseRequest'] and parameter[3][@type='com.umeng.socialize.sina.auth.AuthInfo'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.umeng.socialize.UMShareListener'] and parameter[6][@type='boolean']]"
		[Register ("sendRequest", "(Landroid/app/Activity;Lcom/umeng/socialize/sina/message/BaseRequest;Lcom/umeng/socialize/sina/auth/AuthInfo;Ljava/lang/String;Lcom/umeng/socialize/UMShareListener;Z)Z", "GetSendRequest_Landroid_app_Activity_Lcom_umeng_socialize_sina_message_BaseRequest_Lcom_umeng_socialize_sina_auth_AuthInfo_Ljava_lang_String_Lcom_umeng_socialize_UMShareListener_ZHandler")]
		public virtual unsafe bool SendRequest (global::Android.App.Activity p0, global::Com.Umeng.Socialize.Sina.Message.BaseRequest p1, global::Com.Umeng.Socialize.Sina.Auth.AuthInfo p2, string p3, global::Com.Umeng.Socialize.IUMShareListener p4, bool p5)
		{
			if (id_sendRequest_Landroid_app_Activity_Lcom_umeng_socialize_sina_message_BaseRequest_Lcom_umeng_socialize_sina_auth_AuthInfo_Ljava_lang_String_Lcom_umeng_socialize_UMShareListener_Z == IntPtr.Zero)
				id_sendRequest_Landroid_app_Activity_Lcom_umeng_socialize_sina_message_BaseRequest_Lcom_umeng_socialize_sina_auth_AuthInfo_Ljava_lang_String_Lcom_umeng_socialize_UMShareListener_Z = JNIEnv.GetMethodID (class_ref, "sendRequest", "(Landroid/app/Activity;Lcom/umeng/socialize/sina/message/BaseRequest;Lcom/umeng/socialize/sina/auth/AuthInfo;Ljava/lang/String;Lcom/umeng/socialize/UMShareListener;Z)Z");
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_sendRequest_Landroid_app_Activity_Lcom_umeng_socialize_sina_message_BaseRequest_Lcom_umeng_socialize_sina_auth_AuthInfo_Ljava_lang_String_Lcom_umeng_socialize_UMShareListener_Z, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendRequest", "(Landroid/app/Activity;Lcom/umeng/socialize/sina/message/BaseRequest;Lcom/umeng/socialize/sina/auth/AuthInfo;Ljava/lang/String;Lcom/umeng/socialize/UMShareListener;Z)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_setPkgName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPkgName_Ljava_lang_String_Handler ()
		{
			if (cb_setPkgName_Ljava_lang_String_ == null)
				cb_setPkgName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPkgName_Ljava_lang_String_);
			return cb_setPkgName_Ljava_lang_String_;
		}

		static void n_SetPkgName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Sina.SinaAPI __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.SinaAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPkgName (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPkgName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina']/class[@name='SinaAPI']/method[@name='setPkgName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPkgName", "(Ljava/lang/String;)V", "GetSetPkgName_Ljava_lang_String_Handler")]
		public virtual unsafe void SetPkgName (string p0)
		{
			if (id_setPkgName_Ljava_lang_String_ == IntPtr.Zero)
				id_setPkgName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPkgName", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPkgName_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPkgName", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_startClientShare_Lcom_umeng_socialize_media_AppInfo_Landroid_content_Context_Lcom_sina_weibo_sdk_api_WeiboMultiMessage_;
#pragma warning disable 0169
		static Delegate GetStartClientShare_Lcom_umeng_socialize_media_AppInfo_Landroid_content_Context_Lcom_sina_weibo_sdk_api_WeiboMultiMessage_Handler ()
		{
			if (cb_startClientShare_Lcom_umeng_socialize_media_AppInfo_Landroid_content_Context_Lcom_sina_weibo_sdk_api_WeiboMultiMessage_ == null)
				cb_startClientShare_Lcom_umeng_socialize_media_AppInfo_Landroid_content_Context_Lcom_sina_weibo_sdk_api_WeiboMultiMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_StartClientShare_Lcom_umeng_socialize_media_AppInfo_Landroid_content_Context_Lcom_sina_weibo_sdk_api_WeiboMultiMessage_);
			return cb_startClientShare_Lcom_umeng_socialize_media_AppInfo_Landroid_content_Context_Lcom_sina_weibo_sdk_api_WeiboMultiMessage_;
		}

		static void n_StartClientShare_Lcom_umeng_socialize_media_AppInfo_Landroid_content_Context_Lcom_sina_weibo_sdk_api_WeiboMultiMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Umeng.Socialize.Sina.SinaAPI __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.SinaAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Media.AppInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.AppInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Sina.Weibo.Sdk.Api.WeiboMultiMessage p2 = global::Java.Lang.Object.GetObject<global::Com.Sina.Weibo.Sdk.Api.WeiboMultiMessage> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.StartClientShare (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_startClientShare_Lcom_umeng_socialize_media_AppInfo_Landroid_content_Context_Lcom_sina_weibo_sdk_api_WeiboMultiMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina']/class[@name='SinaAPI']/method[@name='startClientShare' and count(parameter)=3 and parameter[1][@type='com.umeng.socialize.media.AppInfo'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='com.sina.weibo.sdk.api.WeiboMultiMessage']]"
		[Register ("startClientShare", "(Lcom/umeng/socialize/media/AppInfo;Landroid/content/Context;Lcom/sina/weibo/sdk/api/WeiboMultiMessage;)V", "GetStartClientShare_Lcom_umeng_socialize_media_AppInfo_Landroid_content_Context_Lcom_sina_weibo_sdk_api_WeiboMultiMessage_Handler")]
		public virtual unsafe void StartClientShare (global::Com.Umeng.Socialize.Media.AppInfo p0, global::Android.Content.Context p1, global::Com.Sina.Weibo.Sdk.Api.WeiboMultiMessage p2)
		{
			if (id_startClientShare_Lcom_umeng_socialize_media_AppInfo_Landroid_content_Context_Lcom_sina_weibo_sdk_api_WeiboMultiMessage_ == IntPtr.Zero)
				id_startClientShare_Lcom_umeng_socialize_media_AppInfo_Landroid_content_Context_Lcom_sina_weibo_sdk_api_WeiboMultiMessage_ = JNIEnv.GetMethodID (class_ref, "startClientShare", "(Lcom/umeng/socialize/media/AppInfo;Landroid/content/Context;Lcom/sina/weibo/sdk/api/WeiboMultiMessage;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startClientShare_Lcom_umeng_socialize_media_AppInfo_Landroid_content_Context_Lcom_sina_weibo_sdk_api_WeiboMultiMessage_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startClientShare", "(Lcom/umeng/socialize/media/AppInfo;Landroid/content/Context;Lcom/sina/weibo/sdk/api/WeiboMultiMessage;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_startShareWeiboActivity_Landroid_app_Activity_Ljava_lang_String_Lcom_umeng_socialize_sina_message_BaseRequest_Lcom_umeng_socialize_UMShareListener_;
#pragma warning disable 0169
		static Delegate GetStartShareWeiboActivity_Landroid_app_Activity_Ljava_lang_String_Lcom_umeng_socialize_sina_message_BaseRequest_Lcom_umeng_socialize_UMShareListener_Handler ()
		{
			if (cb_startShareWeiboActivity_Landroid_app_Activity_Ljava_lang_String_Lcom_umeng_socialize_sina_message_BaseRequest_Lcom_umeng_socialize_UMShareListener_ == null)
				cb_startShareWeiboActivity_Landroid_app_Activity_Ljava_lang_String_Lcom_umeng_socialize_sina_message_BaseRequest_Lcom_umeng_socialize_UMShareListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_StartShareWeiboActivity_Landroid_app_Activity_Ljava_lang_String_Lcom_umeng_socialize_sina_message_BaseRequest_Lcom_umeng_socialize_UMShareListener_);
			return cb_startShareWeiboActivity_Landroid_app_Activity_Ljava_lang_String_Lcom_umeng_socialize_sina_message_BaseRequest_Lcom_umeng_socialize_UMShareListener_;
		}

		static bool n_StartShareWeiboActivity_Landroid_app_Activity_Ljava_lang_String_Lcom_umeng_socialize_sina_message_BaseRequest_Lcom_umeng_socialize_UMShareListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Umeng.Socialize.Sina.SinaAPI __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.SinaAPI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Sina.Message.BaseRequest p2 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Message.BaseRequest> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.IUMShareListener p3 = (global::Com.Umeng.Socialize.IUMShareListener)global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.IUMShareListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.StartShareWeiboActivity (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_startShareWeiboActivity_Landroid_app_Activity_Ljava_lang_String_Lcom_umeng_socialize_sina_message_BaseRequest_Lcom_umeng_socialize_UMShareListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina']/class[@name='SinaAPI']/method[@name='startShareWeiboActivity' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.umeng.socialize.sina.message.BaseRequest'] and parameter[4][@type='com.umeng.socialize.UMShareListener']]"
		[Register ("startShareWeiboActivity", "(Landroid/app/Activity;Ljava/lang/String;Lcom/umeng/socialize/sina/message/BaseRequest;Lcom/umeng/socialize/UMShareListener;)Z", "GetStartShareWeiboActivity_Landroid_app_Activity_Ljava_lang_String_Lcom_umeng_socialize_sina_message_BaseRequest_Lcom_umeng_socialize_UMShareListener_Handler")]
		public virtual unsafe bool StartShareWeiboActivity (global::Android.App.Activity p0, string p1, global::Com.Umeng.Socialize.Sina.Message.BaseRequest p2, global::Com.Umeng.Socialize.IUMShareListener p3)
		{
			if (id_startShareWeiboActivity_Landroid_app_Activity_Ljava_lang_String_Lcom_umeng_socialize_sina_message_BaseRequest_Lcom_umeng_socialize_UMShareListener_ == IntPtr.Zero)
				id_startShareWeiboActivity_Landroid_app_Activity_Ljava_lang_String_Lcom_umeng_socialize_sina_message_BaseRequest_Lcom_umeng_socialize_UMShareListener_ = JNIEnv.GetMethodID (class_ref, "startShareWeiboActivity", "(Landroid/app/Activity;Ljava/lang/String;Lcom/umeng/socialize/sina/message/BaseRequest;Lcom/umeng/socialize/UMShareListener;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_startShareWeiboActivity_Landroid_app_Activity_Ljava_lang_String_Lcom_umeng_socialize_sina_message_BaseRequest_Lcom_umeng_socialize_UMShareListener_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startShareWeiboActivity", "(Landroid/app/Activity;Ljava/lang/String;Lcom/umeng/socialize/sina/message/BaseRequest;Lcom/umeng/socialize/UMShareListener;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
