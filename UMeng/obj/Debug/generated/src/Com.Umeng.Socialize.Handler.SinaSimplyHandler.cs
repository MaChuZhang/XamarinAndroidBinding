using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Handler {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='SinaSimplyHandler']"
	[global::Android.Runtime.Register ("com/umeng/socialize/handler/SinaSimplyHandler", DoNotGenerateAcw=true)]
	public partial class SinaSimplyHandler : global::Com.Umeng.Socialize.Handler.UMSSOHandler {


		static IntPtr ERR_CANCEL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='SinaSimplyHandler']/field[@name='ERR_CANCEL']"
		[Register ("ERR_CANCEL")]
		public int ErrCancel {
			get {
				if (ERR_CANCEL_jfieldId == IntPtr.Zero)
					ERR_CANCEL_jfieldId = JNIEnv.GetFieldID (class_ref, "ERR_CANCEL", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, ERR_CANCEL_jfieldId);
			}
			set {
				if (ERR_CANCEL_jfieldId == IntPtr.Zero)
					ERR_CANCEL_jfieldId = JNIEnv.GetFieldID (class_ref, "ERR_CANCEL", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, ERR_CANCEL_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr ERR_FAIL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='SinaSimplyHandler']/field[@name='ERR_FAIL']"
		[Register ("ERR_FAIL")]
		public int ErrFail {
			get {
				if (ERR_FAIL_jfieldId == IntPtr.Zero)
					ERR_FAIL_jfieldId = JNIEnv.GetFieldID (class_ref, "ERR_FAIL", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, ERR_FAIL_jfieldId);
			}
			set {
				if (ERR_FAIL_jfieldId == IntPtr.Zero)
					ERR_FAIL_jfieldId = JNIEnv.GetFieldID (class_ref, "ERR_FAIL", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, ERR_FAIL_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr ERR_OK_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='SinaSimplyHandler']/field[@name='ERR_OK']"
		[Register ("ERR_OK")]
		public int ErrOk {
			get {
				if (ERR_OK_jfieldId == IntPtr.Zero)
					ERR_OK_jfieldId = JNIEnv.GetFieldID (class_ref, "ERR_OK", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, ERR_OK_jfieldId);
			}
			set {
				if (ERR_OK_jfieldId == IntPtr.Zero)
					ERR_OK_jfieldId = JNIEnv.GetFieldID (class_ref, "ERR_OK", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, ERR_OK_jfieldId, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='SinaSimplyHandler']/field[@name='SCOPE']"
		[Register ("SCOPE")]
		public const string Scope = (string) "email,direct_messages_read,direct_messages_write,friendships_groups_read,friendships_groups_write,statuses_to_me_read,follow_app_official_microblog,invitation_write";

		static IntPtr keyHash_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='SinaSimplyHandler']/field[@name='keyHash']"
		[Register ("keyHash")]
		public static string KeyHash {
			get {
				if (keyHash_jfieldId == IntPtr.Zero)
					keyHash_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "keyHash", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, keyHash_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (keyHash_jfieldId == IntPtr.Zero)
					keyHash_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "keyHash", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, keyHash_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/handler/SinaSimplyHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SinaSimplyHandler); }
		}

		protected SinaSimplyHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='SinaSimplyHandler']/constructor[@name='SinaSimplyHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SinaSimplyHandler ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SinaSimplyHandler)) {
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

		static Delegate cb_getAuthBundle;
#pragma warning disable 0169
		static Delegate GetGetAuthBundleHandler ()
		{
			if (cb_getAuthBundle == null)
				cb_getAuthBundle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthBundle);
			return cb_getAuthBundle;
		}

		static IntPtr n_GetAuthBundle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Handler.SinaSimplyHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.SinaSimplyHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AuthBundle);
		}
#pragma warning restore 0169

		static IntPtr id_getAuthBundle;
		public virtual unsafe global::Android.OS.Bundle AuthBundle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='SinaSimplyHandler']/method[@name='getAuthBundle' and count(parameter)=0]"
			[Register ("getAuthBundle", "()Landroid/os/Bundle;", "GetGetAuthBundleHandler")]
			get {
				if (id_getAuthBundle == IntPtr.Zero)
					id_getAuthBundle = JNIEnv.GetMethodID (class_ref, "getAuthBundle", "()Landroid/os/Bundle;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAuthBundle), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuthBundle", "()Landroid/os/Bundle;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getInfo;
#pragma warning disable 0169
		static Delegate GetGetInfoHandler ()
		{
			if (cb_getInfo == null)
				cb_getInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInfo);
			return cb_getInfo;
		}

		static IntPtr n_GetInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Handler.SinaSimplyHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.SinaSimplyHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Info);
		}
#pragma warning restore 0169

		static IntPtr id_getInfo;
		public virtual unsafe global::Com.Umeng.Socialize.Media.AppInfo Info {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='SinaSimplyHandler']/method[@name='getInfo' and count(parameter)=0]"
			[Register ("getInfo", "()Lcom/umeng/socialize/media/AppInfo;", "GetGetInfoHandler")]
			get {
				if (id_getInfo == IntPtr.Zero)
					id_getInfo = JNIEnv.GetMethodID (class_ref, "getInfo", "()Lcom/umeng/socialize/media/AppInfo;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.AppInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInfo), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.AppInfo> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInfo", "()Lcom/umeng/socialize/media/AppInfo;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Handler.SinaSimplyHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.SinaSimplyHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Message);
		}
#pragma warning restore 0169

		static IntPtr id_getMessage;
		public virtual unsafe global::Com.Sina.Weibo.Sdk.Api.WeiboMultiMessage Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='SinaSimplyHandler']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Lcom/sina/weibo/sdk/api/WeiboMultiMessage;", "GetGetMessageHandler")]
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Lcom/sina/weibo/sdk/api/WeiboMultiMessage;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Sina.Weibo.Sdk.Api.WeiboMultiMessage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Sina.Weibo.Sdk.Api.WeiboMultiMessage> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessage", "()Lcom/sina/weibo/sdk/api/WeiboMultiMessage;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUID;
#pragma warning disable 0169
		static Delegate GetGetUIDHandler ()
		{
			if (cb_getUID == null)
				cb_getUID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUID);
			return cb_getUID;
		}

		static IntPtr n_GetUID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Handler.SinaSimplyHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.SinaSimplyHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UID);
		}
#pragma warning restore 0169

		static IntPtr id_getUID;
		public virtual unsafe string UID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='SinaSimplyHandler']/method[@name='getUID' and count(parameter)=0]"
			[Register ("getUID", "()Ljava/lang/String;", "GetGetUIDHandler")]
			get {
				if (id_getUID == IntPtr.Zero)
					id_getUID = JNIEnv.GetMethodID (class_ref, "getUID", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getWbAppInfo;
#pragma warning disable 0169
		static Delegate GetGetWbAppInfoHandler ()
		{
			if (cb_getWbAppInfo == null)
				cb_getWbAppInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWbAppInfo);
			return cb_getWbAppInfo;
		}

		static IntPtr n_GetWbAppInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Handler.SinaSimplyHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.SinaSimplyHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WbAppInfo);
		}
#pragma warning restore 0169

		static IntPtr id_getWbAppInfo;
		public virtual unsafe global::Com.Umeng.Socialize.Media.AppInfo WbAppInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='SinaSimplyHandler']/method[@name='getWbAppInfo' and count(parameter)=0]"
			[Register ("getWbAppInfo", "()Lcom/umeng/socialize/media/AppInfo;", "GetGetWbAppInfoHandler")]
			get {
				if (id_getWbAppInfo == IntPtr.Zero)
					id_getWbAppInfo = JNIEnv.GetMethodID (class_ref, "getWbAppInfo", "()Lcom/umeng/socialize/media/AppInfo;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.AppInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWbAppInfo), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.AppInfo> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWbAppInfo", "()Lcom/umeng/socialize/media/AppInfo;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_deleteAuth;
#pragma warning disable 0169
		static Delegate GetDeleteAuthHandler ()
		{
			if (cb_deleteAuth == null)
				cb_deleteAuth = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DeleteAuth);
			return cb_deleteAuth;
		}

		static void n_DeleteAuth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Handler.SinaSimplyHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.SinaSimplyHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteAuth ();
		}
#pragma warning restore 0169

		static IntPtr id_deleteAuth;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='SinaSimplyHandler']/method[@name='deleteAuth' and count(parameter)=0]"
		[Register ("deleteAuth", "()V", "GetDeleteAuthHandler")]
		public virtual unsafe void DeleteAuth ()
		{
			if (id_deleteAuth == IntPtr.Zero)
				id_deleteAuth = JNIEnv.GetMethodID (class_ref, "deleteAuth", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteAuth);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteAuth", "()V"));
			} finally {
			}
		}

		static Delegate cb_getmWeiboShareAPI;
#pragma warning disable 0169
		static Delegate GetGetmWeiboShareAPIHandler ()
		{
			if (cb_getmWeiboShareAPI == null)
				cb_getmWeiboShareAPI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetmWeiboShareAPI);
			return cb_getmWeiboShareAPI;
		}

		static IntPtr n_GetmWeiboShareAPI (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Handler.SinaSimplyHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.SinaSimplyHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetmWeiboShareAPI ());
		}
#pragma warning restore 0169

		static IntPtr id_getmWeiboShareAPI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='SinaSimplyHandler']/method[@name='getmWeiboShareAPI' and count(parameter)=0]"
		[Register ("getmWeiboShareAPI", "()Lcom/umeng/socialize/sina/SinaAPI;", "GetGetmWeiboShareAPIHandler")]
		public virtual unsafe global::Com.Umeng.Socialize.Sina.SinaAPI GetmWeiboShareAPI ()
		{
			if (id_getmWeiboShareAPI == IntPtr.Zero)
				id_getmWeiboShareAPI = JNIEnv.GetMethodID (class_ref, "getmWeiboShareAPI", "()Lcom/umeng/socialize/sina/SinaAPI;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.SinaAPI> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getmWeiboShareAPI), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.SinaAPI> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getmWeiboShareAPI", "()Lcom/umeng/socialize/sina/SinaAPI;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onCancel;
#pragma warning disable 0169
		static Delegate GetOnCancelHandler ()
		{
			if (cb_onCancel == null)
				cb_onCancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCancel);
			return cb_onCancel;
		}

		static void n_OnCancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Handler.SinaSimplyHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.SinaSimplyHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCancel ();
		}
#pragma warning restore 0169

		static IntPtr id_onCancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='SinaSimplyHandler']/method[@name='onCancel' and count(parameter)=0]"
		[Register ("onCancel", "()V", "GetOnCancelHandler")]
		public virtual unsafe void OnCancel ()
		{
			if (id_onCancel == IntPtr.Zero)
				id_onCancel = JNIEnv.GetMethodID (class_ref, "onCancel", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCancel);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCancel", "()V"));
			} finally {
			}
		}

		static Delegate cb_onError;
#pragma warning disable 0169
		static Delegate GetOnErrorHandler ()
		{
			if (cb_onError == null)
				cb_onError = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnError);
			return cb_onError;
		}

		static void n_OnError (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Handler.SinaSimplyHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.SinaSimplyHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnError ();
		}
#pragma warning restore 0169

		static IntPtr id_onError;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='SinaSimplyHandler']/method[@name='onError' and count(parameter)=0]"
		[Register ("onError", "()V", "GetOnErrorHandler")]
		public virtual unsafe void OnError ()
		{
			if (id_onError == IntPtr.Zero)
				id_onError = JNIEnv.GetMethodID (class_ref, "onError", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onError", "()V"));
			} finally {
			}
		}

		static Delegate cb_onResponse_Lcom_umeng_socialize_sina_message_BaseResponse_;
#pragma warning disable 0169
		static Delegate GetOnResponse_Lcom_umeng_socialize_sina_message_BaseResponse_Handler ()
		{
			if (cb_onResponse_Lcom_umeng_socialize_sina_message_BaseResponse_ == null)
				cb_onResponse_Lcom_umeng_socialize_sina_message_BaseResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnResponse_Lcom_umeng_socialize_sina_message_BaseResponse_);
			return cb_onResponse_Lcom_umeng_socialize_sina_message_BaseResponse_;
		}

		static void n_OnResponse_Lcom_umeng_socialize_sina_message_BaseResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Handler.SinaSimplyHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.SinaSimplyHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Sina.Message.BaseResponse p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Message.BaseResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResponse (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onResponse_Lcom_umeng_socialize_sina_message_BaseResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='SinaSimplyHandler']/method[@name='onResponse' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.sina.message.BaseResponse']]"
		[Register ("onResponse", "(Lcom/umeng/socialize/sina/message/BaseResponse;)V", "GetOnResponse_Lcom_umeng_socialize_sina_message_BaseResponse_Handler")]
		public virtual unsafe void OnResponse (global::Com.Umeng.Socialize.Sina.Message.BaseResponse p0)
		{
			if (id_onResponse_Lcom_umeng_socialize_sina_message_BaseResponse_ == IntPtr.Zero)
				id_onResponse_Lcom_umeng_socialize_sina_message_BaseResponse_ = JNIEnv.GetMethodID (class_ref, "onResponse", "(Lcom/umeng/socialize/sina/message/BaseResponse;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResponse_Lcom_umeng_socialize_sina_message_BaseResponse_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onResponse", "(Lcom/umeng/socialize/sina/message/BaseResponse;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSuccess;
#pragma warning disable 0169
		static Delegate GetOnSuccessHandler ()
		{
			if (cb_onSuccess == null)
				cb_onSuccess = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSuccess);
			return cb_onSuccess;
		}

		static void n_OnSuccess (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Handler.SinaSimplyHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.SinaSimplyHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess ();
		}
#pragma warning restore 0169

		static IntPtr id_onSuccess;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='SinaSimplyHandler']/method[@name='onSuccess' and count(parameter)=0]"
		[Register ("onSuccess", "()V", "GetOnSuccessHandler")]
		public virtual unsafe void OnSuccess ()
		{
			if (id_onSuccess == IntPtr.Zero)
				id_onSuccess = JNIEnv.GetMethodID (class_ref, "onSuccess", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSuccess", "()V"));
			} finally {
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
			global::Com.Umeng.Socialize.Handler.SinaSimplyHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.SinaSimplyHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.ShareContent p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareContent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.IUMShareListener p1 = (global::Com.Umeng.Socialize.IUMShareListener)global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.IUMShareListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Share (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_share_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='SinaSimplyHandler']/method[@name='share' and count(parameter)=2 and parameter[1][@type='com.umeng.socialize.ShareContent'] and parameter[2][@type='com.umeng.socialize.UMShareListener']]"
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

		static IntPtr id_validateWeiboSign_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='SinaSimplyHandler']/method[@name='validateWeiboSign' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("validateWeiboSign", "(Landroid/content/Context;Ljava/lang/String;)Z", "")]
		public static unsafe bool ValidateWeiboSign (global::Android.Content.Context p0, string p1)
		{
			if (id_validateWeiboSign_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_validateWeiboSign_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "validateWeiboSign", "(Landroid/content/Context;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_validateWeiboSign_Landroid_content_Context_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
