using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareAction']"
	[global::Android.Runtime.Register ("com/umeng/socialize/ShareAction", DoNotGenerateAcw=true)]
	public partial class ShareAction : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/ShareAction", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ShareAction); }
		}

		protected ShareAction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Activity_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareAction']/constructor[@name='ShareAction' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register (".ctor", "(Landroid/app/Activity;)V", "")]
		public unsafe ShareAction (global::Android.App.Activity p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ShareAction)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/app/Activity;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/app/Activity;)V", __args);
					return;
				}

				if (id_ctor_Landroid_app_Activity_ == IntPtr.Zero)
					id_ctor_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_app_Activity_, __args);
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
			global::Com.Umeng.Socialize.ShareAction __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Platform);
		}
#pragma warning restore 0169

		static IntPtr id_getPlatform;
		public virtual unsafe global::Com.Umeng.Socialize.Bean.SHARE_MEDIA Platform {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareAction']/method[@name='getPlatform' and count(parameter)=0]"
			[Register ("getPlatform", "()Lcom/umeng/socialize/bean/SHARE_MEDIA;", "GetGetPlatformHandler")]
			get {
				if (id_getPlatform == IntPtr.Zero)
					id_getPlatform = JNIEnv.GetMethodID (class_ref, "getPlatform", "()Lcom/umeng/socialize/bean/SHARE_MEDIA;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.SHARE_MEDIA> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPlatform), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.SHARE_MEDIA> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPlatform", "()Lcom/umeng/socialize/bean/SHARE_MEDIA;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getShareContent;
#pragma warning disable 0169
		static Delegate GetGetShareContentHandler ()
		{
			if (cb_getShareContent == null)
				cb_getShareContent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetShareContent);
			return cb_getShareContent;
		}

		static IntPtr n_GetShareContent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.ShareAction __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShareContent);
		}
#pragma warning restore 0169

		static IntPtr id_getShareContent;
		public virtual unsafe global::Com.Umeng.Socialize.ShareContent ShareContent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareAction']/method[@name='getShareContent' and count(parameter)=0]"
			[Register ("getShareContent", "()Lcom/umeng/socialize/ShareContent;", "GetGetShareContentHandler")]
			get {
				if (id_getShareContent == IntPtr.Zero)
					id_getShareContent = JNIEnv.GetMethodID (class_ref, "getShareContent", "()Lcom/umeng/socialize/ShareContent;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareContent> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getShareContent), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareContent> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getShareContent", "()Lcom/umeng/socialize/ShareContent;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUrlValid;
#pragma warning disable 0169
		static Delegate GetGetUrlValidHandler ()
		{
			if (cb_getUrlValid == null)
				cb_getUrlValid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetUrlValid);
			return cb_getUrlValid;
		}

		static bool n_GetUrlValid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.ShareAction __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UrlValid;
		}
#pragma warning restore 0169

		static IntPtr id_getUrlValid;
		public virtual unsafe bool UrlValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareAction']/method[@name='getUrlValid' and count(parameter)=0]"
			[Register ("getUrlValid", "()Z", "GetGetUrlValidHandler")]
			get {
				if (id_getUrlValid == IntPtr.Zero)
					id_getUrlValid = JNIEnv.GetMethodID (class_ref, "getUrlValid", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getUrlValid);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUrlValid", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_addButton_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddButton_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addButton_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addButton_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddButton_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_addButton_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_AddButton_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Umeng.Socialize.ShareAction __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddButton (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addButton_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareAction']/method[@name='addButton' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("addButton", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/umeng/socialize/ShareAction;", "GetAddButton_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Umeng.Socialize.ShareAction AddButton (string p0, string p1, string p2, string p3)
		{
			if (id_addButton_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addButton_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addButton", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/umeng/socialize/ShareAction;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				global::Com.Umeng.Socialize.ShareAction __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addButton_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addButton", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/umeng/socialize/ShareAction;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.ShareAction __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareAction']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
			} finally {
			}
		}

		static IntPtr id_locateView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareAction']/method[@name='locateView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("locateView", "(Landroid/view/View;)Landroid/graphics/Rect;", "")]
		public static unsafe global::Android.Graphics.Rect LocateView (global::Android.Views.View p0)
		{
			if (id_locateView_Landroid_view_View_ == IntPtr.Zero)
				id_locateView_Landroid_view_View_ = JNIEnv.GetStaticMethodID (class_ref, "locateView", "(Landroid/view/View;)Landroid/graphics/Rect;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Graphics.Rect __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (JNIEnv.CallStaticObjectMethod  (class_ref, id_locateView_Landroid_view_View_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_open;
#pragma warning disable 0169
		static Delegate GetOpenHandler ()
		{
			if (cb_open == null)
				cb_open = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Open);
			return cb_open;
		}

		static void n_Open (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.ShareAction __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Open ();
		}
#pragma warning restore 0169

		static IntPtr id_open;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareAction']/method[@name='open' and count(parameter)=0]"
		[Register ("open", "()V", "GetOpenHandler")]
		public virtual unsafe void Open ()
		{
			if (id_open == IntPtr.Zero)
				id_open = JNIEnv.GetMethodID (class_ref, "open", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_open);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "open", "()V"));
			} finally {
			}
		}

		static Delegate cb_open_Lcom_umeng_socialize_shareboard_ShareBoardConfig_;
#pragma warning disable 0169
		static Delegate GetOpen_Lcom_umeng_socialize_shareboard_ShareBoardConfig_Handler ()
		{
			if (cb_open_Lcom_umeng_socialize_shareboard_ShareBoardConfig_ == null)
				cb_open_Lcom_umeng_socialize_shareboard_ShareBoardConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Open_Lcom_umeng_socialize_shareboard_ShareBoardConfig_);
			return cb_open_Lcom_umeng_socialize_shareboard_ShareBoardConfig_;
		}

		static void n_Open_Lcom_umeng_socialize_shareboard_ShareBoardConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.ShareAction __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Open (p0);
		}
#pragma warning restore 0169

		static IntPtr id_open_Lcom_umeng_socialize_shareboard_ShareBoardConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareAction']/method[@name='open' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.shareboard.ShareBoardConfig']]"
		[Register ("open", "(Lcom/umeng/socialize/shareboard/ShareBoardConfig;)V", "GetOpen_Lcom_umeng_socialize_shareboard_ShareBoardConfig_Handler")]
		public virtual unsafe void Open (global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig p0)
		{
			if (id_open_Lcom_umeng_socialize_shareboard_ShareBoardConfig_ == IntPtr.Zero)
				id_open_Lcom_umeng_socialize_shareboard_ShareBoardConfig_ = JNIEnv.GetMethodID (class_ref, "open", "(Lcom/umeng/socialize/shareboard/ShareBoardConfig;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_open_Lcom_umeng_socialize_shareboard_ShareBoardConfig_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "open", "(Lcom/umeng/socialize/shareboard/ShareBoardConfig;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setCallback_Lcom_umeng_socialize_UMShareListener_;
#pragma warning disable 0169
		static Delegate GetSetCallback_Lcom_umeng_socialize_UMShareListener_Handler ()
		{
			if (cb_setCallback_Lcom_umeng_socialize_UMShareListener_ == null)
				cb_setCallback_Lcom_umeng_socialize_UMShareListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCallback_Lcom_umeng_socialize_UMShareListener_);
			return cb_setCallback_Lcom_umeng_socialize_UMShareListener_;
		}

		static IntPtr n_SetCallback_Lcom_umeng_socialize_UMShareListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.ShareAction __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.IUMShareListener p0 = (global::Com.Umeng.Socialize.IUMShareListener)global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.IUMShareListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCallback (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setCallback_Lcom_umeng_socialize_UMShareListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareAction']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.UMShareListener']]"
		[Register ("setCallback", "(Lcom/umeng/socialize/UMShareListener;)Lcom/umeng/socialize/ShareAction;", "GetSetCallback_Lcom_umeng_socialize_UMShareListener_Handler")]
		public virtual unsafe global::Com.Umeng.Socialize.ShareAction SetCallback (global::Com.Umeng.Socialize.IUMShareListener p0)
		{
			if (id_setCallback_Lcom_umeng_socialize_UMShareListener_ == IntPtr.Zero)
				id_setCallback_Lcom_umeng_socialize_UMShareListener_ = JNIEnv.GetMethodID (class_ref, "setCallback", "(Lcom/umeng/socialize/UMShareListener;)Lcom/umeng/socialize/ShareAction;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Umeng.Socialize.ShareAction __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCallback_Lcom_umeng_socialize_UMShareListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCallback", "(Lcom/umeng/socialize/UMShareListener;)Lcom/umeng/socialize/ShareAction;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setContentList_arrayLcom_umeng_socialize_ShareContent_;
#pragma warning disable 0169
		static Delegate GetSetContentList_arrayLcom_umeng_socialize_ShareContent_Handler ()
		{
			if (cb_setContentList_arrayLcom_umeng_socialize_ShareContent_ == null)
				cb_setContentList_arrayLcom_umeng_socialize_ShareContent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetContentList_arrayLcom_umeng_socialize_ShareContent_);
			return cb_setContentList_arrayLcom_umeng_socialize_ShareContent_;
		}

		static IntPtr n_SetContentList_arrayLcom_umeng_socialize_ShareContent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.ShareAction __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.ShareContent[] p0 = (global::Com.Umeng.Socialize.ShareContent[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Umeng.Socialize.ShareContent));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetContentList (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setContentList_arrayLcom_umeng_socialize_ShareContent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareAction']/method[@name='setContentList' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.ShareContent...']]"
		[Obsolete (@"deprecated")]
		[Register ("setContentList", "([Lcom/umeng/socialize/ShareContent;)Lcom/umeng/socialize/ShareAction;", "GetSetContentList_arrayLcom_umeng_socialize_ShareContent_Handler")]
		public virtual unsafe global::Com.Umeng.Socialize.ShareAction SetContentList (params global:: Com.Umeng.Socialize.ShareContent[] p0)
		{
			if (id_setContentList_arrayLcom_umeng_socialize_ShareContent_ == IntPtr.Zero)
				id_setContentList_arrayLcom_umeng_socialize_ShareContent_ = JNIEnv.GetMethodID (class_ref, "setContentList", "([Lcom/umeng/socialize/ShareContent;)Lcom/umeng/socialize/ShareAction;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Umeng.Socialize.ShareAction __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setContentList_arrayLcom_umeng_socialize_ShareContent_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContentList", "([Lcom/umeng/socialize/ShareContent;)Lcom/umeng/socialize/ShareAction;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setDisplayList_arrayLcom_umeng_socialize_bean_SHARE_MEDIA_;
#pragma warning disable 0169
		static Delegate GetSetDisplayList_arrayLcom_umeng_socialize_bean_SHARE_MEDIA_Handler ()
		{
			if (cb_setDisplayList_arrayLcom_umeng_socialize_bean_SHARE_MEDIA_ == null)
				cb_setDisplayList_arrayLcom_umeng_socialize_bean_SHARE_MEDIA_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDisplayList_arrayLcom_umeng_socialize_bean_SHARE_MEDIA_);
			return cb_setDisplayList_arrayLcom_umeng_socialize_bean_SHARE_MEDIA_;
		}

		static IntPtr n_SetDisplayList_arrayLcom_umeng_socialize_bean_SHARE_MEDIA_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.ShareAction __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Bean.SHARE_MEDIA[] p0 = (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDisplayList (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setDisplayList_arrayLcom_umeng_socialize_bean_SHARE_MEDIA_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareAction']/method[@name='setDisplayList' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.bean.SHARE_MEDIA...']]"
		[Register ("setDisplayList", "([Lcom/umeng/socialize/bean/SHARE_MEDIA;)Lcom/umeng/socialize/ShareAction;", "GetSetDisplayList_arrayLcom_umeng_socialize_bean_SHARE_MEDIA_Handler")]
		public virtual unsafe global::Com.Umeng.Socialize.ShareAction SetDisplayList (params global:: Com.Umeng.Socialize.Bean.SHARE_MEDIA[] p0)
		{
			if (id_setDisplayList_arrayLcom_umeng_socialize_bean_SHARE_MEDIA_ == IntPtr.Zero)
				id_setDisplayList_arrayLcom_umeng_socialize_bean_SHARE_MEDIA_ = JNIEnv.GetMethodID (class_ref, "setDisplayList", "([Lcom/umeng/socialize/bean/SHARE_MEDIA;)Lcom/umeng/socialize/ShareAction;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Umeng.Socialize.ShareAction __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDisplayList_arrayLcom_umeng_socialize_bean_SHARE_MEDIA_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisplayList", "([Lcom/umeng/socialize/bean/SHARE_MEDIA;)Lcom/umeng/socialize/ShareAction;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setListenerList_arrayLcom_umeng_socialize_UMShareListener_;
#pragma warning disable 0169
		static Delegate GetSetListenerList_arrayLcom_umeng_socialize_UMShareListener_Handler ()
		{
			if (cb_setListenerList_arrayLcom_umeng_socialize_UMShareListener_ == null)
				cb_setListenerList_arrayLcom_umeng_socialize_UMShareListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetListenerList_arrayLcom_umeng_socialize_UMShareListener_);
			return cb_setListenerList_arrayLcom_umeng_socialize_UMShareListener_;
		}

		static IntPtr n_SetListenerList_arrayLcom_umeng_socialize_UMShareListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.ShareAction __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.IUMShareListener[] p0 = (global::Com.Umeng.Socialize.IUMShareListener[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Umeng.Socialize.IUMShareListener));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetListenerList (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setListenerList_arrayLcom_umeng_socialize_UMShareListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareAction']/method[@name='setListenerList' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.UMShareListener...']]"
		[Obsolete (@"deprecated")]
		[Register ("setListenerList", "([Lcom/umeng/socialize/UMShareListener;)Lcom/umeng/socialize/ShareAction;", "GetSetListenerList_arrayLcom_umeng_socialize_UMShareListener_Handler")]
		public virtual unsafe global::Com.Umeng.Socialize.ShareAction SetListenerList (params global:: Com.Umeng.Socialize.IUMShareListener[] p0)
		{
			if (id_setListenerList_arrayLcom_umeng_socialize_UMShareListener_ == IntPtr.Zero)
				id_setListenerList_arrayLcom_umeng_socialize_UMShareListener_ = JNIEnv.GetMethodID (class_ref, "setListenerList", "([Lcom/umeng/socialize/UMShareListener;)Lcom/umeng/socialize/ShareAction;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Umeng.Socialize.ShareAction __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setListenerList_arrayLcom_umeng_socialize_UMShareListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setListenerList", "([Lcom/umeng/socialize/UMShareListener;)Lcom/umeng/socialize/ShareAction;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setPlatform_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
#pragma warning disable 0169
		static Delegate GetSetPlatform_Lcom_umeng_socialize_bean_SHARE_MEDIA_Handler ()
		{
			if (cb_setPlatform_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == null)
				cb_setPlatform_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPlatform_Lcom_umeng_socialize_bean_SHARE_MEDIA_);
			return cb_setPlatform_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
		}

		static IntPtr n_SetPlatform_Lcom_umeng_socialize_bean_SHARE_MEDIA_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.ShareAction __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.SHARE_MEDIA> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPlatform (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setPlatform_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareAction']/method[@name='setPlatform' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.bean.SHARE_MEDIA']]"
		[Register ("setPlatform", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;)Lcom/umeng/socialize/ShareAction;", "GetSetPlatform_Lcom_umeng_socialize_bean_SHARE_MEDIA_Handler")]
		public virtual unsafe global::Com.Umeng.Socialize.ShareAction SetPlatform (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0)
		{
			if (id_setPlatform_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == IntPtr.Zero)
				id_setPlatform_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNIEnv.GetMethodID (class_ref, "setPlatform", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;)Lcom/umeng/socialize/ShareAction;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Umeng.Socialize.ShareAction __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setPlatform_Lcom_umeng_socialize_bean_SHARE_MEDIA_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPlatform", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;)Lcom/umeng/socialize/ShareAction;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setShareContent_Lcom_umeng_socialize_ShareContent_;
#pragma warning disable 0169
		static Delegate GetSetShareContent_Lcom_umeng_socialize_ShareContent_Handler ()
		{
			if (cb_setShareContent_Lcom_umeng_socialize_ShareContent_ == null)
				cb_setShareContent_Lcom_umeng_socialize_ShareContent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetShareContent_Lcom_umeng_socialize_ShareContent_);
			return cb_setShareContent_Lcom_umeng_socialize_ShareContent_;
		}

		static IntPtr n_SetShareContent_Lcom_umeng_socialize_ShareContent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.ShareAction __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.ShareContent p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareContent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetShareContent (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setShareContent_Lcom_umeng_socialize_ShareContent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareAction']/method[@name='setShareContent' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.ShareContent']]"
		[Register ("setShareContent", "(Lcom/umeng/socialize/ShareContent;)Lcom/umeng/socialize/ShareAction;", "GetSetShareContent_Lcom_umeng_socialize_ShareContent_Handler")]
		public virtual unsafe global::Com.Umeng.Socialize.ShareAction SetShareContent (global::Com.Umeng.Socialize.ShareContent p0)
		{
			if (id_setShareContent_Lcom_umeng_socialize_ShareContent_ == IntPtr.Zero)
				id_setShareContent_Lcom_umeng_socialize_ShareContent_ = JNIEnv.GetMethodID (class_ref, "setShareContent", "(Lcom/umeng/socialize/ShareContent;)Lcom/umeng/socialize/ShareAction;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Umeng.Socialize.ShareAction __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setShareContent_Lcom_umeng_socialize_ShareContent_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShareContent", "(Lcom/umeng/socialize/ShareContent;)Lcom/umeng/socialize/ShareAction;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setShareboardclickCallback_Lcom_umeng_socialize_utils_ShareBoardlistener_;
#pragma warning disable 0169
		static Delegate GetSetShareboardclickCallback_Lcom_umeng_socialize_utils_ShareBoardlistener_Handler ()
		{
			if (cb_setShareboardclickCallback_Lcom_umeng_socialize_utils_ShareBoardlistener_ == null)
				cb_setShareboardclickCallback_Lcom_umeng_socialize_utils_ShareBoardlistener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetShareboardclickCallback_Lcom_umeng_socialize_utils_ShareBoardlistener_);
			return cb_setShareboardclickCallback_Lcom_umeng_socialize_utils_ShareBoardlistener_;
		}

		static IntPtr n_SetShareboardclickCallback_Lcom_umeng_socialize_utils_ShareBoardlistener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.ShareAction __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Utils.IShareBoardlistener p0 = (global::Com.Umeng.Socialize.Utils.IShareBoardlistener)global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Utils.IShareBoardlistener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetShareboardclickCallback (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setShareboardclickCallback_Lcom_umeng_socialize_utils_ShareBoardlistener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareAction']/method[@name='setShareboardclickCallback' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.utils.ShareBoardlistener']]"
		[Register ("setShareboardclickCallback", "(Lcom/umeng/socialize/utils/ShareBoardlistener;)Lcom/umeng/socialize/ShareAction;", "GetSetShareboardclickCallback_Lcom_umeng_socialize_utils_ShareBoardlistener_Handler")]
		public virtual unsafe global::Com.Umeng.Socialize.ShareAction SetShareboardclickCallback (global::Com.Umeng.Socialize.Utils.IShareBoardlistener p0)
		{
			if (id_setShareboardclickCallback_Lcom_umeng_socialize_utils_ShareBoardlistener_ == IntPtr.Zero)
				id_setShareboardclickCallback_Lcom_umeng_socialize_utils_ShareBoardlistener_ = JNIEnv.GetMethodID (class_ref, "setShareboardclickCallback", "(Lcom/umeng/socialize/utils/ShareBoardlistener;)Lcom/umeng/socialize/ShareAction;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Umeng.Socialize.ShareAction __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setShareboardclickCallback_Lcom_umeng_socialize_utils_ShareBoardlistener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShareboardclickCallback", "(Lcom/umeng/socialize/utils/ShareBoardlistener;)Lcom/umeng/socialize/ShareAction;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_share;
#pragma warning disable 0169
		static Delegate GetShareHandler ()
		{
			if (cb_share == null)
				cb_share = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Share);
			return cb_share;
		}

		static void n_Share (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.ShareAction __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Share ();
		}
#pragma warning restore 0169

		static IntPtr id_share;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareAction']/method[@name='share' and count(parameter)=0]"
		[Register ("share", "()V", "GetShareHandler")]
		public virtual unsafe void Share ()
		{
			if (id_share == IntPtr.Zero)
				id_share = JNIEnv.GetMethodID (class_ref, "share", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_share);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "share", "()V"));
			} finally {
			}
		}

		static Delegate cb_withApp_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetWithApp_Ljava_io_File_Handler ()
		{
			if (cb_withApp_Ljava_io_File_ == null)
				cb_withApp_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithApp_Ljava_io_File_);
			return cb_withApp_Ljava_io_File_;
		}

		static IntPtr n_WithApp_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.ShareAction __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithApp (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withApp_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareAction']/method[@name='withApp' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("withApp", "(Ljava/io/File;)Lcom/umeng/socialize/ShareAction;", "GetWithApp_Ljava_io_File_Handler")]
		public virtual unsafe global::Com.Umeng.Socialize.ShareAction WithApp (global::Java.IO.File p0)
		{
			if (id_withApp_Ljava_io_File_ == IntPtr.Zero)
				id_withApp_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "withApp", "(Ljava/io/File;)Lcom/umeng/socialize/ShareAction;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Umeng.Socialize.ShareAction __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withApp_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withApp", "(Ljava/io/File;)Lcom/umeng/socialize/ShareAction;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withExtra_Lcom_umeng_socialize_media_UMImage_;
#pragma warning disable 0169
		static Delegate GetWithExtra_Lcom_umeng_socialize_media_UMImage_Handler ()
		{
			if (cb_withExtra_Lcom_umeng_socialize_media_UMImage_ == null)
				cb_withExtra_Lcom_umeng_socialize_media_UMImage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithExtra_Lcom_umeng_socialize_media_UMImage_);
			return cb_withExtra_Lcom_umeng_socialize_media_UMImage_;
		}

		static IntPtr n_WithExtra_Lcom_umeng_socialize_media_UMImage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.ShareAction __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Media.UMImage p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithExtra (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withExtra_Lcom_umeng_socialize_media_UMImage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareAction']/method[@name='withExtra' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.media.UMImage']]"
		[Register ("withExtra", "(Lcom/umeng/socialize/media/UMImage;)Lcom/umeng/socialize/ShareAction;", "GetWithExtra_Lcom_umeng_socialize_media_UMImage_Handler")]
		public virtual unsafe global::Com.Umeng.Socialize.ShareAction WithExtra (global::Com.Umeng.Socialize.Media.UMImage p0)
		{
			if (id_withExtra_Lcom_umeng_socialize_media_UMImage_ == IntPtr.Zero)
				id_withExtra_Lcom_umeng_socialize_media_UMImage_ = JNIEnv.GetMethodID (class_ref, "withExtra", "(Lcom/umeng/socialize/media/UMImage;)Lcom/umeng/socialize/ShareAction;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Umeng.Socialize.ShareAction __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withExtra_Lcom_umeng_socialize_media_UMImage_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withExtra", "(Lcom/umeng/socialize/media/UMImage;)Lcom/umeng/socialize/ShareAction;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withFile_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetWithFile_Ljava_io_File_Handler ()
		{
			if (cb_withFile_Ljava_io_File_ == null)
				cb_withFile_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithFile_Ljava_io_File_);
			return cb_withFile_Ljava_io_File_;
		}

		static IntPtr n_WithFile_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.ShareAction __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithFile (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withFile_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareAction']/method[@name='withFile' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("withFile", "(Ljava/io/File;)Lcom/umeng/socialize/ShareAction;", "GetWithFile_Ljava_io_File_Handler")]
		public virtual unsafe global::Com.Umeng.Socialize.ShareAction WithFile (global::Java.IO.File p0)
		{
			if (id_withFile_Ljava_io_File_ == IntPtr.Zero)
				id_withFile_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "withFile", "(Ljava/io/File;)Lcom/umeng/socialize/ShareAction;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Umeng.Socialize.ShareAction __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withFile_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withFile", "(Ljava/io/File;)Lcom/umeng/socialize/ShareAction;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withFollow_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithFollow_Ljava_lang_String_Handler ()
		{
			if (cb_withFollow_Ljava_lang_String_ == null)
				cb_withFollow_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithFollow_Ljava_lang_String_);
			return cb_withFollow_Ljava_lang_String_;
		}

		static IntPtr n_WithFollow_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.ShareAction __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithFollow (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withFollow_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareAction']/method[@name='withFollow' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withFollow", "(Ljava/lang/String;)Lcom/umeng/socialize/ShareAction;", "GetWithFollow_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Umeng.Socialize.ShareAction WithFollow (string p0)
		{
			if (id_withFollow_Ljava_lang_String_ == IntPtr.Zero)
				id_withFollow_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withFollow", "(Ljava/lang/String;)Lcom/umeng/socialize/ShareAction;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Umeng.Socialize.ShareAction __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withFollow_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withFollow", "(Ljava/lang/String;)Lcom/umeng/socialize/ShareAction;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withMedia_Lcom_umeng_socialize_media_UMEmoji_;
#pragma warning disable 0169
		static Delegate GetWithMedia_Lcom_umeng_socialize_media_UMEmoji_Handler ()
		{
			if (cb_withMedia_Lcom_umeng_socialize_media_UMEmoji_ == null)
				cb_withMedia_Lcom_umeng_socialize_media_UMEmoji_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithMedia_Lcom_umeng_socialize_media_UMEmoji_);
			return cb_withMedia_Lcom_umeng_socialize_media_UMEmoji_;
		}

		static IntPtr n_WithMedia_Lcom_umeng_socialize_media_UMEmoji_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.ShareAction __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Media.UMEmoji p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMEmoji> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithMedia (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withMedia_Lcom_umeng_socialize_media_UMEmoji_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareAction']/method[@name='withMedia' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.media.UMEmoji']]"
		[Register ("withMedia", "(Lcom/umeng/socialize/media/UMEmoji;)Lcom/umeng/socialize/ShareAction;", "GetWithMedia_Lcom_umeng_socialize_media_UMEmoji_Handler")]
		public virtual unsafe global::Com.Umeng.Socialize.ShareAction WithMedia (global::Com.Umeng.Socialize.Media.UMEmoji p0)
		{
			if (id_withMedia_Lcom_umeng_socialize_media_UMEmoji_ == IntPtr.Zero)
				id_withMedia_Lcom_umeng_socialize_media_UMEmoji_ = JNIEnv.GetMethodID (class_ref, "withMedia", "(Lcom/umeng/socialize/media/UMEmoji;)Lcom/umeng/socialize/ShareAction;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Umeng.Socialize.ShareAction __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withMedia_Lcom_umeng_socialize_media_UMEmoji_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withMedia", "(Lcom/umeng/socialize/media/UMEmoji;)Lcom/umeng/socialize/ShareAction;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withMedia_Lcom_umeng_socialize_media_UMImage_;
#pragma warning disable 0169
		static Delegate GetWithMedia_Lcom_umeng_socialize_media_UMImage_Handler ()
		{
			if (cb_withMedia_Lcom_umeng_socialize_media_UMImage_ == null)
				cb_withMedia_Lcom_umeng_socialize_media_UMImage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithMedia_Lcom_umeng_socialize_media_UMImage_);
			return cb_withMedia_Lcom_umeng_socialize_media_UMImage_;
		}

		static IntPtr n_WithMedia_Lcom_umeng_socialize_media_UMImage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.ShareAction __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Media.UMImage p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMImage> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithMedia (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withMedia_Lcom_umeng_socialize_media_UMImage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareAction']/method[@name='withMedia' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.media.UMImage']]"
		[Register ("withMedia", "(Lcom/umeng/socialize/media/UMImage;)Lcom/umeng/socialize/ShareAction;", "GetWithMedia_Lcom_umeng_socialize_media_UMImage_Handler")]
		public virtual unsafe global::Com.Umeng.Socialize.ShareAction WithMedia (global::Com.Umeng.Socialize.Media.UMImage p0)
		{
			if (id_withMedia_Lcom_umeng_socialize_media_UMImage_ == IntPtr.Zero)
				id_withMedia_Lcom_umeng_socialize_media_UMImage_ = JNIEnv.GetMethodID (class_ref, "withMedia", "(Lcom/umeng/socialize/media/UMImage;)Lcom/umeng/socialize/ShareAction;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Umeng.Socialize.ShareAction __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withMedia_Lcom_umeng_socialize_media_UMImage_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withMedia", "(Lcom/umeng/socialize/media/UMImage;)Lcom/umeng/socialize/ShareAction;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withMedia_Lcom_umeng_socialize_media_UMMin_;
#pragma warning disable 0169
		static Delegate GetWithMedia_Lcom_umeng_socialize_media_UMMin_Handler ()
		{
			if (cb_withMedia_Lcom_umeng_socialize_media_UMMin_ == null)
				cb_withMedia_Lcom_umeng_socialize_media_UMMin_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithMedia_Lcom_umeng_socialize_media_UMMin_);
			return cb_withMedia_Lcom_umeng_socialize_media_UMMin_;
		}

		static IntPtr n_WithMedia_Lcom_umeng_socialize_media_UMMin_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.ShareAction __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Media.UMMin p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMMin> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithMedia (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withMedia_Lcom_umeng_socialize_media_UMMin_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareAction']/method[@name='withMedia' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.media.UMMin']]"
		[Register ("withMedia", "(Lcom/umeng/socialize/media/UMMin;)Lcom/umeng/socialize/ShareAction;", "GetWithMedia_Lcom_umeng_socialize_media_UMMin_Handler")]
		public virtual unsafe global::Com.Umeng.Socialize.ShareAction WithMedia (global::Com.Umeng.Socialize.Media.UMMin p0)
		{
			if (id_withMedia_Lcom_umeng_socialize_media_UMMin_ == IntPtr.Zero)
				id_withMedia_Lcom_umeng_socialize_media_UMMin_ = JNIEnv.GetMethodID (class_ref, "withMedia", "(Lcom/umeng/socialize/media/UMMin;)Lcom/umeng/socialize/ShareAction;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Umeng.Socialize.ShareAction __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withMedia_Lcom_umeng_socialize_media_UMMin_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withMedia", "(Lcom/umeng/socialize/media/UMMin;)Lcom/umeng/socialize/ShareAction;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withMedia_Lcom_umeng_socialize_media_UMVideo_;
#pragma warning disable 0169
		static Delegate GetWithMedia_Lcom_umeng_socialize_media_UMVideo_Handler ()
		{
			if (cb_withMedia_Lcom_umeng_socialize_media_UMVideo_ == null)
				cb_withMedia_Lcom_umeng_socialize_media_UMVideo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithMedia_Lcom_umeng_socialize_media_UMVideo_);
			return cb_withMedia_Lcom_umeng_socialize_media_UMVideo_;
		}

		static IntPtr n_WithMedia_Lcom_umeng_socialize_media_UMVideo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.ShareAction __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Media.UMVideo p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMVideo> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithMedia (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withMedia_Lcom_umeng_socialize_media_UMVideo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareAction']/method[@name='withMedia' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.media.UMVideo']]"
		[Register ("withMedia", "(Lcom/umeng/socialize/media/UMVideo;)Lcom/umeng/socialize/ShareAction;", "GetWithMedia_Lcom_umeng_socialize_media_UMVideo_Handler")]
		public virtual unsafe global::Com.Umeng.Socialize.ShareAction WithMedia (global::Com.Umeng.Socialize.Media.UMVideo p0)
		{
			if (id_withMedia_Lcom_umeng_socialize_media_UMVideo_ == IntPtr.Zero)
				id_withMedia_Lcom_umeng_socialize_media_UMVideo_ = JNIEnv.GetMethodID (class_ref, "withMedia", "(Lcom/umeng/socialize/media/UMVideo;)Lcom/umeng/socialize/ShareAction;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Umeng.Socialize.ShareAction __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withMedia_Lcom_umeng_socialize_media_UMVideo_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withMedia", "(Lcom/umeng/socialize/media/UMVideo;)Lcom/umeng/socialize/ShareAction;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withMedia_Lcom_umeng_socialize_media_UMWeb_;
#pragma warning disable 0169
		static Delegate GetWithMedia_Lcom_umeng_socialize_media_UMWeb_Handler ()
		{
			if (cb_withMedia_Lcom_umeng_socialize_media_UMWeb_ == null)
				cb_withMedia_Lcom_umeng_socialize_media_UMWeb_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithMedia_Lcom_umeng_socialize_media_UMWeb_);
			return cb_withMedia_Lcom_umeng_socialize_media_UMWeb_;
		}

		static IntPtr n_WithMedia_Lcom_umeng_socialize_media_UMWeb_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.ShareAction __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Media.UMWeb p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMWeb> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithMedia (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withMedia_Lcom_umeng_socialize_media_UMWeb_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareAction']/method[@name='withMedia' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.media.UMWeb']]"
		[Register ("withMedia", "(Lcom/umeng/socialize/media/UMWeb;)Lcom/umeng/socialize/ShareAction;", "GetWithMedia_Lcom_umeng_socialize_media_UMWeb_Handler")]
		public virtual unsafe global::Com.Umeng.Socialize.ShareAction WithMedia (global::Com.Umeng.Socialize.Media.UMWeb p0)
		{
			if (id_withMedia_Lcom_umeng_socialize_media_UMWeb_ == IntPtr.Zero)
				id_withMedia_Lcom_umeng_socialize_media_UMWeb_ = JNIEnv.GetMethodID (class_ref, "withMedia", "(Lcom/umeng/socialize/media/UMWeb;)Lcom/umeng/socialize/ShareAction;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Umeng.Socialize.ShareAction __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withMedia_Lcom_umeng_socialize_media_UMWeb_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withMedia", "(Lcom/umeng/socialize/media/UMWeb;)Lcom/umeng/socialize/ShareAction;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withMedia_Lcom_umeng_socialize_media_UMusic_;
#pragma warning disable 0169
		static Delegate GetWithMedia_Lcom_umeng_socialize_media_UMusic_Handler ()
		{
			if (cb_withMedia_Lcom_umeng_socialize_media_UMusic_ == null)
				cb_withMedia_Lcom_umeng_socialize_media_UMusic_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithMedia_Lcom_umeng_socialize_media_UMusic_);
			return cb_withMedia_Lcom_umeng_socialize_media_UMusic_;
		}

		static IntPtr n_WithMedia_Lcom_umeng_socialize_media_UMusic_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.ShareAction __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Media.UMusic p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Media.UMusic> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithMedia (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withMedia_Lcom_umeng_socialize_media_UMusic_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareAction']/method[@name='withMedia' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.media.UMusic']]"
		[Register ("withMedia", "(Lcom/umeng/socialize/media/UMusic;)Lcom/umeng/socialize/ShareAction;", "GetWithMedia_Lcom_umeng_socialize_media_UMusic_Handler")]
		public virtual unsafe global::Com.Umeng.Socialize.ShareAction WithMedia (global::Com.Umeng.Socialize.Media.UMusic p0)
		{
			if (id_withMedia_Lcom_umeng_socialize_media_UMusic_ == IntPtr.Zero)
				id_withMedia_Lcom_umeng_socialize_media_UMusic_ = JNIEnv.GetMethodID (class_ref, "withMedia", "(Lcom/umeng/socialize/media/UMusic;)Lcom/umeng/socialize/ShareAction;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Umeng.Socialize.ShareAction __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withMedia_Lcom_umeng_socialize_media_UMusic_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withMedia", "(Lcom/umeng/socialize/media/UMusic;)Lcom/umeng/socialize/ShareAction;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withShareBoardDirection_Landroid_view_View_I;
#pragma warning disable 0169
		static Delegate GetWithShareBoardDirection_Landroid_view_View_IHandler ()
		{
			if (cb_withShareBoardDirection_Landroid_view_View_I == null)
				cb_withShareBoardDirection_Landroid_view_View_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_WithShareBoardDirection_Landroid_view_View_I);
			return cb_withShareBoardDirection_Landroid_view_View_I;
		}

		static IntPtr n_WithShareBoardDirection_Landroid_view_View_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Umeng.Socialize.ShareAction __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithShareBoardDirection (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withShareBoardDirection_Landroid_view_View_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareAction']/method[@name='withShareBoardDirection' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("withShareBoardDirection", "(Landroid/view/View;I)Lcom/umeng/socialize/ShareAction;", "GetWithShareBoardDirection_Landroid_view_View_IHandler")]
		public virtual unsafe global::Com.Umeng.Socialize.ShareAction WithShareBoardDirection (global::Android.Views.View p0, int p1)
		{
			if (id_withShareBoardDirection_Landroid_view_View_I == IntPtr.Zero)
				id_withShareBoardDirection_Landroid_view_View_I = JNIEnv.GetMethodID (class_ref, "withShareBoardDirection", "(Landroid/view/View;I)Lcom/umeng/socialize/ShareAction;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Umeng.Socialize.ShareAction __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withShareBoardDirection_Landroid_view_View_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withShareBoardDirection", "(Landroid/view/View;I)Lcom/umeng/socialize/ShareAction;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_withSubject_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithSubject_Ljava_lang_String_Handler ()
		{
			if (cb_withSubject_Ljava_lang_String_ == null)
				cb_withSubject_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithSubject_Ljava_lang_String_);
			return cb_withSubject_Ljava_lang_String_;
		}

		static IntPtr n_WithSubject_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.ShareAction __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithSubject (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withSubject_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareAction']/method[@name='withSubject' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withSubject", "(Ljava/lang/String;)Lcom/umeng/socialize/ShareAction;", "GetWithSubject_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Umeng.Socialize.ShareAction WithSubject (string p0)
		{
			if (id_withSubject_Ljava_lang_String_ == IntPtr.Zero)
				id_withSubject_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withSubject", "(Ljava/lang/String;)Lcom/umeng/socialize/ShareAction;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Umeng.Socialize.ShareAction __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withSubject_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withSubject", "(Ljava/lang/String;)Lcom/umeng/socialize/ShareAction;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWithText_Ljava_lang_String_Handler ()
		{
			if (cb_withText_Ljava_lang_String_ == null)
				cb_withText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithText_Ljava_lang_String_);
			return cb_withText_Ljava_lang_String_;
		}

		static IntPtr n_WithText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.ShareAction __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithText (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withText_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize']/class[@name='ShareAction']/method[@name='withText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("withText", "(Ljava/lang/String;)Lcom/umeng/socialize/ShareAction;", "GetWithText_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Umeng.Socialize.ShareAction WithText (string p0)
		{
			if (id_withText_Ljava_lang_String_ == IntPtr.Zero)
				id_withText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "withText", "(Ljava/lang/String;)Lcom/umeng/socialize/ShareAction;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Umeng.Socialize.ShareAction __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withText_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareAction> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withText", "(Ljava/lang/String;)Lcom/umeng/socialize/ShareAction;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
