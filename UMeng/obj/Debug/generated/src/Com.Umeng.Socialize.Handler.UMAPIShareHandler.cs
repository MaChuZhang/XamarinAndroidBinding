using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Handler {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMAPIShareHandler']"
	[global::Android.Runtime.Register ("com/umeng/socialize/handler/UMAPIShareHandler", DoNotGenerateAcw=true)]
	public abstract partial class UMAPIShareHandler : global::Com.Umeng.Socialize.Handler.UMSSOHandler, global::Com.Umeng.Socialize.Editorpage.IEditor {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMAPIShareHandler.StatHolder']"
		[global::Android.Runtime.Register ("com/umeng/socialize/handler/UMAPIShareHandler$StatHolder", DoNotGenerateAcw=true)]
		public partial class StatHolder : global::Java.Lang.Object {


			static IntPtr Content_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMAPIShareHandler.StatHolder']/field[@name='Content']"
			[Register ("Content")]
			public global::Com.Umeng.Socialize.ShareContent Content {
				get {
					if (Content_jfieldId == IntPtr.Zero)
						Content_jfieldId = JNIEnv.GetFieldID (class_ref, "Content", "Lcom/umeng/socialize/ShareContent;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, Content_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareContent> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (Content_jfieldId == IntPtr.Zero)
						Content_jfieldId = JNIEnv.GetFieldID (class_ref, "Content", "Lcom/umeng/socialize/ShareContent;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, Content_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/umeng/socialize/handler/UMAPIShareHandler$StatHolder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (StatHolder); }
			}

			protected StatHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/handler/UMAPIShareHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UMAPIShareHandler); }
		}

		protected UMAPIShareHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMAPIShareHandler']/constructor[@name='UMAPIShareHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UMAPIShareHandler ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (UMAPIShareHandler)) {
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

		static Delegate cb_getPlatform;
#pragma warning disable 0169
		static Delegate GetGetPlatformHandler ()
		{
			if (cb_getPlatform == null)
				cb_getPlatform = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlatform);
			return cb_getPlatform;
		}

		static IntPtr n_GetPlatform (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Handler.UMAPIShareHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.UMAPIShareHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Platform);
		}
#pragma warning restore 0169

		public abstract global::Com.Umeng.Socialize.Bean.SHARE_MEDIA Platform {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMAPIShareHandler']/method[@name='getPlatform' and count(parameter)=0]"
			[Register ("getPlatform", "()Lcom/umeng/socialize/bean/SHARE_MEDIA;", "GetGetPlatformHandler")] get;
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
			global::Com.Umeng.Socialize.Handler.UMAPIShareHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.UMAPIShareHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UID);
		}
#pragma warning restore 0169

		public abstract string UID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMAPIShareHandler']/method[@name='getUID' and count(parameter)=0]"
			[Register ("getUID", "()Ljava/lang/String;", "GetGetUIDHandler")] get;
		}

		static Delegate cb_authorizeCallBack_IILandroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetAuthorizeCallBack_IILandroid_content_Intent_Handler ()
		{
			if (cb_authorizeCallBack_IILandroid_content_Intent_ == null)
				cb_authorizeCallBack_IILandroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_AuthorizeCallBack_IILandroid_content_Intent_);
			return cb_authorizeCallBack_IILandroid_content_Intent_;
		}

		static void n_AuthorizeCallBack_IILandroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::Com.Umeng.Socialize.Handler.UMAPIShareHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.UMAPIShareHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p2 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.AuthorizeCallBack (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMAPIShareHandler']/method[@name='authorizeCallBack' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent']]"
		[Register ("authorizeCallBack", "(IILandroid/content/Intent;)V", "GetAuthorizeCallBack_IILandroid_content_Intent_Handler")]
		public abstract void AuthorizeCallBack (int p0, int p1, global::Android.Content.Intent p2);

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
			global::Com.Umeng.Socialize.Handler.UMAPIShareHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.UMAPIShareHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteAuth ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMAPIShareHandler']/method[@name='deleteAuth' and count(parameter)=0]"
		[Register ("deleteAuth", "()V", "GetDeleteAuthHandler")]
		public abstract void DeleteAuth ();

		static Delegate cb_doShare_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_;
#pragma warning disable 0169
		static Delegate GetDoShare_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_Handler ()
		{
			if (cb_doShare_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_ == null)
				cb_doShare_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoShare_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_);
			return cb_doShare_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_;
		}

		static void n_DoShare_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Socialize.Handler.UMAPIShareHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.UMAPIShareHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.ShareContent p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareContent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.IUMShareListener p1 = (global::Com.Umeng.Socialize.IUMShareListener)global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.IUMShareListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DoShare (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_doShare_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMAPIShareHandler']/method[@name='doShare' and count(parameter)=2 and parameter[1][@type='com.umeng.socialize.ShareContent'] and parameter[2][@type='com.umeng.socialize.UMShareListener']]"
		[Register ("doShare", "(Lcom/umeng/socialize/ShareContent;Lcom/umeng/socialize/UMShareListener;)V", "GetDoShare_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_Handler")]
		protected virtual unsafe void DoShare (global::Com.Umeng.Socialize.ShareContent p0, global::Com.Umeng.Socialize.IUMShareListener p1)
		{
			if (id_doShare_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_ == IntPtr.Zero)
				id_doShare_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_ = JNIEnv.GetMethodID (class_ref, "doShare", "(Lcom/umeng/socialize/ShareContent;Lcom/umeng/socialize/UMShareListener;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_doShare_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doShare", "(Lcom/umeng/socialize/ShareContent;Lcom/umeng/socialize/UMShareListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_sendShareRequest_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_;
#pragma warning disable 0169
		static Delegate GetSendShareRequest_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_Handler ()
		{
			if (cb_sendShareRequest_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_ == null)
				cb_sendShareRequest_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendShareRequest_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_);
			return cb_sendShareRequest_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_;
		}

		static void n_SendShareRequest_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Socialize.Handler.UMAPIShareHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.UMAPIShareHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.ShareContent p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareContent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.IUMShareListener p1 = (global::Com.Umeng.Socialize.IUMShareListener)global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.IUMShareListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendShareRequest (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendShareRequest_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMAPIShareHandler']/method[@name='sendShareRequest' and count(parameter)=2 and parameter[1][@type='com.umeng.socialize.ShareContent'] and parameter[2][@type='com.umeng.socialize.UMShareListener']]"
		[Register ("sendShareRequest", "(Lcom/umeng/socialize/ShareContent;Lcom/umeng/socialize/UMShareListener;)V", "GetSendShareRequest_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_Handler")]
		public virtual unsafe void SendShareRequest (global::Com.Umeng.Socialize.ShareContent p0, global::Com.Umeng.Socialize.IUMShareListener p1)
		{
			if (id_sendShareRequest_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_ == IntPtr.Zero)
				id_sendShareRequest_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_ = JNIEnv.GetMethodID (class_ref, "sendShareRequest", "(Lcom/umeng/socialize/ShareContent;Lcom/umeng/socialize/UMShareListener;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendShareRequest_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendShareRequest", "(Lcom/umeng/socialize/ShareContent;Lcom/umeng/socialize/UMShareListener;)V"), __args);
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
			global::Com.Umeng.Socialize.Handler.UMAPIShareHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.UMAPIShareHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.ShareContent p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareContent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.IUMShareListener p1 = (global::Com.Umeng.Socialize.IUMShareListener)global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.IUMShareListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Share (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_share_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMAPIShareHandler']/method[@name='share' and count(parameter)=2 and parameter[1][@type='com.umeng.socialize.ShareContent'] and parameter[2][@type='com.umeng.socialize.UMShareListener']]"
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

		static Delegate cb_getEditable_Lcom_umeng_socialize_ShareContent_;
#pragma warning disable 0169
		static Delegate GetGetEditable_Lcom_umeng_socialize_ShareContent_Handler ()
		{
			if (cb_getEditable_Lcom_umeng_socialize_ShareContent_ == null)
				cb_getEditable_Lcom_umeng_socialize_ShareContent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetEditable_Lcom_umeng_socialize_ShareContent_);
			return cb_getEditable_Lcom_umeng_socialize_ShareContent_;
		}

		static IntPtr n_GetEditable_Lcom_umeng_socialize_ShareContent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Handler.UMAPIShareHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.UMAPIShareHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.ShareContent p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareContent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetEditable (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.editorpage']/interface[@name='IEditor']/method[@name='getEditable' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.ShareContent']]"
		[Register ("getEditable", "(Lcom/umeng/socialize/ShareContent;)Landroid/os/Bundle;", "GetGetEditable_Lcom_umeng_socialize_ShareContent_Handler")]
		public abstract global::Android.OS.Bundle GetEditable (global::Com.Umeng.Socialize.ShareContent p0);

		static Delegate cb_getResult_Lcom_umeng_socialize_ShareContent_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetResult_Lcom_umeng_socialize_ShareContent_Landroid_os_Bundle_Handler ()
		{
			if (cb_getResult_Lcom_umeng_socialize_ShareContent_Landroid_os_Bundle_ == null)
				cb_getResult_Lcom_umeng_socialize_ShareContent_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetResult_Lcom_umeng_socialize_ShareContent_Landroid_os_Bundle_);
			return cb_getResult_Lcom_umeng_socialize_ShareContent_Landroid_os_Bundle_;
		}

		static IntPtr n_GetResult_Lcom_umeng_socialize_ShareContent_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Socialize.Handler.UMAPIShareHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.UMAPIShareHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.ShareContent p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareContent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetResult (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.editorpage']/interface[@name='IEditor']/method[@name='getResult' and count(parameter)=2 and parameter[1][@type='com.umeng.socialize.ShareContent'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("getResult", "(Lcom/umeng/socialize/ShareContent;Landroid/os/Bundle;)Lcom/umeng/socialize/ShareContent;", "GetGetResult_Lcom_umeng_socialize_ShareContent_Landroid_os_Bundle_Handler")]
		public abstract global::Com.Umeng.Socialize.ShareContent GetResult (global::Com.Umeng.Socialize.ShareContent p0, global::Android.OS.Bundle p1);

	}

	[global::Android.Runtime.Register ("com/umeng/socialize/handler/UMAPIShareHandler", DoNotGenerateAcw=true)]
	internal partial class UMAPIShareHandlerInvoker : UMAPIShareHandler {

		public UMAPIShareHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (UMAPIShareHandlerInvoker); }
		}

		static IntPtr id_getPlatform;
		public override unsafe global::Com.Umeng.Socialize.Bean.SHARE_MEDIA Platform {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMAPIShareHandler']/method[@name='getPlatform' and count(parameter)=0]"
			[Register ("getPlatform", "()Lcom/umeng/socialize/bean/SHARE_MEDIA;", "GetGetPlatformHandler")]
			get {
				if (id_getPlatform == IntPtr.Zero)
					id_getPlatform = JNIEnv.GetMethodID (class_ref, "getPlatform", "()Lcom/umeng/socialize/bean/SHARE_MEDIA;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.SHARE_MEDIA> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPlatform), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getUID;
		public override unsafe string UID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMAPIShareHandler']/method[@name='getUID' and count(parameter)=0]"
			[Register ("getUID", "()Ljava/lang/String;", "GetGetUIDHandler")]
			get {
				if (id_getUID == IntPtr.Zero)
					id_getUID = JNIEnv.GetMethodID (class_ref, "getUID", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUID), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_authorizeCallBack_IILandroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMAPIShareHandler']/method[@name='authorizeCallBack' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent']]"
		[Register ("authorizeCallBack", "(IILandroid/content/Intent;)V", "GetAuthorizeCallBack_IILandroid_content_Intent_Handler")]
		public override unsafe void AuthorizeCallBack (int p0, int p1, global::Android.Content.Intent p2)
		{
			if (id_authorizeCallBack_IILandroid_content_Intent_ == IntPtr.Zero)
				id_authorizeCallBack_IILandroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "authorizeCallBack", "(IILandroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_authorizeCallBack_IILandroid_content_Intent_, __args);
			} finally {
			}
		}

		static IntPtr id_deleteAuth;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMAPIShareHandler']/method[@name='deleteAuth' and count(parameter)=0]"
		[Register ("deleteAuth", "()V", "GetDeleteAuthHandler")]
		public override unsafe void DeleteAuth ()
		{
			if (id_deleteAuth == IntPtr.Zero)
				id_deleteAuth = JNIEnv.GetMethodID (class_ref, "deleteAuth", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteAuth);
			} finally {
			}
		}

		static IntPtr id_getEditable_Lcom_umeng_socialize_ShareContent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.editorpage']/interface[@name='IEditor']/method[@name='getEditable' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.ShareContent']]"
		[Register ("getEditable", "(Lcom/umeng/socialize/ShareContent;)Landroid/os/Bundle;", "GetGetEditable_Lcom_umeng_socialize_ShareContent_Handler")]
		public override unsafe global::Android.OS.Bundle GetEditable (global::Com.Umeng.Socialize.ShareContent p0)
		{
			if (id_getEditable_Lcom_umeng_socialize_ShareContent_ == IntPtr.Zero)
				id_getEditable_Lcom_umeng_socialize_ShareContent_ = JNIEnv.GetMethodID (class_ref, "getEditable", "(Lcom/umeng/socialize/ShareContent;)Landroid/os/Bundle;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEditable_Lcom_umeng_socialize_ShareContent_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getResult_Lcom_umeng_socialize_ShareContent_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.editorpage']/interface[@name='IEditor']/method[@name='getResult' and count(parameter)=2 and parameter[1][@type='com.umeng.socialize.ShareContent'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("getResult", "(Lcom/umeng/socialize/ShareContent;Landroid/os/Bundle;)Lcom/umeng/socialize/ShareContent;", "GetGetResult_Lcom_umeng_socialize_ShareContent_Landroid_os_Bundle_Handler")]
		public override unsafe global::Com.Umeng.Socialize.ShareContent GetResult (global::Com.Umeng.Socialize.ShareContent p0, global::Android.OS.Bundle p1)
		{
			if (id_getResult_Lcom_umeng_socialize_ShareContent_Landroid_os_Bundle_ == IntPtr.Zero)
				id_getResult_Lcom_umeng_socialize_ShareContent_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "getResult", "(Lcom/umeng/socialize/ShareContent;Landroid/os/Bundle;)Lcom/umeng/socialize/ShareContent;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Umeng.Socialize.ShareContent __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareContent> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResult_Lcom_umeng_socialize_ShareContent_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

}
