using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Shareboard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='ShareBoard']"
	[global::Android.Runtime.Register ("com/umeng/socialize/shareboard/ShareBoard", DoNotGenerateAcw=true)]
	public partial class ShareBoard : global::Android.Widget.PopupWindow {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/shareboard/ShareBoard", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ShareBoard); }
		}

		protected ShareBoard (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='ShareBoard']/constructor[@name='ShareBoard' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.List&lt;com.umeng.socialize.shareboard.SnsPlatform&gt;']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/util/List;)V", "")]
		public unsafe ShareBoard (global::Android.Content.Context p0, global::System.Collections.Generic.IList<global::Com.Umeng.Socialize.Shareboard.SnsPlatform> p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Umeng.Socialize.Shareboard.SnsPlatform>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (ShareBoard)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_util_List_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_util_List_Lcom_umeng_socialize_shareboard_ShareBoardConfig_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='ShareBoard']/constructor[@name='ShareBoard' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.List&lt;com.umeng.socialize.shareboard.SnsPlatform&gt;'] and parameter[3][@type='com.umeng.socialize.shareboard.ShareBoardConfig']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/util/List;Lcom/umeng/socialize/shareboard/ShareBoardConfig;)V", "")]
		public unsafe ShareBoard (global::Android.Content.Context p0, global::System.Collections.Generic.IList<global::Com.Umeng.Socialize.Shareboard.SnsPlatform> p1, global::Com.Umeng.Socialize.Shareboard.ShareBoardConfig p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Umeng.Socialize.Shareboard.SnsPlatform>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (ShareBoard)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/util/List;Lcom/umeng/socialize/shareboard/ShareBoardConfig;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/util/List;Lcom/umeng/socialize/shareboard/ShareBoardConfig;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_util_List_Lcom_umeng_socialize_shareboard_ShareBoardConfig_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_util_List_Lcom_umeng_socialize_shareboard_ShareBoardConfig_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/util/List;Lcom/umeng/socialize/shareboard/ShareBoardConfig;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_util_List_Lcom_umeng_socialize_shareboard_ShareBoardConfig_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_util_List_Lcom_umeng_socialize_shareboard_ShareBoardConfig_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setShareBoardlistener_Lcom_umeng_socialize_utils_ShareBoardlistener_;
#pragma warning disable 0169
		static Delegate GetSetShareBoardlistener_Lcom_umeng_socialize_utils_ShareBoardlistener_Handler ()
		{
			if (cb_setShareBoardlistener_Lcom_umeng_socialize_utils_ShareBoardlistener_ == null)
				cb_setShareBoardlistener_Lcom_umeng_socialize_utils_ShareBoardlistener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetShareBoardlistener_Lcom_umeng_socialize_utils_ShareBoardlistener_);
			return cb_setShareBoardlistener_Lcom_umeng_socialize_utils_ShareBoardlistener_;
		}

		static void n_SetShareBoardlistener_Lcom_umeng_socialize_utils_ShareBoardlistener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Shareboard.ShareBoard __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.ShareBoard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Utils.IShareBoardlistener p0 = (global::Com.Umeng.Socialize.Utils.IShareBoardlistener)global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Utils.IShareBoardlistener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetShareBoardlistener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setShareBoardlistener_Lcom_umeng_socialize_utils_ShareBoardlistener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.shareboard']/class[@name='ShareBoard']/method[@name='setShareBoardlistener' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.utils.ShareBoardlistener']]"
		[Register ("setShareBoardlistener", "(Lcom/umeng/socialize/utils/ShareBoardlistener;)V", "GetSetShareBoardlistener_Lcom_umeng_socialize_utils_ShareBoardlistener_Handler")]
		public virtual unsafe void SetShareBoardlistener (global::Com.Umeng.Socialize.Utils.IShareBoardlistener p0)
		{
			if (id_setShareBoardlistener_Lcom_umeng_socialize_utils_ShareBoardlistener_ == IntPtr.Zero)
				id_setShareBoardlistener_Lcom_umeng_socialize_utils_ShareBoardlistener_ = JNIEnv.GetMethodID (class_ref, "setShareBoardlistener", "(Lcom/umeng/socialize/utils/ShareBoardlistener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShareBoardlistener_Lcom_umeng_socialize_utils_ShareBoardlistener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShareBoardlistener", "(Lcom/umeng/socialize/utils/ShareBoardlistener;)V"), __args);
			} finally {
			}
		}

	}
}
