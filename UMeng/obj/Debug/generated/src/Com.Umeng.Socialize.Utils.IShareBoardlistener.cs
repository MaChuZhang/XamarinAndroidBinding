using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Utils {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.umeng.socialize.utils']/interface[@name='ShareBoardlistener']"
	[Register ("com/umeng/socialize/utils/ShareBoardlistener", "", "Com.Umeng.Socialize.Utils.IShareBoardlistenerInvoker")]
	public partial interface IShareBoardlistener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/interface[@name='ShareBoardlistener']/method[@name='onclick' and count(parameter)=2 and parameter[1][@type='com.umeng.socialize.shareboard.SnsPlatform'] and parameter[2][@type='com.umeng.socialize.bean.SHARE_MEDIA']]"
		[Register ("onclick", "(Lcom/umeng/socialize/shareboard/SnsPlatform;Lcom/umeng/socialize/bean/SHARE_MEDIA;)V", "GetOnclick_Lcom_umeng_socialize_shareboard_SnsPlatform_Lcom_umeng_socialize_bean_SHARE_MEDIA_Handler:Com.Umeng.Socialize.Utils.IShareBoardlistenerInvoker, UMeng")]
		void Onclick (global::Com.Umeng.Socialize.Shareboard.SnsPlatform p0, global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p1);

	}

	[global::Android.Runtime.Register ("com/umeng/socialize/utils/ShareBoardlistener", DoNotGenerateAcw=true)]
	internal class IShareBoardlistenerInvoker : global::Java.Lang.Object, IShareBoardlistener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/umeng/socialize/utils/ShareBoardlistener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IShareBoardlistenerInvoker); }
		}

		IntPtr class_ref;

		public static IShareBoardlistener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IShareBoardlistener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.umeng.socialize.utils.ShareBoardlistener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IShareBoardlistenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onclick_Lcom_umeng_socialize_shareboard_SnsPlatform_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
#pragma warning disable 0169
		static Delegate GetOnclick_Lcom_umeng_socialize_shareboard_SnsPlatform_Lcom_umeng_socialize_bean_SHARE_MEDIA_Handler ()
		{
			if (cb_onclick_Lcom_umeng_socialize_shareboard_SnsPlatform_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == null)
				cb_onclick_Lcom_umeng_socialize_shareboard_SnsPlatform_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Onclick_Lcom_umeng_socialize_shareboard_SnsPlatform_Lcom_umeng_socialize_bean_SHARE_MEDIA_);
			return cb_onclick_Lcom_umeng_socialize_shareboard_SnsPlatform_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
		}

		static void n_Onclick_Lcom_umeng_socialize_shareboard_SnsPlatform_Lcom_umeng_socialize_bean_SHARE_MEDIA_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Socialize.Utils.IShareBoardlistener __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Utils.IShareBoardlistener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Shareboard.SnsPlatform p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Shareboard.SnsPlatform> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p1 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.SHARE_MEDIA> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Onclick (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onclick_Lcom_umeng_socialize_shareboard_SnsPlatform_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
		public unsafe void Onclick (global::Com.Umeng.Socialize.Shareboard.SnsPlatform p0, global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p1)
		{
			if (id_onclick_Lcom_umeng_socialize_shareboard_SnsPlatform_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == IntPtr.Zero)
				id_onclick_Lcom_umeng_socialize_shareboard_SnsPlatform_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNIEnv.GetMethodID (class_ref, "onclick", "(Lcom/umeng/socialize/shareboard/SnsPlatform;Lcom/umeng/socialize/bean/SHARE_MEDIA;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onclick_Lcom_umeng_socialize_shareboard_SnsPlatform_Lcom_umeng_socialize_bean_SHARE_MEDIA_, __args);
		}

	}

}
